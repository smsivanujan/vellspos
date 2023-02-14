using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace vellsPos.Services
{
    internal class HTTPRequest
    {
        public static HTTPReturnedResult makePostRequest(String url, NameValueCollection data)
        {
            HTTPReturnedResult result = new HTTPReturnedResult();
            try
            {
                using (var wb = new WebClient())
                {
                    var responseBytes = wb.UploadValues(url, "POST", data);
                    result.message = Encoding.Default.GetString(responseBytes);
                    result.isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                result.exception = ex;
                result.isSuccess = false;
                result.message = ex.Message;
                Console.Write(ex);
            }
            return result;
        }
    }
}
