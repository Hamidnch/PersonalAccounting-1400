using PersonalAccounting.BLL.Enum;
using PersonalAccounting.Domain.Entity;
using PersonalAccounting.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonalAccounting.BLL.IService
{
    public interface IUserService : IDisposable
    {
        Task<int> CountAsync();
        Task<IList<User>> LoadAllAsync(bool containActives = true);
        Task<IList<ViewModelLoadAllUser>> LoadAllViewModelAsync(int? createdBy = null);
        Task<IList<ViewModelSimpleLoadUser>> SimpleLoadViewModelAsync();
        Task<UserRegisterStatus> CreateAsync(User newUser);
        Task<UserRegisterStatus> UpdateAsync(User user);
        Task<User> GetByIdAsync(int userId);
        Task<User> GetByUsernameAsync(string userName);
        Task<IList<User>> GetUsersByRoleAsync(Role role);
        Task<IList<User>> GetUsersByRoleAsync(string roleName);
        Task<ValidateStatus> ValidateAsync(string userName, string password);
        Task<ValidateStatus> ValidateAsync(User currentUser);
        Task<bool> ExistAsync(string userNameOrEmail);
        Task<int> RemoveAsync(User user);
        Task<int> RemoveAsync(int userId);
    }
}
