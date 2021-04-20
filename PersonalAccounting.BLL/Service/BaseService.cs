using PersonalAccounting.DAL.Infrastructure;
using PersonalAccounting.Domain.Entity;
using System;
using System.Data.Entity;

namespace PersonalAccounting.BLL.Service
{
    public class BaseService
    {
        private readonly IDbSet<Log> _logs;

        public BaseService(IUnitOfWork unitOfWork)
        {
            _logs = unitOfWork.Set<Log>();
        }
        public string GetServiceName()
        {
            return this.GetType().Name;
        }

        public void InsertLog(LogLevel logLevel, string formName, string action,
            string shortMessage, string fullMessage, int? currentUser = null)
        {
            var log = new Log
            {
                FormName = formName,
                Action = action,
                ShortMessage = shortMessage,
                FullMessage = fullMessage,
                LogLevelId = (int)logLevel,
                CreatedBy = currentUser,
                //LastUpdate = DateTime.Now,
                CreatedOn = DateTime.Now,
                IsDeleted = false,
                Status = "فعال",
                Description = string.Empty
            };
            _logs.Add(log);
        }
    }
}

