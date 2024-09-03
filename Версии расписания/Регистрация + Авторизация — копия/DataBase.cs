using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Регистрация
{
    public class DataBase
    {
        public SqlConnection _connection;
        public readonly string _connectionString;

        public DataBase(string connectionString)
        {
            _connectionString = connectionString;
            _connection = new SqlConnection(_connectionString);
        }

        public void OpenConnection()
        {
            _connection.Open();
        }

        public void CloseConnection()
        {
            _connection.Close();
        }

        public SqlConnection GetConnection()
        {
            if (_connection.State != System.Data.ConnectionState.Open)
            {
                _connection.Open();
            }
            return _connection;
        }

        internal User AuthenticateUserAsync(string login, string pass)
        {
            throw new NotImplementedException();
        }
    




}
}
