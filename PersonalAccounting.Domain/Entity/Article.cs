using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalAccounting.Domain.Entity
{
    /// <inheritdoc />
    /// <summary>
    /// کالا
    /// </summary>
    public sealed class Article : BaseEntity
    {
        #region Ctor

        public Article()
        {
            MeasurementUnits = new List<MeasurementUnit>();
            Status = "فعال";
            Description = "";
            IsDeleted = false;
        }

        public Article(string name, string latinName, int? groupId,
            ArticleGroup articleGroup, byte[] picture)
        {
            Name = name;
            LatinName = latinName;
            GroupId = groupId;
            ArticleGroup = articleGroup;
            Picture = picture;
            IsDeleted = false;
        }

        public Article(string name, string latinName, int groupId,
            int createdBy, string status, DateTime? createdOn,
            DateTime? lastUpdate, string description, byte[] picture)
        {
            Name = name;
            LatinName = latinName;
            GroupId = groupId;
            CreatedBy = createdBy;
            CreatedOn = createdOn;
            LastUpdate = lastUpdate;
            Status = status;
            Description = description;
            Picture = picture;
            MeasurementUnits = new List<MeasurementUnit>();
            IsDeleted = false;
            //ArticleGroup = new ArticleGroup();
            //User = new User();
        }
        #endregion Ctor

        #region Fields
        /// <summary>
        /// نام کالا
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// نام لاتین کالا
        /// </summary>
        public string LatinName { get; set; }
        /// <summary>
        /// گروه کالا
        /// </summary>
        public int? GroupId { get; set; }
        /// <summary>
        /// تصویر مربوط به کالا
        /// </summary>
        public byte[] Picture { get; set; }
        #endregion Fields

        #region Navigation Property

        public ICollection<MeasurementUnit> MeasurementUnits { get; set; }
        [ForeignKey("GroupId")]
        public ArticleGroup ArticleGroup { get; set; }
        #endregion Navigation Property
    }
}