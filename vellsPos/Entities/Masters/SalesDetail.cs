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
    internal class SalesDetail
    {
        private Int32 id;
        private Sale sale;
        private Product product;
        private Int32 qty;
        private Decimal amount;

        public SalesDetail()
        {

        }

        public SalesDetail(int id, Sale sale, Product product, int qty, decimal amount)
        {
            this.Id = id;
            this.Sale = sale;
            this.Product = product;
            this.Qty = qty;
            this.Amount = amount;
        }

        public int Id { get => id; set => id = value; }
        public int Qty { get => qty; set => qty = value; }
        public decimal Amount { get => amount; set => amount = value; }
        internal Sale Sale { get => sale; set => sale = value; }
        internal Product Product { get => product; set => product = value; }

        public static ReturnResult store(SalesDetail salesDetail)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                //store data
                string sql = "INSERT INTO `sale_details` " +
                    "(`sale_id`,`product_id`,`qty`,`amount`) VALUES (@sale_id,@product_id,@qty,@amount)";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("sale_id", MySqlDbType.Int32, salesDetail.sale.Id));
                parameters.Add(new QueryParameter("product_id", MySqlDbType.Int32, salesDetail.product.Id));
                parameters.Add(new QueryParameter("qty", MySqlDbType.Int32, salesDetail.qty));
                parameters.Add(new QueryParameter("amount", MySqlDbType.Decimal, salesDetail.amount));
                parameters.Add(new QueryParameter("id", MySqlDbType.Int32, salesDetail.Id));

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

        public static ReturnResult update(SalesDetail salesDetail)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                string sql = "UPDATE `sale_details` SET " +
                    "`sale_id` = @sale_id, " +
                     "`product_id` = @product_id, " +
                     "`qty` = @qty, " +
                    "`amount` = @amount " +
                    " WHERE `id` = @id ";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("sale_id", MySqlDbType.Int32, salesDetail.sale.Id));
                parameters.Add(new QueryParameter("product_id", MySqlDbType.Int32, salesDetail.product.Id));
                parameters.Add(new QueryParameter("qty", MySqlDbType.Int32, salesDetail.qty));
                parameters.Add(new QueryParameter("amount", MySqlDbType.Decimal, salesDetail.amount));

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
                string query = "DELETE FROM `sale_details` WHERE id = @id";
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
            dvParam.Title = "Sale Details";
            dvParam.SelectSql = "SELECT " +
                "sd.id, " +
                "s.date, " +
                "b.branch_name, " +
                "s.invoice_number, " +
                "concat(p.product_number,' ',p.product_name), " +
                "sd.qty, " +
                "sd.amount ";
            dvParam.FromSql = "FROM  sale_details sd " +
                 "INNER JOIN sales s ON sd.sale_id = s.id " +
                  "INNER JOIN products p ON sd.product_id = p.id " +
                  "INNER JOIN branches b ON sd.branch_id = b.id " +
                "WHERE " +
                "s.date like @s1 or " +
                "b.branch_name like @s2 or " +
                "s.invoice_number like @s3 or " +
                "p.product_number like @s4 or " +
                "p.product_name like @s5 " +
                "ORDER BY sd.id DESC ";
            dvParam.SearchParamCount = 4; //name and description
            dvParam.TitleList = new List<string>() { "", "Date", "Branch", "Invoice", "Product", "Qty", "Amount" }; //Column titles
            dvParam.InvisibleColumnList = new List<int>() { 5 , 6 };
            dvParam.NumericColumnList = new List<int>() { };
            //dvParam.AddForm = new frms();
            //dvParam.ViewForm = new frmComplain();

            //frmView vData = null;

            //if (idBox == null && labelBox == null)
            //    vData = new frmView(dvParam);
            //else
            //    vData = new frmView(dvParam, idBox, labelBox);
            //vData.Show();
        }

        public static void showOnViewFormSaleProduct(TextBox labelBox = null, TextBox idBox = null,String x=null )
        {
            Console.WriteLine(x);
            DataViewParam dvParam = new DataViewParam();
            dvParam.Title = "Sale Product Detail";
            dvParam.TableName = "sale_details";
            dvParam.SelectSql = "SELECT " +
                "sd.id, " +
                "p.product_number, " +
                "p.product_name, " +
                "sd.qty, " +
                "sd.amount  ";
            dvParam.FromSql = "from sale_details sd  " +
                "LEFT JOIN products p ON sd.product_id=p.id  " +
                "WHERE sd.id='"+ x + "' AND  p.product_number like @s1 or p.product_name like @s2  ORDER BY sd.id DESC ";
            dvParam.SearchParamCount = 2; //name and description
            dvParam.TitleList = new List<string>() { "", "Product Number", "Product Name", "Qty", "Amount" };
            dvParam.InvisibleColumnList = new List<int>() { 1 };
            dvParam.NumericColumnList = new List<int>() { 3, 4  };//Column titles
            //dvParam.FixedColumnNumber = 3;
            dvParam.ShowImage = "show";


            dvParam.AddForm = new frmReturn();
            dvParam.ViewForm = new frmReturn();


            frmView vData = null;

            if (idBox == null && labelBox == null)
                vData = new frmView(dvParam);
            else
                vData = new frmView(dvParam, idBox, labelBox);
            vData.Show();
        }

        public static SalesDetail getOneSaleDetail(int id)
        {
            SalesDetail salesDetail = new SalesDetail();
            Sale sale = new Sale();
            Product product = new Product();
            try
            {
                String query = "SELECT " +
                    "sd.id, " +
                    "s.date AS date, " +
                    "b.branch_name AS branch, " +
                    "s.invoice_number AS invoice, " +
                    "p.product_number AS productNu, " +
                    "p.product_name AS productNa, " +
                    "sd.qty, " +
                    "sd.amount " +
                    "FROM sale_details sd " +
                    "INNER JOIN sales s ON sd.sale_id = s.id " +
                    "INNER JOIN products p ON sd.product_id = p.id " +
                    "INNER JOIN branches b ON sd.branch_id = b.id " +
                    "WHERE sd.id = '" + id + "'";
                Dictionary<String, String> dbData = DBTransactionService.getDataAsDictionary(query);

                if (dbData != null)
                {
                    sale.Date = dbData["date"];
                    sale.InvoiceNumber = dbData["invoice"];
                    salesDetail.sale = sale;
                    product.ProductNumber = dbData["productNu"];
                    product.ProductName = dbData["productNa"];
                    salesDetail.product = product;
                    salesDetail.qty = Convert.ToInt32(dbData["qty"]);
                    salesDetail.amount = Convert.ToDecimal(dbData["amount"]);
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
            return salesDetail;
        }

        public static SalesDetail getOneSaleDetail(int saleID, int productID)
        {
            SalesDetail salesDetail = new SalesDetail();
            Sale sale = new Sale();
            Product product = new Product();
            try
            {
                String query = "SELECT * " +
                    "qty, " +
                    "amount " +
                    "FROM sale_details " +
                    "WHERE sale_id = '" + saleID + "' and product_id = '" + productID + "' ";
                Dictionary<String, String> dbData = DBTransactionService.getDataAsDictionary(query);

                if (dbData != null)
                {
                    //salesDetail.sale = sale;
                    //salesDetail.product = product;
                    salesDetail.qty = Convert.ToInt32(dbData["qty"]);
                    salesDetail.amount = Convert.ToDecimal(dbData["amount"]);
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
            return salesDetail;
        }
    }
}
