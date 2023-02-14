using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vellsPos.Services
{
    internal class UtilManager
    {
        public static string getFinalQueryString(MySqlCommand command)
        {
            string tmp = command.CommandText.ToString();
            Console.WriteLine(command.Parameters.Count + " ==== >>> ");
            foreach (MySqlParameter p in command.Parameters)
            {
                Console.WriteLine(p.ParameterName.ToString() + "=================");
                tmp = tmp.Replace(p.ParameterName.ToString(), "'" + p.Value.ToString() + "'");
            }
            return tmp;
        }
    }
}
