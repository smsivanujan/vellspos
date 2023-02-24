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
    internal class LoyalityCard
    {
        private Int32 id;
        private String cardNumber;
        private String cardType;
        private Customer customer;
        private String issuedDate;
        private Int32 status;
        private User user;


        public LoyalityCard()
        {

        }

        public LoyalityCard(int id, string cardNumber, string cardType, Customer customer, string issuedDate, int status, User user)
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
        internal Customer Customer { get => customer; set => customer = value; }
        public string IssuedDate { get => issuedDate; set => issuedDate = value; }
        public int Status { get => status; set => status = value; }
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
                parameters.Add(new QueryParameter("card_number", MySqlDbType.String, loyalityCard.CardNumber));
                parameters.Add(new QueryParameter("card_type", MySqlDbType.String, loyalityCard.CardType));
                parameters.Add(new QueryParameter("customer_id", MySqlDbType.Int32, loyalityCard.Customer.Id));
                parameters.Add(new QueryParameter("issued_date", MySqlDbType.String, loyalityCard.IssuedDate));
                parameters.Add(new QueryParameter("status", MySqlDbType.Int32, loyalityCard.Status));
                parameters.Add(new QueryParameter("user_id", MySqlDbType.Int32, loyalityCard.User.Id));

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
                parameters.Add(new QueryParameter("card_number", MySqlDbType.String, loyalityCard.CardNumber));
                parameters.Add(new QueryParameter("card_type", MySqlDbType.String, loyalityCard.CardType));
                parameters.Add(new QueryParameter("customer_id", MySqlDbType.Int32, loyalityCard.Customer.Id));
                parameters.Add(new QueryParameter("issued_date", MySqlDbType.String, loyalityCard.IssuedDate));
                parameters.Add(new QueryParameter("status", MySqlDbType.Int32, loyalityCard.Status));
                parameters.Add(new QueryParameter("user_id", MySqlDbType.Int32, loyalityCard.User.Id));
                parameters.Add(new QueryParameter("id", MySqlDbType.Int32, loyalityCard.Id));

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

        public static void showOnViewForm(TextBox labelBox = null, TextBox idBox = null)
        {
            DataViewParam dvParam = new DataViewParam();
            dvParam.Title = "Loyality Cards";
            dvParam.SelectSql = "SELECT " +
                "lc.id, " +
                "date_format(lc.issued_date,'%Y-%m-%d %H:%i'), " +
                "lc.card_number, " +
                "concat(c.customer_number,' ',c.customer_first_name), " +
                "lc.card_type, lc.status ";
            dvParam.FromSql = "FROM loyality_cards lc " +
                "INNER JOIN customers c ON lc.customer_id = c.id " +
                "WHERE lc.issued_date like @s1 or " +
                "lc.card_number like @s2 or " +
                "c.customer_number like @s3 or " +
                "c.customer_first_name like @s4 or " +
                "lc.card_type like @s5 or lc.status like @s6 " +
                "ORDER BY lc.id DESC ";
            dvParam.SearchParamCount = 5; //name and description
            dvParam.TitleList = new List<string>() { "", "Date", "Card Number", "Customer", "Card Type", "Status" }; //Column titles
            dvParam.InvisibleColumnList = new List<int>() { 1 };
            dvParam.NumericColumnList = new List<int>() { };
            dvParam.AddForm = new frmLoyalityCard();
            dvParam.ViewForm = new frmLoyalityCard();

            frmView vData = null;

            if (idBox == null && labelBox == null)
                vData = new frmView(dvParam);
            else
                vData = new frmView(dvParam, idBox, labelBox);
            vData.Show();
        }

        public static LoyalityCard getOneLoyalityCard(int id)
        {
            LoyalityCard loyalityCard = new LoyalityCard();
            Customer customer = new Customer();
            User user = new User();
            try
            {
                String query = "SELECT " +
                    "lc.id, " +
                    "date_format(lc.issued_date,'%Y-%m-%d %H:%i') AS date, " +
                    "lc.card_number, " +
                    "c.customer_number AS customerFN, " +
                    "c.customer_first_name AS customerLN, " +
                    "lc.card_type, " +
                    "lc.issued_date, " +
                    "lc.status, " +
                     "u.user_name AS user " +
                    "FROM loyality_cards lc " +
                    "INNER JOIN customers c ON lc.customer_id = c.id " +
                    "INNER JOIN users u ON lc.user_id = u.id " +
                    "WHERE lc.id = '" + id + "'";
                Dictionary<String, String> dbData = DBTransactionService.getDataAsDictionary(query);

                if (dbData != null)
                {
                    loyalityCard.cardNumber = dbData["card_number"];
                    loyalityCard.cardType = dbData["card_type"];
                    customer.CustomerFirstName = dbData["customerFN"];
                    customer.CustomerLastName = dbData["customerLN"];
                    loyalityCard.customer = customer;
                    loyalityCard.issuedDate = dbData["issued_date"];
                    loyalityCard.status =Convert.ToInt32(dbData["status"]);
                    user.UserName = dbData["user"];
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
