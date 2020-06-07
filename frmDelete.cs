using System;
using System.Windows.Forms;

namespace FileArrangement
{
    public partial class frmDelete : Form
    {
        private enum TLFormType { uDelete };
        TLFormType currentForm;
        private ucDelete uDelete;

        public frmDelete()
        {
            InitializeComponent();
        }

        private void frmDelete_Load(object sender, EventArgs e)
        {
            LoadDelete();
        }

        private void LoadDelete()
        {
            if (uDelete == null)
                uDelete = new ucDelete();
            SetSinglePanel();
            splitContainer1.Panel1.Controls.Clear();
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel1.Controls.Add(uDelete);
            uDelete.Dock = DockStyle.Fill;
            uDelete.Visible = true;
            currentForm = TLFormType.uDelete;
        }

        private void SetSinglePanel()
        {
            splitContainer1.Panel1Collapsed = false;
            splitContainer1.Panel2Collapsed = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            uDelete.Process();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmWhat what = new FrmWhat();
            what.ShowDialog();
        }

        private void frmDelete_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.Cancel)
                switch (MessageBox.Show(this, "Do you want to close the application...?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    case DialogResult.No:
                        e.Cancel = true;
                        break;
                    default:
                        e.Cancel = false;
                        break;
                }
        }
    }
}
