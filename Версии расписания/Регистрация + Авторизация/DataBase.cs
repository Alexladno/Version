using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Регистрация
{
    internal class DataBase
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-AC0US7D\SQLEXPRESS;Initial Catalog=diplom;
        Integrated Security=True");
        
        public DataBase() { }

        public void openConnection()
        {
           if(sqlConnection.State == System.Data.ConnectionState.Closed) 
            {
            sqlConnection.Open();
            }
        }

        public void  closedConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }

        internal User AuthenticateUserAsync(string login, string pass)
        {
            throw new NotImplementedException();
        }




    }
}
