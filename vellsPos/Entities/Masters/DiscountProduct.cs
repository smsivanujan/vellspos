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
    internal class DiscountProduct
    {
        private Int32 id;
        private Discount discount;
        private Product product;

        public DiscountProduct()
        {

        }

        public DiscountProduct(int id, Discount discount, Product product)
        {
            this.Id = id;
            this.Discount = discount;
            this.Product = product;
        }

        public int Id { get => id; set => id = value; }
        internal Discount Discount { get => discount; set => discount = value; }
        internal Product Product { get => product; set => product = value; }

        public static ReturnResult store(DiscountProduct discountProduct)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                //store data
                string sql = "INSERT INTO `discounts_products` " +
                    "(`discount_id`,`product_id`) " +
                    "VALUES (@discount_id,@product_id)";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("discount_id", MySqlDbType.Int32, discountProduct.discount.Id));
                parameters.Add(new QueryParameter("product_id", MySqlDbType.Int32, discountProduct.product.Id));

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

        public static ReturnResult update(DiscountProduct discountProduct)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                string sql = "UPDATE `discounts_products` SET " +
                    "`discount_id` = @discount_id, " +
                     "`product_id` = @product_id " +
                    " WHERE `id` = @id ";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("discount_id", MySqlDbType.Int32, discountProduct.discount.Id));
                parameters.Add(new QueryParameter("product_id", MySqlDbType.Int32, discountProduct.product.Id));
                parameters.Add(new QueryParameter("id", MySqlDbType.Int32, discountProduct.Id));

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
                string query = "DELETE FROM `discounts_products` WHERE id = @id";
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
            dvParam.Title = "Product's Discount        ";
            dvParam.SelectSql = "SELECT " +
                "dp.id, " +
                "d.discount_name, " +
                "date_format(d.date_to,'%Y-%m-%d %H:%i'), " +
                "date_format(d.date_from,'%Y-%m-%d %H:%i'), " +
                "p.product_number, " +
                "p.product_name " +
                "IF(d.status=0,'Inactive','Active') ";
            dvParam.FromSql = "FROM  discounts_products dp " +
                 "INNER JOIN discounts d ON dp.discount_id = d.id " +
                "INNER JOIN products p ON dp.product_id = p.id  " +
                "WHERE " +
                "d.discount_name like @s1 or " +
                "d.date_to like @s2 or " +
                "p.product_number like @s3 or " +
                "p.product_name like @s4 " +
                "ORDER BY d.id DESC ";
            dvParam.SearchParamCount = 3; //name and description
            dvParam.TitleList = new List<string>() { "", "Discount", "Date From", "Date To", "Product Number", "Product Name" }; //Column titles
            dvParam.InvisibleColumnList = new List<int>() { 1 };
            dvParam.NumericColumnList = new List<int>() { };
            dvParam.AddForm = new frmDiscount();
            dvParam.ViewForm = new frmDiscount();

            frmView vData = null;

            if (idBox == null && labelBox == null)
                vData = new frmView(dvParam);
            else
                vData = new frmView(dvParam, idBox, labelBox);
            vData.ShowDialog();
        }

        public static DiscountProduct getOneProductDiscount(int id)
        {
            DiscountProduct discountProduct = new DiscountProduct();
            Discount discount = new Discount();
            Product product = new Product();

            try
            {
                String query = "SELECT " +
                    "dp.id, " +
                    "d.discount_name AS discountNa, " +
                    "d.date_format(date_to,'%Y-%m-%d %H:%i') AS date_to, " +
                    "d.date_format(date_from,'%Y-%m-%d %H:%i') AS date_from, " +
                    "p.product_number AS productNu, " +
                    "p.product_name AS productNa " +
                    "FROM discounts_products dp " +
                    "WHERE dp.id = '" + id + "'";
                Dictionary<String, String> dbData = DBTransactionService.getDataAsDictionary(query);

                if (dbData != null)
                {
                    discount.DiscountName = dbData["discountNa"];
                    discount.DateFrom = dbData["date_to"];
                    discount.DateFrom = dbData["date_from"];
                    discountProduct.discount = discount;
                    product.ProductNumber = dbData["productNu"];
                    product.ProductName = dbData["productNa"];
                    discountProduct.product = product;
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
            return discountProduct;
        }
    }
}
