using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BussinessLogicLayer
{
    public class NhanVien_BLL
    {
        NhanVien_DAL NhanVienDal = new NhanVien_DAL();
        public DataTable NhanVien_Select()
        {
            return NhanVienDal.NhanVien_Select();
        }

        public int NhanVien_Insert(string MaNhanVien, string HoTen, string ChucVu, DateTime NgaySinh, string SDT, string GioiTinh, string MaBoPhan)
        {
            return NhanVienDal.NhanVien_Insert(MaNhanVien, HoTen, ChucVu, NgaySinh, SDT, GioiTinh, MaBoPhan);
        }

        public int NhanVien_Update(string MaNhanVien, string HoTen, string ChucVu, DateTime NgaySinh, string SDT, string GioiTinh, string MaBoPhan)
        {
            return NhanVienDal.NhanVien_Update(MaNhanVien, HoTen, ChucVu, NgaySinh, SDT, GioiTinh, MaBoPhan);
        }

        public int NhanVien_Delete(string MaNhanVien)
        {
            return NhanVienDal.NhanVien_Delete(MaNhanVien);
        }

        public DataTable NhanVien_Search(string HoTen)
        {
            return NhanVienDal.NhanVien_Search(HoTen);
        }

        public DataTable LDLNV()
        {
            return NhanVienDal.NhanVien_Select();
        }
    }
}

