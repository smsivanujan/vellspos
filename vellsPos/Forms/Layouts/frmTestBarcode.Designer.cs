namespace vellsPos.Forms.Layouts
{
    partial class frmTestBarcode
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
            this.pb_barcode = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_encode = new System.Windows.Forms.TextBox();
            this.btn_encode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_barcode)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_barcode
            // 
            this.pb_barcode.Location = new System.Drawing.Point(12, 12);
            this.pb_barcode.Name = "pb_barcode";
            this.pb_barcode.Size = new System.Drawing.Size(369, 187);
            this.pb_barcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_barcode.TabIndex = 0;
            this.pb_barcode.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Encode";
            // 
            // txt_encode
            // 
            this.txt_encode.Location = new System.Drawing.Point(64, 214);
            this.txt_encode.Name = "txt_encode";
            this.txt_encode.Size = new System.Drawing.Size(236, 23);
            this.txt_encode.TabIndex = 2;
            this.txt_encode.TextChanged += new System.EventHandler(this.txt_encode_TextChanged);
            // 
            // btn_encode
            // 
            this.btn_encode.Location = new System.Drawing.Point(306, 213);
            this.btn_encode.Name = "btn_encode";
            this.btn_encode.Size = new System.Drawing.Size(75, 23);
            this.btn_encode.TabIndex = 3;
            this.btn_encode.Text = "encode";
            this.btn_encode.UseVisualStyleBackColor = true;
            this.btn_encode.Click += new System.EventHandler(this.btn_encode_Click);
            // 
            // frmTestBarcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 254);
            this.Controls.Add(this.btn_encode);
            this.Controls.Add(this.txt_encode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_barcode);
            this.Name = "frmTestBarcode";
            this.Text = "frmTestBarcode";
            ((System.ComponentModel.ISupportInitialize)(this.pb_barcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pb_barcode;
        private Label label1;
        private TextBox txt_encode;
        private Button btn_encode;
    }
}