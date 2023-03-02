using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vellsPos.Services;

namespace vellsPos.Entities.Masters
{
    internal class Drawer
    {
        private Int32 id;
        private String date;
        private Decimal initialAmount;
        private User user;

        public Drawer()
        {

        }

        public Drawer(int id, String date, decimal initialAmount, User user)
        {
            this.Id = id;
            this.Date = date;
            this.InitialAmount = initialAmount;
            this.User = user;
        }

        public int Id { get => id; set => id = value; }
        public string Date { get => date; set => date = value; }
        public decimal InitialAmount { get => initialAmount; set => initialAmount = value; }
        internal User User { get => user; set => user = value; }

        public static ReturnResult store(Drawer drawer)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                //store data
                string sql = "INSERT INTO `drawers` " +
                    "(`date`,`initial_amount`,`user_id`) VALUES (@date,@initial_amount,@user_id)";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("date", MySqlDbType.String, drawer.Date));
                parameters.Add(new QueryParameter("initial_amount", MySqlDbType.Decimal, drawer.initialAmount));
                parameters.Add(new QueryParameter("user_id", MySqlDbType.Int32, drawer.user.Id));

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

        //public static ReturnResult update(Drawer drawer)
        //{
        //    ReturnResult result = new ReturnResult(false, "Error");
        //    List<QueryCommand> commands = new List<QueryCommand>();
        //    try
        //    {
        //        string sql = "UPDATE `drawers` SET " +
        //            "`date` = @date, " +
        //             "`initial_amount` = @initial_amount, " +
        //            "`user_id` = @user_id " +
        //            " WHERE `id` = @id ";
        //        List<QueryParameter> parameters = new List<QueryParameter>();
        //        parameters.Add(new QueryParameter("date", MySqlDbType.String, drawer.Date));
        //        parameters.Add(new QueryParameter("initial_amount", MySqlDbType.Decimal, drawer.initialAmount));
        //        parameters.Add(new QueryParameter("user_id", MySqlDbType.Int32, drawer.user.Id));
        //        parameters.Add(new QueryParameter("id", MySqlDbType.Int32, drawer.Id));

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
        //        string query = "DELETE FROM `drawers` WHERE id = @id";
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
            dvParam.Title = "Drawers";
            dvParam.SelectSql = "SELECT " +
                "d.id, " +
                "date_format(d.date,'%Y-%m-%d %H:%i'), " +
                "d.initial_amount, u.user_name ";
            dvParam.FromSql = "FROM  drawers d " +
                  "INNER JOIN users u ON d.user_id = u.id " +
                "WHERE " +
                "d.date like @s1 or " +
                "u.user_name like @s2 " +
                "ORDER BY d.id DESC ";
            dvParam.SearchParamCount = 1; //name and description
            dvParam.TitleList = new List<string>() { "", "Date", "Initial Amount", "User" }; //Column titles
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

        public static Drawer getOneDrawer(int id)
        {
            Drawer drawer = new Drawer();
            User user = new User();
            try
            {
                String query = "SELECT " +
                    "d.id, " +
                    "date_format(d.date,'%Y-%m-%d %H:%i') AS date, " +
                    "d.initial_amount, " +
                    "u.user_name AS user " +
                    "FROM drawers d " +
                     "INNER JOIN users u ON d.user_id = u.id " +
                    "WHERE d.id = '" + id + "'";
                Dictionary<String, String> dbData = DBTransactionService.getDataAsDictionary(query);

                if (dbData != null)
                {
                    drawer.date = dbData["date"];
                    drawer.initialAmount = Convert.ToDecimal(dbData["initial_amount"]);
                    user.UserName = dbData["user"];
                    drawer.user = user;
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
            return drawer;
        }
    }
}
