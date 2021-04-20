using PersonalAccounting.BLL.Enum;
using PersonalAccounting.Domain.Entity;
using PersonalAccounting.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonalAccounting.BLL.IService
{
    /// <summary>
    /// Transfer Money
    /// </summary>
    public interface ITransferMoneyService : IDisposable
    {
        Task<int> CountAsync();
        Task<IList<TransferMoney>> LoadAllAsync(bool containActives = true);

        Task<IList<ViewModelLoadAllTransferMoney>> LoadAllViewModelAsync(int? createdBy = null);
        Task<CreateStatus> CreateAsync(TransferMoney transferMoney);
        Task UpdateAsync(TransferMoney transferMoney);
        Task<TransferMoney> GetByIdAsync(int transferMoneyId);
        Task<TransferMoney> GetByFundAsync(int originFundId, int destinationFundId);
        Task<TransferStatus> TransferAmountAsync(int originFundId, int destinationFundId,
            double amount, double commission, TransferType transferType);
        //Task<TransferStatus> RollbackAmountFromDestinationFundToOriginFundAsync(int originFundId, int destinationFundId,
        //    double amount, double commission);
        Task<int> RemoveAsync(TransferMoney transferMoney);
        Task<int> RemoveAsync(int transferMoneyId);
    }
}
