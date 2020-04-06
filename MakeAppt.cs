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
    public partial class MakeAppt : Form
    {
        int pID = -1;
        int dID = -1;

        //Initialize Make Appointment Form and configure controls
        public MakeAppt(int ID)
        {
            pID = ID;
            InitializeComponent();
            datePicker.MinDate = DateTime.Now;
            datePicker.MaxDate = DateTime.Today.AddYears(1);
            datePicker.Enabled = false;
            boxTimes.Enabled = false;
        }

        //Close form
        private void butReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        //When a valid doctor last name has been entered, allow patient to pick a time
        private void txtDoctorLast_TextChanged(object sender, EventArgs e)
        {
            string LastName = txtDoctorLast.Text;
            string condition = "lastName = '" + LastName + "'";
            if (SQLQuery.Exists("Doctor", condition) == 1)
            {
                datePicker.Enabled = true;
                dID = Convert.ToInt32(SQLQuery.SingleSelect("dID", "Doctor", condition));
            }
            else
            {
                dID = -1;
                datePicker.Enabled = false;
                boxTimes.Enabled = false;
            }
        }

        //When a date is picked, check the database for available times for the patient to schedule an appt with specified doctor
        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            boxTimes.Enabled = true;
            string selectedDate = datePicker.Value.ToShortDateString();
            

            foreach (var control in boxTimes.Controls.OfType<RadioButton>())
            {
                //String WHERE condition to see if the patient and doctor are available at the specified time
                string Availability = "date = '" + selectedDate + 
                    "' AND (dID = '" + dID + "' OR pId = '" + pID + 
                    "') AND time = '" + control.Text + "'";
                
                //If note available, the time is disabled
                if (SQLQuery.Exists("Appointments", Availability) == 1)
                {
                    control.Enabled = false;
                }
                //Otherwise it is enabled
                else
                    control.Enabled = true;
            }
        }

        //Once a valid doctor, date and time have been selected, appointment will be made.
        private void butMakeAppt_Click(object sender, EventArgs e)
        {
            //Gather variables for validation and insert.
            string subject = txtSubject.Text;
            string selectedDate = datePicker.Value.ToShortDateString();
            var checkedButton = boxTimes.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            string time = checkedButton.Text;          
            string checkCon = "date = '" + selectedDate + "' AND dID = '" + dID + "' AND pId = '" + pID + "'";

            //Check to see if the patient has an appointment with that doctor that day.
            if (SQLQuery.Exists("Appointments", checkCon) == 0)
            {
                object[] values = new object[5] { (dID), (pID), (selectedDate), (time), (subject) };
                //Insert appointment into database
                SQLQuery.Insert("Appointments", values);

                //Notify user of their selected appointment
                string message = ("Appointment made for: " + selectedDate + ", at " + time + " with Dr." + txtDoctorLast.Text);
                MessageBox.Show(message);
                this.Hide();
                this.Close();
            }

            //Give user the option to reschedule appointment to new time.
            else
            {
                DialogResult dialogResult = MessageBox.Show(
                    "You already have an appointment with this doctor today. " +
                    "\nWould you like to change it to the newly selected time?", "Reschedule Appointment", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    SQLQuery.UpdateRow("Appointments", "time", time, checkCon);
                    string message = ("Appointment made for: " + selectedDate + ", at " + time + " with Dr." + txtDoctorLast.Text);
                    MessageBox.Show(message);
                    this.Hide();
                    this.Close();
                }
            }
        }
    }
}
