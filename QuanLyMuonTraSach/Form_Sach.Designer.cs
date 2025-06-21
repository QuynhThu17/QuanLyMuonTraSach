namespace QuanLyMuonTraSach
{
    partial class Form_Sach
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TimKiem = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.cbbTacGia = new System.Windows.Forms.ComboBox();
            this.cbbNhaXuatban = new System.Windows.Forms.ComboBox();
            this.cbbLoaiSach = new System.Windows.Forms.ComboBox();
            this.txtSoTrang = new System.Windows.Forms.TextBox();
            this.dgvSACH = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpTGPH = new System.Windows.Forms.DateTimePicker();
            this.nubGiaBan = new System.Windows.Forms.NumericUpDown();
            this.nubSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnXoaN = new FontAwesome.Sharp.IconButton();
            this.btnCN = new FontAwesome.Sharp.IconButton();
            this.btnLuuu = new FontAwesome.Sharp.IconButton();
            this.btnTaoM = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSACH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nubGiaBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nubSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TimKiem);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(627, 166);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(765, 82);
            this.groupBox1.TabIndex = 101;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            // 
            // TimKiem
            // 
            this.TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimKiem.Location = new System.Drawing.Point(98, 26);
            this.TimKiem.Multiline = true;
            this.TimKiem.Name = "TimKiem";
            this.TimKiem.Size = new System.Drawing.Size(628, 34);
            this.TimKiem.TabIndex = 110;
            this.TimKiem.TextChanged += new System.EventHandler(this.TimKiem_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(8, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 28);
            this.label11.TabIndex = 94;
            this.label11.Text = "Mã Sách";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(1159, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 28);
            this.label10.TabIndex = 93;
            this.label10.Text = "Số Trang";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(1152, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 28);
            this.label9.TabIndex = 92;
            this.label9.Text = "Loại Sách";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(843, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 28);
            this.label7.TabIndex = 91;
            this.label7.Text = "Số Lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(847, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 28);
            this.label6.TabIndex = 90;
            this.label6.Text = "Giá Bán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(357, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 28);
            this.label5.TabIndex = 89;
            this.label5.Text = "Nhà Xuất Bản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(418, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 28);
            this.label4.TabIndex = 88;
            this.label4.Text = "Tác Giả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(8, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 28);
            this.label3.TabIndex = 87;
            this.label3.Text = "Tên Sách";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 746);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1442, 19);
            this.panel2.TabIndex = 86;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSach.Location = new System.Drawing.Point(125, 34);
            this.txtMaSach.Multiline = true;
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(186, 34);
            this.txtMaSach.TabIndex = 102;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSach.Location = new System.Drawing.Point(125, 105);
            this.txtTenSach.Multiline = true;
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(186, 34);
            this.txtTenSach.TabIndex = 103;
            // 
            // cbbTacGia
            // 
            this.cbbTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTacGia.FormattingEnabled = true;
            this.cbbTacGia.Location = new System.Drawing.Point(538, 34);
            this.cbbTacGia.Name = "cbbTacGia";
            this.cbbTacGia.Size = new System.Drawing.Size(168, 28);
            this.cbbTacGia.TabIndex = 104;
            // 
            // cbbNhaXuatban
            // 
            this.cbbNhaXuatban.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNhaXuatban.FormattingEnabled = true;
            this.cbbNhaXuatban.Location = new System.Drawing.Point(538, 111);
            this.cbbNhaXuatban.Name = "cbbNhaXuatban";
            this.cbbNhaXuatban.Size = new System.Drawing.Size(168, 28);
            this.cbbNhaXuatban.TabIndex = 105;
            // 
            // cbbLoaiSach
            // 
            this.cbbLoaiSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLoaiSach.FormattingEnabled = true;
            this.cbbLoaiSach.Location = new System.Drawing.Point(1300, 115);
            this.cbbLoaiSach.Name = "cbbLoaiSach";
            this.cbbLoaiSach.Size = new System.Drawing.Size(136, 28);
            this.cbbLoaiSach.TabIndex = 106;
            // 
            // txtSoTrang
            // 
            this.txtSoTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTrang.Location = new System.Drawing.Point(1300, 37);
            this.txtSoTrang.Multiline = true;
            this.txtSoTrang.Name = "txtSoTrang";
            this.txtSoTrang.Size = new System.Drawing.Size(127, 34);
            this.txtSoTrang.TabIndex = 107;
            // 
            // dgvSACH
            // 
            this.dgvSACH.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSACH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSACH.Location = new System.Drawing.Point(33, 363);
            this.dgvSACH.Name = "dgvSACH";
            this.dgvSACH.RowHeadersWidth = 51;
            this.dgvSACH.RowTemplate.Height = 24;
            this.dgvSACH.Size = new System.Drawing.Size(1379, 350);
            this.dgvSACH.TabIndex = 110;
            this.dgvSACH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSACH_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(12, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 28);
            this.label8.TabIndex = 111;
            this.label8.Text = "Thời gian phát hành ";
            // 
            // dtpTGPH
            // 
            this.dtpTGPH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTGPH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTGPH.Location = new System.Drawing.Point(295, 181);
            this.dtpTGPH.Name = "dtpTGPH";
            this.dtpTGPH.Size = new System.Drawing.Size(159, 27);
            this.dtpTGPH.TabIndex = 112;
            // 
            // nubGiaBan
            // 
            this.nubGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nubGiaBan.Location = new System.Drawing.Point(977, 41);
            this.nubGiaBan.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nubGiaBan.Name = "nubGiaBan";
            this.nubGiaBan.Size = new System.Drawing.Size(71, 27);
            this.nubGiaBan.TabIndex = 114;
            // 
            // nubSoLuong
            // 
            this.nubSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nubSoLuong.Location = new System.Drawing.Point(977, 112);
            this.nubSoLuong.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nubSoLuong.Name = "nubSoLuong";
            this.nubSoLuong.Size = new System.Drawing.Size(71, 27);
            this.nubSoLuong.TabIndex = 115;
            // 
            // btnXoaN
            // 
            this.btnXoaN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoaN.BackColor = System.Drawing.Color.Teal;
            this.btnXoaN.FlatAppearance.BorderSize = 0;
            this.btnXoaN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnXoaN.ForeColor = System.Drawing.Color.White;
            this.btnXoaN.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnXoaN.IconColor = System.Drawing.Color.White;
            this.btnXoaN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoaN.IconSize = 30;
            this.btnXoaN.Location = new System.Drawing.Point(936, 268);
            this.btnXoaN.Name = "btnXoaN";
            this.btnXoaN.Size = new System.Drawing.Size(157, 51);
            this.btnXoaN.TabIndex = 252;
            this.btnXoaN.Text = "Xóa";
            this.btnXoaN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoaN.UseVisualStyleBackColor = false;
            this.btnXoaN.Click += new System.EventHandler(this.btnXoaN_Click);
            // 
            // btnCN
            // 
            this.btnCN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCN.BackColor = System.Drawing.Color.Teal;
            this.btnCN.FlatAppearance.BorderSize = 0;
            this.btnCN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCN.ForeColor = System.Drawing.Color.White;
            this.btnCN.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnCN.IconColor = System.Drawing.Color.White;
            this.btnCN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCN.IconSize = 30;
            this.btnCN.Location = new System.Drawing.Point(611, 268);
            this.btnCN.Name = "btnCN";
            this.btnCN.Size = new System.Drawing.Size(157, 51);
            this.btnCN.TabIndex = 251;
            this.btnCN.Text = "Cập nhật";
            this.btnCN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCN.UseVisualStyleBackColor = false;
            this.btnCN.Click += new System.EventHandler(this.btnCN_Click);
            // 
            // btnLuuu
            // 
            this.btnLuuu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLuuu.BackColor = System.Drawing.Color.Teal;
            this.btnLuuu.FlatAppearance.BorderSize = 0;
            this.btnLuuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLuuu.ForeColor = System.Drawing.Color.White;
            this.btnLuuu.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnLuuu.IconColor = System.Drawing.Color.White;
            this.btnLuuu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLuuu.IconSize = 30;
            this.btnLuuu.Location = new System.Drawing.Point(316, 268);
            this.btnLuuu.Name = "btnLuuu";
            this.btnLuuu.Size = new System.Drawing.Size(157, 51);
            this.btnLuuu.TabIndex = 250;
            this.btnLuuu.Text = "Lưu";
            this.btnLuuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuuu.UseVisualStyleBackColor = false;
            this.btnLuuu.Click += new System.EventHandler(this.btnLuuu_Click);
            // 
            // btnTaoM
            // 
            this.btnTaoM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTaoM.BackColor = System.Drawing.Color.Teal;
            this.btnTaoM.FlatAppearance.BorderSize = 0;
            this.btnTaoM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTaoM.ForeColor = System.Drawing.Color.White;
            this.btnTaoM.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnTaoM.IconColor = System.Drawing.Color.White;
            this.btnTaoM.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTaoM.IconSize = 30;
            this.btnTaoM.Location = new System.Drawing.Point(13, 268);
            this.btnTaoM.Name = "btnTaoM";
            this.btnTaoM.Size = new System.Drawing.Size(157, 51);
            this.btnTaoM.TabIndex = 249;
            this.btnTaoM.Text = "Tạo mới";
            this.btnTaoM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTaoM.UseVisualStyleBackColor = false;
            this.btnTaoM.Click += new System.EventHandler(this.btnTaoM_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClose.BackColor = System.Drawing.Color.Teal;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 30;
            this.btnClose.Location = new System.Drawing.Point(1255, 268);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(157, 51);
            this.btnClose.TabIndex = 248;
            this.btnClose.Text = "Đóng";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form_Sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1442, 765);
            this.Controls.Add(this.btnXoaN);
            this.Controls.Add(this.btnCN);
            this.Controls.Add(this.btnLuuu);
            this.Controls.Add(this.btnTaoM);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.nubSoLuong);
            this.Controls.Add(this.nubGiaBan);
            this.Controls.Add(this.dtpTGPH);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvSACH);
            this.Controls.Add(this.txtSoTrang);
            this.Controls.Add(this.cbbLoaiSach);
            this.Controls.Add(this.cbbNhaXuatban);
            this.Controls.Add(this.cbbTacGia);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.txtMaSach);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Name = "Form_Sach";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Sach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSACH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nubGiaBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nubSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TimKiem;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.ComboBox cbbTacGia;
        private System.Windows.Forms.ComboBox cbbNhaXuatban;
        private System.Windows.Forms.ComboBox cbbLoaiSach;
        private System.Windows.Forms.TextBox txtSoTrang;
        private System.Windows.Forms.DataGridView dgvSACH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpTGPH;
        private System.Windows.Forms.NumericUpDown nubGiaBan;
        private System.Windows.Forms.NumericUpDown nubSoLuong;
        private FontAwesome.Sharp.IconButton btnXoaN;
        private FontAwesome.Sharp.IconButton btnCN;
        private FontAwesome.Sharp.IconButton btnLuuu;
        private FontAwesome.Sharp.IconButton btnTaoM;
        private FontAwesome.Sharp.IconButton btnClose;
    }
}

