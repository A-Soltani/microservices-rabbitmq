using System;
using System.Configuration;
using System.Data.SqlClient;

namespace PushNotifying.Infrastructure.Repositories.SqlConnectionFactory
{
    public interface ISqlConnectionFactory
    {
        SqlConnection CreateMainServerSqlConnection();
    }

    public class SqlConnectionFactory : ISqlConnectionFactory
    {
        private const string TdsConnectionString = "ConnectionString";

        public SqlConnection CreateMainServerSqlConnection()
        {
            var mainServerConnectionString = ConfigurationManager.ConnectionStrings[TdsConnectionString].ConnectionString;
            return new SqlConnection(mainServerConnectionString);
        }
    }
}