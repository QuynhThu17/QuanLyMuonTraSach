namespace QuanLyMuonTraSach
{
    partial class Form_DuBaoXuHuongMuonSach
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnDuBao = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 270;
            this.label3.Text = "Đến ngày";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 269;
            this.label4.Text = "Từ ngày";
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new System.Drawing.Point(570, 27);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(200, 22);
            this.dtpDenNgay.TabIndex = 268;
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(145, 27);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(200, 22);
            this.dtpTuNgay.TabIndex = 267;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 72);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1424, 699);
            this.chart1.TabIndex = 272;
            this.chart1.Text = "chart1";
            // 
            // btnDuBao
            // 
            this.btnDuBao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDuBao.BackColor = System.Drawing.Color.Teal;
            this.btnDuBao.FlatAppearance.BorderSize = 0;
            this.btnDuBao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDuBao.ForeColor = System.Drawing.Color.White;
            this.btnDuBao.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnDuBao.IconColor = System.Drawing.Color.White;
            this.btnDuBao.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDuBao.IconSize = 30;
            this.btnDuBao.Location = new System.Drawing.Point(846, 15);
            this.btnDuBao.Name = "btnDuBao";
            this.btnDuBao.Size = new System.Drawing.Size(157, 51);
            this.btnDuBao.TabIndex = 271;
            this.btnDuBao.Text = "Xem";
            this.btnDuBao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDuBao.UseVisualStyleBackColor = false;
            this.btnDuBao.Click += new System.EventHandler(this.btnDuBao_Click);
            // 
            // Form_DuBaoXuHuongMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1439, 773);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnDuBao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDenNgay);
            this.Controls.Add(this.dtpTuNgay);
            this.Name = "Form_DuBaoXuHuongMuonSach";
            this.Text = "Form_DuBaoXuHuongMuonSach";
            this.Load += new System.EventHandler(this.Form_DuBaoXuHuongMuonSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnDuBao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}