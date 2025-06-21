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
    public partial class Form_NhanVien : Form
    {
        NhanVien_BLL NhanVienBLL = new NhanVien_BLL();
        BoPhan_BLL BoPhanBLL = new BoPhan_BLL();
        public Form_NhanVien()
        {
            InitializeComponent();
            dgvNhanVien.DataSource = NhanVienBLL.NhanVien_Select();
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            cbbBoPhan.DataSource = BoPhanBLL.LDLBP();
            cbbBoPhan.DisplayMember = "TenBoPhan";
            cbbBoPhan.ValueMember = "MaBoPhan";

            // Tải dữ liệu và điều chỉnh độ rộng cột
            LoadAndResizeDataGridView();
        }
        private void LoadAndResizeDataGridView()
        {
            dgvNhanVien.DataSource = NhanVienBLL.NhanVien_Select();
            dgvNhanVien.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            foreach (DataGridViewColumn column in dgvNhanVien.Columns)
            {
                column.MinimumWidth = 100;
                if (column.Width > 300)
                {
                    column.Width = 300;
                }
            }
        }

        private void btnTaoM_Click(object sender, EventArgs e)
        {
            DataTable dt = NhanVienBLL.NhanVien_Select();
            txtMaNhanVien.Text = SinhMaNhanVienTuDong(dt);
            txtMaNhanVien.Enabled = false;

            txtTenNhanVien.Clear();
            txtChucVu.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            txtSoDienThoai.Clear();
            txtGioiTinh.Clear();
            cbbBoPhan.SelectedIndex = -1;


            txtMaNhanVien.Focus();
        }
        private string SinhMaNhanVienTuDong(DataTable dtNhanVien)
        {
            List<int> danhSachSo = new List<int>();

            foreach (DataRow row in dtNhanVien.Rows)
            {
                string ma = row["MaNhanVien"].ToString();
                if (ma.StartsWith("NV") && int.TryParse(ma.Substring(2), out int so))
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

            return "NV" + newSo.ToString("D3");
        }

        private void btnLuuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra các trường bắt buộc không được để trống
            if (string.IsNullOrEmpty(txtMaNhanVien.Text) || string.IsNullOrEmpty(txtTenNhanVien.Text) ||
                string.IsNullOrEmpty(txtChucVu.Text) || string.IsNullOrEmpty(txtSoDienThoai.Text) ||
                string.IsNullOrEmpty(txtGioiTinh.Text) || cbbBoPhan.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !!!", "Thông báo",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                NhanVienBLL.NhanVien_Insert(
                    txtMaNhanVien.Text,
                    txtTenNhanVien.Text,
                    txtChucVu.Text,
                    dtpNgaySinh.Value,
                    txtSoDienThoai.Text,
                    txtGioiTinh.Text,
                    cbbBoPhan.SelectedValue.ToString()
                );
                MessageBox.Show("Đã thêm nhân viên thành công", "Thông báo",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAndResizeDataGridView();
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
            if (string.IsNullOrEmpty(txtMaNhanVien.Text) || string.IsNullOrEmpty(txtTenNhanVien.Text) ||
                string.IsNullOrEmpty(txtChucVu.Text) || string.IsNullOrEmpty(txtSoDienThoai.Text) ||
                string.IsNullOrEmpty(txtGioiTinh.Text) || cbbBoPhan.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn hàng và nhập đầy đủ thông tin để sửa.", "Thông báo",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                NhanVienBLL.NhanVien_Update(
                    txtMaNhanVien.Text,
                    txtTenNhanVien.Text,
                    txtChucVu.Text,
                    dtpNgaySinh.Value,
                    txtSoDienThoai.Text,
                    txtGioiTinh.Text,
                    cbbBoPhan.SelectedValue.ToString()
                );
                MessageBox.Show("Cập nhật nhân viên thành công!", "Thông báo",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAndResizeDataGridView();
                btnTaoM_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật nhân viên: {ex.Message}", "Lỗi",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaN_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?",
                                             "Xác nhận xóa", MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                int kq = NhanVienBLL.NhanVien_Delete(txtMaNhanVien.Text);

                if (kq > 0)
                {
                    MessageBox.Show("Xóa thành công.", "Thông báo",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không thể xóa. Có thể nhân viên đang được sử dụng ở bảng khác.", "Lỗi",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                LoadAndResizeDataGridView();
                btnTaoM_Click(sender, e);
            }
            else
            {
                LoadAndResizeDataGridView();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int dong = e.RowIndex;

                txtMaNhanVien.Text = dgvNhanVien[0, dong].Value.ToString();
                txtTenNhanVien.Text = dgvNhanVien[1, dong].Value.ToString();
                txtChucVu.Text = dgvNhanVien[2, dong].Value.ToString();
                dtpNgaySinh.Value = DateTime.TryParse(dgvNhanVien[3, dong].Value.ToString(), out DateTime ngaySinh) ? ngaySinh : DateTime.Now;
                txtSoDienThoai.Text = dgvNhanVien[4, dong].Value.ToString();
                txtGioiTinh.Text = dgvNhanVien[5, dong].Value.ToString();
                cbbBoPhan.SelectedValue = dgvNhanVien[6, dong].Value.ToString();
            }
        }

        private void TimKiem_TextChanged(object sender, EventArgs e)
        {
            string HoTen = TimKiem.Text.Trim();
            dgvNhanVien.DataSource = NhanVienBLL.NhanVien_Search(HoTen);
            dgvNhanVien.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            foreach (DataGridViewColumn column in dgvNhanVien.Columns)
            {
                column.MinimumWidth = 100;
                if (column.Width > 300)
                {
                    column.Width = 300;
                }
            }
        }
    }
}