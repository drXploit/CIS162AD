/*
	Author: Jeremy Bowne
	Professor: Bill Stewart
	Course: CIS162AD
	Date: 12-08-2018
	Assignment: Chapter 14
	Exercise: 1
    Filename: BankGUI.cs
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankGUI
{
    static class BankGUI
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BankForm());
        }
    }
}
