using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Demo
{
    public class Database
    {
        public string sql = "Data Source=DESKTOP-MLOK1UH;Initial Catalog=Question;Integrated Security=True";
        public SqlConnection SqlConnection;
        public SqlCommand command;

        public Database()
        {
            SqlConnection = new SqlConnection(sql);
        }
        
        public void OpenConnec()
        {
            if(SqlConnection != null && SqlConnection.State == System.Data.ConnectionState.Closed)
            {
                SqlConnection.Open();
            }
        }

        public void CloseConnec()
        {

            if(SqlConnection != null && SqlConnection.State == System.Data.ConnectionState.Open)
            {
                SqlConnection.Close();
            }
        }

        public SqlDataReader ReadData(string sql)
        {
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = SqlConnection;
            OpenConnec();
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }
    }
}
