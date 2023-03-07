using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using System.Xml.Linq;
using vellsPos.Entities.Layouts;
using vellsPos.Entities.Masters;
using vellsPos.Services;

namespace vellsPos.Forms.Layouts
{
    public partial class frmDiscountProduct : Form
    {
        private List<ListItem> discounts = new List<ListItem>();
        private List<ListItem> products = new List<ListItem>();
        private string uid;
        ReturnResult result;
        String msgStatus;

        private FormMovable formMove;

        public frmDiscountProduct()
        {
            InitializeComponent();

            formMove = new FormMovable(this);
            formMove.SetMovable(pnl_head, lbl_title);
        }

        private void frmDiscount_Load(object sender, EventArgs e)
        {
            String discountQuery = "SELECT id as value,discount_name as text FROM discounts";
            discounts = DBTransactionService.getDataAsListItemsAndFillComboBox(discountQuery, cmb_discount);

            if (discounts.Count > 0)
            {
                cmb_discount.SelectedIndex = 0;
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
            Discount discount = Discount.getOneDiscount(Int32.Parse(uid));
            txt_id.Text = uid;
            //txt_discountName.Text = discount.DiscountName;
            //dtp_dateFrom.Text = discount.DateFrom;
            //dtp_dateTo.Text = discount.DateTo;
            
            //if(discount.Status==1)
            //{
            //    cb_status.Checked=true;
            //}
            //else
            //{
            //    cb_status.Checked = false;
            //}
            //rtxt_description.Text = discount.Description;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            ReturnResult nameResult = Validator.validateText(cmb_discount.Text, "Discount");

            if (!nameResult.Status)
            {
                MessageBox.Show(nameResult.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Discount discount = new Discount();
                //discount.DiscountName = txt_discountName.Text;
                //discount.DateFrom = dtp_dateFrom.Value.ToString("yyyy-MM-dd H:mm");
                //discount.DateTo = dtp_dateTo.Value.ToString("yyyy-MM-dd H:mm");
                //discount.Description = rtxt_description.Text;

                //discount.Status = 0;
                //if (cb_status.Checked)
                //{
                //    discount.Status = 1;
                //}

                User user = new User();
                user.Id = 1;

                discount.User = user;

                if (this.Tag is null)
                {
                    //save();
                    result = Discount.store(discount);
                    msgStatus = "added";
                   
                }
                else
                {
                    //update();
                    discount.Id = Int32.Parse(uid);
                    result = Discount.update(discount);
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
                    MessageBox.Show("Discount has been " + msgStatus + " successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void cmb_discount_SelectedIndexChanged(object sender, EventArgs e)
        {
            String pId;
            String pName;
            int pointX1 = 35;
            int pointY1 = 50;
            //gb_category.Controls.Clear();

            String productQuery = "SELECT id as value,product_name as text FROM products ";
            products = DBTransactionService.getDataAsListItems(productQuery);

            foreach (ListItem catList in products)
            {
                pId = catList.Value;
                pName = catList.Text;

                CheckBox cbProduct = new CheckBox();
                cbProduct.Text = pName.ToString();
                cbProduct.Tag = pId;
                cbProduct.BackColor = Color.LightPink;
                cbProduct.Size = new System.Drawing.Size(196, 38);
                cbProduct.ForeColor = Color.Black;
                //btnCategory.Font = new Font(btnCategory.Font.FontFamily,18);
                cbProduct.Location = new Point(pointX1, pointY1);
                clb_products.Controls.Add(cbProduct);
                clb_products.Show();
                pointY1 += 45;
                //btnCategory.Click += BtnCategory_Click;
            }
        }
    }
}
