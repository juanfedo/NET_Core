using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Extensions.Configuration;

namespace Microservices1.DataObjects
{
    public class DataAccess
    {
        SqlConnection _connection;
        private readonly IConfiguration _config;

        public SqlConnection GetConnection() {
            if (_connection == null)
                _connection = new SqlConnection("server=DESKTOP-9183MDS\\SQLEXPRESS;database=test;User Id=sa;Password=patojo");
            return _connection;
        }

        public DataAccess()
        {
            //_config = config;
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
                command.Connection.Open();
                temp.Load(command.ExecuteReader());
                command.Connection.Close();
                return temp;
            }
        }

    }
}
