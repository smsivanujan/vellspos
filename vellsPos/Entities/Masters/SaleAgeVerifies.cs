using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vellsPos.Services;

namespace vellsPos.Entities.Masters
{
    internal class SaleAgeVerifies
    {
        private Int32 id;
        private Sale sale;
        private Product product;
        private String verificationMethod;
        private Int32 status;
        private User user;

        public SaleAgeVerifies()
        {

        }

        public SaleAgeVerifies(int id, Sale sale, Product product, string verificationMethod, int status, User user)
        {
            this.Id = id;
            this.Sale = sale;
            this.Product = product;
            this.VerificationMethod = verificationMethod;
            this.Status = status;
            this.User = user;
        }

        public int Id { get => id; set => id = value; }
        public string VerificationMethod { get => verificationMethod; set => verificationMethod = value; }
        public int Status { get => status; set => status = value; }
        internal Sale Sale { get => sale; set => sale = value; }
        internal Product Product { get => product; set => product = value; }
        internal User User { get => user; set => user = value; }

        public static ReturnResult store(SaleAgeVerifies saleAgeVerifies)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                //store data
                string sql = "INSERT INTO `sale_age_verifies` " +
                    "(`sale_id`,`product_id`,`verification_method`,`status`,`user_id`) " +
                    "VALUES (@sale_id,@product_id,@verification_method,@status,@user_id)";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("sale_id", MySqlDbType.Int32, saleAgeVerifies.sale.Id));
                parameters.Add(new QueryParameter("product_id", MySqlDbType.Int32, saleAgeVerifies.product.Id));
                parameters.Add(new QueryParameter("verification_method", MySqlDbType.String, saleAgeVerifies.verificationMethod));
                parameters.Add(new QueryParameter("status", MySqlDbType.Int32, saleAgeVerifies.Status));
                parameters.Add(new QueryParameter("user_id", MySqlDbType.Int32, saleAgeVerifies.user.Id));

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

        public static ReturnResult update(SaleAgeVerifies saleAgeVerifies)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                string sql = "UPDATE `sale_age_verifies` SET " +
                    "`sale_id` = @sale_id, " +
                     "`product_id` = @product_id, " +
                      "`verification_method` = @verification_method, " +
                     "`status` = @status, " +
                    "`user_id` = @user_id " +
                    " WHERE `id` = @id ";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("sale_id", MySqlDbType.Int32, saleAgeVerifies.sale.Id));
                parameters.Add(new QueryParameter("product_id", MySqlDbType.Int32, saleAgeVerifies.product.Id));
                parameters.Add(new QueryParameter("verification_method", MySqlDbType.String, saleAgeVerifies.verificationMethod));
                parameters.Add(new QueryParameter("status", MySqlDbType.Int32, saleAgeVerifies.Status));
                parameters.Add(new QueryParameter("user_id", MySqlDbType.Int32, saleAgeVerifies.user.Id));

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
                string query = "DELETE FROM `sale_age_verifies` WHERE id = @id";
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

        public static SaleAgeVerifies getOneAgeVerify(int id)
        {
            SaleAgeVerifies saleAgeVerifies = new SaleAgeVerifies();
            Sale sale = new Sale();
            Product product = new Product();
            User user = new User();
            try
            {
                String query = "SELECT * FROM sale_age_verifies where id = '" + id + "'";
                Dictionary<String, String> dbData = DBTransactionService.getDataAsDictionary(query);

                if (dbData != null)
                {
                    saleAgeVerifies.sale = sale;
                    saleAgeVerifies.product = product;
                    saleAgeVerifies.verificationMethod = dbData["verification_method"];
                    saleAgeVerifies.status = Convert.ToInt32(dbData["status"]);
                    saleAgeVerifies.user = user;
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
            return saleAgeVerifies;
        }
    }
}
