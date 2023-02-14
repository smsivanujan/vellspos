using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vellsPos.Services;

namespace vellsPos.Entities.Masters
{
    internal class SubCategory
    {
        private Int32 id;
        private String subCategoryName;
        private Category category;
        private String image;
        private String description;

        public SubCategory()
        {

        }

        public SubCategory(int id, string subCategoryName, Category category, string image, string description)
        {
            this.Id = id;
            this.SubCategoryName = subCategoryName;
            this.Category = category;
            this.Image = image;
            this.Description = description;
        }

        public int Id { get => id; set => id = value; }
        public string SubCategoryName { get => subCategoryName; set => subCategoryName = value; }
        public string Image { get => image; set => image = value; }
        public string Description { get => description; set => description = value; }
        internal Category Category { get => category; set => category = value; }

        public static ReturnResult store(SubCategory subCategory)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                //store data
                string sql = "INSERT INTO `sub_categories` " +
                    "(`sub_category_name`,`category_id`,`image`,`description`) VALUES (@sub_category_name,@category_id,@image,@description)";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("sub_category_name", MySqlDbType.String, subCategory.subCategoryName));
                parameters.Add(new QueryParameter("category_id", MySqlDbType.Int32, subCategory.category.Id));
                parameters.Add(new QueryParameter("image", MySqlDbType.String, subCategory.image));
                parameters.Add(new QueryParameter("description", MySqlDbType.String, subCategory.description));

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

        public static ReturnResult update(SubCategory subCategory)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                string sql = "UPDATE `sub_categories` SET " +
                    "`sub_category_name` = @sub_category_name, " +
                     "`category_id` = @category_id, " +
                     "`image` = @image, " +
                    "`description` = @description " +
                    " WHERE `id` = @id ";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("sub_category_name", MySqlDbType.String, subCategory.subCategoryName));
                parameters.Add(new QueryParameter("category_id", MySqlDbType.Int32, subCategory.category.Id));
                parameters.Add(new QueryParameter("image", MySqlDbType.String, subCategory.image));
                parameters.Add(new QueryParameter("description", MySqlDbType.String, subCategory.description));

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
                string query = "DELETE FROM `sub_categories` WHERE id = @id";
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

        public static SubCategory getOneSubCatrgory(int id)
        {
            SubCategory subCategory = new SubCategory();
            Category category = new Category();
            try
            {
                String query = "SELECT * FROM sub_categories where id = '" + id + "'";
                Dictionary<String, String> dbData = DBTransactionService.getDataAsDictionary(query);

                if (dbData != null)
                {
                    subCategory.subCategoryName = dbData["sub_category_name"];
                    subCategory.category = category;
                    subCategory.image = dbData["image"];
                    subCategory.description = dbData["description"];
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
            return subCategory;
        }
    }
}
