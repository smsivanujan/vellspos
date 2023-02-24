namespace vellsPos.Forms.Layouts
{
    partial class frmProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduct));
            this.pnl_head = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.pnl_root = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.cb_barcode = new System.Windows.Forms.CheckBox();
            this.ntxt_salePrice = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_imageStatus = new System.Windows.Forms.Label();
            this.cb_ageVerify = new System.Windows.Forms.CheckBox();
            this.lbl_imagePath = new System.Windows.Forms.Label();
            this.btn_uploadImage = new System.Windows.Forms.Button();
            this.pb_productImage = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_subCoCategory = new System.Windows.Forms.ComboBox();
            this.txt_productNumber = new System.Windows.Forms.TextBox();
            this.txt_productName = new System.Windows.Forms.TextBox();
            this.rtxt_description = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnl_head.SuspendLayout();
            this.pnl_root.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ntxt_salePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_productImage)).BeginInit();
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
            this.pnl_head.Size = new System.Drawing.Size(549, 53);
            this.pnl_head.TabIndex = 0;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.Location = new System.Drawing.Point(12, 11);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(105, 32);
            this.lbl_title.TabIndex = 5;
            this.lbl_title.Text = "Product";
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.Color.Transparent;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(510, 11);
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
            this.pnl_root.Location = new System.Drawing.Point(0, 796);
            this.pnl_root.Name = "pnl_root";
            this.pnl_root.Size = new System.Drawing.Size(549, 75);
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
            this.btn_delete.Location = new System.Drawing.Point(201, 12);
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
            this.btn_save.Location = new System.Drawing.Point(429, 12);
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
            this.btn_cancel.Location = new System.Drawing.Point(315, 12);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_cancel.Size = new System.Drawing.Size(108, 51);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_id);
            this.panel1.Controls.Add(this.cb_barcode);
            this.panel1.Controls.Add(this.ntxt_salePrice);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbl_imageStatus);
            this.panel1.Controls.Add(this.cb_ageVerify);
            this.panel1.Controls.Add(this.lbl_imagePath);
            this.panel1.Controls.Add(this.btn_uploadImage);
            this.panel1.Controls.Add(this.pb_productImage);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cmb_subCoCategory);
            this.panel1.Controls.Add(this.txt_productNumber);
            this.panel1.Controls.Add(this.txt_productName);
            this.panel1.Controls.Add(this.rtxt_description);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtp_date);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(12, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 731);
            this.panel1.TabIndex = 2;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(242, 59);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(41, 23);
            this.txt_id.TabIndex = 109;
            // 
            // cb_barcode
            // 
            this.cb_barcode.AutoSize = true;
            this.cb_barcode.Font = new System.Drawing.Font("Segoe UI Historic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_barcode.Location = new System.Drawing.Point(15, 599);
            this.cb_barcode.Name = "cb_barcode";
            this.cb_barcode.Size = new System.Drawing.Size(212, 34);
            this.cb_barcode.TabIndex = 108;
            this.cb_barcode.Text = "Dont Have Barcode";
            this.cb_barcode.UseVisualStyleBackColor = true;
            // 
            // ntxt_salePrice
            // 
            this.ntxt_salePrice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ntxt_salePrice.Location = new System.Drawing.Point(15, 298);
            this.ntxt_salePrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.ntxt_salePrice.Name = "ntxt_salePrice";
            this.ntxt_salePrice.Size = new System.Drawing.Size(221, 33);
            this.ntxt_salePrice.TabIndex = 107;
            this.ntxt_salePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ntxt_salePrice.ThousandsSeparator = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Historic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(15, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 30);
            this.label4.TabIndex = 106;
            this.label4.Text = "Sale Price";
            // 
            // lbl_imageStatus
            // 
            this.lbl_imageStatus.AutoSize = true;
            this.lbl_imageStatus.Location = new System.Drawing.Point(305, 328);
            this.lbl_imageStatus.Name = "lbl_imageStatus";
            this.lbl_imageStatus.Size = new System.Drawing.Size(69, 15);
            this.lbl_imageStatus.TabIndex = 41;
            this.lbl_imageStatus.Text = "image_path";
            // 
            // cb_ageVerify
            // 
            this.cb_ageVerify.AutoSize = true;
            this.cb_ageVerify.Font = new System.Drawing.Font("Segoe UI Historic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_ageVerify.Location = new System.Drawing.Point(15, 544);
            this.cb_ageVerify.Name = "cb_ageVerify";
            this.cb_ageVerify.Size = new System.Drawing.Size(128, 34);
            this.cb_ageVerify.TabIndex = 102;
            this.cb_ageVerify.Text = "Age Verify";
            this.cb_ageVerify.UseVisualStyleBackColor = true;
            // 
            // lbl_imagePath
            // 
            this.lbl_imagePath.AutoSize = true;
            this.lbl_imagePath.Location = new System.Drawing.Point(303, 298);
            this.lbl_imagePath.Name = "lbl_imagePath";
            this.lbl_imagePath.Size = new System.Drawing.Size(69, 15);
            this.lbl_imagePath.TabIndex = 40;
            this.lbl_imagePath.Text = "image_path";
            // 
            // btn_uploadImage
            // 
            this.btn_uploadImage.Location = new System.Drawing.Point(303, 264);
            this.btn_uploadImage.Name = "btn_uploadImage";
            this.btn_uploadImage.Size = new System.Drawing.Size(107, 31);
            this.btn_uploadImage.TabIndex = 39;
            this.btn_uploadImage.Text = "choose from file";
            this.btn_uploadImage.UseVisualStyleBackColor = true;
            this.btn_uploadImage.Click += new System.EventHandler(this.btn_uploadImage_Click);
            // 
            // pb_productImage
            // 
            this.pb_productImage.Location = new System.Drawing.Point(303, 48);
            this.pb_productImage.Name = "pb_productImage";
            this.pb_productImage.Size = new System.Drawing.Size(180, 180);
            this.pb_productImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_productImage.TabIndex = 38;
            this.pb_productImage.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Historic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(303, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 30);
            this.label7.TabIndex = 37;
            this.label7.Text = "Image";
            // 
            // cmb_subCoCategory
            // 
            this.cmb_subCoCategory.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmb_subCoCategory.FormattingEnabled = true;
            this.cmb_subCoCategory.Location = new System.Drawing.Point(15, 210);
            this.cmb_subCoCategory.Name = "cmb_subCoCategory";
            this.cmb_subCoCategory.Size = new System.Drawing.Size(221, 33);
            this.cmb_subCoCategory.TabIndex = 97;
            // 
            // txt_productNumber
            // 
            this.txt_productNumber.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_productNumber.Location = new System.Drawing.Point(15, 52);
            this.txt_productNumber.MaxLength = 12;
            this.txt_productNumber.Multiline = true;
            this.txt_productNumber.Name = "txt_productNumber";
            this.txt_productNumber.PlaceholderText = "product number";
            this.txt_productNumber.Size = new System.Drawing.Size(221, 34);
            this.txt_productNumber.TabIndex = 84;
            this.txt_productNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_productNumber_KeyPress);
            // 
            // txt_productName
            // 
            this.txt_productName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_productName.Location = new System.Drawing.Point(15, 128);
            this.txt_productName.Multiline = true;
            this.txt_productName.Name = "txt_productName";
            this.txt_productName.PlaceholderText = "category";
            this.txt_productName.Size = new System.Drawing.Size(221, 34);
            this.txt_productName.TabIndex = 86;
            // 
            // rtxt_description
            // 
            this.rtxt_description.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rtxt_description.Location = new System.Drawing.Point(15, 461);
            this.rtxt_description.Name = "rtxt_description";
            this.rtxt_description.Size = new System.Drawing.Size(221, 62);
            this.rtxt_description.TabIndex = 90;
            this.rtxt_description.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Historic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 30);
            this.label2.TabIndex = 83;
            this.label2.Text = "Product Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 30);
            this.label1.TabIndex = 85;
            this.label1.Text = "Product Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Historic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(15, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 30);
            this.label3.TabIndex = 87;
            this.label3.Text = "Sub Co Category";
            // 
            // dtp_date
            // 
            this.dtp_date.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_date.Location = new System.Drawing.Point(15, 383);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(221, 33);
            this.dtp_date.TabIndex = 88;
            this.dtp_date.Value = new System.DateTime(2023, 2, 8, 19, 27, 14, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Historic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(15, 428);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 30);
            this.label9.TabIndex = 91;
            this.label9.Text = "Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Historic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(15, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 30);
            this.label6.TabIndex = 89;
            this.label6.Text = "Added date";
            // 
            // frmProduct
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(549, 871);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_root);
            this.Controls.Add(this.pnl_head);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmForm";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            this.pnl_head.ResumeLayout(false);
            this.pnl_head.PerformLayout();
            this.pnl_root.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ntxt_salePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_productImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnl_head;
        private Button btn_close;
        private Label lbl_title;
        private Panel pnl_root;
        private Button btn_cancel;
        private Button btn_save;
        private Button btn_delete;
        private Panel panel1;
        private ComboBox cmb_subCoCategory;
        private TextBox txt_productNumber;
        private TextBox txt_productName;
        private RichTextBox rtxt_description;
        private Label label2;
        private Label label1;
        private Label label3;
        private DateTimePicker dtp_date;
        private Label label9;
        private Label label6;
        private CheckBox cb_ageVerify;
        private Label lbl_imageStatus;
        private Label lbl_imagePath;
        private Button btn_uploadImage;
        private PictureBox pb_productImage;
        private Label label7;
        private NumericUpDown ntxt_salePrice;
        private Label label4;
        private CheckBox cb_barcode;
        private TextBox txt_id;
    }
}