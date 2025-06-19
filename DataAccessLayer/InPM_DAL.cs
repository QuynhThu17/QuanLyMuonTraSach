using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class InPM_DAL
    {
        private string ketnoi = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QLTVMuonTraSach;Integrated Security=True";

        public DataTable GetPhieuMuonData(string MaPhieuMuon)
        {
            using (SqlConnection cn = new SqlConnection(ketnoi))
            {
                try
                {
                    cn.Open();
                    string SQL = @"
                SELECT 
                    mts.MaPhieuMuon,
                    dg.HoTenDocGia AS TenDocGia,
                    mts.MaDocGia,
                    mts.NgayMuon,
                    mts.NgayTra,
                    nv.HoTen AS TenNhanVien,
                    s.MaSach,
                    s.TenSach,
                    nx.TenXB AS NhaXuatBan,
                    cts.SoLuong,
                    mts.GhiChu
                FROM MuonTraSach mts
                JOIN DocGia dg ON mts.MaDocGia = dg.MaDocGia
                JOIN NhanVien nv ON mts.MaNhanVien = nv.MaNhanVien
                JOIN ChiTietMuonTraSach cts ON mts.MaPhieuMuon = cts.MaPhieuMuon
                JOIN Sach s ON cts.MaSach = s.MaSach
                JOIN NhaXuatBan nx ON s.MaXB = nx.MaXB
                WHERE mts.MaPhieuMuon = @MaPhieuMuon";
                    SqlDataAdapter da = new SqlDataAdapter(SQL, cn);
                    da.SelectCommand.Parameters.AddWithValue("@MaPhieuMuon", MaPhieuMuon);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count == 0)
                    {
                        throw new Exception("Không tìm thấy dữ liệu cho phiếu mượn: " + MaPhieuMuon);
                    }
                    return dt;
                }
                catch (SqlException ex)
                {
                    throw new Exception("Lỗi kết nối cơ sở dữ liệu: " + ex.Message);
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi khi lấy dữ liệu: " + ex.Message);
                }
            }
        }

    }
}
