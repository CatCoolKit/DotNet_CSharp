using repository.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AirConditionerShop_BuiManhCuong
{
    public partial class Login : Form
    {
        private StaffMemberRepository _staffMemberRepository;
        public Login()
        {
            InitializeComponent();
            _staffMemberRepository = new StaffMemberRepository();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.ToString().Trim();
            string password = txtPassword.Text.ToString().Trim();

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Email and password fields cannot be empty.");
                return;
            }

            var staffMember = _staffMemberRepository.Login(email, password);

            if (staffMember != null)
            {
                if (staffMember.Role == 3)
                {
                    MessageBox.Show("You have no permission to access this function!");
                }
                else {
                    txtPassword.Clear();
                    MessageBox.Show("Login successful!");
                    AirConditionerManagement f = new AirConditionerManagement(staffMember);
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Invalid email or password.");
            }
        }
    }
}
