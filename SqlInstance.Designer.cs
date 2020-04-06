namespace Hospital_Management_System
{
    partial class SqlInstance
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
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtDB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.butConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(106, 24);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(210, 20);
            this.txtServer.TabIndex = 0;
            // 
            // txtDB
            // 
            this.txtDB.Location = new System.Drawing.Point(106, 68);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(210, 20);
            this.txtDB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Database Name:";
            // 
            // butConnect
            // 
            this.butConnect.Location = new System.Drawing.Point(115, 103);
            this.butConnect.Name = "butConnect";
            this.butConnect.Size = new System.Drawing.Size(100, 23);
            this.butConnect.TabIndex = 4;
            this.butConnect.Text = "Connect";
            this.butConnect.UseVisualStyleBackColor = true;
            this.butConnect.Click += new System.EventHandler(this.butConnect_Click);
            // 
            // SqlInstance
            // 
            this.AcceptButton = this.butConnect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 138);
            this.Controls.Add(this.butConnect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDB);
            this.Controls.Add(this.txtServer);
            this.Name = "SqlInstance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SqlInstance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butConnect;
    }
}