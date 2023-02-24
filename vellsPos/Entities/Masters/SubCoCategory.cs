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
    internal class SubCoCategory
    {
        private Int32 id;
        private String subCoCategoryName;
        private SubCategory subCategory;
        private String image;
        private String description;


        public SubCoCategory()
        {

        }

        public SubCoCategory(int id, string subCoCategoryName, SubCategory subCategory, string image, string description)
        {
            this.Id = id;
            this.SubCoCategoryName = subCoCategoryName;
            this.SubCategory = subCategory;
            this.Image = image;
            this.Description = description;
        }

        public int Id { get => id; set => id = value; }
        public string SubCoCategoryName { get => subCoCategoryName; set => subCoCategoryName = value; }
        internal SubCategory SubCategory { get => subCategory; set => subCategory = value; }
        public string Image { get => image; set => image = value; }
        public string Description { get => description; set => description = value; }

        public static ReturnResult store(SubCoCategory subCoCategory)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                //store data
                string sql = "INSERT INTO `sub_co_categories` " +
                    "(`sub_co_category_name`,`sub_category_id`,`image`,`description`) VALUES (@sub_co_category_name,@sub_category_id,@image,@description)";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("sub_co_category_name", MySqlDbType.String, subCoCategory.SubCoCategoryName));
                parameters.Add(new QueryParameter("sub_category_id", MySqlDbType.Int32, subCoCategory.SubCategory.Id));
                parameters.Add(new QueryParameter("image", MySqlDbType.String, subCoCategory.image));
                parameters.Add(new QueryParameter("description", MySqlDbType.String, subCoCategory.Description));

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
                     "`image` = @image, " +
                    "`description` = @description " +
                    " WHERE `id` = @id ";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("sub_co_category_name", MySqlDbType.String, subCoCategory.SubCoCategoryName));
                parameters.Add(new QueryParameter("sub_category_id", MySqlDbType.Int32, subCoCategory.SubCategory.Id));
                parameters.Add(new QueryParameter("image", MySqlDbType.String, subCoCategory.image));
                parameters.Add(new QueryParameter("description", MySqlDbType.String, subCoCategory.Description));
                parameters.Add(new QueryParameter("id", MySqlDbType.Int32, subCoCategory.Id));

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

        public static void showOnViewForm(TextBox labelBox = null, TextBox idBox = null)
        {
            DataViewParam dvParam = new DataViewParam();
            dvParam.Title = "Sub Co Categories";
            dvParam.SelectSql = "SELECT " +
                "scc.id, c.category_name, " +
                "sc.sub_category_name, " +
                "scc.sub_co_category_name, " +
                "scc.description ";
            dvParam.FromSql = "FROM sub_co_categories scc " +
                 "INNER JOIN sub_categories sc ON scc.sub_category_id = sc.id " +
                 "INNER JOIN categories c ON sc.category_id = c.id " +
                "WHERE " +
                "c.category_name like @s1 or " +
                "sc.sub_category_name like @s2 or " +
                "scc.sub_co_category_name like @s3 " +
                "ORDER BY scc.id DESC ";
            dvParam.SearchParamCount = 2; //name and description
            dvParam.TitleList = new List<string>() { "", "Category", "Sub Category", "Sub Co Category", "Description" }; //Column titles
            dvParam.InvisibleColumnList = new List<int>() { 1 };
            dvParam.NumericColumnList = new List<int>() { };
            dvParam.AddForm = new frmSubCoCategory();
            dvParam.ViewForm = new frmSubCoCategory();

            frmView vData = null;

            if (idBox == null && labelBox == null)
                vData = new frmView(dvParam);
            else
                vData = new frmView(dvParam, idBox, labelBox);
            vData.Show();
        }

        public static SubCoCategory getOneSubCoCategory(int id)
        {
            SubCoCategory subCoCategory = new SubCoCategory();
            SubCategory subCategory = new SubCategory();
            Category category = new Category();
            try
            {
                String query = "SELECT " +
                    "scc.id, " +
                    "c.category_name AS category, " +
                    "sc.sub_category_name AS subCategory, " +
                    "scc.sub_co_category_name, " +
                    "scc.description " +
                    "FROM sub_co_categories scc " +
                    "INNER JOIN sub_categories sc ON scc.sub_category_id = sc.id " +
                    "INNER JOIN categories c ON sc.category_id = c.id " +
                    "WHERE scc.id = '" + id + "'";
                Dictionary<String, String> dbData = DBTransactionService.getDataAsDictionary(query);

                if (dbData != null)
                {
                    subCoCategory.subCoCategoryName = dbData["sub_co_category_name"];
                    category.CategoryName = dbData["category"];
                    subCategory.Category = category;
                    subCategory.SubCategoryName = dbData["subCategory"];
                    subCoCategory.subCategory = subCategory;
                    subCoCategory.image = dbData["image"];
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
