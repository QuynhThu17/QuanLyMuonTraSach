using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BussinessLogicLayer
{
    public class LoaiSach_BLL
    {
        LoaiSach_DAL LoaiSachdal = new LoaiSach_DAL();
        public DataTable LoaiSach_Select()
        {
            return LoaiSachdal.LoaiSach_select();
        }

        // Gọi phương thức sach_insert() ở lớp Sach_DAL
        public int LoaiSach_Insert(string MaLoaiSach, string TenLoaiSach)
        {
            return LoaiSachdal.LoaiSach_Insert(MaLoaiSach, TenLoaiSach);
        }

        // Gọi phương thức sach_update() ở lớp Sach_DAL
        public int LoaiSach_Update(string MaLoaiSach, string TenLoaiSach)
        {
            return LoaiSachdal.LoaiSach_Update(MaLoaiSach, TenLoaiSach);
        }

        // Gọi phương thức sach_delete() ở lớp Sach_DAL
        public int LoaiSach_Delete(string MaLoaiSach)
        {
            return LoaiSachdal.LoaiSach_Delete(MaLoaiSach);
        }
        public DataTable LoaiSach_Search(string searchText)
        {
            return LoaiSachdal.LoaiSach_Search(searchText);
        }
        public DataTable LDLLS()
        {
            return LoaiSachdal.LoaiSach_select();
        }
        public int TongSoLoaiSachHienCo()
        {
            DataTable dtLoaiSach = LoaiSachdal.LoaiSach_select();
            return dtLoaiSach.Rows.Count;
        }
    }
}
