using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Microservices1.DataObjects
{
    public class DataAccess
    {
        SqlConnection _connection;

        public SqlConnection GetConnection() {
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: false).Build();
            if (_connection == null)
                _connection = new SqlConnection(configuration.GetConnectionString("dbcon"));
            return _connection;
        }

        public DataAccess()
        {
        }

        public string ExecuteNonQuery(string query) {
            using (SqlConnection con = GetConnection())
            {
                SqlCommand command = new SqlCommand(query, con);
                bool temp = false;
                try
                {
                    command.Connection.Open();
                    temp = command.ExecuteNonQuery() > 0;
                    command.Connection.Close();
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
                return temp.ToString();
            }
        }

        public DataTable ExecuteReader(string query) {
            using (SqlConnection con = GetConnection())
            {
                SqlCommand command = new SqlCommand(query,con);
                DataTable temp = new DataTable();
                try
                {
                    command.Connection.Open();
                    temp.Load(command.ExecuteReader());
                    command.Connection.Close();
                }
                catch 
                {
                    return null;
                }
                return temp;
            }
        }

    }
}
