using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vellsPos.Services;

namespace vellsPos.Entities.Masters
{
    internal class PaymentMethod
    {
        private Int32 id;
        private String paymentMethodName;
        private String description;

        public PaymentMethod()
        {

        }

        public PaymentMethod(int id, string paymentMethodName, string description)
        {
            this.Id = id;
            this.PaymentMethodName = paymentMethodName;
            this.Description = description;
        }

        public int Id { get => id; set => id = value; }
        public string PaymentMethodName { get => paymentMethodName; set => paymentMethodName = value; }
        public string Description { get => description; set => description = value; }

        public static ReturnResult store(PaymentMethod paymentMethod)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                //store data
                string sql = "INSERT INTO `payment_methods` " +
                    "(`payment_method_name`,`description`) VALUES (@payment_method_name,@description)";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("payment_method_name", MySqlDbType.String, paymentMethod.paymentMethodName));
                parameters.Add(new QueryParameter("description", MySqlDbType.String, paymentMethod.description));

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

        public static ReturnResult update(PaymentMethod paymentMethod)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                string sql = "UPDATE `payment_methods` SET " +
                    "`payment_method_name` = @payment_method_name, " +
                    "`description` = @description " +
                    " WHERE `id` = @id ";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("payment_method_name", MySqlDbType.String, paymentMethod.paymentMethodName));
                parameters.Add(new QueryParameter("description", MySqlDbType.String, paymentMethod.description));

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
                string query = "DELETE FROM `payment_methods` WHERE id = @id";
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
            dvParam.Title = "Payment Methods";
            dvParam.SelectSql = "SELECT pm.id, pm.payment_method_name, pm.description ";
            dvParam.FromSql = "FROM  payment_methods pm " +
                "WHERE pm.payment_method_name like @s1 or pm.description like @s2 " +
                "ORDER BY pm.id DESC ";
            dvParam.SearchParamCount = 1; //name and description
            dvParam.TitleList = new List<string>() { "", "Payment Method", "Description" }; //Column titles
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

        public static PaymentMethod getOnePaymentMethod(int id)
        {
            PaymentMethod paymentMethod = new PaymentMethod();
            try
            {
                String query = "SELECT * FROM payment_methods where id = '" + id + "'";
                Dictionary<String, String> dbData = DBTransactionService.getDataAsDictionary(query);

                if (dbData != null)
                {
                    paymentMethod.paymentMethodName = dbData["payment_method_name"];
                    paymentMethod.Description = dbData["description"];
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
            return paymentMethod;
        }
    }
}
