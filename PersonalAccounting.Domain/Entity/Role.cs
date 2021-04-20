using System;
using System.Collections.Generic;

namespace PersonalAccounting.Domain.Entity
{
    public class Role : BaseEntity
    {
        #region Ctor
        public Role()
        {
            //    Users = new HashSet<User>();
            Status = "فعال";
            Description = "";
            IsDeleted = false;
            Users = new List<User>();
            Permissions = new List<Permission>();
        }

        public Role(string name)
        {
            Name = name;
            Status = "فعال";
            Description = "";
            IsDeleted = false;
            Users = new List<User>();
            Permissions = new List<Permission>();

        }

        public Role(string name, DateTime? createdOn,
            DateTime? lastUpdate, int? createdBy,
            string status, string description)
        {
            Name = name;
            CreatedOn = createdOn;
            LastUpdate = lastUpdate;
            CreatedBy = createdBy;
            Status = status;
            Description = description;
            IsDeleted = false;
            Users = new List<User>();
            Permissions = new List<Permission>();

        }
        #endregion Ctor

        #region Fields
        public string Name { get; set; }
        #endregion Fields

        #region Navigation Property
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Permission> Permissions { get; set; }
        #endregion Navigation Property
    }
}
