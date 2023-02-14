using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vellsPos.Services;

namespace vellsPos.Entities.Masters
{
    internal class ProductReturn
    {
        private Int32 id;
        private Sale sale;
        private Product product;
        private Int32 qty;
        private Decimal amount;
        private User user;

        public ProductReturn()
        {

        }

        public ProductReturn(int id, Sale sale, Product product, int qty, decimal amount, User user)
        {
            this.Id = id;
            this.Sale = sale;
            this.Product = product;
            this.Qty = qty;
            this.Amount = amount;
            this.User = user;
        }

        public int Id { get => id; set => id = value; }
        public int Qty { get => qty; set => qty = value; }
        public decimal Amount { get => amount; set => amount = value; }
        internal Sale Sale { get => sale; set => sale = value; }
        internal Product Product { get => product; set => product = value; }
        internal User User { get => user; set => user = value; }

        public static ReturnResult store(ProductReturn productReturn)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                //store data
                string sql = "INSERT INTO `product_returns` " +
                    "(`sale_id`,`product_id`,`qty`,`amount`,`user_id`) VALUES (@sale_id,@product_id,@qty,@amount,@user_id)";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("sale_id", MySqlDbType.Int32, productReturn.sale.Id));
                parameters.Add(new QueryParameter("product_id", MySqlDbType.Int32, productReturn.product.Id));
                parameters.Add(new QueryParameter("qty", MySqlDbType.Int32, productReturn.qty));
                parameters.Add(new QueryParameter("amount", MySqlDbType.Decimal, productReturn.amount));
                parameters.Add(new QueryParameter("user_id", MySqlDbType.Int32, productReturn.user.Id));

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

        public static ReturnResult update(ProductReturn productReturn)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                string sql = "UPDATE `product_returns` SET " +
                    "`sale_id` = @sale_id, " +
                     "`product_id` = @product_id, " +
                      "`qty` = @qty, " +
                     "`amount` = @amount, " +
                    "`user_id` = @user_id " +
                    " WHERE `id` = @id ";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("sale_id", MySqlDbType.Int32, productReturn.sale.Id));
                parameters.Add(new QueryParameter("product_id", MySqlDbType.Int32, productReturn.product.Id));
                parameters.Add(new QueryParameter("qty", MySqlDbType.Int32, productReturn.qty));
                parameters.Add(new QueryParameter("amount", MySqlDbType.Decimal, productReturn.amount));
                parameters.Add(new QueryParameter("user_id", MySqlDbType.Int32, productReturn.user.Id));

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
                string query = "DELETE FROM `product_returns` WHERE id = @id";
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

        public static ProductReturn getOneProductReturn(int id)
        {
            ProductReturn productReturn = new ProductReturn();
            Sale sale = new Sale();
            Product product = new Product();
            User user = new User();
            try
            {
                String query = "SELECT * FROM product_returns where id = '" + id + "'";
                Dictionary<String, String> dbData = DBTransactionService.getDataAsDictionary(query);

                if (dbData != null)
                {
                    productReturn.sale = sale;
                    productReturn.product = product;
                    productReturn.qty = Convert.ToInt32(dbData["qty"]);
                    productReturn.amount = Convert.ToDecimal(dbData["amount"]);
                    productReturn.user = user;
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
            return productReturn;
        }
    }
}
