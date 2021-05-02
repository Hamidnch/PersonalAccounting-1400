using PersonalAccounting.CommonLibrary.Helper;
using System;
using System.Globalization;

namespace PersonalAccounting.Domain.ViewModel
{
    public class ViewModelLoadAllTransferMoney
    {
        public int TransferMoneyId { get; set; }
        /// <summary>
        /// کد بانک مبدا
        /// </summary>
        public int OriginFundId { get; set; }
        /// <summary>
        /// نام حساب مبدا
        /// </summary>
        public string OriginFundName { get; set; }

        /// <summary>
        /// کد حساب مقصد
        /// </summary>
        public int DestinationFundId { get; set; }
        /// <summary>
        /// نام حساب مقصد
        /// </summary>
        public string DestinationFundName { get; set; }

        /// <summary>
        /// مبلغ قابل انتقال
        /// </summary>
        public double Amount { get; set; }
        //public string AmountSeparateDigit => Convert.ToString(Amount, CultureInfo.InvariantCulture).AddSeparateEx();

        /// <summary>
        /// کارمزد بانکی
        /// </summary>
        public double BankCommission { get; set; }
        //public string BankCommissionSeparateDigit => Convert.ToString(BankCommission, CultureInfo.InvariantCulture).AddSeparateEx();

        public DateTime? TransferMoneyDate { get; set; }
        public string TransferMoneyPersianDate => TransferMoneyDate != null ? PersianHelper.GetPersiaDateSimple(TransferMoneyDate) : "";
        /// <summary>
        /// تاریخ ایجاد رکورد
        /// </summary>
        public DateTime? TransferMoneyCreationDate { get; set; }
        public string TransferMoneyPersianRegisterDate => TransferMoneyCreationDate != null ? PersianHelper.CreatePersianDate(TransferMoneyCreationDate) : "";

        /// <summary>
        /// تاریخ آخرین ویرایش
        /// </summary>
        public DateTime? TransferMoneyLastUpdate { get; set; }
        public string TransferMoneyPersianLastUpdate => TransferMoneyLastUpdate != null ? PersianHelper.CreatePersianDate(TransferMoneyLastUpdate) : "";

        /// <summary>
        /// کاربر ثبت کننده رکورد
        /// </summary>
        public string TransferMoneyCreationUserName { get; set; }
        public string TransferMoneyUpdateByUserName { get; set; }
        /// <summary>
        /// وضعیت انتقال
        /// </summary>
        public string TransferMoneyStatus { get; set; }
        /// <summary>
        /// توضیحات
        /// </summary>
        public string TransferMoneyDescription { get; set; }

    }
}
