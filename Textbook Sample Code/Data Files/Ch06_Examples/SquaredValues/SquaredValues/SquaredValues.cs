/*SquaredValues.cs   Author: Doyle
 * Displays values 1 through 10
 * along with their squares. 
 */
using System;
using System.Windows.Forms;  //Namespace for Windows Forms class

namespace SquaredValues
{
    class SquaredValues
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string result = "\tn       Squared\n";
            while (counter < 10)
            {
                counter++;
                result += " \t"     // Notice the use of += to build
                       + counter    // the string for the MessageBox.
                       + " \t"
                       + Math.Pow(counter, 2)
                       + "\n";

            }
            MessageBox.Show(result, "1 - 10 and their "
                                     + "squares"
                 //, MessageBoxButtons.YesNoCancel    // Uncomment to see buttons and icon
                 //, MessageBoxIcon.Information
                           );
        }
    }
}
