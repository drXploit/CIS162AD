/* CarpetExampleWithClassMethods.cs		
 * Author:	 Doyle	 
 * Calculates the total cost of carpet. User
 * inputs room dimensions and carpet price.
 */
using System;
using static System.Console;

namespace CarpetExampleWithClassMethods
{
    class CarpetExampleWithClassMethods
    {
        static void Main( )
        {
            double roomWidth;
            double roomLength;
            double pricePerSquareYard;
            double noOfSquareYards;

            DisplayInstructions();

            // Call GetDimension( ) to get the length
            roomLength = GetDimension("Length");

            // Call GetDimension( ) again to get the width
            roomWidth = GetDimension("Width");
            pricePerSquareYard = GetPrice();
            noOfSquareYards =
            DetermineSquareYards(roomWidth, roomLength);
            DisplayResults(noOfSquareYards, pricePerSquareYard);
            ReadKey();
        }

        static void DisplayInstructions()
        {
            WriteLine("This program will " +
                      "determine how much " +
                      "carpet to purchase.");
            WriteLine();
            WriteLine("You will be asked to enter " +
                      "the size of the room ");
            WriteLine("and the price of the carpet, " +
                      "in price per square yds.");
            WriteLine();
        }

        static double GetDimension(string side)
        {
            string inputValue;  // local variables
            int feet,           // needed only by this 
                inches;         // method

            Write("Enter the {0} in feet: ", side);
            inputValue = ReadLine();
            feet = int.Parse(inputValue);
            Write("Enter the {0} in inches: ",
                            side);
            inputValue = ReadLine();
            inches = int.Parse(inputValue);

            // Note: cast required to avoid int division
            return (feet + (double)inches / 12);
        }

        static double GetPrice()
        {
            string inputValue;  // local variables
            double price;

            Write("Enter the price per Square Yard: ");
            inputValue =  ReadLine();
            price = double.Parse(inputValue);
            return price;
        }

        static double DetermineSquareYards(double width,
                                            double length)
        {
            const int SQ_FT_PER_SQ_YARD = 9;

            double noOfSquareYards;
            noOfSquareYards = length * width
                                / SQ_FT_PER_SQ_YARD;
            return noOfSquareYards;
        }

        static double DeterminePrice(double squareYards,
                                     double pricePerSquareYard)
        {
            return (pricePerSquareYard * squareYards);
        }

        static void DisplayResults(double squareYards,
                                    double pricePerSquareYard)
        {
            WriteLine();
            Write("Square Yards needed: ");
            WriteLine("{0:N2}", squareYards);
            Write("Total Cost at {0:C} ",
                   pricePerSquareYard);
            WriteLine(" per Square Yard: {0:C}",
                    DeterminePrice(squareYards, pricePerSquareYard));
        }
    }
}
