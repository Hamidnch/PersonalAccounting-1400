using SQLite.CodeFirst;
using System;

namespace PersonalAccounting.DAL.Infrastructure
{
    public class SqliteCustomHistory : IHistory
    {
        public int Id { get; set; }
        public string Hash { get; set; }
        public string Context { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
