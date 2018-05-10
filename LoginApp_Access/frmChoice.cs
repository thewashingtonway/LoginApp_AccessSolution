using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApp_Access
{
    public partial class frmChoice : Form
    {
        public frmChoice()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmNewMember newMember = new frmNewMember();
            this.Hide();
            newMember.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmEdit edit = new frmEdit();
            this.Hide();
            edit.ShowDialog();
        }

        private void btnOutreach_Click(object sender, EventArgs e)
        {
            frmAddNewOutreach outreach = new frmAddNewOutreach();
            this.Hide();
            outreach.ShowDialog();
        }
    }
}
