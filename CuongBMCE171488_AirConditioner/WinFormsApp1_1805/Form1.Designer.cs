namespace WinFormsApp1_1805
{
    partial class calculation
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtFullname = new TextBox();
            submitfullname = new Button();
            lbresult = new Label();
            number1 = new TextBox();
            number2 = new TextBox();
            rsCalculation = new TextBox();
            caculation = new TextBox();
            lb1 = new Label();
            lb2 = new Label();
            label4 = new Label();
            submitCalculation = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 42);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "Fullname";
            // 
            // txtFullname
            // 
            txtFullname.ForeColor = SystemColors.InactiveCaption;
            txtFullname.Location = new Point(123, 39);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(224, 27);
            txtFullname.TabIndex = 1;
            // 
            // submitfullname
            // 
            submitfullname.BackColor = SystemColors.ActiveBorder;
            submitfullname.Location = new Point(228, 82);
            submitfullname.Name = "submitfullname";
            submitfullname.Size = new Size(119, 46);
            submitfullname.TabIndex = 2;
            submitfullname.Text = "Submit";
            submitfullname.UseVisualStyleBackColor = false;
            submitfullname.Click += button1_Click;
            // 
            // lbresult
            // 
            lbresult.AutoSize = true;
            lbresult.BorderStyle = BorderStyle.FixedSingle;
            lbresult.ForeColor = SystemColors.ActiveCaption;
            lbresult.Location = new Point(394, 46);
            lbresult.Name = "lbresult";
            lbresult.Size = new Size(52, 22);
            lbresult.TabIndex = 3;
            lbresult.Text = "label2";
            // 
            // number1
            // 
            number1.Location = new Point(147, 165);
            number1.Name = "number1";
            number1.PlaceholderText = "input number";
            number1.Size = new Size(125, 27);
            number1.TabIndex = 4;
            // 
            // number2
            // 
            number2.Location = new Point(147, 198);
            number2.Name = "number2";
            number2.PlaceholderText = "input number";
            number2.Size = new Size(125, 27);
            number2.TabIndex = 5;
            // 
            // rsCalculation
            // 
            rsCalculation.BorderStyle = BorderStyle.FixedSingle;
            rsCalculation.Enabled = false;
            rsCalculation.Location = new Point(394, 165);
            rsCalculation.Name = "rsCalculation";
            rsCalculation.PlaceholderText = "result...";
            rsCalculation.ReadOnly = true;
            rsCalculation.Size = new Size(125, 27);
            rsCalculation.TabIndex = 6;
            // 
            // caculation
            // 
            caculation.Location = new Point(147, 242);
            caculation.Name = "caculation";
            caculation.PlaceholderText = "input operation";
            caculation.Size = new Size(125, 27);
            caculation.TabIndex = 7;
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.BackColor = SystemColors.ButtonFace;
            lb1.Location = new Point(58, 168);
            lb1.Name = "lb1";
            lb1.Size = new Size(75, 20);
            lb1.TabIndex = 8;
            lb1.Text = "Number 1";
            // 
            // lb2
            // 
            lb2.AutoSize = true;
            lb2.Location = new Point(58, 201);
            lb2.Name = "lb2";
            lb2.Size = new Size(75, 20);
            lb2.TabIndex = 9;
            lb2.Text = "Number 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 245);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 10;
            label4.Text = "Operation";
            // 
            // submitCalculation
            // 
            submitCalculation.BackColor = SystemColors.AppWorkspace;
            submitCalculation.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            submitCalculation.Location = new Point(296, 281);
            submitCalculation.Name = "submitCalculation";
            submitCalculation.Size = new Size(122, 46);
            submitCalculation.TabIndex = 11;
            submitCalculation.Text = "Calculation";
            submitCalculation.UseVisualStyleBackColor = false;
            submitCalculation.Click += submitCalculation_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(325, 168);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 12;
            label2.Text = "Result";
            // 
            // calculation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(submitCalculation);
            Controls.Add(label4);
            Controls.Add(lb2);
            Controls.Add(lb1);
            Controls.Add(caculation);
            Controls.Add(rsCalculation);
            Controls.Add(number2);
            Controls.Add(number1);
            Controls.Add(lbresult);
            Controls.Add(submitfullname);
            Controls.Add(txtFullname);
            Controls.Add(label1);
            Name = "calculation";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFullname;
        private Button submitfullname;
        private Label lbresult;
        private TextBox number1;
        private TextBox number2;
        private TextBox rsCalculation;
        private TextBox caculation;
        private Label lb1;
        private Label lb2;
        private Label label4;
        private Button submitCalculation;
        private Label label2;
    }
}
