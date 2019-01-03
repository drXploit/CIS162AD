namespace ReadingMaterialPresentation
{
    partial class Presentation
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
            this.detailsBox = new System.Windows.Forms.TextBox();
            this.hardCopyBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MagazineRadio = new System.Windows.Forms.RadioButton();
            this.BookRadio = new System.Windows.Forms.RadioButton();
            this.OnlineRadio = new System.Windows.Forms.RadioButton();
            this.hardCopyOptionLabel = new System.Windows.Forms.Label();
            this.detailsLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // detailsBox
            // 
            this.detailsBox.Location = new System.Drawing.Point(159, 31);
            this.detailsBox.Multiline = true;
            this.detailsBox.Name = "detailsBox";
            this.detailsBox.ReadOnly = true;
            this.detailsBox.Size = new System.Drawing.Size(366, 112);
            this.detailsBox.TabIndex = 0;
            // 
            // hardCopyBox
            // 
            this.hardCopyBox.Location = new System.Drawing.Point(159, 148);
            this.hardCopyBox.Multiline = true;
            this.hardCopyBox.Name = "hardCopyBox";
            this.hardCopyBox.ReadOnly = true;
            this.hardCopyBox.Size = new System.Drawing.Size(366, 26);
            this.hardCopyBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OnlineRadio);
            this.groupBox1.Controls.Add(this.BookRadio);
            this.groupBox1.Controls.Add(this.MagazineRadio);
            this.groupBox1.Location = new System.Drawing.Point(532, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 116);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source";
            // 
            // MagazineRadio
            // 
            this.MagazineRadio.AutoSize = true;
            this.MagazineRadio.Checked = true;
            this.MagazineRadio.Location = new System.Drawing.Point(25, 26);
            this.MagazineRadio.Name = "MagazineRadio";
            this.MagazineRadio.Size = new System.Drawing.Size(103, 24);
            this.MagazineRadio.TabIndex = 0;
            this.MagazineRadio.TabStop = true;
            this.MagazineRadio.Text = "Magazine";
            this.MagazineRadio.UseVisualStyleBackColor = true;
            this.MagazineRadio.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // BookRadio
            // 
            this.BookRadio.AutoSize = true;
            this.BookRadio.Location = new System.Drawing.Point(25, 56);
            this.BookRadio.Name = "BookRadio";
            this.BookRadio.Size = new System.Drawing.Size(71, 24);
            this.BookRadio.TabIndex = 1;
            this.BookRadio.Text = "Book";
            this.BookRadio.UseVisualStyleBackColor = true;
            this.BookRadio.CheckedChanged += new System.EventHandler(this.BookRadio_CheckedChanged);
            // 
            // OnlineRadio
            // 
            this.OnlineRadio.AutoSize = true;
            this.OnlineRadio.Location = new System.Drawing.Point(25, 86);
            this.OnlineRadio.Name = "OnlineRadio";
            this.OnlineRadio.Size = new System.Drawing.Size(127, 24);
            this.OnlineRadio.TabIndex = 2;
            this.OnlineRadio.Text = "Online Article";
            this.OnlineRadio.UseVisualStyleBackColor = true;
            this.OnlineRadio.CheckedChanged += new System.EventHandler(this.OnlineRadio_CheckedChanged);
            // 
            // hardCopyOptionLabel
            // 
            this.hardCopyOptionLabel.AutoSize = true;
            this.hardCopyOptionLabel.Location = new System.Drawing.Point(14, 151);
            this.hardCopyOptionLabel.Name = "hardCopyOptionLabel";
            this.hardCopyOptionLabel.Size = new System.Drawing.Size(139, 20);
            this.hardCopyOptionLabel.TabIndex = 3;
            this.hardCopyOptionLabel.Text = "Hard Copy Option:";
            // 
            // detailsLabel
            // 
            this.detailsLabel.AutoSize = true;
            this.detailsLabel.Location = new System.Drawing.Point(18, 31);
            this.detailsLabel.Name = "detailsLabel";
            this.detailsLabel.Size = new System.Drawing.Size(62, 20);
            this.detailsLabel.TabIndex = 4;
            this.detailsLabel.Text = "Details:";
            // 
            // Presentation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 199);
            this.Controls.Add(this.detailsLabel);
            this.Controls.Add(this.hardCopyOptionLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.hardCopyBox);
            this.Controls.Add(this.detailsBox);
            this.Name = "Presentation";
            this.Text = "Presentation";
            this.Load += new System.EventHandler(this.PresentationFormLoad);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox detailsBox;
        private System.Windows.Forms.TextBox hardCopyBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton OnlineRadio;
        private System.Windows.Forms.RadioButton BookRadio;
        private System.Windows.Forms.RadioButton MagazineRadio;
        private System.Windows.Forms.Label hardCopyOptionLabel;
        private System.Windows.Forms.Label detailsLabel;
    }
}

