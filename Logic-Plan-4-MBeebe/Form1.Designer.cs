namespace Logic_Plan_4_MBeebe
{
    partial class DiscountCalculator
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
            this.components = new System.ComponentModel.Container();
            this.numOfPackagesLabel = new System.Windows.Forms.Label();
            this.numOfPackagesTextBox = new System.Windows.Forms.TextBox();
            this.discountRateLabel = new System.Windows.Forms.Label();
            this.discountRateOutput = new System.Windows.Forms.Label();
            this.savingsLabel = new System.Windows.Forms.Label();
            this.savingsOutput = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.toalPriceOutput = new System.Windows.Forms.Label();
            this.caclulateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.calculateButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // numOfPackagesLabel
            // 
            this.numOfPackagesLabel.AutoSize = true;
            this.numOfPackagesLabel.Location = new System.Drawing.Point(62, 40);
            this.numOfPackagesLabel.Name = "numOfPackagesLabel";
            this.numOfPackagesLabel.Size = new System.Drawing.Size(229, 17);
            this.numOfPackagesLabel.TabIndex = 0;
            this.numOfPackagesLabel.Text = "Number of package(s) Purchased: ";
            // 
            // numOfPackagesTextBox
            // 
            this.numOfPackagesTextBox.Location = new System.Drawing.Point(297, 37);
            this.numOfPackagesTextBox.Name = "numOfPackagesTextBox";
            this.numOfPackagesTextBox.Size = new System.Drawing.Size(126, 22);
            this.numOfPackagesTextBox.TabIndex = 1;
            // 
            // discountRateLabel
            // 
            this.discountRateLabel.AutoSize = true;
            this.discountRateLabel.Location = new System.Drawing.Point(147, 100);
            this.discountRateLabel.Name = "discountRateLabel";
            this.discountRateLabel.Size = new System.Drawing.Size(105, 17);
            this.discountRateLabel.TabIndex = 2;
            this.discountRateLabel.Text = "Discount Rate: ";
            // 
            // discountRateOutput
            // 
            this.discountRateOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.discountRateOutput.Location = new System.Drawing.Point(261, 96);
            this.discountRateOutput.Name = "discountRateOutput";
            this.discountRateOutput.Size = new System.Drawing.Size(145, 25);
            this.discountRateOutput.TabIndex = 3;
            this.discountRateOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // savingsLabel
            // 
            this.savingsLabel.AutoSize = true;
            this.savingsLabel.Location = new System.Drawing.Point(167, 137);
            this.savingsLabel.Name = "savingsLabel";
            this.savingsLabel.Size = new System.Drawing.Size(85, 17);
            this.savingsLabel.TabIndex = 4;
            this.savingsLabel.Text = "You Saved: ";
            // 
            // savingsOutput
            // 
            this.savingsOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.savingsOutput.Location = new System.Drawing.Point(261, 133);
            this.savingsOutput.Name = "savingsOutput";
            this.savingsOutput.Size = new System.Drawing.Size(145, 25);
            this.savingsOutput.TabIndex = 5;
            this.savingsOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Location = new System.Drawing.Point(111, 170);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(141, 17);
            this.totalPriceLabel.TabIndex = 6;
            this.totalPriceLabel.Text = "Total After Discount: ";
            // 
            // toalPriceOutput
            // 
            this.toalPriceOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toalPriceOutput.Location = new System.Drawing.Point(261, 166);
            this.toalPriceOutput.Name = "toalPriceOutput";
            this.toalPriceOutput.Size = new System.Drawing.Size(145, 25);
            this.toalPriceOutput.TabIndex = 7;
            this.toalPriceOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // caclulateButton
            // 
            this.caclulateButton.Location = new System.Drawing.Point(92, 224);
            this.caclulateButton.Name = "caclulateButton";
            this.caclulateButton.Size = new System.Drawing.Size(102, 34);
            this.caclulateButton.TabIndex = 8;
            this.caclulateButton.Text = "Calculate";
            this.calculateButtonToolTip.SetToolTip(this.caclulateButton, "Calculate discount rate, total savings, and final price");
            this.caclulateButton.UseVisualStyleBackColor = true;
            this.caclulateButton.Click += new System.EventHandler(this.caclulateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(358, 224);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(102, 34);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(228, 224);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(102, 34);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // DiscountCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(516, 290);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.caclulateButton);
            this.Controls.Add(this.toalPriceOutput);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.savingsOutput);
            this.Controls.Add(this.savingsLabel);
            this.Controls.Add(this.discountRateOutput);
            this.Controls.Add(this.discountRateLabel);
            this.Controls.Add(this.numOfPackagesTextBox);
            this.Controls.Add(this.numOfPackagesLabel);
            this.Name = "DiscountCalculator";
            this.Text = "Discount Calculator - MBeebe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numOfPackagesLabel;
        private System.Windows.Forms.TextBox numOfPackagesTextBox;
        private System.Windows.Forms.Label discountRateLabel;
        private System.Windows.Forms.Label discountRateOutput;
        private System.Windows.Forms.Label savingsLabel;
        private System.Windows.Forms.Label savingsOutput;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Label toalPriceOutput;
        private System.Windows.Forms.Button caclulateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ToolTip calculateButtonToolTip;
    }
}

