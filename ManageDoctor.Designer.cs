namespace Hospital_Management_System
{
    partial class ManageDoctor
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
            this.txtCUser = new System.Windows.Forms.TextBox();
            this.txtCEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.butUpdateInfo = new System.Windows.Forms.Button();
            this.butReturn = new System.Windows.Forms.Button();
            this.txtCPass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReEnterPass = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.butUpdateEmail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCUser
            // 
            this.txtCUser.Location = new System.Drawing.Point(163, 66);
            this.txtCUser.Name = "txtCUser";
            this.txtCUser.ReadOnly = true;
            this.txtCUser.Size = new System.Drawing.Size(153, 20);
            this.txtCUser.TabIndex = 74;
            this.txtCUser.TabStop = false;
            // 
            // txtCEmail
            // 
            this.txtCEmail.Location = new System.Drawing.Point(163, 201);
            this.txtCEmail.Name = "txtCEmail";
            this.txtCEmail.ReadOnly = true;
            this.txtCEmail.Size = new System.Drawing.Size(153, 20);
            this.txtCEmail.TabIndex = 70;
            this.txtCEmail.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 204);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 67;
            this.label11.Text = "Current Email: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 13);
            this.label10.TabIndex = 65;
            this.label10.Text = "Currently Logged In As:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(163, 239);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(153, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(84, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 20);
            this.label9.TabIndex = 64;
            this.label9.Text = "Manage Account Info";
            // 
            // butUpdateInfo
            // 
            this.butUpdateInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.butUpdateInfo.Location = new System.Drawing.Point(120, 282);
            this.butUpdateInfo.Name = "butUpdateInfo";
            this.butUpdateInfo.Size = new System.Drawing.Size(100, 40);
            this.butUpdateInfo.TabIndex = 5;
            this.butUpdateInfo.Text = "Update Password";
            this.butUpdateInfo.UseVisualStyleBackColor = true;
            this.butUpdateInfo.Click += new System.EventHandler(this.butUpdatePass_Click);
            // 
            // butReturn
            // 
            this.butReturn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.butReturn.Location = new System.Drawing.Point(22, 282);
            this.butReturn.Name = "butReturn";
            this.butReturn.Size = new System.Drawing.Size(90, 40);
            this.butReturn.TabIndex = 4;
            this.butReturn.Text = "Return to Menu";
            this.butReturn.UseVisualStyleBackColor = true;
            this.butReturn.Click += new System.EventHandler(this.butReturn_Click);
            // 
            // txtCPass
            // 
            this.txtCPass.Location = new System.Drawing.Point(163, 99);
            this.txtCPass.Name = "txtCPass";
            this.txtCPass.Size = new System.Drawing.Size(153, 20);
            this.txtCPass.TabIndex = 0;
            this.txtCPass.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "New Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = "Re-enter New Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "New Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Current Password:";
            // 
            // txtReEnterPass
            // 
            this.txtReEnterPass.Location = new System.Drawing.Point(163, 164);
            this.txtReEnterPass.Name = "txtReEnterPass";
            this.txtReEnterPass.Size = new System.Drawing.Size(153, 20);
            this.txtReEnterPass.TabIndex = 2;
            this.txtReEnterPass.UseSystemPasswordChar = true;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(163, 130);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(153, 20);
            this.txtNewPass.TabIndex = 1;
            this.txtNewPass.UseSystemPasswordChar = true;
            // 
            // butUpdateEmail
            // 
            this.butUpdateEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.butUpdateEmail.Location = new System.Drawing.Point(226, 282);
            this.butUpdateEmail.Name = "butUpdateEmail";
            this.butUpdateEmail.Size = new System.Drawing.Size(100, 40);
            this.butUpdateEmail.TabIndex = 6;
            this.butUpdateEmail.Text = "Update Email";
            this.butUpdateEmail.UseVisualStyleBackColor = true;
            this.butUpdateEmail.Click += new System.EventHandler(this.butUpdateEmail_Click);
            // 
            // ManageDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.butReturn;
            this.ClientSize = new System.Drawing.Size(348, 350);
            this.Controls.Add(this.butUpdateEmail);
            this.Controls.Add(this.txtCUser);
            this.Controls.Add(this.txtCEmail);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.butUpdateInfo);
            this.Controls.Add(this.butReturn);
            this.Controls.Add(this.txtCPass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtReEnterPass);
            this.Controls.Add(this.txtNewPass);
            this.Name = "ManageDoctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageDoctor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCUser;
        private System.Windows.Forms.TextBox txtCEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button butUpdateInfo;
        private System.Windows.Forms.Button butReturn;
        private System.Windows.Forms.TextBox txtCPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReEnterPass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Button butUpdateEmail;
    }
}