﻿using MySql.Data.MySqlClient;
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
                parameters.Add(new QueryParameter("id", MySqlDbType.Int32, activityLog.Id));

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

        public static void showOnViewForm(TextBox labelBox = null, TextBox idBox = null)
        {
            DataViewParam dvParam = new DataViewParam();
            dvParam.Title = "Activity Logs";
            dvParam.SelectSql = "SELECT " +
                "al.id, " +
                "date_format(al.date,'%Y-%m-%d %H:%i'), " +
                "u.user_name, " +
                "al.action ";
            dvParam.FromSql = "FROM  activity_logs al " +
                  "INNER JOIN users u ON al.user_id = u.id " +
                "WHERE " +
                "al.date like @s1 " +
                "or u.user_name like @s2 or " +
                "al.action like @s3 " +
                "ORDER BY al.id DESC ";
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

        public static ActivityLog getOneActivityLog(int id)
        {
            ActivityLog activityLog = new ActivityLog();
            User user = new User();
            try
            {
                String query = "SELECT " +
                    "al.id, " +
                    "date_format(al.date,'%Y-%m-%d %H:%i') AS date, " +
                    "u.user_name AS user, " +
                    "al.action " +
                    "FROM activity_logs al " +
                    "INNER JOIN users u ON al.user_id = u.id " +
                    "WHERE al.id = '" + id + "'";
                Dictionary<String, String> dbData = DBTransactionService.getDataAsDictionary(query);

                if (dbData != null)
                {
                    activityLog.date = Convert.ToDateTime(dbData["date"]);
                    user.UserName = dbData["user"];
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
