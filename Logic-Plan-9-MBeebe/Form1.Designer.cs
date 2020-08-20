namespace Logic_Plan_9_MBeebe
{
    partial class showDirection
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
            this.northLabel = new System.Windows.Forms.Label();
            this.southLabel = new System.Windows.Forms.Label();
            this.eastLabel = new System.Windows.Forms.Label();
            this.westLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // northLabel
            // 
            this.northLabel.AutoSize = true;
            this.northLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.northLabel.Location = new System.Drawing.Point(59, 31);
            this.northLabel.Name = "northLabel";
            this.northLabel.Size = new System.Drawing.Size(48, 17);
            this.northLabel.TabIndex = 0;
            this.northLabel.Text = "North";
            this.northLabel.Click += new System.EventHandler(this.northLabel_Click);
            // 
            // southLabel
            // 
            this.southLabel.AutoSize = true;
            this.southLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.southLabel.Location = new System.Drawing.Point(134, 31);
            this.southLabel.Name = "southLabel";
            this.southLabel.Size = new System.Drawing.Size(50, 17);
            this.southLabel.TabIndex = 1;
            this.southLabel.Text = "South";
            this.southLabel.Click += new System.EventHandler(this.southLabel_Click);
            // 
            // eastLabel
            // 
            this.eastLabel.AutoSize = true;
            this.eastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eastLabel.Location = new System.Drawing.Point(209, 31);
            this.eastLabel.Name = "eastLabel";
            this.eastLabel.Size = new System.Drawing.Size(40, 17);
            this.eastLabel.TabIndex = 2;
            this.eastLabel.Text = "East";
            this.eastLabel.Click += new System.EventHandler(this.eastLabel_Click);
            // 
            // westLabel
            // 
            this.westLabel.AutoSize = true;
            this.westLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.westLabel.Location = new System.Drawing.Point(276, 31);
            this.westLabel.Name = "westLabel";
            this.westLabel.Size = new System.Drawing.Size(44, 17);
            this.westLabel.TabIndex = 3;
            this.westLabel.Text = "West";
            this.westLabel.Click += new System.EventHandler(this.westLabel_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.Red;
            this.outputLabel.Location = new System.Drawing.Point(124, 82);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(146, 38);
            this.outputLabel.TabIndex = 4;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(159, 150);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.toolTip1.SetToolTip(this.exitButton, "Close Form");
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // showDirection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 203);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.westLabel);
            this.Controls.Add(this.eastLabel);
            this.Controls.Add(this.southLabel);
            this.Controls.Add(this.northLabel);
            this.Name = "showDirection";
            this.Text = "Show Direction - MBeebe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label northLabel;
        private System.Windows.Forms.Label southLabel;
        private System.Windows.Forms.Label eastLabel;
        private System.Windows.Forms.Label westLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

