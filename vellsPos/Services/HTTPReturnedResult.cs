using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vellsPos.Services
{
    internal class HTTPReturnedResult
    {
        public bool isSuccess;
        public Exception exception = new Exception();
        public string message;
        public List<string> data = new List<string>();
        public int numberOfRecords = 0;
    }
}
