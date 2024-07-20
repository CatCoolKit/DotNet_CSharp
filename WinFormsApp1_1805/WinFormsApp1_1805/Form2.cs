using Repository;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1_1805
{
    public partial class Form2 : Form
    {
        private StaffMemberRepository _staffmemberRepository;
        //private BindingSource source;
        //List<Student> listStudent = new List<Student>();
        public Form2()
        {
            InitializeComponent();
            _staffmemberRepository = new StaffMemberRepository();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            btnRefresh.PerformClick();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(txbName.Text) ||
            //    string.IsNullOrWhiteSpace(txbPhoneNumber.Text) ||
            //    string.IsNullOrWhiteSpace(txbAge.Text) ||
            //    string.IsNullOrWhiteSpace(txbGrade.Text) ||
            //    string.IsNullOrWhiteSpace(txbAddress.Text))
            //{
            //    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            //    return;
            //}

            //int age;
            //if (!int.TryParse(txbAge.Text, out age) || age <= 0)
            //{
            //    MessageBox.Show("Vui lòng nhập tuổi hợp lệ (số nguyên dương)");
            //    return;
            //}

            //double grade;
            //if (!double.TryParse(txbGrade.Text, out grade) || grade < 0 || grade > 10)
            //{
            //    MessageBox.Show("Vui lòng nhập điểm hợp lệ (từ 0 đến 10)");
            //    return;
            //}

            //if (!System.Text.RegularExpressions.Regex.IsMatch(txbPhoneNumber.Text, @"^\d{10,11}$"))
            //{
            //    MessageBox.Show("Vui lòng nhập số điện thoại hợp lệ (10-11 chữ số)");
            //    return;
            //}

            //Student student = new Student
            //{
            //    Name = txbName.Text,
            //    PhoneNumber = txbPhoneNumber.Text,
            //    Address = txbAddress.Text,
            //    Grade = grade,
            //    Age = age
            //};
            //listStudent.Add(student);
            //BindingSource source = new BindingSource();
            //source.DataSource = listStudent;
            //dgvListStudent.DataSource = listStudent;
            //source.ResetBindings(false);

            try
            {
                if (string.IsNullOrWhiteSpace(txbPassword.Text.Trim()) ||
                    string.IsNullOrWhiteSpace(txbFullName.Text.Trim()) ||
                    string.IsNullOrWhiteSpace(txbEmail.Text.Trim()) ||
                    cmbRole.SelectedItem == null)
                {
                    MessageBox.Show("Please fill in all required fields.");
                    return;
                }

                var staff = new StaffMember
                {
                    MemberId = DateTime.Now.Minute + DateTime.Now.Second,
                    Password = PasswordHelper.Hash(txbPassword.Text.Trim()),
                    FullName = txbFullName.Text.Trim(),
                    EmailAddress = txbEmail.Text.Trim()
                };

                if (int.TryParse(cmbRole.SelectedItem.ToString().Trim(), out int role))
                {
                    staff.Role = role;
                }
                else
                {
                    MessageBox.Show("Invalid role. Please select a valid role.");
                    return;
                }

                
                    _staffmemberRepository.Add(staff);

                    var listStaff = _staffmemberRepository.GetAll();

                    BindingSource bind = new BindingSource
                    {
                        DataSource = listStaff
                    };

                    dgvListStaff.DataSource = bind;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txbMemberID.Text.Trim()) ||
                    //string.IsNullOrWhiteSpace(txbPassword.Text.Trim()) ||
                    string.IsNullOrWhiteSpace(txbFullName.Text.Trim()) ||
                    string.IsNullOrWhiteSpace(txbEmail.Text.Trim()) ||
                    cmbRole.SelectedItem == null)
                {
                    MessageBox.Show("Please fill in all required fields.");
                    return;
                }

                if (!int.TryParse(txbMemberID.Text.Trim(), out int memberId))
                {
                    MessageBox.Show("Invalid Member ID. Please enter a valid number.");
                    return;
                }

                
                    var staff = _staffmemberRepository.GetById(memberId);

                    if (staff != null)
                    {
                        staff.Password = PasswordHelper.Hash(txbPassword.Text.Trim());
                        staff.FullName = txbFullName.Text.Trim();
                        staff.EmailAddress = txbEmail.Text.Trim();

                        if (int.TryParse(cmbRole.SelectedItem.ToString().Trim(), out int role))
                        {
                            staff.Role = role;
                        }
                        else
                        {
                            MessageBox.Show("Invalid role. Please select a valid role.");
                            return;
                        }

                        _staffmemberRepository.Update(staff);

                        var listStaff = _staffmemberRepository.GetAll();

                        BindingSource bind = new BindingSource
                        {
                            DataSource = listStaff
                        };

                        dgvListStaff.DataSource = bind;
                    }
                    else
                    {
                        MessageBox.Show("Staff member not found.");
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void dgvListStudent_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvListStudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvListStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dgvListStaff.Rows[e.RowIndex].HeaderCell.Value == null)
                {
                    txbMemberID.Text = dgvListStaff.Rows[e.RowIndex].Cells[0].Value?.ToString();
                    //txbPassword.Text = dgvListStaff.Rows[e.RowIndex].Cells[1].Value?.ToString();
                    txbFullName.Text = dgvListStaff.Rows[e.RowIndex].Cells[2].Value?.ToString();
                    txbEmail.Text = dgvListStaff.Rows[e.RowIndex].Cells[3].Value?.ToString();

                    object roleValue = dgvListStaff.Rows[e.RowIndex].Cells[4].Value;
                    if (roleValue != null)
                    {
                        cmbRole.SelectedItem = roleValue.ToString();
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txbMemberID.Text.Trim(), out int memberId))
                {
                    MessageBox.Show("Invalid Member ID. Please enter a valid number.");
                    return;
                }

                
                    var staff = _staffmemberRepository.GetById(memberId);

                    if (staff != null)
                    {
                        _staffmemberRepository.Delete(staff);

                        var listStaff = _staffmemberRepository.GetAll();

                        BindingSource bind = new BindingSource
                        {
                            DataSource = listStaff
                        };

                        dgvListStaff.DataSource = bind;

                        MessageBox.Show("Staff member deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Staff member not found.");
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            using (var dbcontext = new AirConditionerShop2023DBContext())
            {
                var listStaff = _staffmemberRepository.GetAll();

                BindingSource bind = new BindingSource();
                bind.DataSource = listStaff;
                cmbRole.SelectedIndex = 0;
                txbMemberID.Text = "";
                txbPassword.Text = "";
                txbFullName.Text = "";
                txbEmail.Text = "";

                dgvListStaff.DataSource = bind;
            }
        }
    }
}
