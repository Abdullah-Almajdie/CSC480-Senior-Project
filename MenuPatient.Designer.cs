namespace Hospital_Management_System
{
    partial class MenuPatient
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
            this.lblTable = new System.Windows.Forms.Label();
            this.dtTable = new System.Windows.Forms.DataGridView();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.butSignOut = new System.Windows.Forms.Button();
            this.butNewAppt = new System.Windows.Forms.Button();
            this.butNote = new System.Windows.Forms.Button();
            this.butPrescr = new System.Windows.Forms.Button();
            this.butEditAcc = new System.Windows.Forms.Button();
            this.butViewAppt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtTable)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Location = new System.Drawing.Point(260, 30);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(0, 13);
            this.lblTable.TabIndex = 17;
            // 
            // dtTable
            // 
            this.dtTable.AllowUserToAddRows = false;
            this.dtTable.AllowUserToDeleteRows = false;
            this.dtTable.AllowUserToResizeColumns = false;
            this.dtTable.AllowUserToResizeRows = false;
            this.dtTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtTable.Location = new System.Drawing.Point(146, 55);
            this.dtTable.Name = "dtTable";
            this.dtTable.ReadOnly = true;
            this.dtTable.RowHeadersVisible = false;
            this.dtTable.Size = new System.Drawing.Size(320, 246);
            this.dtTable.TabIndex = 16;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(38, 30);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 13);
            this.lblWelcome.TabIndex = 15;
            // 
            // butSignOut
            // 
            this.butSignOut.Location = new System.Drawing.Point(24, 270);
            this.butSignOut.Name = "butSignOut";
            this.butSignOut.Size = new System.Drawing.Size(116, 31);
            this.butSignOut.TabIndex = 5;
            this.butSignOut.Text = "Sign Out";
            this.butSignOut.UseVisualStyleBackColor = true;
            this.butSignOut.Click += new System.EventHandler(this.butSignOut_Click);
            // 
            // butNewAppt
            // 
            this.butNewAppt.Location = new System.Drawing.Point(24, 229);
            this.butNewAppt.Name = "butNewAppt";
            this.butNewAppt.Size = new System.Drawing.Size(116, 35);
            this.butNewAppt.TabIndex = 4;
            this.butNewAppt.Text = "Make Appointment";
            this.butNewAppt.UseVisualStyleBackColor = true;
            this.butNewAppt.Click += new System.EventHandler(this.butNewAppt_Click);
            // 
            // butNote
            // 
            this.butNote.Location = new System.Drawing.Point(24, 186);
            this.butNote.Name = "butNote";
            this.butNote.Size = new System.Drawing.Size(116, 37);
            this.butNote.TabIndex = 3;
            this.butNote.Text = "View Medical Notes";
            this.butNote.UseVisualStyleBackColor = true;
            this.butNote.Click += new System.EventHandler(this.butNote_Click);
            // 
            // butPrescr
            // 
            this.butPrescr.Location = new System.Drawing.Point(24, 100);
            this.butPrescr.Name = "butPrescr";
            this.butPrescr.Size = new System.Drawing.Size(116, 37);
            this.butPrescr.TabIndex = 1;
            this.butPrescr.Text = "View Prescriptions";
            this.butPrescr.UseVisualStyleBackColor = true;
            this.butPrescr.Click += new System.EventHandler(this.butPrescr_Click);
            // 
            // butEditAcc
            // 
            this.butEditAcc.Location = new System.Drawing.Point(24, 55);
            this.butEditAcc.Name = "butEditAcc";
            this.butEditAcc.Size = new System.Drawing.Size(116, 39);
            this.butEditAcc.TabIndex = 0;
            this.butEditAcc.Text = "Edit Account Info";
            this.butEditAcc.UseVisualStyleBackColor = true;
            this.butEditAcc.Click += new System.EventHandler(this.butEditAcc_Click);
            // 
            // butViewAppt
            // 
            this.butViewAppt.Location = new System.Drawing.Point(24, 143);
            this.butViewAppt.Name = "butViewAppt";
            this.butViewAppt.Size = new System.Drawing.Size(116, 37);
            this.butViewAppt.TabIndex = 2;
            this.butViewAppt.Text = "View Appointments";
            this.butViewAppt.UseVisualStyleBackColor = true;
            this.butViewAppt.Click += new System.EventHandler(this.butViewAppt_Click);
            // 
            // MenuPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 326);
            this.Controls.Add(this.butViewAppt);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.dtTable);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.butSignOut);
            this.Controls.Add(this.butNewAppt);
            this.Controls.Add(this.butNote);
            this.Controls.Add(this.butPrescr);
            this.Controls.Add(this.butEditAcc);
            this.Name = "MenuPatient";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient Menu";
            ((System.ComponentModel.ISupportInitialize)(this.dtTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.DataGridView dtTable;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button butSignOut;
        private System.Windows.Forms.Button butNewAppt;
        private System.Windows.Forms.Button butNote;
        private System.Windows.Forms.Button butPrescr;
        private System.Windows.Forms.Button butEditAcc;
        private System.Windows.Forms.Button butViewAppt;
    }
}