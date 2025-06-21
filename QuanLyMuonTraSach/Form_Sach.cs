using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLogicLayer;

namespace QuanLyMuonTraSach
{
    public partial class Form_Sach : Form
    {
        Sach_BLL SachBLL = new Sach_BLL();
        NhaXuatBan_BLL NXB = new NhaXuatBan_BLL();
        LoaiSach_BLL LS = new LoaiSach_BLL();
        TacGia_BLL TG = new TacGia_BLL();
        public Form_Sach()
        {
            InitializeComponent();
            dgvSACH.DataSource = SachBLL.Sach_Select();
            dgvSACH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSACH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        }

        private void Sach_Load(object sender, EventArgs e)
        {
            cbbNhaXuatban.DataSource = NXB.LDLNXB();
            cbbNhaXuatban.DisplayMember = "TenNhaXuatBan";
            cbbNhaXuatban.ValueMember = "MaXB";

            cbbLoaiSach.DataSource = LS.LDLLS();
            cbbLoaiSach.DisplayMember = "TenLoai";
            cbbLoaiSach.ValueMember = "MaLoai";

            cbbTacGia.DataSource = TG.LDLTG();
            cbbTacGia.DisplayMember = "TenTacGia";
            cbbTacGia.ValueMember = "MaTacGia";

        }

        private void btnLuuu_Click(object sender, EventArgs e)
        {
           
            SachBLL.Sach_Insert(
                         txtMaSach.Text,
                          txtTenSach.Text,
                          cbbTacGia.Text,
                          cbbNhaXuatban.Text,
                          cbbLoaiSach.Text,
                          txtSoTrang.Text,
                          nubGiaBan.Value.ToString(),
                          nubSoLuong.Value.ToString(),
                          dtpTGPH.Value
                    );
            dgvSACH.DataSource = SachBLL.Sach_Select();
        }

        private void btnTaoM_Click(object sender, EventArgs e)
        {
            DataTable dt = SachBLL.Sach_Select();
            txtMaSach.Text = SinhMaSachTuDong(dt);
            txtMaSach.Enabled = false;

           
            txtTenSach.Clear();
            cbbTacGia.SelectedIndex = -1;
            cbbNhaXuatban.SelectedIndex = -1;
            cbbLoaiSach.SelectedIndex = -1;
            txtSoTrang.Clear();
            nubGiaBan.Value=0;
            nubSoLuong.Value = 0;
            dtpTGPH.Value = DateTime.Now;
        }

        private void btnCN_Click(object sender, EventArgs e)
        {
            SachBLL.Sach_Update(
                        txtMaSach.Text,
                         txtTenSach.Text,
                         cbbTacGia.Text,
                         cbbNhaXuatban.Text,
                         cbbLoaiSach.Text,
                         txtSoTrang.Text,
                         nubGiaBan.Value.ToString(),
                         nubSoLuong.Value.ToString(),
                         dtpTGPH.Value
                   );
            dgvSACH.DataSource = SachBLL.Sach_Select();
        }

        private void dgvSACH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem ô được chọn có hợp lệ không
            if (e.RowIndex >= 0)
            {
                int dong = e.RowIndex;

                txtMaSach.Text = dgvSACH[0, dong].Value.ToString();
                txtTenSach.Text = dgvSACH[1, dong].Value.ToString();
                cbbTacGia.Text = dgvSACH[2, dong].Value.ToString();
                cbbNhaXuatban.Text = dgvSACH[3, dong].Value.ToString();
                cbbLoaiSach.Text = dgvSACH[4, dong].Value.ToString();
                txtSoTrang.Text = dgvSACH[5, dong].Value.ToString();
                nubGiaBan.Value = decimal.TryParse(dgvSACH[6, dong].Value.ToString(), out decimal giaBan) ? giaBan : 0;
                nubSoLuong.Value = decimal.TryParse(dgvSACH[7, dong].Value.ToString(), out decimal soLuong) ? soLuong : 0;
                dtpTGPH.Value = DateTime.TryParse(dgvSACH[8, dong].Value.ToString(), out DateTime ngayPhatHanh) ? ngayPhatHanh : DateTime.Now;
            }
        }
  
        private void btnXoaN_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sách này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Gọi hàm xóa sách từ BLL
                int kq = SachBLL.Sach_Delete(txtMaSach.Text);

                if (kq > 0)
                {
                    MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không thể xóa. Có thể sách đang được sử dụng ở bảng khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Cập nhật lại danh sách
                dgvSACH.DataSource = SachBLL.Sach_Select();
            }
            else
            {
                // Nếu không xóa vẫn load lại để làm mới giao diện
                dgvSACH.DataSource = SachBLL.Sach_Select();
            }
        }

        private void TimKiem_TextChanged(object sender, EventArgs e)
        {
            string TenSach = TimKiem.Text.Trim();
            dgvSACH.DataSource = SachBLL.Sach_Search(TenSach);
        }
        private string SinhMaSachTuDong(DataTable dtSach)
        {
            List<int> danhSachSo = new List<int>();

            foreach (DataRow row in dtSach.Rows)
            {
                string ma = row["MaSach"].ToString();
                if (ma.StartsWith("S") && int.TryParse(ma.Substring(1), out int so))
                {
                    danhSachSo.Add(so);
                }
            }

            danhSachSo.Sort();
            int newSo = 1;

            for (int i = 1; i <= danhSachSo.Count; i++)
            {
                if (!danhSachSo.Contains(i))
                {
                    newSo = i;
                    break;
                }
            }

            if (newSo == 1 && danhSachSo.Contains(1))
            {
                newSo = danhSachSo.Max() + 1;
            }

            return "S" + newSo.ToString("D3");

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
    }

}

