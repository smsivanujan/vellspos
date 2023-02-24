using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vellsPos.Services;

namespace vellsPos.Entities.Masters
{
    internal class LoginLog
    {
        private Int32 id;
        private DateTime date;
        private User user;
        private String action;

        public LoginLog()
        {

        }
        
        public LoginLog(int id, DateTime date, User user, string action)
        {
            this.Id = id;
            this.Date = date;
            this.User = user;
            this.Action = action;
        }

        public int Id { get => id; set => id = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Action { get => action; set => action = value; }
        internal User User { get => user; set => user = value; }

        public static ReturnResult store(LoginLog loginLog)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                //store data
                string sql = "INSERT INTO `login_logs` " +
                    "(`date`,`user_id`,`action`) VALUES (@date,@user_id,@action)";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("date", MySqlDbType.DateTime, loginLog.date));
                parameters.Add(new QueryParameter("user_id", MySqlDbType.Int32, loginLog.user.Id));
                parameters.Add(new QueryParameter("action", MySqlDbType.String, loginLog.action));

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

        public static ReturnResult update(LoginLog loginLog)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                string sql = "UPDATE `login_logs` SET " +
                    "`date` = @date, " +
                     "`user_id` = @user_id, " +
                    "`action` = @action " +
                    " WHERE `id` = @id ";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("date", MySqlDbType.DateTime, loginLog.date));
                parameters.Add(new QueryParameter("user_id", MySqlDbType.Int32, loginLog.user.Id));
                parameters.Add(new QueryParameter("action", MySqlDbType.String, loginLog.action));

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
                string query = "DELETE FROM `login_logs` WHERE id = @id";
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
            dvParam.Title = "Login Logs";
            dvParam.SelectSql = "SELECT ll.id, ll.date, u.user_name, ll.action ";
            dvParam.FromSql = "FROM  login_logs ll " +
                  "INNER JOIN users u ON ll.user_id = u.id " +
                "WHERE ll.date like @s1 or u.user_name like @s2 or ll.action like @s3 " +
                "ORDER BY ll.id DESC ";
            dvParam.SearchParamCount = 2; //name and description
            dvParam.TitleList = new List<string>() { "", "Date", "User", "Acton" }; //Column titles
            dvParam.InvisibleColumnList = new List<int>() { 1 };
            dvParam.NumericColumnList = new List<int>() { };
            //dvParam.AddForm = new frmComplain();
            //dvParam.ViewForm = new frmComplain();

            //frmView vData = null;

            //if (idBox == null && labelBox == null)
            //    vData = new frmView(dvParam);
            //else
            //    vData = new frmView(dvParam, idBox, labelBox);
            //vData.Show();
        }

        public static LoginLog getOneLoginLog(int id)
        {
            LoginLog loginLog = new LoginLog();
            User user = new User();
            try
            {
                String query = "SELECT * FROM login_logs where id = '" + id + "'";
                Dictionary<String, String> dbData = DBTransactionService.getDataAsDictionary(query);

                if (dbData != null)
                {
                    loginLog.date = Convert.ToDateTime(dbData["date"]);
                    loginLog.user = user;
                    loginLog.action = dbData["action"];
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
            return loginLog;
        }
    }
}
