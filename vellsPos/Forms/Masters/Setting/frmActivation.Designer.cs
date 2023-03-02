namespace vellsPos.Forms.Masters.Setting
{
    partial class frmActivation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActivation));
            this.btn_active = new System.Windows.Forms.Button();
            this.gb_activation = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lbl_activationDayCount = new System.Windows.Forms.Label();
            this.lbl_activationStatus = new System.Windows.Forms.Label();
            this.pnl_rectancle = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_productKey = new System.Windows.Forms.TextBox();
            this.txt_productNumber = new System.Windows.Forms.TextBox();
            this.pnl_head = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.gb_activation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_head.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_active
            // 
            this.btn_active.BackColor = System.Drawing.Color.Lime;
            this.btn_active.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_active.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_active.ForeColor = System.Drawing.Color.Black;
            this.btn_active.Location = new System.Drawing.Point(257, 234);
            this.btn_active.Name = "btn_active";
            this.btn_active.Size = new System.Drawing.Size(241, 40);
            this.btn_active.TabIndex = 60;
            this.btn_active.Text = "ACTIVE";
            this.btn_active.UseVisualStyleBackColor = false;
            this.btn_active.Click += new System.EventHandler(this.btn_active_Click);
            // 
            // gb_activation
            // 
            this.gb_activation.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gb_activation.Controls.Add(this.pictureBox3);
            this.gb_activation.Controls.Add(this.linkLabel1);
            this.gb_activation.Controls.Add(this.lbl_activationDayCount);
            this.gb_activation.Controls.Add(this.lbl_activationStatus);
            this.gb_activation.Controls.Add(this.pnl_rectancle);
            this.gb_activation.Controls.Add(this.pictureBox2);
            this.gb_activation.Controls.Add(this.pictureBox1);
            this.gb_activation.Controls.Add(this.txt_productKey);
            this.gb_activation.Controls.Add(this.txt_productNumber);
            this.gb_activation.Controls.Add(this.btn_active);
            this.gb_activation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_activation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gb_activation.ForeColor = System.Drawing.Color.White;
            this.gb_activation.Location = new System.Drawing.Point(0, 0);
            this.gb_activation.Name = "gb_activation";
            this.gb_activation.Size = new System.Drawing.Size(743, 377);
            this.gb_activation.TabIndex = 61;
            this.gb_activation.TabStop = false;
            this.gb_activation.Text = "Serial Key";
            this.gb_activation.Enter += new System.EventHandler(this.gb_activation_Enter);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(533, 210);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 96;
            this.pictureBox3.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(558, 210);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(179, 21);
            this.linkLabel1.TabIndex = 95;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Activation Infomation";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            this.linkLabel1.Click += new System.EventHandler(this.linkLabel1_Click);
            // 
            // lbl_activationDayCount
            // 
            this.lbl_activationDayCount.AutoSize = true;
            this.lbl_activationDayCount.ForeColor = System.Drawing.Color.Red;
            this.lbl_activationDayCount.Location = new System.Drawing.Point(539, 171);
            this.lbl_activationDayCount.Name = "lbl_activationDayCount";
            this.lbl_activationDayCount.Size = new System.Drawing.Size(78, 21);
            this.lbl_activationDayCount.TabIndex = 94;
            this.lbl_activationDayCount.Text = "365 Days";
            // 
            // lbl_activationStatus
            // 
            this.lbl_activationStatus.AutoSize = true;
            this.lbl_activationStatus.ForeColor = System.Drawing.Color.Black;
            this.lbl_activationStatus.Location = new System.Drawing.Point(539, 120);
            this.lbl_activationStatus.Name = "lbl_activationStatus";
            this.lbl_activationStatus.Size = new System.Drawing.Size(192, 42);
            this.lbl_activationStatus.TabIndex = 93;
            this.lbl_activationStatus.Text = "This Product Activation \r\nkey will Expire in ";
            // 
            // pnl_rectancle
            // 
            this.pnl_rectancle.BackColor = System.Drawing.Color.Red;
            this.pnl_rectancle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_rectancle.Location = new System.Drawing.Point(517, 82);
            this.pnl_rectancle.Name = "pnl_rectancle";
            this.pnl_rectancle.Size = new System.Drawing.Size(10, 192);
            this.pnl_rectancle.TabIndex = 92;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(32, 178);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 91;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 90;
            this.pictureBox1.TabStop = false;
            // 
            // txt_productKey
            // 
            this.txt_productKey.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_productKey.Location = new System.Drawing.Point(100, 183);
            this.txt_productKey.Multiline = true;
            this.txt_productKey.Name = "txt_productKey";
            this.txt_productKey.PlaceholderText = "product key";
            this.txt_productKey.Size = new System.Drawing.Size(398, 40);
            this.txt_productKey.TabIndex = 89;
            // 
            // txt_productNumber
            // 
            this.txt_productNumber.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_productNumber.Location = new System.Drawing.Point(100, 108);
            this.txt_productNumber.Multiline = true;
            this.txt_productNumber.Name = "txt_productNumber";
            this.txt_productNumber.PlaceholderText = "product number";
            this.txt_productNumber.ReadOnly = true;
            this.txt_productNumber.Size = new System.Drawing.Size(398, 40);
            this.txt_productNumber.TabIndex = 88;
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnl_head.Controls.Add(this.lbl_title);
            this.pnl_head.Controls.Add(this.btn_close);
            this.pnl_head.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_head.Location = new System.Drawing.Point(0, 0);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(743, 53);
            this.pnl_head.TabIndex = 62;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(12, 11);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(131, 32);
            this.lbl_title.TabIndex = 5;
            this.lbl_title.Text = "Activation";
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.Color.Transparent;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(700, 11);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(31, 30);
            this.btn_close.TabIndex = 4;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // frmActivation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 377);
            this.Controls.Add(this.pnl_head);
            this.Controls.Add(this.gb_activation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmActivation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Activation ";
            this.Load += new System.EventHandler(this.frmActivations_Load);
            this.gb_activation.ResumeLayout(false);
            this.gb_activation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_head.ResumeLayout(false);
            this.pnl_head.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btn_active;
        private GroupBox gb_activation;
        private TextBox txt_productKey;
        private TextBox txt_productNumber;
        private Panel pnl_rectancle;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel pnl_head;
        private Label lbl_title;
        private Button btn_close;
        private Label lbl_activationStatus;
        private Label lbl_activationDayCount;
        private PictureBox pictureBox3;
        private LinkLabel linkLabel1;
    }
}