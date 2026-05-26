using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bài_Tập_lớn_Window.UserControls
{
    public partial class UC_MuonSach : UserControl
    {
        string chuoiKetNoi = @"Data Source=.;Initial Catalog=QuanLyThuVien;Integrated Security=True";

        public UC_MuonSach()
        {
            InitializeComponent();
        }

        private void UC_MuonSach_Load(object sender, EventArgs e)
        {
            SinhMaPhieuMuon();
            LoadSach();
        }

        private void SinhMaPhieuMuon()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
                {
                    conn.Open();
                    string sql = "SELECT TOP 1 MaPhieuMuon FROM PhieuMuon ORDER BY MaPhieuMuon DESC";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    object result = cmd.ExecuteScalar();

                    string maMoi = "PM001";
                    if (result != null)
                    {
                        int so = int.Parse(result.ToString().Substring(2));
                        so++;
                        maMoi = "PM" + so.ToString("D3");
                    }
                    txtMaPhieuMuon.Text = maMoi;
                }
            }
            catch { txtMaPhieuMuon.Text = "PM001"; }
        }

        // Hiển thị danh sách sách
        private void LoadSach()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
                {
                    string sql = "SELECT MaSach, TenSach, SoLuong FROM Sach";
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvChonSach.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách sách: " + ex.Message);
            }
        }

        // Tự hiện tên độc giả
        private void txtMaDG_TextChanged(object sender, EventArgs e)
        {
            if (txtMaDG.Text.Trim() == "")
            {
                txtTenDocGia.Clear();
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
                {
                    conn.Open();
                    string sql = "SELECT TenDocGia FROM DocGia WHERE MaDG = @ma";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ma", txtMaDG.Text.Trim());

                    object result = cmd.ExecuteScalar();
                    txtTenDocGia.Text = result != null ? result.ToString() : "";
                }
            }
            catch { txtTenDocGia.Clear(); }
        }

        // Tự hiện tên sách
        private void txtMaSach_TextChanged(object sender, EventArgs e)
        {
            if (txtMaSach.Text.Trim() == "")
            {
                txtTenSach.Clear();
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
                {
                    conn.Open();
                    string sql = "SELECT TenSach FROM Sach WHERE MaSach = @ma";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ma", txtMaSach.Text.Trim());

                    object result = cmd.ExecuteScalar();
                    txtTenSach.Text = result != null ? result.ToString() : "";
                }
            }
            catch { txtTenSach.Clear(); }
        }

        // Khi click vào sách trong dgvChonSach, tự động điền mã và tên sách vào ô bên dưới
        private void dgvChonSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvChonSach.Rows[e.RowIndex];
                txtMaSach.Text = row.Cells[0].Value.ToString();
                txtTenSach.Text = row.Cells[1].Value.ToString();
                nudSoLuong.Value = 1;
            }
        }

        // Thêm sách vào danh sách mượn
        private void btnThemSach_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text.Trim() == "")
            {
                MessageBox.Show("Chưa chọn sách!");
                return;
            }

            if (nudSoLuong.Value <= 0)
            {
                MessageBox.Show("Số lượng không hợp lệ!");
                return;
            }

            foreach (DataGridViewRow row in dgvDanhSachSachMuon.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == txtMaSach.Text)
                {
                    MessageBox.Show("Sách đã tồn tại trong danh sách chờ!");
                    return;
                }
            }

            dgvDanhSachSachMuon.Rows.Add(txtMaSach.Text, txtTenSach.Text, nudSoLuong.Value);

            txtMaSach.Clear();
            txtTenSach.Clear();
            nudSoLuong.Value = 0;
        }

        // Xóa sách khỏi danh sách mượn
        private void btnXoaSachMuon_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachSachMuon.CurrentRow != null)
            {
                dgvDanhSachSachMuon.Rows.RemoveAt(dgvDanhSachSachMuon.CurrentRow.Index);
            }
        }

        private void btnHuyPhieu_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        // Lập phiếu mượn
        private void btnLapPhieuMuon_Click(object sender, EventArgs e)
        {
            if (txtMaDG.Text.Trim() == "")
            {
                MessageBox.Show("Nhập mã độc giả!");
                return;
            }

            if (dgvDanhSachSachMuon.Rows.Count == 0 || (dgvDanhSachSachMuon.Rows.Count == 1 && dgvDanhSachSachMuon.Rows[0].IsNewRow))
            {
                MessageBox.Show("Chưa có sách mượn!");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
                {
                    conn.Open();

                    // 1. Thêm vào bảng Phiếu Mượn (Đã sửa lỗi chỉ định rõ cột)
                    string sqlPM = @"INSERT INTO PhieuMuon (MaPhieuMuon, MaDG, NgayMuon, NgayTra) 
                                     VALUES(@mapm, @madg, @ngaymuon, @ngaytra)";
                    SqlCommand cmdPM = new SqlCommand(sqlPM, conn);
                    cmdPM.Parameters.AddWithValue("@mapm", txtMaPhieuMuon.Text);
                    cmdPM.Parameters.AddWithValue("@madg", txtMaDG.Text);
                    cmdPM.Parameters.AddWithValue("@ngaymuon", dtpNgayMuon.Value.Date);
                    cmdPM.Parameters.AddWithValue("@ngaytra", dtpNgayTra.Value.Date);

                    cmdPM.ExecuteNonQuery();

                    // 2. Thêm Chi Tiết Phiếu Mượn và Cập nhật Số Lượng Sách
                    foreach (DataGridViewRow row in dgvDanhSachSachMuon.Rows)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            // Thêm chi tiết
                            string sqlCT = @"INSERT INTO ChiTietPhieuMuon (MaPhieuMuon, MaSach, SoLuong) 
                                             VALUES(@mapm, @masach, @soluong)";
                            SqlCommand cmdCT = new SqlCommand(sqlCT, conn);
                            cmdCT.Parameters.AddWithValue("@mapm", txtMaPhieuMuon.Text);
                            cmdCT.Parameters.AddWithValue("@masach", row.Cells[0].Value.ToString());
                            cmdCT.Parameters.AddWithValue("@soluong", row.Cells[2].Value);
                            cmdCT.ExecuteNonQuery();

                            // Trừ số lượng sách trong kho
                            string sqlUpdate = @"UPDATE Sach SET SoLuong = SoLuong - @sl WHERE MaSach = @masach";
                            SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, conn);
                            cmdUpdate.Parameters.AddWithValue("@sl", row.Cells[2].Value);
                            cmdUpdate.Parameters.AddWithValue("@masach", row.Cells[0].Value.ToString());
                            cmdUpdate.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("Lập phiếu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dgvDanhSachSachMuon.Rows.Clear();
                txtMaDG.Clear();
                txtTenDocGia.Clear();
                SinhMaPhieuMuon();
                LoadSach();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lập phiếu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            txtMaDG.Clear();
            txtTenDocGia.Clear();
            txtMaSach.Clear();
            txtTenSach.Clear();
            nudSoLuong.Value = 0;
            dtpNgayMuon.Value = DateTime.Now;
            dtpNgayTra.Value = DateTime.Now.AddDays(7);
            dgvDanhSachSachMuon.Rows.Clear();
            SinhMaPhieuMuon();
            txtMaDG.Focus();
        }
    }
}