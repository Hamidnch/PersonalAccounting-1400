﻿using PersonalAccounting.CommonLibrary.Helper;
using System.Data.Entity;
using System.Linq;
using System.Reflection;

namespace PersonalAccounting.DAL.Helper
{
    public static class YeKeExtension
    {
        public static void ApplyCorrectYeKe(this DbContext dbContext)
        {
            if (dbContext == null) return;

            //پیدا کردن موجودیت‌های تغییر کرده
            var changedEntities = dbContext.ChangeTracker
                .Entries()
                .Where(x => x.State == EntityState.Added || x.State == EntityState.Modified);

            foreach (var item in changedEntities)
            {
                var entity = item.Entity;
                if (item.Entity == null)
                {
                    continue;
                }

                //یافتن خواص قابل تنظیم و رشته‌ای این موجودیت‌ها
                var propertyInfos = entity.GetType().GetProperties(
                    BindingFlags.Public | BindingFlags.Instance
                ).Where(p => p.CanRead && p.CanWrite && p.PropertyType == typeof(string));

                var reflections = new Reflections();

                //اعمال یکپارچگی نهایی
                foreach (var propertyInfo in propertyInfos)
                {
                    var propName = propertyInfo.Name;
                    var value = reflections.GetValue(entity, propName);
                    if (value == null) continue;
                    var strValue = value.ToString();
                    var newVal = strValue.ApplyCorrectYeKe();
                    if (newVal == strValue)
                    {
                        continue;
                    }
                    reflections.SetValue(entity, propName, newVal);
                }
            }
        }
    }
}
