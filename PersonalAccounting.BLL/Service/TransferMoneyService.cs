using PersonalAccounting.BLL.Enum;
using PersonalAccounting.BLL.IService;
using PersonalAccounting.CommonLibrary.Helper;
using PersonalAccounting.DAL.Infrastructure;
using PersonalAccounting.Domain.Entity;
using PersonalAccounting.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalAccounting.BLL.Service
{
    public class TransferMoneyService : BaseService, ITransferMoneyService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDbSet<Fund> _funds;
        private readonly IDbSet<TransferMoney> _transferMonies;

        //private readonly IDbSet<Expense> _expenses;
        //private readonly IDbSet<ExpenseDocument> _expenseDocuments;

        private const string EntityName = nameof(TransferMoney);
        private const string EntityNameNormal = "انتقال حساب";
        public TransferMoneyService(IUnitOfWork unitOfWork
            //,IDbSet<Expense> expenses, IDbSet<ExpenseDocument> expenseDocuments
            ) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _funds = _unitOfWork.Set<Fund>();
            _transferMonies = _unitOfWork.Set<TransferMoney>();
            //_expenses = _unitOfWork.Set<Expense>();
            //_expenseDocuments = _unitOfWork.Set<ExpenseDocument>();
        }

        public async Task<int> CountAsync()
        {
            return await _transferMonies.AsNoTracking().CountAsync();
        }

        public async Task<IList<TransferMoney>> LoadAllAsync(bool containActives = true)
        {
            if (!containActives)
                return await _transferMonies.Where(a => a.Status != "فعال")
                    .AsNoTracking().OrderByDescending(a => a.Id).ToListAsync();
            return await _transferMonies.AsNoTracking().ToListAsync();
        }

        public async Task<IList<ViewModelLoadAllTransferMoney>> LoadAllViewModelAsync(int? createdBy = null)
        {
            if (createdBy != null)
            {
                var query =
                    from transferMoney in _transferMonies.Where(a => a.CreatedBy == createdBy)
                    select new ViewModelLoadAllTransferMoney
                    {
                        TransferMoneyId = transferMoney.Id,
                        Amount = transferMoney.Amount,
                        BankCommission = transferMoney.BankCommission,
                        OriginFundId = transferMoney.OriginFundId,
                        OriginFundName = transferMoney.OriginFund.Title,
                        DestinationFundId = transferMoney.DestinationFundId,
                        DestinationFundName = transferMoney.DestinationFund.Title,
                        TransferMoneyCreationUserName = transferMoney.SelfUser.UserName,
                        TransferMoneyUpdateByUserName = transferMoney.UpdateUser.UserName,
                        TransferMoneyDate = transferMoney.TransferDate,
                        TransferMoneyCreationDate = transferMoney.CreatedOn,
                        TransferMoneyLastUpdate = transferMoney.LastUpdate,
                        TransferMoneyStatus = transferMoney.Status,
                        TransferMoneyDescription = transferMoney.Description
                    };
                return await query.ToListAsync(); //.OrderByDescending(x => x.Amount)
            }
            else
            {
                var query =
                    from transferMoney in _transferMonies//.Where(a => a.Status == "فعال")
                    select new ViewModelLoadAllTransferMoney
                    {
                        TransferMoneyId = transferMoney.Id,
                        Amount = transferMoney.Amount,
                        BankCommission = transferMoney.BankCommission,
                        OriginFundId = transferMoney.OriginFundId,
                        OriginFundName = transferMoney.OriginFund.Title,
                        DestinationFundId = transferMoney.DestinationFundId,
                        DestinationFundName = transferMoney.DestinationFund.Title,
                        TransferMoneyCreationUserName = transferMoney.SelfUser.UserName,
                        TransferMoneyUpdateByUserName = transferMoney.UpdateUser.UserName,
                        TransferMoneyDate = transferMoney.TransferDate,
                        TransferMoneyCreationDate = transferMoney.CreatedOn,
                        TransferMoneyLastUpdate = transferMoney.LastUpdate,
                        TransferMoneyStatus = transferMoney.Status,
                        TransferMoneyDescription = transferMoney.Description
                    };
                return await query.ToListAsync(); //.OrderByDescending(x => x.Amount)
            }

        }

        public async Task<CreateStatus> CreateAsync(TransferMoney transferMoney)
        {
            try
            {
                _transferMonies.Add(transferMoney);
                await _unitOfWork.SaveChangesAsync();
                InsertLog(LogLevel.Information, EntityName,
                    "CreateAsync", GetServiceName(), EntityNameNormal + $" جدید با شناسه {transferMoney.Id} با موفقیت ثبت گردید.");
                return CreateStatus.Successful;
            }
            catch (Exception exception)
            {
                InsertLog(LogLevel.Error, EntityName,
                    "CreateAsync", exception.Message, exception.ToDetailedString());
                return CreateStatus.Failure;
            }
        }

        public async Task UpdateAsync(TransferMoney transferMoney)
        {
            _transferMonies.AddOrUpdate(transferMoney);
            await _unitOfWork.SaveChangesAsync();
            InsertLog(LogLevel.Information, EntityName,
                "UpdateAsync", GetServiceName(), EntityNameNormal +
                                                 $" جدید با شناسه {transferMoney.Id} با موفقیت ویرایش گردید.");
        }

        public async Task<TransferMoney> GetByIdAsync(int transferMoneyId)
        {
            return await _transferMonies.FirstOrDefaultAsync(f => f.Id == transferMoneyId);
        }

        public async Task<TransferMoney> GetByFundAsync(int originFundId, int destinationFundId)
        {
            return await _transferMonies.FirstOrDefaultAsync(f => f.OriginFundId == originFundId &&
                                                                 f.DestinationFundId == destinationFundId);
        }

        public async Task<TransferStatus> TransferAmountAsync(int firstFundId, int secondFundId,
            double amount, double commission, TransferType transferType)
        {
            var originFund = await _funds.FirstOrDefaultAsync(o => o.Id == firstFundId);
            var destinationFund = await _funds.FirstOrDefaultAsync(o => o.Id == secondFundId);

            if (originFund == null)
            {
                InsertLog(LogLevel.Error, EntityName,
                    "TransferAmountAsync", GetServiceName(), $"صندوق مبدا با شناسه {firstFundId} یافت نشد.");
                return TransferStatus.OriginFundIsNull;
            }

            if (destinationFund == null)
            {
                InsertLog(LogLevel.Error, EntityName,
                    "TransferAmountAsync", GetServiceName(),
                    $"صندوق مقصد با شناسه {secondFundId} یافت نشد.");
                return TransferStatus.DestinationFundIsNull;
            }

            if (originFund.Id == destinationFund.Id &&
                originFund.Title.ToLower() == destinationFund.Title.ToLower())
            {
                InsertLog(LogLevel.Error, EntityName,
                    "TransferAmountAsync", GetServiceName(),
                    $"صندوق مبدا و مقصد یکسان هست. شناسه صندوق ها : '{originFund} = {secondFundId}' ");
                return TransferStatus.OriginalAndDestinationIsTheSame;
            }

            if (amount <= 0)
            {
                InsertLog(LogLevel.Error, EntityName,
                    "TransferAmountAsync", GetServiceName(),
                    $"مبلغ انتقال کوچکتر یا مساوی صفر می باشد. شناسه صندوق مبدا: {originFund} و شناسه صندوق مقصد: {destinationFund}");
                return TransferStatus.AmountValueIsZeroOrLessThanZero;
            }

            if (commission < 0)
            {
                InsertLog(LogLevel.Error, EntityName,
                    "TransferAmountAsync", GetServiceName(),
                    $"کارمزد بانکی کمتر از صفر می باشد.: {originFund} و شناسه صندوق مقصد: {destinationFund}");
                return TransferStatus.CommissionIsZeroOrLessThanZero;
            }

            var amountCommission = amount + commission;

            switch (transferType)
            {
                case TransferType.Commit:
                    try
                    {
                        //check for Origin Fund Amount for enough value
                        if (originFund.CurrentValue < amountCommission)
                        {
                            InsertLog(LogLevel.Error, EntityName,
                                "TransferAmountAsync", GetServiceName(),
                                $"موجودی صندوق مبدا کمتر از مبلغ قابل انتقال بعلاوه کارمزد بانکی می باشد.\n " +
                                $"شناسه صندوق مبدا: {firstFundId} , " +
                                $"شناسه صندوق مقصد: {secondFundId} , " +
                                $"مبلغ قابل انتقال: {amount} , " +
                                $"کارمزد بانکی: {commission} ");
                            return TransferStatus.OriginFundValueIsLessThanAmountPlusCommission;
                        }
                        //Sub amount and commission from origin fund
                        originFund.CurrentValue -= amountCommission;
                        //add amount to dest fund
                        destinationFund.CurrentValue += amount;

                        //InsertLog(LogLevel.Information, EntityName, "TransferAmountAsync(1)",
                        //    GetServiceName(),
                        //    "مانده جاری صندوق مبدا: " + $"{originFund.CurrentValue} ریال" +
                        //    "مانده جاری صندوق مقصد: " + $"{destinationFund.CurrentValue} ریال");

                        ////Add Commission to expense table
                        //var document = new ExpenseDocument(DateTime.Now,
                        //    null, DateTime.Now,
                        //    DateTime.Now, "ثبت توسط سیستم");
                        //var expenseDocument = _expenseDocuments.Add(document);

                        //var expense = new Expense(1, null, originFund.Id,
                        //    null, null,
                        //    null, commission, 1, 
                        //    commission, "ثبت توسط سیستم")
                        //    { DocumentId = expenseDocument.Id };

                        //_expenses.Add(expense);

                        //Save To DB
                        await _unitOfWork.SaveChangesAsync();
                        InsertLog(LogLevel.Information, EntityName,
                            "TransferAmountAsync(2)", GetServiceName(),
                            EntityNameNormal + $"از صندوق {originFund.Title} به صندوق {destinationFund.Title} " +
                            $" با مبلغ {amount} ریال و کارمزد {commission} ریال " +
                            "انجام شد.\n " +
                            "مانده جاری صندوق مبدا: " + $"{originFund.CurrentValue} ریال" +
                            "مانده جاری صندوق مقصد: " + $"{destinationFund.CurrentValue} ریال");
                        return TransferStatus.Success;
                    }
                    catch (Exception exception)
                    {
                        InsertLog(LogLevel.Error, EntityName,
                            "CreateAsync", exception.Message, exception.ToDetailedString());
                        return TransferStatus.Failure;
                    }

                case TransferType.RollBack:
                    try
                    {
                        //Check for dest Fund Amount for enough value
                        if (destinationFund.CurrentValue < amount)
                        {
                            InsertLog(LogLevel.Error, EntityName,
                                "TransferAmountAsync", GetServiceName(),
                                $"موجودی صندوق مقصد کمتر از مبلغ قابل انتقال می باشد.\n " +
                                $"شناسه صندوق مبدا: {firstFundId} , " +
                                $"شناسه صندوق مقصد: {secondFundId} , " +
                                $"مبلغ قابل انتقال: {amount} , ");
                            return TransferStatus.DestinationFundValueIsLessThanAmount;
                        }
                        //sub amount from second Fund
                        destinationFund.CurrentValue -= amount;

                        //Add amount and commission to origin Fund
                        originFund.CurrentValue += amountCommission;

                        //Delete expense for Bank Commission
                        //Maybe not need!

                        //Save To DB
                        await _unitOfWork.SaveChangesAsync();
                        InsertLog(LogLevel.Information, EntityName,
                            "TransferAmountAsync(2)", GetServiceName(),
                            "استرداد مبلغ" + $"از صندوق {destinationFund.Title} به صندوق {originFund.Title} " +
                            $" با مبلغ {amount} ریال " +
                            "انجام شد.\n " +
                            "مانده جاری صندوق مقصد: " + $"{destinationFund.CurrentValue} ریال" +
                            "مانده جاری صندوق مبدا: " + $"{originFund.CurrentValue} ریال");

                        return TransferStatus.Success;
                    }
                    catch (Exception exception)
                    {
                        InsertLog(LogLevel.Error, EntityName,
                            "CreateAsync", exception.Message, exception.ToDetailedString());
                        return TransferStatus.Failure;
                    }

                default:
                    return TransferStatus.Failure;
            }
        }

        public async Task<int> RemoveAsync(TransferMoney transferMoney)
        {
            return await RemoveAsync(transferMoney.Id);
        }

        public async Task<int> RemoveAsync(int transferMoneyId)
        {
            var item = await
                _transferMonies.FirstOrDefaultAsync(t => t.Id == transferMoneyId);
            _transferMonies.Remove(item);
            var res = await _unitOfWork.SaveChangesAsync();

            InsertLog(LogLevel.Information, EntityName,
                "RemoveAsync", GetServiceName(), EntityNameNormal + $"با موفقیت حذف گردید.");

            return res;
        }

        private bool _disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _unitOfWork.Dispose();
                }
            }
            this._disposed = true;
        }
        public void Dispose()
        {
            //_unitOfWork?.Dispose();
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
