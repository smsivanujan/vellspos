namespace vellsPos.Forms.Layouts
{
    partial class frmProductBarcode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductBarcode));
            this.pnl_head = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.pnl_root = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.pnl_body = new System.Windows.Forms.Panel();
            this.pnl_container = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_pbStatus = new System.Windows.Forms.Label();
            this.txt_imagePath = new System.Windows.Forms.TextBox();
            this.lbl_imageStatus = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_productID = new System.Windows.Forms.TextBox();
            this.txt_product = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_generate = new System.Windows.Forms.Button();
            this.ntxt_height = new System.Windows.Forms.NumericUpDown();
            this.txt_productNumber = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cmb_barcodeType = new System.Windows.Forms.ComboBox();
            this.pb_barcodeImage = new System.Windows.Forms.PictureBox();
            this.pnl_head.SuspendLayout();
            this.pnl_root.SuspendLayout();
            this.pnl_body.SuspendLayout();
            this.pnl_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ntxt_height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_barcodeImage)).BeginInit();
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
            this.pnl_head.Size = new System.Drawing.Size(585, 53);
            this.pnl_head.TabIndex = 0;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(12, 11);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(205, 32);
            this.lbl_title.TabIndex = 5;
            this.lbl_title.Text = "Product Barcode";
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
            this.btn_close.Location = new System.Drawing.Point(546, 11);
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
            this.pnl_root.Location = new System.Drawing.Point(0, 579);
            this.pnl_root.Name = "pnl_root";
            this.pnl_root.Size = new System.Drawing.Size(585, 75);
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
            this.btn_save.Location = new System.Drawing.Point(465, 12);
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
            this.btn_cancel.Location = new System.Drawing.Point(351, 12);
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
            this.pnl_body.Size = new System.Drawing.Size(585, 526);
            this.pnl_body.TabIndex = 2;
            // 
            // pnl_container
            // 
            this.pnl_container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.pnl_container.Controls.Add(this.label7);
            this.pnl_container.Controls.Add(this.lbl_pbStatus);
            this.pnl_container.Controls.Add(this.txt_imagePath);
            this.pnl_container.Controls.Add(this.lbl_imageStatus);
            this.pnl_container.Controls.Add(this.txt_id);
            this.pnl_container.Controls.Add(this.label1);
            this.pnl_container.Controls.Add(this.txt_productID);
            this.pnl_container.Controls.Add(this.txt_product);
            this.pnl_container.Controls.Add(this.label3);
            this.pnl_container.Controls.Add(this.btn_generate);
            this.pnl_container.Controls.Add(this.ntxt_height);
            this.pnl_container.Controls.Add(this.txt_productNumber);
            this.pnl_container.Controls.Add(this.label10);
            this.pnl_container.Controls.Add(this.label16);
            this.pnl_container.Controls.Add(this.cmb_barcodeType);
            this.pnl_container.Controls.Add(this.pb_barcodeImage);
            this.pnl_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_container.Location = new System.Drawing.Point(0, 0);
            this.pnl_container.Name = "pnl_container";
            this.pnl_container.Size = new System.Drawing.Size(585, 526);
            this.pnl_container.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(342, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 30);
            this.label7.TabIndex = 125;
            this.label7.Text = "Image";
            // 
            // lbl_pbStatus
            // 
            this.lbl_pbStatus.AutoSize = true;
            this.lbl_pbStatus.Location = new System.Drawing.Point(436, 487);
            this.lbl_pbStatus.Name = "lbl_pbStatus";
            this.lbl_pbStatus.Size = new System.Drawing.Size(13, 15);
            this.lbl_pbStatus.TabIndex = 124;
            this.lbl_pbStatus.Text = "0";
            // 
            // txt_imagePath
            // 
            this.txt_imagePath.Location = new System.Drawing.Point(342, 282);
            this.txt_imagePath.Name = "txt_imagePath";
            this.txt_imagePath.Size = new System.Drawing.Size(226, 23);
            this.txt_imagePath.TabIndex = 123;
            // 
            // lbl_imageStatus
            // 
            this.lbl_imageStatus.AutoSize = true;
            this.lbl_imageStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_imageStatus.Location = new System.Drawing.Point(342, 314);
            this.lbl_imageStatus.Name = "lbl_imageStatus";
            this.lbl_imageStatus.Size = new System.Drawing.Size(101, 21);
            this.lbl_imageStatus.TabIndex = 122;
            this.lbl_imageStatus.Text = "image_status";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(527, 394);
            this.txt_id.Multiline = true;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(41, 51);
            this.txt_id.TabIndex = 121;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 30);
            this.label1.TabIndex = 118;
            this.label1.Text = "Product Number";
            // 
            // txt_productID
            // 
            this.txt_productID.Location = new System.Drawing.Point(527, 451);
            this.txt_productID.Multiline = true;
            this.txt_productID.Name = "txt_productID";
            this.txt_productID.Size = new System.Drawing.Size(41, 51);
            this.txt_productID.TabIndex = 117;
            this.txt_productID.TextChanged += new System.EventHandler(this.txt_productID_TextChanged);
            // 
            // txt_product
            // 
            this.txt_product.BackColor = System.Drawing.SystemColors.Control;
            this.txt_product.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_product.Location = new System.Drawing.Point(19, 50);
            this.txt_product.Multiline = true;
            this.txt_product.Name = "txt_product";
            this.txt_product.PlaceholderText = "[ Select ]";
            this.txt_product.Size = new System.Drawing.Size(287, 40);
            this.txt_product.TabIndex = 116;
            this.txt_product.Click += new System.EventHandler(this.txt_product_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 30);
            this.label3.TabIndex = 115;
            this.label3.Text = "Product";
            // 
            // btn_generate
            // 
            this.btn_generate.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_generate.Location = new System.Drawing.Point(19, 462);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(287, 40);
            this.btn_generate.TabIndex = 58;
            this.btn_generate.Text = "Generate";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // ntxt_height
            // 
            this.ntxt_height.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ntxt_height.Location = new System.Drawing.Point(102, 377);
            this.ntxt_height.Name = "ntxt_height";
            this.ntxt_height.Size = new System.Drawing.Size(73, 39);
            this.ntxt_height.TabIndex = 55;
            this.ntxt_height.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ntxt_height.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // txt_productNumber
            // 
            this.txt_productNumber.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_productNumber.Location = new System.Drawing.Point(19, 171);
            this.txt_productNumber.Multiline = true;
            this.txt_productNumber.Name = "txt_productNumber";
            this.txt_productNumber.PlaceholderText = "category";
            this.txt_productNumber.Size = new System.Drawing.Size(287, 40);
            this.txt_productNumber.TabIndex = 113;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(19, 381);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 30);
            this.label10.TabIndex = 53;
            this.label10.Text = "Height";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(19, 262);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(144, 30);
            this.label16.TabIndex = 79;
            this.label16.Text = "Barcode Type";
            // 
            // cmb_barcodeType
            // 
            this.cmb_barcodeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_barcodeType.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmb_barcodeType.FormattingEnabled = true;
            this.cmb_barcodeType.Items.AddRange(new object[] {
            "EAN13"});
            this.cmb_barcodeType.Location = new System.Drawing.Point(19, 295);
            this.cmb_barcodeType.Name = "cmb_barcodeType";
            this.cmb_barcodeType.Size = new System.Drawing.Size(287, 40);
            this.cmb_barcodeType.TabIndex = 80;
            // 
            // pb_barcodeImage
            // 
            this.pb_barcodeImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_barcodeImage.Location = new System.Drawing.Point(342, 50);
            this.pb_barcodeImage.Name = "pb_barcodeImage";
            this.pb_barcodeImage.Size = new System.Drawing.Size(226, 226);
            this.pb_barcodeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_barcodeImage.TabIndex = 85;
            this.pb_barcodeImage.TabStop = false;
            // 
            // frmProductBarcode
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(585, 654);
            this.Controls.Add(this.pnl_body);
            this.Controls.Add(this.pnl_root);
            this.Controls.Add(this.pnl_head);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProductBarcode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Barcode ";
            this.Load += new System.EventHandler(this.frmProductBarcode_Load);
            this.pnl_head.ResumeLayout(false);
            this.pnl_head.PerformLayout();
            this.pnl_root.ResumeLayout(false);
            this.pnl_body.ResumeLayout(false);
            this.pnl_container.ResumeLayout(false);
            this.pnl_container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ntxt_height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_barcodeImage)).EndInit();
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
        private PictureBox pb_barcodeImage;
        private NumericUpDown ntxt_height;
        private Label label10;
        private Button btn_generate;
        private TextBox txt_productNumber;
        private TextBox txt_productID;
        private TextBox txt_product;
        private Label label3;
        private Label label1;
        private Label label16;
        private ComboBox cmb_barcodeType;
        private TextBox txt_id;
        private TextBox txt_imagePath;
        private Label lbl_imageStatus;
        private Label lbl_pbStatus;
        private Label label7;
    }
}