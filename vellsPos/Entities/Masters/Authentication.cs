using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vellsPos.Services;

namespace vellsPos.Entities.Masters
{
    internal class Authentication
    {
        private Int32 id;
        private Role role;
        private AuthenticationKey authenticationKey;

        public Authentication()
        {

        }

        public Authentication(int id, Role role, AuthenticationKey authenticationKey)
        {
            this.Id = id;
            this.Role = role;
            this.AuthenticationKey = authenticationKey;
        }

        public int Id { get => id; set => id = value; }
        internal Role Role { get => role; set => role = value; }
        internal AuthenticationKey AuthenticationKey { get => authenticationKey; set => authenticationKey = value; }

        public static ReturnResult store(Authentication authentication)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                //store data
                string sql = "INSERT INTO `authentications` " +
                    "(`role_id`,`authentication_key_id`) VALUES (@role_id,@authentication_key_id)";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("role_id", MySqlDbType.Int32, authentication.role.Id));
                parameters.Add(new QueryParameter("authentication_key_id", MySqlDbType.Int32, authentication.authenticationKey.Id));

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

        public static ReturnResult update(Authentication authentication)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                string sql = "UPDATE `authentications` SET " +
                    "`role_id` = @role_id, " +
                     "`authentication_key_id` = @authentication_key_id " +
                    " WHERE `id` = @id ";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("role_id", MySqlDbType.Int32, authentication.role.Id));
                parameters.Add(new QueryParameter("authentication_key_id", MySqlDbType.Int32, authentication.authenticationKey.Id));

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
                string query = "DELETE FROM `authentications` WHERE id = @id";
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

        public static Authentication getOneAuthentication(int id)
        {
            Authentication authentication = new Authentication();
            AuthenticationKey authenticationKey = new AuthenticationKey();
            try
            {
                String query = "SELECT * FROM settings where id = '" + id + "'";
                Dictionary<String, String> dbData = DBTransactionService.getDataAsDictionary(query);

                if (dbData != null)
                {
                    authentication.role.Id = Convert.ToInt32(dbData["role_id"]);
                    authentication.authenticationKey = authenticationKey;
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
            return authentication;
        }
    }
}
