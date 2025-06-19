using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class BoPhan_DAL
    {
        ThaoTac_CoSoDuLieu thaotac = new ThaoTac_CoSoDuLieu();
        string[] name = { };
        object[] value = { };
        public DataTable BoPhan_Select()
        {
            return thaotac.SQL_Laydulieu("BoPhan_Select");
        }

        public int BoPhan_Insert(string MaBoPhan, string TenBoPhan)
        {
            name = new string[2];
            value = new object[2];

            name[0] = "@MaBoPhan"; value[0] = MaBoPhan;
            name[1] = "@TenBoPhan"; value[1] = TenBoPhan;

            return thaotac.SQL_Thuchien("BoPhan_Insert", name, value, 2);
        }

        public int BoPhan_Update(string MaBoPhan, string TenBoPhan)
        {
            name = new string[2];
            value = new object[2];

            name[0] = "@MaBoPhan"; value[0] = MaBoPhan;
            name[1] = "@TenBoPhan"; value[1] = TenBoPhan;

            return thaotac.SQL_Thuchien("BoPhan_Update", name, value, 2);
        }

        public int BoPhan_Delete(string MaBoPhan)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaBoPhan"; value[0] = MaBoPhan;
            return thaotac.SQL_Thuchien("BoPhan_Delete", name, value, 1);
        }

        public DataTable BoPhan_Search(string MaBoPhan)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaBoPhan"; value[0] = MaBoPhan;
            return thaotac.SQL_LayDLCDK("BoPhan_Search", name, value, 1);
        }
    }
}


