namespace QuanLyMuonTraSach
{
    partial class Form_NhaXuatBan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenNXB = new System.Windows.Forms.TextBox();
            this.txtMaNXB = new System.Windows.Forms.TextBox();
            this.txtTimKien = new System.Windows.Forms.TextBox();
            this.panelHeThong = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvNhaXB = new System.Windows.Forms.DataGridView();
            this.btnXoaN = new FontAwesome.Sharp.IconButton();
            this.btnCN = new FontAwesome.Sharp.IconButton();
            this.btnLuuu = new FontAwesome.Sharp.IconButton();
            this.btnTaoM = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaXB)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1648, 103);
            this.panel1.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(427, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "NHÀ XUẤT BẢN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(363, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "HỆ THỐNG QUẢN LÝ THƯ VIỆN";
            // 
            // txtTenNXB
            // 
            this.txtTenNXB.Location = new System.Drawing.Point(1058, 132);
            this.txtTenNXB.Multiline = true;
            this.txtTenNXB.Name = "txtTenNXB";
            this.txtTenNXB.Size = new System.Drawing.Size(343, 41);
            this.txtTenNXB.TabIndex = 95;
            // 
            // txtMaNXB
            // 
            this.txtMaNXB.Location = new System.Drawing.Point(298, 132);
            this.txtMaNXB.Multiline = true;
            this.txtMaNXB.Name = "txtMaNXB";
            this.txtMaNXB.Size = new System.Drawing.Size(343, 41);
            this.txtMaNXB.TabIndex = 94;
            // 
            // txtTimKien
            // 
            this.txtTimKien.Location = new System.Drawing.Point(100, 26);
            this.txtTimKien.Multiline = true;
            this.txtTimKien.Name = "txtTimKien";
            this.txtTimKien.Size = new System.Drawing.Size(693, 46);
            this.txtTimKien.TabIndex = 94;
            this.txtTimKien.TextChanged += new System.EventHandler(this.txtTimKien_TextChanged);
            // 
            // panelHeThong
            // 
            this.panelHeThong.Location = new System.Drawing.Point(276, -328);
            this.panelHeThong.Name = "panelHeThong";
            this.panelHeThong.Size = new System.Drawing.Size(230, 82);
            this.panelHeThong.TabIndex = 95;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTimKien);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(390, 231);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(834, 93);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 35);
            this.label3.TabIndex = 64;
            this.label3.Text = "Mã Nhà Xuất Bản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(762, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 35);
            this.label4.TabIndex = 65;
            this.label4.Text = "Tên Nhà Xuất Bản";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 850);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1648, 15);
            this.panel2.TabIndex = 67;
            // 
            // dgvNhaXB
            // 
            this.dgvNhaXB.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvNhaXB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhaXB.Location = new System.Drawing.Point(337, 485);
            this.dgvNhaXB.Name = "dgvNhaXB";
            this.dgvNhaXB.RowHeadersWidth = 51;
            this.dgvNhaXB.RowTemplate.Height = 24;
            this.dgvNhaXB.Size = new System.Drawing.Size(802, 331);
            this.dgvNhaXB.TabIndex = 96;
            this.dgvNhaXB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhaXB_CellContentClick);
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
            this.btnXoaN.Location = new System.Drawing.Point(1099, 373);
            this.btnXoaN.Name = "btnXoaN";
            this.btnXoaN.Size = new System.Drawing.Size(157, 51);
            this.btnXoaN.TabIndex = 262;
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
            this.btnCN.Location = new System.Drawing.Point(684, 373);
            this.btnCN.Name = "btnCN";
            this.btnCN.Size = new System.Drawing.Size(157, 51);
            this.btnCN.TabIndex = 261;
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
            this.btnLuuu.Location = new System.Drawing.Point(337, 373);
            this.btnLuuu.Name = "btnLuuu";
            this.btnLuuu.Size = new System.Drawing.Size(157, 51);
            this.btnLuuu.TabIndex = 260;
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
            this.btnTaoM.Location = new System.Drawing.Point(37, 373);
            this.btnTaoM.Name = "btnTaoM";
            this.btnTaoM.Size = new System.Drawing.Size(157, 51);
            this.btnTaoM.TabIndex = 259;
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
            this.btnClose.Location = new System.Drawing.Point(1455, 373);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(157, 51);
            this.btnClose.TabIndex = 258;
            this.btnClose.Text = "Đóng";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // NhaXuatBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1648, 865);
            this.Controls.Add(this.btnXoaN);
            this.Controls.Add(this.btnCN);
            this.Controls.Add(this.btnLuuu);
            this.Controls.Add(this.btnTaoM);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panelHeThong);
            this.Controls.Add(this.dgvNhaXB);
            this.Controls.Add(this.txtTenNXB);
            this.Controls.Add(this.txtMaNXB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "NhaXuatBan";
            this.Text = "NhaXuatBan";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaXB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenNXB;
        private System.Windows.Forms.TextBox txtMaNXB;
        private System.Windows.Forms.TextBox txtTimKien;
        private System.Windows.Forms.Panel panelHeThong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvNhaXB;
        private FontAwesome.Sharp.IconButton btnXoaN;
        private FontAwesome.Sharp.IconButton btnCN;
        private FontAwesome.Sharp.IconButton btnLuuu;
        private FontAwesome.Sharp.IconButton btnTaoM;
        private FontAwesome.Sharp.IconButton btnClose;
    }
}