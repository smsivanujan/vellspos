using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vellsPos.Forms.Layouts
{
    public partial class frmTestForms : Form
    {
        public frmTestForms()
        {
            InitializeComponent();
        }

        private void btndiscount_Click(object sender, EventArgs e)
        {
            frmDiscount dis = new frmDiscount();
            dis.Show();
        }

        private void btn_complain_Click(object sender, EventArgs e)
        {
            frmComplain com = new frmComplain();
            com.Show();
        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            frmCustomer cus = new frmCustomer();
            cus.Show();
        }

        private void btn_loyalityCard_Click(object sender, EventArgs e)
        {
            frmLoyalityCard lcar = new frmLoyalityCard();
            lcar.Show();
        }

        private void btn_category_Click(object sender, EventArgs e)
        {
            frmCategory fcat = new frmCategory();
            fcat.Show();
        }
    }
}
