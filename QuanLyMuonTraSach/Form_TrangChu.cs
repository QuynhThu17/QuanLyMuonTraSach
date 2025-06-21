using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace QuanLyMuonTraSach
{
    public partial class Form_TrangChu : Form
    {
        private string tenDangNhap;
        private string loaiTaiKhoan;
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public Form_TrangChu(string tenDangNhap, string loaiTaiKhoan)
        {
            InitializeComponent();
            this.tenDangNhap = tenDangNhap;
            this.loaiTaiKhoan = loaiTaiKhoan;

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
        }

        private Form currentFormChild;
        private Form_MuonTraSach formMTS;

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(0, 128, 128);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                // Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(249, 118, 176);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(249, 118, 176);
            public static Color color4 = Color.FromArgb(249, 118, 176);
            public static Color color5 = Color.FromArgb(249, 118, 176);
            public static Color color6 = Color.FromArgb(249, 118, 176);
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(0, 128, 128);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        public void hideMenu()
        {
            if (panel_System.Visible == true)
            {
                panel_System.Visible = false;
            }
            if (panelquanly1.Visible == true)
            {
                panelquanly1.Visible = false;
            }
            if (panelthongke.Visible == true)
            {
                panelthongke.Visible = false;
            }
            if (paneldubao.Visible == true)
            {
                paneldubao.Visible = false;
            }
            AdjustButtonPositions();
        }

        public void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;

            AdjustButtonPositions();
        }

        private void AdjustButtonPositions()
        {
            int spacing = 16;
            int currentTop = btnHeThong.Bottom + spacing;

            if (panel_System.Visible)
            {
                panelHeThong.Top = currentTop;
                currentTop = panel_System.Bottom + spacing;
            }

            btnQuanLy.Top = currentTop;
            currentTop = btnQuanLy.Bottom + spacing;

            if (panelquanly1.Visible)
            {
                panelquanly1.Top = currentTop;
                currentTop = panelquanly1.Bottom + spacing;
            }          

            btnThongKe.Top = currentTop;
            currentTop = btnThongKe.Bottom + spacing;

            if (panelthongke.Visible)
            {
                panelthongke.Top = currentTop;
                currentTop = panelthongke.Bottom + spacing;
            }

            btnDuBao.Top = currentTop;
            currentTop = btnDuBao.Bottom + spacing;

            if (paneldubao.Visible)
            {
                paneldubao.Top = currentTop;
                currentTop = paneldubao.Bottom + spacing;
            }
        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            ShowSubMenu(panel_System);
            labelMenuContinue.Text = "Hệ thống";
            labelGachcheo.Visible = true;
            labelGachCheo2.Visible = false;
            lblCon2.Visible = false;
        }
        private void btnDuBao_Click_1(object sender, EventArgs e) 
        {
            ActivateButton(sender, RGBColors.color3);
            ShowSubMenu(paneldubao);
            labelMenuContinue.Text = "Dự báo";
            labelGachcheo.Visible = true;
            panelthongke.Visible = false;
            panel_System.Visible = false;
            labelGachCheo2.Visible = false;
            lblCon2.Visible = false;

            AdjustButtonPositions();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            ShowSubMenu(panelthongke);
            labelMenuContinue.Text = "Thống kê";
            labelGachcheo.Visible = true;
        }

        private void btnHome_Click_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lblTitleChildForm.Text = "Trang chủ";
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            ShowSubMenu(panelquanly1);
            labelMenuContinue.Text = "Quản Lý";
            labelGachcheo.Visible = true;
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            if (loaiTaiKhoan == "admin")
            {
                lablevaitro.Text = "Admin";
            }
            else if (loaiTaiKhoan == "student")
            {
                lablevaitro.Text = "Sinh viên";
                labelIDDG.Text = tenDangNhap;
                labelNameId.Text = "Mã sinh viên:";
                btnThongKe.Visible = false;
                btnDuBao.Visible = false;
                btnQLDG.Visible = false;
                icQLNV.Visible = false;
            }
            else if (loaiTaiKhoan == "lecturer")
            {
                lablevaitro.Text = "Giảng viên";
                labelIDDG.Text = tenDangNhap;
                labelNameId.Text = "Mã giảng viên:";
                btnThongKe.Visible = false;
                btnDuBao.Visible = false;
                btnQLDG.Visible = false;
                icQLNV.Visible = false;
            }
            else if (loaiTaiKhoan == "librarian")
            {
                lablevaitro.Text = "Thủ thư";
            }
            hideMenu();
        }

        private void OpenChildForm3(Form childForm)
        {
            if (currentChildForm != null)
            {
                // Close the current child form if one is already open
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop_01.Controls.Add(childForm);
            panelDesktop_01.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnDMK_Click(object sender, EventArgs e)
        {

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_DangNhap form_DangNhap = new Form_DangNhap();
            form_DangNhap.ShowDialog();
            hideMenu();
        }

        private void btnQuaTrinhDKH_Click(object sender, EventArgs e)
        {
            OpenChildForm3(new Form_TrangChu(tenDangNhap, loaiTaiKhoan));
            lblTitleChildForm.Text = "Trang chủ";
            labelMenuContinue.Text = "Quản lý";
            lblCon2.Text = "Trang chủ";

            labelGachcheo.Visible = true;
            labelGachCheo2.Visible = true;
            lblCon2.Visible = true;
            hideMenu();
        }

        private void icbtnQLMTS_Click(object sender, EventArgs e)
        {
            OpenChildForm3(new Form_MuonTraSach(loaiTaiKhoan));
            lblTitleChildForm.Text = "Trang chủ";
            labelMenuContinue.Text = "Quản lý";
            lblCon2.Text = "Quản lý mượn trả sách";

            labelGachcheo.Visible = true;
            labelGachCheo2.Visible = true;
            lblCon2.Visible = true;
            hideMenu();
        }

        private void icQLS_Click(object sender, EventArgs e)
        {
            OpenChildForm3(new Form_Sach(loaiTaiKhoan));
            lblTitleChildForm.Text = "Trang chủ";
            labelMenuContinue.Text = "Quản lý";
            lblCon2.Text = "Quản lý sách";

            labelGachcheo.Visible = true;
            labelGachCheo2.Visible = true;
            lblCon2.Visible = true;
            hideMenu();
        }

        private void icQLNV_Click(object sender, EventArgs e)
        {
            OpenChildForm3(new Form_NhanVien());
            lblTitleChildForm.Text = "Trang chủ";
            labelMenuContinue.Text = "Quản lý";
            lblCon2.Text = "Quản lý nhân viên";

            labelGachcheo.Visible = true;
            labelGachCheo2.Visible = true;
            lblCon2.Visible = true;
            hideMenu();
        }

        private void btnQLBP_Click(object sender, EventArgs e)
        {
            OpenChildForm3(new Form_BoPhan());
            lblTitleChildForm.Text = "Trang chủ";
            labelMenuContinue.Text = "Quản lý";
            lblCon2.Text = "Quản lý bộ phận";

            labelGachcheo.Visible = true;
            labelGachCheo2.Visible = true;
            lblCon2.Visible = true;
            hideMenu();
        }

        private void icbtnLichSu_Click(object sender, EventArgs e)
        {
            OpenChildForm3(new Form_LichSu(new Form_MuonTraSach(loaiTaiKhoan), tenDangNhap, loaiTaiKhoan));
            lblTitleChildForm.Text = "Trang chủ";
            labelMenuContinue.Text = "Quản lý";
            lblCon2.Text = "Lịch sử";

            labelGachcheo.Visible = true;
            labelGachCheo2.Visible = true;
            lblCon2.Visible = true;
            hideMenu();
        }

        private void btnQLDG_Click(object sender, EventArgs e)
        {
            OpenChildForm3(new Form_DocGia());
            lblTitleChildForm.Text = "Trang chủ";
            labelMenuContinue.Text = "Quản lý";
            lblCon2.Text = "Độc giả";

            labelGachcheo.Visible = true;
            labelGachCheo2.Visible = true;
            lblCon2.Visible = true;
            hideMenu();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            OpenChildForm3(new Form_ThongKe());
            lblTitleChildForm.Text = "Trang chủ";
            labelMenuContinue.Text = "Thống kê";
            lblCon2.Text = "Thống kê tổng hợp";

            labelGachcheo.Visible = true;
            labelGachCheo2.Visible = true;
            lblCon2.Visible = true;
            hideMenu();
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            OpenChildForm3(new Forrm_SachDuocMuonNhieuNhat());
            lblTitleChildForm.Text = "Trang chủ";
            labelMenuContinue.Text = "Thống kê";
            lblCon2.Text = "Thống kê sách được mượn nhiều nhất";

            labelGachcheo.Visible = true;
            labelGachCheo2.Visible = true;
            lblCon2.Visible = true;
            hideMenu();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            OpenChildForm3(new Form_DocGiaMuonNhieu_PieChart());
            lblTitleChildForm.Text = "Trang chủ";
            labelMenuContinue.Text = "Thống kê";
            lblCon2.Text = "Thống kê độc giả mượn nhiều sách nhất";

            labelGachcheo.Visible = true;
            labelGachCheo2.Visible = true;
            lblCon2.Visible = true;
            hideMenu();
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            OpenChildForm3(new Form_DuBaoXuHuongMuonSach());
            lblTitleChildForm.Text = "Trang chủ";
            labelMenuContinue.Text = "Dự báo";
            lblCon2.Text = "Dự báo xu hướng mượn sách";

            labelGachcheo.Visible = true;
            labelGachCheo2.Visible = true;
            lblCon2.Visible = true;
            hideMenu();
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            OpenChildForm3(new Form_DuBaoHoanTra());
            lblTitleChildForm.Text = "Trang chủ";
            labelMenuContinue.Text = "Dự báo";
            lblCon2.Text = "Tỷ lệ hoàn trả";

            labelGachcheo.Visible = true;
            labelGachCheo2.Visible = true;
            lblCon2.Visible = true;
            hideMenu();
        }
    }
}