using System;

namespace PersonalAccounting.Domain.Entity
{
    public class ArticleGroup : BaseEntity
    {
        public ArticleGroup()
        {
            Status = "فعال";
            Description = "";
            IsDeleted = false;
        }

        public ArticleGroup(string name, string latinName)
        {
            Name = name;
            LatinName = latinName;
            IsDeleted = false;
        }
        public ArticleGroup(string name, string latinName, int createdBy, DateTime? createdOn,
            DateTime? lastUpdate, string description, string status)
        {
            Name = name;
            LatinName = latinName;
            CreatedBy = createdBy;
            CreatedOn = createdOn;
            LastUpdate = lastUpdate;
            Status = status;
            Description = description;
            IsDeleted = false;
        }
        public string Name { get; set; }
        public string LatinName { get; set; }
    }
}