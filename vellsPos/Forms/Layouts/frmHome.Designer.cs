namespace vellsPos.Forms.Layouts
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.pnl_head = new System.Windows.Forms.Panel();
            this.lbl_maxStatus = new System.Windows.Forms.Label();
            this.btn_maximize = new System.Windows.Forms.Button();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pb_titleImage = new System.Windows.Forms.PictureBox();
            this.pnl_navigation = new System.Windows.Forms.Panel();
            this.btn_faq = new System.Windows.Forms.Button();
            this.btn_discount = new System.Windows.Forms.Button();
            this.btn_complain = new System.Windows.Forms.Button();
            this.btn_user = new System.Windows.Forms.Button();
            this.btn_product = new System.Windows.Forms.Button();
            this.btn_report = new System.Windows.Forms.Button();
            this.btn_setting = new System.Windows.Forms.Button();
            this.btn_crm = new System.Windows.Forms.Button();
            this.btn_sale = new System.Windows.Forms.Button();
            this.btn_pos = new System.Windows.Forms.Button();
            this.pnl_body = new System.Windows.Forms.Panel();
            this.pnl_display = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnl_foot = new System.Windows.Forms.Panel();
            this.pnl_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_titleImage)).BeginInit();
            this.pnl_navigation.SuspendLayout();
            this.pnl_body.SuspendLayout();
            this.pnl_display.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_head
            // 
            this.pnl_head.Controls.Add(this.lbl_maxStatus);
            this.pnl_head.Controls.Add(this.btn_maximize);
            this.pnl_head.Controls.Add(this.btn_minimize);
            this.pnl_head.Controls.Add(this.btn_search);
            this.pnl_head.Controls.Add(this.btn_close);
            this.pnl_head.Controls.Add(this.txt_search);
            this.pnl_head.Controls.Add(this.lbl_title);
            this.pnl_head.Controls.Add(this.pb_titleImage);
            this.pnl_head.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_head.Location = new System.Drawing.Point(0, 0);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(1300, 59);
            this.pnl_head.TabIndex = 0;
            // 
            // lbl_maxStatus
            // 
            this.lbl_maxStatus.AutoSize = true;
            this.lbl_maxStatus.Location = new System.Drawing.Point(1137, 37);
            this.lbl_maxStatus.Name = "lbl_maxStatus";
            this.lbl_maxStatus.Size = new System.Drawing.Size(13, 15);
            this.lbl_maxStatus.TabIndex = 7;
            this.lbl_maxStatus.Text = "0";
            // 
            // btn_maximize
            // 
            this.btn_maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_maximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_maximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_maximize.ForeColor = System.Drawing.Color.Transparent;
            this.btn_maximize.Image = ((System.Drawing.Image)(resources.GetObject("btn_maximize.Image")));
            this.btn_maximize.Location = new System.Drawing.Point(1202, 12);
            this.btn_maximize.Name = "btn_maximize";
            this.btn_maximize.Size = new System.Drawing.Size(40, 40);
            this.btn_maximize.TabIndex = 6;
            this.btn_maximize.UseVisualStyleBackColor = false;
            this.btn_maximize.Click += new System.EventHandler(this.btn_maximize_Click);
            // 
            // btn_minimize
            // 
            this.btn_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.ForeColor = System.Drawing.Color.Transparent;
            this.btn_minimize.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimize.Image")));
            this.btn_minimize.Location = new System.Drawing.Point(1156, 12);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(40, 40);
            this.btn_minimize.TabIndex = 4;
            this.btn_minimize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_minimize.UseVisualStyleBackColor = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.ForeColor = System.Drawing.Color.Transparent;
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.Location = new System.Drawing.Point(607, 12);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(43, 40);
            this.btn_search.TabIndex = 5;
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.Color.Transparent;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(1248, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(40, 40);
            this.btn_close.TabIndex = 3;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // txt_search
            // 
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_search.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_search.Location = new System.Drawing.Point(263, 12);
            this.txt_search.Multiline = true;
            this.txt_search.Name = "txt_search";
            this.txt_search.PlaceholderText = "search here";
            this.txt_search.Size = new System.Drawing.Size(338, 40);
            this.txt_search.TabIndex = 2;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.Location = new System.Drawing.Point(64, 7);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(179, 45);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "VELLS POS";
            // 
            // pb_titleImage
            // 
            this.pb_titleImage.Image = ((System.Drawing.Image)(resources.GetObject("pb_titleImage.Image")));
            this.pb_titleImage.Location = new System.Drawing.Point(12, 6);
            this.pb_titleImage.Name = "pb_titleImage";
            this.pb_titleImage.Size = new System.Drawing.Size(46, 46);
            this.pb_titleImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_titleImage.TabIndex = 0;
            this.pb_titleImage.TabStop = false;
            // 
            // pnl_navigation
            // 
            this.pnl_navigation.Controls.Add(this.btn_faq);
            this.pnl_navigation.Controls.Add(this.btn_discount);
            this.pnl_navigation.Controls.Add(this.btn_complain);
            this.pnl_navigation.Controls.Add(this.btn_user);
            this.pnl_navigation.Controls.Add(this.btn_product);
            this.pnl_navigation.Controls.Add(this.btn_report);
            this.pnl_navigation.Controls.Add(this.btn_setting);
            this.pnl_navigation.Controls.Add(this.btn_crm);
            this.pnl_navigation.Controls.Add(this.btn_sale);
            this.pnl_navigation.Controls.Add(this.btn_pos);
            this.pnl_navigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_navigation.Location = new System.Drawing.Point(0, 0);
            this.pnl_navigation.Name = "pnl_navigation";
            this.pnl_navigation.Size = new System.Drawing.Size(197, 661);
            this.pnl_navigation.TabIndex = 1;
            this.pnl_navigation.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_navigation_Paint);
            // 
            // btn_faq
            // 
            this.btn_faq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_faq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_faq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_faq.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_faq.Image = ((System.Drawing.Image)(resources.GetObject("btn_faq.Image")));
            this.btn_faq.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_faq.Location = new System.Drawing.Point(95, 601);
            this.btn_faq.Name = "btn_faq";
            this.btn_faq.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_faq.Size = new System.Drawing.Size(96, 48);
            this.btn_faq.TabIndex = 6;
            this.btn_faq.Text = "FAQ";
            this.btn_faq.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_faq.UseVisualStyleBackColor = false;
            // 
            // btn_discount
            // 
            this.btn_discount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_discount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_discount.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_discount.Image = ((System.Drawing.Image)(resources.GetObject("btn_discount.Image")));
            this.btn_discount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_discount.Location = new System.Drawing.Point(18, 215);
            this.btn_discount.Name = "btn_discount";
            this.btn_discount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_discount.Size = new System.Drawing.Size(162, 48);
            this.btn_discount.TabIndex = 12;
            this.btn_discount.Text = "Discount";
            this.btn_discount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_discount.UseVisualStyleBackColor = false;
            this.btn_discount.Click += new System.EventHandler(this.btn_discount_Click);
            // 
            // btn_complain
            // 
            this.btn_complain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_complain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_complain.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_complain.Image = ((System.Drawing.Image)(resources.GetObject("btn_complain.Image")));
            this.btn_complain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_complain.Location = new System.Drawing.Point(18, 472);
            this.btn_complain.Name = "btn_complain";
            this.btn_complain.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_complain.Size = new System.Drawing.Size(162, 48);
            this.btn_complain.TabIndex = 7;
            this.btn_complain.Text = "Complains";
            this.btn_complain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_complain.UseVisualStyleBackColor = false;
            this.btn_complain.Click += new System.EventHandler(this.btn_complain_Click);
            // 
            // btn_user
            // 
            this.btn_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_user.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_user.Image = ((System.Drawing.Image)(resources.GetObject("btn_user.Image")));
            this.btn_user.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_user.Location = new System.Drawing.Point(18, 343);
            this.btn_user.Name = "btn_user";
            this.btn_user.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_user.Size = new System.Drawing.Size(162, 48);
            this.btn_user.TabIndex = 10;
            this.btn_user.Text = "User";
            this.btn_user.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_user.UseVisualStyleBackColor = false;
            this.btn_user.Click += new System.EventHandler(this.btn_user_Click);
            // 
            // btn_product
            // 
            this.btn_product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_product.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_product.Image = ((System.Drawing.Image)(resources.GetObject("btn_product.Image")));
            this.btn_product.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_product.Location = new System.Drawing.Point(18, 87);
            this.btn_product.Name = "btn_product";
            this.btn_product.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_product.Size = new System.Drawing.Size(162, 48);
            this.btn_product.TabIndex = 9;
            this.btn_product.Text = "Product";
            this.btn_product.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_product.UseVisualStyleBackColor = false;
            this.btn_product.Click += new System.EventHandler(this.btn_product_Click);
            // 
            // btn_report
            // 
            this.btn_report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_report.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_report.Image = ((System.Drawing.Image)(resources.GetObject("btn_report.Image")));
            this.btn_report.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_report.Location = new System.Drawing.Point(18, 407);
            this.btn_report.Name = "btn_report";
            this.btn_report.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_report.Size = new System.Drawing.Size(162, 48);
            this.btn_report.TabIndex = 8;
            this.btn_report.Text = "Reports";
            this.btn_report.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_report.UseVisualStyleBackColor = false;
            // 
            // btn_setting
            // 
            this.btn_setting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_setting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_setting.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_setting.Image = ((System.Drawing.Image)(resources.GetObject("btn_setting.Image")));
            this.btn_setting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_setting.Location = new System.Drawing.Point(18, 601);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_setting.Size = new System.Drawing.Size(59, 48);
            this.btn_setting.TabIndex = 5;
            this.btn_setting.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_setting.UseVisualStyleBackColor = false;
            // 
            // btn_crm
            // 
            this.btn_crm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_crm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_crm.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_crm.Image = ((System.Drawing.Image)(resources.GetObject("btn_crm.Image")));
            this.btn_crm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_crm.Location = new System.Drawing.Point(18, 151);
            this.btn_crm.Name = "btn_crm";
            this.btn_crm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_crm.Size = new System.Drawing.Size(162, 48);
            this.btn_crm.TabIndex = 3;
            this.btn_crm.Text = "CRM";
            this.btn_crm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_crm.UseVisualStyleBackColor = false;
            this.btn_crm.Click += new System.EventHandler(this.btn_crm_Click);
            // 
            // btn_sale
            // 
            this.btn_sale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_sale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sale.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_sale.Image = ((System.Drawing.Image)(resources.GetObject("btn_sale.Image")));
            this.btn_sale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sale.Location = new System.Drawing.Point(18, 279);
            this.btn_sale.Name = "btn_sale";
            this.btn_sale.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_sale.Size = new System.Drawing.Size(162, 48);
            this.btn_sale.TabIndex = 2;
            this.btn_sale.Text = "Sales";
            this.btn_sale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sale.UseVisualStyleBackColor = false;
            // 
            // btn_pos
            // 
            this.btn_pos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_pos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_pos.Image = ((System.Drawing.Image)(resources.GetObject("btn_pos.Image")));
            this.btn_pos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pos.Location = new System.Drawing.Point(18, 23);
            this.btn_pos.Name = "btn_pos";
            this.btn_pos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_pos.Size = new System.Drawing.Size(162, 48);
            this.btn_pos.TabIndex = 1;
            this.btn_pos.Text = "Point Of Sales";
            this.btn_pos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_pos.UseVisualStyleBackColor = false;
            this.btn_pos.Click += new System.EventHandler(this.btn_pos_Click);
            // 
            // pnl_body
            // 
            this.pnl_body.Controls.Add(this.pnl_display);
            this.pnl_body.Controls.Add(this.pnl_foot);
            this.pnl_body.Controls.Add(this.pnl_navigation);
            this.pnl_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_body.Location = new System.Drawing.Point(0, 59);
            this.pnl_body.Name = "pnl_body";
            this.pnl_body.Size = new System.Drawing.Size(1300, 661);
            this.pnl_body.TabIndex = 2;
            // 
            // pnl_display
            // 
            this.pnl_display.AutoScroll = true;
            this.pnl_display.Controls.Add(this.panel1);
            this.pnl_display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_display.Location = new System.Drawing.Point(197, 0);
            this.pnl_display.Name = "pnl_display";
            this.pnl_display.Size = new System.Drawing.Size(1103, 609);
            this.pnl_display.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.panel14);
            this.panel1.Controls.Add(this.panel13);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel12);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1085, 597);
            this.panel1.TabIndex = 0;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel14.Location = new System.Drawing.Point(546, 325);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(509, 247);
            this.panel14.TabIndex = 6;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel13.Location = new System.Drawing.Point(31, 325);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(509, 247);
            this.panel13.TabIndex = 5;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Location = new System.Drawing.Point(855, 105);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(200, 82);
            this.panel10.TabIndex = 7;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Location = new System.Drawing.Point(237, 105);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(200, 82);
            this.panel9.TabIndex = 6;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Location = new System.Drawing.Point(649, 105);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(200, 82);
            this.panel11.TabIndex = 6;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Location = new System.Drawing.Point(31, 105);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 82);
            this.panel8.TabIndex = 5;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Location = new System.Drawing.Point(443, 105);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(200, 82);
            this.panel12.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Location = new System.Drawing.Point(855, 17);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 82);
            this.panel7.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(31, 196);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1024, 119);
            this.panel6.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(649, 17);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 82);
            this.panel5.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(443, 17);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 82);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(237, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 82);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(31, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 82);
            this.panel2.TabIndex = 0;
            // 
            // pnl_foot
            // 
            this.pnl_foot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_foot.Location = new System.Drawing.Point(197, 609);
            this.pnl_foot.Name = "pnl_foot";
            this.pnl_foot.Size = new System.Drawing.Size(1103, 52);
            this.pnl_foot.TabIndex = 3;
            // 
            // frmHome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1300, 720);
            this.Controls.Add(this.pnl_body);
            this.Controls.Add(this.pnl_head);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHome";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.pnl_head.ResumeLayout(false);
            this.pnl_head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_titleImage)).EndInit();
            this.pnl_navigation.ResumeLayout(false);
            this.pnl_body.ResumeLayout(false);
            this.pnl_display.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnl_head;
        private Label lbl_title;
        private PictureBox pb_titleImage;
        private Panel pnl_navigation;
        private TextBox txt_search;
        private Panel pnl_body;
        private Button btn_close;
        private Button btn_minimize;
        private Button btn_search;
        private Button btn_crm;
        private Button btn_sale;
        private Button btn_pos;
        private Button btn_complain;
        private Button btn_faq;
        private Button btn_setting;
        private Button btn_report;
        private Button btn_product;
        private Panel pnl_foot;
        private Panel pnl_display;
        private Button btn_maximize;
        private Label lbl_maxStatus;
        private Panel panel1;
        private Panel panel14;
        private Panel panel13;
        private Panel panel10;
        private Panel panel9;
        private Panel panel11;
        private Panel panel8;
        private Panel panel12;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Button btn_user;
        private Button btn_discount;
    }
}