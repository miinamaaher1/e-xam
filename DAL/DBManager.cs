using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Diagnostics;

namespace DAL
{
    public class DBManager
    {

        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter dataAdapter;
        DataTable dataTable;

        public DBManager()
        {
            try
            {
                var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
                conn = new SqlConnection(config.GetSection("constr").Value);

                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                dataAdapter = new SqlDataAdapter(cmd);
                dataTable = new DataTable();
            }
            catch
            {
                Debug.WriteLine("Error in DBManager Constructor");
            }
        }

        public int executeNonQuery(string _sp)
        {
            int R = -1;
            try
            {
                cmd.CommandText = _sp;
                cmd.Parameters.Clear();

                if (conn?.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                R = cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch
            {
                Debug.WriteLine("Error in DBManager.executeNonQuery");
                return R;
            }
            return R;
        }

        public object executeScaler(string _sp)
        {
            object R = new object();
            try
            {
                cmd.CommandText = _sp;
                cmd.Parameters.Clear();

                if (conn?.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                R = cmd.ExecuteScalar();

                conn.Close();
            }
            catch
            {
                Debug.WriteLine("Error in DBManager.executeScaler");
                return R;
            }
            return R;
        }

        public DataTable executeDataTable(string _sp)
        {
            dataTable.Clear();
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandText = _sp;

                dataAdapter.Fill(dataTable);
            }
            catch
            {
                Debug.WriteLine("Error in DBManager.executeDataTable");
                return dataTable;
            }
            return dataTable;
        }

        public int executeNonQuery(string _sp, Dictionary<string, Object> _parameters)
        {
            int R = -1;
            try
            {
                if (_parameters?.Count > 0)
                {
                    cmd.CommandText = _sp;
                    cmd.Parameters.Clear();
                    foreach (KeyValuePair<string, object> item in _parameters)
                    {
                        cmd.Parameters.AddWithValue(item.Key, item.Value);
                    }

                    if (conn?.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    R = cmd.ExecuteNonQuery();

                    conn.Close();
                }
                else
                {
                    Debug.WriteLine("Empty parameter list");
                }
            }
            catch
            {
                Debug.WriteLine("Error in DBManager.executeNonQuery");
                return R;
            }
            return R;
        }

        public object executeScaler(string _sp, Dictionary<string, Object> _parameters)
        {
            object R = new object();
            try
            {
                if (_parameters?.Count > 0)
                {
                    cmd.CommandText = _sp;
                    cmd.Parameters.Clear();

                    foreach (KeyValuePair<string, object> item in _parameters)
                    {
                        cmd.Parameters.AddWithValue(item.Key, item.Value);
                    }

                    if (conn?.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    R = cmd.ExecuteScalar();

                    conn.Close();

                }
                else
                {
                    Debug.WriteLine("Empty parameter list");
                }
            }
            catch
            {
                Debug.WriteLine("Error in DBManager.executeScaler");
                return R;
            }
            return R;
        }

        public DataTable executeDataTable(string _sp, Dictionary<string, Object> _parameters)
        {
            dataTable.Clear();
            try
            {
                if (_parameters?.Count > 0)
                {
                    cmd.CommandText = _sp;
                    cmd.Parameters.Clear();

                    foreach (KeyValuePair<string, object> item in _parameters)
                    {
                        cmd.Parameters.AddWithValue(item.Key, item.Value);
                    }

                    dataAdapter.Fill(dataTable);
                }
                else
                {
                    Debug.WriteLine("Empty parameter list");
                }
            }
            catch
            {
                Debug.WriteLine("Error in DBManager.executeDataTable");
                return dataTable;
            }
            return dataTable;
        }
    }
}
