namespace PersonalAccounting.Domain.ViewModel
{
    public class ViewModelSimpleLoadBankAccount
    {
        public int BankAccountId { get; set; }
        /// <summary>
        /// عنوان حساب بانکی
        /// </summary> 
        public string BankAccountSubject { get; set; }
        /// <summary>
        /// شماره حساب بانکی
        /// </summary>
        public string BankAccountNumber { get; set; }
        /// <summary>
        /// نام بانک محل حساب
        /// </summary>
        public string BankName { get; set; }
        /// <summary>
        /// نام صاحب حساب
        /// </summary>
        public string BankAccountPersonName { get; set; }
    }
}
