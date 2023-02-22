using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
        private DateTime addedDate;
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

        public Product(int id, string productNumber, string productName, SubCoCategory subCoCategory, decimal salePrice, DateTime addedDate, string image, string description, int isBarcode, int ageVerify, int status, int temp, User user)
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
        public DateTime AddedDate { get => addedDate; set => addedDate = value; }
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
                    "(`product_number`,`product_name`,`sub_co_category_id`,`sale_price`,`added_date`,`image`,`description`,`is_barcode`,`age_verify`,`status`,`temp`,`user_id`) " +
                    "VALUES (@product_number,@product_name,@sub_co_category_id,@sale_price,@added_date,@image,@description,@is_barcode,@age_verify,@status,@temp,@user_id)";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("product_number", MySqlDbType.String, product.ProductNumber));
                parameters.Add(new QueryParameter("product_name", MySqlDbType.String, product.ProductName));
                parameters.Add(new QueryParameter("sub_co_category_id", MySqlDbType.Int32, product.SubCoCategory.Id));
                parameters.Add(new QueryParameter("sale_price", MySqlDbType.Decimal, product.SalePrice));
                parameters.Add(new QueryParameter("added_date", MySqlDbType.DateTime, product.AddedDate));
                parameters.Add(new QueryParameter("image", MySqlDbType.String, product.Image));
                parameters.Add(new QueryParameter("description", MySqlDbType.String, product.Description));
                parameters.Add(new QueryParameter("is_barcode", MySqlDbType.Int32, product.AgeVerify));
                parameters.Add(new QueryParameter("age_verify", MySqlDbType.Int32, product.AgeVerify));
                parameters.Add(new QueryParameter("status", MySqlDbType.Int32, product.Status));
                parameters.Add(new QueryParameter("temp", MySqlDbType.Int32, product.Temp));
                parameters.Add(new QueryParameter("user_id", MySqlDbType.Int32, product.User.Id));

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
                parameters.Add(new QueryParameter("product_number", MySqlDbType.String, product.ProductNumber));
                parameters.Add(new QueryParameter("product_name", MySqlDbType.String, product.ProductName));
                parameters.Add(new QueryParameter("sub_co_category_id", MySqlDbType.Int32, product.SubCoCategory.Id));
                parameters.Add(new QueryParameter("sale_price", MySqlDbType.Decimal, product.SalePrice));
                parameters.Add(new QueryParameter("added_date", MySqlDbType.DateTime, product.AddedDate));
                parameters.Add(new QueryParameter("image", MySqlDbType.String, product.Image));
                parameters.Add(new QueryParameter("description", MySqlDbType.String, product.Description));
                parameters.Add(new QueryParameter("age_verify", MySqlDbType.Int32, product.AgeVerify));
                parameters.Add(new QueryParameter("status", MySqlDbType.Int32, product.Status));
                parameters.Add(new QueryParameter("temp", MySqlDbType.Int32, product.Temp));
                parameters.Add(new QueryParameter("user_id", MySqlDbType.Int32, product.User.Id));

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

        //public static void showOnViewForm()
        //{
        //    DataViewParam dvParam = new DataViewParam();
        //    dvParam.Title = "Job Roles";
        //    dvParam.SelectSql = "SELECT id, code, tittle, description ";
        //    dvParam.FromSql = "from job_role where tittle like @s1 or code like @s2 ORDER BY id DESC ";
        //    dvParam.SearchParamCount = 2; //name and description
        //    dvParam.TitleList = new List<string>() { "", "Code", "Job Role", "Description" }; //Column titles
        //    dvParam.AddForm = new JobRoleManagement();
        //    dvParam.ViewForm = new ViewSingleJobRole();
        //    ViewData vData = new ViewData(dvParam);
        //    vData.Show();
        //}


        public static void showOnViewFormProductWithoutBarcode(TextBox labelBox = null, TextBox idBox = null, String id = null)
        {
            DataViewParam dvParam = new DataViewParam();
            dvParam.Title = "Product Whithout Barcode";
            dvParam.TableName = "products";
            dvParam.SelectSql = "SELECT p.id, p.product_number, p.product_name, c.category_name, sc.sub_category_name, scc.sub_co_category_name ";
            dvParam.FromSql = "from products p  " +
                "LEFT JOIN sub_co_categories scc ON p.sub_co_category_id=scc.id  " +
                "LEFT JOIN sub_categories sc ON scc.sub_category_id=sc.id  " +
                "LEFT JOIN categories c ON sc.category_id=c.id  " +
                "WHERE p.id='" + id + "' " +
                "ORDER BY p.id DESC ";
            dvParam.SearchParamCount = 0; //name and description //AND p.product_number like @s1 or p.product_name like @s2 or c.category_name like @s3 or sc.sub_category_name like @s4 or scc.sub_co_category_name like @s5 
            dvParam.TitleList = new List<string>() { "", "Product Number", "Product Name", "Category", "Sub Category", "Sub Co Category" };
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
            SubCoCategory subCoCategory = new SubCoCategory();
            User user = new User();
            try
            {
                String query = "SELECT * FROM products where id = '" + id + "'";
                Dictionary<String, String> dbData = DBTransactionService.getDataAsDictionary(query);

                if (dbData != null)
                {
                    product.ProductNumber = dbData["product_number"];
                    product.ProductName = dbData["product_name"];
                    product.SubCoCategory = subCoCategory;
                    product.SalePrice = Convert.ToDecimal(dbData["sale_price"]);
                    product.AddedDate = Convert.ToDateTime(dbData["added_date"]);
                    product.Image = dbData["image"];
                    product.Description = dbData["description"];
                    product.isBarcode= Convert.ToInt32(dbData["is_barcode"]);
                    product.AgeVerify = Convert.ToInt32(dbData["age_verify"]);
                    product.Status = Convert.ToInt32(dbData["status"]);
                    product.Temp = Convert.ToInt32(dbData["temp"]);
                    product.User= user;
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
