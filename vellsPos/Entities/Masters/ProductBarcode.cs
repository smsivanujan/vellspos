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
    internal class ProductBarcode
    {
        private Int32 id;
        private Product product;
        private Discount discount;
        private String barcodeNumber;
        private String barcodeType;
        private Decimal barcodeWidth;
        private Decimal barcodeHeight;
        private String barcodeImage;

        public ProductBarcode()
        {

        }

        public ProductBarcode(int id, Product product, Discount discount, string barcodeNumber, string barcodeType, decimal barcodeWidth, decimal barcodeHeight, string barcodeImage)
        {
            this.Id = id;
            this.Product = product;;
            this.Discount = discount;
            this.BarcodeNumber = barcodeNumber;
            this.BarcodeType = barcodeType;
            this.BarcodeWidth = barcodeWidth;
            this.BarcodeHeight = barcodeHeight;
            this.BarcodeImage = barcodeImage;
        }

        public int Id { get => id; set => id = value; }
        public string BarcodeNumber { get => barcodeNumber; set => barcodeNumber = value; }
        public string BarcodeType { get => barcodeType; set => barcodeType = value; }
        public decimal BarcodeWidth { get => barcodeWidth; set => barcodeWidth = value; }
        public decimal BarcodeHeight { get => barcodeHeight; set => barcodeHeight = value; }
        public string BarcodeImage { get => barcodeImage; set => barcodeImage = value; }
        internal Product Product { get => product; set => product = value; }
        internal Discount Discount { get => discount; set => discount = value; }

        public static ReturnResult store(ProductBarcode productBarcode)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                //store data
                string sql = "INSERT INTO `product_barcodes` " +
                    "(`product_id`,`barcode_number`,`barcode_type`,`barcode_width`,`barcode_height`,`barcode_image`) " +
                    "VALUES (@product_id,@barcode_number,@barcode_type,@barcode_width,@barcode_height,@barcode_image)";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("product_id", MySqlDbType.Int32, productBarcode.product.Id));
                parameters.Add(new QueryParameter("barcode_number", MySqlDbType.String, productBarcode.barcodeNumber));
                parameters.Add(new QueryParameter("barcode_type", MySqlDbType.String, productBarcode.barcodeType));
                parameters.Add(new QueryParameter("barcode_width", MySqlDbType.Decimal, productBarcode.barcodeWidth));
                parameters.Add(new QueryParameter("barcode_height", MySqlDbType.Decimal, productBarcode.barcodeHeight));
                parameters.Add(new QueryParameter("barcode_image", MySqlDbType.String, productBarcode.BarcodeImage));

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
                string sql = "UPDATE `product_barcodes` SET " +
                    "`product_id` = @product_id, " +
                     "`barcode_number` = @barcode_number, " +
                      "`barcode_type` = @barcode_type, " +
                      "`barcode_width` = @barcode_width, " +
                     "`barcode_height` = @barcode_height, " +
                      "`barcode_image` = @barcode_image, " +
                    " WHERE `id` = @id ";
                List<QueryParameter> parameters = new List<QueryParameter>();
                parameters.Add(new QueryParameter("barcode_number", MySqlDbType.String, productBarcode.barcodeNumber));
                parameters.Add(new QueryParameter("barcode_type", MySqlDbType.String, productBarcode.barcodeType));
                parameters.Add(new QueryParameter("barcode_width", MySqlDbType.Decimal, productBarcode.barcodeWidth));
                parameters.Add(new QueryParameter("barcode_height", MySqlDbType.Decimal, productBarcode.barcodeHeight));
                parameters.Add(new QueryParameter("barcode_image", MySqlDbType.String, productBarcode.BarcodeImage));
                parameters.Add(new QueryParameter("id", MySqlDbType.Int32, productBarcode.Id));

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
                string query = "DELETE FROM `product_barcodes` WHERE id = @id";
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
            dvParam.Title = "Product Barcodes";
            dvParam.SelectSql = "SELECT " +
                "pb.id, " +
                "concat(p.product_number,' ',p.product_name), " +
                "pb.barcode_number, " +
                "pb.barcode_type, " +
                "pb.barcode_width, " +
                "pb.barcode_height ";
            dvParam.FromSql = "FROM  product_barcodes pb " +
                 "INNER JOIN products p ON pb.product_id = p.id " +
                "WHERE " +
                "p.product_name like @s1 or " +
                "pb.barcode_number like @s2 or " +
                "pb.barcode_type like @s3 " +
                "ORDER BY pb.id DESC ";
            dvParam.SearchParamCount = 5; //name and description
            dvParam.TitleList = new List<string>() { "", "Product", "Barcode Number", "Barcode type", "Barcode Width", "Barcode Height" }; //Column titles
            dvParam.InvisibleColumnList = new List<int>() { 4, 5 };
            dvParam.NumericColumnList = new List<int>() { };
            dvParam.AddForm = new frmProductBarcode();
            dvParam.ViewForm = new frmProductBarcode();

            frmView vData = null;

            if (idBox == null && labelBox == null)
                vData = new frmView(dvParam);
            else
                vData = new frmView(dvParam, idBox, labelBox);
            vData.ShowDialog();

            //frmHome g = new frmHome();
            //g.AddNewTab(vData);
            
        }

        public static ProductBarcode getOneProductBarcode(int id)
        {
            ProductBarcode productBarcode = new ProductBarcode();
            Product product = new Product();
            try
            {
                String query = "SELECT " +
                    "pb.id, " +
                     "p.id AS productID, " +
                    "p.product_number AS productNu, " +
                    "p.product_name AS productNa, " +
                    "pb.barcode_number, " +
                    "pb.barcode_type, " +
                    "pb.barcode_width, " +
                    "pb.barcode_height, " +
                    "pb.barcode_image " +
                    "FROM product_barcodes pb " +
                    "INNER JOIN products p ON pb.product_id = p.id " +
                    "WHERE pb.id = '" + id + "'";
                Dictionary<String, String> dbData = DBTransactionService.getDataAsDictionary(query);

                if (dbData != null)
                {
                    product.Id = Convert.ToInt32(dbData["productID"]);
                    product.ProductNumber = dbData["productNu"];
                    product.ProductName = dbData["productNa"];
                    productBarcode.product = product;
                    productBarcode.barcodeNumber = dbData["barcode_number"];
                    productBarcode.barcodeType = dbData["barcode_type"];
                    productBarcode.barcodeWidth = Convert.ToDecimal(dbData["barcode_width"]);
                    productBarcode.barcodeHeight = Convert.ToDecimal(dbData["barcode_height"]);
                    productBarcode.barcodeImage = dbData["barcode_image"];
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
