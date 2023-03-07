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
    public partial class frmHome : Form
    {
        private FormMovable formMove;

        public frmHome()
        {
            InitializeComponent();

            formMove = new FormMovable(this);
            formMove.SetMovable(pnl_head, lbl_title);

            lbl_maxStatus.Text = "1";//maximize
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_pos_Click(object sender, EventArgs e)
        {
            frmPOS frmPointOfSale=new frmPOS();
            frmPointOfSale.ShowDialog();
        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            String product = "product";
            frmViewButton frmViewButton = new frmViewButton(product);
            frmViewButton.ShowDialog();
            //frmView cv = new frmView();
            //cv.test();
            //tb_display.TabPages.Clear();
            //frmProduct frmProduct = new frmProduct();
            //AddNewTab(frmProduct);

            

            //frmProductBarcode frmProductBarcode = new frmProductBarcode();
            //AddNewTab(frmProductBarcode);
            //frmProduct p = new frmProduct() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            //p.StartPosition = FormStartPosition.CenterParent;
            //this.pnl_display.Controls.Add(p);
            ////this.tb_display.Controls.Add(p);
            //p.Show();
        }

        private void btn_maximize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            if (lbl_maxStatus.Text == "1")
            {
                WindowState = FormWindowState.Normal;
                lbl_maxStatus.Text = "0";
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                lbl_maxStatus.Text = "1";
            }
           
        }

        //private void AddNewTab(Form frm)
        //{
        //    TabPage tab = new TabPage(frm.Text);
        //    tab.AutoScroll = true;

        //    frm.TopMost = true;
        //    frm.TopLevel = false;
        //    frm.Parent = tab;
        //    frm.Visible = true;
        //    frm.Dock = DockStyle.Fill;
        //    frm.AutoScroll = true;

        //    tb_display.Controls.Add(tab);
        //    //tb_display.TabPages.Add(frm.Text);
        //    tb_display.SelectedTab = tab;


        //}

        private void btn_search_Click(object sender, EventArgs e)
        {

        }

        private void pnl_navigation_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_crm_Click(object sender, EventArgs e)
        {
            String crm = "crm";
            frmViewButton frmViewButton = new frmViewButton(crm);
            frmViewButton.ShowDialog();



            //tb_display.TabPages.Clear();
            //frmCustomer frmCustomer = new frmCustomer();
            //AddNewTab(frmCustomer);
            //frmLoyalityCard frmLoyalityCard = new frmLoyalityCard();
            //AddNewTab(frmLoyalityCard);
        }

        private void btn_discount_Click(object sender, EventArgs e)
        {
            frmDiscount frmDiscount = new frmDiscount();
            frmDiscount.ShowDialog();
        }

        private void btn_complain_Click(object sender, EventArgs e)
        {
            frmComplain frmComplain = new frmComplain();
            frmComplain.ShowDialog();
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            frmUserRegister userRegister = new frmUserRegister();
            userRegister.ShowDialog();
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            frmSetting frmSetting = new frmSetting();
            frmSetting.ShowDialog();
        }
    }
}
