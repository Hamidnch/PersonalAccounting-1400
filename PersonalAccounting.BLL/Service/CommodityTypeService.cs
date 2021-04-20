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
    public class CommodityTypeService : BaseService, IRepositoryService<CommodityType, ViewModelLoadAllCommodityType, CommodityType>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDbSet<CommodityType> _commodityTypes;
        private readonly IDbSet<Commodity> _commodities;

        private const string EntityName = nameof(CommodityType);
        private const string EntityNameNormal = "نوع کالای دریافتی";
        public CommodityTypeService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _commodityTypes = _unitOfWork.Set<CommodityType>();
            _commodities = _unitOfWork.Set<Commodity>();
        }

        public async Task<int> CountAsync()
        {
            return await _commodityTypes.AsNoTracking().CountAsync();
        }

        public async Task<IList<CommodityType>> LoadAllAsync(bool containActives = true)
        {
            if (!containActives)
                return await _commodityTypes.Where(a => a.Status != "فعال")
                    .AsNoTracking().OrderByDescending(a => a.Id).ToListAsync();
            return await _commodityTypes.AsNoTracking().ToListAsync();
        }

        public async Task<IList<ViewModelLoadAllCommodityType>> LoadAllViewModelAsync(int? createBy = null)
        {
            if (createBy != null)
            {
                var myQuery =
                    from commodityType in _commodityTypes.Where(i => i.CreatedBy == createBy)

                    select new ViewModelLoadAllCommodityType()
                    {
                        CommodityTypeId = commodityType.Id,
                        CommodityTypeTitle = commodityType.Title,
                        CommodityTypeCreationUserName = commodityType.SelfUser.UserName,
                        CommodityTypeUpdateByUserName = commodityType.UpdateUser.UserName,
                        CommodityTypeCreationDate = commodityType.CreatedOn,
                        CommodityTypeLastUpdate = commodityType.LastUpdate
                    };
                return await myQuery.ToListAsync();
            }
            else
            {
                var myQuery =
                    from commodityType in _commodityTypes//.Where(i=> i.Status == "فعال")

                    select new ViewModelLoadAllCommodityType()
                    {
                        CommodityTypeId = commodityType.Id,
                        CommodityTypeTitle = commodityType.Title,
                        CommodityTypeCreationUserName = commodityType.SelfUser.UserName,
                        CommodityTypeUpdateByUserName = commodityType.UpdateUser.UserName,
                        CommodityTypeCreationDate = commodityType.CreatedOn,
                        CommodityTypeLastUpdate = commodityType.LastUpdate
                    };
                return await myQuery.ToListAsync();
            }

        }

        public Task<IList<CommodityType>> SimpleLoadViewModelAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<CreateStatus> CreateAsync(CommodityType t)
        {
            try
            {
                if (await ExistAsync(t))
                {
                    InsertLog(LogLevel.Warning, EntityName,
                        "CreateAsync", GetServiceName(), EntityNameNormal + " جدید تکراری می باشد");
                    return CreateStatus.Exist;
                }

                _commodityTypes.Add(t);
                await _unitOfWork.SaveChangesAsync();
                InsertLog(LogLevel.Information, EntityName,
                    "CreateAsync", GetServiceName(), EntityNameNormal + $" جدید با نام با موفقیت ثبت گردید.");
                return CreateStatus.Successful;
            }
            catch (Exception exception)
            {
                InsertLog(LogLevel.Error, EntityName,
                    "CreateAsync", exception.Message, exception.ToDetailedString());
                return CreateStatus.Failure;
            }
        }

        public async Task UpdateAsync(CommodityType t)
        {
            _commodityTypes.AddOrUpdate(t);
            //_unitOfWork.MarkAsChanged(t);
            await _unitOfWork.SaveChangesAsync();
            InsertLog(LogLevel.Information, EntityName,
                "UpdateAsync", GetServiceName(), EntityNameNormal + $" جدید با نام با موفقیت ویرایش گردید.");
        }

        public async Task<CommodityType> GetByIdAsync(int id)
        {
            return await _commodityTypes.FirstOrDefaultAsync(i => i.Id == id);
        }

        public async Task<CommodityType> GetByNameAsync(string name)
        {
            return await _commodityTypes.FirstOrDefaultAsync(b => b.Title == name);
        }

        public async Task<bool> ExistAsync(CommodityType t)
        {
            return await _commodityTypes.AnyAsync(f => f.Title == t.Title);
        }

        public async Task<bool> IsUsedAsync(CommodityType t)
        {
            return await IsUsedAsync(t.Id);
        }

        public async Task<bool> IsUsedAsync(int id)
        {
            return await _commodities.AnyAsync(e => e.CommodityTypeId == id);
        }

        public async Task<bool> ExistAsync(string name)
        {
            return await _commodityTypes.AnyAsync(f => f.Title == name);
        }

        public async Task<bool> ExistAsync(int id)
        {
            return await _commodityTypes.AnyAsync(f => f.Id == id);
        }

        public async Task<int> RemoveAsync(CommodityType t)
        {
            return await RemoveAsync(t.Id);
        }

        public async Task<int> RemoveAsync(int id)
        {
            var item = await _commodityTypes.FirstOrDefaultAsync(f => f.Id == id);
            _commodityTypes.Remove(item);
            var res = await _unitOfWork.SaveChangesAsync();

            InsertLog(LogLevel.Information, EntityName,
                "RemoveAsync", GetServiceName(), EntityNameNormal + $" با نام با موفقیت حذف گردید.");

            return res;
        }

        public Task<IList<CommodityType>> SimpleLoadViewModelOnlyNoneUserAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IList<ViewModelLoadAllCommodityType>> GetByGroupIdAsync(int groupId)
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