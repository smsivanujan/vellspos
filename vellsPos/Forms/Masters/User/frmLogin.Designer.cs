namespace vellsPos.Forms.Masters.user
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.btn_close = new System.Windows.Forms.Button();
            this.pnl_head = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.pnl_numberKeyPad = new System.Windows.Forms.Panel();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_backSpace = new System.Windows.Forms.Button();
            this.btn_num0 = new System.Windows.Forms.Button();
            this.btn_num4 = new System.Windows.Forms.Button();
            this.btn_numDot3 = new System.Windows.Forms.Button();
            this.btn_num2 = new System.Windows.Forms.Button();
            this.btn_num1 = new System.Windows.Forms.Button();
            this.btn_num6 = new System.Windows.Forms.Button();
            this.btn_num7 = new System.Windows.Forms.Button();
            this.btn_num5 = new System.Windows.Forms.Button();
            this.btn_num10 = new System.Windows.Forms.Button();
            this.btn_num8 = new System.Windows.Forms.Button();
            this.pnl_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnl_numberKeyPad.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.Color.Transparent;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(550, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(31, 30);
            this.btn_close.TabIndex = 4;
            this.btn_close.UseVisualStyleBackColor = false;
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnl_head.Controls.Add(this.lbl_title);
            this.pnl_head.Controls.Add(this.btn_close);
            this.pnl_head.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_head.Location = new System.Drawing.Point(0, 0);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(593, 53);
            this.pnl_head.TabIndex = 1;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(12, 11);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(78, 32);
            this.lbl_title.TabIndex = 5;
            this.lbl_title.Text = "Login";
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_username.Location = new System.Drawing.Point(68, 66);
            this.txt_username.Multiline = true;
            this.txt_username.Name = "txt_username";
            this.txt_username.PlaceholderText = "username";
            this.txt_username.Size = new System.Drawing.Size(287, 40);
            this.txt_username.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 129);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_password.Location = new System.Drawing.Point(68, 136);
            this.txt_password.Multiline = true;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.PlaceholderText = "password";
            this.txt_password.Size = new System.Drawing.Size(287, 40);
            this.txt_password.TabIndex = 8;
            this.txt_password.Enter += new System.EventHandler(this.txt_password_Enter);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.LightGreen;
            this.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.ForeColor = System.Drawing.Color.Transparent;
            this.btn_login.Image = ((System.Drawing.Image)(resources.GetObject("btn_login.Image")));
            this.btn_login.Location = new System.Drawing.Point(12, 198);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(343, 55);
            this.btn_login.TabIndex = 9;
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // pnl_numberKeyPad
            // 
            this.pnl_numberKeyPad.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_numberKeyPad.Controls.Add(this.btn_clear);
            this.pnl_numberKeyPad.Controls.Add(this.btn_backSpace);
            this.pnl_numberKeyPad.Controls.Add(this.btn_num0);
            this.pnl_numberKeyPad.Controls.Add(this.btn_num4);
            this.pnl_numberKeyPad.Controls.Add(this.btn_numDot3);
            this.pnl_numberKeyPad.Controls.Add(this.btn_num2);
            this.pnl_numberKeyPad.Controls.Add(this.btn_num1);
            this.pnl_numberKeyPad.Controls.Add(this.btn_num6);
            this.pnl_numberKeyPad.Controls.Add(this.btn_num7);
            this.pnl_numberKeyPad.Controls.Add(this.btn_num5);
            this.pnl_numberKeyPad.Controls.Add(this.btn_num10);
            this.pnl_numberKeyPad.Controls.Add(this.btn_num8);
            this.pnl_numberKeyPad.Location = new System.Drawing.Point(373, 59);
            this.pnl_numberKeyPad.Name = "pnl_numberKeyPad";
            this.pnl_numberKeyPad.Size = new System.Drawing.Size(197, 254);
            this.pnl_numberKeyPad.TabIndex = 10;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_clear.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_clear.Location = new System.Drawing.Point(133, 190);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(55, 55);
            this.btn_clear.TabIndex = 13;
            this.btn_clear.Text = "C";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_backSpace
            // 
            this.btn_backSpace.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_backSpace.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_backSpace.Image = ((System.Drawing.Image)(resources.GetObject("btn_backSpace.Image")));
            this.btn_backSpace.Location = new System.Drawing.Point(11, 190);
            this.btn_backSpace.Name = "btn_backSpace";
            this.btn_backSpace.Size = new System.Drawing.Size(55, 55);
            this.btn_backSpace.TabIndex = 12;
            this.btn_backSpace.UseVisualStyleBackColor = false;
            this.btn_backSpace.Click += new System.EventHandler(this.btn_backSpace_Click);
            // 
            // btn_num0
            // 
            this.btn_num0.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_num0.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_num0.Location = new System.Drawing.Point(72, 190);
            this.btn_num0.Name = "btn_num0";
            this.btn_num0.Size = new System.Drawing.Size(55, 55);
            this.btn_num0.TabIndex = 10;
            this.btn_num0.Text = "0";
            this.btn_num0.UseVisualStyleBackColor = false;
            this.btn_num0.Click += new System.EventHandler(this.btn_num0_Click);
            // 
            // btn_num4
            // 
            this.btn_num4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_num4.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_num4.Location = new System.Drawing.Point(11, 68);
            this.btn_num4.Name = "btn_num4";
            this.btn_num4.Size = new System.Drawing.Size(55, 55);
            this.btn_num4.TabIndex = 3;
            this.btn_num4.Text = "4";
            this.btn_num4.UseVisualStyleBackColor = false;
            this.btn_num4.Click += new System.EventHandler(this.btn_num0_Click);
            // 
            // btn_numDot3
            // 
            this.btn_numDot3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_numDot3.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_numDot3.Location = new System.Drawing.Point(133, 129);
            this.btn_numDot3.Name = "btn_numDot3";
            this.btn_numDot3.Size = new System.Drawing.Size(55, 55);
            this.btn_numDot3.TabIndex = 8;
            this.btn_numDot3.Text = "3";
            this.btn_numDot3.UseVisualStyleBackColor = false;
            this.btn_numDot3.Click += new System.EventHandler(this.btn_num0_Click);
            // 
            // btn_num2
            // 
            this.btn_num2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_num2.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_num2.Location = new System.Drawing.Point(72, 129);
            this.btn_num2.Name = "btn_num2";
            this.btn_num2.Size = new System.Drawing.Size(55, 55);
            this.btn_num2.TabIndex = 7;
            this.btn_num2.Text = "2";
            this.btn_num2.UseVisualStyleBackColor = false;
            this.btn_num2.Click += new System.EventHandler(this.btn_num0_Click);
            // 
            // btn_num1
            // 
            this.btn_num1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_num1.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_num1.Location = new System.Drawing.Point(11, 129);
            this.btn_num1.Name = "btn_num1";
            this.btn_num1.Size = new System.Drawing.Size(55, 55);
            this.btn_num1.TabIndex = 1;
            this.btn_num1.Text = "1";
            this.btn_num1.UseVisualStyleBackColor = false;
            this.btn_num1.Click += new System.EventHandler(this.btn_num0_Click);
            // 
            // btn_num6
            // 
            this.btn_num6.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_num6.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_num6.Location = new System.Drawing.Point(133, 68);
            this.btn_num6.Name = "btn_num6";
            this.btn_num6.Size = new System.Drawing.Size(55, 55);
            this.btn_num6.TabIndex = 5;
            this.btn_num6.Text = "6";
            this.btn_num6.UseVisualStyleBackColor = false;
            this.btn_num6.Click += new System.EventHandler(this.btn_num0_Click);
            // 
            // btn_num7
            // 
            this.btn_num7.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_num7.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_num7.Location = new System.Drawing.Point(11, 7);
            this.btn_num7.Name = "btn_num7";
            this.btn_num7.Size = new System.Drawing.Size(55, 55);
            this.btn_num7.TabIndex = 0;
            this.btn_num7.Text = "7";
            this.btn_num7.UseVisualStyleBackColor = false;
            this.btn_num7.Click += new System.EventHandler(this.btn_num0_Click);
            // 
            // btn_num5
            // 
            this.btn_num5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_num5.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_num5.Location = new System.Drawing.Point(72, 68);
            this.btn_num5.Name = "btn_num5";
            this.btn_num5.Size = new System.Drawing.Size(55, 55);
            this.btn_num5.TabIndex = 4;
            this.btn_num5.Text = "5";
            this.btn_num5.UseVisualStyleBackColor = false;
            this.btn_num5.Click += new System.EventHandler(this.btn_num0_Click);
            // 
            // btn_num10
            // 
            this.btn_num10.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_num10.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_num10.Location = new System.Drawing.Point(133, 7);
            this.btn_num10.Name = "btn_num10";
            this.btn_num10.Size = new System.Drawing.Size(55, 55);
            this.btn_num10.TabIndex = 2;
            this.btn_num10.Text = "9";
            this.btn_num10.UseVisualStyleBackColor = false;
            this.btn_num10.Click += new System.EventHandler(this.btn_num0_Click);
            // 
            // btn_num8
            // 
            this.btn_num8.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_num8.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_num8.Location = new System.Drawing.Point(72, 7);
            this.btn_num8.Name = "btn_num8";
            this.btn_num8.Size = new System.Drawing.Size(55, 55);
            this.btn_num8.TabIndex = 1;
            this.btn_num8.Text = "8";
            this.btn_num8.UseVisualStyleBackColor = false;
            this.btn_num8.Click += new System.EventHandler(this.btn_num0_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(593, 332);
            this.Controls.Add(this.pnl_numberKeyPad);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.pnl_head);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login ";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.pnl_head.ResumeLayout(false);
            this.pnl_head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnl_numberKeyPad.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_close;
        private Panel pnl_head;
        private Label lbl_title;
        private TextBox txt_username;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox txt_password;
        private Button btn_login;
        private Panel pnl_numberKeyPad;
        private Button btn_clear;
        private Button btn_backSpace;
        private Button btn_num0;
        private Button btn_num4;
        private Button btn_numDot3;
        private Button btn_num2;
        private Button btn_num1;
        private Button btn_num6;
        private Button btn_num7;
        private Button btn_num5;
        private Button btn_num10;
        private Button btn_num8;
    }
}