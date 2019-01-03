namespace TripCalculator
{
    partial class TripCalc
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
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.DestinationTextBox = new System.Windows.Forms.TextBox();
            this.DestinationLabel = new System.Windows.Forms.Label();
            this.MilesTravelledLabel = new System.Windows.Forms.Label();
            this.MilesTravelledTextBox = new System.Windows.Forms.TextBox();
            this.GallonsConsumedLabel = new System.Windows.Forms.Label();
            this.GallonsConsumedTextBox = new System.Windows.Forms.TextBox();
            this.MilesPerGallonLabel = new System.Windows.Forms.Label();
            this.MPGLabel = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CalculateButton
            // 
            this.CalculateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CalculateButton.Location = new System.Drawing.Point(139, 104);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 0;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetButton.Location = new System.Drawing.Point(263, 104);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 1;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // DestinationTextBox
            // 
            this.DestinationTextBox.Location = new System.Drawing.Point(110, 16);
            this.DestinationTextBox.Name = "DestinationTextBox";
            this.DestinationTextBox.Size = new System.Drawing.Size(104, 20);
            this.DestinationTextBox.TabIndex = 2;
            this.DestinationTextBox.Text = "Washington D.C.";
            // 
            // DestinationLabel
            // 
            this.DestinationLabel.AutoSize = true;
            this.DestinationLabel.Location = new System.Drawing.Point(41, 19);
            this.DestinationLabel.Name = "DestinationLabel";
            this.DestinationLabel.Size = new System.Drawing.Size(63, 13);
            this.DestinationLabel.TabIndex = 3;
            this.DestinationLabel.Text = "Destination:";
            // 
            // MilesTravelledLabel
            // 
            this.MilesTravelledLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MilesTravelledLabel.AutoSize = true;
            this.MilesTravelledLabel.Location = new System.Drawing.Point(256, 16);
            this.MilesTravelledLabel.Name = "MilesTravelledLabel";
            this.MilesTravelledLabel.Size = new System.Drawing.Size(81, 13);
            this.MilesTravelledLabel.TabIndex = 5;
            this.MilesTravelledLabel.Text = "Miles Travelled:";
            // 
            // MilesTravelledTextBox
            // 
            this.MilesTravelledTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MilesTravelledTextBox.Location = new System.Drawing.Point(341, 12);
            this.MilesTravelledTextBox.MaximumSize = new System.Drawing.Size(81, 20);
            this.MilesTravelledTextBox.MinimumSize = new System.Drawing.Size(41, 20);
            this.MilesTravelledTextBox.Name = "MilesTravelledTextBox";
            this.MilesTravelledTextBox.Size = new System.Drawing.Size(81, 20);
            this.MilesTravelledTextBox.TabIndex = 4;
            this.MilesTravelledTextBox.Text = "0.0";
            this.MilesTravelledTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GallonsConsumedLabel
            // 
            this.GallonsConsumedLabel.AutoSize = true;
            this.GallonsConsumedLabel.Location = new System.Drawing.Point(240, 54);
            this.GallonsConsumedLabel.Name = "GallonsConsumedLabel";
            this.GallonsConsumedLabel.Size = new System.Drawing.Size(98, 13);
            this.GallonsConsumedLabel.TabIndex = 7;
            this.GallonsConsumedLabel.Text = "Gallons Consumed:";
            // 
            // GallonsConsumedTextBox
            // 
            this.GallonsConsumedTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.GallonsConsumedTextBox.Location = new System.Drawing.Point(341, 51);
            this.GallonsConsumedTextBox.MaximumSize = new System.Drawing.Size(81, 20);
            this.GallonsConsumedTextBox.MinimumSize = new System.Drawing.Size(41, 20);
            this.GallonsConsumedTextBox.Name = "GallonsConsumedTextBox";
            this.GallonsConsumedTextBox.Size = new System.Drawing.Size(81, 20);
            this.GallonsConsumedTextBox.TabIndex = 6;
            this.GallonsConsumedTextBox.Text = "0.0";
            this.GallonsConsumedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MilesPerGallonLabel
            // 
            this.MilesPerGallonLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MilesPerGallonLabel.AutoSize = true;
            this.MilesPerGallonLabel.Location = new System.Drawing.Point(41, 54);
            this.MilesPerGallonLabel.Name = "MilesPerGallonLabel";
            this.MilesPerGallonLabel.Size = new System.Drawing.Size(89, 13);
            this.MilesPerGallonLabel.TabIndex = 8;
            this.MilesPerGallonLabel.Text = "Miles Per Gallon: ";
            // 
            // MPGLabel
            // 
            this.MPGLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MPGLabel.AutoSize = true;
            this.MPGLabel.Location = new System.Drawing.Point(136, 54);
            this.MPGLabel.Name = "MPGLabel";
            this.MPGLabel.Size = new System.Drawing.Size(36, 13);
            this.MPGLabel.TabIndex = 10;
            this.MPGLabel.Text = "0 mpg";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Location = new System.Drawing.Point(41, 81);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.ErrorLabel.TabIndex = 11;
            // 
            // TripCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(468, 139);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.MPGLabel);
            this.Controls.Add(this.MilesPerGallonLabel);
            this.Controls.Add(this.GallonsConsumedLabel);
            this.Controls.Add(this.GallonsConsumedTextBox);
            this.Controls.Add(this.MilesTravelledLabel);
            this.Controls.Add(this.MilesTravelledTextBox);
            this.Controls.Add(this.DestinationLabel);
            this.Controls.Add(this.DestinationTextBox);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.CalculateButton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Location = new System.Drawing.Point(200, 200);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(484, 178);
            this.MinimumSize = new System.Drawing.Size(484, 178);
            this.Name = "TripCalc";
            this.Text = "Trip Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.TextBox DestinationTextBox;
        private System.Windows.Forms.Label DestinationLabel;
        private System.Windows.Forms.Label MilesTravelledLabel;
        private System.Windows.Forms.TextBox MilesTravelledTextBox;
        private System.Windows.Forms.Label GallonsConsumedLabel;
        private System.Windows.Forms.TextBox GallonsConsumedTextBox;
        private System.Windows.Forms.Label MilesPerGallonLabel;
        private System.Windows.Forms.Label MPGLabel;
        private System.Windows.Forms.Label ErrorLabel;
    }
}

