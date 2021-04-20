using PersonalAccounting.CommonLibrary.Helper;
using System;
using System.Globalization;

namespace PersonalAccounting.Domain.ViewModel
{
    public class ViewModelLoadAllIncome
    {

        public int IncomeId { get; set; }
        /// <summary>
        /// شناسه نوع درآمد
        /// </summary>
        public string IncomeTypeTitle { get; set; }

        public int IncomeTypeId { get; set; }

        /// <summary>
        ///  پرداخت کننده
        /// </summary>
        public string ReceivedBy { get; set; }
        ///<summary>
        /// عنوان صندوق
        /// </summary>
        public string FundTitle { get; set; }
        public int FundId { get; set; }
        //public int? BankAccountId { get; set; }

        public double FundOldValue { get; set; }
        public string FundOldValueSeparateDigit => Convert.ToString(FundOldValue, CultureInfo.InvariantCulture).AddSeparateEx();

        public double FundCurrentValue { get; set; }
        public string FundCurrentValueSeparateDigit => Convert.ToString(FundCurrentValue, CultureInfo.InvariantCulture).AddSeparateEx();

        /// <summary>
        /// تاریخ درآمد
        /// </summary>
        public DateTime IncomeDate { get; set; }
        public string IncomePersianDate => PersianHelper.GetPersiaDateSimple(IncomeDate);

        /// <summary>
        /// مبلغ درآمد
        /// </summary>
        public double IncomePrice { get; set; }

        public string IncomeSeparateDigitPrice => Convert.ToString(IncomePrice, CultureInfo.InvariantCulture).AddSeparateEx();

        /// <summary>
        /// کاربر ثبت کننده رکورد
        /// </summary>
        public string IncomeCreationUserName { get; set; }
        public string IncomeUpdateByUserName { get; set; }
        /// <summary>
        /// تاریخ ثبت رکورد
        /// </summary>
        public DateTime? IncomeCreationDate { get; set; }
        public string IncomePersianCreationDate => IncomeCreationDate != null ? PersianHelper.CreatePersianDate(IncomeCreationDate) : "";

        /// <summary>
        /// تاریخ آخرین ویرایش رکورد
        /// </summary>
        public DateTime? IncomeLastUpdate { get; set; }
        public string IncomePersianLastUpdate => IncomeLastUpdate != null ? PersianHelper.CreatePersianDate(IncomeLastUpdate) : "";

        /// <summary>
        /// توضیحاتی در مورد درآمد
        /// </summary>
        public string Description { get; set; }
    }
}
