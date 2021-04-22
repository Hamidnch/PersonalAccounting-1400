using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalAccounting.Domain.Entity
{
    public class DiaryNote : BaseEntity
    {
        #region Ctor

        public DiaryNote()
        {
            Status = "فعال";
            Description = "";
            IsDeleted = false;
        }

        public DiaryNote(DateTime date, string note, int userId)
        {
            Date = date;
            UserId = userId;
            Note = note;
            IsDeleted = false;
        }

        public DiaryNote(DateTime date, string note, int userId ,
            int? weatherConditionId, int? mentalConditionId )
        {
            Date = date;
            Note = note;
            UserId = userId;
            WeatherConditionId = weatherConditionId;
            MentalConditionId = mentalConditionId;
            IsDeleted = false;
        }
        #endregion Ctor

        #region Fields

        public DateTime Date { get; set; }
        [MaxLength]
        public string Note { get; set; }
        public int UserId { get; set; }
        public int? WeatherConditionId { get; set; }
        public int? MentalConditionId { get; set; }

        #endregion Fields

        #region Navigation Property

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        [ForeignKey("WeatherConditionId")]
        public virtual WeatherCondition WeatherCondition { get; set; }
        [ForeignKey("MentalConditionId")]
        public virtual MentalCondition MentalCondition { get; set; }
        #endregion Navigation Property


    }
}