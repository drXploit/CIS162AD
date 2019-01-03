﻿/*
	Author: Jeremy Bowne
	Professor: Bill Stewart
	Course: CIS162AD
	Date: 12-08-2018
	Assignment: Chapter 14
	Exercise: 1
    Filename: BankAccount.cs
*/
/*
	Create a small BankAccount database with one table storing account details. 
	The Account table should have fields for account number, customer last and first names, and current balance. 
	The type of database (SQL Server or Access) will be determined by your instructor. 
	Populate the table with 8–10 records. 
	Design and create a user interface that will enable you to display all customer records.

	Doyle, Barbara. C# Programming: From Problem Analysis to Program Design (Page 990). Cengage Learning. Kindle Edition. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankGUI
{
    class BankAccount
    {
        private string accountNumber;
        private string firstName;
        private string lastName;
        private string currentBalance;

        // Constructors
        public BankAccount()
        {

        }

        public BankAccount(string accnumber, string fname, string lname, string currbalance)
        {
            accountNumber = accnumber;
            firstName = fname;
            lastName = lname;
            currentBalance = currbalance;
        }

        // Properties
        public string FirstName
        {
            get
            {
                return firstName;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
        }

        public string AccountNumber
        {
            get
            {
                return accountNumber;
            }
        }

        public string CurrentBalance
        {
            get
            {
                return currentBalance;
            }
        }

        public override string ToString()
        {
            return firstName + " " + lastName + " - (" + accountNumber + ") - $" + currentBalance;
        }

    }
}
