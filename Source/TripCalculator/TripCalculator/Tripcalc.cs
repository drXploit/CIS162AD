using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Jeremy Bowne
 * CIS162AD
 * Trip Calculator
 * Chapter 9 Exercise 5
 * 
 * Create a Trip Calculator Windows application that can be used to deter-
 * mine miles per gallon for a given trip. Set the Form object proper-
 * ties of Name, ForeColor, BackColor, Size, Location, Text, and 
 * AcceptButton. The form should contain labels and textboxes to allow
 * the user to input trip destination, Miles traveled, and gallons of gas con-
 * sumed. Right justify the number entries. Left justify the destination 
 * entry. Two buttons should be placed on the form. Center the text on the 
 * button objects. Name all objects used in program statements. When the 
 * user clicks the button that performs the calculations, display on a label
 * the miles per gallon for that trip. The second button should be used to
 * reset or clear all textbox entries.
 * */

namespace TripCalculator
{
    public class TripCalculator : Form
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public TripCalculator()
        {
            Text = "Trip Calculator";
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TripCalc());
        }
    }
}
