using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class DangNhap_BLL
    {
        DangNhap_DAL dangNhapDAL = new DangNhap_DAL();

        public DataTable DangNhap(string loaiTaiKhoan, string taiKhoan, string matKhau)
        {
            return dangNhapDAL.DangNhap(loaiTaiKhoan, taiKhoan, matKhau);
        }
    }
}
