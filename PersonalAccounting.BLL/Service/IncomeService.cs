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
    public class IncomeService : BaseService, IRepositoryService<Income, ViewModelLoadAllIncome, Income>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDbSet<Income> _incomes;

        private const string EntityName = nameof(Income);
        private const string EntityNameNormal = "درآمد";

        public IncomeService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _incomes = _unitOfWork.Set<Income>();
        }

        public async Task<int> CountAsync()
        {
            return await _incomes.AsNoTracking().CountAsync();
        }

        public async Task<IList<Income>> LoadAllAsync(bool containActives = true)
        {
            if (!containActives)
                return await _incomes.Where(a => a.Status != "فعال")
                    .AsNoTracking().OrderByDescending(a => a.Id).ToListAsync();
            return await _incomes.AsNoTracking().ToListAsync();
        }

        public async Task<IList<ViewModelLoadAllIncome>> LoadAllViewModelAsync(int? createdBy = null)
        {
            if (createdBy != null)
            {
                var myQuery =
                    from income in _incomes.Where(a => a.CreatedBy == createdBy)
                    select new ViewModelLoadAllIncome()
                    {
                        IncomeId = income.Id,
                        ReceivedBy = income.ReceivedBy,
                        FundTitle = income.Fund.Title,
                        //BankAccountId = income.Fund.BankAccountId,
                        FundId = income.FundId,
                        FundOldValue = income.FundOldValue,
                        FundCurrentValue = income.FundCurrentValue,
                        IncomeTypeId = income.TypeId,
                        IncomeTypeTitle = income.IncomeType.Title,
                        IncomePrice = income.Amount,
                        IncomeDate = income.IncomeDate,
                        IncomeCreationDate = income.CreatedOn,
                        IncomeLastUpdate = income.LastUpdate,
                        IncomeCreationUserName = income.SelfUser.UserName,
                        IncomeUpdateByUserName = income.UpdateUser.UserName,
                        Description = income.Description
                    };
                return await myQuery.ToListAsync();
            }
            else
            {
                var myQuery =
                    from income in _incomes//.Where(a => a.Status == "فعال")
                    select new ViewModelLoadAllIncome()
                    {
                        IncomeId = income.Id,
                        ReceivedBy = income.ReceivedBy,
                        FundTitle = income.Fund.Title,
                        //BankAccountId = income.Fund.BankAccountId,
                        FundId = income.FundId,
                        FundOldValue = income.FundOldValue,
                        FundCurrentValue = income.FundCurrentValue,
                        IncomeTypeId = income.TypeId,
                        IncomeTypeTitle = income.IncomeType.Title,
                        IncomePrice = income.Amount,
                        IncomeDate = income.IncomeDate,
                        IncomeCreationDate = income.CreatedOn,
                        IncomeLastUpdate = income.LastUpdate,
                        IncomeCreationUserName = income.SelfUser.UserName,
                        IncomeUpdateByUserName = income.UpdateUser.UserName,
                        Description = income.Description
                    };
                return await myQuery.ToListAsync();
            }
        }

        public Task<IList<Income>> SimpleLoadViewModelAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<CreateStatus> CreateAsync(Income t)
        {
            try
            {
                if (await ExistAsync(t))
                {
                    InsertLog(LogLevel.Warning, EntityName,
                        "CreateAsync", GetServiceName(), EntityNameNormal + " جدید تکراری می باشد");
                    return CreateStatus.Exist;
                }

                _incomes.Add(t);
                await _unitOfWork.SaveChangesAsync();
                InsertLog(LogLevel.Information, EntityName,
                    "CreateAsync", GetServiceName(), EntityNameNormal +
                                                     $" جدید با شناسه." + $"{t.Id}" + $" و مبلغ {t.Amount} ریال " + " و مانده جاری" +
                                                     $"{t.FundCurrentValue} " + "ثبت گردید.");
                return CreateStatus.Successful;
            }
            catch (Exception exception)
            {
                InsertLog(LogLevel.Error, EntityName,
                    "CreateAsync", exception.Message, exception.ToDetailedString());
                return CreateStatus.Failure;
            }
        }

        public async Task UpdateAsync(Income t)
        {
            _incomes.AddOrUpdate(t);
            var beforeCurrentValue = t.FundCurrentValue;
            //_unitOfWork.MarkAsChanged(t);
            await _unitOfWork.SaveChangesAsync();
            InsertLog(LogLevel.Information, EntityName,
                "UpdateAsync", GetServiceName(), "به رکورد" + EntityNameNormal +
                                                 $" با شناسه. " + $"{t.Id}" +
                                                 $" و موجودی {beforeCurrentValue} ریال " +
                                                 $" مقدار {t.Amount} ریال افزوده گردید. " + " مانده جاری: " +
                                                 $"{t.FundCurrentValue} ریال ");
        }

        public async Task<Income> GetByIdAsync(int id)
        {
            return await _incomes.FirstOrDefaultAsync(i => i.Id == id);
        }
        public Task<Income> GetByNameAsync(string name)
        {
            throw new NotImplementedException();
        }


        public async Task<bool> ExistAsync(Income t)
        {
            return await _incomes.AnyAsync(i => i.IncomeDate == t.IncomeDate &&
                                               t.ReceivedBy == i.ReceivedBy && i.TypeId == t.TypeId &&
                                               i.FundId == t.FundId && i.Amount.Equals(t.Amount));
        }

        public Task<bool> IsUsedAsync(Income t)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsUsedAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistAsync(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> ExistAsync(int id)
        {
            return await _incomes.AnyAsync(i => i.Id == id);
        }

        public async Task<int> RemoveAsync(Income t)
        {
            return await RemoveAsync(t.Id);
        }

        public async Task<int> RemoveAsync(int id)
        {
            var item = await _incomes.FirstOrDefaultAsync(f => f.Id == id);
            _incomes.Remove(item);
            var res = await _unitOfWork.SaveChangesAsync();

            InsertLog(LogLevel.Information, EntityName,
                "RemoveAsync", GetServiceName(), EntityNameNormal + $" با شناسه {id} با موفقیت حذف گردید.");

            return res;
        }

        public Task<IList<Income>> SimpleLoadViewModelOnlyNoneUserAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IList<ViewModelLoadAllIncome>> GetByGroupIdAsync(int groupId)
        {
            throw new NotImplementedException();
        }

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