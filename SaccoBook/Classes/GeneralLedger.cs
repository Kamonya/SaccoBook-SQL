using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaccoBook
{
    class GeneralLedgerAccount
    {
        public string Code { get; set; }
        public string ParentCode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string IncomeBalanceSheet { get; set; }        
        public string BalanceAtDate { get; set; }
        public string DebitAmount { get; set; }
        public string CreditAmount { get; set; }
        public bool IsBlocked { get; set; }
        public string LastModifiedBy { get; set; }
        public string LastModifiedAt { get; set; }
    }
    class BankAccount
    {
        public string Name { get; set; }
        public string Branch { get; set; }
        public string GLAccount { get; set; }
        public string LastModifiedBy { get; set; }
        public string LastModifiedAt { get; set; }
    }
}
