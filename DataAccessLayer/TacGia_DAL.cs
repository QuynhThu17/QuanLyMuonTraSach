using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class TacGia_DAL
    {
        ThaoTac_CoSoDuLieu thaotac = new ThaoTac_CoSoDuLieu();
        string[] name = { };
        object[] value = { };
        public DataTable TacGia_Select()
        {
            return thaotac.SQL_Laydulieu("TacGia_Select");
        }

        public int TacGia_Insert(string MaTacGia, string TenTacGia)
        {
            name = new string[2];
            value = new object[2];

            name[0] = "@MaTacGia"; value[0] = MaTacGia;
            name[1] = "@TenTacGia"; value[1] = TenTacGia;

            return thaotac.SQL_Thuchien("TacGia_Insert", name, value, 2);
        }

        public int TacGia_Update(string MaTacGia, string TenTacGia)
        {
            name = new string[2];
            value = new object[2];

            name[0] = "@MaTacGia"; value[0] = MaTacGia;
            name[1] = "@TenTacGia"; value[1] = TenTacGia;

            return thaotac.SQL_Thuchien("TacGia_Update", name, value, 2);
        }

        public int TacGia_Delete(string MaTacGia)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaTacGia"; value[0] = MaTacGia;
            return thaotac.SQL_Thuchien("TacGia_Delete", name, value, 1);
        }

        public DataTable TacGia_Search(string TenTacGia)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@TenTacGia"; value[0] = TenTacGia;
            return thaotac.SQL_LayDLCDK("TacGia_Search", name, value, 1);
        }
    }

}

