namespace Bài_Tập_lớn_Window.UserControls
{
    partial class UC_TraSach
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblThongTin = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dtpNgayTraThucTe = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.txtTienPhat = new System.Windows.Forms.TextBox();
            this.lblTienPhat = new System.Windows.Forms.Label();
            this.lblNgayTraThucTe = new System.Windows.Forms.Label();
            this.txtTenDG = new System.Windows.Forms.TextBox();
            this.lblTenDG = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblNgayTra = new System.Windows.Forms.Label();
            this.txtMaDG = new System.Windows.Forms.TextBox();
            this.lblMaDG = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.txtNgayMuon = new System.Windows.Forms.Label();
            this.lblMaPhieuMuon = new System.Windows.Forms.Label();
            this.txtMaPhieuMuon = new System.Windows.Forms.TextBox();
            this.btnLuuPhieuTra = new System.Windows.Forms.Button();
            this.btnHuyPhieuTra = new System.Windows.Forms.Button();
            this.dtpNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachPhieuMuon = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaPhieuMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThaiTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblThongTinPhieuTra = new System.Windows.Forms.Label();
            this.dgvDachSachTraSach = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhieuMuon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDachSachTraSach)).BeginInit();
            this.SuspendLayout();
            // 
            // lblThongTin
            // 
            this.lblThongTin.AutoSize = true;
            this.lblThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTin.ForeColor = System.Drawing.Color.Blue;
            this.lblThongTin.Location = new System.Drawing.Point(3, 0);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new System.Drawing.Size(240, 25);
            this.lblThongTin.TabIndex = 2;
            this.lblThongTin.Text = "Thông tin phiếu mượn";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.02898F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.97102F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.tableLayoutPanel2.Controls.Add(this.dtpNgayTraThucTe, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.dtpNgayTra, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtTienPhat, 5, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblTienPhat, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblNgayTraThucTe, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtTenDG, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblTenDG, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblTrangThai, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblNgayTra, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtMaDG, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblMaDG, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblSoLuong, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtNgayMuon, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblMaPhieuMuon, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtMaPhieuMuon, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnLuuPhieuTra, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnHuyPhieuTra, 6, 1);
            this.tableLayoutPanel2.Controls.Add(this.dtpNgayMuon, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.nudSoLuong, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbTrangThai, 5, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(18, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(959, 102);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // dtpNgayTraThucTe
            // 
            this.dtpNgayTraThucTe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtpNgayTraThucTe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayTraThucTe.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTraThucTe.Location = new System.Drawing.Point(425, 77);
            this.dtpNgayTraThucTe.Name = "dtpNgayTraThucTe";
            this.dtpNgayTraThucTe.Size = new System.Drawing.Size(134, 22);
            this.dtpNgayTraThucTe.TabIndex = 26;
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtpNgayTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTra.Location = new System.Drawing.Point(425, 43);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(134, 22);
            this.dtpNgayTra.TabIndex = 25;
            // 
            // txtTienPhat
            // 
            this.txtTienPhat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtTienPhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienPhat.Location = new System.Drawing.Point(689, 77);
            this.txtTienPhat.Name = "txtTienPhat";
            this.txtTienPhat.ReadOnly = true;
            this.txtTienPhat.Size = new System.Drawing.Size(118, 22);
            this.txtTienPhat.TabIndex = 21;
            // 
            // lblTienPhat
            // 
            this.lblTienPhat.AutoSize = true;
            this.lblTienPhat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTienPhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienPhat.Location = new System.Drawing.Point(565, 79);
            this.lblTienPhat.Name = "lblTienPhat";
            this.lblTienPhat.Padding = new System.Windows.Forms.Padding(0, 0, 0, 7);
            this.lblTienPhat.Size = new System.Drawing.Size(118, 23);
            this.lblTienPhat.TabIndex = 20;
            this.lblTienPhat.Text = "Tiền Phạt:";
            // 
            // lblNgayTraThucTe
            // 
            this.lblNgayTraThucTe.AutoSize = true;
            this.lblNgayTraThucTe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblNgayTraThucTe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayTraThucTe.Location = new System.Drawing.Point(286, 79);
            this.lblNgayTraThucTe.Name = "lblNgayTraThucTe";
            this.lblNgayTraThucTe.Padding = new System.Windows.Forms.Padding(0, 0, 0, 7);
            this.lblNgayTraThucTe.Size = new System.Drawing.Size(133, 23);
            this.lblNgayTraThucTe.TabIndex = 18;
            this.lblNgayTraThucTe.Text = "Ngày Trả Thực Tế: ";
            // 
            // txtTenDG
            // 
            this.txtTenDG.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtTenDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDG.Location = new System.Drawing.Point(122, 77);
            this.txtTenDG.Name = "txtTenDG";
            this.txtTenDG.ReadOnly = true;
            this.txtTenDG.Size = new System.Drawing.Size(158, 22);
            this.txtTenDG.TabIndex = 17;
            // 
            // lblTenDG
            // 
            this.lblTenDG.AutoSize = true;
            this.lblTenDG.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTenDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDG.Location = new System.Drawing.Point(3, 79);
            this.lblTenDG.Name = "lblTenDG";
            this.lblTenDG.Padding = new System.Windows.Forms.Padding(0, 0, 0, 7);
            this.lblTenDG.Size = new System.Drawing.Size(113, 23);
            this.lblTenDG.TabIndex = 16;
            this.lblTenDG.Text = "Tên Độc Giả:";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai.Location = new System.Drawing.Point(565, 45);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Padding = new System.Windows.Forms.Padding(0, 0, 0, 7);
            this.lblTrangThai.Size = new System.Drawing.Size(118, 23);
            this.lblTrangThai.TabIndex = 14;
            this.lblTrangThai.Text = "Trạng Thái:";
            // 
            // lblNgayTra
            // 
            this.lblNgayTra.AutoSize = true;
            this.lblNgayTra.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblNgayTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayTra.Location = new System.Drawing.Point(286, 45);
            this.lblNgayTra.Name = "lblNgayTra";
            this.lblNgayTra.Padding = new System.Windows.Forms.Padding(0, 0, 0, 7);
            this.lblNgayTra.Size = new System.Drawing.Size(133, 23);
            this.lblNgayTra.TabIndex = 12;
            this.lblNgayTra.Text = "Ngày Trả:";
            // 
            // txtMaDG
            // 
            this.txtMaDG.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtMaDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDG.Location = new System.Drawing.Point(122, 43);
            this.txtMaDG.Name = "txtMaDG";
            this.txtMaDG.ReadOnly = true;
            this.txtMaDG.Size = new System.Drawing.Size(158, 22);
            this.txtMaDG.TabIndex = 11;
            // 
            // lblMaDG
            // 
            this.lblMaDG.AutoSize = true;
            this.lblMaDG.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMaDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDG.Location = new System.Drawing.Point(3, 45);
            this.lblMaDG.Name = "lblMaDG";
            this.lblMaDG.Padding = new System.Windows.Forms.Padding(0, 0, 0, 7);
            this.lblMaDG.Size = new System.Drawing.Size(113, 23);
            this.lblMaDG.TabIndex = 10;
            this.lblMaDG.Text = "Mã Độc Giả:";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(565, 11);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Padding = new System.Windows.Forms.Padding(0, 0, 0, 7);
            this.lblSoLuong.Size = new System.Drawing.Size(118, 23);
            this.lblSoLuong.TabIndex = 6;
            this.lblSoLuong.Text = "Số Lượng Sách:";
            // 
            // txtNgayMuon
            // 
            this.txtNgayMuon.AutoSize = true;
            this.txtNgayMuon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtNgayMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayMuon.Location = new System.Drawing.Point(286, 11);
            this.txtNgayMuon.Name = "txtNgayMuon";
            this.txtNgayMuon.Padding = new System.Windows.Forms.Padding(0, 0, 0, 7);
            this.txtNgayMuon.Size = new System.Drawing.Size(133, 23);
            this.txtNgayMuon.TabIndex = 4;
            this.txtNgayMuon.Text = "Ngày Mượn:";
            // 
            // lblMaPhieuMuon
            // 
            this.lblMaPhieuMuon.AutoSize = true;
            this.lblMaPhieuMuon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMaPhieuMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPhieuMuon.Location = new System.Drawing.Point(3, 11);
            this.lblMaPhieuMuon.Name = "lblMaPhieuMuon";
            this.lblMaPhieuMuon.Padding = new System.Windows.Forms.Padding(0, 0, 0, 7);
            this.lblMaPhieuMuon.Size = new System.Drawing.Size(113, 23);
            this.lblMaPhieuMuon.TabIndex = 0;
            this.lblMaPhieuMuon.Text = "Mã Phiếu Mượn:\r\n";
            // 
            // txtMaPhieuMuon
            // 
            this.txtMaPhieuMuon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtMaPhieuMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhieuMuon.Location = new System.Drawing.Point(122, 9);
            this.txtMaPhieuMuon.Name = "txtMaPhieuMuon";
            this.txtMaPhieuMuon.Size = new System.Drawing.Size(158, 22);
            this.txtMaPhieuMuon.TabIndex = 3;
            // 
            // btnLuuPhieuTra
            // 
            this.btnLuuPhieuTra.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnLuuPhieuTra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLuuPhieuTra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuPhieuTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuPhieuTra.ForeColor = System.Drawing.Color.White;
            this.btnLuuPhieuTra.Location = new System.Drawing.Point(813, 3);
            this.btnLuuPhieuTra.Name = "btnLuuPhieuTra";
            this.btnLuuPhieuTra.Size = new System.Drawing.Size(143, 28);
            this.btnLuuPhieuTra.TabIndex = 22;
            this.btnLuuPhieuTra.Text = "Lưu Phiếu Trả";
            this.btnLuuPhieuTra.UseVisualStyleBackColor = false;
            // 
            // btnHuyPhieuTra
            // 
            this.btnHuyPhieuTra.BackColor = System.Drawing.Color.IndianRed;
            this.btnHuyPhieuTra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHuyPhieuTra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyPhieuTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyPhieuTra.ForeColor = System.Drawing.Color.White;
            this.btnHuyPhieuTra.Location = new System.Drawing.Point(813, 37);
            this.btnHuyPhieuTra.Name = "btnHuyPhieuTra";
            this.btnHuyPhieuTra.Size = new System.Drawing.Size(143, 28);
            this.btnHuyPhieuTra.TabIndex = 23;
            this.btnHuyPhieuTra.Text = "Hủy Phiếu Trả";
            this.btnHuyPhieuTra.UseVisualStyleBackColor = false;
            // 
            // dtpNgayMuon
            // 
            this.dtpNgayMuon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtpNgayMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayMuon.Location = new System.Drawing.Point(425, 9);
            this.dtpNgayMuon.Name = "dtpNgayMuon";
            this.dtpNgayMuon.Size = new System.Drawing.Size(134, 22);
            this.dtpNgayMuon.TabIndex = 24;
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nudSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSoLuong.Location = new System.Drawing.Point(689, 9);
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.ReadOnly = true;
            this.nudSoLuong.Size = new System.Drawing.Size(118, 22);
            this.nudSoLuong.TabIndex = 27;
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Items.AddRange(new object[] {
            "Đúng hạn",
            "Quá hạn"});
            this.cbTrangThai.Location = new System.Drawing.Point(689, 41);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(118, 24);
            this.cbTrangThai.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDanhSachPhieuMuon);
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Location = new System.Drawing.Point(8, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1005, 374);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // dgvDanhSachPhieuMuon
            // 
            this.dgvDanhSachPhieuMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachPhieuMuon.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachPhieuMuon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachPhieuMuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colMaPhieuMuon,
            this.colMaDocGia,
            this.colTenDG,
            this.colNgayMuon,
            this.colNgayTra,
            this.colTrangThaiTra});
            this.dgvDanhSachPhieuMuon.EnableHeadersVisualStyles = false;
            this.dgvDanhSachPhieuMuon.Location = new System.Drawing.Point(18, 127);
            this.dgvDanhSachPhieuMuon.Name = "dgvDanhSachPhieuMuon";
            this.dgvDanhSachPhieuMuon.Size = new System.Drawing.Size(959, 233);
            this.dgvDanhSachPhieuMuon.TabIndex = 8;
            // 
            // colSTT
            // 
            this.colSTT.FillWeight = 30F;
            this.colSTT.HeaderText = "STT";
            this.colSTT.Name = "colSTT";
            // 
            // colMaPhieuMuon
            // 
            this.colMaPhieuMuon.FillWeight = 90F;
            this.colMaPhieuMuon.HeaderText = "Mã Phiếu Mượn";
            this.colMaPhieuMuon.Name = "colMaPhieuMuon";
            // 
            // colMaDocGia
            // 
            this.colMaDocGia.FillWeight = 80F;
            this.colMaDocGia.HeaderText = "Mã Độc Giả";
            this.colMaDocGia.Name = "colMaDocGia";
            // 
            // colTenDG
            // 
            this.colTenDG.HeaderText = "Tên Độc Giả";
            this.colTenDG.Name = "colTenDG";
            // 
            // colNgayMuon
            // 
            this.colNgayMuon.FillWeight = 60F;
            this.colNgayMuon.HeaderText = "Ngày Mượn";
            this.colNgayMuon.Name = "colNgayMuon";
            // 
            // colNgayTra
            // 
            this.colNgayTra.FillWeight = 60F;
            this.colNgayTra.HeaderText = "Ngày Trả";
            this.colNgayTra.Name = "colNgayTra";
            // 
            // colTrangThaiTra
            // 
            this.colTrangThaiTra.FillWeight = 80F;
            this.colTrangThaiTra.HeaderText = "Trạng Thái Trả";
            this.colTrangThaiTra.Name = "colTrangThaiTra";
            // 
            // lblThongTinPhieuTra
            // 
            this.lblThongTinPhieuTra.AutoSize = true;
            this.lblThongTinPhieuTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinPhieuTra.ForeColor = System.Drawing.Color.Blue;
            this.lblThongTinPhieuTra.Location = new System.Drawing.Point(3, 405);
            this.lblThongTinPhieuTra.Name = "lblThongTinPhieuTra";
            this.lblThongTinPhieuTra.Size = new System.Drawing.Size(216, 25);
            this.lblThongTinPhieuTra.TabIndex = 9;
            this.lblThongTinPhieuTra.Text = "Danh sách trả sách";
            // 
            // dgvDachSachTraSach
            // 
            this.dgvDachSachTraSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDachSachTraSach.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDachSachTraSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDachSachTraSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDachSachTraSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn7});
            this.dgvDachSachTraSach.EnableHeadersVisualStyles = false;
            this.dgvDachSachTraSach.Location = new System.Drawing.Point(23, 433);
            this.dgvDachSachTraSach.Name = "dgvDachSachTraSach";
            this.dgvDachSachTraSach.Size = new System.Drawing.Size(959, 245);
            this.dgvDachSachTraSach.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 90F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã Phiếu Mượn";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 80F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Mã Độc Giả";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Tên Độc Giả";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.FillWeight = 60F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Ngày Trả";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.FillWeight = 60F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Số Lượng";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 80F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Trạng Thái";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.FillWeight = 80F;
            this.dataGridViewTextBoxColumn7.HeaderText = "Tiền Phạt";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // UC_TraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvDachSachTraSach);
            this.Controls.Add(this.lblThongTinPhieuTra);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblThongTin);
            this.Name = "UC_TraSach";
            this.Size = new System.Drawing.Size(1030, 681);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhieuMuon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDachSachTraSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblMaPhieuMuon;
        private System.Windows.Forms.TextBox txtMaPhieuMuon;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label lblNgayTra;
        private System.Windows.Forms.TextBox txtMaDG;
        private System.Windows.Forms.Label lblMaDG;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label txtNgayMuon;
        private System.Windows.Forms.Label lblNgayTraThucTe;
        private System.Windows.Forms.TextBox txtTenDG;
        private System.Windows.Forms.Label lblTenDG;
        private System.Windows.Forms.TextBox txtTienPhat;
        private System.Windows.Forms.Label lblTienPhat;
        private System.Windows.Forms.Button btnLuuPhieuTra;
        private System.Windows.Forms.Button btnHuyPhieuTra;
        private System.Windows.Forms.DateTimePicker dtpNgayMuon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpNgayTraThucTe;
        private System.Windows.Forms.DateTimePicker dtpNgayTra;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.ComboBox cbTrangThai;
        private System.Windows.Forms.DataGridView dgvDanhSachPhieuMuon;
        private System.Windows.Forms.Label lblThongTinPhieuTra;
        private System.Windows.Forms.DataGridView dgvDachSachTraSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhieuMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThaiTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}
