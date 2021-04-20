using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalAccounting.Domain.Entity
{
    /// <inheritdoc />
    /// <summary>
    ///  کالاهای دریافتی
    /// </summary>
    public class Commodity : BaseEntity
    {
        #region Ctor

        public Commodity()
        {
            Status = "فعال";
            Description = string.Empty;
            IsDeleted = false;
        }

        public Commodity(int commodityTypeId, int? receiverId, string receivedBy, DateTime incomeDate)
        {
            CommodityTypeId = commodityTypeId;
            ReceiverId = receiverId;
            ReceivedBy = receivedBy;
            CommodityDate = incomeDate;
            Status = "فعال";
            Description = string.Empty;
            IsDeleted = false;
        }

        public Commodity(int commodityTypeId, int? receiverId, string receivedBy,
            DateTime incomeDate, int? createdBy, DateTime? createdOn,
            DateTime? lastUpdate, string description)
        {
            CommodityTypeId = commodityTypeId;
            ReceiverId = receiverId;
            ReceivedBy = receivedBy;
            CommodityDate = incomeDate;
            CreatedBy = createdBy;
            CreatedOn = createdOn;
            LastUpdate = lastUpdate;
            Description = description;
            IsDeleted = false;
        }
        #endregion Ctor

        #region Fields

        /// <summary>
        /// دریافت کننده کالا
        /// </summary>
        public int? ReceiverId { get; set; }
        /// <summary>
        /// شناسه نوع کالا
        /// </summary>
        public int CommodityTypeId { get; set; }
        /// <summary>
        /// دریافت از طریق
        /// </summary>
        public string ReceivedBy { get; set; }

        /// <summary>
        /// تاریخ دریافت کالا
        /// </summary>
        public DateTime CommodityDate { get; set; }

        #endregion Fields

        #region Navigation Property

        [ForeignKey("ReceiverId")]
        public virtual Person Person { get; set; }

        [ForeignKey("CommodityTypeId")]
        public CommodityType CommodityType { get; set; }

        #endregion Navigation Property
    }
}
