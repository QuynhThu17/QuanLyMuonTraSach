using System;
using System.Data;
using QuanLyMuonTraSach.DAL;

namespace QuanLyMuonTraSach.BLL
{
    public class ThongKeHoanTra_BLL
    {
        private readonly ThongKeHoanTra_DAL dal = new ThongKeHoanTra_DAL();

        public DataTable LayThongKeHoanTra(DateTime tuNgay, DateTime denNgay)
        {
            return dal.LayThongKeHoanTra(tuNgay, denNgay);
        }
    }
}
