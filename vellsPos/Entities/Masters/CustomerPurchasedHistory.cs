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
