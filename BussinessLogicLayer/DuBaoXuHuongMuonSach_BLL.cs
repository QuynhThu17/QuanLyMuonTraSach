using System;
using System.Data;
using QuanLyMuonTraSach.DAL;

namespace QuanLyMuonTraSach.BLL
{
    public class DuBaoXuHuongMuonSach_BLL
    {
        private readonly DuBaoXuHuongMuonSach_DAL duBaoDAL = new DuBaoXuHuongMuonSach_DAL();

        public DataTable LayDuLieuXuHuong(DateTime tuNgay, DateTime denNgay)
        {
            return duBaoDAL.LayDuLieuXuHuong(tuNgay, denNgay);
        }
    }
}
