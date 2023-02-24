using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vellsPos.Services;

namespace vellsPos.Entities.Masters
{
    internal class CustomerPurchasedHistory
    {
        private Int32 id;
        private LoyalityCard loyalityCard;
        private Sale sale;
        private Decimal rewardPoint;

        public CustomerPurchasedHistory()
        {

        }

        public CustomerPurchasedHistory(int id, LoyalityCard loyalityCard, Sale sale, decimal rewardPoint)
        {
            this.Id = id;
            this.LoyalityCard = loyalityCard;
            this.Sale = sale;
            this.RewardPoint = rewardPoint;
        }

        public int Id { get => id; set => id = value; }
        public decimal RewardPoint { get => rewardPoint; set => rewardPoint = value; }
        internal LoyalityCard LoyalityCard { get => loyalityCard; set => loyalityCard = value; }
        internal Sale Sale { get => sale; set => sale = value; }

        public static ReturnResult store(CustomerPurchasedHistory customerPurchasedHistory)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                //store data
                string sql = "INSERT INTO `customer_purchased_histories` " +
                    "(`loyalitycard_id`,`sale_id`,`reward_point`) VALUES (@loyalitycard_id,@sale_id,@reward_point)";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("loyalitycard_id", MySqlDbType.Int32, customerPurchasedHistory.loyalityCard.Id));
                parameters.Add(new QueryParameter("sale_id", MySqlDbType.Int32, customerPurchasedHistory.sale.Id));
                parameters.Add(new QueryParameter("reward_point", MySqlDbType.Decimal, customerPurchasedHistory.rewardPoint));

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

        public static ReturnResult update(CustomerPurchasedHistory customerPurchasedHistory)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                string sql = "UPDATE `customer_purchased_histories` SET " +
                    "`loyalitycard_id` = @loyalitycard_id, " +
                     "`sale_id` = @sale_id, " +
                    "`reward_point` = @reward_point " +
                    " WHERE `id` = @id ";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("loyalitycard_id", MySqlDbType.Int32, customerPurchasedHistory.loyalityCard.Id));
                parameters.Add(new QueryParameter("sale_id", MySqlDbType.Int32, customerPurchasedHistory.sale.Id));
                parameters.Add(new QueryParameter("reward_point", MySqlDbType.Decimal, customerPurchasedHistory.rewardPoint));

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
                string query = "DELETE FROM `customer_purchased_histories` WHERE id = @id";
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
            dvParam.Title = "Customer Purchase History";
            dvParam.SelectSql = "SELECT cph.id, concat(c.customer_number +' '+ c.customer_first_name), lc.card_number, s.invoice_number, cph.reward_point ";
            dvParam.FromSql = "FROM  customer_purchased_histories cph " +
                 "INNER JOIN loyality_cards lc ON cph.loyalitycard_id = s.id " +
                  "INNER JOIN customers c ON cph.loyalitycard_id = s.id " +
                  "INNER JOIN sales s ON cph.sale_id = s.id " +
                "WHERE lc.card_number like @s1 or s.invoice_number like @s2 or c.customer_number like @s3 or c.customer_first_name like @s4 " +
                "ORDER BY cph.id DESC ";
            dvParam.SearchParamCount = 3; //name and description
            dvParam.TitleList = new List<string>() { "", "Customer", "Loyality Card", "Invoice", "Reward Point" }; //Column titles
            dvParam.InvisibleColumnList = new List<int>() { 4 };
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

        public static CustomerPurchasedHistory getOneCustomerPurchasedHistory(int id)
        {
            CustomerPurchasedHistory customerPurchasedHistory = new CustomerPurchasedHistory();
            LoyalityCard loyality = new LoyalityCard();
            Sale sale = new Sale();
            try
            {
                String query = "SELECT * FROM customer_purchased_histories where id = '" + id + "'";
                Dictionary<String, String> dbData = DBTransactionService.getDataAsDictionary(query);

                if (dbData != null)
                {
                    customerPurchasedHistory.loyalityCard = loyality;
                    customerPurchasedHistory.sale = sale;
                    customerPurchasedHistory.rewardPoint = Convert.ToDecimal(dbData["reward_point"]);
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
            return customerPurchasedHistory;
        }
    }
}
