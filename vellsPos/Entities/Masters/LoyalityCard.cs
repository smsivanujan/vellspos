using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vellsPos.Services;

namespace vellsPos.Entities.Masters
{
    internal class LoyalityCard
    {
        private Int32 id;
        private String cardNumber;
        private String cardType;
        private Customer customer;
        private DateTime issuedDate;
        private Int32 status;
        private User user;

        public LoyalityCard()
        {

        }

        public LoyalityCard(int id, string cardNumber, string cardType, Customer customer, DateTime issuedDate, int status, User user)
        {
            this.Id = id;
            this.CardNumber = cardNumber;
            this.CardType = cardType;
            this.Customer = customer;
            this.IssuedDate = issuedDate;
            this.Status = status;
            this.User = user;
        }

        public int Id { get => id; set => id = value; }
        public string CardNumber { get => cardNumber; set => cardNumber = value; }
        public string CardType { get => cardType; set => cardType = value; }
        public DateTime IssuedDate { get => issuedDate; set => issuedDate = value; }
        public int Status { get => status; set => status = value; }
        internal Customer Customer { get => customer; set => customer = value; }
        internal User User { get => user; set => user = value; }

        public static ReturnResult store(LoyalityCard loyalityCard)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                //store data
                string sql = "INSERT INTO `loyality_cards` " +
                    "(`card_number`,`card_type`,`customer_id`,`issued_date`,`status`,`user_id`) VALUES (@card_number,@card_type,@customer_id,@issued_date,@status,@user_id)";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("card_number", MySqlDbType.String, loyalityCard.cardNumber));
                parameters.Add(new QueryParameter("card_type", MySqlDbType.String, loyalityCard.cardType));
                parameters.Add(new QueryParameter("customer_id", MySqlDbType.Int32, loyalityCard.customer.Id));
                parameters.Add(new QueryParameter("issued_date", MySqlDbType.DateTime, loyalityCard.issuedDate));
                parameters.Add(new QueryParameter("status", MySqlDbType.Int32, loyalityCard.status));
                parameters.Add(new QueryParameter("user_id", MySqlDbType.Int32, loyalityCard.user.Id));

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

        public static ReturnResult update(LoyalityCard loyalityCard)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                string sql = "UPDATE `loyality_cards` SET " +
                    "`card_number` = @card_number, " +
                     "`card_type` = @card_type, " +
                    "`customer_id` = @customer_id, " +
                    "`issued_date` = @issued_date, " +
                     "`status` = @status, " +
                    "`user_id` = @user_id " +
                    " WHERE `id` = @id ";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("card_number", MySqlDbType.String, loyalityCard.cardNumber));
                parameters.Add(new QueryParameter("card_type", MySqlDbType.String, loyalityCard.cardType));
                parameters.Add(new QueryParameter("customer_id", MySqlDbType.Int32, loyalityCard.customer.Id));
                parameters.Add(new QueryParameter("issued_date", MySqlDbType.DateTime, loyalityCard.issuedDate));
                parameters.Add(new QueryParameter("status", MySqlDbType.Int32, loyalityCard.status));
                parameters.Add(new QueryParameter("user_id", MySqlDbType.Int32, loyalityCard.user.Id));

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
                string query = "DELETE FROM `loyality_cards` WHERE id = @id";
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

        public static LoyalityCard getOneLoyalityCard(int id)
        {
            LoyalityCard loyalityCard = new LoyalityCard();
            Customer customer = new Customer();
            User user = new User();
            try
            {
                String query = "SELECT * FROM loyality_cards where id = '" + id + "'";
                Dictionary<String, String> dbData = DBTransactionService.getDataAsDictionary(query);

                if (dbData != null)
                {
                    loyalityCard.cardNumber = dbData["card_number"];
                    loyalityCard.cardType = dbData["card_type"];
                    loyalityCard.customer = customer;
                    loyalityCard.issuedDate = Convert.ToDateTime(dbData["issued_date"]);
                    loyalityCard.status =Convert.ToInt32(dbData["status"]);
                    loyalityCard.user = user;
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
            return loyalityCard;
        }
    }
}
