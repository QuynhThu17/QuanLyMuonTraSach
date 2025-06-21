using System;
using System.Data;
using System.Windows.Forms;
using QuanLyMuonTraSach.BLL;
using CrystalDecisions.CrystalReports.Engine;

namespace QuanLyMuonTraSach
{
    public partial class Form_InThongKeSoLuongSachDuocMuon : Form
    {
        private InThongKe_BLL thongKeBusinessLogic = new InThongKe_BLL();

        public Form_InThongKeSoLuongSachDuocMuon()
        {
            InitializeComponent();
        }

        //private void Form_InThongKeSoLuongSachDuocMuon_Load(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        //dtpTuNgay.Value = DateTime.Now.AddMonths(-1);
        //        //dtpDenNgay.Value = DateTime.Now;
        //        //LoadThongKeSoLuongSachDuocMuon(dtpTuNgay.Value, dtpDenNgay.Value);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi khi tải báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void LoadThongKeSoLuongSachDuocMuon(DateTime tuNgay, DateTime denNgay)
        //{
        //    DataTable dt = thongKeBusinessLogic.GetThongKeSoLuongSachDuocMuon(tuNgay, denNgay);

        //    // Kiểm tra nếu DataTable có dữ liệu và cột
        //    if (dt.Rows.Count > 0 && dt.Columns.Contains("Mã Độc Giả") && dt.Columns.Contains("Họ Tên Độc Giả") && dt.Columns.Contains("Số Lượng"))
        //    {
        //        ThongKeSoLuongSachMuonTheoDocGia rpt = new ThongKeSoLuongSachMuonTheoDocGia();
        //        rpt.SetDataSource(dt);
        //        crystalReportViewer1.ReportSource = rpt;
        //    }
        //    else
        //    {
        //        MessageBox.Show("Không có dữ liệu hoặc cột không khớp trong DataTable. Kiểm tra stored procedure hoặc dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //}

        //private void btnXemBaoCao_Click(object sender, EventArgs e)
        //{
        //    //LoadThongKeSoLuongSachDuocMuon(dtpTuNgay.Value, dtpDenNgay.Value);
        //}
    }
}