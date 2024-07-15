namespace Quanlysinhvien_01.GUI
{
    partial class fCoVanHocTap
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
            txbTenCoVan = new TextBox();
            cmbMaKhoa = new ComboBox();
            label4 = new Label();
            txbID = new TextBox();
            panel1 = new Panel();
            rdNu = new RadioButton();
            rdNam = new RadioButton();
            label7 = new Label();
            cmbMaLop = new ComboBox();
            label6 = new Label();
            dtpkNgaySinh = new DateTimePicker();
            label5 = new Label();
            btnLamMoi = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            label3 = new Label();
            txbMaCoVan = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dgvCoVanHocTap = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCoVanHocTap).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txbTenCoVan
            // 
            txbTenCoVan.Location = new Point(117, 76);
            txbTenCoVan.MaxLength = 255;
            txbTenCoVan.Name = "txbTenCoVan";
            txbTenCoVan.Size = new Size(176, 30);
            txbTenCoVan.TabIndex = 2;
            // 
            // cmbMaKhoa
            // 
            cmbMaKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMaKhoa.FormattingEnabled = true;
            cmbMaKhoa.Location = new Point(396, 40);
            cmbMaKhoa.Name = "cmbMaKhoa";
            cmbMaKhoa.Size = new Size(139, 30);
            cmbMaKhoa.TabIndex = 7;
            cmbMaKhoa.SelectedIndexChanged += cmbMaKhoa_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(306, 44);
            label4.Name = "label4";
            label4.Size = new Size(84, 22);
            label4.TabIndex = 13;
            label4.Text = "Mã khoa:";
            // 
            // txbID
            // 
            txbID.Enabled = false;
            txbID.Location = new Point(54, 6);
            txbID.Name = "txbID";
            txbID.Size = new Size(65, 30);
            txbID.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(rdNu);
            panel1.Controls.Add(rdNam);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(cmbMaLop);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(dtpkNgaySinh);
            panel1.Controls.Add(txbTenCoVan);
            panel1.Controls.Add(cmbMaKhoa);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnLamMoi);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txbMaCoVan);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txbID);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(899, 162);
            panel1.TabIndex = 6;
            // 
            // rdNu
            // 
            rdNu.AutoSize = true;
            rdNu.Location = new Point(473, 119);
            rdNu.Name = "rdNu";
            rdNu.Size = new Size(56, 26);
            rdNu.TabIndex = 5;
            rdNu.Text = "Nữ";
            rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            rdNam.AutoSize = true;
            rdNam.Checked = true;
            rdNam.Location = new Point(399, 119);
            rdNam.Name = "rdNam";
            rdNam.Size = new Size(68, 26);
            rdNam.TabIndex = 4;
            rdNam.TabStop = true;
            rdNam.Text = "Nam";
            rdNam.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(306, 121);
            label7.Name = "label7";
            label7.Size = new Size(87, 22);
            label7.TabIndex = 19;
            label7.Text = "Giới tính:";
            // 
            // cmbMaLop
            // 
            cmbMaLop.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMaLop.FormattingEnabled = true;
            cmbMaLop.Location = new Point(396, 76);
            cmbMaLop.Name = "cmbMaLop";
            cmbMaLop.Size = new Size(139, 30);
            cmbMaLop.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(306, 80);
            label6.Name = "label6";
            label6.Size = new Size(74, 22);
            label6.TabIndex = 16;
            label6.Text = "Mã lớp:";
            label6.Click += label6_Click;
            // 
            // dtpkNgaySinh
            // 
            dtpkNgaySinh.Format = DateTimePickerFormat.Short;
            dtpkNgaySinh.Location = new Point(117, 115);
            dtpkNgaySinh.Name = "dtpkNgaySinh";
            dtpkNgaySinh.Size = new Size(139, 30);
            dtpkNgaySinh.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 121);
            label5.Name = "label5";
            label5.Size = new Size(94, 22);
            label5.TabIndex = 12;
            label5.Text = "Ngày sinh:";
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(779, 116);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(96, 36);
            btnLamMoi.TabIndex = 9;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(677, 116);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(96, 36);
            btnSua.TabIndex = 8;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(779, 66);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(96, 36);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(677, 66);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(96, 36);
            btnThem.TabIndex = 6;
            btnThem.TabStop = false;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 80);
            label3.Name = "label3";
            label3.Size = new Size(103, 22);
            label3.TabIndex = 4;
            label3.Text = "Tên cố vấn:";
            // 
            // txbMaCoVan
            // 
            txbMaCoVan.Location = new Point(117, 40);
            txbMaCoVan.MaxLength = 255;
            txbMaCoVan.Name = "txbMaCoVan";
            txbMaCoVan.Size = new Size(176, 30);
            txbMaCoVan.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(99, 22);
            label2.TabIndex = 2;
            label2.Text = "Mã cố vấn:";
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
            // dgvCoVanHocTap
            // 
            dgvCoVanHocTap.AllowUserToAddRows = false;
            dgvCoVanHocTap.AllowUserToDeleteRows = false;
            dgvCoVanHocTap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCoVanHocTap.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column7, Column6 });
            dgvCoVanHocTap.Dock = DockStyle.Fill;
            dgvCoVanHocTap.Location = new Point(0, 0);
            dgvCoVanHocTap.MultiSelect = false;
            dgvCoVanHocTap.Name = "dgvCoVanHocTap";
            dgvCoVanHocTap.ReadOnly = true;
            dgvCoVanHocTap.RowHeadersVisible = false;
            dgvCoVanHocTap.RowHeadersWidth = 51;
            dgvCoVanHocTap.RowTemplate.Height = 30;
            dgvCoVanHocTap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCoVanHocTap.Size = new Size(899, 474);
            dgvCoVanHocTap.TabIndex = 2;
            dgvCoVanHocTap.TabStop = false;
            dgvCoVanHocTap.CellClick += dgvCoVanHocTap_CellClick;
            dgvCoVanHocTap.CellContentClick += dgvLop_CellContentClick;
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
            Column2.DataPropertyName = "MaCVHT";
            Column2.HeaderText = "MÃ CỐ VẤN";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 165;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "TenCVHT";
            Column3.HeaderText = "TÊN CỐ VẤN";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 165;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "NgaySinh";
            Column4.HeaderText = "NGÀY SINH";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "GioiTinh";
            Column5.HeaderText = "GIỚI TÍNH";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 125;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "MaKhoa";
            Column7.HeaderText = "MÃ KHOA";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 125;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "MaLop";
            Column6.HeaderText = "MÃ LỚP";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 125;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvCoVanHocTap);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 168);
            panel2.Name = "panel2";
            panel2.Size = new Size(899, 474);
            panel2.TabIndex = 7;
            // 
            // fCoVanHocTap
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 642);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "fCoVanHocTap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý cố vấn học tập";
            Load += fCoVanHocTap_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCoVanHocTap).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox txbTenCoVan;
        private ComboBox cmbMaKhoa;
        private Label label4;
        private TextBox txbID;
        private Panel panel1;
        private Label label5;
        private Button btnLamMoi;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private Label label3;
        private TextBox txbMaCoVan;
        private Label label2;
        private Label label1;
        private DataGridView dgvCoVanHocTap;
        private Panel panel2;
        private DateTimePicker dtpkNgaySinh;
        private ComboBox cmbMaLop;
        private Label label6;
        private RadioButton rdNu;
        private RadioButton rdNam;
        private Label label7;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column6;
    }
}