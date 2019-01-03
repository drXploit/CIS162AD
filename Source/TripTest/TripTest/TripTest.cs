using System;
using static System.Console;
/*
 * Jeremy Bowne
 * CIS162AD
 * 
 * Chapter 4
 * Programming Exercise 6
 * 
 * Create a Trip class. Include as data members destination, distance traveled, total cost of gasoline, 
 * and number of gallons consumed. Include appropriate constructors and properties. Add additional methods
 * that calculate miles per gallon and the cost per mile. Override the ToString ( ) method. Create a second
 * class to test your Trip class.
 * 
 * */

namespace TripTest
{
    class TripTest
    {

        static void Main(string[] args)
        {
            // create a new instance of the class I made
            Trip trip = new Trip();

            // set the properties
            trip.DblDistanceTraveled = 35.0;
            trip.DblGasConsumed = 2.0;
            trip.DblGasCost = 3.09;
            trip.DblTankGallons = 10.0;

            // using ToString to write applicable information to the screen
            Write(trip.ToString());
            ReadKey(); 
        }
    }

    /*
    Trip Class
     * */

    class Trip
    {
        // variables
        private string strDestination = "NoWhere, AZ";
        private double dblDistanceTraveled = 0.0;
        private double dblGasCost = 0.0;
        private double dblGasConsumed = 0.0;
        private double dblTankGallons = 10.0;

        // constructors
        public Trip()
        {
            strDestination = "NoWhere, AZ";
            dblDistanceTraveled = 0.0;
            dblGasCost = 0.0;
            dblGasConsumed = 0.0;
        }
        public Trip(string strDest)
        {
            strDestination = strDest;
            dblGasCost = 3.09;
            dblGasConsumed = 0.0;
            dblDistanceTraveled = 0.0;
        }
        public Trip(string strDest, double dblGasPrice)
        {
            strDestination = strDest;
            dblGasCost = dblGasPrice;
            dblGasConsumed = 0.0;
            dblDistanceTraveled = 0.0;
        }
        public Trip(double dblGasPrice)
        {
            strDestination = "NoWhere, AZ";
            dblGasCost = dblGasPrice;
            dblGasConsumed = 0.0;
            dblDistanceTraveled = 0.0;
        }
        public Trip(string strDest, double dblGasPrice, double dblDistTraveled)
        {
            strDestination = strDest;
            dblGasCost = dblGasPrice;
            dblDistanceTraveled = dblDistTraveled;
            dblGasConsumed = 0.0;
        }

        // properties
        public string StrDestination
        {
            get
            {
                return strDestination;
            }
            set
            {
                strDestination = value;
            }
        }
        public double DblDistanceTraveled
        {
            get
            {
                return dblDistanceTraveled;
            }
            set
            {
                dblDistanceTraveled = value;
            }
        }
        public double DblGasCost
        {
            get
            {
                return dblGasCost;
            }
            set
            {
                dblGasCost = value;
            }
        }
        public double DblGasConsumed
        {
            get
            {
                return dblGasConsumed;
            }
            set
            {
                dblGasConsumed = value;
            }
        }
        public double DblTankGallons
        {
            get
            {
                return dblTankGallons;
            }
            set
            {
                dblTankGallons = value;
            }
        }

        //methods
        public double getMilesPerGallon()
        {
            return dblDistanceTraveled / dblGasConsumed;
        }
        public double getCostPerMile()
        {
            return dblGasCost / getMilesPerGallon();
        }

        // ToString override
        public override string ToString()
        {
            return "Destination: " + strDestination + "\n" +
                "Distance Travelled: " + dblDistanceTraveled + "\n" +
                "Gasoline Cost Per Gallon: $" + dblGasCost + "\n" +
                "Gasoline Consumed: " + dblGasConsumed + "\n" +
                "Miles Per Gallon: " + getMilesPerGallon() + "\n" +
                "Cost Per Mile: $" + getCostPerMile() + "\n";
        }
    }

}
