using System;

using PersonalAccounting.CommonLibrary.Helper;

namespace PersonalAccounting.Domain.ViewModel
{
    public class ViewModelLoadAllMeasurementUnit
    {
        public int MeasurementUnitId { get; set; }
        public string MeasurementUnitName { get; set; }
        public DateTime? MeasurementUnitCreationDate { get; set; }
        public string MeasurementUnitPersianRegisterDate =>
            MeasurementUnitCreationDate != null ? PersianHelper.CreatePersianDate(MeasurementUnitCreationDate) : "";
        public DateTime? MeasurementUnitLastUpdate { get; set; }
        public string MeasurementUnitPersianLastUpdate =>
            MeasurementUnitLastUpdate != null ? PersianHelper.CreatePersianDate(MeasurementUnitLastUpdate) : "";

        public string MeasurementUnitCreationUserName { get; set; }
        public string MeasurementUnitUpdateByUserName { get; set; }
        //public string MeasurementUnitDescription { get; set; }
    }
}
