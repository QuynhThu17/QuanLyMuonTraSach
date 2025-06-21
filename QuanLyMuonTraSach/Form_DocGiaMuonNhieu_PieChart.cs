using System;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using QuanLyMuonTraSach.BLL;

namespace QuanLyMuonTraSach
{
    public partial class Form_DocGiaMuonNhieu_PieChart : Form
    {
        private readonly ThongKeDocGiaMuonNhieu_BLL thongKeBLL = new ThongKeDocGiaMuonNhieu_BLL();

        public Form_DocGiaMuonNhieu_PieChart()
        {
            InitializeComponent();
        }

        private void LoadPieChart()
        {
            DateTime tuNgay = dtpTuNgay.Value.Date;
            DateTime denNgay = dtpDenNgay.Value.Date;

            DataTable dt = thongKeBLL.LayThongKeDocGiaMuonNhieu(tuNgay, denNgay);

            chart1.Series.Clear();
            chart1.Legends.Clear();

            Series series = new Series("Độc giả mượn nhiều nhất");
            series.ChartType = SeriesChartType.Pie;
            series.IsValueShownAsLabel = true;
            series.Label = "#PERCENT{P0}";
            series.LegendText = "#VALX";
            series.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Regular);

            Legend legend = new Legend();
            legend.Docking = Docking.Right;
            legend.Font = new System.Drawing.Font("Segoe UI", 9);
            chart1.Legends.Add(legend);
            chart1.Series.Add(series);

            foreach (DataRow row in dt.Rows)
            {
                string tenDocGia = row["HoTenDocGia"].ToString();
                int tongSoLuong = Convert.ToInt32(row["TongSoLuongMuon"]);
                series.Points.AddXY(tenDocGia, tongSoLuong);
            }

            chart1.Titles.Clear();
            chart1.Titles.Add("BIỂU ĐỒ ĐỘC GIẢ MƯỢN NHIỀU NHẤT");
            chart1.Titles[0].Font = new System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Bold);
        }

        private void Form_DocGiaMuonNhieu_PieChart_Load(object sender, EventArgs e)
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
