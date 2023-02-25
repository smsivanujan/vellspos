using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vellsPos.Forms.Layouts;
using vellsPos.Services;

namespace vellsPos.Entities.Masters
{
    internal class Product
    {
        private Int32 id;
        private String productNumber;
        private String productName;
        private SubCoCategory subCoCategory;
        private Decimal salePrice;
        private String addedDate;
        private String image;
        private String description;
        private Int32 isBarcode;
        private Int32 ageVerify;
        private Int32 status;
        private Int32 temp;
        private User user;

        public Product()
        {

        }

        public Product(int id, string productNumber, string productName, SubCoCategory subCoCategory, decimal salePrice, string addedDate, string image, string description, int isBarcode, int ageVerify, int status, int temp, User user)
        {
            this.Id = id;
            this.ProductNumber = productNumber;
            this.ProductName = productName;
            this.SubCoCategory = subCoCategory;
            this.SalePrice = salePrice;
            this.AddedDate = addedDate;
            this.Image = image;
            this.Description = description;
            this.IsBarcode = isBarcode;
            this.AgeVerify = ageVerify;
            this.Status = status;
            this.Temp = temp;
            this.User = user;
        }

        public int Id { get => id; set => id = value; }
        public string ProductNumber { get => productNumber; set => productNumber = value; }
        public string ProductName { get => productName; set => productName = value; }
        internal SubCoCategory SubCoCategory { get => subCoCategory; set => subCoCategory = value; }
        public decimal SalePrice { get => salePrice; set => salePrice = value; }
        public string AddedDate { get => addedDate; set => addedDate = value; }
        public string Image { get => image; set => image = value; }
        public string Description { get => description; set => description = value; }
        public int IsBarcode { get => isBarcode; set => isBarcode = value; }
        public int AgeVerify { get => ageVerify; set => ageVerify = value; }
        public int Status { get => status; set => status = value; }
        public int Temp { get => temp; set => temp = value; }
        internal User User { get => user; set => user = value; }

        public static ReturnResult store(Product product)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                //store data
                string sql = "INSERT INTO `products` " +
                    "(" +
                    "`product_number`," +
                    "`product_name`," +
                    "`sub_co_category_id`," +
                    "`sale_price`," +
                    "`added_date`," +
                    "`image`,`description`," +
                    "`is_barcode`," +
                    "`age_verify`," +
                    "`status`,`temp`," +
                    "`user_id`) " +
                    "VALUES (" +
                    "@product_number," +
                    "@product_name," +
                    "@sub_co_category_id," +
                    "@sale_price," +
                    "@added_date," +
                    "@image," +
                    "@description," +
                    "@is_barcode," +
                    "@age_verify," +
                    "@status," +
                    "@temp," +
                    "@user_id)";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("product_number", MySqlDbType.String, product.productNumber));
                parameters.Add(new QueryParameter("product_name", MySqlDbType.String, product.ProductName));
                parameters.Add(new QueryParameter("sub_co_category_id", MySqlDbType.Int32, product.subCoCategory.Id));
                parameters.Add(new QueryParameter("sale_price", MySqlDbType.Decimal, product.salePrice));
                parameters.Add(new QueryParameter("added_date", MySqlDbType.String, product.addedDate));
                parameters.Add(new QueryParameter("image", MySqlDbType.String, product.image));
                parameters.Add(new QueryParameter("description", MySqlDbType.String, product.description));
                parameters.Add(new QueryParameter("is_barcode", MySqlDbType.Int32, product.isBarcode));
                parameters.Add(new QueryParameter("age_verify", MySqlDbType.Int32, product.ageVerify));
                parameters.Add(new QueryParameter("status", MySqlDbType.Int32, product.status));
                parameters.Add(new QueryParameter("temp", MySqlDbType.Int32, product.temp));
                parameters.Add(new QueryParameter("user_id", MySqlDbType.Int32, product.user.Id));

                commands.Add(new QueryCommand(sql, parameters));
                result = DBTransactionService.executeNonQuery(commands);
                if (result.Status)

                    result.Msg = Constants.MSG_STORE_SUCCESS;
            }
            catch (Exception e)
            {
                result = new ReturnResult(false, Constants.MSG_ERROR, e.Message, e);
                // MessageBox.Show(result);
            }
            return result;
        }

        public static ReturnResult update(Product product)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                string sql = "UPDATE `products` SET " +
                    "`product_number` = @product_number, " +
                     "`product_name` = @product_name, " +
                     "`sub_co_category_id` = @sub_co_category_id, " +
                     "`sale_price` = @sale_price, " +
                     "`added_date` = @added_date, " +
                     "`image` = @image, " +
                     "`description` = @description, " +
                      "`is_barcode` = @is_barcode, " +
                       "`age_verify` = @age_verify, " +
                     "`status` = @status, " +
                     "`temp` = @temp, " +
                     "`user_id` = @user_id " +
                    " WHERE `id` = @id ";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("product_number", MySqlDbType.String, product.productNumber));
                parameters.Add(new QueryParameter("product_name", MySqlDbType.String, product.ProductName));
                parameters.Add(new QueryParameter("sub_co_category_id", MySqlDbType.Int32, product.subCoCategory.Id));
                parameters.Add(new QueryParameter("sale_price", MySqlDbType.Decimal, product.salePrice));
                parameters.Add(new QueryParameter("added_date", MySqlDbType.String, product.addedDate));
                parameters.Add(new QueryParameter("image", MySqlDbType.String, product.image));
                parameters.Add(new QueryParameter("description", MySqlDbType.String, product.description));
                parameters.Add(new QueryParameter("is_barcode", MySqlDbType.Int32, product.isBarcode));
                parameters.Add(new QueryParameter("age_verify", MySqlDbType.Int32, product.ageVerify));
                parameters.Add(new QueryParameter("status", MySqlDbType.Int32, product.status));
                parameters.Add(new QueryParameter("temp", MySqlDbType.Int32, product.temp));
                parameters.Add(new QueryParameter("user_id", MySqlDbType.Int32, product.user.Id));
                parameters.Add(new QueryParameter("id", MySqlDbType.Int32, product.id));

                commands.Add(new QueryCommand(sql, parameters));
                result = DBTransactionService.executeNonQuery(commands);
                if (result.Status)
                    result.Msg = Constants.MSG_UPDATE_SUCCESS;
            }
            catch (Exception e)
            {
                result = new ReturnResult(false, Constants.MSG_ERROR, e.Message, e);
                // MessageBox.Show(result);
            }
            return result;
        }

        public static ReturnResult delete(int id)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                string query = "DELETE FROM `products` WHERE id = @id";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("id", MySqlDbType.Int32, id));
                commands.Add(new QueryCommand(query, parameters));
                result = DBTransactionService.executeNonQuery(commands);
                if (result.Status)
                    result.Msg = Constants.MSG_DELETE_SUCCESS;
            }
            catch (Exception e)
            {
                result = new ReturnResult(false, Constants.MSG_ERROR, e.Message, e);
                // MessageBox.Show(result);
            }
            return result;
        }

        public static void showOnViewForm(TextBox labelBox = null, TextBox idBox = null)
        {
            DataViewParam dvParam = new DataViewParam();
            dvParam.Title = "Products";
            dvParam.SelectSql = "SELECT " +
                "p.id, " +
                "p.product_number, " +
                "p.product_name, " +
                "c.category_name, " +
                "sc.sub_category_name, " +
                "scc.sub_co_category_name, " +
                "p.sale_price, " +
                "date_format(p.added_date,'%Y-%m-%d %H:%i'), " +
                "p.description ";
            dvParam.FromSql = "FROM  products p " +
                 "INNER JOIN sub_co_categories scc ON p.sub_co_category_id = scc.id " +
                  "INNER JOIN sub_categories sc ON scc.sub_category_id = sc.id " +
                  "INNER JOIN categories c ON sc.category_id = c.id " +
                "WHERE " +
                "c.category_name like @s1 or " +
                "sc.sub_category_name like @s2 or " +
                "scc.sub_co_category_name like @s3 or " +
                "p.product_number like @s4 or " +
                "p.product_name like @s5 or " +
                "p.status like @s6 " +
                "ORDER BY p.id DESC ";
            dvParam.SearchParamCount = 5; //name and description
            dvParam.TitleList = new List<string>() { "", "Product Number", "Product", "Category", "Sub Category", "Sub Co Category", "Sale Price", "Added Date", "Description", "Status" }; //Column titles
            dvParam.InvisibleColumnList = new List<int>() { 6 };
            dvParam.NumericColumnList = new List<int>() { };
            dvParam.AddForm = new frmProduct();
            dvParam.ViewForm = new frmProduct();

            frmView vData = null;

            if (idBox == null && labelBox == null)
                vData = new frmView(dvParam);
            else
                vData = new frmView(dvParam, idBox, labelBox);
            vData.Show();
        }

        public static void showOnViewFormProductWithoutBarcode(TextBox labelBox = null, TextBox idBox = null)
        {
            DataViewParam dvParam = new DataViewParam();
            dvParam.Title = "Product Whithout Barcode";
            dvParam.TableName = "products";
            dvParam.SelectSql = "SELECT " +
                "p.id, " +
                "p.product_name, " +
                "p.product_number, " +
                "c.category_name, " +
                "sc.sub_category_name, " +
                "scc.sub_co_category_name ";
            dvParam.FromSql = "from products p  " +
                "LEFT JOIN sub_co_categories scc ON p.sub_co_category_id=scc.id  " +
                "LEFT JOIN sub_categories sc ON scc.sub_category_id=sc.id  " +
                "LEFT JOIN categories c ON sc.category_id=c.id  " +
                "WHERE p.is_barcode='1' AND  p.status='1' AND p.temp='0' " +
                "ORDER BY p.id DESC ";
            dvParam.SearchParamCount = 0; //name and description //AND p.product_number like @s1 or p.product_name like @s2 or c.category_name like @s3 or sc.sub_category_name like @s4 or scc.sub_co_category_name like @s5 
            dvParam.TitleList = new List<string>() { "", "Product Name", "Product Number", "Category", "Sub Category", "Sub Co Category" };
            dvParam.InvisibleColumnList = new List<int>() { 1 };
            dvParam.NumericColumnList = new List<int>() { };//Column titles
            //dvParam.FixedColumnNumber = 3;
            dvParam.ShowImage = "show";


            dvParam.AddForm = new frmProduct();
            dvParam.ViewForm = new frmProduct();


            frmView vData = null;

            if (idBox == null && labelBox == null)
                vData = new frmView(dvParam);
            else
                vData = new frmView(dvParam, idBox, labelBox);
            vData.Show();
        }

        public static Product getOneProduct(int id)
        {
            Product product = new Product();
            Category category = new Category();
            SubCategory subCategory = new SubCategory();
            SubCoCategory subCoCategory = new SubCoCategory();
            User user = new User();
            try
            {
                String query = "SELECT " +
                    "p.id, " +
                    "p.product_number, " +
                    "p.product_name, " +
                    "c.category_name AS category, " +
                    "sc.sub_category_name AS subCategory, " +
                    "scc.sub_co_category_name AS subCoCategory, " +
                    "p.sale_price, " +
                    "date_format(p.added_date,'%Y-%m-%d %H:%i') AS added_date, " +
                     "p.image, " +
                    "p.description, " +
                     "p.is_barcode, " +
                      "p.age_verify, " +
                       "p.temp, " +
                       "p.status " +
                    "FROM products p " +
                    "INNER JOIN sub_co_categories scc ON p.sub_co_category_id = scc.id " +
                    "INNER JOIN sub_categories sc ON scc.sub_category_id = sc.id " +
                    "INNER JOIN categories c ON sc.category_id = c.id " +
                    "WHERE p.id = '" + id + "'";
                Dictionary<String, String> dbData = DBTransactionService.getDataAsDictionary(query);

                if (dbData != null)
                {
                    product.productNumber = dbData["product_number"];
                    product.productName = dbData["product_name"];

                    category.CategoryName = dbData["category"];
                    subCategory.Category = category;

                    subCategory.SubCategoryName = dbData["subCategory"];
                    subCoCategory.SubCategory = subCategory;

                    subCoCategory.SubCoCategoryName = dbData["subCoCategory"];
                    product.subCoCategory = subCoCategory;

                    product.salePrice = Convert.ToDecimal(dbData["sale_price"]);
                    product.addedDate = dbData["added_date"];
                    product.image = dbData["image"];
                    product.description = dbData["description"];
                    product.isBarcode= Convert.ToInt32(dbData["is_barcode"]);
                    product.ageVerify = Convert.ToInt32(dbData["age_verify"]);
                    product.status = Convert.ToInt32(dbData["status"]);
                    product.temp = Convert.ToInt32(dbData["temp"]);
                    product.user= user;
                }
                else
                {
                    //
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return product;
        }
    }
}
