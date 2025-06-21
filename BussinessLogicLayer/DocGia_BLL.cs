using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BussinessLogicLayer
{
    public class DocGia_BLL
    {
         DocGia_DAL DocGiaDal = new DocGia_DAL();
        public DataTable DocGia_Select()
        {
            return DocGiaDal.DocGia_Select();
        }

        public int DocGia_Insert(string MaDocGia, string HoTenDocGia, string Lop, string GioiTinh, DateTime NgaySinh, string SDT, string DiaChi, string VaiTro)
        {
            return DocGiaDal.DocGia_Insert(MaDocGia, HoTenDocGia, Lop, GioiTinh, NgaySinh, SDT, DiaChi, VaiTro);
        }

        public int DocGia_Update(string MaDocGia, string HoTenDocGia, string Lop, string GioiTinh, DateTime NgaySinh, string SDT, string DiaChi, string VaiTro)
        {
            return DocGiaDal.DocGia_Update(MaDocGia, HoTenDocGia, Lop, GioiTinh, NgaySinh, SDT, DiaChi, VaiTro);
        }

        public int DocGia_Delete(string MaDocGia)
        {
            return DocGiaDal.DocGia_Delete(MaDocGia);
        }

        public DataTable DocGia_Search(string HoTenDocGia)
        {
            return DocGiaDal.DocGia_Search(HoTenDocGia);
        }

        public DataTable LDLDG()
        {
            return DocGiaDal.DocGia_Select();
        }
        public int TongSoDocGiaHienCo()
        {
            DataTable dtLoaiSach = DocGiaDal.DocGia_Select();
            return dtLoaiSach.Rows.Count;
        }

    }

}
