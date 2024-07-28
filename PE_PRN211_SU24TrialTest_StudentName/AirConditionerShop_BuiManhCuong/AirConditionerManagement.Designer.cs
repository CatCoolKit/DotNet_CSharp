namespace AirConditionerShop_BuiManhCuong
{
    partial class AirConditionerManagement
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
            dgvAirConditioner = new DataGridView();
            button1 = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            label1 = new Label();
            txbAirId = new TextBox();
            label2 = new Label();
            txbAirName = new TextBox();
            txbWarranty = new TextBox();
            txbFeature = new TextBox();
            txbSound = new TextBox();
            txbDollar = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            numQuantity = new NumericUpDown();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            cmbSupplierId = new ComboBox();
            txbSearch = new TextBox();
            btnSearch = new Button();
            trackBar1 = new TrackBar();
            txbTrackBar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvAirConditioner).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // dgvAirConditioner
            // 
            dgvAirConditioner.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAirConditioner.Location = new Point(1, 244);
            dgvAirConditioner.Name = "dgvAirConditioner";
            dgvAirConditioner.RowHeadersWidth = 51;
            dgvAirConditioner.Size = new Size(1281, 392);
            dgvAirConditioner.TabIndex = 0;
            dgvAirConditioner.CellClick += dgvAirConditioner_CellClick;
            // 
            // button1
            // 
            button1.Location = new Point(1147, 73);
            button1.Name = "button1";
            button1.Size = new Size(110, 44);
            button1.TabIndex = 1;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1147, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(110, 44);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1017, 73);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(110, 44);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(1017, 12);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(110, 44);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(156, 23);
            label1.TabIndex = 5;
            label1.Text = "AirConditionerId:";
            // 
            // txbAirId
            // 
            txbAirId.Enabled = false;
            txbAirId.Location = new Point(208, 6);
            txbAirId.Name = "txbAirId";
            txbAirId.Size = new Size(355, 30);
            txbAirId.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 51);
            label2.Name = "label2";
            label2.Size = new Size(190, 23);
            label2.TabIndex = 6;
            label2.Text = "AirConditionerName:";
            // 
            // txbAirName
            // 
            txbAirName.Location = new Point(208, 48);
            txbAirName.Name = "txbAirName";
            txbAirName.Size = new Size(355, 30);
            txbAirName.TabIndex = 1;
            // 
            // txbWarranty
            // 
            txbWarranty.Location = new Point(208, 91);
            txbWarranty.Name = "txbWarranty";
            txbWarranty.Size = new Size(355, 30);
            txbWarranty.TabIndex = 2;
            // 
            // txbFeature
            // 
            txbFeature.Location = new Point(208, 185);
            txbFeature.Name = "txbFeature";
            txbFeature.Size = new Size(355, 30);
            txbFeature.TabIndex = 4;
            // 
            // txbSound
            // 
            txbSound.Location = new Point(208, 138);
            txbSound.Name = "txbSound";
            txbSound.Size = new Size(355, 30);
            txbSound.TabIndex = 3;
            // 
            // txbDollar
            // 
            txbDollar.Location = new Point(692, 48);
            txbDollar.Name = "txbDollar";
            txbDollar.Size = new Size(152, 30);
            txbDollar.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 94);
            label3.Name = "label3";
            label3.Size = new Size(96, 23);
            label3.TabIndex = 12;
            label3.Text = "Warranty:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 141);
            label4.Name = "label4";
            label4.Size = new Size(196, 23);
            label4.TabIndex = 13;
            label4.Text = "SoundPressureLevel:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 188);
            label5.Name = "label5";
            label5.Size = new Size(157, 23);
            label5.TabIndex = 14;
            label5.Text = "FeatureFunction:";
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(692, 7);
            numQuantity.Maximum = new decimal(new int[] { 4000000, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(152, 30);
            numQuantity.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(575, 9);
            label6.Name = "label6";
            label6.Size = new Size(89, 23);
            label6.TabIndex = 16;
            label6.Text = "Quantity:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(575, 51);
            label7.Name = "label7";
            label7.Size = new Size(112, 23);
            label7.TabIndex = 17;
            label7.Text = "DollarPrice:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(575, 94);
            label8.Name = "label8";
            label8.Size = new Size(104, 23);
            label8.TabIndex = 18;
            label8.Text = "SupplierId:";
            // 
            // cmbSupplierId
            // 
            cmbSupplierId.FormattingEnabled = true;
            cmbSupplierId.Location = new Point(692, 91);
            cmbSupplierId.Name = "cmbSupplierId";
            cmbSupplierId.Size = new Size(151, 31);
            cmbSupplierId.TabIndex = 7;
            // 
            // txbSearch
            // 
            txbSearch.Location = new Point(575, 185);
            txbSearch.Name = "txbSearch";
            txbSearch.Size = new Size(377, 30);
            txbSearch.TabIndex = 20;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(958, 181);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 37);
            btnSearch.TabIndex = 21;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(575, 128);
            trackBar1.Maximum = 4000000;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(130, 56);
            trackBar1.TabIndex = 22;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // txbTrackBar
            // 
            txbTrackBar.Location = new Point(711, 134);
            txbTrackBar.Name = "txbTrackBar";
            txbTrackBar.Size = new Size(132, 30);
            txbTrackBar.TabIndex = 23;
            txbTrackBar.TextChanged += txbTrackBar_TextChanged;
            // 
            // AirConditionerManagement
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1282, 636);
            Controls.Add(txbTrackBar);
            Controls.Add(trackBar1);
            Controls.Add(btnSearch);
            Controls.Add(txbSearch);
            Controls.Add(cmbSupplierId);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(numQuantity);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txbDollar);
            Controls.Add(txbSound);
            Controls.Add(txbFeature);
            Controls.Add(txbWarranty);
            Controls.Add(txbAirName);
            Controls.Add(label2);
            Controls.Add(txbAirId);
            Controls.Add(label1);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(button1);
            Controls.Add(dgvAirConditioner);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "AirConditionerManagement";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AirConditioner Management";
            Load += AirConditionerManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAirConditioner).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAirConditioner;
        private Button button1;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnUpdate;
        private Label label1;
        private TextBox txbAirId;
        private Label label2;
        private TextBox txbAirName;
        private TextBox txbWarranty;
        private TextBox txbFeature;
        private TextBox txbSound;
        private TextBox txbDollar;
        private Label label3;
        private Label label4;
        private Label label5;
        private NumericUpDown numQuantity;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox cmbSupplierId;
        private TextBox txbSearch;
        private Button btnSearch;
        private TrackBar trackBar1;
        private TextBox txbTrackBar;
    }
}