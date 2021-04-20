using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PersonalAccounting.Domain.Entity;

namespace PersonalAccounting.BLL.IService
{
    public partial interface ILoggerService
    {
        bool IsEnabled(LogLevel level);
        Task DeleteLogAsync(Log log);
        Task DeleteLogsAsync(IList<Log> logs);
        Task ClearLogAsync();
        Task<IList<Log>> GetAllLogsAsync(DateTime? fromUtc = null, DateTime? toUtc = null,
            string message = "", LogLevel? logLevel = null);
        Task<Log> GetLogByIdAsync(int logId);
        Task<IList<Log>> GetLogByIdsAsync(int[] logIds);
        Task<Log> InsertLogAsync(string formName, string action, LogLevel logLevel, string shortMessage,
            string fullMessage = "", int? userId = null);
        Task InformationAsync(string formName, string action, string message, string exception = null, int? userId = null);
        Task WarningAsync(string formName, string action, string message, string exception = null, int? userId = null);
        Task ErrorAsync(string formName, string action, string message, string exception = null, int? userId = null);
    }
}