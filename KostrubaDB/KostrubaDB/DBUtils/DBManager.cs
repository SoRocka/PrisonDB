using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrisonDB
{
    public class DBManager : IDisposable
    {
        private const string connectionString = @"Data Source = DESKTOP-LPI61EL\SQLEXPRESS01; Initial Catalog = prison; Integrated Security = True";
        private SqlConnection sqlConnection = null;

        public DBManager()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public void Open()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                return;
            }
            sqlConnection.Open();
        }

        public void Close()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                return;
            }
            sqlConnection.Close();
        }

        public SqlDataReader ExecuteQuery(string sql, Hashtable pairs = null)
        {
            using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
            {
                try
                {
                    if (pairs != null && pairs.Count > 0)
                    {
                        foreach (DictionaryEntry entry in pairs)
                        {
                            cmd.Parameters.Add(new SqlParameter(entry.Key.ToString(), entry.Value));
                        }
                    }
                    return cmd.ExecuteReader();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public void ExecuteNonQuery(string sql, Hashtable pars = null)
        {
            using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
            {
                try
                {
                    if (pars != null && pars.Count > 0)
                    {
                        foreach (DictionaryEntry entry in pars)
                        {
                            cmd.Parameters.Add(new SqlParameter(entry.Key.ToString(), entry.Value));
                        }
                    }
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void Dispose()
        {
            if (sqlConnection.State != System.Data.ConnectionState.Closed)
            {
                Close();
            }
            sqlConnection.Dispose();
        }
    }
}
