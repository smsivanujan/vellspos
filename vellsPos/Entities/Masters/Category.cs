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
    internal class Category
    {
        private Int32 id;
        private String categoryName; 
        private String image;
        private String description;

        public Category()
        {

        }

        public Category(int id, string categoryName, string image, string description)
        {
            this.Id = id;
            this.CategoryName = categoryName;
            this.Image = image;
            this.Description = description;
        }

        public int Id { get => id; set => id = value; }
        public string CategoryName { get => categoryName; set => categoryName = value; }
        public string Image { get => image; set => image = value; }
        public string Description { get => description; set => description = value; }
        
        public static ReturnResult store(Category category)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                //store data
                string sql = "INSERT INTO `categories` " +
                    "(" +
                    "`category_name`," +
                    "`image`," +
                    "`description`) " +
                    "VALUES (" +
                    "@category_name," +
                    "@image," +
                    "@description)";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("category_name", MySqlDbType.String, category.categoryName));
                parameters.Add(new QueryParameter("image", MySqlDbType.String, category.image));
                parameters.Add(new QueryParameter("description", MySqlDbType.String, category.description));

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

        public static ReturnResult update(Category category)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                string sql = "UPDATE `categories` SET " +
                    "`category_name` = @category_name, " +
                     "`image` = @image, " +
                    "`description` = @description " +
                    " WHERE `id` = @id ";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("category_name", MySqlDbType.String, category.categoryName));
                parameters.Add(new QueryParameter("image", MySqlDbType.String, category.image));
                parameters.Add(new QueryParameter("description", MySqlDbType.String, category.description));
                parameters.Add(new QueryParameter("id", MySqlDbType.Int32, category.Id));

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
                string query = "DELETE FROM `categories` WHERE id = @id";
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
            dvParam.Title = "Categories";
            dvParam.SelectSql = "SELECT " +
                "c.id, " +
                "c.category_name, " +
                "c.description ";
            dvParam.FromSql = "FROM categories c " +
                "WHERE c.category_name like @s1 " +
                "ORDER BY c.id DESC ";
            dvParam.SearchParamCount = 1; //name and description
            dvParam.TitleList = new List<string>() { "", "Category", "Description" }; //Column titles
            dvParam.InvisibleColumnList = new List<int>() { 1 };
            dvParam.NumericColumnList = new List<int>() { };
            dvParam.AddForm = new frmCategory();
            dvParam.ViewForm = new frmCategory();

            frmView vData = null;

            if (idBox == null && labelBox == null)
                vData = new frmView(dvParam);
            else
                vData = new frmView(dvParam, idBox, labelBox);
            vData.Show();
        }

        public static Category getOneCategory(int id)
        {
            Category category = new Category();
            try
            {
                String query = "SELECT " +
                    "id, " +
                    "category_name, " +
                    "image, " +
                    "description " +
                    "FROM categories " +
                    "WHERE id = '" + id + "'";
                Dictionary<String, String> dbData = DBTransactionService.getDataAsDictionary(query);

                if (dbData != null)
                {
                    category.categoryName = dbData["category_name"];
                    category.image = dbData["image"];
                    category.description = dbData["description"];
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
            return category;
        }
    }
}
