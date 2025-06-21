using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BussinessLogicLayer
{
    public class TacGia_BLL
    {
        TacGia_DAL TacGiaDal = new TacGia_DAL();
        public DataTable TacGia_Select()
        {
            return TacGiaDal.TacGia_Select();
        }

        public int TacGia_Insert(string MaTacGia, string TenTacGia)
        {
            return TacGiaDal.TacGia_Insert(MaTacGia, TenTacGia);
        }

        public int TacGia_Update(string MaTacGia, string TenTacGia)
        {
            return TacGiaDal.TacGia_Update(MaTacGia, TenTacGia);
        }

        public int TacGia_Delete(string MaTacGia)
        {
            return TacGiaDal.TacGia_Delete(MaTacGia);
        }

        public DataTable TacGia_Search(string TenTacGia)
        {
            return TacGiaDal.TacGia_Search(TenTacGia);
        }

        public DataTable LDLTG()
        {
            return TacGiaDal.TacGia_Select();
        }
        public int TongSoTacGiaHienCo()
        {
            DataTable dtLoaiSach = TacGiaDal.TacGia_Select();
            return dtLoaiSach.Rows.Count;
        }
    }
}
