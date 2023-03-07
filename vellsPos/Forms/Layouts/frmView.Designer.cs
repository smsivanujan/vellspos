namespace vellsPos.Forms.Layouts
{
    partial class frmView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmView));
            this.pnl_base = new System.Windows.Forms.Panel();
            this.pnl_baseBody = new System.Windows.Forms.Panel();
            this.tbl_layoutBase = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_header = new System.Windows.Forms.Panel();
            this.tbl_layoutHeader = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_title = new System.Windows.Forms.Panel();
            this.pb_img = new System.Windows.Forms.PictureBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pnl_add = new System.Windows.Forms.Panel();
            this.btn_add = new System.Windows.Forms.Button();
            this.pnl_search = new System.Windows.Forms.Panel();
            this.pb_search = new System.Windows.Forms.PictureBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.pnl_footer = new System.Windows.Forms.Panel();
            this.tbl_layoutFooter = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_sort = new System.Windows.Forms.Panel();
            this.lbl_sortStatus = new System.Windows.Forms.Label();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_previous = new System.Windows.Forms.Button();
            this.pnl_body = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.pnl_head = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.pnl_base.SuspendLayout();
            this.pnl_baseBody.SuspendLayout();
            this.tbl_layoutBase.SuspendLayout();
            this.pnl_header.SuspendLayout();
            this.tbl_layoutHeader.SuspendLayout();
            this.pnl_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_img)).BeginInit();
            this.pnl_add.SuspendLayout();
            this.pnl_search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_search)).BeginInit();
            this.pnl_footer.SuspendLayout();
            this.tbl_layoutFooter.SuspendLayout();
            this.pnl_sort.SuspendLayout();
            this.pnl_body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.pnl_head.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_base
            // 
            this.pnl_base.Controls.Add(this.pnl_baseBody);
            this.pnl_base.Controls.Add(this.pnl_head);
            this.pnl_base.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_base.Location = new System.Drawing.Point(0, 0);
            this.pnl_base.Name = "pnl_base";
            this.pnl_base.Size = new System.Drawing.Size(1059, 576);
            this.pnl_base.TabIndex = 0;
            // 
            // pnl_baseBody
            // 
            this.pnl_baseBody.Controls.Add(this.tbl_layoutBase);
            this.pnl_baseBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_baseBody.Location = new System.Drawing.Point(0, 53);
            this.pnl_baseBody.Name = "pnl_baseBody";
            this.pnl_baseBody.Size = new System.Drawing.Size(1059, 523);
            this.pnl_baseBody.TabIndex = 2;
            // 
            // tbl_layoutBase
            // 
            this.tbl_layoutBase.ColumnCount = 1;
            this.tbl_layoutBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_layoutBase.Controls.Add(this.pnl_header, 0, 0);
            this.tbl_layoutBase.Controls.Add(this.pnl_footer, 0, 2);
            this.tbl_layoutBase.Controls.Add(this.pnl_body, 0, 1);
            this.tbl_layoutBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_layoutBase.Location = new System.Drawing.Point(0, 0);
            this.tbl_layoutBase.Name = "tbl_layoutBase";
            this.tbl_layoutBase.RowCount = 3;
            this.tbl_layoutBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tbl_layoutBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_layoutBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tbl_layoutBase.Size = new System.Drawing.Size(1059, 523);
            this.tbl_layoutBase.TabIndex = 0;
            // 
            // pnl_header
            // 
            this.pnl_header.Controls.Add(this.tbl_layoutHeader);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_header.Location = new System.Drawing.Point(3, 3);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(1053, 75);
            this.pnl_header.TabIndex = 0;
            // 
            // tbl_layoutHeader
            // 
            this.tbl_layoutHeader.ColumnCount = 3;
            this.tbl_layoutHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_layoutHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_layoutHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tbl_layoutHeader.Controls.Add(this.pnl_title, 0, 0);
            this.tbl_layoutHeader.Controls.Add(this.pnl_add, 1, 0);
            this.tbl_layoutHeader.Controls.Add(this.pnl_search, 2, 0);
            this.tbl_layoutHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_layoutHeader.Location = new System.Drawing.Point(0, 0);
            this.tbl_layoutHeader.Name = "tbl_layoutHeader";
            this.tbl_layoutHeader.RowCount = 1;
            this.tbl_layoutHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_layoutHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_layoutHeader.Size = new System.Drawing.Size(1053, 75);
            this.tbl_layoutHeader.TabIndex = 0;
            // 
            // pnl_title
            // 
            this.pnl_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.pnl_title.Controls.Add(this.pb_img);
            this.pnl_title.Controls.Add(this.lbl_title);
            this.pnl_title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_title.Location = new System.Drawing.Point(3, 3);
            this.pnl_title.Name = "pnl_title";
            this.pnl_title.Size = new System.Drawing.Size(370, 69);
            this.pnl_title.TabIndex = 0;
            // 
            // pb_img
            // 
            this.pb_img.Location = new System.Drawing.Point(303, 4);
            this.pb_img.Name = "pb_img";
            this.pb_img.Size = new System.Drawing.Size(60, 60);
            this.pb_img.TabIndex = 1;
            this.pb_img.TabStop = false;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(17, 15);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(68, 30);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "label1";
            // 
            // pnl_add
            // 
            this.pnl_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.pnl_add.Controls.Add(this.btn_add);
            this.pnl_add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_add.Location = new System.Drawing.Point(379, 3);
            this.pnl_add.Name = "pnl_add";
            this.pnl_add.Size = new System.Drawing.Size(370, 69);
            this.pnl_add.TabIndex = 1;
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.BackColor = System.Drawing.Color.Blue;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(164, 8);
            this.btn_add.Name = "btn_add";
            this.btn_add.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_add.Size = new System.Drawing.Size(59, 51);
            this.btn_add.TabIndex = 2;
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // pnl_search
            // 
            this.pnl_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.pnl_search.Controls.Add(this.pb_search);
            this.pnl_search.Controls.Add(this.txt_search);
            this.pnl_search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_search.Location = new System.Drawing.Point(755, 3);
            this.pnl_search.Name = "pnl_search";
            this.pnl_search.Size = new System.Drawing.Size(295, 69);
            this.pnl_search.TabIndex = 2;
            // 
            // pb_search
            // 
            this.pb_search.BackColor = System.Drawing.Color.White;
            this.pb_search.Image = ((System.Drawing.Image)(resources.GetObject("pb_search.Image")));
            this.pb_search.Location = new System.Drawing.Point(3, 8);
            this.pb_search.Name = "pb_search";
            this.pb_search.Size = new System.Drawing.Size(53, 49);
            this.pb_search.TabIndex = 2;
            this.pb_search.TabStop = false;
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_search.Location = new System.Drawing.Point(62, 8);
            this.txt_search.Multiline = true;
            this.txt_search.Name = "txt_search";
            this.txt_search.PlaceholderText = "category";
            this.txt_search.Size = new System.Drawing.Size(227, 49);
            this.txt_search.TabIndex = 87;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // pnl_footer
            // 
            this.pnl_footer.Controls.Add(this.tbl_layoutFooter);
            this.pnl_footer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_footer.Location = new System.Drawing.Point(3, 472);
            this.pnl_footer.Name = "pnl_footer";
            this.pnl_footer.Size = new System.Drawing.Size(1053, 48);
            this.pnl_footer.TabIndex = 1;
            // 
            // tbl_layoutFooter
            // 
            this.tbl_layoutFooter.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tbl_layoutFooter.ColumnCount = 3;
            this.tbl_layoutFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_layoutFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 375F));
            this.tbl_layoutFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_layoutFooter.Controls.Add(this.pnl_sort, 1, 0);
            this.tbl_layoutFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_layoutFooter.Location = new System.Drawing.Point(0, 0);
            this.tbl_layoutFooter.Name = "tbl_layoutFooter";
            this.tbl_layoutFooter.RowCount = 1;
            this.tbl_layoutFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_layoutFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_layoutFooter.Size = new System.Drawing.Size(1053, 48);
            this.tbl_layoutFooter.TabIndex = 0;
            // 
            // pnl_sort
            // 
            this.pnl_sort.Controls.Add(this.lbl_sortStatus);
            this.pnl_sort.Controls.Add(this.btn_next);
            this.pnl_sort.Controls.Add(this.btn_previous);
            this.pnl_sort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_sort.Location = new System.Drawing.Point(342, 3);
            this.pnl_sort.Name = "pnl_sort";
            this.pnl_sort.Size = new System.Drawing.Size(369, 42);
            this.pnl_sort.TabIndex = 0;
            // 
            // lbl_sortStatus
            // 
            this.lbl_sortStatus.AutoSize = true;
            this.lbl_sortStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_sortStatus.ForeColor = System.Drawing.Color.White;
            this.lbl_sortStatus.Location = new System.Drawing.Point(95, 12);
            this.lbl_sortStatus.Name = "lbl_sortStatus";
            this.lbl_sortStatus.Size = new System.Drawing.Size(183, 21);
            this.lbl_sortStatus.TabIndex = 0;
            this.lbl_sortStatus.Text = "Showing 1 to 40 of 105";
            this.lbl_sortStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.Yellow;
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_next.Image = ((System.Drawing.Image)(resources.GetObject("btn_next.Image")));
            this.btn_next.Location = new System.Drawing.Point(291, 4);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 33);
            this.btn_next.TabIndex = 1;
            this.btn_next.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_previous
            // 
            this.btn_previous.BackColor = System.Drawing.Color.Yellow;
            this.btn_previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_previous.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_previous.Image = ((System.Drawing.Image)(resources.GetObject("btn_previous.Image")));
            this.btn_previous.Location = new System.Drawing.Point(3, 4);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(75, 33);
            this.btn_previous.TabIndex = 2;
            this.btn_previous.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_previous.UseVisualStyleBackColor = false;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // pnl_body
            // 
            this.pnl_body.Controls.Add(this.dataGridView);
            this.pnl_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_body.Location = new System.Drawing.Point(3, 84);
            this.pnl_body.Name = "pnl_body";
            this.pnl_body.Size = new System.Drawing.Size(1053, 382);
            this.pnl_body.TabIndex = 2;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(1053, 382);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pnl_head.Controls.Add(this.btn_close);
            this.pnl_head.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_head.Location = new System.Drawing.Point(0, 0);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(1059, 53);
            this.pnl_head.TabIndex = 1;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.Color.Transparent;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(1016, 11);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(31, 30);
            this.btn_close.TabIndex = 6;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // frmView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 576);
            this.Controls.Add(this.pnl_base);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmView";
            this.Activated += new System.EventHandler(this.frmView_Activated);
            this.Load += new System.EventHandler(this.frmView_Load);
            this.pnl_base.ResumeLayout(false);
            this.pnl_baseBody.ResumeLayout(false);
            this.tbl_layoutBase.ResumeLayout(false);
            this.pnl_header.ResumeLayout(false);
            this.tbl_layoutHeader.ResumeLayout(false);
            this.pnl_title.ResumeLayout(false);
            this.pnl_title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_img)).EndInit();
            this.pnl_add.ResumeLayout(false);
            this.pnl_search.ResumeLayout(false);
            this.pnl_search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_search)).EndInit();
            this.pnl_footer.ResumeLayout(false);
            this.tbl_layoutFooter.ResumeLayout(false);
            this.pnl_sort.ResumeLayout(false);
            this.pnl_sort.PerformLayout();
            this.pnl_body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.pnl_head.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnl_base;
        private TableLayoutPanel tbl_layoutBase;
        private Panel pnl_header;
        private TableLayoutPanel tbl_layoutHeader;
        private Panel pnl_title;
        private Label lbl_title;
        private Panel pnl_add;
        private Panel pnl_search;
        private Panel pnl_footer;
        private TableLayoutPanel tbl_layoutFooter;
        private Panel pnl_sort;
        private Button btn_next;
        private Button btn_previous;
        private Label lbl_sortStatus;
        private Panel pnl_body;
        private TextBox txt_search;
        private DataGridView dataGridView;
        private PictureBox pb_img;
        private Panel pnl_head;
        private Panel pnl_baseBody;
        private Button btn_close;
        private PictureBox pb_search;
        private Button btn_add;
    }
}