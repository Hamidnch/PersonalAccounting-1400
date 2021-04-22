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
        Task<IList<ExpenseDocument>> LoadAllAsync(int userId, bool containActives = true);
        Task<IList<ViewModelLoadAllExpenseDocument>> LoadAllViewModelAsync(int? userId);
        Task<CreateStatus> CreateAsync(ExpenseDocument expenseDocument);
        Task UpdateAsync(ExpenseDocument expenseDocument);
        Task<ExpenseDocument> GetByIdAsync(int expenseDocumentId, int userId);
        Task<IList<ViewModelLoadAllExpense>> GetExpensesByDocumentIdAsync(int expenseDocumentId);
        Task<bool> ExistAsync(ExpenseDocument expenseDocument);
        Task<int> RemoveAsync(ExpenseDocument expenseDocument);
        Task<int> RemoveAsync(int expenseDocumentId);
    }
}
