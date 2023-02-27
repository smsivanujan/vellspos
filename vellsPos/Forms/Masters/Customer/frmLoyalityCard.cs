using Google.Protobuf.WellKnownTypes;
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
    public partial class frmLoyalityCard : Form
    {
        private List<ListItem> customers = new List<ListItem>();
        private string uid;
        ReturnResult result;
        String msgStatus;

        private FormMovable formMove;

        public frmLoyalityCard()
        {
            InitializeComponent();

            formMove = new FormMovable(this);
            formMove.SetMovable(pnl_head, lbl_title);
        }

        private void frmLoyalityCard_Load(object sender, EventArgs e)
        {
            //String customerQuery = "SELECT id as value,concat(customer_number,' ',customer_first_name) as text FROM customers";
            //customers = DBTransactionService.getDataAsListItemsAndFillComboBox(customerQuery, cmb_customer);

            //if (customers.Count > 0)
            //{
            //    cmb_customer.SelectedIndex = 0;
            //}

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
            LoyalityCard loyalityCard = LoyalityCard.getOneLoyalityCard(Int32.Parse(uid));
            txt_id.Text = uid;
            txt_customer.Text = loyalityCard.Customer.CustomerFirstName;
            txt_customerID.Text = Convert.ToString(loyalityCard.Customer.Id);
            txt_cardNumber.Text = loyalityCard.CardNumber;
            cmb_cardType.Text = loyalityCard.CardType;
            dtp_issuedDate.Text = loyalityCard.IssuedDate;
            

            if(loyalityCard.Status==1)
            {
                cb_status.Checked=true;
            }
            else
            {
                cb_status.Checked = false;
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
            ReturnResult nameResult = Validator.validateText(txt_cardNumber.Text, "Loyality Card");

            if (!nameResult.Status)
            {
                MessageBox.Show(nameResult.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //int customerId = 0;
                //if (cmb_customer.SelectedIndex >= 0)
                //{
                //    customerId = int.Parse(customers[cmb_customer.SelectedIndex].Value);
                //}

                Customer customer = new Customer();
                customer.Id = Convert.ToInt32(txt_customerID.Text);
                User user = new User();
                user.Id = 1;

                LoyalityCard loyalityCard = new LoyalityCard();
                loyalityCard.CardNumber = txt_cardNumber.Text;
                loyalityCard.CardType = cmb_cardType.Text;
                loyalityCard.IssuedDate = dtp_issuedDate.Value.ToString("yyyy-MM-dd");

                loyalityCard.Status = 0;
                if (cb_status.Checked)
                {
                    loyalityCard.Status = 1;
                }

                loyalityCard.Customer = customer;
                loyalityCard.User = user;

                if (this.Tag is null)
                {
                    //save();
                    result = LoyalityCard.store(loyalityCard);
                    msgStatus = "added";

                }
                else
                {
                    //update();
                    loyalityCard.Id = Int32.Parse(this.Tag.ToString());
                    result = LoyalityCard.update(loyalityCard);
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
                    MessageBox.Show("Discount has been "+ msgStatus +" successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txt_customer_Click(object sender, EventArgs e)
        {
            Customer.showOnViewFormCustomer(txt_customer, txt_customerID);
        }

        private void txt_customerID_TextChanged(object sender, EventArgs e)
        {
            String customerNameQuery = "SELECT concat(customer_first_name,' ',customer_last_name)  FROM customers WHERE id='" + txt_customerID.Text + "' ";
            String customerName = DBTransactionService.getScalerData(customerNameQuery);

            txt_customer.Text = customerName;
        }
    }
}
