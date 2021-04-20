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
    public class IncomeTypeService : BaseService, IRepositoryService<IncomeType, ViewModelLoadAllIncomeType, IncomeType>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDbSet<IncomeType> _incomeTypes;
        private readonly IDbSet<Income> _incomes;

        private const string EntityName = nameof(IncomeType);
        private const string EntityNameNormal = "نوع درآمد";

        public IncomeTypeService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _incomeTypes = _unitOfWork.Set<IncomeType>();
            _incomes = _unitOfWork.Set<Income>();
        }

        public async Task<int> CountAsync()
        {
            return await _incomeTypes.AsNoTracking().CountAsync();
        }

        public async Task<IList<IncomeType>> LoadAllAsync(bool containActives = true)
        {
            if (!containActives)
                return await _incomeTypes.Where(a => a.Status != "فعال")
                    .AsNoTracking().OrderByDescending(a => a.Id).ToListAsync();
            return await _incomeTypes.AsNoTracking().ToListAsync();
        }

        public async Task<IList<ViewModelLoadAllIncomeType>> LoadAllViewModelAsync(int? createBy = null)
        {
            if (createBy != null)
            {
                var myQuery =
                    from incomeType in _incomeTypes.Where(i => i.CreatedBy == createBy)

                    select new ViewModelLoadAllIncomeType()
                    {
                        IncomeTypeId = incomeType.Id,
                        IncomeTypeTitle = incomeType.Title,
                        IncomeTypeCreationUserName = incomeType.SelfUser.UserName,
                        IncomeTypeUpdateByUserName = incomeType.UpdateUser.UserName,
                        IncomeTypeCreationDate = incomeType.CreatedOn,
                        IncomeTypeLastUpdate = incomeType.LastUpdate
                    };
                return await myQuery.ToListAsync();
            }
            else
            {
                var myQuery =
                    from incomeType in _incomeTypes//.Where(i=> i.Status == "فعال")

                    select new ViewModelLoadAllIncomeType()
                    {
                        IncomeTypeId = incomeType.Id,
                        IncomeTypeTitle = incomeType.Title,
                        IncomeTypeCreationUserName = incomeType.SelfUser.UserName,
                        IncomeTypeUpdateByUserName = incomeType.UpdateUser.UserName,
                        IncomeTypeCreationDate = incomeType.CreatedOn,
                        IncomeTypeLastUpdate = incomeType.LastUpdate
                    };
                return await myQuery.ToListAsync();
            }

        }

        public Task<IList<IncomeType>> SimpleLoadViewModelAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<CreateStatus> CreateAsync(IncomeType t)
        {
            try
            {
                if (await ExistAsync(t.Title))
                {
                    InsertLog(LogLevel.Warning, EntityName,
                        "CreateAsync", GetServiceName(), EntityNameNormal + " جدید تکراری می باشد");
                    return CreateStatus.Exist;
                }

                _incomeTypes.Add(t);
                await _unitOfWork.SaveChangesAsync();
                InsertLog(LogLevel.Information, EntityName,
                    "CreateAsync", GetServiceName(), EntityNameNormal + $" جدید با نام {t.Title} با موفقیت ثبت گردید.");
                return CreateStatus.Successful;
            }
            catch (Exception exception)
            {
                InsertLog(LogLevel.Error, EntityName,
                    "CreateAsync", exception.Message, exception.ToDetailedString());
                return CreateStatus.Failure;
            }
        }

        public async Task UpdateAsync(IncomeType t)
        {
            _incomeTypes.AddOrUpdate(t);
            //_unitOfWork.MarkAsChanged(t);
            await _unitOfWork.SaveChangesAsync();
            InsertLog(LogLevel.Information, EntityName,
                "UpdateAsync", GetServiceName(), EntityNameNormal + $" جدید با نام {t.Title} با موفقیت ویرایش گردید.");
        }

        public async Task<IncomeType> GetByIdAsync(int id)
        {
            return await _incomeTypes.FirstOrDefaultAsync(i => i.Id == id);
        }

        public async Task<IncomeType> GetByNameAsync(string name)
        {
            return await _incomeTypes.FirstOrDefaultAsync(b => b.Title == name);
        }

        public async Task<bool> ExistAsync(IncomeType t)
        {
            return await _incomeTypes.AnyAsync(f => f.Title == t.Title);
        }

        public async Task<bool> IsUsedAsync(IncomeType t)
        {
            return await IsUsedAsync(t.Id);
        }

        public async Task<bool> IsUsedAsync(int id)
        {
            return await _incomes.AnyAsync(e => e.TypeId == id);
        }

        public async Task<bool> ExistAsync(string name)
        {
            return await _incomeTypes.AnyAsync(f => f.Title == name);
        }

        public async Task<bool> ExistAsync(int id)
        {
            return await _incomeTypes.AnyAsync(f => f.Id == id);
        }

        public async Task<int> RemoveAsync(IncomeType t)
        {
            return await RemoveAsync(t.Id);
        }

        public async Task<int> RemoveAsync(int id)
        {
            var item = await _incomeTypes.FirstOrDefaultAsync(f => f.Id == id);
            _incomeTypes.Remove(item);
            var res = await _unitOfWork.SaveChangesAsync();

            InsertLog(LogLevel.Information, EntityName,
                "RemoveAsync", GetServiceName(), EntityNameNormal + $" با نام {item.Title} با موفقیت حذف گردید.");

            return res;
        }

        public Task<IList<IncomeType>> SimpleLoadViewModelOnlyNoneUserAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IList<ViewModelLoadAllIncomeType>> GetByGroupIdAsync(int groupId)
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