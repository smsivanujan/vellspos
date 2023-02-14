using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vellsPos.Services;

namespace vellsPos.Entities.Masters
{
    internal class Payouts
    {
        private Int32 id;
        private DateTime date;
        private Decimal amount;
        private String description;
        private User user;

        public Payouts()
        {

        }

        public Payouts(int id, DateTime date, decimal amount, string description, User user)
        {
            this.Id = id;
            this.Date = date;
            this.Amount = amount;
            this.Description = description;
            this.User = user;
        }

        public int Id { get => id; set => id = value; }
        public DateTime Date { get => date; set => date = value; }
        public decimal Amount { get => amount; set => amount = value; }
        public string Description { get => description; set => description = value; }
        internal User User { get => user; set => user = value; }

        public static ReturnResult store(Payouts payouts)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                //store data
                string sql = "INSERT INTO `payouts` " +
                    "(`date`,`amount`,`description`,`user_id`) VALUES (@date,@amount,@description,@user_id)";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("date", MySqlDbType.DateTime, payouts.date));
                parameters.Add(new QueryParameter("amount", MySqlDbType.Decimal, payouts.amount));
                parameters.Add(new QueryParameter("description", MySqlDbType.String, payouts.description));
                parameters.Add(new QueryParameter("user_id", MySqlDbType.Int32, payouts.user.Id));

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

        public static ReturnResult update(Payouts payouts)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                string sql = "UPDATE `payouts` SET " +
                    "`date` = @date, " +
                     "`amount` = @amount, " +
                      "`description` = @description, " +
                    "`user_id` = @user_id " +
                    " WHERE `id` = @id ";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("date", MySqlDbType.DateTime, payouts.date));
                parameters.Add(new QueryParameter("amount", MySqlDbType.Decimal, payouts.amount));
                parameters.Add(new QueryParameter("description", MySqlDbType.String, payouts.description));
                parameters.Add(new QueryParameter("user_id", MySqlDbType.Int32, payouts.user.Id));

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
                string query = "DELETE FROM `payouts` WHERE id = @id";
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

        public static Payouts getOnePayout(int id)
        {
            Payouts payouts = new Payouts();
            User user = new User();
            try
            {
                String query = "SELECT * FROM payouts where id = '" + id + "'";
                Dictionary<String, String> dbData = DBTransactionService.getDataAsDictionary(query);

                if (dbData != null)
                {
                    payouts.date = Convert.ToDateTime(dbData["date"]);
                    payouts.amount = Convert.ToDecimal(dbData["amount"]);
                    payouts.description = dbData["priority"];
                    payouts.user = user;
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
            return payouts;
        }
    }
}
