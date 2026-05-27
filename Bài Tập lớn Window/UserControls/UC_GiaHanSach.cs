using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_Tập_lớn_Window.UserControls
{
    public partial class UC_GiaHanSach : UserControl
    {
        // Nhớ đổi chuỗi kết nối cho đúng với máy của bạn
        private string chuoiKetNoi = @"Data Source=.;Initial Catalog=QuanLyThuVien;Integrated Security=True";

        public UC_GiaHanSach()
        {
            InitializeComponent();

            // Gán các sự kiện
            this.Load += UC_GiaHanSach_Load;
            
        }

        private void UC_GiaHanSach_Load(object sender, EventArgs e)
        {
            LoadDataDanhSachPhieuMuon();
            ClearForm();
        }

        // Chỉ hiển thị các phiếu CHƯA TRẢ lên dgv
        private void LoadDataDanhSachPhieuMuon()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
                {
                    // Lưu ý: đặt alias TenDG để khớp với DataPropertyName của cột colTenDG trong Designer
                    string query = @"SELECT pm.MaPhieuMuon, pm.MaDG, dg.TenDocGia AS TenDG, pm.NgayMuon, pm.NgayTra 
                                     FROM PhieuMuon pm 
                                     JOIN DocGia dg ON pm.MaDG = dg.MaDG 
                                     WHERE pm.TrangThaiTra = N'Chưa trả'";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Bạn nhớ gán DataPropertyName trên Form Designer nhé!
                    // colMaPhieuMuon -> MaPhieuMuon, colNgayTra -> NgayTra ...
                    dgvDanhSachPhieuMuon.AutoGenerateColumns = false;
                    dgvDanhSachPhieuMuon.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách phiếu mượn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     
        private void txtMaPhieuMuon_TextChanged(object sender, EventArgs e)
        {
            if (txtMaPhieuMuon.Text.Trim() == "")
            {
                ClearThongTinPhu();
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
                {
                    // Lấy thông tin phiếu mượn (chỉ lấy phiếu chưa trả)
                    string query = @"SELECT pm.MaDG, dg.TenDocGia, pm.NgayMuon, pm.NgayTra 
                                     FROM PhieuMuon pm 
                                     JOIN DocGia dg ON pm.MaDG = dg.MaDG 
                                     WHERE pm.MaPhieuMuon = @MaPM AND pm.TrangThaiTra = N'Chưa trả'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaPM", txtMaPhieuMuon.Text.Trim());

                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            txtMaDG.Text = dr["MaDG"].ToString();
                            txtTenDG.Text = dr["TenDocGia"].ToString();
                            dtpNgayMuon.Value = Convert.ToDateTime(dr["NgayMuon"]);
                            dtpNgayTra.Value = Convert.ToDateTime(dr["NgayTra"]);

                            // Gợi ý ngày gia hạn = ngày trả cũ + 7 ngày
                            dtpGiaHanTra.Value = dtpNgayTra.Value.AddDays(7);
                        }
                        else
                        {
                            ClearThongTinPhu();
                        }
                    }
                }
            }
            catch { ClearThongTinPhu(); }
        }

        private void dgvDanhSachPhieuMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Tự động kích hoạt txtMaPhieuMuon_TextChanged
                txtMaPhieuMuon.Text = dgvDanhSachPhieuMuon.Rows[e.RowIndex].Cells[colMaPhieuMuon.Name].Value.ToString();
            }
        }

        private void btnGiaHanSach_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDG.Text))
            {
                MessageBox.Show("Vui lòng chọn hoặc nhập một mã phiếu mượn hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra tính hợp lệ của ngày gia hạn
            if (dtpGiaHanTra.Value.Date <= dtpNgayTra.Value.Date)
            {
                MessageBox.Show("Ngày gia hạn phải lớn hơn ngày trả cũ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpGiaHanTra.Focus();
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
                {
                    // Cập nhật lại cột NgayTra trong cơ sở dữ liệu
                    string query = "UPDATE PhieuMuon SET NgayTra = @NgayMoi WHERE MaPhieuMuon = @MaPM";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@NgayMoi", dtpGiaHanTra.Value.Date);
                    cmd.Parameters.AddWithValue("@MaPM", txtMaPhieuMuon.Text.Trim());

                    conn.Open();
                    int rowAffected = cmd.ExecuteNonQuery();

                    if (rowAffected > 0)
                    {
                        MessageBox.Show("Gia hạn sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataDanhSachPhieuMuon(); // Cập nhật lại GridView
                        // Thông báo cho các control khác (ví dụ trang Trả sách) biết dữ liệu PhieuMuon đã thay đổi
                        Bài_Tập_lớn_Window.Common.EventBus.RaisePhieuMuonChanged();
                        ClearForm();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi gia hạn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Quang
        private void btnHuyGiaHan_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        // Xóa hoàn toàn form
        private void ClearForm()
        {
            txtMaPhieuMuon.Clear();
            ClearThongTinPhu();
        }

        // Xóa các thông tin phụ, giữ lại mã phiếu đang gõ
        private void ClearThongTinPhu()
        {
            txtMaDG.Clear();
            txtTenDG.Clear();
            dtpNgayMuon.Value = DateTime.Now;
            dtpNgayTra.Value = DateTime.Now;
            dtpGiaHanTra.Value = DateTime.Now;
        }

        private void dgvDanhSachPhieuMuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}