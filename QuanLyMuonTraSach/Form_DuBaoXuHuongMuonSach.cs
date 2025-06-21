using System;
using System.Data;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using QuanLyMuonTraSach.BLL;

namespace QuanLyMuonTraSach
{
    public partial class Form_DuBaoXuHuongMuonSach : Form
    {
        private readonly DuBaoXuHuongMuonSach_BLL duBaoBLL = new DuBaoXuHuongMuonSach_BLL();

        public Form_DuBaoXuHuongMuonSach()
        {
            InitializeComponent();
        }

        private void SetupChart()
        {
            chart1.Series.Clear();
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM";
            chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Months;
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chart1.ChartAreas[0].AxisX.Title = "Tháng";
            chart1.ChartAreas[0].AxisY.Title = "Số lượng mượn sách";
        }
        private void LoadChart()
        {
            SetupChart();

            DateTime tuNgay = dtpTuNgay.Value.Date;
            DateTime denNgay = dtpDenNgay.Value.Date;

            DateTime denNgayDuLieuThucTe = denNgay < DateTime.Now ? denNgay : DateTime.Now;

            DataTable dt = duBaoBLL.LayDuLieuXuHuong(tuNgay, denNgayDuLieuThucTe);

            Series series = new Series("Lịch sử mượn sách");
            series.ChartType = SeriesChartType.Line;
            series.MarkerStyle = MarkerStyle.Circle;
            series.MarkerSize = 8;
            series.IsValueShownAsLabel = true;
            series.XValueType = ChartValueType.DateTime;
            chart1.Series.Add(series);

            foreach (DataRow row in dt.Rows)
            {
                string thang = row["ThangMuon"].ToString(); // yyyy-MM
                DateTime thangDate = DateTime.ParseExact(thang + "-01", "yyyy-MM-dd", null);
                int tongSoLuong = Convert.ToInt32(row["TongSoLuongMuon"]);
                series.Points.AddXY(thangDate, tongSoLuong);
            }

            DuBaoTuongLai(dt, denNgay);
        }



        private void DuBaoTuongLai(DataTable dt, DateTime denNgayChon)
        {
            List<int> xValues = new List<int>();
            List<int> yValues = new List<int>();

            int index = 1;
            foreach (DataRow row in dt.Rows)
            {
                xValues.Add(index);
                int tongSoLuong = Convert.ToInt32(row["TongSoLuongMuon"]);
                yValues.Add(tongSoLuong);
                index++;
            }

            int n = xValues.Count;
            if (n < 2)
            {
                MessageBox.Show("Không đủ dữ liệu để dự báo.");
                return;
            }

            double sumX = xValues.Sum();
            double sumY = yValues.Sum();
            double sumXY = xValues.Zip(yValues, (x, y) => x * y).Sum();
            double sumX2 = xValues.Sum(x => x * x);

            double a = (n * sumXY - sumX * sumY) / (n * sumX2 - sumX * sumX);
            double b = (sumY - a * sumX) / n;

            string thangCuoiCung = dt.Rows[dt.Rows.Count - 1]["ThangMuon"].ToString();
            DateTime thangCuoi = DateTime.ParseExact(thangCuoiCung + "-01", "yyyy-MM-dd", null);
            DateTime batDauDuBao = thangCuoi.AddMonths(1);

            if (batDauDuBao > denNgayChon) return;

            int soThangDuBao = ((denNgayChon.Year - batDauDuBao.Year) * 12 + denNgayChon.Month - batDauDuBao.Month + 1);

            Series forecastSeries = new Series("Dự báo");
            forecastSeries.ChartType = SeriesChartType.Line;
            forecastSeries.Color = System.Drawing.Color.Red;
            forecastSeries.BorderDashStyle = ChartDashStyle.Dash;
            forecastSeries.MarkerStyle = MarkerStyle.Square;
            forecastSeries.MarkerSize = 8;
            forecastSeries.IsValueShownAsLabel = true;
            forecastSeries.XValueType = ChartValueType.DateTime;
            chart1.Series.Add(forecastSeries);

            for (int i = 1; i <= soThangDuBao; i++)
            {
                int thangMoi = n + i;
                double duBao = a * thangMoi + b;
                DateTime thangDuBao = batDauDuBao.AddMonths(i - 1);
                forecastSeries.Points.AddXY(thangDuBao, duBao);
            }
        }




        private void Form_DuBaoXuHuongMuonSach_Load(object sender, EventArgs e)
        {
            dtpDenNgay.Value = DateTime.Now;
            dtpTuNgay.Value = DateTime.Now.AddYears(-1);
            LoadChart();
        }

        private void btnDuBao_Click(object sender, EventArgs e)
        {
            LoadChart();
        }
    }
}
