using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.Xml.Linq;
using vellsPos.Services;
using Microsoft.VisualBasic;
using vellsPos.Entities.Masters;
using System.Transactions;

namespace vellsPos.Forms.Layouts
{
    public partial class frmReturn : Form
    {
        private string uid;
        ReturnResult result;
        String msgStatus;

        public frmReturn()
        {
            InitializeComponent();
        }

        private void frmReturn_Load(object sender, EventArgs e)
        {
            uid = this.Tag.ToString();
            if (String.IsNullOrEmpty(uid))
            {
                //
            }
            else
            {
                fillData();
            }
        }

        private void search()
        {
            String saleIdCountSQL = "SELECT count(id) FROM sales " +
                "WHERE invoice_number='" + txt_invoiceNumber.Text + "' ";//AND date='" + dtp_date.Value.ToString("yyyy-MM-dd") + "'
            String saleCountId = DBTransactionService.getScalerData(saleIdCountSQL);

            if (saleCountId.Equals("0"))
            {
                txt_invoiceNumber.Text = "[ Select ]";
                txt_saleID.Text = "";
            }
            else
            {
                String saleIdSQL = "SELECT id FROM sales  WHERE invoice_number='" + txt_invoiceNumber.Text + "' ";
                String saleId = DBTransactionService.getScalerData(saleIdSQL);

                String dateSQL = "SELECT date_format(date,'%Y-%m-%d') FROM sales WHERE id='" + saleId + "' ";
                String date = DBTransactionService.getScalerData(dateSQL);

                txt_saleID.Text = saleId;
                //txt_invoiceNumber.Text = invoice;
                txt_date.Text = date;
            }
        }

        private void fill()
        {
            try
            {
                if (String.IsNullOrEmpty(txt_saleID.Text))
                {
                    //
                }
                else
                {
                    int saletID = Int32.Parse(txt_saleID.Text);
                    int productID = Int32.Parse(txt_productID.Text);
                    SalesDetail salesDetail = SalesDetail.getOneSaleDetail(saletID, productID);
                    ntxt_qty.Value = salesDetail.Qty;
                    ntxt_amount.Value = salesDetail.Amount;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void fillData()
        {
            ProductReturn productReturn = ProductReturn.getOneProductReturn(Int32.Parse(uid));
            txt_id.Text = uid;

            txt_invoiceNumber.Text = productReturn.Sale.InvoiceNumber;
            txt_date.Text = productReturn.Sale.Date;
            txt_product.Text = productReturn.Product.ProductName;
            ntxt_amount.Value = productReturn.Amount;
            ntxt_qty.Value = productReturn.Qty;
        }

        //private void save()
        //{
            
        //}

        //private void update()
        //{
        //    ReturnResult invoiceNumberResult = Validator.validateText(txt_invoiceNumber.Text, "Invoice Number");
        //    ReturnResult productResult = Validator.validateText(txt_product.Text, "Product");
        //    ReturnResult AmountResult = Validator.validateDecimal(Decimal.Parse(ntxt_amount.Text), "Amount", false);

        //    if (!invoiceNumberResult.Status)
        //    {
        //        MessageBox.Show(invoiceNumberResult.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    else if (!productResult.Status)
        //    {
        //        MessageBox.Show(productResult.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    else if (!AmountResult.Status)
        //    {
        //        MessageBox.Show(AmountResult.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    else
        //    {

        //        if (String.IsNullOrEmpty(txt_saleID.Text))
        //        {
        //            MessageBox.Show("Select Sale", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        }
        //        else if (txt_invoiceNumber.Text != "[ Select ]")
        //        {

        //            Sale sale = new Sale();
        //            sale.Id = Convert.ToInt32(txt_saleID.Text);
        //            Product product = new Product();
        //            product.Id = Convert.ToInt32(txt_productID.Text);
        //            User user = new User();
        //            user.Id = 1;

        //            ProductReturn productReturn = new ProductReturn();
        //            productReturn.Sale = sale;
        //            productReturn.Product = product;
        //            productReturn.Qty = Convert.ToInt32(ntxt_qty.Value);
        //            productReturn.Amount = ntxt_amount.Value;
        //            productReturn.User = user;
        //            ReturnResult result = ProductReturn.store(productReturn);


        //            if (result.Status)
        //            {
        //                //ActivityLog aL = new ActivityLog();
        //                //aL.Date = DateTime.Now;
        //                //User user = new User();
        //                //String query = "SELECT id from user WHERE name = '" + Session.uname + "'";
        //                //String id = DBTransactionService.getScalerData(query);
        //                //user.Id = Int32.Parse(id);
        //                //aL.User = user;
        //                //aL.Description = "One New Transaction Added.[Date : " + dateTimePicker1.Value + "Employee : " + txtname.Text + "Transaction Category : " + txttransaction.Text + "Invoice No : " + txtInvoiceNo.Text + "Amount : " + txtamount.Text + " Description :" + txtdescrib.Text + " Added by :" + Session.uname + "]";
        //                //ActivityLog.store(aL);
        //                MessageBox.Show("Product Return has been updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                this.Close();
        //            }
        //            else
        //            {
        //                MessageBox.Show(result.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }
        //    }
        //}
        
        private void btn_save_Click(object sender, EventArgs e)
        {
            ReturnResult invoiceNumberResult = Validator.validateText(txt_invoiceNumber.Text, "Invoice Number");
            ReturnResult productResult = Validator.validateText(txt_product.Text, "Product");
            ReturnResult AmountResult = Validator.validateDecimal(Decimal.Parse(ntxt_amount.Text), "Amount", false);

            if (!invoiceNumberResult.Status)
            {
                MessageBox.Show(invoiceNumberResult.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!productResult.Status)
            {
                MessageBox.Show(productResult.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!AmountResult.Status)
            {
                MessageBox.Show(AmountResult.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (String.IsNullOrEmpty(txt_saleID.Text))
                {
                    MessageBox.Show("Select Sale", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txt_invoiceNumber.Text != "[ Select ]")
                {

                    Sale sale = new Sale();
                    sale.Id = Convert.ToInt32(txt_saleID.Text);
                    Product product = new Product();
                    product.Id = Convert.ToInt32(txt_productID.Text);
                    User user = new User();
                    user.Id = 1;

                    ProductReturn productReturn = new ProductReturn();
                    productReturn.Sale = sale;
                    productReturn.Product = product;
                    productReturn.Qty = Convert.ToInt32(ntxt_qty.Value);
                    productReturn.Amount = ntxt_amount.Value;
                    productReturn.User = user;
                    //ReturnResult result = ProductReturn.store(productReturn);

                    if (String.IsNullOrEmpty(txt_id.Text))
                    {
                        //save();
                        result = ProductReturn.store(productReturn);
                        msgStatus = "added";

                    }
                    else
                    {
                        //update();
                        user.Id = Int32.Parse(this.Tag.ToString());
                        result = ProductReturn.update(productReturn);
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
                        //aL.Description = "One New Transaction Added.[Date : " + dateTimePicker1.Value + "Employee : " + txtname.Text + "Transaction Category : " + txttransaction.Text + "Invoice No : " + txtInvoiceNo.Text + "Amount : " + txtamount.Text + " Description :" + txtdescrib.Text + " Added by :" + Session.uname + "]";
                        //ActivityLog.store(aL);
                        MessageBox.Show("Product Return has been "+ msgStatus + " successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(result.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

        private void btn_search_Click(object sender, EventArgs e)
        {
            search();
        }

        private void txt_product_Click(object sender, EventArgs e)
        {
            String saleID = txt_saleID.Text;
            SalesDetail.showOnViewFormSaleProduct(txt_product, txt_productID, saleID);
        }

        private void txt_productID_TextChanged(object sender, EventArgs e)
        {
            fill();
        }

        
    }
}
