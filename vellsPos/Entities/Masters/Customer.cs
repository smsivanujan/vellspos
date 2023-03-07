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
    internal class Customer
    {
        private Int32 id;
        private String customerNumber;
        private String customerFirstName;
        private String customerLastName;
        private String dateOfBirth;
        private Int32 gender;
        private String nic;
        private String phoneNumber;
        private String email;
        private User user;


        public Customer()
        {

        }

        public Customer(int id, string customerNumber, string customerFirstName, string customerLastName, string dateOfBirth, int gender, string nic, string phoneNumber, string email, User user)
        {
            this.Id = id;
            this.CustomerNumber = customerNumber;
            this.CustomerFirstName = customerFirstName;
            this.CustomerLastName = customerLastName;
            this.DateOfBirth = dateOfBirth;
            this.Gender = gender;
            this.Nic = nic;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.User = user;
        }

        public int Id { get => id; set => id = value; }
        public string CustomerNumber { get => customerNumber; set => customerNumber = value; }
        public string CustomerFirstName { get => customerFirstName; set => customerFirstName = value; }
        public string CustomerLastName { get => customerLastName; set => customerLastName = value; }
        public string DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public int Gender { get => gender; set => gender = value; }
        public string Nic { get => nic; set => nic = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }
        internal User User { get => user; set => user = value; }

        public static ReturnResult store(Customer customer)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                //store data
                string sql = "INSERT INTO `customers` " +
                    "(" +
                    "`customer_number`," +
                    "`customer_first_name`," +
                    "`customer_last_name`," +
                    "`date_of_birth`," +
                    "`gender`,`" +
                    "nic`," +
                    "`phone_number`," +
                    "`email`," +
                    "`user_id`) " +
                    "VALUES (" +
                    "@customer_number," +
                    "@customer_first_name," +
                    "@customer_last_name," +
                    "@date_of_birth," +
                    "@gender,@nic," +
                    "@phone_number," +
                    "@email," +
                    "@user_id)";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("customer_number", MySqlDbType.String, customer.CustomerNumber));
                parameters.Add(new QueryParameter("customer_first_name", MySqlDbType.String, customer.customerFirstName));
                parameters.Add(new QueryParameter("customer_last_name", MySqlDbType.String, customer.CustomerLastName));
                parameters.Add(new QueryParameter("date_of_birth", MySqlDbType.String, customer.dateOfBirth));
                parameters.Add(new QueryParameter("gender", MySqlDbType.Int32, customer.gender));
                parameters.Add(new QueryParameter("nic", MySqlDbType.String, customer.nic));
                parameters.Add(new QueryParameter("phone_number", MySqlDbType.String, customer.phoneNumber));
                parameters.Add(new QueryParameter("email", MySqlDbType.String, customer.email));
                parameters.Add(new QueryParameter("user_id", MySqlDbType.Int32, customer.user.Id));

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

        public static ReturnResult update(Customer customer)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                string sql = "UPDATE `customers` SET " +
                    "`customer_number` = @customer_number, " +
                     "`customer_first_name` = @customer_first_name, " +
                     "`customer_last_name` = @customer_last_name, " +
                     "`date_of_birth` = @date_of_birth, " +
                     "`gender` = @gender, " +
                     "`nic` = @nic, " +
                     "`phone_number` = @phone_number, " +
                     "`email` = @email, " +
                    "`user_id` = @user_id " +
                    " WHERE `id` = @id ";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("customer_number", MySqlDbType.String, customer.CustomerNumber));
                parameters.Add(new QueryParameter("customer_first_name", MySqlDbType.String, customer.customerFirstName));
                parameters.Add(new QueryParameter("customer_last_name", MySqlDbType.String, customer.CustomerLastName));
                parameters.Add(new QueryParameter("date_of_birth", MySqlDbType.String, customer.dateOfBirth));
                parameters.Add(new QueryParameter("gender", MySqlDbType.Int32, customer.gender));
                parameters.Add(new QueryParameter("nic", MySqlDbType.String, customer.nic));
                parameters.Add(new QueryParameter("phone_number", MySqlDbType.String, customer.phoneNumber));
                parameters.Add(new QueryParameter("email", MySqlDbType.String, customer.email));
                parameters.Add(new QueryParameter("user_id", MySqlDbType.Int32, customer.user.Id));
                parameters.Add(new QueryParameter("id", MySqlDbType.Int32, customer.Id));

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
                string query = "DELETE FROM `customers` WHERE id = @id";
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
            dvParam.Title = "Customers";
            dvParam.SelectSql = "SELECT " +
                "c.id, " +
                "c.customer_number, concat(c.customer_first_name,' ',c.customer_last_name), " +
                "c.nic, " +
                "IF(c.gender=0,'Female','Male'), " +
                "date_format(c.date_of_birth,'%Y-%m-%d'), " +
                "c.phone_number, " +
                "c.email ";
            dvParam.FromSql = "FROM  customers c " +
                "WHERE " +
                "c.customer_number like @s1 or " +
                "c.customer_first_name like @s2 or " +
                "c.customer_last_name like @s3 or " +
                "c.nic like @s4 or c.gender like @s5 or " +
                "c.phone_number like @s6 " +
                "ORDER BY c.id DESC ";
            dvParam.SearchParamCount = 5; //name and description
            dvParam.TitleList = new List<string>() { "", "Customer Number", "Customer", "NIC", "Gender", "Date of Birth", "Phone Number", "Email" }; //Column titles
            dvParam.InvisibleColumnList = new List<int>() { 1 };
            dvParam.NumericColumnList = new List<int>() { };
            dvParam.AddForm = new frmCustomer();
            dvParam.ViewForm = new frmCustomer();

            frmView vData = null;

            if (idBox == null && labelBox == null)
                vData = new frmView(dvParam);
            else
                vData = new frmView(dvParam, idBox, labelBox);
            vData.ShowDialog();
        }

        public static void showOnViewFormCustomer(TextBox labelBox = null, TextBox idBox = null)
        {
            DataViewParam dvParam = new DataViewParam();
            dvParam.Title = "Customers";
            dvParam.TableName = "customers";
            dvParam.SelectSql = "SELECT " +
                "c.id, " +
                "c.customer_number, " +
                "concat(c.customer_first_name,' ',c.customer_last_name), " +
                "c.nic, " +
                "c.gender, " +
                "date_format(c.date_of_birth,'%Y-%m-%d'), " +
                "c.phone_number, " +
                "c.email ";
            dvParam.FromSql = "FROM  customers c " +
                 "LEFT JOIN loyality_cards lc ON lc.customer_id=c.id  " +
                 "WHERE lc.customer_id IS NULL " +
                "ORDER BY c.id DESC ";
            dvParam.SearchParamCount = 0; //name and description //AND p.product_number like @s1 or p.product_name like @s2 or c.category_name like @s3 or sc.sub_category_name like @s4 or scc.sub_co_category_name like @s5 
            dvParam.TitleList = new List<string>() { "", "Customer Number", "Customer", "NIC", "Gender", "Date of Birth", "Phone Number", "Email" }; //Column titles
            dvParam.InvisibleColumnList = new List<int>() { 1 };
            dvParam.NumericColumnList = new List<int>() { };//Column titles
            //dvParam.FixedColumnNumber = 3;
            dvParam.ShowImage = "show";


            dvParam.AddForm = new frmProduct();
            dvParam.ViewForm = new frmProduct();


            frmView vData = null;

            if (idBox == null && labelBox == null)
                vData = new frmView(dvParam);
            else
                vData = new frmView(dvParam, idBox, labelBox);
            vData.ShowDialog();
        }
        public static Customer getOneCustomer(int id)
        {
            Customer customer = new Customer();
            User user = new User();
            try
            {
                String query = "SELECT " +
                    "id, " +
                    "customer_number, " +
                    "customer_first_name, " +
                    "customer_last_name, " +
                    "nic, " +
                    "gender, "+
                    "date_format(date_of_birth,'%Y-%m-%d') AS date_of_birth, " +
                    "phone_number, " +
                    "email " +
                    "FROM customers " +
                    "WHERE id = '" + id + "'";
                Dictionary<String, String> dbData = DBTransactionService.getDataAsDictionary(query);

                if (dbData != null)
                {
                    customer.customerNumber = dbData["customer_number"];
                    customer.customerFirstName = dbData["customer_first_name"];
                    customer.customerLastName = dbData["customer_last_name"];
                    customer.dateOfBirth = dbData["date_of_birth"];
                    customer.gender = Convert.ToInt32(dbData["gender"]);
                    customer.nic = dbData["nic"];
                    customer.phoneNumber = dbData["phone_number"];
                    customer.email = dbData["email"];
                    customer.user = user;
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
            return customer;
        }
    }
}
