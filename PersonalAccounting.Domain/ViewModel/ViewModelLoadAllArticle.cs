using System;

using PersonalAccounting.CommonLibrary.Helper;

namespace PersonalAccounting.Domain.ViewModel
{
    public class ViewModelLoadAllArticle
    {
        public int ArticleId { get; set; }
        public string ArticleName { get; set; }
        public string ArticleGroupName { get; set; }
        public string ArticleLatinName { get; set; }
        public string ArticleCreationUserName { get; set; }
        public string ArticleUpdateByUserName { get; set; }
        public DateTime? ArticleCreationDate { get; set; }
        public string ArticlePersianRegisterDate =>
            ArticleCreationDate != null ? PersianHelper.CreatePersianDate(ArticleCreationDate) : "";
        public DateTime? ArticleLastUpdate { get; set; }
        public string ArticlePersianLastUpdate =>
            ArticleLastUpdate != null ? PersianHelper.CreatePersianDate(ArticleLastUpdate) : "";
        public string ArticleStatus { get; set; }
        public string ArticleDescription { get; set; }
    }
}
