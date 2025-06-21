using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class ThongKe_DAL
    {
        private string connectionString = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QLMuonTraSach;Integrated Security=True";

        public int GetSoLuongNhanVien()
        {
            return ExecuteScalar("SELECT COUNT(*) FROM NhanVien");
        }

        public int GetSoLuongSinhVien()
        {
            return ExecuteScalar("SELECT COUNT(*) FROM SinhVien");
        }

        public int GetSoLuongSach()
        {
            return ExecuteScalar("SELECT COUNT(*) FROM Sach");
        }

        public int GetSoLuongPhieuMuon()
        {
            return ExecuteScalar("SELECT COUNT(*) FROM MuonTraSach");
        }

        public int GetSoLuongLoaiSach()
        {
            return ExecuteScalar("SELECT COUNT(*) FROM LoaiSach");
        }

        public int GetSoLuongTacGia()
        {
            return ExecuteScalar("SELECT COUNT(*) FROM TacGia");
        }

        public int GetSoLuongNhaXuatBan()
        {
            return ExecuteScalar("SELECT COUNT(*) FROM NhaXuatBan");
        }

        private int ExecuteScalar(string query)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }
    }
}
