using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vellsPos.Services
{
    internal class ConnectionManager
    {
        public static String getConnectionString()
        {
            String uname = "";
            String pword = "";

            if(Properties.Settings.Default.IsDBCredentialsDefault==1)
            {
                uname = Properties.Settings.Default.DBuser;
                pword = Properties.Settings.Default.DBpassword;
            }
            else
            {
                uname = "root";
                pword = "v1e2l3l4p5o6s";
            }

            String conString = Properties.Settings.Default.DBServerString + "Database=" + Properties.Settings.Default.DBName + ";Uid=" + uname + ";Password=" + pword + ";Convert Zero Datetime=True;Allow Zero Datetime=True;Allow User Variables=True;";
            return conString;

        }

        public static bool checkConnection()
        {
            using(var l_oConnection = new MySqlConnection(getConnectionString()))
            {
                try
                {
                    l_oConnection.Open();
                    return true;
                }
                catch(MySqlException)
                {
                    return false;
                }
            }
        }
    }
}
