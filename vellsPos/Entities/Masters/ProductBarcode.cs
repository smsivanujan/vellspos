using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vellsPos.Services;

namespace vellsPos.Entities.Masters
{
    internal class ProductBarcode
    {
        private Int32 id;
        private Product product;
        private Decimal salePrice;
        private Discount discount;
        private String barcodeNumber;
        private String barcodeType;
        private Int32 barcodeOption;
        private Decimal barcodeWidth;
        private Decimal barcodeHeight;
        private String barcodeImage;
        private String productNumber;
        private String productName;

        public ProductBarcode()
        {

        }

        public ProductBarcode(int id, Product product, decimal salePrice, Discount discount, string barcodeNumber, string barcodeType, int barcodeOption, decimal barcodeWidth, decimal barcodeHeight, string barcodeImage, string productNumber, string productName)
        {
            this.Id = id;
            this.Product = product;
            this.SalePrice = salePrice;
            this.Discount = discount;
            this.BarcodeNumber = barcodeNumber;
            this.BarcodeType = barcodeType;
            this.BarcodeOption = barcodeOption;
            this.BarcodeWidth = barcodeWidth;
            this.BarcodeHeight = barcodeHeight;
            this.BarcodeImage = barcodeImage;
            this.ProductNumber = productNumber;
            this.ProductName = productName;
        }

        public int Id { get => id; set => id = value; }
        public decimal SalePrice { get => salePrice; set => salePrice = value; }
        public string BarcodeNumber { get => barcodeNumber; set => barcodeNumber = value; }
        public string BarcodeType { get => barcodeType; set => barcodeType = value; }
        public int BarcodeOption { get => barcodeOption; set => barcodeOption = value; }
        public decimal BarcodeWidth { get => barcodeWidth; set => barcodeWidth = value; }
        public decimal BarcodeHeight { get => barcodeHeight; set => barcodeHeight = value; }
        public string BarcodeImage { get => barcodeImage; set => barcodeImage = value; }
        public string ProductNumber { get => productNumber; set => productNumber = value; }
        public string ProductName { get => productName; set => productName = value; }
        internal Product Product { get => product; set => product = value; }
        internal Discount Discount { get => discount; set => discount = value; }

        public static ReturnResult store(ProductBarcode productBarcode)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                //store data
                string sql = "INSERT INTO `product_barcode` " +
                    "(`product_id`,`sale_price`,`discount_id`,`barcode_number`,`barcode_type`,`barcode_option`,`barcode_width`,`barcode_height`,`barcode_image`,`product_number`,`product_name`) " +
                    "VALUES (@product_id,@sale_price,@discount_id,@barcode_number,@barcode_type,@barcode_option,@barcode_width,@barcode_height,@barcode_image,@product_number,@product_name)";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("product_id", MySqlDbType.Int32, productBarcode.product.Id));
                parameters.Add(new QueryParameter("sale_price", MySqlDbType.Decimal, productBarcode.salePrice));
                parameters.Add(new QueryParameter("discount_id", MySqlDbType.Int32, productBarcode.discount.Id));
                parameters.Add(new QueryParameter("barcode_number", MySqlDbType.String, productBarcode.barcodeNumber));
                parameters.Add(new QueryParameter("barcode_type", MySqlDbType.String, productBarcode.barcodeType));
                parameters.Add(new QueryParameter("barcode_option", MySqlDbType.Int32, productBarcode.barcodeOption));
                parameters.Add(new QueryParameter("barcode_width", MySqlDbType.Decimal, productBarcode.barcodeWidth));
                parameters.Add(new QueryParameter("barcode_height", MySqlDbType.Decimal, productBarcode.barcodeHeight));
                parameters.Add(new QueryParameter("barcode_image", MySqlDbType.String, productBarcode.BarcodeImage));
                parameters.Add(new QueryParameter("product_number", MySqlDbType.String, productBarcode.productNumber));
                parameters.Add(new QueryParameter("product_name", MySqlDbType.String, productBarcode.productName));

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

        public static ReturnResult update(ProductBarcode productBarcode)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                string sql = "UPDATE `product_barcode` SET " +
                    "`product_id` = @product_id, " +
                     "`sale_price` = @sale_price, " +
                      "`discount_id` = @discount_id, " +
                     "`barcode_number` = @barcode_number, " +
                      "`barcode_type` = @barcode_type, " +
                     "`barcode_option` = @barcode_option, " +
                      "`barcode_width` = @barcode_width, " +
                     "`barcode_height` = @barcode_height, " +
                      "`barcode_image` = @barcode_image, " +
                     "`product_number` = @product_number, " +
                      "`product_name` = @product_name " +
                    " WHERE `id` = @id ";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("product_id", MySqlDbType.Int32, productBarcode.product.Id));
                parameters.Add(new QueryParameter("sale_price", MySqlDbType.Decimal, productBarcode.salePrice));
                parameters.Add(new QueryParameter("discount_id", MySqlDbType.Int32, productBarcode.discount.Id));
                parameters.Add(new QueryParameter("barcode_number", MySqlDbType.String, productBarcode.barcodeNumber));
                parameters.Add(new QueryParameter("barcode_type", MySqlDbType.String, productBarcode.barcodeType));
                parameters.Add(new QueryParameter("barcode_option", MySqlDbType.Int32, productBarcode.barcodeOption));
                parameters.Add(new QueryParameter("barcode_width", MySqlDbType.Decimal, productBarcode.barcodeWidth));
                parameters.Add(new QueryParameter("barcode_height", MySqlDbType.Decimal, productBarcode.barcodeHeight));
                parameters.Add(new QueryParameter("barcode_image", MySqlDbType.String, productBarcode.BarcodeImage));
                parameters.Add(new QueryParameter("product_number", MySqlDbType.String, productBarcode.productNumber));
                parameters.Add(new QueryParameter("product_name", MySqlDbType.String, productBarcode.productName));

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
                string query = "DELETE FROM `product_barcode` WHERE id = @id";
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

        public static ProductBarcode getOneProductBarcode(int id)
        {
            ProductBarcode productBarcode = new ProductBarcode();
            Product product = new Product();
            Discount discount = new Discount();
            try
            {
                String query = "SELECT * FROM product_barcode where id = '" + id + "'";
                Dictionary<String, String> dbData = DBTransactionService.getDataAsDictionary(query);

                if (dbData != null)
                {
                    productBarcode.product = product;
                    productBarcode.salePrice = Convert.ToDecimal(dbData["sale_price"]);
                    productBarcode.discount = discount;
                    productBarcode.barcodeNumber = dbData["barcode_number"];
                    productBarcode.barcodeType = dbData["barcode_type"];
                    productBarcode.barcodeOption = Convert.ToInt32(dbData["barcode_option"]);
                    productBarcode.barcodeWidth = Convert.ToDecimal(dbData["barcode_width"]);
                    productBarcode.barcodeHeight = Convert.ToDecimal(dbData["barcode_height"]);
                    productBarcode.barcodeImage = dbData["barcode_image"];
                    productBarcode.productNumber = dbData["product_number"];
                    productBarcode.productName = dbData["product_name"];

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
            return productBarcode;
        }
    }
}
