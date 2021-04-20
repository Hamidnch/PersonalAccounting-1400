using PersonalAccounting.BLL.Enum;
using PersonalAccounting.Domain.Entity;
using PersonalAccounting.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonalAccounting.BLL.IService
{
    public interface IExpenseDocumentService : IDisposable
    {
        Task<int> CountAsync();
        Task<IList<ExpenseDocument>> LoadAllAsync(bool containActives = true, int? createdBy = null);
        Task<IList<ViewModelLoadAllExpenseDocument>> LoadAllViewModelAsync(int? createdBy = null);
        Task<CreateStatus> CreateAsync(ExpenseDocument expenseDocument);
        Task UpdateAsync(ExpenseDocument expenseDocument);
        Task<ExpenseDocument> GetByIdAsync(int expenseDocumentId, int? createdBy = null);
        Task<IList<ViewModelLoadAllExpense>> GetExpensesByDocumentIdAsync(int expenseDocumentId, int? createdBy = null);
        Task<bool> ExistAsync(ExpenseDocument expenseDocument);
        Task<int> RemoveAsync(ExpenseDocument expenseDocument);
        Task<int> RemoveAsync(int expenseDocumentId);
    }
}
