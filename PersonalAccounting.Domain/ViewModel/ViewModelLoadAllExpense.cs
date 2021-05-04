namespace PersonalAccounting.Domain.ViewModel
{
    public class ViewModelLoadAllExpense
    {
        public int? RowNumber { get; set; }

        public int? ArticleId { get; set; }
        /// <summary>
        /// مورد هزینه شده
        /// </summary>
        public string ArticleName { get; set; }
        public int? FundId { get; set; }
        /// <summary>
        /// صندوق محل هزینه
        /// </summary>
        public string FundName { get; set; }
        public int? ByPersonId { get; set; }
        /// <summary>
        /// هزینه کننده
        /// </summary>
        public string ByPersonName { get; set; }
        public int? ForPersonId { get; set; }
        /// <summary>
        /// برای کسی که هزینه شده
        /// </summary>
        public string ForPersonName { get; set; }
        public int? MeasurementUnitId { get; set; }
        /// <summary>
        /// واحد سنجش
        /// </summary>
        public string MeasurementUnitName { get; set; }
        ///// <summary>
        ///// کاربر ثبت کننده رکورد
        ///// </summary>
        //public string ExpenseCreationUserName { get; set; }
        /// <summary>
        /// نرخ واحد هزینه
        /// </summary>
        public double Fi { get; set; }
        /// <summary>
        /// تعداد
        /// </summary>
        public double Count { get; set; }
        /// <summary>
        /// مبلغ کل هزینه شده
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// موجودی جاری صندوق
        /// </summary>
        public double FundCurrentValue { get; set; }

        //public string FundCurrentValueString => Convert.ToString(FundCurrentValue, CultureInfo.InvariantCulture).AddSeparateEx();
        //public string PriceString
        //{
        //    get { return CommonHelper.AddSeparate(Convert.ToString(Price)); }
        //}
        ///// <summary>
        ///// تاریخ هزینه انجام شده
        ///// </summary>
        //public DateTime? ExpenseDate { get; set; }

        //public string ExpensePersianDate
        //{
        //    get {return PersianHelper.CreatePersianDate(ExpenseDate);}
        //}
        ///// <summary>
        ///// تاریخ ثبت هزینه
        ///// </summary>
        //public DateTime? ExpenseCreationDate { get; set; }
        ///// <summary>
        ///// تاریخ ویرایش مشخصات هزینه
        ///// </summary>
        //public DateTime? ExpenseLastUpdate { get; set; }
        /// <summary>
        /// توضیحاتی در مورد هزینه انجام شده
        /// </summary>
        public string Comment { get; set; }
    }
}