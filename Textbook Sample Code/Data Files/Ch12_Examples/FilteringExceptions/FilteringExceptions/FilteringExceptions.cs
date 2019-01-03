using System;
using static System.Console;

namespace FilteringExceptions
{
    class FilteringExceptions
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

                averageTestScore = totalScores / countOfScores;
                //averageTestScore = totalScores / (double)countOfScores;  //No exception is thrown

                WriteLine("Average is {0}", averageTestScore);
            }
            catch (FormatException e)
            {
                WriteLine("Problem with one of " +
                          "the operands - Cannot compute average!");
                WriteLine("Exception type: {0}", e.Message);
            }

            //catch (DivideByZeroException e)
            //{
            //    Error.WriteLine("No scores were " +
            //        "entered - Cannot compute average!");
            //    Error.WriteLine("Exception type: {0}",
            //                                      e.Message);
            //}
            //catch (ArithmeticException e)
            //{
            //    Error.WriteLine("Error in your " +
            //        "arithmetic or casting.");
            //    Error.WriteLine("Exception type: {0}",
            //                                      e.Message);
            //}

            catch (Exception e)  if (countOfScores == 0)  // Added to illustrate filtering 
            {
                WriteLine("No scores entered – division by zero avoided!");
            }

            catch (Exception e)
            {
                WriteLine("Any other problem" +
                          "Cannot compute average!");
                WriteLine("Exception type: {0}", e.Message);
            }

            finally
            {
                WriteLine("...\n...\n...\n" +
                    "Terminated Normally!!!");
            }
            ReadKey();
        }
     }
}