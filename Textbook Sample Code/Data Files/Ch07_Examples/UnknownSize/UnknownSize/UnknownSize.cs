/* UnknownSize.cs   Author: Doyle
 * Any number of scores, up to 100, can be entered. 
 */

using System;
using static System.Console;

namespace UnknownSize
{
    class UnknownSize
    {
        static void Main( )
        {
            int[] score = new int[100];
            string inValue;

            int scoreCnt = 0;
            int total = 0;
            double avg;
            Write("Enter Score{0}: ((-99 to exit)) ", scoreCnt + 1);
            inValue = ReadLine();

            while (inValue != "-99")
            {
                if (int.TryParse(inValue, out score[scoreCnt]) == false)
                    WriteLine("Invalid data - 0 stored in array element");
                ++scoreCnt;
                Write("Enter Score{0}: ((-99 to exit)) ", scoreCnt + 1);
                inValue = ReadLine();
            }

            WriteLine("The number of scores: "
                               + scoreCnt);
            foreach (int val in score)
            {
                    total += val;
            }
            WriteLine("Total: " + total);
            avg = (double)total / scoreCnt;
            WriteLine("Average: " + avg.ToString("F0"));
            ReadKey();
        }
    }
}
