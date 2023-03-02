namespace vellsPos.Forms.Layouts
{
    partial class frmPointOfSale
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPointOfSale));
            this.pnl_head = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.lbl_maxStatus = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_maximize = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_currentDateTime = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pb_titleImage = new System.Windows.Forms.PictureBox();
            this.pnl_saleDetail = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnl_paymentDetail = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnl_saleButton = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pnl_productPurchaseList = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnl_shortCutButton = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.btn_return = new System.Windows.Forms.Button();
            this.btn_holdBill = new System.Windows.Forms.Button();
            this.btn_payout = new System.Windows.Forms.Button();
            this.pnl_search = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.currentDateTimeClock = new System.Windows.Forms.Timer(this.components);
            this.pnl_showCase = new System.Windows.Forms.Panel();
            this.gb_product = new System.Windows.Forms.GroupBox();
            this.gb_subCoCategory = new System.Windows.Forms.GroupBox();
            this.gb_subCategory = new System.Windows.Forms.GroupBox();
            this.gb_category = new System.Windows.Forms.GroupBox();
            this.btn_nextBill = new System.Windows.Forms.Button();
            this.btn_previousBill = new System.Windows.Forms.Button();
            this.cb_drawerOpen = new System.Windows.Forms.CheckBox();
            this.pnl_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_titleImage)).BeginInit();
            this.pnl_saleDetail.SuspendLayout();
            this.pnl_paymentDetail.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.pnl_saleButton.SuspendLayout();
            this.pnl_productPurchaseList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnl_shortCutButton.SuspendLayout();
            this.pnl_search.SuspendLayout();
            this.pnl_showCase.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pnl_head.Controls.Add(this.btn_logout);
            this.pnl_head.Controls.Add(this.lbl_maxStatus);
            this.pnl_head.Controls.Add(this.pictureBox2);
            this.pnl_head.Controls.Add(this.btn_maximize);
            this.pnl_head.Controls.Add(this.label3);
            this.pnl_head.Controls.Add(this.btn_minimize);
            this.pnl_head.Controls.Add(this.btn_close);
            this.pnl_head.Controls.Add(this.lbl_currentDateTime);
            this.pnl_head.Controls.Add(this.lbl_title);
            this.pnl_head.Controls.Add(this.pb_titleImage);
            this.pnl_head.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_head.Location = new System.Drawing.Point(0, 0);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(1300, 56);
            this.pnl_head.TabIndex = 0;
            this.pnl_head.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_logout
            // 
            this.btn_logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_logout.BackColor = System.Drawing.Color.Red;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_logout.Image")));
            this.btn_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.Location = new System.Drawing.Point(835, 7);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_logout.Size = new System.Drawing.Size(58, 41);
            this.btn_logout.TabIndex = 32;
            this.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_maxStatus
            // 
            this.lbl_maxStatus.AutoSize = true;
            this.lbl_maxStatus.Location = new System.Drawing.Point(1137, 32);
            this.lbl_maxStatus.Name = "lbl_maxStatus";
            this.lbl_maxStatus.Size = new System.Drawing.Size(13, 15);
            this.lbl_maxStatus.TabIndex = 37;
            this.lbl_maxStatus.Text = "0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(631, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 47);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // btn_maximize
            // 
            this.btn_maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_maximize.BackColor = System.Drawing.Color.Transparent;
            this.btn_maximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_maximize.ForeColor = System.Drawing.Color.Transparent;
            this.btn_maximize.Image = ((System.Drawing.Image)(resources.GetObject("btn_maximize.Image")));
            this.btn_maximize.Location = new System.Drawing.Point(1202, 7);
            this.btn_maximize.Name = "btn_maximize";
            this.btn_maximize.Size = new System.Drawing.Size(40, 40);
            this.btn_maximize.TabIndex = 36;
            this.btn_maximize.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Historic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(704, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 30);
            this.label3.TabIndex = 32;
            this.label3.Text = "Ganapathy";
            // 
            // btn_minimize
            // 
            this.btn_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimize.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.ForeColor = System.Drawing.Color.Transparent;
            this.btn_minimize.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimize.Image")));
            this.btn_minimize.Location = new System.Drawing.Point(1156, 7);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(40, 40);
            this.btn_minimize.TabIndex = 35;
            this.btn_minimize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_minimize.UseVisualStyleBackColor = false;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.Red;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.Color.Transparent;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(1248, 7);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(40, 40);
            this.btn_close.TabIndex = 34;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_currentDateTime
            // 
            this.lbl_currentDateTime.AutoSize = true;
            this.lbl_currentDateTime.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_currentDateTime.Location = new System.Drawing.Point(337, 13);
            this.lbl_currentDateTime.Name = "lbl_currentDateTime";
            this.lbl_currentDateTime.Size = new System.Drawing.Size(271, 32);
            this.lbl_currentDateTime.TabIndex = 33;
            this.lbl_currentDateTime.Text = "12-02-2022 12:15:25 AM";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.Location = new System.Drawing.Point(64, 6);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(179, 45);
            this.lbl_title.TabIndex = 3;
            this.lbl_title.Text = "VELLS POS";
            // 
            // pb_titleImage
            // 
            this.pb_titleImage.Image = ((System.Drawing.Image)(resources.GetObject("pb_titleImage.Image")));
            this.pb_titleImage.Location = new System.Drawing.Point(12, 6);
            this.pb_titleImage.Name = "pb_titleImage";
            this.pb_titleImage.Size = new System.Drawing.Size(46, 46);
            this.pb_titleImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_titleImage.TabIndex = 2;
            this.pb_titleImage.TabStop = false;
            // 
            // pnl_saleDetail
            // 
            this.pnl_saleDetail.Controls.Add(this.comboBox1);
            this.pnl_saleDetail.Controls.Add(this.textBox3);
            this.pnl_saleDetail.Controls.Add(this.label7);
            this.pnl_saleDetail.Controls.Add(this.label6);
            this.pnl_saleDetail.Controls.Add(this.textBox2);
            this.pnl_saleDetail.Controls.Add(this.label5);
            this.pnl_saleDetail.Controls.Add(this.pnl_paymentDetail);
            this.pnl_saleDetail.Controls.Add(this.textBox1);
            this.pnl_saleDetail.Controls.Add(this.pnl_saleButton);
            this.pnl_saleDetail.Controls.Add(this.pnl_productPurchaseList);
            this.pnl_saleDetail.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_saleDetail.Location = new System.Drawing.Point(687, 56);
            this.pnl_saleDetail.Name = "pnl_saleDetail";
            this.pnl_saleDetail.Size = new System.Drawing.Size(613, 664);
            this.pnl_saleDetail.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "%",
            "0"});
            this.comboBox1.Location = new System.Drawing.Point(83, 475);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(47, 23);
            this.comboBox1.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(136, 516);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.PlaceholderText = "category";
            this.textBox3.Size = new System.Drawing.Size(123, 29);
            this.textBox3.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(6, 524);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 21);
            this.label7.TabIndex = 36;
            this.label7.Text = "Loyality Poits";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(6, 470);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 21);
            this.label6.TabIndex = 34;
            this.label6.Text = "Discount";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(136, 470);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "category";
            this.textBox2.Size = new System.Drawing.Size(123, 29);
            this.textBox2.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Historic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(85, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 30);
            this.label5.TabIndex = 32;
            this.label5.Text = "Payable";
            // 
            // pnl_paymentDetail
            // 
            this.pnl_paymentDetail.Controls.Add(this.tabControl1);
            this.pnl_paymentDetail.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_paymentDetail.Location = new System.Drawing.Point(265, 354);
            this.pnl_paymentDetail.Name = "pnl_paymentDetail";
            this.pnl_paymentDetail.Size = new System.Drawing.Size(348, 243);
            this.pnl_paymentDetail.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(17, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(306, 179);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(298, 145);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Payment";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(298, 145);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 30);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(298, 145);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Loyality Points";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(6, 390);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "category";
            this.textBox1.Size = new System.Drawing.Size(253, 51);
            this.textBox1.TabIndex = 32;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnl_saleButton
            // 
            this.pnl_saleButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pnl_saleButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_saleButton.Controls.Add(this.btn_previousBill);
            this.pnl_saleButton.Controls.Add(this.btn_nextBill);
            this.pnl_saleButton.Controls.Add(this.button2);
            this.pnl_saleButton.Controls.Add(this.btn_holdBill);
            this.pnl_saleButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_saleButton.Location = new System.Drawing.Point(0, 597);
            this.pnl_saleButton.Name = "pnl_saleButton";
            this.pnl_saleButton.Size = new System.Drawing.Size(613, 67);
            this.pnl_saleButton.TabIndex = 5;
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.Color.Transparent;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(426, 16);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(43, 40);
            this.button8.TabIndex = 34;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // txt_search
            // 
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_search.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_search.Location = new System.Drawing.Point(82, 16);
            this.txt_search.Multiline = true;
            this.txt_search.Name = "txt_search";
            this.txt_search.PlaceholderText = "search here";
            this.txt_search.Size = new System.Drawing.Size(338, 40);
            this.txt_search.TabIndex = 33;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(487, 10);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(113, 51);
            this.button2.TabIndex = 32;
            this.button2.Text = "PRINT";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // pnl_productPurchaseList
            // 
            this.pnl_productPurchaseList.Controls.Add(this.dataGridView1);
            this.pnl_productPurchaseList.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_productPurchaseList.Location = new System.Drawing.Point(0, 0);
            this.pnl_productPurchaseList.Name = "pnl_productPurchaseList";
            this.pnl_productPurchaseList.Size = new System.Drawing.Size(613, 354);
            this.pnl_productPurchaseList.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.clm_qty,
            this.clm_discount,
            this.clm_price,
            this.clm_remove});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(613, 354);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "No";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 30;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Product No";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Unit Price";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // clm_qty
            // 
            this.clm_qty.HeaderText = "Qty";
            this.clm_qty.Name = "clm_qty";
            this.clm_qty.Width = 30;
            // 
            // clm_discount
            // 
            this.clm_discount.HeaderText = "Dis.";
            this.clm_discount.Name = "clm_discount";
            this.clm_discount.ReadOnly = true;
            this.clm_discount.Width = 30;
            // 
            // clm_price
            // 
            this.clm_price.HeaderText = "Price";
            this.clm_price.Name = "clm_price";
            // 
            // clm_remove
            // 
            this.clm_remove.HeaderText = "Remove";
            this.clm_remove.Name = "clm_remove";
            this.clm_remove.Width = 50;
            // 
            // pnl_shortCutButton
            // 
            this.pnl_shortCutButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pnl_shortCutButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_shortCutButton.Controls.Add(this.cb_drawerOpen);
            this.pnl_shortCutButton.Controls.Add(this.button9);
            this.pnl_shortCutButton.Controls.Add(this.button11);
            this.pnl_shortCutButton.Controls.Add(this.button14);
            this.pnl_shortCutButton.Controls.Add(this.button15);
            this.pnl_shortCutButton.Controls.Add(this.btn_return);
            this.pnl_shortCutButton.Controls.Add(this.btn_payout);
            this.pnl_shortCutButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_shortCutButton.Location = new System.Drawing.Point(0, 599);
            this.pnl_shortCutButton.Name = "pnl_shortCutButton";
            this.pnl_shortCutButton.Size = new System.Drawing.Size(687, 121);
            this.pnl_shortCutButton.TabIndex = 2;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(180, 69);
            this.button9.Name = "button9";
            this.button9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button9.Size = new System.Drawing.Size(141, 40);
            this.button9.TabIndex = 39;
            this.button9.Text = "Return ";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.Location = new System.Drawing.Point(34, 69);
            this.button11.Name = "button11";
            this.button11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button11.Size = new System.Drawing.Size(140, 40);
            this.button11.TabIndex = 38;
            this.button11.Text = "HOLD";
            this.button11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button14.Image = ((System.Drawing.Image)(resources.GetObject("button14.Image")));
            this.button14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.Location = new System.Drawing.Point(180, 69);
            this.button14.Name = "button14";
            this.button14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button14.Size = new System.Drawing.Size(141, 40);
            this.button14.TabIndex = 37;
            this.button14.Text = "Payout";
            this.button14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button15.Image = ((System.Drawing.Image)(resources.GetObject("button15.Image")));
            this.button15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button15.Location = new System.Drawing.Point(33, 23);
            this.button15.Name = "button15";
            this.button15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button15.Size = new System.Drawing.Size(141, 40);
            this.button15.TabIndex = 36;
            this.button15.Text = "Drawer";
            this.button15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button15.UseVisualStyleBackColor = false;
            // 
            // btn_return
            // 
            this.btn_return.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_return.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_return.Image = ((System.Drawing.Image)(resources.GetObject("btn_return.Image")));
            this.btn_return.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_return.Location = new System.Drawing.Point(180, 23);
            this.btn_return.Name = "btn_return";
            this.btn_return.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_return.Size = new System.Drawing.Size(141, 40);
            this.btn_return.TabIndex = 35;
            this.btn_return.Text = "Return ";
            this.btn_return.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_return.UseVisualStyleBackColor = false;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // btn_holdBill
            // 
            this.btn_holdBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_holdBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_holdBill.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_holdBill.Image = ((System.Drawing.Image)(resources.GetObject("btn_holdBill.Image")));
            this.btn_holdBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_holdBill.Location = new System.Drawing.Point(238, 10);
            this.btn_holdBill.Name = "btn_holdBill";
            this.btn_holdBill.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_holdBill.Size = new System.Drawing.Size(140, 51);
            this.btn_holdBill.TabIndex = 34;
            this.btn_holdBill.Text = "HOLD BILL";
            this.btn_holdBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_holdBill.UseVisualStyleBackColor = false;
            // 
            // btn_payout
            // 
            this.btn_payout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_payout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_payout.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_payout.Image = ((System.Drawing.Image)(resources.GetObject("btn_payout.Image")));
            this.btn_payout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_payout.Location = new System.Drawing.Point(497, 68);
            this.btn_payout.Name = "btn_payout";
            this.btn_payout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_payout.Size = new System.Drawing.Size(175, 40);
            this.btn_payout.TabIndex = 33;
            this.btn_payout.Text = "Payout";
            this.btn_payout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_payout.UseVisualStyleBackColor = false;
            this.btn_payout.Click += new System.EventHandler(this.btn_payout_Click);
            // 
            // pnl_search
            // 
            this.pnl_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_search.Controls.Add(this.button8);
            this.pnl_search.Controls.Add(this.label2);
            this.pnl_search.Controls.Add(this.txt_search);
            this.pnl_search.Controls.Add(this.btn_add);
            this.pnl_search.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_search.Location = new System.Drawing.Point(0, 56);
            this.pnl_search.Name = "pnl_search";
            this.pnl_search.Size = new System.Drawing.Size(687, 73);
            this.pnl_search.TabIndex = 3;
            this.pnl_search.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_search_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 30);
            this.label2.TabIndex = 31;
            this.label2.Text = "BC/N";
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.BackColor = System.Drawing.Color.Lime;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(545, 16);
            this.btn_add.Name = "btn_add";
            this.btn_add.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_add.Size = new System.Drawing.Size(134, 40);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = " ADD";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // currentDateTimeClock
            // 
            this.currentDateTimeClock.Enabled = true;
            this.currentDateTimeClock.Interval = 1000;
            this.currentDateTimeClock.Tick += new System.EventHandler(this.currentDateTimeClock_Tick);
            // 
            // pnl_showCase
            // 
            this.pnl_showCase.Controls.Add(this.gb_product);
            this.pnl_showCase.Controls.Add(this.gb_subCoCategory);
            this.pnl_showCase.Controls.Add(this.gb_subCategory);
            this.pnl_showCase.Controls.Add(this.gb_category);
            this.pnl_showCase.Location = new System.Drawing.Point(13, 135);
            this.pnl_showCase.Name = "pnl_showCase";
            this.pnl_showCase.Size = new System.Drawing.Size(667, 464);
            this.pnl_showCase.TabIndex = 4;
            // 
            // gb_product
            // 
            this.gb_product.Dock = System.Windows.Forms.DockStyle.Left;
            this.gb_product.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gb_product.Location = new System.Drawing.Point(485, 0);
            this.gb_product.Name = "gb_product";
            this.gb_product.Size = new System.Drawing.Size(197, 464);
            this.gb_product.TabIndex = 11;
            this.gb_product.TabStop = false;
            this.gb_product.Text = "products";
            // 
            // gb_subCoCategory
            // 
            this.gb_subCoCategory.Dock = System.Windows.Forms.DockStyle.Left;
            this.gb_subCoCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gb_subCoCategory.Location = new System.Drawing.Point(326, 0);
            this.gb_subCoCategory.Name = "gb_subCoCategory";
            this.gb_subCoCategory.Size = new System.Drawing.Size(159, 464);
            this.gb_subCoCategory.TabIndex = 10;
            this.gb_subCoCategory.TabStop = false;
            this.gb_subCoCategory.Text = "Sub Co Categories";
            // 
            // gb_subCategory
            // 
            this.gb_subCategory.Dock = System.Windows.Forms.DockStyle.Left;
            this.gb_subCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gb_subCategory.Location = new System.Drawing.Point(162, 0);
            this.gb_subCategory.Name = "gb_subCategory";
            this.gb_subCategory.Size = new System.Drawing.Size(164, 464);
            this.gb_subCategory.TabIndex = 9;
            this.gb_subCategory.TabStop = false;
            this.gb_subCategory.Text = "Sub Categories";
            // 
            // gb_category
            // 
            this.gb_category.Dock = System.Windows.Forms.DockStyle.Left;
            this.gb_category.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gb_category.Location = new System.Drawing.Point(0, 0);
            this.gb_category.Name = "gb_category";
            this.gb_category.Size = new System.Drawing.Size(162, 464);
            this.gb_category.TabIndex = 8;
            this.gb_category.TabStop = false;
            this.gb_category.Text = "Categories";
            // 
            // btn_nextBill
            // 
            this.btn_nextBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_nextBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nextBill.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_nextBill.Image = ((System.Drawing.Image)(resources.GetObject("btn_nextBill.Image")));
            this.btn_nextBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nextBill.Location = new System.Drawing.Point(135, 10);
            this.btn_nextBill.Name = "btn_nextBill";
            this.btn_nextBill.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_nextBill.Size = new System.Drawing.Size(97, 51);
            this.btn_nextBill.TabIndex = 35;
            this.btn_nextBill.Text = "Next";
            this.btn_nextBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_nextBill.UseVisualStyleBackColor = false;
            // 
            // btn_previousBill
            // 
            this.btn_previousBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_previousBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_previousBill.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_previousBill.Image = ((System.Drawing.Image)(resources.GetObject("btn_previousBill.Image")));
            this.btn_previousBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_previousBill.Location = new System.Drawing.Point(5, 10);
            this.btn_previousBill.Name = "btn_previousBill";
            this.btn_previousBill.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_previousBill.Size = new System.Drawing.Size(124, 51);
            this.btn_previousBill.TabIndex = 36;
            this.btn_previousBill.Text = "Prevoius";
            this.btn_previousBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_previousBill.UseVisualStyleBackColor = false;
            // 
            // cb_drawerOpen
            // 
            this.cb_drawerOpen.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb_drawerOpen.AutoSize = true;
            this.cb_drawerOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.cb_drawerOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_drawerOpen.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cb_drawerOpen.Location = new System.Drawing.Point(497, 18);
            this.cb_drawerOpen.Name = "cb_drawerOpen";
            this.cb_drawerOpen.Size = new System.Drawing.Size(175, 42);
            this.cb_drawerOpen.TabIndex = 69;
            this.cb_drawerOpen.Text = "Drawer Open";
            this.cb_drawerOpen.UseVisualStyleBackColor = false;
            // 
            // frmPointOfSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 720);
            this.Controls.Add(this.pnl_showCase);
            this.Controls.Add(this.pnl_search);
            this.Controls.Add(this.pnl_shortCutButton);
            this.Controls.Add(this.pnl_saleDetail);
            this.Controls.Add(this.pnl_head);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPointOfSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POS";
            this.Load += new System.EventHandler(this.frmPointOfSale_Load);
            this.pnl_head.ResumeLayout(false);
            this.pnl_head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_titleImage)).EndInit();
            this.pnl_saleDetail.ResumeLayout(false);
            this.pnl_saleDetail.PerformLayout();
            this.pnl_paymentDetail.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.pnl_saleButton.ResumeLayout(false);
            this.pnl_productPurchaseList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnl_shortCutButton.ResumeLayout(false);
            this.pnl_shortCutButton.PerformLayout();
            this.pnl_search.ResumeLayout(false);
            this.pnl_search.PerformLayout();
            this.pnl_showCase.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnl_head;
        private Panel pnl_saleDetail;
        private Panel pnl_shortCutButton;
        private Panel pnl_search;
        private Panel pnl_productPurchaseList;
        private Button btn_add;
        private Label label2;
        private Label lbl_currentDateTime;
        private Button btn_logout;
        private Label label3;
        private PictureBox pictureBox2;
        private Label lbl_title;
        private PictureBox pb_titleImage;
        private Button btn_return;
        private Button btn_holdBill;
        private Button btn_payout;
        private Panel pnl_saleButton;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private DataGridView dataGridView1;
        private Label label7;
        private TextBox textBox3;
        private Label label6;
        private TextBox textBox2;
        private Label label5;
        private Panel pnl_paymentDetail;
        private TextBox textBox1;
        private Button button2;
        private ComboBox comboBox1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn clm_qty;
        private DataGridViewTextBoxColumn clm_discount;
        private DataGridViewTextBoxColumn clm_price;
        private DataGridViewButtonColumn clm_remove;
        private System.Windows.Forms.Timer currentDateTimeClock;
        private Label lbl_maxStatus;
        private Button btn_maximize;
        private Button btn_minimize;
        private Button btn_close;
        private Button button8;
        private TextBox txt_search;
        private Button button9;
        private Button button11;
        private Button button14;
        private Button button15;
        private Panel pnl_showCase;
        private GroupBox gb_product;
        private GroupBox gb_subCoCategory;
        private GroupBox gb_subCategory;
        private GroupBox gb_category;
        private Button btn_previousBill;
        private Button btn_nextBill;
        private CheckBox cb_drawerOpen;
    }
}