using System;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using BussinessLogicLayer;
using System.Data;

namespace QuanLyMuonTraSach
{
    public partial class Form_InBienLaiPhat : Form
    {
        private BienLaiPhat_BLL phatBusinessLogic = new BienLaiPhat_BLL();
        private string _maLichSu;

        public Form_InBienLaiPhat()
        {
            InitializeComponent();
        }

        public Form_InBienLaiPhat(string maLichSu)
        {
            InitializeComponent();
            _maLichSu = maLichSu;
        }

        private void InBLP_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_maLichSu))
            {
                LoadReport();
            }
        }

        private void LoadReport()
        {
            try
            {
                if (string.IsNullOrEmpty(_maLichSu))
                {
                    MessageBox.Show("Mã phiếu mượn không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DataTable dt = phatBusinessLogic.GetPhatData(_maLichSu);
                BienLaiPhat rpt = new BienLaiPhat();
                rpt.SetDataSource(dt);
                crystalReportViewer1.ReportSource = rpt;
                // Ngăn chặn sự kiện Load gọi lại
                this.Load -= InBLP_Load; // Loại bỏ sự kiện Load sau khi chạy lần đầu
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}