/*  ValidInput.cs    Author: Doyle
 *  Demonstrates testing input to 
 *  ensure that integers are entered.
 */
using System;
using static System.Console;

namespace ValidInput
{
    class ValidInput
    {
        static void Main( )
        {
            int integerValue;
            string inStringValue;

            Write("Enter an integer value. ");
            inStringValue = ReadLine();
            while (int.TryParse(inStringValue, out integerValue) == false)
            {
                WriteLine("Invalid input");
                Write("Please re-enter an integer value. ");
                inStringValue = ReadLine();
            }

            WriteLine("Valid value entered: " + integerValue);
            ReadKey();
        }
    }
}
