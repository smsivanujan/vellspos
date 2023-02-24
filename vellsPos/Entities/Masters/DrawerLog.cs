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
    internal class DrawerLog
    {
        private Int32 id;
        private DateTime date;
        private User user;
        private String type;
        private String action;

        public DrawerLog()
        {

        }

        public DrawerLog(int id, DateTime date, User user, string type, string action)
        {
            this.Id = id;
            this.Date = date;
            this.User = user;
            this.Type = type;
            this.Action = action;
        }

        public int Id { get => id; set => id = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Type { get => type; set => type = value; }
        public string Action { get => action; set => action = value; }
        internal User User { get => user; set => user = value; }

        public static ReturnResult store(DrawerLog drawerLog)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                //store data
                string sql = "INSERT INTO `drawer_logs` " +
                    "(`date`,`user_id`,`type`,`action`) VALUES (@date,@user_id,@type,@action)";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("date", MySqlDbType.DateTime, drawerLog.date));
                parameters.Add(new QueryParameter("user_id", MySqlDbType.Int32, drawerLog.user.Id));
                parameters.Add(new QueryParameter("type", MySqlDbType.String, drawerLog.type));
                parameters.Add(new QueryParameter("action", MySqlDbType.String, drawerLog.action));

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

        public static ReturnResult update(DrawerLog drawerLog)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                string sql = "UPDATE `drawer_logs` SET " +
                    "`date` = @date, " +
                     "`user_id` = @user_id, " +
                     "`type` = @type, " +
                    "`action` = @action " +
                    " WHERE `id` = @id ";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("date", MySqlDbType.DateTime, drawerLog.date));
                parameters.Add(new QueryParameter("user_id", MySqlDbType.Int32, drawerLog.user.Id));
                parameters.Add(new QueryParameter("type", MySqlDbType.String, drawerLog.type));
                parameters.Add(new QueryParameter("action", MySqlDbType.String, drawerLog.action));

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
                string query = "DELETE FROM `drawer_logs` WHERE id = @id";
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
            dvParam.Title = "Drawer Logs";
            dvParam.SelectSql = "SELECT dl.id, dl.date, u.user_name, dl.type, dl.action ";
            dvParam.FromSql = "FROM  drawer_logs dl " +
                 "INNER JOIN users u ON dl.user_id = u.id " +
                "WHERE dl.date like @s1 or u.user_name like @s2 or dl.type like @s3 or dl.action like @s4 " +
                "ORDER BY dl.id DESC ";
            dvParam.SearchParamCount = 3; //name and description
            dvParam.TitleList = new List<string>() { "", "Date", "User", "Type", "Acton" }; //Column titles
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

        public static DrawerLog getOneDrawerLog(int id)
        {
            DrawerLog drawerLog = new DrawerLog();
            User user = new User();
            try
            {
                String query = "SELECT * FROM drawer_logs where id = '" + id + "'";
                Dictionary<String, String> dbData = DBTransactionService.getDataAsDictionary(query);

                if (dbData != null)
                {
                    drawerLog.date = Convert.ToDateTime(dbData["date"]);
                    drawerLog.user = user;
                    drawerLog.type = dbData["type"];
                    drawerLog.action = dbData["action"];
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
            return drawerLog;
        }
    }
}
