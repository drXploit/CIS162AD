/* AgeIncrementer.cs	Author:	Doyle	
 * Displays age one year from now.
 */

using System;
using static System.Console;
namespace AgeIncrementer
{
    class AgeIncrementer
    {
        static void Main( )
        {
			string aValue;
			int age;
		    Write("Enter your age: ");
            aValue = ReadLine();
            age = int.Parse(aValue);
            WriteLine("Your age next year will be {0}", 
				      ++age);
            ReadKey();
        }
    }
}