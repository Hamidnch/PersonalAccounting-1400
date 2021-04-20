using System;
using System.Collections.Generic;

namespace PersonalAccounting.Domain.Entity
{
    public class FormEntity : BaseEntity
    {
        #region Ctor

        public FormEntity()
        {
            Status = "فعال";
            Description = "";
            IsDeleted = false;
            Permissions = new List<Permission>();
        }

        public FormEntity(string name, string systemName)
        {
            Name = name;
            SystemName = systemName;
            Status = "فعال";
            Description = "";
            IsDeleted = false;
            Permissions = new List<Permission>();
        }
        public FormEntity(string name, string systemName, DateTime? createdOn,
            DateTime? lastUpdate, int? createdBy,
            string status, string description)
        {
            Name = name;
            SystemName = systemName;
            CreatedOn = createdOn;
            LastUpdate = lastUpdate;
            CreatedBy = createdBy;
            Status = status;
            Description = description;
            Permissions = new List<Permission>();
        }
        #endregion Ctor

        #region Fields
        public string Name { get; set; }
        public string SystemName { get; set; }
        #endregion Fields

        #region Navigation Property
        public virtual ICollection<Permission> Permissions { get; set; }
        #endregion Navigation Property
    }
}
