namespace QuanLyMuonTraSach
{
    partial class Form_LichSu
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLichSu = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPhucHoi = new FontAwesome.Sharp.IconButton();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.InBLP = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(489, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "LỊCH SỬ";
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
            // dgvLichSu
            // 
            this.dgvLichSu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLichSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichSu.Location = new System.Drawing.Point(24, 98);
            this.dgvLichSu.Name = "dgvLichSu";
            this.dgvLichSu.RowHeadersWidth = 51;
            this.dgvLichSu.RowTemplate.Height = 24;
            this.dgvLichSu.Size = new System.Drawing.Size(1626, 701);
            this.dgvLichSu.TabIndex = 265;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 861);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1662, 12);
            this.panel2.TabIndex = 261;
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
            this.panel1.Size = new System.Drawing.Size(1662, 82);
            this.panel1.TabIndex = 258;
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPhucHoi.BackColor = System.Drawing.Color.Teal;
            this.btnPhucHoi.FlatAppearance.BorderSize = 0;
            this.btnPhucHoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhucHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPhucHoi.ForeColor = System.Drawing.Color.White;
            this.btnPhucHoi.IconChar = FontAwesome.Sharp.IconChar.Rev;
            this.btnPhucHoi.IconColor = System.Drawing.Color.White;
            this.btnPhucHoi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPhucHoi.IconSize = 30;
            this.btnPhucHoi.Location = new System.Drawing.Point(987, 805);
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.Size = new System.Drawing.Size(202, 51);
            this.btnPhucHoi.TabIndex = 283;
            this.btnPhucHoi.Text = "Khôi phục ";
            this.btnPhucHoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPhucHoi.UseVisualStyleBackColor = false;
            this.btnPhucHoi.Click += new System.EventHandler(this.btnPhucHoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.BackColor = System.Drawing.Color.Teal;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnXoa.IconColor = System.Drawing.Color.White;
            this.btnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoa.IconSize = 30;
            this.btnXoa.Location = new System.Drawing.Point(1319, 805);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(202, 51);
            this.btnXoa.TabIndex = 284;
            this.btnXoa.Text = "Xóa ";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // InBLP
            // 
            this.InBLP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.InBLP.BackColor = System.Drawing.Color.Teal;
            this.InBLP.FlatAppearance.BorderSize = 0;
            this.InBLP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InBLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.InBLP.ForeColor = System.Drawing.Color.White;
            this.InBLP.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.InBLP.IconColor = System.Drawing.Color.White;
            this.InBLP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.InBLP.IconSize = 30;
            this.InBLP.Location = new System.Drawing.Point(689, 805);
            this.InBLP.Name = "InBLP";
            this.InBLP.Size = new System.Drawing.Size(202, 51);
            this.InBLP.TabIndex = 285;
            this.InBLP.Text = "In ";
            this.InBLP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.InBLP.UseVisualStyleBackColor = false;
            this.InBLP.Click += new System.EventHandler(this.InBLP_Click);
            // 
            // Form_LichSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1662, 873);
            this.Controls.Add(this.InBLP);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnPhucHoi);
            this.Controls.Add(this.dgvLichSu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form_LichSu";
            this.Text = "FormLichSu";
            this.Load += new System.EventHandler(this.FormLichSu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLichSu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnPhucHoi;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton InBLP;
    }
}