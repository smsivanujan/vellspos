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
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
                //int pid = 0;
                //int pid1 = 0;
                //int pid2 = 0;

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

                Customer customer = new Customer();
                customer.CustomerNumber = txt_customerNumber.Text;
                customer.CustomerFirstName = txt_customerFirstName.Text;
                customer.CustomerLastName = txt_cusromerLastName.Text;
                customer.DateOfBirth = dtp_dateOfBirth.Value.ToString("yyyy-MM-dd");

                customer.Gender = 0;
                if (cmb_gender.Text=="Nale")
                {
                    customer.Gender = 1;
                }
                else if(cmb_gender.Text == "Female")
                {
                    customer.Gender = 2;
                }
                else
                {
                    customer.Gender = 0;
                }
               
                customer.Nic = txt_nic.Text;
                customer.Email = txt_Email.Text;
                customer.PhoneNumber = txt_phoneNumber.Text;

                User user = new User();
                user.Id = 1;

                customer.User = user;

                ReturnResult result = Customer.store(customer);

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
                    MessageBox.Show("Customer has been added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void pnl_container_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void FrmForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //frmProductCreate p = new frmProductCreate() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            //this.pnl_container.Controls.Add(p);
            //p.Show();
        }
    }
}
