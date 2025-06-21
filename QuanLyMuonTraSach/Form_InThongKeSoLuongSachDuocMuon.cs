using System;
using System.Data;
using System.Windows.Forms;
using BLL;
using BussinessLogicLayer;
using CrystalDecisions.CrystalReports.Engine;
using QuanLyMuonTraSach.BLL;

namespace QuanLyMuonTraSach
{
    public partial class Form_InThongKeSoLuongSachDuocMuon : Form
    {
        private readonly InThongKe_BLL thongKeBLL = new InThongKe_BLL();
        private DateTime tuNgay;
        private DateTime denNgay;

        public Form_InThongKeSoLuongSachDuocMuon(DateTime tuNgay, DateTime denNgay)
        {
            InitializeComponent();
            this.tuNgay = tuNgay;
            this.denNgay = denNgay;
        }

        private void Form_InThongKeSoLuongSachDuocMuon_Load(object sender, EventArgs e)
        {
            DataTable dt = thongKeBLL.LayBaoCaoThongKeMuonSach(tuNgay, denNgay);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu trong khoảng thời gian đã chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ThongKeSoLuongSachMuonTheoDocGia rpt = new ThongKeSoLuongSachMuonTheoDocGia();
            rpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }
    }
}
