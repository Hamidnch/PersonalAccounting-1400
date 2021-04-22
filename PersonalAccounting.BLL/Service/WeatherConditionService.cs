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
    public class WeatherConditionService : BaseService,
        IRepositoryService<WeatherCondition, ViewModelLoadAllWeatherCondition, ViewModelSimpleLoadWeatherCondition>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDbSet<WeatherCondition> _weatherConditions;
        private readonly IDbSet<DiaryNote> _diaryNotes;

        private const string EntityName = nameof(WeatherCondition);
        private const string EntityNameNormal = "شرایط آب و هوا";

        public WeatherConditionService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _weatherConditions = _unitOfWork.Set<WeatherCondition>();
            _diaryNotes = _unitOfWork.Set<DiaryNote>();
        }

        public async Task<int> CountAsync()
        {
            return await _weatherConditions.AsNoTracking().CountAsync();
        }
        public async Task<IList<WeatherCondition>> LoadAllAsync(bool containActives = true)
        {
            if (!containActives)
                return await _weatherConditions.Where(a => a.Status != "فعال")
                    .AsNoTracking().OrderByDescending(a => a.Id).ToListAsync();
            return await _weatherConditions.AsNoTracking().ToListAsync();
        }

        public async Task<IList<ViewModelLoadAllWeatherCondition>> LoadAllViewModelAsync(int? createdBy = null)
        {
            if (createdBy != null)
            {
                var myQuery =
                    from mentalCondition in _weatherConditions.Where(a => a.CreatedBy == createdBy)
                    select new ViewModelLoadAllWeatherCondition()
                    {
                        Id = mentalCondition.Id,
                        Title = mentalCondition.Title,
                        Picture = mentalCondition.Picture,
                        LastUpdate = mentalCondition.LastUpdate,
                        CreationDate = mentalCondition.CreatedOn,
                        CreationUser = mentalCondition.SelfUser.UserName,
                        UpdateByUser = mentalCondition.UpdateUser.UserName,
                        Description = mentalCondition.Description,
                        Status = mentalCondition.Status
                    };
                return await myQuery.ToListAsync();
            }
            else
            {
                var myQuery =
                    from mentalCondition in _weatherConditions //.Where(a => a.Status == "فعال")
                    select new ViewModelLoadAllWeatherCondition()
                    {
                        Id = mentalCondition.Id,
                        Title = mentalCondition.Title,
                        Picture = mentalCondition.Picture,
                        LastUpdate = mentalCondition.LastUpdate,
                        CreationDate = mentalCondition.CreatedOn,
                        CreationUser = mentalCondition.SelfUser.UserName,
                        UpdateByUser = mentalCondition.UpdateUser.UserName,
                        Description = mentalCondition.Description,
                        Status = mentalCondition.Status
                    };
                return await myQuery.ToListAsync();
            }
        }

        public async Task<IList<ViewModelSimpleLoadWeatherCondition>> SimpleLoadViewModelAsync()
        {
            var myQuery =
                from mentalCondition in _weatherConditions//.Where(a => a.Status == "فعال")
                select new ViewModelSimpleLoadWeatherCondition()
                {
                    Id = mentalCondition.Id,
                    Title = mentalCondition.Title,
                    Picture = mentalCondition.Picture

                };
            return await myQuery.ToListAsync();
        }

        public async Task<CreateStatus> CreateAsync(WeatherCondition t)
        {
            try
            {
                if (await ExistAsync(t.Title))
                {
                    InsertLog(LogLevel.Warning, EntityName,
                        "CreateAsync", GetServiceName(), EntityNameNormal + " جدید تکراری می باشد");
                    return CreateStatus.Exist;
                }

                _weatherConditions.Add(t);
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

        public async Task UpdateAsync(WeatherCondition t)
        {
            _weatherConditions.AddOrUpdate(t);
            //_unitOfWork.MarkAsChanged(t);
            await _unitOfWork.SaveChangesAsync();
            InsertLog(LogLevel.Information, EntityName,
                "UpdateAsync", GetServiceName(), EntityNameNormal + $" جدید با نام {t.Title} با موفقیت ویرایش گردید.");
        }

        public async Task<WeatherCondition> GetByIdAsync(int id)
        {
            return await _weatherConditions.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<WeatherCondition> GetByNameAsync(string name)
        {
            return await _weatherConditions.FirstOrDefaultAsync(b => b.Title == name);
        }

        public async Task<bool> ExistAsync(WeatherCondition t)
        {
            return await _weatherConditions.AnyAsync(p => p.Id == t.Id && p.Title == t.Title);
        }

        public async Task<bool> IsUsedAsync(WeatherCondition t)
        {
            return await IsUsedAsync(t.Id);
        }

        public async Task<bool> IsUsedAsync(int id)
        {
            return await _diaryNotes.AnyAsync(e => e.WeatherConditionId == id);
        }

        public async Task<bool> ExistAsync(string name)
        {
            return await _weatherConditions.AnyAsync(p => p.Title == name);
        }

        public async Task<bool> ExistAsync(int id)
        {
            return await _weatherConditions.AnyAsync(p => p.Id == id);
        }

        public async Task<int> RemoveAsync(WeatherCondition t)
        {
            return await RemoveAsync(t.Id);
            //return await _weatherConditions.Where(f => f.Title == t.Title).DeleteAsync();
        }

        public async Task<int> RemoveAsync(int id)
        {
            var item = await
                _weatherConditions.FirstOrDefaultAsync(f => f.Id == id);
            _weatherConditions.Remove(item);
            var res = await _unitOfWork.SaveChangesAsync();

            if (!(item is null))
                InsertLog(LogLevel.Information, EntityName,
                    "RemoveAsync", GetServiceName(), EntityNameNormal + $" با نام {item.Title} با موفقیت حذف گردید.");

            return res;
        }

        public Task<IList<ViewModelSimpleLoadWeatherCondition>> SimpleLoadViewModelOnlyNoneUserAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IList<ViewModelLoadAllWeatherCondition>> GetByGroupIdAsync(int groupId)
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
