using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace PersonnelSTU.Data.Providers
{
    public interface ISqlProvider
    {
        SqlConnection GetLastOpenedConnection();
        SqlConnection OpenConnection(string connectionString);
        SqlConnection CloseLastOpenedConnection();
        int ExecuteQuery(string query);
        SqlDataReader ExecuteReader(string query);
    }

    public class SqlProvider : ISqlProvider
    {
        private SqlConnection _sqlConnection;

        public SqlConnection GetLastOpenedConnection()
        {
            return _sqlConnection;
        }

        public SqlConnection OpenConnection(string connectionString)
        {
            _sqlConnection = new SqlConnection(connectionString);
            _sqlConnection.Open();
            
            return _sqlConnection;
        }

        public SqlConnection CloseLastOpenedConnection()
        {
            _sqlConnection?.Close();

            return _sqlConnection;
        }

        public int ExecuteQuery(string query)
        {
            var sqlCommand = new SqlCommand(query, _sqlConnection);

            return sqlCommand.ExecuteNonQuery();
        }

        public SqlDataReader ExecuteReader(string query)
        {
            var sqlCommand = new SqlCommand(query, _sqlConnection);

            return sqlCommand.ExecuteReader();
        }
    }
}