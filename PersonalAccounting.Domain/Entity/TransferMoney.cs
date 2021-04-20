using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalAccounting.Domain.Entity
{
    public class TransferMoney : BaseEntity
    {
        public TransferMoney(DateTime? transferDate, double amount, int originFundId,
            int destinationFundId, double bankCommission,
            DateTime? createdOn, DateTime? lastUpdate,
            int? createdBy, string description)
        {
            TransferDate = transferDate;
            Amount = amount;
            OriginFundId = originFundId;
            DestinationFundId = destinationFundId;
            BankCommission = bankCommission;
            CreatedOn = createdOn;
            LastUpdate = lastUpdate;
            CreatedBy = createdBy;
            Status = "فعال";
            Description = description;
            IsDeleted = false;
        }
        public TransferMoney()
        {
            Status = "فعال";
            Description = "";
            IsDeleted = false;
        }

        public TransferMoney(DateTime? transferDate, double amount, int originFundId,
            int destinationFundId, double bankCommission)
        {
            TransferDate = transferDate;
            Amount = amount;
            OriginFundId = originFundId;
            DestinationFundId = destinationFundId;
            BankCommission = bankCommission;
            Status = "فعال";
            Description = "";
            IsDeleted = false;
        }

        public DateTime? TransferDate { get; set; }

        /// <summary>
        /// مبلغ قابل انتقال
        /// </summary>
        public double Amount { get; set; }
        /// <summary>
        /// حساب مبدا
        /// </summary>
        public int OriginFundId { get; set; }
        ///حساب مقصد 
        public int DestinationFundId { get; set; }
        /// <summary>
        /// کارمزد بانکی
        /// </summary>
        public double BankCommission { get; set; }

        #region Navigation Property
        [ForeignKey("OriginFundId")]
        public Fund OriginFund { get; protected set; }
        [ForeignKey("DestinationFundId")]
        public Fund DestinationFund { get; protected set; }
        #endregion  Navigation Property

    }
}
