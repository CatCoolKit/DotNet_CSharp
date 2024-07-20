using Repository;
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
    public partial class Login : Form
    {
        private StaffMemberRepository _staffMemberRepository;
        public Login()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            _staffMemberRepository = new StaffMemberRepository();
            label1 = new Label();
            label2 = new Label();
            txbEmail = new TextBox();
            txbPassword = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 66);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 125);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(109, 63);
            txbEmail.MaxLength = 255;
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(261, 27);
            txbEmail.TabIndex = 0;
            // 
            // txbPassword
            // 
            txbPassword.Location = new Point(109, 122);
            txbPassword.MaxLength = 255;
            txbPassword.Name = "txbPassword";
            txbPassword.Size = new Size(261, 27);
            txbPassword.TabIndex = 1;
            txbPassword.UseSystemPasswordChar = true;
            txbPassword.TextChanged += txbPassword_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(149, 221);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(95, 41);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // Login
            // 
            ClientSize = new Size(398, 412);
            Controls.Add(btnLogin);
            Controls.Add(txbPassword);
            Controls.Add(txbEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private TextBox txbEmail;
        private TextBox txbPassword;
        private Button btnLogin;

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txbEmail.Text.ToString().Trim();
            string password = txbPassword.Text.ToString().Trim();

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Email and password fields cannot be empty.");
                return;
            }

            var staffMember = _staffMemberRepository.Login(email, password);

            if (staffMember != null)
            {
                txbPassword.Clear();
                MessageBox.Show("Login successful!");
                Form3 f = new Form3(staffMember);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Invalid email or password.");
            }
        }

        private void txbPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
