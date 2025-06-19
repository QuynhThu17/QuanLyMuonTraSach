using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class LoaiSach_DAL
    {
        ThaoTac_CoSoDuLieu thaotac = new ThaoTac_CoSoDuLieu();
        string[] name = { };
        object[] value = { };
        public DataTable LoaiSach_select()
        {
            //thaotac.KetnoiCSDL();
            return thaotac.SQL_Laydulieu("LoaiSach_Select");
        }

        //phương thức này gọi phương thức SQL_Thuchien ở lớp ThaoTac_CoSoDuLieu để thực hiện insert
        public int LoaiSach_Insert(string MaLoaiSach, string TenLoaiSach)
        {
            name = new string[2];
            value = new object[2];

            name[0] = "@MaLoai"; value[0] = MaLoaiSach;
            name[1] = "@TenLoai"; value[1] = TenLoaiSach;
        
          

            return thaotac.SQL_Thuchien("LoaiSach_Insert", name, value, 2);
        }

        //phương thức này gọi phương thức SQL_Thuchien ở lớp ThaoTac_CoSoDuLieu để thực hiện update
        public int LoaiSach_Update(string MaLoaiSach, string TenLoaiSach)
        {
            name = new string[2];
            value = new object[2];

            name[0] = "@MaLoai"; value[0] = MaLoaiSach;
            name[1] = "@TenLoai"; value[1] = TenLoaiSach;
          
           


            return thaotac.SQL_Thuchien("LoaiSach_Update", name, value, 2);
        }

        //phương thức này gọi phương thức SQL_Thuchien ở lớp ThaoTac_CoSoDuLieu để thực hiện delete
        public int LoaiSach_Delete(string MaLoaiSach)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaLoai"; value[0] = MaLoaiSach;
            return thaotac.SQL_Thuchien("LoaiSach_Delete", name, value, 1);
        }
        public DataTable LoaiSach_Search(string searchText)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@SearchText"; value[0] = searchText;
            return thaotac.SQL_LayDLCDK("LoaiSach_Search", name, value, 1);
        }
    }
}
