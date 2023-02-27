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
    public partial class frmUserRegister : Form
    {
        private List<ListItem> branches = new List<ListItem>();
        private List<ListItem> roles = new List<ListItem>();
        private string uid;
        ReturnResult result;
        String msgStatus;

        private FormMovable formMove;

        public frmUserRegister()
        {
            InitializeComponent();

            formMove = new FormMovable(this);
            formMove.SetMovable(pnl_head, lbl_title);
        }

        private void frmUserRegister_Load(object sender, EventArgs e)
        {
            String branchQuery = "SELECT id as value,branch_name as text FROM branches";
            branches = DBTransactionService.getDataAsListItemsAndFillComboBox(branchQuery, cmb_branch);

            if (branches.Count > 0)
            {
                cmb_branch.SelectedIndex = 0;
            }

            String roleQuery = "SELECT id as value,role_name as text FROM roles";
            roles = DBTransactionService.getDataAsListItemsAndFillComboBox(roleQuery, cmb_role);

            if (roles.Count > 0)
            {
                cmb_role.SelectedIndex = 0;
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
            User user = User.getOneUser(Int32.Parse(uid));
            txt_id.Text = uid;
            txt_userName.Text = user.UserName;
            cmb_branch.Text= user.Branch.BranchName;
            cmb_role.Text = user.Role.RoleName;
            txt_password.Text = user.Password;
        }

        //private void save()
        //{
            
        //}
        
        //private void update()
        //{
        //    ReturnResult nameResult = Validator.validateText(txt_userName.Text, "User Name");

        //    if (!nameResult.Status)
        //    {
        //        MessageBox.Show(nameResult.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    else
        //    {
        //        int branchId = 0;
        //        int roleId = 0;

        //        if (cmb_branch.SelectedIndex >= 0)
        //        {
        //            branchId = int.Parse(branches[cmb_branch.SelectedIndex].Value);
        //        }

        //        if (cmb_role.SelectedIndex >= 0)
        //        {
        //            roleId = int.Parse(roles[cmb_role.SelectedIndex].Value);
        //        }

        //        Branch branch = new Branch();
        //        branch.Id = branchId;

        //        Role role = new Role();
        //        role.Id = roleId;

        //        Authentication authentication = new Authentication();
        //        authentication.Id = 1;

        //        User user = new User();
        //        user.Id = Int32.Parse(this.Tag.ToString());
        //        user.UserName = txt_userName.Text;
        //        user.Branch = branch;
        //        user.Role = role;
        //        user.Password = txt_password.Text;
        //        user.Authentication = authentication;


        //        ReturnResult result = User.store(user);


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
        //            MessageBox.Show("User has been updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            this.Close();
        //        }
        //        else
        //        {
        //            MessageBox.Show(result.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //}

        private void btn_save_Click(object sender, EventArgs e)
        {
            
            ReturnResult nameResult = Validator.validateText(txt_userName.Text, "User Name");

            if (!nameResult.Status)
            {
                MessageBox.Show(nameResult.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int branchId = 0;
                int roleId = 0;

                if (cmb_branch.SelectedIndex >= 0)
                {
                    branchId = int.Parse(branches[cmb_branch.SelectedIndex].Value);
                }

                if (cmb_role.SelectedIndex >= 0)
                {
                    roleId = int.Parse(roles[cmb_role.SelectedIndex].Value);
                }

                Branch branch = new Branch();
                branch.Id = branchId;
                Role role = new Role();
                role.Id = roleId;
                Authentication authentication = new Authentication();
                authentication.Id = 1;

                DateTime thisDay = DateTime.Today;

                User user = new User();
                user.UserName = txt_userName.Text;
                user.Branch = branch;
                user.Role = role;
                user.Password = txt_password.Text;
                user.Authentication = authentication;

                if (this.Tag is null)
                {
                    //save();
                    user.Date = thisDay.ToString("yyyy-MM-dd");
                    result = User.store(user);
                    msgStatus = "added";

                }
                else
                {
                    //update();
                    user.Id = Int32.Parse(this.Tag.ToString());
                    result = User.update(user);
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
                    MessageBox.Show("User has been "+ msgStatus +" successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button1_Click(object sender, EventArgs e)
        {
            //frmProductCreate p = new frmProductCreate() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            //this.pnl_container.Controls.Add(p);
            //p.Show();
        }
    }
}
