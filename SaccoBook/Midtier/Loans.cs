using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaccoBook.Midtier
{
    class Loans
    {
        //create disbursement format here
        public static bool CreateLoanRecord(string DocumentNumber, string MembershipNumber, string LoanType, string LoanAwardDate, string LoanRepaymentDeadlineDate, string InterestRate, string InterestCalculationType, string LoanAmount, string RepaymentPeriodInMonths, string Description, string Status)
        {
            bool status = false;

            DocumentNumber = DocumentNumber.Trim();
            MembershipNumber = MembershipNumber.Trim();
            LoanType = LoanType.Trim();
            LoanAwardDate = LoanAwardDate.Trim();
            LoanRepaymentDeadlineDate = LoanRepaymentDeadlineDate.Trim();
            InterestRate = InterestRate.Trim();
            InterestCalculationType = InterestCalculationType.Trim();
            LoanAmount = LoanAmount.Trim().Replace(",", "");
            RepaymentPeriodInMonths = RepaymentPeriodInMonths.Trim();
            Description = Description.Trim();
            Status = Status.Trim();
            string CreatedBy = Login.LoggedInUser;
            string LastModifiedBy = Login.LoggedInUser;
            string LastModifiedAt = DateTime.Now.ToString();

            if (EF.LoansQueries.CreateLoanRecord(DocumentNumber, MembershipNumber, LoanType, LoanAwardDate, LoanRepaymentDeadlineDate, InterestRate, InterestCalculationType, LoanAmount, RepaymentPeriodInMonths, Description, Status, CreatedBy, LastModifiedBy, LastModifiedAt))
            {
                status = true;
            }
            return status;
        }

    }
}
