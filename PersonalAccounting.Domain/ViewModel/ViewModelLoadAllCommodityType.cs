using PersonalAccounting.CommonLibrary.Helper;
using System;

namespace PersonalAccounting.Domain.ViewModel
{
    public class ViewModelLoadAllCommodityType
    {
        public int CommodityTypeId { get; set; }
        /// <summary>
        /// عنوان کالا
        /// </summary>
        public string CommodityTypeTitle { get; set; }
        /// <summary>
        /// کاربر ثبت کننده
        /// </summary>
        public string CommodityTypeCreationUserName { get; set; }
        public string CommodityTypeUpdateByUserName { get; set; }
        /// <summary>
        /// تاریخ ثبت کالای دریافتی
        /// </summary>
        public DateTime? CommodityTypeCreationDate { get; set; }
        public string CommodityTypePersianRegisterDate =>
            CommodityTypeCreationDate != null ? PersianHelper.CreatePersianDate(CommodityTypeCreationDate) : string.Empty;

        /// <summary>
        /// تاریخ آخرین ویرایش مشخصات کالا
        /// </summary>
        public DateTime? CommodityTypeLastUpdate { get; set; }
        public string CommodityTypePersianLastUpdate =>
            CommodityTypeLastUpdate != null ? PersianHelper.CreatePersianDate(CommodityTypeLastUpdate) : string.Empty;
    }
}
