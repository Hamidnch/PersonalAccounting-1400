namespace PersonalAccounting.Domain.Entity
{
    /// <inheritdoc />
    /// <summary>
    /// وام
    /// </summary>
    public class Loan : BaseEntity
    {
        public Loan()
        {
            Status = "فعال";
            Description = "";
            IsDeleted = false;
        }
    }
}
