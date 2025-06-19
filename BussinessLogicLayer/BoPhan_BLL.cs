using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BussinessLogicLayer
{
    public class BoPhan_BLL
    {
        BoPhan_DAL BoPhanDal = new BoPhan_DAL();
        public DataTable BoPhan_Select()
        {
            return BoPhanDal.BoPhan_Select();
        }

        public int BoPhan_Insert(string MaBoPhan, string TenBoPhan)
        {
            return BoPhanDal.BoPhan_Insert(MaBoPhan, TenBoPhan);
        }

        public int BoPhan_Update(string MaBoPhan, string TenBoPhan)
        {
            return BoPhanDal.BoPhan_Update(MaBoPhan, TenBoPhan);
        }

        public int BoPhan_Delete(string MaBoPhan)
        {
            return BoPhanDal.BoPhan_Delete(MaBoPhan);
        }

        public DataTable BoPhan_Search(string MaBoPhan)
        {
            return BoPhanDal.BoPhan_Search(MaBoPhan);
        }

        public DataTable LDLBP()
        {
            return BoPhanDal.BoPhan_Select();
        }
    }

}
