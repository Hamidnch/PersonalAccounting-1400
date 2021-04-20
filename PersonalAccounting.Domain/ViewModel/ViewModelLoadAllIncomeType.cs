using System;

using PersonalAccounting.CommonLibrary.Helper;

namespace PersonalAccounting.Domain.ViewModel
{
    public class ViewModelLoadAllIncomeType
    {
        public int IncomeTypeId { get; set; }
        /// <summary>
        /// عنوان نوع درآمد
        /// </summary>
        public string IncomeTypeTitle { get; set; }
        /// <summary>
        /// کاربر ثبت کننده رکورد
        /// </summary>
        public string IncomeTypeCreationUserName { get; set; }
        public string IncomeTypeUpdateByUserName { get; set; }
        /// <summary>
        /// تاریخ ثبت نوع درآمد
        /// </summary>
        public DateTime? IncomeTypeCreationDate { get; set; }
        public string IncomeTypePersianRegisterDate =>
            IncomeTypeCreationDate != null ? PersianHelper.CreatePersianDate(IncomeTypeCreationDate) : "";

        /// <summary>
        /// تاریخ ویرایش مشخصات نوع درآمد
        /// </summary>
        public DateTime? IncomeTypeLastUpdate { get; set; }
        public string IncomeTypePersianLastUpdate =>
            IncomeTypeLastUpdate != null ? PersianHelper.CreatePersianDate(IncomeTypeLastUpdate) : "";
    }
}
