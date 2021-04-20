using PersonalAccounting.BLL.Enum;
using PersonalAccounting.BLL.IService;
using PersonalAccounting.CommonLibrary.Helper;
using PersonalAccounting.Domain.Entity;
using PersonalAccounting.UI.Infrastructure;
using System;
using System.ComponentModel;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalAccounting.UI.Helper
{
    public static class InitialHelper
    {
        public static string dbPath = DefaultConstants.SqliteDbPath;
        public static Color BackColorCustom { get; set; } = Color.Beige;
        public static DateTime CurrentDateTime { get; set; } = DateTime.Now;
        public static User CurrentUser { get; set; } = null;

        #region Stamp Properties

        [Description("Determines how the stamp button will respond"),
         Category("Behavior")]
        public static StampActions StampAction { get; set; } = StampActions.EditedBy;

        [Description("Color of the stamp text"),
         Category("Appearance")]
        public static Color StampColor { get; set; } = Color.Blue;

        #endregion Stamp Properties

        public static void ShowFormWithAccessLevel(Form parentForm, Form childForm)
        {
            var formName = childForm.Name;
            var hasPermission = HasPermissionFor(formName, PermissionMode.View);
            if (hasPermission)
            {
                if (childForm.Controls[DefaultConstants.FormCaptionLabel] == null) return;
                childForm.Controls[DefaultConstants.FormCaptionLabel].Text = string.Empty;
                childForm.Controls[DefaultConstants.FormCaptionLabel].Text = childForm.Text;
                childForm.Controls[DefaultConstants.FormCaptionLabel].Dock = DockStyle.Top;
                childForm.Controls[DefaultConstants.FormCaptionLabel].SendToBack();

                CommonHelper.ShowForm(parentForm, childForm);
            }
            else
            {
                CommonHelper.ShowNotificationMessage(DefaultConstants.IllegalAccess, DefaultConstants.ViewActionNotAllow);
            }
        }

        private static string GetPermissionName(string formName, PermissionMode permissionMode)
        {
            var entityName = formName.Remove(0, 3);
            switch (permissionMode)
            {
                case PermissionMode.View:
                    return $"{DefaultConstants.PrefixCanViewPermission}{entityName}";
                case PermissionMode.Add:
                    return $"{DefaultConstants.PrefixCanAddPermission}{entityName}";
                case PermissionMode.Edit:
                    return $"{DefaultConstants.PrefixCanEditPermission}{entityName}";
                case PermissionMode.Delete:
                    return $"{DefaultConstants.PrefixCanDeletePermission}{entityName}";
                default:
                    throw new ArgumentOutOfRangeException(nameof(permissionMode), permissionMode, null);
            }
        }

        public static async Task<bool> IsAdmin(this User user)
        {
            var roleService = IocConfig.Container.GetInstance<IRoleService>();
            var adminRole = await roleService.GetByNameAsync(DefaultConstants.AdminRole);
            return await roleService.IsRoleForUserAsync(adminRole, user);

        }
        public static bool HasPermissionFor(string formName, PermissionMode permissionMode)
        {
            var permissionName = GetPermissionName(formName, permissionMode);

            var userRoles = CurrentUser?.Roles.ToList();
            if (userRoles == null) return false;

            var permissionService = IocConfig.Container.GetInstance<IPermissionService>();
            var hasPermission = permissionService.HasPermission(userRoles, permissionName, formName);

            return hasPermission;
        }

        public static void SetPersianDateToTextBoxAndSelectAll(this MaskedTextBox textBox, bool enable = true, bool isSelectAll = true)
        {
            var selectedDate = PersianHelper.GetPersiaDateSimple(DateTime.Now);
            textBox.Enabled = enable;
            textBox.Text = selectedDate;

            if (!isSelectAll) return;

            textBox.Select();
            textBox.SelectAll();
        }

        public static void Backup(string strDestination)
        {
            using (var location = new SQLiteConnection(dbPath))
            using (var destination = new SQLiteConnection(
                    string.Format(DefaultConstants.SqliteBackupDestinationPath, strDestination, DateTime.Now)))
            //$@"Data Source={strDestination}\PA-{DateTime.Now:yyyyMMdd}.nch;foreign keys=true;"
            {
                location.Open();
                destination.Open();
                location.BackupDatabase(destination, "main", "main", -1, null, 0);
            }
        }
    }
}
