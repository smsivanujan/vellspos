using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vellsPos.Services;

namespace vellsPos.Entities.Masters
{
    internal class SalesDetail
    {
        private Int32 id;
        private Sale sale;
        private Product product;
        private Int32 qty;
        private Decimal amount;

        public SalesDetail()
        {

        }

        public SalesDetail(int id, Sale sale, Product product, int qty, decimal amount)
        {
            this.Id = id;
            this.Sale = sale;
            this.Product = product;
            this.Qty = qty;
            this.Amount = amount;
        }

        public int Id { get => id; set => id = value; }
        public int Qty { get => qty; set => qty = value; }
        public decimal Amount { get => amount; set => amount = value; }
        internal Sale Sale { get => sale; set => sale = value; }
        internal Product Product { get => product; set => product = value; }

        public static ReturnResult store(SalesDetail salesDetail)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                //store data
                string sql = "INSERT INTO `sale_details` " +
                    "(`sale_id`,`product_id`,`qty`,`amount`) VALUES (@sale_id,@product_id,@qty,@amount)";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("sale_id", MySqlDbType.Int32, salesDetail.sale.Id));
                parameters.Add(new QueryParameter("product_id", MySqlDbType.Int32, salesDetail.product.Id));
                parameters.Add(new QueryParameter("qty", MySqlDbType.Int32, salesDetail.qty));
                parameters.Add(new QueryParameter("amount", MySqlDbType.Decimal, salesDetail.amount));

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

        public static ReturnResult update(SalesDetail salesDetail)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                string sql = "UPDATE `sale_details` SET " +
                    "`sale_id` = @sale_id, " +
                     "`product_id` = @product_id, " +
                     "`qty` = @qty, " +
                    "`amount` = @amount " +
                    " WHERE `id` = @id ";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("sale_id", MySqlDbType.Int32, salesDetail.sale.Id));
                parameters.Add(new QueryParameter("product_id", MySqlDbType.Int32, salesDetail.product.Id));
                parameters.Add(new QueryParameter("qty", MySqlDbType.Int32, salesDetail.qty));
                parameters.Add(new QueryParameter("amount", MySqlDbType.Decimal, salesDetail.amount));

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
                string query = "DELETE FROM `sale_details` WHERE id = @id";
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

        public static SalesDetail getOneSaleDetail(int id)
        {
            SalesDetail salesDetail = new SalesDetail();
            Sale sale = new Sale();
            Product product = new Product();
            try
            {
                String query = "SELECT * FROM sale_details where id = '" + id + "'";
                Dictionary<String, String> dbData = DBTransactionService.getDataAsDictionary(query);

                if (dbData != null)
                {
                    salesDetail.sale = sale;
                    salesDetail.product = product;
                    salesDetail.qty = Convert.ToInt32(dbData["description"]);
                    salesDetail.amount = Convert.ToDecimal(dbData["description"]);
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
            return salesDetail;
        }
    }
}
