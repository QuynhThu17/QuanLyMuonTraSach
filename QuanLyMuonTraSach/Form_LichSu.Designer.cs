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
            this.dgvLichSu = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPhucHoi = new FontAwesome.Sharp.IconButton();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.InBLP = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLichSu
            // 
            this.dgvLichSu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLichSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichSu.Location = new System.Drawing.Point(12, 12);
            this.dgvLichSu.Name = "dgvLichSu";
            this.dgvLichSu.RowHeadersWidth = 51;
            this.dgvLichSu.RowTemplate.Height = 24;
            this.dgvLichSu.Size = new System.Drawing.Size(1425, 672);
            this.dgvLichSu.TabIndex = 265;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 746);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1437, 19);
            this.panel2.TabIndex = 261;
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
            this.btnPhucHoi.Location = new System.Drawing.Point(970, 690);
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.Size = new System.Drawing.Size(145, 51);
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
            this.btnXoa.Location = new System.Drawing.Point(1252, 690);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(116, 51);
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
            this.InBLP.Location = new System.Drawing.Point(1121, 690);
            this.InBLP.Name = "InBLP";
            this.InBLP.Size = new System.Drawing.Size(125, 51);
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
            this.ClientSize = new System.Drawing.Size(1437, 765);
            this.Controls.Add(this.InBLP);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnPhucHoi);
            this.Controls.Add(this.dgvLichSu);
            this.Controls.Add(this.panel2);
            this.Name = "Form_LichSu";
            this.Text = "FormLichSu";
            this.Load += new System.EventHandler(this.FormLichSu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvLichSu;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnPhucHoi;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton InBLP;
    }
}