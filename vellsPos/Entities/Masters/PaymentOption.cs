using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vellsPos.Services;

namespace vellsPos.Entities.Masters
{
    internal class PaymentOption
    {
        private Int32 id;
        private Sale sale;
        private PaymentMethod paymentMethod;
        private Decimal paidAmount;

        public PaymentOption()
        {

        }

        public PaymentOption(int id, Sale sale, PaymentMethod paymentMethod, decimal paidAmount)
        {
            this.id = id;
            this.sale = sale;
            this.paymentMethod = paymentMethod;
            this.paidAmount = paidAmount;
        }

        public int Id { get => id; set => id = value; }
        internal Sale Sale { get => sale; set => sale = value; }
        internal PaymentMethod PaymentMethod { get => paymentMethod; set => paymentMethod = value; }
        public decimal PaidAmount { get => paidAmount; set => paidAmount = value; }

        public static ReturnResult store(PaymentOption paymentOption)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                //store data
                string sql = "INSERT INTO `payment_options` " +
                    "(`sale_id`,`payment_method_id`,`paid_amount`) VALUES (@sale_id, @payment_method_id, @paid_amount)";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("sale_id", MySqlDbType.Int32, paymentOption.sale.Id));
                parameters.Add(new QueryParameter("payment_method_id", MySqlDbType.Int32, paymentOption.PaymentMethod.Id));
                parameters.Add(new QueryParameter("paid_amount", MySqlDbType.Decimal, paymentOption.PaidAmount));

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

        public static ReturnResult update(PaymentOption paymentOption)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                string sql = "UPDATE `payment_options` SET " +
                    "`sale_id` = @sale_id, " +
                     "`payment_method_id` = @payment_method_id, " +
                    "`paid_amount` = @paid_amount " +
                    " WHERE `id` = @id ";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("sale_id", MySqlDbType.Int32, paymentOption.sale.Id));
                parameters.Add(new QueryParameter("payment_method_id", MySqlDbType.Int32, paymentOption.PaymentMethod.Id));
                parameters.Add(new QueryParameter("paid_amount", MySqlDbType.Decimal, paymentOption.PaidAmount));
                parameters.Add(new QueryParameter("id", MySqlDbType.Int32, paymentOption.Id));

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
                string query = "DELETE FROM `payment_options` WHERE id = @id";
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
        //    dvParam.Title = "Payment Options";
        //    dvParam.SelectSql = "SELECT po.id, p.date, b.branch_name, b.status ";
        //    dvParam.FromSql = "FROM  payment_options po " +
        //         "INNER JOIN payments p ON po.payment_id = p.id " +
        //           "INNER JOIN payment_methods pm ON po.payment_method_id = pm.id " +
        //        "where s.shop_name like @s1 or b.branch_name like @s2 or b.status like @s3 ORDER BY po.id DESC ";
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

        public static PaymentOption getOnePaymentOption(int id)
        {
            PaymentOption paymentOption = new PaymentOption();
            Sale sale = new Sale();
            PaymentMethod paymentMethod = new PaymentMethod();
            try
            {
                String query = "SELECT " +
                    "s.id, " +
                    "date_format(s.date,'%Y-%m-%d %H:%i') AS date, " +
                    "b.branch_name, " +
                    "s.invoice_number, " +
                    "s.total_amount, " +
                    "s.total_discount, " +
                    "s.status, " +
                    "pm.payment_method_name, " +
                    "po.paid_amount " +
                    "FROM payment_options po " +
                    "INNER JOIN sales s ON po.sale_id = s.id " +
                    "INNER JOIN branches b ON s.branch_id = b.id " +
                    "INNER JOIN payment_methods pm ON pm.payment_method_id = b.id " +
                    "WHERE po.id = '" + id + "'";
                Dictionary<String, String> dbData = DBTransactionService.getDataAsDictionary(query);

                if (dbData != null)
                {
                    sale.Date = dbData["date"];
                    sale.InvoiceNumber= dbData["invoice_number"];
                    sale.TotalAmount = Convert.ToDecimal(dbData["total_amount"]);
                    sale.TotalDiscount = Convert.ToDecimal(dbData["total_discount"]);
                    paymentOption.sale = sale;
                    paymentMethod.PaymentMethodName= dbData["payment_method_name"];
                    paymentOption.PaymentMethod = paymentMethod;
                    paymentOption.PaidAmount = Convert.ToDecimal(dbData["paid_amount"]);
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
            return paymentOption;
        }
    }
}
