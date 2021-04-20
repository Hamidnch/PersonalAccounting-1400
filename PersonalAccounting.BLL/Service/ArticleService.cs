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
    public class ArticleService : BaseService,
        IRepositoryService<Article, ViewModelLoadAllArticle, ViewModelSimpleLoadArticle>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDbSet<Article> _articles;
        private readonly IDbSet<Expense> _expenses;

        private const string EntityName = nameof(Article);
        private const string EntityNameNormal = "کالای";

        public ArticleService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _articles = unitOfWork.Set<Article>();
            _expenses = _unitOfWork.Set<Expense>();
        }

        public async Task<int> CountAsync()
        {
            return await _articles.AsNoTracking().CountAsync<Article>();
        }

        public async Task<IList<Article>> LoadAllAsync(bool containActives = true)
        {
            if (!containActives)
                return await _articles.AsNoTracking()
                    .Where(a => a.Status == "فعال").OrderByDescending(a => a.Id).ToListAsync();
            return await _articles.AsNoTracking().OrderByDescending(a => a.Id).ToListAsync();
        }

        public async Task<IList<ViewModelLoadAllArticle>> LoadAllViewModelAsync(int? createBy = null)
        {
            if (createBy != null)
            {
                var myQuery =
                    from article in _articles.Where(a => a.CreatedBy == createBy)
                    select new ViewModelLoadAllArticle()
                    {
                        ArticleId = article.Id,
                        ArticleName = article.Name,
                        ArticleGroupName = article.ArticleGroup.Name,
                        ArticleLatinName = article.LatinName,
                        ArticleCreationDate = article.CreatedOn,
                        ArticleCreationUserName = article.SelfUser.UserName,
                        ArticleUpdateByUserName = article.UpdateUser.UserName,
                        ArticleLastUpdate = article.LastUpdate,
                        ArticleStatus = article.Status,
                        ArticleDescription = article.Description
                    };
                return await myQuery.ToListAsync();
            }
            else
            {
                var myQuery =
                    from article in _articles //.Where(a => a.Status == "فعال")
                    select new ViewModelLoadAllArticle()
                    {
                        ArticleId = article.Id,
                        ArticleName = article.Name,
                        ArticleGroupName = article.ArticleGroup.Name,
                        ArticleLatinName = article.LatinName,
                        ArticleCreationDate = article.CreatedOn,
                        ArticleCreationUserName = article.SelfUser.UserName,
                        ArticleUpdateByUserName = article.UpdateUser.UserName,
                        ArticleLastUpdate = article.LastUpdate,
                        ArticleStatus = article.Status,
                        ArticleDescription = article.Description
                    };
                return await myQuery.ToListAsync();
            }
        }

        public async Task<IList<ViewModelSimpleLoadArticle>> SimpleLoadViewModelAsync()
        {
            var myQuery = from article in _articles
                          select new ViewModelSimpleLoadArticle()
                          {
                              ArticleId = article.Id,
                              ArticleName = article.Name,
                              ArticleGroupName = article.ArticleGroup.Name
                          };
            return await myQuery.ToListAsync();
        }

        public async Task<CreateStatus> CreateAsync(Article t)
        {
            try
            {
                if (await ExistAsync(t.Name))
                {
                    InsertLog(LogLevel.Warning, EntityName,
                        "CreateAsync", GetServiceName(), EntityNameNormal + " جدید تکراری می باشد");
                    return CreateStatus.Exist;
                }

                _articles.Add(t);
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

        public async Task UpdateAsync(Article t)
        {
            _articles.AddOrUpdate(t);
            //_unitOfWork.MarkAsChanged(t);
            await _unitOfWork.SaveChangesAsync();
            InsertLog(LogLevel.Information, EntityName,
                "UpdateAsync", GetServiceName(), EntityNameNormal + $" جدید با نام {t.Name} با موفقیت ویرایش گردید.");
        }

        public async Task<Article> GetByIdAsync(int id)
        {
            return await _articles.FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<Article> GetByNameAsync(string name)
        {
            return await _articles.FirstOrDefaultAsync(b => b.Name == name);
        }

        public async Task<bool> ExistAsync(Article t)
        {
            return await _articles.AnyAsync(b => b.Id == t.Id);
        }

        public async Task<bool> IsUsedAsync(Article t)
        {
            return await _expenses.AnyAsync(e => e.ArticleId == t.Id);
        }

        public async Task<bool> IsUsedAsync(int id)
        {
            return await _expenses.AnyAsync(e => e.ArticleId == id);
        }

        public async Task<bool> ExistAsync(string name)
        {
            return await _articles.AnyAsync(b => b.Name == name);
        }

        public async Task<bool> ExistAsync(int id)
        {
            return await _articles.AnyAsync(b => b.Id == id);
        }

        public async Task<int> RemoveAsync(Article t)
        {
            return await RemoveAsync(t.Id);
            //return await _articles.Where(b => b.Id == t.Id).DeleteAsync();
        }

        public async Task<int> RemoveAsync(int id)
        {
            var item = await _articles.FirstOrDefaultAsync(f => f.Id == id);
            _articles.Remove(item);
            var res = await _unitOfWork.SaveChangesAsync();

            InsertLog(LogLevel.Information, EntityName,
                "RemoveAsync", GetServiceName(), EntityNameNormal + $" با نام {item.Name} با موفقیت حذف گردید.");

            return res;
            //return await _articles.Where(b => b.Id == id).DeleteAsync();
        }

        public Task<IList<ViewModelSimpleLoadArticle>> SimpleLoadViewModelOnlyNoneUserAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IList<ViewModelLoadAllArticle>> GetByGroupIdAsync(int groupId)
        {
            var myQuery =
                from article in _articles.Where(a => a.GroupId == groupId)
                select new ViewModelLoadAllArticle()
                {
                    ArticleId = article.Id,
                    ArticleName = article.Name,
                    ArticleLatinName = article.LatinName,
                    ArticleCreationDate = article.CreatedOn,
                    ArticleCreationUserName = article.SelfUser.UserName,
                    ArticleLastUpdate = article.LastUpdate,
                    ArticleStatus = article.Status,
                    ArticleDescription = article.Description
                };
            return await myQuery.ToListAsync();
            // return await Articles.AsNoTracking().Where(a => a.GroupId == groupId).ToListAsync();
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
