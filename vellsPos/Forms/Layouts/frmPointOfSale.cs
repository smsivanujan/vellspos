using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using vellsPos.Entities.Layouts;
using vellsPos.Entities.Masters;
using vellsPos.Services;

namespace vellsPos.Forms.Layouts
{
    public partial class frmPointOfSale : Form
    {
        private List<ListItem> categories = new List<ListItem>();
        private List<ListItem> subCategories = new List<ListItem>();
        private List<ListItem> subCoategories = new List<ListItem>();
        private List<ListItem> products = new List<ListItem>();
        private FormMovable formMove;

        public frmPointOfSale()
        {
            InitializeComponent();

            formMove = new FormMovable(this);
            formMove.SetMovable(pnl_head, lbl_title);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmPointOfSale_Load(object sender, EventArgs e)
        {
            showCategory();
        }

        private void showCategory()
        {
            String catId;
            String catName;
            int pointX = 5;
            int pointY = 5;
            int pointX1 = 15;
            int pointY1 = 10;
            gb_category.Controls.Clear();
            gb_subCategory.Controls.Clear();
            gb_subCoCategory.Controls.Clear();
            gb_product.Controls.Clear();

            String categoryQuery = "SELECT id as value,category_name as text FROM categories ";
            categories = DBTransactionService.getDataAsListItems(categoryQuery);
            //Category category = Category.getMultipleCategory();

            foreach(ListItem catList in categories)
            {
                catId = catList.Value;
                catName = catList.Text;

                Button btnCategory = new Button();
                btnCategory.Text = catName.ToString();
                btnCategory.Tag= catId;
                btnCategory.Size = new System.Drawing.Size(134, 29);
                btnCategory.ForeColor = Color.Red;
                btnCategory.Location = new Point(pointX1, pointY1);
                gb_category.Controls.Add(btnCategory);
                gb_category.Show();
                pointY1 += 32;
                btnCategory.Click += BtnCategory_Click;
                ////Label b = new Label();
                ////b.Text = (catName).ToString();
                ////b.Location = new Point(pointX1, pointY1);
                ////b.Size = new Size(134, 29);
                //b.BackColor = Color.Gainsboro;
                //b.Font = new Font("Segoe UI Semibold", 10.2f, FontStyle.Bold);
                //pnl_category.Controls.Add(b);
                //pnl_category.Show();
                ////pointY1 += 32;
            }
        }

        private void BtnCategory_Click(object? sender, EventArgs e)
        {
            String subCatId;
            String subCatName;
            int pointX = 5;
            int pointY = 5;
            int pointX1 = 15;
            int pointY1 = 10;
            gb_subCategory.Controls.Clear();
            gb_subCoCategory.Controls.Clear();
            gb_product.Controls.Clear();

            Button btnCategory = (Button)sender;

            String categoryId = Convert.ToString(btnCategory.Tag);

            String subCategoryQuery = "SELECT sc.id as value, sc.sub_category_name as text " +
                "FROM sub_categories sc " +
                "LEFT JOIN categories c ON sc.category_id=c.id " +
                "WHERE c.id='"+ categoryId + "' ";
            subCategories = DBTransactionService.getDataAsListItems(subCategoryQuery);

            foreach (ListItem subCatList in subCategories)
            {
                subCatId = subCatList.Value;
                subCatName = subCatList.Text;

                Button btnSubCategory = new Button();
                btnSubCategory.Text = subCatName.ToString();
                btnSubCategory.Tag = subCatId;
                btnSubCategory.Size = new System.Drawing.Size(134, 29);
                btnSubCategory.ForeColor = Color.Red;
                btnSubCategory.Location = new Point(pointX1, pointY1);
                gb_subCategory.Controls.Add(btnSubCategory);
                gb_subCategory.Show();
                pointY1 += 32;
                btnSubCategory.Click += BtnSubCategory_Click;
                ////Label b = new Label();
                ////b.Text = (catName).ToString();
                ////b.Location = new Point(pointX1, pointY1);
                ////b.Size = new Size(134, 29);
                //b.BackColor = Color.Gainsboro;
                //b.Font = new Font("Segoe UI Semibold", 10.2f, FontStyle.Bold);
                //pnl_category.Controls.Add(b);
                //pnl_category.Show();
                ////pointY1 += 32;
            }
        }

        private void BtnSubCategory_Click(object? sender, EventArgs e)
        {
            String subCoCatId;
            String subCoCatName;
            int pointX = 5;
            int pointY = 5;
            int pointX1 = 15;
            int pointY1 = 10;
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
                btnSubCoCategory.Size = new System.Drawing.Size(134, 29);
                btnSubCoCategory.ForeColor = Color.Red;
                btnSubCoCategory.Location = new Point(pointX1, pointY1);
                gb_subCoCategory.Controls.Add(btnSubCoCategory);
                gb_subCoCategory.Show();
                pointY1 += 32;
                btnSubCoCategory.Click += BtnSubCoCategory_Click;
                ////Label b = new Label();
                ////b.Text = (catName).ToString();
                ////b.Location = new Point(pointX1, pointY1);
                ////b.Size = new Size(134, 29);
                //b.BackColor = Color.Gainsboro;
                //b.Font = new Font("Segoe UI Semibold", 10.2f, FontStyle.Bold);
                //pnl_category.Controls.Add(b);
                //pnl_category.Show();
                ////pointY1 += 32;
            }
        }

        private void BtnSubCoCategory_Click(object? sender, EventArgs e)
        {
            String productId;
            String productName;
            int pointX = 5;
            int pointY = 5;
            int pointX1 = 15;
            int pointY1 = 10;
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
                btnProduct.Size = new System.Drawing.Size(134, 29);
                btnProduct.ForeColor = Color.Red;
                btnProduct.Location = new Point(pointX1, pointY1);
                gb_product.Controls.Add(btnProduct);
                gb_product.Show();
                pointY1 += 32;
                btnProduct.Click += BtnProduct_Click;
                ////Label b = new Label();
                ////b.Text = (catName).ToString();
                ////b.Location = new Point(pointX1, pointY1);
                ////b.Size = new Size(134, 29);
                //b.BackColor = Color.Gainsboro;
                //b.Font = new Font("Segoe UI Semibold", 10.2f, FontStyle.Bold);
                //pnl_category.Controls.Add(b);
                //pnl_category.Show();
                ////pointY1 += 32;
            }
        }

        private void BtnProduct_Click(object? sender, EventArgs e)
        {
            //
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void currentDateTimeClock_Tick(object sender, EventArgs e)
        {
            lbl_currentDateTime.Text= DateTime.Now.ToString("dddd, dd-MMMM-yyyy  HH:mm:ss tt");
        }

        private void btn_payout_Click(object sender, EventArgs e)
        {
            frmPayout frmPayout= new frmPayout();
            frmPayout.ShowDialog();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            ProductReturn.showOnViewForm();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        }

        private void pnl_search_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
