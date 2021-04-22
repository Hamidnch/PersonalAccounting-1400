using PersonalAccounting.CommonLibrary.Properties;
using System;
using System.Drawing;
using System.Globalization;

namespace PersonalAccounting.CommonLibrary.Helper
{
    public static class PersianHelper
    {
        public static string GetPersiaDate(DateTime? date, string dateType, bool hasTime, string timeType = "R")
        {
            if (date == null || string.IsNullOrWhiteSpace(date.ToString())) return "---";
            var solarDate = Persia.Calendar.ConvertToPersian(date.Value);
            return hasTime ? solarDate.ToString(dateType + "," + timeType) : solarDate.ToString(dateType);
        }

        public static string GetPersiaDateSimple(DateTime? date)
        {
            if (date == null || string.IsNullOrWhiteSpace(date.ToString())) return "---";
            var solarDate = Persia.Calendar.ConvertToPersian(date.Value);
            var currentDate = solarDate.ToString().Split('/');
            if (currentDate[1].Length == 1) currentDate[1] = currentDate[1].Insert(0, "0");
            if (currentDate[2].Length == 1) currentDate[2] = currentDate[2].Insert(0, "0");
            return currentDate[0] + "/" + currentDate[1] + "/" + currentDate[2];
        }

        public static string GetPersiaDate(string date, string dateType, bool hasTime, string timeType = "R")
        {
            if (date == null || string.IsNullOrWhiteSpace(date)) return "---";
            var solarDate = Persia.Calendar.ConvertToPersian(DateTime.Parse(date));
            return hasTime ? solarDate.ToString(dateType + "," + timeType) : solarDate.ToString(dateType);
        }

        public static string CreatePersianDate(DateTime? current)
        {
            return current == null ? "" : GetLatinNumberStyle(GetPersiaDate(current, "D", true, "H"));
        }

        public static DateTime GetGregorianDate(int year, int month, int day, int hour, int minute, int second,
            Persia.DateType dateType)
        {
            return Persia.Calendar.ConvertToGregorian(year, month, day, hour, minute, second, dateType);
        }

        public static DateTime GetGregorianDate(string date)
        {
            var year = int.Parse(date.Substring(0, 4));
            var month = int.Parse(date.Substring(5, 2));
            var day = int.Parse(date.Substring(8, 2));
            return Persia.Calendar.ConvertToGregorian(year, month, day, Persia.DateType.Persian);
        }

        public static DateTime GetGregorianDateSimple(string date)
        {
            var year = int.Parse(date.Substring(0, 4));
            var month = int.Parse(date.Substring(5, 2));
            var day = int.Parse(date.Substring(8, 2));
            return Persia.Calendar.ConvertToGregorian(year, month, day, Persia.DateType.Persian).Date;
        }

        public static DateTime GetGregorianDate(Persia.SolarDate solarDate)
        {
            return Persia.Calendar.ConvertToGregorian(solarDate);
        }

        public static string GetPersianNumberStyle(object value)
        {
            return Persia.PersianWord.ToPersianString(value);
        }

        public static string GetLatinNumberStyle(string value)
        {
            return Persia.PersianWord.ConvertToLatinNumber(value);
        }

        #region Property

        private static readonly PersianCalendar PersianCalendar = new PersianCalendar();

        #endregion

        #region Public Methods

        public static string Shamsi_Date(DateTime md)
        {
            try
            {
                string day = "", month = "";
                day = (PersianCalendar.GetDayOfMonth(md) < 10)
                    ? "0" +
                      PersianCalendar.GetDayOfMonth(md)
                    : PersianCalendar.GetDayOfMonth(md).ToString(CultureInfo.InvariantCulture);

                month = (PersianCalendar.GetMonth(md) < 10)
                    ? "0" + PersianCalendar.GetMonth(md)
                    : PersianCalendar.GetMonth(md).ToString(CultureInfo.InvariantCulture);
                return PersianCalendar.GetYear(md) + "/" + month + "/" + day;
            }
            catch (Exception ex)
            {
                var dlg = new MessageBoxHamidNCH.CustomDialogs(400, 200);
                dlg.Invoke("خطا", ex.Message, MessageBoxHamidNCH.CustomDialogs.ImageType.itError5,
                    MessageBoxHamidNCH.CustomDialogs.ButtonType.Ok);
                return "";
            }
        }

        public static string ShowShamsiToday(DateTime dt)
        {
            var year = PersianCalendar.GetYear(dt).ToString("0000");
            var month = PersianCalendar.GetMonth(dt).ToString("00");
            var day = PersianCalendar.GetDayOfMonth(dt).ToString("00");
            return year + "/" + month + "/" + day;
        }

        public static string ShowTime()
        {
            var hour = PersianCalendar.GetHour(DateTime.Now).ToString("0#");
            var minute = PersianCalendar.GetMinute(DateTime.Now).ToString("0#");
            return hour + ":" + minute;
        }

        private static int NumberDayOfWeek(string name)
        {
            var n = 0;
            switch (name)
            {
                case "Saturday":
                    n = 0;
                    break;
                case "Sunday":
                    n = 1;
                    break;
                case "Monday":
                    n = 2;
                    break;
                case "Tuesday":
                    n = 3;
                    break;
                case "Wednesday":
                    n = 4;
                    break;
                case "Thursday":
                    n = 5;
                    break;
                case "Friday":
                    n = 6;
                    break;
            }

            return n;
        }

        public static bool IsLeapPersianYear(int year)
        {
            return PersianCalendar.IsLeapYear(year);
        }

        public static string GetPersianDayName(DateTime date)
        {
            var dayName = Convert.ToString(PersianCalendar.GetDayOfWeek(date));
            var result = string.Empty;
            switch (dayName.ToLower())
            {
                case "saturday":
                    result = "شنبه";
                    break;
                case "sunday":
                    result = "یکشنبه";
                    break;
                case "monday":
                    result = "دوشنبه";
                    break;
                case "tuesday":
                    result = "سه شنبه";
                    break;
                case "wednesday":
                    result = "چهارشنبه";
                    break;
                case "thursday":
                    result = "پنج شنبه";
                    break;
                case "friday":
                    result = "جمعه";
                    break;
            }

            return result;
        }

        public static string GetPersianDayOfMonth(DateTime date)
        {
            return Convert.ToString(PersianCalendar.GetDayOfMonth(date));
        }
        public static string GetPersianMonth(DateTime date)
        {
            var monthInt = PersianCalendar.GetMonth(date);
            var monthStr = string.Empty;
            switch (monthInt)
            {
                case 1:
                    monthStr = "فروردین";
                    break;
                case 2:
                    monthStr = "اردیبهشت";
                    break;
                case 3:
                    monthStr = "خرداد";
                    break;
                case 4:
                    monthStr = "تیر";
                    break;
                case 5:
                    monthStr = "مرداد";
                    break;
                case 6:
                    monthStr = "شهریور";
                    break;
                case 7:
                    monthStr = "مهر";
                    break;
                case 8:
                    monthStr = "آبان";
                    break;
                case 9:
                    monthStr = "آذر";
                    break;
                case 10:
                    monthStr = "دی";
                    break;
                case 11:
                    monthStr = "بهمن";
                    break;
                case 12:
                    monthStr = "اسفند";
                    break;
            }

            return monthStr;
        }

        public static string GetPersianYear(DateTime date)
        {
            return Convert.ToString(PersianCalendar.GetYear(date));
        }
        #endregion

        #region FilterDate Method

        public static string[] FilterWeek(DateTime date)
        {
            var arrWeek = new string[2];
            var start = date.AddDays((-1 * NumberDayOfWeek(GetPersianDayName(date))));
            var end = start.AddDays(6);

            arrWeek[0] = ShowShamsiToday(start);
            arrWeek[1] = ShowShamsiToday(end);
            return arrWeek;
        }

        public static string[] FilterMonth(DateTime date)
        {
            var month = PersianCalendar.GetMonth(date);
            var year = PersianCalendar.GetYear(date);
            var getDayMonth = PersianCalendar.GetDaysInMonth(year, month);
            var arrMonth = new string[2];
            arrMonth[0] = year + "/" + month.ToString("0#") + "/" + "01";
            arrMonth[1] = year + "/" + month.ToString("0#") + "/" + getDayMonth;
            return arrMonth;
        }

        public static string[] FilterYear(DateTime date)
        {
            var year = PersianCalendar.GetYear(date);
            IsLeapPersianYear(year);
            var arrYear = new string[2];
            if (IsLeapPersianYear(year))
            {
                arrYear[0] = year + "/" + "01" + "/" + "01";
                arrYear[1] = year + "/" + "12" + "/" + "30";
            }
            else
            {
                arrYear[0] = year + "/" + "01" + "/" + "01";
                arrYear[1] = year + "/" + "12" + "/" + "29";
            }

            return arrYear;
        }

        #endregion

        #region Persian Date Validation

        public static bool IsValidPersianDate(this string persianDate)
        {
            if (persianDate == "1   /  /" || string.IsNullOrEmpty(persianDate)) 
                return false;
            try
            {
                var year = int.Parse(persianDate.Substring(0, 4));
                var month = int.Parse(persianDate.Substring(5, 2));
                var day = int.Parse(persianDate.Substring(8, 2));
                return true;
            }
            catch
            {
                return false;
            }

            //public const string PersianDateRegex = @"(?:1[23]\d{2})\/(?:0?[1-9]|1[0-2])\/(?:0?[1-9]|[12][0-9]|3[01])$";

            //const string persianDateRegex =
            //    @"^[1-4]\d{3}\/((0?[1-6]\/((3[0-1])|([1-2][0-9])|(0?[1-9])))|((1[0-2]|(0?[7-9]))\/(30|([1-2][0-9])|(0?[1-9]))))$";
            //return Regex.IsMatch(persianDate, persianDateRegex);
        }

        public static string GetLongPersianDate(DateTime date, out Color color)
        {
            //var newDate = GetGregorianDate(date);
            var currentDayOfWeek = GetPersianDayName(date);

            var monthStr = GetPersianMonth(date);
            var yearStr = GetPersianYear(date);

            switch (currentDayOfWeek)
            {
                case DefaultConstants.HolidayString:
                    //lbl_DayOfWeek.ForeColor = Color.Red;
                    //lbl_DayOfMonth.ForeColor = Color.Red;
                    color = Color.Red;
                    break;
                default:
                    //lbl_DayOfWeek.ForeColor = Color.Black;
                    //lbl_DayOfMonth.ForeColor = Color.Black;
                    color = Color.Black;
                    break;
            }

            return currentDayOfWeek + Resources.TwoSpace + GetPersianDayOfMonth(date) +
                                 Resources.TwoSpace + monthStr + Resources.TwoSpace + yearStr;
        }

        #endregion
    }
}