namespace WinFormsApp1_1805
{
    partial class Form3
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
            dgvAirCondition = new DataGridView();
            label1 = new Label();
            txbAirID = new TextBox();
            txbAirName = new TextBox();
            label2 = new Label();
            txbWarranty = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txbSound = new TextBox();
            label5 = new Label();
            txbFeature = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            cmbSupplierID = new ComboBox();
            numQuantity = new NumericUpDown();
            button1 = new Button();
            txbDollar = new TextBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            txbSearch = new TextBox();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAirCondition).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            SuspendLayout();
            // 
            // dgvAirCondition
            // 
            dgvAirCondition.AllowUserToAddRows = false;
            dgvAirCondition.AllowUserToDeleteRows = false;
            dgvAirCondition.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAirCondition.Location = new Point(33, 12);
            dgvAirCondition.MultiSelect = false;
            dgvAirCondition.Name = "dgvAirCondition";
            dgvAirCondition.ReadOnly = true;
            dgvAirCondition.RowHeadersWidth = 51;
            dgvAirCondition.Size = new Size(998, 217);
            dgvAirCondition.TabIndex = 0;
            dgvAirCondition.TabStop = false;
            dgvAirCondition.CellClick += dgvAirCondition_CellClick;
            dgvAirCondition.CellContentClick += dgvAirCondition_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 254);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 1;
            label1.Text = "AirConditionerID:";
            // 
            // txbAirID
            // 
            txbAirID.Enabled = false;
            txbAirID.Location = new Point(174, 253);
            txbAirID.Name = "txbAirID";
            txbAirID.Size = new Size(358, 27);
            txbAirID.TabIndex = 0;
            // 
            // txbAirName
            // 
            txbAirName.Location = new Point(174, 286);
            txbAirName.Name = "txbAirName";
            txbAirName.Size = new Size(358, 27);
            txbAirName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 289);
            label2.Name = "label2";
            label2.Size = new Size(149, 20);
            label2.TabIndex = 3;
            label2.Text = "AirConditionerName:";
            // 
            // txbWarranty
            // 
            txbWarranty.Location = new Point(174, 319);
            txbWarranty.Name = "txbWarranty";
            txbWarranty.Size = new Size(358, 27);
            txbWarranty.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 322);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 5;
            label3.Text = "Warranty:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 358);
            label4.Name = "label4";
            label4.Size = new Size(142, 20);
            label4.TabIndex = 7;
            label4.Text = "SoundPressureLevel:";
            // 
            // txbSound
            // 
            txbSound.Location = new Point(174, 355);
            txbSound.Name = "txbSound";
            txbSound.Size = new Size(358, 27);
            txbSound.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 397);
            label5.Name = "label5";
            label5.Size = new Size(117, 20);
            label5.TabIndex = 9;
            label5.Text = "FeatureFunction:";
            // 
            // txbFeature
            // 
            txbFeature.Location = new Point(174, 390);
            txbFeature.Name = "txbFeature";
            txbFeature.Size = new Size(358, 27);
            txbFeature.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 438);
            label6.Name = "label6";
            label6.Size = new Size(68, 20);
            label6.TabIndex = 11;
            label6.Text = "Quantity:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 476);
            label7.Name = "label7";
            label7.Size = new Size(85, 20);
            label7.TabIndex = 13;
            label7.Text = "DollarPrice:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 514);
            label8.Name = "label8";
            label8.Size = new Size(80, 20);
            label8.TabIndex = 15;
            label8.Text = "SupplierId:";
            // 
            // cmbSupplierID
            // 
            cmbSupplierID.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSupplierID.FormattingEnabled = true;
            cmbSupplierID.Location = new Point(174, 511);
            cmbSupplierID.Name = "cmbSupplierID";
            cmbSupplierID.Size = new Size(151, 28);
            cmbSupplierID.TabIndex = 7;
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(175, 431);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(150, 27);
            numQuantity.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(607, 253);
            button1.Name = "button1";
            button1.Size = new Size(112, 51);
            button1.TabIndex = 16;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txbDollar
            // 
            txbDollar.Location = new Point(175, 469);
            txbDollar.Name = "txbDollar";
            txbDollar.Size = new Size(358, 27);
            txbDollar.TabIndex = 6;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(736, 253);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 51);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(607, 323);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 51);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(736, 323);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(112, 51);
            btnRefresh.TabIndex = 19;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // txbSearch
            // 
            txbSearch.Location = new Point(174, 557);
            txbSearch.Name = "txbSearch";
            txbSearch.PlaceholderText = "AirConditioner Name";
            txbSearch.Size = new Size(357, 27);
            txbSearch.TabIndex = 21;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(550, 557);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 22;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1073, 623);
            Controls.Add(btnSearch);
            Controls.Add(txbSearch);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(txbDollar);
            Controls.Add(button1);
            Controls.Add(numQuantity);
            Controls.Add(cmbSupplierID);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txbFeature);
            Controls.Add(label5);
            Controls.Add(txbSound);
            Controls.Add(label4);
            Controls.Add(txbWarranty);
            Controls.Add(label3);
            Controls.Add(txbAirName);
            Controls.Add(label2);
            Controls.Add(txbAirID);
            Controls.Add(label1);
            Controls.Add(dgvAirCondition);
            Name = "Form3";
            Text = "Air Conditioner";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAirCondition).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAirCondition;
        private Label label1;
        private TextBox txbAirID;
        private TextBox txbAirName;
        private Label label2;
        private TextBox txbWarranty;
        private Label label3;
        private Label label4;
        private TextBox txbSound;
        private Label label5;
        private TextBox txbFeature;
        private Label label6;
        private TextBox textBox6;
        private Label label7;
        private TextBox textBox7;
        private Label label8;
        private ComboBox cmbSupplierID;
        private NumericUpDown numQuantity;
        private Button button1;
        private TextBox txbDollar;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnRefresh;
        private TextBox txbSearch;
        private Button btnSearch;
    }
}