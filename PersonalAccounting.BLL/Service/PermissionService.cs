using PersonalAccounting.BLL.Enum;
using PersonalAccounting.BLL.IService;
using PersonalAccounting.CommonLibrary.Helper;
using PersonalAccounting.DAL.Infrastructure;
using PersonalAccounting.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalAccounting.BLL.Service
{
    public class PermissionService : BaseService, IPermissionService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDbSet<Role> _roles;
        private readonly IDbSet<Permission> _permissions;

        private const string EntityName = nameof(Permission);
        private const string EntityNameNormal = "مجوز کاربری";

        public PermissionService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _permissions = _unitOfWork.Set<Permission>();
            _roles = _unitOfWork.Set<Role>();
        }

        private bool _disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _unitOfWork.Dispose();
                }
            }
            this._disposed = true;
        }
        public void Dispose()
        {
            //_unitOfWork?.Dispose();
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public async Task<Permission> GetByIdAsync(int permissionId)
        {
            return await _permissions.FirstOrDefaultAsync(p => p.Id == permissionId);
        }

        public async Task<Permission> GetByNameAsync(string permissionName)
        {
            return await _permissions
                .FirstOrDefaultAsync(p =>
                    p.SystemName == permissionName || p.Name == permissionName);
        }

        public async Task<Permission> GetByNameAndFormEntityAsync(string permissionName, FormEntity formEntity)
        {
            var permission =
                _permissions.Where(p => p.SystemName == permissionName || p.Name == permissionName
                                                    && p.FormEntities
                                                        .Any(fe =>
                                                            fe.SystemName == formEntity.SystemName));

            return await permission.FirstOrDefaultAsync();
        }

        public async Task<CreateStatus> CreateAsync(Permission newPermission)
        {
            try
            {
                if (await ExistAsync(newPermission))
                {
                    InsertLog(LogLevel.Warning, EntityName,
                        "CreateAsync", GetServiceName(), EntityNameNormal + " جدید تکراری می باشد");
                    return CreateStatus.Exist;
                }

                _permissions.Add(newPermission);
                await _unitOfWork.SaveChangesAsync();
                InsertLog(LogLevel.Information, EntityName,
                    "CreateAsync", GetServiceName(), EntityNameNormal + $" جدید با نام {newPermission.Name} با موفقیت ثبت گردید.");
                return CreateStatus.Successful;
            }
            catch (Exception exception)
            {
                InsertLog(LogLevel.Error, EntityName,
                    "CreateAsync", exception.Message, exception.ToDetailedString());
                return CreateStatus.Failure;
            }
        }

        public async void CreateAsync(IList<Permission> permissions)
        {
            foreach (var permission in permissions)
            {
                await CreateAsync(permission);
            }
        }

        public async Task UpdateAsync(Permission permission)
        {
            _permissions.AddOrUpdate(permission);
            //_unitOfWork.MarkAsChanged(permission);
            await _unitOfWork.SaveChangesAsync();
            InsertLog(LogLevel.Information, EntityName,
                "UpdateAsync", GetServiceName(), EntityNameNormal + $" جدید با نام {permission.Name} با موفقیت ویرایش گردید.");
        }

        public IList<Permission> GetAllPermissionsByUserRoles(User user)
        {
            return (
                from role in user.Roles
                from permission in _permissions
                where permission.Roles.Any(p => p.Id == role.Id)
                select permission
                ).ToList();
        }

        public IList<Permission> GetAllPermissionsByUserRoles(IList<Role> roles)
        {
            return (
                from role in roles
                from permission in _permissions
                where permission.Roles.Any(p => p.Id == role.Id)
                select permission
            ).ToList();
        }

        public async Task<IList<Permission>> GetAllPermissionsByRoleAsync(Role role)
        {
            return await (
                from permission in _permissions
                where permission.Roles.Any(p => p.Id == role.Id)
                select permission
            ).ToListAsync();
        }

        public IList<Permission> GetAllPermissionsByRole(int roleId)
        {
            return (
                from permission in _permissions
                where permission.Roles.Any(p => p.Id == roleId)
                select permission
            ).ToList();
        }

        public async Task<IList<Permission>> GetAllPermissionsByFormEntityAsync(FormEntity formEntity)
        {
            return await (
                from permission in _permissions
                where permission.FormEntities.Any(p => p.Id == formEntity.Id
                                                       && p.Name == formEntity.Name)
                select permission
            ).ToListAsync();
        }

        public async Task<IList<Permission>> GetAllPermissionsByFormEntityAsync(string formEntityName)
        {
            return await (
                from permission in _permissions
                where permission.FormEntities.Any(p =>
                    p.Name == formEntityName || p.SystemName == formEntityName)
                select permission
            ).ToListAsync();
        }

        public bool HasPermission(Role role, string permissionName, string formName)
        {
            var permission = _permissions
                .FirstOrDefaultAsync(p => p.SystemName == permissionName
                                          || p.Name == permissionName
                                          && p.FormEntities.Any(fe =>
                                              fe.Name == formName || p.SystemName == formName)).Result;

            return permission != null &&
                   permission.Roles.Any(r => r.Id == role.Id && r.Name == role.Name);
        }

        public bool HasPermission(Role role, Permission permission, FormEntity formEntity)
        {
            var currentPermission = _permissions
                .FirstOrDefaultAsync(p => p.SystemName == permission.Name
                                          || p.Name == permission.Name
                                          && p.FormEntities.Any(fe =>
                                              fe.Name == formEntity.Name || p.SystemName == formEntity.Name)).Result;

            return currentPermission != null &&
                   currentPermission.Roles.Any(r => r.Id == role.Id && r.Name == role.Name);
        }

        public bool HasPermission(IList<Role> roles, string permissionName, string formName)
        {
            var permission = _permissions
                .FirstOrDefaultAsync(p => p.SystemName == permissionName
                                          || p.Name == permissionName).Result;

            if (permission == null) return false;

            var hasFormEntity = permission.FormEntities.Any(f =>
                f.Name == formName || f.SystemName == formName);
            if (!hasFormEntity) return false;

            return (
                from role in roles
                where permission.Roles.Any(r => r.Id == role.Id)
                select role
                    ).Any();

        }

        public async Task<bool> ExistAsync(int permissionId)
        {
            return await _permissions.AnyAsync(p => p.Id == permissionId);
        }

        public async Task<bool> ExistAsync(string permissionName)
        {
            return await _permissions
                .AnyAsync(p =>
                    p.SystemName == permissionName || p.Name == permissionName);
        }

        public async Task<bool> ExistAsync(Permission permission)
        {
            return await _permissions
                .AnyAsync(p => p.SystemName == permission.SystemName
                               && p.Name == permission.Name);
        }

        public async Task<bool> ExistForRoleAsync(Permission permission, string roleName)
        {
            if (!await ExistAsync(permission)) return false;

            return permission.Roles.Any(r => r.Name == roleName);
        }

        public async Task<bool> ExistForRoleAsync(Permission permission, Role role)
        {
            var currentPermission = await
                _permissions.FirstOrDefaultAsync(p => p.SystemName == permission.SystemName);
            if (currentPermission == null) return false;

            if (!await ExistAsync(currentPermission)) return false;

            return currentPermission.Roles.Any(r => r.Name == role.Name);
        }

        public async Task<bool> ExistForRoleAsync(string permissionName, string roleName)
        {
            var permission = await _permissions.FirstOrDefaultAsync(
                p => p.SystemName == permissionName || p.Name == permissionName);

            if (!await ExistAsync(permission)) return false;

            return permission != null && permission.Roles.Any(r => r.Name == roleName);
        }

        public async Task<bool> ExistForRoleAsync(string permissionName, Role role)
        {
            var permission = await _permissions.FirstOrDefaultAsync(
                p => p.SystemName == permissionName || p.Name == permissionName);

            if (!await ExistAsync(permission)) return false;

            return permission != null && permission.Roles.Any(r => r.Name == role.Name);
        }

        public async Task<bool> ExistForFormEntityAsync(Permission permission, string formEntityName)
        {
            if (!await ExistAsync(permission)) return false;

            return permission.FormEntities.Any(r => r.Name == formEntityName);
        }

        public async Task<bool> ExistForFormEntityAsync(Permission permission, FormEntity formEntity)
        {
            var currentPermission = await
                _permissions.FirstOrDefaultAsync(p => p.SystemName == permission.SystemName);
            if (currentPermission == null) return false;

            if (!await ExistAsync(currentPermission)) return false;

            return currentPermission.FormEntities.Any(r =>
                r.Name == formEntity.Name && r.SystemName == formEntity.SystemName);
        }

        public async Task<bool> ExistForFormEntityAsync(string permissionName, string formEntityName)
        {
            var permission = await _permissions.FirstOrDefaultAsync(
                p => p.SystemName == permissionName || p.Name == permissionName);

            if (!await ExistAsync(permission)) return false;

            return permission != null && permission.FormEntities.Any(r =>
                r.Name == formEntityName || r.SystemName == formEntityName);
        }

        public async Task<bool> ExistForFormEntityAsync(string permissionName, FormEntity formEntity)
        {
            var permission = await _permissions.FirstOrDefaultAsync(
                p => p.SystemName == permissionName || p.Name == permissionName);

            if (!await ExistAsync(permission)) return false;

            return permission != null && permission.FormEntities.Any(r => r.Name == formEntity.Name);
        }

        public async Task AddPermissionToRoleAsync(Permission permission, Role role, FormEntity formEntity)
        {
            try
            {
                if (HasPermission(role, permission, formEntity)) return;

                if (!await ExistForFormEntityAsync(permission, formEntity))
                {
                    permission.FormEntities.Add(formEntity);
                }

                if (!await ExistForRoleAsync(permission, role))
                {
                    permission.Roles.Add(role);
                }

                await UpdateAsync(permission);
            }
            catch (Exception exception)
            {
                InsertLog(LogLevel.Error, EntityName,
                    "AddPermissionToRoleAsync", exception.Message, exception.ToDetailedString());
                throw;
            }
        }

        public async Task UpdatePermissionAsync(Permission permission, Role role, bool isSelected = false)
        {
            if (isSelected)
            {
                permission.Roles.Add(role);
            }
            else
            {
                permission.Roles.Remove(role);
            }
            await UpdateAsync(permission);

            //if (HasPermission(role, permission, formEntity))
            //{
            //    var currentPermission =
            //        await Permissions.FirstOrDefaultAsync(p => p.SystemName == permission.SystemName);

            //    if (currentPermission != null)
            //    {
            //        currentPermission.IsSelected = isSelected;
            //        await UpdateAsync(permission);
            //    }
            //}
        }

        public async Task RemovePermissionFromRoleAsync(Permission permission, Role role, FormEntity formEntity)
        {
            try
            {
                if (HasPermission(role, permission, formEntity))
                {
                    if (!await ExistForFormEntityAsync(permission, formEntity))
                    {
                        permission.Roles.Remove(role);
                    }

                    if (!await ExistForRoleAsync(permission, role))
                    {
                        permission.FormEntities.Remove(formEntity);
                    }

                    await UpdateAsync(permission);
                }
            }
            catch (Exception exception)
            {
                InsertLog(LogLevel.Error, EntityName,
                    "RemovePermissionFromRoleAsync", exception.Message, exception.ToDetailedString());
                throw;
            }
        }

        public async Task<int> RemoveAsync(Permission permission)
        {
            var item = await
                _permissions.FirstOrDefaultAsync(p => p.SystemName == permission.SystemName
                                                && p.Name == permission.Name);
            _permissions.Remove(item);
            var res = await _unitOfWork.SaveChangesAsync();

            if (!(item is null))
                InsertLog(LogLevel.Information, EntityName,
                    "RemoveAsync", GetServiceName(), EntityNameNormal + $" با نام {item.Name} با موفقیت حذف گردید.");

            return res;

            //return await _permissions.Where(p => p.SystemName == permission.SystemName
            //                                    && p.Name == permission.Name).DeleteAsync();
        }

        public async Task<int> RemoveAsync(int permissionId)
        {
            var item = await _permissions.FirstOrDefaultAsync(f => f.Id == permissionId);
            _permissions.Remove(item);
            var res = await _unitOfWork.SaveChangesAsync();

            if (!(item is null))
                InsertLog(LogLevel.Information, EntityName,
                    "RemoveAsync", GetServiceName(), EntityNameNormal + $" با نام {item.Name} با موفقیت حذف گردید.");

            return res;
            //return await _permissions.Where(p => p.Id == permissionId).DeleteAsync();
        }
    }
}