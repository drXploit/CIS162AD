// Form1.cs

using System;

using System.Windows.Forms;

namespace TaxApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            string inValue;
            double purchaseAmt,
                       percent,
                       ans;

            while (double.TryParse(txtPurchase.Text, out purchaseAmt) == false)
            {
                MessageBox.Show("Value entered must be numeric");
                txtPurchase.Text = "0.0";
                txtPurchase.Focus();
            }

            inValue = lblTaxPercent.Text;
            inValue = inValue.Remove(inValue.Length - 1, 1);
            percent = double.Parse(inValue) / 100;

            //Three previous lines could be replaced with the following
            //percent =  (double.Parse(label5.Text.Remove(label5.Text.Length-1,1))) / 100;      

            ans = (purchaseAmt * percent) + purchaseAmt;
            txtTotalDue.Text = string.Format("{0:C}", ans);
        }

    }
}
