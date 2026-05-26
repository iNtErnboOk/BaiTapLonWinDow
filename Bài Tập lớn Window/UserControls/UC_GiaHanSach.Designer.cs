namespace Bài_Tập_lớn_Window.UserControls
{
    partial class UC_GiaHanSach
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDanhSachPhieuMuon = new System.Windows.Forms.DataGridView();
            this.colMaPhieuMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblThongTinGiaHan = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnHuyGiaHan = new System.Windows.Forms.Button();
            this.btnGiaHanSach = new System.Windows.Forms.Button();
            this.dtpGiaHanTra = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.lblGiaHanTra = new System.Windows.Forms.Label();
            this.txtTenDG = new System.Windows.Forms.TextBox();
            this.lblTenDG = new System.Windows.Forms.Label();
            this.lblNgayTra = new System.Windows.Forms.Label();
            this.txtMaDG = new System.Windows.Forms.TextBox();
            this.lblMaDG = new System.Windows.Forms.Label();
            this.lblNgayMuon = new System.Windows.Forms.Label();
            this.lblMaPhieuMuon = new System.Windows.Forms.Label();
            this.txtMaPhieuMuon = new System.Windows.Forms.TextBox();
            this.dtpNgayMuon = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhieuMuon)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDanhSachPhieuMuon
            // 
            this.dgvDanhSachPhieuMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachPhieuMuon.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachPhieuMuon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDanhSachPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachPhieuMuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaPhieuMuon,
            this.colMaDocGia,
            this.colTenDG,
            this.colNgayMuon,
            this.colNgayTra});
            this.dgvDanhSachPhieuMuon.EnableHeadersVisualStyles = false;
            this.dgvDanhSachPhieuMuon.Location = new System.Drawing.Point(48, 62);
            this.dgvDanhSachPhieuMuon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDanhSachPhieuMuon.Name = "dgvDanhSachPhieuMuon";
            this.dgvDanhSachPhieuMuon.RowHeadersWidth = 51;
            this.dgvDanhSachPhieuMuon.Size = new System.Drawing.Size(1279, 412);
            this.dgvDanhSachPhieuMuon.TabIndex = 9;
            this.dgvDanhSachPhieuMuon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachPhieuMuon_CellClick);
            this.dgvDanhSachPhieuMuon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachPhieuMuon_CellContentClick);
            // 
            // colMaPhieuMuon
            // 
            this.colMaPhieuMuon.DataPropertyName = "MaPhieuMuon";
            this.colMaPhieuMuon.FillWeight = 90F;
            this.colMaPhieuMuon.HeaderText = "Mã Phiếu Mượn";
            this.colMaPhieuMuon.MinimumWidth = 6;
            this.colMaPhieuMuon.Name = "colMaPhieuMuon";
            // 
            // colMaDocGia
            // 
            this.colMaDocGia.DataPropertyName = "MaDG";
            this.colMaDocGia.FillWeight = 80F;
            this.colMaDocGia.HeaderText = "Mã Độc Giả";
            this.colMaDocGia.MinimumWidth = 6;
            this.colMaDocGia.Name = "colMaDocGia";
            // 
            // colTenDG
            // 
            this.colTenDG.DataPropertyName = "TenDG";
            this.colTenDG.HeaderText = "Tên Độc Giả";
            this.colTenDG.MinimumWidth = 6;
            this.colTenDG.Name = "colTenDG";
            // 
            // colNgayMuon
            // 
            this.colNgayMuon.DataPropertyName = "NgayMuon";
            this.colNgayMuon.FillWeight = 60F;
            this.colNgayMuon.HeaderText = "Ngày Mượn";
            this.colNgayMuon.MinimumWidth = 6;
            this.colNgayMuon.Name = "colNgayMuon";
            // 
            // colNgayTra
            // 
            this.colNgayTra.DataPropertyName = "NgayTra";
            this.colNgayTra.FillWeight = 60F;
            this.colNgayTra.HeaderText = "Ngày Trả";
            this.colNgayTra.MinimumWidth = 6;
            this.colNgayTra.Name = "colNgayTra";
            // 
            // lblThongTinGiaHan
            // 
            this.lblThongTinGiaHan.AutoSize = true;
            this.lblThongTinGiaHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinGiaHan.ForeColor = System.Drawing.Color.Blue;
            this.lblThongTinGiaHan.Location = new System.Drawing.Point(41, 14);
            this.lblThongTinGiaHan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThongTinGiaHan.Name = "lblThongTinGiaHan";
            this.lblThongTinGiaHan.Size = new System.Drawing.Size(476, 31);
            this.lblThongTinGiaHan.TabIndex = 10;
            this.lblThongTinGiaHan.Text = "Thông tin phiếu mượn muốn gia hạn";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.02898F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.97102F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 185F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 187F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.tableLayoutPanel2.Controls.Add(this.btnHuyGiaHan, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnGiaHanSach, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.dtpGiaHanTra, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.dtpNgayTra, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblGiaHanTra, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtTenDG, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblTenDG, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblNgayTra, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtMaDG, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblMaDG, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblNgayMuon, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblMaPhieuMuon, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtMaPhieuMuon, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dtpNgayMuon, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(48, 513);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1037, 235);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // btnHuyGiaHan
            // 
            this.btnHuyGiaHan.BackColor = System.Drawing.Color.IndianRed;
            this.btnHuyGiaHan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHuyGiaHan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyGiaHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyGiaHan.ForeColor = System.Drawing.Color.White;
            this.btnHuyGiaHan.Location = new System.Drawing.Point(872, 82);
            this.btnHuyGiaHan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHuyGiaHan.Name = "btnHuyGiaHan";
            this.btnHuyGiaHan.Size = new System.Drawing.Size(161, 70);
            this.btnHuyGiaHan.TabIndex = 29;
            this.btnHuyGiaHan.Text = "Hủy Gia Hạn";
            this.btnHuyGiaHan.UseVisualStyleBackColor = false;
            this.btnHuyGiaHan.Click += new System.EventHandler(this.btnHuyGiaHan_Click);
            // 
            // btnGiaHanSach
            // 
            this.btnGiaHanSach.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnGiaHanSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGiaHanSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiaHanSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaHanSach.ForeColor = System.Drawing.Color.White;
            this.btnGiaHanSach.Location = new System.Drawing.Point(872, 4);
            this.btnGiaHanSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGiaHanSach.Name = "btnGiaHanSach";
            this.btnGiaHanSach.Size = new System.Drawing.Size(161, 70);
            this.btnGiaHanSach.TabIndex = 27;
            this.btnGiaHanSach.Text = "Gia Hạn Sách";
            this.btnGiaHanSach.UseVisualStyleBackColor = false;
            this.btnGiaHanSach.Click += new System.EventHandler(this.btnGiaHanSach_Click);
            // 
            // dtpGiaHanTra
            // 
            this.dtpGiaHanTra.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtpGiaHanTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpGiaHanTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpGiaHanTra.Location = new System.Drawing.Point(685, 205);
            this.dtpGiaHanTra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpGiaHanTra.Name = "dtpGiaHanTra";
            this.dtpGiaHanTra.Size = new System.Drawing.Size(179, 26);
            this.dtpGiaHanTra.TabIndex = 26;
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtpNgayTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTra.Location = new System.Drawing.Point(685, 126);
            this.dtpNgayTra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(179, 26);
            this.dtpNgayTra.TabIndex = 25;
            // 
            // lblGiaHanTra
            // 
            this.lblGiaHanTra.AutoSize = true;
            this.lblGiaHanTra.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblGiaHanTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaHanTra.Location = new System.Drawing.Point(500, 206);
            this.lblGiaHanTra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGiaHanTra.Name = "lblGiaHanTra";
            this.lblGiaHanTra.Padding = new System.Windows.Forms.Padding(0, 0, 0, 9);
            this.lblGiaHanTra.Size = new System.Drawing.Size(177, 29);
            this.lblGiaHanTra.TabIndex = 18;
            this.lblGiaHanTra.Text = "Gia Hạn Trả:";
            // 
            // txtTenDG
            // 
            this.txtTenDG.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtTenDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDG.Location = new System.Drawing.Point(212, 205);
            this.txtTenDG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenDG.Name = "txtTenDG";
            this.txtTenDG.ReadOnly = true;
            this.txtTenDG.Size = new System.Drawing.Size(280, 26);
            this.txtTenDG.TabIndex = 17;
            // 
            // lblTenDG
            // 
            this.lblTenDG.AutoSize = true;
            this.lblTenDG.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTenDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDG.Location = new System.Drawing.Point(4, 206);
            this.lblTenDG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenDG.Name = "lblTenDG";
            this.lblTenDG.Padding = new System.Windows.Forms.Padding(0, 0, 0, 9);
            this.lblTenDG.Size = new System.Drawing.Size(200, 29);
            this.lblTenDG.TabIndex = 16;
            this.lblTenDG.Text = "Tên Độc Giả:";
            // 
            // lblNgayTra
            // 
            this.lblNgayTra.AutoSize = true;
            this.lblNgayTra.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblNgayTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayTra.Location = new System.Drawing.Point(500, 127);
            this.lblNgayTra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayTra.Name = "lblNgayTra";
            this.lblNgayTra.Padding = new System.Windows.Forms.Padding(0, 0, 0, 9);
            this.lblNgayTra.Size = new System.Drawing.Size(177, 29);
            this.lblNgayTra.TabIndex = 12;
            this.lblNgayTra.Text = "Ngày Trả:";
            // 
            // txtMaDG
            // 
            this.txtMaDG.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtMaDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDG.Location = new System.Drawing.Point(212, 126);
            this.txtMaDG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaDG.Name = "txtMaDG";
            this.txtMaDG.ReadOnly = true;
            this.txtMaDG.Size = new System.Drawing.Size(280, 26);
            this.txtMaDG.TabIndex = 11;
            // 
            // lblMaDG
            // 
            this.lblMaDG.AutoSize = true;
            this.lblMaDG.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMaDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDG.Location = new System.Drawing.Point(4, 127);
            this.lblMaDG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaDG.Name = "lblMaDG";
            this.lblMaDG.Padding = new System.Windows.Forms.Padding(0, 0, 0, 9);
            this.lblMaDG.Size = new System.Drawing.Size(200, 29);
            this.lblMaDG.TabIndex = 10;
            this.lblMaDG.Text = "Mã Độc Giả:";
            // 
            // lblNgayMuon
            // 
            this.lblNgayMuon.AutoSize = true;
            this.lblNgayMuon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblNgayMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayMuon.Location = new System.Drawing.Point(500, 49);
            this.lblNgayMuon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayMuon.Name = "lblNgayMuon";
            this.lblNgayMuon.Padding = new System.Windows.Forms.Padding(0, 0, 0, 9);
            this.lblNgayMuon.Size = new System.Drawing.Size(177, 29);
            this.lblNgayMuon.TabIndex = 4;
            this.lblNgayMuon.Text = "Ngày Mượn:";
            // 
            // lblMaPhieuMuon
            // 
            this.lblMaPhieuMuon.AutoSize = true;
            this.lblMaPhieuMuon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMaPhieuMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPhieuMuon.Location = new System.Drawing.Point(4, 49);
            this.lblMaPhieuMuon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaPhieuMuon.Name = "lblMaPhieuMuon";
            this.lblMaPhieuMuon.Padding = new System.Windows.Forms.Padding(0, 0, 0, 9);
            this.lblMaPhieuMuon.Size = new System.Drawing.Size(200, 29);
            this.lblMaPhieuMuon.TabIndex = 0;
            this.lblMaPhieuMuon.Text = "Mã Phiếu Mượn:\r\n";
            // 
            // txtMaPhieuMuon
            // 
            this.txtMaPhieuMuon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtMaPhieuMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhieuMuon.Location = new System.Drawing.Point(212, 48);
            this.txtMaPhieuMuon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaPhieuMuon.Name = "txtMaPhieuMuon";
            this.txtMaPhieuMuon.Size = new System.Drawing.Size(280, 26);
            this.txtMaPhieuMuon.TabIndex = 3;
            this.txtMaPhieuMuon.TextChanged += new System.EventHandler(this.txtMaPhieuMuon_TextChanged);
            // 
            // dtpNgayMuon
            // 
            this.dtpNgayMuon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtpNgayMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayMuon.Location = new System.Drawing.Point(685, 48);
            this.dtpNgayMuon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpNgayMuon.Name = "dtpNgayMuon";
            this.dtpNgayMuon.Size = new System.Drawing.Size(179, 26);
            this.dtpNgayMuon.TabIndex = 24;
            // 
            // UC_GiaHanSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.lblThongTinGiaHan);
            this.Controls.Add(this.dgvDanhSachPhieuMuon);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UC_GiaHanSach";
            this.Size = new System.Drawing.Size(1373, 838);
            this.Load += new System.EventHandler(this.UC_GiaHanSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhieuMuon)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhSachPhieuMuon;
        private System.Windows.Forms.Label lblThongTinGiaHan;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DateTimePicker dtpGiaHanTra;
        private System.Windows.Forms.DateTimePicker dtpNgayTra;
        private System.Windows.Forms.Label lblGiaHanTra;
        private System.Windows.Forms.TextBox txtTenDG;
        private System.Windows.Forms.Label lblTenDG;
        private System.Windows.Forms.Label lblNgayTra;
        private System.Windows.Forms.TextBox txtMaDG;
        private System.Windows.Forms.Label lblMaDG;
        private System.Windows.Forms.Label lblNgayMuon;
        private System.Windows.Forms.Label lblMaPhieuMuon;
        private System.Windows.Forms.TextBox txtMaPhieuMuon;
        private System.Windows.Forms.DateTimePicker dtpNgayMuon;
        private System.Windows.Forms.Button btnHuyGiaHan;
        private System.Windows.Forms.Button btnGiaHanSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhieuMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayTra;
    }
}
