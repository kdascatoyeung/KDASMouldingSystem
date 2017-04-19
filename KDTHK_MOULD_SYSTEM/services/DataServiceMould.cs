using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace KDTHK_MOULD_SYSTEM.services
{
    public class DataServiceMould
    {
        private SqlConnection connection;
        private static DataServiceMould _dataService = null;
        private SqlCommand command;

        private DataServiceMould()
        {
            //string connectionString = "server=HSP1DB01\\KM_SQUARE;database=KDTHK_DB_MOULD_SYSTEM;user id=general;password=JLgj2007";
            string connectionString = "server=KDTHK-INTDB\\KDTHK_DB;database=db_mould;user id=sa;password=Aa123456";
            connection = new SqlConnection(connectionString);
            connection.Open();
            command = new SqlCommand();
            command.Connection = connection;
        }

        public static DataServiceMould GetInstance()
        {
            if (_dataService == null)
                _dataService = new DataServiceMould();

            return _dataService;
        }

        public SqlConnection Connection
        {
            get { return connection; }
        }

        public SqlDataReader ExecuteReader(string query)
        {
            command.CommandText = query;
            return command.ExecuteReader();
        }

        public object ExecuteScalar(string query)
        {
            command.CommandText = query;
            return command.ExecuteScalar();
        }

        public SqlCommand CreateCommand(string query)
        {
            return connection.CreateCommand();
        }

        public int ExecuteNonQuery(string commandText)
        {
            command.CommandText = commandText;
            return command.ExecuteNonQuery();
        }

        public SqlTransaction BeginTransaction()
        {
            return Connection.BeginTransaction();
        }
    }
}
