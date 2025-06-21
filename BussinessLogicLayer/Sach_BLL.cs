using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;


namespace BussinessLogicLayer
{
    public class Sach_BLL
    {
        Sach_DAL SachDal = new Sach_DAL();
        public DataTable Sach_Select()
        {
            return SachDal.Sach_Select();
        }

        public int Sach_Insert(string MaSach, string TenSach, string MaTacGia, string MaXB, string MaLoai, string SoTrang, string GiaBan, string SoLuong, DateTime ThoiGianPhatHanh)
        {
            return SachDal.Sach_Insert(MaSach, TenSach, MaTacGia, MaXB, MaLoai, SoTrang, GiaBan, SoLuong, ThoiGianPhatHanh);
        }

        public int Sach_Update(string MaSach, string TenSach, string MaTacGia, string MaXB, string MaLoai, string SoTrang, string GiaBan, string SoLuong, DateTime ThoiGianPhatHanh)
        {
            return SachDal.Sach_Update(MaSach, TenSach, MaTacGia, MaXB, MaLoai, SoTrang, GiaBan, SoLuong, ThoiGianPhatHanh);
        }

        public int Sach_Delete(string MaSach)
        {
            return SachDal.Sach_Delete(MaSach);
        }

        public DataTable Sach_Search(string TenSach)
        {
            return SachDal.Sach_Search(TenSach);
        }

        public DataTable LDLS()
        {
            return SachDal.Sach_Select();
        }
        public void Sach_UpdateSoLuong(string maSach, int soLuongMoi)
        {
            SachDal.Sach_UpdateSoLuong(maSach, soLuongMoi);
        }
        public int TongSoSachHienCo()
        {
            DataTable dtSach = SachDal.Sach_Select();
            int tongSoLuong = dtSach.AsEnumerable().Sum(row => row.Field<int>("SoLuong"));
            return tongSoLuong;
        }
    }



}
