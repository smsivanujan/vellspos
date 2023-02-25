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
    public partial class frmCategory : Form
    {
        private string uid;
        ReturnResult result;
        String msgStatus;
        String directoryPath="";
        string rootPath = @"c:\vellspos";

        public frmCategory()
        {
            InitializeComponent();
        }

        private void frmCategory_Load(object sender, EventArgs e)
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
            Category category = Category.getOneCategory(Int32.Parse(uid));
            txt_id.Text = uid;
            txt_category.Text = category.CategoryName;
            rtxt_description.Text = category.Description;
            txt_imagePath.Text = category.Image;

            if (!String.IsNullOrEmpty(txt_imagePath.Text))
            {
                pb_categoryImage.Image = Image.FromFile(category.Image);
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
            ReturnResult nameResult = Validator.validateText(txt_category.Text, "Category");

            if (!nameResult.Status)
            {
                MessageBox.Show(nameResult.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Category category = new Category();
                category.CategoryName = txt_category.Text;
                category.Description = rtxt_description.Text;
                

                if (!String.IsNullOrEmpty(txt_imagePath.Text))
                {
                    directoryPath = Path.Combine(rootPath, Path.GetFileName(txt_imagePath.Text));
                    ImageUpload imageUpload = new ImageUpload();
                    imageUpload.DirectoryPath = directoryPath;
                    imageUpload.RootPath = rootPath;//root folder from save
                    imageUpload.ImagePath = txt_imagePath.Text;
                    ReturnResult resul2 = ImageUpload.store(imageUpload);
                }

                category.Image = directoryPath;//root folder to save
                if (this.Tag is null)
                {
                    //save();
                    result = Category.store(category);
                    msgStatus = "added";

                }
                else
                {
                    //update();
                    category.Id = Int32.Parse(this.Tag.ToString());
                    result = Category.update(category);
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
                    MessageBox.Show("Category has been "+ msgStatus +" successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                pb_categoryImage.Load(ofd.FileName);
                lbl_imageStatus.Text = "Image Uploded";
                lbl_imageStatus.ForeColor = System.Drawing.Color.Green;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string rootPath = @"c:\vellspos";
            String directoryPath = Path.Combine(rootPath, Path.GetFileName(txt_imagePath.Text));
            Console.WriteLine(directoryPath);
        }
    }
}
