using Quanlysinhvien_01.BLL;
using Quanlysinhvien_01.DAL;
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
    public partial class fQuanLyThiCu : Form
    {
        public fQuanLyThiCu()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void fQuanLyThiCu_Load(object sender, EventArgs e)
        {
            btnLamMoi.PerformClick();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvThiCu.DataSource = DAL_ThiCu.Instance.DanhSach();
            cmbCourseID.DataSource = BLL_MonHoc.Instance.DanhSach();
            cmbCourseID.DisplayMember = "TenMH";
            cmbCourseID.ValueMember = "MaMH";
            cmbCourseID.SelectedIndex = 0;
            txbExamName.Text = "";
            dtpkExamDate.Value = DateTime.Now;
            dtpkStartTime.Value = DateTime.Now;
            dtpkEndTime.Value = DateTime.Now;
            rdOpenExam.Checked = true;
            txbId.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string examName = txbExamName.Text.Trim();
            DateTime ngaysinh = dtpkExamDate.Value;

            DateTime startDateTime = dtpkStartTime.Value;
            TimeSpan startTime = startDateTime.TimeOfDay;
            DateTime endDateTime = dtpkEndTime.Value;
            TimeSpan endTime = endDateTime.TimeOfDay;

            string courseId = cmbCourseID.SelectedValue.ToString();
            Boolean status = (rdOpenExam.Checked == true) ? true : false;

            if (string.IsNullOrEmpty(examName))
            {
                MessageBox.Show("Please enter complete information", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (BLL_ThiCu.Instance.Them(examName, ngaysinh, startTime, endTime, courseId, status) == true)
                        btnLamMoi.PerformClick();
                    MessageBox.Show("Add exam successfully.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Exam name already exists", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string examName = txbExamName.Text.Trim();
            DateTime ngaysinh = dtpkExamDate.Value;

            DateTime startDateTime = dtpkStartTime.Value;
            TimeSpan startTime = startDateTime.TimeOfDay;
            DateTime endDateTime = dtpkEndTime.Value;
            TimeSpan endTime = endDateTime.TimeOfDay;

            string courseId = cmbCourseID.SelectedValue.ToString();
            Boolean status = (rdOpenExam.Checked == true) ? true : false;

            if (string.IsNullOrEmpty(txbId.Text) || !int.TryParse(txbId.Text, out int id))
            {
                MessageBox.Show("Please select a valid ID before editing.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(examName))
            {
                MessageBox.Show("Please enter complete information", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (BLL_ThiCu.Instance.Sua(examName, ngaysinh, startTime, endTime, courseId, status, id) == true)
                        btnLamMoi.PerformClick();
                    MessageBox.Show("Update exam successfully.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Exam name already exists", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string examName = txbExamName.Text.ToString();

            if (string.IsNullOrEmpty(txbId.Text) || !int.TryParse(txbId.Text, out int id))
            {
                MessageBox.Show("Please select a valid ID before deleting.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Do you want to delete exam " + examName + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                try
                {
                    if (BLL_ThiCu.Instance.Xoa(id) == true)
                        btnLamMoi.PerformClick();
                    MessageBox.Show("Delete exam successfully.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("There was a problem during deletion, deletion cannot be done!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void dgvThiCu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbId.Text = dgvThiCu.CurrentRow.Cells[0].Value.ToString();
            txbExamName.Text = dgvThiCu.CurrentRow.Cells[1].Value.ToString();
            dtpkExamDate.Value = (DateTime)dgvThiCu.CurrentRow.Cells[2].Value;

            TimeSpan startTime = (TimeSpan)dgvThiCu.CurrentRow.Cells[3].Value;
            DateTime startDateTime = DateTime.Today.Add(startTime);
            dtpkStartTime.Value = startDateTime;

            TimeSpan endTime = (TimeSpan)dgvThiCu.CurrentRow.Cells[4].Value;
            DateTime endDateTime = DateTime.Today.Add(endTime);
            dtpkEndTime.Value = endDateTime;

            cmbCourseID.SelectedValue = dgvThiCu.CurrentRow.Cells[5].Value.ToString();

            bool status = Convert.ToBoolean(dgvThiCu.CurrentRow.Cells[6].Value);
            if (status)
                rdOpenExam.Checked = true;
            else
                rdCloseExam.Checked = true;
        }

        private void quảnLýCâuHỏiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLyCauHoi f = new fQuanLyCauHoi();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
