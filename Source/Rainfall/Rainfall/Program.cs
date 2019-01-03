/*
 Jeremy Bowne
 CIS162AD
 Chapter 7 Exercise 1

 Write an application that allows the user to input monthly rainfall
 amounts for one year storing the values in an array. Create a second
 array that holds the names of the month. Produce a report showing the
 month name along with the rainfall amount and its variance from the
 mean. Calculate and display the average rainfall for the year.

 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Rainfall
{
    class Program
    {
        // global variable for months
        private static string [] arrayMonths = new string[12] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

        // entry point
        static void Main(string[] args)
        {
            // local variables
            double [] arrayInches = new double[12];
            string strValue;
            double dblAverage = 0.0;

            // gather information from the user
            WriteLine("Please enter the rainfall in inches for each month of the year.");
            for (int i = 0; i < arrayInches.Length; i++)
            {
                Write(arrayMonths[i] + ": ");

                // read user input
                strValue = ReadLine();
                if (double.TryParse(strValue, out arrayInches[i]) == false)
                {
                    //let the user know they entered invalid input
                    WriteLine("Invalid data entered - please try again");
                    // decrement i so that it'll ask for that same month again since an error occured parsing into a double
                    i--;
                }
            }
            // retrieve the average rainfall
            dblAverage = getAverage(arrayInches);
            
            // display the output
            DisplayOutput(arrayInches, dblAverage);
            WriteLine("-------------");
            WriteLine("Average rainfall for the year: " + dblAverage);
            ReadKey();
        }
        
        // method calculate the average from the array that's passed 
        public static double getAverage(double [] arrayTemp)
        {
            double dblTemp = 0.0;
            foreach (double dblInch in arrayTemp)
                dblTemp += dblInch;
            dblTemp = dblTemp / arrayTemp.Length;
            return dblTemp;
        }

        // method to display the output to the user
        public static void DisplayOutput(double[] arrayTemp, double dblTemp)
        {
            WriteLine("{0,-25} {1} {2, -35}", "Month:", "Inches", "Variance");
            for (int i = 0; i < arrayTemp.Length; i++)
            {
                double dblVariance = arrayTemp[i] - dblTemp;
                WriteLine("{0,-25} {1}\"\t {2}", arrayMonths[i], arrayTemp[i], dblVariance );
            }
        }
    }
}
