using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement.Libraries
{
    class Database
    {
        private string dbName;

        public Database(string dbname)
        {
            this.dbName = dbname;
        }

        public bool Query(string query, string[] param = null, string[] value = null)
        {
            using (var conn = new SQLiteConnection("Data Source=" + this.dbName + ".db;Version=3;"))
            {
                conn.Open();
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    // if param is still null, return the right-hand operand instead
                    param = param ?? new string[0];
                    for (int i = 0; i < param.Length; i++)
                    {
                        cmd.Parameters.AddWithValue(param[i], value[i]);
                    }

                    string[] split = query.Split(' ');
                    if (split[0].Equals("SELECT"))
                    {
                        var read = cmd.ExecuteReader();
                        var count = 0;
                        while (read.Read())
                        {
                            count += 1;
                        }

                        if (count > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        var isExecuted = cmd.ExecuteNonQuery();
                        if (isExecuted == 1)
                        {
                            return true;

                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            
        }

        public string[] RetrieveRowValues(string query, string[] param = null, string[] value = null, string[] columnToRetrieve = null)
        {
            string[] retrievedValues = new string[columnToRetrieve.Length];
            using (var conn = new SQLiteConnection("Data Source=" + this.dbName + ".db;Version=3;"))
            {
                conn.Open();
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    param = param ?? new string[0];
                    for (int i = 0; i < param.Length; i++)
                    {
                        cmd.Parameters.AddWithValue(param[i], value[i]);
                    }

                    SQLiteDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        for (int i = 0; i < columnToRetrieve.Length; i++)
                        {
                            retrievedValues[i] = dr[columnToRetrieve[i]].ToString();
                        }
                    }

                    dr.Close();
                }
            }
            return retrievedValues;
        }

        public void RetrieveToTable(DataTable dt,DataGridView dgv,string query, string[] param = null, string[] value = null)
        {
            dt.Clear();
            dgv.Refresh();
            using (var conn = new SQLiteConnection("Data Source=" + this.dbName + ".db;Version=3;"))
            {
                conn.Open();
                using (var da = new SQLiteDataAdapter(query, conn))
                {
                    param = param ?? new string[0];
                    for (int i = 0; i < param.Length; i++)
                    {
                        da.SelectCommand.Parameters.AddWithValue(param[i], value[i]);
                    }
                    
                    da.Fill(dt);
                    dgv.DataSource = dt;
                }
            }
        }

        public void RetrieveColumnValueToComboBox(ComboBox combobox,string query,string columnName, string[] param = null, string[] value = null)
        {
            using (var conn = new SQLiteConnection("Data Source=" + this.dbName + ".db;Version=3;"))
            {
                conn.Open();
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    param = param ?? new string[0];
                    for (int i = 0; i < param.Length; i++)
                    {
                        cmd.Parameters.AddWithValue(param[i], value[i]);
                    }

                    SQLiteDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        combobox.Items.Add(dr[columnName]);
                    }
                }
            }
        }
       
    }
}
