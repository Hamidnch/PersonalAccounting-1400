using PersonalAccounting.BLL.Enum;
using PersonalAccounting.Domain.Entity;
using PersonalAccounting.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonalAccounting.BLL.IService
{
    /// <summary>
    /// Fund
    /// </summary>
    public interface IFundService : IDisposable
    {
        Task<int> CountAsync();
        Task<IList<Fund>> LoadAllAsync(bool containActives = true);
        Task<IList<ViewModelLoadAllFund>> LoadAllViewModelAsync(int? createdBy = null);
        Task<IList<ViewModelSimpleLoadFund>> SimpleLoadViewModelAsync();
        Task<CreateStatus> CreateAsync(Fund fund);
        Task UpdateAsync(Fund fund);
        Task<Fund> GetByIdAsync(int fundId);
        Task AddValueToFundAsync(int fundId, double value);
        Task<FundStatus> SubValueFromFundAsync(int fundId, double value);
        Task<double> GetFundValueAsync(int fundId);
        Task<bool> ExistAsync(Fund fund);
        Task<bool> ExistAsync(string fundName);
        Task<bool> IsUsedAsync(Fund fund);
        Task<bool> IsUsedAsync(int fundId);
        Task<int> RemoveAsync(Fund fund);
        Task<int> RemoveAsync(int fundId);
    }
}
