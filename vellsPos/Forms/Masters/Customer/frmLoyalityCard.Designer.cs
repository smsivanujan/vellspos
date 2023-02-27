namespace vellsPos.Forms.Layouts
{
    partial class frmLoyalityCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoyalityCard));
            this.pnl_head = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.pnl_root = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.pnl_body = new System.Windows.Forms.Panel();
            this.pnl_container = new System.Windows.Forms.Panel();
            this.txt_customerID = new System.Windows.Forms.TextBox();
            this.txt_customer = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_issuedDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_status = new System.Windows.Forms.CheckBox();
            this.txt_cardNumber = new System.Windows.Forms.TextBox();
            this.cmb_cardType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.pnl_head.Size = new System.Drawing.Size(722, 53);
            this.pnl_head.TabIndex = 0;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.Location = new System.Drawing.Point(12, 11);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(163, 32);
            this.lbl_title.TabIndex = 5;
            this.lbl_title.Text = "Loyality Card";
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.Color.Transparent;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(683, 11);
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
            this.pnl_root.Size = new System.Drawing.Size(722, 75);
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
            this.btn_delete.Location = new System.Drawing.Point(355, 12);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_delete.Size = new System.Drawing.Size(108, 51);
            this.btn_delete.TabIndex = 5;
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
            this.btn_save.Location = new System.Drawing.Point(583, 12);
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
            this.btn_cancel.Location = new System.Drawing.Point(469, 12);
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
            this.pnl_body.Size = new System.Drawing.Size(722, 476);
            this.pnl_body.TabIndex = 2;
            // 
            // pnl_container
            // 
            this.pnl_container.Controls.Add(this.txt_customerID);
            this.pnl_container.Controls.Add(this.txt_customer);
            this.pnl_container.Controls.Add(this.txt_id);
            this.pnl_container.Controls.Add(this.label1);
            this.pnl_container.Controls.Add(this.label4);
            this.pnl_container.Controls.Add(this.dtp_issuedDate);
            this.pnl_container.Controls.Add(this.label2);
            this.pnl_container.Controls.Add(this.cb_status);
            this.pnl_container.Controls.Add(this.txt_cardNumber);
            this.pnl_container.Controls.Add(this.cmb_cardType);
            this.pnl_container.Controls.Add(this.label3);
            this.pnl_container.Controls.Add(this.label5);
            this.pnl_container.Location = new System.Drawing.Point(12, 6);
            this.pnl_container.Name = "pnl_container";
            this.pnl_container.Size = new System.Drawing.Size(667, 464);
            this.pnl_container.TabIndex = 0;
            // 
            // txt_customerID
            // 
            this.txt_customerID.Location = new System.Drawing.Point(247, 73);
            this.txt_customerID.Name = "txt_customerID";
            this.txt_customerID.Size = new System.Drawing.Size(38, 23);
            this.txt_customerID.TabIndex = 119;
            this.txt_customerID.TextChanged += new System.EventHandler(this.txt_customerID_TextChanged);
            // 
            // txt_customer
            // 
            this.txt_customer.BackColor = System.Drawing.SystemColors.Control;
            this.txt_customer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_customer.Location = new System.Drawing.Point(20, 53);
            this.txt_customer.Multiline = true;
            this.txt_customer.Name = "txt_customer";
            this.txt_customer.PlaceholderText = "[ Select ]";
            this.txt_customer.Size = new System.Drawing.Size(221, 43);
            this.txt_customer.TabIndex = 118;
            this.txt_customer.Click += new System.EventHandler(this.txt_customer_Click);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(247, 44);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(41, 23);
            this.txt_id.TabIndex = 89;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 30);
            this.label1.TabIndex = 72;
            this.label1.Text = "Customer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Historic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(20, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 30);
            this.label4.TabIndex = 71;
            this.label4.Text = "Issued date";
            // 
            // dtp_issuedDate
            // 
            this.dtp_issuedDate.CustomFormat = "yyyy-MM-dd";
            this.dtp_issuedDate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtp_issuedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_issuedDate.Location = new System.Drawing.Point(20, 313);
            this.dtp_issuedDate.Name = "dtp_issuedDate";
            this.dtp_issuedDate.Size = new System.Drawing.Size(221, 33);
            this.dtp_issuedDate.TabIndex = 70;
            this.dtp_issuedDate.Value = new System.DateTime(2023, 2, 8, 19, 27, 14, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 15);
            this.label2.TabIndex = 69;
            this.label2.Text = "1";
            // 
            // cb_status
            // 
            this.cb_status.AutoSize = true;
            this.cb_status.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cb_status.Location = new System.Drawing.Point(20, 378);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(85, 29);
            this.cb_status.TabIndex = 68;
            this.cb_status.Text = "Active";
            this.cb_status.UseVisualStyleBackColor = true;
            // 
            // txt_cardNumber
            // 
            this.txt_cardNumber.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_cardNumber.Location = new System.Drawing.Point(20, 133);
            this.txt_cardNumber.Multiline = true;
            this.txt_cardNumber.Name = "txt_cardNumber";
            this.txt_cardNumber.PlaceholderText = "CX123456789";
            this.txt_cardNumber.Size = new System.Drawing.Size(221, 34);
            this.txt_cardNumber.TabIndex = 65;
            // 
            // cmb_cardType
            // 
            this.cmb_cardType.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmb_cardType.FormattingEnabled = true;
            this.cmb_cardType.Items.AddRange(new object[] {
            "Brownce",
            "Silver",
            "Gold",
            "Plattinum"});
            this.cmb_cardType.Location = new System.Drawing.Point(20, 231);
            this.cmb_cardType.Name = "cmb_cardType";
            this.cmb_cardType.Size = new System.Drawing.Size(221, 33);
            this.cmb_cardType.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Historic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(20, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 30);
            this.label3.TabIndex = 63;
            this.label3.Text = "Card Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Historic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(20, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 30);
            this.label5.TabIndex = 62;
            this.label5.Text = "Card Number";
            // 
            // frmLoyalityCard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(722, 604);
            this.Controls.Add(this.pnl_body);
            this.Controls.Add(this.pnl_root);
            this.Controls.Add(this.pnl_head);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLoyalityCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loyality Card   ";
            this.Load += new System.EventHandler(this.frmLoyalityCard_Load);
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
        private TextBox txt_cardNumber;
        private ComboBox cmb_cardType;
        private Label label3;
        private Label label5;
        private CheckBox cb_status;
        private Button btn_delete;
        private Label label2;
        private Label label4;
        private DateTimePicker dtp_issuedDate;
        private Label label1;
        private TextBox txt_id;
        private TextBox txt_customerID;
        private TextBox txt_customer;
    }
}