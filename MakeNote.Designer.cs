namespace Hospital_Management_System
{
    partial class MakeNote
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSymptomName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtSymptomDetails = new System.Windows.Forms.TextBox();
            this.butNote = new System.Windows.Forms.Button();
            this.butReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(19, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Symptom Details ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Symptom Name:";
            // 
            // txtSymptomName
            // 
            this.txtSymptomName.Location = new System.Drawing.Point(118, 136);
            this.txtSymptomName.Name = "txtSymptomName";
            this.txtSymptomName.Size = new System.Drawing.Size(138, 20);
            this.txtSymptomName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(38, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Add Patient Medical Note";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Patient Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Patient First Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(118, 100);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(138, 20);
            this.txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(118, 67);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(139, 20);
            this.txtFirstName.TabIndex = 0;
            // 
            // txtSymptomDetails
            // 
            this.txtSymptomDetails.Location = new System.Drawing.Point(22, 189);
            this.txtSymptomDetails.Multiline = true;
            this.txtSymptomDetails.Name = "txtSymptomDetails";
            this.txtSymptomDetails.Size = new System.Drawing.Size(234, 102);
            this.txtSymptomDetails.TabIndex = 3;
            // 
            // butNote
            // 
            this.butNote.Location = new System.Drawing.Point(149, 310);
            this.butNote.Name = "butNote";
            this.butNote.Size = new System.Drawing.Size(107, 29);
            this.butNote.TabIndex = 5;
            this.butNote.Text = "Make Note";
            this.butNote.UseVisualStyleBackColor = true;
            this.butNote.Click += new System.EventHandler(this.butNote_Click);
            // 
            // butReturn
            // 
            this.butReturn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butReturn.Location = new System.Drawing.Point(22, 310);
            this.butReturn.Name = "butReturn";
            this.butReturn.Size = new System.Drawing.Size(101, 29);
            this.butReturn.TabIndex = 4;
            this.butReturn.Text = "Return";
            this.butReturn.UseVisualStyleBackColor = true;
            this.butReturn.Click += new System.EventHandler(this.butReturn_Click);
            // 
            // MakeNote
            // 
            this.AcceptButton = this.butNote;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.butReturn;
            this.ClientSize = new System.Drawing.Size(282, 371);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSymptomName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtSymptomDetails);
            this.Controls.Add(this.butNote);
            this.Controls.Add(this.butReturn);
            this.Name = "MakeNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MakeNote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSymptomName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtSymptomDetails;
        private System.Windows.Forms.Button butNote;
        private System.Windows.Forms.Button butReturn;
    }
}