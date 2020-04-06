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
    public partial class ManageDoctor : Form
    {
        string CurrentUser;
        string condition;

        //Initialize form and fills out fields
        public ManageDoctor(string Username)
        {
            CurrentUser = Username;
            InitializeComponent();
            txtCUser.Text = CurrentUser;
            condition = ("userName = '" + CurrentUser + "'");
            txtCEmail.Text = Convert.ToString(SQLQuery.SingleSelect("Email", "Doctor", condition));
        }

        //Returns to previous GUI
        private void butReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
        }

        //Updates the password if strength is good and current password field is correct as well as new passwords mathcing.
        //Clears the password fields when successfully changed to prevent spam.
        private void butUpdatePass_Click(object sender, EventArgs e)
        {
            if (SQLQuery.Exists("Doctor", "passWord = '" + txtCPass.Text + "'") == 1)
            {
                if (txtNewPass.Text == txtReEnterPass.Text)
                {
                    if (Validation.IsValidPassword(txtNewPass.Text))
                    {
                        SQLQuery.UpdateRow("Doctor", "passWord", txtNewPass.Text, condition);
                        MessageBox.Show("Password updated");
                        txtCPass.Clear();
                        txtNewPass.Clear();
                        txtReEnterPass.Clear();
                    }
                }
                else MessageBox.Show("Passwords do not match");
            }
            else if (txtCPass.Text == "") MessageBox.Show("Must enter your current password");
            else MessageBox.Show("Incorrect Password");
        }
        
        //Updates the email and checks for validity in the process
        private void butUpdateEmail_Click(object sender, EventArgs e)
        {
            if (Validation.IsValidEmail(txtEmail.Text))
            {
                SQLQuery.UpdateRow("Doctor", "Email", txtEmail.Text, condition);
                MessageBox.Show("Email updated");
                txtCEmail.Text = Convert.ToString(SQLQuery.SingleSelect("Email", "Doctor", condition));
            }
            else if (Validation.IsValidEmail(txtEmail.Text) == false && txtEmail.Text != "")
                MessageBox.Show("Email is not in proper format");
            else if (txtEmail.Text != "")
                MessageBox.Show("Must enter a new email to change the existing email");
        }
    }
}
