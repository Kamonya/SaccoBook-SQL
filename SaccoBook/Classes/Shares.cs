using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaccoBook
{
    class Share
    {
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Description { get; set; }
        public string TotalShares { get; set; }
        public string NominalPrice { get; set; }
        public string SharesToBeIssued { get; set; }
        public string CapitalValue { get; set; }
        public string MinimumSharesPerClient { get; set; }
        public string DefaultSharesPerClient { get; set; }
        public string MaximumSharesPerClient { get; set; }
        public string MinimumActivePeriod { get; set; }
        public string AllowDividendsForInactiveUsers { get; set; }
        public string SharesReferenceGlAccount { get; set; }
        public string ShaaresSuspenseControl { get; set; }
        public string Equity { get; set; }
        public string IncomeFromFees { get; set; }
        public string AllowWithdrawal { get; set; }
        public string Status { get; set; }
        public string LastModifiedBy { get; set; }
        public string LastModifiedAt { get; set; }
    }
}
