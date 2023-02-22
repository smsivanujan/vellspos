﻿using System;
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

namespace vellsPos.Forms.Layouts
{
    public partial class frmComplain : Form
    {
        private string uid;

        public frmComplain()
        {
            InitializeComponent();
        }

        private void frmComplain_Load(object sender, EventArgs e)
        {
            uid = this.Tag.ToString();
            if (String.IsNullOrEmpty(uid))
            {
                //
                MessageBox.Show("111");
            }
            else
            {
                Console.WriteLine("2222");
                fillData();
            }
        }

        private void fillData()
        {
            Complain complain=Complain.getOneComplain(Int32.Parse(uid));
            txt_id.Text = uid;
            dtp_date.Text = complain.Date;
            cmb_type.Text = complain.Type;
            cmb_priority.Text = complain.Priority;
            rtxt_description.Text = complain.Description;
        }

        private void save()
        {
            ReturnResult nameResult = Validator.validateText(rtxt_description.Text, "Discount");

            if (!nameResult.Status)
            {
                MessageBox.Show(nameResult.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Complain complain = new Complain();
                complain.Date = dtp_date.Value.ToString("yyyy-MM-dd H:mm");
                complain.Type = cmb_type.Text;
                complain.Priority = cmb_priority.Text;
                complain.Description = rtxt_description.Text;
                complain.Status = 1;


                User user = new User();
                user.Id = 1;

                complain.User = user;

                ReturnResult result = Complain.store(complain);

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
                    MessageBox.Show("Complain has been added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(result.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //}
            }
        }

        private void update()
        {
            ReturnResult nameResult = Validator.validateText(rtxt_description.Text, "Discount");

            if (!nameResult.Status)
            {
                MessageBox.Show(nameResult.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Complain complain = new Complain();
                complain.Id = Int32.Parse(this.Tag.ToString());
                Console.WriteLine(Int32.Parse(this.Tag.ToString()));
                complain.Date = dtp_date.Value.ToString("yyyy-MM-dd H:mm");
                complain.Type = cmb_type.Text;
                complain.Priority = cmb_priority.Text;
                complain.Description = rtxt_description.Text;
                complain.Status = 1;
                User user = new User();
                user.Id = 1;

                complain.User = user;

                ReturnResult result = Complain.update(complain);

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
                    MessageBox.Show("Complain has been Updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(result.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //}
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_id.Text))
            {
                save();
            }
            else
            {
                update();
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

        private void btn_delete_Click(object sender, EventArgs e)
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
