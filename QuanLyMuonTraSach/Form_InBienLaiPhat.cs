using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BussinessLogicLayer;
using CrystalDecisions.CrystalReports.Engine;

namespace QuanLyMuonTraSach
{
    public partial class Form_InBienLaiPhat : Form
    {
        private BienLaiPhat_BLL bienLaiPhatBusinessLogic = new BienLaiPhat_BLL();
        private string maPhieuMuon;
        private string maDocGia;
        private string maSach; // Lọc theo sách cụ thể

        public Form_InBienLaiPhat(string maPhieuMuon, string maDocGia, string maSach = null)
        {
            InitializeComponent();
            this.maPhieuMuon = maPhieuMuon;
            this.maDocGia = maDocGia;
            this.maSach = maSach;
        }

        private void Form_InBienLaiPhat_Load(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(maPhieuMuon) || string.IsNullOrEmpty(maDocGia))
                {
                    MessageBox.Show("Mã phiếu mượn hoặc mã độc giả không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                // Tạo report
                BienLaiPhat rpt = new BienLaiPhat();

                // Thiết lập Record Selection Formula để lọc dữ liệu trực tiếp trên report
                string filter = $"{{LichSuMuonSach.MaPhieuMuon}} = '{maPhieuMuon}' AND {{LichSuMuonSach.MaDocGia}} = '{maDocGia}'";
                if (!string.IsNullOrEmpty(maSach))
                {
                    filter += $" AND {{LichSuMuonSach.MaSach}} = '{maSach}'";
                }

                rpt.RecordSelectionFormula = filter;

                // (Nếu cần có thể set lại kết nối database nếu chạy ở máy khác)
                // rpt.SetDatabaseLogon("username", "password", "server", "database");

                // Gán report cho viewer
                crystalReportViewer1.ReportSource = rpt;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}