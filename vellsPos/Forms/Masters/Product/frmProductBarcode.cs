using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vellsPos.Entities.Layouts;
using vellsPos.Entities.Masters;
using vellsPos.Services;
using Zen.Barcode;

namespace vellsPos.Forms.Layouts
{
    public partial class frmProductBarcode : Form
    {
        private List<ListItem> discounts = new List<ListItem>();
        private string uid;

        public frmProductBarcode()
        {
            InitializeComponent();
        }
        private void frmProductBarcode_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            ReturnResult numberResult = Validator.validateText(txt_productNumber.Text, "ProductNumber");
            //ReturnResult nameResult = Validator.validateText(txt_productName.Text, "ProductName");


            if (!numberResult.Status)
            {
                MessageBox.Show(numberResult.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //if (!nameResult.Status)
            //{
            //    MessageBox.Show(nameResult.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            else
            {
                Product product = new Product();
                product.Id = Convert.ToInt32(txt_productID.Text);

                string fileName = txt_productNumber.Text + ".jpg";
                string rootPath = @"c:\vellspos";
                String directoryPath = Path.Combine(rootPath, Path.GetFileName(fileName));

                ImageUpload imageUpload = new ImageUpload();
                imageUpload.DirectoryPath = directoryPath;
                imageUpload.RootPath = rootPath;//root folder from save
                imageUpload.ImagePath = lbl_imagePath.Text;
                ReturnResult resul2 = ImageUpload.store(imageUpload);

                pb_barcodeImage.Image.Save(directoryPath, ImageFormat.Jpeg);
                ProductBarcode productBarcode = new ProductBarcode();
                productBarcode.Product = product;
                productBarcode.BarcodeNumber = txt_productNumber.Text;
                productBarcode.BarcodeType = cmb_barcodeType.Text;
                productBarcode.BarcodeHeight = ntxt_height.Value;
                productBarcode.BarcodeImage= directoryPath;//root folder to save
                ReturnResult result = ProductBarcode.store(productBarcode);


                if (result.Status)
                {
                    //ActivityLog aL = new ActivityLog();
                    //aL.Date = DateTime.Now;
                    //User user = new User();
                    //String query = "SELECT id from user WHERE name = '" + Session.uname + "'";
                    //String id = DBTransactionService.getScalerData(query);
                    //user.Id = Int32.Parse(id);
                    //aL.User = user;
                    //aL.Description = "One New Transaction Added.[Date : " + dtp_dateFrom.Value + "Employee : " + txtname.Text + "Transaction Category : " + txttransaction.Text + "Invoice No : " + txtInvoiceNo.Text + "Amount : " + txtamount.Text + " Description :" + txtdescrib.Text + " Added by :" + Session.uname + "]";
                    //ActivityLog.store(aL);
                    MessageBox.Show("Product Barcode has been added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(result.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //frmProductCreate p = new frmProductCreate() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            //this.pnl_container.Controls.Add(p);
            //p.Show();
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            //pb_barcodeImage.Image = barcode.Draw(txt_productCode.Text, Convert.ToInt32(ntxt_height.Value));
            Zen.Barcode.CodeEan13BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.CodeEan13WithChecksum;
            pb_barcodeImage.Image = barcode.Draw(txt_productNumber.Text, Convert.ToInt32(ntxt_height.Value));
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            
        }
        
        private void txt_product_Click(object sender, EventArgs e)
        {
            String isBarcode = "1";
            Product.showOnViewFormProductWithoutBarcode(txt_product, txt_productID, isBarcode);
        }

        private void txt_productID_TextChanged(object sender, EventArgs e)
        {
            String productCodeQuery = "SELECT product_number  FROM products WHERE id='"+txt_productID.Text+"' ";
            String productCode = DBTransactionService.getScalerData(productCodeQuery);

            txt_productNumber.Text = productCode;
        }
    }
}
