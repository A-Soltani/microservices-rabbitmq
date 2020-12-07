using System.Configuration;
using System.Data.SqlClient;

namespace Marketing.Infrastructure.Repositories
{
    public interface ISqlConnectionProvider
    {
        SqlConnection GetMainServerSqlConnection();
    }

    public abstract class SqlConnectionProvider : ISqlConnectionProvider
    {
        private readonly string _mainConnectionString = ConfigurationManager.ConnectionStrings["MainServerConnectionString"].ConnectionString; 
        public SqlConnection GetMainServerSqlConnection() => new SqlConnection(_mainConnectionString);
    }
}