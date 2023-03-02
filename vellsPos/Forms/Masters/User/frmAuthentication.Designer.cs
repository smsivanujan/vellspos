namespace vellsPos.Forms.Masters.User
{
    partial class frmAuthentication
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
            this.pnl_tabBar = new System.Windows.Forms.Panel();
            this.tb_authentication = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.tb = new System.Windows.Forms.TabPage();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_tabBar.SuspendLayout();
            this.tb_authentication.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tb.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_tabBar
            // 
            this.pnl_tabBar.Controls.Add(this.tb_authentication);
            this.pnl_tabBar.Location = new System.Drawing.Point(12, 140);
            this.pnl_tabBar.Name = "pnl_tabBar";
            this.pnl_tabBar.Size = new System.Drawing.Size(966, 448);
            this.pnl_tabBar.TabIndex = 0;
            // 
            // tb_authentication
            // 
            this.tb_authentication.Controls.Add(this.tabPage1);
            this.tb_authentication.Controls.Add(this.tb);
            this.tb_authentication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_authentication.Location = new System.Drawing.Point(0, 0);
            this.tb_authentication.Name = "tb_authentication";
            this.tb_authentication.SelectedIndex = 0;
            this.tb_authentication.Size = new System.Drawing.Size(966, 448);
            this.tb_authentication.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkedListBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(958, 420);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(3, 3);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(952, 414);
            this.checkedListBox1.TabIndex = 0;
            // 
            // tb
            // 
            this.tb.Controls.Add(this.checkedListBox2);
            this.tb.Location = new System.Drawing.Point(4, 24);
            this.tb.Name = "tb";
            this.tb.Padding = new System.Windows.Forms.Padding(3);
            this.tb.Size = new System.Drawing.Size(958, 420);
            this.tb.TabIndex = 1;
            this.tb.Text = "tabPage2";
            this.tb.UseVisualStyleBackColor = true;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Location = new System.Drawing.Point(3, 3);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(952, 414);
            this.checkedListBox2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(966, 122);
            this.panel1.TabIndex = 1;
            // 
            // frmAuthentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_tabBar);
            this.Name = "frmAuthentication";
            this.Text = "Authentication  ";
            this.Load += new System.EventHandler(this.frmAuthentication_Load);
            this.pnl_tabBar.ResumeLayout(false);
            this.tb_authentication.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tb.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnl_tabBar;
        private TabControl tb_authentication;
        private TabPage tabPage1;
        private CheckedListBox checkedListBox1;
        private TabPage tb;
        private CheckedListBox checkedListBox2;
        private Panel panel1;
    }
}