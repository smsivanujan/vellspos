namespace vellsPos.Forms.Layouts
{
    partial class frmProductList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductList));
            this.pnl_container = new System.Windows.Forms.Panel();
            this.pnl_product = new System.Windows.Forms.Panel();
            this.pnl_productList = new System.Windows.Forms.Panel();
            this.gb_product = new System.Windows.Forms.GroupBox();
            this.gb_subCoCategory = new System.Windows.Forms.GroupBox();
            this.gb_subCategory = new System.Windows.Forms.GroupBox();
            this.lb_user = new System.Windows.Forms.Label();
            this.pnl_body = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.pnl_head = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pnl_container.SuspendLayout();
            this.pnl_product.SuspendLayout();
            this.pnl_productList.SuspendLayout();
            this.pnl_body.SuspendLayout();
            this.pnl_head.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_container
            // 
            this.pnl_container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.pnl_container.Controls.Add(this.pnl_product);
            this.pnl_container.Controls.Add(this.lb_user);
            this.pnl_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_container.Location = new System.Drawing.Point(0, 0);
            this.pnl_container.Name = "pnl_container";
            this.pnl_container.Size = new System.Drawing.Size(494, 563);
            this.pnl_container.TabIndex = 0;
            // 
            // pnl_product
            // 
            this.pnl_product.BackColor = System.Drawing.Color.White;
            this.pnl_product.Controls.Add(this.pnl_productList);
            this.pnl_product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_product.Location = new System.Drawing.Point(0, 0);
            this.pnl_product.Name = "pnl_product";
            this.pnl_product.Size = new System.Drawing.Size(494, 563);
            this.pnl_product.TabIndex = 70;
            // 
            // pnl_productList
            // 
            this.pnl_productList.BackColor = System.Drawing.Color.SteelBlue;
            this.pnl_productList.Controls.Add(this.gb_product);
            this.pnl_productList.Controls.Add(this.gb_subCoCategory);
            this.pnl_productList.Controls.Add(this.gb_subCategory);
            this.pnl_productList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_productList.Location = new System.Drawing.Point(0, 0);
            this.pnl_productList.Name = "pnl_productList";
            this.pnl_productList.Size = new System.Drawing.Size(494, 563);
            this.pnl_productList.TabIndex = 16;
            // 
            // gb_product
            // 
            this.gb_product.BackColor = System.Drawing.Color.SteelBlue;
            this.gb_product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_product.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gb_product.ForeColor = System.Drawing.Color.White;
            this.gb_product.Location = new System.Drawing.Point(290, 0);
            this.gb_product.Name = "gb_product";
            this.gb_product.Size = new System.Drawing.Size(204, 563);
            this.gb_product.TabIndex = 15;
            this.gb_product.TabStop = false;
            this.gb_product.Text = "Products";
            // 
            // gb_subCoCategory
            // 
            this.gb_subCoCategory.BackColor = System.Drawing.Color.SteelBlue;
            this.gb_subCoCategory.Dock = System.Windows.Forms.DockStyle.Left;
            this.gb_subCoCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gb_subCoCategory.ForeColor = System.Drawing.Color.White;
            this.gb_subCoCategory.Location = new System.Drawing.Point(145, 0);
            this.gb_subCoCategory.Name = "gb_subCoCategory";
            this.gb_subCoCategory.Size = new System.Drawing.Size(145, 563);
            this.gb_subCoCategory.TabIndex = 14;
            this.gb_subCoCategory.TabStop = false;
            this.gb_subCoCategory.Text = "Sub Co Categories";
            // 
            // gb_subCategory
            // 
            this.gb_subCategory.BackColor = System.Drawing.Color.SteelBlue;
            this.gb_subCategory.Dock = System.Windows.Forms.DockStyle.Left;
            this.gb_subCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gb_subCategory.ForeColor = System.Drawing.Color.White;
            this.gb_subCategory.Location = new System.Drawing.Point(0, 0);
            this.gb_subCategory.Name = "gb_subCategory";
            this.gb_subCategory.Size = new System.Drawing.Size(145, 563);
            this.gb_subCategory.TabIndex = 13;
            this.gb_subCategory.TabStop = false;
            this.gb_subCategory.Text = "Sub Categories";
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.Location = new System.Drawing.Point(339, 485);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(13, 15);
            this.lb_user.TabIndex = 69;
            this.lb_user.Text = "1";
            // 
            // pnl_body
            // 
            this.pnl_body.Controls.Add(this.pnl_container);
            this.pnl_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_body.Location = new System.Drawing.Point(0, 53);
            this.pnl_body.Name = "pnl_body";
            this.pnl_body.Size = new System.Drawing.Size(494, 563);
            this.pnl_body.TabIndex = 5;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.Color.Transparent;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(451, 13);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(31, 30);
            this.btn_close.TabIndex = 4;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnl_head.Controls.Add(this.lbl_title);
            this.pnl_head.Controls.Add(this.btn_close);
            this.pnl_head.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_head.Location = new System.Drawing.Point(0, 0);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(494, 53);
            this.pnl_head.TabIndex = 3;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(12, 11);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(151, 32);
            this.lbl_title.TabIndex = 5;
            this.lbl_title.Text = "Product List";
            // 
            // frmProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 616);
            this.Controls.Add(this.pnl_body);
            this.Controls.Add(this.pnl_head);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProductList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmProductList";
            this.Load += new System.EventHandler(this.frmProductList_Load);
            this.pnl_container.ResumeLayout(false);
            this.pnl_container.PerformLayout();
            this.pnl_product.ResumeLayout(false);
            this.pnl_productList.ResumeLayout(false);
            this.pnl_body.ResumeLayout(false);
            this.pnl_head.ResumeLayout(false);
            this.pnl_head.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnl_container;
        private Label lb_user;
        private Panel pnl_body;
        private Button btn_close;
        private Panel pnl_head;
        private Label lbl_title;
        private Panel pnl_product;
        private Panel pnl_productList;
        private GroupBox gb_product;
        private GroupBox gb_subCoCategory;
        private GroupBox gb_subCategory;
    }
}