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
    public partial class MenuPatient : Form
    {
        string CurrentUser;
        int ID;

        //Initializes the Menu Patient form and updates labels.
        public MenuPatient(string Username)
        {
            CurrentUser = Username;
            string fname = Convert.ToString(SQLQuery.SingleSelect("firstName", "Patients", "userName = '" + CurrentUser + "'"));
            ID = Convert.ToInt32(SQLQuery.SingleSelect("pId", "Patients", "userName = '" + CurrentUser + "'"));
            InitializeComponent();
            lblWelcome.Text = ("Welcome Back " + fname);
        }

        //Opens a new Manage Patient form.
        private void butEditAcc_Click(object sender, EventArgs e)
        {
            ManagePatient mngPatient = new ManagePatient(CurrentUser);
            mngPatient.ShowDialog();
        }

        //Updates the table with prescription information of logged in patient
        private void butPrescr_Click(object sender, EventArgs e)
        {
            lblTable.Text = "Prescriptions";
            string[] PrescrCol = new string[] { "date", "presc_Name", "presc_instructions" };
            dtTable.DataSource = SQLQuery.SelectTable(PrescrCol, "Prescriptions", "pId = '" + ID + "'");
        }

        //Updates the table with medical history information of logged in patient
        private void butNote_Click(object sender, EventArgs e)
        {
            lblTable.Text = "Medical History";
            string[] NoteCol = new string[] { "date", "symptom_Name", "symptom_Desc" };
            dtTable.DataSource = SQLQuery.SelectTable(NoteCol, "Medical_History", "pId = '" + ID + "'");
        }

        //Updates the table with the scheduled appointments the logged in patient has
        private void butViewAppt_Click(object sender, EventArgs e)
        {
            lblTable.Text = "Appointments";
            string[] ApptCol = new string[] { "lastName", "date", "time", "subject" };
            dtTable.DataSource = SQLQuery.JoinSelectTable(ApptCol, "Appointments", "Doctor", "dID", "pId = '" + ID + "'");
        }

        //Opens the new appointment form
        private void butNewAppt_Click(object sender, EventArgs e)
        {
            MakeAppt newAppt = new MakeAppt(ID);
            newAppt.ShowDialog();
        }

        //"Signs-Out" the current user by closing their current form and returning them to the log-in form
        private void butSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn signin = new LogIn();
            signin.ShowDialog();
            this.Close();
        }
    }
}
