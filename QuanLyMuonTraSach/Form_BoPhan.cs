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
    public partial class Form_BoPhan : Form
    {
        BoPhan_BLL BoPhanBLL = new BoPhan_BLL();
        public Form_BoPhan()
        {
            InitializeComponent();
            dgvBoPhan.DataSource = BoPhanBLL.BoPhan_Select();
        }

        private void btnTaoM_Click(object sender, EventArgs e)
        {
            DataTable dt = BoPhanBLL.BoPhan_Select();
            txtMaBoPhan.Text = SinhMaBoPhanTuDong(dt);
            txtMaBoPhan.Enabled = false;

            txtTenBoPhan.Clear();

            txtMaBoPhan.Focus();
        }


        private void btnLuuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra các trường bắt buộc không được để trống
            if (string.IsNullOrEmpty(txtMaBoPhan.Text) || string.IsNullOrEmpty(txtTenBoPhan.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !!!", "Thông báo",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                BoPhanBLL.BoPhan_Insert(
                    txtMaBoPhan.Text,
                    txtTenBoPhan.Text
                );
                MessageBox.Show("Đã thêm bộ phận thành công", "Thông báo",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvBoPhan.DataSource = BoPhanBLL.BoPhan_Select();
                btnTaoM_Click(sender, e); // Làm mới các trường
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
            if (string.IsNullOrEmpty(txtMaBoPhan.Text) || string.IsNullOrEmpty(txtTenBoPhan.Text))
            {
                MessageBox.Show("Vui lòng chọn hàng và nhập đầy đủ thông tin để sửa.", "Thông báo",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                BoPhanBLL.BoPhan_Update(
                    txtMaBoPhan.Text,
                    txtTenBoPhan.Text
                );
                MessageBox.Show("Cập nhật bộ phận thành công!", "Thông báo",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvBoPhan.DataSource = BoPhanBLL.BoPhan_Select();
                btnTaoM_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật bộ phận: {ex.Message}", "Lỗi",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaN_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa bộ phận này?",
                                             "Xác nhận xóa", MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                int kq = BoPhanBLL.BoPhan_Delete(txtMaBoPhan.Text);

                if (kq > 0)
                {
                    MessageBox.Show("Xóa thành công.", "Thông báo",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không thể xóa. Có thể bộ phận đang được sử dụng ở bảng khác.", "Lỗi",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                dgvBoPhan.DataSource = BoPhanBLL.BoPhan_Select();
                btnTaoM_Click(sender, e);
            }
            else
            {
                dgvBoPhan.DataSource = BoPhanBLL.BoPhan_Select();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TimKiem_TextChanged(object sender, EventArgs e)
        {
            string TenBoPhan = TimKiem.Text.Trim();
            dgvBoPhan.DataSource = BoPhanBLL.BoPhan_Search(TenBoPhan);
        }

        private void BoPhan_Load(object sender, EventArgs e)
        {

            // Tải dữ liệu và điều chỉnh độ rộng cột
            LoadAndResizeDataGridView();
        }
        private void LoadAndResizeDataGridView()
        {
            dgvBoPhan.DataSource = BoPhanBLL.BoPhan_Select();

            // Điều chỉnh độ rộng cột để phù hợp với nội dung
            dgvBoPhan.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);

            // Tùy chỉnh độ rộng tối thiểu và tối đa nếu cần
            foreach (DataGridViewColumn column in dgvBoPhan.Columns)
            {
                // Đặt độ rộng tối thiểu để tránh cột quá hẹp
                column.MinimumWidth = 100;

                // Đặt độ rộng tối đa để tránh cột quá rộng
                if (column.Width > 10000)
                {
                    column.Width = 10000;
                }
            }
        }

        private string SinhMaBoPhanTuDong(DataTable dtBoPhan)
        {
            List<int> danhSachSo = new List<int>();

            foreach (DataRow row in dtBoPhan.Rows)
            {
                string ma = row["MaBoPhan"].ToString();
                if (ma.StartsWith("BP") && int.TryParse(ma.Substring(2), out int so))
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

            return "BP" + newSo.ToString("D3");
        }

        private void dgvBoPhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int dong = e.RowIndex;

                txtMaBoPhan.Text = dgvBoPhan[0, dong].Value.ToString();
                txtTenBoPhan.Text = dgvBoPhan[1, dong].Value.ToString();
            }
        }
    }
}
