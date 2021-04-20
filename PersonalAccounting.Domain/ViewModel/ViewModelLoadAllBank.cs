using System;

using PersonalAccounting.CommonLibrary.Helper;

namespace PersonalAccounting.Domain.ViewModel
{
    public class ViewModelLoadAllBank
    {
        public int BankId { get; set; }
        /// <summary>
        /// نام بانک
        /// </summary>
        public string BankName { get; set; }
        /// <summary>
        /// شعبه بانک
        /// </summary>
        public string BankDepartment { get; set; }
        /// <summary>
        /// کاربر ثبت کننده رکورد
        /// </summary>
        public string BankCreationUserName { get; set; }
        public string BankUpdateByUserName { get; set; }
        /// <summary>
        /// تاریخ ثبت رکورد
        /// </summary>
        public DateTime? BankCreationDate { get; set; }
        public string BankPersianRegisterDate => BankCreationDate != null ? PersianHelper.CreatePersianDate(BankCreationDate) : "";

        /// <summary>
        /// تاریخ آخرین ویرایش رکورد
        /// </summary>
        public DateTime? BankLastUpdate { get; set; }
        public string BankPersianLastUpdate => BankLastUpdate != null ? PersianHelper.CreatePersianDate(BankLastUpdate) : "";

        /// <summary>
        /// وضعیت بانک
        /// </summary>
        public string BankStatus { get; set; }
        /// <summary>
        /// توضیحاتی در مورد بانک
        /// </summary>
        public string BankDescription { get; set; }
    }
}
