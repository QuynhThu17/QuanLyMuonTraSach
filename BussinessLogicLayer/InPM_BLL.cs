using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BussinessLogicLayer
{
    public class InPM_BLL
    {
        
            private InPM_DAL phieuMuonDataAccess = new InPM_DAL();

            public DataTable GetPhieuMuon(string MaPhieuMuon)
            {
                return phieuMuonDataAccess.GetPhieuMuonData(MaPhieuMuon);
            }
        

    }
}
