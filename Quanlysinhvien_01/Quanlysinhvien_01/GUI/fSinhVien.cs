using Quanlysinhvien_01.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlysinhvien_01.GUI
{
    public partial class fSinhVien : Form
    {
        public fSinhVien()
        {
            InitializeComponent();
        }

        private void fSinhVien_Load(object sender, EventArgs e)
        {
                if (Hethong.LOAITAIKHOAN != "Quản trị")
                {
                    btnQuanLy.Visible = false;
                }
                else
                {
                    btnQuanLy.Visible = true;
                }
                btnLamMoi.PerformClick();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLyTaiKhoan f = new fQuanLyTaiKhoan();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void quảnLýKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLyKhoa f = new fQuanLyKhoa();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void quảnLýLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLyLop f = new fQuanLyLop();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void quảnLýCốVấnHọcTậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fCoVanHocTap f = new fCoVanHocTap();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void quảnLýMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLyMonHoc f = new fQuanLyMonHoc();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void quảnLýĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýĐiểmToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fQuanLyDiem f = new fQuanLyDiem();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThongTinChiTiet f = new fThongTinChiTiet();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void quảnLýĐềThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLyThiCu f = new fQuanLyThiCu();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string masv = txbMaSV.Text.Trim();
            string tensv = txbTenSV.Text.Trim();
            string ngaysinh = dtpkNgaySinh.Value.ToShortDateString();
            string gioitinh = (rdNam.Checked == true) ? "Nam" : "Nữ";
            string quequan = txbQueQuan.Text.Trim();
            string ngaynhaphoc = dtpkNhapHoc.Value.ToShortDateString();
            string malop = cmbMaLop.SelectedValue.ToString();
            string makhoa = cmbMaKhoa.SelectedValue.ToString();
            string macovan = cmbMaCoVan.SelectedValue.ToString();

            try
            {
                if (string.IsNullOrEmpty(masv) || string.IsNullOrEmpty(tensv) || string.IsNullOrEmpty(quequan))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!IsValid_01(masv))
                {
                    MessageBox.Show("Mã sinh viên chỉ được nhập số hoặc chữ cái!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!IsValid_02(tensv))
                {
                    MessageBox.Show("Tên sinh viên chỉ được nhập chữ cái!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!IsValid_01(quequan))
                {
                    MessageBox.Show("Quê quán chỉ được nhập số hoặc chữ cái!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (BLL_SinhVien.Instance.Them(masv, tensv, ngaysinh, gioitinh, quequan, ngaynhaphoc, malop, makhoa, macovan))
                {
                    btnLamMoi.PerformClick(); 
                    MessageBox.Show("Thêm thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm sinh viên thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string masv = txbMaSV.Text.Trim();
            string tensv = txbTenSV.Text.Trim();
            string ngaysinh = dtpkNgaySinh.Value.ToShortDateString();
            string gioitinh = (rdNam.Checked == true) ? "Nam" : "Nữ";
            string quequan = txbQueQuan.Text.Trim();
            string ngaynhaphoc = dtpkNhapHoc.Value.ToShortDateString();
            string malop = cmbMaLop.SelectedValue.ToString();
            string makhoa = cmbMaKhoa.SelectedValue.ToString();
            string macovan = cmbMaCoVan.SelectedValue.ToString();

            if (string.IsNullOrEmpty(txbID.Text) || !int.TryParse(txbID.Text, out int id))
            {
                MessageBox.Show("Vui lòng chọn ID hợp lệ trước khi sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (string.IsNullOrEmpty(masv) || string.IsNullOrEmpty(tensv) || string.IsNullOrEmpty(quequan))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!IsValid_01(masv))
                {
                    MessageBox.Show("Mã sinh viên chỉ được nhập số hoặc chữ cái!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!IsValid_02(tensv))
                {
                    MessageBox.Show("Tên sinh viên chỉ được nhập chữ cái!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!IsValid_01(quequan))
                {
                    MessageBox.Show("Quê quán chỉ được nhập số hoặc chữ cái!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (BLL_SinhVien.Instance.Sua(masv, tensv, ngaysinh, gioitinh, quequan, ngaynhaphoc, malop, makhoa, macovan, id))
                {
                    btnLamMoi.PerformClick(); 
                    MessageBox.Show("Sửa thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sửa thông tin sinh viên thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string MaSV = txbMaSV.Text;
            if (string.IsNullOrEmpty(txbID.Text) || !int.TryParse(txbID.Text, out int id))
            {
                MessageBox.Show("Vui lòng chọn ID hợp lệ trước khi xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có muốn xóa sinh viên " + MaSV + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                try
                {
                    if (BLL_SinhVien.Instance.Xoa(id) == true)
                        btnLamMoi.PerformClick();
                    MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Phát sinh lỗi khi xóa...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            if (Hethong.MACVHT == "") {
                dgvSinhVien.DataSource = BLL_SinhVien.Instance.DanhSach();
            }
            else
            {
                dgvSinhVien.DataSource = BLL_SinhVien.Instance.DanhSachSV_CVHT(Hethong.MACVHT);
            }
            cmbMaCoVan.DataSource = BLL_CoVanHocTap.Instance.DanhSach();
            cmbMaCoVan.DisplayMember = "TenCVHT";
            cmbMaCoVan.ValueMember = "MaCVHT";
            cmbMaKhoa.DataSource = BLL_Khoa.Instance.DanhSach();
            cmbMaKhoa.DisplayMember = "TenKhoa";
            cmbMaKhoa.ValueMember = "MaKhoa";
            cmbMaLop.DataSource = BLL_Lop.Instance.DanhSach();
            cmbMaLop.DisplayMember = "TenLop";
            cmbMaLop.ValueMember = "MaLop";
            txbID.Text = "";
            txbMaSV.Text = "";
            txbTenSV.Text = "";
            dtpkNgaySinh.Value = DateTime.Now;
            rdNam.Checked = true;
            txbQueQuan.Text = "";
            dtpkNhapHoc.Value = DateTime.Now;
            cmbMaLop.SelectedIndex = 0;
            cmbMaKhoa.SelectedIndex = 0;
            cmbMaCoVan.SelectedIndex = 0;
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbID.Text = dgvSinhVien.CurrentRow.Cells[0].Value.ToString();
            txbMaSV.Text = dgvSinhVien.CurrentRow.Cells[1].Value.ToString();
            txbTenSV.Text = dgvSinhVien.CurrentRow.Cells[2].Value.ToString();
            dtpkNgaySinh.Value = (DateTime)dgvSinhVien.CurrentRow.Cells[3].Value;
            if (dgvSinhVien.CurrentRow.Cells[4].Value.ToString().Trim() == "Nam")
                rdNam.Checked = true;
            else
                rdNu.Checked = true;
            txbQueQuan.Text = dgvSinhVien.CurrentRow.Cells[5].Value.ToString();
            dtpkNhapHoc.Value = (DateTime)dgvSinhVien.CurrentRow.Cells[6].Value;
            cmbMaLop.SelectedValue = dgvSinhVien.CurrentRow.Cells[7].Value.ToString();
            cmbMaKhoa.SelectedValue = dgvSinhVien.CurrentRow.Cells[8].Value.ToString();
            cmbMaCoVan.SelectedValue = dgvSinhVien.CurrentRow.Cells[9].Value.ToString();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDoiMatKhau f = new fDoiMatKhau();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private bool IsValidInput(string input, string regexPattern, string errorMessage)
        {
            if (!Regex.IsMatch(input, regexPattern))
            {
                MessageBox.Show(errorMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool IsValid_01(string test)
        {
            return Regex.IsMatch(test, @"^[a-zA-Z0-9]+$");
        }

        private bool IsValid_02(string test)
        {
            return Regex.IsMatch(test, @"^[a-zA-Z\s]+$");
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
    }
}
