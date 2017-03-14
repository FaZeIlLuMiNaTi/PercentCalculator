namespace PercentCalculator
{
    partial class PercentageCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PercentageCalculator));
            this.PercentIn = new System.Windows.Forms.TextBox();
            this.PercentLabel = new System.Windows.Forms.Label();
            this.CalculationTypeBox = new System.Windows.Forms.ComboBox();
            this.NumberIn = new System.Windows.Forms.TextBox();
            this.EqualsLabel = new System.Windows.Forms.Label();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.GoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PercentIn
            // 
            this.PercentIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PercentIn.Location = new System.Drawing.Point(12, 12);
            this.PercentIn.Name = "PercentIn";
            this.PercentIn.Size = new System.Drawing.Size(43, 26);
            this.PercentIn.TabIndex = 0;
            this.PercentIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PercentIn_KeyPress);
            // 
            // PercentLabel
            // 
            this.PercentLabel.AutoSize = true;
            this.PercentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PercentLabel.Location = new System.Drawing.Point(57, 15);
            this.PercentLabel.Name = "PercentLabel";
            this.PercentLabel.Size = new System.Drawing.Size(23, 20);
            this.PercentLabel.TabIndex = 1;
            this.PercentLabel.Text = "%";
            this.PercentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CalculationTypeBox
            // 
            this.CalculationTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CalculationTypeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.CalculationTypeBox.Items.AddRange(new object[] {
            "Of",
            "Off"});
            this.CalculationTypeBox.Location = new System.Drawing.Point(86, 12);
            this.CalculationTypeBox.Name = "CalculationTypeBox";
            this.CalculationTypeBox.Size = new System.Drawing.Size(56, 26);
            this.CalculationTypeBox.TabIndex = 1;
            // 
            // NumberIn
            // 
            this.NumberIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberIn.Location = new System.Drawing.Point(148, 12);
            this.NumberIn.Name = "NumberIn";
            this.NumberIn.Size = new System.Drawing.Size(43, 26);
            this.NumberIn.TabIndex = 2;
            this.NumberIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberIn_KeyPress);
            // 
            // EqualsLabel
            // 
            this.EqualsLabel.AutoSize = true;
            this.EqualsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EqualsLabel.Location = new System.Drawing.Point(197, 14);
            this.EqualsLabel.Name = "EqualsLabel";
            this.EqualsLabel.Size = new System.Drawing.Size(18, 20);
            this.EqualsLabel.TabIndex = 1;
            this.EqualsLabel.Text = "=";
            this.EqualsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OutputBox
            // 
            this.OutputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputBox.Location = new System.Drawing.Point(221, 12);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ReadOnly = true;
            this.OutputBox.Size = new System.Drawing.Size(55, 26);
            this.OutputBox.TabIndex = 5;
            this.OutputBox.TabStop = false;
            this.OutputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OutputBox_KeyPress);
            // 
            // GoButton
            // 
            this.GoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoButton.Location = new System.Drawing.Point(12, 45);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(264, 37);
            this.GoButton.TabIndex = 3;
            this.GoButton.Text = "Calculate";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // PercentageCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 89);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.CalculationTypeBox);
            this.Controls.Add(this.EqualsLabel);
            this.Controls.Add(this.PercentLabel);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.NumberIn);
            this.Controls.Add(this.PercentIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PercentageCalculator";
            this.Text = "Percent Calculator";
            this.Load += new System.EventHandler(this.PercentageCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PercentIn;
        private System.Windows.Forms.Label PercentLabel;
        private System.Windows.Forms.ComboBox CalculationTypeBox;
        private System.Windows.Forms.TextBox NumberIn;
        private System.Windows.Forms.Label EqualsLabel;
        private System.Windows.Forms.TextBox OutputBox;
        private System.Windows.Forms.Button GoButton;
    }
}

