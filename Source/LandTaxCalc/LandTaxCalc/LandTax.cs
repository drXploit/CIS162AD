using System;
using static System.Console;

/* LandTax.cs
 *  Jeremy Bowne
 *  CIS162AD
 *  09-08-2018
 *  Chapter 3 - Exercise 10
 *
 */
/*
 * Write an application that helps landowners determine what their prop-
 * erty tax will be for the current year. Taxes are based on the property's 
 * assessed value and the annual millage rate. The established millage rate
 * for the current year is $10.03 per $1000 value. Homeowners are given
 * a $25,000 exemption, which means they may subtract $25,000 from the
 * assessed value prior to calculating the taxes. Enable users to enter the 
 * property address and the prior year's assessed value. The township has
 * decided to increase all properties' assessed value 2.7% for the current
 * year to add additional monies to the school budget line and the proposed
 * taxes for the current year. Provide another method that displays the
 * formatted values.
 * */

namespace LandTaxCalc
{
    // LandTax class
    class LandTax
    {
        // global variables in this case are constants
        const double MILLAGERATE = 10.03;
        const double MILLAGEPER = 1000;
        const double BUDGETINCREASE = 0.027;

        /* Main method
         * Entry point of application pipeline
         * */
        static void Main(string[] args)
        {
            // declaration of local variables
            bool exemptionBool = false;
            int assessedValueInteger = 0;
            double totalTax = 0.00;
            DisplayBanner();
            string priorAddress = "12345 West Elm Street";

            priorAddress = GetAddress();

            assessedValueInteger = GetAssessment();

            // a personal addition to check whether the assessed value is worth calculating (dont want a negative number in the end)
            if (assessedValueInteger > 25000)
            {
                exemptionBool = GetExemption();
                if (exemptionBool == true)
                {
                    assessedValueInteger = assessedValueInteger - 25000;
                }
            }
            else
            {
                WriteLine("Property value is too small for exemption (must be greater than 25,000)");
                Environment.Exit(1);
            }
            
            // calculate the total tax
            totalTax = GetTotalTax(assessedValueInteger, BUDGETINCREASE);

            // clear the screen when user presses a key
            WriteLine("Press any key for calculations to be displayed...");
            ReadKey();
            Clear();

            DisplayOutput(priorAddress, assessedValueInteger, exemptionBool, totalTax);

            ReadKey();
        }

        /* GetAddress method
         * Asks user for the address
         * Returns a string
         * */
         static string GetAddress()
        {
            string inputString;
            Write("Enter address for last years taxes: ");
            inputString = ReadLine();
            return inputString;
        }

        /* DisplayOutput method
         * displays all of the calculated information
         * Returns void
         * */
        static void DisplayOutput(string addressString, int assessedValue, bool exBool, double total)
        {
            WriteLine("---------------------");
            WriteLine("Address: \t\t\t\t\t\t" + addressString);
            WriteLine("$25000 exemption used? \t\t\t\t\t" + exBool);
            WriteLine("Total value assessed before school budget applied: \t$" + assessedValue);
            WriteLine("Total value assessed after school budget applied: \t$" + (assessedValue + (assessedValue * BUDGETINCREASE )));
            WriteLine("Total tax for the year: \t\t\t\t$" + total);
            WriteLine();
            WriteLine("Press any key to exit...");
            ReadKey();
        }

        /* GetTotalTax method
         * Calculates the total tax based on business rules
         * Returns a double with calculation
         * */
        static double GetTotalTax(int assessedValueInteger, double valueIncrease)
        {
            double tmp = assessedValueInteger + (assessedValueInteger * valueIncrease);
            double ret = (tmp / MILLAGEPER) * MILLAGERATE;
            return ret;
        }

        /* DisplayBanner
         * Displays banner for application start
         * Return is void
         * */
        static void DisplayBanner()
        {
            Clear();
            WriteLine("Property Tax Calculator");
            WriteLine("Written by Jeremy Bowne for CIS162AD");
            WriteLine();
        }

        /* GetAssessment method
         * Asks the user for the property value
         * Returns an integer containing the value
         * */
        static int GetAssessment()
        {
            string inputString;
            int inputInteger;
            Write("\nEnter property value: $");
            inputString = ReadLine();
            inputInteger = int.Parse(inputString);
            return inputInteger;
        }

        /*
         * GetExemption method
         * Asks whether user wants to use the 25000 property
         * value exemption (takes off 25000 of value)
         * Returns a boolean of true or false
         * */
        static bool GetExemption()
        {
            string inputString;
            Write("\nUse $25000 property exemption? (y/n) ");
            inputString = ReadLine();
            char inputChar = char.Parse(inputString);
            inputChar = char.ToUpper(inputChar);
            if (inputChar == 'Y') return true;
            else if (inputChar == 'N') return false;
            else return false;
        }

    }
}
