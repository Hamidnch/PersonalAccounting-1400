using PersonalAccounting.CommonLibrary.Helper;
using System;

namespace PersonalAccounting.Domain.ViewModel
{
    public class ViewModelLoadAllDiaryNoteReport
    {
        public DateTime? DiaryNoteDate { get; set; }
        public string DiaryNotePersianDate => DiaryNoteDate != null ? PersianHelper.GetPersiaDateSimple(DiaryNoteDate) : "";

        public int? MentalConditionId { get; set; }
        public string MentalConditionSubject { get; set; }

        public int? WeatherConditionId { get; set; }
        public string WeatherConditionSubject { get; set; }

        public string Note { get; set; }

        public int? UserId { get; set; }
        public string Username { get; set; }


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
