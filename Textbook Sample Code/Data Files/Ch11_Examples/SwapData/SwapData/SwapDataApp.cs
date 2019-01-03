using System;
using static System.Console;

namespace SwapData
{
    class SwapDataApp
    {
        static void Main(string[] args)
        {
            TestSwap();
            ReadKey();
        }

        public static void SwapData<T>(ref T first, ref T second)
        {
            T temp;
            temp = first;
            first = second;
            second = temp;
        }

        public static void TestSwap()
        {
            string firstValue = "Programming";
            string secondValue = "C#";

            int aValue = 75;
            int bValue = 90;

            SwapData<string>(ref firstValue, ref secondValue);
            WriteLine(firstValue + " " + secondValue);

            SwapData<int>(ref aValue, ref bValue);
            WriteLine(aValue + " " + bValue);
        }
    }
}
