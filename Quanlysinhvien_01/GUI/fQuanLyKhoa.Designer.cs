namespace Quanlysinhvien_01.GUI
{
    partial class fQuanLyKhoa
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
            txbTenKhoa = new TextBox();
            label3 = new Label();
            panel2 = new Panel();
            dgvKhoa = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            txbMaKhoa = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            txbID = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhoa).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(419, 72);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(96, 36);
            btnLamMoi.TabIndex = 9;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(317, 72);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(96, 36);
            btnSua.TabIndex = 8;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(419, 22);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(96, 36);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(317, 22);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(96, 36);
            btnThem.TabIndex = 6;
            btnThem.TabStop = false;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txbTenKhoa
            // 
            txbTenKhoa.Location = new Point(102, 79);
            txbTenKhoa.MaxLength = 255;
            txbTenKhoa.Name = "txbTenKhoa";
            txbTenKhoa.Size = new Size(175, 30);
            txbTenKhoa.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 82);
            label3.Name = "label3";
            label3.Size = new Size(88, 22);
            label3.TabIndex = 4;
            label3.Text = "Tên khoa:";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvKhoa);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(531, 442);
            panel2.TabIndex = 3;
            // 
            // dgvKhoa
            // 
            dgvKhoa.AllowUserToAddRows = false;
            dgvKhoa.AllowUserToDeleteRows = false;
            dgvKhoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhoa.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgvKhoa.Dock = DockStyle.Fill;
            dgvKhoa.Location = new Point(0, 0);
            dgvKhoa.MultiSelect = false;
            dgvKhoa.Name = "dgvKhoa";
            dgvKhoa.ReadOnly = true;
            dgvKhoa.RowHeadersVisible = false;
            dgvKhoa.RowHeadersWidth = 51;
            dgvKhoa.RowTemplate.Height = 30;
            dgvKhoa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhoa.Size = new Size(531, 442);
            dgvKhoa.TabIndex = 2;
            dgvKhoa.TabStop = false;
            dgvKhoa.CellClick += dgvKhoa_CellClick;
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
            Column2.DataPropertyName = "MaKhoa";
            Column2.HeaderText = "MÃ KHOA";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 180;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "TenKhoa";
            Column3.HeaderText = "TÊN KHOA";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 250;
            // 
            // txbMaKhoa
            // 
            txbMaKhoa.Location = new Point(102, 43);
            txbMaKhoa.MaxLength = 255;
            txbMaKhoa.Name = "txbMaKhoa";
            txbMaKhoa.Size = new Size(176, 30);
            txbMaKhoa.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 46);
            label2.Name = "label2";
            label2.Size = new Size(84, 22);
            label2.TabIndex = 2;
            label2.Text = "Mã khoa:";
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
            panel1.Controls.Add(btnLamMoi);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(txbTenKhoa);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txbMaKhoa);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txbID);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(531, 125);
            panel1.TabIndex = 2;
            // 
            // txbID
            // 
            txbID.Enabled = false;
            txbID.Location = new Point(54, 6);
            txbID.Name = "txbID";
            txbID.Size = new Size(65, 30);
            txbID.TabIndex = 0;
            // 
            // fQuanLyKhoa
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 567);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "fQuanLyKhoa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý khoa";
            Load += fQuanLyKhoa_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKhoa).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private DataGridView dgvKhoa;
        private TextBox txbMaKhoa;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private TextBox txbID;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}