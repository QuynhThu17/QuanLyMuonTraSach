using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BussinessLogicLayer
{
    public class TaiKhoan_BLL
    {
        TaiKhoan_DAL TaiKhoanDal = new TaiKhoan_DAL();
        public DataTable TaiKhoan_Select()
        {
            return TaiKhoanDal.TaiKhoan_Select();
        }

        public int TaiKhoan_Insert(string MaTaiKhoan, string TenTaiKhoan, string MatKhau, DateTime ThoiGianCap, DateTime ThoiGianHet, string MaNhanVien, string MaDocGia)
        {
            return TaiKhoanDal.TaiKhoan_Insert(MaTaiKhoan, TenTaiKhoan, MatKhau, ThoiGianCap, ThoiGianHet, MaNhanVien, MaDocGia);
        }

        public int TaiKhoan_Update(string MaTaiKhoan, string TenTaiKhoan, string MatKhau, DateTime ThoiGianCap, DateTime ThoiGianHet, string MaNhanVien, string MaDocGia)
        {
            return TaiKhoanDal.TaiKhoan_Update(MaTaiKhoan, TenTaiKhoan, MatKhau, ThoiGianCap, ThoiGianHet, MaNhanVien, MaDocGia);
        }

        public int TaiKhoan_Delete(string MaTaiKhoan)
        {
            return TaiKhoanDal.TaiKhoan_Delete(MaTaiKhoan);
        }

        public DataTable TaiKhoan_Search(string TenTaiKhoan)
        {
            return TaiKhoanDal.TaiKhoan_Search(TenTaiKhoan);
        }

        public DataTable LDLTK()
        {
            return TaiKhoanDal.TaiKhoan_Select();
        }
    }
}

