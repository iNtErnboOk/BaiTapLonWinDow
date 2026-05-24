namespace Bài_Tập_lớn_Window.UserControls
{
    partial class UC_Sach
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnXoaAnh = new System.Windows.Forms.Button();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.picAnhBia = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblTheLoai = new System.Windows.Forms.Label();
            this.lblNamXB = new System.Windows.Forms.Label();
            this.lblTacGia = new System.Windows.Forms.Label();
            this.lblMaSach = new System.Windows.Forms.Label();
            this.lblTenSach = new System.Windows.Forms.Label();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.nudNamXB = new System.Windows.Forms.NumericUpDown();
            this.cboTheLoai = new System.Windows.Forms.ComboBox();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radHetSach = new System.Windows.Forms.RadioButton();
            this.radConSach = new System.Windows.Forms.RadioButton();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cboLocTheLoai = new System.Windows.Forms.ComboBox();
            this.cboLocTrangThai = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.colMaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bt_XoaTrang = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhBia)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNamXB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.bt_XoaTrang);
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel4);
            this.splitContainer1.Panel1.Controls.Add(this.btnXoaAnh);
            this.splitContainer1.Panel1.Controls.Add(this.btnChonAnh);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.picAnhBia);
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel3);
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.dgvDanhSach);
            this.splitContainer1.Size = new System.Drawing.Size(1373, 838);
            this.splitContainer1.SplitterDistance = 362;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Controls.Add(this.btnThem, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnSua, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnXoa, 2, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(5, 773);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(332, 62);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(4, 4);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(102, 54);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(114, 4);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(102, 54);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa ";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.IndianRed;
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(224, 4);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(104, 54);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa ";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnXoaAnh
            // 
            this.btnXoaAnh.BackColor = System.Drawing.Color.LightCoral;
            this.btnXoaAnh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaAnh.ForeColor = System.Drawing.Color.White;
            this.btnXoaAnh.Location = new System.Drawing.Point(203, 681);
            this.btnXoaAnh.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaAnh.Name = "btnXoaAnh";
            this.btnXoaAnh.Size = new System.Drawing.Size(100, 34);
            this.btnXoaAnh.TabIndex = 5;
            this.btnXoaAnh.Text = "Xóa Ảnh";
            this.btnXoaAnh.UseVisualStyleBackColor = false;
            this.btnXoaAnh.Click += new System.EventHandler(this.btnXoaAnh_Click);
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.BackColor = System.Drawing.Color.SteelBlue;
            this.btnChonAnh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonAnh.ForeColor = System.Drawing.Color.White;
            this.btnChonAnh.Location = new System.Drawing.Point(203, 639);
            this.btnChonAnh.Margin = new System.Windows.Forms.Padding(4);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(100, 34);
            this.btnChonAnh.TabIndex = 4;
            this.btnChonAnh.Text = "Chọn Ảnh";
            this.btnChonAnh.UseVisualStyleBackColor = false;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 502);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Chọn Ảnh Bìa :";
            // 
            // picAnhBia
            // 
            this.picAnhBia.BackColor = System.Drawing.Color.White;
            this.picAnhBia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAnhBia.Location = new System.Drawing.Point(13, 539);
            this.picAnhBia.Margin = new System.Windows.Forms.Padding(4);
            this.picAnhBia.Name = "picAnhBia";
            this.picAnhBia.Size = new System.Drawing.Size(162, 176);
            this.picAnhBia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnhBia.TabIndex = 2;
            this.picAnhBia.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.08333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.91667F));
            this.tableLayoutPanel1.Controls.Add(this.lblSoLuong, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblTheLoai, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblNamXB, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblTacGia, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblMaSach, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTenSach, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtMaSach, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTenSach, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTacGia, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.nudNamXB, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cboTheLoai, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.nudSoLuong, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblTrangThai, 0, 6);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 47);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(328, 406);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblSoLuong.Location = new System.Drawing.Point(4, 319);
            this.lblSoLuong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Padding = new System.Windows.Forms.Padding(0, 0, 0, 9);
            this.lblSoLuong.Size = new System.Drawing.Size(113, 29);
            this.lblSoLuong.TabIndex = 10;
            this.lblSoLuong.Text = "Số Lượng :";
            // 
            // lblTheLoai
            // 
            this.lblTheLoai.AutoSize = true;
            this.lblTheLoai.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTheLoai.Location = new System.Drawing.Point(4, 261);
            this.lblTheLoai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTheLoai.Name = "lblTheLoai";
            this.lblTheLoai.Padding = new System.Windows.Forms.Padding(0, 0, 0, 9);
            this.lblTheLoai.Size = new System.Drawing.Size(113, 29);
            this.lblTheLoai.TabIndex = 8;
            this.lblTheLoai.Text = "Thể Loại :";
            // 
            // lblNamXB
            // 
            this.lblNamXB.AutoSize = true;
            this.lblNamXB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblNamXB.Location = new System.Drawing.Point(4, 203);
            this.lblNamXB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNamXB.Name = "lblNamXB";
            this.lblNamXB.Padding = new System.Windows.Forms.Padding(0, 0, 0, 9);
            this.lblNamXB.Size = new System.Drawing.Size(113, 29);
            this.lblNamXB.TabIndex = 6;
            this.lblNamXB.Text = "Năm XB :";
            // 
            // lblTacGia
            // 
            this.lblTacGia.AutoSize = true;
            this.lblTacGia.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTacGia.Location = new System.Drawing.Point(4, 145);
            this.lblTacGia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTacGia.Name = "lblTacGia";
            this.lblTacGia.Padding = new System.Windows.Forms.Padding(0, 0, 0, 9);
            this.lblTacGia.Size = new System.Drawing.Size(113, 29);
            this.lblTacGia.TabIndex = 4;
            this.lblTacGia.Text = "Tác Giả :";
            // 
            // lblMaSach
            // 
            this.lblMaSach.AutoSize = true;
            this.lblMaSach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMaSach.Location = new System.Drawing.Point(4, 29);
            this.lblMaSach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaSach.Name = "lblMaSach";
            this.lblMaSach.Padding = new System.Windows.Forms.Padding(0, 0, 0, 9);
            this.lblMaSach.Size = new System.Drawing.Size(113, 29);
            this.lblMaSach.TabIndex = 0;
            this.lblMaSach.Text = "Mã Sách :";
            // 
            // lblTenSach
            // 
            this.lblTenSach.AutoSize = true;
            this.lblTenSach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTenSach.Location = new System.Drawing.Point(4, 87);
            this.lblTenSach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenSach.Name = "lblTenSach";
            this.lblTenSach.Padding = new System.Windows.Forms.Padding(0, 0, 0, 9);
            this.lblTenSach.Size = new System.Drawing.Size(113, 29);
            this.lblTenSach.TabIndex = 1;
            this.lblTenSach.Text = "Tên Sách :";
            // 
            // txtMaSach
            // 
            this.txtMaSach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtMaSach.Location = new System.Drawing.Point(125, 28);
            this.txtMaSach.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(199, 26);
            this.txtMaSach.TabIndex = 13;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtTenSach.Location = new System.Drawing.Point(125, 86);
            this.txtTenSach.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(199, 26);
            this.txtTenSach.TabIndex = 14;
            // 
            // txtTacGia
            // 
            this.txtTacGia.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtTacGia.Location = new System.Drawing.Point(125, 144);
            this.txtTacGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(199, 26);
            this.txtTacGia.TabIndex = 15;
            // 
            // nudNamXB
            // 
            this.nudNamXB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nudNamXB.Location = new System.Drawing.Point(125, 202);
            this.nudNamXB.Margin = new System.Windows.Forms.Padding(4);
            this.nudNamXB.Name = "nudNamXB";
            this.nudNamXB.Size = new System.Drawing.Size(199, 26);
            this.nudNamXB.TabIndex = 16;
            // 
            // cboTheLoai
            // 
            this.cboTheLoai.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cboTheLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTheLoai.FormattingEnabled = true;
            this.cboTheLoai.Items.AddRange(new object[] {
            "-- Chọn thể loại sách --",
            "Giáo trình",
            "Tài liệu tham khảo",
            "Đồ án - Luận văn",
            "Công nghệ thông tin - Lập trình",
            "Toán học - Thống kê",
            "Triết học - Kinh tế chính trị",
            "Kỹ thuật - Điện tử",
            "Khoa học tự nhiên",
            "Khoa học xã hội & Nhân văn",
            "Ngoại ngữ",
            "Văn học - Tiểu thuyết",
            "Tâm lý - Kỹ năng sống",
            "Lịch sử - Địa lý",
            "Tạp chí - Báo cáo khoa học",
            "Khác..."});
            this.cboTheLoai.Location = new System.Drawing.Point(125, 258);
            this.cboTheLoai.Margin = new System.Windows.Forms.Padding(4);
            this.cboTheLoai.Name = "cboTheLoai";
            this.cboTheLoai.Size = new System.Drawing.Size(199, 28);
            this.cboTheLoai.TabIndex = 17;
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nudSoLuong.Location = new System.Drawing.Point(125, 318);
            this.nudSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(199, 26);
            this.nudSoLuong.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radHetSach);
            this.groupBox1.Controls.Add(this.radConSach);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(125, 377);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(199, 25);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // radHetSach
            // 
            this.radHetSach.AutoSize = true;
            this.radHetSach.Location = new System.Drawing.Point(103, -2);
            this.radHetSach.Margin = new System.Windows.Forms.Padding(4);
            this.radHetSach.Name = "radHetSach";
            this.radHetSach.Size = new System.Drawing.Size(98, 24);
            this.radHetSach.TabIndex = 1;
            this.radHetSach.TabStop = true;
            this.radHetSach.Text = "Hết sách";
            this.radHetSach.UseVisualStyleBackColor = true;
            // 
            // radConSach
            // 
            this.radConSach.AutoSize = true;
            this.radConSach.Location = new System.Drawing.Point(0, -2);
            this.radConSach.Margin = new System.Windows.Forms.Padding(4);
            this.radConSach.Name = "radConSach";
            this.radConSach.Size = new System.Drawing.Size(101, 24);
            this.radConSach.TabIndex = 0;
            this.radConSach.TabStop = true;
            this.radConSach.Text = "Còn sách";
            this.radConSach.UseVisualStyleBackColor = true;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTrangThai.Location = new System.Drawing.Point(4, 377);
            this.lblTrangThai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Padding = new System.Windows.Forms.Padding(0, 0, 0, 9);
            this.lblTrangThai.Size = new System.Drawing.Size(113, 29);
            this.lblTrangThai.TabIndex = 12;
            this.lblTrangThai.Text = "Trạng Thái :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(4, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin sách";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.tableLayoutPanel3.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.button3, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(725, 4);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(276, 44);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SlateGray;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(132, 4);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 36);
            this.button2.TabIndex = 0;
            this.button2.Text = "In Danh Sách";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.ForestGreen;
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(4, 4);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 36);
            this.button3.TabIndex = 1;
            this.button3.Text = "Xuất Excel";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.7767F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.2233F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 237F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel2.Controls.Add(this.txtTimKiem, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cboLocTheLoai, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cboLocTrangThai, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnTimKiem, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 55);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(997, 49);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(4, 19);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(373, 26);
            this.txtTimKiem.TabIndex = 0;
            // 
            // cboLocTheLoai
            // 
            this.cboLocTheLoai.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cboLocTheLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLocTheLoai.FormattingEnabled = true;
            this.cboLocTheLoai.Items.AddRange(new object[] {
            "-- Chọn thể loại sách --",
            "Giáo trình",
            "Tài liệu tham khảo",
            "Đồ án - Luận văn",
            "Công nghệ thông tin - Lập trình",
            "Toán học - Thống kê",
            "Triết học - Kinh tế chính trị",
            "Kỹ thuật - Điện tử",
            "Khoa học tự nhiên",
            "Khoa học xã hội & Nhân văn",
            "Ngoại ngữ",
            "Văn học - Tiểu thuyết",
            "Tâm lý - Kỹ năng sống",
            "Lịch sử - Địa lý",
            "Tạp chí - Báo cáo khoa học",
            "Khác..."});
            this.cboLocTheLoai.Location = new System.Drawing.Point(385, 17);
            this.cboLocTheLoai.Margin = new System.Windows.Forms.Padding(4);
            this.cboLocTheLoai.Name = "cboLocTheLoai";
            this.cboLocTheLoai.Size = new System.Drawing.Size(238, 28);
            this.cboLocTheLoai.TabIndex = 1;
            // 
            // cboLocTrangThai
            // 
            this.cboLocTrangThai.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cboLocTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLocTrangThai.FormattingEnabled = true;
            this.cboLocTrangThai.Items.AddRange(new object[] {
            "-- Chọn trạng thái --",
            "Còn sách",
            "Hết sách"});
            this.cboLocTrangThai.Location = new System.Drawing.Point(631, 17);
            this.cboLocTrangThai.Margin = new System.Windows.Forms.Padding(4);
            this.cboLocTrangThai.Name = "cboLocTrangThai";
            this.cboLocTrangThai.Size = new System.Drawing.Size(229, 28);
            this.cboLocTrangThai.TabIndex = 2;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTimKiem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(868, 4);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(125, 41);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(4, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Danh sách sách";
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.AllowUserToResizeColumns = false;
            this.dgvDanhSach.AllowUserToResizeRows = false;
            this.dgvDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSach.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSach,
            this.colTenSach,
            this.colTacGia,
            this.colTheLoai,
            this.colSoLuong,
            this.colTrangThai});
            this.dgvDanhSach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDanhSach.EnableHeadersVisualStyles = false;
            this.dgvDanhSach.Location = new System.Drawing.Point(0, 112);
            this.dgvDanhSach.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.RowHeadersWidth = 51;
            this.dgvDanhSach.Size = new System.Drawing.Size(1006, 726);
            this.dgvDanhSach.TabIndex = 0;
            this.dgvDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellClick);
            this.dgvDanhSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colMaSach
            // 
            this.colMaSach.HeaderText = "Mã Sách";
            this.colMaSach.MinimumWidth = 6;
            this.colMaSach.Name = "colMaSach";
            // 
            // colTenSach
            // 
            this.colTenSach.HeaderText = "Tên Sách";
            this.colTenSach.MinimumWidth = 6;
            this.colTenSach.Name = "colTenSach";
            // 
            // colTacGia
            // 
            this.colTacGia.HeaderText = "Tác Giả";
            this.colTacGia.MinimumWidth = 6;
            this.colTacGia.Name = "colTacGia";
            // 
            // colTheLoai
            // 
            this.colTheLoai.HeaderText = "Thể Loại";
            this.colTheLoai.MinimumWidth = 6;
            this.colTheLoai.Name = "colTheLoai";
            // 
            // colSoLuong
            // 
            this.colSoLuong.HeaderText = "Số Lượng";
            this.colSoLuong.MinimumWidth = 6;
            this.colSoLuong.Name = "colSoLuong";
            // 
            // colTrangThai
            // 
            this.colTrangThai.HeaderText = "Trạng Thái";
            this.colTrangThai.MinimumWidth = 6;
            this.colTrangThai.Name = "colTrangThai";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"Image Files|*.jpg;*.jpeg;*.png\"";
            // 
            // bt_XoaTrang
            // 
            this.bt_XoaTrang.BackColor = System.Drawing.Color.IndianRed;
            this.bt_XoaTrang.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_XoaTrang.Location = new System.Drawing.Point(221, 471);
            this.bt_XoaTrang.Margin = new System.Windows.Forms.Padding(4);
            this.bt_XoaTrang.Name = "bt_XoaTrang";
            this.bt_XoaTrang.Size = new System.Drawing.Size(108, 37);
            this.bt_XoaTrang.TabIndex = 8;
            this.bt_XoaTrang.Text = "Xóa trắng";
            this.bt_XoaTrang.UseVisualStyleBackColor = false;
            this.bt_XoaTrang.Click += new System.EventHandler(this.bt_XoaTrang_Click);
            // 
            // UC_Sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_Sach";
            this.Size = new System.Drawing.Size(1373, 838);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAnhBia)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNamXB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblTheLoai;
        private System.Windows.Forms.Label lblNamXB;
        private System.Windows.Forms.Label lblTacGia;
        private System.Windows.Forms.Label lblMaSach;
        private System.Windows.Forms.Label lblTenSach;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.NumericUpDown nudNamXB;
        private System.Windows.Forms.ComboBox cboTheLoai;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cboLocTheLoai;
        private System.Windows.Forms.ComboBox cboLocTrangThai;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton radHetSach;
        private System.Windows.Forms.RadioButton radConSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.PictureBox picAnhBia;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnXoaAnh;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button bt_XoaTrang;
    }
}
