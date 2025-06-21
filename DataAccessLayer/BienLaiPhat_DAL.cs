using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class BienLaiPhat_DAL
    {
        private string connectionString = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QLTVMuonTraSach;Integrated Security=True";

        public DataTable GetBienLaiPhatFromDB(string maPhieuMuon, string maDocGia, string maSach = null)
        {
            DataTable dt = new DataTable();

            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("sp_InBienLaiPhat", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaPhieuMuon", maPhieuMuon);
                    cmd.Parameters.AddWithValue("@MaDocGia", maDocGia ?? (object)DBNull.Value);
                    if (!string.IsNullOrEmpty(maSach))
                        cmd.Parameters.AddWithValue("@MaSach", maSach);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Lỗi truy cập dữ liệu tại {DateTime.Now:dd/MM/yyyy HH:mm}: {ex.Message}");
                }
                finally
                {
                    cn.Close();
                }
            }

            return dt;
        }
    }
}