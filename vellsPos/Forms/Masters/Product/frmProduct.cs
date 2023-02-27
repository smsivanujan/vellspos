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
        private List<ListItem> categories = new List<ListItem>();
        private List<ListItem> subCategories = new List<ListItem>();
        private List<ListItem> subCoCategories = new List<ListItem>();
        private string uid;
        ReturnResult result;
        String msgStatus;
        String directoryPath="";
        string rootPath = @"c:\vellspos";

        private FormMovable formMove;

        public frmProduct()
        {
            InitializeComponent();

            formMove = new FormMovable(this);
            formMove.SetMovable(pnl_head, lbl_title);
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            txt_imagePath.Visible = false;
            lbl_imageStatus.Visible = false;

            String categoryQuery = "SELECT id as value,category_name as text FROM categories";
            categories = DBTransactionService.getDataAsListItemsAndFillComboBox(categoryQuery, cmb_category);

            if (categories.Count > 0)
            {
                cmb_category.SelectedIndex = 0;
            }

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
            Product product = Product.getOneProduct(Int32.Parse(uid));
            txt_id.Text = uid;
            txt_productNumber.Text = product.ProductNumber;
            txt_productName.Text = product.ProductName;
            cmb_subCoCategory.Text = product.SubCoCategory.SubCoCategoryName;
            ntxt_salePrice.Value = product.SalePrice;
            dtp_date.Text = product.AddedDate;
            rtxt_description.Text = product.Description;       

            if (product.AgeVerify==1)
            {
                cb_ageVerify.Checked=true;
            }
            else
            {
                cb_ageVerify.Checked = false;
            }

            if (product.IsBarcode == 1)
            {
                cb_barcode.Checked = true;
            }
            else
            {
                cb_barcode.Checked = false;
            }

            if (product.Status == 1)
            {
                cb_active.Checked = true;
            }
            else
            {
                cb_active.Checked = false;
            }

            txt_imagePath.Text = product.Image;

            if (!String.IsNullOrEmpty(txt_imagePath.Text))
            {
                pb_productImage.Image = Image.FromFile(product.Image);
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

                int categoryId = 0; int subCategoryId = 0;  int subCocategoryId = 0;

                if (cmb_category.SelectedIndex >= 0)
                {
                    categoryId = int.Parse(categories[cmb_subCoCategory.SelectedIndex].Value);
                }

                if (cmb_subCategory.SelectedIndex >= 0)
                {
                    subCategoryId = int.Parse(subCategories[cmb_subCategory.SelectedIndex].Value);
                }

                if (cmb_subCoCategory.SelectedIndex >= 0)
                {
                    subCocategoryId = int.Parse(subCoCategories[cmb_subCoCategory.SelectedIndex].Value);
                }

                SubCoCategory subCoCategory = new SubCoCategory();
                subCoCategory.Id = subCocategoryId;

                User user = new User();
                user.Id = 1;

                Product product = new Product();
                product.ProductNumber = txt_productNumber.Text;
                product.ProductName = txt_productName.Text;
                product.SubCoCategory = subCoCategory;
                product.SalePrice = ntxt_salePrice.Value;
                product.AddedDate = dtp_date.Value.ToString("yyyy-MM-dd H:mm");
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

                if (cb_active.Checked)
                {
                    product.Status = 1;
                }
                else
                {
                    product.Status = 0;
                }

                product.Temp = 0;
                product.User = user;

                if (!String.IsNullOrEmpty(txt_imagePath.Text))
                {
                    directoryPath = Path.Combine(rootPath, Path.GetFileName(txt_imagePath.Text));
                    ImageUpload imageUpload = new ImageUpload();
                    imageUpload.DirectoryPath = directoryPath;
                    imageUpload.RootPath = rootPath;//root folder from save
                    imageUpload.ImagePath = txt_imagePath.Text;
                    ReturnResult resul2 = ImageUpload.store(imageUpload);
                }

                product.Image = directoryPath;//root folder to save
                
                if (this.Tag is null)
                {
                    //save();
                    result = Product.store(product);
                    msgStatus = "added";

                }
                else
                {
                    //update();
                    product.Id = Int32.Parse(this.Tag.ToString());
                    result = Product.update(product);
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
                    MessageBox.Show("Product has been "+ msgStatus +" successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                txt_imagePath.Visible = true;
                lbl_imageStatus.Visible = true;

                txt_imagePath.Text = ofd.FileName;
                pb_productImage.Load(ofd.FileName);
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

        private void cmb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            String categoryID = "Select id from categories where category_name='" + cmb_category.Text + "' ";
            String cid = DBTransactionService.getScalerData(categoryID);

            String subCategoryQuery = "SELECT sc.id as value, sc.sub_category_name as text" +
                " FROM sub_categories sc" +
                " LEFT JOIN categories c ON sc.category_id = c.id " +
                " WHERE sc.category_id = '" + cid + "' ";
            subCategories = DBTransactionService.getDataAsListItemsAndFillComboBox(subCategoryQuery, cmb_subCategory);
            if (subCategories.Count > 0)
            {
                cmb_subCategory.SelectedIndex = 0;
            }
        }

        private void cmb_subCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            String subCategoryID = "Select id from sub_categories where sub_category_name='" + cmb_subCategory.Text + "' ";
            String subCid = DBTransactionService.getScalerData(subCategoryID);

            String subCoCategoryQuery = "SELECT scc.id as value, scc.sub_co_category_name as text" +
                " FROM sub_co_categories scc" +
                " LEFT JOIN categories c ON scc.sub_category_id = c.id " +
                " WHERE scc.sub_category_id = '" + subCid + "' ";
            subCategories = DBTransactionService.getDataAsListItemsAndFillComboBox(subCoCategoryQuery, cmb_subCoCategory);
            if (subCategories.Count > 0)
            {
                cmb_subCoCategory.SelectedIndex = 0;
            }
        }
    }
}
