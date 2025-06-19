using System;
using System.Data;
using DataAccessLayer;

namespace BussinessLogicLayer
{
    public class LichSuMuonSach_BLL
    {
        private LichSuMuonSach_DAL lichSuDAL = new LichSuMuonSach_DAL();

        public DataTable LayTatCa()
        {
            try
            {
                return lichSuDAL.LichSu_SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi trong logic kinh doanh: " + ex.Message);
            }
        }

        public DataTable LayLichSuTheoMaDocGia(string maDocGia)
        {
            try
            {
                return lichSuDAL.LayLichSuTheoMaDocGia(maDocGia);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi trong logic kinh doanh: " + ex.Message);
            }
        }

        public int ThemLichSu(string maPM, string maDG, string maNV, DateTime ngayMuon, DateTime ngayTra, string ghiChu, string maSach, int soLuong)
        {
            try
            {
                return lichSuDAL.LichSu_Insert(maPM, maDG, maNV, ngayMuon, ngayTra, ghiChu, maSach, soLuong);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi trong logic kinh doanh: " + ex.Message);
            }
        }

        public int XoaLichSu(int maLichSu)
        {
            try
            {
                return lichSuDAL.XoaLichSu(maLichSu);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi trong logic kinh doanh: " + ex.Message);
            }
        }

        public void ResetLaiMaLichSu()
        {
            try
            {
                lichSuDAL.ResetLaiMaLichSu();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi trong logic kinh doanh: " + ex.Message);
            }
        }
    }
}