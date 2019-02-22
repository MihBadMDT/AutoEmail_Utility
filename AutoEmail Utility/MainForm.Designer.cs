namespace AutoEmail_Utility
{
    partial class frmMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainForm));
            this.lblUser = new System.Windows.Forms.Label();
            this.btnSendEmails = new System.Windows.Forms.Button();
            this.lblSendEmails = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mnuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpContact = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpFeedback = new System.Windows.Forms.ToolStripMenuItem();
            this.praiseMartinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.praisePavelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proEmailsSent = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mnuStrip_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.Location = new System.Drawing.Point(388, 186);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(127, 17);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "ActiveUser";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSendEmails
            // 
            this.btnSendEmails.Location = new System.Drawing.Point(219, 217);
            this.btnSendEmails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSendEmails.Name = "btnSendEmails";
            this.btnSendEmails.Size = new System.Drawing.Size(87, 30);
            this.btnSendEmails.TabIndex = 1;
            this.btnSendEmails.Text = "Send Emails";
            this.btnSendEmails.UseVisualStyleBackColor = true;
            this.btnSendEmails.Click += new System.EventHandler(this.btnSendEmails_Click);
            // 
            // lblSendEmails
            // 
            this.lblSendEmails.AutoSize = true;
            this.lblSendEmails.Location = new System.Drawing.Point(14, 224);
            this.lblSendEmails.Name = "lblSendEmails";
            this.lblSendEmails.Size = new System.Drawing.Size(201, 17);
            this.lblSendEmails.TabIndex = 2;
            this.lblSendEmails.Text = "Auto send emails with attachments";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::AutoEmail_Utility.Properties.Resources.Medtronic_Logo_and_Name;
            this.pictureBox1.Location = new System.Drawing.Point(0, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(530, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // mnuStrip_Main
            // 
            this.mnuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuHelp});
            this.mnuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.mnuStrip_Main.Name = "mnuStrip_Main";
            this.mnuStrip_Main.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.mnuStrip_Main.Size = new System.Drawing.Size(530, 25);
            this.mnuStrip_Main.TabIndex = 4;
            this.mnuStrip_Main.Text = "Main Menu";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 19);
            this.mnuFile.Text = "&File";
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(92, 22);
            this.mnuFileExit.Text = "&Exit";
            this.mnuFileExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelpAbout,
            this.mnuHelpContact,
            this.mnuHelpFeedback,
            this.praiseMartinToolStripMenuItem,
            this.praisePavelToolStripMenuItem});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 19);
            this.mnuHelp.Text = "&Help";
            // 
            // mnuHelpAbout
            // 
            this.mnuHelpAbout.Name = "mnuHelpAbout";
            this.mnuHelpAbout.Size = new System.Drawing.Size(152, 22);
            this.mnuHelpAbout.Text = "&About...";
            // 
            // mnuHelpContact
            // 
            this.mnuHelpContact.Name = "mnuHelpContact";
            this.mnuHelpContact.Size = new System.Drawing.Size(152, 22);
            this.mnuHelpContact.Text = "&Contact...";
            // 
            // mnuHelpFeedback
            // 
            this.mnuHelpFeedback.Name = "mnuHelpFeedback";
            this.mnuHelpFeedback.Size = new System.Drawing.Size(152, 22);
            this.mnuHelpFeedback.Text = "&Feedback...";
            // 
            // praiseMartinToolStripMenuItem
            // 
            this.praiseMartinToolStripMenuItem.Name = "praiseMartinToolStripMenuItem";
            this.praiseMartinToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.praiseMartinToolStripMenuItem.Text = "Praise &Martin...";
            // 
            // praisePavelToolStripMenuItem
            // 
            this.praisePavelToolStripMenuItem.Name = "praisePavelToolStripMenuItem";
            this.praisePavelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.praisePavelToolStripMenuItem.Text = "Praise &Pavel...";
            // 
            // proEmailsSent
            // 
            this.proEmailsSent.Location = new System.Drawing.Point(345, 224);
            this.proEmailsSent.Name = "proEmailsSent";
            this.proEmailsSent.Size = new System.Drawing.Size(100, 23);
            this.proEmailsSent.TabIndex = 5;
            this.proEmailsSent.Click += new System.EventHandler(this.proEmailsSent_Click);
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 588);
            this.Controls.Add(this.proEmailsSent);
            this.Controls.Add(this.lblSendEmails);
            this.Controls.Add(this.btnSendEmails);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mnuStrip_Main);
            this.Font = new System.Drawing.Font("Effra", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuStrip_Main;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMainForm";
            this.Text = "AutoEmail_Utility";
            this.Load += new System.EventHandler(this.frmMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mnuStrip_Main.ResumeLayout(false);
            this.mnuStrip_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnSendEmails;
        private System.Windows.Forms.Label lblSendEmails;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip mnuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpContact;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpFeedback;
        private System.Windows.Forms.ToolStripMenuItem praiseMartinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem praisePavelToolStripMenuItem;
        private System.Windows.Forms.ProgressBar proEmailsSent;
    }
}

