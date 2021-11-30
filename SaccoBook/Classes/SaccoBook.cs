using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaccoBook
{
    class SaccoBookSettings
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string HomePage { get; set; }
        public byte[] Photo { get; set; }
        public string AfricasTalkingUsername { get; set; }
        public string AfricasTalkingAPIKey { get; set; }
        public bool SMSNotificationsEnabled { get; set; }
        public string SMTPServer { get; set; }
        public int SMTPServerPort { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public bool EmailNotificationsEnabled { get; set; }
        public bool AutomaticDatabaseBackUpEnabled { get; set; }
        public string DatabaseBackUpPath { get; set; }
        public string CredentialType { get; set; }
        public string LastModifiedAt { get; set; }
        public string LastModifiedBy { get; set; }
    }
    class SystemUser
    {
        public static string SystemId { get; set; }
        public string Username { get; set; }
        public string CredentialType { get; set; }
        public string RoleId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string IdNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string Status { get; set; }
        public string LastModifiedBy { get; set; }
        public string LastModifiedAt { get; set; }
    }
    class Role
    {
        public string RoleId { get; set; }
        public bool CanLogin { get; set; }
        public bool IsMasterAdmin { get; set; }
        //Members Functionalities
        public bool CanAddUser { get; set; }
        public bool CanAddKin { get; set; }
        public bool CanViewMemberProfile { get; set; }
        public bool CanEditUser { get; set; }
        public bool CanDeleteUser { get; set; }
        //Savings Functionalities
        public bool CanAddSavings { get; set; }
        public bool CanAddWithdrawal { get; set; }
        public bool CanAddBulkSavings { get; set; }
        //Loans Functionalities
        public bool CanAddLoan { get; set; }
        public bool CanAddLoanRepayment { get; set; }
        public bool CanViewRepaymentHistory { get; set; }
        public bool CanViewLoanGuarantors { get; set; }
        public bool CanEditLoan { get; set; }
        public bool CanDeleteLoan { get; set; }
        //Shares Functionalities
        public bool CanAddShares { get; set; }
        public bool CanViewShares { get; set; }
        //Expenses Functionalities
        public bool CanAddExpenses { get; set; }
        public bool CanEditExpenses { get; set; }
        public bool CanDeleteExpenses { get; set; }
        public string LastModifiedBy { get; set; }
        public string LastModifiedAt { get; set; }
    }
    class NumberSeries
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public string StartingNumber { get; set; }
        public string EndingNumber { get; set; }
        public string LastUsedNumber { get; set; }
        public string LastModifiedBy { get; set; }
        public string LastModifiedAt { get; set; }
    }
    class Branch
    {
        public int Id { get; set; }
        public string BranchName { get; set; }
        public string Location { get; set; }
        public string LastModifiedBy { get; set; }
        public string LastModifiedAt { get; set; }
    }
    class NotificationTemplate
    {
        public int Id { get; set; }
        public string Document { get; set; }
        public string EmailTemplate { get; set; }
        public string SMSTemplate { get; set; }
        public string LastModifiedBy { get; set; }
        public string LastModifiedAt { get; set; }
    }
}
