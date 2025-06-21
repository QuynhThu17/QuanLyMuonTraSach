using System;
using System.Data;
using QuanLyMuonTraSach.DAL;

namespace QuanLyMuonTraSach.BLL
{
    public class ThongKeDocGiaMuonNhieu_BLL
    {
        private readonly ThongKeDocGiaMuonNhieu_DAL thongKeDAL = new ThongKeDocGiaMuonNhieu_DAL();

        public DataTable LayThongKeDocGiaMuonNhieu(DateTime tuNgay, DateTime denNgay)
        {
            return thongKeDAL.LayThongKeDocGiaMuonNhieu(tuNgay, denNgay);
        }
    }
}
