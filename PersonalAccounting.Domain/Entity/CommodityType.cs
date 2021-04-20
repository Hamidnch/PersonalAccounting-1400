using System;

namespace PersonalAccounting.Domain.Entity
{
    public class CommodityType : BaseEntity
    {
        #region Ctor

        public CommodityType()
        {
            Status = "فعال";
            Description = "";
            IsDeleted = false;
        }

        public CommodityType(string title)
        {
            Title = title;
            Status = "فعال";
            Description = "";
            IsDeleted = false;
        }
        public CommodityType(string title, int? createdBy,
            DateTime? createdOn, DateTime? lastUpdate)
        {
            Title = title;
            CreatedBy = createdBy;
            CreatedOn = createdOn;
            LastUpdate = lastUpdate;
            Status = "فعال";
            Description = "";
            IsDeleted = false;
        }
        #endregion Ctor
        #region Fields

        /// <summary>
        /// عنوان نوع درآمد
        /// </summary>
        public string Title { get; set; }
        #endregion Fields
    }
}
