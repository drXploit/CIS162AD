// DataSetExample.cs
// A Windows application is used as the 
// front end to display records retrieved
// from an Access database.
// Values can be changed and the
// database is updated using these changes.

using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DataSetExample
{
    public partial class FrmUpdate : Form
    {
        private OleDbDataAdapter memberDataAdap;
        private DataSet memberDS;
        private OleDbCommandBuilder cBuilder;
        private OleDbConnection dbConn;
        private OleDbCommand dbCmd;
        private string sConnection;
        private string sql;

        public FrmUpdate()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                cBuilder = new OleDbCommandBuilder(memberDataAdap);
                memberDataAdap.Update(memberDS, "memberTable");
            }
            catch (System.Exception exc)
            {
                this.lblMessage.Text = exc.Message;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                // Construct an object of the OleDbConnection
                // class to store the connection string
                // representing the type of data provider
                // (database) and the source (actual db)
                sConnection =
                    "Provider=Microsoft.ACE.OLEDB.12.0;" +
                    "Data Source=member.accdb";
                dbConn = new OleDbConnection(sConnection);

                sql = "SELECT * FROM memberTable ORDER " +
                    "BY LastName ASC, FirstName ASC;";

                // Construct an object of the OleDbCommand
                // class to hold the SQL query. 
                dbCmd = new OleDbCommand();
                dbCmd.CommandText = sql;

                // Tie the OleDbCommand object to the OleDbConnection object
                dbCmd.Connection = dbConn;

                memberDataAdap = new OleDbDataAdapter();
                memberDataAdap.SelectCommand = dbCmd;
                memberDS = new DataSet();
                memberDataAdap.Fill(memberDS, "memberTable");
                dataGridView1.DataSource = memberDS;
                dataGridView1.DataMember = "memberTable";
            }
            catch (System.Exception exc)
            {
                lblMessage.Text = exc.Message;
            }
        }

 
    }
}
