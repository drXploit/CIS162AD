using System;
using static System.Console;
/*
 * Jeremy Bowne
 * AverageLoopExceptions.cs
 * CIS162AD
 * 
 * I modified MultipleCatches for scoring grades
 * I changed it so that it loops multiple times
 * and uses "q" to quit.
 * It also shows letter grades and uses the 
 * finally block to reset the score.
 * 
 * */

// Demonstrates the use of multiple catch clauses and a finally clause.

namespace AverageLoopExceptions
{
    class AverageLoop
    {
        static void Main(string[] args)
        {
            // local variables
            int[] examScore;
            int totalScores = 0;
            int countOfScores = 0;
            string inValue;
            double averageTestScore;
            // try block
            while (true)
            { 
                try
                {
                    Write("How many scores will you enter (q to quit)? ");

                    // read the input value
                    inValue = ReadLine();
                    
                    // exit if token is q
                    if (inValue == "q")
                        Environment.Exit(0);
                    countOfScores = int.Parse(inValue);
                    examScore = new int[countOfScores];

                    // get the scores
                    for (int i = 0; i < countOfScores; i++)
                    {
                        Write("Enter score {0}: ", i + 1);
                        inValue = ReadLine();
                        examScore[i] = int.Parse(inValue);
                        totalScores += examScore[i];
                    }

                    // calculate average
                    averageTestScore = totalScores / countOfScores;

                    Console.WriteLine("Average: " + averageTestScore);

                    // Show letter grade
                    if (averageTestScore < 60)
                        Console.WriteLine("Letter grade: F");
                    else if (averageTestScore < 70)
                        Console.WriteLine("Letter grade: D");
                    else if (averageTestScore < 80)
                        Console.WriteLine("Letter grade: C");
                    else if (averageTestScore < 90)
                        Console.WriteLine("Letter grade: B");
                    else
                        Console.WriteLine("Letter grade: A");
                }

                // catch blocks
                catch (FormatException e)
                {
                    Error.WriteLine("Problem with one of " +
                        "the operands - Cannot compute average!");
                    Error.WriteLine("Exception type: {0}",
                                                      e.Message);
                }

                catch (DivideByZeroException e)
                {
                    Error.WriteLine("No scores were " +
                        "entered - Cannot compute average!");
                    Error.WriteLine("Exception type: {0}",
                                                      e.Message);
                }
                catch (ArithmeticException e)
                {
                    Error.WriteLine("Error in your " +
                        "arithmetic or casting.");
                    Error.WriteLine("Exception type: {0}",
                                                      e.Message);
                }
                catch (Exception e)
                {
                    Error.WriteLine("Any other problem" +
                        "Cannot compute average!");
                    Error.WriteLine("Exception type: {0}",
                                                      e.Message);
                }
                // finally block resets the total scores
                finally
                {
                    totalScores = 0;
                }
                ReadKey();
            }
        }
    }
}
