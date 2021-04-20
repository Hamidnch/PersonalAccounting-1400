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
    public class MentalConditionService : BaseService,
        IRepositoryService<MentalCondition, ViewModelLoadAllMentalCondition, ViewModelSimpleLoadMentalCondition>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDbSet<MentalCondition> _mentalConditions;
        private readonly IDbSet<DiaryNote> _diaryNotes;

        private const string EntityName = nameof(MentalCondition);
        private const string EntityNameNormal = "شرایط روحی و روانی";

        public MentalConditionService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mentalConditions = _unitOfWork.Set<MentalCondition>();
            _diaryNotes = _unitOfWork.Set<DiaryNote>();
        }

        public async Task<int> CountAsync()
        {
            return await _mentalConditions.AsNoTracking().CountAsync();
        }
        public async Task<IList<MentalCondition>> LoadAllAsync(bool containActives = true)
        {
            if (!containActives)
                return await _mentalConditions.Where(a => a.Status != "فعال")
                    .AsNoTracking().OrderByDescending(a => a.Id).ToListAsync();
            return await _mentalConditions.AsNoTracking().ToListAsync();
        }

        public async Task<IList<ViewModelLoadAllMentalCondition>> LoadAllViewModelAsync(int? createdBy = null)
        {
            if (createdBy != null)
            {
                var myQuery =
                    from mentalCondition in _mentalConditions.Where(a => a.CreatedBy == createdBy)
                    select new ViewModelLoadAllMentalCondition()
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
                    from mentalCondition in _mentalConditions//.Where(a => a.Status == "فعال")
                    select new ViewModelLoadAllMentalCondition()
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

        public async Task<IList<ViewModelSimpleLoadMentalCondition>> SimpleLoadViewModelAsync()
        {
            var myQuery =
                from mentalCondition in _mentalConditions//.Where(a => a.Status == "فعال")
                select new ViewModelSimpleLoadMentalCondition()
                {
                    Id = mentalCondition.Id,
                    Title = mentalCondition.Title,
                    Picture = mentalCondition.Picture

                };
            return await myQuery.ToListAsync();
        }

        public async Task<CreateStatus> CreateAsync(MentalCondition t)
        {
            try
            {
                if (await ExistAsync(t.Title))
                {
                    InsertLog(LogLevel.Warning, EntityName,
                        "CreateAsync", GetServiceName(), EntityNameNormal + " جدید تکراری می باشد");
                    return CreateStatus.Exist;
                }

                _mentalConditions.Add(t);
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

        public async Task UpdateAsync(MentalCondition t)
        {
            _mentalConditions.AddOrUpdate(t);
            //_unitOfWork.MarkAsChanged(t);
            await _unitOfWork.SaveChangesAsync();
            InsertLog(LogLevel.Information, EntityName,
                "UpdateAsync", GetServiceName(), EntityNameNormal + $" جدید با نام {t.Title} با موفقیت ویرایش گردید.");
        }

        public async Task<MentalCondition> GetByIdAsync(int id)
        {
            return await _mentalConditions.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<MentalCondition> GetByNameAsync(string name)
        {
            return await _mentalConditions.FirstOrDefaultAsync(b => b.Title == name);
        }

        public async Task<bool> ExistAsync(MentalCondition t)
        {
            return await _mentalConditions.AnyAsync(p => p.Id == t.Id && p.Title == t.Title);
        }

        public async Task<bool> IsUsedAsync(MentalCondition t)
        {
            return await IsUsedAsync(t.Id);
        }

        public async Task<bool> IsUsedAsync(int id)
        {
            return await _diaryNotes.AnyAsync(e => e.MentalConditionId == id);
        }

        public async Task<bool> ExistAsync(string name)
        {
            return await _mentalConditions.AnyAsync(p => p.Title == name);
        }

        public async Task<bool> ExistAsync(int id)
        {
            return await _mentalConditions.AnyAsync(p => p.Id == id);
        }

        public async Task<int> RemoveAsync(MentalCondition t)
        {
            return await RemoveAsync(t.Id);
        }

        public async Task<int> RemoveAsync(int id)
        {
            var item = await _mentalConditions.FirstOrDefaultAsync(f => f.Id == id);
            _mentalConditions.Remove(item);

            var res = await _unitOfWork.SaveChangesAsync();

            InsertLog(LogLevel.Information, EntityName,
                "RemoveAsync", GetServiceName(), EntityNameNormal + $" با نام {item.Title} با موفقیت حذف گردید.");

            return res;
        }

        public Task<IList<ViewModelSimpleLoadMentalCondition>> SimpleLoadViewModelOnlyNoneUserAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IList<ViewModelLoadAllMentalCondition>> GetByGroupIdAsync(int groupId)
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
