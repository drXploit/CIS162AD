/*
 *      Author:     Jeremy Bowne
 *      Class:      CIS162AD
 *      Date:       11-02-2018
 *      Exercise:   Chapter 10 Exercise 7
 *                  Extension of Chapter 10 Exercise 6
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BagsApp
{
    public partial class BagsForm : Form
    {
        // global variables with initial values preset
        private string[] strBags = { "full decorative--$50.00", "beaded--$45.00", "pirate design--$40.00", "fringe--$25.00", "leather--$80.00", "plain--$20.00" };
        private double dblSubTotal = 0.00;
        private double dblGrandTotal = 0.00;
        private double dblShipping = 0.00;
        private double dblShippingRate = 0.00;
        private double dblPrice = 0.00;
        private double dblQuantity = 0.00;

        /*
         * BagsForm() - constructor which calls the component initialization routine
         */
        public BagsForm()
        {
            InitializeComponent();
        }

        /*
         *  Form1_Load() - Event for when the GUI interface has loaded which enters predefined values into various GUI components and setting certain initial values
         */
        private void Form1_Load(object sender, EventArgs e)
        {
            // add the bag names from the array into the ListBox
            for (int i=0;i<strBags.Length;i++)
                listBoxBags.Items.Add(strBags[i]);

            // add the numbers 1 through 10 into the quantity box
            for (int i = 1; i <= 10; i++)
                comboBoxQuantity.Items.Add(i);

            // set the initial quantity to the first index, 0
            comboBoxQuantity.SelectedIndex = 0;

            // set the standard shipping radio button as checked by default
            radioStandard.Checked = true;
        }

        /*
         *  QuantityBoxChanged() - Event for updating globals when quantity text box is changed
         */
        private void QuantityBoxChanged(object sender, EventArgs e)
        {
            if (ValidInput())
                UpdateGlobals();
        }

        /*
         *  ListBoxChanged() - Event for updating globals when list box is changed
         */
        private void ListBoxChanged(object sender, EventArgs e)
        {
            if (ValidInput())
                UpdateGlobals();
        }

        /*
         *  RadioCheckChanged() - Event for updating globals when radio button is changed
         */
        private void RadioCheckChanged(object sender, EventArgs e)
        {
            if (ValidInput())
                UpdateGlobals();
        }

        /*
         * GetShippingRate() - returns the shipping rate decimal based on business rules
         */
        private double GetShippingRate()
        {
            if (radioOvernight.Checked)
                return 0.10;
            else if (radioThreeDay.Checked)
                return 0.07;
            else    //default aka (radioStandard.Checked)
                return 0.05;
        }

        /*
         * ValidInput() - returns true if all of the values selected or entered are valid
         *              - Also shows warnings in the MessageLabel text area dependant on whether something went wrong or not
         */
        private bool ValidInput()
        {
            if (double.TryParse(comboBoxQuantity.Text, out dblQuantity))
            {
                if (listBoxBags.SelectedIndex < 0)
                {
                    MessageLabel.Text = "Make a product selection.";
                    return false;
                }
                else if (dblQuantity <= 0.00)
                {
                    MessageLabel.Text = "Make a valid quantity selection greater than zero.";
                    return false;
                }
                else
                    return true;
            }
            else
            {
                MessageLabel.Text = "Please enter a valid quantity.";
                return false;
            }
        }

        /*
         * UpdateGlobals() - Update all of the global variables
         */

        private void UpdateGlobals()
        {
            // local variables
            string strSelectedString;

            // set global variables that reset with each iteration
            dblPrice = 0.00;
            dblQuantity = double.Parse(comboBoxQuantity.Text);
            
            // gather the rate from selected radiobutton
            dblShippingRate = GetShippingRate();

            // get the product string
            strSelectedString = listBoxBags.SelectedItem.ToString();

            // extract the price directly from the product string by using string method
            dblPrice = double.Parse(strSelectedString.Substring(strSelectedString.LastIndexOf('$') + 1));

            // calculate amounts
            dblSubTotal = dblQuantity * dblPrice;
            dblShipping = dblSubTotal * dblShippingRate;
            dblGrandTotal = dblSubTotal + dblShipping;

            // update the shipping label
            labelShippingPrice.Text = "$" + dblShipping.ToString("N2");

            // update the MessageLabel
            MessageLabel.Text = dblQuantity.ToString("0") + "x " + listBoxBags.SelectedItem.ToString() +
                " bag" + "\nSubtotal: $" + dblSubTotal.ToString("N2") + "\nShipping: $" +
                dblShipping.ToString("N2") + "\nGrand Total: $" + dblGrandTotal.ToString("N2");
        }

        /*
         * SubmitButton_Click - shows a MessageBox with the order information
        */
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (ValidInput())
            {
                UpdateGlobals();

                MessageBox.Show(dblQuantity.ToString("0") + "x " + listBoxBags.SelectedItem.ToString() +
                " bag" + "\nSubtotal: $" + dblSubTotal.ToString("N2") + "\nShipping: $" +
                dblShipping.ToString("N2") + "\nGrand Total: $" + dblGrandTotal.ToString("N2"), "Order");
            }
        }

        /*
        * ClearButton_click() - puts form back in initial state by clearing all values   
        */

        private void ClearButton_Click(object sender, EventArgs e)
        {
            
            listBoxBags.ClearSelected();
            comboBoxQuantity.SelectedIndex = 0;
            radioStandard.Checked = true;
            MessageLabel.Text = "";
            labelShippingPrice.Text = "$";
            dblSubTotal = 0.00;
            dblShipping = 0.00;
            dblShippingRate = 0.05;
            dblGrandTotal = 0.00;
        }
    }
}
