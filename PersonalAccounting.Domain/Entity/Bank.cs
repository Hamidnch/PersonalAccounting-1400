using System;

namespace PersonalAccounting.Domain.Entity
{
    /// <inheritdoc />
    /// <summary>
    /// بانک
    /// </summary>
    public class Bank : BaseEntity
    {
        public Bank()
        {
            Status = "فعال";
            Description = "";
            IsDeleted = false;
        }

        public Bank(string name, string department)
        {
            Name = name;
            Department = department;
            IsDeleted = false;
        }

        public Bank(string name, string department, int? createdBy, DateTime? createdOn,
            DateTime? lastUpdate, string status, string description)
        {
            Name = name;
            Department = department;
            CreatedBy = createdBy;
            CreatedOn = createdOn;
            LastUpdate = lastUpdate;
            Status = status;
            Description = description;
            IsDeleted = false;
        }
        /// <summary>
        /// نام بانک
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// شعبه بانک
        /// </summary>
        public string Department { get; set; }
    }
}
