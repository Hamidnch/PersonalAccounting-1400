using PersonalAccounting.BLL.Enum;
using PersonalAccounting.Domain.Entity;
using PersonalAccounting.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalAccounting.BLL.IService
{
    public interface IRoleService : IDisposable
    {
        Task<int> CountAsync();
        Task<IList<Role>> LoadAllAsync(bool containActives = true);
        Task<IList<ViewModelLoadAllRole>> LoadAllViewModelAsync(int? createdBy);
        Task<IList<ViewModelSimpleLoadRole>> SimpleLoadViewModelAsync();
        Task<IList<ViewModelSimpleLoadRole>> GetAllRolesForUserAsync(string userName);
        Task<Role> GetRoleByNameAsync(string roleName);
        //Task<IList<User>> GetUsersByRoleAsync(Role role);
        //Task<IList<User>> GetUsersByRoleAsync(string roleName);
        Task<Role> GetByIdAsync(int roleId);
        Task<Role> GetByNameAsync(string roleName);
        Task<Role> GetByUserAsync(string userName);
        Task<Role> GetByUserAsync(User user);
        Task<CreateStatus> CreateAsync(string roleName, int? createdBy);
        Task<CreateStatus> CreateAsync(Role role);
        Task CreateAsync(IList<Role> roles);
        Task UpdateAsync(Role role);
        Task<bool> AssignRoleToUserAsync(string userName, string roleName);
        Task<bool> AssignToUserAsync(User user, string roleName);
        Task<bool> AssignToUserAsync(User user, Role role);
        Task<bool> ExistAsync(string roleName);
        Task<bool> ExistAsync(Role role);
        Task<bool> IsRoleForUserAsync(Role role, User user);
        Task<bool> IsRoleForUserAsync(string roleName, string userName);
        Task RemoveByUserAsync(string userName);
        Task RemoveByUserAsync(User user);
        Task<int> RemoveAsync(string roleName);
        Task<int> RemoveAsync(Role role);

        /**************************/
        Task<IQueryable<Role>> GetRolesForUserAsync(string username);
        IQueryable<Role> GetRolesForUser(User user);
        //Task<bool> AddRolesToUserAsync(string userName, string[] roleNames);
        Task RemoveRoleForUserAsync(string userName, string roleName);
        Task<int> RemoveAllRolesForUserAsync(string userName);
    }
}
