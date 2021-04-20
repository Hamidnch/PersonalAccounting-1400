namespace PersonalAccounting.CommonLibrary.Helper
{
    public static class DefaultConstants
    {
        public const string SqliteDbPath = @"data source=.\db\PA.nch;foreign keys=true;";
        public const string SqliteBackupDestinationPath = @"Data Source={0}\PA-{1:yyyyMMdd}.nch;foreign keys=true;";

        public const string AdminRole = "مدیر سیستم";
        public const string SupervisorRole = "کاربر ارشد";
        public const string UserRole = "کاربر";

        public const string DefaultAdminUserName = "Admin";
        public const string DefaultAdminEmail = "admin@admin.com";
        public const string DefaultAdminPassword = "Element**";

        public const string FormCaptionLabel = "lbl_FormCaption";
        public const string HolidayString = "جمعه";

        public const string PrefixCanViewPermission = "Can_View_";
        public const string PrefixCanAddPermission = "Can_Add_";
        public const string PrefixCanEditPermission = "Can_Edit_";
        public const string PrefixCanDeletePermission = "Can_Delete_";

        public const string PermissionViewString = "نمایش";
        public const string PermissionAddString = "ایجاد جدید";
        public const string PermissionEditString = "ویرایش";
        public const string PermissionDeleteString = "حذف";

        public const string IllegalAccess = "عدم دسترسی مجاز";
        public const string ViewActionNotAllow = "شما دسترسی لازم برای نمایش را ندارید.";
        public const string CreateActionNotAllow = "شما دسترسی لازم برای ایجاد را ندارید.";
        public const string EditActionNotAllow = "شما دسترسی لازم برای ویرایش را ندارید.";
        public const string DeleteActionNotAllow = "شما دسترسی لازم برای حذف را ندارید.";

        public const string PasswordHash = "1^Gandom&~";
        public const string SaltKey = "S^alt@1231";
        public const string ViKey = "@1B2c3D4e5F6g7H8";

        public const string NoPersonImagePath = @"\Images\NoPerson.png";
        public const string ImageSizeWarningTitle = "خطا در اندازه تصویر";
        public const string ImageSizeWarningMessage = "سایز تصویر انتخابی خارج از محدوده مجاز می باشد.";

        public const string SelectOptionString = "انتخاب کنید ...";
        public const string ActiveOptionString = "فعال";
        public const string NonActiveOptionString = "غیرفعال";

        public const string GenderMaleOptionString = "مذکر";
        public const string GenderFemaleOptionString = "مونث";


    }
}
