using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vellsPos.Forms.Layouts;
using vellsPos.Forms.Masters.Setting;
using vellsPos.Services;

namespace vellsPos.Entities.Masters
{
    internal class Activation
    {
        private Int32 id;
        private String date;
        private String endDate;
        private String serialKey;
        private Int32 status;

        public Activation()
        {

        }

        public Activation(int id, string date, string endDate, string serialKey, int status)
        {
            this.Id = id;
            this.Date = date;
            this.EndDate = endDate;
            this.SerialKey = serialKey;
            this.Status = status;
        }

        public int Id { get => id; set => id = value; }
        public string Date { get => date; set => date = value; }
        public string EndDate { get => endDate; set => endDate = value; }
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
                    "(`date`,`serial_key`,`end_date`,`status`) VALUES (@date,@serial_key,@end_date,@status)";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("date", MySqlDbType.String, activation.Date));
                parameters.Add(new QueryParameter("serial_key", MySqlDbType.String, activation.SerialKey));
                parameters.Add(new QueryParameter("end_date", MySqlDbType.String, activation.Date));
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

        //public static ReturnResult update(Activation activation)
        //{
        //    ReturnResult result = new ReturnResult(false, "Error");
        //    List<QueryCommand> commands = new List<QueryCommand>();
        //    try
        //    {
        //        string sql = "UPDATE `activations` SET " +
        //            "`date` = @date, " +
        //             "`serial_key` = @serial_key, " +
        //              "`end_date` = @end_date, " +
        //            "`status` = @status " +
        //            " WHERE `id` = @id ";
        //        List<QueryParameter> parameters = new List<QueryParameter>();
        //        parameters.Add(new QueryParameter("date", MySqlDbType.String, activation.Date));
        //        parameters.Add(new QueryParameter("serial_key", MySqlDbType.String, activation.SerialKey));
        //        parameters.Add(new QueryParameter("end_date", MySqlDbType.String, activation.Date));
        //        parameters.Add(new QueryParameter("status", MySqlDbType.Int32, activation.Status));

        //        commands.Add(new QueryCommand(sql, parameters));
        //        result = DBTransactionService.executeNonQuery(commands);
        //        if (result.Status)
        //            result.Msg = Constants.MSG_UPDATE_SUCCESS;
        //    }
        //    catch (Exception e)
        //    {
        //        result = new ReturnResult(false, Constants.MSG_ERROR, e.Message, e);
        //        // MessageBox.Show(result);
        //    }
        //    return result;
        //}

        //public static ReturnResult delete(int id)
        //{
        //    ReturnResult result = new ReturnResult(false, "Error");
        //    List<QueryCommand> commands = new List<QueryCommand>();
        //    try
        //    {
        //        string query = "DELETE FROM `activations` WHERE id = @id";
        //        List<QueryParameter> parameters = new List<QueryParameter>();
        //        parameters.Add(new QueryParameter("id", MySqlDbType.Int32, id));
        //        commands.Add(new QueryCommand(query, parameters));
        //        result = DBTransactionService.executeNonQuery(commands);
        //        if (result.Status)
        //            result.Msg = Constants.MSG_DELETE_SUCCESS;
        //    }
        //    catch (Exception e)
        //    {
        //        result = new ReturnResult(false, Constants.MSG_ERROR, e.Message, e);
        //        // MessageBox.Show(result);
        //    }
        //    return result;
        //}

        public static void showOnViewForm(TextBox labelBox = null, TextBox idBox = null)
        {
            DataViewParam dvParam = new DataViewParam();
            dvParam.Title = "Activations";
            dvParam.SelectSql = "SELECT " +
                "a.id, " +
                "date_format(a.date,'%Y-%m-%d %H:%i'), " +
                "date_format(a.end_date,'%Y-%m-%d %H:%i'), a.status ";
            dvParam.FromSql = "FROM  activations a " +
                "WHERE " +
                "a.date like @s1 or " +
                "a.end_date like @s2 or " +
                "a.status like @s3 " +
                "ORDER BY a.id DESC ";
            dvParam.SearchParamCount = 2; //name and description
            dvParam.TitleList = new List<string>() { "", "Acitivation Date", "Expiry Date", "Status" }; //Column titles
            dvParam.InvisibleColumnList = new List<int>() { 1 };
            dvParam.NumericColumnList = new List<int>() { };
            dvParam.AddForm = new frmActivations();
            dvParam.ViewForm = new frmActivations();

            frmView vData = null;

            if (idBox == null && labelBox == null)
                vData = new frmView(dvParam);
            else
                vData = new frmView(dvParam, idBox, labelBox);
            vData.ShowDialog();
        }

        //public static Activation getOneActivation(int id)
        //{
        //    Activation activation = new Activation();
        //    try
        //    {
        //        String query = "SELECT " +
        //            "id, " +
        //            "date, " +
        //            "end_date, " +
        //            "status " +
        //            "FROM activations " +
        //            "WHERE id = '" + id + "'";
        //        Dictionary<String, String> dbData = DBTransactionService.getDataAsDictionary(query);

        //        if (dbData != null)
        //        {
        //            activation.Date = dbData["date"];
        //            activation.Date = dbData["end_date"];
        //            activation.SerialKey = dbData["serial_key"];
        //            activation.Status = Convert.ToInt32(dbData["status"]);
        //        }
        //        else
        //        {
        //            //
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //    return activation;
        //}
    }
}
