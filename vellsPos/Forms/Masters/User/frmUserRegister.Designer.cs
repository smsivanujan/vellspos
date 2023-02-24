namespace vellsPos.Forms.Layouts
{
    partial class frmUserRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserRegister));
            this.pnl_head = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.pnl_root = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.pnl_body = new System.Windows.Forms.Panel();
            this.pnl_container = new System.Windows.Forms.Panel();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_branch = new System.Windows.Forms.ComboBox();
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_role = new System.Windows.Forms.ComboBox();
            this.pnl_head.SuspendLayout();
            this.pnl_root.SuspendLayout();
            this.pnl_body.SuspendLayout();
            this.pnl_container.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.pnl_head.Controls.Add(this.lbl_title);
            this.pnl_head.Controls.Add(this.btn_close);
            this.pnl_head.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_head.Location = new System.Drawing.Point(0, 0);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(427, 53);
            this.pnl_head.TabIndex = 0;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.Location = new System.Drawing.Point(12, 11);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(64, 32);
            this.lbl_title.TabIndex = 5;
            this.lbl_title.Text = "Title";
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.Color.Transparent;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(388, 11);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(31, 30);
            this.btn_close.TabIndex = 4;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // pnl_root
            // 
            this.pnl_root.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.pnl_root.Controls.Add(this.btn_delete);
            this.pnl_root.Controls.Add(this.btn_save);
            this.pnl_root.Controls.Add(this.btn_cancel);
            this.pnl_root.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_root.Location = new System.Drawing.Point(0, 529);
            this.pnl_root.Name = "pnl_root";
            this.pnl_root.Size = new System.Drawing.Size(427, 75);
            this.pnl_root.TabIndex = 1;
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(79, 12);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_delete.Size = new System.Drawing.Size(108, 51);
            this.btn_delete.TabIndex = 7;
            this.btn_delete.Text = "Delete";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(307, 12);
            this.btn_save.Name = "btn_save";
            this.btn_save.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_save.Size = new System.Drawing.Size(108, 51);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Save";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancel.Image")));
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(193, 12);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_cancel.Size = new System.Drawing.Size(108, 51);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // pnl_body
            // 
            this.pnl_body.Controls.Add(this.pnl_container);
            this.pnl_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_body.Location = new System.Drawing.Point(0, 53);
            this.pnl_body.Name = "pnl_body";
            this.pnl_body.Size = new System.Drawing.Size(427, 476);
            this.pnl_body.TabIndex = 2;
            // 
            // pnl_container
            // 
            this.pnl_container.Controls.Add(this.txt_id);
            this.pnl_container.Controls.Add(this.txt_password);
            this.pnl_container.Controls.Add(this.label1);
            this.pnl_container.Controls.Add(this.label2);
            this.pnl_container.Controls.Add(this.cmb_branch);
            this.pnl_container.Controls.Add(this.txt_userName);
            this.pnl_container.Controls.Add(this.label3);
            this.pnl_container.Controls.Add(this.label5);
            this.pnl_container.Controls.Add(this.cmb_role);
            this.pnl_container.Location = new System.Drawing.Point(12, 6);
            this.pnl_container.Name = "pnl_container";
            this.pnl_container.Size = new System.Drawing.Size(328, 464);
            this.pnl_container.TabIndex = 0;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(242, 60);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(47, 23);
            this.txt_id.TabIndex = 88;
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_password.Location = new System.Drawing.Point(15, 299);
            this.txt_password.Multiline = true;
            this.txt_password.Name = "txt_password";
            this.txt_password.PlaceholderText = "category";
            this.txt_password.Size = new System.Drawing.Size(221, 34);
            this.txt_password.TabIndex = 87;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 30);
            this.label1.TabIndex = 86;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Historic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 30);
            this.label2.TabIndex = 80;
            this.label2.Text = "Role";
            // 
            // cmb_branch
            // 
            this.cmb_branch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_branch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmb_branch.FormattingEnabled = true;
            this.cmb_branch.Location = new System.Drawing.Point(15, 132);
            this.cmb_branch.Name = "cmb_branch";
            this.cmb_branch.Size = new System.Drawing.Size(221, 33);
            this.cmb_branch.TabIndex = 85;
            // 
            // txt_userName
            // 
            this.txt_userName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_userName.Location = new System.Drawing.Point(15, 49);
            this.txt_userName.Multiline = true;
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.PlaceholderText = "category";
            this.txt_userName.Size = new System.Drawing.Size(221, 34);
            this.txt_userName.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Historic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(15, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 30);
            this.label3.TabIndex = 84;
            this.label3.Text = "Branch";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Historic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(15, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 30);
            this.label5.TabIndex = 82;
            this.label5.Text = "User Name";
            // 
            // cmb_role
            // 
            this.cmb_role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_role.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmb_role.FormattingEnabled = true;
            this.cmb_role.Location = new System.Drawing.Point(15, 205);
            this.cmb_role.Name = "cmb_role";
            this.cmb_role.Size = new System.Drawing.Size(221, 33);
            this.cmb_role.TabIndex = 83;
            // 
            // frmUserRegister
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(427, 604);
            this.Controls.Add(this.pnl_body);
            this.Controls.Add(this.pnl_root);
            this.Controls.Add(this.pnl_head);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUserRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmForm";
            this.Load += new System.EventHandler(this.frmUserRegister_Load);
            this.pnl_head.ResumeLayout(false);
            this.pnl_head.PerformLayout();
            this.pnl_root.ResumeLayout(false);
            this.pnl_body.ResumeLayout(false);
            this.pnl_container.ResumeLayout(false);
            this.pnl_container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnl_head;
        private Button btn_close;
        private Label lbl_title;
        private Panel pnl_root;
        private Panel pnl_body;
        private Button btn_cancel;
        private Button btn_save;
        private Panel pnl_container;
        private TextBox txt_password;
        private Label label1;
        private Label label2;
        private ComboBox cmb_branch;
        private TextBox txt_userName;
        private Label label3;
        private Label label5;
        private ComboBox cmb_role;
        private Button btn_delete;
        private TextBox txt_id;
    }
}