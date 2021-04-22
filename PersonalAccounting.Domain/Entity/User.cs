using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalAccounting.Domain.Entity
{
    public class User : BaseEntity
    {
        #region Ctor

        public User()
        {
            Status = "فعال";
            Description = "";
            IsDeleted = false;
            Roles = new List<Role>();
        }

        public User(string userName, string password, string email, bool isApproved, bool isLockout,
             long lastActiveDurationValue, string ip, int personId, int? createdBy, string status, string description)
        {
            UserName = userName;
            Password = password;
            Email = email;
            IsApproved = isApproved;
            IsLockout = isLockout;
            LastActiveDurationValue = lastActiveDurationValue;
            Ip = ip;
            PersonId = personId;
            CreatedOn = DateTime.Now;
            CreatedBy = createdBy;
            Status = status;
            Description = description;
            IsDeleted = false;
            Roles = new List<Role>();
        }
        public User(int personId, string userName, string password, string email,
            bool isApproved, bool isLockout, int? passwordFailuresSinceLastSuccess,
            DateTime? lastPasswordFailureDate, DateTime? lastActivityDate,
            long lastActiveDurationValue, DateTime? lastLockoutDate,
            DateTime? lastLoginDate, DateTime? previousLastLoginDate,
            int? loginCount, DateTime? lastPasswordChangedDate, string ip)
        {
            PersonId = personId;
            UserName = userName;
            Password = password;
            Email = email;
            IsApproved = isApproved;
            IsLockout = isLockout;
            PasswordFailuresSinceLastSuccess = passwordFailuresSinceLastSuccess;
            LastPasswordFailureDate = lastPasswordFailureDate;
            LastActivityDate = lastActivityDate;
            LastActiveDurationValue = lastActiveDurationValue;
            LastLockoutDate = lastLockoutDate;
            LastLoginDate = lastLoginDate;
            PreviousLastLoginDate = previousLastLoginDate;
            LoginCount = loginCount;
            LastPasswordChangedDate = lastPasswordChangedDate;
            Ip = ip;
            Status = "فعال";
            Description = "";
            IsDeleted = false;
            Roles = new List<Role>();
        }
        public User(int personId, string userName, string password, string email,
            bool isApproved, bool isLockout, int? passwordFailuresSinceLastSuccess,
            DateTime? createdOn, DateTime? lastUpdate,
            DateTime? lastPasswordFailureDate, DateTime? lastActivityDate,
            DateTime? lastLockoutDate, DateTime? lastLoginDate,
            DateTime? lastPasswordChangedDate, string description, string status,
            string ip, int? createdBy)
        {
            PersonId = personId;
            UserName = userName;
            Password = password;
            Email = email;
            IsApproved = isApproved;
            IsLockout = isLockout;
            CreatedOn = createdOn;
            LastUpdate = lastUpdate;
            PasswordFailuresSinceLastSuccess = passwordFailuresSinceLastSuccess;
            LastPasswordFailureDate = lastPasswordFailureDate;
            LastActivityDate = lastActivityDate;
            LastLockoutDate = lastLockoutDate;
            LastLoginDate = lastLoginDate;
            LastPasswordChangedDate = lastPasswordChangedDate;
            Description = description;
            Status = status;
            LoginCount = 0;
            Ip = ip;
            CreatedBy = createdBy;
            IsDeleted = false;
            Roles = new List<Role>();
        }
        #endregion Ctor

        #region Fields
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool IsApproved { get; set; }
        public bool IsLockout { get; set; }
        public int? PasswordFailuresSinceLastSuccess { get; set; }
        public DateTime? LastPasswordFailureDate { get; set; }
        public DateTime? LastActivityDate { get; set; }
        public long LastActiveDurationValue { get; set; }
        [NotMapped]
        public TimeSpan LastActiveDuration
        {
            get => TimeSpan.FromTicks(LastActiveDurationValue);
            set => LastActiveDurationValue = value.Ticks;
        }
        public DateTime? LastLockoutDate { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public DateTime? PreviousLastLoginDate { get; set; }
        public int? LoginCount { get; set; }
        public DateTime? LastPasswordChangedDate { get; set; }
        public string Ip { get; set; }
        //public int? RoleId { get; set; }
        public int PersonId { get; set; }
        #endregion Fields

        #region Navigation Property
        public virtual ICollection<Role> Roles { get; set; }
        //[ForeignKey("RoleId")]
        //public virtual Role Role { get; set; }
        [ForeignKey("PersonId")]
        public virtual Person Person { get; protected set; }
        public virtual ICollection<DiaryNote> DiaryNotes { get; set; }
        public virtual ICollection<ExpenseDocument> ExpenseDocuments { get; set; }
        #endregion Navigation Property
    }
}