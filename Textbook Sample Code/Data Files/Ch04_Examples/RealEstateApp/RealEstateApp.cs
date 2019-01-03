/* RealEstateApp.cs 	Author:	Doyle	
 * This class constructs an
 * object of the RealEstateInvestment
 * class. It test several properties and
 * methods of the class.
 * A static method is used in
 * the application class to
 * input expenses.   
 */

using System;
using static System.Console;

namespace RealEstateApp
{
    class RealEstateApp
    {
        static void Main( )
        {
            const double RENTAL_AMOUNT = 1000.00;

            RealEstateInvestment invest1 = new
                RealEstateInvestment(2004, 150000,
                                    "65th Street");
            WriteLine("\tFirst Investment");
            invest1.MonthlyExpense = GetExpenses();
            invest1.IncomeFromRent = RENTAL_AMOUNT;
            WriteLine();
            WriteLine("Property Location: {0}",
                                invest1.StreetAddress);
            WriteLine("Earnings For Month: {0:C}",
                        invest1.DetermineMonthlyEarnings());

            RealEstateInvestment invest2 = new
                RealEstateInvestment("72 Westchester Dr.", 229000);

            invest2.MonthlyExpense = 900;
            invest2.IncomeFromRent = 1500.00;
            WriteLine("\n\n\tSecond Investment");
            WriteLine(invest2);
            ReadKey();
        }


        static double GetExpenses()
        {
            double insurance;
            double taxes;
            double utilities;
            string inValue;

            Write("Yearly Insurance: ");
            inValue = ReadLine();
            insurance = double.Parse(inValue);
            Write("Yearly Tax: ");
            inValue = ReadLine();
            taxes = double.Parse(inValue);
            Write("Monthly Utilities: ");
            inValue = ReadLine();
            utilities = double.Parse(inValue);
            return (insurance / 12 + taxes / 12
                + utilities);
        }
    }
}
