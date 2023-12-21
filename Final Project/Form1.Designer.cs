namespace Final_Project
{
    partial class Form1
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            initialPaymentTextBox = new TextBox();
            monthlyPaymentTextBox = new TextBox();
            annualPaymentTextBox = new TextBox();
            termTextBox = new TextBox();
            interestRateTextBox = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            CalculateButton = new Button();
            resultsBox = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1056, 45);
            label1.TabIndex = 0;
            label1.Text = "Calculate your savings furure!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(178, 32);
            label2.TabIndex = 1;
            label2.Text = "Initial payment:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 117);
            label3.Name = "label3";
            label3.Size = new Size(210, 32);
            label3.TabIndex = 2;
            label3.Text = "Monthly payment:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 169);
            label4.Name = "label4";
            label4.Size = new Size(195, 32);
            label4.TabIndex = 3;
            label4.Text = "Annual payment:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 221);
            label5.Name = "label5";
            label5.Size = new Size(148, 32);
            label5.TabIndex = 4;
            label5.Text = "Term (years):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 273);
            label6.Name = "label6";
            label6.Size = new Size(242, 32);
            label6.TabIndex = 5;
            label6.Text = "Interest rate (%/year):";
            // 
            // initialPaymentTextBox
            // 
            initialPaymentTextBox.Location = new Point(268, 65);
            initialPaymentTextBox.Name = "initialPaymentTextBox";
            initialPaymentTextBox.Size = new Size(200, 39);
            initialPaymentTextBox.TabIndex = 6;
            initialPaymentTextBox.Text = "1000";
            // 
            // monthlyPaymentTextBox
            // 
            monthlyPaymentTextBox.Location = new Point(268, 117);
            monthlyPaymentTextBox.Name = "monthlyPaymentTextBox";
            monthlyPaymentTextBox.Size = new Size(200, 39);
            monthlyPaymentTextBox.TabIndex = 7;
            monthlyPaymentTextBox.Text = "100";
            // 
            // annualPaymentTextBox
            // 
            annualPaymentTextBox.Location = new Point(268, 169);
            annualPaymentTextBox.Name = "annualPaymentTextBox";
            annualPaymentTextBox.Size = new Size(200, 39);
            annualPaymentTextBox.TabIndex = 8;
            annualPaymentTextBox.Text = "0";
            // 
            // termTextBox
            // 
            termTextBox.Location = new Point(268, 221);
            termTextBox.Name = "termTextBox";
            termTextBox.Size = new Size(200, 39);
            termTextBox.TabIndex = 9;
            termTextBox.Text = "10";
            // 
            // interestRateTextBox
            // 
            interestRateTextBox.Location = new Point(268, 273);
            interestRateTextBox.Name = "interestRateTextBox";
            interestRateTextBox.Size = new Size(200, 39);
            interestRateTextBox.TabIndex = 10;
            interestRateTextBox.Text = "6";
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(12, 328);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(456, 59);
            CalculateButton.TabIndex = 12;
            CalculateButton.Text = "Calculate";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // resultsBox
            // 
            resultsBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resultsBox.Location = new Point(474, 65);
            resultsBox.Name = "resultsBox";
            resultsBox.Size = new Size(582, 322);
            resultsBox.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 400);
            Controls.Add(resultsBox);
            Controls.Add(CalculateButton);
            Controls.Add(interestRateTextBox);
            Controls.Add(termTextBox);
            Controls.Add(annualPaymentTextBox);
            Controls.Add(monthlyPaymentTextBox);
            Controls.Add(initialPaymentTextBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Savings calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox initialPaymentTextBox;
        private TextBox monthlyPaymentTextBox;
        private TextBox annualPaymentTextBox;
        private TextBox termTextBox;
        private TextBox interestRateTextBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button CalculateButton;
        private Label resultsBox;
    }
}
