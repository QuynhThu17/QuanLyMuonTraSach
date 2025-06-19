using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class TaiKhoan_DAL
    {
        ThaoTac_CoSoDuLieu thaotac = new ThaoTac_CoSoDuLieu(); 
        string[] name = { }; 
        object[] value = { };
        public DataTable TaiKhoan_Select()
        {
            return thaotac.SQL_Laydulieu("TaiKhoan_Select");
        }

        public int TaiKhoan_Insert(string MaTaiKhoan, string TenTaiKhoan, string MatKhau, DateTime ThoiGianCap, DateTime ThoiGianHet, string MaNhanVien, string MaDocGia)
        {
            name = new string[7];
            value = new object[7];

            name[0] = "@MaTaiKhoan"; value[0] = MaTaiKhoan;
            name[1] = "@TenTaiKhoan"; value[1] = TenTaiKhoan;
            name[2] = "@MatKhau"; value[2] = MatKhau;
            name[3] = "@ThoiGianCap"; value[3] = ThoiGianCap;
            name[4] = "@ThoiGianHet"; value[4] = ThoiGianHet;
            name[5] = "@MaNhanVien"; value[5] = MaNhanVien;
            name[6] = "@MaDocGia"; value[6] = MaDocGia;

            return thaotac.SQL_Thuchien("TaiKhoan_Insert", name, value, 7);
        }

        public int TaiKhoan_Update(string MaTaiKhoan, string TenTaiKhoan, string MatKhau, DateTime ThoiGianCap, DateTime ThoiGianHet, string MaNhanVien, string MaDocGia)
        {
            name = new string[7];
            value = new object[7];

            name[0] = "@MaTaiKhoan"; value[0] = MaTaiKhoan;
            name[1] = "@TenTaiKhoan"; value[1] = TenTaiKhoan;
            name[2] = "@MatKhau"; value[2] = MatKhau;
            name[3] = "@ThoiGianCap"; value[3] = ThoiGianCap;
            name[4] = "@ThoiGianHet"; value[4] = ThoiGianHet;
            name[5] = "@MaNhanVien"; value[5] = MaNhanVien;
            name[6] = "@MaDocGia"; value[6] = MaDocGia;

            return thaotac.SQL_Thuchien("TaiKhoan_Update", name, value, 7);
        }

        public int TaiKhoan_Delete(string MaTaiKhoan)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaTaiKhoan"; value[0] = MaTaiKhoan;
            return thaotac.SQL_Thuchien("TaiKhoan_Delete", name, value, 1);
        }

        public DataTable TaiKhoan_Search(string TenTaiKhoan)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@TenTaiKhoan"; value[0] = TenTaiKhoan;
            return thaotac.SQL_LayDLCDK("TaiKhoan_Search", name, value, 1);
        }
    }
}

