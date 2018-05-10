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
    public partial class LoginApp : Form
    {
        private OleDbConnection connect = new OleDbConnection(); //create OleDB connection
        public LoginApp()
        {
            InitializeComponent();
            connect.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\SyncShareState\Hero House\Our Work Folder;
Persist Security Info=False;"; //connect to specific DB
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                txtPassword.Focus();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnLogin.PerformClick();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            connect.Open(); //open DB
            OleDbCommand command = new OleDbCommand();
            command.Connection = connect;
            command.CommandText = "SELECT * FROM Login WHERE UserName = '" + txtUsername.Text + "' and PassW = '" + txtPassword.Text + "'";

            OleDbDataReader reader = command.ExecuteReader();
            int count = 0;
            while(reader.Read())
            {
                count++;
            }

            if(count == 1)
            {
                MessageBox.Show("Username and password are correct");
                connect.Close();
                connect.Dispose(); //dispose of all connections
                this.Hide(); //hide login form
                /*frmMain main = new frmMain(); //creates an instance of frmMain
                main.ShowDialog(); //shows frmMain*/
                frmChoice choice = new frmChoice();
                choice.ShowDialog();
            }
            else if(count > 1)
            {
                MessageBox.Show("Duplicate Username and Password");
            }
            else
            {
                MessageBox.Show("Username and password are incorrect");
            }
            connect.Close(); //ALWAYS close connection
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginApp_Load(object sender, EventArgs e) //connects to Access DB
        {
            try
            {
                connect.Open(); //open DB
                lblConnection.Text = "Connection Successful"; //notify connection is successful
                connect.Close(); //ALWAYS close connection
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }
        }
    }
}
