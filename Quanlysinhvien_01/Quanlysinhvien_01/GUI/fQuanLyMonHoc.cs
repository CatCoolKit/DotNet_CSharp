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
    public partial class fQuanLyMonHoc : Form
    {
        public fQuanLyMonHoc()
        {
            InitializeComponent();
        }

        private void fQuanLyMonHoc_Load(object sender, EventArgs e)
        {
            btnLamMoi.PerformClick();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvMonHoc.DataSource = BLL_MonHoc.Instance.DanhSach();
            txbID.Text = "";
            txbMaMonHoc.Text = "";
            txbTenMonHoc.Text = "";
            numSoTinChi.Value = 0;
            numTietlyThuyet.Value = 0;
            numTietThucHanh.Value = 0;
        }

        private void dgvMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbID.Text = dgvMonHoc.CurrentRow.Cells[0].Value.ToString().Trim();
            txbMaMonHoc.Text = dgvMonHoc.CurrentRow.Cells[1].Value.ToString().Trim();
            txbTenMonHoc.Text = dgvMonHoc.CurrentRow.Cells[2].Value.ToString().Trim();
            numSoTinChi.Value = int.Parse(dgvMonHoc.CurrentRow.Cells[3].Value.ToString());
            numTietlyThuyet.Value = int.Parse(dgvMonHoc.CurrentRow.Cells[4].Value.ToString());
            numTietThucHanh.Value = int.Parse(dgvMonHoc.CurrentRow.Cells[5].Value.ToString());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string mamonhoc = txbMaMonHoc.Text.Trim();
            string tenmonhoc = txbTenMonHoc.Text.Trim();
            int sotinchi = int.Parse(numSoTinChi.Value.ToString().Trim());
            int sotietlythuyet = int.Parse(numTietlyThuyet.Value.ToString().Trim());
            int sotietthuchanh = int.Parse(numTietThucHanh.Value.ToString().Trim());

            if (string.IsNullOrEmpty(mamonhoc) || string.IsNullOrEmpty(tenmonhoc) || sotinchi == 0 || sotietlythuyet == 0 || sotietthuchanh == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (BLL_MonHoc.Instance.Them(mamonhoc, tenmonhoc, sotinchi, sotietlythuyet, sotietthuchanh) == true)
                        btnLamMoi.PerformClick();
                    MessageBox.Show("Thêm thông tin môn học thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Mã môn học đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string mamonhoc = txbMaMonHoc.Text.Trim();
            string tenmonhoc = txbTenMonHoc.Text.Trim();
            int sotinchi = int.Parse(numSoTinChi.Value.ToString().Trim());
            int sotietlythuyet = int.Parse(numTietlyThuyet.Value.ToString().Trim());
            int sotietthuchanh = int.Parse(numTietThucHanh.Value.ToString().Trim());

            if (string.IsNullOrEmpty(txbID.Text) || !int.TryParse(txbID.Text, out int id))
            {
                MessageBox.Show("Vui lòng chọn ID hợp lệ trước khi sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(mamonhoc) || string.IsNullOrEmpty(tenmonhoc) || sotinchi == 0 || sotietlythuyet == 0 || sotietthuchanh == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (BLL_MonHoc.Instance.Sua(mamonhoc, tenmonhoc, sotinchi, sotietlythuyet, sotietthuchanh, id) == true)
                        btnLamMoi.PerformClick();
                    MessageBox.Show("Cập nhật thông tin môn học thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Mã môn học đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string mamonhoc = txbMaMonHoc.Text;

            if (string.IsNullOrEmpty(txbID.Text) || !int.TryParse(txbID.Text, out int id))
            {
                MessageBox.Show("Vui lòng chọn ID hợp lệ trước khi xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa mã môn " + mamonhoc + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                try
                {
                    if (BLL_MonHoc.Instance.Xoa(id) == true)
                        btnLamMoi.PerformClick();
                    MessageBox.Show("Xóa thông tin môn học thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Mã học tập hiện đang được sử dụng, không thể xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
