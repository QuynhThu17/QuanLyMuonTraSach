using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class NhanVien_DAL
    {
        ThaoTac_CoSoDuLieu thaotac = new ThaoTac_CoSoDuLieu(); 
        string[] name = { }; 
        object[] value = { };
        public DataTable NhanVien_Select()
        {
            return thaotac.SQL_Laydulieu("NhanVien_Select");
        }

        public int NhanVien_Insert(string MaNhanVien, string HoTen, string ChucVu, DateTime NgaySinh, string SDT, string GioiTinh, string MaBoPhan)
        {
            name = new string[7];
            value = new object[7];

            name[0] = "@MaNhanVien"; value[0] = MaNhanVien;
            name[1] = "@HoTen"; value[1] = HoTen;
            name[2] = "@ChucVu"; value[2] = ChucVu;
            name[3] = "@NgaySinh"; value[3] = NgaySinh;
            name[4] = "@SDT"; value[4] = SDT;
            name[5] = "@GioiTinh"; value[5] = GioiTinh;
            name[6] = "@MaBoPhan"; value[6] = MaBoPhan;

            return thaotac.SQL_Thuchien("NhanVien_Insert", name, value, 7);
        }

        public int NhanVien_Update(string MaNhanVien, string HoTen, string ChucVu, DateTime NgaySinh, string SDT, string GioiTinh, string MaBoPhan)
        {
            name = new string[7];
            value = new object[7];

            name[0] = "@MaNhanVien"; value[0] = MaNhanVien;
            name[1] = "@HoTen"; value[1] = HoTen;
            name[2] = "@ChucVu"; value[2] = ChucVu;
            name[3] = "@NgaySinh"; value[3] = NgaySinh;
            name[4] = "@SDT"; value[4] = SDT;
            name[5] = "@GioiTinh"; value[5] = GioiTinh;
            name[6] = "@MaBoPhan"; value[6] = MaBoPhan;

            return thaotac.SQL_Thuchien("NhanVien_Update", name, value, 7);
        }

        public int NhanVien_Delete(string MaNhanVien)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaNhanVien"; value[0] = MaNhanVien;
            return thaotac.SQL_Thuchien("NhanVien_Delete", name, value, 1);
        }

        public DataTable NhanVien_Search(string HoTen)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@HoTen"; value[0] = HoTen;
            return thaotac.SQL_LayDLCDK("NhanVien_Search", name, value, 1);
        }
    }
}

