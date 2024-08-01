namespace Eternity
{
    partial class ZodiacManager
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
            lblWelcom = new Label();
            label2 = new Label();
            btnShowImage = new Button();
            txtMonth = new TextBox();
            txtDay = new TextBox();
            label1 = new Label();
            picImage = new PictureBox();
            btnExit = new Button();
            pnlImage = new Panel();
            btnCheckZodiac = new Button();
            lblYourZodiac = new Label();
            lblCopyRight = new Label();
            ((System.ComponentModel.ISupportInitialize)picImage).BeginInit();
            pnlImage.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelcom
            // 
            lblWelcom.AutoSize = true;
            lblWelcom.Font = new Font("Arial", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcom.Location = new Point(22, 26);
            lblWelcom.Name = "lblWelcom";
            lblWelcom.Size = new Size(658, 89);
            lblWelcom.TabIndex = 9;
            lblWelcom.Text = "Zodiac Calculator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 186);
            label2.Name = "label2";
            label2.Size = new Size(138, 23);
            label2.TabIndex = 8;
            label2.Text = "Your birth day:";
            // 
            // btnShowImage
            // 
            btnShowImage.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowImage.Location = new Point(85, 383);
            btnShowImage.Name = "btnShowImage";
            btnShowImage.Size = new Size(158, 35);
            btnShowImage.TabIndex = 3;
            btnShowImage.Text = "Show Image";
            btnShowImage.UseVisualStyleBackColor = true;
            btnShowImage.Click += btnShowImage_Click;
            // 
            // txtMonth
            // 
            txtMonth.Location = new Point(220, 249);
            txtMonth.Name = "txtMonth";
            txtMonth.Size = new Size(239, 30);
            txtMonth.TabIndex = 1;
            // 
            // txtDay
            // 
            txtDay.Location = new Point(220, 183);
            txtDay.Name = "txtDay";
            txtDay.Size = new Size(239, 30);
            txtDay.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 252);
            label1.Name = "label1";
            label1.Size = new Size(159, 23);
            label1.TabIndex = 7;
            label1.Text = "Your birth month:";
            // 
            // picImage
            // 
            picImage.BackColor = Color.Gray;
            picImage.Location = new Point(14, 19);
            picImage.Name = "picImage";
            picImage.Size = new Size(486, 327);
            picImage.SizeMode = PictureBoxSizeMode.AutoSize;
            picImage.TabIndex = 6;
            picImage.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(268, 329);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(158, 35);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // pnlImage
            // 
            pnlImage.AutoScroll = true;
            pnlImage.BackColor = Color.Brown;
            pnlImage.Controls.Add(picImage);
            pnlImage.Location = new Point(656, 118);
            pnlImage.Name = "pnlImage";
            pnlImage.Size = new Size(519, 365);
            pnlImage.TabIndex = 5;
            // 
            // btnCheckZodiac
            // 
            btnCheckZodiac.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckZodiac.Location = new Point(85, 329);
            btnCheckZodiac.Name = "btnCheckZodiac";
            btnCheckZodiac.Size = new Size(158, 35);
            btnCheckZodiac.TabIndex = 2;
            btnCheckZodiac.Text = "Check Zodiac";
            btnCheckZodiac.UseVisualStyleBackColor = true;
            btnCheckZodiac.Click += btnCheckZodiac_Click;
            // 
            // lblYourZodiac
            // 
            lblYourZodiac.AutoSize = true;
            lblYourZodiac.Font = new Font("Cascadia Mono", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblYourZodiac.Location = new Point(51, 520);
            lblYourZodiac.Name = "lblYourZodiac";
            lblYourZodiac.Size = new Size(369, 37);
            lblYourZodiac.TabIndex = 6;
            lblYourZodiac.Text = "Your zodiac sign is...";
            // 
            // lblCopyRight
            // 
            lblCopyRight.AutoSize = true;
            lblCopyRight.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCopyRight.Location = new Point(12, 625);
            lblCopyRight.Name = "lblCopyRight";
            lblCopyRight.Size = new Size(183, 19);
            lblCopyRight.TabIndex = 10;
            lblCopyRight.Text = "© 2024 CatCoolKit, Inc.";
            // 
            // ZodiacManager
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(1199, 653);
            Controls.Add(lblCopyRight);
            Controls.Add(lblYourZodiac);
            Controls.Add(btnCheckZodiac);
            Controls.Add(pnlImage);
            Controls.Add(btnExit);
            Controls.Add(label1);
            Controls.Add(txtDay);
            Controls.Add(txtMonth);
            Controls.Add(btnShowImage);
            Controls.Add(label2);
            Controls.Add(lblWelcom);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "ZodiacManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcom to Zodiac Calculator";
            ((System.ComponentModel.ISupportInitialize)picImage).EndInit();
            pnlImage.ResumeLayout(false);
            pnlImage.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcom;
        private Label label2;
        private Button btnShowImage;
        private TextBox txtMonth;
        private TextBox txtDay;
        private Label label1;
        private PictureBox picImage;
        private Button btnExit;
        private Panel pnlImage;
        private Button btnCheckZodiac;
        private Label lblYourZodiac;
        private Label lblCopyRight;
    }
}