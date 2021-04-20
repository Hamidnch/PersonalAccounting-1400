using PersonalAccounting.CommonLibrary.Helper;
using System;

namespace PersonalAccounting.Domain.ViewModel
{
    public class ViewModelLoadAllRole
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public DateTime? RoleCreationDate { get; set; }
        public string RolePersianRegisterDate => RoleCreationDate != null ? PersianHelper.CreatePersianDate(RoleCreationDate) : "";
        public DateTime? RoleLastUpdate { get; set; }
        public string RolePersianLastUpdate => RoleLastUpdate != null ? PersianHelper.CreatePersianDate(RoleLastUpdate) : "";
        public string RoleStatus { get; set; }
        public string RoleDescription { get; set; }
        public int? UserCreationId { get; set; }
        public string UserCreationName { get; set; }
        public int? UserUpdateById { get; set; }
        public string UserUpdateByName { get; set; }
    }
}