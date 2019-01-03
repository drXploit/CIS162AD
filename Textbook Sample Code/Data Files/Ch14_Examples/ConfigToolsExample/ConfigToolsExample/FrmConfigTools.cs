/*
Review Figure 14-11. A local copy of the database file was stored with
the project. 
If you run the application a second time, 
you may think your application did not do the updates. 
This is because the application always loads the database file 
stored in the project’s directory (not the one stored in the bin\Debug directory).
Updates are made to the one stored in the bin\debug directory.
*/

using System;
using System.Windows.Forms;

namespace ConfigToolsExample
{
    public partial class FrmConfigTools : Form
    {
        public FrmConfigTools()
        {
            InitializeComponent();
        }

        private void studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentDataBaseDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDataBaseDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.studentDataBaseDataSet.Student);

        }
    }
}
