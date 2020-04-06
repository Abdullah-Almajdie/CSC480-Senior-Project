namespace Hospital_Management_System
{
    partial class ResetPassword
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
            this.butReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.butReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(108, 48);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(182, 20);
            this.txtEmail.TabIndex = 0;
            // 
            // butReset
            // 
            this.butReset.Location = new System.Drawing.Point(168, 96);
            this.butReset.Name = "butReset";
            this.butReset.Size = new System.Drawing.Size(122, 34);
            this.butReset.TabIndex = 2;
            this.butReset.Text = "Reset Password";
            this.butReset.UseVisualStyleBackColor = true;
            this.butReset.Click += new System.EventHandler(this.butReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Recovery Email:";
            // 
            // butReturn
            // 
            this.butReturn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butReturn.Location = new System.Drawing.Point(21, 96);
            this.butReturn.Name = "butReturn";
            this.butReturn.Size = new System.Drawing.Size(112, 34);
            this.butReturn.TabIndex = 1;
            this.butReturn.Text = "Return to Log In";
            this.butReturn.UseVisualStyleBackColor = true;
            this.butReturn.Click += new System.EventHandler(this.butReturn_Click);
            // 
            // ResetPassword
            // 
            this.AcceptButton = this.butReset;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.butReturn;
            this.ClientSize = new System.Drawing.Size(313, 160);
            this.Controls.Add(this.butReturn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butReset);
            this.Controls.Add(this.txtEmail);
            this.Name = "ResetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResetPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button butReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butReturn;
    }
}