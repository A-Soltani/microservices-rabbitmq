using System;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using PushNotifying.Infrastructure.Repositories.SqlConnectionFactory;

namespace PushNotifying.Infrastructure.Repositories.Dapper.PushNotification
{
    public class DapperPushNotificationRepository : IDapperPushNotificationRepository
    {
        private readonly ISqlConnectionFactory _sqlConnectionFactory;

        public DapperPushNotificationRepository(ISqlConnectionFactory sqlConnectionFactory) =>
            _sqlConnectionFactory = sqlConnectionFactory ?? throw new ArgumentNullException(nameof(sqlConnectionFactory));

        public async Task Add(PushNotificationDto pushNotificationDto)
        {
            await using var connection = _sqlConnectionFactory.CreateMainServerSqlConnection();

            var parameters = AddStoredProcedureParameters(pushNotificationDto, new DynamicParameters());
            await connection.QueryAsync("SpName", parameters, commandType: CommandType.StoredProcedure);

        }

        private DynamicParameters AddStoredProcedureParameters(PushNotificationDto pushNotificationDto, DynamicParameters parameters)
        {
            parameters.Add("@IN_Alert_en", pushNotificationDto.AlertEn, DbType.String);
            parameters.Add("@IN_Alert_fa", pushNotificationDto.AlertFa, DbType.String);
            parameters.Add("@IN_PushText_en", pushNotificationDto.PushTextEn, DbType.String);
            parameters.Add("@IN_PushText_fa", pushNotificationDto.PushTextFa, DbType.String);
            parameters.Add("@ActionType", pushNotificationDto.ActionType, DbType.Byte);
            parameters.Add("@IN_UserID", pushNotificationDto.UserId, DbType.Int32);
            parameters.Add("@IN_MobileNumber", pushNotificationDto.MobileNumber, DbType.String);
            parameters.Add("@IN_AppID", pushNotificationDto.AppId, DbType.Int64);
            return parameters;
        }
    }
}