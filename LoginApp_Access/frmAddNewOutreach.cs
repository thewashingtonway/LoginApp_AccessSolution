using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace LoginApp_Access
{
    public partial class frmAddNewOutreach : Form
    {
        OleDbConnection connect = new OleDbConnection();
        public frmAddNewOutreach()
        {
            InitializeComponent();
            connect.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\SyncShareState\Hero House\Our Work Folder;
Persist Security Info=False;"; //connect to specific DB
        }

        private void txtStaffName_Enter(object sender, EventArgs e)
        {
            if(txtStaffName.Text == "Full Name")
            {
                txtStaffName.Text = "";

                txtStaffName.ForeColor = Color.Black;
            }
        }

        private void txtStaffName_Leave(object sender, EventArgs e)
        {
            if(txtStaffName.Text == "")
            {
                txtStaffName.Text = "Full Name";

                txtStaffName.ForeColor = Color.Silver;
            }
        }

        private void txtMemberName_Enter(object sender, EventArgs e)
        {
            if(txtMemberName.Text == "Full Name")
            {
                txtMemberName.Text = "";

                txtMemberName.ForeColor = Color.Black;
            }
        }

        private void txtMemberName_Leave(object sender, EventArgs e)
        {
            if(txtMemberName.Text == "")
            {
                txtMemberName.Text = "Full Name";

                txtMemberName.ForeColor = Color.Silver;
            }
        }

        private void txtDate_Enter(object sender, EventArgs e)
        {
            if(txtDate.Text == "MM/DD/YYYY")
            {
                txtDate.Text = "";

                txtDate.ForeColor = Color.Black;
            }
        }

        private void txtDate_Leave(object sender, EventArgs e)
        {
            if(txtDate.Text == "")
            {
                txtDate.Text = "MM/DD/YYYY";

                txtDate.ForeColor = Color.Silver;
            }
        }

        private void richTextBox1_Enter(object sender, EventArgs e)
        {
            if(richTextBox1.Text == "Enter any comments about the outreach")
            {
                richTextBox1.Text = "";

                richTextBox1.ForeColor = Color.Black;
            }
        }

        private void richTextBox1_Leave(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                richTextBox1.Text = "Enter any comments about the outreach";

                txtDate.ForeColor = Color.Silver;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}
