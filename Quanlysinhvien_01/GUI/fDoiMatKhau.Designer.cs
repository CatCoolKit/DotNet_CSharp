namespace Quanlysinhvien_01.GUI
{
    partial class fDoiMatKhau
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
            txbMKMoi = new TextBox();
            label3 = new Label();
            txbMKCu = new TextBox();
            label2 = new Label();
            txbTenDangNhap = new TextBox();
            label1 = new Label();
            txbXNMKMoi = new TextBox();
            label4 = new Label();
            btnCapNhat = new Button();
            SuspendLayout();
            // 
            // txbMKMoi
            // 
            txbMKMoi.Location = new Point(24, 181);
            txbMKMoi.MaxLength = 255;
            txbMKMoi.Name = "txbMKMoi";
            txbMKMoi.Size = new Size(285, 30);
            txbMKMoi.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 156);
            label3.Name = "label3";
            label3.Size = new Size(124, 22);
            label3.TabIndex = 10;
            label3.Text = "Mật khẩu mới:";
            // 
            // txbMKCu
            // 
            txbMKCu.Location = new Point(24, 114);
            txbMKCu.MaxLength = 255;
            txbMKCu.Name = "txbMKCu";
            txbMKCu.Size = new Size(285, 30);
            txbMKCu.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 89);
            label2.Name = "label2";
            label2.Size = new Size(111, 22);
            label2.TabIndex = 9;
            label2.Text = "Mật khẩu cũ:";
            // 
            // txbTenDangNhap
            // 
            txbTenDangNhap.Location = new Point(24, 45);
            txbTenDangNhap.MaxLength = 255;
            txbTenDangNhap.Name = "txbTenDangNhap";
            txbTenDangNhap.Size = new Size(285, 30);
            txbTenDangNhap.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 20);
            label1.Name = "label1";
            label1.Size = new Size(130, 22);
            label1.TabIndex = 6;
            label1.Text = "Tên đăng nhập:";
            // 
            // txbXNMKMoi
            // 
            txbXNMKMoi.Location = new Point(24, 254);
            txbXNMKMoi.MaxLength = 255;
            txbXNMKMoi.Name = "txbXNMKMoi";
            txbXNMKMoi.Size = new Size(285, 30);
            txbXNMKMoi.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 229);
            label4.Name = "label4";
            label4.Size = new Size(199, 22);
            label4.TabIndex = 12;
            label4.Text = "Xác nhận mật khẩu mới:";
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(152, 323);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(104, 47);
            btnCapNhat.TabIndex = 4;
            btnCapNhat.TabStop = false;
            btnCapNhat.Text = "Xác Nhận";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // fDoiMatKhau
            // 
            AcceptButton = btnCapNhat;
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 461);
            Controls.Add(btnCapNhat);
            Controls.Add(txbXNMKMoi);
            Controls.Add(label4);
            Controls.Add(txbMKMoi);
            Controls.Add(label3);
            Controls.Add(txbMKCu);
            Controls.Add(label2);
            Controls.Add(txbTenDangNhap);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "fDoiMatKhau";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Đổi mật khẩu";
            Load += fDoiMatKhau_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbMKMoi;
        private Label label3;
        private TextBox txbMKCu;
        private Label label2;
        private TextBox txbTenDangNhap;
        private Label label1;
        private TextBox txbXNMKMoi;
        private Label label4;
        private Button btnCapNhat;
    }
}