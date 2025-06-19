using System;
using System.Data;
using DataAccessLayer;

namespace BussinessLogicLayer
{
    public class BienLaiPhat_BLL
    {
        private BienLaiPhat_DAL phatDataAccess = new BienLaiPhat_DAL(); // Phải là BienLaiPhat_DAL

        public DataTable GetPhatData(string MaPhieuMuon)
        {
            try
            {
                return phatDataAccess.GetPhatData(MaPhieuMuon);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi trong logic kinh doanh: " + ex.Message);
            }
        }
    }
}