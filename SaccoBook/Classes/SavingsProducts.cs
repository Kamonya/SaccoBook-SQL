using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaccoBook
{    
    class Saving
    {
        public string DocumentNumber { get; set; }
        public string MembershipNumber { get; set; }
        public string TransactionType { get; set; }
        public string Source { get; set; }
        public string SourceAccount { get; set; }
        public string AccountType { get; set; }
        public string Destination { get; set; }
        public string DestinationAccount { get; set; }
        public string Description { get; set; }
        public string ReferenceNo { get; set; }
        public DateTime TransactionDate { get; set; }
        public string GLAccount { get; set; }
        public double CreditAmount { get; set; }
        public double DebitAmount { get; set; }
        public string Status { get; set; }
        public string LastModifiedBy { get; set; }
        public string LastModifiedAt { get; set; }
    }
    class SavingsDividends
    {
        public string MonthNumber { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
        public string Amount { get; set; }
    }
    class SavingsDeposit
    {
        public string ProductName { get; set; }
        public string ShortName { get; set; }
        public string Description { get; set; }
        public string Currency { get; set; }
        public string NominalAnnualInterest { get; set; }
        public string InterestCompoundingPeriod { get; set; }
        public string InterestCalculatedUsing { get; set; }
        public string InterestPostingPeriod { get; set; }
        public string MinimumOpeningBalance { get; set; }
        public string ApplyWithdrawalFeesForTransfer { get; set; }
        public string EnforceMinimumBalance { get; set; }
        public string IsOverdraftAllowed { get; set; }
        public string EnableDormancyTracking { get; set; }
        public string InactiveUserPeriod { get; set; }
        public string DormantUserPeriod { get; set; }
        public string SavingsReferenceGLAccount { get; set; }
        public string OverdraftPortfolio { get; set; }
        public string SavingsControlGLAccount { get; set; }
        public string InterestsOnSavingsAccount { get; set; }
        public string WriteOffAccount { get; set; }
        public string IncomeFromFees { get; set; }
        public string IncomeFromPenalties { get; set; }
        public string OverdraftInterestIncome { get; set; }
        public string IsAGroupProduct { get; set; }
        public string Status { get; set; }
        public string LastModifiedBy { get; set; }
        public string LastModifiedAt { get; set; }
    }
    class SavingsType
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double MinimumOpeningBalance { get; set; }
        public double MinimumMonthlyContributions { get; set; }
        public double MaximumAmountWithdrawableInADay { get; set; }
        public double WithdrawalCharge { get; set; }
        public string LastModifiedBy { get; set; }
        public string LastModifiedAt { get; set; }
    }
    class MemberSavingsAccounts
    {
        public string AccountNumber { get; set; }
        public string MembershipNumber { get; set; }
        public string AccountType { get; set; }
        public string AccountName { get; set; }
        public double CreditAmount { get; set; }
        public double DebitAmount { get; set; }
        public double Balance { get; set; }
        public DateTime DateCreated { get; set; }
        public string Status { get; set; }
        public string LastModifiedBy { get; set; }
        public string LastModifiedAt { get; set; }
    }
}
