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
            Discount.showOnViewForm();
            //frmDiscount dis = new frmDiscount();
            //dis.Show();
        }

        private void btn_complain_Click(object sender, EventArgs e)
        {
            Complain.showOnViewForm();
            //frmComplain com = new frmComplain();
            //com.Show();
        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            Customer.showOnViewForm();
            //frmCustomer cus = new frmCustomer();
            //cus.Show();
        }

        private void btn_loyalityCard_Click(object sender, EventArgs e)
        {
            LoyalityCard.showOnViewForm();
            //frmLoyalityCard lcar = new frmLoyalityCard();
            //lcar.Show();
        }

        private void btn_category_Click(object sender, EventArgs e)
        {
            Category.showOnViewForm();
            //frmCategory fcat = new frmCategory();
            //fcat.Show();
        }

        private void btn_subCategory_Click(object sender, EventArgs e)
        {
            SubCategory.showOnViewForm();
            //frmSubCategory fsubcat = new frmSubCategory();
            //fsubcat.Show();
        }

        private void btn_subCoCategory_Click(object sender, EventArgs e)
        {
            SubCoCategory.showOnViewForm();
            //frmSubCoCategory fsubcocat = new frmSubCoCategory();
            //fsubcocat.Show();
        }

        private void btn_payout_Click(object sender, EventArgs e)
        {
            Payout.showOnViewForm();
            //frmPayout fpay = new frmPayout();
            //fpay.Show();
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            User.showOnViewForm();
            //frmUserRegister fusr=new frmUserRegister();
            //fusr.Show();
        }

        private void btn_pos_Click(object sender, EventArgs e)
        {
            frmPointOfSale frmPointOfSale = new frmPointOfSale();
            frmPointOfSale.Show();
        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            Product.showOnViewForm();
            //frmProduct fpro = new frmProduct();
            //fpro.Show();
        }

        private void btn_barcode_Click(object sender, EventArgs e)
        {
            frmTestBarcode ftb = new frmTestBarcode();
            ftb.Show();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            ProductReturn.showOnViewForm();
            //frmReturn fr = new frmReturn();
            //fr.Show();
        }

        private void btn_productBarcode_Click(object sender, EventArgs e)
        {
            ProductBarcode.showOnViewForm();
            //frmProductBarcode fpb = new frmProductBarcode();
            //fpb.Show();
        }
    }
}
