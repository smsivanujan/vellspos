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
    internal class AuthenticationKey
    {
        private Int32 id;
        private String route;
        private String description;

        public AuthenticationKey()
        {

        }

        public AuthenticationKey(int id, string route, string description)
        {
            this.Id = id;
            this.Route = route;
            this.Description = description;
        }

        public int Id { get => id; set => id = value; }
        public string Route { get => route; set => route = value; }
        public string Description { get => description; set => description = value; }

        public static ReturnResult store(AuthenticationKey authenticationKey)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                //store data
                string sql = "INSERT INTO `authentication_keys` " +
                    "(`route`,`description`) VALUES (@route,@description)";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("route", MySqlDbType.String, authenticationKey.route));
                parameters.Add(new QueryParameter("description", MySqlDbType.String, authenticationKey.description));

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

        public static ReturnResult update(AuthenticationKey authenticationKey)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                string sql = "UPDATE `authentication_keys` SET " +
                    "`route` = @route, " +
                    "`description` = @description " +
                    " WHERE `id` = @id ";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("route", MySqlDbType.String, authenticationKey.route));
                parameters.Add(new QueryParameter("description", MySqlDbType.String, authenticationKey.description));
                parameters.Add(new QueryParameter("id", MySqlDbType.Int32, authenticationKey.Id));

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
                string query = "DELETE FROM `authentication_keys` WHERE id = @id";
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
            dvParam.Title = "Authentication Keys";
            dvParam.SelectSql = "SELECT " +
                "ak.id, " +
                "ak.route, " +
                "ak.description ";
            dvParam.FromSql = "FROM  authentication_keys ak " +
                "WHERE " +
                "ak.route like @s1 or " +
                "ak.description like @s2 " +
                "ORDER BY ak.id DESC ";
            dvParam.SearchParamCount = 1; //name and description
            dvParam.TitleList = new List<string>() { "", "Route", "Description" }; //Column titles
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

        public static AuthenticationKey getOneAuthenticationKey(int id)
        {
            AuthenticationKey authenticationKey = new AuthenticationKey();
            try
            {
                String query = "SELECT " +
                    "id, " +
                    "route, " +
                    "description " +
                    "FROM authentication_keys " +
                    "WHERE id = '" + id + "'";
                Dictionary<String, String> dbData = DBTransactionService.getDataAsDictionary(query);

                if (dbData != null)
                {
                    authenticationKey.route = dbData["route"];
                    authenticationKey.description = dbData["description"];
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
            return authenticationKey;
        }
    }
}
