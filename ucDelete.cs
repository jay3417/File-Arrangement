﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace FileArrangement
{
    public partial class ucDelete : UserControl
    {
        public string sourcePath { get; set; }
        public string selectedDate { get; set; }
        public int filecount { get; set; }
        public int targetCount { get; set; }    
        private int copiedFiles { get; set; }
        public ucDelete()
        {
            InitializeComponent();
            monthCalendar1.Enabled = false;
            lblDate.Text = System.DateTime.Today.ToShortDateString();
        }

        private void btnSource_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txtSource.Text = fbd.SelectedPath;
                    sourcePath = fbd.SelectedPath;
                }
            }
        }

        private void monthCalendar1_DateSelected_1(object sender, DateRangeEventArgs e)
        {
            selectedDate = e.Start.ToShortDateString();
            lblDate.Text = selectedDate;
            dateFilecountAdjuster(selectedDate);
        }

        //Allows the user to select a date where file count criteria would change.
        private void dateFilecountAdjuster(string dateSelected)
        {
            try
            {
                filecount = new int();
                string[] files = Directory.GetFiles(sourcePath, "*", SearchOption.TopDirectoryOnly);

                //Get the file count based on calendar date selection
                foreach (string cFile in files)
                {
                    string filename = Path.GetFileName(cFile);
                    DateTime fDt = Convert.ToDateTime(File.GetLastWriteTime(Path.Combine(sourcePath, filename)));
                    DateTime cDt = Convert.ToDateTime(dateSelected);

                    if (cDt == Convert.ToDateTime("01/01/0001"))
                        cDt = System.DateTime.Today;

                    if (fDt.Date < cDt.Date)
                        filecount++;
                }
                //Assign the file count to source label
                lblSourceNo.Text = filecount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtSource_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtSource.Text))
                sourcePath = null;
            else
            {
                sourcePath = txtSource.Text;
                filecount = (from file in Directory.EnumerateFiles(sourcePath, "*", SearchOption.TopDirectoryOnly) select file).Count();
                lblSourceNo.Text = filecount.ToString();
                monthCalendar1.Enabled = true;
            }
        }

        //Clear the applications (objects)
        private void clearApp()
        {
            try
            {
                //Reset the textboxes, progress bar and label percentage count
                txtSource.Text = string.Empty;
                progressBar1.Value = 0;
                lblProgressPercent.Text = string.Format("{0}%", progressBar1.Value);
                lblSourceNo.Text = "XXX";
                lblNoFilesTransferred.Text = "XXX";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }


        //Update the progress bar and percentage label
        private void updateBar(int bar)
        {
            try
            {
                this.BeginInvoke((Action)delegate ()
                {
                    progressBar1.Value = bar;
                    lblProgressPercent.Text = string.Format("{0}%", bar.ToString());
                    lblNoFilesTransferred.Text = Convert.ToString(copiedFiles + "/" + filecount);
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //Start the process operations and calls a task run method to move the files
        public async void Process()
        {
            try
            {
                //Verify if the source and destination text boxes are null or empty
                if (string.IsNullOrEmpty(txtSource.Text))
                {
                    MessageBox.Show("Source path can't be empty", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Verify if the source count is greater than zero, if not throw an error.
                if (lblSourceNo.Text == Convert.ToString(0))
                {
                    MessageBox.Show("There are no file(s) in source to move", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Run the process
                await Task.Run(() => DeleteFrom(sourcePath, selectedDate, filecount, new Progress<int>(updateBar)));
                clearApp();
            }
            catch (OperationCanceledException oce)
            {
                MessageBox.Show(oce.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //Operation where the file moves from one directory to another
        private void DeleteFrom(string source, string cDate, int fcount, IProgress<int> progressCallback = null)
        {
            string[] files = Directory.GetFiles(source, "*", SearchOption.TopDirectoryOnly);
            int j = 0;

            try
            {
                if (Directory.Exists(source))
                {
                    while (progressBar1.Value < 100)
                    {
                        //Move the files from source to directory
                        foreach (string cFile in files)
                        {
                            string filename = Path.GetFileName(cFile);
                            DateTime fDt = Convert.ToDateTime(File.GetLastWriteTime(Path.Combine(source, filename)));
                            DateTime cDt = Convert.ToDateTime(cDate);

                            if (cDt == Convert.ToDateTime("01/01/0001")) cDt = System.DateTime.Today;

                            if (fDt.Date < cDt.Date)
                                File.Delete(Path.Combine(source, filename));
                                //increment file count in dest
                                j++;
                                copiedFiles = j;

                            //Update the status bar
                            Thread.Sleep(10);
                            if (progressCallback != null) progressCallback.Report(j * 100 / fcount);
                        }
                        if ((j * 100 / fcount) == 100) MessageBox.Show(fcount + " file(s) successfully deleted!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
