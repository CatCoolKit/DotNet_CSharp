namespace Quanlysinhvien_01.GUI
{
    partial class fQuanLyThiCu
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txbId = new TextBox();
            txbExamName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dtpkExamDate = new DateTimePicker();
            label5 = new Label();
            dtpkStartTime = new DateTimePicker();
            dtpkEndTime = new DateTimePicker();
            label6 = new Label();
            cmbCourseID = new ComboBox();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            menuStrip1 = new MenuStrip();
            quảnLýToolStripMenuItem = new ToolStripMenuItem();
            quảnLýCâuHỏiToolStripMenuItem = new ToolStripMenuItem();
            quảnLýĐápÁnToolStripMenuItem = new ToolStripMenuItem();
            panel3 = new Panel();
            rdOpenExam = new RadioButton();
            rdCloseExam = new RadioButton();
            dgvThiCu = new DataGridView();
            toolTip1 = new ToolTip(components);
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThiCu).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 16);
            label1.Name = "label1";
            label1.Size = new Size(36, 22);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // txbId
            // 
            txbId.Enabled = false;
            txbId.Location = new Point(59, 12);
            txbId.Name = "txbId";
            txbId.Size = new Size(71, 30);
            txbId.TabIndex = 0;
            // 
            // txbExamName
            // 
            txbExamName.Location = new Point(260, 12);
            txbExamName.Name = "txbExamName";
            txbExamName.Size = new Size(125, 30);
            txbExamName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(148, 16);
            label2.Name = "label2";
            label2.Size = new Size(106, 22);
            label2.TabIndex = 3;
            label2.Text = "ExamName:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 100);
            label3.Name = "label3";
            label3.Size = new Size(92, 22);
            label3.TabIndex = 5;
            label3.Text = "CourseID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(404, 16);
            label4.Name = "label4";
            label4.Size = new Size(97, 22);
            label4.TabIndex = 6;
            label4.Text = "ExamDate:";
            label4.Click += label4_Click;
            // 
            // dtpkExamDate
            // 
            dtpkExamDate.Format = DateTimePickerFormat.Short;
            dtpkExamDate.Location = new Point(501, 12);
            dtpkExamDate.Name = "dtpkExamDate";
            dtpkExamDate.Size = new Size(137, 30);
            dtpkExamDate.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 57);
            label5.Name = "label5";
            label5.Size = new Size(93, 22);
            label5.TabIndex = 7;
            label5.Text = "StartTime:";
            // 
            // dtpkStartTime
            // 
            dtpkStartTime.Format = DateTimePickerFormat.Time;
            dtpkStartTime.Location = new Point(116, 53);
            dtpkStartTime.Name = "dtpkStartTime";
            dtpkStartTime.Size = new Size(138, 30);
            dtpkStartTime.TabIndex = 3;
            // 
            // dtpkEndTime
            // 
            dtpkEndTime.Format = DateTimePickerFormat.Time;
            dtpkEndTime.Location = new Point(363, 53);
            dtpkEndTime.Name = "dtpkEndTime";
            dtpkEndTime.Size = new Size(138, 30);
            dtpkEndTime.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(273, 57);
            label6.Name = "label6";
            label6.Size = new Size(87, 22);
            label6.TabIndex = 9;
            label6.Text = "EndTime:";
            // 
            // cmbCourseID
            // 
            cmbCourseID.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCourseID.FormattingEnabled = true;
            cmbCourseID.Location = new Point(115, 96);
            cmbCourseID.Name = "cmbCourseID";
            cmbCourseID.Size = new Size(177, 30);
            cmbCourseID.TabIndex = 5;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(871, 101);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(90, 38);
            btnLamMoi.TabIndex = 26;
            btnLamMoi.TabStop = false;
            btnLamMoi.Text = "Refresh";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(775, 101);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(90, 38);
            btnXoa.TabIndex = 25;
            btnXoa.TabStop = false;
            btnXoa.Text = "Delete";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(871, 51);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(90, 38);
            btnSua.TabIndex = 24;
            btnSua.TabStop = false;
            btnSua.Text = "Update";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(775, 51);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(90, 38);
            btnThem.TabIndex = 23;
            btnThem.TabStop = false;
            btnThem.Text = "Add";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { quảnLýToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(973, 28);
            menuStrip1.TabIndex = 27;
            menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýToolStripMenuItem
            // 
            quảnLýToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quảnLýCâuHỏiToolStripMenuItem, quảnLýĐápÁnToolStripMenuItem });
            quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            quảnLýToolStripMenuItem.Size = new Size(73, 24);
            quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // quảnLýCâuHỏiToolStripMenuItem
            // 
            quảnLýCâuHỏiToolStripMenuItem.Name = "quảnLýCâuHỏiToolStripMenuItem";
            quảnLýCâuHỏiToolStripMenuItem.Size = new Size(194, 26);
            quảnLýCâuHỏiToolStripMenuItem.Text = "Quản lý câu hỏi";
            quảnLýCâuHỏiToolStripMenuItem.Click += quảnLýCâuHỏiToolStripMenuItem_Click;
            // 
            // quảnLýĐápÁnToolStripMenuItem
            // 
            quảnLýĐápÁnToolStripMenuItem.Name = "quảnLýĐápÁnToolStripMenuItem";
            quảnLýĐápÁnToolStripMenuItem.Size = new Size(194, 26);
            quảnLýĐápÁnToolStripMenuItem.Text = "Quản lý đáp án";
            // 
            // panel3
            // 
            panel3.Controls.Add(rdOpenExam);
            panel3.Controls.Add(rdCloseExam);
            panel3.Controls.Add(txbExamName);
            panel3.Controls.Add(btnLamMoi);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(btnXoa);
            panel3.Controls.Add(txbId);
            panel3.Controls.Add(btnSua);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(btnThem);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(cmbCourseID);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(dtpkEndTime);
            panel3.Controls.Add(dtpkExamDate);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(dtpkStartTime);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 28);
            panel3.Name = "panel3";
            panel3.Size = new Size(973, 155);
            panel3.TabIndex = 28;
            // 
            // rdOpenExam
            // 
            rdOpenExam.AutoSize = true;
            rdOpenExam.Checked = true;
            rdOpenExam.Location = new Point(446, 98);
            rdOpenExam.Name = "rdOpenExam";
            rdOpenExam.Size = new Size(119, 26);
            rdOpenExam.TabIndex = 7;
            rdOpenExam.TabStop = true;
            rdOpenExam.Text = "Open exam";
            rdOpenExam.UseVisualStyleBackColor = true;
            // 
            // rdCloseExam
            // 
            rdCloseExam.AutoSize = true;
            rdCloseExam.Location = new Point(317, 98);
            rdCloseExam.Name = "rdCloseExam";
            rdCloseExam.Size = new Size(123, 26);
            rdCloseExam.TabIndex = 6;
            rdCloseExam.Text = "Close exam";
            rdCloseExam.UseVisualStyleBackColor = true;
            // 
            // dgvThiCu
            // 
            dgvThiCu.AllowUserToAddRows = false;
            dgvThiCu.AllowUserToDeleteRows = false;
            dgvThiCu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThiCu.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dgvThiCu.Dock = DockStyle.Fill;
            dgvThiCu.Location = new Point(0, 183);
            dgvThiCu.MultiSelect = false;
            dgvThiCu.Name = "dgvThiCu";
            dgvThiCu.ReadOnly = true;
            dgvThiCu.RowHeadersVisible = false;
            dgvThiCu.RowHeadersWidth = 51;
            dgvThiCu.RowTemplate.Height = 30;
            dgvThiCu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvThiCu.Size = new Size(973, 380);
            dgvThiCu.TabIndex = 29;
            dgvThiCu.TabStop = false;
            dgvThiCu.CellClick += dgvThiCu_CellClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column1.DataPropertyName = "ExamID";
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 65;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "ExamName";
            Column2.HeaderText = "ExamName";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 300;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "ExamDate";
            Column3.HeaderText = "ExamDate";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 180;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "StartTime";
            Column4.HeaderText = "StartTime";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 145;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "EndTime";
            Column5.HeaderText = "EndTime";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 145;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "CourseID";
            Column6.HeaderText = "CourseID";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 120;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "Status";
            Column7.HeaderText = "Status";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 125;
            // 
            // fQuanLyThiCu
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 563);
            Controls.Add(dgvThiCu);
            Controls.Add(panel3);
            Controls.Add(menuStrip1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "fQuanLyThiCu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý thi cử";
            Load += fQuanLyThiCu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThiCu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txbId;
        private TextBox txbExamName;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpkExamDate;
        private Label label5;
        private DateTimePicker dtpkStartTime;
        private DateTimePicker dtpkEndTime;
        private Label label6;
        private ComboBox cmbCourseID;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem quảnLýToolStripMenuItem;
        private Panel panel3;
        private DataGridView dgvThiCu;
        private ToolStripMenuItem quảnLýCâuHỏiToolStripMenuItem;
        private RadioButton rdOpenExam;
        private RadioButton rdCloseExam;
        private ToolTip toolTip1;
        private ToolStripMenuItem quảnLýĐápÁnToolStripMenuItem;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}