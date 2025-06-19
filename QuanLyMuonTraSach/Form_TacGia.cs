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
    public partial class Form_TacGia : Form
    {
        TacGia_BLL TacGiaBLL = new TacGia_BLL();
        public Form_TacGia()
        {
            InitializeComponent();
            dgvTacGia.DataSource = TacGiaBLL.TacGia_Select();
        }


        private void btnTaoM_Click(object sender, EventArgs e)
        {
            DataTable dt = TacGiaBLL.TacGia_Select();
            txtMaTacGia.Text = SinhMaTacGiaTuDong(dt);
            txtMaTacGia.Enabled = false;

            txtTenTacGia.Clear();

            txtMaTacGia.Focus();
        }

        private void btnLuuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra các trường bắt buộc không được để trống
            if (string.IsNullOrEmpty(txtMaTacGia.Text) || string.IsNullOrEmpty(txtTenTacGia.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !!!", "Thông báo",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                TacGiaBLL.TacGia_Insert(
                    txtMaTacGia.Text,
                    txtTenTacGia.Text
                );
                MessageBox.Show("Đã thêm tác giả thành công", "Thông báo",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvTacGia.DataSource = TacGiaBLL.TacGia_Select();
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
            if (string.IsNullOrEmpty(txtMaTacGia.Text) || string.IsNullOrEmpty(txtTenTacGia.Text))
            {
                MessageBox.Show("Vui lòng chọn hàng và nhập đầy đủ thông tin để sửa.", "Thông báo",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                TacGiaBLL.TacGia_Update(
                    txtMaTacGia.Text,
                    txtTenTacGia.Text
                );
                MessageBox.Show("Cập nhật tác giả thành công!", "Thông báo",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvTacGia.DataSource = TacGiaBLL.TacGia_Select();
                btnTaoM_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật tác giả: {ex.Message}", "Lỗi",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaN_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tác giả này?",
                                             "Xác nhận xóa", MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                int kq = TacGiaBLL.TacGia_Delete(txtMaTacGia.Text);

                if (kq > 0)
                {
                    MessageBox.Show("Xóa thành công.", "Thông báo",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không thể xóa. Có thể tác giả đang được sử dụng ở bảng khác.", "Lỗi",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                dgvTacGia.DataSource = TacGiaBLL.TacGia_Select();
                btnTaoM_Click(sender, e);
            }
            else
            {
                dgvTacGia.DataSource = TacGiaBLL.TacGia_Select();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int dong = e.RowIndex;

                txtMaTacGia.Text = dgvTacGia[0, dong].Value.ToString();
                txtTenTacGia.Text = dgvTacGia[1, dong].Value.ToString();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string TenTacGia = txtTimKiem.Text.Trim();
            dgvTacGia.DataSource = TacGiaBLL.TacGia_Search(TenTacGia);
        }
        private string SinhMaTacGiaTuDong(DataTable dtTacGia)
        {
            List<int> danhSachSo = new List<int>();

            foreach (DataRow row in dtTacGia.Rows)
            {
                string ma = row["MaTacGia"].ToString();
                if (ma.StartsWith("TG") && int.TryParse(ma.Substring(2), out int so))
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

            return "TG" + newSo.ToString("D3");
        }

        private void TacGia_Load(object sender, EventArgs e)
        {
            // Tải dữ liệu và điều chỉnh độ rộng cột
            LoadAndResizeDataGridView();
        }
        private void LoadAndResizeDataGridView()
        {
            dgvTacGia.DataSource = TacGiaBLL.TacGia_Select();
            dgvTacGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //// Điều chỉnh độ rộng cột để phù hợp với nội dung
            //dgvTacGia.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);

            //// Tùy chỉnh độ rộng tối thiểu và tối đa nếu cần
            //foreach (DataGridViewColumn column in dgvTacGia.Columns)
            //{
            //    // Đặt độ rộng tối thiểu để tránh cột quá hẹp
            //    column.MinimumWidth = 100;

            //    // Đặt độ rộng tối đa để tránh cột quá rộng
            //    if (column.Width > 300)
            //    {
            //        column.Width = 300;
            //    }
            //}
        }
    }
}
