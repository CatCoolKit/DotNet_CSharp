namespace Quanlysinhvien_01.GUI
{
    partial class fQuanLyLop
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
            btnLamMoi = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            label3 = new Label();
            panel2 = new Panel();
            dgvLop = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            txbMaLop = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            txbTenLop = new TextBox();
            cmbMaKhoa = new ComboBox();
            numSoLuong = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            txbID = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLop).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            SuspendLayout();
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(368, 120);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(96, 36);
            btnLamMoi.TabIndex = 9;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(266, 120);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(96, 36);
            btnSua.TabIndex = 8;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(178, 120);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(82, 36);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(90, 120);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(82, 36);
            btnThem.TabIndex = 6;
            btnThem.TabStop = false;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 82);
            label3.Name = "label3";
            label3.Size = new Size(78, 22);
            label3.TabIndex = 4;
            label3.Text = "Tên lớp:";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvLop);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 162);
            panel2.Name = "panel2";
            panel2.Size = new Size(532, 407);
            panel2.TabIndex = 5;
            // 
            // dgvLop
            // 
            dgvLop.AllowUserToAddRows = false;
            dgvLop.AllowUserToDeleteRows = false;
            dgvLop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLop.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgvLop.Dock = DockStyle.Fill;
            dgvLop.Location = new Point(0, 0);
            dgvLop.MultiSelect = false;
            dgvLop.Name = "dgvLop";
            dgvLop.ReadOnly = true;
            dgvLop.RowHeadersVisible = false;
            dgvLop.RowHeadersWidth = 51;
            dgvLop.RowTemplate.Height = 30;
            dgvLop.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLop.Size = new Size(532, 407);
            dgvLop.TabIndex = 2;
            dgvLop.TabStop = false;
            dgvLop.CellClick += dgvLop_CellClick;
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
            Column2.DataPropertyName = "MaLop";
            Column2.HeaderText = "MÃ LỚP";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 145;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "TenLop";
            Column3.HeaderText = "TÊN LỚP";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 145;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "SoLuong";
            Column4.HeaderText = "SỐ LƯỢNG";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "MaKhoa";
            Column5.HeaderText = "MÃ KHOA";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 125;
            // 
            // txbMaLop
            // 
            txbMaLop.Location = new Point(90, 41);
            txbMaLop.MaxLength = 255;
            txbMaLop.Name = "txbMaLop";
            txbMaLop.Size = new Size(176, 30);
            txbMaLop.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 46);
            label2.Name = "label2";
            label2.Size = new Size(74, 22);
            label2.TabIndex = 2;
            label2.Text = "Mã lớp:";
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
            // panel1
            // 
            panel1.Controls.Add(txbTenLop);
            panel1.Controls.Add(cmbMaKhoa);
            panel1.Controls.Add(numSoLuong);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnLamMoi);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txbMaLop);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txbID);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(532, 162);
            panel1.TabIndex = 4;
            // 
            // txbTenLop
            // 
            txbTenLop.Location = new Point(90, 77);
            txbTenLop.MaxLength = 255;
            txbTenLop.Name = "txbTenLop";
            txbTenLop.Size = new Size(176, 30);
            txbTenLop.TabIndex = 2;
            // 
            // cmbMaKhoa
            // 
            cmbMaKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMaKhoa.FormattingEnabled = true;
            cmbMaKhoa.Location = new Point(367, 79);
            cmbMaKhoa.Name = "cmbMaKhoa";
            cmbMaKhoa.Size = new Size(151, 30);
            cmbMaKhoa.TabIndex = 4;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(368, 41);
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(150, 30);
            numSoLuong.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(278, 81);
            label4.Name = "label4";
            label4.Size = new Size(84, 22);
            label4.TabIndex = 13;
            label4.Text = "Mã khoa:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(278, 45);
            label5.Name = "label5";
            label5.Size = new Size(88, 22);
            label5.TabIndex = 12;
            label5.Text = "Số lượng:";
            // 
            // txbID
            // 
            txbID.Enabled = false;
            txbID.Location = new Point(54, 6);
            txbID.Name = "txbID";
            txbID.Size = new Size(65, 30);
            txbID.TabIndex = 0;
            // 
            // fQuanLyLop
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 569);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "fQuanLyLop";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý lớp";
            Load += fQuanLyLop_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLop).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLamMoi;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private TextBox txbTenKhoa;
        private Label label3;
        private Panel panel2;
        private DataGridView dgvLop;
        private TextBox txbMaLop;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private TextBox txbID;
        private NumericUpDown numSoLuong;
        private Label label4;
        private Label label5;
        private ComboBox cmbMaKhoa;
        private TextBox txbTenLop;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}