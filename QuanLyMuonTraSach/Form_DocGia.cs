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
    public partial class Form_DocGia : Form
    {
        DocGia_BLL DocGiaBLL = new DocGia_BLL();
        public Form_DocGia()
        {
            InitializeComponent();
            dgvDocGia.DataSource = DocGiaBLL.DocGia_Select();
            dgvDocGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDocGia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        }

        private void btnTaoM_Click(object sender, EventArgs e)
        {
            DataTable dt = DocGiaBLL.DocGia_Select();
            txtMaDocGia.Text = SinhMaDocGiaTuDong(dt);
            txtMaDocGia.Enabled = false;

            txtTenDocGia.Clear();
            txtLop.Clear();
            txtGioiTinh.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            txtSoDienThoai.Clear();
            txtDiaChi.Clear();
            txtVaiTro.Clear();

            txtMaDocGia.Focus();
        }
        private string SinhMaDocGiaTuDong(DataTable dtDocGia)
        {
            List<int> danhSachSo = new List<int>();

            foreach (DataRow row in dtDocGia.Rows)
            {
                string ma = row["MaDocGia"].ToString();
                if (ma.StartsWith("DG") && int.TryParse(ma.Substring(2), out int so))
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

            return "DG" + newSo.ToString("D3");
        }

        private void btnLuuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra các trường bắt buộc không được để trống
        if (string.IsNullOrEmpty(txtMaDocGia.Text) || string.IsNullOrEmpty(txtTenDocGia.Text) ||
            string.IsNullOrEmpty(txtLop.Text) || string.IsNullOrEmpty(txtGioiTinh.Text) ||
            string.IsNullOrEmpty(txtSoDienThoai.Text) || string.IsNullOrEmpty(txtDiaChi.Text) ||
            string.IsNullOrEmpty(txtVaiTro.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !!!", "Thông báo",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DocGiaBLL.DocGia_Insert(
                    txtMaDocGia.Text,
                    txtTenDocGia.Text,
                    txtLop.Text,
                    txtGioiTinh.Text,
                    dtpNgaySinh.Value,
                    txtSoDienThoai.Text,
                    txtDiaChi.Text,
                    txtVaiTro.Text
                );
                MessageBox.Show("Đã thêm độc giả thành công", "Thông báo",
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
            if (string.IsNullOrEmpty(txtMaDocGia.Text) || string.IsNullOrEmpty(txtTenDocGia.Text) ||
                string.IsNullOrEmpty(txtLop.Text) || string.IsNullOrEmpty(txtGioiTinh.Text) ||
                string.IsNullOrEmpty(txtSoDienThoai.Text) || string.IsNullOrEmpty(txtDiaChi.Text) ||
                string.IsNullOrEmpty(txtVaiTro.Text))
            {
                MessageBox.Show("Vui lòng chọn hàng và nhập đầy đủ thông tin để sửa.", "Thông báo",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                DocGiaBLL.DocGia_Update(
                    txtMaDocGia.Text,
                    txtTenDocGia.Text,
                    txtLop.Text,
                    txtGioiTinh.Text,
                    dtpNgaySinh.Value,
                    txtSoDienThoai.Text,
                    txtDiaChi.Text,
                    txtVaiTro.Text
                );
                MessageBox.Show("Cập nhật độc giả thành công!", "Thông báo",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAndResizeDataGridView();
                btnTaoM_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật độc giả: {ex.Message}", "Lỗi",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaN_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa độc giả này?",
                                            "Xác nhận xóa", MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                int kq = DocGiaBLL.DocGia_Delete(txtMaDocGia.Text);

                if (kq > 0)
                {
                    MessageBox.Show("Xóa thành công.", "Thông báo",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không thể xóa. Có thể độc giả đang được sử dụng ở bảng khác.", "Lỗi",
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

        private void dgvDocGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int dong = e.RowIndex;

                txtMaDocGia.Text = dgvDocGia[0, dong].Value.ToString();
                txtTenDocGia.Text = dgvDocGia[1, dong].Value.ToString();
                txtLop.Text = dgvDocGia[2, dong].Value.ToString();
                txtGioiTinh.Text = dgvDocGia[3, dong].Value.ToString();
                dtpNgaySinh.Value = DateTime.TryParse(dgvDocGia[4, dong].Value.ToString(), out DateTime ngaySinh) ? ngaySinh : DateTime.Now;
                txtSoDienThoai.Text = dgvDocGia[5, dong].Value.ToString();
                txtDiaChi.Text = dgvDocGia[6, dong].Value.ToString();
                txtVaiTro.Text = dgvDocGia[7, dong].Value.ToString();
            }
        }

        private void DocGia_Load(object sender, EventArgs e)
        {
            LoadAndResizeDataGridView();
        }
        private void LoadAndResizeDataGridView()
        {
            dgvDocGia.DataSource = DocGiaBLL.DocGia_Select();

            // Điều chỉnh độ rộng cột để phù hợp với nội dung
            dgvDocGia.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);

            // Tùy chỉnh độ rộng tối thiểu và tối đa nếu cần
            foreach (DataGridViewColumn column in dgvDocGia.Columns)
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
