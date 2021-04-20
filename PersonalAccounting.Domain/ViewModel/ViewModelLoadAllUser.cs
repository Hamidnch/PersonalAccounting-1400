using PersonalAccounting.CommonLibrary.Helper;
using PersonalAccounting.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonalAccounting.Domain.ViewModel
{
    public class ViewModelLoadAllUser
    {
        public int UserId { get; set; }
        public int? PersonId { get; set; }
        public string PersonName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool IsApproved { get; set; }
        public bool IsLockout { get; set; }
        public DateTime? CreationDate { get; set; }
        public string PersianCreationDate => CreationDate != null ? PersianHelper.CreatePersianDate(CreationDate) : "";

        public DateTime? LastUpdate { get; set; }
        public string PersianLastUpdate => LastUpdate != null ? PersianHelper.CreatePersianDate(LastUpdate) : "";
        public int? PasswordFailuresSinceLastSuccess { get; set; }
        public DateTime? LastPasswordFailureDate { get; set; }

        public string PersianLastPasswordFailureDate =>
            LastPasswordFailureDate != null ? PersianHelper.CreatePersianDate(LastPasswordFailureDate) : "";
        public DateTime? LastActivityDate { get; set; }

        public string PersianLastActivityDate =>
            LastActivityDate != null ? PersianHelper.CreatePersianDate(LastActivityDate) : "";
        public DateTime? LastLockoutDate { get; set; }

        public string PersianLastLockoutDate => LastLockoutDate != null ? PersianHelper.CreatePersianDate(LastLockoutDate) : "";
        public DateTime? LastLoginDate { get; set; }
        public string PersianLastLoginDate => LastLoginDate != null ? PersianHelper.CreatePersianDate(LastLoginDate) : "";
        public DateTime? LastPasswordChangedDate { get; set; }
        public string PersianLastPasswordChangedDate =>
            LastPasswordChangedDate != null ? PersianHelper.CreatePersianDate(LastPasswordChangedDate) : "";
        public int? LoginCount { get; set; }
        //public string RoleName { get; set; }
        public string Ip { get; set; }
        public string CreationUser { get; set; }
        public string UpdateByUser { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public ICollection<Role> Roles { get; set; }
        public string RoleNames
        {
            get
            {
                var res = Roles.Aggregate(string.Empty, (current, role) => current + (role.Name + ", "));
                if(res.Length > 0)
                    res = res?.Substring(0, res.Length - 2);
                return res;
            }
        }
    }


}