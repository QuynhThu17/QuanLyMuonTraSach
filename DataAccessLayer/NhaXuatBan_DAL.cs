using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class NhaXuatBan_DAL
    {
        ThaoTac_CoSoDuLieu thaotac = new ThaoTac_CoSoDuLieu();
        string[] name = { };
        object[] value = { };
        public DataTable NhaXuatBan_Select()
        {
            return thaotac.SQL_Laydulieu("NhaXuatBan_Select");
        }

        public int NhaXuatBan_Insert(string MaXB, string TenXB)
        {
            name = new string[2];
            value = new object[2];

            name[0] = "@MaXB"; value[0] = MaXB;
            name[1] = "@TenXB"; value[1] = TenXB;

            return thaotac.SQL_Thuchien("NhaXuatBan_Insert", name, value, 2);
        }

        public int NhaXuatBan_Update(string MaXB, string TenXB)
        {
            name = new string[2];
            value = new object[2];

            name[0] = "@MaXB"; value[0] = MaXB;
            name[1] = "@TenXB"; value[1] = TenXB;

            return thaotac.SQL_Thuchien("NhaXuatBan_Update", name, value, 2);
        }

        public int NhaXuatBan_Delete(string MaXB)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaXB"; value[0] = MaXB;
            return thaotac.SQL_Thuchien("NhaXuatBan_Delete", name, value, 1);
        }

        public DataTable NhaXuatBan_Search(string TenXB)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@TenXB"; value[0] = TenXB;
            return thaotac.SQL_LayDLCDK("NhaXuatBan_Search", name, value, 1);
        }
    }
}

