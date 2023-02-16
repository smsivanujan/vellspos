using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vellsPos.Entities.Masters;
using vellsPos.Services;

namespace vellsPos.Entities.Layouts
{
    internal class Image
    {
        String imagePath;

        public Image(string imagePath)
        {
            this.ImagePath = imagePath;
        }

        public string ImagePath { get => imagePath; set => imagePath = value; }

        public static ReturnResult store(Image image)
        {
            ReturnResult result = new ReturnResult(false, "Error");
            //List<QueryCommand> commands = new List<QueryCommand>();
            try
            {
                // Specify the directory you want to manipulate.
                string directoryPath = @"c:\vellspos";

                try
                {
                    // Determine whether the directory exists.
                    if (Directory.Exists(directoryPath))
                    {
                        Console.WriteLine("That path exists already.");
                        //return;
                    }

                    // Try to create the directory.
                    DirectoryInfo di = Directory.CreateDirectory(directoryPath);
                    Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(directoryPath));

                    //saveImage(path);
                    String imagePath = image.imagePath;

                    File.Copy(imagePath, Path.Combine(directoryPath, Path.GetFileName(imagePath)), true);
                    // Delete the directory.
                    //di.Delete();
                    //Console.WriteLine("The directory was deleted successfully.");
                    result.Status = true;
                }
                catch (Exception ex)
                {
                    result.Status = false;
                    Console.WriteLine("The process failed: {0}", ex.ToString());
                }
                finally { }
                //store data
                //string sql = "INSERT INTO `customers` " +
                //    "(`customer_number`,`customer_first_name`,`customer_last_name`,`date_of_birth`,`gender`,`nic`,`phone_number`,`email`,`user_id`) " +
                //    "VALUES (@customer_number,@customer_first_name,@customer_last_name,@date_of_birth,@gender,@nic,@phone_number,@email,@user_id)";
                //List<QueryParameter> parameters = new List<QueryParameter>();
                //parameters.Add(new QueryParameter("customer_number", MySqlDbType.String, customer.CustomerNumber));
                //parameters.Add(new QueryParameter("customer_first_name", MySqlDbType.String, customer.CustomerLastName));
                //parameters.Add(new QueryParameter("customer_last_name", MySqlDbType.String, customer.CustomerLastName));
                //parameters.Add(new QueryParameter("date_of_birth", MySqlDbType.String, customer.dateOfBirth));
                //parameters.Add(new QueryParameter("gender", MySqlDbType.Int32, customer.gender));
                //parameters.Add(new QueryParameter("nic", MySqlDbType.String, customer.nic));
                //parameters.Add(new QueryParameter("phone_number", MySqlDbType.String, customer.phoneNumber));
                //parameters.Add(new QueryParameter("email", MySqlDbType.String, customer.email));
                //parameters.Add(new QueryParameter("user_id", MySqlDbType.Int32, customer.user.Id));

                //commands.Add(new QueryCommand(sql, parameters));
                //result = DBTransactionService.executeNonQuery(commands);
                if (result.Status==true)

                    result.Msg = Constants.MSG_STORE_SUCCESS;
            }
            catch (Exception e)
            {
                result = new ReturnResult(false, Constants.MSG_ERROR, e.Message, e);
                // MessageBox.Show(result);
            }
            return result;
        }
    }
}
