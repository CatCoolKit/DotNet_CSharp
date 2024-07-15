using Microsoft.VisualBasic;
using Quanlysinhvien_01.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlysinhvien_01.GUI
{
    public partial class fQuanLyDiem : Form
    {
        public fQuanLyDiem()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fQuanLyDiem_Load(object sender, EventArgs e)
        {
            btnLamMoi.PerformClick();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvDiem.DataSource = BLL_Diem.Instance.DanhSach();
            cmbMaSV.DataSource = BLL_SinhVien.Instance.DanhSach();
            cmbMaSV.DisplayMember = "TenSV";
            cmbMaSV.ValueMember = "MaSV";
            cmbMaMH.DataSource = BLL_MonHoc.Instance.DanhSach();
            cmbMaMH.DisplayMember = "TenMH";
            cmbMaMH.ValueMember = "MaMH";
            cmbLoai.SelectedIndex = 0;
            txbID.Text = "";
            numPTTrenLop.Value = 0;
            numPTThi.Value = 0;
            txbDiemTrenLop.Text = "";
            txbDiemThi.Text = "";
            txbDiemTB.Text = "";
            txbNamHoc.Text = "";
            cmbMaMH.SelectedIndex = 0;
            cmbMaSV.SelectedIndex = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string MaSV = cmbMaSV.SelectedValue.ToString();
            string MaMH = cmbMaMH.SelectedValue.ToString();
            char Loai = char.Parse(cmbLoai.SelectedItem.ToString().Trim());
            if (!int.TryParse(numPTTrenLop.Value.ToString(), out int PTTrenLop) ||
        !int.TryParse(numPTThi.Value.ToString(), out int PTThi) ||
        !double.TryParse(txbDiemTrenLop.Text.Trim(), out double DiemTrenLop) ||
        !double.TryParse(txbDiemThi.Text.Trim(), out double DiemThi) ||
        !double.TryParse(txbDiemTB.Text.Trim(), out double DiemTB) ||
        !int.TryParse(txbNamHoc.Text.Trim(), out int NamHoc))
            {
                MessageBox.Show("Vui lòng nhập thông tin đúng định dạng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (PTTrenLop == 0 || PTThi == 0 || DiemTrenLop == 0 || DiemThi == 0 || DiemTB == 0 || NamHoc <= 1975)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin và thông tin hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (BLL_Diem.Instance.Them(MaSV, MaMH, PTTrenLop, PTThi, DiemTrenLop, DiemThi, DiemTB, Loai, NamHoc) == true)
                        btnLamMoi.PerformClick();
                    MessageBox.Show("Thêm thông tin điểm của sinh viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Đã xảy ra sự cố khi thêm thông tin, vui lòng kiểm tra lại thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string MaSV = cmbMaSV.SelectedValue.ToString();
            string MaMH = cmbMaMH.SelectedValue.ToString();
            char Loai = char.Parse(cmbLoai.SelectedItem.ToString().Trim());

            if (string.IsNullOrEmpty(txbID.Text) || !int.TryParse(txbID.Text, out int id))
            {
                MessageBox.Show("Vui lòng chọn ID hợp lệ trước khi sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(numPTTrenLop.Value.ToString(), out int PTTrenLop) ||
        !int.TryParse(numPTThi.Value.ToString(), out int PTThi) ||
        !double.TryParse(txbDiemTrenLop.Text.Trim(), out double DiemTrenLop) ||
        !double.TryParse(txbDiemThi.Text.Trim(), out double DiemThi) ||
        !double.TryParse(txbDiemTB.Text.Trim(), out double DiemTB) ||
        !int.TryParse(txbNamHoc.Text.Trim(), out int NamHoc))
            {
                MessageBox.Show("Vui lòng nhập thông tin đúng định dạng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (PTTrenLop == 0 || PTThi == 0 || DiemTrenLop == 0 || DiemThi == 0 || DiemTB == 0 || NamHoc <= 1975)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (BLL_Diem.Instance.Sua(MaSV, MaMH, PTTrenLop, PTThi, DiemTrenLop, DiemThi, DiemTB, Loai, NamHoc, id) == true)
                        btnLamMoi.PerformClick();
                    MessageBox.Show("Cập nhật thông tin điểm của sinh viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Đã xảy ra sự cố khi sửa thông tin, vui lòng kiểm tra lại thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string MaSV = cmbMaSV.Text;

            if (string.IsNullOrEmpty(txbID.Text) || !int.TryParse(txbID.Text, out int id))
            {
                MessageBox.Show("Vui lòng chọn ID hợp lệ trước khi xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa thông tin điểm của " + MaSV + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                try
                {
                    if (BLL_Diem.Instance.Xoa(id) == true)
                        btnLamMoi.PerformClick();
                    MessageBox.Show("Xóa thông tin điểm của sinh viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Đã xảy ra sự cố khi xóa, vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void dgvDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbID.Text = dgvDiem.CurrentRow.Cells[0].Value.ToString();
            cmbMaSV.SelectedValue = dgvDiem.CurrentRow.Cells[1].Value.ToString();
            cmbMaMH.SelectedValue = dgvDiem.CurrentRow.Cells[2].Value.ToString();
            numPTTrenLop.Value = int.Parse(dgvDiem.CurrentRow.Cells[3].Value.ToString());
            numPTThi.Value = int.Parse(dgvDiem.CurrentRow.Cells[4].Value.ToString());
            txbDiemTrenLop.Text = dgvDiem.CurrentRow.Cells[5].Value.ToString();
            txbDiemThi.Text = dgvDiem.CurrentRow.Cells[6].Value.ToString();
            txbDiemTB.Text = dgvDiem.CurrentRow.Cells[7].Value.ToString();
            cmbLoai.SelectedItem = dgvDiem.CurrentRow.Cells[8].Value.ToString().Trim();
            txbNamHoc.Text = dgvDiem.CurrentRow.Cells[9].Value.ToString();
        }
    }
}
