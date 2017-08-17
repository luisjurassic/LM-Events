using LM_Events.Properties;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace LM_Events.DataObjectBase.Conexao
{
    class DbUtils
    {
        public void Execute(SqlCommand command)
        {
            using (ConnectionHelper helper = new ConnectionHelper())
            {
                helper.AttachCommand(command);
                command.ExecuteNonQuery();
            }
        }

        public int ExecuteOnIdentity(SqlCommand command)
        {
            using (ConnectionHelper helper = new ConnectionHelper())
            {
                helper.AttachCommand(command);
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        public DataTable Search(SqlCommand command)
        {
            using (ConnectionHelper helper = new ConnectionHelper())
            {
                helper.AttachCommand(command);
                SqlDataReader reader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                return dt;
            }
        }

    }

    class ConnectionHelper : IDisposable
    {
        SqlConnection connection;
        public string ConnectionString
        {
            get
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DataObjectBase", "dbo.mdf");
                return $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={path};Integrated Security=True;Connect Timeout=120;Context Connection=False";
            }
        }


        public ConnectionHelper()
        {
            connection = new SqlConnection(ConnectionString);
        }

        public void AttachCommand(SqlCommand command)
        {
            command.Connection = connection;
            this.Open();
        }

        public void Open()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }

        public void Dispose()
        {
            connection.Dispose();
        }
    }
}
