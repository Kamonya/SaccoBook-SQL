using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaccoBook
{
    class IncomeExpenses
    {
        public string DocumentId { get; set; }
        public string TransactionType { get; set; }
        public string Amount { get; set; }
        public string Datepaid { get; set; }
        public string Description { get; set; }
        public string Branch { get; set; }
        public string LastModifiedBy { get; set; }
        public string LastModifiedAt { get; set; }
    }
    class Expense
    {
        public string DocumentId { get; set; }
        public string MembershipNumber { get; set; }
        public string Date { get; set; }
        public string Amount { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Branch { get; set; }
        public string LastModifiedBy { get; set; }
        public string LastModifiedAt { get; set; }
    }
}
