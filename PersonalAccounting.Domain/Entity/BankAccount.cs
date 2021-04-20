using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalAccounting.Domain.Entity
{
    public class BankAccount : BaseEntity
    {
        #region Ctor

        public BankAccount()
        {
            Status = "فعال";
            Description = "";
            IsDeleted = false;
        }

        public BankAccount(string name, string accountNumber, int bankId, int personId)
        {
            Name = name;
            AccountNumber = accountNumber;
            BankId = bankId;
            PersonId = personId;
            IsDeleted = false;
        }

        public BankAccount(string name, string accountNumber, int bankId, int personId, int? createdBy,
            DateTime? createdOn, DateTime? lastUpdate, string status, string description)
        {
            Name = name;
            AccountNumber = accountNumber;
            BankId = bankId;
            PersonId = personId;
            CreatedBy = createdBy;
            CreatedOn = createdOn;
            LastUpdate = lastUpdate;
            Status = status;
            Description = description;
            IsDeleted = false;
        }
        #endregion Ctor

        #region  Fields
        /// <summary>
        /// عنوان حساب بانکی
        /// </summary> 
        public string Name { get; set; }
        /// <summary>
        /// شماره حساب بانکی
        /// </summary>
        public string AccountNumber { get; set; }
        /// <summary>
        /// نام بانک محل حساب
        /// </summary>
        public int BankId { get; set; }
        /// <summary>
        /// نام صاحب حساب
        /// </summary>
        public int PersonId { get; set; }
        #endregion Fields

        #region Navigation Property
        [ForeignKey("BankId")]
        public virtual Bank Bank { get; set; }
        [ForeignKey("PersonId")]
        public virtual Person Person { get; set; }
        #endregion Navigation Property
    }
}
