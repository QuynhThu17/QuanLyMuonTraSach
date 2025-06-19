using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ChiTietMTS_DAL
    {
        ThaoTac_CoSoDuLieu thaotac = new ThaoTac_CoSoDuLieu();
        string[] name = { };
        object[] value = { };
        public DataTable ChiTietMuonTraSach_Select()
        {
            return thaotac.SQL_Laydulieu("ChiTietMuonTraSach_Select");
        }

        public int ChiTietMuonTraSach_Insert(string MaPhieuMuon, string MaSach, int SoLuong)
        {
            name = new string[3];
            value = new object[3];

            name[0] = "@MaPhieuMuon"; value[0] = MaPhieuMuon;
            name[1] = "@MaSach"; value[1] = MaSach;
            name[2] = "@SoLuong"; value[2] = SoLuong;

            return thaotac.SQL_Thuchien("ChiTietMuonTraSach_Insert", name, value, 3);
        }

        public int ChiTietMuonTraSach_Update(string MaPhieuMuon, string MaSach, int SoLuong)
        {
            name = new string[3];
            value = new object[3];

            name[0] = "@MaPhieuMuon"; value[0] = MaPhieuMuon;
            name[1] = "@MaSach"; value[1] = MaSach;
            name[2] = "@SoLuong"; value[2] = SoLuong;

            return thaotac.SQL_Thuchien("ChiTietMuonTraSach_Update", name, value, 3);
        }

        public int ChiTietMuonTraSach_Delete(string MaPhieuMuon, string MaSach)
        {
            name = new string[2];
            value = new object[2];

            name[0] = "@MaPhieuMuon"; value[0] = MaPhieuMuon;
            name[1] = "@MaSach"; value[1] = MaSach;


            return thaotac.SQL_Thuchien("ChiTietMuonTraSach_Delete", name, value, 2);
        }

        public DataTable ChiTietMuonTraSach_Search(string MaPhieuMuon)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaPhieuMuon"; value[0] = MaPhieuMuon;
            return thaotac.SQL_LayDLCDK("ChiTietMuonTraSach_Search", name, value, 1);
        }

        public int CapNhatTraSach(string maPM, string maSach, int soLuongTra, DateTime ngayTraThucTe)
        {
            string[] name = { "@MaPhieuMuon", "@MaSach", "@SoLuongTra", "@NgayTraThucTe" };
            object[] value = { maPM, maSach, soLuongTra, ngayTraThucTe };
            return thaotac.SQL_Thuchien("CapNhatTraSach", name, value, 4);
        }

    }
}

