using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vellsPos.Services
{
    internal class ReturnResult
    {
        private bool status;
        private string msg;
        private string detailedError;
        private Exception exception;

        public ReturnResult(bool status, string msg)
        {
            this.Status = status;
            this.Msg = msg;
        }

        public ReturnResult(bool status, string msg, string detailedError, Exception exception)
        {
            this.Status = status;
            this.Msg = msg;
            this.DetailedError = detailedError;
            this.Exception = exception;
        }

        public bool Status { get => status; set => status = value; }
        public string Msg { get => msg; set => msg = value; }
        public string DetailedError { get => detailedError; set => detailedError = value; }
        public Exception Exception { get => exception; set => exception = value; }
    }
}
