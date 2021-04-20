using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PersonalAccounting.Domain.Entity
{
    /// <inheritdoc />
    /// <summary>
    /// شرایط روحی
    /// </summary>
    public class MentalCondition : BaseEntity
    {
        #region Ctor

        public MentalCondition()
        {
            Status = "فعال";
            Description = "";
            IsDeleted = false;
        }

        public MentalCondition(string title, byte[] picture)
        {
            Title = title;
            Picture = picture;
            Status = "فعال";
            Description = "";
            IsDeleted = false;
        }

        public MentalCondition(string title, byte[] picture,
            DateTime? createdOn, DateTime? lastUpdate,
            int? createdBy, string status, string description)
        {
            Title = title;
            Picture = picture;
            CreatedOn = createdOn;
            LastUpdate = lastUpdate;
            CreatedBy = createdBy;
            Status = status;
            Description = description;
            IsDeleted = false;
        }
        #endregion Ctor

        #region Fields
        public string Title { get; set; }
        [MaxLength]
        public byte[] Picture { get; set; }
        #endregion Fields

        #region Navigation Property
        public virtual ICollection<DiaryNote> DiaryNotes { get; set; }
        #endregion Navigation Property
    }
}
