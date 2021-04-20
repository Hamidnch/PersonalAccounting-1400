using System;
using System.Collections.Generic;

namespace PersonalAccounting.CommonLibrary.Helper
{
    public static class NumToStr
    {
        private static List<int> p = new List<int>();
        //اگه میخواید بیش از 99 رقم رو تبدیل کنید فقط کافیه آرایه زیر را کامل کنید
        private static readonly string[] Farsi = new string[] 
            {
                ""," هزار "," میلیون "," میلیارد "," بیلیون "," بیلیارد "," تریلیون "," تریلیارد "," کوادریلیون "," کوادریلیارد "
                ," کوینتیلیون " ," کوینتیلیارد "," سکستیلیون "," سکستیلیارد "," سپتیلیون "," سپتیلیارد "," اکتیلیون "," اکتیلیارد "
                ," نونیلیون "," نونیلیارد "," دسیلیون "," دسیلیارد "," آندسیلیون "," آندسیلیارد "," دودسیلیون "," دودسیلیارد "," تردیسیلیون "," تردیسیلیارد "
                ," کواتوردیسیلیون "," کواتوردیسیلیارد "," کویندسلیون "," کویندسیلیارد "," سکسدیسیلیون "," سکسدیسیلیارد "
            };

        private static string Get1Digit(int n)
        {
            var digit = new string[10]
            {
                "","یک","دو","سه","چهار","پنج","شش","هفت","هشت","نه"
            };
            if (n < 10)
                return digit[n];
            else
                return "";
        }

        private static string Get2Digit(int n)
        {
            string s = "", t = "";
            var dah = new string[10] { "ده", "یازده", "دوازده", "سیزده", "چهارده", "پانزده", "شانزده", "هفده", "هجده", "نوزده" };
            var dahgan = new string[10] { "", "", "بیست", "سی", "چهل", "پنجاه", "شصت", "هفتاد", "هشتاد", "نود" };

            var d = (int)(n / 10);
            if (d == 0)
                s = Get1Digit(n);
            if (d == 1)
            {
                s = dah[n - 10];
            }
            if (d > 1)
            {
                s = "";
                t = Get1Digit(n % 10);
                if (t != "") s = " و " + t;
                s = dahgan[d] + s;
            }
            return s;
        }

        private static string Get3Digit(int n)
        {
            string s = "", t = "";
            var sad = new string[10] { "", "صد", "دویست", "سیصد", "چهارصد", "پانصد", "ششصد", "هفتصد", "هشتصد", "نهصد" };

            var d = (int)(n / 100);
            var a = n % 100;

            t = Get2Digit(a);
            s = sad[d];

            if ((t != "") & (s == ""))
                s = t;
            else if ((t != "") & (s != ""))
                s += (" و " + t);
            return s;
        }

        private static string Function(int b)
        {
            if (b > 0)
            {
                var t = Get3Digit(p[b]);
                if (t != "")
                {
                    var st = Function(b - 1);
                    if (st != "")
                        st = " و " + st;
                    return (t + Farsi[b] + st);
                }
                else
                    return (Function(b - 1));
            }
            else
            {
                return Get3Digit(p[0]);
            }
        }

        public static string ToString(Int64 Num)
        {
            if (Num <= 0) return "صفر";
            p.Clear();
            Int64 n = Num;
            while (n > 0)
            {
                var a = Convert.ToInt32(n % 1000);
                n = Convert.ToInt64(n / 1000);
                p.Add(a);
            }
            return (Function(p.Count - 1));
        }

        public static string ToString(int num)
        {
            return (ToString(Convert.ToInt64(num)));
        }

        public static string ToString(byte num)
        {
            return (ToString(Convert.ToInt64(num)));
        }

        public static string ToString(string num)
        {
            int i;
            num = num.Trim();

            if (num == "")
                return ("");
            if (num == "0")
                return ("صفر");
            for (i = num.Length; i > 2; i -= 3)
                p.Add(Convert.ToInt32(num.Substring(i - 3, 3)));
            if (i > 0)
                p.Add(Convert.ToInt32(num.Substring(0, i)));

            return (Function(p.Count - 1));

        }
    }
}
