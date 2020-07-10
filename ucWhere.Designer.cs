namespace FileArrangement
{
    partial class ucWhere
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnSource = new System.Windows.Forms.Button();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.lblSource = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDestination = new System.Windows.Forms.Button();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.lblDestination = new System.Windows.Forms.Label();
            this.pnlCal = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblProgressPercent = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSourceNo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNoFilesTransferred = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDestNo = new System.Windows.Forms.Label();
            this.pnlFolderInfo = new System.Windows.Forms.Panel();
            this.lblDtSelect = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDateChosen = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlCal.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlFolderInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnSource);
            this.pnlTop.Controls.Add(this.txtSource);
            this.pnlTop.Controls.Add(this.lblSource);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(523, 21);
            this.pnlTop.TabIndex = 0;
            // 
            // btnSource
            // 
            this.btnSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSource.Location = new System.Drawing.Point(479, 0);
            this.btnSource.Margin = new System.Windows.Forms.Padding(2);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(41, 21);
            this.btnSource.TabIndex = 2;
            this.btnSource.Text = "...";
            this.btnSource.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSource.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnSource.UseVisualStyleBackColor = true;
            this.btnSource.Click += new System.EventHandler(this.btnSource_Click);
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(70, 1);
            this.txtSource.Margin = new System.Windows.Forms.Padding(2);
            this.txtSource.Name = "txtSource";
            this.txtSource.ReadOnly = true;
            this.txtSource.Size = new System.Drawing.Size(403, 20);
            this.txtSource.TabIndex = 1;
            this.txtSource.TextChanged += new System.EventHandler(this.txtSource_TextChanged);
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(3, 4);
            this.lblSource.Margin = new System.Windows.Forms.Padding(2);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(44, 13);
            this.lblSource.TabIndex = 0;
            this.lblSource.Text = "Source:";
            this.lblSource.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDestination);
            this.panel1.Controls.Add(this.txtDestination);
            this.panel1.Controls.Add(this.lblDestination);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 21);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 21);
            this.panel1.TabIndex = 1;
            // 
            // btnDestination
            // 
            this.btnDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDestination.Location = new System.Drawing.Point(479, 0);
            this.btnDestination.Margin = new System.Windows.Forms.Padding(2);
            this.btnDestination.Name = "btnDestination";
            this.btnDestination.Size = new System.Drawing.Size(41, 21);
            this.btnDestination.TabIndex = 2;
            this.btnDestination.Text = "...";
            this.btnDestination.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDestination.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnDestination.UseVisualStyleBackColor = true;
            this.btnDestination.Click += new System.EventHandler(this.btnDestination_Click);
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(70, 1);
            this.txtDestination.Margin = new System.Windows.Forms.Padding(2);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.ReadOnly = true;
            this.txtDestination.Size = new System.Drawing.Size(403, 20);
            this.txtDestination.TabIndex = 1;
            this.txtDestination.TextChanged += new System.EventHandler(this.txtDestination_TextChanged);
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(3, 4);
            this.lblDestination.Margin = new System.Windows.Forms.Padding(2);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(63, 13);
            this.lblDestination.TabIndex = 0;
            this.lblDestination.Text = "Destination:";
            this.lblDestination.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlCal
            // 
            this.pnlCal.Controls.Add(this.label5);
            this.pnlCal.Controls.Add(this.label4);
            this.pnlCal.Controls.Add(this.monthCalendar1);
            this.pnlCal.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCal.Location = new System.Drawing.Point(0, 84);
            this.pnlCal.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCal.Name = "pnlCal";
            this.pnlCal.Size = new System.Drawing.Size(318, 285);
            this.pnlCal.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Select a Date:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 4);
            this.label4.Margin = new System.Windows.Forms.Padding(2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Calendar";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(56, 52);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 63);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(523, 21);
            this.panel3.TabIndex = 3;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(70, 0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(403, 20);
            this.progressBar1.TabIndex = 0;
            // 
            // lblProgressPercent
            // 
            this.lblProgressPercent.AutoSize = true;
            this.lblProgressPercent.Location = new System.Drawing.Point(483, 4);
            this.lblProgressPercent.Margin = new System.Windows.Forms.Padding(2);
            this.lblProgressPercent.Name = "lblProgressPercent";
            this.lblProgressPercent.Size = new System.Drawing.Size(21, 13);
            this.lblProgressPercent.TabIndex = 1;
            this.lblProgressPercent.Text = "0%";
            this.lblProgressPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblProgressPercent);
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(523, 21);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Folder Transfer Info";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Source";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Num of files:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSourceNo
            // 
            this.lblSourceNo.AutoSize = true;
            this.lblSourceNo.Location = new System.Drawing.Point(110, 93);
            this.lblSourceNo.Margin = new System.Windows.Forms.Padding(2);
            this.lblSourceNo.Name = "lblSourceNo";
            this.lblSourceNo.Size = new System.Drawing.Size(28, 13);
            this.lblSourceNo.TabIndex = 4;
            this.lblSourceNo.Text = "XXX";
            this.lblSourceNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 127);
            this.label7.Margin = new System.Windows.Forms.Padding(2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Transfer";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 151);
            this.label6.Margin = new System.Windows.Forms.Padding(2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Files Transferred:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNoFilesTransferred
            // 
            this.lblNoFilesTransferred.AutoSize = true;
            this.lblNoFilesTransferred.Location = new System.Drawing.Point(110, 151);
            this.lblNoFilesTransferred.Margin = new System.Windows.Forms.Padding(2);
            this.lblNoFilesTransferred.Name = "lblNoFilesTransferred";
            this.lblNoFilesTransferred.Size = new System.Drawing.Size(28, 13);
            this.lblNoFilesTransferred.TabIndex = 7;
            this.lblNoFilesTransferred.Text = "XXX";
            this.lblNoFilesTransferred.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(2, 177);
            this.label9.Margin = new System.Windows.Forms.Padding(2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Destination";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 201);
            this.label8.Margin = new System.Windows.Forms.Padding(2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Num of files:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDestNo
            // 
            this.lblDestNo.AutoSize = true;
            this.lblDestNo.Location = new System.Drawing.Point(110, 201);
            this.lblDestNo.Margin = new System.Windows.Forms.Padding(2);
            this.lblDestNo.Name = "lblDestNo";
            this.lblDestNo.Size = new System.Drawing.Size(28, 13);
            this.lblDestNo.TabIndex = 10;
            this.lblDestNo.Text = "XXX";
            this.lblDestNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlFolderInfo
            // 
            this.pnlFolderInfo.Controls.Add(this.lblDtSelect);
            this.pnlFolderInfo.Controls.Add(this.lblDate);
            this.pnlFolderInfo.Controls.Add(this.lblDestNo);
            this.pnlFolderInfo.Controls.Add(this.lblDateChosen);
            this.pnlFolderInfo.Controls.Add(this.label8);
            this.pnlFolderInfo.Controls.Add(this.label9);
            this.pnlFolderInfo.Controls.Add(this.lblNoFilesTransferred);
            this.pnlFolderInfo.Controls.Add(this.label6);
            this.pnlFolderInfo.Controls.Add(this.label7);
            this.pnlFolderInfo.Controls.Add(this.lblSourceNo);
            this.pnlFolderInfo.Controls.Add(this.label3);
            this.pnlFolderInfo.Controls.Add(this.label2);
            this.pnlFolderInfo.Controls.Add(this.label1);
            this.pnlFolderInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlFolderInfo.Location = new System.Drawing.Point(323, 84);
            this.pnlFolderInfo.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFolderInfo.Name = "pnlFolderInfo";
            this.pnlFolderInfo.Size = new System.Drawing.Size(200, 285);
            this.pnlFolderInfo.TabIndex = 5;
            // 
            // lblDtSelect
            // 
            this.lblDtSelect.AutoSize = true;
            this.lblDtSelect.Location = new System.Drawing.Point(18, 52);
            this.lblDtSelect.Margin = new System.Windows.Forms.Padding(2);
            this.lblDtSelect.Name = "lblDtSelect";
            this.lblDtSelect.Size = new System.Drawing.Size(78, 13);
            this.lblDtSelect.TabIndex = 11;
            this.lblDtSelect.Text = "Date Selected:";
            this.lblDtSelect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(110, 52);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(28, 13);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "XXX";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDateChosen
            // 
            this.lblDateChosen.AutoSize = true;
            this.lblDateChosen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateChosen.Location = new System.Drawing.Point(2, 28);
            this.lblDateChosen.Margin = new System.Windows.Forms.Padding(2);
            this.lblDateChosen.Name = "lblDateChosen";
            this.lblDateChosen.Size = new System.Drawing.Size(44, 20);
            this.lblDateChosen.TabIndex = 5;
            this.lblDateChosen.Text = "Date";
            this.lblDateChosen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ucWhere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlFolderInfo);
            this.Controls.Add(this.pnlCal);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucWhere";
            this.Size = new System.Drawing.Size(523, 369);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlCal.ResumeLayout(false);
            this.pnlCal.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlFolderInfo.ResumeLayout(false);
            this.pnlFolderInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Button btnSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDestination;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Panel pnlCal;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblProgressPercent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSourceNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label lblNoFilesTransferred;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDestNo;
        private System.Windows.Forms.Panel pnlFolderInfo;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDateChosen;
        private System.Windows.Forms.Label lblDtSelect;
    }
}
