using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vellsPos.Entities.Layouts;
using vellsPos.Entities.Masters;
using vellsPos.Services;

namespace vellsPos.Forms.Layouts
{
    public partial class frmProduct : Form
    {
        private List<ListItem> subCoCategories = new List<ListItem>();
        private string uid;

        public frmProduct()
        {
            InitializeComponent();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            String subCoCategoryQuery = "SELECT id as value,sub_co_category_name as text FROM sub_co_categories";
            subCoCategories = DBTransactionService.getDataAsListItemsAndFillComboBox(subCoCategoryQuery, cmb_subCoCategory);

            if (subCoCategories.Count > 0)
            {
                cmb_subCoCategory.SelectedIndex = 0;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            ReturnResult numberResult = Validator.validateText(txt_productNumber.Text, "ProductNumber");
            ReturnResult nameResult = Validator.validateText(txt_productName.Text, "ProductName");
           

            if (!numberResult.Status)
            {
                MessageBox.Show(numberResult.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (!nameResult.Status)
            {
                MessageBox.Show(nameResult.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int subCoategoryId = 0;
               
                if (cmb_subCoCategory.SelectedIndex >= 0)
                {
                    subCoategoryId = int.Parse(subCoCategories[cmb_subCoCategory.SelectedIndex].Value);
                }

                SubCoCategory subCoCategory = new SubCoCategory();
                subCoCategory.Id = subCoategoryId;

                User user = new User();
                user.Id = 1;


                string rootPath = @"c:\vellspos";
                String directoryPath = Path.Combine(rootPath, Path.GetFileName(lbl_imagePath.Text));

                ImageUpload imageUpload = new ImageUpload();
                imageUpload.DirectoryPath = directoryPath;
                imageUpload.RootPath = rootPath;//root folder from save
                imageUpload.ImagePath = lbl_imagePath.Text;
                ReturnResult resul2 = ImageUpload.store(imageUpload);

                Product product = new Product();
                product.AddedDate = dtp_date.Value;
                product.ProductNumber = txt_productNumber.Text;
                product.ProductName = txt_productName.Text;
                product.SalePrice = ntxt_salePrice.Value;
                product.SubCoCategory = subCoCategory;
                product.Description = rtxt_description.Text;

                if (cb_barcode.Checked)
                {
                    product.IsBarcode = 1;
                }
                else
                {
                    product.IsBarcode = 0;
                }

                if (cb_ageVerify.Checked)
                {
                    product.AgeVerify = 1;
                }
                else
                {
                    product.AgeVerify = 0;
                }
                product.Temp = 0;
                product.Image = directoryPath;//root folder to save
                product.User = user;
                ReturnResult result = Product.store(product);


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
                    MessageBox.Show("Product has been added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(result.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //}
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

        private void btn_uploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Image file..";
            ofd.DefaultExt = ".jpg";
            ofd.Filter = "Media Files|*.jpg;*.png;*.gif;*.bmp;*.jpeg|All Files|*.*";
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                lbl_imagePath.Text = ofd.FileName;
                pb_categoryImage.Load(ofd.FileName);
                lbl_imageStatus.Text = "Image Uploded";
                lbl_imageStatus.ForeColor = System.Drawing.Color.Green;
            }
        }

        private void txt_productNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsNumber(ch) && !char.IsLetter(ch) && ch != 8 && ch != 46)  //8 is Backspace key; 46 is Delete key. This statement accepts dot key. 
            //if (!char.IsLetterOrDigit(ch) && !char.IsLetter(ch) && ch != 8 && ch != 46)   //This statement accepts dot key. 
            {
                e.Handled = true;
                MessageBox.Show("Only accept digital character or letter.");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //frmProductCreate p = new frmProductCreate() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            //this.pnl_container.Controls.Add(p);
            //p.Show();
        }

        private void ntxt_saleprice_ValueChanged(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
