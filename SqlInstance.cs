using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class SqlInstance : Form
    {
        //Initialize form and fill out boxes with default parameters
        public SqlInstance()
        {
            InitializeComponent();
            txtServer.Text = SQLQuery.servername;
            txtDB.Text = SQLQuery.dbname;
        }

        //Establish connection event. Tests to make sure connection stirng works for SQL Queries.
        private void butConnect_Click(object sender, EventArgs e)
        {
            SQLQuery.servername = txtServer.Text;
            SQLQuery.dbname = txtDB.Text;
            if (SQLQuery.IsServerConnected() == true)
            {
                this.Hide();
                LogIn logIn = new LogIn();
                logIn.ShowDialog();
                this.Close();
            }
            else if (SQLQuery.IsServerConnected() == false)
                MessageBox.Show("Unable to connect to SQL Database");
        }
    }
}
