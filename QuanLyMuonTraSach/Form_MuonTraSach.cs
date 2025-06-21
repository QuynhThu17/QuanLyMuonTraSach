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
    public partial class Form_MuonTraSach : Form
    {
        MuonTraSach_BLL MuonTraSachBLL = new MuonTraSach_BLL();
        ChiTietMTS_BLL ChiTietMuonTraSachBLL = new ChiTietMTS_BLL();
        DocGia_BLL DocGiaBLL = new DocGia_BLL();
        Sach_BLL SachBLL = new Sach_BLL();
        NhanVien_BLL NhanVienBLL = new NhanVien_BLL();
        DataTable dtChiTietMuonTra1;
        public static string MaPM;
        private string tenDangNhap;
        private string loaiTaiKhoan;

        public Form_MuonTraSach(string loaTaiKhoan)
        {
            InitializeComponent();
            loaiTaiKhoan = loaTaiKhoan;
            LoadAndResizeDataGridView();
            // Thêm sự kiện CellFormatting cho cả hai DataGridView
            dgvMuonTraSach1.CellFormatting += dgvMuonTraSach1_CellFormatting;
            dgvChiTietMuonTraSach1.CellFormatting += dgvChiTietMuonTraSach1_CellFormatting;
        }




        private void LoadAndResizeDataGridView()
        {
            // Tải danh sách phiếu mượn
            dgvMuonTraSach1.DataSource = MuonTraSachBLL.MuonTraSach_Select();
            dgvChiTietMuonTraSach1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMuonTraSach1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMuonTraSach1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;


            // Ẩn cột mã trong dgvMuonTraSach1
            dgvMuonTraSach1.Columns["MaDocGia"].Visible = false;
            dgvMuonTraSach1.Columns["MaNhanVien"].Visible = false;

            // Tải danh sách chi tiết phiếu mượn (nếu có phiếu mượn được chọn)
            if (!string.IsNullOrEmpty(txtMaPhieuMuon.Text))
            {
                LoadChiTietPhieuMuon(txtMaPhieuMuon.Text);
            }
            else
            {
                dgvChiTietMuonTraSach1.DataSource = null;
            }
            if (dgvChiTietMuonTraSach1.Columns.Contains("MaSach"))
            {
                dgvChiTietMuonTraSach1.Columns["MaSach"].HeaderText = "TenSach";
            }

        }

        private void LoadChiTietPhieuMuon(string maPhieuMuon)
        {
            dtChiTietMuonTra1 = ChiTietMuonTraSachBLL.ChiTietMuonTraSach_Search(maPhieuMuon);
            dgvChiTietMuonTraSach1.DataSource = dtChiTietMuonTra1;
            dgvChiTietMuonTraSach1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void TaoMoiPM_Click(object sender, EventArgs e)
        {
            DataTable dt = MuonTraSachBLL.MuonTraSach_Select();

            string maMoi = SinhMaPhieuMuonTuDong(dt);

            txtMaPhieuMuon.Text = maMoi;
            txtMaPhieuMuon.Enabled = false;
            cbbSach.Text = "None";
            nubSoLuong.Value = 0;

            // Gán mã mới qua Chi Tiết Mượn Trả
            txbMPM.Text = maMoi;

            cbbDocGia.SelectedIndex = -1;
            cbbNhanVien.SelectedIndex = -1;
            dtpNgaymuon.Value = DateTime.Now;
            dtpNgayTra.Value = DateTime.Now;
            txtGhiChu.Clear();

            // Làm trống bảng chi tiết
            dtChiTietMuonTra1.Clear();
            dgvChiTietMuonTraSach1.DataSource = dtChiTietMuonTra1;
        }

        private string SinhMaPhieuMuonTuDong(DataTable dtPhieuMuon)
        {
            List<int> danhSachSo = new List<int>();

            foreach (DataRow row in dtPhieuMuon.Rows)
            {
                string ma = row["MaPhieuMuon"].ToString();
                if (ma.StartsWith("PMT") && int.TryParse(ma.Substring(3), out int so))
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

            return "PMT" + newSo.ToString("D3");
        }

        private void btnMuon_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaPhieuMuon.Text) || cbbDocGia.SelectedValue == null || cbbNhanVien.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin phiếu mượn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dtChiTietMuonTra1.Rows.Count == 0)
                {
                    MessageBox.Show("Vui lòng thêm ít nhất một sách cần mượn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MuonTraSachBLL.MuonTraSach_Insert(
                    txtMaPhieuMuon.Text,
                    cbbDocGia.SelectedValue.ToString(),
                    cbbNhanVien.SelectedValue.ToString(),
                    dtpNgaymuon.Value,
                    dtpNgayTra.Value,
                    txtGhiChu.Text
                );

                foreach (DataRow row in dtChiTietMuonTra1.Rows)
                {
                    ChiTietMuonTraSachBLL.ChiTietMuonTraSach_Insert(
                        row["MaPhieuMuon"].ToString(),
                        row["MaSach"].ToString(),
                        Convert.ToInt32(row["SoLuong"])
                    );

                    // Trừ số lượng kho
                    SoLuongSauMuon(row["MaSach"].ToString(), Convert.ToInt32(row["SoLuong"]));
                }

                // Hiển thị lại
                LoadAndResizeDataGridView();
                MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaPhieuMuon.Text))
                {
                    MessageBox.Show("Vui lòng chọn phiếu mượn để gia hạn!", "Thông báo",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string maPhieuMuon = txtMaPhieuMuon.Text;
                DateTime ngayTraCu = dtpNgayTra.Value;

                using (var form = new Form())
                {
                    form.Text = "Gia hạn phiếu mượn";
                    form.Size = new Size(300, 150);
                    form.StartPosition = FormStartPosition.CenterParent;

                    Label lblNgayTra = new Label();
                    lblNgayTra.Text = "Chọn ngày trả mới:";
                    lblNgayTra.Location = new Point(10, 10);
                    lblNgayTra.Size = new Size(120, 20);

                    DateTimePicker dtpNewNgayTra = new DateTimePicker();
                    dtpNewNgayTra.Value = ngayTraCu;
                    dtpNewNgayTra.Location = new Point(10, 40);
                    dtpNewNgayTra.Size = new Size(250, 20);

                    Button btnConfirm = new Button();
                    btnConfirm.Text = "Xác nhận";
                    btnConfirm.Location = new Point(10, 70);
                    btnConfirm.Size = new Size(80, 30);
                    btnConfirm.Click += (s, ev) =>
                    {
                        DateTime ngayTraMoi = dtpNewNgayTra.Value;

                        // Kiểm tra ngày hợp lệ
                        if (ngayTraMoi <= dtpNgaymuon.Value)
                        {
                            MessageBox.Show("Ngày trả mới phải lớn hơn ngày mượn!", "Thông báo",
                                           MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if ((ngayTraMoi - ngayTraCu).TotalDays > 30)
                        {
                            MessageBox.Show("Thời gian gia hạn không được quá 30 ngày!", "Thông báo",
                                           MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Kiểm tra đã gia hạn hay chưa
                        DataTable dtPM = MuonTraSachBLL.MuonTraSach_Select();
                        var row = dtPM.AsEnumerable().FirstOrDefault(r => r["MaPhieuMuon"].ToString() == maPhieuMuon);
                        if (row != null && row["DaGiaHan"] != DBNull.Value && Convert.ToBoolean(row["DaGiaHan"]))
                        {
                            MessageBox.Show("Phiếu mượn này đã được gia hạn 1 lần rồi!", "Thông báo",
                                           MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Ghi gia hạn (KHÔNG cập nhật lại toàn bộ)
                        MuonTraSachBLL.GiaHan(maPhieuMuon, ngayTraMoi);

                        MessageBox.Show("Gia hạn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAndResizeDataGridView();
                        form.Close();
                    };

                    Button btnCancel = new Button();
                    btnCancel.Text = "Hủy";
                    btnCancel.Location = new Point(100, 70);
                    btnCancel.Size = new Size(80, 30);
                    btnCancel.Click += (s, ev) => form.Close();

                    form.Controls.Add(lblNgayTra);
                    form.Controls.Add(dtpNewNgayTra);
                    form.Controls.Add(btnConfirm);
                    form.Controls.Add(btnCancel);

                    form.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaPhieuMuon.Text))
                {
                    MessageBox.Show("Vui lòng chọn phiếu mượn để trả!", "Thông báo",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cbbSach.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn sách cần trả!", "Thông báo",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string maPM = txtMaPhieuMuon.Text;
                string maDG = cbbDocGia.SelectedValue.ToString();
                string maNV = cbbNhanVien.SelectedValue.ToString();
                DateTime ngayMuon = dtpNgaymuon.Value;
                DateTime ngayTra = dtpNgayTra.Value;
                int soLuongTra = (int)nubSoLuong.Value;
                string ghiChu = txtGhiChu.Text;
                string maSach = cbbSach.SelectedValue.ToString();
                DateTime ngayGhiNhan = DateTime.Now; // Ngày ghi nhận là ngày hiện tại
                DateTime ngayTraThucTe = DateTime.Now; // Sử dụng ngày hiện tại để tính toán

                // Sử dụng ngayTra làm ngày hạn trả cố định
                DateTime hanTra = ngayTra;
                int soNgayTre = (ngayTraThucTe - hanTra).Days;
                int tongTienPhat = 0;

                if (soNgayTre > 0)
                {
                    tongTienPhat = soNgayTre * soLuongTra * 2000;

                    // Hỏi người dùng có đồng ý trả muộn với tiền phạt này không
                    DialogResult result = MessageBox.Show(
                        $"Bạn trả sách trễ {soNgayTre} ngày. Tiền phạt là {tongTienPhat:N0} VND. Bạn có muốn tiếp tục trả sách?",
                        "Xác nhận trả sách quá hạn",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (result != DialogResult.Yes)
                    {
                        // Người dùng hủy trả sách
                        return;
                    }

                    ghiChu += $" | Trễ {soNgayTre} ngày, Phạt: {tongTienPhat:N0} VND";
                }

                // Lấy chi tiết từ DB
                DataTable dtChiTiet = ChiTietMuonTraSachBLL.ChiTietMuonTraSach_Search(maPM);
                DataRow row = dtChiTiet.AsEnumerable().FirstOrDefault(r => r["MaSach"].ToString() == maSach);
                if (row == null)
                {
                    MessageBox.Show("Không tìm thấy sách này trong phiếu mượn!", "Lỗi",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int soLuongHienTai = Convert.ToInt32(row["SoLuong"]);
                if (soLuongTra > soLuongHienTai)
                {
                    MessageBox.Show($"Bạn chỉ mượn {soLuongHienTai} cuốn!", "Thông báo",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Cập nhật kho
                SoLuongSauTra(maSach, soLuongTra);

                // Ghi lịch sử (ghiChu đã có tiền phạt nếu có)
                LichSuMuonSach_BLL lichSuBLL = new LichSuMuonSach_BLL();
                lichSuBLL.ThemLichSu(maPM, maDG, maNV, ngayMuon, ngayTra, ghiChu, maSach, soLuongTra,ngayGhiNhan);

                // Cập nhật phiếu mượn còn lại
                if (soLuongTra == soLuongHienTai)
                {
                    // Trả hết → xóa dòng chi tiết
                    ChiTietMuonTraSachBLL.ChiTietMuonTraSach_Delete(maPM, maSach);
                }
                else
                {
                    // Trả một phần → cập nhật lại số lượng còn
                    int soLuongConLai = soLuongHienTai - soLuongTra; // Sử dụng tên biến khác để tránh nhầm với cột
                    ChiTietMuonTraSachBLL.ChiTietMuonTraSach_Update(maPM, maSach, soLuongConLai);
                }

                // Nếu không còn chi tiết nào thì xóa phiếu mượn
                DataTable dtConLai = ChiTietMuonTraSachBLL.ChiTietMuonTraSach_Search(maPM);
                if (dtConLai.Rows.Count == 0)
                {
                    MuonTraSachBLL.MuonTraSach_Delete(maPM);
                    MessageBox.Show("Đã trả hết tất cả sách trong phiếu mượn!", "Thông báo",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đã trả sách và cập nhật lịch sử!", "Thông báo",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LoadAndResizeDataGridView(); // refresh lại lưới
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void SoLuongSauTra(string maSach, int soLuongTra)
        {
            DataTable dtSach = SachBLL.LDLS();
            var sachRow = dtSach.AsEnumerable().FirstOrDefault(row => row.Field<string>("MaSach") == maSach);
            if (sachRow != null)
            {
                int soLuongTon = Convert.ToInt32(sachRow["SoLuong"]);
                int soLuongMoi = soLuongTon + soLuongTra;
                SachBLL.Sach_UpdateSoLuong(maSach, soLuongMoi);
            }
        }
        
        private void FormMTS_Load(object sender, EventArgs e)
        {
           
            txbMPM.Enabled = false;
            txtMaPhieuMuon.Enabled = false;
            dgvChiTietMuonTraSach1.DataSource = null;
            dgvMuonTraSach1.DataSource = MuonTraSachBLL.LDLMTS();

            cbbDocGia.DataSource = DocGiaBLL.LDLDG();
            cbbDocGia.DisplayMember = "HoTenDocGia";
            cbbDocGia.ValueMember = "MaDocGia";

            cbbSach.DataSource = SachBLL.LDLS();
            cbbSach.DisplayMember = "TenSach";
            cbbSach.ValueMember = "MaSach";

            cbbNhanVien.DataSource = NhanVienBLL.LDLNV();
            cbbNhanVien.DisplayMember = "HoTen";
            cbbNhanVien.ValueMember = "MaNhanVien";

            dtChiTietMuonTra1 = new DataTable();
            dtChiTietMuonTra1.Columns.Add("MaPhieuMuon", typeof(string));
            dtChiTietMuonTra1.Columns.Add("TenSach", typeof(string));
            dtChiTietMuonTra1.Columns.Add("SoLuong", typeof(int));

            dgvChiTietMuonTraSach1.DataSource = dtChiTietMuonTra1;
            dgvMuonTraSach1.CellContentClick += dgvMuonTraSach1_CellContentClick;

            if (loaiTaiKhoan == "admin")
            {
                // Admin được toàn quyền
                return;
            }
            else if (loaiTaiKhoan == "student")
            {
                // Chỉ được gia hạn sách, khóa toàn bộ các nút còn lại
                btnMuon2.Enabled = false;
                btnLuu.Enabled = false;
                btnXoa.Enabled = false;
                btnCN.Enabled = false;
                btnXoaPM.Enabled = false;
                btnXoaPM1.Enabled = false;
                btnTra1.Enabled = false;
                TaoMoiPM1.Enabled = false;

                // Có thể thêm ẩn luôn các nút nếu bạn muốn:
                // btnMuon.Visible = false; // ví dụ
            }

        }

        private void dgvMuonTraSach1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                cbbSach.Focus();
                DataGridViewRow row = dgvMuonTraSach1.Rows[e.RowIndex];

                // Gán thông tin phiếu mượn sang các điều khiển chính
                txtMaPhieuMuon.Text = row.Cells["MaPhieuMuon"].Value.ToString();
                cbbDocGia.SelectedValue = row.Cells["MaDocGia"].Value.ToString();
                cbbNhanVien.SelectedValue = row.Cells["MaNhanVien"].Value.ToString();
                dtpNgaymuon.Value = Convert.ToDateTime(row.Cells["NgayMuon"].Value);
                if (row.Cells["NgayTra"].Value == DBNull.Value || row.Cells["NgayTra"].Value == null)
                {
                    dtpNgayTra.Value = DateTime.Now; // hoặc giá trị mặc định bạn muốn
                }
                else
                {
                    dtpNgayTra.Value = Convert.ToDateTime(row.Cells["NgayTra"].Value);
                }

                txtGhiChu.Text = row.Cells["GhiChu"].Value.ToString();

                // Gán MaPhieuMuon cho combobox bên chi tiết
                txbMPM.Text = txtMaPhieuMuon.Text;

                // Load chi tiết phiếu mượn tương ứng
                LoadChiTietPhieuMuon(txtMaPhieuMuon.Text);

                // Nếu có ít nhất 1 chi tiết thì gán cbbSach và số lượng từ dòng đầu tiên
                if (dgvChiTietMuonTraSach1.Rows.Count > 0)
                {
                    var firstRow = dgvChiTietMuonTraSach1.Rows[0];
                    if (firstRow.Cells["MaSach"].Value != null)
                    {
                        cbbSach.SelectedValue = firstRow.Cells["MaSach"].Value.ToString();
                    }
                    if (firstRow.Cells["SoLuong"].Value != null)
                    {
                        nubSoLuong.Value = Convert.ToDecimal(firstRow.Cells["SoLuong"].Value);
                    }
                }
                else
                {
                    cbbSach.SelectedIndex = -1;
                    nubSoLuong.Value = 0;
                }
            }
        }

        private void btnXoaPM_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem có phiếu mượn nào được chọn không
                if (string.IsNullOrEmpty(txtMaPhieuMuon.Text))
                {
                    MessageBox.Show("Vui lòng chọn phiếu mượn để xóa!", "Thông báo",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Hiển thị hộp thoại xác nhận xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu mượn này?",
                                                     "Xác nhận xóa", MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Gọi phương thức từ BLL để xóa phiếu mượn
                    int kq = MuonTraSachBLL.MuonTraSach_Delete(txtMaPhieuMuon.Text);

                    if (kq > 0)
                    {
                        MessageBox.Show("Xóa phiếu mượn thành công!", "Thông báo",
                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa phiếu mượn!", "Lỗi",
                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // Làm mới danh sách phiếu mượn và chi tiết
                    LoadAndResizeDataGridView();

                    // Làm mới các control
                    txtMaPhieuMuon.Clear();
                    cbbDocGia.SelectedIndex = -1;
                    cbbSach.SelectedIndex = -1;
                    cbbNhanVien.SelectedIndex = -1;
                    dtpNgaymuon.Value = DateTime.Now;
                    dtpNgayTra.Value = DateTime.Now;
                    txtGhiChu.Clear();
                    nubSoLuong.Value = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa phiếu mượn: {ex.Message}", "Lỗi",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaPhieuMuon.Text) || cbbSach.SelectedValue == null || nubSoLuong.Value <= 0)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin chi tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string maPhieuMuon = txtMaPhieuMuon.Text;
                string maSach = cbbSach.SelectedValue.ToString();
                int soLuong = (int)nubSoLuong.Value;

                // Kiểm tra xem sách đã có trong chi tiết chưa
                var existingRow = dtChiTietMuonTra1.AsEnumerable()
                    .FirstOrDefault(r => r["MaSach"].ToString() == maSach);

                if (existingRow != null)
                {
                    // Cộng dồn số lượng trong DataTable
                    int soLuongCu = Convert.ToInt32(existingRow["SoLuong"]);
                    int soLuongMoi = soLuongCu + soLuong;
                    existingRow["SoLuong"] = soLuongMoi;

                    // Cập nhật database: cập nhật chi tiết mượn trả sách
                    ChiTietMuonTraSachBLL.ChiTietMuonTraSach_Update(maPhieuMuon, maSach, soLuongMoi);

                    // Cập nhật số lượng tồn kho: giảm đi số lượng vừa thêm
                    SoLuongSauMuon(maSach, soLuong);
                }
                else
                {
                    // Thêm dòng mới vào DataTable
                    DataRow newRow = dtChiTietMuonTra1.NewRow();
                    newRow["MaPhieuMuon"] = maPhieuMuon;
                    newRow["MaSach"] = maSach;
                    newRow["SoLuong"] = soLuong;
                    dtChiTietMuonTra1.Rows.Add(newRow);

                    // Thêm mới chi tiết vào database
                    ChiTietMuonTraSachBLL.ChiTietMuonTraSach_Insert(maPhieuMuon, maSach, soLuong);

                    // Cập nhật số lượng tồn kho: giảm đi số lượng vừa thêm
                    SoLuongSauMuon(maSach, soLuong);
                }

                // Cập nhật lại DataGridView
                dgvChiTietMuonTraSach1.DataSource = null;
                dgvChiTietMuonTraSach1.DataSource = dtChiTietMuonTra1;

                MessageBox.Show("Đã thêm vào danh sách chi tiết! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm chi tiết: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaPhieuMuon.Text) || cbbSach.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn phiếu mượn và sách để xóa!", "Thông báo",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa chi tiết phiếu mượn này?",
                                                     "Xác nhận xóa", MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    string maSach = cbbSach.SelectedValue.ToString();
                    ChiTietMuonTraSachBLL.ChiTietMuonTraSach_Delete(txtMaPhieuMuon.Text, maSach);

                    // Remove the corresponding row from dtChiTietMuonTra1
                    DataRow rowToDelete = dtChiTietMuonTra1.Rows.Cast<DataRow>()
                        .FirstOrDefault(r => r["MaSach"].ToString() == maSach);
                    if (rowToDelete != null)
                    {
                        dtChiTietMuonTra1.Rows.Remove(rowToDelete);
                    }

                    // Refresh the detail grid
                    dgvChiTietMuonTraSach1.DataSource = null;
                    dgvChiTietMuonTraSach1.DataSource = dtChiTietMuonTra1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCN_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaPhieuMuon.Text) || cbbSach.SelectedValue == null || nubSoLuong.Value <= 0)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin để cập nhật!", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string maPhieuMuon = txtMaPhieuMuon.Text;
                string maSach = cbbSach.SelectedValue.ToString();
                int soLuongMoi = (int)nubSoLuong.Value;

                // Lấy chi tiết hiện tại từ database
                DataTable dtChiTietDB = ChiTietMuonTraSachBLL.ChiTietMuonTraSach_Search(maPhieuMuon);
                var chiTietDBRow = dtChiTietDB.AsEnumerable()
                    .FirstOrDefault(r => r.Field<string>("MaSach") == maSach);

                if (chiTietDBRow == null)
                {
                    MessageBox.Show("Không tìm thấy chi tiết để cập nhật!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int soLuongCu = Convert.ToInt32(chiTietDBRow["SoLuong"]);
                int chenhLech = soLuongMoi - soLuongCu; // Số lượng tăng hay giảm

                // Kiểm tra số lượng tồn kho nếu tăng số lượng mượn
                DataTable dtSach = SachBLL.LDLS();
                var sachRow = dtSach.AsEnumerable()
                    .FirstOrDefault(row => row.Field<string>("MaSach") == maSach);

                if (sachRow == null)
                {
                    MessageBox.Show("Không tìm thấy sách!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int soLuongTon = Convert.ToInt32(sachRow["SoLuong"]);
                if (chenhLech > 0 && soLuongTon < chenhLech)
                {
                    MessageBox.Show($"Chỉ còn {soLuongTon} cuốn sách này, không đủ để mượn thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Cập nhật chi tiết trong database
                ChiTietMuonTraSachBLL.ChiTietMuonTraSach_Update(maPhieuMuon, maSach, soLuongMoi);

                // Cập nhật tồn kho tương ứng
                if (chenhLech > 0)
                {
                    SoLuongSauMuon(maSach, chenhLech);  // Giảm tồn kho
                }
                else if (chenhLech < 0)
                {
                    SoLuongSauTra(maSach, -chenhLech); // Tăng tồn kho
                }

                // Cập nhật lại trong DataTable dtChiTietMuonTra1
                var rowInTable = dtChiTietMuonTra1.AsEnumerable()
                    .FirstOrDefault(r => r["MaSach"].ToString() == maSach);

                if (rowInTable != null)
                {
                    rowInTable["SoLuong"] = soLuongMoi;
                }

                // Cập nhật lại DataGridView
                dgvChiTietMuonTraSach1.DataSource = null;
                dgvChiTietMuonTraSach1.DataSource = dtChiTietMuonTra1;

                MessageBox.Show("Cập nhật chi tiết thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật chi tiết: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SoLuongSauMuon(string maSach, int soLuongMuon)
        {
            DataTable dtSach = SachBLL.LDLS();
            var sachRow = dtSach.AsEnumerable().FirstOrDefault(row => row.Field<string>("MaSach") == maSach);
            if (sachRow != null)
            {
                int soLuongTon = Convert.ToInt32(sachRow["SoLuong"]);
                int soLuongMoi = soLuongTon - soLuongMuon;
                SachBLL.Sach_UpdateSoLuong(maSach, soLuongMoi);
            }
        }

        private void dgvChiTietMuonTraSach1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    txbMPM.Text = txtMaPhieuMuon.Text;
                    cbbSach.SelectedValue = dgvChiTietMuonTraSach1.Rows[e.RowIndex].Cells["MaSach"].Value.ToString();
                    nubSoLuong.Value = Convert.ToDecimal(dgvChiTietMuonTraSach1.Rows[e.RowIndex].Cells["SoLuong"].Value);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi hiển thị thông tin chi tiết phiếu mượn: {ex.Message}", "Lỗi",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txbMPM_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLichSu_Click(object sender, EventArgs e)
        {
            // Truyền tenDangNhap và loaiTaiKhoan (nếu có), nhưng hiện tại chúng chưa được khởi tạo
            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(loaiTaiKhoan))
            {
                MessageBox.Show("Thông tin đăng nhập không khả dụng. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Form_LichSu lichSuForm = new Form_LichSu(this, tenDangNhap, loaiTaiKhoan);
            lichSuForm.ShowDialog();
        }

        public void PhucHoiPhieuMuon(string maPM, string maDG, string maNV, DateTime ngayMuon, DateTime ngayTra, string ghiChu, string maSach, int soLuong)
        {
            // 1. Kiểm tra và thêm lại phiếu mượn nếu chưa có
            DataTable dt = MuonTraSachBLL.MuonTraSach_Select();
            bool tonTai = dt.AsEnumerable().Any(r => r.Field<string>("MaPhieuMuon") == maPM);
            if (!tonTai)
            {
                MuonTraSachBLL.MuonTraSach_Insert(maPM, maDG, maNV, ngayMuon, ngayTra, ghiChu);
            }

            // 2. Thêm chi tiết
            ChiTietMuonTraSachBLL.ChiTietMuonTraSach_Insert(maPM, maSach, soLuong);

            // 3. Cập nhật giao diện
            txtMaPhieuMuon.Text = maPM;
            cbbDocGia.SelectedValue = maDG;
            cbbNhanVien.SelectedValue = maNV;
            dtpNgaymuon.Value = ngayMuon;
            dtpNgayTra.Value = ngayTra;
            txtGhiChu.Text = ghiChu;
            cbbSach.SelectedValue = maSach;
            nubSoLuong.Value = soLuong;

            MessageBox.Show("Đã khôi phục phiếu mượn từ lịch sử!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Làm mới dgv
            LoadAndResizeDataGridView();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPhieuMuon.Text))
            {
                MessageBox.Show("Vui lòng chọn một phiếu mượn để in!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MaPM = txtMaPhieuMuon.Text;
            Form_InPhieuMuon frm = new Form_InPhieuMuon();
            frm.Show();
        }

        private void dgvMuonTraSach1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridView dgv = sender as DataGridView;
                if (dgv.Columns[e.ColumnIndex].Name == "MaDocGia")
                {
                    string maDocGia = dgv.Rows[e.RowIndex].Cells["MaDocGia"].Value?.ToString();
                    if (!string.IsNullOrEmpty(maDocGia))
                    {
                        DataTable dtDocGia = DocGiaBLL.LDLDG();
                        var row = dtDocGia.AsEnumerable().FirstOrDefault(r => r.Field<string>("MaDocGia") == maDocGia);
                        if (row != null)
                        {
                            e.Value = row.Field<string>("HoTenDocGia") ?? maDocGia;
                            e.FormattingApplied = true;
                        }
                    }
                }
                else if (dgv.Columns[e.ColumnIndex].Name == "MaNhanVien")
                {
                    string maNhanVien = dgv.Rows[e.RowIndex].Cells["MaNhanVien"].Value?.ToString();
                    if (!string.IsNullOrEmpty(maNhanVien))
                    {
                        DataTable dtNhanVien = NhanVienBLL.LDLNV();
                        var row = dtNhanVien.AsEnumerable().FirstOrDefault(r => r.Field<string>("MaNhanVien") == maNhanVien);
                        if (row != null)
                        {
                            e.Value = row.Field<string>("HoTen") ?? maNhanVien;
                            e.FormattingApplied = true;
                        }
                    }
                }
            }
        }

        private void dgvChiTietMuonTraSach1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridView dgv = sender as DataGridView;
                if (dgv.Columns[e.ColumnIndex].Name == "MaSach")
                {
                    string maSach = dgv.Rows[e.RowIndex].Cells["MaSach"].Value?.ToString();
                    if (!string.IsNullOrEmpty(maSach))
                    {
                        DataTable dtSach = SachBLL.LDLS();
                        var row = dtSach.AsEnumerable().FirstOrDefault(r => r.Field<string>("MaSach") == maSach);
                        if (row != null)
                        {
                            e.Value = row.Field<string>("TenSach") ?? maSach;
                            e.FormattingApplied = true;
                        }
                    }
                }
            }
        }
    }
}