using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalAccounting.Domain.Entity
{
    public class Fund : BaseEntity
    {
        public enum FundTypes
        {
            Account = 1,
            Other = 2
        }
        #region Ctor

        public Fund()
        {
            Status = "فعال";
            Description = "";
            IsDeleted = false;
        }

        public Fund(FundTypes type, string title, int? bankAccountId, double primaryValue, double currentValue)
        {
            Type = type;
            Title = title;
            BankAccountId = bankAccountId;
            PrimaryValue = primaryValue;
            CurrentValue = currentValue;
            Status = "فعال";
            Description = "";
            IsDeleted = false;
        }

        public Fund(FundTypes type, string title, int? bankAccountId,
            double primaryValue, double currentValue,
            DateTime? createdOn, DateTime? lastUpdate,
            int? createdBy, string status, string description)
        {
            Type = type;
            Title = title;
            BankAccountId = bankAccountId;
            PrimaryValue = primaryValue;
            CurrentValue = currentValue;
            CreatedOn = createdOn;
            LastUpdate = lastUpdate;
            CreatedBy = createdBy;
            Status = status;
            Description = description;
            IsDeleted = false;
        }
        #endregion Ctor

        #region Fields
        /// <summary>
        /// نوع صندوق
        /// </summary>
        public FundTypes Type { get; set; }
        /// <summary>
        /// نام صندوق
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// شناسه حساب بانکی در صورتی که نوع صندوق حساب بانکی باشد.
        /// </summary>
        public int? BankAccountId { get; set; }
        /// <summary>
        /// مانده اولیه
        /// </summary>
        public double PrimaryValue { get; set; }
        /// <summary>
        /// مانده جاری صندوق
        /// </summary>
        public double CurrentValue { get; set; }
        #endregion Fields

        #region Navigation Property

        [ForeignKey("BankAccountId")]
        public virtual BankAccount BankAccount { get; set; }

        #endregion Navigation Property
    }
}