using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyMuonTraSach.BLL;

namespace QuanLyMuonTraSach
{
    public partial class Form_InThongKeSach : Form
    {
        private readonly InThongKe_BLL thongKeSachBLL = new InThongKe_BLL();
        public Form_InThongKeSach()
        {
            InitializeComponent();
        }

        private void Form_InThongKeSach_Load(object sender, EventArgs e)
        {
            DataTable dt = thongKeSachBLL.LayThongKeSach();

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu thống kê sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ThongkeSach rpt = new ThongkeSach(); // File Crystal Report .rpt bạn đã thiết kế
            rpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }
    }
}
