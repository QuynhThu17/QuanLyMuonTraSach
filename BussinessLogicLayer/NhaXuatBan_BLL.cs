using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BussinessLogicLayer
{
    public class NhaXuatBan_BLL
    {
        NhaXuatBan_DAL NhaXuatBanDal = new NhaXuatBan_DAL();
        public DataTable NhaXuatBan_Select()
        {
            return NhaXuatBanDal.NhaXuatBan_Select();
        }

        public int NhaXuatBan_Insert(string MaXB, string TenXB)
        {
            return NhaXuatBanDal.NhaXuatBan_Insert(MaXB, TenXB);
        }

        public int NhaXuatBan_Update(string MaXB, string TenXB)
        {
            return NhaXuatBanDal.NhaXuatBan_Update(MaXB, TenXB);
        }

        public int NhaXuatBan_Delete(string MaXB)
        {
            return NhaXuatBanDal.NhaXuatBan_Delete(MaXB);
        }

        public DataTable NhaXuatBan_Search(string TenXB)
        {
            return NhaXuatBanDal.NhaXuatBan_Search(TenXB);
        }

        public DataTable LDLNXB()
        {
            return NhaXuatBanDal.NhaXuatBan_Select();
        }
    }
}
