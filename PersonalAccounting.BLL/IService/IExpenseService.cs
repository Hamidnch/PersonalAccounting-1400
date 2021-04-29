using PersonalAccounting.Domain.Entity;
using PersonalAccounting.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonalAccounting.BLL.IService
{
    public interface IExpenseService : IDisposable
    {
        Task<int> GetExpenseCountInDocumentAsync(ExpenseDocument document);
        Task<int> GetExpenseCountInDocumentAsync(int documentId);
        IList<ViewModelLoadAllExpenseReport> LoadAllExpenses(DateTime? startDateTime = null, DateTime? endDateTime = null, 
            int? documentId = null, int? articleGroupId = null, int? articleId = null,
            int? byPersonId = null, int? forPersonId = null, int? fundId = null, string comment = null);
        Task<IList<Expense>> GetExpensesByDocumentAsync(ExpenseDocument document);
        Task<IList<Expense>> GetExpensesByDocumentIdAsync(int documentId);
        Task<IList<ViewModelLoadAllExpense>> LoadAllExpensesByDocumentAsync(ExpenseDocument document);
        Task<IList<ViewModelLoadAllExpense>> LoadAllExpensesByDocumentIdAsync(int documentId);
        //Task InsertExpenseInToDocumentAsync(Expense expense, ExpenseDocument document);
        Task InsertExpenseInToDocumentAsync(Expense expense);

        Task UpdateExpenseByDocumentAsync(Expense expense, int documentId);
        Task RemoveFromDocumentAsync(int documentId);
        Task RemoveFromDocumentAsync(ExpenseDocument document);
        //Task<int> RemoveExpensesAsync(ICollection<Expense> expenses);
        Task<int> RemoveExpenseAsync(Expense expense);
        Task<int> RemoveExpenseAsync(int expenseId);
        //int ExpenseCount { get; }
        //IList<Expense> LoadAllExpenses();
        //IList<ViewModelExpenseLoadAll> CustomLoadAllExpenses();
        //CreateStatus CreateNewExpense(Expense expense);
        //void UpdateCurrentExpense(Expense expense);
        //Expense GetExpenseById(int expenseId);
        //bool ExistExpense(Expense expense);
        //bool IsUsedExpense(Expense expense);
        //bool IsUsedExpense(int expenseId);
        //int RemoveExpense(Expense expense);
        //int RemoveExpense(int expenseId);
    }
}
