using System;

using PersonalAccounting.CommonLibrary.Helper;

namespace PersonalAccounting.Domain.ViewModel
{
    public class ViewModelLoadAllExpenseDocument
    {
        /// <summary>
        /// شماره سند
        /// </summary>
        public int ExpenseDocumentId { get; set; }
        /// <summary>
        /// تاریخ ثبت سند هزینه
        /// </summary>
        public DateTime? ExpenseDocumentDate { get; set; }
        public string ExpenseDocumentPersianDate =>
            ExpenseDocumentDate != null ? PersianHelper.GetPersiaDateSimple(ExpenseDocumentDate) : "";

        /// <summary>
        /// کاربر ثبت کننده رکورد
        /// </summary>
        public string ExpenseDocumentCreationUserName { get; set; }
        public string ExpenseDocumentUpdateByUserName { get; set; }
        ///// <summary>
        ///// تاریخ ثبت سند
        ///// </summary>
        public DateTime? ExpenseDocumentCreationDate { get; set; }
        public string ExpenseDocumentCreationPersianDate =>
            ExpenseDocumentCreationDate != null ? PersianHelper.CreatePersianDate(ExpenseDocumentCreationDate) : "";

        /// <summary>
        /// تاریخ ویرایش مشخصات هزینه
        /// </summary>
        public DateTime? ExpenseDocumentLastUpdate { get; set; }
        public string ExpenseDocumentPersianLastUpdate =>
            ExpenseDocumentLastUpdate != null ? PersianHelper.CreatePersianDate(ExpenseDocumentLastUpdate) : "";

        /// <summary>
        /// توضیحات مربوط به سند هزینه
        /// </summary>
        public string ExpenseDocumentDescription { get; set; }
    }
}
