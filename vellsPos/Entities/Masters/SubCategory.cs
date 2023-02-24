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
                parameters.Add(new QueryParameter("id", MySqlDbType.Int32, subCategory.Id));

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

        public static void showOnViewForm(TextBox labelBox = null, TextBox idBox = null)
        {
            DataViewParam dvParam = new DataViewParam();
            dvParam.Title = "Sub Categories";
            dvParam.SelectSql = "SELECT " +
                "sc.id, " +
                "c.category_name, " +
                "sc.sub_category_name, " +
                "sc.description ";
            dvParam.FromSql = "FROM  sub_categories sc " +
                  "INNER JOIN categories c ON sc.category_id = c.id " +
                "WHERE " +
                "c.category_name like @s1 or " +
                "sc.sub_category_name like @s2 " +
                "ORDER BY sc.id DESC ";
            dvParam.SearchParamCount = 1; //name and description
            dvParam.TitleList = new List<string>() { "", "Category", "Sub Category", "Description" }; //Column titles
            dvParam.InvisibleColumnList = new List<int>() { 1 };
            dvParam.NumericColumnList = new List<int>() { };
            dvParam.AddForm = new frmSubCategory();
            dvParam.ViewForm = new frmSubCategory();

            frmView vData = null;

            if (idBox == null && labelBox == null)
                vData = new frmView(dvParam);
            else
                vData = new frmView(dvParam, idBox, labelBox);
            vData.Show();
        }

        public static SubCategory getOneSubCategory(int id)
        {
            SubCategory subCategory = new SubCategory();
            Category category = new Category();
            try
            {
                String query = "SELECT " +
                    "sc.id, " +
                    "c.category_name AS category, " +
                    "sc.sub_category_name, " +
                    "sc.description " +
                    "FROM sub_categories sc " +
                    "INNER JOIN categories c ON sc.category_id = c.id " +
                    "WHERE sc.id = '" + id + "'";
                Dictionary<String, String> dbData = DBTransactionService.getDataAsDictionary(query);

                if (dbData != null)
                {
                    subCategory.subCategoryName = dbData["sub_category_name"];
                    category.CategoryName = dbData["category"];
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
