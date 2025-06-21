using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyMuonTraSach.DAL
{
    public class InThongKe_DAL
    {
        private string ketnoi = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QLTVMuonTraSach;Integrated Security=True";

        public DataTable GetThongKeSoLuongSachDuocMuon(DateTime tuNgay, DateTime denNgay)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(ketnoi))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("ThongKeSoLuongSachDuocMuon", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@TuNgay", tuNgay);
                        cmd.Parameters.AddWithValue("@DenNgay", denNgay);
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi khi thực thi truy vấn: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            return dt;
        }
    }
}