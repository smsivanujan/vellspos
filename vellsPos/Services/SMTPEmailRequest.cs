using Org.BouncyCastle.Utilities.Net;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace vellsPos.Services
{
    internal class SMTPEmailRequest
    {
        //public static HTTPReturnedResult makePostRequest(String url, NameValueCollection data)
        //{
        //    HTTPReturnedResult result = new HTTPReturnedResult();
        //    try
        //    {
        //        using (var wb = new WebClient())
        //        {
        //            var responseBytes = wb.UploadValues(url, "POST", data);
        //            result.message = Encoding.Default.GetString(responseBytes);
        //            result.isSuccess = true;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.exception = ex;
        //        result.isSuccess = false;
        //        result.message = ex.Message;
        //        Console.Write(ex);
        //    }
        //    return result;
        //}

        public static void SendEmail(String subject, String body)
        {
            String fromAddress = Properties.Settings.Default.SMTPemail;
            String password=Properties.Settings.Default.SMTPpassword;
            String toAddress = "lfailiure0@gmail.com";

            using SmtpClient email = new SmtpClient
            {
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                EnableSsl = true,
                Host = "smtp.gmail.com",
                Port = 587,
                Credentials = new NetworkCredential(fromAddress, password)
            };

            subject = "Login Detail";
            body = body + ' '+ DateTime.UtcNow;

            try
            {
                email.Send(fromAddress, toAddress, subject, body);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
