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
    public partial class frmEdit : Form
    {
        OleDbConnection connect = new OleDbConnection();
        public frmEdit()
        {
            InitializeComponent();
            connect.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\SyncShareState\Hero House\Our Work Folder;
Persist Security Info=False;"; //connect to specific DB
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connect;
                /*
                //insert inputed data into Practice Access Database
                command.CommandText = "INSERT INTO EmployeeData (FirstName,LastName,DOB,Country,Pay,Username,PassW) VALUES ('"+ txtFirstName.Text + "', '" + txtLastName.Text + "', '" + txtDOB.Text + "', '" + txtCountry.Text + "', '" + txtPay.Text + "', '" + txtUsername.Text + "', '" + txtPw.Text + "')";
                //executes the query
                */
                //inster inputed data into HERO HOUSE DATABASE
                //Must input more data because of required fields in Access Database
                //Must input in other tables

                string query = "INSERT INTO EmailAddress (EmailAddress) VALUES ('" + txtEmail.Text + "');";
                //query += "\rINSERT INTO EmailAddress (EmailAddress) VALUES ('" + txtEmergencyEmail.Text + "');";
                //query += "\rINSERT INTO Member (FirstName, LastName, MI, Phone1, Phone2, Email, DOB, Gender, ProgramStartDate, Status, CreatedDate) VALUES ('" + txtFirstName.Text + "', '" + txtLastName.Text + "', '" + txtMI.Text + "', '" + txtPhone1.Text + "', '" + txtPhone2.Text + "', '" + txtEmail.Text + "', '" + txtDOB.Text + "', '" + txtGender.Text + "', '" + txtProgramDate.Text + "', '" + txtStatus.Text + "', '" + txtJoinDate.Text + "');";
                MessageBox.Show(query);
                command.CommandText = query;
                command.ExecuteNonQuery();

                MessageBox.Show("Data Saved");
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFirstName_Enter(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "Jane")
            {
                txtFirstName.Text = "";

                txtFirstName.ForeColor = Color.Black;
            }
        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "")
            {
                txtFirstName.Text = "Jane";

                txtFirstName.ForeColor = Color.Silver;
            }
        }

        private void txtLastName_Enter(object sender, EventArgs e)
        {
            if (txtLastName.Text == "Doe")
            {
                txtLastName.Text = "";

                txtLastName.ForeColor = Color.Black;
            }
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            if (txtLastName.Text == "")
            {
                txtLastName.Text = "Doe";

                txtLastName.ForeColor = Color.Silver;
            }
        }

        private void txtDOB_Enter(object sender, EventArgs e)
        {
            if (txtDOB.Text == "MM/DD/YYYY")
            {
                txtDOB.Text = "";

                txtDOB.ForeColor = Color.Black;
            }
        }

        private void txtDOB_Leave(object sender, EventArgs e)
        {
            if (txtDOB.Text == "")
            {
                txtDOB.Text = "MM/DD/YYYY";

                txtDOB.ForeColor = Color.Silver;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "example@someone.com")
            {
                txtEmail.Text = "";

                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "example@someone.com";

                txtEmail.ForeColor = Color.Silver;
            }
        }

        private void txtPhone_Enter(object sender, EventArgs e)
        {
            if (txtPhone.Text == "(XXX) XXX-XXXX")
            {
                txtPhone.Text = "";

                txtPhone.ForeColor = Color.Black;
            }
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            if (txtPhone.Text == "")
            {
                txtPhone.Text = "(XXX) XXX-XXXX";

                txtPhone.ForeColor = Color.Silver;
            }
        }

        private void txtEnrollmentDate_Enter(object sender, EventArgs e)
        {
            if (txtEnrollmentDate.Text == "MM/DD/YYYY")
            {
                txtEnrollmentDate.Text = "";

                txtEnrollmentDate.ForeColor = Color.Black;
            }
        }

        private void txtEnrollmentDate_Leave(object sender, EventArgs e)
        {
            if (txtEnrollmentDate.Text == "")
            {
                txtEnrollmentDate.Text = "MM/DD/YYYY";

                txtEnrollmentDate.ForeColor = Color.Silver;
            }
        }
    }
}
