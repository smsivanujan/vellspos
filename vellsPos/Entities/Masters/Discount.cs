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
    internal class Discount
    {
        private Int32 id;
        private String discountName;
        private String dateTo;
        private String dateFrom;
        private Int32 type;
        private Decimal value;
        private Int32 status;
        private String description;
        private User user;

        public Discount()
        {

        }

        public Discount(int id, string discountName, string dateTo, string dateFrom, int type, decimal value, int status, string description, User user)
        {
            this.id = id;
            this.discountName = discountName;
            this.dateTo = dateTo;
            this.dateFrom = dateFrom;
            this.type = type;
            this.value = value;
            this.status = status;
            this.description = description;
            this.user = user;
        }

        public int Id { get => id; set => id = value; }
        public string DiscountName { get => discountName; set => discountName = value; }
        public string DateTo { get => dateTo; set => dateTo = value; }
        public string DateFrom { get => dateFrom; set => dateFrom = value; }
        public int Type { get => type; set => type = value; }
        public decimal Value { get => value; set => this.value = value; }
        public int Status { get => status; set => status = value; }
        public string Description { get => description; set => description = value; }
        internal User User { get => user; set => user = value; }

        public static ReturnResult store(Discount discount)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                //store data
                string sql = "INSERT INTO `discounts` " +
                    "(`discount_name`,`date_to`,`date_from`,`type`,`value`,`status`,`description`,`user_id`) " +
                    "VALUES (@discount_name,@date_to,@date_from,@type,@value,@status,@description,@user_id)";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("discount_name", MySqlDbType.String, discount.DiscountName));
                parameters.Add(new QueryParameter("date_to", MySqlDbType.String, discount.DateFrom));
                parameters.Add(new QueryParameter("date_from", MySqlDbType.String, discount.DateTo));
                parameters.Add(new QueryParameter("type", MySqlDbType.Int32, discount.Type));
                parameters.Add(new QueryParameter("value", MySqlDbType.Decimal, discount.value));
                parameters.Add(new QueryParameter("status", MySqlDbType.Int32, discount.Status));
                parameters.Add(new QueryParameter("description", MySqlDbType.String, discount.Description));
                parameters.Add(new QueryParameter("user_id", MySqlDbType.Int32, discount.User.Id));

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

        public static ReturnResult update(Discount discount)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                string sql = "UPDATE `discounts` SET " +
                    "`discount_name` = @discount_name, " +
                     "`date_to` = @date_to, " +
                     "`date_from` = @date_from, " +
                      "`type` = @type, " +
                       "`value` = @value, " +
                     "`status` = @status, " +
                     "`description` = @description, " +
                     "`user_id` = @user_id " +
                    " WHERE `id` = @id ";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("discount_name", MySqlDbType.String, discount.DiscountName));
                parameters.Add(new QueryParameter("date_to", MySqlDbType.String, discount.DateFrom));
                parameters.Add(new QueryParameter("date_from", MySqlDbType.String, discount.DateTo));
                parameters.Add(new QueryParameter("type", MySqlDbType.Int32, discount.Type));
                parameters.Add(new QueryParameter("value", MySqlDbType.Decimal, discount.value));
                parameters.Add(new QueryParameter("status", MySqlDbType.Int32, discount.Status));
                parameters.Add(new QueryParameter("description", MySqlDbType.String, discount.Description));
                parameters.Add(new QueryParameter("user_id", MySqlDbType.Int32, discount.User.Id));
                parameters.Add(new QueryParameter("id", MySqlDbType.Int32, discount.Id));

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
                string query = "DELETE FROM `discounts` WHERE id = @id";
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
            dvParam.Title = "Discounts";
            dvParam.SelectSql = "SELECT " +
                "d.id, " +
                "d.discount_name, " +
                "date_format(d.date_to,'%Y-%m-%d %H:%i'), " +
                "date_format(d.date_from,'%Y-%m-%d %H:%i'), " +
                 "IF(d.type=0,'Percentage','Amount'), " +
                 "d.value, " +
                "d.description, " +
                "IF(d.status=0,'Inactive','Active') ";
            dvParam.FromSql = "FROM  discounts d " +
                "WHERE " +
                "d.discount_name like @s1 or " +
                "d.date_to like @s2 or " +
                "d.date_from like @s3 or " +
                 "d.value like @s4 or " +
                "d.status like @s5 " +
                "ORDER BY d.id DESC ";
            dvParam.SearchParamCount = 4; //name and description
            dvParam.TitleList = new List<string>() { "", "Discount", "Date From", "Date To", "Type", "value", "Description", "Status" }; //Column titles
            dvParam.InvisibleColumnList = new List<int>() { 1 };
            dvParam.NumericColumnList = new List<int>() { };
            dvParam.AddForm = new frmDiscount();
            dvParam.ViewForm = new frmDiscount();

            frmView vData = null;

            if (idBox == null && labelBox == null)
                vData = new frmView(dvParam);
            else
                vData = new frmView(dvParam, idBox, labelBox);
            vData.ShowDialog();
        }

        public static Discount getOneDiscount(int id)
        {
            Discount discount = new Discount();
            User user = new User();
            try
            {
                String query = "SELECT " +
                    "id, " +
                    "discount_name, " +
                    "date_format(date_to,'%Y-%m-%d %H:%i') AS date_to, " +
                    "date_format(date_from,'%Y-%m-%d %H:%i') AS date_from, " +
                    "description, " +
                    "type, "+
                    "value, " +
                    "status " +
                    "FROM discounts " +
                    "WHERE id = '" + id + "'";
                Dictionary<String, String> dbData = DBTransactionService.getDataAsDictionary(query);

                if (dbData != null)
                {
                    discount.DiscountName = dbData["discount_name"];
                    discount.DateTo = dbData["date_to"];
                    discount.DateFrom = dbData["date_from"];
                    discount.Type = Convert.ToInt32(dbData["type"]);
                    discount.value = Convert.ToDecimal(dbData["value"]);
                    discount.Status = Convert.ToInt32(dbData["status"]);
                    discount.Description = dbData["description"];
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
            return discount;
        }
    }
}
