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
    public class MeasurementUnitService : BaseService, IMeasurementUnitService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDbSet<MeasurementUnit> _measurementUnits;
        private readonly IDbSet<Article> _articles;

        private const string EntityName = nameof(MeasurementUnit);
        private const string EntityNameNormal = "واحد سنجش";

        public MeasurementUnitService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _measurementUnits = _unitOfWork.Set<MeasurementUnit>();
            _articles = _unitOfWork.Set<Article>();
        }

        #region IMeasurementUnitService Members

        public async Task<int> CountAsync()
        {
            return await _measurementUnits.AsNoTracking().CountAsync();
        }

        public async Task<IList<MeasurementUnit>> LoadAllAsync(bool containActives = true)
        {
            if (!containActives)
                return await _measurementUnits.Where(a => a.Status != "فعال")
                    .AsNoTracking().OrderByDescending(a => a.Id).ToListAsync();
            return await _measurementUnits.AsNoTracking().ToListAsync();
        }

        public async Task<IList<ViewModelLoadAllMeasurementUnit>> LoadAllViewModelAsync(int? createdBy = null)
        {
            if (createdBy != null)
            {
                var myQuery =
                    from measurementUnit in _measurementUnits.Where(a => a.CreatedBy == createdBy)
                    select new ViewModelLoadAllMeasurementUnit()
                    {
                        MeasurementUnitId = measurementUnit.Id,
                        MeasurementUnitName = measurementUnit.Name,
                        MeasurementUnitCreationUserName = measurementUnit.SelfUser.UserName,
                        MeasurementUnitUpdateByUserName = measurementUnit.UpdateUser.UserName,
                        MeasurementUnitCreationDate = measurementUnit.CreatedOn,
                        MeasurementUnitLastUpdate = measurementUnit.LastUpdate
                    };
                return await myQuery.ToListAsync();
            }
            else
            {
                var myQuery =
                    from measurementUnit in _measurementUnits//.Where(a => a.Status == "فعال")
                    select new ViewModelLoadAllMeasurementUnit()
                    {
                        MeasurementUnitId = measurementUnit.Id,
                        MeasurementUnitName = measurementUnit.Name,
                        MeasurementUnitCreationUserName = measurementUnit.SelfUser.UserName,
                        MeasurementUnitUpdateByUserName = measurementUnit.UpdateUser.UserName,
                        MeasurementUnitCreationDate = measurementUnit.CreatedOn,
                        MeasurementUnitLastUpdate = measurementUnit.LastUpdate
                    };
                return await myQuery.ToListAsync();
            }

        }

        public async Task<IList<ViewModelSimpleLoadMeasurementUnit>> SimpleLoadViewModelAsync()
        {
            var myQuery =
                from measurementUnit in _measurementUnits//.Where(a => a.Status == "فعال")
                select new ViewModelSimpleLoadMeasurementUnit()
                {
                    MeasurementUnitId = measurementUnit.Id,
                    MeasurementUnitName = measurementUnit.Name
                };
            return await myQuery.ToListAsync();
        }

        //public async Task<IList<ViewModelSimpleLoadMeasurementUnit>> SimpleLoadViewModelByArticleIdAsync(int articleId)
        //{
        //    var myQuery = from measurementUnit in MeasurementUnits
        //        select new ViewModelSimpleLoadMeasurementUnit()
        //        {
        //            MeasurementUnitId = measurementUnit.Id,
        //            MeasurementUnitName = measurementUnit.Name
        //        };

        //    return await myQuery.ToListAsync();
        //}

        public async Task<CreateStatus> CreateAsync(MeasurementUnit measurementUnit)
        {
            try
            {
                if (await ExistAsync(measurementUnit.Name))
                {
                    InsertLog(LogLevel.Warning, EntityName,
                        "CreateAsync", GetServiceName(), EntityNameNormal + " جدید تکراری می باشد");
                    return CreateStatus.Exist;
                }

                _measurementUnits.Add(measurementUnit);
                await _unitOfWork.SaveChangesAsync();
                InsertLog(LogLevel.Information, EntityName,
                    "CreateAsync", GetServiceName(), EntityNameNormal + $" جدید با نام {measurementUnit.Name} با موفقیت ثبت گردید.");
                return CreateStatus.Successful;
            }
            catch (Exception exception)
            {
                InsertLog(LogLevel.Error, EntityName,
                    "CreateAsync", exception.Message, exception.ToDetailedString());
                return CreateStatus.Failure;
            }
        }

        public async Task UpdateAsync(MeasurementUnit measurementUnit)
        {
            _measurementUnits.AddOrUpdate(measurementUnit);
            //_unitOfWork.MarkAsChanged(measurementUnit);
            await _unitOfWork.SaveChangesAsync();
            InsertLog(LogLevel.Information, EntityName,
                "UpdateAsync", GetServiceName(), EntityNameNormal + $" جدید با نام {measurementUnit.Name} با موفقیت ویرایش گردید.");
        }

        public async Task<MeasurementUnit> GetByIdAsync(int measurementUnitId)
        {
            return await _measurementUnits
                .FirstOrDefaultAsync(mu => mu.Id == measurementUnitId);
        }

        public async Task<MeasurementUnit> GetByNameAsync(string measurementUnitName)
        {
            return await _measurementUnits
                .FirstOrDefaultAsync(mu => mu.Name == measurementUnitName);
        }

        public async Task AssignToArticleAsync(Article article, IList<string> measurementUnits)
        {
            await AssignToArticleAsync(article.Id, measurementUnits);
        }

        public async Task AssignToArticleAsync(string articleName, IList<string> measurementUnits)
        {
            var article = await _articles
                .FirstOrDefaultAsync(a => a.Name == articleName);

            if (article == null)
            {
                InsertLog(LogLevel.Error, EntityName, GetServiceName(),
                    "Assign measurement unit to article",
                    "کالایی با نام " + $" {articleName} " + " یافت نشد. ");
            }
            else
            {
                var selectedMeasurementUnits =
                    _measurementUnits.Where(mu => measurementUnits.Contains(mu.Name)).ToList();

                foreach (var mu in selectedMeasurementUnits.Where(mu =>
                    !article.MeasurementUnits.Contains(mu)))
                {
                    article.MeasurementUnits.Add(mu);
                    await _unitOfWork.SaveChangesAsync();
                    InsertLog(LogLevel.Information, EntityName,
                        GetServiceName(), "Assign measurement unit to article", EntityNameNormal +
                        $" جدید با نام {mu.Name} " +
                        " به کالای با شناسه " + $"{article.Id} " + " و نام " +
                        $"{article.Name} " +
                        "اضافه گردید.");
                }
            }
        }

        public async Task AssignToArticleAsync(int articleId, IList<string> measurementUnits)
        {
            var article = await _articles
                .FirstOrDefaultAsync(a => a.Id == articleId);

            if (article == null)
            {
                InsertLog(LogLevel.Error, EntityName, GetServiceName(),
                    "Assign measurement unit to article",
                    "کالایی با شناسه " + $" {articleId} " + " یافت نشد. ");
            }
            else
            {
                var selectedMeasurementUnits =
                    _measurementUnits.Where(mu => measurementUnits.Contains(mu.Name)).ToList();

                foreach (var mu in selectedMeasurementUnits.Where(mu => !article.MeasurementUnits.Contains(mu)))
                {
                    article.MeasurementUnits.Add(mu);
                    await _unitOfWork.SaveChangesAsync();

                    InsertLog(LogLevel.Information, EntityName,
                        "AssignToArticleAsync", GetServiceName(), EntityNameNormal +
                                                                  $" جدید با نام {mu.Name} " +
                                                                  " به کالای با شناسه " + $"{article.Id} " + " و نام " +
                                                                  $"{article.Name} " +
                                                                  "اضافه گردید.");
                }
            }
        }

        public async Task RemoveFromArticleAsync(string articleName)
        {
            var article = await _articles.Include(m => m.MeasurementUnits)
                .FirstOrDefaultAsync(a => a.Name == articleName);

            if (article == null)
            {
                InsertLog(LogLevel.Error, EntityName, GetServiceName(),
                    "Assign measurement unit to article",
                    "کالایی با نام " + $" {articleName} " + " یافت نشد. ");
            }

            else
            {
                article.MeasurementUnits.Clear();
            }
        }

        public async Task<IList<ViewModelSimpleLoadMeasurementUnit>> GetByArticleAsync(int articleId)
        {
            var article = await _articles.Include(m => m.MeasurementUnits)
                .FirstOrDefaultAsync(a => a.Id == articleId);

            var myQuery =
                from measurementUnit in article?.MeasurementUnits//.Where(mu => mu.Articles.Contains(article))
                select new ViewModelSimpleLoadMeasurementUnit()
                {
                    MeasurementUnitId = measurementUnit.Id,
                    MeasurementUnitName = measurementUnit.Name
                };
            return myQuery.ToList();
            //return article?.MeasurementUnits.Select(mus => mus.Name).ToList();
        }

        public async Task<IList<string>> GetByArticleAsync(string articleName)
        {
            var article = await _articles.Include(m => m.MeasurementUnits)
                .FirstOrDefaultAsync(a => a.Name == articleName);
            return article?.MeasurementUnits.Select(mus => mus.Name).ToList();
        }

        public IList<string> GetByArticle(Article article)
        {
            return article?.MeasurementUnits.Select(mus => mus.Name).ToList();
        }

        public async Task<bool> ExistAsync(MeasurementUnit measurementUnit)
        {
            return await _measurementUnits.AnyAsync(mu => mu.Name == measurementUnit.Name);
        }

        public async Task<bool> ExistAsync(string measurementUnitName)
        {
            return await _measurementUnits.AnyAsync(mu => mu.Name == measurementUnitName);
        }

        public async Task<bool> IsUsedAsync(MeasurementUnit measurementUnit)
        {
            return await IsUsedAsync(measurementUnit.Id);
        }

        public async Task<bool> IsUsedAsync(int measurementUnitId)
        {
            return await _articles.AnyAsync(e =>
                e.MeasurementUnits.Any(m =>
                    m.Id == measurementUnitId));
        }

        public async Task<int> RemoveAsync(MeasurementUnit measurementUnit)
        {
            return await RemoveAsync(measurementUnit.Id);
        }

        public async Task<int> RemoveAsync(int measurementUnitId)
        {
            var item = await
                _measurementUnits.FirstOrDefaultAsync(f => f.Id == measurementUnitId);

            _measurementUnits.Remove(item);
            var res = await _unitOfWork.SaveChangesAsync();

            if (!(item is null))
                InsertLog(LogLevel.Information, EntityName,
                    "RemoveAsync", GetServiceName(), EntityNameNormal + $" با نام {item.Name} با موفقیت حذف گردید.");

            return res;
        }


        #endregion

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