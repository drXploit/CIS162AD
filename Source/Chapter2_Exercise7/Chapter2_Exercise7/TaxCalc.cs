using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

/*
    Chapter 2 - Excercise 7
    Jeremy Bowne
    CIS162AD
 */

namespace Chapter2_Exercise7
{
    class TaxCalc
    {
        static void Main(string[] args)
        {
            // variables
            double originalBill = 88.00;

            const double TIPFIFTEEN = 15.00;
            double fifteenPercent = originalBill * (TIPFIFTEEN / 100);

            const double TIPTWENTY = 20.00;
            double twentyPercent = originalBill * (TIPTWENTY / 100);

            // Write the information to the screen, properly formatted with WriteLine
            WriteLine("Chapter 2 - Excercise 7");
            WriteLine("{0,-7}{1,24:C}", "Bill total: ", originalBill);
            WriteLine();
            WriteLine("{0,-7}{1,18:C}", "Tip @ 15 percent: ", fifteenPercent);
            WriteLine("{0,-7}{1,12:C}", "Total Bill @ 15 percent: ", originalBill + fifteenPercent);
            WriteLine();
            WriteLine("{0,-7}{1,18:C}", "Tip @ 20 percent: ", twentyPercent);
            WriteLine("{0,-7}{1,12:C}", "Total Bill @ 20 percent: ", originalBill + twentyPercent);

            // allow the information to stay on the screen long enough to read
            ReadKey();
        }
    }
}
