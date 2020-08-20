namespace Logic_Plan_5_MBeebe
{
    partial class distanceCalculator
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
            this.vehicleSpeedLabel = new System.Windows.Forms.Label();
            this.hoursTraveledLabel = new System.Windows.Forms.Label();
            this.vehicleSpeedTextbox = new System.Windows.Forms.TextBox();
            this.hoursTraveledTextbox = new System.Windows.Forms.TextBox();
            this.outputListbox = new System.Windows.Forms.ListBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.calculateButtonTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.clearButtonTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.exitButtonTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // vehicleSpeedLabel
            // 
            this.vehicleSpeedLabel.AutoSize = true;
            this.vehicleSpeedLabel.Location = new System.Drawing.Point(100, 26);
            this.vehicleSpeedLabel.Name = "vehicleSpeedLabel";
            this.vehicleSpeedLabel.Size = new System.Drawing.Size(152, 17);
            this.vehicleSpeedLabel.TabIndex = 0;
            this.vehicleSpeedLabel.Text = "Vehicle Speed in MPH:";
            // 
            // hoursTraveledLabel
            // 
            this.hoursTraveledLabel.AutoSize = true;
            this.hoursTraveledLabel.Location = new System.Drawing.Point(142, 69);
            this.hoursTraveledLabel.Name = "hoursTraveledLabel";
            this.hoursTraveledLabel.Size = new System.Drawing.Size(110, 17);
            this.hoursTraveledLabel.TabIndex = 1;
            this.hoursTraveledLabel.Text = "Hours Traveled:";
            // 
            // vehicleSpeedTextbox
            // 
            this.vehicleSpeedTextbox.Location = new System.Drawing.Point(258, 26);
            this.vehicleSpeedTextbox.Name = "vehicleSpeedTextbox";
            this.vehicleSpeedTextbox.Size = new System.Drawing.Size(116, 22);
            this.vehicleSpeedTextbox.TabIndex = 2;
            // 
            // hoursTraveledTextbox
            // 
            this.hoursTraveledTextbox.Location = new System.Drawing.Point(258, 69);
            this.hoursTraveledTextbox.Name = "hoursTraveledTextbox";
            this.hoursTraveledTextbox.Size = new System.Drawing.Size(116, 22);
            this.hoursTraveledTextbox.TabIndex = 3;
            // 
            // outputListbox
            // 
            this.outputListbox.FormattingEnabled = true;
            this.outputListbox.ItemHeight = 16;
            this.outputListbox.Location = new System.Drawing.Point(103, 109);
            this.outputListbox.Name = "outputListbox";
            this.outputListbox.Size = new System.Drawing.Size(271, 148);
            this.outputListbox.TabIndex = 4;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(65, 273);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(88, 33);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate";
            this.calculateButtonTooltip.SetToolTip(this.calculateButton, "Calculate the distance traveled");
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(187, 273);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(92, 33);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButtonTooltip.SetToolTip(this.clearButton, "Clear form");
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(310, 273);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(94, 33);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButtonTooltip.SetToolTip(this.exitButton, "Close form");
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // distanceCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 337);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.outputListbox);
            this.Controls.Add(this.hoursTraveledTextbox);
            this.Controls.Add(this.vehicleSpeedTextbox);
            this.Controls.Add(this.hoursTraveledLabel);
            this.Controls.Add(this.vehicleSpeedLabel);
            this.Name = "distanceCalculator";
            this.Text = "Distance Calculator - MBeebe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label vehicleSpeedLabel;
        private System.Windows.Forms.Label hoursTraveledLabel;
        private System.Windows.Forms.TextBox vehicleSpeedTextbox;
        private System.Windows.Forms.TextBox hoursTraveledTextbox;
        private System.Windows.Forms.ListBox outputListbox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ToolTip calculateButtonTooltip;
        private System.Windows.Forms.ToolTip clearButtonTooltip;
        private System.Windows.Forms.ToolTip exitButtonTooltip;
    }
}

