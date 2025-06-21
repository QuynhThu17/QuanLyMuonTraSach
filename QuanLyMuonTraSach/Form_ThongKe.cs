using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLogicLayer;

namespace QuanLyMuonTraSach
{
    public partial class Form_ThongKe : Form
    {
        private Sach_BLL sachBLL = new Sach_BLL();
        LoaiSach_BLL loaiSachBLL = new LoaiSach_BLL();
        NhaXuatBan_BLL nhaXB_BLL = new NhaXuatBan_BLL();
        TacGia_BLL tacGiaBLL = new TacGia_BLL();
        DocGia_BLL docGiaBLL = new DocGia_BLL();
        NhanVien_BLL nhanVienBLL = new NhanVien_BLL();
        ChiTietMTS_BLL chiTietMTS_BLL = new ChiTietMTS_BLL();
        public Form_ThongKe()
        {
            InitializeComponent();
        }

        private void dgvDSMuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form_ThongKe_Load(object sender, EventArgs e)
        {
            int tongSach = sachBLL.TongSoSachHienCo();
            lblTongSach.Text = tongSach.ToString();

            int tongLoaiSach = loaiSachBLL.TongSoLoaiSachHienCo();
            lblLoaiSach.Text = tongLoaiSach.ToString();

            int tongNhaXuatBan = nhaXB_BLL.TongSoNhaXuatBanHienCo();
            lblNhaXuatBan.Text = tongNhaXuatBan.ToString();

            int tongTacGia = tacGiaBLL.TongSoTacGiaHienCo();
            lblTacGia.Text = tongTacGia.ToString();

            int tongDocGia = docGiaBLL.TongSoDocGiaHienCo();
            lblDocGia.Text = tongDocGia.ToString();

            int tongNhanVien = nhanVienBLL.TongSoNhanVienHienCo();
            lblNhanVien.Text = tongNhanVien.ToString();

            int tongSachDangMuon = chiTietMTS_BLL.TongSoSachDangMuon();
            lblSachMuon.Text = tongSachDangMuon.ToString();
        }

        private void TkSach_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
