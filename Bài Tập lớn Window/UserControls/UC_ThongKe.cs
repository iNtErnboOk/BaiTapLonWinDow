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
            LoadTongQuan();
            LoadDataGrid("SELECT MaSach, TenSach, TacGia, TheLoai, NamXB, SoLuong, TrangThai FROM Sach");
        }

        private void LoadTongQuan()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                lblTongSach.Text = new SqlCommand("SELECT COUNT(*) FROM Sach", conn).ExecuteScalar().ToString();
                lblDangMuon.Text = new SqlCommand("SELECT COUNT(*) FROM PhieuMuon", conn).ExecuteScalar().ToString();
                lblDocGiaMuon.Text = new SqlCommand("SELECT COUNT(*) FROM DocGia", conn).ExecuteScalar().ToString();
            }
        }

        private void LoadDataGrid(string query)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvThongKe.DataSource = dt;
            }

            DiemCboLocTheLoai();
            txtTimKiem.Clear();
            CapNhatLblTong();
        }

        private void DiemCboLocTheLoai()
        {
            cboLocTheLoai.Items.Clear();
            cboLocTheLoai.Items.Add("-- Tất cả --");

            int idx = cboLoaiThongKe.SelectedIndex;
            string cotLoc = (idx >= 0 && idx < cotLocTheoLoai.Length && dgvThongKe.Columns.Contains(cotLocTheoLoai[idx]))
                            ? cotLocTheoLoai[idx] : "";

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
            string cotLoc = (idx >= 0 && idx < cotLocTheoLoai.Length) ? cotLocTheoLoai[idx] : "";

            dgvThongKe.CurrentCell = null;

            foreach (DataGridViewRow row in dgvThongKe.Rows)
            {
                bool khopTuKhoa = string.IsNullOrEmpty(keyword) ||
                    row.Cells.Cast<DataGridViewCell>()
                       .Any(c => c.Value?.ToString().ToLower().Contains(keyword) == true);

                bool khopLoc = giaTriLoc == "-- Tất cả --" ||
                    !dgvThongKe.Columns.Contains(cotLoc) ||
                    row.Cells[cotLoc].Value?.ToString() == giaTriLoc;

                try { row.Visible = khopTuKhoa && khopLoc; }
                catch { }
            }

            CapNhatLblTong();
        }

        private void CapNhatLblTong()
        {
            int dem = dgvThongKe.Rows.Cast<DataGridViewRow>().Count(r => r.Visible && !r.IsNewRow);
            lblTong.Text = $"Tổng hiển thị: {dem} bản ghi";
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e) => LocDuLieu();

        private void cboLocTheLoai_SelectedIndexChanged(object sender, EventArgs e) => LocDuLieu();

        private void btnXemThongKe_Click(object sender, EventArgs e)
        {
            string[] queries = {
                "SELECT MaSach, TenSach, TacGia, TheLoai, NamXB, SoLuong, TrangThai FROM Sach",
                "SELECT MaDG, TenDocGia, SDT, Email, DiaChi, NamSinh, GioiTinh FROM DocGia",
                @"SELECT p.MaPhieuMuon, d.TenDocGia, s.TenSach, p.NgayMuon, p.NgayTra, ct.SoLuong
                  FROM PhieuMuon p
                  JOIN DocGia d ON p.MaDG = d.MaDG
                  JOIN ChiTietPhieuMuon ct ON p.MaPhieuMuon = ct.MaPhieuMuon
                  JOIN Sach s ON ct.MaSach = s.MaSach
                  ORDER BY p.NgayMuon DESC"
            };

            int idx = cboLoaiThongKe.SelectedIndex;
            if (idx >= 0 && idx < queries.Length)
                LoadDataGrid(queries[idx]);
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

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV file (*.csv)|*.csv";
                sfd.FileName = "BaoCaoThongKe_" + DateTime.Now.ToString("yyyyMMdd_HHmm");
                if (sfd.ShowDialog() != DialogResult.OK) return;

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("BÁO CÁO THỐNG KÊ THƯ VIỆN");
                sb.AppendLine("Ngày xuất: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
                sb.AppendLine("Loại: " + cboLoaiThongKe.Text);
                sb.AppendLine("========================================");
                sb.AppendLine(string.Join(",", dgvThongKe.Columns.Cast<DataGridViewColumn>().Select(c => c.HeaderText)));

                foreach (DataGridViewRow row in dgvThongKe.Rows)
                {
                    if (row.IsNewRow || !row.Visible) continue;
                    sb.AppendLine(string.Join(",", row.Cells.Cast<DataGridViewCell>()
                        .Select(c => $"\"{c.Value?.ToString() ?? ""}\"")));
                }

                File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                MessageBox.Show("Xuất thành công!\nFile: " + sfd.FileName, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}