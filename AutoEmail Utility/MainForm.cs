using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoEmail_Utility
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void frmMainForm_Load(object sender, EventArgs e)
        {
            // initialize the default form objects
            lblUser.Text = Utility.ActiveUserName;

            // check for authorization
            if (Security.LogInCheck)
            {
                lblUser.Text += " - OK";
            } else
            {
                lblUser.Text += " - Error";
            }

            // automatic email sending
            DSR_Email.SendAutomatedEmails(); // same as clicking the button

            // waiting 10 seconds and exiting
            Application.DoEvents();
            System.Threading.Thread.Sleep(1000);
            Application.Exit();
        }

        private void btnSendEmails_Click(object sender, EventArgs e)
        {
            // send all emails
            DSR_Email.SendAutomatedEmails();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void proEmailsSent_Click(object sender, EventArgs e)
        {

        }
    }
}
