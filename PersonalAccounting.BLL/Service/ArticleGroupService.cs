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
    public class ArticleGroupService : BaseService,
        IRepositoryService<ArticleGroup, ViewModelLoadAllArticleGroup, ViewModelSimpleLoadArticleGroup>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDbSet<ArticleGroup> _articleGroups;
        private readonly IDbSet<Article> _articles;

        private const string EntityName = nameof(ArticleGroup);
        private const string EntityNameNormal = "دسته کالای";

        public ArticleGroupService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _articleGroups = _unitOfWork.Set<ArticleGroup>();
            _articles = _unitOfWork.Set<Article>();
        }

        public async Task<int> CountAsync()
        {
            return await _articleGroups.AsNoTracking().CountAsync<ArticleGroup>();
        }

        public async Task<IList<ArticleGroup>> LoadAllAsync(bool containActives = true)
        {
            if (!containActives)
                return await _articleGroups.Where(a => a.Status != "فعال")
                    .AsNoTracking().OrderByDescending(a => a.Id).ToListAsync();
            return await _articleGroups.AsNoTracking().OrderByDescending(a => a.Id).ToListAsync();
        }

        public async Task<IList<ViewModelLoadAllArticleGroup>> LoadAllViewModelAsync(int? createBy = null)
        {
            if (createBy != null)
            {
                var myQuery =
                    from articleGroup in _articleGroups.Where(ag => ag.CreatedBy == createBy)
                        //.Where(a=> a.Status == "فعال")
                    select new ViewModelLoadAllArticleGroup()
                    {
                        ArticleGroupId = articleGroup.Id,
                        ArticleGroupName = articleGroup.Name,
                        ArticleGroupLatinName = articleGroup.LatinName,
                        ArticleGroupCreationUserName = articleGroup.SelfUser.UserName,
                        ArticleGroupUpdateByUserName = articleGroup.UpdateUser.UserName,
                        ArticleGroupCreationDate = articleGroup.CreatedOn,
                        ArticleGroupLastUpdate = articleGroup.LastUpdate,
                        ArticleGroupStatus = articleGroup.Status,
                        ArticleGroupDescription = articleGroup.Description
                    };
                return await myQuery.ToListAsync();
            }
            else
            {
                var myQuery =
                    from articleGroup in _articleGroups
                        //.Where(a=> a.Status == "فعال")
                    select new ViewModelLoadAllArticleGroup()
                    {
                        ArticleGroupId = articleGroup.Id,
                        ArticleGroupName = articleGroup.Name,
                        ArticleGroupLatinName = articleGroup.LatinName,
                        ArticleGroupCreationUserName = articleGroup.SelfUser.UserName,
                        ArticleGroupUpdateByUserName = articleGroup.UpdateUser.UserName,
                        ArticleGroupCreationDate = articleGroup.CreatedOn,
                        ArticleGroupLastUpdate = articleGroup.LastUpdate,
                        ArticleGroupStatus = articleGroup.Status,
                        ArticleGroupDescription = articleGroup.Description
                    };
                return await myQuery.ToListAsync();
            }
        }

        public async Task<IList<ViewModelSimpleLoadArticleGroup>> SimpleLoadViewModelAsync()
        {
            var query =
                from articleGroup in _articleGroups//.Where(a => a.Status == "فعال")
                select new ViewModelSimpleLoadArticleGroup()
                {
                    ArticleGroupId = articleGroup.Id,
                    ArticleGroupName = articleGroup.Name
                };
            return await query.ToListAsync();
        }

        public async Task<CreateStatus> CreateAsync(ArticleGroup t)
        {
            try
            {
                if (await ExistAsync(t.Name))
                {
                    InsertLog(LogLevel.Warning, EntityName,
                        "CreateAsync", GetServiceName(), EntityNameNormal + " جدید تکراری می باشد");
                    return CreateStatus.Exist;
                }

                _articleGroups.Add(t);
                await _unitOfWork.SaveChangesAsync();
                InsertLog(LogLevel.Information, EntityName,
                    "CreateAsync", GetServiceName(), EntityNameNormal + $" جدید با نام {t.Name} با موفقیت ثبت گردید.");
                return CreateStatus.Successful;
            }
            catch (Exception exception)
            {
                // add logger
                InsertLog(LogLevel.Error, EntityName,
                    "CreateAsync", exception.Message, exception.ToDetailedString());
                return CreateStatus.Failure;
            }
        }

        public async Task UpdateAsync(ArticleGroup t)
        {
            _articleGroups.AddOrUpdate(t);
            //_unitOfWork.MarkAsChanged(t);
            await _unitOfWork.SaveChangesAsync();
            InsertLog(LogLevel.Information, EntityName,
                "UpdateAsync", GetServiceName(), EntityNameNormal + $" جدید با نام {t.Name} با موفقیت ویرایش گردید.");
        }

        public async Task<ArticleGroup> GetByIdAsync(int id)
        {
            return await _articleGroups.FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<ArticleGroup> GetByNameAsync(string name)
        {
            return await _articleGroups.FirstOrDefaultAsync(b => b.Name == name);
        }

        public async Task<bool> ExistAsync(ArticleGroup t)
        {
            return await _articleGroups.AnyAsync(b => b.Id == t.Id);
        }

        public async Task<bool> IsUsedAsync(ArticleGroup t)
        {
            return await _articles.AnyAsync(e => e.GroupId == t.Id);
        }

        public async Task<bool> IsUsedAsync(int id)
        {
            return await _articles.AnyAsync(e => e.GroupId == id);
        }

        public async Task<bool> ExistAsync(string name)
        {
            return await _articleGroups.AnyAsync(b => b.Name == name);
        }

        public async Task<bool> ExistAsync(int id)
        {
            return await _articleGroups.AnyAsync(b => b.Id == id);
        }

        public async Task<int> RemoveAsync(ArticleGroup t)
        {
            return await RemoveAsync(t.Id);
            //return await _articleGroups.Where(b => b.Id == t.Id).DeleteAsync();
        }

        public async Task<int> RemoveAsync(int id)
        {
            var item = await _articleGroups.FirstOrDefaultAsync(f => f.Id == id);
            _articleGroups.Remove(item);
            var res = await _unitOfWork.SaveChangesAsync();

            InsertLog(LogLevel.Information, EntityName,
                "RemoveAsync", GetServiceName(), EntityNameNormal + $" با نام {item.Name} با موفقیت حذف گردید.");
            return res;

            //return await _articleGroups.Where(b => b.Id == id).DeleteAsync();
        }

        public Task<IList<ViewModelSimpleLoadArticleGroup>> SimpleLoadViewModelOnlyNoneUserAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IList<ViewModelLoadAllArticleGroup>> GetByGroupIdAsync(int groupId)
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