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
    public class BankAccountService : BaseService,
        IRepositoryService<BankAccount, ViewModelLoadAllBankAccount, ViewModelSimpleLoadBankAccount>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDbSet<BankAccount> _bankAccounts;
        private readonly IDbSet<Fund> _funds;
        private readonly IDbSet<TransferMoney> _transferMonies;

        private const string EntityName = nameof(BankAccount);
        private const string EntityNameNormal = "حساب بانکی";

        public BankAccountService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _bankAccounts = _unitOfWork.Set<BankAccount>();
            _funds = _unitOfWork.Set<Fund>();
            _transferMonies = _unitOfWork.Set<TransferMoney>();
        }

        public async Task<int> CountAsync()
        {
            return await _bankAccounts.AsNoTracking().CountAsync<BankAccount>();
        }

        public async Task<IList<BankAccount>> LoadAllAsync(bool containActives)
        {
            if (!containActives)
                return await _bankAccounts.Where(a => a.Status != "فعال")
                    .AsNoTracking().OrderByDescending(a => a.Id).ToListAsync();
            return await _bankAccounts.AsNoTracking().OrderByDescending(a => a.Id).ToListAsync();
        }

        public async Task<IList<ViewModelLoadAllBankAccount>> LoadAllViewModelAsync(int? createBy = null)
        {
            if (createBy != null)
            {
                var query =
                    from bankAccount in _bankAccounts.Where(a => a.CreatedBy == createBy)
                    select new ViewModelLoadAllBankAccount()
                    {
                        BankAccountId = bankAccount.Id,
                        BankAccountSubject = bankAccount.Name,
                        BankAccountNumber = bankAccount.AccountNumber,
                        BankAccountPersonName = bankAccount.Person.FullName,
                        BankName = bankAccount.Bank.Name,
                        PersonId = bankAccount.PersonId,
                        BankId = bankAccount.BankId,
                        BankAccountCreationUserName = bankAccount.SelfUser.UserName,
                        BankAccountUpdateByUserName = bankAccount.UpdateUser.UserName,
                        BankAccountCreationDate = bankAccount.CreatedOn,
                        BankAccountLastUpdate = bankAccount.LastUpdate,
                        BankAccountDescription = bankAccount.Description,
                        BankAccountStatus = bankAccount.Status
                    };
                return await query.ToListAsync();
            }
            else
            {
                var query =
                    from bankAccount in _bankAccounts//.Where(a => a.Status == "فعال")
                    select new ViewModelLoadAllBankAccount()
                    {
                        BankAccountId = bankAccount.Id,
                        BankAccountSubject = bankAccount.Name,
                        BankAccountNumber = bankAccount.AccountNumber,
                        BankAccountPersonName = bankAccount.Person.FullName,
                        BankName = bankAccount.Bank.Name,
                        PersonId = bankAccount.PersonId,
                        BankId = bankAccount.BankId,
                        BankAccountCreationUserName = bankAccount.SelfUser.UserName,
                        BankAccountUpdateByUserName = bankAccount.UpdateUser.UserName,
                        BankAccountCreationDate = bankAccount.CreatedOn,
                        BankAccountLastUpdate = bankAccount.LastUpdate,
                        BankAccountDescription = bankAccount.Description,
                        BankAccountStatus = bankAccount.Status
                    };
                return await query.ToListAsync();
            }
        }


        public async Task<IList<ViewModelSimpleLoadBankAccount>> SimpleLoadViewModelAsync()
        {
            var query = from bankAccount in _bankAccounts
                        select new ViewModelSimpleLoadBankAccount()
                        {
                            BankAccountId = bankAccount.Id,
                            BankAccountSubject = bankAccount.Name,
                            BankAccountNumber = bankAccount.AccountNumber,
                            BankAccountPersonName = bankAccount.Person.FullName,
                            BankName = bankAccount.Bank.Name
                        };
            return await query.ToListAsync();
        }

        public async Task<CreateStatus> CreateAsync(BankAccount t)
        {
            try
            {
                if (await ExistAsync(t.Name))
                {
                    InsertLog(LogLevel.Warning, EntityName,
                        "CreateAsync", GetServiceName(), EntityNameNormal + "جدید تکراری می باشد");
                    return CreateStatus.Exist;
                }

                _bankAccounts.Add(t);
                await _unitOfWork.SaveChangesAsync();
                InsertLog(LogLevel.Information, EntityName,
                    "CreateAsync", GetServiceName(), EntityNameNormal + $" جدید با نام {t.Name} با موفقیت ثبت گردید.");
                return CreateStatus.Successful;
            }
            catch (Exception exception)
            {
                InsertLog(LogLevel.Error, EntityName,
                    "CreateAsync", exception.Message, exception.ToDetailedString());
                return CreateStatus.Failure;
            }
        }

        public async Task UpdateAsync(BankAccount t)
        {
            _bankAccounts.AddOrUpdate(t);
            //_unitOfWork.MarkAsChanged(t);
            await _unitOfWork.SaveChangesAsync();
            InsertLog(LogLevel.Information, EntityName,
                "UpdateAsync", GetServiceName(), EntityNameNormal + $" جدید با نام {t.Name} با موفقیت ویرایش گردید.");
        }

        public async Task<BankAccount> GetByIdAsync(int id)
        {
            return await _bankAccounts.FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<BankAccount> GetByNameAsync(string name)
        {
            return await _bankAccounts.FirstOrDefaultAsync(b => b.Name == name);
        }

        public async Task<bool> ExistAsync(BankAccount t)
        {
            return await _bankAccounts.AnyAsync(b => b.Id == t.Id);
        }

        public async Task<bool> IsUsedAsync(BankAccount t)
        {
            return await IsUsedAsync(t.Id);
        }

        public async Task<bool> IsUsedAsync(int id)
        {
            return await _funds.AnyAsync(e => e.BankAccountId == id) ||
                await _transferMonies.AnyAsync(t => t.OriginFundId == id ||
                                                    t.DestinationFundId == id);
        }

        public async Task<bool> ExistAsync(string name)
        {
            return await _bankAccounts.AnyAsync(b => b.Name == name);
        }

        public async Task<bool> ExistAsync(int id)
        {
            return await _bankAccounts.AnyAsync(b => b.Id == id);
        }

        public async Task<int> RemoveAsync(BankAccount t)
        {
            return await RemoveAsync(t.Id);
            //return await _bankAccounts.Where(b => b.Id == t.Id).DeleteAsync();
        }

        public async Task<int> RemoveAsync(int id)
        {
            var item =
                await _bankAccounts.FirstOrDefaultAsync(f => f.Id == id);
            _bankAccounts.Remove(item);
            var res = await _unitOfWork.SaveChangesAsync();

            InsertLog(LogLevel.Information, EntityName,
                "RemoveAsync", GetServiceName(), EntityNameNormal + $" با نام {item.Name} با موفقیت حذف گردید.");

            return res;
        }

        public Task<IList<ViewModelSimpleLoadBankAccount>> SimpleLoadViewModelOnlyNoneUserAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IList<ViewModelLoadAllBankAccount>> GetByGroupIdAsync(int groupId)
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
