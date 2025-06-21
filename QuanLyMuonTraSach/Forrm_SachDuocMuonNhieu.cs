using System;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using QuanLyMuonTraSach.BLL;

namespace QuanLyMuonTraSach
{
    public partial class Forrm_SachDuocMuonNhieuNhat : Form
    {
        private readonly ThongKeSachMuonNhieu_BLL thongKeBLL = new ThongKeSachMuonNhieu_BLL();

        public Forrm_SachDuocMuonNhieuNhat()
        {
            InitializeComponent();
        }

        private void LoadPieChart()
        {
            DateTime tuNgay = dtpTuNgay.Value.Date;
            DateTime denNgay = dtpDenNgay.Value.Date;

            DataTable dt = thongKeBLL.LayThongKeSachMuonNhieu(tuNgay, denNgay);

            // Xóa dữ liệu cũ
            ChartTKSachMuonNhieuNhat.Series.Clear();
            ChartTKSachMuonNhieuNhat.Legends.Clear();

            // Tạo Series
            Series series = new Series("Sách được mượn nhiều nhất");
            series.ChartType = SeriesChartType.Pie;
            series.IsValueShownAsLabel = true;
            series.Label = "#PERCENT{P0}"; // Hiển thị phần trăm
            series.LegendText = "#VALX";   // Hiển thị tên sách trong ghi chú
            series.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Regular);

            // Tạo legend
            Legend legend = new Legend();
            legend.Docking = Docking.Right;
            legend.Font = new System.Drawing.Font("Segoe UI", 9);
            ChartTKSachMuonNhieuNhat.Legends.Add(legend);
            ChartTKSachMuonNhieuNhat.Series.Add(series);

            foreach (DataRow row in dt.Rows)
            {
                string tenSach = row["TenSach"].ToString();
                int tongSoLuong = Convert.ToInt32(row["TongSoLuongMuon"]);
                series.Points.AddXY(tenSach, tongSoLuong);
            }

            ChartTKSachMuonNhieuNhat.Titles.Clear();
            ChartTKSachMuonNhieuNhat.Titles.Add("BIỂU ĐỒ TỶ LỆ SÁCH ĐƯỢC MƯỢN NHIỀU NHẤT");
            ChartTKSachMuonNhieuNhat.Titles[0].Font = new System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Bold);
        }

        private void Form_SachMuonNhieu_Load(object sender, EventArgs e)
        {
            dtpDenNgay.Value = DateTime.Now;
            dtpTuNgay.Value = DateTime.Now.AddMonths(-1);
            LoadPieChart();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            LoadPieChart();
        }
    }
}

