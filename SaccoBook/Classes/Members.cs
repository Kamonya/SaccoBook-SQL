using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaccoBook
{
    class Member
    {
        public string MembershipNumber { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string AlternativeNumber { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }
        public string NationalIdNumber { get; set; }        
        public string TaxPIN { get; set; }     
        public string Address { get; set; }
        public byte[] Photo { get; set; }
        public string Password { get; set; }
        public string SourceOfIncome { get; set; }
        public string Employer { get; set; }
        public string JobPosition { get; set; }
        public string PayrollNumber { get; set; }
        public string EmployerAddress { get; set; }
        public string EmployerTelephoneNumber { get; set; }
        public double GrossMonthlyIncome { get; set; }           
        public DateTime DateJoined { get; set; }
        public string MembershipStatus { get; set; }
        public string MembershipType { get; set; }
        public string LastModifiedBy { get; set; }
        public string LastModifiedAt { get; set; }
        public List<Kin> MemberKinsList { get; set; }
    } 
    class Kin
    {
        public string IdentificationDocumentNumber { get; set; }
        public string MembershipNumber { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Relationship { get; set; }
        public string Occupation { get; set; }
        public string LastModifiedBy { get; set; }
        public string LastModifiedAt { get; set; }
    }
    class Beneficiary
    {
        public string IdentificationDocumentNumber { get; set; }
        public string MembershipNumber { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Relationship { get; set; }
        public string Occupation { get; set; }
        public string LastModifiedBy { get; set; }
        public string LastModifiedAt { get; set; }
    }
    class MemberBankAccount
    {
        public string MembershipNumber { get; set; }
        public string BankName { get; set; }
        public string Branch { get; set; }
        public string AccountNumber { get; set; }
        public string LastModifiedBy { get; set; }
        public string LastModifiedAt { get; set; }
    }

    public class GroupSignatory
    {
        public string GroupMembershipNo { get; set; }
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
    }
}
