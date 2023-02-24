using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vellsPos.Entities.Masters;
using vellsPos.Services;

namespace vellsPos.Forms.Layouts
{
    public partial class frmCustomer : Form
    {
        private string uid;
        ReturnResult result;
        String msgStatus;

        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
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

        private void fillData()
        {
            Customer customer = Customer.getOneCustomer(Int32.Parse(uid));
            txt_id.Text = uid;
            txt_customerNumber.Text = customer.CustomerNumber;
            txt_customerFirstName.Text = customer.CustomerFirstName;
            txt_cusromerLastName.Text = customer.CustomerLastName;
            dtp_dateOfBirth.Text = customer.DateOfBirth;
            if(customer.Gender==1)
            {
                cmb_gender.Text = "Male";
            }
            else if(customer.Gender == 0)
            {
                cmb_gender.Text = "Female";
            }
            else
            {
                cmb_gender.Text = "Other";
            }
            txt_nic.Text = customer.Nic;
            txt_Email.Text = customer.Email;
            txt_phoneNumber.Text = customer.PhoneNumber;
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
            ReturnResult numberResult = Validator.validateText(txt_customerNumber.Text, "Number");
            ReturnResult fNameResult = Validator.validateText(txt_customerFirstName.Text, "First Name");
            ReturnResult lNameResult = Validator.validateText(txt_cusromerLastName.Text, "Last Name");
            ReturnResult emailResult = Validator.validateText(txt_Email.Text, "Email");
            ReturnResult identyResult = Validator.validateText(txt_nic.Text, "Identy Card");
            ReturnResult pnumberResult = Validator.validateText(txt_phoneNumber.Text, "Phone Number");

            if (!numberResult.Status)
            {
                MessageBox.Show(numberResult.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!fNameResult.Status)
            {
                MessageBox.Show(fNameResult.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!lNameResult.Status)
            {
                MessageBox.Show(lNameResult.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!emailResult.Status)
            {
                MessageBox.Show(emailResult.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!identyResult.Status)
            {
                MessageBox.Show(identyResult.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!pnumberResult.Status)
            {
                MessageBox.Show(pnumberResult.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Customer customer = new Customer();
                customer.CustomerNumber = txt_customerNumber.Text;
                customer.CustomerFirstName = txt_customerFirstName.Text;
                customer.CustomerLastName = txt_cusromerLastName.Text;
                customer.DateOfBirth = dtp_dateOfBirth.Value.ToString("yyyy-MM-dd");

                if (cmb_gender.Text == "Male")
                {
                    customer.Gender = 1;
                }
                else if (cmb_gender.Text == "Female")
                {
                    customer.Gender = 0;
                }
                else
                {
                    customer.Gender = 2;
                }

                customer.Nic = txt_nic.Text;
                customer.Email = txt_Email.Text;
                customer.PhoneNumber = txt_phoneNumber.Text;

                User user = new User();
                user.Id = 1;

                customer.User = user;

                //ReturnResult result = Customer.store(customer);

                if (String.IsNullOrEmpty(txt_id.Text))
                {
                    //save();
                    result = Customer.store(customer);
                    msgStatus = "added";

                }
                else
                {
                    //update();
                    customer.Id = Int32.Parse(this.Tag.ToString());
                    result = Customer.update(customer);
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
                    MessageBox.Show("Customer has been "+ msgStatus +" successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
