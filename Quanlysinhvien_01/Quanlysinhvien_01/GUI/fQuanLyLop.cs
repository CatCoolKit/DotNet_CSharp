using Quanlysinhvien_01.BLL;
using Quanlysinhvien_01.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlysinhvien_01.GUI
{
    public partial class fQuanLyLop : Form
    {
        public fQuanLyLop()
        {
            InitializeComponent();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvLop.DataSource = BLL_Lop.Instance.DanhSach();
            cmbMaKhoa.DataSource = BLL_Khoa.Instance.DanhSach();
            cmbMaKhoa.DisplayMember = "TenKhoa";
            cmbMaKhoa.ValueMember = "MaKhoa";
            cmbMaKhoa.SelectedIndex = 0;
            txbID.Text = "";
            txbMaLop.Text = "";
            txbTenLop.Text = "";
            numSoLuong.Value = 0;
        }

        private void fQuanLyLop_Load(object sender, EventArgs e)
        {
            btnLamMoi.PerformClick();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string malop = txbMaLop.Text.Trim();
            string tenlop = txbTenLop.Text.Trim();
            int soluong = (int)numSoLuong.Value;
            string makhoa = cmbMaKhoa.SelectedValue.ToString().Trim();

            if (string.IsNullOrEmpty(malop) || string.IsNullOrEmpty(tenlop) || soluong == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (BLL_Lop.Instance.Them(malop, tenlop, soluong, makhoa) == true)
                        btnLamMoi.PerformClick();
                    MessageBox.Show("Thêm thông tin lớp học thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Mã lớp đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string tenlop = dgvLop.CurrentRow.Cells[2].Value.ToString().Trim();

            if (string.IsNullOrEmpty(txbID.Text) || !int.TryParse(txbID.Text, out int id))
            {
                MessageBox.Show("Vui lòng chọn ID hợp lệ trước khi xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa lớp " + tenlop + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                try
                {
                    if (BLL_Lop.Instance.Xoa(id) == true)
                        btnLamMoi.PerformClick();
                    MessageBox.Show("Xóa thông tin lớp học thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Mã lớp đang được sử dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string malop = txbMaLop.Text.Trim();
            string tenlop = txbTenLop.Text.Trim();
            int soluong = (int)numSoLuong.Value;
            string makhoa = cmbMaKhoa.SelectedValue.ToString();

            if (string.IsNullOrEmpty(txbID.Text) || !int.TryParse(txbID.Text, out int id))
            {
                MessageBox.Show("Vui lòng chọn ID hợp lệ trước khi sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(malop) || string.IsNullOrEmpty(tenlop) || soluong == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (BLL_Lop.Instance.Sua(malop, tenlop, soluong, makhoa, id) == true)
                        btnLamMoi.PerformClick();
                    MessageBox.Show("Cập nhật thông tin lớp học thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Mã lớp đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                }
            }
        }

        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbID.Text = dgvLop.CurrentRow.Cells[0].Value.ToString().Trim();
            txbMaLop.Text = dgvLop.CurrentRow.Cells[1].Value.ToString().Trim();
            txbTenLop.Text = dgvLop.CurrentRow.Cells[2].Value.ToString().Trim();
            numSoLuong.Value = int.Parse(dgvLop.CurrentRow.Cells[3].Value.ToString());
            cmbMaKhoa.SelectedValue = dgvLop.CurrentRow.Cells[4].Value.ToString().Trim();
        }
    }
}
