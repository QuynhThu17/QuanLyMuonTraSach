using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Phat_DAL
    {
        ThaoTac_CoSoDuLieu thaotac = new ThaoTac_CoSoDuLieu();

    

        public int TinhTienPhatTheoPhieuMuon(string maPhieuMuon)
        {
            string[] name = { "@MaPhieuMuon" };
            object[] value = { maPhieuMuon };

            DataTable dt = thaotac.SQL_LayDLCDK("sp_TinhTienPhatTheoPhieuMuon", name, value, 1);
            if (dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0]["TongTienPhat"]);
            }
            return 0;
        }
    }
}
