using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bài_Tập_lớn_Window.UserControls
{
    public partial class UC_ThongKe : UserControl
    {   
        private string connectionString = @"Data Source=.;Initial Catalog=QuanLyThuVien;Integrated Security=True";

        private string[] cotLocTheoLoai = { "TheLoai", "GioiTinh", "TenDocGia" };

        public UC_ThongKe()
        {
            InitializeComponent();
        }

        private void UC_ThongKe_Load(object sender, EventArgs e)
        {
            if (cboLoaiThongKe.Items.Count > 0)
            {
                cboLoaiThongKe.SelectedIndex = 0;
            }
            LoadTongQuan();
            LoadDataGrid("SELECT MaSach, TenSach, TacGia, TheLoai, NamXB, SoLuong, TrangThai FROM Sach");
        }

        private void LoadTongQuan()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            lblTongSach.Text = new SqlCommand("SELECT COUNT(*) FROM Sach", conn).ExecuteScalar().ToString();
            lblDangMuon.Text = new SqlCommand("SELECT COUNT(*) FROM PhieuMuon", conn).ExecuteScalar().ToString();
            lblDocGiaMuon.Text = new SqlCommand("SELECT COUNT(*) FROM DocGia", conn).ExecuteScalar().ToString();
            conn.Close();
        }

        private void LoadDataGrid(string query)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvThongKe.DataSource = dt;

            DiemCboLocTheLoai();
            txtTimKiem.Clear();
            CapNhatLblTong();
        }

        private void DiemCboLocTheLoai()
        {
            cboLocTheLoai.Items.Clear();
            cboLocTheLoai.Items.Add("-- Tất cả --");

            int idx = cboLoaiThongKe.SelectedIndex;
            string cotLoc = cotLocTheoLoai[idx];

            if (!string.IsNullOrEmpty(cotLoc))
                foreach (DataGridViewRow row in dgvThongKe.Rows)
                {
                    string val = row.Cells[cotLoc].Value?.ToString();
                    if (!string.IsNullOrEmpty(val) && !cboLocTheLoai.Items.Contains(val))
                        cboLocTheLoai.Items.Add(val);
                }

            cboLocTheLoai.SelectedIndex = 0;
        }

        private void LocDuLieu()
        {
            string keyword = txtTimKiem.Text.ToLower().Trim();
            string giaTriLoc = cboLocTheLoai.SelectedItem?.ToString();
            int idx = cboLoaiThongKe.SelectedIndex;
            string cotLoc = cotLocTheoLoai[idx];

            dgvThongKe.CurrentCell = null;

            foreach (DataGridViewRow row in dgvThongKe.Rows)
            {
                bool khopTuKhoa = true;
                bool khopLoc = true;

                if (!string.IsNullOrEmpty(keyword))
                {
                    khopTuKhoa = false;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && cell.Value.ToString().ToLower().Contains(keyword))
                        {
                            khopTuKhoa = true;
                            break;
                        }
                    }
                }
                if (giaTriLoc != "-- Tất cả --" && dgvThongKe.Columns.Contains(cotLoc))
                {
                    string giaTriDong = row.Cells[cotLoc].Value?.ToString();
                    khopLoc = (giaTriDong == giaTriLoc);
                }

                try
                {
                    row.Visible = khopTuKhoa && khopLoc;
                }
                catch
                {
                }
            }

            CapNhatLblTong();
        }

        private void CapNhatLblTong()
        {
            int dem = 0;

            foreach (DataGridViewRow row in dgvThongKe.Rows)
            {
                if (row.Visible)
                {
                    dem++;
                }
            }
            lblTong.Text = $"Tổng hiển thị: {dem} bản ghi";
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e) => LocDuLieu();

        private void cboLocTheLoai_SelectedIndexChanged(object sender, EventArgs e) => LocDuLieu();

        private void btnXemThongKe_Click(object sender, EventArgs e)
        {
            string query = "";

            switch (cboLoaiThongKe.SelectedIndex)
            {
                case 0:
                    query = "SELECT MaSach, TenSach, TacGia, TheLoai, NamXB, SoLuong, TrangThai FROM Sach";
                    break;
                case 1:
                    query = "SELECT MaDG, TenDocGia, SDT, Email, DiaChi, NamSinh, GioiTinh FROM DocGia";
                    break;
                case 2:
                    query = @"SELECT p.MaPhieuMuon, d.TenDocGia, s.TenSach, p.NgayMuon, p.NgayTra, ct.SoLuong
                      FROM PhieuMuon p
                      JOIN DocGia d ON p.MaDG = d.MaDG
                      JOIN ChiTietPhieuMuon ct ON p.MaPhieuMuon = ct.MaPhieuMuon
                      JOIN Sach s ON ct.MaSach = s.MaSach
                      ORDER BY p.NgayMuon DESC";
                    break;
            }

            if (!string.IsNullOrEmpty(query))
            {
                LoadDataGrid(query);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadTongQuan();
            btnXemThongKe_Click(sender, e);
        }

        private void btnXuatBaoCao_Click(object sender, EventArgs e)
        {
            if (dgvThongKe.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV file (*.csv)|*.csv";
            sfd.FileName = "BaoCaoThongKe_" + DateTime.Now.ToString("yyyyMMdd_HHmm");
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8);
                sw.WriteLine("BÁO CÁO THỐNG KÊ THƯ VIỆN");
                sw.WriteLine("Ngày xuất: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
                sw.WriteLine("Loại: " + cboLoaiThongKe.Text);
                sw.WriteLine("========================================");
                string dongTieuDe = "";
                foreach (DataGridViewColumn col in dgvThongKe.Columns)
                {
                    dongTieuDe += col.HeaderText + ",";
                }
                dongTieuDe = dongTieuDe.TrimEnd(',');
                sw.WriteLine(dongTieuDe);
                foreach (DataGridViewRow row in dgvThongKe.Rows)
                {
                    if (row.Visible == true)
                    {
                        string dongDuLieu = "";
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            string giaTri = "";
                            if (cell.Value != null)
                            {
                                giaTri = cell.Value.ToString();
                            }
                            dongDuLieu += "\"" + giaTri + "\",";
                        }
                        dongDuLieu = dongDuLieu.TrimEnd(',');
                        sw.WriteLine(dongDuLieu);
                    }
                }
                sw.Close();
                MessageBox.Show("Xuất thành công!\nFile: " + sfd.FileName, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}