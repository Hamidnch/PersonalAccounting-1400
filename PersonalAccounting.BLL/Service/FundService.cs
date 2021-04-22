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
    public class FundService : BaseService, IFundService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDbSet<Fund> _funds;
        private readonly IDbSet<Expense> _expenses;
        private readonly IDbSet<Income> _incomes;
        private readonly IDbSet<TransferMoney> _transferMonies;

        private const string EntityName = nameof(Fund);
        private const string EntityNameNormal = "صندوق ";

        public FundService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _funds = _unitOfWork.Set<Fund>();
            _expenses = _unitOfWork.Set<Expense>();
            _incomes = _unitOfWork.Set<Income>();
            _transferMonies = _unitOfWork.Set<TransferMoney>();
        }

        public async Task<int> CountAsync()
        {
            return await _funds.AsNoTracking().CountAsync();
        }

        public async Task<IList<Fund>> LoadAllAsync(bool containActives = true)
        {
            if (containActives)
                return await _funds.AsNoTracking().Where(i => i.Status == "فعال").ToListAsync();
            return await _funds.AsNoTracking().ToListAsync();
        }

        public async Task<IList<ViewModelLoadAllFund>> LoadAllViewModelAsync(int? createdBy = null)
        {
            if (createdBy != null)
            {
                var query =
                    from fund in _funds.Where(i => i.CreatedBy == createdBy)
                    select new ViewModelLoadAllFund()
                    {
                        FundId = fund.Id,
                        FundType = fund.Type,
                        BankAccountSubject =
                            !string.IsNullOrEmpty(fund.BankAccount.Name) ? fund.BankAccount.Name : " ------ ",
                        BankAccountId = fund.BankAccountId,
                        FundTitle = fund.Title,
                        FundCreationDate = fund.CreatedOn,
                        FundCreationUserName = fund.SelfUser.UserName,
                        FundUpdateByUserName = fund.UpdateUser.UserName,
                        FundPrimaryValue = fund.PrimaryValue,
                        FundCurrentValue = fund.CurrentValue,
                        FundDescription = fund.Description,
                        FundLastUpdate = fund.LastUpdate,
                        FundStatus = fund.Status
                    };
                return await query.OrderByDescending(x => x.FundCurrentValue).ToListAsync();
            }
            else
            {
                var query =
                    from fund in _funds//.Where(i => i.Status == "فعال")
                    select new ViewModelLoadAllFund()
                    {
                        FundId = fund.Id,
                        FundType = fund.Type,
                        BankAccountSubject = !string.IsNullOrEmpty(fund.BankAccount.Name) ? fund.BankAccount.Name : " ------ ",
                        BankAccountId = fund.BankAccountId,
                        FundTitle = fund.Title,
                        FundCreationDate = fund.CreatedOn,
                        FundCreationUserName = fund.SelfUser.UserName,
                        FundUpdateByUserName = fund.UpdateUser.UserName,
                        FundPrimaryValue = fund.PrimaryValue,
                        FundCurrentValue = fund.CurrentValue,
                        FundDescription = fund.Description,
                        FundLastUpdate = fund.LastUpdate,
                        FundStatus = fund.Status
                    };
                return await query.OrderByDescending(x => x.FundCurrentValue).ToListAsync();
            }
        }

        public async Task<IList<ViewModelSimpleLoadFund>> SimpleLoadViewModelAsync()
        {
            //var query = 
            //    (await _funds.ToListAsync()).Select(fund => new ViewModelLoadAllFund()
            //    {
            //                FundId = fund.Id,
            //                FundTitle = fund.Title
            //    });

            var query = from fund in await LoadAllAsync()
                        select new ViewModelSimpleLoadFund()
                        {
                            FundId = fund.Id,
                            FundTitle = fund.Title
                        };
            return query.ToList();
        }

        public async Task<CreateStatus> CreateAsync(Fund fund)
        {
            try
            {
                if (await ExistAsync(fund.Title))
                {
                    InsertLog(LogLevel.Warning, EntityName,
                        "CreateAsync", GetServiceName(), EntityNameNormal + " جدید تکراری می باشد");
                    return CreateStatus.Exist;
                }

                _funds.Add(fund);
                await _unitOfWork.SaveChangesAsync();
                InsertLog(LogLevel.Information, EntityName,
                    "CreateAsync", GetServiceName(), EntityNameNormal + $" جدید با نام {fund.Title} با موفقیت ثبت گردید.");
                return CreateStatus.Successful;
            }
            catch (Exception exception)
            {
                InsertLog(LogLevel.Error, EntityName,
                    "CreateAsync", exception.Message, exception.ToDetailedString());
                return CreateStatus.Failure;
            }
        }

        public async Task UpdateAsync(Fund fund)
        {
            _funds.AddOrUpdate(fund);
            //_unitOfWork.MarkAsChanged(fund);
            await _unitOfWork.SaveChangesAsync();
            InsertLog(LogLevel.Information, EntityName,
                "UpdateAsync", GetServiceName(), EntityNameNormal + $" جدید با نام {fund.Title} با موفقیت ویرایش گردید.");
        }

        public async Task<Fund> GetByIdAsync(int fundId)
        {
            return await _funds.FirstOrDefaultAsync(f => f.Id == fundId);
        }

        public async Task AddValueToFundAsync(int fundId, double value)
        {
            var fund = await GetByIdAsync(fundId);
            if (fund == null)
            {
                InsertLog(LogLevel.Error, EntityName,
                    "AddValueToFundAsync", GetServiceName(), $"صندوقی با شناسه {fundId} یافت نشد.");
            }
            else
            {
                var beforeFundCurrentValue = fund.CurrentValue;
                fund.CurrentValue += value;
                await UpdateAsync(fund);
                InsertLog(LogLevel.Information, EntityName,
                    "AddValueToFundAsync", GetServiceName(),
                    $"مانده قبلی صندوق: {beforeFundCurrentValue} ریال " +
                    "\n" +
                    $"مبلغ {value} ریال " + " به صندوق " +
                    $" با شناسه {fundId} " +
                    $"  و عنوان {fund.Title} افزوده گردید." +
                    "\n" +
                    $"مانده جاری صندوق: {fund.CurrentValue} ریال");
            }

        }

        public async Task<FundStatus> SubValueFromFundAsync(int fundId, double value)
        {
            var fund = await GetByIdAsync(fundId);

            if (fund == null)
            {
                InsertLog(LogLevel.Error, EntityName,
                    "SubValueFromFundAsync", GetServiceName(), $"صندوقی با شناسه {fundId} یافت نشد.");
            }
            else
            {
                if (fund.CurrentValue < value)
                {
                    InsertLog(LogLevel.Error, EntityName,
                        "SubValueFromFundAsync", GetServiceName(),
                        $"مانده صندوق با سناسه {fundId} " +
                        $"و عنوان {fund.Title} " + " کافی نمی باشد." +
                        $"مانده جاری صندوق: {fund.CurrentValue} ریال");

                    return FundStatus.FundValueIsLessThanCurrentValue;
                }

                var beforeFundCurrentValue = fund.CurrentValue;
                fund.CurrentValue -= value;
                await UpdateAsync(fund);

                InsertLog(LogLevel.Information, EntityName,
                    "AddValueToFundAsync", GetServiceName(),
                    $"مانده قبلی صندوق: {beforeFundCurrentValue} ریال " +
                    "\n" +
                    $"مبلغ {value} ریال " + " از صندوق " +
                    $" با شناسه {fundId} " +
                    $"  و عنوان {fund.Title} کسر گردید." +
                    "\n" +
                    $"مانده جاری صندوق: {fund.CurrentValue} ریال");
            }

            return FundStatus.Success;
        }

        public async Task<double> GetFundValueAsync(int fundId)
        {
            var fund = await _funds.FirstOrDefaultAsync(f => f.Id == fundId);
            return fund != null ? fund.CurrentValue : 0;
        }

        public async Task<bool> ExistAsync(Fund fund)
        {
            return await _funds.AnyAsync(f => f.Title == fund.Title);
        }

        public async Task<bool> ExistAsync(string fundName)
        {
            return await _funds.AnyAsync(f => f.Title == fundName);
        }

        public async Task<bool> IsUsedAsync(Fund fund)
        {
            return await IsUsedAsync(fund.Id);
        }

        public async Task<bool> IsUsedAsync(int fundId)
        {
            return await _expenses.AnyAsync(e => e.FundId == fundId) ||
                   await _incomes.AnyAsync(e => e.FundId == fundId) ||
                   await _transferMonies.AnyAsync(t => t.OriginFundId == fundId || t.DestinationFundId == fundId);
        }

        public async Task<int> RemoveAsync(Fund fund)
        {
            return await RemoveAsync(fund.Id);
            //return await _funds.Where(f => f.Title == fund.Title).DeleteAsync();
        }

        public async Task<int> RemoveAsync(int fundId)
        {
            var fund = await _funds.FirstOrDefaultAsync(f => f.Id == fundId);
            _funds.Remove(fund);

            var res = await _unitOfWork.SaveChangesAsync();
            InsertLog(LogLevel.Information, EntityName,
                "RemoveAsync", GetServiceName(), EntityNameNormal + $" با نام {fund.Title} با موفقیت حذف گردید.");

            return res;
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