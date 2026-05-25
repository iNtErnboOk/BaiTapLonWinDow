using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Bài_Tập_lớn_Window.UserControls
{
    public partial class UC_MuonSach : UserControl
    {
        // Use the database name that contains the DocGia table. Updated to match provided SQL script.
        string chuoiKetNoi = @"Data Source=.;Initial Catalog=quanlydocgia;Integrated Security=True";
        SqlConnection conn;
        public UC_MuonSach()
        {
            InitializeComponent();
        }
        private void UC_MuonSach_Load(object sender, EventArgs e)
        {
            SinhMaPhieuMuon();
            LoadSach();

            // Ensure the TextChanged event is attached in case the designer did not wire it.
            txtMaDG.TextChanged -= txtMaDG_TextChanged;
            txtMaDG.TextChanged += txtMaDG_TextChanged;

        }

        private void SinhMaPhieuMuon()
        {
            conn = new SqlConnection(chuoiKetNoi);
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

            conn.Close();
        }


        // Hiển thị danh sách sách
        private void LoadSach()
        {
            conn = new SqlConnection(chuoiKetNoi);

            string sql = "SELECT MaSach, TenSach, SoLuong FROM Sach";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvChonSach.DataSource = dt;
        }

        // Tự hiện tên độc giả
        private void txtMaDG_TextChanged(object sender, EventArgs e)
        {
            if (txtMaDG.Text.Trim() == "")
            {
                txtTenDocGia.Clear();
                return;
            }

            string sql = "SELECT TenDocGia FROM DocGia WHERE MaDG = @ma";

            try
            {
                // Use a local connection and command with using to ensure proper disposal
                using (var localConn = new SqlConnection(chuoiKetNoi))
                using (var cmd = new SqlCommand(sql, localConn))
                {
                    cmd.Parameters.AddWithValue("@ma", txtMaDG.Text.Trim());

                    localConn.Open();

                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                        txtTenDocGia.Text = result.ToString();
                    else
                        txtTenDocGia.Clear();
                }
            }
            catch (Exception ex)
            {
                // Log exception for debugging and clear the name field.
                Debug.WriteLine("Error in txtMaDG_TextChanged: " + ex.Message);
                txtTenDocGia.Clear();
            }
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
                conn = new SqlConnection(chuoiKetNoi);

                conn.Open();

                string sql = "SELECT TenSach FROM Sach WHERE MaSach = @ma";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ma", txtMaSach.Text.Trim());

                object result = cmd.ExecuteScalar();

                if (result != null)
                    txtTenSach.Text = result.ToString();
                else
                    txtTenSach.Clear();

                conn.Close();
            }
            catch
            {
                txtTenSach.Clear();
            }
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
                if (row.Cells[0].Value != null &&
                    row.Cells[0].Value.ToString() == txtMaSach.Text)
                {
                    MessageBox.Show("Sách đã tồn tại!");
                    return;
                }
            }

            dgvDanhSachSachMuon.Rows.Add(
                txtMaSach.Text,
                txtTenSach.Text,
                nudSoLuong.Value
            );

            txtMaSach.Clear();
            txtTenSach.Clear();

            nudSoLuong.Value = 0;

        }

        //Xóa sách khỏi danh sách mượn
        private void btnXoaSachMuon_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachSachMuon.CurrentRow != null)
            {
                dgvDanhSachSachMuon.Rows.RemoveAt(dgvDanhSachSachMuon.CurrentRow.Index);
            }
        }

        private void btnHuyPhieu_Click(object sender, EventArgs e)
        {
            dgvDanhSachSachMuon.Rows.Clear();

            txtMaDG.Clear();
            txtTenDocGia.Clear();

            txtMaSach.Clear();
            txtTenSach.Clear();

            nudSoLuong.Value = 0;

            SinhMaPhieuMuon();
        }

        private void btnLapPhieuMuon_Click(object sender, EventArgs e)
        {
            if (txtMaDG.Text.Trim() == "")
            {
                MessageBox.Show("Nhập mã độc giả!");
                return;
            }

            if (dgvDanhSachSachMuon.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có sách mượn!");
                return;
            }

            try
            {
                conn = new SqlConnection(chuoiKetNoi);

                conn.Open();

                string sqlPM = @"INSERT INTO PhieuMuon
                VALUES(@mapm,@madg,@ngaymuon,@ngaytra)";

                SqlCommand cmdPM = new SqlCommand(sqlPM, conn);

                cmdPM.Parameters.AddWithValue("@mapm", txtMaPhieuMuon.Text);
                cmdPM.Parameters.AddWithValue("@madg", txtMaDG.Text);
                cmdPM.Parameters.AddWithValue("@ngaymuon", dtpNgayMuon.Value);
                cmdPM.Parameters.AddWithValue("@ngaytra", dtpNgayTra.Value);

                cmdPM.ExecuteNonQuery();

                foreach (DataGridViewRow row in dgvDanhSachSachMuon.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        string sqlCT = @"INSERT INTO ChiTietPhieuMuon
                        VALUES(@mapm,@masach,@soluong)";

                        SqlCommand cmdCT = new SqlCommand(sqlCT, conn);

                        cmdCT.Parameters.AddWithValue("@mapm", txtMaPhieuMuon.Text);
                        cmdCT.Parameters.AddWithValue("@masach", row.Cells[0].Value.ToString());
                        cmdCT.Parameters.AddWithValue("@soluong", row.Cells[2].Value);

                        cmdCT.ExecuteNonQuery();

                        string sqlUpdate = @"UPDATE Sach
                        SET SoLuong = SoLuong - @sl
                        WHERE MaSach = @masach";

                        SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, conn);

                        cmdUpdate.Parameters.AddWithValue("@sl", row.Cells[2].Value);
                        cmdUpdate.Parameters.AddWithValue("@masach", row.Cells[0].Value.ToString());

                        cmdUpdate.ExecuteNonQuery();
                    }
                }

                conn.Close();

                MessageBox.Show("Lập phiếu thành công!");

                dgvDanhSachSachMuon.Rows.Clear();

                txtMaDG.Clear();
                txtTenDocGia.Clear();

                SinhMaPhieuMuon();

                LoadSach();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
