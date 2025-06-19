using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLogicLayer;

namespace QuanLyMuonTraSach
{
    public partial class Form_InPhieuMuon : Form
    {
        private InPM_BLL phieuMuonBusinessLogic = new InPM_BLL();

        public Form_InPhieuMuon()
        {
            InitializeComponent();
        }

        private void InPM_Load(object sender, EventArgs e)
        {
            try
            {
                string maPhieuMuon = Form_MuonTraSach.MaPM;
                if (string.IsNullOrEmpty(maPhieuMuon))
                {
                    MessageBox.Show("Mã phiếu mượn không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DataTable dt = phieuMuonBusinessLogic.GetPhieuMuon(maPhieuMuon);

                // Tạo DataTable mới để nhóm dữ liệu theo MaSach nếu cần
                DataTable dtReport = dt.Clone();
                var groups = dt.AsEnumerable().GroupBy(row => new { MaSach = row.Field<string>("MaSach"), TenSach = row.Field<string>("TenSach"), NhaXuatBan = row.Field<string>("NhaXuatBan") });
                foreach (var group in groups)
                {
                    DataRow newRow = dtReport.NewRow();
                    newRow["MaPhieuMuon"] = maPhieuMuon;
                    newRow["TenDocGia"] = group.First()["TenDocGia"];
                    newRow["MaDocGia"] = group.First()["MaDocGia"];
                    newRow["NgayMuon"] = group.First()["NgayMuon"];
                    newRow["NgayTra"] = group.First()["NgayTra"];
                    newRow["TenNhanVien"] = group.First()["TenNhanVien"];
                    newRow["MaSach"] = group.Key.MaSach;
                    newRow["TenSach"] = group.Key.TenSach;
                    newRow["NhaXuatBan"] = group.Key.NhaXuatBan;
                    newRow["SoLuong"] = group.Sum(r => r.Field<int>("SoLuong"));
                    newRow["GhiChu"] = group.First()["GhiChu"];
                    dtReport.Rows.Add(newRow);
                }

                PMSach rpt = new PMSach();
                rpt.SetDataSource(dtReport);
                crystalReportViewer1.ReportSource = rpt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
