using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalAccounting.CommonLibrary.Helper;

namespace PersonalAccounting.Domain.ViewModel
{
    public class ViewModelLoadAllExpenseReport
    {
        /// <summary>
        /// تاریخ ثبت هزینه
        /// </summary>
        public DateTime? ExpenseDate { get; set; }
        public string ExpensePersianDate => ExpenseDate != null ? PersianHelper.CreatePersianDate(ExpenseDate) : "";

        public int? DocumentId { get; set; }
        public int? ArticleGroupId { get; set; }
        /// <summary>
        /// دسته کالا
        /// </summary>
        public string ArticleGroupSubject { get; set; }

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

        public int? CreatedBy { get; set; }
        /// <summary>
        /// کاربر ثبت کننده رکورد
        /// </summary>
        public string CreationUserName { get; set; }

        public int? UpdateBy { get; set; }
        /// <summary>
        /// کاربر ویرایش کننده رکورد
        /// </summary>
        public string UpdateUserName { get; set; }
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

        public string PriceString => Convert.ToString(Price, CultureInfo.InvariantCulture).AddSeparateEx();

        /// <summary>
        /// تاریخ ثبت هزینه
        /// </summary>
        public DateTime? CreatedOn { get; set; }
        public string ExpenseCreatedOnPersian => CreatedOn != null ? PersianHelper.CreatePersianDate(CreatedOn) : "";
        /// <summary>
        /// تاریخ ویرایش مشخصات هزینه
        /// </summary>
        public DateTime? UpdateOn { get; set; }
        public string UpdateOnPersian => UpdateOn != null ? PersianHelper.CreatePersianDate(UpdateOn) : "";
        /// <summary>
        /// توضیحاتی در مورد هزینه انجام شده
        /// </summary>
        public string Comment { get; set; }
    }
}
