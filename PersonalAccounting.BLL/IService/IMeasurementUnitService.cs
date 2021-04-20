using PersonalAccounting.BLL.Enum;
using PersonalAccounting.Domain.Entity;
using PersonalAccounting.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonalAccounting.BLL.IService
{
    public interface IMeasurementUnitService : IDisposable
    {
        Task<int> CountAsync();
        Task<IList<MeasurementUnit>> LoadAllAsync(bool containActives = true);
        Task<IList<ViewModelLoadAllMeasurementUnit>> LoadAllViewModelAsync(int? createdBy = null);
        Task<IList<ViewModelSimpleLoadMeasurementUnit>> SimpleLoadViewModelAsync();
        //Task<IList<ViewModelSimpleLoadMeasurementUnit>> SimpleLoadViewModelByArticleIdAsync(int articleId);
        Task<CreateStatus> CreateAsync(MeasurementUnit measurementUnit);
        Task UpdateAsync(MeasurementUnit measurementUnit);
        Task<MeasurementUnit> GetByIdAsync(int measurementUnitId);
        Task<MeasurementUnit> GetByNameAsync(string measurementUnitName);
        Task AssignToArticleAsync(Article article, IList<string> measurementUnits);
        Task AssignToArticleAsync(string articleName, IList<string> measurementUnits);
        Task AssignToArticleAsync(int articleId, IList<string> measurementUnits);
        Task RemoveFromArticleAsync(string articleName);
        Task<IList<ViewModelSimpleLoadMeasurementUnit>> GetByArticleAsync(int articleId);
        Task<IList<string>> GetByArticleAsync(string articleName);
        IList<string> GetByArticle(Article article);
        Task<bool> ExistAsync(MeasurementUnit measurementUnit);
        Task<bool> ExistAsync(string measurementUnitName);
        Task<bool> IsUsedAsync(MeasurementUnit measurementUnit);
        Task<bool> IsUsedAsync(int measurementUnitId);
        Task<int> RemoveAsync(MeasurementUnit measurementUnit);
        Task<int> RemoveAsync(int measurementUnitId);
    }
}
