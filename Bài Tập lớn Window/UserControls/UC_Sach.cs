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
    public partial class UC_Sach : UserControl
    {
        public UC_Sach()
        {
            InitializeComponent();

            // Ensure NumericUpDown for year has a sensible range to avoid ArgumentOutOfRange
            try
            {
                nudNamXB.Minimum = 1900;
                nudNamXB.Maximum = DateTime.Now.Year + 5; // allow some future years
                // ensure default value is within range
                if (nudNamXB.Value < nudNamXB.Minimum || nudNamXB.Value > nudNamXB.Maximum)
                {
                    nudNamXB.Value = Math.Min(nudNamXB.Maximum, Math.Max(nudNamXB.Minimum, (decimal)DateTime.Now.Year));
                }
            }
            catch
            {
                // In case control isn't fully initialized for some reason, ignore and rely on load-time setup
            }

            // Wire Load event so UC_Sach_Load is called when control is shown (ClearForm / LoadData)
            this.Load += new System.EventHandler(this.UC_Sach_Load);
        }

        // Đổi chuỗi này theo đúng tên Server và tên Database của bạn
        private string connectionString = @"Data Source=.;Initial Catalog=QuanLyThuVien;Integrated Security=True";
        // Đường dẫn ảnh hiện tại (được chọn bởi người dùng)
        private string duongDanAnh = string.Empty;

        // =========================================================
        // HÀM SINH MÃ SÁCH TỰ ĐỘNG
        // =========================================================
        private string GetNextMaSach()
        {
            string newMa = "S001"; // Mặc định nếu bảng chưa có dữ liệu
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // Cắt chữ 'S' ở đầu, lấy phần số chuyển thành INT để tìm Max chính xác nhất
                    string query = "SELECT MAX(CAST(SUBSTRING(MaSach, 2, LEN(MaSach)) AS INT)) FROM Sach WHERE MaSach LIKE 'S%'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value && result != null)
                    {
                        int maxNumber = Convert.ToInt32(result);
                        maxNumber++; // Tăng lên 1 đơn vị
                        // Format lại thành dạng S001, S015, S120... (D3 nghĩa là luôn có ít nhất 3 chữ số)
                        newMa = "S" + maxNumber.ToString("D3");
                    }
                }
                catch (Exception ex)
                {
                    // Nếu có lỗi (ví dụ chưa có bảng), vẫn âm thầm trả về S001
                    Console.WriteLine("Lỗi sinh mã: " + ex.Message);
                }
            }
            return newMa;
        }

        // Hàm dùng chung để tải dữ liệu lên Bảng
        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT MaSach, TenSach, TacGia, NamXB, TheLoai, SoLuong, TrangThai, HinhAnh FROM Sach";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvDanhSach.DataSource = dt;

                    // Chỉ hiển thị đúng 6 cột: MaSach, TenSach, TacGia, TheLoai, SoLuong, TrangThai
                    var visibleCols = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
                    {
                        "MaSach", "TenSach", "TacGia", "TheLoai", "SoLuong", "TrangThai"
                    };

                    foreach (DataGridViewColumn col in dgvDanhSach.Columns)
                    {
                        if (!visibleCols.Contains(col.Name))
                        {
                            col.Visible = false;
                        }
                        else
                        {
                            col.Visible = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Gọi hàm này trong sự kiện Load của UserControl
        private void UC_Sach_Load(object sender, EventArgs e)
        {
            LoadData();
            ClearForm();
        }

        // Hàm xóa trắng các ô nhập liệu
        private void ClearForm()
        {
            // TỰ ĐỘNG SINH MÃ VÀ KHÓA Ô MÃ SÁCH LẠI
            txtMaSach.Text = GetNextMaSach();
            txtMaSach.Enabled = false;

            txtTenSach.Clear();
            txtTacGia.Clear();
            nudNamXB.Value = DateTime.Now.Year; // Đặt mặc định là năm hiện tại
            nudSoLuong.Value = 0;
            cboTheLoai.SelectedIndex = -1; // Bỏ chọn ComboBox
            radConSach.Checked = true;

            // Xóa ảnh
            picAnhBia.Image = null;
            duongDanAnh = string.Empty;

            // Đặt trỏ chuột vào ô Tên sách để người dùng gõ luôn
            txtTenSach.Focus();
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Đọc ảnh từ file vào stream và clone vào Bitmap để không giữ khóa trên file
                using (var fs = new System.IO.FileStream(ofd.FileName, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                using (var img = Image.FromStream(fs))
                {
                    picAnhBia.Image = new Bitmap(img);
                }
                // Lưu đường dẫn ảnh để ghi vào CSDL khi cần
                duongDanAnh = ofd.FileName;
            }
        }

        private void btnXoaAnh_Click(object sender, EventArgs e)
        {
            picAnhBia.Image = null;
            duongDanAnh = string.Empty;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra rỗng
            if (string.IsNullOrWhiteSpace(txtMaSach.Text) || string.IsNullOrWhiteSpace(txtTenSach.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã sách và Tên sách!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Lấy trạng thái
            string trangThai = radConSach.Checked ? "Còn sách" : "Hết sách";
            string tenFileAnhLuuCSDL = "";

            // Xử lý copy ảnh mới vào thư mục Images của dự án
            if (!string.IsNullOrEmpty(duongDanAnh) && System.IO.File.Exists(duongDanAnh))
            {
                try
                {
                    string thuMucDich = System.IO.Path.Combine(Application.StartupPath, "Images");
                    if (!System.IO.Directory.Exists(thuMucDich))
                        System.IO.Directory.CreateDirectory(thuMucDich);

                    string phanMoRong = System.IO.Path.GetExtension(duongDanAnh);
                    tenFileAnhLuuCSDL = txtMaSach.Text.Trim() + phanMoRong;
                    string duongDanDich = System.IO.Path.Combine(thuMucDich, tenFileAnhLuuCSDL);

                    System.IO.File.Copy(duongDanAnh, duongDanDich, true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi lưu trữ tệp tin ảnh: " + ex.Message);
                }
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO Sach (MaSach, TenSach, TacGia, NamXB, TheLoai, SoLuong, TrangThai, HinhAnh) 
                                     VALUES (@MaSach, @TenSach, @TacGia, @NamXB, @TheLoai, @SoLuong, @TrangThai, @HinhAnh)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaSach", txtMaSach.Text.Trim());
                    cmd.Parameters.AddWithValue("@TenSach", txtTenSach.Text.Trim());
                    cmd.Parameters.AddWithValue("@TacGia", txtTacGia.Text.Trim());
                    cmd.Parameters.AddWithValue("@NamXB", (int)nudNamXB.Value);
                    cmd.Parameters.AddWithValue("@TheLoai", cboTheLoai.Text);
                    cmd.Parameters.AddWithValue("@SoLuong", (int)nudSoLuong.Value);
                    cmd.Parameters.AddWithValue("@TrangThai", trangThai);
                    cmd.Parameters.AddWithValue("@HinhAnh", string.IsNullOrEmpty(tenFileAnhLuuCSDL) ? (object)DBNull.Value : tenFileAnhLuuCSDL);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadData();
                    ClearForm(); // Tự động clear form và sinh mã mới tiếp theo
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDanhSach.Rows[e.RowIndex];

                txtMaSach.Text = GetCellString(row, "colMaSach", "MaSach");
                txtTenSach.Text = GetCellString(row, "colTenSach", "TenSach");
                txtTacGia.Text = GetCellString(row, "colTacGia", "TacGia");

                var namXbStr = GetCellString(row, "colNamXB", "NamXB");
                decimal namXbVal;
                if (decimal.TryParse(namXbStr, out namXbVal))
                {
                    decimal min = nudNamXB.Minimum;
                    decimal max = nudNamXB.Maximum;
                    decimal safeVal = Math.Min(max, Math.Max(min, namXbVal));
                    nudNamXB.Value = safeVal;
                }

                cboTheLoai.Text = GetCellString(row, "colTheLoai", "TheLoai");
                var soLuongStr = GetCellString(row, "colSoLuong", "SoLuong");
                decimal soLuongVal;
                if (decimal.TryParse(soLuongStr, out soLuongVal)) nudSoLuong.Value = soLuongVal;

                string trangThai = GetCellString(row, "colTrangThai", "TrangThai");
                if (trangThai == "Còn sách") radConSach.Checked = true;
                else radHetSach.Checked = true;

                // Xử lý hiển thị ảnh theo chuẩn đường dẫn tương đối
                string tenFileAnh = GetCellString(row, "colHinhAnh", "HinhAnh");

                if (!string.IsNullOrEmpty(tenFileAnh))
                {
                    string thuMucDuAn = System.IO.Path.Combine(Application.StartupPath, "Images");
                    duongDanAnh = System.IO.Path.Combine(thuMucDuAn, tenFileAnh);

                    if (System.IO.File.Exists(duongDanAnh))
                    {
                        using (System.IO.FileStream fs = new System.IO.FileStream(duongDanAnh, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                        using (var img = Image.FromStream(fs))
                        {
                            picAnhBia.Image = new Bitmap(img);
                        }
                    }
                    else
                    {
                        picAnhBia.Image = null;
                    }
                }
                else
                {
                    picAnhBia.Image = null;
                    duongDanAnh = string.Empty;
                }

                txtMaSach.Enabled = false; // Khóa Mã sách khi click vào dòng
            }
        }

        private string GetCellString(DataGridViewRow row, params string[] possibleColumnNames)
        {
            foreach (var name in possibleColumnNames)
            {
                var col = dgvDanhSach.Columns[name];
                if (col != null)
                {
                    var val = row.Cells[col.Index].Value;
                    if (val != null)
                        return val.ToString();
                }
            }
            return string.Empty;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSach.Text))
            {
                MessageBox.Show("Vui lòng chọn cuốn sách cần sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string trangThai = radConSach.Checked ? "Còn sách" : "Hết sách";
            string tenFileAnhLuuCSDL = null;

            // Xử lý copy ảnh NẾU người dùng thực sự chọn ảnh mới
            if (!string.IsNullOrEmpty(duongDanAnh) && System.IO.File.Exists(duongDanAnh) && !duongDanAnh.Contains(Application.StartupPath))
            {
                try
                {
                    string thuMucDich = System.IO.Path.Combine(Application.StartupPath, "Images");
                    if (!System.IO.Directory.Exists(thuMucDich))
                        System.IO.Directory.CreateDirectory(thuMucDich);

                    string phanMoRong = System.IO.Path.GetExtension(duongDanAnh);
                    tenFileAnhLuuCSDL = txtMaSach.Text.Trim() + phanMoRong;
                    string duongDanDich = System.IO.Path.Combine(thuMucDich, tenFileAnhLuuCSDL);

                    System.IO.File.Copy(duongDanAnh, duongDanDich, true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi lưu trữ tệp tin ảnh mới: " + ex.Message);
                }
            }
            else if (duongDanAnh == string.Empty)
            {
                tenFileAnhLuuCSDL = ""; // Đánh dấu xóa ảnh
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // Query ĐÃ FIX LỖI MẤT ẢNH bằng CASE WHEN
                    string query = @"UPDATE Sach SET 
                                     TenSach = @TenSach, TacGia = @TacGia, NamXB = @NamXB, 
                                     TheLoai = @TheLoai, SoLuong = @SoLuong, TrangThai = @TrangThai, 
                                     HinhAnh = CASE WHEN @HinhAnh IS NULL THEN HinhAnh ELSE @HinhAnh END 
                                     WHERE MaSach = @MaSach";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaSach", txtMaSach.Text.Trim());
                    cmd.Parameters.AddWithValue("@TenSach", txtTenSach.Text.Trim());
                    cmd.Parameters.AddWithValue("@TacGia", txtTacGia.Text.Trim());
                    cmd.Parameters.AddWithValue("@NamXB", (int)nudNamXB.Value);
                    cmd.Parameters.AddWithValue("@TheLoai", cboTheLoai.Text);
                    cmd.Parameters.AddWithValue("@SoLuong", (int)nudSoLuong.Value);
                    cmd.Parameters.AddWithValue("@TrangThai", trangThai);

                    if (tenFileAnhLuuCSDL == null)
                        cmd.Parameters.AddWithValue("@HinhAnh", DBNull.Value); // Giữ nguyên ảnh cũ
                    else
                        cmd.Parameters.AddWithValue("@HinhAnh", tenFileAnhLuuCSDL); // Có ảnh mới hoặc xóa ảnh

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Cập nhật sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        ClearForm(); // Chuyển về trạng thái sẵn sàng Thêm mới
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSach.Text))
            {
                MessageBox.Show("Vui lòng chọn cuốn sách cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn xóa cuốn sách này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM Sach WHERE MaSach = @MaSach";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@MaSach", txtMaSach.Text.Trim());

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadData();
                        ClearForm();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa (Có thể sách đang có phiếu mượn): " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT MaSach, TenSach, TacGia, NamXB, TheLoai, SoLuong, TrangThai, HinhAnh FROM Sach WHERE 1=1";

                    if (!string.IsNullOrWhiteSpace(txtTimKiem.Text))
                    {
                        query += " AND (MaSach LIKE @TuKhoa OR TenSach LIKE @TuKhoa OR TacGia LIKE @TuKhoa)";
                    }

                    if (cboLocTheLoai.SelectedIndex != -1 && !string.IsNullOrWhiteSpace(cboLocTheLoai.Text) && cboLocTheLoai.SelectedIndex != 0)
                    {
                        query += " AND TheLoai = @TheLoai";
                    }

                    if (cboLocTrangThai.SelectedIndex != -1 && !string.IsNullOrWhiteSpace(cboLocTrangThai.Text) && cboLocTrangThai.SelectedIndex != 0)
                    {
                        query += " AND TrangThai = @TrangThai";
                    }

                    SqlCommand cmd = new SqlCommand(query, conn);

                    if (!string.IsNullOrWhiteSpace(txtTimKiem.Text))
                        cmd.Parameters.AddWithValue("@TuKhoa", "%" + txtTimKiem.Text.Trim() + "%");

                    if (cboLocTheLoai.SelectedIndex != -1 && !string.IsNullOrWhiteSpace(cboLocTheLoai.Text) && cboLocTheLoai.SelectedIndex != 0)
                        cmd.Parameters.AddWithValue("@TheLoai", cboLocTheLoai.Text);

                    if (cboLocTrangThai.SelectedIndex != -1 && !string.IsNullOrWhiteSpace(cboLocTrangThai.Text) && cboLocTrangThai.SelectedIndex != 0)
                        cmd.Parameters.AddWithValue("@TrangThai", cboLocTrangThai.Text);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvDanhSach.DataSource = dt;

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy sách nào phù hợp với bộ lọc hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Empty method as generated by designer, kept to avoid compile error if attached to events
        }
    }
}