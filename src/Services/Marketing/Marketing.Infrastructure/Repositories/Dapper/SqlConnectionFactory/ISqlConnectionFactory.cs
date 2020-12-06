using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Marketing.Infrastructure.Repositories.Dapper.SqlConnectionFactory.SqlConnections;

namespace Marketing.Infrastructure.Repositories.Dapper.SqlConnectionFactory
{
    public interface ISqlConnectionFactory
    {
        SqlConnectionProvider CreateSqlConnection(SqlConnectionDatabaseType sqlConnectionDatabaseType);
    }

    public class SqlConnectionFactory : ISqlConnectionFactory
    {
        private readonly IEnumerable<SqlConnectionProvider> _sqlConnections;

        public SqlConnectionFactory(IEnumerable<SqlConnectionProvider> sqlConnections) => 
            _sqlConnections = sqlConnections ?? throw new ArgumentNullException(nameof(sqlConnections));

        public SqlConnectionProvider CreateSqlConnection(SqlConnectionDatabaseType sqlConnectionDatabaseType) => 
            _sqlConnections.First(s => s.DatabaseType == sqlConnectionDatabaseType);
    }
}