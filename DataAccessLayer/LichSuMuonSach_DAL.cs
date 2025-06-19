using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class LichSuMuonSach_DAL
    {
        ThaoTac_CoSoDuLieu thaotac = new ThaoTac_CoSoDuLieu();
        string[] name = { };
        object[] value = { };

        public int LichSu_Insert(string maPM, string maDG, string maNV, DateTime ngayMuon, DateTime ngayTra, string ghiChu, string maSach, int soLuong)
        {
            name = new string[8];
            value = new object[8];

            name[0] = "@MaPhieuMuon"; value[0] = maPM;
            name[1] = "@MaDocGia"; value[1] = maDG;
            name[2] = "@MaNhanVien"; value[2] = maNV;
            name[3] = "@NgayMuon"; value[3] = ngayMuon;
            name[4] = "@NgayTra"; value[4] = ngayTra;
            name[5] = "@GhiChu"; value[5] = ghiChu;
            name[6] = "@MaSach"; value[6] = maSach;
            name[7] = "@SoLuong"; value[7] = soLuong;

            return thaotac.SQL_Thuchien("LichSuMuonSach_Insert", name, value, 8);
        }

        public DataTable LichSu_SelectAll()
        {
            return thaotac.SQL_Laydulieu("LichSuMuonSach_SelectAll");
        }

        public DataTable LayLichSuTheoMaDocGia(string maDocGia)
        {
            // Sử dụng kết nối trực tiếp để xử lý tham số với stored procedure đúng
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QLTVMuonTraSach;Integrated Security=True"))
            {
                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("LichSuMuonSach_SelectByMaDocGia", cn); // Sử dụng stored procedure đúng
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaDocGia", maDocGia);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi khi lấy dữ liệu lịch sử theo MaDocGia: " + ex.Message);
                }
            }
            return dt;
        }

        public int XoaLichSu(int maLichSu)
        {
            string[] name = { "@MaLichSu" };
            object[] value = { maLichSu };
            return thaotac.SQL_Thuchien("LichSuMuonSach_Delete", name, value, 1);
        }

        public void ResetLaiMaLichSu()
        {
            string[] name = new string[0];
            object[] value = new object[0];
            thaotac.SQL_Thuchien("LichSuMuonSach_ResetMaLichSu", name, value, 0);
        }
    }
}