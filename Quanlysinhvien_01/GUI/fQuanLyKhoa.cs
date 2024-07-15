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

namespace Quanlysinhvien_01.GUI
{
    public partial class fQuanLyKhoa : Form
    {
        public fQuanLyKhoa()
        {
            InitializeComponent();
        }

        private void fQuanLyKhoa_Load(object sender, EventArgs e)
        {
            btnLamMoi.PerformClick();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvKhoa.DataSource = BLL_Khoa.Instance.DanhSach();
            txbID.Text = "";
            txbMaKhoa.Text = "";
            txbTenKhoa.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string makhoa = txbMaKhoa.Text.Trim();
            string tenkhoa = txbTenKhoa.Text.Trim();

            if (string.IsNullOrEmpty(makhoa) || string.IsNullOrEmpty(tenkhoa))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (BLL_Khoa.Instance.Them(makhoa, tenkhoa) == true)
                        btnLamMoi.PerformClick();
                    MessageBox.Show("Thêm thông tin khoa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Mã khoa đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string makhoa = txbMaKhoa.Text.Trim();
            string tenkhoa = txbTenKhoa.Text.Trim();

            if (string.IsNullOrEmpty(txbID.Text) || !int.TryParse(txbID.Text, out int id))
            {
                MessageBox.Show("Vui lòng chọn ID hợp lệ trước khi sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(makhoa) || string.IsNullOrEmpty(tenkhoa))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (BLL_Khoa.Instance.Sua(makhoa, tenkhoa, id) == true)
                        btnLamMoi.PerformClick();
                    MessageBox.Show("Cập nhật thông tin khoa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Mã khoa đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string tenkhoa = dgvKhoa.CurrentRow.Cells[2].Value.ToString().Trim();
            if (string.IsNullOrEmpty(txbID.Text) || !int.TryParse(txbID.Text, out int id))
            {
                MessageBox.Show("Vui lòng chọn ID hợp lệ trước khi xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có muốn xóa khoa " + tenkhoa + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                try
                {
                    if (BLL_Khoa.Instance.Xoa(id) == true)
                        btnLamMoi.PerformClick();
                    MessageBox.Show("Xóa thông tin khoa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Mã khoa đang được sử dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void dgvKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbID.Text = dgvKhoa.CurrentRow.Cells[0].Value.ToString().Trim();
            txbMaKhoa.Text = dgvKhoa.CurrentRow.Cells[1].Value.ToString().Trim();
            txbTenKhoa.Text = dgvKhoa.CurrentRow.Cells[2].Value.ToString().Trim();
        }
    }
}
