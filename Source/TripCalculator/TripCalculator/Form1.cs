using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TripCalculator
{

    public partial class TripCalc : Form
    {
        /*
         * TripCalc is the constructor
         * */
        public TripCalc()
        {
            InitializeComponent();
        }


        /*
         * CalculateButton_click method handles all of the math and text manipulation
         * */
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            // local variables
            float gasConsumed = -1;
            float milesTravelled = -1;

            // only calculate if the text boxes actually have text in them
            if ((MilesTravelledTextBox.Text.Length > 0) && (GallonsConsumedTextBox.Text.Length > 0) && (DestinationTextBox.Text.Length > 0))
            {
                // reset the error message if there is one viewable
                ErrorLabel.Text = "";
                while (float.TryParse(MilesTravelledTextBox.Text, out milesTravelled) == false)
                {
                    ErrorLabel.Text = "Miles Travelled value entered must be numeric.";
                    MilesTravelledTextBox.Text = "0.0";
                    MilesTravelledTextBox.Focus();
                }
                while (float.TryParse(GallonsConsumedTextBox.Text, out gasConsumed) == false)
                {
                    ErrorLabel.Text = "Gallons consumed value entered must be numeric.";
                    GallonsConsumedTextBox.Text = "0.0";
                    GallonsConsumedTextBox.Focus();
                }

                // make sure the variables are greater than 0 so we don't divide by 0
                if ((milesTravelled > 0) && (gasConsumed > 0))
                {
                    MPGLabel.Text = milesTravelled / gasConsumed + " mpg";
                    ErrorLabel.Text = "";
                }
                else
                    ErrorLabel.Text = "Please insert only numbers with values greater than 0";
            }
            else // focus on the problem
            {
                ErrorLabel.Text = "Please fill out all of the boxes.";
                if (DestinationTextBox.Text.Length <= 0)
                    DestinationTextBox.Focus();
                else if (MilesTravelledTextBox.Text.Length <= 0)
                    MilesTravelledTextBox.Focus();
                else if (GallonsConsumedLabel.Text.Length <= 0)
                    GallonsConsumedLabel.Focus();
            }
        }
        /*
         * ResetButton_Click method resets the values on the form to their default state
         * */
        private void ResetButton_Click(object sender, EventArgs e)
        {
            ErrorLabel.Text = "";
            MPGLabel.Text = "0 mpg";
            MilesTravelledTextBox.Text = "0.0";
            GallonsConsumedTextBox.Text = "0.0";
            DestinationTextBox.Text = "";
        }
    }
}
