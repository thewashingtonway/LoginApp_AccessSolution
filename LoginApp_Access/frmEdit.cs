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
        private OleDbConnection connect = new OleDbConnection();
        public frmEdit()
        {
            InitializeComponent();
            connect.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\lockj\OneDrive\Documents\School Work\Spring 18\ISIT 491\HeroHouse12.accdb;
Persist Security Info=False;"; //connect to specific DB
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click_1(object sender, EventArgs e)
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

        }
    }
}
