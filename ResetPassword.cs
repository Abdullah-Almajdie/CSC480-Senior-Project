using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace Hospital_Management_System
{
    public partial class ResetPassword : Form
    {
        //Initializes the Reset Password Form.
        public ResetPassword() { InitializeComponent(); }
        
        //When called it creates a random temporary password of specified length.
        public static string CreatePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        //Sends a recovery email using HospitalAccRecoveryEmail@gmail.com. The email is validated through gmail smtp host. 
        //Creates a random temporary password and sends it to recipient
        public static string sendRecoveryEmail(string email)
        {
            //Connecting to email server and inputing credentials
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Timeout = 50000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("HospitalAccRecoveryEmail@gmail.com", "R3cover!");

            //Create temp password
            string pass = CreatePassword(10);

            //Create email
            MailMessage RecEmail = new MailMessage("donotreply@hospitalmanagementsystem.com", email, "Temporary Password for Hosptial Management System", 
                "Here is your new temporary password you requested." +
                "\nPass: " + pass +
                "\n\nThank you and have a nice day!");
            RecEmail.BodyEncoding = UTF8Encoding.UTF8;
            RecEmail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            //Send email
            client.Send(RecEmail);

            return pass;
        }

        //Checks the email input by the user against the database to see if it exists. Updates the database with temporary password.
        public void CheckSend(string email)
        {
            int countP = SQLQuery.RowCount("email", "Patients", "email=" + "'" + email + "'");
            int countD = SQLQuery.RowCount("Email", "Doctor", "Email=" + "'" + email + "'");
            if (countP == 1)
            {
                string newpass = sendRecoveryEmail(email);
                SQLQuery.UpdateRow("Patients", "passWord", newpass, "email=" + "'" + email + "'");
            }
            if (countD == 1)
            {
                string newpass = sendRecoveryEmail(email);
                SQLQuery.UpdateRow("Doctor", "passWord", newpass, "Email=" + "'" + email + "'");
            }
        }

        //Checks to make sure entered email is in valid email format and calls CheckSend to verify it is in the database.
        //If both these conditions are met, the temp pass is sent and the table updated.
        private void butReset_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;

            if (Validation.IsValidEmail(email))
            {
                CheckSend(email);
                MessageBox.Show("New temporary password has been sent to your email");
            }
            else
                MessageBox.Show("Please enter a valid email address");
        }

        //Returns to log-in form and closes this form
        private void butReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn signin = new LogIn();
            signin.ShowDialog();
            this.Close();
        }
    }
}
