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
    public partial class frmProductList : Form
    {
        //frmPOS formPOS;
        private List<ListItem> categories = new List<ListItem>();
        private List<ListItem> subCategories = new List<ListItem>();
        private List<ListItem> subCoategories = new List<ListItem>();
        private List<ListItem> products = new List<ListItem>();
        public static string productID = "";
        public static string productIDStatus = "";
        private FormMovable formMove;

        //public frmProductList(frmPOS frmPos)
        //{
        //    InitializeComponent();
        //    formPOS = frmPos;

        //    formMove = new FormMovable(this);
        //    formMove.SetMovable(pnl_head, lbl_title);
        //}

        public frmProductList()
        {
            InitializeComponent();

            formMove = new FormMovable(this);
            formMove.SetMovable(pnl_head, lbl_title);
        }

        private void frmProductList_Load(object sender, EventArgs e)
        {
            showCategory();
            //showSubCategory(frmPOS.categoryID);
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
            String subCatId;
            String subCatName;
            int pointX1 = 5;
            int pointY1 = 50;
            gb_subCategory.Controls.Clear();
            gb_subCoCategory.Controls.Clear();
            gb_product.Controls.Clear();

            Button btnCategory = (Button)sender;
            String categoryId = Convert.ToString(btnCategory.Tag);

            String subCategoryQuery = "SELECT sc.id as value, sc.sub_category_name as text " +
                "FROM sub_categories sc " +
                "LEFT JOIN categories c ON sc.category_id=c.id " +
                "WHERE c.id='" + categoryId + "' ";
            subCategories = DBTransactionService.getDataAsListItems(subCategoryQuery);

            foreach (ListItem subCatList in subCategories)
            {
                subCatId = subCatList.Value;
                subCatName = subCatList.Text;

                Button btnSubCategory = new Button();
                btnSubCategory.Text = subCatName.ToString();
                btnSubCategory.Tag = subCatId;
                btnSubCategory.BackColor = Color.LightBlue;
                btnSubCategory.Size = new System.Drawing.Size(134, 29);
                btnSubCategory.ForeColor = Color.Red;
                btnSubCategory.Location = new Point(pointX1, pointY1);
                gb_subCategory.Controls.Add(btnSubCategory);
                gb_subCategory.Show();
                pointY1 += 32;
                btnSubCategory.Click += BtnSubCategory_Click;
            }
        }

        private void BtnSubCategory_Click(object? sender, EventArgs e)
        {
            String subCoCatId;
            String subCoCatName;
            int pointX1 = 5;
            int pointY1 = 50;
            gb_subCoCategory.Controls.Clear();
            gb_product.Controls.Clear();

            Button btnsubCategory = (Button)sender;

            String subCategoryId = Convert.ToString(btnsubCategory.Tag);

            String subCoCategoryQuery = "SELECT scc.id as value, scc.sub_co_category_name as text " +
                "FROM sub_co_categories scc " +
                "LEFT JOIN sub_categories sc ON scc.sub_category_id=sc.id " +
                "LEFT JOIN categories c ON sc.category_id=c.id " +
                "WHERE sc.id='" + subCategoryId + "' ";
            subCoategories = DBTransactionService.getDataAsListItems(subCoCategoryQuery);

            foreach (ListItem subCoCatList in subCoategories)
            {
                subCoCatId = subCoCatList.Value;
                subCoCatName = subCoCatList.Text;

                Button btnSubCoCategory = new Button();
                btnSubCoCategory.Text = subCoCatName.ToString();
                btnSubCoCategory.Tag = subCoCatId;
                btnSubCoCategory.BackColor = Color.LightYellow;
                btnSubCoCategory.Size = new System.Drawing.Size(134, 29);
                btnSubCoCategory.ForeColor = Color.Red;
                btnSubCoCategory.Location = new Point(pointX1, pointY1);
                gb_subCoCategory.Controls.Add(btnSubCoCategory);
                gb_subCoCategory.Show();
                pointY1 += 32;
                btnSubCoCategory.Click += BtnSubCoCategory_Click; ;
            }
        }

        private void BtnSubCoCategory_Click(object? sender, EventArgs e)
        {
            String productId;
            String productName;
            int pointX1 = 5;
            int pointY1 = 50;
            gb_product.Controls.Clear();

            Button btnSubCoCategory = (Button)sender;

            String subCoCategoryId = Convert.ToString(btnSubCoCategory.Tag);

            String productQuery = "SELECT p.id as value, p.product_name as text " +
                 "FROM products p " +
                  "LEFT JOIN sub_co_categories scc ON p.sub_co_category_id=scc.id " +
                 "LEFT JOIN sub_categories sc ON scc.sub_category_id=sc.id " +
                 "LEFT JOIN categories c ON sc.category_id=c.id " +
                 "WHERE scc.id='" + subCoCategoryId + "' ";
            products = DBTransactionService.getDataAsListItems(productQuery);

            foreach (ListItem productList in products)
            {
                productId = productList.Value;
                productName = productList.Text;

                Button btnProduct = new Button();
                btnProduct.Text = productName.ToString();
                btnProduct.Tag = productId;
                btnProduct.BackColor = Color.LightGreen;
                btnProduct.Size = new System.Drawing.Size(134, 29);
                btnProduct.ForeColor = Color.Red;
                btnProduct.Location = new Point(pointX1, pointY1);
                gb_product.Controls.Add(btnProduct);
                gb_product.Show();
                pointY1 += 32;
                btnProduct.Click += BtnProduct_Click;
            }
        }

        private void BtnProduct_Click(object? sender, EventArgs e)
        {
            Button btnProduct = (Button)sender;
            String product_Id = Convert.ToString(btnProduct.Tag);
            productID = product_Id;

            //frmPOS.frmposInstance.tbx.Text = product_Id;
            this.Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
