using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vellsPos.Services;

namespace vellsPos.Entities.Masters
{
    internal class SubCoCategory
    {
        private Int32 id;
        private String subCoCategoryName;
        private SubCategory subCategory;
        private String description;

        public SubCoCategory()
        {

        }

        public SubCoCategory(int id, string subCoCategoryName, SubCategory subCategory, string description)
        {
            this.Id = id;
            this.SubCoCategoryName = subCoCategoryName;
            this.SubCategory = subCategory;
            this.Description = description;
        }

        public int Id { get => id; set => id = value; }
        public string SubCoCategoryName { get => subCoCategoryName; set => subCoCategoryName = value; }
        public string Description { get => description; set => description = value; }
        internal SubCategory SubCategory { get => subCategory; set => subCategory = value; }

        public static ReturnResult store(SubCoCategory subCoCategory)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                //store data
                string sql = "INSERT INTO `sub_co_categories` " +
                    "(`sub_co_category_name`,`sub_category_id`,`description`) VALUES (@sub_co_category_name,@sub_category_id,@description)";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("sub_co_category_name", MySqlDbType.String, subCoCategory.subCoCategoryName));
                parameters.Add(new QueryParameter("sub_category_id", MySqlDbType.Int32, subCoCategory.SubCategory.Id));
                parameters.Add(new QueryParameter("description", MySqlDbType.String, subCoCategory.description));

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

        public static ReturnResult update(SubCoCategory subCoCategory)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                string sql = "UPDATE `sub_co_categories` SET " +
                    "`sub_co_category_name` = @sub_co_category_name, " +
                     "`sub_category_id` = @sub_category_id, " +
                    "`description` = @description " +
                    " WHERE `id` = @id ";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("sub_co_category_name", MySqlDbType.String, subCoCategory.subCoCategoryName));
                parameters.Add(new QueryParameter("sub_category_id", MySqlDbType.Int32, subCoCategory.SubCategory.Id));
                parameters.Add(new QueryParameter("description", MySqlDbType.String, subCoCategory.description));

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
                string query = "DELETE FROM `sub_co_categories` WHERE id = @id";
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

        public static SubCoCategory getOneSubCategory(int id)
        {
            SubCoCategory subCoCategory = new SubCoCategory();
            SubCategory subCategory = new SubCategory();
            try
            {
                String query = "SELECT * FROM sub_co_categories where id = '" + id + "'";
                Dictionary<String, String> dbData = DBTransactionService.getDataAsDictionary(query);

                if (dbData != null)
                {
                    subCoCategory.subCoCategoryName = dbData["sub_co_category_name"];
                    subCoCategory.subCategory = subCategory;
                    subCoCategory.description = dbData["description"];
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
            return subCoCategory;
        }
    }
}
