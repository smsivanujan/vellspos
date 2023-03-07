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
    internal class LoyalityPoint
    {
        private Int32 id;
        private Customer customer;
        private Sale sale;
        private Decimal points;

        public LoyalityPoint()
        {

        }

        public LoyalityPoint(int id, Customer customer, Sale sale, decimal points)
        {
            this.Id = id;
            this.Customer = customer;
            this.Sale = sale;
            this.Points = points;
        }

        public int Id { get => id; set => id = value; }
        public decimal Points { get => points; set => points = value; }
        internal Customer Customer { get => customer; set => customer = value; }
        internal Sale Sale { get => sale; set => sale = value; }

        public static ReturnResult store(LoyalityPoint loyalityPoint)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                //store data
                string sql = "INSERT INTO `loyality_points` " +
                    "(`customer_id`,`sale_id`,`points`) " +
                    "VALUES (@customer_id,@sale_id,@points)";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("customer_id", MySqlDbType.String, loyalityPoint.customer.Id));
                parameters.Add(new QueryParameter("sale_id", MySqlDbType.String, loyalityPoint.sale.Id));
                parameters.Add(new QueryParameter("points", MySqlDbType.Int32, loyalityPoint.points));

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

        public static ReturnResult update(LoyalityPoint loyalityPoint)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                string sql = "UPDATE `loyality_points` SET " +
                    "`customer_id` = @customer_id, " +
                     "`sale_id` = @sale_id, " +
                    "`customer_id` = @customer_id, " +
                    "`points` = @points " +
                    " WHERE `id` = @id ";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("customer_id", MySqlDbType.String, loyalityPoint.customer.Id));
                parameters.Add(new QueryParameter("sale_id", MySqlDbType.String, loyalityPoint.sale.Id));
                parameters.Add(new QueryParameter("points", MySqlDbType.Int32, loyalityPoint.points));
                parameters.Add(new QueryParameter("id", MySqlDbType.Int32, loyalityPoint.Id));

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
                string query = "DELETE FROM `loyality_points` WHERE id = @id";
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

        //public static void showOnViewForm(TextBox labelBox = null, TextBox idBox = null)
        //{
        //    DataViewParam dvParam = new DataViewParam();
        //    dvParam.Title = "Loyality Points";
        //    dvParam.SelectSql = "SELECT " +
        //        "lc.id, " +
        //        "date_format(s.date,'%Y-%m-%d %H:%i') AS date, " +
        //        "s.invoice_number, " +
        //        "lc.card_number, " +
        //        "concat(c.customer_number,' ',c.customer_first_name), " +
        //        "lp.points";
        //    dvParam.FromSql = "FROM loyality_points lp " +
        //        "INNER JOIN customers c ON lp.customer_id = c.id " +
        //        "INNER JOIN sales s ON lp.sale_id = s.id " +
        //        "WHERE lc.date like @s1 or " +
        //        "s.invoice_number like @s2 or " +
        //        "c.customer_number like @s3 or " +
        //        "c.customer_first_name like @s4 " +
        //        "ORDER BY lc.id DESC ";
        //    dvParam.SearchParamCount = 5; //name and description
        //    dvParam.TitleList = new List<string>() { "", "Date", "Card Number", "Customer", "Card Type", "Status" }; //Column titles
        //    dvParam.InvisibleColumnList = new List<int>() { 1 };
        //    dvParam.NumericColumnList = new List<int>() { };
        //    dvParam.AddForm = new frmLoyalityCard();
        //    dvParam.ViewForm = new frmLoyalityCard();

        //    frmView vData = null;

        //    if (idBox == null && labelBox == null)
        //        vData = new frmView(dvParam);
        //    else
        //        vData = new frmView(dvParam, idBox, labelBox);
        //    vData.ShowDialog();
        //}

        //public static LoyalityPoint getOneLoyalityPoint(String id)
        //{
        //    LoyalityPoint loyalityPoint = new LoyalityPoint();
        //    try
        //    {
        //        String query = "SELECT " +
        //            "SUM(points) AS point " +
        //            "FROM loyality_points lp " +
        //            "WHERE lp.customer_id = '" + id + "'";
        //        Dictionary<String, String> dbData = DBTransactionService.getDataAsDictionary(query);

        //        if (dbData != null)
        //        {
        //            loyalityPoint.points = Convert.ToDecimal(dbData["point"]);
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
        //    return loyalityPoint;
        //}
    }
}
