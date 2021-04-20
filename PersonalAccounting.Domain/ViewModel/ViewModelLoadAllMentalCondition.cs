using System;
using PersonalAccounting.CommonLibrary.Helper;

namespace PersonalAccounting.Domain.ViewModel
{
    public class ViewModelLoadAllMentalCondition
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public byte[] Picture { get; set; }

        public DateTime? CreationDate { get; set; }
        public string PersianCreationDate =>
            CreationDate != null ? PersianHelper.CreatePersianDate(CreationDate) : "";
        public DateTime? LastUpdate { get; set; }
        public string PersianLastUpdate =>
            LastUpdate != null ? PersianHelper.CreatePersianDate(LastUpdate) : "";

        public string CreationUser { get; set; }
        public string UpdateByUser { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
    }
}
