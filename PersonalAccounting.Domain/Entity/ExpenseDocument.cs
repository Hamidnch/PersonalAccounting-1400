using System;
using System.Collections.Generic;

namespace PersonalAccounting.Domain.Entity
{
    /// <summary>
    /// سند هزینه
    /// </summary>
    public sealed class ExpenseDocument : BaseEntity
    {
        #region Ctor

        public ExpenseDocument()
        {
            Status = "فعال";
            Description = "";
            IsDeleted = false;
        }

        public ExpenseDocument(DateTime? registerDate)
        {
            Status = "فعال";
            Description = "";
            IsDeleted = false;
            RegisterDate = registerDate;
        }
        public ExpenseDocument(DateTime? registerDate, int? createdBy,
            DateTime? createdOn, DateTime? lastUpdate, string description)
        {
            RegisterDate = registerDate;
            CreatedBy = createdBy;
            CreatedOn = createdOn;
            LastUpdate = lastUpdate;
            Description = description;
            Expenses = new List<Expense>();
            IsDeleted = false;
        }
        #endregion Ctor

        #region Fields
        /// <summary>
        /// تاریخ ثبت سند هزینه
        /// </summary>
        public DateTime? RegisterDate { get; set; }
        ///// <summary>
        ///// شماره سند
        ///// </summary>
        //public int DocumentId { get; set; }
        /// <summary>
        /// لیست اقلام هزینه
        /// </summary>
        #endregion Fields

        #region Navigation Property
        public ICollection<Expense> Expenses { get; set; }

        #endregion Navigation Property
    }
}
