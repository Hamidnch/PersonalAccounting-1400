using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalAccounting.Domain.Entity
{
    /// <inheritdoc />
    /// <summary>
    /// هزینه
    /// </summary>
    public class Expense : BaseEntity
    {
        #region Ctor

        public Expense()
        {
            Status = "فعال";
            Description = "";
            IsDeleted = false;
        }

        public Expense(int? row, int? articleId, int? fundId,
            double rate, double count, double price, int? personId,
            int? measurementUnitId, int documentId)
        {
            Row = row;
            ArticleId = articleId;
            FundId = fundId;
            Rate = rate;
            Count = count;
            Price = price;
            ByPersonId = personId;
            MeasurementUnitId = measurementUnitId;
            DocumentId = documentId;
            IsDeleted = false;
        }

        public Expense(int? row, int? articleId, int? fundId,
            int? byPersonId, int? forPersonId, int? measurementUnitId, double rate,
            double count, double price, string description)
        {
            Row = row;
            ArticleId = articleId;
            FundId = fundId;
            Rate = rate;
            Count = count;
            Price = price;
            ByPersonId = byPersonId;
            ForPersonId = forPersonId;
            MeasurementUnitId = measurementUnitId;
            Description = description;
            IsDeleted = false;
        }
        #endregion Ctor

        #region Fields
        ///// <summary>
        ///// کد هزینه
        ///// </summary>
        //public int ExpenseId { get; set; }
        /// <summary>
        /// ردیف
        /// </summary>
        public int? Row { get; set; }
        /// <summary>
        /// مورد هزینه شده
        /// </summary>
        public int? ArticleId { get; set; }
        /// <summary>
        /// کد صندوق محل هزینه
        /// </summary>
        public int? FundId { get; set; }
        /// <summary>
        /// نرخ واحد هزینه
        /// </summary>
        public double Rate { get; set; }
        /// <summary>
        /// تعداد
        /// </summary>
        public double Count { get; set; }
        /// <summary>
        /// مبلغ کل هزینه شده
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// کد شخص هزینه کننده
        /// </summary>
        public int? ByPersonId { get; set; }
        /// <summary>
        /// کد شخصی که برایش هزینه شده
        /// </summary>
        public int? ForPersonId { get; set; }
        /// <summary>
        /// کد واحد سنجش
        /// </summary>
        public int? MeasurementUnitId { get; set; }
        public int DocumentId { get; set; }
        #endregion Fields

        #region NavigationProperty
        [ForeignKey("ArticleId")]
        public virtual Article Article { get; protected set; }
        [ForeignKey("FundId")]
        public virtual Fund Fund { get; protected set; }
        [ForeignKey("ByPersonId")]
        public virtual Person ByPerson { get; set; }
        [ForeignKey("ForPersonId")]
        public virtual Person ForPerson { get; set; }
        [ForeignKey("MeasurementUnitId")]
        public virtual MeasurementUnit MeasurementUnit { get; protected set; }
        [ForeignKey("DocumentId")]
        public virtual ExpenseDocument ExpenseDocument { get; set; }

        #endregion NavigationProperty
    }
}