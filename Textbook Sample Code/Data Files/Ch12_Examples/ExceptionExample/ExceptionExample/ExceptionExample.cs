// ExceptionExample.cs   
// Uses a generic catch block to catch any
// type of exception that is thrown.
using System;
using static System.Console;

namespace ExceptionExample
{
    class ExceptionExample
    {
        static void Main(string[] args)
        {
            int[] examScore;
            int totalScores = 0;
            int countOfScores = 0;
            string inValue;
            double averageTestScore;

            try
            {
                Write("How many scores will you enter? ");
                inValue = ReadLine();
                countOfScores = int.Parse(inValue);
                examScore = new int[countOfScores];

                for (int i = 0; i < countOfScores; i++)
                {
                    Write("Enter score {0}: ", i + 1);
                    inValue = ReadLine();
                    examScore[i] = int.Parse(inValue);
                    totalScores += examScore[i];

                }

                ////Commented out lines used with Example 12-3
                //averageTestScore = totalScores / examScore[10];  // threw exception

                averageTestScore = totalScores / countOfScores;
                WriteLine("Average is {0}", averageTestScore);
            }

            catch
            {
                WriteLine("Problem with scores - " +
                    "Cannot compute average");
            }

            ////Example 12-4 replaced the above catch clause with the following
            //catch (Exception e)
            //{
            //    Error.WriteLine("Problem with scores - " +
            //         "Cannot compute average");
            //    Error.WriteLine(e.Message);
            //}
            //ReadKey();


            ////foreach (int val in numbers) ;


        }
    }
}
