using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;

namespace BussinessLogicLayer
{
    public class MuonTraSach_BLL
    {
        MuonTraSach_DAL MuonTraSachDal = new MuonTraSach_DAL();
        public DataTable MuonTraSach_Select()
        {
            return MuonTraSachDal.MuonTraSach_Select();
        }

        public int MuonTraSach_Insert(string MaPhieuMuon, string MaDocGia, string MaNhanVien, DateTime NgayMuon, DateTime? NgayTra, string GhiChu)
        {
            return MuonTraSachDal.MuonTraSach_Insert(MaPhieuMuon, MaDocGia, MaNhanVien, NgayMuon, NgayTra, GhiChu);
        }

        public int MuonTraSach_Update(string MaPhieuMuon, string MaDocGia,  string MaNhanVien, DateTime NgayMuon, DateTime? NgayTra, string GhiChu)
        {
            return MuonTraSachDal.MuonTraSach_Update(MaPhieuMuon, MaDocGia, MaNhanVien, NgayMuon, NgayTra, GhiChu);
        }

        public int MuonTraSach_Delete(string MaPhieuMuon)
        {
            return MuonTraSachDal.MuonTraSach_Delete(MaPhieuMuon);
        }

        public DataTable MuonTraSach_Search(string MaPhieuMuon)
        {
            return MuonTraSachDal.MuonTraSach_Search(MaPhieuMuon);
        }

        public DataTable LDLMTS()
        {
            return MuonTraSachDal.MuonTraSach_Select();
        }
        public int GiaHan(string maPM, DateTime ngayGiaHan)
        {
            return MuonTraSachDal.GiaHan(maPM, ngayGiaHan);
        }
    }
}

