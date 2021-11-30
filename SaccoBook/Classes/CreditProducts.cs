using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaccoBook
{
    class CreditProduct
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public double InterestRate { get; set; }
        public bool RequiresMakerChecker { get; set; }
        public string InterestCalculationType { get; set; }
        public double MaximumLoanAmount { get; set; }
        public double MaxRepaymentPeriodInMonths { get; set; }
        public double MinimumDepositContribution { get; set; }
        public string NotificationTemplate { get; set; }
        public string LastModifiedBy { get; set; }
        public string LastModifiedAt { get; set; }
    }
    class Loan
    {
        public string DocumentNumber { get; set; }
        public string MembershipNumber { get; set; }
        public DateTime LoanAwardDate { get; set; }
        public DateTime LoanRepaymentDeadlineDate { get; set; }
        public double InterestRate { get; set; }
        public double LoanAmount { get; set; }
        public double RepaymentPeriodInMonths { get; set; }
        public string LoanType { get; set; }
        public string InterestCalculationType { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string Branch { get; set; }
        public double Balance { get; set; }
        public string LastModifiedBy { get; set; }
        public string LastModifiedAt { get; set; }
    }
    public class LoanRepayment
    {
        public string DocumentNumber { get; set; }
        public string LoanId { get; set; }
        public string MembershipNumber { get; set; }
        public DateTime Date { get; set; }
        public string PaidBy { get; set; }
        public string PayingAccountNumber { get; set; }
        public string Narration { get; set; }
        public string BankReference { get; set; }
        public double InstallmentAmount { get; set; }
        public double InterestAmount { get; set; }
        public string Source { get; set; }
        public string SourceAccountNumber { get; set; }
        public string Status { get; set; }
        public string LastModifiedBy { get; set; }
        public string LastModifiedAt { get; set; }
    }
    public class LoanGuarantor
    {
        public string LoanID { get; set; }
        public string IDNumber { get; set; }
        public string Names { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string StaffPayroll { get; set; }
        public bool Signatory { get; set; }
        public bool MustSign { get; set; }
        public bool MustBePresent { get; set; }
        public byte[] Picture { get; set; }
        public byte[] Signature { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string Type { get; set; }
        public string MemberNo { get; set; }
        public string EntryType { get; set; }
        public string PhoneNo { get; set; }
        public string Nationality { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string WorkStation { get; set; }
        public string Employer { get; set; }
        public string Residence { get; set; }
        public string OtherBankers { get; set; }
        public string Occupation { get; set; }
        public string PINNumber { get; set; }
        public double AmountGuaranteed { get; set; }
    }

}
