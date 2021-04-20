using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalAccounting.Domain.Entity
{
    public class MeasurementUnit : BaseEntity
    {
        #region Ctor

        public MeasurementUnit()
        {
            Status = "فعال";
            Description = "";
            IsDeleted = false;
        }

        public MeasurementUnit(string name)
        {
            Name = name;
            Status = "فعال";
            Description = "";
            IsDeleted = false;
        }
        public MeasurementUnit(string name, DateTime? createdOn, DateTime? lastUpdate, int? createdBy)
        {
            Name = name;
            CreatedOn = createdOn;
            LastUpdate = lastUpdate;
            CreatedBy = createdBy;
            Articles = new List<Article>();
            Status = "فعال";
            Description = "";
            IsDeleted = false;
        }
        #endregion Ctor

        #region Fields
        public string Name { get; set; }
        #endregion Fields

        #region Navigation Property
        public ICollection<Article> Articles { get; set; }

        #endregion Navigation Property
    }
}
