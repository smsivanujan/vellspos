using vellsPos.Entities.Layouts;

namespace vellsPos.Forms.Layouts
{
    public partial class frmHome : Form
    {
        private FormMovable formMove;
        private FromResizable formResize;

        private float fontScale = 1;


        private Rectangle rzlbl_txttotalCustomer;
        private Rectangle rzlbl_txtdiscount;
        private Rectangle rzlbl_sale;
        private Rectangle rzlbl_txtsale;
        private Rectangle rzlbl_invoice;
        private Rectangle rzlbl_txtinvoice;
        private Rectangle rzlbl_totalCustomer;
        private Rectangle rzlbl_newCustomer;
        private Rectangle rzlbl_txtnewCustomer;
        private Rectangle rzlbl_discount;
        private Rectangle rzpnl_saleByYear;
        private Rectangle rzpnl_saleByCard;
        private Rectangle rzpnl_saleByWeek;
        private Rectangle rzpnl_saleByValue;
        private Rectangle rzlbl_txtsaleByYear;
        private Rectangle rzlbl_txtsaleByCard;
        private Rectangle rzlbl_txtsaleByWeek;
        private Rectangle rzlbl_txtsaleByValue;
        private Rectangle rzpnl_body;
        private Rectangle rzpnl_graph;
        private Rectangle rzpnl_total_customer;
        private Rectangle rzpnl_newCustomer;
        private Rectangle rzpnl_discount;
        private Rectangle rzpnl_sale;
        private Rectangle rzpnl_invoice;

        private float rzlbl_txttotalCustomerFontSize;
        private float rzlbl_txtdiscountFontSize;
        private float rzlbl_saleFontSize;
        private float rzlbl_txtsaleFontSize;
        private float rzlbl_invoiceFontSize;
        private float rzlbl_txtinvoiceFontSize;
        private float rzlbl_totalCustomerFontSize;
        private float rzlbl_newCustomerFontSize;
        private float rzlbl_txtnewCustomerFontSize;
        private float rzlbl_discountFontSize;
        private float rzpnl_saleByYearFontSize;
        private float rzpnl_saleByCardFontSize;
        private float rzpnl_saleByWeekFontSize;
        private float rzpnl_saleByValueFontSize;
        private float rzlbl_txtsaleByYearFontSize;
        private float rzlbl_txtsaleByCardFontSize;
        private float rzlbl_txtsaleByWeekFontSize;
        private float rzlbl_txtsaleByValueFontSize;
        private float rzpnl_bodyFontSize;
        private float rzpnl_graphFontSize;
        private float rzpnl_total_customerFontSize;
        private float rzpnl_newCustomerFontSize;
        private float rzpnl_discountFontSize;
        private float rzpnl_saleFontSize;
        private float rzpnl_invoiceFontSize;

        //ReSize
        //form
        private Rectangle rzForm;
        //panel
        private Rectangle rzpnl_navigation;

        private float rzpnl_navigationFontSize;

        //navigation elements
        //button
        private Rectangle rzbtn_crm;
        private Rectangle rzbtn_sale;
        private Rectangle rzbtn_pos;
        private Rectangle rzbtn_complain;
        private Rectangle rzbtn_faq;
        private Rectangle rzbtn_setting;
        private Rectangle rzbtn_report;
        private Rectangle rzbtn_product;
        private Rectangle rzbtn_discount;
        private Rectangle rzbtn_user;
        private Rectangle rzbtn_log;
        
        private float rzbtn_crmFontSize;
        private float rzbtn_saleFontSize;
        private float rzbtn_posFontSize;
        private float rzbtn_complainFontSize;
        private float rzbtn_faqFontSize;
        private float rzbtn_settingFontSize;
        private float rzbtn_reportFontSize;
        private float rzbtn_productFontSize;
        private float rzbtn_discountFontSize;
        private float rzbtn_userFontSize;
        private float rzbtn_logFontSize;


        public frmHome()
        {
            InitializeComponent();

            formMove = new FormMovable(this);
            formMove.SetMovable(pnl_head, lbl_title);

            //lbl_maxStatus.Text = "1";//maximize
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            resize();

        }

        private void resize()
        {
            rzForm = new Rectangle(this.Location, this.Size);

            //navigation elements
            rzpnl_navigation = new Rectangle(pnl_navigation.Location, pnl_navigation.Size);
            rzbtn_crm = new Rectangle(btn_crm.Location, btn_crm.Size);
            rzbtn_sale = new Rectangle(btn_sale.Location, btn_sale.Size);
            rzbtn_pos = new Rectangle(btn_pos.Location, btn_pos.Size);
            rzbtn_complain = new Rectangle(btn_complain.Location, btn_complain.Size);
            rzbtn_faq = new Rectangle(btn_faq.Location, btn_faq.Size);
            rzbtn_setting = new Rectangle(btn_setting.Location, btn_setting.Size);
            rzbtn_report = new Rectangle(btn_report.Location, btn_report.Size);
            rzbtn_product = new Rectangle(btn_product.Location, btn_product.Size);
            rzbtn_discount = new Rectangle(btn_discount.Location, btn_discount.Size);
            rzbtn_user = new Rectangle(btn_user.Location, btn_user.Size);
            rzbtn_log = new Rectangle(btn_logs.Location, btn_logs.Size);

            rzpnl_body = new Rectangle(pnl_body.Location, pnl_body.Size);
            rzpnl_graph = new Rectangle(pnl_graph.Location, pnl_graph.Size);
            rzpnl_total_customer = new Rectangle(pnl_total_customer.Location, pnl_total_customer.Size);
            rzpnl_newCustomer = new Rectangle(pnl_newCustomer.Location, pnl_newCustomer.Size);
            rzpnl_discount = new Rectangle(pnl_discount.Location, pnl_discount.Size);
            rzpnl_sale = new Rectangle(pnl_sale.Location, pnl_sale.Size);
            rzpnl_invoice = new Rectangle(pnl_invoice.Location, pnl_invoice.Size);

            rzlbl_txttotalCustomer = new Rectangle(lbl_txttotalCustomer.Location, lbl_txttotalCustomer.Size);
            rzlbl_txtdiscount = new Rectangle(lbl_txtdiscount.Location, lbl_txtdiscount.Size);
            rzlbl_sale = new Rectangle(lbl_sale.Location, lbl_sale.Size);
            rzlbl_txtsale = new Rectangle(lbl_txtsale.Location, lbl_txtsale.Size);
            rzlbl_invoice = new Rectangle(lbl_invoice.Location, lbl_invoice.Size);
            rzlbl_txtinvoice = new Rectangle(lbl_txtinvoice.Location, lbl_txtinvoice.Size);
            rzlbl_totalCustomer = new Rectangle(lbl_totalCustomer.Location, lbl_totalCustomer.Size);
            rzlbl_newCustomer = new Rectangle(lbl_newCustomer.Location, lbl_newCustomer.Size);
            rzlbl_txtnewCustomer = new Rectangle(lbl_txtnewCustomer.Location, lbl_txtnewCustomer.Size);
            rzlbl_discount = new Rectangle(lbl_discount.Location, lbl_discount.Size);
            rzpnl_saleByYear = new Rectangle(pnl_saleByYear.Location, pnl_saleByYear.Size);
            rzpnl_saleByCard = new Rectangle(pnl_saleByCard.Location, pnl_saleByCard.Size);
            rzpnl_saleByWeek = new Rectangle(pnl_saleByWeek.Location, pnl_saleByWeek.Size);
            rzpnl_saleByValue = new Rectangle(pnl_saleByValue.Location, pnl_saleByValue.Size);
            rzlbl_txtsaleByYear = new Rectangle(lbl_txtsaleByYear.Location, lbl_txtsaleByYear.Size);
            rzlbl_txtsaleByCard = new Rectangle(lbl_txtsaleByCard.Location, lbl_txtsaleByCard.Size);
            rzlbl_txtsaleByWeek = new Rectangle(lbl_txtsaleByWeek.Location, lbl_txtsaleByWeek.Size);
            rzlbl_txtsaleByValue = new Rectangle(lbl_txtsaleByValue.Location, lbl_txtsaleByValue.Size);

            //navigation elements fonts
            rzpnl_navigationFontSize = pnl_navigation.Font.Size;
            rzbtn_crmFontSize = btn_crm.Font.Size;
            rzbtn_saleFontSize = btn_sale.Font.Size;
            rzbtn_posFontSize = btn_pos.Font.Size;
            rzbtn_complainFontSize = btn_complain.Font.Size;
            rzbtn_faqFontSize = btn_faq.Font.Size;
            rzbtn_settingFontSize = btn_setting.Font.Size;
            rzbtn_reportFontSize = btn_report.Font.Size;
            rzbtn_productFontSize = btn_product.Font.Size;
            rzbtn_discountFontSize = btn_discount.Font.Size;
            rzbtn_userFontSize = btn_user.Font.Size;
            rzbtn_logFontSize = btn_logs.Font.Size;

            rzpnl_bodyFontSize = pnl_body.Font.Size;
            rzpnl_graphFontSize = pnl_graph.Font.Size;
            rzpnl_total_customerFontSize = pnl_total_customer.Font.Size;
            rzpnl_newCustomerFontSize = pnl_newCustomer.Font.Size;
            rzpnl_discountFontSize = pnl_discount.Font.Size;
            rzpnl_saleFontSize = pnl_sale.Font.Size;
            rzpnl_invoiceFontSize = pnl_invoice.Font.Size;

            rzlbl_txttotalCustomerFontSize = lbl_txttotalCustomer.Font.Size;
            rzlbl_txtdiscountFontSize = lbl_txtdiscount.Font.Size;
            rzlbl_saleFontSize = lbl_sale.Font.Size;
            rzlbl_txtsaleFontSize = lbl_txtsale.Font.Size;
            rzlbl_invoiceFontSize = lbl_invoice.Font.Size;
            rzlbl_txtinvoiceFontSize = lbl_txtinvoice.Font.Size;
            rzlbl_totalCustomerFontSize = lbl_totalCustomer.Font.Size;
            rzlbl_newCustomerFontSize = lbl_newCustomer.Font.Size;
            rzlbl_txtnewCustomerFontSize = lbl_txtnewCustomer.Font.Size;
            rzlbl_discountFontSize = lbl_discount.Font.Size;
            rzpnl_saleByYearFontSize = pnl_saleByYear.Font.Size;
            rzpnl_saleByCardFontSize = pnl_saleByCard.Font.Size;
            rzpnl_saleByWeekFontSize = pnl_saleByWeek.Font.Size;
            rzpnl_saleByValueFontSize = pnl_saleByValue.Font.Size;
            rzlbl_txtsaleByYearFontSize = lbl_txtsaleByYear.Font.Size;
            rzlbl_txtsaleByCardFontSize = lbl_txtsaleByCard.Font.Size;
            rzlbl_txtsaleByWeekFontSize = lbl_txtsaleByWeek.Font.Size;
            rzlbl_txtsaleByValueFontSize = lbl_txtsaleByValue.Font.Size;
        }

        private void resizeChildrenControls()
        {
            resizeControl(rzpnl_navigation, pnl_navigation, rzpnl_navigationFontSize);
            resizeControl(rzbtn_crm, btn_crm, rzbtn_crmFontSize);
            resizeControl(rzbtn_sale, btn_sale, rzbtn_saleFontSize);
            resizeControl(rzbtn_pos, btn_pos, rzbtn_posFontSize);
            resizeControl(rzbtn_complain, btn_complain, rzbtn_complainFontSize);
            resizeControl(rzbtn_faq, btn_faq, rzbtn_faqFontSize);
            resizeControl(rzbtn_setting, btn_setting, rzbtn_settingFontSize);
            resizeControl(rzbtn_report, btn_report, rzbtn_reportFontSize);
            resizeControl(rzbtn_product, btn_product, rzbtn_productFontSize);
            resizeControl(rzbtn_discount, btn_discount, rzbtn_discountFontSize);
            resizeControl(rzbtn_user, btn_user, rzbtn_userFontSize);
            resizeControl(rzbtn_log, btn_logs, rzbtn_logFontSize);

            resizeControl(rzpnl_body, pnl_body, rzpnl_bodyFontSize);
            resizeControl(rzpnl_graph, pnl_graph, rzpnl_graphFontSize);
            resizeControl(rzpnl_total_customer, pnl_total_customer, rzpnl_total_customerFontSize);
            resizeControl(rzpnl_newCustomer, pnl_newCustomer, rzpnl_newCustomerFontSize);
            resizeControl(rzpnl_discount, pnl_discount, rzpnl_discountFontSize);
            resizeControl(rzpnl_sale, pnl_sale, rzpnl_saleFontSize);
            resizeControl(rzpnl_invoice, pnl_invoice, rzpnl_invoiceFontSize);

            resizeControl(rzlbl_txttotalCustomer, lbl_txttotalCustomer, rzlbl_txttotalCustomerFontSize);
            resizeControl(rzlbl_txtdiscount, lbl_txtdiscount, rzlbl_txtdiscountFontSize);
            resizeControl(rzlbl_sale, lbl_sale, rzlbl_saleFontSize);
            resizeControl(rzlbl_txtsale, lbl_txtsale, rzlbl_txtsaleFontSize);
            resizeControl(rzlbl_invoice, lbl_invoice, rzlbl_invoiceFontSize);
            resizeControl(rzlbl_txtinvoice, lbl_txtinvoice, rzlbl_txtinvoiceFontSize);
            resizeControl(rzlbl_totalCustomer, lbl_totalCustomer, rzlbl_totalCustomerFontSize);
            resizeControl(rzlbl_newCustomer, lbl_newCustomer, rzlbl_newCustomerFontSize);
            resizeControl(rzlbl_txtnewCustomer, lbl_txtnewCustomer, rzlbl_txtnewCustomerFontSize);
            resizeControl(rzlbl_discount, lbl_discount, rzlbl_discountFontSize);
            resizeControl(rzpnl_saleByYear, pnl_saleByYear, rzpnl_saleByYearFontSize);
            resizeControl(rzpnl_saleByCard, pnl_saleByCard, rzpnl_saleByCardFontSize);
            resizeControl(rzpnl_saleByWeek, pnl_saleByWeek, rzpnl_saleByWeekFontSize);
            resizeControl(rzpnl_saleByValue, pnl_saleByValue, rzpnl_saleByValueFontSize);
            resizeControl(rzlbl_txtsaleByYear, lbl_txtsaleByYear, rzlbl_txtsaleByYearFontSize);
            resizeControl(rzlbl_txtsaleByCard, lbl_txtsaleByCard, rzlbl_txtsaleByCardFontSize);
            resizeControl(rzlbl_txtsaleByWeek, lbl_txtsaleByWeek, rzlbl_txtsaleByWeekFontSize);
            resizeControl(rzlbl_txtsaleByValue, lbl_txtsaleByValue, rzlbl_txtsaleByValueFontSize);
        }

        private void resizeControl(Rectangle r, Control c, float ofs)
        {
            float xRatio = (float)(this.ClientRectangle.Width) / (float)(rzForm.Width);
            float yRatio = (float)(this.ClientRectangle.Height) / (float)(rzForm.Height);

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

        private void frmHome_Resize(object sender, EventArgs e)
        {
            resizeChildrenControls();
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
            //WindowState = FormWindowState.Maximized;

            //if (lbl_maxStatus.Text == "1")
            //{
            //    WindowState = FormWindowState.Normal;
            //    lbl_maxStatus.Text = "0";
            //}
            //else
            //{
            //    WindowState = FormWindowState.Maximized;
            //    lbl_maxStatus.Text = "1";
            //}
           
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

        private void btn_logs_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
