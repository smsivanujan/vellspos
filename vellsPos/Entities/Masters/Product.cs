using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vellsPos.Services;

namespace vellsPos.Entities.Masters
{
    internal class Product
    {
        private Int32 id;
        private String productNumber;
        private String productName;
        private SubCoCategory subCoCategory;
        private DateTime addedDate;
        private String image;
        private String description;
        private Int32 ageVerify;
        private Int32 status;
        private Int32 temp;
        private User user;

        public Product()
        {

        }

        public Product(int id, string productNumber, string productName, SubCoCategory subCoCategory, DateTime addedDate, string image, string description, int ageVerify, int status, int temp, User user)
        {
            this.Id = id;
            this.ProductNumber = productNumber;
            this.ProductName = productName;
            this.SubCoCategory = subCoCategory;
            this.AddedDate = addedDate;
            this.Image = image;
            this.Description = description;
            this.AgeVerify = ageVerify;
            this.Status = status;
            this.Temp = temp;
            this.User = user;
        }

        public int Id { get => id; set => id = value; }
        public string ProductNumber { get => productNumber; set => productNumber = value; }
        public string ProductName { get => productName; set => productName = value; }
        public DateTime AddedDate { get => addedDate; set => addedDate = value; }
        public string Image { get => image; set => image = value; }
        public string Description { get => description; set => description = value; }
        public int AgeVerify { get => ageVerify; set => ageVerify = value; }
        public int Status { get => status; set => status = value; }
        public int Temp { get => temp; set => temp = value; }
        internal SubCoCategory SubCoCategory { get => subCoCategory; set => subCoCategory = value; }
        internal User User { get => user; set => user = value; }

        public static ReturnResult store(Product product)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                //store data
                string sql = "INSERT INTO `products` " +
                    "(`product_number`,`product_name`,`sub_co_category_id`,`added_date`,`image`,`description`,`age_verify`,`status`,`temp`,`user_id`) " +
                    "VALUES (@product_number,@product_name,@sub_co_category_id,@added_date,@image,@description,@age_verify,@status,@temp,@user_id)";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("product_number", MySqlDbType.String, product.productNumber));
                parameters.Add(new QueryParameter("product_name", MySqlDbType.String, product.productName));
                parameters.Add(new QueryParameter("sub_co_category_id", MySqlDbType.Int32, product.subCoCategory.Id));
                parameters.Add(new QueryParameter("added_date", MySqlDbType.DateTime, product.addedDate));
                parameters.Add(new QueryParameter("image", MySqlDbType.String, product.image));
                parameters.Add(new QueryParameter("description", MySqlDbType.String, product.description));
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
                     "`added_date` = @added_date, " +
                     "`image` = @image, " +
                     "`description` = @description, " +
                     "`status` = @status, " +
                     "`temp` = @temp, " +
                     "`user_id` = @user_id " +
                    " WHERE `id` = @id ";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("product_number", MySqlDbType.String, product.productNumber));
                parameters.Add(new QueryParameter("product_name", MySqlDbType.String, product.productName));
                parameters.Add(new QueryParameter("sub_co_category_id", MySqlDbType.Int32, product.subCoCategory.Id));
                parameters.Add(new QueryParameter("added_date", MySqlDbType.DateTime, product.addedDate));
                parameters.Add(new QueryParameter("image", MySqlDbType.String, product.image));
                parameters.Add(new QueryParameter("description", MySqlDbType.String, product.description));
                parameters.Add(new QueryParameter("age_verify", MySqlDbType.Int32, product.ageVerify));
                parameters.Add(new QueryParameter("status", MySqlDbType.Int32, product.status));
                parameters.Add(new QueryParameter("temp", MySqlDbType.Int32, product.temp));
                parameters.Add(new QueryParameter("user_id", MySqlDbType.Int32, product.user.Id));

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
                    product.productNumber = dbData["product_number"];
                    product.ProductName = dbData["product_name"];
                    product.subCoCategory = subCoCategory;
                    product.addedDate = Convert.ToDateTime(dbData["added_date"]);
                    product.image = dbData["image"];
                    product.description = dbData["description"];
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
