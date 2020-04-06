namespace Hospital_Management_System
{
    partial class ManagePatient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.MaskedTextBox();
            this.txtZIP = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.butUpdatePass = new System.Windows.Forms.Button();
            this.butReturn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCPass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtReEnterPass = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCAddress = new System.Windows.Forms.TextBox();
            this.txtCEmail = new System.Windows.Forms.TextBox();
            this.txtCAge = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCZIP = new System.Windows.Forms.MaskedTextBox();
            this.txtCUser = new System.Windows.Forms.TextBox();
            this.butUpdateInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(291, 210);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(153, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(422, 176);
            this.txtAge.Mask = "00";
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(19, 20);
            this.txtAge.TabIndex = 3;
            // 
            // txtZIP
            // 
            this.txtZIP.Location = new System.Drawing.Point(403, 315);
            this.txtZIP.Mask = "00000";
            this.txtZIP.Name = "txtZIP";
            this.txtZIP.Size = new System.Drawing.Size(38, 20);
            this.txtZIP.TabIndex = 6;
            this.txtZIP.ValidatingType = typeof(int);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(148, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 20);
            this.label9.TabIndex = 37;
            this.label9.Text = "Manage Account Info";
            // 
            // butUpdatePass
            // 
            this.butUpdatePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.butUpdatePass.Location = new System.Drawing.Point(167, 370);
            this.butUpdatePass.Name = "butUpdatePass";
            this.butUpdatePass.Size = new System.Drawing.Size(129, 40);
            this.butUpdatePass.TabIndex = 8;
            this.butUpdatePass.Text = "Update Password";
            this.butUpdatePass.UseVisualStyleBackColor = true;
            this.butUpdatePass.Click += new System.EventHandler(this.butUpdatePass_Click);
            // 
            // butReturn
            // 
            this.butReturn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.butReturn.Location = new System.Drawing.Point(29, 370);
            this.butReturn.Name = "butReturn";
            this.butReturn.Size = new System.Drawing.Size(132, 40);
            this.butReturn.TabIndex = 7;
            this.butReturn.Text = "Return to Menu";
            this.butReturn.UseVisualStyleBackColor = true;
            this.butReturn.Click += new System.EventHandler(this.butReturn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(326, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "New ZIP:";
            // 
            // txtCPass
            // 
            this.txtCPass.Location = new System.Drawing.Point(278, 69);
            this.txtCPass.Name = "txtCPass";
            this.txtCPass.Size = new System.Drawing.Size(163, 20);
            this.txtCPass.TabIndex = 0;
            this.txtCPass.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(215, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "New Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(225, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "New Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(362, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "New Age:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Re-enter New Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "New Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Current Password:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(291, 243);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(150, 53);
            this.txtAddress.TabIndex = 5;
            // 
            // txtReEnterPass
            // 
            this.txtReEnterPass.Location = new System.Drawing.Point(278, 134);
            this.txtReEnterPass.Name = "txtReEnterPass";
            this.txtReEnterPass.Size = new System.Drawing.Size(163, 20);
            this.txtReEnterPass.TabIndex = 2;
            this.txtReEnterPass.UseSystemPasswordChar = true;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(278, 100);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(163, 20);
            this.txtNewPass.TabIndex = 1;
            this.txtNewPass.UseSystemPasswordChar = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Currently Logged In As:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Age:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 213);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 40;
            this.label11.Text = "Email: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 246);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 41;
            this.label12.Text = "Address:";
            // 
            // txtCAddress
            // 
            this.txtCAddress.Location = new System.Drawing.Point(81, 246);
            this.txtCAddress.Multiline = true;
            this.txtCAddress.Name = "txtCAddress";
            this.txtCAddress.ReadOnly = true;
            this.txtCAddress.Size = new System.Drawing.Size(128, 53);
            this.txtCAddress.TabIndex = 42;
            this.txtCAddress.TabStop = false;
            // 
            // txtCEmail
            // 
            this.txtCEmail.Location = new System.Drawing.Point(81, 210);
            this.txtCEmail.Name = "txtCEmail";
            this.txtCEmail.ReadOnly = true;
            this.txtCEmail.Size = new System.Drawing.Size(128, 20);
            this.txtCEmail.TabIndex = 43;
            this.txtCEmail.TabStop = false;
            // 
            // txtCAge
            // 
            this.txtCAge.Location = new System.Drawing.Point(81, 176);
            this.txtCAge.Mask = "00";
            this.txtCAge.Name = "txtCAge";
            this.txtCAge.ReadOnly = true;
            this.txtCAge.Size = new System.Drawing.Size(19, 20);
            this.txtCAge.TabIndex = 44;
            this.txtCAge.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 315);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 13);
            this.label13.TabIndex = 45;
            this.label13.Text = "ZIP:";
            // 
            // txtCZIP
            // 
            this.txtCZIP.Location = new System.Drawing.Point(81, 315);
            this.txtCZIP.Mask = "00000";
            this.txtCZIP.Name = "txtCZIP";
            this.txtCZIP.ReadOnly = true;
            this.txtCZIP.Size = new System.Drawing.Size(38, 20);
            this.txtCZIP.TabIndex = 46;
            this.txtCZIP.TabStop = false;
            this.txtCZIP.ValidatingType = typeof(int);
            // 
            // txtCUser
            // 
            this.txtCUser.Location = new System.Drawing.Point(278, 39);
            this.txtCUser.Name = "txtCUser";
            this.txtCUser.ReadOnly = true;
            this.txtCUser.Size = new System.Drawing.Size(163, 20);
            this.txtCUser.TabIndex = 47;
            this.txtCUser.TabStop = false;
            // 
            // butUpdateInfo
            // 
            this.butUpdateInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.butUpdateInfo.Location = new System.Drawing.Point(302, 370);
            this.butUpdateInfo.Name = "butUpdateInfo";
            this.butUpdateInfo.Size = new System.Drawing.Size(139, 40);
            this.butUpdateInfo.TabIndex = 9;
            this.butUpdateInfo.Text = "Update Information";
            this.butUpdateInfo.UseVisualStyleBackColor = true;
            this.butUpdateInfo.Click += new System.EventHandler(this.butUpdateInfo_Click);
            // 
            // ManagePatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.butReturn;
            this.ClientSize = new System.Drawing.Size(473, 450);
            this.Controls.Add(this.butUpdateInfo);
            this.Controls.Add(this.txtCUser);
            this.Controls.Add(this.txtCZIP);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtCAge);
            this.Controls.Add(this.txtCEmail);
            this.Controls.Add(this.txtCAddress);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtZIP);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.butUpdatePass);
            this.Controls.Add(this.butReturn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCPass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtReEnterPass);
            this.Controls.Add(this.txtNewPass);
            this.Name = "ManagePatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagePatient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox txtAge;
        private System.Windows.Forms.MaskedTextBox txtZIP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button butUpdatePass;
        private System.Windows.Forms.Button butReturn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCPass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtReEnterPass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCAddress;
        private System.Windows.Forms.TextBox txtCEmail;
        private System.Windows.Forms.MaskedTextBox txtCAge;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox txtCZIP;
        private System.Windows.Forms.TextBox txtCUser;
        private System.Windows.Forms.Button butUpdateInfo;
    }
}