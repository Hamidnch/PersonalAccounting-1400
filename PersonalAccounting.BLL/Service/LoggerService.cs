using PersonalAccounting.BLL.IService;
using PersonalAccounting.DAL.Infrastructure;
using PersonalAccounting.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalAccounting.BLL.Service
{
    public partial class LoggerService : ILoggerService
    {
        #region Fields

        private readonly IUnitOfWork _unitOfWork;
        private readonly IDbSet<Log> _logs;

        #endregion

        #region Ctor

        public LoggerService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _logs = _unitOfWork.Set<Log>();
        }

        #endregion

        #region Methods

        public virtual bool IsEnabled(LogLevel level)
        {
            switch (level)
            {
                case LogLevel.Debug:
                    return false;
                case LogLevel.Information:
                    return true;
                case LogLevel.Warning:
                    return true;
                case LogLevel.Error:
                    return true;
                case LogLevel.Fatal:
                    return true;
                default:
                    return true;
            }
        }

        public virtual async Task DeleteLogAsync(Log log)
        {
            if (log == null)
                throw new ArgumentNullException(nameof(log));

            var item = await _logs.FirstOrDefaultAsync(f => f.Id == log.Id);
            _logs.Remove(item);
            await _unitOfWork.SaveChangesAsync();
        }

        public virtual async Task DeleteLogsAsync(IList<Log> logs)
        {
            foreach (var log in logs)
            {
                await DeleteLogAsync(log);
            }
        }

        public virtual async Task ClearLogAsync()
        {
            foreach (var log in _logs)
            {
                await DeleteLogAsync(log);
            }
        }

        public virtual async Task<IList<Log>> GetAllLogsAsync(DateTime? fromUtc = null, DateTime? toUtc = null,
            string message = "", LogLevel? logLevel = null)
        {
            var myQuery =
                _logs.Where(l =>
                        fromUtc.Value <= l.CreatedOn &&
                        toUtc.Value >= l.CreatedOn &&
                        (int)logLevel.Value == l.LogLevelId &&
                        l.ShortMessage.Contains(message) || l.FullMessage.Contains(message))
                        .ToListAsync();

            return await myQuery;
        }

        public virtual async Task<Log> GetLogByIdAsync(int logId)
        {
            return await _logs.FirstOrDefaultAsync(i => i.Id == logId);
        }

        public virtual async Task<IList<Log>> GetLogByIdsAsync(int[] logIds)
        {
            IList<Log> logs = new List<Log>();

            foreach (var id in logIds)
            {
                var log = await _logs.FirstOrDefaultAsync(l => l.Id == id);
                logs.Add(log);
            }

            return logs;
        }

        public virtual async Task<Log> InsertLogAsync(string formName, string action,
            LogLevel logLevel, string shortMessage, string fullMessage = "", int? userId = null)
        {
            var log = new Log
            {
                LogLevel = logLevel,
                ShortMessage = shortMessage,
                FullMessage = fullMessage,
                CreatedOn = DateTime.UtcNow,
                CreatedBy = userId,
                FormName = formName,
                Action = action
            };

            _logs.Add(log);
            await _unitOfWork.SaveChangesAsync();

            return log;
        }

        public virtual async Task InformationAsync(string formName, string action, string message,
            string exception = null, int? userId = null)
        {
            if (IsEnabled(LogLevel.Information))
                await InsertLogAsync(formName, action, LogLevel.Information, message,
                    exception ?? string.Empty, userId);
        }

        public virtual async Task WarningAsync(string formName, string action, string message,
            string exception = null, int? userId = null)
        {
            if (IsEnabled(LogLevel.Warning))
                await InsertLogAsync(formName, action, LogLevel.Warning, message,
                    exception ?? string.Empty, userId);
        }

        public virtual async Task ErrorAsync(string formName, string action, string message,
            string exception = null, int? userId = null)
        {
            if (IsEnabled(LogLevel.Error))
                await InsertLogAsync(formName, action, LogLevel.Error, message,
                    exception ?? string.Empty, userId);
        }

        #endregion
    }
}
