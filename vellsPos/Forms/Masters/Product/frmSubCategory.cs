using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class frmSubCategory : Form
    {
        private List<ListItem> categories = new List<ListItem>();
        private string uid;
        ReturnResult result;
        String msgStatus;
        String directoryPath="";
        string rootPath = @"c:\vellspos";

        public frmSubCategory()
        {
            InitializeComponent();
        }

        private void frmSubCategory_Load(object sender, EventArgs e)
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
            //String categoryQuery = "SELECT id as value,category_name as text FROM categories";
            //categories = DBTransactionService.getDataAsListItemsAndFillComboBox(categoryQuery, cmb_category);

            //if (categories.Count > 0)
            //{
            //    cmb_category.SelectedIndex = 0;
            //}

            SubCategory subCategory = SubCategory.getOneSubCategory(Int32.Parse(uid));
            txt_id.Text = uid;
            cmb_category.Text = subCategory.Category.CategoryName;
            txt_subCategory.Text = subCategory.SubCategoryName;
            rtxt_description.Text = subCategory.Description;
            txt_imagePath.Text = subCategory.Image;

            if (!String.IsNullOrEmpty(txt_imagePath.Text))
            {
                pb_subCategoryImage.Image = Image.FromFile(subCategory.Image);
            }
        }

        //private void save()
        //{
            
        //}

        //private void update()
        //{
        //    ReturnResult nameResult = Validator.validateText(txt_subCategory.Text, "SubCategory");

        //    if (!nameResult.Status)
        //    {
        //        MessageBox.Show(nameResult.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    else
        //    {
        //        int categoryId = 0;
        //        if (cmb_category.SelectedIndex >= 0)
        //        {
        //            categoryId = int.Parse(categories[cmb_category.SelectedIndex].Value);
        //        }

        //        Category category = new Category();
        //        category.Id = categoryId;

        //        string rootPath = @"c:\vellspos";
        //        String directoryPath = Path.Combine(rootPath, Path.GetFileName(lbl_imagePath.Text));

        //        ImageUpload imageUpload = new ImageUpload();
        //        imageUpload.DirectoryPath = directoryPath;
        //        imageUpload.RootPath = rootPath;//root folder from save
        //        imageUpload.ImagePath = lbl_imagePath.Text;
        //        ReturnResult resul2 = ImageUpload.store(imageUpload);

        //        SubCategory subCategory = new SubCategory();
        //        subCategory.SubCategoryName = txt_subCategory.Text;
        //        subCategory.Category = category;
        //        subCategory.Description = rtxt_description.Text;
        //        subCategory.Image = directoryPath;//root folder to save
        //        ReturnResult result = SubCategory.store(subCategory);


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
        //            MessageBox.Show("Sub Category has been added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            ReturnResult nameResult = Validator.validateText(txt_subCategory.Text, "SubCategory");

            if (!nameResult.Status)
            {
                MessageBox.Show(nameResult.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               

                int categoryId = 0;
                if (cmb_category.SelectedIndex >= 0)
                {
                    categoryId = int.Parse(categories[cmb_category.SelectedIndex].Value);
                }

                Category category = new Category();
                category.Id = categoryId;

                SubCategory subCategory = new SubCategory();
                subCategory.SubCategoryName = txt_subCategory.Text;
                subCategory.Category = category;
                subCategory.Description = rtxt_description.Text;

                if (!String.IsNullOrEmpty(txt_imagePath.Text))
                {
                    directoryPath = Path.Combine(rootPath, Path.GetFileName(txt_imagePath.Text));
                    ImageUpload imageUpload = new ImageUpload();
                    imageUpload.DirectoryPath = directoryPath;
                    imageUpload.RootPath = rootPath;//root folder from save
                    imageUpload.ImagePath = txt_imagePath.Text;
                    ReturnResult resul2 = ImageUpload.store(imageUpload);
                }

                subCategory.Image = directoryPath;//root folder to save

                if (this.Tag is null)
                {
                    //save();
                    result = SubCategory.store(subCategory);
                    msgStatus = "added";

                }
                else
                {
                    //update();
                    subCategory.Id = Int32.Parse(this.Tag.ToString());
                    result = SubCategory.update(subCategory);
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
                    MessageBox.Show("Sub Category has been "+ msgStatus +" successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button1_Click(object sender, EventArgs e)
        {
            //frmProductCreate p = new frmProductCreate() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            //this.pnl_container.Controls.Add(p);
            //p.Show();
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
                pb_subCategoryImage.Load(ofd.FileName);
                lbl_imageStatus.Text = "Image Uploded";
                lbl_imageStatus.ForeColor = System.Drawing.Color.Green;
            }
        }
    }
}
