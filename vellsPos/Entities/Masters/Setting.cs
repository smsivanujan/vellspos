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
    internal class Setting
    {
        private Int32 id;
        private String keyName;
        private String keyValue;
        private String description;


        public Setting()
        {

        }

        public Setting(int id, string keyName, string keyValue, string description)
        {
            this.Id = id;
            this.KeyName = keyName;
            this.KeyValue = keyValue;
            this.Description = description;
        }

        public int Id { get => id; set => id = value; }
        public string KeyName { get => keyName; set => keyName = value; }
        public string KeyValue { get => keyValue; set => keyValue = value; }
        public string Description { get => description; set => description = value; }

        public static ReturnResult store(Setting setting)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                //store data
                string sql = "INSERT INTO `settings` " +
                    "(`key_name`,`key_value`,`description`) VALUES (@key_name,@key_value,@description)";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("key_name", MySqlDbType.String, setting.keyName));
                parameters.Add(new QueryParameter("key_value", MySqlDbType.String, setting.keyValue));
                parameters.Add(new QueryParameter("description", MySqlDbType.String, setting.Description));
                parameters.Add(new QueryParameter("id", MySqlDbType.Int32, setting.Id));

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

        public static ReturnResult update(Setting setting)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                string sql = "UPDATE `settings` SET " +
                    "`key_name` = @key_name, " +
                     "`key_value` = @key_value, " +
                    "`description` = @description " +
                    " WHERE `id` = @id ";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("key_name", MySqlDbType.String, setting.keyName));
                parameters.Add(new QueryParameter("key_value", MySqlDbType.String, setting.keyValue));
                parameters.Add(new QueryParameter("description", MySqlDbType.String, setting.Description));

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
                string query = "DELETE FROM `settings` WHERE id = @id";
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
            dvParam.Title = "Setings";
            dvParam.SelectSql = "SELECT " +
                "s.id, " +
                "s.key_name, " +
                "s.key_value, " +
                "s.description ";
            dvParam.FromSql = "FROM  settings s " +
                "WHERE s.key_name like @s1 or s.key_value like @s2 " +
                "ORDER BY s.id DESC ";
            dvParam.SearchParamCount = 3; //name and description
            dvParam.TitleList = new List<string>() { "", "Key", "Value" }; //Column titles
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

        public static Setting getOneSetting(int id)
        {
            Setting setting = new Setting();
            try
            {
                String query = "SELECT  " +
                    "id, " +
                    "key_name, " +
                    "key_value, " +
                    "description " +
                    "FROM settings " +
                    "WHERE id = '" + id + "'";
                Dictionary<String, String> dbData = DBTransactionService.getDataAsDictionary(query);

                if (dbData != null)
                {
                    setting.keyName = dbData["key_name"];
                    setting.keyValue = dbData["key_value"];
                    setting.description = dbData["description"];
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
            return setting;
        }
    }
}
