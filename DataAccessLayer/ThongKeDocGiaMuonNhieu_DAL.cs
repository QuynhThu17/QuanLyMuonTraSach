using System;
using System.Data;
using DataAccessLayer;

namespace QuanLyMuonTraSach.DAL
{
    public class ThongKeDocGiaMuonNhieu_DAL
    {
        private readonly ThaoTac_CoSoDuLieu ThaoTac = new ThaoTac_CoSoDuLieu();

        public DataTable LayThongKeDocGiaMuonNhieu(DateTime tuNgay, DateTime denNgay)
        {
            string[] name = { "@TuNgay", "@DenNgay" };
            object[] value = { tuNgay.Date, denNgay.Date };
            return ThaoTac.SQL_LayDLCDK("sp_ThongKeDocGiaMuonNhieuNhat", name, value, 2);
        }
    }
}
