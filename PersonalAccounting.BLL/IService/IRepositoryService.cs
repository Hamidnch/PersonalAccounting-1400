using PersonalAccounting.BLL.Enum;
using PersonalAccounting.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonalAccounting.BLL.IService
{
    public interface IRepositoryService<T, TVm1, TVm2> : IDisposable where T : BaseEntity
    {
        Task<int> CountAsync();
        Task<IList<T>> LoadAllAsync(bool containActives = true);
        Task<IList<TVm1>> LoadAllViewModelAsync(int? createdBy = null);
        Task<IList<TVm2>> SimpleLoadViewModelAsync();
        Task<CreateStatus> CreateAsync(T t);
        Task UpdateAsync(T t);
        Task<T> GetByIdAsync(int id);
        Task<T> GetByNameAsync(string name);
        Task<bool> ExistAsync(T t);
        Task<bool> IsUsedAsync(T t);
        Task<bool> IsUsedAsync(int id);
        Task<bool> ExistAsync(string name);
        Task<bool> ExistAsync(int id);
        Task<int> RemoveAsync(T t);
        Task<int> RemoveAsync(int id);

        //For Person
        Task<IList<TVm2>> SimpleLoadViewModelOnlyNoneUserAsync();

        //For Article and Article Group
        Task<IList<TVm1>> GetByGroupIdAsync(int groupId);
    }
}