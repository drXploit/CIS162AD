/*StateControlled.cs    Author: Doyle
 * One or more random integers are
 * printed. User is prompted to
 * determine when to stop printing
 * random values. 
*/

using System;
using static System.Console;
using System.Windows.Forms;

namespace StateControlled
{
    class StateControlled
    {
        static void Main( )
        {
            bool moreData = true;
            Random numb = new Random();
            int s = numb.Next(100);

            while (moreData)
            {
                Write("{0}  ", s);
                if (MessageBox.Show("Do you want another number?",
                    "State Controlled Loop",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question)
                    == DialogResult.No)
                {
                    moreData = false;
                }
                else
                {
                    s = numb.Next(100);
                }
            }
        }
    }
}