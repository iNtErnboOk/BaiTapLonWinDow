using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bài_Tập_lớn_Window.UserControls
{
    public partial class UC_DocGia : UserControl
    {
        string chuoiKetNoi = @"Data Source=.;Initial Catalog=QuanLyThuVien;Integrated Security=True";
        SqlConnection conn = null;

        public UC_DocGia()
        {
            InitializeComponent();
            HienThiDuLieu();
        }

        private void HienThiDuLieu()
        {
            conn = new SqlConnection(chuoiKetNoi);
            conn.Open();

            string sql = "SELECT * FROM DocGia";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns[0].DataPropertyName = "MaDG";
            dataGridView1.Columns[1].DataPropertyName = "TenDocGia";
            dataGridView1.Columns[2].DataPropertyName = "SDT";
            dataGridView1.Columns[3].DataPropertyName = "Email";
            dataGridView1.Columns[4].DataPropertyName = "DiaChi";
            dataGridView1.Columns[5].DataPropertyName = "NamSinh";
            dataGridView1.Columns[6].DataPropertyName = "GioiTinh";

            dataGridView1.DataSource = dt;
            conn.Close();
        }

        // ĐÃ SỬA SẠCH LỖI VÀ CHỈ GIỮ LẠI 1 ĐOẠN LẤY DỮ LIỆU DUY NHẤT
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int chiSoHang = e.RowIndex;

            // Kiểm tra để tránh click nhầm tiêu đề cột hoặc lề dưới cùng
            if (chiSoHang >= 0 && chiSoHang < dataGridView1.Rows.Count)
            {
                DataGridViewRow dong = dataGridView1.Rows[chiSoHang];

                // GỌI DỮ LIỆU THEO SỐ THỨ TỰ CỘT (0 đến 6) ĐỂ TRÁNH LỖI SAI TÊN
                txtMaDocGia.Text = dong.Cells[0].Value?.ToString() ?? "";
                txtTenDocGia.Text = dong.Cells[1].Value?.ToString() ?? "";
                txtSDT.Text = dong.Cells[2].Value?.ToString() ?? "";
                txtEmail.Text = dong.Cells[3].Value?.ToString() ?? "";
                txtDiaChi.Text = dong.Cells[4].Value?.ToString() ?? "";

                // Xử lý Năm Sinh (Cột số 5)
                if (dong.Cells[5].Value != DBNull.Value && dong.Cells[5].Value != null)
                {
                    int namSinh = Convert.ToInt32(dong.Cells[5].Value);
                    dtpNamSinh.Value = new DateTime(namSinh, 1, 1);
                }

                // Xử lý Giới Tính (Cột số 6)
                string gioiTinh = dong.Cells[6].Value?.ToString() ?? "";
                if (gioiTinh == "Nam") radNam.Checked = true;
                else if (gioiTinh == "Nữ") radNu.Checked = true;

                // Khóa mã độc giả lại để an toàn khi Sửa
                txtMaDocGia.ReadOnly = true;
            }
        }
        private void btnThemSach_Click(object sender, EventArgs e)
        {
            string gioiTinh = radNam.Checked ? "Nam" : "Nữ";

            conn = new SqlConnection(chuoiKetNoi);
            conn.Open();

            string sql = "INSERT INTO DocGia (MaDG, TenDocGia, SDT, Email, DiaChi, NamSinh, GioiTinh) " +
                         "VALUES (@ma, @ten, @sdt, @email, @diachi, @namsinh, @gioitinh)";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ma", txtMaDocGia.Text);
            cmd.Parameters.AddWithValue("@ten", txtTenDocGia.Text);
            cmd.Parameters.AddWithValue("@sdt", txtSDT.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@diachi", txtDiaChi.Text);
            cmd.Parameters.AddWithValue("@namsinh", dtpNamSinh.Value.Year);
            cmd.Parameters.AddWithValue("@gioitinh", gioiTinh);

            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Thêm độc giả thành công!");
            HienThiDuLieu();
        }

        private void btnSuaSach_Click(object sender, EventArgs e)
        {
            string gioiTinh = radNam.Checked ? "Nam" : "Nữ";

            conn = new SqlConnection(chuoiKetNoi);
            conn.Open();

            string sql = "UPDATE DocGia SET TenDocGia=@ten, SDT=@sdt, Email=@email, " +
                         "DiaChi=@diachi, NamSinh=@namsinh, GioiTinh=@gioitinh WHERE MaDG=@ma";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ma", txtMaDocGia.Text);
            cmd.Parameters.AddWithValue("@ten", txtTenDocGia.Text);
            cmd.Parameters.AddWithValue("@sdt", txtSDT.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@diachi", txtDiaChi.Text);
            cmd.Parameters.AddWithValue("@namsinh", dtpNamSinh.Value.Year);
            cmd.Parameters.AddWithValue("@gioitinh", gioiTinh);

            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Sửa thông tin thành công!");
            HienThiDuLieu();
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(chuoiKetNoi);
            conn.Open();

            string sql = "DELETE FROM DocGia WHERE MaDG = @ma";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ma", txtMaDocGia.Text);

            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Xóa độc giả thành công!");
            HienThiDuLieu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tuKhoa = textTimKiem.Text;

            conn = new SqlConnection(chuoiKetNoi);
            conn.Open();

            string sql = "SELECT * FROM DocGia WHERE MaDG LIKE @tukhoa OR TenDocGia LIKE @tukhoa";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("@tukhoa", "%" + tuKhoa + "%");

            DataTable dtTimKiem = new DataTable();
            da.Fill(dtTimKiem);
            dataGridView1.DataSource = dtTimKiem;

            conn.Close();
        }
    }
}