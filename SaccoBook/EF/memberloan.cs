//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SaccoBook.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class memberloan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public memberloan()
        {
            this.guarantors = new HashSet<guarantor>();
            this.memberloanrepayments = new HashSet<memberloanrepayment>();
        }
    
        public string DocumentNumber { get; set; }
        public string MembershipNumber { get; set; }
        public string LoanType { get; set; }
        public System.DateTime LoanAwardDate { get; set; }
        public System.DateTime LoanRepaymentDeadlineDate { get; set; }
        public double InterestRate { get; set; }
        public string InterestCalculationType { get; set; }
        public double LoanAmount { get; set; }
        public double RepaymentPeriodInMonths { get; set; }
        public string Description { get; set; }
        public double Balance { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public string LastModifiedBy { get; set; }
        public string LastModifiedAt { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<guarantor> guarantors { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<memberloanrepayment> memberloanrepayments { get; set; }
        public virtual member member { get; set; }
    }
}
