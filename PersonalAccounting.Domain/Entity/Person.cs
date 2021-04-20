using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PersonalAccounting.Domain.Entity
{
    public class Person : BaseEntity
    {
        #region Ctor

        public Person()
        {
            Status = "فعال";
            Description = "";
            IsDeleted = false;
        }

        public Person(string fullName, string gender, byte[] picture)
        {
            FullName = fullName;
            Gender = gender;
            Picture = picture;
            Status = "فعال";
            Description = "";
            IsDeleted = false;
        }

        public Person(string fullName, string gender, DateTime? createdOn,
            DateTime? lastUpdate, byte[] picture, int? createdBy,
            string status, string description)
        {
            FullName = fullName;
            Gender = gender;
            CreatedOn = createdOn;
            LastUpdate = lastUpdate;
            Picture = picture;
            CreatedBy = createdBy;
            Status = status;
            Description = description;
            IsDeleted = false;
        }
        #endregion Ctor

        #region Fields
        public string FullName { get; set; }
        public string Gender { get; set; }
        [MaxLength]
        public byte[] Picture { get; set; }
        #endregion

        #region Navigation Property
        //public virtual User User { get; set; }
        public virtual ICollection<Expense> ByExpenses { get; set; }
        public virtual ICollection<Expense> ForExpenses { get; set; }
        #endregion Navigation Property
    }
}
