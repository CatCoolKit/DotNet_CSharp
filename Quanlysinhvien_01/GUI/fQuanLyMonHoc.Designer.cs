namespace Quanlysinhvien_01.GUI
{
    partial class fQuanLyMonHoc
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
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnLamMoi = new Button();
            panel2 = new Panel();
            dgvMonHoc = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            txbTenMonHoc = new TextBox();
            numTietThucHanh = new NumericUpDown();
            numTietlyThuyet = new NumericUpDown();
            numSoTinChi = new NumericUpDown();
            txbMaMonHoc = new TextBox();
            txbID = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMonHoc).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTietThucHanh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTietlyThuyet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoTinChi).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(334, 81);
            label6.Name = "label6";
            label6.Size = new Size(127, 22);
            label6.TabIndex = 16;
            label6.Text = "Tiết thực hành:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(334, 45);
            label4.Name = "label4";
            label4.Size = new Size(119, 22);
            label4.TabIndex = 13;
            label4.Text = "Tiết lý thuyết:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 121);
            label5.Name = "label5";
            label5.Size = new Size(91, 22);
            label5.TabIndex = 12;
            label5.Text = "Số tín chỉ:";
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(791, 94);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(96, 36);
            btnLamMoi.TabIndex = 9;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvMonHoc);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 160);
            panel2.Name = "panel2";
            panel2.Size = new Size(899, 418);
            panel2.TabIndex = 9;
            // 
            // dgvMonHoc
            // 
            dgvMonHoc.AllowUserToAddRows = false;
            dgvMonHoc.AllowUserToDeleteRows = false;
            dgvMonHoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMonHoc.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column6, Column7 });
            dgvMonHoc.Dock = DockStyle.Fill;
            dgvMonHoc.Location = new Point(0, 0);
            dgvMonHoc.MultiSelect = false;
            dgvMonHoc.Name = "dgvMonHoc";
            dgvMonHoc.ReadOnly = true;
            dgvMonHoc.RowHeadersVisible = false;
            dgvMonHoc.RowHeadersWidth = 51;
            dgvMonHoc.RowTemplate.Height = 30;
            dgvMonHoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMonHoc.Size = new Size(899, 418);
            dgvMonHoc.TabIndex = 2;
            dgvMonHoc.TabStop = false;
            dgvMonHoc.CellClick += dgvMonHoc_CellClick;
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
            Column2.DataPropertyName = "MaMH";
            Column2.HeaderText = "MÃ MÔN HỌC";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 170;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "TenMH";
            Column3.HeaderText = "TÊN MÔN HỌC";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 175;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "SoTC";
            Column4.HeaderText = "SỐ TÍN CHỈ";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 145;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "TietLT";
            Column6.HeaderText = "TIẾT LÝ THUYẾT";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 200;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "TietTH";
            Column7.HeaderText = "TIẾT THỰC HÀNH";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 200;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(689, 94);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(96, 36);
            btnSua.TabIndex = 8;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(791, 44);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(96, 36);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(689, 44);
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
            label3.Size = new Size(117, 22);
            label3.TabIndex = 4;
            label3.Text = "Tên môn học:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(113, 22);
            label2.TabIndex = 2;
            label2.Text = "Mã môn học:";
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
            panel1.Controls.Add(txbTenMonHoc);
            panel1.Controls.Add(numTietThucHanh);
            panel1.Controls.Add(numTietlyThuyet);
            panel1.Controls.Add(numSoTinChi);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnLamMoi);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txbMaMonHoc);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txbID);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(899, 162);
            panel1.TabIndex = 8;
            // 
            // txbTenMonHoc
            // 
            txbTenMonHoc.Location = new Point(131, 78);
            txbTenMonHoc.MaxLength = 255;
            txbTenMonHoc.Name = "txbTenMonHoc";
            txbTenMonHoc.Size = new Size(176, 30);
            txbTenMonHoc.TabIndex = 17;
            // 
            // numTietThucHanh
            // 
            numTietThucHanh.Location = new Point(467, 78);
            numTietThucHanh.Name = "numTietThucHanh";
            numTietThucHanh.Size = new Size(150, 30);
            numTietThucHanh.TabIndex = 5;
            // 
            // numTietlyThuyet
            // 
            numTietlyThuyet.Location = new Point(467, 42);
            numTietlyThuyet.Name = "numTietlyThuyet";
            numTietlyThuyet.Size = new Size(150, 30);
            numTietlyThuyet.TabIndex = 4;
            // 
            // numSoTinChi
            // 
            numSoTinChi.Location = new Point(131, 119);
            numSoTinChi.Name = "numSoTinChi";
            numSoTinChi.Size = new Size(150, 30);
            numSoTinChi.TabIndex = 3;
            // 
            // txbMaMonHoc
            // 
            txbMaMonHoc.Location = new Point(131, 42);
            txbMaMonHoc.MaxLength = 255;
            txbMaMonHoc.Name = "txbMaMonHoc";
            txbMaMonHoc.Size = new Size(176, 30);
            txbMaMonHoc.TabIndex = 1;
            // 
            // txbID
            // 
            txbID.Enabled = false;
            txbID.Location = new Point(54, 6);
            txbID.Name = "txbID";
            txbID.Size = new Size(65, 30);
            txbID.TabIndex = 0;
            // 
            // fQuanLyMonHoc
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 578);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "fQuanLyMonHoc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý môn học";
            Load += fQuanLyMonHoc_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMonHoc).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numTietThucHanh).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTietlyThuyet).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoTinChi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RadioButton rdNu;
        private RadioButton rdNam;
        private Label label7;
        private Label label6;
        private DateTimePicker dtpkNgaySinh;
        private TextBox txbTenCoVan;
        private Label label4;
        private Label label5;
        private Button btnLamMoi;
        private Panel panel2;
        private DataGridView dgvMonHoc;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private TextBox txbMaMonHoc;
        private TextBox txbID;
        private NumericUpDown numTietlyThuyet;
        private NumericUpDown numSoTinChi;
        private NumericUpDown numTietThucHanh;
        private TextBox txbTenMonHoc;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}