using Quanlysinhvien_01.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Quanlysinhvien_01.GUI
{
    public partial class fQuanLyTaiKhoan : Form
    {
        public fQuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tendangnhap = txbTenDangNhap.Text.Trim();
            string matkhau = txbMatKhau.Text.Trim();
            string loaiTK = cmbLoaiTaiKhoan.SelectedItem.ToString();
            string maCVHT = cmbMaCVHT.SelectedValue.ToString();

            if (tendangnhap.Length > 0 && matkhau.Length >= 6)
            {
                try
                {
                    if (BLL_TaiKhoan.Instance.Them(tendangnhap, matkhau, loaiTK, maCVHT) == true)
                        btnLamMoi.PerformClick();
                        MessageBox.Show($"Thêm tài khoản {loaiTK} thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Tên đăng nhập bị trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (string.IsNullOrEmpty(tendangnhap) || string.IsNullOrEmpty(matkhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Mật khẩu không được dưới 6 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string tendangnhap = txbTenDangNhap.Text.Trim();
            string matkhau = txbMatKhau.Text.Trim();
            string loaiTK = cmbLoaiTaiKhoan.SelectedItem.ToString();
            string maCVHT = cmbMaCVHT.SelectedValue.ToString();

            if (string.IsNullOrEmpty(txbID.Text) || !int.TryParse(txbID.Text, out int id))
            {
                MessageBox.Show("Vui lòng chọn ID hợp lệ trước khi sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tendangnhap.Length > 0)
            {
                try
                {
                    if (matkhau.Length == 0)
                    {
                        if (BLL_TaiKhoan.Instance.KhongSuaMatKhau(tendangnhap, loaiTK, maCVHT, id) == true)
                            btnLamMoi.PerformClick();
                            MessageBox.Show($"Cập nhật tài khoản {loaiTK} thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (matkhau.Length >= 6)
                        {
                            BLL_TaiKhoan.Instance.Sua_Het(tendangnhap, matkhau, loaiTK, maCVHT, id);
                            btnLamMoi.PerformClick();
                            MessageBox.Show($"Cập nhật tài khoản {loaiTK} thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu không được dưới 6 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                }
                catch
                {
                    MessageBox.Show("Tên đăng nhập bị trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (string.IsNullOrEmpty(tendangnhap) || string.IsNullOrEmpty(matkhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ten = dgvTaiKhoan.CurrentRow.Cells[1].Value.ToString().Trim();
            string loaiTK = cmbLoaiTaiKhoan.SelectedItem.ToString();

            if (string.IsNullOrEmpty(txbID.Text) || !int.TryParse(txbID.Text, out int id))
            {
                MessageBox.Show("Vui lòng chọn ID hợp lệ trước khi xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa tài khoản " + ten + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                try
                {
                    if (BLL_TaiKhoan.Instance.Xoa(id) == true)
                        btnLamMoi.PerformClick();
                        MessageBox.Show($"Xóa tài khoản {loaiTK} thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Phát sinh lỗi khi xóa...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvTaiKhoan.DataSource = BLL_TaiKhoan.Instance.DanhSach();
            txbID.Text = "";
            txbTenDangNhap.Text = "";
            txbMatKhau.Text = "";
            cmbLoaiTaiKhoan.SelectedIndex = 0;
        }

        private void fQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            btnLamMoi.PerformClick(); 
            cmbLoaiTaiKhoan.SelectedIndex = 0;
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbID.Text = dgvTaiKhoan.CurrentRow.Cells[0].Value.ToString().Trim();
            txbTenDangNhap.Text = dgvTaiKhoan.CurrentRow.Cells[1].Value.ToString().Trim();
            //txbMatKhau.Text = dgvTaiKhoan.CurrentRow.Cells[2].Value.ToString().Trim();
            cmbLoaiTaiKhoan.SelectedItem = dgvTaiKhoan.CurrentRow.Cells[3].Value.ToString().Trim();
            cmbMaCVHT.SelectedValue = dgvTaiKhoan.CurrentRow.Cells[4].Value.ToString().Trim();
        }

        private void dgvTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cmbLoaiTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLoaiTaiKhoan.SelectedItem.ToString().Equals("Cố vấn học tập"))
            {
                cmbMaCVHT.DataSource = BLL_CoVanHocTap.Instance.DanhSach();
                cmbMaCVHT.DisplayMember = "TenCVHT";
                cmbMaCVHT.ValueMember = "MaCVHT";
                cmbMaCVHT.SelectedIndex = 0;
                cmbMaCVHT.Visible = true; 
                lbMaCVHT.Visible = true;
            }
            else
            {
                cmbMaCVHT.Visible = false;
                lbMaCVHT.Visible = false;
            }
        }
    }
}
