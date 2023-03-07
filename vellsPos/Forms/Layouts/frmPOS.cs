using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using vellsPos.Entities.Layouts;
using vellsPos.Entities.Masters;
using vellsPos.Properties;
using vellsPos.Services;

namespace vellsPos.Forms.Layouts
{
    public partial class frmPOS : Form
    {
        public static frmPOS frmposInstance;
        public TextBox tbx;
        private List<ListItem> categories = new List<ListItem>();
        public static string categoryID = "";
        public int RowIndex = 0;
        private FormMovable formMove;
        public static string productID;

        public frmPOS()
        {
            InitializeComponent();
            frmposInstance = this;
            tbx = txt_productID;

            formMove = new FormMovable(this);
            formMove.SetMovable(pnl_head, lbl_title);
            lbl_maxStatus.Text = "1";//maximize
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

        private void frmPOS_Load(object sender, EventArgs e)
        {          
            showCategory();
        }

        private void showCategory()
        {
            String catId;
            String catName;
            int pointX1 = 35;
            int pointY1 = 50;
            gb_category.Controls.Clear();

            String categoryQuery = "SELECT id as value,category_name as text FROM categories ";
            categories = DBTransactionService.getDataAsListItems(categoryQuery);

            foreach (ListItem catList in categories)
            {
                catId = catList.Value;
                catName = catList.Text;

                Button btnCategory = new Button();
                btnCategory.Text = catName.ToString();
                btnCategory.Tag = catId;
                btnCategory.BackColor = Color.LightPink;
                btnCategory.Size = new System.Drawing.Size(196, 38);
                btnCategory.ForeColor = Color.Black;
                //btnCategory.Font = new Font(btnCategory.Font.FontFamily,18);
                btnCategory.Location = new Point(pointX1, pointY1);
                gb_category.Controls.Add(btnCategory);
                gb_category.Show();
                pointY1 += 45;
                btnCategory.Click += BtnCategory_Click;
            }
        }

        private void BtnCategory_Click(object? sender, EventArgs e)
        {
            Button btnCategory = (Button)sender;
            String category_Id = Convert.ToString(btnCategory.Tag);

            categoryID = category_Id;

            frmProductList frm2 = new frmProductList(this);
            frm2.ShowDialog();
            
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void txt_customer_Click(object sender, EventArgs e)
        {
            Customer.showOnViewFormCustomer(txt_customer, txt_customerID);
        }

        private void txt_customerID_TextChanged(object sender, EventArgs e)
        {
            String loyalityPointCodeQuery = "SELECT " +
                    "IFNULL(SUM(points),0) AS point " +
                    "FROM loyality_points " +
                    "WHERE customer_id = '" + txt_customerID.Text + "' ";
            String loyalityPoint = DBTransactionService.getScalerData(loyalityPointCodeQuery);
            Console.WriteLine(loyalityPointCodeQuery);
            Console.WriteLine(loyalityPoint);
            txt_balanceLoyalityPoint.Text = loyalityPoint;
        }

        private void txt_product_Click(object sender, EventArgs e)
        {
            Product.showOnViewFormProduct(txt_product,txt_productID);
            txt_product.Clear();
        }

        public decimal calculateTotalBill(DataGridView dataGridView1)
        {
            decimal TotalBill = 0;

            foreach (DataGridViewRow Row in dataGridView1.Rows)
            {
                decimal ProductTotal = Convert.ToDecimal(Row.Cells["clm_price"].Value);

                TotalBill = TotalBill + ProductTotal;
            }

            return TotalBill;
        }

        public void autoIncrementQuantity()
        {
            int Quantity = Convert.ToInt32(dataGridView1.Rows[RowIndex].Cells["clm_qty"].Value);
            decimal Price = Convert.ToInt32(dataGridView1.Rows[RowIndex].Cells["clm_unitPrice"].Value);

            Quantity++;

            double TotalPrice = Convert.ToDouble(Quantity * Price);

            dataGridView1.Rows[RowIndex].Cells["clm_qty"].Value = Quantity;
            dataGridView1.Rows[RowIndex].Cells["clm_price"].Value = TotalPrice;
            txt_productID.Clear();
            txt_product.Clear();
            txt_grossAmount.Text = calculateTotalBill(dataGridView1).ToString();


        }

        private void txt_productID_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_productID.Text))
            {
                //
                txt_productID.Clear();
                txt_product.Text = " ";
            }
            else
            {
                Product x = Product.getOneProduct(Int32.Parse(txt_productID.Text));
                String productID = Convert.ToString(x.Id);
                //dvParam.TitleList = new List<string>() { "", "Customer Number", "Customer", "NIC", "Gender", "Date of Birth", "Phone Number", "Email" }; //Column titles
                if (CheckProductAlreadyAdded(productID))
                {
                    autoIncrementQuantity();
                }
                else
                {
                    dataGridView1.Rows.Add(productID, x.ProductName, x.SalePrice, 1, x.SalePrice);
                    txt_productID.Clear();
                    txt_product.Clear();
                    //dataGridView1.Rows.Add(It_ID, ProductDetails.Name, ProductDetails.Price, 1, ProductDetails.Price * 1);

                    txt_grossAmount.Text = calculateTotalBill(dataGridView1).ToString();
                }
            } 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_qty.Text = Convert.ToString(dataGridView1.Rows[RowIndex].Cells["clm_qty"].Value);
            if (e.RowIndex >= 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "clm_remove")
                {
                    if (MessageBox.Show("Are You Sure You Want to Remove this Product", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        decimal DeletedProductTotal = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["clm_price"].Value);

                        decimal CurrentTotalBill = Convert.ToDecimal(txt_grossAmount.Text);

                        CurrentTotalBill = CurrentTotalBill - DeletedProductTotal;

                        dataGridView1.Rows.RemoveAt(e.RowIndex);
                        txt_grossAmount.Text = CurrentTotalBill.ToString();

                    }
                }
            }
        }

        public bool CheckProductAlreadyAdded(string It_ID)
        {
            foreach (DataGridViewRow Row in dataGridView1.Rows)
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
            dataGridView1.Rows[RowIndex].Cells["clm_qty"].Value = qty;
            autoIncrementQuantity();
            txt_qty.Clear();
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

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_currentDateTime.Text = DateTime.Now.ToString("dddd, dd-MMMM-yyyy  HH:mm:ss tt");
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPOS_Activated(object sender, EventArgs e)
        {

        }

        private void btn_loyalityPointUse_Click(object sender, EventArgs e)
        {   
            
            txt_loyalityPoint.Text = ntxt_useLoyalityPoint.Text;
        }

        private void ntxt_useLoyalityPoint_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
