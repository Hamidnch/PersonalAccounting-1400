using PersonalAccounting.Domain.Entity;

namespace PersonalAccounting.BLL.Enum
{
    public class ValidateStatus
    {
        public User CurrentUser { get; set; } = null;
        public ValidateUserStatus ValidateUserStatus { get; set; } = ValidateUserStatus.Failure;
    }
}
