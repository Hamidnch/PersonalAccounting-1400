using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalAccounting.Domain.Entity
{
    /// <summary>
    /// لاگ گزارش
    /// </summary>
    public partial class Log : BaseEntity
    {
        public int LogLevelId { get; set; }
        public string ShortMessage { get; set; }
        public string FullMessage { get; set; }
        public string FormName { get; set; }
        public string Action { get; set; }


        public LogLevel LogLevel
        {
            get => (LogLevel)LogLevelId;
            set => LogLevelId = (int)value;
        }
    }
}
