using System;
using System.IO;
using static System.Console;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Author: Jeremy Bowne
 * File: AverageFile.cs
 * Class: CIS162AD
 * */

/*
Place 10 to 20 integer values in a text file.
Write a C# program to retrieve the values from the text file. 
Display the number of values processed, the average of the values, 
formatted with two decimal places, and the smallest and largest values. 
Include appropriate exception-handling techniques with your solution. 
Hint: To simplify the problem, the values can each be placed on separate lines in a Notepad file.

Doyle, Barbara.C# Programming: From Problem Analysis to Program Design (Page 904). Cengage Learning. Kindle Edition. 
*/
namespace AverageFile
{
    class AverageFileApp
    {
        /*
         * Main
         * Entry point
         */
        static void Main(string[] args)
        {
            //local variables
            string inValue;
            StreamReader inFile;
            int itemCount = 0;
            int[] intArray = new int[20];


            // make sure the file exists
            if (File.Exists("integervalues.txt"))
            {
                // try clause for error catching
                try
                {
                    // clear the array with zeros
                    for (int i = 0; i < intArray.Length; i++)
                    {
                        intArray[i] = 0;
                    }

                    // open the text file as a data stream
                    inFile = new StreamReader("integervalues.txt");

                    // read each line, until the line is null (end)
                    while ((inValue = inFile.ReadLine()) != null)
                    {
                        // in the cycle, make sure intArray is properly parsed, and also increment the itemCount
                        if (int.TryParse(inValue, out intArray[itemCount++]) == false)
                        {
                            PauseExitMessage("Line " + itemCount + " was not a valid integer.");
                        }
                    }
                }
                // catch clause for array index being too big for what was initialized
                catch (System.IndexOutOfRangeException exc)
                {
                    PauseExitMessage(exc.Message);
                }

                // all other errors go here
                catch (System.IO.IOException exc)
                {
                    PauseExitMessage(exc.Message);
                }
            }
            // file wasn't found, so let the user know
            else
            {
                PauseExitMessage("File unavailable (not found)");
            }

            // Write the stats to the Console
            WriteLine("Values Processed: " + itemCount);

            // Average stat is formatted to two decimal places
            WriteLine("Average: {0:N2}", Average(intArray));

            WriteLine("Smallest integer: " + Smallest(intArray));
            WriteLine("Biggest integer: " + Biggest(intArray));

            // pause to view stats
            WriteLine("Press any key to exit...");
            ReadKey();

        }

        /*
         * PauseExitMessage
         * Shows an error message, pauses, and then exits with an error code.
         * "Never rewrite code that is used over and over"
        */
        public static void PauseExitMessage(string msg)
        {
            Error.WriteLine(msg);
            ReadKey();
            Environment.Exit(1);
        }

        /*
         * Sum
         * Returns the sum of an array
        */
        public static int Sum(params int[] integerArray)
        {
            int result = 0;
            for (int i = 0; i < integerArray.Length; i++)
            {
                result += integerArray[i];
            }
            return result;
        }

        /*
         * Average
         * Returns the average (as a decimal) of an array
        */
        public static decimal Average(params int[] integerArray)
        {
            return (decimal)Sum(integerArray) / integerArray.Length;
        }

        /*
         * Biggest
         * Returns the biggest integer of an array
        */
        public static int Biggest(params int[] integerArray)
        {
            int result = integerArray[0];
            for (int i = 0; i < integerArray.Length; i++)
            {
                if (result < integerArray[i])
                {
                    result = integerArray[i];
                }
            }
            return result;
        }

        /*
         * Smallest
         * Returns the smallest integer of an array
        */
        public static int Smallest(params int[] integerArray)
        {
            int result = integerArray[0];
            for (int i = 0; i < integerArray.Length; i++)
            {
                if (result > integerArray[i])
                {
                    result = integerArray[i];
                }
            }
            return result;
        }
    }
}
