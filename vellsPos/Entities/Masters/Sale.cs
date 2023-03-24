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
    internal class Sale
    {
        private Int32 id;
        private String date;
        private Branch branch;
        private String invoiceNumber;
        private Decimal totalAmount;
        private Decimal totalDiscount;
        private Int32 status;
        private User user;

        public Sale()
        {

        }

        public Sale(int id, string date, Branch branch, string invoiceNumber, decimal totalAmount, decimal totalDiscount, int status, User user)
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
        public string Date { get => date; set => date = value; }
        internal Branch Branch { get => branch; set => branch = value; }
        public string InvoiceNumber { get => invoiceNumber; set => invoiceNumber = value; }
        public decimal TotalAmount { get => totalAmount; set => totalAmount = value; }
        public decimal TotalDiscount { get => totalDiscount; set => totalDiscount = value; }
        public int Status { get => status; set => status = value; }
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
                    "VALUES (@date, @branch_id,@invoice_number,@total_amount,@total_discount,@status,@user_id)";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("date", MySqlDbType.String, sale.Date));
                parameters.Add(new QueryParameter("branch_id", MySqlDbType.Int32, sale.Branch.Id));
                parameters.Add(new QueryParameter("invoice_number", MySqlDbType.String, sale.InvoiceNumber));
                parameters.Add(new QueryParameter("total_amount", MySqlDbType.Decimal, sale.TotalAmount));
                parameters.Add(new QueryParameter("total_discount", MySqlDbType.Decimal, sale.TotalDiscount));
                parameters.Add(new QueryParameter("status", MySqlDbType.Int32, sale.Status));
                parameters.Add(new QueryParameter("user_id", MySqlDbType.Int32, sale.User.Id));
                parameters.Add(new QueryParameter("id", MySqlDbType.Int32, sale.Id));

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
                parameters.Add(new QueryParameter("date", MySqlDbType.String, sale.Date));
                parameters.Add(new QueryParameter("branch_id", MySqlDbType.Int32, sale.Branch.Id));
                parameters.Add(new QueryParameter("invoice_number", MySqlDbType.String, sale.InvoiceNumber));
                parameters.Add(new QueryParameter("total_amount", MySqlDbType.Decimal, sale.TotalAmount));
                parameters.Add(new QueryParameter("total_discount", MySqlDbType.Decimal, sale.TotalDiscount));
                parameters.Add(new QueryParameter("status", MySqlDbType.Int32, sale.Status));
                parameters.Add(new QueryParameter("user_id", MySqlDbType.Int32, sale.User.Id));

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

        public static void showOnViewForm(TextBox labelBox = null, TextBox idBox = null)
        {
            DataViewParam dvParam = new DataViewParam();
            dvParam.Title = "Sales";
            dvParam.SelectSql = "SELECT " +
                "s.id, " +
                "date_format(s.date,'%Y-%m-%d %H:%i') AS date, " +
                "b.branch_name, " +
                "s.invoice_number, " +
                "s.total_amount, " +
                "s.total_discount, " +
                "s.status ";
            dvParam.FromSql = "FROM  sales s " +
                  "INNER JOIN branches b ON s.branch_id = b.id " +
                "WHERE s.date like @s1 or " +
                "b.branch_name like @s2 or " +
                "s.invoice_number like @s3 or " +
                "s.status like @s4 " +
                "ORDER BY s.id DESC ";
            dvParam.SearchParamCount = 3; //name and description
            dvParam.TitleList = new List<string>() { "", "Date", "Branch", "Total Amount", "Total Discount", "Qty", "Status" }; //Column titles
            dvParam.InvisibleColumnList = new List<int>() { 3, 4 };
            dvParam.NumericColumnList = new List<int>() { };
            //dvParam.AddForm = new frms();
            //dvParam.ViewForm = new frmComplain();

            //frmView vData = null;

            //if (idBox == null && labelBox == null)
            //    vData = new frmView(dvParam);
            //else
            //    vData = new frmView(dvParam, idBox, labelBox);
            //vData.Show();
        }

        public static Sale getOneSale(int id)
        {
            Sale sale = new Sale();
            Branch branch = new Branch();
            User user = new User();
            try
            {
                String query = "SELECT " +
                    "s.id, " +
                    "date_format(s.date,'%Y-%m-%d %H:%i') AS date, " +
                    "b.branch_name AS branch, " +
                    "s.invoice_number, " +
                    "s.total_amount, " +
                    "s.total_discount, " +
                    "s.status " +
                    "FROM sales s " +
                    "INNER JOIN branches b ON s.branch_id = b.id " +
                    "WHERE s.id = '" + id + "'";
                Dictionary<String, String> dbData = DBTransactionService.getDataAsDictionary(query);

                if (dbData != null)
                {
                    sale.date = dbData["date"];
                    branch.BranchName = dbData["branch"];
                    sale.branch = branch;
                    sale.invoiceNumber = dbData["invoice_number"];
                    sale.totalAmount = Convert.ToDecimal(dbData["total_amount"]);
                    sale.totalDiscount = Convert.ToDecimal(dbData["total_discount"]);
                    sale.status = Convert.ToInt32(dbData["status"]);
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
