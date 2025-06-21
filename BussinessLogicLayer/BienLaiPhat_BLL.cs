using System;
using System.Data;
using DataAccessLayer;

namespace BussinessLogicLayer
{
    public class BienLaiPhat_BLL
    {
        private readonly BienLaiPhat_DAL dal = new BienLaiPhat_DAL();

        public DataTable GetBienLaiPhatData(string maPhieuMuon, string maDocGia, string maSach = null)
        {
            try
            {
                if (string.IsNullOrEmpty(maPhieuMuon) || string.IsNullOrEmpty(maDocGia))
                    throw new ArgumentException("Mã phiếu mượn hoặc mã độc giả không được để trống!");

                return dal.GetBienLaiPhatFromDB(maPhieuMuon, maDocGia, maSach);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi xử lý nghiệp vụ tại {DateTime.Now:dd/MM/yyyy HH:mm}: {ex.Message}");
            }
        }
    }
}