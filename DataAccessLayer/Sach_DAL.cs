using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Sach_DAL
    {
        ThaoTac_CoSoDuLieu thaotac = new ThaoTac_CoSoDuLieu();
        string[] name = { };
        object[] value = { };
        public DataTable Sach_Select()
        {
            return thaotac.SQL_Laydulieu("Sach_Select");
        }

        public int Sach_Insert(string MaSach, string TenSach, string MaTacGia, string MaXB, string MaLoai, string SoTrang, string GiaBan, string SoLuong, DateTime ThoiGianPhatHanh)
        {
            name = new string[9];
            value = new object[9];

            name[0] = "@MaSach"; value[0] = MaSach;
            name[1] = "@TenSach"; value[1] = TenSach;
            name[2] = "@MaTacGia"; value[2] = MaTacGia;
            name[3] = "@MaXB"; value[3] = MaXB;
            name[4] = "@MaLoai"; value[4] = MaLoai;
            name[5] = "@SoTrang"; value[5] = SoTrang;
            name[6] = "@GiaBan"; value[6] = GiaBan;
            name[7] = "@SoLuong"; value[7] = SoLuong;
            name[8] = "@ThoiGianPhatHanh"; value[8] = ThoiGianPhatHanh;

            return thaotac.SQL_Thuchien("Sach_Insert", name, value, 9);
        }

        public int Sach_Update(string MaSach, string TenSach, string MaTacGia, string MaXB, string MaLoai, string SoTrang, string GiaBan, string SoLuong, DateTime ThoiGianPhatHanh)
        {
            name = new string[9];
            value = new object[9];

            name[0] = "@MaSach"; value[0] = MaSach;
            name[1] = "@TenSach"; value[1] = TenSach;
            name[2] = "@MaTacGia"; value[2] = MaTacGia;
            name[3] = "@MaXB"; value[3] = MaXB;
            name[4] = "@MaLoai"; value[4] = MaLoai;
            name[5] = "@SoTrang"; value[5] = SoTrang;
            name[6] = "@GiaBan"; value[6] = GiaBan;
            name[7] = "@SoLuong"; value[7] = SoLuong;
            name[8] = "@ThoiGianPhatHanh"; value[8] = ThoiGianPhatHanh;

            return thaotac.SQL_Thuchien("Sach_Update", name, value, 9);
        }

        public int Sach_Delete(string MaSach)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaSach"; value[0] = MaSach;
            return thaotac.SQL_Thuchien("Sach_Delete", name, value, 1);
        }

        public DataTable Sach_Search(string TenSach)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@TenSach"; value[0] = TenSach;
            return thaotac.SQL_LayDLCDK("Sach_Search", name, value, 1);
        }
        public void Sach_UpdateSoLuong(string maSach, int soLuongMoi)
        {
            string tenProc = "Sach_UpdateSoLuong"; // Giả sử bạn có stored procedure để cập nhật số lượng
            string[] parameterNames = { "@MaSach", "@SoLuong" };
            object[] parameterValues = { maSach, soLuongMoi };
            int soLuongThamSo = 2;

            thaotac.SQL_Thuchien(tenProc, parameterNames, parameterValues, soLuongThamSo);
        }
    }



}

