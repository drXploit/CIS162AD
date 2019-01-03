using System;
using static System.Console;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] anArray = { { 100, 100, 100 } { 100, 100, 100 } };
            int[,] anArray2 = new int[,] { { 100, 100, 100 } { 100, 100, 100 } };
            int[,] anArray3 = new int[2, 3] { { 100, 100, 100 } { 100, 100, 100 } };
            int[] anArray4 = new int[10] { { 100, 100, 100 } { 100, 100, 100 } };
            int[] score = { 86, 66, 76, 92, 95, 88 };
            int total = 0;
            for (int i = score.Length - 1; i > -1; i--)
            {
                total += score[i];
                WriteLine(total);
                ReadKey();
            }
        }
    }
}
