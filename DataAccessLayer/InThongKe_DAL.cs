using System;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer;

namespace QuanLyMuonTraSach.DAL
{
    public class InThongKe_DAL
    {
        private readonly ThaoTac_CoSoDuLieu ThaoTac = new ThaoTac_CoSoDuLieu();

        public DataTable LayBaoCaoThongKeMuonSach(DateTime tuNgay, DateTime denNgay)
        {
            string[] name = { "@TuNgay", "@DenNgay" };
            object[] value = { tuNgay.Date, denNgay.Date };
            return ThaoTac.SQL_LayDLCDK("sp_ThongKeSoLuongSachDuocMuon", name, value, 2);
        }
        public DataTable LayThongKeSach()
        {
            // Vì procedure này không có tham số
            return ThaoTac.SQL_LayDLCDK("sp_ThongKeSoLuongSach", null, null, 0);
        }
    }


}