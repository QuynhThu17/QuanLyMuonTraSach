using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BussinessLogicLayer
{
    public class Phat_BLL
    {
        Phat_DAL dal = new Phat_DAL();

        public int TinhTienPhatTheoPhieuMuon(string maPhieuMuon)
        {
            return dal.TinhTienPhatTheoPhieuMuon(maPhieuMuon);
        }
    }
}
