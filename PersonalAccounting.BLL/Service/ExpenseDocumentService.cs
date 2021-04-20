using PersonalAccounting.BLL.Enum;
using PersonalAccounting.BLL.IService;
using PersonalAccounting.CommonLibrary.Helper;
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
    public class ExpenseDocumentService : BaseService, IExpenseDocumentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDbSet<ExpenseDocument> _expenseDocuments;
        private readonly IDbSet<Expense> _expenses;

        private const string EntityName = nameof(ExpenseDocument);
        private const string EntityNameNormal = "سند هزینه";

        public ExpenseDocumentService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _expenseDocuments = _unitOfWork.Set<ExpenseDocument>();
            _expenses = _unitOfWork.Set<Expense>();
        }

        #region IExpenseDocument Members

        public async Task<int> CountAsync()
        {
            return await _expenseDocuments.AsNoTracking().CountAsync<ExpenseDocument>();
        }

        public async Task<IList<ExpenseDocument>> LoadAllAsync(bool containActives = true, int? createdBy = null)
        {
            if (createdBy != null)
            {
                if (!containActives)
                    return await _expenseDocuments.Where(a => a.Status != "فعال" && a.CreatedBy == createdBy)
                        .AsNoTracking().OrderByDescending(a => a.Id).ToListAsync();
                return await _expenseDocuments.Where(a => a.CreatedBy == createdBy)
                    .AsNoTracking().OrderByDescending(a => a.Id).ToListAsync();
            }
            else
            {
                if (!containActives)
                    return await _expenseDocuments.Where(a => a.Status != "فعال")
                        .AsNoTracking().OrderByDescending(a => a.Id).ToListAsync();
                return await _expenseDocuments.AsNoTracking().OrderByDescending(a => a.Id).ToListAsync();
            }
        }

        public async Task<IList<ViewModelLoadAllExpenseDocument>> LoadAllViewModelAsync(int? createdBy = null)
        {
            if (createdBy != null)
            {
                var myQuery =
                    from expenseDocument in _expenseDocuments.Where(a => a.CreatedBy == createdBy)
                    orderby expenseDocument.Id descending
                    select
                        new ViewModelLoadAllExpenseDocument()
                        {
                            ExpenseDocumentCreationDate = expenseDocument.CreatedOn,
                            ExpenseDocumentCreationUserName = expenseDocument.SelfUser.UserName,
                            ExpenseDocumentUpdateByUserName = expenseDocument.UpdateUser.UserName,
                            ExpenseDocumentDate = expenseDocument.RegisterDate,
                            ExpenseDocumentDescription = expenseDocument.Description,
                            ExpenseDocumentId = expenseDocument.Id,
                            ExpenseDocumentLastUpdate = expenseDocument.LastUpdate
                        };
                return await myQuery.AsNoTracking()
                    //.OrderByDescending(a => a.ExpenseDocumentCreationDate)
                    .ToListAsync();
            }
            else
            {
                var myQuery =
                    from expenseDocument in _expenseDocuments//.Where(a => a.Status == "فعال")
                    orderby expenseDocument.Id descending
                    select
                        new ViewModelLoadAllExpenseDocument()
                        {
                            ExpenseDocumentCreationDate = expenseDocument.CreatedOn,
                            ExpenseDocumentCreationUserName = expenseDocument.SelfUser.UserName,
                            ExpenseDocumentUpdateByUserName = expenseDocument.UpdateUser.UserName,
                            ExpenseDocumentDate = expenseDocument.RegisterDate,
                            ExpenseDocumentDescription = expenseDocument.Description,
                            ExpenseDocumentId = expenseDocument.Id,
                            ExpenseDocumentLastUpdate = expenseDocument.LastUpdate
                        };
                return await myQuery.AsNoTracking()
                    //.OrderByDescending(a => a.ExpenseDocumentCreationDate)
                    .ToListAsync();
            }
        }

        public async Task<IList<ViewModelLoadAllExpense>> GetExpensesByDocumentIdAsync(int expenseDocumentId, int? createdBy = null)
        {
            var expenseDocument = await _expenseDocuments
                .FirstOrDefaultAsync(ed => ed.Id == expenseDocumentId);
            var expenses = _expenses.Where(e => e.DocumentId == expenseDocument.Id);
            if (createdBy != null)
            {
                expenses = expenses.Where(e => e.CreatedBy == createdBy);
            }
            //var expenses = expenseDocument.Expense.ToList();
            var myQuery = from expense in expenses
                          select new ViewModelLoadAllExpense()
                          {
                              ArticleName = expense.Article.Name,
                              Comment = expense.Description,
                              Count = expense.Count,
                              FundName = expense.Fund.Title,
                              MeasurementUnitName = expense.MeasurementUnit.Name,
                              ByPersonName = expense.ByPerson.FullName,
                              ForPersonName = expense.ForPerson.FullName,
                              Price = expense.Price,
                              Fi = expense.Rate,
                              ArticleId = expense.ArticleId,
                              FundId = expense.FundId,
                              MeasurementUnitId = expense.MeasurementUnitId,
                              ByPersonId = expense.ByPersonId,
                              ForPersonId = expense.ForPersonId,
                              RowNumber = expense.Row
                          };
            return await myQuery.OrderBy(e => e.RowNumber).ToListAsync();
        }
        public async Task<CreateStatus> CreateAsync(ExpenseDocument expenseDocument)
        {
            try
            {
                if (await ExistAsync(expenseDocument))
                {
                    InsertLog(LogLevel.Warning, EntityName,
                        "CreateAsync", GetServiceName(), EntityNameNormal + " تکراری می باشد");
                    return CreateStatus.Exist;
                }

                _expenseDocuments.Add(expenseDocument);
                await _unitOfWork.SaveChangesAsync();
                InsertLog(LogLevel.Information, EntityName,
                    "CreateAsync", GetServiceName(), EntityNameNormal + $" جدید با موفقیت ثبت گردید.");
                return CreateStatus.Successful;
            }
            catch (Exception exception)
            {
                InsertLog(LogLevel.Error, EntityName,
                    "CreateAsync", exception.Message, exception.ToDetailedString());
                return CreateStatus.Failure;
            }
        }

        public async Task UpdateAsync(ExpenseDocument expenseDocument)
        {
            _expenseDocuments.AddOrUpdate(expenseDocument);
            //_unitOfWork.MarkAsChanged(expenseDocument);
            await _unitOfWork.SaveChangesAsync();

            InsertLog(LogLevel.Information, EntityName,
                "UpdateAsync", GetServiceName(), EntityNameNormal + $" جدید با موفقیت ویرایش گردید.");
        }

        public async Task<ExpenseDocument> GetByIdAsync(int expenseDocumentId, int? createdBy = null)
        {
            if (createdBy != null)
            {
                return await _expenseDocuments.Include(ex => ex.Expenses)
                    .FirstOrDefaultAsync(ed => ed.Id == expenseDocumentId && ed.CreatedBy == createdBy);
            }
            else
            {
                return await _expenseDocuments.Include(ex => ex.Expenses)
                    .FirstOrDefaultAsync(ed => ed.Id == expenseDocumentId);
            }
        }

        public async Task<bool> ExistAsync(ExpenseDocument expenseDocument)
        {
            return await _expenseDocuments.AnyAsync(
                ed => ed.RegisterDate == expenseDocument.RegisterDate &&
                        ed.Id == expenseDocument.Id);
        }


        public async Task<int> RemoveAsync(ExpenseDocument expenseDocument)
        {
            return await RemoveAsync(expenseDocument.Id);
        }

        public async Task<int> RemoveAsync(int expenseDocumentId)
        {
            var item =
                await _expenseDocuments.FirstOrDefaultAsync(f => f.Id == expenseDocumentId);
            _expenseDocuments.Remove(item);
            var res = await _unitOfWork.SaveChangesAsync();

            InsertLog(LogLevel.Information, EntityName,
                "RemoveAsync", GetServiceName(), EntityNameNormal + $" با شناسه {item.Id} با موفقیت حذف گردید.");

            return res;
        }

        #endregion

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