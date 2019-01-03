﻿// Form1.Designer.cs
namespace TaxApp
{
    public partial class Form1
    {
        // Required designer variable.
        private System.ComponentModel.IContainer components = null;

        // Clean up any resources being used.
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        // Required method for Designer support - do not modify
        // the contents of this method with the code editor.
        private void InitializeComponent()
        {
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblTaxPercent = new System.Windows.Forms.Label();
			this.txtPurchase = new System.Windows.Forms.TextBox();
			this.txtTotalDue = new System.Windows.Forms.TextBox();
			this.btnCompute = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(33, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(108, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Total Amount:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(33, 98);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(124, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tax Percentage:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(33, 145);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Total Due:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, 
				System.Drawing.FontStyle.Bold, 
				System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(80, 13);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(144, 24);
			this.label4.TabIndex = 3;
			this.label4.Text = "Tax Calculator";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lblTaxPercent
			// 
			this.lblTaxPercent.AutoSize = true;
			this.lblTaxPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(192)))));
			this.lblTaxPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTaxPercent.ForeColor = System.Drawing.Color.LightBlue;
			this.lblTaxPercent.Location = new System.Drawing.Point(166, 98);
			this.lblTaxPercent.Name = "lblTaxPercent";
			this.lblTaxPercent.Size = new System.Drawing.Size(49, 20);
			this.lblTaxPercent.TabIndex = 4;
			this.lblTaxPercent.Text = "7.5%";
			// 
			// txtPurchase
			// 
			this.txtPurchase.Location = new System.Drawing.Point(162, 50);
			this.txtPurchase.Name = "txtPurchase";
			this.txtPurchase.Size = new System.Drawing.Size(90, 26);
			this.txtPurchase.TabIndex = 1;
			this.txtPurchase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtTotalDue
			// 
			this.txtTotalDue.Enabled = false;
			this.txtTotalDue.Location = new System.Drawing.Point(162, 144);
			this.txtTotalDue.Name = "txtTotalDue";
			this.txtTotalDue.Size = new System.Drawing.Size(90, 26);
			this.txtTotalDue.TabIndex = 6;
			this.txtTotalDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// btnCompute
			// 
			this.btnCompute.BackColor = System.Drawing.Color.Navy;
			this.btnCompute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.btnCompute.ForeColor = System.Drawing.Color.Yellow;
			this.btnCompute.Location = new System.Drawing.Point(86, 183);
			this.btnCompute.Name = "btnCompute";
			this.btnCompute.Size = new System.Drawing.Size(107, 34);
			this.btnCompute.TabIndex = 2;
			this.btnCompute.Text = "Compute";
			this.btnCompute.UseVisualStyleBackColor = false;
			this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
			// 
			// Form1
			// 
			this.AcceptButton = this.btnCompute;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSkyBlue;
			this.ClientSize = new System.Drawing.Size(304, 256);
			this.Controls.Add(this.btnCompute);
			this.Controls.Add(this.txtTotalDue);
			this.Controls.Add(this.txtPurchase);
			this.Controls.Add(this.lblTaxPercent);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "Windows Tax App";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTaxPercent;
        private System.Windows.Forms.TextBox txtPurchase;
        private System.Windows.Forms.TextBox txtTotalDue;
        private System.Windows.Forms.Button btnCompute;
    }
}

