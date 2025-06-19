using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace DAL
{
    public class DangNhap_DAL
    {
        ThaoTac_CoSoDuLieu thaoTac = new ThaoTac_CoSoDuLieu();

        public DataTable DangNhap(string loaiTaiKhoan, string taiKhoan, string matKhau)
        {
            string[] name = new string[3];
            object[] value = new object[3];

            name[0] = "@LoaiTaiKhoan";
            value[0] = loaiTaiKhoan;
            name[1] = "@TaiKhoan";
            value[1] = taiKhoan;
            name[2] = "@MatKhau";
            value[2] = matKhau;

            return thaoTac.SQL_LayDLCDK("sp_DangNhap", name, value, 3);
        }
    }
}
