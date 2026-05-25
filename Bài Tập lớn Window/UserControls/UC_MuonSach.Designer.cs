namespace Bài_Tập_lớn_Window.UserControls
{
    partial class UC_MuonSach
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMaPhieuMuon = new System.Windows.Forms.Label();
            this.lblMaDG = new System.Windows.Forms.Label();
            this.dtpNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.lblNgayMuon = new System.Windows.Forms.Label();
            this.lblTenDG = new System.Windows.Forms.Label();
            this.lblNgayTra = new System.Windows.Forms.Label();
            this.txtMaPhieuMuon = new System.Windows.Forms.TextBox();
            this.txtMaDG = new System.Windows.Forms.TextBox();
            this.txtTenDocGia = new System.Windows.Forms.TextBox();
            this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.lblChonSach = new System.Windows.Forms.Label();
            this.dgvChonSach = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.lblTenSach = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblMaSach = new System.Windows.Forms.Label();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.btnThemSach = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDanhSachSachMuon = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnXoaSachMuon = new System.Windows.Forms.Button();
            this.btnHuyPhieu = new System.Windows.Forms.Button();
            this.btnLapPhieuMuon = new System.Windows.Forms.Button();
            this.dgvDanhSachSachMuon = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuongCon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChonSach)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSachMuon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblThongTin
            // 
            this.lblThongTin.AutoSize = true;
            this.lblThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTin.ForeColor = System.Drawing.Color.Blue;
            this.lblThongTin.Location = new System.Drawing.Point(11, 12);
            this.lblThongTin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new System.Drawing.Size(285, 31);
            this.lblThongTin.TabIndex = 1;
            this.lblThongTin.Text = "Thông tin mượn sách\r\n";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.8102F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.1898F));
            this.tableLayoutPanel1.Controls.Add(this.lblMaPhieuMuon, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblMaDG, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtpNgayMuon, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblNgayMuon, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblTenDG, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblNgayTra, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtMaPhieuMuon, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtMaDG, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTenDocGia, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dtpNgayTra, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 47);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(411, 327);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lblMaPhieuMuon
            // 
            this.lblMaPhieuMuon.AutoSize = true;
            this.lblMaPhieuMuon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMaPhieuMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPhieuMuon.Location = new System.Drawing.Point(4, 36);
            this.lblMaPhieuMuon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaPhieuMuon.Name = "lblMaPhieuMuon";
            this.lblMaPhieuMuon.Padding = new System.Windows.Forms.Padding(0, 0, 0, 9);
            this.lblMaPhieuMuon.Size = new System.Drawing.Size(151, 29);
            this.lblMaPhieuMuon.TabIndex = 0;
            this.lblMaPhieuMuon.Text = "Mã Phiếu Mượn:";
            // 
            // lblMaDG
            // 
            this.lblMaDG.AutoSize = true;
            this.lblMaDG.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMaDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDG.Location = new System.Drawing.Point(4, 101);
            this.lblMaDG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaDG.Name = "lblMaDG";
            this.lblMaDG.Padding = new System.Windows.Forms.Padding(0, 0, 0, 9);
            this.lblMaDG.Size = new System.Drawing.Size(151, 29);
            this.lblMaDG.TabIndex = 1;
            this.lblMaDG.Text = "Mã Độc Giả:";
            // 
            // dtpNgayMuon
            // 
            this.dtpNgayMuon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtpNgayMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayMuon.Location = new System.Drawing.Point(163, 230);
            this.dtpNgayMuon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpNgayMuon.Name = "dtpNgayMuon";
            this.dtpNgayMuon.Size = new System.Drawing.Size(244, 26);
            this.dtpNgayMuon.TabIndex = 9;
            // 
            // lblNgayMuon
            // 
            this.lblNgayMuon.AutoSize = true;
            this.lblNgayMuon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblNgayMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayMuon.Location = new System.Drawing.Point(4, 231);
            this.lblNgayMuon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayMuon.Name = "lblNgayMuon";
            this.lblNgayMuon.Padding = new System.Windows.Forms.Padding(0, 0, 0, 9);
            this.lblNgayMuon.Size = new System.Drawing.Size(151, 29);
            this.lblNgayMuon.TabIndex = 3;
            this.lblNgayMuon.Text = "Ngày Mượn:";
            // 
            // lblTenDG
            // 
            this.lblTenDG.AutoSize = true;
            this.lblTenDG.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTenDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDG.Location = new System.Drawing.Point(4, 166);
            this.lblTenDG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenDG.Name = "lblTenDG";
            this.lblTenDG.Padding = new System.Windows.Forms.Padding(0, 0, 0, 9);
            this.lblTenDG.Size = new System.Drawing.Size(151, 29);
            this.lblTenDG.TabIndex = 2;
            this.lblTenDG.Text = "Tên Độc Giả:";
            // 
            // lblNgayTra
            // 
            this.lblNgayTra.AutoSize = true;
            this.lblNgayTra.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblNgayTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayTra.Location = new System.Drawing.Point(4, 298);
            this.lblNgayTra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayTra.Name = "lblNgayTra";
            this.lblNgayTra.Padding = new System.Windows.Forms.Padding(0, 0, 0, 9);
            this.lblNgayTra.Size = new System.Drawing.Size(151, 29);
            this.lblNgayTra.TabIndex = 4;
            this.lblNgayTra.Text = "Ngày Trả:";
            // 
            // txtMaPhieuMuon
            // 
            this.txtMaPhieuMuon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtMaPhieuMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhieuMuon.Location = new System.Drawing.Point(163, 35);
            this.txtMaPhieuMuon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaPhieuMuon.Name = "txtMaPhieuMuon";
            this.txtMaPhieuMuon.ReadOnly = true;
            this.txtMaPhieuMuon.Size = new System.Drawing.Size(244, 26);
            this.txtMaPhieuMuon.TabIndex = 5;
            // 
            // txtMaDG
            // 
            this.txtMaDG.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtMaDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDG.Location = new System.Drawing.Point(163, 100);
            this.txtMaDG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaDG.Name = "txtMaDG";
            this.txtMaDG.Size = new System.Drawing.Size(244, 26);
            this.txtMaDG.TabIndex = 6;
            this.txtMaDG.TextChanged += new System.EventHandler(this.txtMaDG_TextChanged);
            // 
            // txtTenDocGia
            // 
            this.txtTenDocGia.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtTenDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDocGia.Location = new System.Drawing.Point(163, 165);
            this.txtTenDocGia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenDocGia.Name = "txtTenDocGia";
            this.txtTenDocGia.ReadOnly = true;
            this.txtTenDocGia.Size = new System.Drawing.Size(244, 26);
            this.txtTenDocGia.TabIndex = 7;
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtpNgayTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTra.Location = new System.Drawing.Point(163, 297);
            this.dtpNgayTra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(244, 26);
            this.dtpNgayTra.TabIndex = 8;
            // 
            // lblChonSach
            // 
            this.lblChonSach.AutoSize = true;
            this.lblChonSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChonSach.ForeColor = System.Drawing.Color.Blue;
            this.lblChonSach.Location = new System.Drawing.Point(515, 12);
            this.lblChonSach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChonSach.Name = "lblChonSach";
            this.lblChonSach.Size = new System.Drawing.Size(153, 31);
            this.lblChonSach.TabIndex = 3;
            this.lblChonSach.Text = "Chọn sách";
            // 
            // dgvChonSach
            // 
            this.dgvChonSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChonSach.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChonSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChonSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChonSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSach,
            this.colTenSach,
            this.colSoLuongCon});
            this.dgvChonSach.EnableHeadersVisualStyles = false;
            this.dgvChonSach.Location = new System.Drawing.Point(521, 47);
            this.dgvChonSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvChonSach.Name = "dgvChonSach";
            this.dgvChonSach.RowHeadersWidth = 51;
            this.dgvChonSach.Size = new System.Drawing.Size(848, 261);
            this.dgvChonSach.TabIndex = 5;
            this.dgvChonSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChonSach_CellClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.77778F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.22222F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 249F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tableLayoutPanel2.Controls.Add(this.txtTenSach, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.nudSoLuong, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblTenSach, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblSoLuong, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblMaSach, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtMaSach, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnThemSach, 5, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(7, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(848, 106);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSach.Location = new System.Drawing.Point(352, 23);
            this.txtTenSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.ReadOnly = true;
            this.txtTenSach.Size = new System.Drawing.Size(241, 26);
            this.txtTenSach.TabIndex = 12;
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nudSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSoLuong.Location = new System.Drawing.Point(712, 23);
            this.nudSoLuong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(132, 26);
            this.nudSoLuong.TabIndex = 11;
            // 
            // lblTenSach
            // 
            this.lblTenSach.AutoSize = true;
            this.lblTenSach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSach.Location = new System.Drawing.Point(243, 24);
            this.lblTenSach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenSach.Name = "lblTenSach";
            this.lblTenSach.Padding = new System.Windows.Forms.Padding(0, 0, 0, 9);
            this.lblTenSach.Size = new System.Drawing.Size(101, 29);
            this.lblTenSach.TabIndex = 10;
            this.lblTenSach.Text = "Tên Sách:";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(601, 24);
            this.lblSoLuong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Padding = new System.Windows.Forms.Padding(0, 0, 0, 9);
            this.lblSoLuong.Size = new System.Drawing.Size(103, 29);
            this.lblSoLuong.TabIndex = 9;
            this.lblSoLuong.Text = "Số Lượng:";
            // 
            // lblMaSach
            // 
            this.lblMaSach.AutoSize = true;
            this.lblMaSach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSach.Location = new System.Drawing.Point(4, 24);
            this.lblMaSach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaSach.Name = "lblMaSach";
            this.lblMaSach.Padding = new System.Windows.Forms.Padding(0, 0, 0, 9);
            this.lblMaSach.Size = new System.Drawing.Size(94, 29);
            this.lblMaSach.TabIndex = 0;
            this.lblMaSach.Text = "Mã Sách:";
            // 
            // txtMaSach
            // 
            this.txtMaSach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtMaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSach.Location = new System.Drawing.Point(106, 23);
            this.txtMaSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(129, 26);
            this.txtMaSach.TabIndex = 3;
            this.txtMaSach.TextChanged += new System.EventHandler(this.txtMaSach_TextChanged);
            // 
            // btnThemSach
            // 
            this.btnThemSach.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnThemSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThemSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSach.ForeColor = System.Drawing.Color.White;
            this.btnThemSach.Location = new System.Drawing.Point(712, 57);
            this.btnThemSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.Size = new System.Drawing.Size(132, 45);
            this.btnThemSach.TabIndex = 13;
            this.btnThemSach.Text = "Thêm Sách";
            this.btnThemSach.UseVisualStyleBackColor = false;
            this.btnThemSach.Click += new System.EventHandler(this.btnThemSach_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(17, 47);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(461, 382);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // lblDanhSachSachMuon
            // 
            this.lblDanhSachSachMuon.AutoSize = true;
            this.lblDanhSachSachMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhSachSachMuon.ForeColor = System.Drawing.Color.Blue;
            this.lblDanhSachSachMuon.Location = new System.Drawing.Point(19, 447);
            this.lblDanhSachSachMuon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDanhSachSachMuon.Name = "lblDanhSachSachMuon";
            this.lblDanhSachSachMuon.Size = new System.Drawing.Size(302, 31);
            this.lblDanhSachSachMuon.TabIndex = 8;
            this.lblDanhSachSachMuon.Text = "Danh sách sách mượn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Location = new System.Drawing.Point(511, 313);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(863, 116);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.btnXoaSachMuon, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnHuyPhieu, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnLapPhieuMuon, 0, 0);
            this.tableLayoutPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1171, 481);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(199, 353);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // btnXoaSachMuon
            // 
            this.btnXoaSachMuon.BackColor = System.Drawing.Color.IndianRed;
            this.btnXoaSachMuon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXoaSachMuon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaSachMuon.ForeColor = System.Drawing.Color.White;
            this.btnXoaSachMuon.Location = new System.Drawing.Point(4, 238);
            this.btnXoaSachMuon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoaSachMuon.Name = "btnXoaSachMuon";
            this.btnXoaSachMuon.Size = new System.Drawing.Size(191, 111);
            this.btnXoaSachMuon.TabIndex = 2;
            this.btnXoaSachMuon.Text = "Xóa Sách Mượn";
            this.btnXoaSachMuon.UseVisualStyleBackColor = false;
            this.btnXoaSachMuon.Click += new System.EventHandler(this.btnXoaSachMuon_Click);
            // 
            // btnHuyPhieu
            // 
            this.btnHuyPhieu.BackColor = System.Drawing.Color.SlateGray;
            this.btnHuyPhieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHuyPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyPhieu.ForeColor = System.Drawing.Color.White;
            this.btnHuyPhieu.Location = new System.Drawing.Point(4, 121);
            this.btnHuyPhieu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHuyPhieu.Name = "btnHuyPhieu";
            this.btnHuyPhieu.Size = new System.Drawing.Size(191, 109);
            this.btnHuyPhieu.TabIndex = 1;
            this.btnHuyPhieu.Text = "Hủy Phiếu";
            this.btnHuyPhieu.UseVisualStyleBackColor = false;
            this.btnHuyPhieu.Click += new System.EventHandler(this.btnHuyPhieu_Click);
            // 
            // btnLapPhieuMuon
            // 
            this.btnLapPhieuMuon.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLapPhieuMuon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLapPhieuMuon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLapPhieuMuon.ForeColor = System.Drawing.Color.White;
            this.btnLapPhieuMuon.Location = new System.Drawing.Point(4, 4);
            this.btnLapPhieuMuon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLapPhieuMuon.Name = "btnLapPhieuMuon";
            this.btnLapPhieuMuon.Size = new System.Drawing.Size(191, 109);
            this.btnLapPhieuMuon.TabIndex = 0;
            this.btnLapPhieuMuon.Text = "Lập Phiếu Mượn";
            this.btnLapPhieuMuon.UseVisualStyleBackColor = false;
            this.btnLapPhieuMuon.Click += new System.EventHandler(this.btnLapPhieuMuon_Click);
            // 
            // dgvDanhSachSachMuon
            // 
            this.dgvDanhSachSachMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachSachMuon.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachSachMuon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDanhSachSachMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachSachMuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvDanhSachSachMuon.EnableHeadersVisualStyles = false;
            this.dgvDanhSachSachMuon.Location = new System.Drawing.Point(17, 481);
            this.dgvDanhSachSachMuon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDanhSachSachMuon.Name = "dgvDanhSachSachMuon";
            this.dgvDanhSachSachMuon.RowHeadersWidth = 51;
            this.dgvDanhSachSachMuon.Size = new System.Drawing.Size(1145, 353);
            this.dgvDanhSachSachMuon.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 50F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã Sách";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 99.49239F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Tên Sách";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.FillWeight = 50F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Số Lượng";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // colMaSach
            // 
            this.colMaSach.DataPropertyName = "MaSach";
            this.colMaSach.FillWeight = 50F;
            this.colMaSach.HeaderText = "Mã Sách";
            this.colMaSach.MinimumWidth = 6;
            this.colMaSach.Name = "colMaSach";
            // 
            // colTenSach
            // 
            this.colTenSach.DataPropertyName = "TenSach";
            this.colTenSach.FillWeight = 99.49239F;
            this.colTenSach.HeaderText = "Tên Sách";
            this.colTenSach.MinimumWidth = 6;
            this.colTenSach.Name = "colTenSach";
            // 
            // colSoLuongCon
            // 
            this.colSoLuongCon.DataPropertyName = "SoLuong";
            this.colSoLuongCon.FillWeight = 50F;
            this.colSoLuongCon.HeaderText = "Số Lượng Còn";
            this.colSoLuongCon.MinimumWidth = 6;
            this.colSoLuongCon.Name = "colSoLuongCon";
            // 
            // UC_MuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.dgvDanhSachSachMuon);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblDanhSachSachMuon);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvChonSach);
            this.Controls.Add(this.lblChonSach);
            this.Controls.Add(this.lblThongTin);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UC_MuonSach";
            this.Size = new System.Drawing.Size(1373, 838);
            this.Load += new System.EventHandler(this.UC_MuonSach_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChonSach)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSachMuon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblMaPhieuMuon;
        private System.Windows.Forms.Label lblMaDG;
        private System.Windows.Forms.TextBox txtMaPhieuMuon;
        private System.Windows.Forms.TextBox txtMaDG;
        private System.Windows.Forms.DateTimePicker dtpNgayMuon;
        private System.Windows.Forms.Label lblNgayMuon;
        private System.Windows.Forms.Label lblTenDG;
        private System.Windows.Forms.Label lblNgayTra;
        private System.Windows.Forms.TextBox txtTenDocGia;
        private System.Windows.Forms.DateTimePicker dtpNgayTra;
        private System.Windows.Forms.Label lblChonSach;
        private System.Windows.Forms.DataGridView dgvChonSach;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblMaSach;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label lblTenSach;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.Button btnThemSach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDanhSachSachMuon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnXoaSachMuon;
        private System.Windows.Forms.Button btnHuyPhieu;
        private System.Windows.Forms.Button btnLapPhieuMuon;
        private System.Windows.Forms.DataGridView dgvDanhSachSachMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuongCon;
    }
}
