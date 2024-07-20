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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Quanlysinhvien_01.GUI
{
    public partial class fQuanLyCauHoi : Form
    {
        public fQuanLyCauHoi()
        {
            InitializeComponent();
        }

        private void fQuanLyCauHoi_Load(object sender, EventArgs e)
        {
            btnLamMoi.PerformClick();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            cmbExamID.DataSource = BLL_ThiCu.Instance.DanhSach();
            cmbExamID.DisplayMember = "ExamName";
            cmbExamID.ValueMember = "ExamID";
            cmbQuestionType.SelectedIndex = 0;
            cmbExamID.SelectedIndex = 0; 
        }

        private void cmbExamID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbExamID.SelectedValue != null && int.TryParse(cmbExamID.SelectedValue.ToString(), out int ExamID))
            {
                dgvCauHoi.DataSource = BLL_CauHoi.Instance.DanhSach(ExamID);
            }
        }

        private void dgvCauHoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbId.Text = dgvCauHoi.CurrentRow.Cells[0].Value.ToString();
            cmbExamID.SelectedValue = dgvCauHoi.CurrentRow.Cells[1].Value.ToString();
            rtxbQuestion.Text = dgvCauHoi.CurrentRow.Cells[2].Value.ToString();
            cmbQuestionType.Text = dgvCauHoi.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string QText = rtxbQuestion.Text.Trim();
            int ExamID = int.Parse(cmbExamID.SelectedValue.ToString());
            string QType = cmbQuestionType.SelectedItem.ToString();

            if (string.IsNullOrEmpty(QText))
            {
                MessageBox.Show("Please enter complete information", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (BLL_CauHoi.Instance.Them(ExamID, QText, QType) == true)
                    {
                        //btnLamMoi.PerformClick();
                        dgvCauHoi.DataSource = BLL_CauHoi.Instance.DanhSach(ExamID);
                        MessageBox.Show("Question added successfully.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Question Text already exists", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch
                {
                    MessageBox.Show("There was a problem adding a new question, please try again!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string QText = rtxbQuestion.Text.Trim();
            int ExamID = int.Parse(cmbExamID.SelectedValue.ToString());
            string QType = cmbQuestionType.SelectedItem.ToString();

            if (string.IsNullOrEmpty(txbId.Text) || !int.TryParse(txbId.Text, out int id))
            {
                MessageBox.Show("Please select a valid ID before editing.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(QText))
            {
                MessageBox.Show("Please enter complete information", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (BLL_CauHoi.Instance.Sua(ExamID, QText, QType, id) == true)
                    {
                        //btnLamMoi.PerformClick(); 
                        dgvCauHoi.DataSource = BLL_CauHoi.Instance.DanhSach(ExamID);
                        MessageBox.Show("Question updated successfully.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Question Text already exists", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch
                {
                    MessageBox.Show("There was a problem updating a new question, please try again!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int ExamID = int.Parse(cmbExamID.SelectedValue.ToString());

            if (string.IsNullOrEmpty(txbId.Text) || !int.TryParse(txbId.Text, out int id))
            {
                MessageBox.Show("Please select a valid ID before deleting.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Do you want to delete question " + id + " of " + ExamID + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                try
                {
                    if (BLL_CauHoi.Instance.Xoa(id) == true)
                        //btnLamMoi.PerformClick(); 
                        dgvCauHoi.DataSource = BLL_CauHoi.Instance.DanhSach(ExamID);
                    MessageBox.Show("Question deleted successfully.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("There was a problem during deletion, deletion cannot be done!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void dgvCauHoi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
