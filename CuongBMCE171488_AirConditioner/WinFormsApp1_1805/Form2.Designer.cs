namespace WinFormsApp1_1805
{
    partial class Form2
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
            dgvListStaff = new DataGridView();
            label1 = new Label();
            txbMemberID = new TextBox();
            label2 = new Label();
            txbPassword = new TextBox();
            txbEmail = new TextBox();
            txbFullName = new TextBox();
            label4 = new Label();
            label5 = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            label3 = new Label();
            cmbRole = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvListStaff).BeginInit();
            SuspendLayout();
            // 
            // dgvListStaff
            // 
            dgvListStaff.AllowUserToAddRows = false;
            dgvListStaff.AllowUserToDeleteRows = false;
            dgvListStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListStaff.Location = new Point(38, 26);
            dgvListStaff.MultiSelect = false;
            dgvListStaff.Name = "dgvListStaff";
            dgvListStaff.ReadOnly = true;
            dgvListStaff.RowHeadersWidth = 51;
            dgvListStaff.Size = new Size(725, 229);
            dgvListStaff.TabIndex = 0;
            dgvListStaff.TabStop = false;
            dgvListStaff.CellClick += dgvListStaff_CellClick;
            dgvListStaff.CellContentDoubleClick += dgvListStudent_CellContentDoubleClick;
            dgvListStaff.CellDoubleClick += dgvListStudent_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 287);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 1;
            label1.Text = "MemberID:";
            // 
            // txbMemberID
            // 
            txbMemberID.Enabled = false;
            txbMemberID.Location = new Point(151, 284);
            txbMemberID.Name = "txbMemberID";
            txbMemberID.Size = new Size(232, 27);
            txbMemberID.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 330);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // txbPassword
            // 
            txbPassword.Location = new Point(151, 327);
            txbPassword.Name = "txbPassword";
            txbPassword.Size = new Size(232, 27);
            txbPassword.TabIndex = 1;
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(151, 410);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(232, 27);
            txbEmail.TabIndex = 3;
            // 
            // txbFullName
            // 
            txbFullName.Location = new Point(151, 370);
            txbFullName.Name = "txbFullName";
            txbFullName.Size = new Size(232, 27);
            txbFullName.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 373);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 5;
            label4.Text = "FullName:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 413);
            label5.Name = "label5";
            label5.Size = new Size(102, 20);
            label5.TabIndex = 9;
            label5.Text = "EmailAddress:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(512, 284);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(102, 48);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(632, 284);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(102, 48);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(512, 349);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(102, 48);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(632, 349);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(102, 48);
            btnRefresh.TabIndex = 14;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 457);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 15;
            label3.Text = "RoleID:";
            // 
            // cmbRole
            // 
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "1", "2", "3" });
            cmbRole.Location = new Point(151, 454);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(232, 28);
            cmbRole.TabIndex = 16;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 592);
            Controls.Add(cmbRole);
            Controls.Add(label3);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(label5);
            Controls.Add(txbEmail);
            Controls.Add(txbFullName);
            Controls.Add(label4);
            Controls.Add(txbPassword);
            Controls.Add(label2);
            Controls.Add(txbMemberID);
            Controls.Add(label1);
            Controls.Add(dgvListStaff);
            Name = "Form2";
            Text = "Staff Member";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListStaff).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvListStaff;
        private Label label1;
        private TextBox txbMemberID;
        private Label label2;
        private TextBox txbPassword;
        private TextBox txbEmail;
        private TextBox txbFullName;
        private Label label4;
        private Label label5;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnRefresh;
        private Label label3;
        private ComboBox cmbRole;
    }
}