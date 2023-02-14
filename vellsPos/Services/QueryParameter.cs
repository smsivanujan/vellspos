using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vellsPos.Services
{
    internal class QueryParameter
    {
        private String paramKey;
        private MySqlDbType paramType;
        private String strValue;
        private Decimal decimalValue;
        private DateTime dateValue;
        private Int32 int32Value;
        //private string v;
        //private string id;

        public QueryParameter(string paramKey, MySqlDbType paramType, string strValue)
        {
            this.ParamKey = paramKey;
            this.ParamType = paramType;
            this.StrValue = strValue;
        }

        public QueryParameter(string paramKey, MySqlDbType paramType, decimal decimalValue)
        {
            this.ParamKey = paramKey;
            this.ParamType = paramType;
            this.DecimalValue = decimalValue;
        }

        public QueryParameter(string paramKey, MySqlDbType paramType, DateTime dateValue)
        {
            this.ParamKey = paramKey;
            this.ParamType = paramType;
            this.DateValue = dateValue;
        }

        public QueryParameter(string paramKey, MySqlDbType paramType, int int32Value)
        {
            this.ParamKey = paramKey;
            this.ParamType = paramType;
            this.Int32Value = int32Value;
        }

        public string ParamKey { get => paramKey; set => paramKey = value; }
        public MySqlDbType ParamType { get => paramType; set => paramType = value; }
        public string StrValue { get => strValue; set => strValue = value; }
        public decimal DecimalValue { get => decimalValue; set => decimalValue = value; }
        public DateTime DateValue { get => dateValue; set => dateValue = value; }
        public int Int32Value { get => int32Value; set => int32Value = value; }
    }
}
