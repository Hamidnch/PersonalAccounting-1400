using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalAccounting.Domain.Entity
{
    /// <inheritdoc />
    /// <summary>
    /// درآمد
    /// </summary>
    public class Income : BaseEntity
    {
        #region Ctor

        public Income()
        {
            Status = "فعال";
            Description = "";
            IsDeleted = false;
        }

        public Income(int typeId, string receivedBy, int fundId,
            double fundCurrentValue, DateTime incomeDate, double amount)
        {
            TypeId = typeId;
            ReceivedBy = receivedBy;
            FundId = fundId;
            FundOldValue = 0;
            FundCurrentValue = fundCurrentValue;
            IncomeDate = incomeDate;
            Amount = amount;
            Status = "فعال";
            Description = "";
            IsDeleted = false;
        }

        public Income(int typeId, string receivedBy, int fundId, double fundCurrentValue, double fundOldValue,
            DateTime incomeDate, double amount, int? createdBy, DateTime? createdOn, DateTime? lastUpdate,
            string description)
        {
            TypeId = typeId;
            ReceivedBy = receivedBy;
            FundId = fundId;
            FundOldValue = 0;
            FundOldValue = fundOldValue;
            FundCurrentValue = fundCurrentValue;
            IncomeDate = incomeDate;
            Amount = amount;
            CreatedBy = createdBy;
            CreatedOn = createdOn;
            LastUpdate = lastUpdate;
            Description = description;
            IsDeleted = false;
            Status = "فعال";
        }
        #endregion Ctor

        #region Fields

        /// <summary>
        /// شناسه نوع درآمد
        /// </summary>
        public int TypeId { get; set; }
        /// <summary>
        /// دریافت از طریق
        /// </summary>
        public string ReceivedBy { get; set; }

        ///<summary>
        /// عنوان صندوق - واریز به صندوق
        /// </summary>
        public int FundId { set; get; }
        public double FundOldValue { get; set; }
        public double FundCurrentValue { get; set; }
        /// <summary>
        /// تاریخ درآمد
        /// </summary>
        public DateTime IncomeDate { get; set; }
        /// <summary>
        /// مبلغ درآمد
        /// </summary>
        public double Amount { get; set; }

        #endregion Fields

        #region Navigation Property

        [ForeignKey("TypeId")]
        public IncomeType IncomeType { get; set; }
        [ForeignKey("FundId")]
        public virtual Fund Fund { get; set; }

        #endregion Navigation Property
    }
}
