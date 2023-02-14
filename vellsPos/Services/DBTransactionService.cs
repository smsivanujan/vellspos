using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vellsPos.Services
{
    internal class DBTransactionService
    {
        public static MySqlConnection conn = new MySqlConnection(ConnectionManager.getConnectionString());

        public static DataTable QueryAsDataTable(string sql)
        {
            try
            {
                conn.Close();
                conn.Open();
                DataSet ds;
                MySqlDataAdapter da;
                da = new MySqlDataAdapter(sql, conn);
                ds = new DataSet();
                da.Fill(ds, "result");
                conn.Close();
                return ds.Tables["result"];
            }
            catch (Exception ex)
            {
                conn.Close();
                return null;
            }
        }

        public static ReturnResult executeNonQuery(List<QueryCommand> commands)
        {
            bool isLocallySaved = false;
            bool isQuerySaved = false;
            try
            {
                conn.Close();
                conn.Open();
            }
            catch (Exception e)
            {
                return new ReturnResult(false, Constants.MSG_DB_ERROR, "", e);
            }
            MySqlTransaction tran = conn.BeginTransaction();
            try
            {
                //saving data locally
                foreach (QueryCommand qc in commands)
                {
                    MySqlCommand command = conn.CreateCommand();
                    command.CommandText = qc.Query;
                    QueryCommand.prepareQueryCommandWithParameters(command, qc.Parameters);
                    Console.WriteLine(UtilManager.getFinalQueryString(command));
                    command.ExecuteNonQuery();
                }
                /**MySqlCommand command2 = conn.CreateCommand();
                string commandText = "insert into zz_ran_queries (querytext,isLocalSaveSuccessful,isOnlineSaveSuccessful,executedby,executedcounter,message) VALUES ( \"" + sql + "\",true,true," + Session.uid + ",\"" + Session.counterName + "\",'SUCCESS');";
                command2.CommandText = commandText;
                command2.ExecuteNonQuery();**/
                tran.Commit();
                conn.Close();
                isLocallySaved = true;
                isQuerySaved = true;
                return new ReturnResult(true, "Operation Successful");
            }
            catch (Exception e)
            {
                tran.Rollback();
                throw;
                try
                {
                    //saving the queries if failes
                    conn.Close();
                    /** conn.Open();
                     MySqlCommand command2 = conn.CreateCommand();
                     command2.CommandText = "insert into zz_ran_queries (querytext,isLocalSaveSuccessful,isOnlineSaveSuccessful,executedby,executedcounter,message) VALUES ( \"" + sql + "\"," + isLocallySaved + ", " + isOnlineSaved + "," + Session.uid + ",\"" + Session.counterName + "\",\"" + ex.Message + "\");";
                     command2.ExecuteNonQuery();
                     isQuerySaved = true;
                     conn.Close();**/
                }
                catch (Exception ex2)
                {
                    Console.WriteLine(ex2.Message);
                }
                conn.Close();
                return new ReturnResult(false, Constants.MSG_ERROR, e.Message, e);
            }
        }

        public static DataTable getDataAsDataTable(int offset, int count, string sql)
        {
            try
            {
                conn.Close();
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                DataTable table = new DataTable();
                adapter.Fill(offset, count, table);
                conn.Close();
                return table;
            }
            catch (Exception ex)
            {
                conn.Close();
                return null;
            }
        }

        public static DataTable getDataAsDataTable(int offset, int count, QueryCommand qCommand)
        {
            try
            {
                conn.Close();
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = qCommand.Query;
                QueryCommand.prepareQueryCommandWithParameters(command, qCommand.Parameters);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(offset, count, table);
                conn.Close();
                return table;
            }
            catch (Exception ex)
            {
                conn.Close();
                throw;
                return null;
            }
        }

        //get data as data table without limits
        public static DataTable getDataAsDataTableWithOutLimit(string sql)
        {
            try
            {
                conn.Close();
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                conn.Close();
                return table;
            }
            catch (Exception ex)
            {
                conn.Close();
                return null;
            }
        }

        //get data as dictionary
        public static Dictionary<string, string> getDataAsDictionary(String sql)
        {
            Console.WriteLine("===================");
            try
            {
                Dictionary<String, String> dict = new Dictionary<String, String>();
                conn.Close();
                conn.Open();
                Console.WriteLine("This is from inside the function " + sql);
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = sql;
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    if (reader[0] != DBNull.Value)
                    {
                        for (int lp = 0; lp < reader.FieldCount; lp++)
                        {
                            String name = reader.GetName(lp);
                            String value = reader.GetValue(lp).ToString();
                            dict.Add(name, value);
                        }
                    }
                }
                conn.Close();
                reader.Close();
                return dict;
            }
            catch (Exception ex)
            {
                Console.WriteLine(">>>>>>> ===================");
                conn.Close();
                //MessageBox.Show(ex.Message);
                return null;
            }
        }

        //get data as list of listitems for dropdown and fill combo boxes
        public static List<ListItem> getDataAsListItemsAndFillComboBox(String sql, ComboBox cmb)
        {
            try
            {
                List<ListItem> itm = new List<ListItem>();
                conn.Close();
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = sql;
                MySqlDataReader reader = command.ExecuteReader();
                cmb.Items.Clear();
                int x = 0;
                while (reader.Read())
                {
                    string value = reader["value"].ToString();
                    string text = reader["text"].ToString();

                    ListItem it = new ListItem(x, value, text);
                    itm.Add(it);
                    cmb.Items.Add(text);
                    x++;
                }
                conn.Close();
                reader.Close();
                Console.WriteLine("Master Function " + itm.Count);
                return itm;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
                return null;
            }
        }

        //get a scaler or single data
        public static string getScalerData(string sql)
        {
            try
            {
                sql += " LIMIT 1 OFFSET 0 ";
                List<ListItem> itm = new List<ListItem>();
                conn.Close();
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                String data = cmd.ExecuteScalar().ToString();
                conn.Close();
                return data;
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static string getScalerData(QueryCommand qCommand)
        {
            try
            {
                conn.Close();
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = qCommand.Query + " LIMIT 1 OFFSET 0 ";
                QueryCommand.prepareQueryCommandWithParameters(command, qCommand.Parameters);
                String data = command.ExecuteScalar().ToString();
                conn.Close();
                return data;
            }
            catch (Exception ex)
            {
                conn.Close();
                return null;
            }
        }

        public static int checkLogin(String sql)
        {
            int status = 0;
            try
            {
                conn.Close();
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = sql;
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    status = 1;
                }
                else
                {
                    status = 0;
                }
                conn.Close();
                reader.Close();
                Console.WriteLine("Authentication " + status);
                return status;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }
            return status;
        }

        public static Bitmap getImgFromDB(String sql)
        {
            MySqlDataReader myData;
            MySqlCommand cmd = new MySqlCommand();

            byte[] rawData;
            MemoryStream ms;
            UInt32 FileSize;
            Bitmap outImage;

            try
            {
                conn.Close();
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = sql;

                myData = cmd.ExecuteReader();

                if (!myData.HasRows)
                    throw new Exception("There are no blobs to save");

                myData.Read();

                FileSize = myData.GetUInt32(myData.GetOrdinal("img"));
                rawData = new byte[FileSize];

                myData.GetBytes(myData.GetOrdinal("img"), 0, rawData, 0, (Int32)FileSize);


                ms = new MemoryStream(rawData);
                outImage = new Bitmap(ms);
                ms.Close();
                ms.Dispose();

                myData.Close();
                myData.Dispose();

                cmd.Dispose();

                return outImage;


            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
