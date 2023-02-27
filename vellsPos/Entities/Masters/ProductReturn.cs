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
    internal class ProductReturn
    {
        private Int32 id;
        private Sale sale;
        private Product product;
        private Int32 qty;
        private Decimal amount;
        private User user;

        public ProductReturn()
        {

        }

        public ProductReturn(int id, Sale sale, Product product, int qty, decimal amount, User user)
        {
            this.Id = id;
            this.Sale = sale;
            this.Product = product;
            this.Qty = qty;
            this.Amount = amount;
            this.User = user;
        }

        public int Id { get => id; set => id = value; }
        public int Qty { get => qty; set => qty = value; }
        public decimal Amount { get => amount; set => amount = value; }
        internal Sale Sale { get => sale; set => sale = value; }
        internal Product Product { get => product; set => product = value; }
        internal User User { get => user; set => user = value; }

        public static ReturnResult store(ProductReturn productReturn)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                //store data
                string sql = "INSERT INTO `product_returns` " +
                    "(`sale_id`,`product_id`,`qty`,`amount`,`user_id`) VALUES (@sale_id,@product_id,@qty,@amount,@user_id)";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("sale_id", MySqlDbType.Int32, productReturn.sale.Id));
                parameters.Add(new QueryParameter("product_id", MySqlDbType.Int32, productReturn.product.Id));
                parameters.Add(new QueryParameter("qty", MySqlDbType.Int32, productReturn.qty));
                parameters.Add(new QueryParameter("amount", MySqlDbType.Decimal, productReturn.amount));
                parameters.Add(new QueryParameter("user_id", MySqlDbType.Int32, productReturn.user.Id));
                parameters.Add(new QueryParameter("id", MySqlDbType.Int32, productReturn.Id));

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

        public static ReturnResult update(ProductReturn productReturn)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                string sql = "UPDATE `product_returns` SET " +
                    "`sale_id` = @sale_id, " +
                     "`product_id` = @product_id, " +
                      "`qty` = @qty, " +
                     "`amount` = @amount, " +
                    "`user_id` = @user_id " +
                    " WHERE `id` = @id ";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("sale_id", MySqlDbType.Int32, productReturn.sale.Id));
                parameters.Add(new QueryParameter("product_id", MySqlDbType.Int32, productReturn.product.Id));
                parameters.Add(new QueryParameter("qty", MySqlDbType.Int32, productReturn.qty));
                parameters.Add(new QueryParameter("amount", MySqlDbType.Decimal, productReturn.amount));
                parameters.Add(new QueryParameter("user_id", MySqlDbType.Int32, productReturn.user.Id));

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
                string query = "DELETE FROM `product_returns` WHERE id = @id";
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
            dvParam.Title = "Product Returns";
            dvParam.SelectSql = "SELECT " +
                "pr.id, " +
                "s.date, " +
                "s.invoice_number, " +
                "p.product_number, " +
                "p.product_name, " +
                "pr.qty, pr.amount  ";
            dvParam.FromSql = "FROM  product_returns pr " +
                "INNER JOIN sales s ON pr.sale_id = s.id " +
                "INNER JOIN products p ON pr.product_id = p.id  " +
                "WHERE " +
                "p.product_number like @s1 or " +
                "p.product_name like @s2 " +
                "ORDER BY pr.id DESC ";
            dvParam.SearchParamCount = 2; //name and description
            dvParam.TitleList = new List<string>() { "", "Date", "Invoice Number", "Product Number", "Product Name", "Qty", "Amount" }; //Column titles

            dvParam.AddForm = new frmReturn();
            dvParam.ViewForm = new frmReturn();

            frmView vData = null;

            if (idBox == null && labelBox == null)
                vData = new frmView(dvParam);
            else
                vData = new frmView(dvParam, idBox, labelBox);
            vData.ShowDialog();
        }

        //public static void showOnViewFormSaleProduct(TextBox labelBox = null, TextBox idBox = null)
        //{
        //    DataViewParam dvParam = new DataViewParam();
        //    dvParam.Title = "Employees";
        //    dvParam.TableName = "employee";
        //    dvParam.SelectSql = "SELECT e.id, CONCAT(e.f_name,' ',e.l_name ), e.code, jr.tittle, p.name, d.name,e.work_hours,e.basic_salary, e.nic, e.gender  ";
        //    dvParam.FromSql = "from employee e  " +
        //        "LEFT JOIN job_role jr ON e.job_role_id=jr.id  " +
        //        "LEFT JOIN property p ON e.property_id=p.id  " +
        //        "LEFT JOIN department d ON e.depatrment_id=d.id " +
        //        "WHERE e.code like @s1 or CONCAT(e.f_name,' ',e.l_name) like @s2 or e.work_hours like @s3 or e.basic_salary like @s4 or nic like @s5 or jr.tittle like @s6 or  e.gender like @s7 or p.name like @s8 or d.name like @s9  ORDER BY e.id DESC ";
        //    dvParam.SearchParamCount = 8; //name and description
        //    dvParam.TitleList = new List<string>() { "", "Employee", "Code", "Job Role", "Property", "Department", "Work Hours", "Basic Salary", "NIC", "Gender" };
        //    dvParam.InvisibleColumnList = new List<int>() { 1 };
        //    dvParam.NumericColumnList = new List<int>() { };//Column titles
        //    //dvParam.FixedColumnNumber = 3;
        //    dvParam.ShowImage = "show";


        //    dvParam.AddForm = new frmReturn();
        //    dvParam.ViewForm = new frmReturn();


        //    frmView vData = null;

        //    if (idBox == null && labelBox == null)
        //        vData = new frmView(dvParam);
        //    else
        //        vData = new frmView(dvParam, idBox, labelBox);
        //    vData.Show();
        //}

        public static ProductReturn getOneProductReturn(int id)
        {
            ProductReturn productReturn = new ProductReturn();
            Sale sale = new Sale();
            Product product = new Product();
            User user = new User();
            try
            {
                String query = "SELECT " +
                    "pr.id, " +
                    "s.date AS date, " +
                    "s.invoice_number AS invoice, " +
                    "p.product_number AS productNu, " +
                    "p.product_name AS productNa, " +
                    "pr.qty, " +
                    "pr.amount " +
                    "FROM product_returns pr " +
                    "INNER JOIN sales s ON pr.sale_id = s.id " +
                    "INNER JOIN products p ON pr.product_id = p.id  " +
                    "WHERE pr.id = '" + id + "'";
                Dictionary<String, String> dbData = DBTransactionService.getDataAsDictionary(query);

                if (dbData != null)
                {
                    sale.Date = dbData["date"];
                    sale.InvoiceNumber = dbData["invoice"];
                    productReturn.sale = sale;
                    product.ProductNumber = dbData["productNu"];
                    product.ProductName = dbData["productNa"];
                    productReturn.product = product;
                    productReturn.qty = Convert.ToInt32(dbData["qty"]);
                    productReturn.amount = Convert.ToDecimal(dbData["amount"]);
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
            return productReturn;
        }
    }
}
