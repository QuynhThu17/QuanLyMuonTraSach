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
    public partial class Form_NhaXuatBan : Form
    {
        NhaXuatBan_BLL NhaXuatBanBLL = new NhaXuatBan_BLL();
        public Form_NhaXuatBan()
        {
            InitializeComponent();
            dgvNhaXB.DataSource = NhaXuatBanBLL.NhaXuatBan_Select();
            dgvNhaXB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnTaoM_Click(object sender, EventArgs e)
        {
            DataTable dt = NhaXuatBanBLL.NhaXuatBan_Select();
            txtMaNXB.Text = SinhMaNXBTuDong(dt);
            txtMaNXB.Enabled = false;

            txtTenNXB.Clear();

            txtMaNXB.Focus();
        }

        private void btnLuuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra các trường bắt buộc không được để trống
        if (string.IsNullOrEmpty(txtMaNXB.Text) || string.IsNullOrEmpty(txtTenNXB.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !!!", "Thông báo",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                NhaXuatBanBLL.NhaXuatBan_Insert(
                    txtMaNXB.Text,
                    txtTenNXB.Text
                );
                MessageBox.Show("Đã thêm nhà xuất bản thành công", "Thông báo",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvNhaXB.DataSource = NhaXuatBanBLL.NhaXuatBan_Select();
                btnTaoM_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCN_Click(object sender, EventArgs e)
        {
            // Kiểm tra các trường bắt buộc không được để trống
            if (string.IsNullOrEmpty(txtMaNXB.Text) || string.IsNullOrEmpty(txtTenNXB.Text))
            {
                MessageBox.Show("Vui lòng chọn hàng và nhập đầy đủ thông tin để sửa.", "Thông báo",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                NhaXuatBanBLL.NhaXuatBan_Update(
                    txtMaNXB.Text,
                    txtTenNXB.Text
                );
                MessageBox.Show("Cập nhật nhà xuất bản thành công!", "Thông báo",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvNhaXB.DataSource = NhaXuatBanBLL.NhaXuatBan_Select();
                btnTaoM_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật nhà xuất bản: {ex.Message}", "Lỗi",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaN_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhà xuất bản này?",
                                               "Xác nhận xóa", MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                int kq = NhaXuatBanBLL.NhaXuatBan_Delete(txtMaNXB.Text);

                if (kq > 0)
                {
                    MessageBox.Show("Xóa thành công.", "Thông báo",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không thể xóa. Có thể nhà xuất bản đang được sử dụng ở bảng khác.", "Lỗi",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                dgvNhaXB.DataSource = NhaXuatBanBLL.NhaXuatBan_Select();
                btnTaoM_Click(sender, e);
            }
            else
            {
                dgvNhaXB.DataSource = NhaXuatBanBLL.NhaXuatBan_Select();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvNhaXB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int dong = e.RowIndex;

                txtMaNXB.Text = dgvNhaXB[0, dong].Value.ToString();
                txtTenNXB.Text = dgvNhaXB[1, dong].Value.ToString();
            }
        }

        private void txtTimKien_TextChanged(object sender, EventArgs e)
        {
            string TenXB = txtTimKien.Text.Trim();
            dgvNhaXB.DataSource = NhaXuatBanBLL.NhaXuatBan_Search(TenXB);
        }
        private string SinhMaNXBTuDong(DataTable dtNXB)
        {
            List<int> danhSachSo = new List<int>();

            foreach (DataRow row in dtNXB.Rows)
            {
                string ma = row["MaXB"].ToString();
                if (ma.StartsWith("XB") && int.TryParse(ma.Substring(2), out int so))
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

            return "XB" + newSo.ToString("D3");
        }

    }
}
