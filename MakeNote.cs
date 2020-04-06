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
    public partial class MakeNote : Form
    {
        int dID;
        //Initializes Make Medical History Note form and assigns the doctor ID
        public MakeNote(int ID)
        {
            InitializeComponent();
            dID = ID;
        }

        //Closes form
        private void butReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        //Validates the fields to see if patient exists. Creates SQL insert with user text and current date.
        private void butNote_Click(object sender, EventArgs e)
        {
            string FirstName = txtFirstName.Text;
            string LastName = txtLastName.Text;
            string condition = "firstName = '" + FirstName + "' AND lastName = '" + LastName + "'";

            //If the patient specified by the doctor exists then proceed
            if (SQLQuery.Exists("Patients", condition) == 1)
            {
                object pID = SQLQuery.SingleSelect("pId", "Patients", condition);
                string Date = DateTime.Now.ToString("MM/dd/yyyy");
                string SymptomName = txtSymptomName.Text;
                string SymptomDetails = txtSymptomDetails.Text;
                object[] values = new object[5] { (dID), (pID), (Date), (SymptomName), (SymptomDetails) };
                SQLQuery.Insert("Medical_History", values);
                MessageBox.Show("Medical Note Added");
                this.Hide();
                this.Close();
            }
            else
                MessageBox.Show("Invalid First or Last Patient Name");
        }
    }
}
