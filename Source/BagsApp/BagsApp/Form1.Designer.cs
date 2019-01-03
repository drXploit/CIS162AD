namespace BagsApp
{
    partial class BagsForm
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
            this.listBoxBags = new System.Windows.Forms.ListBox();
            this.comboBoxQuantity = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.radioOvernight = new System.Windows.Forms.RadioButton();
            this.radioThreeDay = new System.Windows.Forms.RadioButton();
            this.radioStandard = new System.Windows.Forms.RadioButton();
            this.panelShipping = new System.Windows.Forms.Panel();
            this.labelShippingCost = new System.Windows.Forms.Label();
            this.labelShippingPrice = new System.Windows.Forms.Label();
            this.labelShipping = new System.Windows.Forms.Label();
            this.panelShipping.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxBags
            // 
            this.listBoxBags.FormattingEnabled = true;
            this.listBoxBags.ItemHeight = 20;
            this.listBoxBags.Location = new System.Drawing.Point(12, 12);
            this.listBoxBags.Name = "listBoxBags";
            this.listBoxBags.Size = new System.Drawing.Size(254, 184);
            this.listBoxBags.Sorted = true;
            this.listBoxBags.TabIndex = 0;
            this.listBoxBags.SelectedIndexChanged += new System.EventHandler(this.ListBoxChanged);
            // 
            // comboBoxQuantity
            // 
            this.comboBoxQuantity.Location = new System.Drawing.Point(145, 205);
            this.comboBoxQuantity.MaxDropDownItems = 10;
            this.comboBoxQuantity.Name = "comboBoxQuantity";
            this.comboBoxQuantity.Size = new System.Drawing.Size(121, 28);
            this.comboBoxQuantity.TabIndex = 1;
            this.comboBoxQuantity.Text = "1";
            this.comboBoxQuantity.SelectedIndexChanged += new System.EventHandler(this.QuantityBoxChanged);
            this.comboBoxQuantity.SelectionChangeCommitted += new System.EventHandler(this.QuantityBoxChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quantity:";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(531, 205);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(182, 32);
            this.SubmitButton.TabIndex = 3;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(276, 205);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(182, 32);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "Clear Selection";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // MessageLabel
            // 
            this.MessageLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MessageLabel.Location = new System.Drawing.Point(409, 12);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(304, 184);
            this.MessageLabel.TabIndex = 5;
            // 
            // radioOvernight
            // 
            this.radioOvernight.AutoSize = true;
            this.radioOvernight.Location = new System.Drawing.Point(7, 27);
            this.radioOvernight.Name = "radioOvernight";
            this.radioOvernight.Size = new System.Drawing.Size(99, 24);
            this.radioOvernight.TabIndex = 6;
            this.radioOvernight.Text = "overnight";
            this.radioOvernight.UseVisualStyleBackColor = true;
            this.radioOvernight.CheckedChanged += new System.EventHandler(this.RadioCheckChanged);
            // 
            // radioThreeDay
            // 
            this.radioThreeDay.AutoSize = true;
            this.radioThreeDay.Location = new System.Drawing.Point(7, 58);
            this.radioThreeDay.Name = "radioThreeDay";
            this.radioThreeDay.Size = new System.Drawing.Size(100, 24);
            this.radioThreeDay.TabIndex = 7;
            this.radioThreeDay.Text = "three day";
            this.radioThreeDay.UseVisualStyleBackColor = true;
            this.radioThreeDay.CheckedChanged += new System.EventHandler(this.RadioCheckChanged);
            // 
            // radioStandard
            // 
            this.radioStandard.AutoSize = true;
            this.radioStandard.Checked = true;
            this.radioStandard.Location = new System.Drawing.Point(7, 89);
            this.radioStandard.Name = "radioStandard";
            this.radioStandard.Size = new System.Drawing.Size(97, 24);
            this.radioStandard.TabIndex = 8;
            this.radioStandard.TabStop = true;
            this.radioStandard.Text = "standard";
            this.radioStandard.UseVisualStyleBackColor = true;
            this.radioStandard.CheckedChanged += new System.EventHandler(this.RadioCheckChanged);
            // 
            // panelShipping
            // 
            this.panelShipping.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelShipping.Controls.Add(this.labelShippingCost);
            this.panelShipping.Controls.Add(this.labelShippingPrice);
            this.panelShipping.Controls.Add(this.labelShipping);
            this.panelShipping.Controls.Add(this.radioStandard);
            this.panelShipping.Controls.Add(this.radioOvernight);
            this.panelShipping.Controls.Add(this.radioThreeDay);
            this.panelShipping.Location = new System.Drawing.Point(276, 12);
            this.panelShipping.Name = "panelShipping";
            this.panelShipping.Size = new System.Drawing.Size(127, 184);
            this.panelShipping.TabIndex = 9;
            // 
            // labelShippingCost
            // 
            this.labelShippingCost.AutoSize = true;
            this.labelShippingCost.Location = new System.Drawing.Point(3, 125);
            this.labelShippingCost.Name = "labelShippingCost";
            this.labelShippingCost.Size = new System.Drawing.Size(112, 20);
            this.labelShippingCost.TabIndex = 11;
            this.labelShippingCost.Text = "Shipping Cost:";
            // 
            // labelShippingPrice
            // 
            this.labelShippingPrice.AutoSize = true;
            this.labelShippingPrice.Location = new System.Drawing.Point(9, 156);
            this.labelShippingPrice.Name = "labelShippingPrice";
            this.labelShippingPrice.Size = new System.Drawing.Size(18, 20);
            this.labelShippingPrice.TabIndex = 10;
            this.labelShippingPrice.Text = "$";
            // 
            // labelShipping
            // 
            this.labelShipping.AutoSize = true;
            this.labelShipping.Location = new System.Drawing.Point(3, 4);
            this.labelShipping.Name = "labelShipping";
            this.labelShipping.Size = new System.Drawing.Size(75, 20);
            this.labelShipping.TabIndex = 9;
            this.labelShipping.Text = "Shipping:";
            // 
            // BagsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 254);
            this.Controls.Add(this.panelShipping);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxQuantity);
            this.Controls.Add(this.listBoxBags);
            this.Name = "BagsForm";
            this.Text = "BagApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelShipping.ResumeLayout(false);
            this.panelShipping.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxBags;
        private System.Windows.Forms.ComboBox comboBoxQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.RadioButton radioOvernight;
        private System.Windows.Forms.RadioButton radioThreeDay;
        private System.Windows.Forms.RadioButton radioStandard;
        private System.Windows.Forms.Panel panelShipping;
        private System.Windows.Forms.Label labelShippingPrice;
        private System.Windows.Forms.Label labelShipping;
        private System.Windows.Forms.Label labelShippingCost;
    }
}

