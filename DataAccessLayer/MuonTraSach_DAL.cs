using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class MuonTraSach_DAL
    {
        ThaoTac_CoSoDuLieu thaotac = new ThaoTac_CoSoDuLieu(); 
        string[] name = { }; 
        object[] value = { };
        public DataTable MuonTraSach_Select()
        {
            return thaotac.SQL_Laydulieu("MuonTraSach_Select");
        }

        public int MuonTraSach_Insert(string MaPhieuMuon, string MaDocGia, string MaNhanVien, DateTime NgayMuon, DateTime? NgayTra, string GhiChu)
        {
            name = new string[6];
            value = new object[6];

            name[0] = "@MaPhieuMuon"; value[0] = MaPhieuMuon;
            name[1] = "@MaDocGia"; value[1] = MaDocGia;
           
            name[2] = "@MaNhanVien"; value[2] = MaNhanVien;
            name[3] = "@NgayMuon"; value[3] = NgayMuon;
            name[4] = "@NgayTra"; value[4] = NgayTra;
            name[5] = "@GhiChu"; value[5] = GhiChu;

            return thaotac.SQL_Thuchien("MuonTraSach_Insert", name, value, 6);
        }

        public int MuonTraSach_Update(string MaPhieuMuon, string MaDocGia,  string MaNhanVien, DateTime NgayMuon, DateTime? NgayTra, string GhiChu)
        {
            name = new string[6];
            value = new object[6];

            name[0] = "@MaPhieuMuon"; value[0] = MaPhieuMuon;
            name[1] = "@MaDocGia"; value[1] = MaDocGia;

            name[2] = "@MaNhanVien"; value[2] = MaNhanVien;
            name[3] = "@NgayMuon"; value[3] = NgayMuon;
            name[4] = "@NgayTra"; value[4] = NgayTra;
            name[5] = "@GhiChu"; value[5] = GhiChu;

            

            return thaotac.SQL_Thuchien("MuonTraSach_Update", name, value, 6);
        }

        public int MuonTraSach_Delete(string MaPhieuMuon)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaPhieuMuon"; value[0] = MaPhieuMuon;
            return thaotac.SQL_Thuchien("MuonTraSach_Delete", name, value, 1);
        }

        public DataTable MuonTraSach_Search(string MaPhieuMuon)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaPhieuMuon"; value[0] = MaPhieuMuon;
            return thaotac.SQL_LayDLCDK("MuonTraSach_Search", name, value, 1);
        }

        public int GiaHan(string maPM, DateTime ngayGiaHan)
        {
            string[] name = { "@MaPhieuMuon", "@NgayGiaHan" };
            object[] value = { maPM, ngayGiaHan };
            return thaotac.SQL_Thuchien("MuonTraSach_GiaHan", name, value, 2);
        }

    }
}

