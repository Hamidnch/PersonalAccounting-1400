namespace PersonalAccounting.Domain.Entity
{
    /// <inheritdoc />
    /// <summary>
    /// چک
    /// </summary>
    public class Cheque : BaseEntity
    {
        public Cheque()
        {
            Status = "فعال";
            Description = "";
            IsDeleted = false;
        }
    }
}
