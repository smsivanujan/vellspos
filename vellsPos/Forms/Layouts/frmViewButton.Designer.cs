namespace vellsPos.Forms.Layouts
{
    partial class frmViewButton
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewButton));
            this.pnl_head = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.pnl_root = new System.Windows.Forms.Panel();
            this.pnl_body = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_loginLog = new System.Windows.Forms.Button();
            this.btn_activityLog = new System.Windows.Forms.Button();
            this.gb_crm = new System.Windows.Forms.GroupBox();
            this.btn_loyalityCard = new System.Windows.Forms.Button();
            this.btn_customer = new System.Windows.Forms.Button();
            this.gb_product = new System.Windows.Forms.GroupBox();
            this.btn_subCoCategory = new System.Windows.Forms.Button();
            this.btn_productBarcode = new System.Windows.Forms.Button();
            this.btn_product = new System.Windows.Forms.Button();
            this.btn_subCategory = new System.Windows.Forms.Button();
            this.btn_category = new System.Windows.Forms.Button();
            this.pnl_head.SuspendLayout();
            this.pnl_body.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gb_crm.SuspendLayout();
            this.gb_product.SuspendLayout();
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
            this.pnl_head.Size = new System.Drawing.Size(710, 53);
            this.pnl_head.TabIndex = 0;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.Location = new System.Drawing.Point(12, 11);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(0, 32);
            this.lbl_title.TabIndex = 5;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.Color.Transparent;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(671, 11);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(31, 30);
            this.btn_close.TabIndex = 4;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // pnl_root
            // 
            this.pnl_root.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.pnl_root.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_root.Location = new System.Drawing.Point(0, 514);
            this.pnl_root.Name = "pnl_root";
            this.pnl_root.Size = new System.Drawing.Size(710, 53);
            this.pnl_root.TabIndex = 1;
            // 
            // pnl_body
            // 
            this.pnl_body.Controls.Add(this.groupBox1);
            this.pnl_body.Controls.Add(this.gb_crm);
            this.pnl_body.Controls.Add(this.gb_product);
            this.pnl_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_body.Location = new System.Drawing.Point(0, 53);
            this.pnl_body.Name = "pnl_body";
            this.pnl_body.Size = new System.Drawing.Size(710, 461);
            this.pnl_body.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_loginLog);
            this.groupBox1.Controls.Add(this.btn_activityLog);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(0, 323);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(710, 120);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Logs";
            // 
            // btn_loginLog
            // 
            this.btn_loginLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_loginLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loginLog.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_loginLog.Image = ((System.Drawing.Image)(resources.GetObject("btn_loginLog.Image")));
            this.btn_loginLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_loginLog.Location = new System.Drawing.Point(231, 22);
            this.btn_loginLog.Name = "btn_loginLog";
            this.btn_loginLog.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_loginLog.Size = new System.Drawing.Size(214, 75);
            this.btn_loginLog.TabIndex = 14;
            this.btn_loginLog.Text = "Login Log";
            this.btn_loginLog.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_loginLog.UseVisualStyleBackColor = false;
            this.btn_loginLog.Click += new System.EventHandler(this.btn_loginLog_Click);
            // 
            // btn_activityLog
            // 
            this.btn_activityLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_activityLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_activityLog.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_activityLog.Image = ((System.Drawing.Image)(resources.GetObject("btn_activityLog.Image")));
            this.btn_activityLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_activityLog.Location = new System.Drawing.Point(6, 22);
            this.btn_activityLog.Name = "btn_activityLog";
            this.btn_activityLog.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_activityLog.Size = new System.Drawing.Size(214, 75);
            this.btn_activityLog.TabIndex = 13;
            this.btn_activityLog.Text = "Activity log";
            this.btn_activityLog.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_activityLog.UseVisualStyleBackColor = false;
            this.btn_activityLog.Click += new System.EventHandler(this.btn_activityLog_Click);
            // 
            // gb_crm
            // 
            this.gb_crm.Controls.Add(this.btn_loyalityCard);
            this.gb_crm.Controls.Add(this.btn_customer);
            this.gb_crm.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_crm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gb_crm.Location = new System.Drawing.Point(0, 203);
            this.gb_crm.Name = "gb_crm";
            this.gb_crm.Size = new System.Drawing.Size(710, 120);
            this.gb_crm.TabIndex = 21;
            this.gb_crm.TabStop = false;
            this.gb_crm.Text = "CRM";
            // 
            // btn_loyalityCard
            // 
            this.btn_loyalityCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_loyalityCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loyalityCard.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_loyalityCard.Image = ((System.Drawing.Image)(resources.GetObject("btn_loyalityCard.Image")));
            this.btn_loyalityCard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_loyalityCard.Location = new System.Drawing.Point(231, 22);
            this.btn_loyalityCard.Name = "btn_loyalityCard";
            this.btn_loyalityCard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_loyalityCard.Size = new System.Drawing.Size(214, 75);
            this.btn_loyalityCard.TabIndex = 14;
            this.btn_loyalityCard.Text = "Loyality card";
            this.btn_loyalityCard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_loyalityCard.UseVisualStyleBackColor = false;
            this.btn_loyalityCard.Click += new System.EventHandler(this.btn_loyalityCard_Click);
            // 
            // btn_customer
            // 
            this.btn_customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_customer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_customer.Image = ((System.Drawing.Image)(resources.GetObject("btn_customer.Image")));
            this.btn_customer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_customer.Location = new System.Drawing.Point(6, 22);
            this.btn_customer.Name = "btn_customer";
            this.btn_customer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_customer.Size = new System.Drawing.Size(214, 75);
            this.btn_customer.TabIndex = 13;
            this.btn_customer.Text = "Customer";
            this.btn_customer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_customer.UseVisualStyleBackColor = false;
            this.btn_customer.Click += new System.EventHandler(this.btn_customer_Click);
            // 
            // gb_product
            // 
            this.gb_product.Controls.Add(this.btn_subCoCategory);
            this.gb_product.Controls.Add(this.btn_productBarcode);
            this.gb_product.Controls.Add(this.btn_product);
            this.gb_product.Controls.Add(this.btn_subCategory);
            this.gb_product.Controls.Add(this.btn_category);
            this.gb_product.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_product.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gb_product.Location = new System.Drawing.Point(0, 0);
            this.gb_product.Name = "gb_product";
            this.gb_product.Size = new System.Drawing.Size(710, 203);
            this.gb_product.TabIndex = 20;
            this.gb_product.TabStop = false;
            this.gb_product.Text = "Products";
            // 
            // btn_subCoCategory
            // 
            this.btn_subCoCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_subCoCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_subCoCategory.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_subCoCategory.Image = ((System.Drawing.Image)(resources.GetObject("btn_subCoCategory.Image")));
            this.btn_subCoCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_subCoCategory.Location = new System.Drawing.Point(456, 22);
            this.btn_subCoCategory.Name = "btn_subCoCategory";
            this.btn_subCoCategory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_subCoCategory.Size = new System.Drawing.Size(214, 75);
            this.btn_subCoCategory.TabIndex = 17;
            this.btn_subCoCategory.Text = "Sub Co Category";
            this.btn_subCoCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_subCoCategory.UseVisualStyleBackColor = false;
            this.btn_subCoCategory.Click += new System.EventHandler(this.btn_subCoCategory_Click);
            // 
            // btn_productBarcode
            // 
            this.btn_productBarcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_productBarcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_productBarcode.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_productBarcode.Image = ((System.Drawing.Image)(resources.GetObject("btn_productBarcode.Image")));
            this.btn_productBarcode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_productBarcode.Location = new System.Drawing.Point(231, 113);
            this.btn_productBarcode.Name = "btn_productBarcode";
            this.btn_productBarcode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_productBarcode.Size = new System.Drawing.Size(214, 75);
            this.btn_productBarcode.TabIndex = 16;
            this.btn_productBarcode.Text = "Barcode";
            this.btn_productBarcode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_productBarcode.UseVisualStyleBackColor = false;
            this.btn_productBarcode.Click += new System.EventHandler(this.btn_productBarcode_Click);
            // 
            // btn_product
            // 
            this.btn_product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_product.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_product.Image = ((System.Drawing.Image)(resources.GetObject("btn_product.Image")));
            this.btn_product.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_product.Location = new System.Drawing.Point(6, 113);
            this.btn_product.Name = "btn_product";
            this.btn_product.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_product.Size = new System.Drawing.Size(214, 75);
            this.btn_product.TabIndex = 15;
            this.btn_product.Text = "Product";
            this.btn_product.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_product.UseVisualStyleBackColor = false;
            this.btn_product.Click += new System.EventHandler(this.btn_product_Click);
            // 
            // btn_subCategory
            // 
            this.btn_subCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_subCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_subCategory.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_subCategory.Image = ((System.Drawing.Image)(resources.GetObject("btn_subCategory.Image")));
            this.btn_subCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_subCategory.Location = new System.Drawing.Point(231, 22);
            this.btn_subCategory.Name = "btn_subCategory";
            this.btn_subCategory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_subCategory.Size = new System.Drawing.Size(214, 75);
            this.btn_subCategory.TabIndex = 14;
            this.btn_subCategory.Text = "Sub Category";
            this.btn_subCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_subCategory.UseVisualStyleBackColor = false;
            this.btn_subCategory.Click += new System.EventHandler(this.btn_subCategory_Click);
            // 
            // btn_category
            // 
            this.btn_category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_category.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_category.Image = ((System.Drawing.Image)(resources.GetObject("btn_category.Image")));
            this.btn_category.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_category.Location = new System.Drawing.Point(6, 22);
            this.btn_category.Name = "btn_category";
            this.btn_category.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_category.Size = new System.Drawing.Size(214, 75);
            this.btn_category.TabIndex = 13;
            this.btn_category.Text = "Category";
            this.btn_category.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_category.UseVisualStyleBackColor = false;
            this.btn_category.Click += new System.EventHandler(this.btn_category_Click);
            // 
            // frmViewButton
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(710, 567);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_body);
            this.Controls.Add(this.pnl_root);
            this.Controls.Add(this.pnl_head);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmViewButton";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmForm";
            this.Load += new System.EventHandler(this.frmViewButton_Load);
            this.pnl_head.ResumeLayout(false);
            this.pnl_head.PerformLayout();
            this.pnl_body.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gb_crm.ResumeLayout(false);
            this.gb_product.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnl_head;
        private Button btn_close;
        private Label lbl_title;
        private Panel pnl_root;
        private Panel pnl_body;
        private GroupBox gb_crm;
        private Button btn_loyalityCard;
        private Button btn_customer;
        private GroupBox gb_product;
        private Button btn_subCoCategory;
        private Button btn_productBarcode;
        private Button btn_product;
        private Button btn_subCategory;
        private Button btn_category;
        private GroupBox groupBox1;
        private Button btn_loginLog;
        private Button btn_activityLog;
    }
}