using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace QuanLyMuonTraSach
{
    public partial class Form_DangNhap : Form
    {
        DangNhap_BLL DANGNHAP = new DangNhap_BLL();
        public Form_DangNhap()
        {
            InitializeComponent();
            btnLogin.KeyDown += new KeyEventHandler(btnLogin_KeyDown);
        }
        public string tenDangNhap = "";
        public string loaiTaiKhoan = "";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            switch (cbbLoaiTaiKhoan.Text)
            {
                case "admin":
                    loaiTaiKhoan = "admin";
                    break;
                case "lecturer":
                    loaiTaiKhoan = "lecturer";
                    break;
                default:
                    loaiTaiKhoan = "student";
                    break;
            }


            string taiKhoan = txbTenDangNhap.Text;
            string matKhau = txbMatKhau.Text;

            // Gọi stored procedure DangNhap để kiểm tra thông tin đăng nhập
            DataTable dt = DANGNHAP.DangNhap(loaiTaiKhoan, taiKhoan, matKhau);

            if (dt.Rows.Count > 0)
            {
                tenDangNhap = taiKhoan;
                this.Hide();

                if (loaiTaiKhoan == "admin")
                {
                    Form_TrangChu formTrangChu = new Form_TrangChu(tenDangNhap, loaiTaiKhoan);
                    formTrangChu.Show();
                }
                else if (loaiTaiKhoan == "lecturer")
                {
                    Form_TrangChu formLecturer = new Form_TrangChu(tenDangNhap, loaiTaiKhoan);
                    formLecturer.Show();
                }
                else
                {
                    Form_TrangChu formAdmin = new Form_TrangChu(tenDangNhap, loaiTaiKhoan);
                    formAdmin.Show();
                }
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (cbbLoaiTaiKhoan.Text)
                {
                    case "admin":
                        loaiTaiKhoan = "admin";
                        break;
                    case "lecturer":
                        loaiTaiKhoan = "lecturer";
                        break;
                    default:
                        loaiTaiKhoan = "student";
                        break;
                }

                string taiKhoan = txbTenDangNhap.Text;
                string matKhau = txbMatKhau.Text;

                // Gọi stored procedure DangNhap để kiểm tra thông tin đăng nhập
                DataTable dt = DANGNHAP.DangNhap(loaiTaiKhoan, taiKhoan, matKhau);

                if (dt.Rows.Count > 0)
                {
                    tenDangNhap = taiKhoan;
                    this.Hide();

                    if (loaiTaiKhoan == "admin")
                    {
                        Form_TrangChu formTrangChu = new Form_TrangChu(tenDangNhap, loaiTaiKhoan);
                        formTrangChu.Show();
                    }
                    else if (loaiTaiKhoan == "lecturer")
                    {
                        Form_TrangChu formLecturer = new Form_TrangChu(tenDangNhap, loaiTaiKhoan);
                        formLecturer.Show();
                    }
                    else
                    {
                        Form_TrangChu formAdmin = new Form_TrangChu(tenDangNhap, loaiTaiKhoan);
                        formAdmin.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.");
                }
            }
        }

        private void Form_DangNhap_Load_1(object sender, EventArgs e)
        {
            // Thêm các lựa chọn vào ComboBox
            cbbLoaiTaiKhoan.Items.Add("admin");
            cbbLoaiTaiKhoan.Items.Add("student");
            cbbLoaiTaiKhoan.Items.Add("lecturer");
            cbbLoaiTaiKhoan.SelectedIndex = 0; // Chọn mặc định là Quản trị viên
        }
    }
}

