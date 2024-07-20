namespace Quanlysinhvien_01.GUI
{
    partial class fSinhVien
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
            menuStrip1 = new MenuStrip();
            btnQuanLy = new ToolStripMenuItem();
            quảnLýKhoaToolStripMenuItem = new ToolStripMenuItem();
            quảnLýLớpToolStripMenuItem = new ToolStripMenuItem();
            quảnLýCốVấnHọcTậpToolStripMenuItem = new ToolStripMenuItem();
            quảnLýMônHọcToolStripMenuItem = new ToolStripMenuItem();
            quảnLýTàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            chứcNăngToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            đổiMậtKhẩuToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            thiCửToolStripMenuItem = new ToolStripMenuItem();
            quảnLýĐềThiToolStripMenuItem = new ToolStripMenuItem();
            quảnLýĐiểmToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            dgvSinhVien = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            panel3 = new Panel();
            cmbMaLop = new ComboBox();
            cmbMaCoVan = new ComboBox();
            cmbMaKhoa = new ComboBox();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            rdNu = new RadioButton();
            rdNam = new RadioButton();
            dtpkNhapHoc = new DateTimePicker();
            dtpkNgaySinh = new DateTimePicker();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            txbQueQuan = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txbTenSV = new TextBox();
            label4 = new Label();
            txbMaSV = new TextBox();
            label3 = new Label();
            txbID = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { btnQuanLy, chứcNăngToolStripMenuItem, thiCửToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1007, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // btnQuanLy
            // 
            btnQuanLy.DropDownItems.AddRange(new ToolStripItem[] { quảnLýKhoaToolStripMenuItem, quảnLýLớpToolStripMenuItem, quảnLýCốVấnHọcTậpToolStripMenuItem, quảnLýMônHọcToolStripMenuItem, quảnLýTàiKhoảnToolStripMenuItem });
            btnQuanLy.Name = "btnQuanLy";
            btnQuanLy.Size = new Size(73, 24);
            btnQuanLy.Text = "Quản lý";
            // 
            // quảnLýKhoaToolStripMenuItem
            // 
            quảnLýKhoaToolStripMenuItem.Name = "quảnLýKhoaToolStripMenuItem";
            quảnLýKhoaToolStripMenuItem.Size = new Size(243, 26);
            quảnLýKhoaToolStripMenuItem.Text = "Quản lý khoa";
            quảnLýKhoaToolStripMenuItem.Click += quảnLýKhoaToolStripMenuItem_Click;
            // 
            // quảnLýLớpToolStripMenuItem
            // 
            quảnLýLớpToolStripMenuItem.Name = "quảnLýLớpToolStripMenuItem";
            quảnLýLớpToolStripMenuItem.Size = new Size(243, 26);
            quảnLýLớpToolStripMenuItem.Text = "Quản lý lớp";
            quảnLýLớpToolStripMenuItem.Click += quảnLýLớpToolStripMenuItem_Click;
            // 
            // quảnLýCốVấnHọcTậpToolStripMenuItem
            // 
            quảnLýCốVấnHọcTậpToolStripMenuItem.Name = "quảnLýCốVấnHọcTậpToolStripMenuItem";
            quảnLýCốVấnHọcTậpToolStripMenuItem.Size = new Size(243, 26);
            quảnLýCốVấnHọcTậpToolStripMenuItem.Text = "Quản lý cố vấn học tập";
            quảnLýCốVấnHọcTậpToolStripMenuItem.Click += quảnLýCốVấnHọcTậpToolStripMenuItem_Click;
            // 
            // quảnLýMônHọcToolStripMenuItem
            // 
            quảnLýMônHọcToolStripMenuItem.Name = "quảnLýMônHọcToolStripMenuItem";
            quảnLýMônHọcToolStripMenuItem.Size = new Size(243, 26);
            quảnLýMônHọcToolStripMenuItem.Text = "Quản lý môn học";
            quảnLýMônHọcToolStripMenuItem.Click += quảnLýMônHọcToolStripMenuItem_Click;
            // 
            // quảnLýTàiKhoảnToolStripMenuItem
            // 
            quảnLýTàiKhoảnToolStripMenuItem.Name = "quảnLýTàiKhoảnToolStripMenuItem";
            quảnLýTàiKhoảnToolStripMenuItem.Size = new Size(243, 26);
            quảnLýTàiKhoảnToolStripMenuItem.Text = "Quản lý tài khoản";
            quảnLýTàiKhoảnToolStripMenuItem.Click += quảnLýTàiKhoảnToolStripMenuItem_Click;
            // 
            // chứcNăngToolStripMenuItem
            // 
            chứcNăngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thoátToolStripMenuItem, đổiMậtKhẩuToolStripMenuItem, đăngXuấtToolStripMenuItem });
            chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            chứcNăngToolStripMenuItem.Size = new Size(85, 24);
            chứcNăngToolStripMenuItem.Text = "Tài khoản";
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(204, 26);
            thoátToolStripMenuItem.Text = "Thông tin chi tiết";
            thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            đổiMậtKhẩuToolStripMenuItem.Size = new Size(204, 26);
            đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            đổiMậtKhẩuToolStripMenuItem.Click += đổiMậtKhẩuToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(204, 26);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // thiCửToolStripMenuItem
            // 
            thiCửToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quảnLýĐềThiToolStripMenuItem, quảnLýĐiểmToolStripMenuItem });
            thiCửToolStripMenuItem.Name = "thiCửToolStripMenuItem";
            thiCửToolStripMenuItem.Size = new Size(63, 24);
            thiCửToolStripMenuItem.Text = "Thi cử";
            // 
            // quảnLýĐềThiToolStripMenuItem
            // 
            quảnLýĐềThiToolStripMenuItem.Name = "quảnLýĐềThiToolStripMenuItem";
            quảnLýĐềThiToolStripMenuItem.Size = new Size(183, 26);
            quảnLýĐềThiToolStripMenuItem.Text = "Quản lý thi cử";
            quảnLýĐềThiToolStripMenuItem.Click += quảnLýĐềThiToolStripMenuItem_Click;
            // 
            // quảnLýĐiểmToolStripMenuItem
            // 
            quảnLýĐiểmToolStripMenuItem.Name = "quảnLýĐiểmToolStripMenuItem";
            quảnLýĐiểmToolStripMenuItem.Size = new Size(183, 26);
            quảnLýĐiểmToolStripMenuItem.Text = "Quản lý điểm";
            quảnLýĐiểmToolStripMenuItem.Click += quảnLýĐiểmToolStripMenuItem_Click_1;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvSinhVien);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 169);
            panel1.Name = "panel1";
            panel1.Size = new Size(1007, 459);
            panel1.TabIndex = 1;
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.AllowUserToAddRows = false;
            dgvSinhVien.AllowUserToDeleteRows = false;
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhVien.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10 });
            dgvSinhVien.Dock = DockStyle.Fill;
            dgvSinhVien.Location = new Point(0, 0);
            dgvSinhVien.MultiSelect = false;
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.ReadOnly = true;
            dgvSinhVien.RowHeadersVisible = false;
            dgvSinhVien.RowHeadersWidth = 51;
            dgvSinhVien.RowTemplate.Height = 30;
            dgvSinhVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSinhVien.Size = new Size(1007, 459);
            dgvSinhVien.TabIndex = 1;
            dgvSinhVien.TabStop = false;
            dgvSinhVien.CellClick += dgvSinhVien_CellClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column1.DataPropertyName = "Id";
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 65;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "MaSV";
            Column2.HeaderText = "MÃ SINH VIÊN";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 175;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "TenSV";
            Column3.HeaderText = "TÊN SINH VIÊN";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 180;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "NgaySinh";
            Column4.HeaderText = "NGÀY SINH";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 120;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "GioiTinh";
            Column5.HeaderText = "GIỚI TÍNH";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 120;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "QueQuan";
            Column6.HeaderText = "QUÊ QUÁN";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 120;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "NgayNhapHoc";
            Column7.HeaderText = "NHẬP HỌC";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 125;
            // 
            // Column8
            // 
            Column8.DataPropertyName = "MaLop";
            Column8.HeaderText = "MÃ LỚP";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 125;
            // 
            // Column9
            // 
            Column9.DataPropertyName = "MaKhoa";
            Column9.HeaderText = "MÃ KHOA";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            Column9.Width = 125;
            // 
            // Column10
            // 
            Column10.DataPropertyName = "MaCVHT";
            Column10.HeaderText = "MÃ CỐ VẤN";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            Column10.Width = 120;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 28);
            panel2.Name = "panel2";
            panel2.Size = new Size(1007, 137);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(cmbMaLop);
            panel3.Controls.Add(cmbMaCoVan);
            panel3.Controls.Add(cmbMaKhoa);
            panel3.Controls.Add(btnLamMoi);
            panel3.Controls.Add(btnXoa);
            panel3.Controls.Add(btnSua);
            panel3.Controls.Add(btnThem);
            panel3.Controls.Add(rdNu);
            panel3.Controls.Add(rdNam);
            panel3.Controls.Add(dtpkNhapHoc);
            panel3.Controls.Add(dtpkNgaySinh);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(txbQueQuan);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(txbTenSV);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txbMaSV);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(txbID);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1007, 137);
            panel3.TabIndex = 3;
            panel3.Paint += panel3_Paint;
            // 
            // cmbMaLop
            // 
            cmbMaLop.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMaLop.FormattingEnabled = true;
            cmbMaLop.Location = new Point(824, 51);
            cmbMaLop.Name = "cmbMaLop";
            cmbMaLop.Size = new Size(129, 30);
            cmbMaLop.TabIndex = 7;
            // 
            // cmbMaCoVan
            // 
            cmbMaCoVan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMaCoVan.FormattingEnabled = true;
            cmbMaCoVan.Location = new Point(342, 101);
            cmbMaCoVan.Name = "cmbMaCoVan";
            cmbMaCoVan.Size = new Size(159, 30);
            cmbMaCoVan.TabIndex = 9;
            // 
            // cmbMaKhoa
            // 
            cmbMaKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMaKhoa.FormattingEnabled = true;
            cmbMaKhoa.Location = new Point(93, 101);
            cmbMaKhoa.Name = "cmbMaKhoa";
            cmbMaKhoa.Size = new Size(141, 30);
            cmbMaKhoa.TabIndex = 8;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(771, 97);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(90, 38);
            btnLamMoi.TabIndex = 22;
            btnLamMoi.TabStop = false;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(693, 97);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(72, 38);
            btnXoa.TabIndex = 21;
            btnXoa.TabStop = false;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(615, 97);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(72, 38);
            btnSua.TabIndex = 20;
            btnSua.TabStop = false;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(537, 97);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(72, 38);
            btnThem.TabIndex = 19;
            btnThem.TabStop = false;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // rdNu
            // 
            rdNu.AutoSize = true;
            rdNu.Location = new Point(179, 53);
            rdNu.Name = "rdNu";
            rdNu.Size = new Size(56, 26);
            rdNu.TabIndex = 10;
            rdNu.Text = "Nữ";
            rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            rdNam.AutoSize = true;
            rdNam.Checked = true;
            rdNam.Location = new Point(105, 53);
            rdNam.Name = "rdNam";
            rdNam.Size = new Size(68, 26);
            rdNam.TabIndex = 4;
            rdNam.TabStop = true;
            rdNam.Text = "Nam";
            rdNam.UseVisualStyleBackColor = true;
            // 
            // dtpkNhapHoc
            // 
            dtpkNhapHoc.Format = DateTimePickerFormat.Short;
            dtpkNhapHoc.Location = new Point(604, 51);
            dtpkNhapHoc.Name = "dtpkNhapHoc";
            dtpkNhapHoc.Size = new Size(139, 30);
            dtpkNhapHoc.TabIndex = 6;
            // 
            // dtpkNgaySinh
            // 
            dtpkNgaySinh.Format = DateTimePickerFormat.Short;
            dtpkNgaySinh.Location = new Point(815, 5);
            dtpkNgaySinh.Name = "dtpkNgaySinh";
            dtpkNgaySinh.Size = new Size(139, 30);
            dtpkNgaySinh.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(240, 105);
            label11.Name = "label11";
            label11.Size = new Size(99, 22);
            label11.TabIndex = 18;
            label11.Text = "Mã cố vấn:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 105);
            label10.Name = "label10";
            label10.Size = new Size(84, 22);
            label10.TabIndex = 16;
            label10.Text = "Mã khoa:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(749, 55);
            label9.Name = "label9";
            label9.Size = new Size(74, 22);
            label9.TabIndex = 14;
            label9.Text = "Mã lớp:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(507, 55);
            label8.Name = "label8";
            label8.Size = new Size(91, 22);
            label8.TabIndex = 12;
            label8.Text = "Nhập học:";
            label8.Click += label8_Click;
            // 
            // txbQueQuan
            // 
            txbQueQuan.Location = new Point(342, 51);
            txbQueQuan.MaxLength = 255;
            txbQueQuan.Name = "txbQueQuan";
            txbQueQuan.Size = new Size(159, 30);
            txbQueQuan.TabIndex = 5;
            txbQueQuan.TextChanged += textBox7_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(246, 55);
            label7.Name = "label7";
            label7.Size = new Size(90, 22);
            label7.TabIndex = 10;
            label7.Text = "Quê quán:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 55);
            label6.Name = "label6";
            label6.Size = new Size(87, 22);
            label6.TabIndex = 8;
            label6.Text = "Giới tính:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(714, 8);
            label5.Name = "label5";
            label5.Size = new Size(94, 22);
            label5.TabIndex = 6;
            label5.Text = "Ngày sinh:";
            // 
            // txbTenSV
            // 
            txbTenSV.Location = new Point(424, 4);
            txbTenSV.MaxLength = 255;
            txbTenSV.Name = "txbTenSV";
            txbTenSV.Size = new Size(284, 30);
            txbTenSV.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(344, 8);
            label4.Name = "label4";
            label4.Size = new Size(74, 22);
            label4.TabIndex = 4;
            label4.Text = "Tên SV:";
            // 
            // txbMaSV
            // 
            txbMaSV.Location = new Point(210, 4);
            txbMaSV.MaxLength = 255;
            txbMaSV.Name = "txbMaSV";
            txbMaSV.Size = new Size(125, 30);
            txbMaSV.TabIndex = 1;
            txbMaSV.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(134, 8);
            label3.Name = "label3";
            label3.Size = new Size(70, 22);
            label3.TabIndex = 2;
            label3.Text = "Mã SV:";
            // 
            // txbID
            // 
            txbID.Enabled = false;
            txbID.Location = new Point(53, 4);
            txbID.Name = "txbID";
            txbID.Size = new Size(53, 30);
            txbID.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 8);
            label2.Name = "label2";
            label2.Size = new Size(36, 22);
            label2.TabIndex = 0;
            label2.Text = "ID:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(53, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 30);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 9);
            label1.Name = "label1";
            label1.Size = new Size(36, 22);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // fSinhVien
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 628);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "fSinhVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý sinh viên";
            Load += fSinhVien_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem btnQuanLy;
        private ToolStripMenuItem chứcNăngToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem quảnLýKhoaToolStripMenuItem;
        private ToolStripMenuItem quảnLýLớpToolStripMenuItem;
        private ToolStripMenuItem quảnLýCốVấnHọcTậpToolStripMenuItem;
        private ToolStripMenuItem quảnLýMônHọcToolStripMenuItem;
        private Panel panel1;
        private Panel panel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView dgvSinhVien;
        private Panel panel3;
        private Label label5;
        private TextBox txbTenSV;
        private Label label4;
        private TextBox txbMaSV;
        private Label label3;
        private TextBox txbID;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Label label8;
        private TextBox txbQueQuan;
        private Label label7;
        private Label label11;
        private Label label10;
        private Label label9;
        private DateTimePicker dtpkNgaySinh;
        private DateTimePicker dtpkNhapHoc;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private ToolStripMenuItem quảnLýTàiKhoảnToolStripMenuItem;
        private RadioButton rdNu;
        private RadioButton rdNam;
        private Label label6;
        private ComboBox cmbMaLop;
        private ComboBox cmbMaCoVan;
        private ComboBox cmbMaKhoa;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private ToolStripMenuItem thiCửToolStripMenuItem;
        private ToolStripMenuItem quảnLýĐềThiToolStripMenuItem;
        private ToolStripMenuItem quảnLýĐiểmToolStripMenuItem;
    }
}