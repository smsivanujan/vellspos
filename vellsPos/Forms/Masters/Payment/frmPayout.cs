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
    public partial class frmPayout : Form
    {
        private string uid;

        public frmPayout()
        {
            InitializeComponent();
        }

        private void frmPayout_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            ReturnResult amountResult = Validator.validateDecimal(ntxt_amount.Value, "SubCategory",false);

            if (!amountResult.Status)
            {
                MessageBox.Show(amountResult.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //int categoryId = 0;
                //if (cmb_category.SelectedIndex >= 0)
                //{
                //    categoryId = int.Parse(categories[cmb_category.SelectedIndex].Value);
                //}

                User user = new User();
                user.Id = 1;

                //string rootPath = @"c:\vellspos";
                //String directoryPath = Path.Combine(rootPath, Path.GetFileName(lbl_imagePath.Text));

                //ImageUpload imageUpload = new ImageUpload();
                //imageUpload.DirectoryPath = directoryPath;
                //imageUpload.RootPath = rootPath;//root folder from save
                //imageUpload.ImagePath = lbl_imagePath.Text;
                //ReturnResult resul2 = ImageUpload.store(imageUpload);

                Payout payout = new Payout();
                payout.Date = dpt_date.Value;
                payout.Amount = ntxt_amount.Value;
                payout.Description= rtxt_description.Text;
                payout.User = user;//root folder to save
                ReturnResult result = Payout.store(payout);


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
                    MessageBox.Show("Payout has been added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
