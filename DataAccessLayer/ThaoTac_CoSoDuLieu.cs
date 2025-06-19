using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    internal class ThaoTac_CoSoDuLieu
    {
        
            SqlConnection cn;
            SqlCommand cmd;
            SqlDataAdapter da;
            DataTable dt;
            //string sql;
            private void KetnoiCSDL()
            {
                cn = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QLTVMuonTraSach;Integrated Security=True");
                cn.Open();
            }
            private void NgatKetNoi()
            {
                cn.Close();
                cn.Dispose();
            }
            //phương thức thực thi Select dữ liệu
            public DataTable SQL_Laydulieu(string Ten)
            {
                KetnoiCSDL();
                //thực thi lấy dữ liệu từ CSDL
                cmd = new SqlCommand(Ten, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                //ngắt kết nối
                NgatKetNoi();
                //trả về bảng chứa dữ liệu lấy được.
                return dt;
            }

            public DataTable SQL_LayDLCDK(string Ten, string[] name, object[] value, int NPara)
            {
                KetnoiCSDL();
                 cmd = new SqlCommand(Ten, cn); // kết nối csdl
                cmd.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i < NPara; i++)
                {
                    cmd.Parameters.AddWithValue(name[i], value[i]);

                }
                SqlDataAdapter dat = new SqlDataAdapter(cmd); //kết nối dl về
                DataTable dt = new DataTable();
                dat.Fill(dt);
                NgatKetNoi();
                return dt;
            }
            public int SQL_Thuchien(string Ten, string[] name, object[] value, int Npara)
            {
                KetnoiCSDL();
                 cmd = new SqlCommand(Ten, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i < Npara; i++)
                {
                    cmd.Parameters.AddWithValue(name[i], value[i]);
                }
                return cmd.ExecuteNonQuery();
            }

    }



}
