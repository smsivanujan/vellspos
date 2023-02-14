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
