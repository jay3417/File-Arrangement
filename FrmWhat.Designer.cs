namespace FileArrangement
{
    partial class FrmWhat
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWhat));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblOptions = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCopyForm = new System.Windows.Forms.Button();
            this.lblCopyDescrp = new System.Windows.Forms.Label();
            this.lblDeleteDescrp = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblExitDescrp = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lblExitDescrp);
            this.pnlMain.Controls.Add(this.btnExit);
            this.pnlMain.Controls.Add(this.lblDeleteDescrp);
            this.pnlMain.Controls.Add(this.btnDelete);
            this.pnlMain.Controls.Add(this.lblCopyDescrp);
            this.pnlMain.Controls.Add(this.btnCopyForm);
            this.pnlMain.Controls.Add(this.lblOptions);
            this.pnlMain.Controls.Add(this.label4);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(524, 330);
            this.pnlMain.TabIndex = 0;
            // 
            // lblOptions
            // 
            this.lblOptions.AutoSize = true;
            this.lblOptions.Location = new System.Drawing.Point(10, 26);
            this.lblOptions.Margin = new System.Windows.Forms.Padding(2);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(92, 13);
            this.lblOptions.TabIndex = 6;
            this.lblOptions.Text = "Choose an Option";
            this.lblOptions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 2);
            this.label4.Margin = new System.Windows.Forms.Padding(2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Welcome to File Arrangement";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCopyForm
            // 
            this.btnCopyForm.Location = new System.Drawing.Point(13, 70);
            this.btnCopyForm.Name = "btnCopyForm";
            this.btnCopyForm.Size = new System.Drawing.Size(115, 37);
            this.btnCopyForm.TabIndex = 7;
            this.btnCopyForm.Text = "Copy";
            this.btnCopyForm.UseVisualStyleBackColor = true;
            this.btnCopyForm.Click += new System.EventHandler(this.btnCopyForm_Click);
            // 
            // lblCopyDescrp
            // 
            this.lblCopyDescrp.AutoSize = true;
            this.lblCopyDescrp.Location = new System.Drawing.Point(147, 75);
            this.lblCopyDescrp.Margin = new System.Windows.Forms.Padding(2);
            this.lblCopyDescrp.MaximumSize = new System.Drawing.Size(310, 0);
            this.lblCopyDescrp.Name = "lblCopyDescrp";
            this.lblCopyDescrp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCopyDescrp.Size = new System.Drawing.Size(284, 26);
            this.lblCopyDescrp.TabIndex = 8;
            this.lblCopyDescrp.Text = "The copy button allows the users to trasnfer file(s) from the source directory to" +
    " target directory";
            this.lblCopyDescrp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDeleteDescrp
            // 
            this.lblDeleteDescrp.AutoSize = true;
            this.lblDeleteDescrp.Location = new System.Drawing.Point(147, 174);
            this.lblDeleteDescrp.Margin = new System.Windows.Forms.Padding(2);
            this.lblDeleteDescrp.MaximumSize = new System.Drawing.Size(310, 0);
            this.lblDeleteDescrp.Name = "lblDeleteDescrp";
            this.lblDeleteDescrp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDeleteDescrp.Size = new System.Drawing.Size(310, 26);
            this.lblDeleteDescrp.TabIndex = 10;
            this.lblDeleteDescrp.Text = "The delete button allows the users to delete files from the source directory";
            this.lblDeleteDescrp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(13, 169);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 37);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblExitDescrp
            // 
            this.lblExitDescrp.AutoSize = true;
            this.lblExitDescrp.Location = new System.Drawing.Point(147, 280);
            this.lblExitDescrp.Margin = new System.Windows.Forms.Padding(2);
            this.lblExitDescrp.MaximumSize = new System.Drawing.Size(310, 0);
            this.lblExitDescrp.Name = "lblExitDescrp";
            this.lblExitDescrp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblExitDescrp.Size = new System.Drawing.Size(183, 13);
            this.lblExitDescrp.TabIndex = 12;
            this.lblExitDescrp.Text = "The exit button closes the application";
            this.lblExitDescrp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(13, 268);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 37);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmWhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 330);
            this.Controls.Add(this.pnlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmWhat";
            this.Text = "File Arrangement";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCopyForm;
        private System.Windows.Forms.Label lblExitDescrp;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblDeleteDescrp;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblCopyDescrp;
    }
}