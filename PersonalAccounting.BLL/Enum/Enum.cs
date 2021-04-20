namespace PersonalAccounting.BLL.Enum
{
    public static class PublicError
    {
        public static string Error { get; set; }
    }

    public enum StampActions
    {
        EditedBy = 1,
        DateTime = 2,
        Custom = 4
    }

    public enum PermissionMode
    {
        View = 0,
        Add = 1,
        Edit = 2,
        Delete = 3
    }
    public enum UserRegisterStatus
    {
        Failure = -1,
        Successful = 0,
        UserNameExist = 1,
        EmailExist = 2
    }

    public enum CreateStatus
    {
        Failure = -1,
        Successful = 0,
        Exist = 1
    }

    public enum ValidateUserStatus
    {
        Failure = -1,
        Successful = 0,
        IsLockout = 1,
        IsNotApproved = 2,
        IsNotActive = 3,
        UsernameIsEmpty = 4,
        PasswordIsEmpty = 5,
        UserIsNotExists = 6
    }

    public enum FundStatus
    {
        Success = 0,
        FundValueIsLessThanCurrentValue = 1
    }
    public enum TransferStatus
    {
        Failure = -1,
        Success = 0,
        OriginFundIsNull = 2,
        DestinationFundIsNull = 3,
        OriginalAndDestinationIsTheSame = 4,
        AmountValueIsZeroOrLessThanZero = 5,
        CommissionIsZeroOrLessThanZero = 6,
        OriginFundValueIsLessThanAmountPlusCommission = 7,
        DestinationFundValueIsLessThanAmount = 8
    }

    public enum TransferType
    {
        Commit,
        RollBack
    }
}