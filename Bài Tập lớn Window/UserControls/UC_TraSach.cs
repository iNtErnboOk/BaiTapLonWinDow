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
    public partial class UC_TraSach : UserControl
    {
        private string chuoiKetNoi = @"Data Source=.;Initial Catalog=QuanLyThuVien;Integrated Security=True";

        public UC_TraSach()
        {
            InitializeComponent();
        }

        private void UC_TraSach_Load(object sender, EventArgs e)
        {
            LoadDataDanhSachChuaTra();
            LoadDataDanhSachDaTra();
            ClearForm();
        }

        private void LoadDataDanhSachChuaTra()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
                {
                    string query = @"SELECT pm.MaPhieuMuon, pm.MaDG, dg.TenDocGia, pm.NgayMuon, pm.NgayTra, pm.TrangThaiTra 
                                     FROM PhieuMuon pm 
                                     JOIN DocGia dg ON pm.MaDG = dg.MaDG 
                                     WHERE pm.TrangThaiTra = N'Chưa trả'";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvDanhSachPhieuMuon.AutoGenerateColumns = false; // Bắt buộc giữ lại
                    dgvDanhSachPhieuMuon.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách phiếu mượn: " + ex.Message);
            }
        }

        private void LoadDataDanhSachDaTra()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
                {
                    string query = @"SELECT pm.MaPhieuMuon, pm.MaDG, dg.TenDocGia, pm.NgayTraThucTe, pm.TrangThaiTra, pm.TienPhat 
                                     FROM PhieuMuon pm 
                                     JOIN DocGia dg ON pm.MaDG = dg.MaDG 
                                     WHERE pm.TrangThaiTra = N'Đã trả'";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvDachSachTraSach.AutoGenerateColumns = false; // Bắt buộc giữ lại
                    dgvDachSachTraSach.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách đã trả: " + ex.Message);
            }
        }

        private void dgvDanhSachPhieuMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDanhSachPhieuMuon.Rows[e.RowIndex];

                txtMaPhieuMuon.Text = row.Cells[colMaPhieuMuon.Name].Value.ToString();
                txtMaDG.Text = row.Cells[colMaDocGia.Name].Value.ToString();
                txtTenDG.Text = row.Cells[colTenDG.Name].Value.ToString();
                dtpNgayMuon.Value = Convert.ToDateTime(row.Cells[colNgayMuon.Name].Value);
                dtpNgayTra.Value = Convert.ToDateTime(row.Cells[colNgayTra.Name].Value);
                dtpNgayTraThucTe.Value = DateTime.Now;

                TinhSoLuongSach(txtMaPhieuMuon.Text);
                TinhTienPhatVaTrangThai();
            }
        }

        private void TinhSoLuongSach(string maPhieu)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
                {
                    string query = "SELECT ISNULL(SUM(SoLuong), 0) FROM ChiTietPhieuMuon WHERE MaPhieuMuon = @MaPM";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaPM", maPhieu);
                    conn.Open();
                    nudSoLuong.Value = Convert.ToDecimal(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đếm số lượng sách: " + ex.Message);
            }
        }

        private void dtpNgayTraThucTe_ValueChanged(object sender, EventArgs e)
        {
            TinhTienPhatVaTrangThai();
        }

        private void TinhTienPhatVaTrangThai()
        {
            if (string.IsNullOrEmpty(txtMaPhieuMuon.Text)) return;

            DateTime ngayTraQuyDinh = dtpNgayTra.Value.Date;
            DateTime ngayTraThucTe = dtpNgayTraThucTe.Value.Date;

            TimeSpan timeSpan = ngayTraThucTe - ngayTraQuyDinh;
            int soNgayQuaHan = timeSpan.Days;

            if (soNgayQuaHan > 0)
            {
                cbTrangThai.Text = "Quá hạn";
                txtTienPhat.Text = (soNgayQuaHan * 5000).ToString();
            }
            else
            {
                cbTrangThai.Text = "Đúng hạn";
                txtTienPhat.Text = "0";
            }
        }

        private void btnHuyPhieu_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtMaPhieuMuon.Clear();
            txtMaDG.Clear();
            txtTenDG.Clear();
            dtpNgayMuon.Value = DateTime.Now;
            dtpNgayTra.Value = DateTime.Now;
            dtpNgayTraThucTe.Value = DateTime.Now;
            nudSoLuong.Value = 0;
            cbTrangThai.SelectedIndex = -1;
            txtTienPhat.Clear();
        }

        private void btnLuuPhieuTra_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPhieuMuon.Text))
            {
                MessageBox.Show("Vui lòng chọn một phiếu mượn để trả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
                {
                    string query = @"UPDATE PhieuMuon 
                                     SET TrangThaiTra = N'Đã trả', 
                                         NgayTraThucTe = @NgayTraThucTe, 
                                         TienPhat = @TienPhat 
                                     WHERE MaPhieuMuon = @MaPM";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@NgayTraThucTe", dtpNgayTraThucTe.Value.Date);
                    cmd.Parameters.AddWithValue("@TienPhat", int.Parse(txtTienPhat.Text));
                    cmd.Parameters.AddWithValue("@MaPM", txtMaPhieuMuon.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Lưu phiếu trả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadDataDanhSachChuaTra();
                    LoadDataDanhSachDaTra();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu phiếu trả: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaPhieuMuon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPhieuMuon.Text))
            {
                MessageBox.Show("Vui lòng chọn một phiếu mượn để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu mượn " + txtMaPhieuMuon.Text + " không?\nLưu ý: Mọi chi tiết mượn sách cũng sẽ bị xóa!", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
                    {
                        string query = "DELETE FROM PhieuMuon WHERE MaPhieuMuon = @MaPM";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@MaPM", txtMaPhieuMuon.Text);

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Xóa phiếu mượn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadDataDanhSachChuaTra();
                        ClearForm();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}