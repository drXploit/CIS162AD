﻿using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;


namespace LinqArrayExample
{
    class LinqArrayExample
    {
        static void Main(string[] args)
        {
            string[] nameArray = {"Wong", "Abi", "Fredrick", 
                              "Davis", "Howard", "Abbott",
                              "Fang", "Erlanger", "Halcomb", 
                              "George", "King", "Doyle", 
                              "Mitchell", "Ralph", "Barry"};

            IEnumerable<string> queryResult = from aName 
                                       in nameArray
                                              //var queryResult = from aName in nameArray
                                       where aName.Length > 5
                                       orderby aName descending
                                              select aName;

            foreach (string name in queryResult)
                WriteLine(name);
            ReadKey();
        }
    }
}