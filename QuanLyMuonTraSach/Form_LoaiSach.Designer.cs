namespace QuanLyMuonTraSach
{
    partial class Form_LoaiSach
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
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaLoaiSach = new System.Windows.Forms.TextBox();
            this.txtTenLoaiSach = new System.Windows.Forms.TextBox();
            this.dgvLoaiSach = new System.Windows.Forms.DataGridView();
            this.btnXoaN = new FontAwesome.Sharp.IconButton();
            this.btnCN = new FontAwesome.Sharp.IconButton();
            this.btnLuuu = new FontAwesome.Sharp.IconButton();
            this.btnTaoM = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSach)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(332, 178);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(757, 101);
            this.groupBox1.TabIndex = 91;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(103, 26);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(595, 46);
            this.txtTimKiem.TabIndex = 93;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 856);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1656, 15);
            this.panel2.TabIndex = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(541, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "HỆ THỐNG QUẢN LÝ THƯ VIỆN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(672, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 28);
            this.label4.TabIndex = 82;
            this.label4.Text = "Tên Loại Sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(66, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 35);
            this.label3.TabIndex = 81;
            this.label3.Text = "Mã Loại sách";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1656, 103);
            this.panel1.TabIndex = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(637, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "LOẠI SÁCH";
            // 
            // txtMaLoaiSach
            // 
            this.txtMaLoaiSach.Location = new System.Drawing.Point(291, 107);
            this.txtMaLoaiSach.Multiline = true;
            this.txtMaLoaiSach.Name = "txtMaLoaiSach";
            this.txtMaLoaiSach.Size = new System.Drawing.Size(315, 34);
            this.txtMaLoaiSach.TabIndex = 92;
            // 
            // txtTenLoaiSach
            // 
            this.txtTenLoaiSach.Location = new System.Drawing.Point(906, 108);
            this.txtTenLoaiSach.Multiline = true;
            this.txtTenLoaiSach.Name = "txtTenLoaiSach";
            this.txtTenLoaiSach.Size = new System.Drawing.Size(315, 34);
            this.txtTenLoaiSach.TabIndex = 93;
            // 
            // dgvLoaiSach
            // 
            this.dgvLoaiSach.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLoaiSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiSach.Location = new System.Drawing.Point(384, 421);
            this.dgvLoaiSach.Name = "dgvLoaiSach";
            this.dgvLoaiSach.RowHeadersWidth = 51;
            this.dgvLoaiSach.RowTemplate.Height = 24;
            this.dgvLoaiSach.Size = new System.Drawing.Size(802, 430);
            this.dgvLoaiSach.TabIndex = 95;
            this.dgvLoaiSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiSach_CellContentClick);
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
            this.btnXoaN.Location = new System.Drawing.Point(1105, 330);
            this.btnXoaN.Name = "btnXoaN";
            this.btnXoaN.Size = new System.Drawing.Size(157, 51);
            this.btnXoaN.TabIndex = 257;
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
            this.btnCN.Location = new System.Drawing.Point(690, 330);
            this.btnCN.Name = "btnCN";
            this.btnCN.Size = new System.Drawing.Size(157, 51);
            this.btnCN.TabIndex = 256;
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
            this.btnLuuu.Location = new System.Drawing.Point(343, 330);
            this.btnLuuu.Name = "btnLuuu";
            this.btnLuuu.Size = new System.Drawing.Size(157, 51);
            this.btnLuuu.TabIndex = 255;
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
            this.btnTaoM.Location = new System.Drawing.Point(43, 330);
            this.btnTaoM.Name = "btnTaoM";
            this.btnTaoM.Size = new System.Drawing.Size(157, 51);
            this.btnTaoM.TabIndex = 254;
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
            this.btnClose.Location = new System.Drawing.Point(1461, 330);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(157, 51);
            this.btnClose.TabIndex = 253;
            this.btnClose.Text = "Đóng";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // LoaiSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1656, 871);
            this.Controls.Add(this.btnXoaN);
            this.Controls.Add(this.btnCN);
            this.Controls.Add(this.btnLuuu);
            this.Controls.Add(this.btnTaoM);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvLoaiSach);
            this.Controls.Add(this.txtTenLoaiSach);
            this.Controls.Add(this.txtMaLoaiSach);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "LoaiSach";
            this.Text = "LoaiSach";
            this.Load += new System.EventHandler(this.LoaiSach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.TextBox txtMaLoaiSach;
        private System.Windows.Forms.TextBox txtTenLoaiSach;
        private System.Windows.Forms.DataGridView dgvLoaiSach;
        private FontAwesome.Sharp.IconButton btnXoaN;
        private FontAwesome.Sharp.IconButton btnCN;
        private FontAwesome.Sharp.IconButton btnLuuu;
        private FontAwesome.Sharp.IconButton btnTaoM;
        private FontAwesome.Sharp.IconButton btnClose;
    }
}