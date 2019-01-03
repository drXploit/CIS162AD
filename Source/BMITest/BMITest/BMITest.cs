using System;
using static System.Console;
/* 
 Jeremy Bowne
 CIS162AD
 BMITest
     */

namespace BMITest
{
    class BMITest
    {
        static void Main(string[] args)
        {
            bool loop = true;
            string key = " ";
            bool metric = false;
            double dblBMI = 0.00;
            string strBMI = "";
            WriteLine("Choose scale, Imperial or Metric? (I/M) ");
            do
            {
                key = ReadLine();
                switch(key)
                {
                    case "M":
                    case "m":
                        metric = true;
                        loop = false;
                        break;
                    case "I":
                    case "i":
                        metric = false;
                        loop = false;
                        break;
                }
            } while (loop);
            if (metric)
            {
                String strValue;
                double dblValue = 0.00;
                MetricBMI bmi = new MetricBMI();

                WriteLine("Enter Height in Centimeters: ");
                strValue = ReadLine();
                if (!double.TryParse(strValue, out dblValue))
                    WriteLine("Invalid height value!");
                else
                    bmi.Height = dblValue;

                WriteLine("Enter Weight in Kilograms: ");
                strValue = ReadLine();
                if (!double.TryParse(strValue, out dblValue))
                    WriteLine("Invalid weight value!");
                else
                    bmi.Weight = dblValue;

                WriteLine("Body Mass Index: " + bmi.BMI);
                dblBMI = bmi.BMI;

            }
            else
            {
                String strValue;
                double dblValue = 0.00;

                ImperialBMI bmi = new ImperialBMI();

                WriteLine("Enter Height in Inches: ");
                strValue = ReadLine();
                if (!double.TryParse(strValue, out dblValue))
                    WriteLine("Invalid height value!");
                else
                    bmi.Height = dblValue;


                WriteLine("Enter Weight in Pounds: ");
                strValue = ReadLine();
                if (!double.TryParse(strValue, out dblValue))
                    WriteLine("Invalid weight value!");
                else
                    bmi.Weight = dblValue;

                WriteLine("Body Mass Index: " + bmi.BMI);
                dblBMI = bmi.BMI;
            }
            if (dblBMI < 18.5) strBMI = "underweight";
            else if (dblBMI >= 18.5 && dblBMI < 25) strBMI = "normal";
            else if (dblBMI >= 25 && dblBMI < 30) strBMI = "overweight";
            else if (dblBMI > 30) strBMI = "obese";
            WriteLine("Body Mass Index is considered " + strBMI);

            ReadKey();
        }

    }
    class ImperialBMI
    {
        private double dblHeight;
        private double dblWeight;

        public ImperialBMI()
        {
            dblHeight = 0;
            dblWeight = 0;
        }
        public double BMI
        {
            get
            {
                return (dblWeight / dblHeight / dblHeight) * 703;
            }
        }
        public double Height
        {
            get
            {
                return dblHeight;
            }
            set
            {
                dblHeight = value;
            }
        }
        public double Weight
        {
            get
            {
                return dblWeight;
            }
            set
            {
                dblWeight = value;
            }
        }
    }
    class MetricBMI
    {
        private double dblHeight;
        private double dblWeight;

        public MetricBMI()
        {
            dblHeight = 0;
            dblWeight = 0;
        }
        public double BMI
        {
            get
            {
                return (dblWeight / dblHeight / dblHeight) * 10000;
            }
        }
        public double Height
        {
            get
            {
                return dblHeight;
            }
            set
            {
                dblHeight = value;
            }
        }
        public double Weight
        {
            get
            {
                return dblWeight;
            }
            set
            {
                dblWeight = value;
            }
        }
    }

}
