using PersonalAccounting.BLL.Enum;
using PersonalAccounting.BLL.IService;
using PersonalAccounting.CommonLibrary.Helper;
using PersonalAccounting.DAL.Infrastructure;
using PersonalAccounting.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Threading.Tasks;

namespace PersonalAccounting.BLL.Service
{
    public class FormEntityService : BaseService, IFormEntityService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDbSet<FormEntity> _formEntities;

        private const string EntityName = nameof(FormEntity);
        private const string EntityNameNormal = "فرم";

        public FormEntityService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _formEntities = _unitOfWork.Set<FormEntity>();
        }

        public async Task<int> CountAsync()
        {
            return await _formEntities.AsNoTracking().CountAsync<FormEntity>();
        }

        public async Task<IList<FormEntity>> LoadAllFormEntitiesAsync()
        {
            return await _formEntities.AsNoTracking().ToListAsync();
        }

        public async Task<CreateStatus> CreateAsync(FormEntity formEntity)
        {
            try
            {
                if (await ExistAsync(formEntity.Name))
                {
                    InsertLog(LogLevel.Warning, EntityName,
                        "CreateAsync", GetServiceName(), EntityNameNormal + " جدید تکراری می باشد");
                    return CreateStatus.Exist;
                }

                _formEntities.Add(formEntity);
                await _unitOfWork.SaveChangesAsync();
                InsertLog(LogLevel.Information, EntityName,
                    "CreateAsync", GetServiceName(), EntityNameNormal + $" جدید با نام {formEntity.Name} با موفقیت ثبت گردید.");
                return CreateStatus.Successful;
            }
            catch (Exception exception)
            {
                InsertLog(LogLevel.Error, EntityName,
                    "CreateAsync", exception.Message, exception.ToDetailedString());
                return CreateStatus.Failure;
            }
        }

        public async Task UpdateAsync(FormEntity formEntity)
        {
            _formEntities.AddOrUpdate(formEntity);
            //_unitOfWork.MarkAsChanged(formEntity);
            await _unitOfWork.SaveChangesAsync();
            InsertLog(LogLevel.Information, EntityName,
                "UpdateAsync", GetServiceName(), EntityNameNormal + $" جدید با نام {formEntity.Name} با موفقیت ویرایش گردید.");
        }

        public async Task<FormEntity> GetByIdAsync(int id)
        {
            return await _formEntities.FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<FormEntity> GetByNameAsync(string name)
        {
            return await _formEntities.FirstOrDefaultAsync(b => b.Name == name);
        }

        public async Task<bool> ExistAsync(FormEntity formEntity)
        {
            return await _formEntities.AnyAsync(b => b.Id == formEntity.Id
                                                    && b.Name == formEntity.Name && b.SystemName == formEntity.SystemName);
        }

        public async Task<bool> ExistAsync(string name)
        {
            return await _formEntities.AnyAsync(b => b.Name == name || b.SystemName == name);
        }

        public async Task<bool> ExistAsync(int id)
        {
            return await _formEntities.AnyAsync(b => b.Id == id);
        }

        public async Task<int> RemoveAsync(FormEntity formEntity)
        {
            return await RemoveAsync(formEntity.Id);
            //return await _formEntities.Where(b => b.Id == formEntity.Id).DeleteAsync();
        }

        public async Task<int> RemoveAsync(int id)
        {
            var item = await _formEntities.FirstOrDefaultAsync(f => f.Id == id);
            _formEntities.Remove(item);
            var res = await _unitOfWork.SaveChangesAsync();

            if (!(item is null))
                InsertLog(LogLevel.Information, EntityName,
                    "RemoveAsync", GetServiceName(), EntityNameNormal + $" با نام {item.Name} با موفقیت حذف گردید.");

            return res;
            //return await _formEntities.Where(b => b.Id == id).DeleteAsync();
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
