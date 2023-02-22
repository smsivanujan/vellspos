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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace vellsPos.Forms.Layouts
{
    public partial class frmSubCoCategory : Form
    {
        private List<ListItem> categories = new List<ListItem>();
        private List<ListItem> subCategories = new List<ListItem>();
        private string uid;

        public frmSubCoCategory()
        {
            InitializeComponent();
        }

        private void frmSubCoCategory_Load(object sender, EventArgs e)
        {
            String categoryQuery = "SELECT id as value,category_name as text FROM categories";
            categories = DBTransactionService.getDataAsListItemsAndFillComboBox(categoryQuery, cmb_category);

            if (categories.Count > 0)
            {
                cmb_category.SelectedIndex = 0;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            ReturnResult nameResult = Validator.validateText(txt_subCoCategory.Text, "SubCOCategory");

            if (!nameResult.Status)
            {
                MessageBox.Show(nameResult.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int categoryId = 0; int subCategoryId = 0;
                if (cmb_category.SelectedIndex >= 0)
                {
                    categoryId = int.Parse(categories[cmb_category.SelectedIndex].Value);
                }

                if (cmb_subCategory.SelectedIndex >= 0)
                {
                    subCategoryId = int.Parse(subCategories[cmb_subCategory.SelectedIndex].Value);
                }

                //Category category = new Category();
                //category.Id = categoryId;

                SubCategory subCategory = new SubCategory();
                subCategory.Id = subCategoryId;

                string rootPath = @"c:\vellspos";
                String directoryPath = Path.Combine(rootPath, Path.GetFileName(lbl_imagePath.Text));

                ImageUpload imageUpload = new ImageUpload();
                imageUpload.DirectoryPath = directoryPath;
                imageUpload.RootPath = rootPath;//root folder from save
                imageUpload.ImagePath = lbl_imagePath.Text;
                ReturnResult resul2 = ImageUpload.store(imageUpload);

                SubCoCategory subCoCategory = new SubCoCategory();
                subCoCategory.SubCoCategoryName = txt_subCoCategory.Text;
                subCoCategory.SubCategory = subCategory;
                subCoCategory.Description = rtxt_description.Text;
                subCoCategory.Image = directoryPath;//root folder to save
                ReturnResult result = SubCoCategory.store(subCoCategory);


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
                    MessageBox.Show("Sub Co Category has been added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                lbl_imagePath.Text = ofd.FileName;
                pb_subCoCategoryImage.Load(ofd.FileName);
                lbl_imageStatus.Text = "Image Uploded";
                lbl_imageStatus.ForeColor = System.Drawing.Color.Green;
            }
        }

        private void cmb_category_SelectedIndexChanged(object sender, EventArgs e)
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
            //else
            //{
            //    comboBox4.Items.Add("None");
            //    comboBox4.SelectedIndex = comboBox4.Items.Count - 1;
            //}
        }
    }
}
