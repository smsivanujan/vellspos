namespace vellsPos.Forms.Masters.Other
{
    partial class frmDBUpload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDBUpload));
            this.pbar_progressBarBackup = new System.Windows.Forms.ProgressBar();
            this.btn_backupToLocal = new System.Windows.Forms.Button();
            this.btn_browseTo = new System.Windows.Forms.Button();
            this.txt_localPathBackup = new System.Windows.Forms.TextBox();
            this.btn_backupToServer = new System.Windows.Forms.Button();
            this.pnl_rectancle = new System.Windows.Forms.Panel();
            this.txt_serverPathBackup = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_upload = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbar_progressBarRestore = new System.Windows.Forms.ProgressBar();
            this.btn_restoreFromLocal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_localPathRestore = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_restoreFromServer = new System.Windows.Forms.Button();
            this.btn_browseFrom = new System.Windows.Forms.Button();
            this.txt_serverPathRestore = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_syncDatabase = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.gb_upload.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbar_progressBarBackup
            // 
            this.pbar_progressBarBackup.Location = new System.Drawing.Point(23, 180);
            this.pbar_progressBarBackup.Name = "pbar_progressBarBackup";
            this.pbar_progressBarBackup.Size = new System.Drawing.Size(608, 31);
            this.pbar_progressBarBackup.TabIndex = 62;
            // 
            // btn_backupToLocal
            // 
            this.btn_backupToLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(218)))), ((int)(((byte)(81)))));
            this.btn_backupToLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_backupToLocal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_backupToLocal.Image = ((System.Drawing.Image)(resources.GetObject("btn_backupToLocal.Image")));
            this.btn_backupToLocal.Location = new System.Drawing.Point(171, 119);
            this.btn_backupToLocal.Name = "btn_backupToLocal";
            this.btn_backupToLocal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_backupToLocal.Size = new System.Drawing.Size(212, 41);
            this.btn_backupToLocal.TabIndex = 91;
            this.btn_backupToLocal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_backupToLocal.UseVisualStyleBackColor = false;
            // 
            // btn_browseTo
            // 
            this.btn_browseTo.BackColor = System.Drawing.SystemColors.Control;
            this.btn_browseTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_browseTo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_browseTo.ForeColor = System.Drawing.Color.Black;
            this.btn_browseTo.Location = new System.Drawing.Point(23, 119);
            this.btn_browseTo.Name = "btn_browseTo";
            this.btn_browseTo.Size = new System.Drawing.Size(142, 41);
            this.btn_browseTo.TabIndex = 92;
            this.btn_browseTo.Text = "Backup To ";
            this.btn_browseTo.UseVisualStyleBackColor = false;
            // 
            // txt_localPathBackup
            // 
            this.txt_localPathBackup.Location = new System.Drawing.Point(23, 77);
            this.txt_localPathBackup.Multiline = true;
            this.txt_localPathBackup.Name = "txt_localPathBackup";
            this.txt_localPathBackup.Size = new System.Drawing.Size(360, 23);
            this.txt_localPathBackup.TabIndex = 93;
            // 
            // btn_backupToServer
            // 
            this.btn_backupToServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(218)))), ((int)(((byte)(81)))));
            this.btn_backupToServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_backupToServer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_backupToServer.Image = ((System.Drawing.Image)(resources.GetObject("btn_backupToServer.Image")));
            this.btn_backupToServer.Location = new System.Drawing.Point(419, 119);
            this.btn_backupToServer.Name = "btn_backupToServer";
            this.btn_backupToServer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_backupToServer.Size = new System.Drawing.Size(212, 41);
            this.btn_backupToServer.TabIndex = 94;
            this.btn_backupToServer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_backupToServer.UseVisualStyleBackColor = false;
            // 
            // pnl_rectancle
            // 
            this.pnl_rectancle.BackColor = System.Drawing.Color.Red;
            this.pnl_rectancle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_rectancle.Location = new System.Drawing.Point(389, 59);
            this.pnl_rectancle.Name = "pnl_rectancle";
            this.pnl_rectancle.Size = new System.Drawing.Size(10, 115);
            this.pnl_rectancle.TabIndex = 95;
            // 
            // txt_serverPathBackup
            // 
            this.txt_serverPathBackup.Location = new System.Drawing.Point(419, 77);
            this.txt_serverPathBackup.Multiline = true;
            this.txt_serverPathBackup.Name = "txt_serverPathBackup";
            this.txt_serverPathBackup.Size = new System.Drawing.Size(212, 23);
            this.txt_serverPathBackup.TabIndex = 96;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(23, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 30);
            this.label5.TabIndex = 97;
            this.label5.Text = "Local Path";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(419, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 30);
            this.label1.TabIndex = 98;
            this.label1.Text = "Cloud Path";
            // 
            // gb_upload
            // 
            this.gb_upload.Controls.Add(this.pbar_progressBarBackup);
            this.gb_upload.Controls.Add(this.btn_backupToLocal);
            this.gb_upload.Controls.Add(this.label1);
            this.gb_upload.Controls.Add(this.txt_localPathBackup);
            this.gb_upload.Controls.Add(this.label5);
            this.gb_upload.Controls.Add(this.btn_backupToServer);
            this.gb_upload.Controls.Add(this.btn_browseTo);
            this.gb_upload.Controls.Add(this.txt_serverPathBackup);
            this.gb_upload.Controls.Add(this.pnl_rectancle);
            this.gb_upload.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gb_upload.Location = new System.Drawing.Point(12, 12);
            this.gb_upload.Name = "gb_upload";
            this.gb_upload.Size = new System.Drawing.Size(669, 236);
            this.gb_upload.TabIndex = 99;
            this.gb_upload.TabStop = false;
            this.gb_upload.Text = "BackUp Database";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbar_progressBarRestore);
            this.groupBox1.Controls.Add(this.btn_restoreFromLocal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_localPathRestore);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_restoreFromServer);
            this.groupBox1.Controls.Add(this.btn_browseFrom);
            this.groupBox1.Controls.Add(this.txt_serverPathRestore);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 254);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 236);
            this.groupBox1.TabIndex = 100;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Restore Database";
            // 
            // pbar_progressBarRestore
            // 
            this.pbar_progressBarRestore.Location = new System.Drawing.Point(23, 180);
            this.pbar_progressBarRestore.Name = "pbar_progressBarRestore";
            this.pbar_progressBarRestore.Size = new System.Drawing.Size(608, 31);
            this.pbar_progressBarRestore.TabIndex = 62;
            // 
            // btn_restoreFromLocal
            // 
            this.btn_restoreFromLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(218)))), ((int)(((byte)(81)))));
            this.btn_restoreFromLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_restoreFromLocal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_restoreFromLocal.Image = ((System.Drawing.Image)(resources.GetObject("btn_restoreFromLocal.Image")));
            this.btn_restoreFromLocal.Location = new System.Drawing.Point(171, 119);
            this.btn_restoreFromLocal.Name = "btn_restoreFromLocal";
            this.btn_restoreFromLocal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_restoreFromLocal.Size = new System.Drawing.Size(212, 41);
            this.btn_restoreFromLocal.TabIndex = 91;
            this.btn_restoreFromLocal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_restoreFromLocal.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(419, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 30);
            this.label2.TabIndex = 98;
            this.label2.Text = "Cloud Path";
            // 
            // txt_localPathRestore
            // 
            this.txt_localPathRestore.Location = new System.Drawing.Point(23, 77);
            this.txt_localPathRestore.Multiline = true;
            this.txt_localPathRestore.Name = "txt_localPathRestore";
            this.txt_localPathRestore.Size = new System.Drawing.Size(360, 23);
            this.txt_localPathRestore.TabIndex = 93;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(23, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 30);
            this.label3.TabIndex = 97;
            this.label3.Text = "Local Path";
            // 
            // btn_restoreFromServer
            // 
            this.btn_restoreFromServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(218)))), ((int)(((byte)(81)))));
            this.btn_restoreFromServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_restoreFromServer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_restoreFromServer.Image = ((System.Drawing.Image)(resources.GetObject("btn_restoreFromServer.Image")));
            this.btn_restoreFromServer.Location = new System.Drawing.Point(419, 119);
            this.btn_restoreFromServer.Name = "btn_restoreFromServer";
            this.btn_restoreFromServer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_restoreFromServer.Size = new System.Drawing.Size(212, 41);
            this.btn_restoreFromServer.TabIndex = 94;
            this.btn_restoreFromServer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_restoreFromServer.UseVisualStyleBackColor = false;
            // 
            // btn_browseFrom
            // 
            this.btn_browseFrom.BackColor = System.Drawing.SystemColors.Control;
            this.btn_browseFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_browseFrom.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_browseFrom.ForeColor = System.Drawing.Color.Black;
            this.btn_browseFrom.Location = new System.Drawing.Point(23, 119);
            this.btn_browseFrom.Name = "btn_browseFrom";
            this.btn_browseFrom.Size = new System.Drawing.Size(142, 41);
            this.btn_browseFrom.TabIndex = 92;
            this.btn_browseFrom.Text = "Restore From";
            this.btn_browseFrom.UseVisualStyleBackColor = false;
            // 
            // txt_serverPathRestore
            // 
            this.txt_serverPathRestore.Location = new System.Drawing.Point(419, 77);
            this.txt_serverPathRestore.Multiline = true;
            this.txt_serverPathRestore.Name = "txt_serverPathRestore";
            this.txt_serverPathRestore.Size = new System.Drawing.Size(212, 23);
            this.txt_serverPathRestore.TabIndex = 96;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(389, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 115);
            this.panel1.TabIndex = 95;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_syncDatabase);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(701, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 236);
            this.groupBox2.TabIndex = 101;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sync Database From Server";
            // 
            // btn_syncDatabase
            // 
            this.btn_syncDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(218)))), ((int)(((byte)(81)))));
            this.btn_syncDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_syncDatabase.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_syncDatabase.Image = ((System.Drawing.Image)(resources.GetObject("btn_syncDatabase.Image")));
            this.btn_syncDatabase.Location = new System.Drawing.Point(47, 59);
            this.btn_syncDatabase.Name = "btn_syncDatabase";
            this.btn_syncDatabase.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_syncDatabase.Size = new System.Drawing.Size(212, 83);
            this.btn_syncDatabase.TabIndex = 99;
            this.btn_syncDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_syncDatabase.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(701, 254);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(307, 236);
            this.groupBox4.TabIndex = 106;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Auto Backup";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(218)))), ((int)(((byte)(81)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(47, 59);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(212, 83);
            this.button2.TabIndex = 99;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // frmDBUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 525);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_upload);
            this.Name = "frmDBUpload";
            this.Text = "DB Upload ";
            this.gb_upload.ResumeLayout(false);
            this.gb_upload.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ProgressBar pbar_progressBarBackup;
        private Button btn_backupToLocal;
        private TextBox txt_localPathBackup;
        private Button btn_backupToServer;
        private Button btn_browseTo;
        private Panel pnl_rectancle;
        private TextBox txt_serverPathBackup;
        private Label label5;
        private Label label1;
        private GroupBox gb_upload;
        private GroupBox groupBox1;
        private ProgressBar pbar_progressBarRestore;
        private Button btn_restoreFromLocal;
        private Label label2;
        private TextBox txt_localPathRestore;
        private Label label3;
        private Button btn_restoreFromServer;
        private Button btn_browseFrom;
        private TextBox txt_serverPathRestore;
        private Panel panel1;
        private GroupBox groupBox2;
        private Button btn_syncDatabase;
        private GroupBox groupBox4;
        private Button button2;
    }
}