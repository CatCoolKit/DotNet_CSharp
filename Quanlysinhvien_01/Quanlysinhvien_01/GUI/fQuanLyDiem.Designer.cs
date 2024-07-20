namespace Quanlysinhvien_01.GUI
{
    partial class fQuanLyDiem
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
            numPTThi = new NumericUpDown();
            numPTTrenLop = new NumericUpDown();
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnLamMoi = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            label3 = new Label();
            label2 = new Label();
            txbID = new TextBox();
            label1 = new Label();
            dgvDiem = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            panel1 = new Panel();
            txbNamHoc = new TextBox();
            label10 = new Label();
            cmbMaMH = new ComboBox();
            cmbMaSV = new ComboBox();
            txbDiemTB = new TextBox();
            label9 = new Label();
            txbDiemThi = new TextBox();
            label8 = new Label();
            txbDiemTrenLop = new TextBox();
            label7 = new Label();
            cmbLoai = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numPTThi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPTTrenLop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDiem).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // numPTThi
            // 
            numPTThi.Location = new Point(299, 57);
            numPTThi.Margin = new Padding(6, 3, 6, 3);
            numPTThi.Name = "numPTThi";
            numPTThi.Size = new Size(64, 30);
            numPTThi.TabIndex = 4;
            // 
            // numPTTrenLop
            // 
            numPTTrenLop.Location = new Point(139, 57);
            numPTTrenLop.Margin = new Padding(6, 3, 6, 3);
            numPTTrenLop.Name = "numPTTrenLop";
            numPTTrenLop.Size = new Size(64, 30);
            numPTTrenLop.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(221, 61);
            label6.Name = "label6";
            label6.Size = new Size(79, 22);
            label6.TabIndex = 16;
            label6.Text = "Thi (%):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 61);
            label4.Name = "label4";
            label4.Size = new Size(120, 22);
            label4.TabIndex = 13;
            label4.Text = "Trên lớp (%):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(396, 61);
            label5.Name = "label5";
            label5.Size = new Size(52, 22);
            label5.TabIndex = 12;
            label5.Text = "Loại:";
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(991, 107);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(96, 36);
            btnLamMoi.TabIndex = 9;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(889, 107);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(96, 36);
            btnSua.TabIndex = 8;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(991, 57);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(96, 36);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(889, 57);
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
            label3.Location = new Point(428, 16);
            label3.Name = "label3";
            label3.Size = new Size(113, 22);
            label3.TabIndex = 4;
            label3.Text = "Mã môn học:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(131, 16);
            label2.Name = "label2";
            label2.Size = new Size(118, 22);
            label2.TabIndex = 2;
            label2.Text = "Mã sinh viên:";
            // 
            // txbID
            // 
            txbID.Enabled = false;
            txbID.Location = new Point(53, 12);
            txbID.Name = "txbID";
            txbID.Size = new Size(65, 30);
            txbID.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 16);
            label1.Name = "label1";
            label1.Size = new Size(36, 22);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // dgvDiem
            // 
            dgvDiem.AllowUserToAddRows = false;
            dgvDiem.AllowUserToDeleteRows = false;
            dgvDiem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDiem.Columns.AddRange(new DataGridViewColumn[] { Column1, Column5, Column2, Column8, Column4, Column6, Column7, Column9, Column10, Column3 });
            dgvDiem.Dock = DockStyle.Fill;
            dgvDiem.Location = new Point(0, 0);
            dgvDiem.MultiSelect = false;
            dgvDiem.Name = "dgvDiem";
            dgvDiem.ReadOnly = true;
            dgvDiem.RowHeadersVisible = false;
            dgvDiem.RowHeadersWidth = 51;
            dgvDiem.RowTemplate.Height = 30;
            dgvDiem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDiem.Size = new Size(1109, 475);
            dgvDiem.TabIndex = 2;
            dgvDiem.TabStop = false;
            dgvDiem.CellClick += dgvDiem_CellClick;
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
            // Column5
            // 
            Column5.DataPropertyName = "MaSV";
            Column5.HeaderText = "MÃ SINH VIÊN";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 170;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "MaMH";
            Column2.HeaderText = "MÃ MÔN HỌC";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 170;
            // 
            // Column8
            // 
            Column8.DataPropertyName = "PhanTramTrenLop";
            Column8.HeaderText = "TRÊN LỚP (%)";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 165;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "PhanTramTH";
            Column4.HeaderText = "THI (%)";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "DiemTrenLop";
            Column6.HeaderText = "ĐIỂM TRÊN LỚP";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 200;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "DiemTH";
            Column7.HeaderText = "ĐIỂM THI";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 125;
            // 
            // Column9
            // 
            Column9.DataPropertyName = "DiemTB";
            Column9.HeaderText = "ĐIỂM TB";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            Column9.Width = 125;
            // 
            // Column10
            // 
            Column10.DataPropertyName = "Loai";
            Column10.HeaderText = "LOẠI";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            Column10.Width = 125;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "NamHoc";
            Column3.HeaderText = "NĂM HỌC";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvDiem);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 161);
            panel2.Name = "panel2";
            panel2.Size = new Size(1109, 475);
            panel2.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.Controls.Add(txbNamHoc);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(cmbMaMH);
            panel1.Controls.Add(cmbMaSV);
            panel1.Controls.Add(txbDiemTB);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txbDiemThi);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txbDiemTrenLop);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(cmbLoai);
            panel1.Controls.Add(numPTThi);
            panel1.Controls.Add(numPTTrenLop);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnLamMoi);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txbID);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1109, 155);
            panel1.TabIndex = 10;
            panel1.Paint += panel1_Paint;
            // 
            // txbNamHoc
            // 
            txbNamHoc.Location = new Point(810, 12);
            txbNamHoc.Name = "txbNamHoc";
            txbNamHoc.Size = new Size(88, 30);
            txbNamHoc.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(719, 16);
            label10.Name = "label10";
            label10.Size = new Size(86, 22);
            label10.TabIndex = 24;
            label10.Text = "Năm học:";
            // 
            // cmbMaMH
            // 
            cmbMaMH.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMaMH.FormattingEnabled = true;
            cmbMaMH.Items.AddRange(new object[] { "A", "B", "C", "D", "F" });
            cmbMaMH.Location = new Point(547, 12);
            cmbMaMH.Name = "cmbMaMH";
            cmbMaMH.Size = new Size(155, 30);
            cmbMaMH.TabIndex = 2;
            // 
            // cmbMaSV
            // 
            cmbMaSV.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMaSV.FormattingEnabled = true;
            cmbMaSV.Location = new Point(255, 12);
            cmbMaSV.Name = "cmbMaSV";
            cmbMaSV.Size = new Size(157, 30);
            cmbMaSV.TabIndex = 1;
            // 
            // txbDiemTB
            // 
            txbDiemTB.Location = new Point(524, 108);
            txbDiemTB.MaxLength = 255;
            txbDiemTB.Name = "txbDiemTB";
            txbDiemTB.Size = new Size(86, 30);
            txbDiemTB.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(429, 112);
            label9.Name = "label9";
            label9.Size = new Size(89, 22);
            label9.TabIndex = 23;
            label9.Text = "Điểm TB:";
            // 
            // txbDiemThi
            // 
            txbDiemThi.Location = new Point(327, 108);
            txbDiemThi.MaxLength = 255;
            txbDiemThi.Name = "txbDiemThi";
            txbDiemThi.Size = new Size(86, 30);
            txbDiemThi.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(237, 112);
            label8.Name = "label8";
            label8.Size = new Size(84, 22);
            label8.TabIndex = 21;
            label8.Text = "Điểm thi:";
            // 
            // txbDiemTrenLop
            // 
            txbDiemTrenLop.Location = new Point(139, 108);
            txbDiemTrenLop.MaxLength = 255;
            txbDiemTrenLop.Name = "txbDiemTrenLop";
            txbDiemTrenLop.Size = new Size(86, 30);
            txbDiemTrenLop.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 112);
            label7.Name = "label7";
            label7.Size = new Size(126, 22);
            label7.TabIndex = 19;
            label7.Text = "Điểm trên lớp:";
            // 
            // cmbLoai
            // 
            cmbLoai.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLoai.FormattingEnabled = true;
            cmbLoai.Items.AddRange(new object[] { "A", "B", "C", "D", "F" });
            cmbLoai.Location = new Point(454, 57);
            cmbLoai.Name = "cmbLoai";
            cmbLoai.Size = new Size(126, 30);
            cmbLoai.TabIndex = 8;
            // 
            // fQuanLyDiem
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 636);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "fQuanLyDiem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý điểm";
            Load += fQuanLyDiem_Load;
            ((System.ComponentModel.ISupportInitialize)numPTThi).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPTTrenLop).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDiem).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private NumericUpDown numPTThi;
        private NumericUpDown numPTTrenLop;
        private Label label6;
        private Label label4;
        private Label label5;
        private Button btnLamMoi;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private Label label3;
        private Label label2;
        private TextBox txbID;
        private Label label1;
        private DataGridView dgvDiem;
        private Panel panel2;
        private Panel panel1;
        private TextBox txbDiemTB;
        private Label label9;
        private TextBox txbDiemThi;
        private Label label8;
        private TextBox txbDiemTrenLop;
        private Label label7;
        private ComboBox cmbLoai;
        private ComboBox cmbMaMH;
        private ComboBox cmbMaSV;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column3;
        private TextBox txbNamHoc;
        private Label label10;
    }
}