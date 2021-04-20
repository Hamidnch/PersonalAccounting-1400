using PersonalAccounting.CommonLibrary.Helper;
using System;

namespace PersonalAccounting.Domain.ViewModel
{
    public class ViewModelLoadAllBankAccount
    {
        public int BankAccountId { get; set; }
        /// <summary>
        /// عنوان حساب بانکی
        /// </summary> 
        public string BankAccountSubject { get; set; }
        /// <summary>
        /// شماره حساب بانکی
        /// </summary>
        public string BankAccountNumber { get; set; }
        /// <summary>
        /// نام بانک محل حساب
        /// </summary>
        public string BankName { get; set; }

        public int BankId { get; set; }
        /// <summary>
        /// نام صاحب حساب
        /// </summary>
        public string BankAccountPersonName { get; set; }

        public int PersonId { get; set; }
        /// <summary>
        /// کاربر ثبت کننده رکورد
        /// </summary>
        public string BankAccountCreationUserName { get; set; }
        public string BankAccountUpdateByUserName { get; set; }
        /// <summary>
        /// تاریخ ثبت رکورد
        /// </summary>
        public DateTime? BankAccountCreationDate { get; set; }
        public string BankAccountPersianCreationDate =>
            BankAccountCreationDate != null ? PersianHelper.CreatePersianDate(BankAccountCreationDate) : "";

        /// <summary>
        /// تاریخ آخرین ویرایش رکورد
        /// </summary>
        public DateTime? BankAccountLastUpdate { get; set; }
        public string BankAccountPersianLastUpdate =>
            BankAccountLastUpdate != null ? PersianHelper.CreatePersianDate(BankAccountLastUpdate) : "";

        /// <summary>
        /// وضعیت حساب بانکی
        /// </summary>
        public string BankAccountStatus { get; set; }
        /// <summary>
        /// توضیحاتی در مورد حساب بانکی
        /// </summary>
        public string BankAccountDescription { get; set; }
    }
}