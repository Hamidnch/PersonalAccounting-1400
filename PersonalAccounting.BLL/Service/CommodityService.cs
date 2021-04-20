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
    public class CommodityService : BaseService, IRepositoryService<Commodity, ViewModelLoadAllCommodity, Commodity>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDbSet<Commodity> _commodities;

        private const string EntityName = nameof(Commodity);
        private const string EntityNameNormal = "کالای دریافتی";
        public CommodityService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _commodities = _unitOfWork.Set<Commodity>();
        }

        public async Task<int> CountAsync()
        {
            return await _commodities.AsNoTracking().CountAsync();
        }

        public async Task<IList<Commodity>> LoadAllAsync(bool containActives = true)
        {
            if (!containActives)
                return await _commodities.Where(a => a.Status != "فعال")
                    .AsNoTracking().OrderByDescending(a => a.Id).ToListAsync();
            return await _commodities.AsNoTracking().ToListAsync();
        }

        public async Task<IList<ViewModelLoadAllCommodity>> LoadAllViewModelAsync(int? createBy = null)
        {
            if (createBy != null)
            {
                var myQuery =
                    from commodity in _commodities.Where(a => a.CreatedBy == createBy)
                    select new ViewModelLoadAllCommodity()
                    {
                        CommodityId = commodity.Id,
                        ReceiverId = commodity.ReceiverId,
                        ReceiverName = commodity.Person.FullName,
                        ReceivedBy = commodity.ReceivedBy,
                        CommodityTypeId = commodity.CommodityTypeId,
                        CommodityTypeTitle = commodity.CommodityType.Title,
                        CommodityDate = commodity.CommodityDate,
                        CommodityCreationDate = commodity.CreatedOn,
                        CommodityLastUpdate = commodity.LastUpdate,
                        CommodityCreationUserName = commodity.SelfUser.UserName,
                        CommodityUpdateByUserName = commodity.UpdateUser.UserName,
                        Description = commodity.Description
                    };
                return await myQuery.ToListAsync();
            }
            else
            {
                var myQuery =
                    from commodity in _commodities//.Where(a => a.Status == "فعال")
                    select new ViewModelLoadAllCommodity()
                    {
                        CommodityId = commodity.Id,
                        ReceiverId = commodity.ReceiverId,
                        ReceiverName = commodity.Person.FullName,
                        ReceivedBy = commodity.ReceivedBy,
                        CommodityTypeId = commodity.CommodityTypeId,
                        CommodityTypeTitle = commodity.CommodityType.Title,
                        CommodityDate = commodity.CommodityDate,
                        CommodityCreationDate = commodity.CreatedOn,
                        CommodityLastUpdate = commodity.LastUpdate,
                        CommodityCreationUserName = commodity.SelfUser.UserName,
                        CommodityUpdateByUserName = commodity.UpdateUser.UserName,
                        Description = commodity.Description
                    };
                return await myQuery.ToListAsync();
            }
        }

        public Task<IList<Commodity>> SimpleLoadViewModelAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<CreateStatus> CreateAsync(Commodity t)
        {
            try
            {
                if (await ExistAsync(t))
                {
                    InsertLog(LogLevel.Warning, EntityName,
                        "CreateAsync", GetServiceName(), EntityNameNormal + " جدید تکراری می باشد");
                    return CreateStatus.Exist;
                }

                _commodities.Add(t);
                await _unitOfWork.SaveChangesAsync();
                InsertLog(LogLevel.Information, EntityName,
                    "CreateAsync", GetServiceName(), EntityNameNormal + $" جدید با موفقیت ثبت گردید.");
                return CreateStatus.Successful;
            }
            catch (Exception exception)
            {
                InsertLog(LogLevel.Error, EntityName,
                    "CreateAsync", exception.Message, exception.ToDetailedString());
                //PublicError.Error = ex.ExceptionToString();
                return CreateStatus.Failure;
            }
        }

        public async Task UpdateAsync(Commodity t)
        {
            _commodities.AddOrUpdate(t);
            //_unitOfWork.MarkAsChanged(t);
            await _unitOfWork.SaveChangesAsync();
            InsertLog(LogLevel.Information, EntityName,
                "UpdateAsync", GetServiceName(), EntityNameNormal + $" جدید با موفقیت ویرایش گردید.");
        }

        public async Task<Commodity> GetByIdAsync(int id)
        {
            return await _commodities.FirstOrDefaultAsync(i => i.Id == id);
        }
        public Task<Commodity> GetByNameAsync(string name)
        {
            throw new NotImplementedException();
        }


        public async Task<bool> ExistAsync(Commodity t)
        {
            return await _commodities.AnyAsync(i => i.CommodityDate == t.CommodityDate &&
                                                       t.ReceiverId == i.ReceiverId && t.ReceivedBy == i.ReceivedBy &&
                                                       i.CommodityTypeId == t.CommodityTypeId);
        }

        public Task<bool> IsUsedAsync(Commodity t)
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
            return await _commodities.AnyAsync(i => i.Id == id);
        }

        public async Task<int> RemoveAsync(Commodity t)
        {
            return await RemoveAsync(t.Id);
            //return await _incomes.Where(i => i.Id == t.Id).DeleteAsync();
        }

        public async Task<int> RemoveAsync(int id)
        {
            var item = await _commodities.FirstOrDefaultAsync(f => f.Id == id);
            _commodities.Remove(item);
            var res = await _unitOfWork.SaveChangesAsync();

            InsertLog(LogLevel.Information, EntityName,
                "RemoveAsync", GetServiceName(), EntityNameNormal + $" با نام با موفقیت حذف گردید.");

            return res;
            //return await _incomes.Where(i => i.Id == id).DeleteAsync();
        }

        public Task<IList<Commodity>> SimpleLoadViewModelOnlyNoneUserAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IList<ViewModelLoadAllCommodity>> GetByGroupIdAsync(int groupId)
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