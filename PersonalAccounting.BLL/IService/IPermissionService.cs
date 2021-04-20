using PersonalAccounting.BLL.Enum;
using PersonalAccounting.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonalAccounting.BLL.IService
{
    public interface IPermissionService : IDisposable
    {
        //Task<IList<Permission>> LoadAllByRoleIdAsync(int roleId);
        //Task<int> RemoveByRoleIdAsync(int roleId);
        //Task<int> RemoveByPermissionNameAndRoleIdAsync(int roleId, string permissionName);

        Task<Permission> GetByIdAsync(int permissionId);
        Task<Permission> GetByNameAsync(string permissionName);
        Task<Permission> GetByNameAndFormEntityAsync(string permissionName, FormEntity formEntity);
        IList<Permission> GetAllPermissionsByUserRoles(User user);
        IList<Permission> GetAllPermissionsByUserRoles(IList<Role> roles);
        Task<IList<Permission>> GetAllPermissionsByRoleAsync(Role role);
        IList<Permission> GetAllPermissionsByRole(int roleId);
        Task<IList<Permission>> GetAllPermissionsByFormEntityAsync(FormEntity formEntity);
        Task<IList<Permission>> GetAllPermissionsByFormEntityAsync(string formEntityName);
        Task<CreateStatus> CreateAsync(Permission newPermission);
        void CreateAsync(IList<Permission> permissions);
        Task UpdateAsync(Permission permission);
        bool HasPermission(Role role, string permissionName, string formName);
        bool HasPermission(Role role, Permission permission, FormEntity formEntity);
        bool HasPermission(IList<Role> roles, string permissionName, string formName);
        Task<bool> ExistAsync(int permissionId);
        Task<bool> ExistAsync(string permissionName);
        Task<bool> ExistAsync(Permission permission);
        Task<bool> ExistForRoleAsync(Permission permission, string roleName);
        Task<bool> ExistForRoleAsync(Permission permission, Role role);
        Task<bool> ExistForRoleAsync(string permissionName, string roleName);
        Task<bool> ExistForRoleAsync(string permissionName, Role role);

        Task<bool> ExistForFormEntityAsync(Permission permission, string formEntityName);
        Task<bool> ExistForFormEntityAsync(Permission permission, FormEntity formEntity);
        Task<bool> ExistForFormEntityAsync(string permissionName, string formEntityName);
        Task<bool> ExistForFormEntityAsync(string permissionName, FormEntity formEntity);

        Task AddPermissionToRoleAsync(Permission permission, Role role, FormEntity formEntity);
        Task UpdatePermissionAsync(Permission permission, Role role, bool isSelected = false);
        Task RemovePermissionFromRoleAsync(Permission permission, Role role, FormEntity formEntity);
        //Task ApplyPermissionAsync(Permission permission, Role role);
        Task<int> RemoveAsync(Permission permission);
        Task<int> RemoveAsync(int permissionId);

    }
}
