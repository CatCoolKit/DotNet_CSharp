namespace Quanlysinhvien_01.GUI
{
    partial class fQuanLyTaiKhoan
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
            panel1 = new Panel();
            lbMaCVHT = new Label();
            cmbMaCVHT = new ComboBox();
            cmbLoaiTaiKhoan = new ComboBox();
            label4 = new Label();
            btnLamMoi = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            txbMatKhau = new TextBox();
            label3 = new Label();
            txbTenDangNhap = new TextBox();
            label2 = new Label();
            txbID = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            dgvTaiKhoan = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lbMaCVHT);
            panel1.Controls.Add(cmbMaCVHT);
            panel1.Controls.Add(cmbLoaiTaiKhoan);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnLamMoi);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(txbMatKhau);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txbTenDangNhap);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txbID);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(744, 162);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // lbMaCVHT
            // 
            lbMaCVHT.AutoSize = true;
            lbMaCVHT.Location = new Point(12, 121);
            lbMaCVHT.Name = "lbMaCVHT";
            lbMaCVHT.Size = new Size(93, 22);
            lbMaCVHT.TabIndex = 12;
            lbMaCVHT.Text = "MaCVHT:";
            lbMaCVHT.Click += label5_Click;
            // 
            // cmbMaCVHT
            // 
            cmbMaCVHT.FormattingEnabled = true;
            cmbMaCVHT.Location = new Point(142, 118);
            cmbMaCVHT.Name = "cmbMaCVHT";
            cmbMaCVHT.Size = new Size(175, 30);
            cmbMaCVHT.TabIndex = 11;
            // 
            // cmbLoaiTaiKhoan
            // 
            cmbLoaiTaiKhoan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLoaiTaiKhoan.FormattingEnabled = true;
            cmbLoaiTaiKhoan.Items.AddRange(new object[] { "Sinh Viên", "Cố vấn học tập", "Quản trị" });
            cmbLoaiTaiKhoan.Location = new Point(212, 6);
            cmbLoaiTaiKhoan.Name = "cmbLoaiTaiKhoan";
            cmbLoaiTaiKhoan.Size = new Size(120, 30);
            cmbLoaiTaiKhoan.TabIndex = 3;
            cmbLoaiTaiKhoan.SelectedIndexChanged += cmbLoaiTaiKhoan_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(154, 9);
            label4.Name = "label4";
            label4.Size = new Size(52, 22);
            label4.TabIndex = 10;
            label4.Text = "Loại:";
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(609, 91);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(96, 36);
            btnLamMoi.TabIndex = 9;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(497, 91);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(96, 36);
            btnSua.TabIndex = 8;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(609, 39);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(96, 36);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(497, 39);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(96, 36);
            btnThem.TabIndex = 6;
            btnThem.TabStop = false;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txbMatKhau
            // 
            txbMatKhau.Location = new Point(142, 78);
            txbMatKhau.MaxLength = 255;
            txbMatKhau.Name = "txbMatKhau";
            txbMatKhau.Size = new Size(175, 30);
            txbMatKhau.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 82);
            label3.Name = "label3";
            label3.Size = new Size(88, 22);
            label3.TabIndex = 4;
            label3.Text = "Mật khẩu:";
            // 
            // txbTenDangNhap
            // 
            txbTenDangNhap.Location = new Point(142, 42);
            txbTenDangNhap.MaxLength = 255;
            txbTenDangNhap.Name = "txbTenDangNhap";
            txbTenDangNhap.Size = new Size(176, 30);
            txbTenDangNhap.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 46);
            label2.Name = "label2";
            label2.Size = new Size(130, 22);
            label2.TabIndex = 2;
            label2.Text = "Tên đăng nhập:";
            label2.Click += label2_Click;
            // 
            // txbID
            // 
            txbID.Enabled = false;
            txbID.Location = new Point(54, 6);
            txbID.Name = "txbID";
            txbID.Size = new Size(65, 30);
            txbID.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(36, 22);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvTaiKhoan);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 162);
            panel2.Name = "panel2";
            panel2.Size = new Size(744, 473);
            panel2.TabIndex = 1;
            // 
            // dgvTaiKhoan
            // 
            dgvTaiKhoan.AllowUserToAddRows = false;
            dgvTaiKhoan.AllowUserToDeleteRows = false;
            dgvTaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTaiKhoan.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgvTaiKhoan.Dock = DockStyle.Fill;
            dgvTaiKhoan.Location = new Point(0, 0);
            dgvTaiKhoan.MultiSelect = false;
            dgvTaiKhoan.Name = "dgvTaiKhoan";
            dgvTaiKhoan.ReadOnly = true;
            dgvTaiKhoan.RowHeadersVisible = false;
            dgvTaiKhoan.RowHeadersWidth = 51;
            dgvTaiKhoan.RowTemplate.Height = 30;
            dgvTaiKhoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTaiKhoan.Size = new Size(744, 473);
            dgvTaiKhoan.TabIndex = 2;
            dgvTaiKhoan.TabStop = false;
            dgvTaiKhoan.CellClick += dgvTaiKhoan_CellClick;
            dgvTaiKhoan.CellContentClick += dgvTaiKhoan_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column1.DataPropertyName = "id";
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 55;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "TenDangNhap";
            Column2.HeaderText = "TÊN ĐĂNG NHẬP";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "MatKhau";
            Column3.HeaderText = "MẬT KHẨU";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 160;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "LoaiTaiKhoan";
            Column4.HeaderText = "LOẠI TÀI KHOẢN";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 200;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "MaCVHT";
            Column5.HeaderText = "MaCVHT";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 125;
            // 
            // fQuanLyTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 635);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "fQuanLyTaiKhoan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý tài khoản";
            Load += fQuanLyTaiKhoan_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvTaiKhoan;
        private TextBox txbMatKhau;
        private Label label3;
        private TextBox txbTenDangNhap;
        private Label label2;
        private TextBox txbID;
        private Label label1;
        private Button btnThem;
        private Button btnLamMoi;
        private Button btnSua;
        private Button btnXoa;
        private ComboBox cmbLoaiTaiKhoan;
        private Label label4;
        private Label lbMaCVHT;
        private ComboBox cmbMaCVHT;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}