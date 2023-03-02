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
    internal class Client
    {
        private Int32 id;
        private String bussiness_name;
        private String contact_number;
        private String email;
        private String address;
        private String image;

        public Client()
        {

        }

        public Client(int id, string bussiness_name, string contact_number, string email, string address, string image)
        {
            this.Id = id;
            this.Bussiness_name = bussiness_name;
            this.Contact_number = contact_number;
            this.Email = email;
            this.Address = address;
            this.Image = image;
        }

        public int Id { get => id; set => id = value; }
        public string Bussiness_name { get => bussiness_name; set => bussiness_name = value; }
        public string Contact_number { get => contact_number; set => contact_number = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
        public string Image { get => image; set => image = value; }

        public static ReturnResult store(Client clientProfile)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                //store data
                string sql = "INSERT INTO `clients` " +
                    "(" +
                    "`bussiness_name`," +
                    "`contact_number`," +
                    "`email`," +
                    "`address`," +
                    "`image`) " +
                    "VALUES (" +
                    "@bussiness_name," +
                    "@contact_number," +
                    "@email," +
                    "@address," +
                    "@image)";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("bussiness_name", MySqlDbType.String, clientProfile.bussiness_name));
                parameters.Add(new QueryParameter("contact_number", MySqlDbType.String, clientProfile.contact_number));
                parameters.Add(new QueryParameter("email", MySqlDbType.String, clientProfile.email));
                parameters.Add(new QueryParameter("address", MySqlDbType.String, clientProfile.address));
                parameters.Add(new QueryParameter("image", MySqlDbType.String, clientProfile.image));

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

        public static ReturnResult update(Client clientProfile)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                string sql = "UPDATE `clients` SET " +
                    "`bussiness_name` = @bussiness_name, " +
                     "`contact_number` = @contact_number, " +
                     "`email` = @email, " +
                     "`address` = @address, " +
                     "`image` = @image " +
                    " WHERE `id` = @id ";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("bussiness_name", MySqlDbType.String, clientProfile.bussiness_name));
                parameters.Add(new QueryParameter("contact_number", MySqlDbType.String, clientProfile.contact_number));
                parameters.Add(new QueryParameter("email", MySqlDbType.String, clientProfile.email));
                parameters.Add(new QueryParameter("address", MySqlDbType.String, clientProfile.address));
                parameters.Add(new QueryParameter("image", MySqlDbType.String, clientProfile.image));
                parameters.Add(new QueryParameter("id", MySqlDbType.Int32, clientProfile.Id));

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

        //public static ReturnResult delete(int id)
        //{
        //    ReturnResult result = new ReturnResult(false, "Error");
        //    List<QueryCommand> commands = new List<QueryCommand>();
        //    try
        //    {
        //        string query = "DELETE FROM `customers` WHERE id = @id";
        //        List<QueryParameter> parameters = new List<QueryParameter>();
        //        parameters.Add(new QueryParameter("id", MySqlDbType.Int32, id));
        //        commands.Add(new QueryCommand(query, parameters));
        //        result = DBTransactionService.executeNonQuery(commands);
        //        if (result.Status)
        //            result.Msg = Constants.MSG_DELETE_SUCCESS;
        //    }
        //    catch (Exception e)
        //    {
        //        result = new ReturnResult(false, Constants.MSG_ERROR, e.Message, e);
        //        // MessageBox.Show(result);
        //    }
        //    return result;
        //}

        //public static void showOnViewForm(TextBox labelBox = null, TextBox idBox = null)
        //{
        //    DataViewParam dvParam = new DataViewParam();
        //    dvParam.Title = "Customers";
        //    dvParam.SelectSql = "SELECT " +
        //        "c.id, " +
        //        "c.customer_number, concat(c.customer_first_name,' ',c.customer_last_name), " +
        //        "c.nic, " +
        //        "IF(c.gender=0,'Female','Male'), " +
        //        "date_format(c.date_of_birth,'%Y-%m-%d'), " +
        //        "c.phone_number, " +
        //        "c.email ";
        //    dvParam.FromSql = "FROM  customers c " +
        //        "WHERE " +
        //        "c.customer_number like @s1 or " +
        //        "c.customer_first_name like @s2 or " +
        //        "c.customer_last_name like @s3 or " +
        //        "c.nic like @s4 or c.gender like @s5 or " +
        //        "c.phone_number like @s6 " +
        //        "ORDER BY c.id DESC ";
        //    dvParam.SearchParamCount = 5; //name and description
        //    dvParam.TitleList = new List<string>() { "", "Customer Number", "Customer", "NIC", "Gender", "Date of Birth", "Phone Number", "Email" }; //Column titles
        //    dvParam.InvisibleColumnList = new List<int>() { 1 };
        //    dvParam.NumericColumnList = new List<int>() { };
        //    dvParam.AddForm = new frmCustomer();
        //    dvParam.ViewForm = new frmCustomer();

        //    frmView vData = null;

        //    if (idBox == null && labelBox == null)
        //        vData = new frmView(dvParam);
        //    else
        //        vData = new frmView(dvParam, idBox, labelBox);
        //    vData.ShowDialog();
        //}

        public static Client getOneClient(int id)
        {
            Client client = new Client();
            try
            {
                String query = "SELECT " +
                    "id, " +
                    "bussiness_name, " +
                    "contact_number, " +
                    "email, " +
                    "address, " +
                    "image " +
                    "FROM clients " +
                    "WHERE id = '" + id + "'";
                Dictionary<String, String> dbData = DBTransactionService.getDataAsDictionary(query);

                if (dbData != null)
                {
                    client.Bussiness_name = dbData["bussiness_name"];
                    client.contact_number = dbData["contact_number"];
                    client.email = dbData["email"];
                    client.address = dbData["address"];
                    client.image = dbData["image"];
    
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
            return client;
        }
    }
}
