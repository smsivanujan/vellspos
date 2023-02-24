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
        private Payment payment;
        private PaymentMethod paymentMethod;
        private Decimal paidAmount;

        public PaymentOption()
        {

        }
        public PaymentOption(int id, Payment payment, PaymentMethod paymentMethod, decimal paidAmount)
        {
            this.Id = id;
            this.Payment = payment;
            this.PaymentMethod = paymentMethod;
            this.PaidAmount = paidAmount;
        }

        public int Id { get => id; set => id = value; }
        public decimal PaidAmount { get => paidAmount; set => paidAmount = value; }
        internal Payment Payment { get => payment; set => payment = value; }
        internal PaymentMethod PaymentMethod { get => paymentMethod; set => paymentMethod = value; }

        public static ReturnResult store(PaymentOption paymentOption)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                //store data
                string sql = "INSERT INTO `payment_options` " +
                    "(`payment_id`,`payment_method_id`,`paid_amount`) VALUES (@payment_id,@payment_method_id,@paid_amount)";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("payment_id", MySqlDbType.Int32, paymentOption.payment.Id));
                parameters.Add(new QueryParameter("payment_method_id", MySqlDbType.Int32, paymentOption.paymentMethod.Id));
                parameters.Add(new QueryParameter("paid_amount", MySqlDbType.Decimal, paymentOption.paidAmount));

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
                    "`payment_id` = @payment_id, " +
                     "`payment_method_id` = @payment_method_id, " +
                    "`paid_amount` = @paid_amount " +
                    " WHERE `id` = @id ";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("payment_id", MySqlDbType.Int32, paymentOption.payment.Id));
                parameters.Add(new QueryParameter("payment_method_id", MySqlDbType.Int32, paymentOption.paymentMethod.Id));
                parameters.Add(new QueryParameter("paid_amount", MySqlDbType.Decimal, paymentOption.paidAmount));
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
            Payment payment = new Payment();
            PaymentMethod paymentMethod = new PaymentMethod();
            try
            {
                String query = "SELECT * FROM payment_options where id = '" + id + "'";
                Dictionary<String, String> dbData = DBTransactionService.getDataAsDictionary(query);

                if (dbData != null)
                {
                    paymentOption.payment = payment;
                    paymentOption.paymentMethod = paymentMethod;
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
