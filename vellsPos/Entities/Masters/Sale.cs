using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vellsPos.Services;

namespace vellsPos.Entities.Masters
{
    internal class Sale
    {
        private Int32 id;
        private DateTime date;
        private Branch branch;
        private String invoiceNumber;
        private Decimal totalAmount;
        private Decimal totalDiscount;
        private Int32 status;
        private User user;

        public Sale()
        {

        }

        public Sale(int id, DateTime date, Branch branch, string invoiceNumber, decimal totalAmount, decimal totalDiscount, int status, User user)
        {
            this.Id = id;
            this.Date = date;
            this.Branch = branch;
            this.InvoiceNumber = invoiceNumber;
            this.TotalAmount = totalAmount;
            this.TotalDiscount = totalDiscount;
            this.Status = status;
            this.User = user;
        }

        public int Id { get => id; set => id = value; }
        public DateTime Date { get => date; set => date = value; }
        public string InvoiceNumber { get => invoiceNumber; set => invoiceNumber = value; }
        public decimal TotalAmount { get => totalAmount; set => totalAmount = value; }
        public decimal TotalDiscount { get => totalDiscount; set => totalDiscount = value; }
        public int Status { get => status; set => status = value; }
        internal Branch Branch { get => branch; set => branch = value; }
        internal User User { get => user; set => user = value; }

        public static ReturnResult store(Sale sale)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                //store data
                string sql = "INSERT INTO `sales` " +
                    "(`date`,`branch_id`,`invoice_number`,`total_amount`,`total_discount`,`status`,`user_id`) " +
                    "VALUES (@branch_id,@invoice_number,@total_amount,@total_discount,@status,@user_id)";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("date", MySqlDbType.DateTime, sale.date));
                parameters.Add(new QueryParameter("branch_id", MySqlDbType.Int32, sale.branch.Id));
                parameters.Add(new QueryParameter("invoice_number", MySqlDbType.String, sale.invoiceNumber));
                parameters.Add(new QueryParameter("total_amount", MySqlDbType.Decimal, sale.totalAmount));
                parameters.Add(new QueryParameter("total_discount", MySqlDbType.Decimal, sale.totalDiscount));
                parameters.Add(new QueryParameter("status", MySqlDbType.Int32, sale.status));
                parameters.Add(new QueryParameter("user_id", MySqlDbType.Int32, sale.user.Id));

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

        public static ReturnResult update(Sale sale)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                string sql = "UPDATE `sales` SET " +
                    "`date` = @date, " +
                     "`branch_id` = @branch_id, " +
                      "`invoice_number` = @invoice_number, " +
                     "`total_amount` = @total_amount, " +
                     "`total_discount` = @total_discount, " +
                     "`status` = @status, " +
                    "`user_id` = @user_id " +
                    " WHERE `id` = @id ";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("date", MySqlDbType.DateTime, sale.date));
                parameters.Add(new QueryParameter("branch_id", MySqlDbType.Int32, sale.branch.Id));
                parameters.Add(new QueryParameter("invoice_number", MySqlDbType.String, sale.invoiceNumber));
                parameters.Add(new QueryParameter("total_amount", MySqlDbType.Decimal, sale.totalAmount));
                parameters.Add(new QueryParameter("total_discount", MySqlDbType.Decimal, sale.totalDiscount));
                parameters.Add(new QueryParameter("status", MySqlDbType.Int32, sale.status));
                parameters.Add(new QueryParameter("user_id", MySqlDbType.Int32, sale.user.Id));

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
                string query = "DELETE FROM `sales` WHERE id = @id";
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

        public static Sale getOneSale(int id)
        {
            Sale sale = new Sale();
            Branch branch = new Branch();
            User user = new User();
            try
            {
                String query = "SELECT * FROM sales where id = '" + id + "'";
                Dictionary<String, String> dbData = DBTransactionService.getDataAsDictionary(query);

                if (dbData != null)
                {
                    sale.date = Convert.ToDateTime(dbData["date"]);
                    sale.branch = branch;
                    sale.invoiceNumber = dbData["invoice_number"];
                    sale.totalAmount = Convert.ToDecimal(dbData["total_amount"]);
                    sale.totalDiscount = Convert.ToDecimal(dbData["total_discount"]);
                    sale.status = Convert.ToInt32(dbData["status"]);
                    sale.user = user;
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
            return sale;
        }
    }
}
