using System.Data.SqlClient;

namespace Marketing.Infrastructure.Repositories.Dapper.SqlConnectionFactory.SqlConnections
{
    public interface ISqlConnectionProvider
    {
        SqlConnectionDatabaseType DatabaseType { get; }
        string ConnectionString { get; }
        SqlConnection GetSqlConnection();
    }
}