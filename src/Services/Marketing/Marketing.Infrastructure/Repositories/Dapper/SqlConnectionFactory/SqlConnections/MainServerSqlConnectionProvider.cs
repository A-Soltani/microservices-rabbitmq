using System.Configuration;
using System.Data.SqlClient;

namespace Marketing.Infrastructure.Repositories.Dapper.SqlConnectionFactory.SqlConnections
{
    public class MainServerSqlConnectionProvider : SqlConnectionProvider
    {
        public SqlConnectionDatabaseType DatabaseType => SqlConnectionDatabaseType.Main;

        public string ConnectionString => ConfigurationManager.ConnectionStrings["MainServerConnectionString"].ConnectionString;
    }
}