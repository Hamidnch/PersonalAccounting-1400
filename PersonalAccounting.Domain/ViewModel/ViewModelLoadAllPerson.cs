using System;

using PersonalAccounting.CommonLibrary.Helper;

namespace PersonalAccounting.Domain.ViewModel
{
    public class ViewModelLoadAllPerson
    {
        public int PersonId { get; set; }
        public string PersonFullName { get; set; }
        public string PersonSex { get; set; }
        public DateTime? PersonCreationDate { get; set; }
        public string PersonPersianCreationDate =>
            PersonCreationDate != null ? PersianHelper.CreatePersianDate(PersonCreationDate) : "";
        public DateTime? PersonLastUpdate { get; set; }
        public string PersonPersianLastUpdate =>
            PersonLastUpdate != null ? PersianHelper.CreatePersianDate(PersonLastUpdate) : "";
        public byte[] PersonPicture { get; set; }
        public string PersonCreationUser { get; set; }
        public string PersonUpdateByUser { get; set; }
        public string PersonStatus { get; set; }
        public string PersonDescription { get; set; }
    }
}
