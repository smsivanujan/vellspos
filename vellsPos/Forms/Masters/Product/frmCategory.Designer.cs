namespace vellsPos.Forms.Layouts
{
    partial class frmCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategory));
            this.pnl_head = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.pnl_root = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.pnl_body = new System.Windows.Forms.Panel();
            this.pnl_container = new System.Windows.Forms.Panel();
            this.txt_imagePath = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_imageStatus = new System.Windows.Forms.Label();
            this.btn_uploadImage = new System.Windows.Forms.Button();
            this.pb_categoryImage = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtxt_description = new System.Windows.Forms.RichTextBox();
            this.txt_category = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_head.SuspendLayout();
            this.pnl_root.SuspendLayout();
            this.pnl_body.SuspendLayout();
            this.pnl_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_categoryImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnl_head.Controls.Add(this.lbl_title);
            this.pnl_head.Controls.Add(this.btn_close);
            this.pnl_head.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_head.Location = new System.Drawing.Point(0, 0);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(613, 53);
            this.pnl_head.TabIndex = 0;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_title.Location = new System.Drawing.Point(12, 11);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(118, 32);
            this.lbl_title.TabIndex = 5;
            this.lbl_title.Text = "Category";
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.Color.Transparent;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(574, 11);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(31, 30);
            this.btn_close.TabIndex = 4;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // pnl_root
            // 
            this.pnl_root.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnl_root.Controls.Add(this.btn_save);
            this.pnl_root.Controls.Add(this.btn_cancel);
            this.pnl_root.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_root.Location = new System.Drawing.Point(0, 437);
            this.pnl_root.Name = "pnl_root";
            this.pnl_root.Size = new System.Drawing.Size(613, 75);
            this.pnl_root.TabIndex = 1;
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(218)))), ((int)(((byte)(81)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(493, 12);
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
            this.btn_cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancel.Image")));
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(379, 12);
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
            this.pnl_body.Size = new System.Drawing.Size(613, 384);
            this.pnl_body.TabIndex = 2;
            // 
            // pnl_container
            // 
            this.pnl_container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.pnl_container.Controls.Add(this.txt_imagePath);
            this.pnl_container.Controls.Add(this.txt_id);
            this.pnl_container.Controls.Add(this.lbl_imageStatus);
            this.pnl_container.Controls.Add(this.btn_uploadImage);
            this.pnl_container.Controls.Add(this.pb_categoryImage);
            this.pnl_container.Controls.Add(this.label3);
            this.pnl_container.Controls.Add(this.label1);
            this.pnl_container.Controls.Add(this.rtxt_description);
            this.pnl_container.Controls.Add(this.txt_category);
            this.pnl_container.Controls.Add(this.label2);
            this.pnl_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_container.Location = new System.Drawing.Point(0, 0);
            this.pnl_container.Name = "pnl_container";
            this.pnl_container.Size = new System.Drawing.Size(613, 384);
            this.pnl_container.TabIndex = 0;
            // 
            // txt_imagePath
            // 
            this.txt_imagePath.Location = new System.Drawing.Point(350, 319);
            this.txt_imagePath.Name = "txt_imagePath";
            this.txt_imagePath.Size = new System.Drawing.Size(226, 23);
            this.txt_imagePath.TabIndex = 90;
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_id.Location = new System.Drawing.Point(14, 315);
            this.txt_id.Multiline = true;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(41, 51);
            this.txt_id.TabIndex = 89;
            // 
            // lbl_imageStatus
            // 
            this.lbl_imageStatus.AutoSize = true;
            this.lbl_imageStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_imageStatus.Location = new System.Drawing.Point(350, 345);
            this.lbl_imageStatus.Name = "lbl_imageStatus";
            this.lbl_imageStatus.Size = new System.Drawing.Size(101, 21);
            this.lbl_imageStatus.TabIndex = 36;
            this.lbl_imageStatus.Text = "image_status";
            // 
            // btn_uploadImage
            // 
            this.btn_uploadImage.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_uploadImage.Location = new System.Drawing.Point(350, 44);
            this.btn_uploadImage.Name = "btn_uploadImage";
            this.btn_uploadImage.Size = new System.Drawing.Size(226, 37);
            this.btn_uploadImage.TabIndex = 34;
            this.btn_uploadImage.Text = "choose from file";
            this.btn_uploadImage.UseVisualStyleBackColor = true;
            this.btn_uploadImage.Click += new System.EventHandler(this.btn_uploadImage_Click);
            // 
            // pb_categoryImage
            // 
            this.pb_categoryImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_categoryImage.Location = new System.Drawing.Point(350, 87);
            this.pb_categoryImage.Name = "pb_categoryImage";
            this.pb_categoryImage.Size = new System.Drawing.Size(226, 226);
            this.pb_categoryImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_categoryImage.TabIndex = 33;
            this.pb_categoryImage.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(350, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 30);
            this.label3.TabIndex = 32;
            this.label3.Text = "Image";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 30);
            this.label1.TabIndex = 31;
            this.label1.Text = "Description";
            // 
            // rtxt_description
            // 
            this.rtxt_description.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rtxt_description.Location = new System.Drawing.Point(14, 151);
            this.rtxt_description.Name = "rtxt_description";
            this.rtxt_description.Size = new System.Drawing.Size(288, 87);
            this.rtxt_description.TabIndex = 30;
            this.rtxt_description.Text = "";
            // 
            // txt_category
            // 
            this.txt_category.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_category.Location = new System.Drawing.Point(14, 43);
            this.txt_category.Multiline = true;
            this.txt_category.Name = "txt_category";
            this.txt_category.PlaceholderText = "category";
            this.txt_category.Size = new System.Drawing.Size(287, 40);
            this.txt_category.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 30);
            this.label2.TabIndex = 28;
            this.label2.Text = "Category";
            // 
            // frmCategory
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(613, 512);
            this.Controls.Add(this.pnl_body);
            this.Controls.Add(this.pnl_root);
            this.Controls.Add(this.pnl_head);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category   ";
            this.Load += new System.EventHandler(this.frmCategory_Load);
            this.pnl_head.ResumeLayout(false);
            this.pnl_head.PerformLayout();
            this.pnl_root.ResumeLayout(false);
            this.pnl_body.ResumeLayout(false);
            this.pnl_container.ResumeLayout(false);
            this.pnl_container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_categoryImage)).EndInit();
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
        private Button btn_uploadImage;
        private PictureBox pb_categoryImage;
        private Label label3;
        private Label label1;
        private RichTextBox rtxt_description;
        private TextBox txt_category;
        private Label label2;
        private Label lbl_imageStatus;
        private TextBox txt_id;
        private TextBox txt_imagePath;
    }
}