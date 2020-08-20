namespace Logic_Plan_3_MBeebe
{
    partial class PurchasePriceCalculator
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
            this.components = new System.ComponentModel.Container();
            this.amountOfPurchaseInputLabel = new System.Windows.Forms.Label();
            this.amountOfPurchaseOutputLabel = new System.Windows.Forms.Label();
            this.toalDiscountLabel = new System.Windows.Forms.Label();
            this.totalOfSaleLabel = new System.Windows.Forms.Label();
            this.calculatePurchaseButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.amountOfPurchaseOutput = new System.Windows.Forms.Label();
            this.totalDiscountAmountOutput = new System.Windows.Forms.Label();
            this.totalOfSaleOutput = new System.Windows.Forms.Label();
            this.calculateButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.amountOfPurchaseTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // amountOfPurchaseInputLabel
            // 
            this.amountOfPurchaseInputLabel.AutoSize = true;
            this.amountOfPurchaseInputLabel.Location = new System.Drawing.Point(12, 9);
            this.amountOfPurchaseInputLabel.Name = "amountOfPurchaseInputLabel";
            this.amountOfPurchaseInputLabel.Size = new System.Drawing.Size(128, 15);
            this.amountOfPurchaseInputLabel.TabIndex = 0;
            this.amountOfPurchaseInputLabel.Text = "Amount of Purchase: $";
            // 
            // amountOfPurchaseOutputLabel
            // 
            this.amountOfPurchaseOutputLabel.AutoSize = true;
            this.amountOfPurchaseOutputLabel.Location = new System.Drawing.Point(48, 57);
            this.amountOfPurchaseOutputLabel.Name = "amountOfPurchaseOutputLabel";
            this.amountOfPurchaseOutputLabel.Size = new System.Drawing.Size(119, 15);
            this.amountOfPurchaseOutputLabel.TabIndex = 1;
            this.amountOfPurchaseOutputLabel.Text = "Amount of Purchase:";
            // 
            // toalDiscountLabel
            // 
            this.toalDiscountLabel.AutoSize = true;
            this.toalDiscountLabel.Location = new System.Drawing.Point(35, 88);
            this.toalDiscountLabel.Name = "toalDiscountLabel";
            this.toalDiscountLabel.Size = new System.Drawing.Size(132, 15);
            this.toalDiscountLabel.TabIndex = 2;
            this.toalDiscountLabel.Text = "Total Discount Amount:";
            // 
            // totalOfSaleLabel
            // 
            this.totalOfSaleLabel.AutoSize = true;
            this.totalOfSaleLabel.Location = new System.Drawing.Point(74, 123);
            this.totalOfSaleLabel.Name = "totalOfSaleLabel";
            this.totalOfSaleLabel.Size = new System.Drawing.Size(93, 15);
            this.totalOfSaleLabel.TabIndex = 3;
            this.totalOfSaleLabel.Text = "Total of the Sale:";
            // 
            // calculatePurchaseButton
            // 
            this.calculatePurchaseButton.Location = new System.Drawing.Point(252, 4);
            this.calculatePurchaseButton.Name = "calculatePurchaseButton";
            this.calculatePurchaseButton.Size = new System.Drawing.Size(117, 24);
            this.calculatePurchaseButton.TabIndex = 8;
            this.calculatePurchaseButton.Text = "Calculate Purchase";
            this.calculateButtonToolTip.SetToolTip(this.calculatePurchaseButton, "Applies 10% Discount to Purchase Amount");
            this.calculatePurchaseButton.UseVisualStyleBackColor = true;
            this.calculatePurchaseButton.Click += new System.EventHandler(this.calculatePurchaseButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(151, 168);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // amountOfPurchaseOutput
            // 
            this.amountOfPurchaseOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.amountOfPurchaseOutput.Location = new System.Drawing.Point(173, 57);
            this.amountOfPurchaseOutput.Name = "amountOfPurchaseOutput";
            this.amountOfPurchaseOutput.Size = new System.Drawing.Size(100, 19);
            this.amountOfPurchaseOutput.TabIndex = 4;
            this.amountOfPurchaseOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalDiscountAmountOutput
            // 
            this.totalDiscountAmountOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalDiscountAmountOutput.Location = new System.Drawing.Point(173, 88);
            this.totalDiscountAmountOutput.Name = "totalDiscountAmountOutput";
            this.totalDiscountAmountOutput.Size = new System.Drawing.Size(100, 19);
            this.totalDiscountAmountOutput.TabIndex = 4;
            this.totalDiscountAmountOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalOfSaleOutput
            // 
            this.totalOfSaleOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalOfSaleOutput.Location = new System.Drawing.Point(173, 123);
            this.totalOfSaleOutput.Name = "totalOfSaleOutput";
            this.totalOfSaleOutput.Size = new System.Drawing.Size(100, 19);
            this.totalOfSaleOutput.TabIndex = 4;
            this.totalOfSaleOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // amountOfPurchaseTextBox
            // 
            this.amountOfPurchaseTextBox.Location = new System.Drawing.Point(146, 6);
            this.amountOfPurchaseTextBox.Name = "amountOfPurchaseTextBox";
            this.amountOfPurchaseTextBox.Size = new System.Drawing.Size(100, 23);
            this.amountOfPurchaseTextBox.TabIndex = 10;
            // 
            // PurchasePriceCalculator
            // 
            this.ClientSize = new System.Drawing.Size(386, 206);
            this.Controls.Add(this.amountOfPurchaseTextBox);
            this.Controls.Add(this.totalOfSaleOutput);
            this.Controls.Add(this.totalDiscountAmountOutput);
            this.Controls.Add(this.amountOfPurchaseOutput);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculatePurchaseButton);
            this.Controls.Add(this.totalOfSaleLabel);
            this.Controls.Add(this.toalDiscountLabel);
            this.Controls.Add(this.amountOfPurchaseOutputLabel);
            this.Controls.Add(this.amountOfPurchaseInputLabel);
            this.Name = "PurchasePriceCalculator";
            this.Text = "Purchase Price Calculator - MBeebe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label amountOfPurchaseInputLabel;
        private System.Windows.Forms.Label amountOfPurchaseOutputLabel;
        private System.Windows.Forms.Label toalDiscountLabel;
        private System.Windows.Forms.Label totalOfSaleLabel;
        private System.Windows.Forms.Button calculatePurchaseButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label amountOfPurchaseOutput;
        private System.Windows.Forms.Label totalDiscountAmountOutput;
        private System.Windows.Forms.Label totalOfSaleOutput;
        private System.Windows.Forms.ToolTip calculateButtonToolTip;
        private System.Windows.Forms.TextBox amountOfPurchaseTextBox;
    }
}

