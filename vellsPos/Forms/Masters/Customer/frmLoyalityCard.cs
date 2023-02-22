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
using vellsPos.Entities.Masters;
using vellsPos.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace vellsPos.Forms.Layouts
{
    public partial class frmLoyalityCard : Form
    {
        private List<ListItem> customers = new List<ListItem>();
        private string uid;

        public frmLoyalityCard()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            ReturnResult nameResult = Validator.validateText(txt_cardNumber.Text, "Loyality Card");

            if (!nameResult.Status)
            {
                MessageBox.Show(nameResult.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int customerId = 0;
                if (cmb_customer.SelectedIndex >= 0)
                {
                    customerId = int.Parse(customers[cmb_customer.SelectedIndex].Value);
                }

                Customer customer = new Customer();
                customer.Id = customerId;
                User user = new User();
                user.Id = 1;

                LoyalityCard loyalityCard = new LoyalityCard();
                loyalityCard.CardNumber = txt_cardNumber.Text;
                loyalityCard.CardType = cmb_cardType.Text;
                loyalityCard.IssuedDate=dtp_issuedDate.Value.ToString("yyyy-MM-dd");

                loyalityCard.Status = 0;
                if (cb_status.Checked)
                {
                    loyalityCard.Status = 1;
                }

                loyalityCard.Customer = customer;
                loyalityCard.User = user;

                ReturnResult result = LoyalityCard.store(loyalityCard);

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

        private void frmLoyalityCard_Load(object sender, EventArgs e)
        {
            String customerQuery = "SELECT id as value,concat(customer_number,' ',customer_first_name) as text FROM customers";
            customers = DBTransactionService.getDataAsListItemsAndFillComboBox(customerQuery, cmb_customer);

            if (customers.Count > 0)
            {
                cmb_customer.SelectedIndex = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //frmProductCreate p = new frmProductCreate() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            //this.pnl_container.Controls.Add(p);
            //p.Show();
        }
    }
}
