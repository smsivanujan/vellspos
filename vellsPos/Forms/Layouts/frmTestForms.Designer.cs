namespace vellsPos.Forms.Layouts
{
    partial class frmTestForms
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
            this.btndiscount = new System.Windows.Forms.Button();
            this.btn_complain = new System.Windows.Forms.Button();
            this.btn_customer = new System.Windows.Forms.Button();
            this.btn_loyalityCard = new System.Windows.Forms.Button();
            this.btn_category = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btndiscount
            // 
            this.btndiscount.Location = new System.Drawing.Point(3, 12);
            this.btndiscount.Name = "btndiscount";
            this.btndiscount.Size = new System.Drawing.Size(147, 75);
            this.btndiscount.TabIndex = 0;
            this.btndiscount.Text = "Discount";
            this.btndiscount.UseVisualStyleBackColor = true;
            this.btndiscount.Click += new System.EventHandler(this.btndiscount_Click);
            // 
            // btn_complain
            // 
            this.btn_complain.Location = new System.Drawing.Point(156, 12);
            this.btn_complain.Name = "btn_complain";
            this.btn_complain.Size = new System.Drawing.Size(147, 75);
            this.btn_complain.TabIndex = 1;
            this.btn_complain.Text = "Complain";
            this.btn_complain.UseVisualStyleBackColor = true;
            this.btn_complain.Click += new System.EventHandler(this.btn_complain_Click);
            // 
            // btn_customer
            // 
            this.btn_customer.Location = new System.Drawing.Point(309, 12);
            this.btn_customer.Name = "btn_customer";
            this.btn_customer.Size = new System.Drawing.Size(147, 75);
            this.btn_customer.TabIndex = 2;
            this.btn_customer.Text = "Customer";
            this.btn_customer.UseVisualStyleBackColor = true;
            this.btn_customer.Click += new System.EventHandler(this.btn_customer_Click);
            // 
            // btn_loyalityCard
            // 
            this.btn_loyalityCard.Location = new System.Drawing.Point(462, 12);
            this.btn_loyalityCard.Name = "btn_loyalityCard";
            this.btn_loyalityCard.Size = new System.Drawing.Size(147, 75);
            this.btn_loyalityCard.TabIndex = 3;
            this.btn_loyalityCard.Text = "Loyality card";
            this.btn_loyalityCard.UseVisualStyleBackColor = true;
            this.btn_loyalityCard.Click += new System.EventHandler(this.btn_loyalityCard_Click);
            // 
            // btn_category
            // 
            this.btn_category.Location = new System.Drawing.Point(615, 12);
            this.btn_category.Name = "btn_category";
            this.btn_category.Size = new System.Drawing.Size(147, 75);
            this.btn_category.TabIndex = 4;
            this.btn_category.Text = "Category";
            this.btn_category.UseVisualStyleBackColor = true;
            this.btn_category.Click += new System.EventHandler(this.btn_category_Click);
            // 
            // frmTestForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_category);
            this.Controls.Add(this.btn_loyalityCard);
            this.Controls.Add(this.btn_customer);
            this.Controls.Add(this.btn_complain);
            this.Controls.Add(this.btndiscount);
            this.Name = "frmTestForms";
            this.Text = "frmTestForms";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btndiscount;
        private Button btn_complain;
        private Button btn_customer;
        private Button btn_loyalityCard;
        private Button btn_category;
    }
}