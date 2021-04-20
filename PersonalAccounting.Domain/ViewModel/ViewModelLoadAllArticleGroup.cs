using System;

using PersonalAccounting.CommonLibrary.Helper;

namespace PersonalAccounting.Domain.ViewModel
{
    public class ViewModelLoadAllArticleGroup
    {
        public int ArticleGroupId { get; set; }
        public string ArticleGroupName { get; set; }
        public string ArticleGroupLatinName { get; set; }
        public string ArticleGroupCreationUserName { get; set; }
        public string ArticleGroupUpdateByUserName { get; set; }
        public DateTime? ArticleGroupCreationDate { get; set; }
        public string ArticleGroupPersianRegisterDate =>
            ArticleGroupCreationDate != null ? PersianHelper.CreatePersianDate(ArticleGroupCreationDate) : "";
        public DateTime? ArticleGroupLastUpdate { get; set; }
        public string ArticleGroupPersianLastUpdate =>
            ArticleGroupLastUpdate != null ? PersianHelper.CreatePersianDate(ArticleGroupLastUpdate) : "";
        public string ArticleGroupStatus { get; set; }
        public string ArticleGroupDescription { get; set; }
    }
}