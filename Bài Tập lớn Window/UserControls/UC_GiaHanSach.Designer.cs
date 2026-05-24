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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDanhSachPhieuMuon = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaPhieuMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThaiTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblThongTinGiaHan = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
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
            this.btnGiaHanSach = new System.Windows.Forms.Button();
            this.btnHuyGiaHan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhieuMuon)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
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
            this.dgvDanhSachPhieuMuon.Location = new System.Drawing.Point(36, 50);
            this.dgvDanhSachPhieuMuon.Name = "dgvDanhSachPhieuMuon";
            this.dgvDanhSachPhieuMuon.Size = new System.Drawing.Size(959, 335);
            this.dgvDanhSachPhieuMuon.TabIndex = 9;
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
            this.colTrangThaiTra.HeaderText = "Gia Hạn Trả";
            this.colTrangThaiTra.Name = "colTrangThaiTra";
            // 
            // lblThongTinGiaHan
            // 
            this.lblThongTinGiaHan.AutoSize = true;
            this.lblThongTinGiaHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinGiaHan.ForeColor = System.Drawing.Color.Blue;
            this.lblThongTinGiaHan.Location = new System.Drawing.Point(31, 11);
            this.lblThongTinGiaHan.Name = "lblThongTinGiaHan";
            this.lblThongTinGiaHan.Size = new System.Drawing.Size(389, 25);
            this.lblThongTinGiaHan.TabIndex = 10;
            this.lblThongTinGiaHan.Text = "Thông tin phiếu mượn muốn gia hạn";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.02898F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.97102F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(36, 417);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(778, 191);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // dtpGiaHanTra
            // 
            this.dtpGiaHanTra.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtpGiaHanTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpGiaHanTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpGiaHanTra.Location = new System.Drawing.Point(516, 166);
            this.dtpGiaHanTra.Name = "dtpGiaHanTra";
            this.dtpGiaHanTra.Size = new System.Drawing.Size(134, 22);
            this.dtpGiaHanTra.TabIndex = 26;
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtpNgayTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTra.Location = new System.Drawing.Point(516, 101);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(134, 22);
            this.dtpNgayTra.TabIndex = 25;
            // 
            // lblGiaHanTra
            // 
            this.lblGiaHanTra.AutoSize = true;
            this.lblGiaHanTra.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblGiaHanTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaHanTra.Location = new System.Drawing.Point(377, 168);
            this.lblGiaHanTra.Name = "lblGiaHanTra";
            this.lblGiaHanTra.Padding = new System.Windows.Forms.Padding(0, 0, 0, 7);
            this.lblGiaHanTra.Size = new System.Drawing.Size(133, 23);
            this.lblGiaHanTra.TabIndex = 18;
            this.lblGiaHanTra.Text = "Gia Hạn Trả:";
            // 
            // txtTenDG
            // 
            this.txtTenDG.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtTenDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDG.Location = new System.Drawing.Point(160, 166);
            this.txtTenDG.Name = "txtTenDG";
            this.txtTenDG.ReadOnly = true;
            this.txtTenDG.Size = new System.Drawing.Size(211, 22);
            this.txtTenDG.TabIndex = 17;
            // 
            // lblTenDG
            // 
            this.lblTenDG.AutoSize = true;
            this.lblTenDG.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTenDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDG.Location = new System.Drawing.Point(3, 168);
            this.lblTenDG.Name = "lblTenDG";
            this.lblTenDG.Padding = new System.Windows.Forms.Padding(0, 0, 0, 7);
            this.lblTenDG.Size = new System.Drawing.Size(151, 23);
            this.lblTenDG.TabIndex = 16;
            this.lblTenDG.Text = "Tên Độc Giả:";
            // 
            // lblNgayTra
            // 
            this.lblNgayTra.AutoSize = true;
            this.lblNgayTra.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblNgayTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayTra.Location = new System.Drawing.Point(377, 103);
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
            this.txtMaDG.Location = new System.Drawing.Point(160, 101);
            this.txtMaDG.Name = "txtMaDG";
            this.txtMaDG.ReadOnly = true;
            this.txtMaDG.Size = new System.Drawing.Size(211, 22);
            this.txtMaDG.TabIndex = 11;
            // 
            // lblMaDG
            // 
            this.lblMaDG.AutoSize = true;
            this.lblMaDG.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMaDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDG.Location = new System.Drawing.Point(3, 103);
            this.lblMaDG.Name = "lblMaDG";
            this.lblMaDG.Padding = new System.Windows.Forms.Padding(0, 0, 0, 7);
            this.lblMaDG.Size = new System.Drawing.Size(151, 23);
            this.lblMaDG.TabIndex = 10;
            this.lblMaDG.Text = "Mã Độc Giả:";
            // 
            // lblNgayMuon
            // 
            this.lblNgayMuon.AutoSize = true;
            this.lblNgayMuon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblNgayMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayMuon.Location = new System.Drawing.Point(377, 40);
            this.lblNgayMuon.Name = "lblNgayMuon";
            this.lblNgayMuon.Padding = new System.Windows.Forms.Padding(0, 0, 0, 7);
            this.lblNgayMuon.Size = new System.Drawing.Size(133, 23);
            this.lblNgayMuon.TabIndex = 4;
            this.lblNgayMuon.Text = "Ngày Mượn:";
            // 
            // lblMaPhieuMuon
            // 
            this.lblMaPhieuMuon.AutoSize = true;
            this.lblMaPhieuMuon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMaPhieuMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPhieuMuon.Location = new System.Drawing.Point(3, 40);
            this.lblMaPhieuMuon.Name = "lblMaPhieuMuon";
            this.lblMaPhieuMuon.Padding = new System.Windows.Forms.Padding(0, 0, 0, 7);
            this.lblMaPhieuMuon.Size = new System.Drawing.Size(151, 23);
            this.lblMaPhieuMuon.TabIndex = 0;
            this.lblMaPhieuMuon.Text = "Mã Phiếu Mượn:\r\n";
            // 
            // txtMaPhieuMuon
            // 
            this.txtMaPhieuMuon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtMaPhieuMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhieuMuon.Location = new System.Drawing.Point(160, 38);
            this.txtMaPhieuMuon.Name = "txtMaPhieuMuon";
            this.txtMaPhieuMuon.Size = new System.Drawing.Size(211, 22);
            this.txtMaPhieuMuon.TabIndex = 3;
            // 
            // dtpNgayMuon
            // 
            this.dtpNgayMuon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtpNgayMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayMuon.Location = new System.Drawing.Point(516, 38);
            this.dtpNgayMuon.Name = "dtpNgayMuon";
            this.dtpNgayMuon.Size = new System.Drawing.Size(134, 22);
            this.dtpNgayMuon.TabIndex = 24;
            // 
            // btnGiaHanSach
            // 
            this.btnGiaHanSach.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnGiaHanSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGiaHanSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiaHanSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaHanSach.ForeColor = System.Drawing.Color.White;
            this.btnGiaHanSach.Location = new System.Drawing.Point(656, 3);
            this.btnGiaHanSach.Name = "btnGiaHanSach";
            this.btnGiaHanSach.Size = new System.Drawing.Size(119, 57);
            this.btnGiaHanSach.TabIndex = 27;
            this.btnGiaHanSach.Text = "Gia Hạn Sách";
            this.btnGiaHanSach.UseVisualStyleBackColor = false;
            // 
            // btnHuyGiaHan
            // 
            this.btnHuyGiaHan.BackColor = System.Drawing.Color.IndianRed;
            this.btnHuyGiaHan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHuyGiaHan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyGiaHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyGiaHan.ForeColor = System.Drawing.Color.White;
            this.btnHuyGiaHan.Location = new System.Drawing.Point(656, 66);
            this.btnHuyGiaHan.Name = "btnHuyGiaHan";
            this.btnHuyGiaHan.Size = new System.Drawing.Size(119, 57);
            this.btnHuyGiaHan.TabIndex = 29;
            this.btnHuyGiaHan.Text = "Hủy Gia Hạn";
            this.btnHuyGiaHan.UseVisualStyleBackColor = false;
            // 
            // UC_GiaHanSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.lblThongTinGiaHan);
            this.Controls.Add(this.dgvDanhSachPhieuMuon);
            this.Name = "UC_GiaHanSach";
            this.Size = new System.Drawing.Size(1030, 681);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhieuMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThaiTra;
        private System.Windows.Forms.Button btnHuyGiaHan;
        private System.Windows.Forms.Button btnGiaHanSach;
    }
}
