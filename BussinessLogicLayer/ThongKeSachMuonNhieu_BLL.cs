using System;
using System.Data;
using QuanLyMuonTraSach.DAL;

namespace QuanLyMuonTraSach.BLL
{
    public class ThongKeSachMuonNhieu_BLL
    {
        private readonly ThongKeSachMuonNhieu_DAL thongKeDAL = new ThongKeSachMuonNhieu_DAL();

        public DataTable LayThongKeSachMuonNhieu(DateTime tuNgay, DateTime denNgay)
        {
            return thongKeDAL.LayThongKeSachMuonNhieu(tuNgay, denNgay);
        }
    }
}
