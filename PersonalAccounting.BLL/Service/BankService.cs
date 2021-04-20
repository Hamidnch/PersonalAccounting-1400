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
    public class BankService : BaseService, IRepositoryService<Bank, ViewModelLoadAllBank, Bank>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDbSet<Bank> _banks;
        private readonly IDbSet<BankAccount> _bankAccounts;

        private const string EntityName = nameof(Bank);
        private const string EntityNameNormal = "بانک";

        public BankService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _banks = _unitOfWork.Set<Bank>();
            _bankAccounts = _unitOfWork.Set<BankAccount>();
        }

        public async Task<int> CountAsync()
        {
            return await _banks.AsNoTracking().CountAsync<Bank>();
        }

        public async Task<IList<Bank>> LoadAllAsync(bool containActives = true)
        {
            if (!containActives)
                return await _banks.Where(a => a.Status != "فعال")
                    .AsNoTracking().OrderByDescending(a => a.Id).ToListAsync();
            return await _banks.AsNoTracking().OrderByDescending(a => a.Id).ToListAsync();
        }

        public async Task<IList<ViewModelLoadAllBank>> LoadAllViewModelAsync(int? createBy = null)
        {
            if (createBy != null)
            {
                var myQuery =
                    from bank in _banks.Where(a => a.CreatedBy == createBy)
                    select new ViewModelLoadAllBank()
                    {
                        BankId = bank.Id,
                        BankName = bank.Name,
                        BankDepartment = bank.Department,
                        BankCreationDate = bank.CreatedOn,
                        BankCreationUserName = bank.SelfUser.UserName,
                        BankUpdateByUserName = bank.UpdateUser.UserName,
                        BankLastUpdate = bank.LastUpdate,
                        BankStatus = bank.Status,
                        BankDescription = bank.Description
                    };
                return await myQuery.ToListAsync();
            }
            else
            {
                var myQuery =
                    from bank in _banks//.Where(a => a.Status == "فعال")
                    select new ViewModelLoadAllBank()
                    {
                        BankId = bank.Id,
                        BankName = bank.Name,
                        BankDepartment = bank.Department,
                        BankCreationDate = bank.CreatedOn,
                        BankCreationUserName = bank.SelfUser.UserName,
                        BankUpdateByUserName = bank.UpdateUser.UserName,
                        BankLastUpdate = bank.LastUpdate,
                        BankStatus = bank.Status,
                        BankDescription = bank.Description
                    };
                return await myQuery.ToListAsync();
            }
        }

        public Task<IList<Bank>> SimpleLoadViewModelAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<CreateStatus> CreateAsync(Bank t)
        {
            try
            {
                if (await ExistAsync(t.Name))
                {
                    InsertLog(LogLevel.Warning, EntityName,
                        "CreateAsync", GetServiceName(), EntityNameNormal + "جدید تکراری می باشد");
                    return CreateStatus.Exist;
                }

                _banks.Add(t);
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

        public async Task UpdateAsync(Bank t)
        {
            _banks.AddOrUpdate(t);
            //_unitOfWork.MarkAsChanged(t);
            await _unitOfWork.SaveChangesAsync();
            InsertLog(LogLevel.Information, EntityName,
                "UpdateAsync", GetServiceName(), EntityNameNormal + $" جدید با نام {t.Name} با موفقیت ویرایش گردید.");
        }

        public async Task<Bank> GetByIdAsync(int id)
        {
            return await _banks.FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<Bank> GetByNameAsync(string name)
        {
            return await _banks.FirstOrDefaultAsync(b => b.Name == name);
        }

        public async Task<bool> ExistAsync(Bank t)
        {
            return await _banks.AnyAsync(b => b.Id == t.Id);
        }

        public async Task<bool> IsUsedAsync(Bank t)
        {
            return await _bankAccounts.AnyAsync(e => e.BankId == t.Id);
        }

        public async Task<bool> IsUsedAsync(int id)
        {
            return await _bankAccounts.AnyAsync(e => e.BankId == id);
        }

        public async Task<bool> ExistAsync(string name)
        {
            return await _banks.AnyAsync(b => b.Name == name);
        }

        public async Task<bool> ExistAsync(int id)
        {
            return await _banks.AnyAsync(b => b.Id == id);
        }

        public async Task<int> RemoveAsync(Bank t)
        {
            return await RemoveAsync(t.Id);
            //return await _banks.Where(b => b.Id == t.Id).DeleteAsync();
        }

        public async Task<int> RemoveAsync(int id)
        {
            var item = await _banks.FirstOrDefaultAsync(f => f.Id == id);
            _banks.Remove(item);
            var res = await _unitOfWork.SaveChangesAsync();

            InsertLog(LogLevel.Information, EntityName,
                "RemoveAsync", GetServiceName(), EntityNameNormal + $" با نام {item.Name} با موفقیت حذف گردید.");

            return res;
            //return await _banks.Where(b => b.Id == id).DeleteAsync();
        }

        public Task<IList<Bank>> SimpleLoadViewModelOnlyNoneUserAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IList<ViewModelLoadAllBank>> GetByGroupIdAsync(int groupId)
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