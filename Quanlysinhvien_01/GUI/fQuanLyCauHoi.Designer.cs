namespace Quanlysinhvien_01.GUI
{
    partial class fQuanLyCauHoi
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
            panel3 = new Panel();
            rtxbQuestion = new RichTextBox();
            label4 = new Label();
            cmbExamID = new ComboBox();
            btnLamMoi = new Button();
            label1 = new Label();
            btnXoa = new Button();
            txbId = new TextBox();
            btnSua = new Button();
            label2 = new Label();
            btnThem = new Button();
            label3 = new Label();
            cmbQuestionType = new ComboBox();
            toolTip1 = new ToolTip(components);
            dgvCauHoi = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCauHoi).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(rtxbQuestion);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(cmbExamID);
            panel3.Controls.Add(btnLamMoi);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(btnXoa);
            panel3.Controls.Add(txbId);
            panel3.Controls.Add(btnSua);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(btnThem);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(cmbQuestionType);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(978, 316);
            panel3.TabIndex = 31;
            // 
            // rtxbQuestion
            // 
            rtxbQuestion.Location = new Point(142, 52);
            rtxbQuestion.Name = "rtxbQuestion";
            rtxbQuestion.Size = new Size(599, 87);
            rtxbQuestion.TabIndex = 2;
            rtxbQuestion.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 55);
            label4.Name = "label4";
            label4.Size = new Size(119, 22);
            label4.TabIndex = 27;
            label4.Text = "Question text:";
            // 
            // cmbExamID
            // 
            cmbExamID.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbExamID.FormattingEnabled = true;
            cmbExamID.Location = new Point(234, 8);
            cmbExamID.Name = "cmbExamID";
            cmbExamID.Size = new Size(267, 30);
            cmbExamID.TabIndex = 1;
            cmbExamID.SelectedIndexChanged += cmbExamID_SelectedIndexChanged;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 12);
            label1.Name = "label1";
            label1.Size = new Size(36, 22);
            label1.TabIndex = 0;
            label1.Text = "ID:";
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
            // txbId
            // 
            txbId.Enabled = false;
            txbId.Location = new Point(59, 8);
            txbId.Name = "txbId";
            txbId.Size = new Size(71, 30);
            txbId.TabIndex = 0;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(148, 12);
            label2.Name = "label2";
            label2.Size = new Size(80, 22);
            label2.TabIndex = 3;
            label2.Text = "ExamID:";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(518, 12);
            label3.Name = "label3";
            label3.Size = new Size(124, 22);
            label3.TabIndex = 5;
            label3.Text = "Question type:";
            // 
            // cmbQuestionType
            // 
            cmbQuestionType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbQuestionType.FormattingEnabled = true;
            cmbQuestionType.Items.AddRange(new object[] { "Multiple Choice", "True/False", "Short Answer" });
            cmbQuestionType.Location = new Point(648, 8);
            cmbQuestionType.Name = "cmbQuestionType";
            cmbQuestionType.Size = new Size(177, 30);
            cmbQuestionType.TabIndex = 3;
            // 
            // dgvCauHoi
            // 
            dgvCauHoi.AllowUserToAddRows = false;
            dgvCauHoi.AllowUserToDeleteRows = false;
            dgvCauHoi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCauHoi.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvCauHoi.Dock = DockStyle.Bottom;
            dgvCauHoi.Location = new Point(0, 322);
            dgvCauHoi.MultiSelect = false;
            dgvCauHoi.Name = "dgvCauHoi";
            dgvCauHoi.ReadOnly = true;
            dgvCauHoi.RowHeadersVisible = false;
            dgvCauHoi.RowHeadersWidth = 51;
            dgvCauHoi.RowTemplate.Height = 30;
            dgvCauHoi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCauHoi.Size = new Size(978, 371);
            dgvCauHoi.TabIndex = 32;
            dgvCauHoi.TabStop = false;
            dgvCauHoi.CellClick += dgvCauHoi_CellClick;
            dgvCauHoi.CellContentClick += dgvCauHoi_CellContentClick;
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
            Column2.DataPropertyName = "ExamID";
            Column2.HeaderText = "ExamID";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 165;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "QuestionText";
            Column3.HeaderText = "Question Text";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 580;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "QuestionType";
            Column4.HeaderText = "Question Type";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 165;
            // 
            // fQuanLyCauHoi
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 693);
            Controls.Add(panel3);
            Controls.Add(dgvCauHoi);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "fQuanLyCauHoi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý câu hỏi";
            Load += fQuanLyCauHoi_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCauHoi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Button btnLamMoi;
        private Label label1;
        private Button btnXoa;
        private TextBox txbId;
        private Button btnSua;
        private Label label2;
        private Button btnThem;
        private Label label3;
        private ComboBox cmbQuestionType;
        private ToolTip toolTip1;
        private DataGridView dgvCauHoi;
        private ComboBox cmbExamID;
        private Label label4;
        private RichTextBox rtxbQuestion;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}