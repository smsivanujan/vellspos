using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vellsPos.Services;

namespace vellsPos.Entities.Layouts
{
    internal class ImageUpload
    {
        String rootPath;
        String directoryPath;
        String imagePath;

        public ImageUpload()
        {
            
        }

        public ImageUpload(string rootPath, string directoryPath, string imagePath)
        {
            this.RootPath = rootPath;
            this.DirectoryPath = directoryPath;
            this.ImagePath = imagePath;
        }

        public string RootPath { get => rootPath; set => rootPath = value; }
        public string DirectoryPath { get => directoryPath; set => directoryPath = value; }
        public string ImagePath { get => imagePath; set => imagePath = value; }


        public static ReturnResult store(ImageUpload imageUpload)
        {
            ReturnResult result = new ReturnResult(false, "Error");

            try
            {
                // Specify the directory you want to manipulate.
                //string rootPath = @"c:\vellspos";
                String rootPath = imageUpload.rootPath;
                String directoryPath = imageUpload.directoryPath;
                String imagePath = imageUpload.imagePath;

                try
                {
                    // Determine whether the directory exists.
                    if (Directory.Exists(rootPath))
                    {
                        Console.WriteLine("That path exists already.");
                        //return;
                    }

                    // Try to create the directory.
                    DirectoryInfo di = Directory.CreateDirectory(rootPath);
                    Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(rootPath));

                    //saveImage(path);
                    File.Copy(imagePath, directoryPath, true);

                    //File.Copy(imagePath, directoryPath, true);
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
                if (result.Status == true)

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
