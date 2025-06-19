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
    public partial class Form_LoaiSach : Form
    {
        LoaiSach_BLL LoaiSachBLL = new LoaiSach_BLL();


        public Form_LoaiSach()
        {
            InitializeComponent();
            dgvLoaiSach.DataSource = LoaiSachBLL.LoaiSach_Select();
        }

        private void btnTaoM_Click(object sender, EventArgs e)
        {
            DataTable dt = LoaiSachBLL.LoaiSach_Select();
            txtMaLoaiSach.Text = SinhMaLoaiSachTuDong(dt);
            txtMaLoaiSach.Enabled = false;

            txtTenLoaiSach.Clear();

            txtMaLoaiSach.Focus();
        }
        private string SinhMaLoaiSachTuDong(DataTable dtLoaiSach)
        {
            List<int> danhSachSo = new List<int>();

            foreach (DataRow row in dtLoaiSach.Rows)
            {
                string ma = row["MaLoai"].ToString();
                if (ma.StartsWith("LS") && int.TryParse(ma.Substring(2), out int so))
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

            return "LS" + newSo.ToString("D3");
        }


        private void btnLuuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra các trường bắt buộc không được để trống
            if (string.IsNullOrEmpty(txtMaLoaiSach.Text) || string.IsNullOrEmpty(txtTenLoaiSach.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !!!", "Thông báo",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                LoaiSachBLL.LoaiSach_Insert(
                    txtMaLoaiSach.Text,
                    txtTenLoaiSach.Text
                );
                MessageBox.Show("Đã thêm loại sách thành công", "Thông báo",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvLoaiSach.DataSource = LoaiSachBLL.LoaiSach_Select();
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
            if (string.IsNullOrEmpty(txtMaLoaiSach.Text) || string.IsNullOrEmpty(txtTenLoaiSach.Text))
            {
                MessageBox.Show("Vui lòng chọn hàng và nhập đầy đủ thông tin để sửa.", "Thông báo",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                LoaiSachBLL.LoaiSach_Update(
                    txtMaLoaiSach.Text,
                    txtTenLoaiSach.Text
                );
                MessageBox.Show("Cập nhật loại sách thành công!", "Thông báo",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvLoaiSach.DataSource = LoaiSachBLL.LoaiSach_Select();
                btnTaoM_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật loại sách: {ex.Message}", "Lỗi",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaN_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa loại sách này?",
                                            "Xác nhận xóa", MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                int kq = LoaiSachBLL.LoaiSach_Delete(txtMaLoaiSach.Text);

                if (kq > 0)
                {
                    MessageBox.Show("Xóa thành công.", "Thông báo",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không thể xóa. Có thể loại sách đang được sử dụng ở bảng khác.", "Lỗi",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                dgvLoaiSach.DataSource = LoaiSachBLL.LoaiSach_Select();
                btnTaoM_Click(sender, e);
            }
            else
            {
                dgvLoaiSach.DataSource = LoaiSachBLL.LoaiSach_Select();
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvLoaiSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int dong = e.RowIndex;

                txtMaLoaiSach.Text = dgvLoaiSach[0, dong].Value.ToString();
                txtTenLoaiSach.Text = dgvLoaiSach[1, dong].Value.ToString();
            }
        }

        private void LoaiSach_Load(object sender, EventArgs e)
        {
            LoadAndResizeDataGridView();
        }
        private void LoadAndResizeDataGridView()
        {
            dgvLoaiSach.DataSource = LoaiSachBLL.LoaiSach_Select();

            // Điều chỉnh độ rộng cột để phù hợp với nội dung
            dgvLoaiSach.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            dgvLoaiSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Tùy chỉnh độ rộng tối thiểu và tối đa
            //foreach (DataGridViewColumn column in dgvLoaiSach.Columns)
            //{
            //    column.MinimumWidth = 100; // Độ rộng tối thiểu
            //    if (column.Width > 300) // Độ rộng tối đa
            //    {
            //        column.Width = 300;
            //    }
            //}
        }
    }
}
