using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace PersonalAccounting.Domain.Entity
{
    /// <inheritdoc />
    /// <summary>
    /// وضعیت آب و هوا
    /// </summary>
    public class WeatherCondition : BaseEntity
    {
        #region Ctor

        public WeatherCondition()
        {
            Status = "فعال";
            Description = "";
            IsDeleted = false;
        }

        public WeatherCondition(string title, byte[] picture)
        {
            Title = title;
            Picture = picture;
            Status = "فعال";
            Description = "";
            IsDeleted = false;
        }

        public WeatherCondition(string title, byte[] picture,
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