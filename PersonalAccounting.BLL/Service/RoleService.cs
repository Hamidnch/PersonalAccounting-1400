using PersonalAccounting.BLL.Enum;
using PersonalAccounting.BLL.IService;
using PersonalAccounting.CommonLibrary.Helper;
using PersonalAccounting.DAL.Infrastructure;
using PersonalAccounting.Domain.Entity;
using PersonalAccounting.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalAccounting.BLL.Service
{
    public class RoleService : BaseService, IRoleService
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IDbSet<User> _users;
        private readonly IDbSet<Role> _roles;

        private const string EntityName = nameof(Role);
        private const string EntityNameNormal = "نقش کاربری";

        public RoleService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _roles = _unitOfWork.Set<Role>();
            _users = _unitOfWork.Set<User>();
        }

        public async Task<int> CountAsync()
        {
            return await _roles.CountAsync();
        }

        public async Task<IList<Role>> LoadAllAsync(bool containActives = true)
        {
            if (!containActives)
                return await _roles.Where(a => a.Status != "فعال")
                    .AsNoTracking().OrderByDescending(a => a.Id).ToListAsync();
            return await _roles.ToListAsync();
        }

        public async Task<IList<ViewModelLoadAllRole>> LoadAllViewModelAsync(int? createdBy)
        {
            var myQuery = from role in _roles.Where(r=> r.CreatedBy == createdBy) //.Include(u => u.Users)
                          select new ViewModelLoadAllRole()
                          {
                              RoleId = role.Id,
                              RoleName = role.Name,
                              RoleDescription = role.Description,
                              RoleCreationDate = role.CreatedOn,
                              RoleLastUpdate = role.LastUpdate,
                              RoleStatus = role.Status,
                              UserCreationId = role.SelfUser.Id,
                              UserCreationName = role.SelfUser.UserName,                            
                              UserUpdateById = role.UpdateUser.Id,
                              UserUpdateByName = role.UpdateUser.UserName
                          };
            return await myQuery.ToListAsync();
        }

        public async Task<IList<ViewModelSimpleLoadRole>> SimpleLoadViewModelAsync()
        {
            var myQuery =
                from role in _roles//.Where(a => a.Status == "فعال")
                select new ViewModelSimpleLoadRole()
                {
                    RoleId = role.Id,
                    RoleName = role.Name,

                };
            return await myQuery.ToListAsync();
        }

        public async Task<IList<ViewModelSimpleLoadRole>> GetAllRolesForUserAsync(string userName)
        {
            var user = await _users.Where(u => u.UserName == userName).FirstOrDefaultAsync();
            //var selectedRoles = await Roles.Where(r => r.Users.Contains(user)).ToListAsync();
            var myQuery = from role in _roles
                          where role.Users.Any(u => u.UserName == user.UserName)
                          select new ViewModelSimpleLoadRole()
                          {
                              RoleId = role.Id,
                              RoleName = role.Name,

                          };
            return await myQuery.ToListAsync();
        }

        public async Task<Role> GetRoleByNameAsync(string roleName)
        {
            return await _roles.FirstOrDefaultAsync(r => r.Name == roleName);
        }

        //public async Task<IList<User>> GetUsersByRoleAsync(Role role)
        //{
        //    return await Users.Include(q => q.Roles.Where(r => r.Id == role.Id)).ToListAsync();
        //    //return await Roles.Where(r => r.Id == role.Id).Include(r => r.Users).ToListAsync();
        //    //return null;
        //}

        //public async Task<IList<User>> GetUsersByRoleAsync(string roleName)
        //{
        //    return await Users.Include(rs => rs.Roles.Where(r => r.Name == roleName)).ToListAsync();
        //    //return await Users.Where(u => u.Role.Name == roleName).ToListAsync();
        //    //return null;
        //}
        public async Task<Role> GetByIdAsync(int roleId)
        {
            return await _roles.FirstOrDefaultAsync(r => r.Id == roleId);
        }

        public async Task<Role> GetByNameAsync(string roleName)
        {
            return await _roles.FirstOrDefaultAsync(r => r.Name == roleName);
        }

        public async Task<Role> GetByUserAsync(string userName)
        {
            //return await Roles.Include(usr => usr.Users.Where(u => u.UserName == userName)).FirstOrDefaultAsync();
            return await _roles.Include(u => u.Users)
                .Where(u => _users.Any(usr => usr.UserName == userName)).FirstOrDefaultAsync();

            //var user = await Users.FirstOrDefaultAsync(u => u.UserName == userName);
            //return user?.Role;
            //return null;
        }

        public async Task<Role> GetByUserAsync(User user)
        {
            //return await Roles.Include(usr => usr.Users.Where(u => u.UserName == user.UserName)).FirstOrDefaultAsync();
            return await _roles.Include(u => u.Users)
                .Where(u => _users.Any(usr => usr.UserName == user.UserName)).FirstOrDefaultAsync();
            //var usr = await Users.FirstOrDefaultAsync(u => u.UserName == user.UserName);
            //return usr?.Role;
            //return null;
        }

        public async Task<CreateStatus> CreateAsync(string roleName, int? createdBy)
        {
            try
            {
                if (await ExistAsync(roleName))
                {
                    InsertLog(LogLevel.Warning, EntityName,
                        "CreateAsync", GetServiceName(), EntityNameNormal + " جدید تکراری می باشد");
                    return CreateStatus.Exist;
                }

                _roles.Add(new Role(roleName, DateTime.Now, DateTime.Now, createdBy, "فعال", string.Empty));
                await _unitOfWork.SaveChangesAsync();

                InsertLog(LogLevel.Information, EntityName,
                    "CreateAsync", GetServiceName(), EntityNameNormal + $" جدید با نام {roleName} با موفقیت ثبت گردید.");

                return CreateStatus.Successful;
            }
            catch (Exception exception)
            {
                InsertLog(LogLevel.Error, EntityName,
                    "CreateAsync", exception.Message, exception.ToDetailedString());
                return CreateStatus.Failure;
            }
        }

        public async Task<CreateStatus> CreateAsync(Role role)
        {
            try
            {
                if (await ExistAsync(role.Name))
                {
                    InsertLog(LogLevel.Warning, EntityName,
                        "CreateAsync", GetServiceName(), EntityNameNormal + " جدید تکراری می باشد");
                    return CreateStatus.Exist;
                }

                _roles.Add(new Role(role.Name, DateTime.Now,
                    DateTime.Now, null, "فعال", ""));
                await _unitOfWork.SaveChangesAsync();
                InsertLog(LogLevel.Information, EntityName,
                    "CreateAsync", GetServiceName(), EntityNameNormal + $" جدید با نام {role.Name} با موفقیت ثبت گردید.");
                return CreateStatus.Successful;
            }
            catch (Exception exception)
            {
                InsertLog(LogLevel.Error, EntityName,
                    "CreateAsync", exception.Message, exception.ToDetailedString());
                return CreateStatus.Failure;
            }
        }

        public async Task CreateAsync(IList<Role> roles)
        {
            foreach (var role in roles)
            {
                await CreateAsync(role);
            }
        }

        public async Task UpdateAsync(Role role)
        {
            _roles.AddOrUpdate(role);
            //_unitOfWork.MarkAsChanged(role);
            await _unitOfWork.SaveChangesAsync();

            InsertLog(LogLevel.Information, EntityName,
                "UpdateAsync", GetServiceName(), EntityNameNormal + $" با نام {role.Name} با موفقیت ویرایش گردید.");
        }

        public async Task<bool> AssignRoleToUserAsync(string userName, string roleName)
        {
            if (!await ExistAsync(roleName)) return false;

            var currentUser = await _users.FirstOrDefaultAsync(u => u.UserName == userName);
            if (currentUser == null)
            {
                InsertLog(LogLevel.Error, EntityName,
                    "AssignToUserAsync", GetServiceName(), $"کاربری با نام کاربری {userName} یافت نشد.");
                return false;
            }

            var currentRole = await GetRoleByNameAsync(roleName);

            if (currentRole == null)
            {
                InsertLog(LogLevel.Error, EntityName,
                    "AssignToUserAsync", GetServiceName(), $"نقشی با عنوان {roleName} یافت نشد.");
                return false;
            }
            if (currentUser.Roles.Contains(currentRole))
            {
                InsertLog(LogLevel.Error, EntityName,
                    "AssignToUserAsync", GetServiceName(), $"نفش {roleName} " +
                                                        $"برای کاربری با نام {userName} " +
                                                        " قبلا تخصیص داده شده است");
                return false;
            }

            currentUser.Roles.Add(currentRole);
            _users.AddOrUpdate(currentUser);
            await _unitOfWork.SaveChangesAsync();

            InsertLog(LogLevel.Information, EntityName,
                "AssignToUserAsync", GetServiceName(), EntityNameNormal + $" {roleName} " +
                                                    $" به کاربر {userName} " + " اختصاص یافت.");
            return true;
        }

        public async Task<bool> AssignToUserAsync(User user, string roleName)
        {
            if (!await ExistAsync(roleName)) return false;

            var currentUser = await _users.FirstOrDefaultAsync(u => u.UserName == user.UserName);
            if (currentUser == null)
            {
                InsertLog(LogLevel.Error, EntityName,
                    "AssignToUserAsync", GetServiceName(), $"کاربری با نام کاربری {user.UserName} یافت نشد.");
                return false;
            }

            try
            {
                var currentRole = await GetRoleByNameAsync(roleName);

                currentUser.Roles.Add(currentRole);
                _users.AddOrUpdate(currentUser);
                await _unitOfWork.SaveChangesAsync();

                InsertLog(LogLevel.Information, EntityName,
                    "AssignToUserAsync", GetServiceName(), EntityNameNormal + $"نقش {roleName} به کاربر {user.UserName} اختصاص یافت.");
            }
            catch (Exception exception)
            {
                InsertLog(LogLevel.Error, EntityName,
                    "AssignToUserAsync", exception.Message, exception.ToDetailedString());
                return false;
            }

            return true;
        }

        public async Task<bool> AssignToUserAsync(User user, Role role)
        {
            if (!await ExistAsync(role.Name)) return false;

            var currentUser = await _users.FirstOrDefaultAsync(u => u.UserName == user.UserName);

            if (currentUser == null)
            {
                InsertLog(LogLevel.Error, EntityName,
                    "AssignToUserAsync", GetServiceName(), $"کاربری با نام کاربری {user.UserName} یافت نشد.");
                return false;
            }

            currentUser.Roles.Add(role);
            _users.AddOrUpdate(currentUser);
            await _unitOfWork.SaveChangesAsync();

            InsertLog(LogLevel.Information, EntityName,
                "AssignToUserAsync", GetServiceName(), EntityNameNormal + $"نقش {role.Name} به کاربر {user.UserName} اختصاص یافت.");

            return true;
        }

        public async Task<bool> ExistAsync(string roleName)
        {
            return await _roles.AnyAsync(f => f.Name == roleName);
        }

        public async Task<bool> ExistAsync(Role role)
        {
            return await _roles.AnyAsync(f => f.Name == role.Name);
        }

        public async Task<bool> IsRoleForUserAsync(Role role, User user)
        {
            if (!await ExistAsync(role.Name)) return false;

            var currentUser = await _users.FirstOrDefaultAsync(u => u.UserName == user.UserName);
            if (currentUser == null)
            {
                InsertLog(LogLevel.Error, EntityName,
                    "IsRoleForUserAsync", GetServiceName(), $"کاربری با نام کاربری {user.UserName} یافت نشد.");
                return false;
            }
            return currentUser.Roles.Contains(role);
        }

        public async Task<bool> IsRoleForUserAsync(string roleName, string userName)
        {
            if (!await ExistAsync(roleName)) return false;

            var currentUser = await _users.FirstOrDefaultAsync(u => u.UserName == userName);
            if (currentUser == null)
            {
                InsertLog(LogLevel.Error, EntityName,
                    "IsRoleForUserAsync", GetServiceName(), $"کاربری با نام کاربری {userName} یافت نشد.");
                return false;
            }
            var currentRole = await GetRoleByNameAsync(roleName);

            return currentUser.Roles.Contains(currentRole);
        }

        public async Task RemoveByUserAsync(string userName)
        {
            var currentUser = await _users.FirstOrDefaultAsync(u => u.UserName == userName);
            if (currentUser == null)
            {
                InsertLog(LogLevel.Error, EntityName,
                    "RemoveByUserAsync", GetServiceName(), $"کاربری با نام کاربری {userName} یافت نشد.");
            }
            else
            {
                currentUser.Roles.Clear();
                _users.AddOrUpdate(currentUser);
                await _unitOfWork.SaveChangesAsync();

                InsertLog(LogLevel.Information, EntityName,
                    "RemoveByUserAsync", GetServiceName(), EntityNameNormal + $" مربوط به کاربر {userName} با موفقیت حذف گردید.");

            }
        }

        public async Task RemoveByUserAsync(User user)
        {
            var currentUser = await _users.FirstOrDefaultAsync(u => u.UserName == user.UserName);
            if (currentUser == null)
            {
                InsertLog(LogLevel.Error, EntityName,
                    "RemoveByUserAsync", GetServiceName(), $"کاربری با نام کاربری {user.UserName} یافت نشد.");
            }
            else
            {
                currentUser.Roles.Clear();
                _users.AddOrUpdate(currentUser);
                await _unitOfWork.SaveChangesAsync();

                InsertLog(LogLevel.Information, EntityName,
                    "RemoveByUserAsync", GetServiceName(), EntityNameNormal + $" مربوط به کاربر {user.UserName} با موفقیت حذف گردید.");
            }
        }

        public async Task<int> RemoveAsync(string roleName)
        {
            var item = await _roles.FirstOrDefaultAsync(f => f.Name == roleName);
            _roles.Remove(item);
            var res = await _unitOfWork.SaveChangesAsync();

            if (!(item is null))
                InsertLog(LogLevel.Information, EntityName,
                    "RemoveAsync", GetServiceName(), EntityNameNormal + $" با نام {item.Name} با موفقیت حذف گردید.");

            return res;
        }

        public async Task<int> RemoveAsync(Role role)
        {
            return await RemoveAsync(role.Name);
        }

        public async Task<IQueryable<Role>> GetRolesForUserAsync(string username)
        {
            var currentUser = await _users.FirstOrDefaultAsync(u => u.UserName == username);
            return currentUser?.Roles.AsQueryable();
        }

        public IQueryable<Role> GetRolesForUser(User user)
        {
            return user.Roles.AsQueryable();
        }

        public async Task RemoveRoleForUserAsync(string userName, string roleName)
        {
            if (!await ExistAsync(roleName)) return;

            var currentUser = await _users.FirstOrDefaultAsync(u => u.UserName == userName);
            if (currentUser == null)
            {
                InsertLog(LogLevel.Error, EntityName,
                    "RemoveRoleForUserAsync", GetServiceName(), $"کاربری با نام کاربری {userName} یافت نشد.");
            }
            else
            {
                var currentRole = await GetRoleByNameAsync(roleName);
                if (!currentUser.Roles.Contains(currentRole))
                {
                    InsertLog(LogLevel.Error, EntityName,
                        "RemoveRoleForUserAsync", GetServiceName(), $"نام کاربری {userName} "
                                                                         + $" دارای نقش کاربری " + $" {roleName} " + "نمی باشد.");
                    return;
                }

                currentUser.Roles.Remove(currentRole);
                _users.AddOrUpdate(currentUser);
                await _unitOfWork.SaveChangesAsync();

                InsertLog(LogLevel.Information, EntityName,
                    "RemoveRoleForUserAsync", GetServiceName(), EntityNameNormal + $"نقش کاربری {roleName}"
                                                                         + $" برای نام کاربری {userName}" + " حذف گردید.");
            }
        }

        public async Task<int> RemoveAllRolesForUserAsync(string userName)
        {
            var roleList = _roles.Include(r => r.Users)
                .Where(r => r.Users.Any(u => u.UserName == userName));

            foreach (var role in roleList)
            {
                _roles.Remove(role);
            }
            var res = await _unitOfWork.SaveChangesAsync();

            InsertLog(LogLevel.Information, EntityName,
                "RemoveAllRolesForUserAsync", GetServiceName(), $"کلیه نقشهای مربوط به نام کاربری {userName} حذف گردید.");

            return res;
            //return await _roles.Include(r => r.Users)
            //    .Where(r => r.Users.Any(u => u.UserName == userName)).DeleteAsync();
            //.Include(r => r.Users.Where(u => u.UserName == userName)).DeleteAsync();
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
    }
}
