using System;
using System.Data;
using DataAccessLayer;

namespace QuanLyMuonTraSach.DAL
{
    public class ThongKeHoanTra_DAL
    {
        private readonly ThaoTac_CoSoDuLieu ThaoTac = new ThaoTac_CoSoDuLieu();

        public DataTable LayThongKeHoanTra(DateTime tuNgay, DateTime denNgay)
        {
            string[] name = { "@TuNgay", "@DenNgay" };
            object[] value = { tuNgay.Date, denNgay.Date };
            return ThaoTac.SQL_LayDLCDK("sp_ThongKeHoanTraTheoThang", name, value, 2);
        }
    }
}
