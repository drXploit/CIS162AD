﻿using System;
using System.Windows.Forms;

namespace ConfigToolsExampleDetailView
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

        private void FrmConfigTools_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDataBaseDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.studentDataBaseDataSet.Student);

        }
    }
}