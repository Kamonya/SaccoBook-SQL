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
    
    public partial class Signatory
    {
        public int Id { get; set; }
        public string GroupMembershipNo { get; set; }
        public string IDNumber { get; set; }
        public string Names { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public string StaffPayroll { get; set; }
        public byte Signatory1 { get; set; }
        public byte MustSign { get; set; }
        public byte MustBePresent { get; set; }
        public byte[] Picture { get; set; }
        public byte[] Signature { get; set; }
        public System.DateTime ExpiryDate { get; set; }
        public string Type { get; set; }
        public string MemberNo { get; set; }
        public int EntryType { get; set; }
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
    
        public virtual member member { get; set; }
    }
}
