using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vellsPos.Services;

namespace vellsPos.Entities.Masters
{
    internal class DBUpload
    {
        private Int32 id;
        private DateTime uploadDate;
        private String api;
        private String type;
        private Int32 status;
        private String description;

        public DBUpload()
        {


        }
        public DBUpload(int id, DateTime uploadDate, string api, string type, int status, string description)
        {
            this.Id = id;
            this.UploadDate = uploadDate;
            this.Api = api;
            this.Type = type;
            this.Status = status;
            this.Description = description;
        }

        public int Id { get => id; set => id = value; }
        public DateTime UploadDate { get => uploadDate; set => uploadDate = value; }
        public string Api { get => api; set => api = value; }
        public string Type { get => type; set => type = value; }
        public int Status { get => status; set => status = value; }
        public string Description { get => description; set => description = value; }

        public static ReturnResult store(DBUpload dBUpload)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                //store data
                string sql = "INSERT INTO `db_uploads` " +
                    "(`upload_date`,`api`,`type`,`status`,`description`) VALUES (@upload_date,@api,@type,@status,@description)";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("upload_date", MySqlDbType.DateTime, dBUpload.uploadDate));
                parameters.Add(new QueryParameter("api", MySqlDbType.String, dBUpload.api));
                parameters.Add(new QueryParameter("type", MySqlDbType.String, dBUpload.type));
                parameters.Add(new QueryParameter("status", MySqlDbType.Int32, dBUpload.status));
                parameters.Add(new QueryParameter("description", MySqlDbType.String, dBUpload.Description));

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

        public static ReturnResult update(DBUpload dBUpload)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                string sql = "UPDATE `db_uploads` SET " +
                    "`upload_date` = @upload_date, " +
                     "`api` = @api, " +
                     "`type` = @type, " +
                     "`status` = @status, " +
                    "`description` = @description " +
                    " WHERE `id` = @id ";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("upload_date", MySqlDbType.DateTime, dBUpload.uploadDate));
                parameters.Add(new QueryParameter("api", MySqlDbType.String, dBUpload.api));
                parameters.Add(new QueryParameter("type", MySqlDbType.String, dBUpload.type));
                parameters.Add(new QueryParameter("status", MySqlDbType.Int32, dBUpload.status));
                parameters.Add(new QueryParameter("description", MySqlDbType.String, dBUpload.Description));

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
                string query = "DELETE FROM `db_uploads` WHERE id = @id";
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
            dvParam.Title = "Database Uploads";
            dvParam.SelectSql = "SELECT du.id, du.upload_date, du.type, du.status, du.description ";
            dvParam.FromSql = "FROM  db_uploads du " +
                "WHERE du.upload_date like @s1 or du.type like @s2 or  du.status like @s3 or du.descriptionn like @s4 " +
                "ORDER BY du.id DESC ";
            dvParam.SearchParamCount = 3; //name and description
            dvParam.TitleList = new List<string>() { "", "Date", "Type", "Status", "Description" }; //Column titles
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

        public static DBUpload getOneDBUpload(int id)
        {
            DBUpload dBUpload = new DBUpload();
            try
            {
                String query = "SELECT * FROM db_uploads where id = '" + id + "'";
                Dictionary<String, String> dbData = DBTransactionService.getDataAsDictionary(query);

                if (dbData != null)
                {
                    dBUpload.uploadDate = Convert.ToDateTime(dbData["upload_date"]);
                    dBUpload.api = dbData["api"];
                    dBUpload.type = dbData["type"];
                    dBUpload.status = Convert.ToInt32(dbData["status"]);
                    dBUpload.description = dbData["description"];
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
            return dBUpload;
        }
    }
}
