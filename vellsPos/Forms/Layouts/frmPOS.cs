﻿using vellsPos.Entities.Layouts;
using vellsPos.Entities.Masters;
using vellsPos.Services;

namespace vellsPos.Forms.Layouts
{
    public partial class frmPOS : Form
    {
        public static frmPOS frmposInstance;
        //public TextBox tbx;
        
        public static string categoryID = "";
        public int RowIndex = 0;
        Control numberPadControl;
        Control moneyPadControl;
        Control backSpacePadControl;
        private FormMovable formMove;
        public static string productID;
        private Decimal discount;
        private Decimal lpoint;
        private Decimal txtgrossAmount;
        private Decimal txtdiscount;

        private Decimal cardAmount;
        private Decimal totalDiscount;


        //form
        private Rectangle rzForm;
        //panel
        private Rectangle rzpnl_button;
        private Rectangle rzpnl_hold;
        private Rectangle rzpnl_numberKeyPad;
        private Rectangle rzpnl_sortMoney;
        private Rectangle rzpnl_numbers;
        private Rectangle rzpnl_shortcut;
        private Rectangle rzpnl_amount;
        private Rectangle rzpnl_productSearch;
        private Rectangle rzpnl_customerSearch;
        private Rectangle rzpnl_balance;
        private Rectangle rzpnl_bottom;

        private float rzpnl_buttonFontSize;
        private float rzpnl_holdFontSize;
        private float rzpnl_numberKeyPadFontSize;
        private float rzpnl_sortMoneyFontSize;
        private float rzpnl_numbersFontSize;
        private float rzpnl_shortcutFontSize;
        private float rzpnl_amountFontSize;
        private float rzpnl_productSearchFontSize;
        private float rzpnl_customerSearchFontSize;
        private float rzpnl_balanceFontSize;
        private float rzpnl_bottomFontSize;
        //button
        private Rectangle rzbtn_previousBill;
        private Rectangle rzbtn_nextBill;
        private Rectangle rzbtn_holdBill;
        private Rectangle rzbtn_return;
        private Rectangle rzbtn_payout;
        private Rectangle rzbtn_numDouble0;
        private Rectangle rzbtn_num0;
        private Rectangle rzbtn_numDot;
        private Rectangle rzbtn_numDot3;
        private Rectangle rzbtn_num2;
        private Rectangle rzbtn_num1;
        private Rectangle rzbtn_num6;
        private Rectangle rzbtn_num5;
        private Rectangle rzbtn_num4;
        private Rectangle rzbtn_num10;
        private Rectangle rzbtn_num8;
        private Rectangle rzbtn_num7;
        private Rectangle rzbtn_card;
        private Rectangle rzbtn_cash;
        private Rectangle rzbtn_money50;
        private Rectangle rzbtn_money20;
        private Rectangle rzbtn_money10;
        private Rectangle rzbtn_money3;
        private Rectangle rzbtn_money2;
        private Rectangle rzbtn_money1;
        private Rectangle rzbtn_changeQtyDatagridviw;
        private Rectangle rzbtn_loyalityPointUse;
        private Rectangle rzbtn_add;
        private Rectangle rzbtn_productList;
        private Rectangle rzbtn_backSpace;

        private float rzbtn_previousBillFontSize;
        private float rzbtn_nextBillFontSize;
        private float rzbtn_holdBillFontSize;
        private float rzbtn_returnFontSize;
        private float rzbtn_payoutFontSize;
        private float rzbtn_numDouble0FontSize;
        private float rzbtn_num0FontSize;
        private float rzbtn_numDotFontSize;
        private float rzbtn_numDot3FontSize;
        private float rzbtn_num2FontSize;
        private float rzbtn_num1FontSize;
        private float rzbtn_num6FontSize;
        private float rzbtn_num5FontSize;
        private float rzbtn_num4FontSize;
        private float rzbtn_num10FontSize;
        private float rzbtn_num8FontSize;
        private float rzbtn_num7FontSize;
        private float rzbtn_cardFontSize;
        private float rzbtn_cashFontSize;
        private float rzbtn_money50FontSize;
        private float rzbtn_money20FontSize;
        private float rzbtn_money10FontSize;
        private float rzbtn_money3FontSize;
        private float rzbtn_money2FontSize;
        private float rzbtn_money1FontSize;
        private float rzbtn_changeQtyDatagridviwFontSize;
        private float rzbtn_loyalityPointUseFontSize;
        private float rzbtn_addFontSize;
        private float rzbtn_productListFontSize;
        private float rzbtn_backSpaceFontSize;
        //label
        private Rectangle rzlbl_txtbalance;
        private Rectangle rzlbl_txtnetAmount;
        private Rectangle rzlbl_txtloyalityPoint;
        private Rectangle rzlbl_txtdiscount;
        private Rectangle rzlbl_txtgrossAmount;
        private Rectangle rzlbl_txtpoints;
        private Rectangle rzlbl_txtbcn;
        private Rectangle rzlbl_txtpayment;
        private Rectangle rzlbl_txtqty;
        private Rectangle rzlbl_txtuseInBill;
        private Rectangle rzlbl_txtcustomer;
        private Rectangle rzlbl_balance;
        private Rectangle rzlbl_netAmount;
        private Rectangle rzlbl_grossAmount;
        private Rectangle rzlbl_txtholdBill;
        private Rectangle rzlbl_balanceLoyalityPoint;

        private float rzlbl_txtbalanceFontSize;
        private float rzlbl_txtnetAmountFontSize;
        private float rzlbl_txtloyalityPointFontSize;
        private float rzlbl_txtdiscountFontSize;
        private float rzlbl_txtgrossAmountFontSize;
        private float rzlbl_txtpointsFontSize;
        private float rzlbl_txtbcnFontSize;
        private float rzlbl_txtpaymentFontSize;
        private float rzlbl_txtqtyFontSize;
        private float rzlbl_txtuseInBillFontSize;
        private float rzlbl_txtcustomerFontSize;
        private float rzlbl_balanceFontSize;
        private float rzlbl_netAmountFontSize;
        private float rzlbl_grossAmountFontSize;
        private float rzlbl_txtholdBillFontSize;
        private float rzlbl_balanceLoyalityPointFontSize;
        //text
        private Rectangle rztxt_customerID;
        private Rectangle rztxt_customer;
        private Rectangle rztxt_product;
        private Rectangle rztxt_productID;
        private Rectangle rztxt_qty;
        private Rectangle rzntxt_loyalityPoint;
        private Rectangle rzntxt_discount;
        private Rectangle rzntxt_pay;
        private Rectangle rzntxt_useLoyalityPoint;
        
        private float rztxt_customerIDFontSize;
        private float rztxt_customerFontSize;
        private float rztxt_productFontSize;
        private float rztxt_productIDFontSize;
        private float rztxt_qtyFontSize;
        private float rzntxt_loyalityPointFontSize;
        private float rzntxt_discountFontSize;
        private float rzntxt_payFontSize;
        private float rzntxt_useLoyalityPointFontSize;
        //other
        private Rectangle rzcb_drawerOpen;
        private Rectangle rzrb_discountCash;
        private Rectangle rzrb_discountPersentage;
              
        private float rzcb_drawerOpenFontSize;
        private float rzrb_discountCashFontSize;
        private float rzrb_discountPersentageFontSize;

        //private Rectangle rzdataGridView1;
        private Rectangle rzclm_id;
        private Rectangle rzclm_product;
        private Rectangle rzclm_unitPrice;
        private Rectangle rzclm_qty;
        private Rectangle rzclm_price;
        private Rectangle rzclm_remove;

        //private float rzdataGridView1FontSize;
        //private float rzclm_idFontSize;
        //private float rzclm_productFontSize;
        //private float rzclm_unitPriceFontSize;
        //private float rzclm_qtyFontSize;
        //private float rzclm_priceFontSize;
        //private float rzclm_removeFontSize;

        public frmPOS()
        {
            InitializeComponent();
            frmposInstance = this;
            //tbx = txt_productID;

            formMove = new FormMovable(this);
            formMove.SetMovable(pnl_head, lbl_title);
            //lbl_maxStatus.Text = "1";//maximize
        }

        private void frmPOS_Load(object sender, EventArgs e)
        {
            rb_discountCash.Checked=true;

            resize();
        }

        private void resize()
        {
            rzForm = new Rectangle(this.Location, this.Size);

            //navigation elements
            rzpnl_button = new Rectangle(pnl_button.Location, pnl_button.Size);
            rzpnl_hold = new Rectangle(pnl_hold.Location, pnl_hold.Size);
            rzpnl_numberKeyPad = new Rectangle(pnl_numberKeyPad.Location, pnl_numberKeyPad.Size);
            rzpnl_sortMoney = new Rectangle(pnl_sortMoney.Location, pnl_sortMoney.Size);
            rzpnl_numbers = new Rectangle(pnl_numbers.Location, pnl_numbers.Size);
            rzpnl_shortcut = new Rectangle(pnl_shortcut.Location, pnl_shortcut.Size);
            rzpnl_amount = new Rectangle(pnl_amount.Location, pnl_amount.Size);
            rzpnl_productSearch = new Rectangle(pnl_productSearch.Location, pnl_productSearch.Size);
            rzpnl_customerSearch = new Rectangle(pnl_customerSearch.Location, pnl_customerSearch.Size);
            rzpnl_balance = new Rectangle(pnl_balance.Location, pnl_balance.Size);
            rzpnl_bottom = new Rectangle(pnl_bottom.Location, pnl_bottom.Size);

            rzbtn_previousBill = new Rectangle(btn_previousBill.Location, btn_previousBill.Size);
            rzbtn_nextBill = new Rectangle(btn_nextBill.Location, btn_nextBill.Size);
            rzbtn_holdBill = new Rectangle(btn_holdBill.Location, btn_holdBill.Size);
            rzbtn_return = new Rectangle(btn_return.Location, btn_return.Size);
            rzbtn_payout = new Rectangle(btn_payout.Location, btn_payout.Size);
            rzbtn_numDouble0 = new Rectangle(btn_numDouble0.Location, btn_numDouble0.Size);
            rzbtn_num0 = new Rectangle(btn_num0.Location, btn_num0.Size);
            rzbtn_numDot = new Rectangle(btn_numDot.Location, btn_numDot.Size);
            rzbtn_numDot3 = new Rectangle(btn_numDot3.Location, btn_numDot3.Size);
            rzbtn_num2 = new Rectangle(btn_num2.Location, btn_num2.Size);
            rzbtn_num1 = new Rectangle(btn_num1.Location, btn_num1.Size);
            rzbtn_num6 = new Rectangle(btn_num6.Location, btn_num6.Size);
            rzbtn_num5 = new Rectangle(btn_num5.Location, btn_num5.Size);
            rzbtn_num4 = new Rectangle(btn_num4.Location, btn_num4.Size);
            rzbtn_num10 = new Rectangle(btn_num10.Location, btn_num10.Size);
            rzbtn_num8 = new Rectangle(btn_num8.Location, btn_num8.Size);
            rzbtn_num7 = new Rectangle(btn_num7.Location, btn_num7.Size);
            rzbtn_card = new Rectangle(btn_card.Location, btn_card.Size);
            rzbtn_cash = new Rectangle(btn_cash.Location, btn_cash.Size);
            rzbtn_money50 = new Rectangle(btn_money50.Location, btn_money50.Size);
            rzbtn_money20 = new Rectangle(btn_money20.Location, btn_money20.Size);
            rzbtn_money10 = new Rectangle(btn_money10.Location, btn_money10.Size);
            rzbtn_money3 = new Rectangle(btn_money3.Location, btn_money3.Size);
            rzbtn_money2 = new Rectangle(btn_money2.Location, btn_money2.Size);
            rzbtn_money1 = new Rectangle(btn_money1.Location, btn_money1.Size);
            rzbtn_changeQtyDatagridviw = new Rectangle(btn_changeQtyDatagridviw.Location, btn_changeQtyDatagridviw.Size);
            rzbtn_loyalityPointUse = new Rectangle(btn_loyalityPointUse.Location, btn_loyalityPointUse.Size);
            rzbtn_add = new Rectangle(btn_add.Location, btn_add.Size);
            rzbtn_productList = new Rectangle(btn_productList.Location, btn_productList.Size);
            rzbtn_backSpace = new Rectangle(btn_backSpace.Location, btn_backSpace.Size);

            rzlbl_txtbalance = new Rectangle(lbl_txtbalance.Location, lbl_txtbalance.Size);
            rzlbl_txtnetAmount = new Rectangle(lbl_txtnetAmount.Location, lbl_txtnetAmount.Size);
            rzlbl_txtloyalityPoint = new Rectangle(lbl_txtloyalityPoint.Location, lbl_txtloyalityPoint.Size);
            rzlbl_txtdiscount = new Rectangle(lbl_txtdiscount.Location, lbl_txtdiscount.Size);
            rzlbl_txtgrossAmount = new Rectangle(lbl_txtgrossAmount.Location, lbl_txtgrossAmount.Size);
            rzlbl_txtpoints = new Rectangle(lbl_txtpoints.Location, lbl_txtpoints.Size);
            rzlbl_txtbcn = new Rectangle(lbl_txtbcn.Location, lbl_txtbcn.Size);
            rzlbl_txtpayment = new Rectangle(lbl_txtpayment.Location, lbl_txtpayment.Size);
            rzlbl_txtqty = new Rectangle(lbl_txtqty.Location, lbl_txtqty.Size);
            rzlbl_txtuseInBill = new Rectangle(lbl_txtuseInBill.Location, lbl_txtuseInBill.Size);
            rzlbl_txtcustomer = new Rectangle(lbl_txtcustomer.Location, lbl_txtcustomer.Size);
            rzlbl_balance = new Rectangle(lbl_balance.Location, lbl_balance.Size);
            rzlbl_netAmount = new Rectangle(lbl_netAmount.Location, lbl_netAmount.Size);
            rzlbl_grossAmount = new Rectangle(lbl_grossAmount.Location, lbl_grossAmount.Size);
            rzlbl_txtholdBill = new Rectangle(lbl_txtholdBill.Location, lbl_txtholdBill.Size);

            rzlbl_balanceLoyalityPoint = new Rectangle(lbl_balanceLoyalityPoint.Location, lbl_balanceLoyalityPoint.Size);
            rztxt_customerID = new Rectangle(txt_customerID.Location, txt_customerID.Size);
            rztxt_customer = new Rectangle(txt_customer.Location, txt_customer.Size);
            rztxt_product = new Rectangle(txt_product.Location, txt_product.Size);
            rztxt_productID = new Rectangle(txt_productID.Location, txt_productID.Size);
            rztxt_qty = new Rectangle(txt_qty.Location, txt_qty.Size);
            rzntxt_loyalityPoint = new Rectangle(ntxt_loyalityPoint.Location, ntxt_loyalityPoint.Size);
            rzntxt_discount = new Rectangle(ntxt_discount.Location, ntxt_discount.Size);
            rzntxt_pay = new Rectangle(ntxt_pay.Location, ntxt_pay.Size);
            rzntxt_useLoyalityPoint = new Rectangle(ntxt_useLoyalityPoint.Location, ntxt_useLoyalityPoint.Size);

            
            rzcb_drawerOpen = new Rectangle(cb_drawerOpen.Location, cb_drawerOpen.Size);
            rzrb_discountCash = new Rectangle(rb_discountCash.Location, rb_discountCash.Size);
            rzrb_discountPersentage = new Rectangle(rb_discountPersentage.Location, rb_discountPersentage.Size);

            //rzdataGridView1 = new Rectangle(dataGridView1.Location, dataGridView1.Size);
            //rzclm_id = new Rectangle(rzclm_id.Location, rzclm_id.Size);
            //rzclm_product = new Rectangle(rzclm_product.Location, rzclm_product.Size);
            //rzclm_unitPrice = new Rectangle(rzclm_unitPrice.Location, rzclm_unitPrice.Size);
            //rzclm_qty = new Rectangle(rzclm_qty.Location, rzclm_qty.Size);
            //rzclm_price = new Rectangle(rzclm_price.Location, rzclm_price.Size);
            //rzclm_remove = new Rectangle(rzclm_remove.Location, rzclm_remove.Size);

            //navigation elements fonts
            rzpnl_buttonFontSize = pnl_button.Font.Size;
            rzpnl_holdFontSize = pnl_hold.Font.Size;
            rzpnl_numberKeyPadFontSize = pnl_numberKeyPad.Font.Size;
            rzpnl_sortMoneyFontSize = pnl_sortMoney.Font.Size;
            rzpnl_numbersFontSize = pnl_numbers.Font.Size;
            rzpnl_shortcutFontSize = pnl_shortcut.Font.Size;
            rzpnl_amountFontSize = pnl_amount.Font.Size;
            rzpnl_productSearchFontSize = pnl_productSearch.Font.Size;
            rzpnl_customerSearchFontSize = pnl_customerSearch.Font.Size;
            rzpnl_balanceFontSize = pnl_balance.Font.Size;
            rzpnl_bottomFontSize = pnl_bottom.Font.Size;

            rzbtn_previousBillFontSize = btn_previousBill.Font.Size;
            rzbtn_nextBillFontSize = btn_nextBill.Font.Size;
            rzbtn_holdBillFontSize = btn_holdBill.Font.Size;
            rzbtn_returnFontSize = btn_return.Font.Size;
            rzbtn_payoutFontSize = btn_payout.Font.Size;
            rzbtn_numDouble0FontSize = btn_numDouble0.Font.Size;
            rzbtn_num0FontSize = btn_num0.Font.Size;
            rzbtn_numDotFontSize = btn_numDot.Font.Size;
            rzbtn_numDot3FontSize = btn_numDot3.Font.Size;
            rzbtn_num2FontSize = btn_num2.Font.Size;
            rzbtn_num1FontSize = btn_num1.Font.Size;
            rzbtn_num6FontSize = btn_num6.Font.Size;
            rzbtn_num5FontSize = btn_num5.Font.Size;
            rzbtn_num4FontSize = btn_num4.Font.Size;
            rzbtn_num10FontSize = btn_num10.Font.Size;
            rzbtn_num8FontSize = btn_num8.Font.Size;
            rzbtn_num7FontSize = btn_num7.Font.Size;
            rzbtn_cardFontSize = btn_card.Font.Size;
            rzbtn_cashFontSize = btn_cash.Font.Size;
            rzbtn_money50FontSize = btn_money50.Font.Size;
            rzbtn_money20FontSize = btn_money20.Font.Size;
            rzbtn_money10FontSize = btn_money10.Font.Size;
            rzbtn_money3FontSize = btn_money3.Font.Size;
            rzbtn_money2FontSize = btn_money2.Font.Size;
            rzbtn_money1FontSize = btn_money1.Font.Size;
            rzbtn_changeQtyDatagridviwFontSize = btn_changeQtyDatagridviw.Font.Size;
            rzbtn_loyalityPointUseFontSize = btn_loyalityPointUse.Font.Size;
            rzbtn_addFontSize = btn_add.Font.Size;
            rzbtn_productListFontSize = btn_productList.Font.Size;
            rzbtn_backSpaceFontSize = btn_backSpace.Font.Size;

            rzlbl_txtbalanceFontSize = lbl_txtbalance.Font.Size;
            rzlbl_txtnetAmountFontSize = lbl_txtnetAmount.Font.Size;
            rzlbl_txtloyalityPointFontSize = lbl_txtloyalityPoint.Font.Size;
            rzlbl_txtdiscountFontSize = lbl_txtdiscount.Font.Size;
            rzlbl_txtgrossAmountFontSize = lbl_txtgrossAmount.Font.Size;
            rzlbl_txtpointsFontSize = lbl_txtpoints.Font.Size;
            rzlbl_txtbcnFontSize = lbl_txtbcn.Font.Size;
            rzlbl_txtpaymentFontSize = lbl_txtpayment.Font.Size;
            rzlbl_txtqtyFontSize = lbl_txtqty.Font.Size;
            rzlbl_txtuseInBillFontSize = lbl_txtuseInBill.Font.Size;
            rzlbl_txtcustomerFontSize = lbl_txtcustomer.Font.Size;
            rzlbl_balanceFontSize = lbl_balance.Font.Size;
            rzlbl_netAmountFontSize = lbl_netAmount.Font.Size;
            rzlbl_grossAmountFontSize = lbl_grossAmount.Font.Size;
            rzlbl_txtholdBillFontSize = lbl_txtholdBill.Font.Size;

            rzlbl_balanceLoyalityPointFontSize = lbl_balanceLoyalityPoint.Font.Size;
            rztxt_customerIDFontSize = txt_customerID.Font.Size;
            rztxt_customerFontSize = txt_customer.Font.Size;
            rztxt_productFontSize = txt_product.Font.Size;
            rztxt_productIDFontSize = txt_productID.Font.Size;
            rztxt_qtyFontSize = txt_qty.Font.Size;
            rzntxt_loyalityPointFontSize = ntxt_loyalityPoint.Font.Size;
            rzntxt_discountFontSize = ntxt_discount.Font.Size;
            rzntxt_payFontSize = ntxt_pay.Font.Size;
            rzntxt_useLoyalityPointFontSize = ntxt_useLoyalityPoint.Font.Size;

            rzcb_drawerOpenFontSize = cb_drawerOpen.Font.Size;
            rzrb_discountCashFontSize = rb_discountCash.Font.Size;
            rzrb_discountPersentageFontSize = rb_discountPersentage.Font.Size;

            //rzdataGridView1FontSize = dataGridView1.Font.Size;
            //rzclm_idFontSize = clm_id.DefaultCellStyle.Font.Size;
            //rzclm_productFontSize = clm_product.DefaultCellStyle.Font.Size;
            //rzclm_unitPriceFontSize = clm_unitPrice.DefaultCellStyle.Font.Size;
            //rzclm_qtyFontSize = clm_qty.DefaultCellStyle.Font.Size;
            //rzclm_priceFontSize = clm_price.DefaultCellStyle.Font.Size;
            //rzclm_removeFontSize = clm_remove.DefaultCellStyle.Font.Size;
        }

        private void resizeChildrenControls()
        {
            resizeControl(rzpnl_button, pnl_button, rzpnl_buttonFontSize);
            resizeControl(rzpnl_hold, pnl_hold, rzpnl_holdFontSize);
            resizeControl(rzpnl_numberKeyPad, pnl_numberKeyPad, rzpnl_numberKeyPadFontSize);
            resizeControl(rzpnl_sortMoney, pnl_sortMoney, rzpnl_sortMoneyFontSize);
            resizeControl(rzpnl_numbers, pnl_numbers, rzpnl_numbersFontSize);
            resizeControl(rzpnl_shortcut, pnl_shortcut, rzpnl_shortcutFontSize);
            resizeControl(rzpnl_amount, pnl_amount, rzpnl_amountFontSize);
            resizeControl(rzpnl_productSearch, pnl_productSearch, rzpnl_productSearchFontSize);
            resizeControl(rzpnl_customerSearch, pnl_customerSearch, rzpnl_customerSearchFontSize);
            resizeControl(rzpnl_balance, pnl_balance, rzpnl_balanceFontSize);
            resizeControl(rzpnl_bottom, pnl_bottom, rzpnl_bottomFontSize);

            resizeControl(rzbtn_previousBill, btn_previousBill, rzbtn_previousBillFontSize);
            resizeControl(rzbtn_nextBill, btn_nextBill, rzbtn_nextBillFontSize);
            resizeControl(rzbtn_holdBill, btn_holdBill, rzbtn_holdBillFontSize);
            resizeControl(rzbtn_return, btn_return, rzbtn_returnFontSize);
            resizeControl(rzbtn_payout, btn_payout, rzbtn_payoutFontSize);
            resizeControl(rzbtn_numDouble0, btn_numDouble0, rzbtn_numDouble0FontSize);
            resizeControl(rzbtn_num0, btn_num0, rzbtn_num0FontSize);
            resizeControl(rzbtn_numDot, btn_numDot, rzbtn_numDotFontSize);
            resizeControl(rzbtn_numDot3, btn_numDot3, rzbtn_numDot3FontSize);
            resizeControl(rzbtn_num2, btn_num2, rzbtn_num2FontSize);
            resizeControl(rzbtn_num1, btn_num1, rzbtn_num1FontSize);
            resizeControl(rzbtn_num6, btn_num6, rzbtn_num6FontSize);
            resizeControl(rzbtn_num5, btn_num5, rzbtn_num5FontSize);
            resizeControl(rzbtn_num4, btn_num4, rzbtn_num4FontSize);
            resizeControl(rzbtn_num10, btn_num10, rzbtn_num10FontSize);
            resizeControl(rzbtn_num8, btn_num8, rzbtn_num8FontSize);
            resizeControl(rzbtn_num7, btn_num7, rzbtn_num7FontSize);
            resizeControl(rzbtn_card, btn_card, rzbtn_cardFontSize);
            resizeControl(rzbtn_cash, btn_cash, rzbtn_cashFontSize);
            resizeControl(rzbtn_money50, btn_money50, rzbtn_money50FontSize);
            resizeControl(rzbtn_money20, btn_money20, rzbtn_money20FontSize);
            resizeControl(rzbtn_money10, btn_money10, rzbtn_money10FontSize);
            resizeControl(rzbtn_money3, btn_money3, rzbtn_money3FontSize);
            resizeControl(rzbtn_money2, btn_money2, rzbtn_money2FontSize);
            resizeControl(rzbtn_money1, btn_money1, rzbtn_money1FontSize);
            resizeControl(rzbtn_changeQtyDatagridviw, btn_changeQtyDatagridviw, rzbtn_changeQtyDatagridviwFontSize);
            resizeControl(rzbtn_loyalityPointUse, btn_loyalityPointUse, rzbtn_loyalityPointUseFontSize);
            resizeControl(rzbtn_add, btn_add, rzbtn_addFontSize);
            resizeControl(rzbtn_productList, btn_productList, rzbtn_productListFontSize);
            resizeControl(rzbtn_backSpace, btn_backSpace, rzbtn_backSpaceFontSize);

            resizeControl(rzlbl_txtbalance, lbl_txtbalance, rzlbl_txtbalanceFontSize);
            resizeControl(rzlbl_txtnetAmount, lbl_txtnetAmount, rzlbl_txtnetAmountFontSize);
            resizeControl(rzlbl_txtloyalityPoint, lbl_txtloyalityPoint, rzlbl_txtloyalityPointFontSize);
            resizeControl(rzlbl_txtdiscount, lbl_txtdiscount, rzlbl_txtdiscountFontSize);
            resizeControl(rzlbl_txtgrossAmount, lbl_txtgrossAmount, rzlbl_txtgrossAmountFontSize);
            resizeControl(rzlbl_txtpoints, lbl_txtpoints, rzlbl_txtpointsFontSize);
            resizeControl(rzlbl_txtbcn, lbl_txtbcn, rzlbl_txtbcnFontSize);
            resizeControl(rzlbl_txtpayment, lbl_txtpayment, rzlbl_txtpaymentFontSize);
            resizeControl(rzlbl_txtqty, lbl_txtqty, rzlbl_txtqtyFontSize);
            resizeControl(rzlbl_txtuseInBill, lbl_txtuseInBill, rzlbl_txtuseInBillFontSize);
            resizeControl(rzlbl_txtcustomer, lbl_txtcustomer, rzlbl_txtcustomerFontSize);
            resizeControl(rzlbl_balance, lbl_balance, rzlbl_balanceFontSize);
            resizeControl(rzlbl_netAmount, lbl_netAmount, rzlbl_netAmountFontSize);
            resizeControl(rzlbl_grossAmount, lbl_grossAmount, rzlbl_grossAmountFontSize);
            resizeControl(rzlbl_txtholdBill, lbl_txtholdBill, rzlbl_txtholdBillFontSize);

            resizeControl(rzlbl_balanceLoyalityPoint, lbl_balanceLoyalityPoint, rzlbl_balanceLoyalityPointFontSize);
            resizeControl(rztxt_customerID, txt_customerID, rztxt_customerIDFontSize);
            resizeControl(rztxt_customer, txt_customer, rztxt_customerFontSize);
            resizeControl(rztxt_product, txt_product, rztxt_productFontSize);
            resizeControl(rztxt_productID, txt_productID, rztxt_productIDFontSize);
            resizeControl(rztxt_qty, txt_qty, rztxt_qtyFontSize);
            resizeControl(rzntxt_loyalityPoint, ntxt_loyalityPoint, rzntxt_loyalityPointFontSize);
            resizeControl(rzntxt_discount, ntxt_discount, rzntxt_discountFontSize);
            resizeControl(rzntxt_pay, ntxt_pay, rzntxt_payFontSize);
            resizeControl(rzntxt_useLoyalityPoint, ntxt_useLoyalityPoint, rzntxt_useLoyalityPointFontSize);

            resizeControl(rzcb_drawerOpen, cb_drawerOpen, rzcb_drawerOpenFontSize);
            resizeControl(rzrb_discountCash, rb_discountCash, rzrb_discountCashFontSize);
            resizeControl(rzrb_discountPersentage, rb_discountPersentage, rzrb_discountPersentageFontSize);

            //resizeControl(rzdataGridView1, dataGridView1, rzdataGridView1FontSize);
            //resizeControl(rzclm_id, daclm_id, rzclm_idFontSize);
            //resizeControl(rzclm_product, clm_product, rzclm_productFontSize);
            //resizeControl(rzclm_unitPrice, clm_unitPrice, rzclm_unitPriceFontSize);
            //resizeControl(rzclm_qty, clm_qty, rzclm_qtyFontSize);
            //resizeControl(rzclm_price, clm_price, rzclm_priceFontSize);
            //resizeControl(rzclm_remove, clm_remove, rzclm_removeFontSize);
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
       
        private void frmPOS_Resize(object sender, EventArgs e)
        {
            resizeChildrenControls();
        }

        private void btn_payout_Click(object sender, EventArgs e)
        {
            frmPayout frmPayout = new frmPayout();
            frmPayout.ShowDialog();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            ProductReturn.showOnViewForm();
        }

        private void txt_product_Click(object sender, EventArgs e)
        {
            Product.showOnViewFormProduct(txt_product, txt_productID);
            txt_product.Clear();
        }

        
        private void txt_customerID_TextChanged(object sender, EventArgs e)
        {
            String loyalityPointCodeQuery = "SELECT " +
                    "IFNULL(SUM(points),0) AS point " +
                    "FROM loyality_points " +
                    "WHERE customer_id = '" + txt_customerID.Text + "' ";
            String loyalityPoint = DBTransactionService.getScalerData(loyalityPointCodeQuery);
            
            lbl_balanceLoyalityPoint.Text = loyalityPoint;
            lpoint = Convert.ToDecimal(loyalityPoint);
        }

        public decimal calculateTotalBill(DataGridView dataGridView1)
        {
            Decimal TotalBill = 0;

            foreach (DataGridViewRow Row in dataGridView1.Rows)
            {
                Decimal ProductTotal = Convert.ToDecimal(Row.Cells["clm_total"].Value);

                TotalBill = TotalBill + ProductTotal;
            }

            return TotalBill;
        }

        public void autoIncrementQuantity()
        {
            Int32 Quantity = Convert.ToInt32(dataGridView2.Rows[RowIndex].Cells["clm_qty"].Value);
            Decimal Price = Convert.ToInt32(dataGridView2.Rows[RowIndex].Cells["clm_price"].Value);

            Quantity++;

            Decimal TotalPrice = Convert.ToDecimal(Quantity) * Price;

            dataGridView2.Rows[RowIndex].Cells["clm_qty"].Value = Quantity;
            dataGridView2.Rows[RowIndex].Cells["clm_total"].Value = TotalPrice;

            txt_productID.Clear();
            txt_product.Clear();

            lbl_grossAmount.Text = calculateTotalBill(dataGridView2).ToString();
        }

        private void txt_productID_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_productID.Text))
            {
                txt_productID.Clear();
                txt_product.Text = " ";
            }
            else
            {
                Product x = Product.getOneProduct(Int32.Parse(txt_productID.Text));
                String productID = Convert.ToString(x.Id);
               
                if (CheckProductAlreadyAdded(productID))
                {
                    autoIncrementQuantity();
                }
                else
                {
                    Decimal TotalPrice = x.SalePrice * 1;

                    dataGridView2.Rows.Add(productID, x.ProductName, x.SalePrice, 1, TotalPrice);

                    txt_productID.Clear();
                    txt_product.Clear();
                    //dataGridView1.Rows.Add(It_ID, ProductDetails.Name, ProductDetails.Price, 1, ProductDetails.Price * 1);

                    lbl_grossAmount.Text = calculateTotalBill(dataGridView2).ToString();
                }
            } 
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_qty.Text = Convert.ToString(dataGridView2.Rows[RowIndex].Cells["clm_qty"].Value);
            if (e.RowIndex >= 0)
            {
                if (dataGridView2.Columns[e.ColumnIndex].Name == "clm_remove")
                {
                    if (MessageBox.Show("Are You Sure You Want to Remove this Product", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        decimal DeletedProductTotal = Convert.ToDecimal(dataGridView2.Rows[e.RowIndex].Cells["clm_total"].Value);

                        decimal CurrentTotalBill = Convert.ToDecimal(lbl_grossAmount.Text);

                        CurrentTotalBill = CurrentTotalBill - DeletedProductTotal;

                        dataGridView2.Rows.RemoveAt(e.RowIndex);
                        lbl_grossAmount.Text = CurrentTotalBill.ToString();

                    }
                }
            }
        }

        public bool CheckProductAlreadyAdded(string It_ID)
        {
            foreach (DataGridViewRow Row in dataGridView2.Rows)
            {
                if (Convert.ToString(Row.Cells["clm_id"].Value) == It_ID)
                {
                    RowIndex = Row.Index;
                    return true;
                }
            }
            return false;
        }

        private void btn_changeQtyDatagridviw_Click(object sender, EventArgs e)
        {
            Int32 qty = Int32.Parse(txt_qty.Text) - 1;
            dataGridView2.Rows[RowIndex].Cells["clm_qty"].Value = qty;

            autoIncrementQuantity();

            txt_qty.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_currentDateTime.Text = DateTime.Now.ToString("dddd, dd-MMMM-yyyy  HH:mm:ss tt");
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_loyalityPointUse_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(ntxt_useLoyalityPoint.Text) > lpoint)
            {
                MessageBox.Show("Out of Value");
                ntxt_useLoyalityPoint.Text = "0";
            }
            ntxt_loyalityPoint.Value = Convert.ToDecimal(ntxt_useLoyalityPoint.Text);
        }

        private void btn_productList_Click_1(object sender, EventArgs e)
        {
            frmProductList frmProductList = new frmProductList();
            frmProductList.Show();
        }

        private void txt_customer_Click(object sender, EventArgs e)
        {
            Customer.showOnViewFormCustomer(txt_customer, txt_customerID);
        }

        private void calculationNetAmount()
        {
            Decimal minusTotal = ntxt_loyalityPoint.Value + discount;
            Decimal netAmount = Convert.ToDecimal(lbl_grossAmount.Text) - minusTotal;
            lbl_netAmount.Text = netAmount.ToString();
        }
        private void lbl_grossAmount_TextChanged(object sender, EventArgs e)
        {
            calculationNetAmount();
            calculateBalance();
            //Decimal minusTotal = ntxt_loyalityPoint.Value + discount;
            //Decimal netAmount = Convert.ToDecimal(lbl_grossAmount.Text) - minusTotal;
            //lbl_netAmount.Text = Math.Round(netAmount, 2).ToString();
        }

        private void rb_discountCash_CheckedChanged(object sender, EventArgs e)
        {
            txtgrossAmount = Convert.ToDecimal(lbl_grossAmount.Text);

            if(String.IsNullOrEmpty(txtdiscount.ToString()))
            {
                txtdiscount = 0;

            }
            else
            {
                txtdiscount = Convert.ToDecimal(ntxt_discount.Text);
            }
           

            if (rb_discountCash.Checked == true)
            {
                lbl_discountStatus.Text = "0";
                if (txtdiscount <= 0)
                {
                    //
                }
                else
                {
                    lbl_discountStatus.Text = "0";

                    Decimal calDiscount = txtgrossAmount * (txtdiscount / (decimal)100);

                    ntxt_discount.Text = calDiscount.ToString();//125
                }
            }
        }

        private void rb_discountPersentage_CheckedChanged(object sender, EventArgs e)
        {
            txtgrossAmount = Convert.ToDecimal(lbl_grossAmount.Text);
            txtdiscount = Convert.ToDecimal(ntxt_discount.Text);

            if (rb_discountPersentage.Checked == true)
            {
                lbl_discountStatus.Text = "1";
                if (txtdiscount <= 0)
                { 
                    //
                }
                else
                {
                    Decimal calDiscount = (txtdiscount / txtgrossAmount) * (decimal)100;
                    ntxt_discount.Text = calDiscount.ToString();//50
                }
            }
        }

        private void ntxt_loyalityPoint_ValueChanged(object sender, EventArgs e)
        {
            calculationNetAmount();
        }

        private void saveDataToSale()
        {
            string numbers = "1234567890";
            string characters = numbers;
            int length = 10;
            string id = string.Empty;

            for (int i = 0; i < length; i++)
            {
                string character = string.Empty;
                do
                {
                    int index = new Random().Next(0, characters.Length);
                    character = characters.ToCharArray()[index].ToString();
                } while (id.IndexOf(character) != -1);
                id += character;
            }
            String invoiceNumber = "INV" + id + DateTime.UtcNow.ToString("yyMMdd");

            Branch branch = new Branch();
            branch.Id = 1;
            User user = new User();
            user.Id = 1;

            //sale
            Sale sale = new Sale();
            sale.Branch = branch;
            sale.Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");//DateTime.UtcNow.ToString("yyyy-MM-dd  H:m:ss");
            sale.InvoiceNumber = invoiceNumber;
            sale.TotalAmount = Convert.ToDecimal(lbl_netAmount.Text);
            sale.TotalDiscount = totalDiscount;
            sale.Status = 1;
            sale.User = user;
            ReturnResult result = Sale.store(sale);
        }

        private void saveDataToSaleDetail()
        {
            String lastSaleIDQuery = "SELECT MAX(id) FROM sales";
            String lastSaleID = DBTransactionService.getScalerData(lastSaleIDQuery);

            //sale Detail
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                try
                {
                    Int32 saleId = Convert.ToInt32(lastSaleID);
                    Int32 productId = Convert.ToInt32(row.Cells["clm_id"].Value);
                    Int32 qty = Convert.ToInt32(row.Cells["clm_qty"].Value);
                    Decimal amount = Convert.ToDecimal(row.Cells["clm_total"].Value);

                    Sale sale = new Sale();
                    sale.Id = saleId;
                    Product product = new Product();
                    product.Id = productId;

                    SalesDetail salesDetail = new SalesDetail();
                    salesDetail.Sale = sale;
                    salesDetail.Product = product;
                    salesDetail.Qty = qty;
                    salesDetail.Amount = amount;
                    ReturnResult result2 = SalesDetail.store(salesDetail);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void saveToPaymentOptionCash()
        {
            String lastSaleIDQuery = "SELECT MAX(id) FROM sales";
            String lastSaleID = DBTransactionService.getScalerData(lastSaleIDQuery);

            //sale Detail
            Sale sale = new Sale();
            sale.Id = Convert.ToInt32(lastSaleID);
            PaymentMethod paymentMethod = new PaymentMethod();
            paymentMethod.Id = 1;

            PaymentOption paymentOption = new PaymentOption();
            paymentOption.Sale = sale;
            paymentOption.PaymentMethod = paymentMethod;
            paymentOption.PaidAmount = Convert.ToDecimal(ntxt_pay.Text);
            ReturnResult result3 = PaymentOption.store(paymentOption);
        }

        private void saveToPaymentOptionCard()
        {
            String lastSaleIDQuery = "SELECT MAX(id) FROM sales";
            String lastSaleID = DBTransactionService.getScalerData(lastSaleIDQuery);

            //sale Detail
            Sale sale = new Sale();
            sale.Id = Convert.ToInt32(lastSaleID);
            PaymentMethod paymentMethod = new PaymentMethod();
            paymentMethod.Id = 2;

            PaymentOption paymentOption = new PaymentOption();
            paymentOption.Sale = sale;
            paymentOption.PaymentMethod = paymentMethod;
            paymentOption.PaidAmount = cardAmount;
            ReturnResult result3 = PaymentOption.store(paymentOption);
        }

        private void btn_cash_Click(object sender, EventArgs e)
        {
            lbl_cashStatus.Text = "1";

            saveDataToSale();
            saveDataToSaleDetail();
            saveToPaymentOptionCash();
        }

        private void btn_card_Click(object sender, EventArgs e)
        {
            lbl_cardStatus.Text = "1";

            saveDataToSale();
            saveDataToSaleDetail();

            if (lbl_cashStatus.Text!="0" && lbl_cardStatus.Text!="0")
            {
                saveToPaymentOptionCash();
                saveToPaymentOptionCard();
            }
            else if (lbl_cashStatus.Text == "0" && lbl_cardStatus.Text != "0")
            {
                saveToPaymentOptionCard();
            }
            else
            {
                //
            }
        }

        private void ntxt_discount_TextChanged(object sender, EventArgs e)
        {
            var box = (TextBox)sender;
            if (box.Text.StartsWith(".")) box.Text = "";

            calculateDiscount();

            if (String.IsNullOrEmpty(lbl_grossAmount.Text))
            {
                lbl_grossAmount.Text = "0";
            }
        }

        private void ntxt_discount_KeyUp(object sender, KeyEventArgs e)
        {
            calculateDiscount();

            if (String.IsNullOrEmpty(lbl_grossAmount.Text))
            {
                lbl_grossAmount.Text = "0";
            }
        }

        private void calculateDiscount()
        {
            if (String.IsNullOrEmpty(ntxt_discount.Text))
            {
                //
            }
            else
            {
                if (rb_discountCash.Checked == true)
                {
                    discount = Convert.ToDecimal(ntxt_discount.Text);
                }
                else if (rb_discountPersentage.Checked == true)
                {
                    discount = txtgrossAmount * (Convert.ToDecimal(ntxt_discount.Text) / (decimal)100);
                }

                Decimal minusTotal = ntxt_loyalityPoint.Value + discount;
                Decimal netAmount = Convert.ToDecimal(lbl_grossAmount.Text) - minusTotal;
                lbl_netAmount.Text = netAmount.ToString();
            }
        }

        private void calculateBalance()
        {
            if (String.IsNullOrEmpty(ntxt_pay.Text))
            {
                //
            }
            else
            {
                Decimal balance = Convert.ToDecimal(ntxt_pay.Text) - Convert.ToDecimal(lbl_netAmount.Text);
                lbl_balance.Text = Math.Round(balance, 2).ToString();

                if (balance < 0)
                {
                    lbl_cashStatus.Text = "1";
                    lbl_cardStatus.Text = "1";
                    btn_cash.Enabled = false;

                    cardAmount = Convert.ToDecimal(lbl_netAmount.Text) - Convert.ToDecimal(ntxt_pay.Text);
                }
                else if ((balance >= 0))
                {
                    lbl_cardStatus.Text = "0";
                    lbl_cashStatus.Text = "0";
                    btn_cash.Enabled = true;

                    cardAmount = 0;
                }
            }
        }
        
        private void ntxt_pay_TextChanged(object sender, EventArgs e)
        {
            var box = (TextBox)sender;
            if (box.Text.StartsWith(".")) box.Text = "0";

            calculateBalance();

            if (String.IsNullOrEmpty(lbl_netAmount.Text))
            {
                lbl_netAmount.Text = "0";
            }
        }

        private void ntxt_pay_KeyUp(object sender, KeyEventArgs e)
        {
            calculateBalance();

            if (String.IsNullOrEmpty(lbl_netAmount.Text))
            {
                lbl_netAmount.Text = "0";
            }
        }

        private void lbl_netAmount_TextChanged(object sender, EventArgs e)
        {
            calculateBalance();
        }

        private void btn_num0_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            numberPadControl.Focus();
            SendKeys.Send(btn.Text);
        }

        private void btn_money1_Click(object sender, EventArgs e)
        {
            ntxt_pay.Clear();
            Button btn = (Button)sender;
            moneyPadControl.Focus();
            SendKeys.Send(btn.Text);
        }

        private void btn_backSpace_Click(object sender, EventArgs e)
        {
            backSpacePadControl.Focus();
            SendKeys.Send("{BACKSPACE}");
        }

        private void txt_qty_Enter(object sender, EventArgs e)
        {
            numberPadControl = (Control)sender;
            backSpacePadControl = (Control)sender;
        }

        private void ntxt_pay_Enter(object sender, EventArgs e)
        {
            numberPadControl = (Control)sender;
            moneyPadControl = (Control)sender;
            backSpacePadControl = (Control)sender;
        }

        private void ntxt_pay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_qty_TextChanged(object sender, EventArgs e)
        {
            var box = (TextBox)sender;
            if (box.Text.StartsWith(".")) box.Text = "";
            if (box.Text.StartsWith("0")) box.Text = "";
        }

        private void txt_qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ntxt_useLoyalityPoint_TextChanged(object sender, EventArgs e)
        {
            var box = (TextBox)sender;
            if (box.Text.StartsWith(".")) box.Text = "0";
        }

        private void ntxt_useLoyalityPoint_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }       
    }
}
