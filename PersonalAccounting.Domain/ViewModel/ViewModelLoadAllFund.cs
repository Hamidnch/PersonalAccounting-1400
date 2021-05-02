using PersonalAccounting.CommonLibrary.Helper;
using PersonalAccounting.Domain.Entity;
using System;
using System.Globalization;

namespace PersonalAccounting.Domain.ViewModel
{
    public class ViewModelLoadAllFund
    {
        /// <summary>
        /// نام صندوق
        /// </summary>
        public int FundId { get; set; }
        public string FundTitle { get; set; }
        /// <summary>
        /// نوع صندوق
        /// </summary>
        public Fund.FundTypes FundType { get; set; }

        public string FundTypeName => FundType == Fund.FundTypes.Account ? "حساب بانکی" : "سایر";
        public int FundTypeId => (int)FundType;
        /// <summary>
        /// عنوان حساب
        /// </summary>
        public string BankAccountSubject { get; set; }
        public int? BankAccountId { get; set; }
        /// <summary>
        /// مانده اولیه
        /// </summary>
        public double FundPrimaryValue { get; set; }

        //public string FundPrimaryValueSeparateDigit => Convert.ToString(FundPrimaryValue, CultureInfo.InvariantCulture).AddSeparateEx();

        /// <summary>
        /// مانده جاری صندوق
        /// </summary>
        public double FundCurrentValue { get; set; }
        //public string FundCurrentValueSeparateDigit => Convert.ToString(FundCurrentValue, CultureInfo.InvariantCulture).AddSeparateEx();

        /// <summary>
        /// تاریخ ایجاد رکورد
        /// </summary>
        public DateTime? FundCreationDate { get; set; }
        public string FundPersianRegisterDate => FundCreationDate != null ? PersianHelper.CreatePersianDate(FundCreationDate) : "";

        /// <summary>
        /// تاریخ آخرین ویرایش
        /// </summary>
        public DateTime? FundLastUpdate { get; set; }
        public string FundPersianLastUpdate => FundLastUpdate != null ? PersianHelper.CreatePersianDate(FundLastUpdate) : "";

        /// <summary>
        /// کاربر ثبت کننده رکورد
        /// </summary>
        public string FundCreationUserName { get; set; }
        public string FundUpdateByUserName { get; set; }
        /// <summary>
        /// وضعیت صندوق
        /// </summary>
        public string FundStatus { get; set; }
        /// <summary>
        /// توضیحات
        /// </summary>
        public string FundDescription { get; set; }
    }
}