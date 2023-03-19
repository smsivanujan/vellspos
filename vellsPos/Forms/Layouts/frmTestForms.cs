﻿using System;
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
using vellsPos.Forms.Masters.Setting;

namespace vellsPos.Forms.Layouts
{
    public partial class frmTestForms : Form
    {
        //private FormMovable formMove;
        private float fontScale = 1;
        private Rectangle originalFormRect;
        private Rectangle originalButtonRect;
        private Rectangle originalPanelRect;
        private float originalButtonFontSize;

        public frmTestForms()
        {
            InitializeComponent();

            //formMove = new FormMovable(this);
            //formMove.SetMovable(pnl_head, lbl_title);
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
            frmPOS frmPointOfSale = new frmPOS();
            frmPointOfSale.ShowDialog();
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
            ftb.ShowDialog();
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

        private void btn_home_Click(object sender, EventArgs e)
        {
            frmHome fhome = new frmHome();
            fhome.ShowDialog();
        }

        private void frmTestForms_Load(object sender, EventArgs e)
        {
            originalFormRect = new Rectangle(this.Location, this.Size);
            originalButtonRect = new Rectangle(btn_category.Location, btn_category.Size);
            originalPanelRect = new Rectangle(panel1.Location, panel1.Size);
            originalButtonFontSize = panel1.Font.Size;
        }

        private void resizeChildrenControls()
        {
            resizeControl(originalButtonRect, btn_category , originalButtonFontSize);
            resizeControl(originalPanelRect, panel1, originalButtonFontSize);
        }

        private void resizeControl(Rectangle r, Control c, float ofs)
        {
            float xRatio = (float)(this.ClientRectangle.Width) / (float)(originalFormRect.Width);
            float yRatio = (float)(this.ClientRectangle.Height) / (float)(originalFormRect.Height);

            float newX = r.Location.X * xRatio;
            float newY = r.Location.Y * yRatio;

            c.Location = new Point((int)newX, (int)newY);
            c.Width = (int)(r.Width * xRatio);
            c.Height = (int)(r.Height * yRatio);

            float ratio = xRatio;

            if (xRatio >= yRatio)
            {
                ratio = yRatio;
            }

            
            float newFontSize = ofs * ratio;
            Font newFont = new Font(c.Font.FontFamily, newFontSize);
            c.Font = newFont;

        }

        private void btn_activation_Click(object sender, EventArgs e)
        {
            frmActivation frmActivation = new frmActivation();
            frmActivation.ShowDialog();
        }

        private void btn_drawer_Click(object sender, EventArgs e)
        {
            frmDrawer frmDrawer = new frmDrawer();
            frmDrawer.ShowDialog();
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            frmSetting frmSetting = new frmSetting();
            frmSetting.ShowDialog();
        }

        private void btn_productDiscount_Click(object sender, EventArgs e)
        {
            frmDiscountProduct f = new frmDiscountProduct();
            f.ShowDialog();
        }

        private void frmTestForms_Resize(object sender, EventArgs e)
        {
            resizeChildrenControls();
        }
    }
}
