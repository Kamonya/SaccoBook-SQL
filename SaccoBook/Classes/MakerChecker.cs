using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaccoBook
{
    class ApprovalDocument
    {
        public string DocumentType { get; set; }
        public string ApprovalSequences { get; set; }
        public string LastModifiedBy { get; set; }
        public string LastModifiedAt { get; set; }
    }
    class ApprovalUser
    {
        public string DocumentType { get; set; }
        public string Approver { get; set; }
        public int ApprovalSequence { get; set; }
        public string SubstituteApprover { get; set; }
        public string ApproverEmail { get; set; }
        public string SubstituteApproverEmail { get; set; }
        public string LastModifiedBy { get; set; }
        public string LastModifiedAt { get; set; }
    }
    class ApprovalEntry
    {
        public string EntryNumber { get; set; }
        public string DocumentType { get; set; }
        public string DocumentNumber { get; set; }
        public int SequenceNumber { get; set; }
        public string SenderId { get; set; }
        public string ApproverId { get; set; }
        public string Status { get; set; }
        public string DateTimeSentForApproval { get; set; }
        public string LastModifiedBy { get; set; }
        public string LastModifiedAt { get; set; }
    }
}
