using Google.Protobuf.WellKnownTypes;
using Microsoft.VisualBasic.ApplicationServices;
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
        ReturnResult result;
        String msgStatus;
        String directoryPath="";
        string rootPath = @"c:\vellspos";

        private FormMovable formMove;

        public frmProductBarcode()
        {
            InitializeComponent();

            formMove = new FormMovable(this);
            formMove.SetMovable(pnl_head, lbl_title);
        }
        private void frmProductBarcode_Load(object sender, EventArgs e)
        {
            txt_imagePath.Visible = false;
            lbl_imageStatus.Visible = false;

            if (this.Tag is null)
            {
                //
            }
            else
            {
                uid = this.Tag.ToString();
                fillData();
            }
        }

        private void fillData()
        {
            ProductBarcode productBarcode = ProductBarcode.getOneProductBarcode(Int32.Parse(uid));
            txt_id.Text = uid;
            txt_productID.Text = Convert.ToString(productBarcode.Product.Id);
            txt_product.Text = productBarcode.Product.ProductName;
            txt_productNumber.Text = productBarcode.Product.ProductNumber;
            cmb_barcodeType.Text = productBarcode.BarcodeType;
            ntxt_height.Value = productBarcode.BarcodeHeight;
            txt_imagePath.Text = productBarcode.BarcodeImage;
            lbl_pbStatus.Text = "1";

            if (!String.IsNullOrEmpty(txt_imagePath.Text))
            {
                pb_barcodeImage.Image = Image.FromFile(productBarcode.BarcodeImage);
            }
        }

        //private void save()
        //{
           
        //}
        //private void update()
        //{
        //    ReturnResult nameResult = Validator.validateText(rtxt_description.Text, "Discount");

        //    if (!nameResult.Status)
        //    {
        //        MessageBox.Show(nameResult.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    else
        //    {
        //        Complain complain = new Complain();
        //        complain.Id = Int32.Parse(this.Tag.ToString());
        //        Console.WriteLine(Int32.Parse(this.Tag.ToString()));
        //        complain.Date = dtp_date.Value.ToString("yyyy-MM-dd H:mm");
        //        complain.Type = cmb_type.Text;
        //        complain.Priority = cmb_priority.Text;
        //        complain.Description = rtxt_description.Text;
        //        complain.Status = 1;
        //        User user = new User();
        //        user.Id = 1;

        //        complain.User = user;

        //        ReturnResult result = Complain.update(complain);

        //        if (result.Status)
        //        {
        //            //ActivityLog aL = new ActivityLog();
        //            //aL.Date = DateTime.Now;
        //            //User user = new User();
        //            //String query = "SELECT id from user WHERE name = '" + Session.uname + "'";
        //            //String id = DBTransactionService.getScalerData(query);
        //            //user.Id = Int32.Parse(id);
        //            //aL.User = user;
        //            //aL.Description = "One New Transaction Added.[Date : " + dtp_dateFrom.Value + "Employee : " + txtname.Text + "Transaction Category : " + txttransaction.Text + "Invoice No : " + txtInvoiceNo.Text + "Amount : " + txtamount.Text + " Description :" + txtdescrib.Text + " Added by :" + Session.uname + "]";
        //            //ActivityLog.store(aL);
        //            MessageBox.Show("Complain has been Updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            this.Close();
        //        }
        //        else
        //        {
        //            MessageBox.Show(result.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //        //}
        //    }
        //}

        private void btn_save_Click(object sender, EventArgs e)
        {
            ReturnResult numberResult = Validator.validateText(txt_productNumber.Text, "ProductNumber");

            if (!numberResult.Status)
            {
                MessageBox.Show(numberResult.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                Product product = new Product();
                product.Id = Convert.ToInt32(txt_productID.Text);

                
                ProductBarcode productBarcode = new ProductBarcode();
                productBarcode.Product = product;
                productBarcode.BarcodeNumber = txt_productNumber.Text;
                productBarcode.BarcodeType = cmb_barcodeType.Text;
                productBarcode.BarcodeHeight = ntxt_height.Value;

                if (lbl_pbStatus.Text!="0")
                {
                    
                    string fileName = txt_productNumber.Text + ".jpg";
                    directoryPath = Path.Combine(rootPath, Path.GetFileName(fileName));
                    ImageUpload imageUpload = new ImageUpload();
                    imageUpload.DirectoryPath = directoryPath;
                    imageUpload.RootPath = rootPath;//root folder from save
                    imageUpload.ImagePath = txt_imagePath.Text;
                    ReturnResult resul2 = ImageUpload.store(imageUpload);

                    pb_barcodeImage.Image.Save(directoryPath, ImageFormat.Jpeg);
                }

                productBarcode.BarcodeImage = directoryPath;//root folder to save

                if (this.Tag is null)
                {
                    //save();
                    result = ProductBarcode.store(productBarcode);
                    msgStatus = "added";

                }
                else
                {
                    //update();
                    productBarcode.Id = Int32.Parse(this.Tag.ToString());
                    result = ProductBarcode.update(productBarcode);
                    msgStatus = "updated";
                }


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
                    MessageBox.Show("Product Barcode has been "+ msgStatus +" successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            lbl_pbStatus.Text = "1";
        }
        
        private void txt_product_Click(object sender, EventArgs e)
        {
            Product.showOnViewFormProductWithoutBarcode(txt_product, txt_productID);
        }

        private void txt_productID_TextChanged(object sender, EventArgs e)
        {
            String productCodeQuery = "SELECT product_number  FROM products WHERE id='"+txt_productID.Text+"' ";
            String productCode = DBTransactionService.getScalerData(productCodeQuery);

            txt_productNumber.Text = productCode;
        }
    }
}
