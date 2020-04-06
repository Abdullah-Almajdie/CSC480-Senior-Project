namespace Hospital_Management_System
{
    partial class MakeAppt
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
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.boxTimes = new System.Windows.Forms.GroupBox();
            this.rad5 = new System.Windows.Forms.RadioButton();
            this.rad4 = new System.Windows.Forms.RadioButton();
            this.rad3 = new System.Windows.Forms.RadioButton();
            this.rad2 = new System.Windows.Forms.RadioButton();
            this.rad1 = new System.Windows.Forms.RadioButton();
            this.rad12 = new System.Windows.Forms.RadioButton();
            this.rad11 = new System.Windows.Forms.RadioButton();
            this.rad10 = new System.Windows.Forms.RadioButton();
            this.rad9 = new System.Windows.Forms.RadioButton();
            this.rad8 = new System.Windows.Forms.RadioButton();
            this.butReturn = new System.Windows.Forms.Button();
            this.butMakeAppt = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtDoctorLast = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.boxTimes.SuspendLayout();
            this.SuspendLayout();
            // 
            // datePicker
            // 
            this.datePicker.Enabled = false;
            this.datePicker.Location = new System.Drawing.Point(24, 117);
            this.datePicker.MinDate = new System.DateTime(2018, 10, 23, 0, 0, 0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(213, 20);
            this.datePicker.TabIndex = 1;
            this.datePicker.Value = new System.DateTime(2018, 10, 23, 16, 26, 48, 0);
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // boxTimes
            // 
            this.boxTimes.Controls.Add(this.rad5);
            this.boxTimes.Controls.Add(this.rad4);
            this.boxTimes.Controls.Add(this.rad3);
            this.boxTimes.Controls.Add(this.rad2);
            this.boxTimes.Controls.Add(this.rad1);
            this.boxTimes.Controls.Add(this.rad12);
            this.boxTimes.Controls.Add(this.rad11);
            this.boxTimes.Controls.Add(this.rad10);
            this.boxTimes.Controls.Add(this.rad9);
            this.boxTimes.Controls.Add(this.rad8);
            this.boxTimes.Enabled = false;
            this.boxTimes.Location = new System.Drawing.Point(24, 155);
            this.boxTimes.Name = "boxTimes";
            this.boxTimes.Size = new System.Drawing.Size(213, 162);
            this.boxTimes.TabIndex = 1;
            this.boxTimes.TabStop = false;
            this.boxTimes.Text = "Available Times";
            // 
            // rad5
            // 
            this.rad5.AutoSize = true;
            this.rad5.Location = new System.Drawing.Point(117, 125);
            this.rad5.Name = "rad5";
            this.rad5.Size = new System.Drawing.Size(65, 17);
            this.rad5.TabIndex = 9;
            this.rad5.TabStop = true;
            this.rad5.Text = "5:00 PM";
            this.rad5.UseVisualStyleBackColor = true;
            // 
            // rad4
            // 
            this.rad4.AutoSize = true;
            this.rad4.Location = new System.Drawing.Point(117, 102);
            this.rad4.Name = "rad4";
            this.rad4.Size = new System.Drawing.Size(65, 17);
            this.rad4.TabIndex = 8;
            this.rad4.TabStop = true;
            this.rad4.Text = "4:00 PM";
            this.rad4.UseVisualStyleBackColor = true;
            // 
            // rad3
            // 
            this.rad3.AutoSize = true;
            this.rad3.Location = new System.Drawing.Point(117, 79);
            this.rad3.Name = "rad3";
            this.rad3.Size = new System.Drawing.Size(65, 17);
            this.rad3.TabIndex = 7;
            this.rad3.TabStop = true;
            this.rad3.Text = "3:00 PM";
            this.rad3.UseVisualStyleBackColor = true;
            // 
            // rad2
            // 
            this.rad2.AutoSize = true;
            this.rad2.Location = new System.Drawing.Point(117, 56);
            this.rad2.Name = "rad2";
            this.rad2.Size = new System.Drawing.Size(65, 17);
            this.rad2.TabIndex = 6;
            this.rad2.TabStop = true;
            this.rad2.Text = "2:00 PM";
            this.rad2.UseVisualStyleBackColor = true;
            // 
            // rad1
            // 
            this.rad1.AutoSize = true;
            this.rad1.Location = new System.Drawing.Point(117, 33);
            this.rad1.Name = "rad1";
            this.rad1.Size = new System.Drawing.Size(65, 17);
            this.rad1.TabIndex = 5;
            this.rad1.TabStop = true;
            this.rad1.Text = "1:00 PM";
            this.rad1.UseVisualStyleBackColor = true;
            // 
            // rad12
            // 
            this.rad12.AutoSize = true;
            this.rad12.Location = new System.Drawing.Point(19, 125);
            this.rad12.Name = "rad12";
            this.rad12.Size = new System.Drawing.Size(71, 17);
            this.rad12.TabIndex = 4;
            this.rad12.TabStop = true;
            this.rad12.Text = "12:00 PM";
            this.rad12.UseVisualStyleBackColor = true;
            // 
            // rad11
            // 
            this.rad11.AutoSize = true;
            this.rad11.Location = new System.Drawing.Point(19, 102);
            this.rad11.Name = "rad11";
            this.rad11.Size = new System.Drawing.Size(71, 17);
            this.rad11.TabIndex = 3;
            this.rad11.TabStop = true;
            this.rad11.Text = "11:00 AM";
            this.rad11.UseVisualStyleBackColor = true;
            // 
            // rad10
            // 
            this.rad10.AutoSize = true;
            this.rad10.Location = new System.Drawing.Point(19, 79);
            this.rad10.Name = "rad10";
            this.rad10.Size = new System.Drawing.Size(71, 17);
            this.rad10.TabIndex = 2;
            this.rad10.TabStop = true;
            this.rad10.Text = "10:00 AM";
            this.rad10.UseVisualStyleBackColor = true;
            // 
            // rad9
            // 
            this.rad9.AutoSize = true;
            this.rad9.Location = new System.Drawing.Point(19, 56);
            this.rad9.Name = "rad9";
            this.rad9.Size = new System.Drawing.Size(65, 17);
            this.rad9.TabIndex = 1;
            this.rad9.TabStop = true;
            this.rad9.Text = "9:00 AM";
            this.rad9.UseVisualStyleBackColor = true;
            // 
            // rad8
            // 
            this.rad8.AutoSize = true;
            this.rad8.Location = new System.Drawing.Point(19, 33);
            this.rad8.Name = "rad8";
            this.rad8.Size = new System.Drawing.Size(65, 17);
            this.rad8.TabIndex = 0;
            this.rad8.TabStop = true;
            this.rad8.Text = "8:00 AM";
            this.rad8.UseVisualStyleBackColor = true;
            // 
            // butReturn
            // 
            this.butReturn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butReturn.Location = new System.Drawing.Point(24, 388);
            this.butReturn.Name = "butReturn";
            this.butReturn.Size = new System.Drawing.Size(93, 36);
            this.butReturn.TabIndex = 3;
            this.butReturn.Text = "Return";
            this.butReturn.UseVisualStyleBackColor = true;
            this.butReturn.Click += new System.EventHandler(this.butReturn_Click);
            // 
            // butMakeAppt
            // 
            this.butMakeAppt.Location = new System.Drawing.Point(123, 388);
            this.butMakeAppt.Name = "butMakeAppt";
            this.butMakeAppt.Size = new System.Drawing.Size(114, 36);
            this.butMakeAppt.TabIndex = 4;
            this.butMakeAppt.Text = "Make Appointment";
            this.butMakeAppt.UseVisualStyleBackColor = true;
            this.butMakeAppt.Click += new System.EventHandler(this.butMakeAppt_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(21, 101);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(134, 13);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "Desired Appointment Date:";
            // 
            // txtDoctorLast
            // 
            this.txtDoctorLast.Location = new System.Drawing.Point(118, 63);
            this.txtDoctorLast.Name = "txtDoctorLast";
            this.txtDoctorLast.Size = new System.Drawing.Size(119, 20);
            this.txtDoctorLast.TabIndex = 0;
            this.txtDoctorLast.TextChanged += new System.EventHandler(this.txtDoctorLast_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Doctor Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(54, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Make Appointment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Appointment Subject:";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(24, 348);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(213, 20);
            this.txtSubject.TabIndex = 2;
            // 
            // MakeAppt
            // 
            this.AcceptButton = this.butMakeAppt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.butReturn;
            this.ClientSize = new System.Drawing.Size(271, 437);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDoctorLast);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.butMakeAppt);
            this.Controls.Add(this.butReturn);
            this.Controls.Add(this.boxTimes);
            this.Controls.Add(this.datePicker);
            this.Name = "MakeAppt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MakeAppt";
            this.boxTimes.ResumeLayout(false);
            this.boxTimes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.GroupBox boxTimes;
        private System.Windows.Forms.RadioButton rad5;
        private System.Windows.Forms.RadioButton rad4;
        private System.Windows.Forms.RadioButton rad3;
        private System.Windows.Forms.RadioButton rad2;
        private System.Windows.Forms.RadioButton rad1;
        private System.Windows.Forms.RadioButton rad12;
        private System.Windows.Forms.RadioButton rad11;
        private System.Windows.Forms.RadioButton rad10;
        private System.Windows.Forms.RadioButton rad9;
        private System.Windows.Forms.RadioButton rad8;
        private System.Windows.Forms.Button butReturn;
        private System.Windows.Forms.Button butMakeAppt;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtDoctorLast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSubject;
    }
}