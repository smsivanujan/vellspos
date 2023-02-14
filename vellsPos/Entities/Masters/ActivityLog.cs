using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vellsPos.Services;

namespace vellsPos.Entities.Masters
{
    internal class ActivityLog
    {
        private Int32 Id;
        private DateTime date;
        private User user;
        private String action;

        public ActivityLog()
        {

        }

        public ActivityLog(int id, DateTime date, User user, string action)
        {
            Id1 = id;
            this.Date = date;
            this.User = user;
            this.Action = action;
        }

        public int Id1 { get => Id; set => Id = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Action { get => action; set => action = value; }
        internal User User { get => user; set => user = value; }

        public static ReturnResult store(ActivityLog activityLog)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                //store data
                string sql = "INSERT INTO `activity_logs` " +
                    "(`date`,`user_id`,`action`) VALUES (@date,@user_id,@action)";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("date", MySqlDbType.DateTime, activityLog.date));
                parameters.Add(new QueryParameter("user_id", MySqlDbType.Int32, activityLog.user.Id));
                parameters.Add(new QueryParameter("action", MySqlDbType.String, activityLog.action));

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

        public static ReturnResult update(ActivityLog activityLog)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                string sql = "UPDATE `activity_logs` SET " +
                    "`date` = @date, " +
                     "`user_id` = @user_id, " +
                    "`action` = @action " +
                    " WHERE `id` = @id ";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("date", MySqlDbType.DateTime, activityLog.date));
                parameters.Add(new QueryParameter("user_id", MySqlDbType.Int32, activityLog.user.Id));
                parameters.Add(new QueryParameter("action", MySqlDbType.String, activityLog.action));

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
                string query = "DELETE FROM `activity_logs` WHERE id = @id";
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

        public static ActivityLog getOneActivityLog(int id)
        {
            ActivityLog activityLog = new ActivityLog();
            User user = new User();
            try
            {
                String query = "SELECT * FROM activity_logs where id = '" + id + "'";
                Dictionary<String, String> dbData = DBTransactionService.getDataAsDictionary(query);

                if (dbData != null)
                {
                    activityLog.date = Convert.ToDateTime(dbData["date"]);
                    activityLog.user = user;
                    activityLog.action = dbData["action"];
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
            return activityLog;
        }
    }
}
