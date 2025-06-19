using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BussinessLogicLayer
{
    public class ChiTietMTS_BLL
    {
        ChiTietMTS_DAL ChiTietMuonTraSachDal = new ChiTietMTS_DAL();
        public DataTable ChiTietMuonTraSach_Select()
        {
            return ChiTietMuonTraSachDal.ChiTietMuonTraSach_Select();
        }

        public int ChiTietMuonTraSach_Insert(string MaPhieuMuon, string MaSach, int SoLuong)
        {
            return ChiTietMuonTraSachDal.ChiTietMuonTraSach_Insert(MaPhieuMuon, MaSach, SoLuong);
        }

        public int ChiTietMuonTraSach_Update(string MaPhieuMuon, string MaSach, int SoLuong)
        {
            return ChiTietMuonTraSachDal.ChiTietMuonTraSach_Update(MaPhieuMuon, MaSach, SoLuong);
        }

        public int ChiTietMuonTraSach_Delete(string MaPhieuMuon, string MaSach)
        {
            return ChiTietMuonTraSachDal.ChiTietMuonTraSach_Delete(MaPhieuMuon, MaSach);
        }

        public DataTable ChiTietMuonTraSach_Search(string MaPhieuMuon)
        {
            return ChiTietMuonTraSachDal.ChiTietMuonTraSach_Search(MaPhieuMuon);
        }

        public DataTable LDLCTMTS()
        {
            return ChiTietMuonTraSachDal.ChiTietMuonTraSach_Select();
        }

        public int CapNhatTraSach(string maPM, string maSach, int soLuongTra, DateTime ngayTraThucTe)
        {
            return ChiTietMuonTraSachDal.CapNhatTraSach(maPM, maSach, soLuongTra, ngayTraThucTe);
        }

    }
}

