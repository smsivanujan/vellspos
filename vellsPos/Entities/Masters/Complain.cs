using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vellsPos.Services;

namespace vellsPos.Entities.Masters
{
    internal class Complain
    {
        private Int32 id;
        private DateTime date;
        private String description;
        private String priority;
        private Int32 status;
        private User user;

        public Complain()
        {

        }

        public Complain(int id, DateTime date, string description, string priority, int status, User user)
        {
            this.Id = id;
            this.Date = date;
            this.Description = description;
            this.Priority = priority;
            this.Status = status;
            this.User = user;
        }

        public int Id { get => id; set => id = value; }
        public DateTime Date { get => date; set => date = value; }
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
                    "(`date`,`description`,`priority`,`status`,`user_id`) VALUES (@date,@priority,@description,@status,@user_id)";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("date", MySqlDbType.DateTime, complain.date));
                parameters.Add(new QueryParameter("description", MySqlDbType.String, complain.description));
                parameters.Add(new QueryParameter("priority", MySqlDbType.String, complain.priority));
                parameters.Add(new QueryParameter("status", MySqlDbType.Int32, complain.Status));
                parameters.Add(new QueryParameter("user_id", MySqlDbType.Int32, complain.user.Id));

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
                parameters.Add(new QueryParameter("date", MySqlDbType.DateTime, complain.date));
                parameters.Add(new QueryParameter("description", MySqlDbType.String, complain.description));
                parameters.Add(new QueryParameter("priority", MySqlDbType.String, complain.priority));
                parameters.Add(new QueryParameter("status", MySqlDbType.Int32, complain.Status));
                parameters.Add(new QueryParameter("user_id", MySqlDbType.Int32, complain.user.Id));

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

        public static Complain getOneComplain(int id)
        {
            Complain complain = new Complain();
            User user = new User();
            try
            {
                String query = "SELECT * FROM complains where id = '" + id + "'";
                Dictionary<String, String> dbData = DBTransactionService.getDataAsDictionary(query);

                if (dbData != null)
                {
                    complain.date = Convert.ToDateTime(dbData["date"]);
                    complain.description = dbData["description"];
                    complain.priority = dbData["priority"];
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
