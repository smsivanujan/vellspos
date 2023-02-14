using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vellsPos.Services
{
    internal class QueryCommand
    {
        private string query;
        private List<QueryParameter> parameters;

        public QueryCommand(string query, List<QueryParameter> parameters)
        {
            this.Query = query;
            this.Parameters = parameters;
        }

        public string Query { get => query; set => query = value; }
        internal List<QueryParameter> Parameters { get => parameters; set => parameters = value; }

        public static void prepareQueryCommandWithParameters(MySqlCommand command, List<QueryParameter> queryParams)
        {
            foreach (QueryParameter qp in queryParams)
            {
                //MessageBox.Show(qp.ParamKey + " - " + qp.StrValue);

                if (qp.ParamType.ToString().Equals(MySqlDbType.Int32.ToString()))
                    command.Parameters.AddWithValue("@" + qp.ParamKey, qp.Int32Value);
                else if (qp.ParamType.ToString().Equals(MySqlDbType.String.ToString()) || qp.ParamType.ToString().Equals(MySqlDbType.VarChar.ToString()))
                    command.Parameters.AddWithValue("@" + qp.ParamKey, qp.StrValue);
                else if (qp.ParamType.ToString().Equals(MySqlDbType.Decimal.ToString()))
                    command.Parameters.AddWithValue("@" + qp.ParamKey, qp.DecimalValue);
                else if (qp.ParamType.ToString().Equals(MySqlDbType.DateTime.ToString()))
                    command.Parameters.AddWithValue("@" + qp.ParamKey, qp.DateValue);
            }
        }
    }
}
