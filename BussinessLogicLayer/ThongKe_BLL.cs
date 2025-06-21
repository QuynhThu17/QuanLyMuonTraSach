using System;
using DataAccessLayer;

namespace BussinessLogicLayer
{
    public class ThongKe_BLL
    {
        private ThongKe_DAL thongKeDAL = new ThongKe_DAL();

        public int LayTongNhanVien() => thongKeDAL.GetSoLuongNhanVien();
        public int LayTongSinhVien() => thongKeDAL.GetSoLuongSinhVien();
        public int LayTongSach() => thongKeDAL.GetSoLuongSach();
        public int LayTongPhieuMuon() => thongKeDAL.GetSoLuongPhieuMuon();
        public int LayTongLoaiSach() => thongKeDAL.GetSoLuongLoaiSach();
        public int LayTongTacGia() => thongKeDAL.GetSoLuongTacGia();
        public int LayTongNhaXuatBan() => thongKeDAL.GetSoLuongNhaXuatBan();
    }
}
