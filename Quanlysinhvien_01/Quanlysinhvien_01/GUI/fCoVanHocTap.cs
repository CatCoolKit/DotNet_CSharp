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
    public partial class fCoVanHocTap : Form
    {
        public fCoVanHocTap()
        {
            InitializeComponent();
        }

        private void cmbMaKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dgvLop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fCoVanHocTap_Load(object sender, EventArgs e)
        {
            btnLamMoi.PerformClick();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvCoVanHocTap.DataSource = BLL_CoVanHocTap.Instance.DanhSach();
            cmbMaKhoa.DataSource = BLL_Khoa.Instance.DanhSach();
            cmbMaKhoa.DisplayMember = "TenKhoa";
            cmbMaKhoa.ValueMember = "MaKhoa";
            cmbMaLop.DataSource = BLL_Lop.Instance.DanhSach();
            cmbMaLop.DisplayMember = "TenLop";
            cmbMaLop.ValueMember = "MaLop";
            txbMaCoVan.Text = "";
            txbTenCoVan.Text = "";
            txbID.Text = "";
            cmbMaKhoa.SelectedIndex = 0;
            cmbMaLop.SelectedIndex = 0;
            rdNam.Checked = true;
            dtpkNgaySinh.Value = DateTime.Now;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string MaCVHT = txbMaCoVan.Text.Trim();
            string TenCVHT = txbTenCoVan.Text.Trim();
            string NgaySinh = dtpkNgaySinh.Value.ToShortDateString();
            string GioiTinh = (rdNam.Checked == true) ? "Nam" : "Nữ";
            string MaKhoa = cmbMaKhoa.SelectedValue.ToString();
            string MaLop = cmbMaLop.SelectedValue.ToString();

            if (string.IsNullOrEmpty(MaCVHT) || string.IsNullOrEmpty(TenCVHT))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (BLL_CoVanHocTap.Instance.Them(MaCVHT, TenCVHT, NgaySinh, GioiTinh, MaKhoa, MaLop) == true)
                        btnLamMoi.PerformClick();
                    MessageBox.Show("Thêm thành công cố vấn học tập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Mã cố vấn đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string MaCVHT = txbMaCoVan.Text.Trim();
            string TenCVHT = txbTenCoVan.Text.Trim();
            string NgaySinh = dtpkNgaySinh.Value.ToShortDateString();
            string GioiTinh = (rdNam.Checked == true) ? "Nam" : "Nữ";
            string MaKhoa = cmbMaKhoa.SelectedValue.ToString();
            string MaLop = cmbMaLop.SelectedValue.ToString();

            if (string.IsNullOrEmpty(txbID.Text) || !int.TryParse(txbID.Text, out int id))
            {
                MessageBox.Show("Vui lòng chọn ID hợp lệ trước khi sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(MaCVHT) || string.IsNullOrEmpty(TenCVHT))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {                try
                {
                    if (BLL_CoVanHocTap.Instance.Sua(MaCVHT, TenCVHT, NgaySinh, GioiTinh, MaKhoa, MaLop, id) == true)
                        btnLamMoi.PerformClick();
                    MessageBox.Show("Cập nhật thành công cố vấn học tập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Mã cố vấn đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string MaCVHT = txbMaCoVan.Text;

            if (string.IsNullOrEmpty(txbID.Text) || !int.TryParse(txbID.Text, out int id))
            {
                MessageBox.Show("Vui lòng chọn ID hợp lệ trước khi xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa cố vấn " + MaCVHT + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                try
                {
                    if (BLL_CoVanHocTap.Instance.Xoa(id) == true)
                        btnLamMoi.PerformClick();
                    MessageBox.Show("Xóa thành công cố vấn học tập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Mã cố vấn hiện đang được sử dụng, không thể xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void dgvCoVanHocTap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbID.Text = dgvCoVanHocTap.CurrentRow.Cells[0].Value.ToString();
            txbMaCoVan.Text = dgvCoVanHocTap.CurrentRow.Cells[1].Value.ToString();
            txbTenCoVan.Text = dgvCoVanHocTap.CurrentRow.Cells[2].Value.ToString();
            dtpkNgaySinh.Value = (DateTime)dgvCoVanHocTap.CurrentRow.Cells[3].Value;
            if (dgvCoVanHocTap.CurrentRow.Cells[4].Value.ToString().Trim() == "Nam")
                rdNam.Checked = true;
            else
                rdNu.Checked = true;
            cmbMaKhoa.SelectedValue = dgvCoVanHocTap.CurrentRow.Cells[5].Value.ToString().Trim();
            cmbMaLop.SelectedValue = dgvCoVanHocTap.CurrentRow.Cells[6].Value.ToString().Trim();
        }
    }
}
