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
        Image Image;

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

                    if (result.Status == true)

                        result.Msg = Constants.MSG_STORE_SUCCESS;
                }
                catch (Exception ex)
                {
                    result.Status = false;
                    Console.WriteLine("The process failed: {0}", ex.ToString());
                }
                finally { }

                
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
