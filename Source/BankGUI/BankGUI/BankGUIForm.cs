/*
	Author: Jeremy Bowne
	Professor: Bill Stewart
	Course: CIS162AD
	Date: 12-08-2018
	Assignment: Chapter 14
	Exercise: 1
    Filename: BankGUIForm.cs
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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BankGUI
{
    public partial class BankForm : Form
    {
        // private variables
        private OleDbConnection dbConn;
        private OleDbCommand dbCmd;
        private OleDbDataReader dbReader;
        private BankAccount aBankAccount;
        private string sConnection;
        private string sql;

        // constructor
        public BankForm()
        {
            InitializeComponent();
        }

        // btnLoad_Click
        // loads the database file into the 
        private void btnLoad_Click(object sender, EventArgs e)
        {
            // clear the listbox
            membersBox.Items.Clear();

            try
            {
                // construction of the OLE provider was difficult and required me to install an ms office addon
                // from https://www.microsoft.com/en-us/download/confirmation.aspx?id=23734 which worried me because
                // of the old version, plus it's 32 bit and so my form looks strange after the db is loaded
                // but it worked
                sConnection =
                    "Provider=Microsoft.ACE.OLEDB.12.0;" +
                    "Data Source=BankAccount.accdb";
                dbConn = new OleDbConnection(sConnection);
                dbConn.Open();

                // select all records but sort by lastname, then firstname
                sql = "SELECT * FROM BankAccount ORDER " +
                      "BY LastName ASC, FirstName ASC;";

                dbCmd = new OleDbCommand();
                dbCmd.CommandText = sql;

                // link objects

                dbCmd.Connection = dbConn;

                // get the dbReader object prepared 
                dbReader = dbCmd.ExecuteReader();

                // loop through each row
                while (dbReader.Read())
                {
                    aBankAccount = new BankAccount
                            (dbReader["AccountNumber"].ToString(),
                             dbReader["FirstName"].ToString(),
                             dbReader["LastName"].ToString(),
                             dbReader["CurrentBalance"].ToString());

                    // when adding an item to the listbox, use the 
                    // overridden ToString method from the
                    // BankAccount class
                    this.membersBox.Items.Add(aBankAccount);
                }

                // close the reader, and then the connection
                dbReader.Close();
                dbConn.Close();
            }
            catch (System.Exception exc)
            {
                // display an error message if something goes wrong
                this.errorLabel.Text = exc.Message;
            }

        }

        // exit the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
