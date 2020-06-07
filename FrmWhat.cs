using System;
using System.Windows.Forms;

namespace FileArrangement
{
    public partial class FrmWhat : Form
    {
        public FrmWhat()
        {
            InitializeComponent();
        }

        //Close the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Calls the Main Form to allow the user to copy the files from one directory to another.
        private void btnCopyForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain main = new frmMain();
            main.ShowDialog();
            Application.Exit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDelete ud = new frmDelete();
            ud.ShowDialog();
            Application.Exit();
        }
    }
}
