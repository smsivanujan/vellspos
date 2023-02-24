using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using vellsPos.Forms.Layouts;
using vellsPos.Services;

namespace vellsPos.Entities.Masters
{
    internal class Complain
    {
        private Int32 id;
        private String date;
        private string type;
        private String description;
        private String priority;
        private Int32 status;
        private User user;

        public Complain()
        {

        }

        public Complain(int id, string date, string type, string description, string priority, int status, User user)
        {
            this.Id = id;
            this.Date = date;
            this.Type = type;
            this.Description = description;
            this.Priority = priority;
            this.Status = status;
            this.User = user;
        }

        public int Id { get => id; set => id = value; }
        public string Date { get => date; set => date = value; }
        public string Type { get => type; set => type = value; }
        public string Description { get => description; set => description = value; }
        public string Priority { get => priority; set => priority = value; }
        public int Status { get => status; set => status = value; }
        internal User User { get => user; set => user = value; }

        public static ReturnResult store(Complain complain)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                //store data
                string sql = "INSERT INTO `complains` " +
                    "(`date`,`description`,`priority`,`type`,`status`,`user_id`) " +
                    "VALUES (@date,@priority,@description,@type,@status,@user_id)";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("date", MySqlDbType.String, complain.Date));
                parameters.Add(new QueryParameter("description", MySqlDbType.String, complain.Description));
                parameters.Add(new QueryParameter("priority", MySqlDbType.String, complain.Priority));
                parameters.Add(new QueryParameter("type", MySqlDbType.String, complain.type));
                parameters.Add(new QueryParameter("status", MySqlDbType.Int32, complain.Status));
                parameters.Add(new QueryParameter("user_id", MySqlDbType.Int32, complain.User.Id));

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

        public static ReturnResult update(Complain complain)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                string sql = "UPDATE `complains` SET " +
                    "`date` = @date, " +
                     "`description` = @description, " +
                      "`priority` = @priority, " +
                     "`status` = @status, " +
                    "`user_id` = @user_id " +
                    " WHERE `id` = @id ";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("id", MySqlDbType.Int32, complain.Id));
                parameters.Add(new QueryParameter("date", MySqlDbType.String, complain.Date));
                parameters.Add(new QueryParameter("description", MySqlDbType.String, complain.Description));
                parameters.Add(new QueryParameter("priority", MySqlDbType.String, complain.Priority));
                parameters.Add(new QueryParameter("type", MySqlDbType.String, complain.type));
                parameters.Add(new QueryParameter("status", MySqlDbType.Int32, complain.Status));
                parameters.Add(new QueryParameter("user_id", MySqlDbType.Int32, complain.User.Id));

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
                string query = "DELETE FROM `complains` WHERE id = @id";
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
            dvParam.Title = "Complains";
            dvParam.SelectSql = "SELECT " +
                "c.id, " +
                "date_format(c.date,'%Y-%m-%d %H:%i'), " +
                "c.type, " +
                "c.priority, " +
                "c.description, " +
                "c.status ";
            dvParam.FromSql = "FROM  complains c " +
                "WHERE c.date like @s1 or " +
                "c.type like @s2 or " +
                "c.priority like @s3 or " +
                "c.status like @s4 " +
                "ORDER BY c.id DESC ";
            dvParam.SearchParamCount = 3; //name and description
            dvParam.TitleList = new List<string>() { "", "Date", "Type", "Priority", "Description", "Status" }; //Column titles
            dvParam.InvisibleColumnList = new List<int>() { 1 };
            dvParam.NumericColumnList = new List<int>() { };
            dvParam.AddForm = new frmComplain();
            dvParam.ViewForm = new frmComplain();

            frmView vData = null;

            if (idBox == null && labelBox == null)
                vData = new frmView(dvParam);
            else
                vData = new frmView(dvParam, idBox, labelBox);
            vData.Show();
        }

        public static Complain getOneComplain(int id)
        {
            Complain complain = new Complain();
            User user = new User();
            try
            {
                String query = "SELECT " +
                    "id, " +
                    "date_format(date,'%Y-%m-%d %H:%i') AS date, " +
                    "type, " +
                    "priority, " +
                    "description, " +
                    "status " +
                    "FROM complains " +
                    "WHERE id = '" + id + "'";
                Dictionary<String, String> dbData = DBTransactionService.getDataAsDictionary(query);

                if (dbData != null)
                {
                    complain.date = dbData["date"];
                    complain.description = dbData["description"];
                    complain.priority = dbData["priority"];
                    complain.type = dbData["type"];
                    complain.status = Convert.ToInt32(dbData["status"]);
                    complain.user = user;
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
            return complain;
        }
    }
}
