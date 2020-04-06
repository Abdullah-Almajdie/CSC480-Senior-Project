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
    public partial class ManagePatient : Form
    {
        string CurrentUser;
        string condition;

        //Initializes the Manage Patient Form and fills out fields about current user.
        public ManagePatient(string Username)
        {
            CurrentUser = Username;           
            InitializeComponent();
            RefreshInfo();
        }

        //Fills out disabled text boxes with current patient information
        public void RefreshInfo()
        {
            condition = ("userName = '" + CurrentUser + "'");
            txtCUser.Text = CurrentUser;
            txtCAge.Text = Convert.ToString(SQLQuery.SingleSelect("age", "Patients", condition));
            txtCEmail.Text = Convert.ToString(SQLQuery.SingleSelect("email", "Patients", condition));
            txtCAddress.Text = Convert.ToString(SQLQuery.SingleSelect("address", "Patients", condition));
            txtCZIP.Text = Convert.ToString(SQLQuery.SingleSelect("zip", "Patients", condition));
        }

        //Closes this form.
        private void butReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
        }

        //Checks if current password matches and if password is strong enough and new passwords match. Updates table if conditions met.
        //Clears the text boxes if password is reset to prevent spam.
        private void butUpdatePass_Click(object sender, EventArgs e)
        {          
            if (SQLQuery.Exists("Patients", "passWord = '" + txtCPass.Text + "'") == 1)
            {
                if (txtNewPass.Text == txtReEnterPass.Text)
                {
                    if (Validation.IsValidPassword(txtNewPass.Text))
                    {
                        SQLQuery.UpdateRow("Patients", "passWord", txtNewPass.Text, condition);
                        MessageBox.Show("Password updated");
                        txtCPass.Clear();
                        txtNewPass.Clear();
                        txtReEnterPass.Clear();
                    }
                }
                else
                    MessageBox.Show("Passwords do not match");
            }
            else if (txtCPass.Text == "") MessageBox.Show("Must enter your current password");
            else MessageBox.Show("Incorrect Password");           
        }

        //Upadates any information filled out other than password. Checks to make sure fields are valid.
        //Clears fields when table update completes. Refreshes current info afterwards.
        private void butUpdateInfo_Click(object sender, EventArgs e)
        {
            if (Validation.IsValidEmail(txtEmail.Text))
            {
                SQLQuery.UpdateRow("Patients", "email", txtEmail.Text, condition);
                txtEmail.Clear();
            }
            else if (Validation.IsValidEmail(txtEmail.Text) == false && txtEmail.Text != "")
                MessageBox.Show("Email is not in proper format");

            if (txtZIP.Text != "")
            {
                SQLQuery.UpdateRow("Patients", "zip", txtZIP.Text, condition);
                txtZIP.Clear();
            }
            if (txtAddress.Text != "")
            {
                SQLQuery.UpdateRow("Patients", "address", txtAddress.Text, condition);
                txtAddress.Clear();
            }
            if (txtAge.Text != "")
            {
                SQLQuery.UpdateRow("Patients", "age", txtAge.Text, condition);
                txtAge.Clear();
            }
            else
                MessageBox.Show("You must enter new account information to make changes");
            //MessageBox.Show("Information Updated");
            RefreshInfo();
        }
    }
}
