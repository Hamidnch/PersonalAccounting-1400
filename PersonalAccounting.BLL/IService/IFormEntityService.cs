using PersonalAccounting.BLL.Enum;
using PersonalAccounting.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonalAccounting.BLL.IService
{
    public interface IFormEntityService : IDisposable
    {
        Task<int> CountAsync();
        Task<IList<FormEntity>> LoadAllFormEntitiesAsync();
        Task<CreateStatus> CreateAsync(FormEntity formEntity);
        Task UpdateAsync(FormEntity formEntity);
        Task<FormEntity> GetByIdAsync(int id);
        Task<FormEntity> GetByNameAsync(string name);
        Task<bool> ExistAsync(FormEntity formEntity);
        Task<bool> ExistAsync(string name);
        Task<bool> ExistAsync(int id);
        Task<int> RemoveAsync(FormEntity formEntity);
        Task<int> RemoveAsync(int id);
    }
}
