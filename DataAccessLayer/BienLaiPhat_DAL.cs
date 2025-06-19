using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class BienLaiPhat_DAL
    {
        private string ketnoi = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QLTVMuonTraSach;Integrated Security=True";

        public DataTable GetPhatData(string MaPhieuMuon)
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
                            dg.DiaChi,
                            dg.NgaySinh,
                            s.MaSach,
                            s.TenSach,
                            cts.SoLuong,
                            mts.NgayTra,
                            ls.NgayGhiNhan,
                            CASE 
                                WHEN ls.NgayGhiNhan > mts.NgayTra THEN 
                                    cts.SoLuong * DATEDIFF(day, mts.NgayTra, ls.NgayGhiNhan) * 2000 
                                ELSE 0 
                            END AS TienPhat
                        FROM MuonTraSach mts
                        JOIN DocGia dg ON mts.MaDocGia = dg.MaDocGia
                        JOIN ChiTietMuonTraSach cts ON mts.MaPhieuMuon = cts.MaPhieuMuon
                        JOIN Sach s ON cts.MaSach = s.MaSach
                        JOIN LichSuMuonSach ls ON mts.MaPhieuMuon = ls.MaPhieuMuon
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