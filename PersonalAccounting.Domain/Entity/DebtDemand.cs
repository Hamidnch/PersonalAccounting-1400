namespace PersonalAccounting.Domain.Entity
{
    /// <inheritdoc />
    /// <summary>
    /// طلب و بدهی
    /// </summary>
    public class DebtDemand : BaseEntity
    {
        public DebtDemand()
        {
            Status = "فعال";
            Description = "";
            IsDeleted = false;
        }
    }
}
