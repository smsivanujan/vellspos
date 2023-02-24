using Microsoft.VisualBasic.ApplicationServices;
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
    internal class User
    {
        private Int32 id;
        private DateTime date;
        private String userName;
        private Branch branch;
        private Role role;
        private String password;
        private Authentication authentication;

        public User()
        {

        }

        public User(int id, DateTime date, string userName, Branch branch, Role role, string password, Authentication authentication)
        {
            this.Id = id;
            this.Date = date;
            this.UserName = userName;
            this.Branch = branch;
            this.Role = role;
            this.Password = password;
            this.Authentication = authentication;
        }

        public int Id { get => id; set => id = value; }
        public DateTime Date { get => date; set => date = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        internal Branch Branch { get => branch; set => branch = value; }
        internal Role Role { get => role; set => role = value; }
        internal Authentication Authentication { get => authentication; set => authentication = value; }

        public static ReturnResult store(User user)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                //store data
                string sql = "INSERT INTO `users` " +
                    "(`date`,`user_name`,`branch_id`,`role_id`,`password`,`authentication_id`) VALUES (@date,@user_name,@branch_id,@role_id,@password,@authentication_id)";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("date", MySqlDbType.DateTime, user.date));
                parameters.Add(new QueryParameter("user_name", MySqlDbType.String, user.userName));
                parameters.Add(new QueryParameter("branch_id", MySqlDbType.Int32, user.branch.Id));
                parameters.Add(new QueryParameter("role_id", MySqlDbType.Int32, user.role.Id));
                parameters.Add(new QueryParameter("password", MySqlDbType.String, user.password));
                parameters.Add(new QueryParameter("authentication_id", MySqlDbType.Int32, user.authentication.Id));

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

        public static ReturnResult update(User user)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                string sql = "UPDATE `users` SET " +
                    "`date` = @date, " +
                     "`user_name` = @user_name, " +
                    "`branch_id` = @branch_id " +
                    "`role_id` = @role_id, " +
                    "`password` = @password, " +
                    "`authentication_id` = @authentication_id " +
                    " WHERE `id` = @id ";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("date", MySqlDbType.DateTime, user.date));
                parameters.Add(new QueryParameter("user_name", MySqlDbType.String, user.userName));
                parameters.Add(new QueryParameter("branch_id", MySqlDbType.Int32, user.branch.Id));
                parameters.Add(new QueryParameter("role_id", MySqlDbType.Int32, user.role.Id));
                parameters.Add(new QueryParameter("password", MySqlDbType.String, user.password));
                parameters.Add(new QueryParameter("authentication_id", MySqlDbType.Int32, user.authentication.Id));

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
                string query = "DELETE FROM `users` WHERE id = @id";
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
            dvParam.Title = "Users";
            dvParam.SelectSql = "SELECT u.id, u.date, b.branch_name, r.role_name, u.user_name ";
            dvParam.FromSql = "FROM  users u " +
                 "INNER JOIN branches b ON u.branch_id = b.id " +
                  "INNER JOIN roles r ON u.role_id = r.id " +
                "WHERE u.date like @s1 or b.branch_name like @s2 or r.role_name like @s3 or u.user_name like @s4 " +
                "ORDER BY u.id DESC ";
            dvParam.SearchParamCount = 3; //name and description
            dvParam.TitleList = new List<string>() { "", "Date", "Branch", "Role", "User" }; //Column titles
            dvParam.InvisibleColumnList = new List<int>() { 1 };
            dvParam.NumericColumnList = new List<int>() { };
            dvParam.AddForm = new frmUserRegister();
            dvParam.ViewForm = new frmUserRegister();

            frmView vData = null;

            if (idBox == null && labelBox == null)
                vData = new frmView(dvParam);
            else
                vData = new frmView(dvParam, idBox, labelBox);
            vData.Show();
        }

        public static User getOneUser(int id)
        {
            User user = new User();
            Branch branch = new Branch();
            Role role = new Role();
            Authentication authentication = new Authentication();
            try
            {
                String query = "SELECT " +
                    "u.id, " +
                    "u.date, " +
                    "b.branch_name AS branch, " +
                    "r.role_name AS role, " +
                    "u.user_name, " +
                    "u.password " +
                    "FROM users u " +
                    "INNER JOIN branches b ON u.branch_id = b.id " +
                    "INNER JOIN roles r ON u.role_id = r.id " +
                    "WHERE u.id = '" + id + "'";
                Dictionary<String, String> dbData = DBTransactionService.getDataAsDictionary(query);

                if (dbData != null)
                {
                    user.date = Convert.ToDateTime(dbData["date"]);
                    user.userName = dbData["user_name"];
                    branch.BranchName = dbData["branch"];
                    user.branch = branch;
                    role.RoleName = dbData["role"];
                    user.role = role;
                    user.password = dbData["password"];
                    user.authentication = authentication;
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
            return user;
        }
    }
}
