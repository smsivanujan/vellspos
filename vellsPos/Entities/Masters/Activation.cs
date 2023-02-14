using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vellsPos.Services;

namespace vellsPos.Entities.Masters
{
    internal class Activation
    {
        private Int32 id;
        private DateTime date;
        private String serialKey;
        private Int32 status;

        public Activation()
        {

        }

        public Activation(int id, DateTime date, string serialKey, int status)
        {
            this.Id = id;
            this.Date = date;
            this.SerialKey = serialKey;
            this.Status = status;
        }

        public int Id { get => id; set => id = value; }
        public DateTime Date { get => date; set => date = value; }
        public string SerialKey { get => serialKey; set => serialKey = value; }
        public int Status { get => status; set => status = value; }

        public static ReturnResult store(Activation activation)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                //store data
                string sql = "INSERT INTO `activations` " +
                    "(`date`,`serial_key`,`status`) VALUES (@date,@serial_key,@status)";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("date", MySqlDbType.DateTime, activation.Date));
                parameters.Add(new QueryParameter("serial_key", MySqlDbType.String, activation.serialKey));
                parameters.Add(new QueryParameter("status", MySqlDbType.Int32, activation.Status));

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

        public static ReturnResult update(Activation activation)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                string sql = "UPDATE `activations` SET " +
                    "`date` = @date, " +
                     "`serial_key` = @serial_key, " +
                    "`status` = @status " +
                    " WHERE `id` = @id ";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("date", MySqlDbType.DateTime, activation.Date));
                parameters.Add(new QueryParameter("serial_key", MySqlDbType.String, activation.serialKey));
                parameters.Add(new QueryParameter("status", MySqlDbType.Int32, activation.Status));

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
                string query = "DELETE FROM `activations` WHERE id = @id";
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

        public static Activation getOneActivation(int id)
        {
            Activation activation = new Activation();
            try
            {
                String query = "SELECT * FROM activations where id = '" + id + "'";
                Dictionary<String, String> dbData = DBTransactionService.getDataAsDictionary(query);

                if (dbData != null)
                {
                    activation.Date = Convert.ToDateTime(dbData["date"]);
                    activation.serialKey = dbData["serial_key"];
                    activation.Status = Convert.ToInt32(dbData["status"]);
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
            return activation;
        }
    }
}
