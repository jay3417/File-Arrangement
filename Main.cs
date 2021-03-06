﻿using System;
using System.Windows.Forms;

namespace FileArrangement
{
    public partial class frmMain : Form
    {
        private enum TLFormType { where };
        TLFormType currentForm;
        private ucWhere where;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadWhere();
        }

        private void LoadWhere()
        {
            if (where == null)
                where = new ucWhere();
            SetSinglePanel();
            splitContainer1.Panel1.Controls.Clear();
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel1.Controls.Add(where);
            where.Dock = DockStyle.Fill;
            where.Visible = true;
            currentForm = TLFormType.where;
        }

        private void SetSinglePanel()
        {
            splitContainer1.Panel1Collapsed = false;
            splitContainer1.Panel2Collapsed = true;
        }

        //Move file(s) from source to target directory
        private void btnCopy_Click(object sender, EventArgs e)
        {
            where.Process();
        }

        //Go back to home page
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmWhat what = new FrmWhat();
            what.ShowDialog();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.Cancel)
                switch (MessageBox.Show(this,"Do you want to close the application...?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
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
