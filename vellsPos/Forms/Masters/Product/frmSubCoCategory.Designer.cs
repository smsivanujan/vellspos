namespace vellsPos.Forms.Layouts
{
    partial class frmSubCoCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSubCoCategory));
            this.pnl_head = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.pnl_root = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.pnl_body = new System.Windows.Forms.Panel();
            this.pnl_container = new System.Windows.Forms.Panel();
            this.txt_imagePath = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_imageStatus = new System.Windows.Forms.Label();
            this.btn_uploadImage = new System.Windows.Forms.Button();
            this.pb_subCoCategoryImage = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_subCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_category = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtxt_description = new System.Windows.Forms.RichTextBox();
            this.txt_subCoCategory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_head.SuspendLayout();
            this.pnl_root.SuspendLayout();
            this.pnl_body.SuspendLayout();
            this.pnl_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_subCoCategoryImage)).BeginInit();
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
            this.pnl_head.Size = new System.Drawing.Size(536, 53);
            this.pnl_head.TabIndex = 0;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.Location = new System.Drawing.Point(12, 11);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(212, 32);
            this.lbl_title.TabIndex = 5;
            this.lbl_title.Text = "Sub Co Category ";
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.Color.Transparent;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(497, 11);
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
            this.pnl_root.Size = new System.Drawing.Size(536, 75);
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
            this.btn_delete.Location = new System.Drawing.Point(188, 12);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_delete.Size = new System.Drawing.Size(108, 51);
            this.btn_delete.TabIndex = 8;
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
            this.btn_save.Location = new System.Drawing.Point(416, 12);
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
            this.btn_cancel.Location = new System.Drawing.Point(302, 12);
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
            this.pnl_body.Size = new System.Drawing.Size(536, 476);
            this.pnl_body.TabIndex = 2;
            // 
            // pnl_container
            // 
            this.pnl_container.Controls.Add(this.txt_imagePath);
            this.pnl_container.Controls.Add(this.txt_id);
            this.pnl_container.Controls.Add(this.lbl_imageStatus);
            this.pnl_container.Controls.Add(this.btn_uploadImage);
            this.pnl_container.Controls.Add(this.pb_subCoCategoryImage);
            this.pnl_container.Controls.Add(this.label4);
            this.pnl_container.Controls.Add(this.cmb_subCategory);
            this.pnl_container.Controls.Add(this.label3);
            this.pnl_container.Controls.Add(this.cmb_category);
            this.pnl_container.Controls.Add(this.label5);
            this.pnl_container.Controls.Add(this.label1);
            this.pnl_container.Controls.Add(this.rtxt_description);
            this.pnl_container.Controls.Add(this.txt_subCoCategory);
            this.pnl_container.Controls.Add(this.label2);
            this.pnl_container.Location = new System.Drawing.Point(12, 6);
            this.pnl_container.Name = "pnl_container";
            this.pnl_container.Size = new System.Drawing.Size(512, 464);
            this.pnl_container.TabIndex = 0;
            this.pnl_container.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_container_Paint);
            // 
            // txt_imagePath
            // 
            this.txt_imagePath.Location = new System.Drawing.Point(305, 290);
            this.txt_imagePath.Name = "txt_imagePath";
            this.txt_imagePath.Size = new System.Drawing.Size(192, 23);
            this.txt_imagePath.TabIndex = 91;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(243, 59);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(41, 23);
            this.txt_id.TabIndex = 89;
            // 
            // lbl_imageStatus
            // 
            this.lbl_imageStatus.AutoSize = true;
            this.lbl_imageStatus.Location = new System.Drawing.Point(304, 317);
            this.lbl_imageStatus.Name = "lbl_imageStatus";
            this.lbl_imageStatus.Size = new System.Drawing.Size(76, 15);
            this.lbl_imageStatus.TabIndex = 65;
            this.lbl_imageStatus.Text = "image_status";
            // 
            // btn_uploadImage
            // 
            this.btn_uploadImage.Location = new System.Drawing.Point(300, 253);
            this.btn_uploadImage.Name = "btn_uploadImage";
            this.btn_uploadImage.Size = new System.Drawing.Size(107, 31);
            this.btn_uploadImage.TabIndex = 63;
            this.btn_uploadImage.Text = "choose from file";
            this.btn_uploadImage.UseVisualStyleBackColor = true;
            this.btn_uploadImage.Click += new System.EventHandler(this.btn_uploadImage_Click);
            // 
            // pb_subCoCategoryImage
            // 
            this.pb_subCoCategoryImage.Location = new System.Drawing.Point(300, 16);
            this.pb_subCoCategoryImage.Name = "pb_subCoCategoryImage";
            this.pb_subCoCategoryImage.Size = new System.Drawing.Size(180, 180);
            this.pb_subCoCategoryImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_subCoCategoryImage.TabIndex = 62;
            this.pb_subCoCategoryImage.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Historic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(300, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 30);
            this.label4.TabIndex = 61;
            this.label4.Text = "Image";
            // 
            // cmb_subCategory
            // 
            this.cmb_subCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_subCategory.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmb_subCategory.FormattingEnabled = true;
            this.cmb_subCategory.Location = new System.Drawing.Point(16, 130);
            this.cmb_subCategory.Name = "cmb_subCategory";
            this.cmb_subCategory.Size = new System.Drawing.Size(221, 33);
            this.cmb_subCategory.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Historic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(16, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 30);
            this.label3.TabIndex = 59;
            this.label3.Text = "Sub Category";
            // 
            // cmb_category
            // 
            this.cmb_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_category.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmb_category.FormattingEnabled = true;
            this.cmb_category.Location = new System.Drawing.Point(16, 49);
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.Size = new System.Drawing.Size(221, 33);
            this.cmb_category.TabIndex = 58;
            this.cmb_category.SelectedIndexChanged += new System.EventHandler(this.cmb_category_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Historic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(14, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 30);
            this.label5.TabIndex = 57;
            this.label5.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(16, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 30);
            this.label1.TabIndex = 53;
            this.label1.Text = "Description";
            // 
            // rtxt_description
            // 
            this.rtxt_description.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rtxt_description.Location = new System.Drawing.Point(18, 308);
            this.rtxt_description.Name = "rtxt_description";
            this.rtxt_description.Size = new System.Drawing.Size(221, 62);
            this.rtxt_description.TabIndex = 52;
            this.rtxt_description.Text = "";
            // 
            // txt_subCoCategory
            // 
            this.txt_subCoCategory.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_subCoCategory.Location = new System.Drawing.Point(16, 216);
            this.txt_subCoCategory.Multiline = true;
            this.txt_subCoCategory.Name = "txt_subCoCategory";
            this.txt_subCoCategory.PlaceholderText = "category";
            this.txt_subCoCategory.Size = new System.Drawing.Size(221, 34);
            this.txt_subCoCategory.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Historic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(16, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 30);
            this.label2.TabIndex = 50;
            this.label2.Text = "Sub Co Category";
            // 
            // frmSubCoCategory
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(536, 604);
            this.Controls.Add(this.pnl_body);
            this.Controls.Add(this.pnl_root);
            this.Controls.Add(this.pnl_head);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSubCoCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sub Co Category ";
            this.Load += new System.EventHandler(this.frmSubCoCategory_Load);
            this.pnl_head.ResumeLayout(false);
            this.pnl_head.PerformLayout();
            this.pnl_root.ResumeLayout(false);
            this.pnl_body.ResumeLayout(false);
            this.pnl_container.ResumeLayout(false);
            this.pnl_container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_subCoCategoryImage)).EndInit();
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
        private ComboBox cmb_subCategory;
        private Label label3;
        private ComboBox cmb_category;
        private Label label5;
        private Label label1;
        private RichTextBox rtxt_description;
        private TextBox txt_subCoCategory;
        private Label label2;
        private Button btn_delete;
        private Label lbl_imageStatus;
        private Button btn_uploadImage;
        private PictureBox pb_subCoCategoryImage;
        private Label label4;
        private TextBox txt_id;
        private TextBox txt_imagePath;
    }
}