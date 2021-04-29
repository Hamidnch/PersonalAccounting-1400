using PersonalAccounting.BLL.IService;
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
    public class ExpenseService : BaseService, IExpenseService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDbSet<Expense> _expenses;
        private readonly IDbSet<ExpenseDocument> _expenseDocuments;

        private const string EntityName = nameof(Expense);
        private const string EntityNameNormal = "قلم هزینه";

        public ExpenseService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _expenses = _unitOfWork.Set<Expense>();
            _expenseDocuments = _unitOfWork.Set<ExpenseDocument>();
        }

        public async Task<int> GetExpenseCountInDocumentAsync(ExpenseDocument document)
        {
            return await _expenses.Where(ex => ex.DocumentId == document.Id)
                .AsNoTracking().CountAsync();
        }

        public async Task<int> GetExpenseCountInDocumentAsync(int documentId)
        {
            return await _expenses.Where(ex => ex.DocumentId == documentId)
                .AsNoTracking().CountAsync();
        }

        public IList<ViewModelLoadAllExpenseReport> LoadAllExpenses(
            DateTime? startDateTime = null, DateTime? endDateTime = null, 
            int? documentId = null, int? articleGroupId = null, int? articleId = null, 
            int? byPersonId = null, int? forPersonId = null, int? fundId = null, string comment = null)
        {
            var expenseList = _expenses.AsNoTracking();

            if (startDateTime != null)
            {
                expenseList = expenseList.Where(el => el.ExpenseDocument.RegisterDate == startDateTime);
            }
            if (endDateTime != null)
            {
                expenseList = expenseList.Where(el => el.ExpenseDocument.RegisterDate == endDateTime);
            }
            if (documentId != null)
            {
                expenseList = expenseList.Where(ex => ex.DocumentId == documentId);
            }
            if (articleGroupId != null)
            {
                expenseList = expenseList.Where(ex => ex.Article.GroupId == articleGroupId);
            }
            if (articleId != null)
            {
                expenseList = expenseList.Where(ex => ex.ArticleId == articleId);
            }
            if (byPersonId != null)
            {
                expenseList = expenseList.Where(ex => ex.ByPersonId == byPersonId);
            }
            if (forPersonId != null)
            {
                expenseList = expenseList.Where(ex => ex.ForPersonId == forPersonId);
            }
            if (fundId != null)
            {
                expenseList = expenseList.Where(ex => ex.FundId == fundId);
            }
            if (comment != null)
            {
                expenseList = expenseList.Where(ex => ex.Description == comment);
            }

            var myQuery = from expense in expenseList
                select
                    new ViewModelLoadAllExpenseReport()
                    {
                        ExpenseDate = expense.ExpenseDocument.RegisterDate,
                        DocumentId = expense.DocumentId,
                        ArticleGroupId = expense.Article.GroupId,
                        ArticleGroupSubject = expense.Article.ArticleGroup.Name,
                        ArticleId = expense.ArticleId,
                        ArticleName = expense.Article.Name,
                        FundId = expense.FundId,
                        FundName = expense.Fund.Title,
                        ByPersonId = expense.ByPersonId,
                        ByPersonName = expense.ByPerson.FullName,
                        ForPersonId = expense.ForPersonId,
                        ForPersonName = expense.ForPerson.FullName,
                        Fi = expense.Rate,
                        Count = expense.Count,
                        Price = expense.Price,
                        MeasurementUnitId = expense.MeasurementUnitId,
                        MeasurementUnitName = expense.MeasurementUnit.Name,
                        CreatedBy = expense.CreatedBy,
                        UpdateBy = expense.UpdateBy,
                        CreatedOn = expense.CreatedOn,
                        UpdateOn = expense.LastUpdate,
                        Comment = expense.Description
                    };
            return myQuery.ToList();
        }

        public async Task<IList<Expense>> GetExpensesByDocumentAsync(ExpenseDocument document)
        {
            return await _expenses.Where(ex => ex.DocumentId == document.Id).ToListAsync();
        }

        public async Task<IList<Expense>> GetExpensesByDocumentIdAsync(int documentId)
        {
            return await _expenses.Where(ex => ex.DocumentId == documentId).ToListAsync();
        }

        public async Task<IList<ViewModelLoadAllExpense>> LoadAllExpensesByDocumentAsync(ExpenseDocument document)
        {
            var expenseList = _expenses.Where(ex => ex.DocumentId == document.Id);

            var myQuery = from expense in expenseList
                          select
                              new ViewModelLoadAllExpense()
                              {
                                  Comment = expense.Description,
                                  ArticleName = expense.Article.Name,
                                  Count = expense.Count,
                                  FundName = expense.Fund.Title,
                                  MeasurementUnitName = expense.MeasurementUnit.Name,
                                  ByPersonName = expense.ByPerson.FullName,
                                  ForPersonName = expense.ForPerson.FullName,
                                  Price = expense.Price,
                                  Fi = expense.Rate
                              };
            return await myQuery.ToListAsync();
        }

        public async Task<IList<ViewModelLoadAllExpense>> LoadAllExpensesByDocumentIdAsync(int documentId)
        {
            var expenseList = _expenses.Where(ex => ex.DocumentId == documentId);

            var myQuery = from expense in expenseList
                          select
                              new ViewModelLoadAllExpense()
                              {
                                  Comment = expense.Description,
                                  ArticleName = expense.Article.Name,
                                  Count = expense.Count,
                                  FundName = expense.Fund.Title,
                                  MeasurementUnitName = expense.MeasurementUnit.Name,
                                  ByPersonName = expense.ByPerson.FullName,
                                  ForPersonName = expense.ForPerson.FullName,
                                  Price = expense.Price,
                                  Fi = expense.Rate
                              };
            return await myQuery.ToListAsync();
        }

        //public async Task InsertExpenseInToDocumentAsync(Expense expense, ExpenseDocument document)
        //{
        //    expense.DocumentId = document.Id;
        //    Expenses.Add(expense);
        //    //_unitOfWork.MarkAsAdded(expense);
        //    await _unitOfWork.SaveChangesAsync();
        //}

        public async Task InsertExpenseInToDocumentAsync(Expense expense)
        {
            //expense.DocumentId = documentId;
            _expenses.Add(expense);
            //_unitOfWork.MarkAsAdded(expense);
            await _unitOfWork.SaveChangesAsync();

            InsertLog(LogLevel.Warning, EntityName,
                "InsertExpenseInToDocumentAsync", GetServiceName(), EntityNameNormal + $" جدید با موفقیت ثبت گردید.");
        }

        public async Task UpdateExpenseByDocumentAsync(Expense expense, int documentId)
        {
            expense.DocumentId = documentId;
            _expenses.AddOrUpdate(expense);
            //_unitOfWork.MarkAsChanged(expense);
            await _unitOfWork.SaveChangesAsync();

            InsertLog(LogLevel.Information, EntityName,
                "UpdateExpenseByDocumentAsync", GetServiceName(), EntityNameNormal + $" جدید با موفقیت ویرایش گردید.");
        }


        public async Task RemoveFromDocumentAsync(int documentId)
        {
            var doc = await _expenseDocuments.Include(ex => _expenses)
                .FirstOrDefaultAsync(d => d.Id == documentId);

            if (doc != null) doc.Expenses.Clear();

            InsertLog(LogLevel.Information, EntityName,
                "RemoveFromDocumentAsync", "Remove Expense",
                EntityNameNormal + $" با سند هزینه {documentId} با موفقیت حذف گردید.");

            //_unitOfWork.MarkAsDeleted(doc?.Expenses);
            //return await _unitOfWork.SaveChangesAsync();
            //return await Expenses.Where(ex => ex.DocumentId == documentId).DeleteAsync();
        }

        public async Task RemoveFromDocumentAsync(ExpenseDocument document)
        {
            await RemoveExpenseAsync(document.Id);

            //var doc = await _expenseDocuments.Include(ex => _expenses)
            //    .FirstOrDefaultAsync(d => d.Id == document.Id);

            //if (doc != null)
            //{
            //    //_unitOfWork.MarkAsDeleted(doc.Expenses);
            //    //await _unitOfWork.SaveChangesAsync();
            //    doc.Expenses.Clear();
            //}

            //InsertLog(LogLevel.Information, EntityName,
            //    "RemoveFromDocumentAsync", GetServiceName(),
            //    EntityNameNormal + $" با سند هزینه {document.Id} با موفقیت حذف گردید.");
            ////var expenses = document.Expenses;
            ////foreach (var expense in expenses)
            ////{
            ////    _unitOfWork.MarkAsDeleted(expense);
            ////}

            ////return await _unitOfWork.SaveChangesAsync();
        }

        public async Task<int> RemoveExpenseAsync(Expense expense)
        {
            return await RemoveExpenseAsync(expense.Id);
        }

        //public async Task<int> RemoveExpenseAsync(Expense expense)
        //{
        //    //_unitOfWork.MarkAsDeleted(expense);
        //    //return await Expenses.Where(ex => ex.Id == expense.Id).DeleteAsync();
        //    //return await _unitOfWork.SaveChangesAsync();
        //    //var exp = await Expenses.FirstOrDefaultAsync(ex => ex.Id == expense.Id);
        //    _unitOfWork.MarkAsDeleted(expense);
        //    return await _unitOfWork.SaveChangesAsync();
        //}

        public async Task<int> RemoveExpenseAsync(int expenseId)
        {
            var expense = await _expenses.FirstOrDefaultAsync(ex => ex.Id == expenseId);
            _expenses.Remove(expense);
            //_unitOfWork.MarkAsDeleted(expense);
            var res = await _unitOfWork.SaveChangesAsync();

            InsertLog(LogLevel.Information, EntityName,
                "RemoveFromDocumentAsync", GetServiceName(),
                EntityNameNormal + $" با شناسه {expenseId} با موفقیت حذف گردید.");
            return res;
        }

        //public async Task<int> RemoveExpensesAsync(ICollection<Expense> expenses)
        //{
        //    _unitOfWork.MarkAsDeleted(expenses);

        //    return await _unitOfWork.SaveChangesAsync();
        //}

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
