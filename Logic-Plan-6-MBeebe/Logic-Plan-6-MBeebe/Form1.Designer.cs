namespace Logic_Plan_6_MBeebe
{
    partial class retailPriceCalculator
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
            this.wholesaleCostLabel = new System.Windows.Forms.Label();
            this.markupPercentageLabel = new System.Windows.Forms.Label();
            this.retailPriceOutput = new System.Windows.Forms.Label();
            this.wholesaleCostInputTextbox = new System.Windows.Forms.TextBox();
            this.markupPercentageInputTextbox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.calculateButtonTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.clearButtonTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.exitButtonTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.percent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wholesaleCostLabel
            // 
            this.wholesaleCostLabel.AutoSize = true;
            this.wholesaleCostLabel.Location = new System.Drawing.Point(124, 37);
            this.wholesaleCostLabel.Name = "wholesaleCostLabel";
            this.wholesaleCostLabel.Size = new System.Drawing.Size(130, 17);
            this.wholesaleCostLabel.TabIndex = 0;
            this.wholesaleCostLabel.Text = "Wholesale cost ($):";
            // 
            // markupPercentageLabel
            // 
            this.markupPercentageLabel.AutoSize = true;
            this.markupPercentageLabel.Location = new System.Drawing.Point(118, 80);
            this.markupPercentageLabel.Name = "markupPercentageLabel";
            this.markupPercentageLabel.Size = new System.Drawing.Size(136, 17);
            this.markupPercentageLabel.TabIndex = 1;
            this.markupPercentageLabel.Text = "Markup Percentage:";
            // 
            // retailPriceOutput
            // 
            this.retailPriceOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.retailPriceOutput.Location = new System.Drawing.Point(198, 138);
            this.retailPriceOutput.Name = "retailPriceOutput";
            this.retailPriceOutput.Size = new System.Drawing.Size(178, 31);
            this.retailPriceOutput.TabIndex = 2;
            this.retailPriceOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wholesaleCostInputTextbox
            // 
            this.wholesaleCostInputTextbox.Location = new System.Drawing.Point(260, 34);
            this.wholesaleCostInputTextbox.Name = "wholesaleCostInputTextbox";
            this.wholesaleCostInputTextbox.Size = new System.Drawing.Size(140, 22);
            this.wholesaleCostInputTextbox.TabIndex = 3;
            // 
            // markupPercentageInputTextbox
            // 
            this.markupPercentageInputTextbox.Location = new System.Drawing.Point(260, 77);
            this.markupPercentageInputTextbox.Name = "markupPercentageInputTextbox";
            this.markupPercentageInputTextbox.Size = new System.Drawing.Size(140, 22);
            this.markupPercentageInputTextbox.TabIndex = 4;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(88, 205);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(103, 39);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate";
            this.calculateButtonTooltip.SetToolTip(this.calculateButton, "Calculate retail price");
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(236, 205);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(94, 39);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButtonTooltip.SetToolTip(this.clearButton, "Clear form");
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(377, 205);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(98, 39);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButtonTooltip.SetToolTip(this.exitButton, "Exit form");
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // percent
            // 
            this.percent.AutoSize = true;
            this.percent.Location = new System.Drawing.Point(406, 80);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(20, 17);
            this.percent.TabIndex = 8;
            this.percent.Text = "%";
            // 
            // retailPriceCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 268);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.markupPercentageInputTextbox);
            this.Controls.Add(this.wholesaleCostInputTextbox);
            this.Controls.Add(this.retailPriceOutput);
            this.Controls.Add(this.markupPercentageLabel);
            this.Controls.Add(this.wholesaleCostLabel);
            this.Name = "retailPriceCalculator";
            this.Text = "Retail Price Calculator - MBeebe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wholesaleCostLabel;
        private System.Windows.Forms.Label markupPercentageLabel;
        private System.Windows.Forms.Label retailPriceOutput;
        private System.Windows.Forms.TextBox wholesaleCostInputTextbox;
        private System.Windows.Forms.TextBox markupPercentageInputTextbox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ToolTip calculateButtonTooltip;
        private System.Windows.Forms.ToolTip clearButtonTooltip;
        private System.Windows.Forms.ToolTip exitButtonTooltip;
        private System.Windows.Forms.Label percent;
    }
}

