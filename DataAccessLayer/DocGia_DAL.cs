using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DocGia_DAL
    {
        ThaoTac_CoSoDuLieu thaotac = new ThaoTac_CoSoDuLieu(); 
        string[] name = { };
        object[] value = { };
        public DataTable DocGia_Select()
        {
            return thaotac.SQL_Laydulieu("DocGia_Select");
        }

        public int DocGia_Insert(string MaDocGia, string HoTenDocGia, string Lop, string GioiTinh, DateTime NgaySinh, string SDT, string DiaChi, string VaiTro)
        {
            name = new string[8];
            value = new object[8];

            name[0] = "@MaDocGia"; value[0] = MaDocGia;
            name[1] = "@HoTenDocGia"; value[1] = HoTenDocGia;
            name[2] = "@Lop"; value[2] = Lop;
            name[3] = "@GioiTinh"; value[3] = GioiTinh;
            name[4] = "@NgaySinh"; value[4] = NgaySinh;
            name[5] = "@SDT"; value[5] = SDT;
            name[6] = "@DiaChi"; value[6] = DiaChi;
            name[7] = "@VaiTro"; value[7] = VaiTro;

            return thaotac.SQL_Thuchien("DocGia_Insert", name, value, 8);
        }

        public int DocGia_Update(string MaDocGia, string HoTenDocGia, string Lop, string GioiTinh, DateTime NgaySinh, string SDT, string DiaChi, string VaiTro)
        {
            name = new string[8];
            value = new object[8];

            name[0] = "@MaDocGia"; value[0] = MaDocGia;
            name[1] = "@HoTenDocGia"; value[1] = HoTenDocGia;
            name[2] = "@Lop"; value[2] = Lop;
            name[3] = "@GioiTinh"; value[3] = GioiTinh;
            name[4] = "@NgaySinh"; value[4] = NgaySinh;
            name[5] = "@SDT"; value[5] = SDT;
            name[6] = "@DiaChi"; value[6] = DiaChi;
            name[7] = "@VaiTro"; value[7] = VaiTro;

            return thaotac.SQL_Thuchien("DocGia_Update", name, value, 8);
        }

        public int DocGia_Delete(string MaDocGia)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaDocGia"; value[0] = MaDocGia;
            return thaotac.SQL_Thuchien("DocGia_Delete", name, value, 1);
        }

        public DataTable DocGia_Search(string HoTenDocGia)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@HoTenDocGia"; value[0] = HoTenDocGia;
            return thaotac.SQL_LayDLCDK("DocGia_Search", name, value, 1);
        }
    }
}

