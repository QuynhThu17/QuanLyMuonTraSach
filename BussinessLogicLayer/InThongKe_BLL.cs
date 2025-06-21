using System;
using System.Data;
using BussinessLogicLayer;
using System.Linq;
using QuanLyMuonTraSach.DAL;
using DataAccessLayer;
using System.Windows.Forms;

namespace QuanLyMuonTraSach.BLL
{
    public class InThongKe_BLL
    {
        Sach_BLL sachBLL = new Sach_BLL();
        LoaiSach_BLL loaiSachBLL = new LoaiSach_BLL();
        NhaXuatBan_BLL nhaXB_BLL = new NhaXuatBan_BLL();
        TacGia_BLL tacGiaBLL = new TacGia_BLL();
        DocGia_BLL docGiaBLL = new DocGia_BLL();
        NhanVien_BLL nhanVienBLL = new NhanVien_BLL();
        ChiTietMTS_BLL chiTietMTS_BLL = new ChiTietMTS_BLL();
        private InThongKe_DAL thongKeDAL = new InThongKe_DAL();

        public int TongSoSach()
        {
            DataTable dtSach = sachBLL.LDLS();
            return dtSach.AsEnumerable().Sum(r => r.Field<int>("SoLuong"));
        }

        public int TongLoaiSach()
        {
            DataTable dt = loaiSachBLL.LDLLS();
            return dt.Rows.Count;
        }

        public int TongNhaXuatBan()
        {
            DataTable dt = nhaXB_BLL.LDLNXB();
            return dt.Rows.Count;
        }

        public int TongTacGia()
        {
            DataTable dt = tacGiaBLL.LDLTG();
            return dt.Rows.Count;
        }

        public int TongDocGia()
        {
            DataTable dt = docGiaBLL.LDLDG();
            // Giả sử cột LoaiDocGia trong bảng DocGia

            return dt.Rows.Count;
        }

        public int TongNhanVien()
        {
            DataTable dt = nhanVienBLL.LDLNV();
            return dt.Rows.Count;
        }

        public int TongSachDangMuon()
        {
            DataTable dtChiTiet = chiTietMTS_BLL.ChiTietMuonTraSach_Select();
            int tongSoLuongDangMuon = dtChiTiet.AsEnumerable().Sum(r => r.Field<int>("SoLuong"));
            return tongSoLuongDangMuon;
        }

        public DataTable LayBaoCaoThongKeMuonSach(DateTime tuNgay, DateTime denNgay)
        {
            return thongKeDAL.LayBaoCaoThongKeMuonSach(tuNgay, denNgay);
        }
        public DataTable LayThongKeSach()
        {
            return thongKeDAL.LayThongKeSach();
        }

    }


}
