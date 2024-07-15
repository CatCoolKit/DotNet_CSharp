namespace Quanlysinhvien_01.GUI
{
    partial class fThongTinChiTiet
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
            txbLoaiTaiKhoan = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 25);
            label1.Name = "label1";
            label1.Size = new Size(130, 22);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập:";
            // 
            // txbTenDangNhap
            // 
            txbTenDangNhap.Enabled = false;
            txbTenDangNhap.Location = new Point(27, 50);
            txbTenDangNhap.MaxLength = 255;
            txbTenDangNhap.Name = "txbTenDangNhap";
            txbTenDangNhap.Size = new Size(285, 30);
            txbTenDangNhap.TabIndex = 0;
            // 
            // txbMatKhau
            // 
            txbMatKhau.Enabled = false;
            txbMatKhau.Location = new Point(27, 119);
            txbMatKhau.MaxLength = 255;
            txbMatKhau.Name = "txbMatKhau";
            txbMatKhau.Size = new Size(285, 30);
            txbMatKhau.TabIndex = 1;
            txbMatKhau.Text = "***********";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 94);
            label2.Name = "label2";
            label2.Size = new Size(88, 22);
            label2.TabIndex = 2;
            label2.Text = "Mật khẩu:";
            // 
            // txbLoaiTaiKhoan
            // 
            txbLoaiTaiKhoan.Enabled = false;
            txbLoaiTaiKhoan.Location = new Point(27, 186);
            txbLoaiTaiKhoan.MaxLength = 255;
            txbLoaiTaiKhoan.Name = "txbLoaiTaiKhoan";
            txbLoaiTaiKhoan.Size = new Size(285, 30);
            txbLoaiTaiKhoan.TabIndex = 2;
            txbLoaiTaiKhoan.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 161);
            label3.Name = "label3";
            label3.Size = new Size(128, 22);
            label3.TabIndex = 4;
            label3.Text = "Loại tài khoản:";
            // 
            // fThongTinChiTiet
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 386);
            Controls.Add(txbLoaiTaiKhoan);
            Controls.Add(label3);
            Controls.Add(txbMatKhau);
            Controls.Add(label2);
            Controls.Add(txbTenDangNhap);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "fThongTinChiTiet";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thông tin chi tiết";
            Load += fThongTinChiTiet_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txbTenDangNhap;
        private TextBox txbMatKhau;
        private Label label2;
        private TextBox txbLoaiTaiKhoan;
        private Label label3;
    }
}