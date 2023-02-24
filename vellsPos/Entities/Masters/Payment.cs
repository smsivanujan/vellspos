using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vellsPos.Services;

namespace vellsPos.Entities.Masters
{
    internal class Payment
    {
        private Int32 id;
        private DateTime date;
        private Sale sale;
        private Decimal payableAmount;

        public Payment()
        {

        }

        public Payment(int id, DateTime date, Sale sale, decimal payableAmount)
        {
            this.Id = id;
            this.Date = date;
            this.Sale = sale;
            this.PayableAmount = payableAmount;
        }

        public int Id { get => id; set => id = value; }
        public DateTime Date { get => date; set => date = value; }
        public decimal PayableAmount { get => payableAmount; set => payableAmount = value; }
        internal Sale Sale { get => sale; set => sale = value; }

        public static ReturnResult store(Payment payment)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                //store data
                string sql = "INSERT INTO `payments` " +
                    "(`date`,`sale_id`,`payable_amount`) VALUES (@date,@sale_id,@payable_amount)";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("date", MySqlDbType.DateTime, payment.date));
                parameters.Add(new QueryParameter("sale_id", MySqlDbType.Int32, payment.sale.Id));
                parameters.Add(new QueryParameter("payable_amount", MySqlDbType.Decimal, payment.payableAmount));

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

        public static ReturnResult update(Payment payment)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                string sql = "UPDATE `payments` SET " +
                    "`date` = @date, " +
                     "`sale_id` = @sale_id, " +
                    "`payable_amount` = @payable_amount " +
                    " WHERE `id` = @id ";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("date", MySqlDbType.DateTime, payment.date));
                parameters.Add(new QueryParameter("sale_id", MySqlDbType.Int32, payment.sale.Id));
                parameters.Add(new QueryParameter("payable_amount", MySqlDbType.Decimal, payment.payableAmount));
                parameters.Add(new QueryParameter("id", MySqlDbType.Int32, payment.Id));

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
                string query = "DELETE FROM `payments` WHERE id = @id";
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
        //    dvParam.Title = "Payments";
        //    dvParam.SelectSql = "SELECT p.id, p.date, s.invoice_number, p.payable_amount ";
        //    dvParam.FromSql = "FROM  payments p " +
        //         "INNER JOIN sales s ON p.sale_id = s.id " +
        //        "where s.shop_name like @s1 or b.branch_name like @s2 or b.status like @s3 ORDER BY b.id DESC ";
        //    dvParam.SearchParamCount = 2; //name and description
        //    dvParam.TitleList = new List<string>() { "", "Shop", "Branch", "Status" }; //Column titles
        //    dvParam.InvisibleColumnList = new List<int>() { 1 };
        //    dvParam.NumericColumnList = new List<int>() { };
        //    //dvParam.AddForm = new frmComplain();
        //    //dvParam.ViewForm = new frmComplain();

        //    //frmView vData = null;

        //    //if (idBox == null && labelBox == null)
        //    //    vData = new frmView(dvParam);
        //    //else
        //    //    vData = new frmView(dvParam, idBox, labelBox);
        //    //vData.Show();
        //}

        public static Payment getOnePayment(int id)
        {
            Payment payment = new Payment();
            Sale sale = new Sale();
            try
            {
                String query = "SELECT * FROM payments where id = '" + id + "'";
                Dictionary<String, String> dbData = DBTransactionService.getDataAsDictionary(query);

                if (dbData != null)
                {
                    payment.date = Convert.ToDateTime(dbData["date"]);
                    payment.sale = sale;
                    payment.payableAmount = Convert.ToDecimal(dbData["payable_amount"]);
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
            return payment;
        }
    }
}
