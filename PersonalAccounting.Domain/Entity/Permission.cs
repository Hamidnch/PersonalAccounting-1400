using System;
using System.Collections.Generic;

namespace PersonalAccounting.Domain.Entity
{
    public class Permission : BaseEntity
    {
        #region Ctor

        public Permission()
        {
            IsSelected = false;
            Status = "فعال";
            Description = "";
            IsDeleted = false;
            Roles = new List<Role>();
            FormEntities = new List<FormEntity>();
        }

        public Permission(string systemName, string name, bool isSelected)
        {
            SystemName = systemName;
            Name = name;
            IsSelected = isSelected;
            Status = "فعال";
            Description = "";
            IsDeleted = false;
            Roles = new List<Role>();
            FormEntities = new List<FormEntity>();
        }
        public Permission(string systemName, string name, bool isSelected,
            DateTime? createdOn, DateTime? lastUpdate, int? createdBy,
            string status, string description)
        {
            SystemName = systemName;
            Name = name;
            IsSelected = isSelected;
            CreatedOn = createdOn;
            LastUpdate = lastUpdate;
            CreatedBy = createdBy;
            Status = status;
            Description = description;
            Roles = new List<Role>();
            FormEntities = new List<FormEntity>();
        }
        #endregion Ctor

        #region Fields
        public string SystemName { get; set; }
        public string Name { get; set; }
        public bool IsSelected { get; set; }
        #endregion

        #region Navigation Property
        public virtual ICollection<Role> Roles { get; set; }
        public virtual ICollection<FormEntity> FormEntities { get; set; }
        #endregion Navigation Property
    }
}
