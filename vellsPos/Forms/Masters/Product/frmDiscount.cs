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
using vellsPos.Entities.Masters;
using vellsPos.Services;

namespace vellsPos.Forms.Layouts
{
    public partial class frmDiscount : Form
    {
        private string uid;

        public frmDiscount()
        {
            InitializeComponent();
        }

        private void frmDiscount_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            ReturnResult nameResult = Validator.validateText(txt_discountName.Text, "Discount");
            //ReturnResult transactonResult = Validator.validateText(txttransaction.Text, "Transaction");
            //ReturnResult AmountResult = Validator.validateDecimal(Decimal.Parse(txtamount.Text), "Amount", false);

            if (!nameResult.Status)
            {
                MessageBox.Show(nameResult.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //else if (!transactonResult.Status)
            //{
            //    MessageBox.Show(transactonResult.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else if (!AmountResult.Status)
            //{
            //    MessageBox.Show(AmountResult.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            else
            {
                int pid = 0;
                int pid1 = 0;
                int pid2 = 0;

                //if (txttransaction.SelectedIndex >= 0)
                //{
                //    pid2 = int.Parse(tran[txttransaction.SelectedIndex].Value);
                //}

                //TransactionCategory tc = new TransactionCategory();
                //tc.Id = pid2;

                //if (String.IsNullOrEmpty(txtId.Text))
                //{
                //    MessageBox.Show("Select Employee", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}
                //else if (txtname.Text != "[ Select ]")
                //{
                    //String dep = "select depatrment_id from employee where id='" + txtId.Text + "' ";
                    //String depID = DBTransactionService.getScalerData(dep);
                    //String dep1 = "select name from department where id='" + depID + "'";
                    //String depName = DBTransactionService.getScalerData(dep1);
                    //String prtyid = "select property_id from employee where id='" + txtId.Text + "' ";
                    //String prtyidID = DBTransactionService.getScalerData(prtyid);

                    //Property pty = new Property();
                    //pty.Id = Int32.Parse(prtyidID);
                    //Employee em = new Employee();
                    //em.Id = Int32.Parse(txtId.Text);
                    //Department dp = new Department();
                    //dp.Id = Int32.Parse(depID);

                    Discount discount = new Discount();
                    discount.DiscountName = txt_discountName.Text;
                Console.WriteLine(dtp_dateFrom.Value.ToString("yyyy-MM-dd H:mm"));
                    discount.DateFrom = dtp_dateFrom.Value.ToString("yyyy-MM-dd H:mm");
                discount.DateTo = dtp_dateTo.Value.ToString("yyyy-MM-dd H:mm");
                discount.Description = rtxt_description.Text;

                discount.Status = 0;
                if (cb_status.Checked)
                {
                    discount.Status = 1;
                }

                User user = new User();
                user.Id = 1;

                discount.User = user;
                
                    ReturnResult result = Discount.store(discount);

                    //String transMaxID = "SELECT MAX(id) FROM transaction";
                    //String transDetailID = DBTransactionService.getScalerData(transMaxID);

                    //Transaction tr = new Transaction();
                    //tr.Id = Int32.Parse(transDetailID);

                    //TransactionDetails transactionDetails = new TransactionDetails();
                    //transactionDetails.Transaction = tr;
                    //transactionDetails.Date = DateTime.Today;
                    //transactionDetails.Amount = txtpaidAmount.Value;
                    //if (txtpaidAmount.Value != 0)
                    //{
                    //    ReturnResult resulttransDetail1 = TransactionDetails.store(transactionDetails);
                    //}

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
                        MessageBox.Show("Discount has been added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
