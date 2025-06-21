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
    public partial class Form_LichSu : Form
    {
        public Form_MuonTraSach formMTS;
        private string tenDangNhap;
        private string loaiTaiKhoan;

        public Form_LichSu(Form_MuonTraSach formMTS, string tenDangNhap, string loaiTaiKhoan)
        {
            InitializeComponent();
            this.formMTS = formMTS;
            this.tenDangNhap = tenDangNhap;
            this.loaiTaiKhoan = loaiTaiKhoan;
        }

        private void FormLichSu_Load(object sender, EventArgs e)
        {
            LichSuMuonSach_BLL lichSuBLL = new LichSuMuonSach_BLL();
            if (loaiTaiKhoan == "admin" || loaiTaiKhoan == "librarian")
            {
                // Hiển thị toàn bộ lịch sử cho admin và thủ thư
                dgvLichSu.DataSource = lichSuBLL.LayTatCa();
            }
            else
            {
                // Lấy MaDocGia từ DangNhap dựa trên tenDangNhap cho student và lecturer
                string maDocGia = GetMaDocGiaFromDangNhap(tenDangNhap);
                if (!string.IsNullOrEmpty(maDocGia))
                {
                    dgvLichSu.DataSource = lichSuBLL.LayLichSuTheoMaDocGia(maDocGia);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin độc giả cho tài khoản này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvLichSu.DataSource = null;
                }
            }
            dgvLichSu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLichSu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        }

        private string GetMaDocGiaFromDangNhap(string taiKhoan)
        {
            try
            {
                using (var connection = new System.Data.SqlClient.SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QLTVMuonTraSach;Integrated Security=True"))
                {
                    connection.Open();
                    string query = "SELECT MaDocGia FROM DangNhap WHERE TaiKhoan = @TaiKhoan";
                    using (var command = new System.Data.SqlClient.SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TaiKhoan", taiKhoan);
                        var result = command.ExecuteScalar();
                        return result != DBNull.Value ? result.ToString() : null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lấy MaDocGia: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void btnPhucHoi_Click(object sender, EventArgs e)
        {
            if (dgvLichSu.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng để khôi phục!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgvLichSu.SelectedRows[0];

            string maPM = row.Cells["MaPhieuMuon"].Value.ToString();
            string maDG = row.Cells["MaDocGia"].Value.ToString();
            string maNV = row.Cells["MaNhanVien"].Value.ToString();
            DateTime ngayMuon = Convert.ToDateTime(row.Cells["NgayMuon"].Value);
            DateTime ngayTra = Convert.ToDateTime(row.Cells["NgayTra"].Value);
            string ghiChu = row.Cells["GhiChu"].Value?.ToString() ?? "";
            string maSach = row.Cells["MaSach"].Value.ToString();
            int soLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);

            // ✅ Gọi phục hồi từ FormMTS
            formMTS.PhucHoiPhieuMuon(maPM, maDG, maNV, ngayMuon, ngayTra, ghiChu, maSach, soLuong);

            // ✅ Xóa bản ghi vừa phục hồi khỏi bảng lịch sử
            int maLichSu = Convert.ToInt32(row.Cells["MaLichSu"].Value); // Cột này cần tồn tại
            LichSuMuonSach_BLL lichSuBLL = new LichSuMuonSach_BLL();
            lichSuBLL.XoaLichSu(maLichSu);
            lichSuBLL.ResetLaiMaLichSu();

            // ✅ Tải lại danh sách lịch sử
            if (loaiTaiKhoan == "admin" || loaiTaiKhoan == "librarian")
            {
                dgvLichSu.DataSource = lichSuBLL.LayTatCa();
            }
            else
            {
                string maDocGia = GetMaDocGiaFromDangNhap(tenDangNhap);
                if (!string.IsNullOrEmpty(maDocGia))
                {
                    dgvLichSu.DataSource = lichSuBLL.LayLichSuTheoMaDocGia(maDocGia);
                }
            }

            MessageBox.Show("Khôi phục và xoá bản ghi lịch sử thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvLichSu.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng để xoá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá dòng này khỏi lịch sử?",
                                                  "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    DataGridViewRow row = dgvLichSu.SelectedRows[0];
                    int maLichSu = Convert.ToInt32(row.Cells["MaLichSu"].Value);

                    // Gọi BLL để xoá dòng này
                    LichSuMuonSach_BLL lichSuBLL = new LichSuMuonSach_BLL();
                    lichSuBLL.XoaLichSu(maLichSu);

                    // Gọi SP reset lại mã
                    lichSuBLL.ResetLaiMaLichSu();

                    // Tải lại dữ liệu
                    if (loaiTaiKhoan == "admin" || loaiTaiKhoan == "librarian")
                    {
                        dgvLichSu.DataSource = lichSuBLL.LayTatCa();
                    }
                    else
                    {
                        string maDocGia = GetMaDocGiaFromDangNhap(tenDangNhap);
                        if (!string.IsNullOrEmpty(maDocGia))
                        {
                            dgvLichSu.DataSource = lichSuBLL.LayLichSuTheoMaDocGia(maDocGia);
                        }
                    }

                    MessageBox.Show("Xoá dòng thành công và đã đánh lại mã!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xoá: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void InBLP_Click(object sender, EventArgs e)
        {
            if (dgvLichSu.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để in biên lai phạt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgvLichSu.SelectedRows[0];
            string maPhieuMuon = row.Cells["MaPhieuMuon"].Value?.ToString();
            string maDocGia = row.Cells["MaDocGia"].Value?.ToString();
            string maSach = row.Cells["MaSach"].Value?.ToString();

            if (string.IsNullOrEmpty(maPhieuMuon) || string.IsNullOrEmpty(maDocGia))
            {
                MessageBox.Show("Mã phiếu mượn hoặc mã độc giả không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Form_InBienLaiPhat frm = new Form_InBienLaiPhat(maPhieuMuon, maDocGia, maSach);
            frm.ShowDialog();
        }
    }
}