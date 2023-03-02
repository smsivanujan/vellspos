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

namespace vellsPos.Forms.Layouts
{
    public partial class frmViewButton : Form
    {
        private FormMovable formMove;

        public frmViewButton(String name)
        {
            InitializeComponent();

            formMove = new FormMovable(this);
            formMove.SetMovable(pnl_head, lbl_title);

            if(name=="product")
            {
                gb_crm.Visible=false;
                this.Size = new Size(710, 319);
            }
            else if(name == "crm")
            {
                gb_product.Visible = false;
                this.Size = new Size(710, 238);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmViewButton_Load(object sender, EventArgs e)
        {

        }

        private void btn_category_Click(object sender, EventArgs e)
        {
            Category.showOnViewForm();
            //Form frm = Application.OpenForms["Form1"]; //it should works
            //frm.Show();
        }

        private void btn_subCategory_Click(object sender, EventArgs e)
        {
            SubCategory.showOnViewForm();
        }

        private void btn_subCoCategory_Click(object sender, EventArgs e)
        {
            SubCoCategory.showOnViewForm();
        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            Product.showOnViewForm();
        }

        private void btn_productBarcode_Click(object sender, EventArgs e)
        {
            ProductBarcode.showOnViewForm();
        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            Customer.showOnViewForm();
        }

        private void btn_loyalityCard_Click(object sender, EventArgs e)
        {
            LoyalityCard.showOnViewForm();
        }

        private void btn_activityLog_Click(object sender, EventArgs e)
        {
            ActivityLog.showOnViewForm();
        }

        private void btn_loginLog_Click(object sender, EventArgs e)
        {
            LoginLog.showOnViewForm();
        }
    }
}
