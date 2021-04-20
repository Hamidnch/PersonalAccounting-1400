using PersonalAccounting.CommonLibrary.Helper;
using System;

namespace PersonalAccounting.Domain.ViewModel
{
    public class ViewModelLoadAllCommodity
    {
        public int CommodityId { get; set; }
        /// <summary>
        /// شناسه نوع کالا
        /// </summary>
        public string CommodityTypeTitle { get; set; }
        public int CommodityTypeId { get; set; }

        /// <summary>
        /// نام دریافت کننده
        /// </summary>
        public string ReceiverName { get; set; }
        public int? ReceiverId { get; set; }
        /// <summary>
        ///  تحویل دهنده کالا
        /// </summary>
        public string ReceivedBy { get; set; }

        /// <summary>
        /// تاریخ دریافت کالا
        /// </summary>
        public DateTime CommodityDate { get; set; }
        public string CommodityPersianDate => PersianHelper.GetPersiaDateSimple(CommodityDate);

        /// <summary>
        /// کاربر ثبت کننده
        /// </summary>
        public string CommodityCreationUserName { get; set; }
        public string CommodityUpdateByUserName { get; set; }
        /// <summary>
        /// تاریخ ثبت رکورد
        /// </summary>
        public DateTime? CommodityCreationDate { get; set; }
        public string CommodityPersianCreationDate =>
            CommodityCreationDate != null ? PersianHelper.CreatePersianDate(CommodityCreationDate) : string.Empty;

        /// <summary>
        /// تاریخ آخرین ویرایش
        /// </summary>
        public DateTime? CommodityLastUpdate { get; set; }
        public string CommodityPersianLastUpdate =>
            CommodityLastUpdate != null ? PersianHelper.CreatePersianDate(CommodityLastUpdate) : string.Empty;

        /// <summary>
        /// توضیحاتی در مورد کالای دریافتی
        /// </summary>
        public string Description { get; set; }
    }
}
