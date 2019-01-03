using System;
/*
 * Jeremy Bowne
 * AverageLoop.cs
 * CIS162AD
 * 
 * */
namespace AverageLoop
{
    class AverageLoop
    {
        static void Main(string[] args)
        {
            // variables
            string scores = "0";
            int numbers = 0;
            double average = 0;
            double total = 0;
            int loops = 0;

            // scores is the sentinel token
            while (scores != "-99")
            {
                // gather user input
                Console.WriteLine("Enter number for average 1-100, -99 to quit: ");
                scores = Console.ReadLine();

                // make sure it's an integer, if it isnt try again
                while ((int.TryParse(scores, out numbers) == false))
                {
                    //validation failed, re-prompt user for better number
                   Console.WriteLine("Bad value, try again");
                   scores = Console.ReadLine();
                }
                
                // add to total and increment average except with sentinel token
                if (numbers != -99)
                {
                    total += numbers;
                    loops++;
                }
                //Console.WriteLine("Total: " + total + " -- Loops: " + loops);
            }
            // calculate the average
            average = total / loops;
            Console.WriteLine("Average: " + average);

            // Show letter grade
            if (average < 60)
                Console.WriteLine("Letter grade: F");
            else if (average < 70)
                Console.WriteLine("Letter grade: D");
            else if (average < 80)
                Console.WriteLine("Letter grade: C");
            else if (average < 90)
                Console.WriteLine("Letter grade: B");
            else
                Console.WriteLine("Letter grade: A");

            // pause to view output
            Console.ReadKey();
        }
    }
}
