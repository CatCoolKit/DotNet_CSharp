namespace Quanlysinhvien_01.GUI
{
    partial class fDangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txbTenDangNhap = new TextBox();
            txbMatKhau = new TextBox();
            label2 = new Label();
            btnDangNhap = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 20);
            label1.Name = "label1";
            label1.Size = new Size(139, 22);
            label1.TabIndex = 0;
            label1.Text = "Tên Đăng Nhập:";
            // 
            // txbTenDangNhap
            // 
            txbTenDangNhap.Location = new Point(26, 45);
            txbTenDangNhap.MaxLength = 255;
            txbTenDangNhap.Name = "txbTenDangNhap";
            txbTenDangNhap.Size = new Size(331, 30);
            txbTenDangNhap.TabIndex = 0;
            txbTenDangNhap.Text = "admin";
            // 
            // txbMatKhau
            // 
            txbMatKhau.Location = new Point(26, 120);
            txbMatKhau.MaxLength = 255;
            txbMatKhau.Name = "txbMatKhau";
            txbMatKhau.Size = new Size(331, 30);
            txbMatKhau.TabIndex = 1;
            txbMatKhau.Text = "123456";
            txbMatKhau.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 95);
            label2.Name = "label2";
            label2.Size = new Size(93, 22);
            label2.TabIndex = 2;
            label2.Text = "Mật Khẩu:";
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(129, 188);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(108, 33);
            btnDangNhap.TabIndex = 2;
            btnDangNhap.TabStop = false;
            btnDangNhap.Text = "Đăng Nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // fDangNhap
            // 
            AcceptButton = btnDangNhap;
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 411);
            Controls.Add(btnDangNhap);
            Controls.Add(txbMatKhau);
            Controls.Add(label2);
            Controls.Add(txbTenDangNhap);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "fDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DangNhap";
            Load += fDangNhap_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txbTenDangNhap;
        private TextBox txbMatKhau;
        private Label label2;
        private Button btnDangNhap;
    }
}