using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vellsPos.Forms.Layouts;
using vellsPos.Forms.Masters.User;
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
                parameters.Add(new QueryParameter("id", MySqlDbType.Int32, authentication.Id));

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

        public static void showOnViewForm(TextBox labelBox = null, TextBox idBox = null)
        {
            DataViewParam dvParam = new DataViewParam();
            dvParam.Title = "Authentications";
            dvParam.SelectSql = "SELECT " +
                "a.id, " +
                "r.role_name, " +
                "ak.route, " +
                "ak.description ";
            dvParam.FromSql = "FROM  authentications a " +
                 "INNER JOIN roles r ON a.role_id = r.id " +
                  "INNER JOIN authentication_keys ak ON a.authentication_key_id = ak.id " +
                "WHERE " +
                "r.role_name like @s1 or " +
                "ak.route like @s2 or " +
                "ak.description like @s3 " +
                "ORDER BY a.id DESC ";
            dvParam.SearchParamCount = 2; //name and description
            dvParam.TitleList = new List<string>() { "", "Role", "Route", "Description" }; //Column titles
            dvParam.InvisibleColumnList = new List<int>() { 1 };
            dvParam.NumericColumnList = new List<int>() { };
            dvParam.AddForm = new frmAuthentication();
            dvParam.ViewForm = new frmAuthentication();

            frmView vData = null;

            if (idBox == null && labelBox == null)
                vData = new frmView(dvParam);
            else
                vData = new frmView(dvParam, idBox, labelBox);
            vData.ShowDialog();
        }

        public static Authentication getOneAuthentication(int id)
        {
            Authentication authentication = new Authentication();
            AuthenticationKey authenticationKey = new AuthenticationKey();
            Role role = new Role();
            try
            {
                String query = "SELECT " +
                    "a.id, " +
                    "r.role_name AS role, " +
                    "ak.route AS route, " +
                    "ak.description " +
                    "FROM authentications a " +
                    "INNER JOIN roles r ON a.role_id = r.id " +
                   "INNER JOIN authentication_keys ak ON a.authentication_key_id = ak.id " +
                    "WHERE a.id = '" + id + "'";
                Dictionary<String, String> dbData = DBTransactionService.getDataAsDictionary(query);

                if (dbData != null)
                {
                    role.Id = Convert.ToInt32(dbData["role_id"]);
                    role.RoleName = dbData["role"];
                    authentication.role= role;
                    authenticationKey.Route = dbData["route"];
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
