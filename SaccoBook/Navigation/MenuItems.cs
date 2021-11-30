using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaccoBook.Navigation
{
    class MenuItems
    {
        /**************************** DASHBOARD ****************************/
         
        public static void DashboardClick(string ChildNode)
        {

            if (ChildNode.Equals("Members"))
            {
                OpenDashboard("Members");
            }
            if (ChildNode.Equals("Savings"))
            {
                OpenDashboard("Savings");
            }
        }

        /**************************** APPROVAL ENTRIES ********************************/
        public static void ApprovalEntriesClick(string ChildNode)
        {

            if (ChildNode.Equals("Pending Approval Entries"))
            {
                OpenApprovalEntriesWindow("Open", "Pending Approval Entries");
            }
            if (ChildNode.Equals("Approved Entries"))
            {
                OpenApprovalEntriesWindow("Approved", "Approved Approval Entries");
            }
            if (ChildNode.Equals("Rejected Entries"))
            {
                OpenApprovalEntriesWindow("Rejected", "Rejected Approval Entries");
            }
        }
        public static void ReportsClick(string ChildNode, DevExpress.XtraEditors.XtraForm form)
        {
            if (ChildNode.Equals("Sacco Savings") || ChildNode.Equals("Member Savings") || ChildNode.Equals("Awarded Loans Report"))
            {
                Reports.PeriodChooser _PeriodChooser = new Reports.PeriodChooser(ChildNode);
                _PeriodChooser.ShowDialog();
            }
            else if(ChildNode.Equals("Loan Balances Report"))
            {
                Reports.Loans.LoanBalancesReport _LoanBalancesReport = new Reports.Loans.LoanBalancesReport();
                AppResources.DevexpressFunctions.LoadReport(_LoanBalancesReport, form);
            }
            else if (ChildNode.Equals("Loan Defaulters Report"))
            {
                Reports.Loans.LoanDefaultersReport _LoanDefaultersReport = new Reports.Loans.LoanDefaultersReport();
                AppResources.DevexpressFunctions.LoadReport(_LoanDefaultersReport, form);
            }
            else if (ChildNode.Equals("Loan Repayment Statement"))
            {
                Reports.Loans.LoanRepaymentStatement _LoanRepaymentStatement = new Reports.Loans.LoanRepaymentStatement();
                AppResources.DevexpressFunctions.LoadReport(_LoanRepaymentStatement, form);
            }
        }
        private static void OpenApprovalEntriesWindow(string status, string Title)
        {
            Modules.ApprovalEntries.ViewApprovalEntries _ViewApprovalEntries = new Modules.ApprovalEntries.ViewApprovalEntries(status, Title);
            _ViewApprovalEntries.ShowDialog();
        }
        private static void OpenDashboard(string Window)
        {
            ViewDashboard _ViewDashboard = new ViewDashboard(Window);
            _ViewDashboard.ShowDialog();
        }

        /********************************** MEMBERS **********************************/
        public static void MembersClick(string ChildNode)
        {

            if (ChildNode.Equals("Active Members"))
            {
                OpenViewMembersListWindow("Active");
            }
            if (ChildNode.Equals("Dormant Members"))
            {
                OpenViewMembersListWindow("Dormant");
            }
            if (ChildNode.Equals("Inactive Members"))
            {
                OpenViewMembersListWindow("Inactive");
            }
        }

        private static void OpenViewMembersListWindow(string status)
        {
            Modules.SaccoMembers.ViewMembersList _ViewMembersList = new Modules.SaccoMembers.ViewMembersList(status);
            _ViewMembersList.ShowDialog();
        }

        /*********************************** SAVINGS *********************************/
        public static void SavingsClick(string ChildNode)
        {
            //savings
            if (ChildNode.Equals("Open Savings Entries"))
            {
                OpenViewSavingsWithdrawalWindow("Open", "Saving");
            }
            if (ChildNode.Equals("Pending Approval Savings Entries"))
            {
                OpenViewSavingsWithdrawalWindow("Pending Approval", "Saving");
            }
            if (ChildNode.Equals("Approved Savings Entries"))
            {
                OpenViewSavingsWithdrawalWindow("Rejected", "Saving");
            }
            if (ChildNode.Equals("Rejected Savings Entries"))
            {
                OpenViewSavingsWithdrawalWindow("Approved", "Saving");
            }
            //withdawals
            if (ChildNode.Equals("Open Withdrawals Entries"))
            {
                OpenViewSavingsWithdrawalWindow("Open", "Withdrawal");
            }
            if (ChildNode.Equals("Pending Approval Withdrawals Entries"))
            {
                OpenViewSavingsWithdrawalWindow("Pending Approval", "Withdrawal");
            }
            if (ChildNode.Equals("Approved Withdrawals Entries"))
            {
                OpenViewSavingsWithdrawalWindow("Rejected", "Withdrawal");
            }
            if (ChildNode.Equals("Rejected Withdrawals Entries"))
            {
                OpenViewSavingsWithdrawalWindow("Approved", "Withdrawal");
            }
            ///Savings Accounts
            ///
            if (ChildNode.Equals("Savings Accounts Balances"))
            {
                Modules.SavingsWithdrawals.Savings.SavingsAccounts _SavingsAccounts = new Modules.SavingsWithdrawals.Savings.SavingsAccounts();
                _SavingsAccounts.ShowDialog();
            }
        }

        private static void OpenViewSavingsWithdrawalWindow(string status, string DocumentType)
        {
            Modules.SavingsWithdrawals.ViewSavingsWithdrawals _ViewSavingsWithdrawals = new Modules.SavingsWithdrawals.ViewSavingsWithdrawals(status, DocumentType);
            _ViewSavingsWithdrawals.ShowDialog();
        }

        /********************************** LOANS ***************************************/
        public static void LoansClick(string ChildNode)
        {
            if (ChildNode.Equals("Open Disbursement Entries"))
            {
                OpenViewLoansWindow("Open", "Open Loan Disbursement Entries", "Disbursement");
            }
            if (ChildNode.Equals("Pending Approval Disbursement Entries"))
            {
                OpenViewLoansWindow("Pending Approval", "Open Loan Disbursement Entries", "Disbursement");
            }
            if (ChildNode.Equals("Approved Disbursement Entries"))
            {
                OpenViewLoansWindow("Approved", "Approved Loan Disbursement Entries", "Disbursement");
            }
            if (ChildNode.Equals("Rejected Disbursement Entries"))
            {
                OpenViewLoansWindow("Rejected", "Rejected Loan Disbursement Entries", "Disbursement");
            }
            //
            if (ChildNode.Equals("Active Loans"))
            {
                OpenViewLoansWindow("Active", "Active Loans", "Disbursement");
            }
            if (ChildNode.Equals("Defaulted Loans"))
            {
                OpenViewLoansWindow("Defaulted", "Defaulted Loans", "Disbursement");
            }
            if (ChildNode.Equals("Settled Loans"))
            {
                OpenViewLoansWindow("Settled", "Settled Loans", "Disbursement");
            }
            //
            if (ChildNode.Equals("Open Repayment Entries"))
            {
                OpenViewLoansWindow("Open", "Open Loan Repayment Entries", "Repayment");
            }
            if (ChildNode.Equals("Pending Approval Repayment Entries"))
            {
                OpenViewLoansWindow("Pending Approval", "Pending Approval Loan Repayment Entries", "Repayment");
            }
            if (ChildNode.Equals("Approved Repayment Entries"))
            {
                OpenViewLoansWindow("Approved", "Approved Loan Repayment Entries", "Repayment");
            }
            if (ChildNode.Equals("Rejected Repayment Entries"))
            {
                OpenViewLoansWindow("Rejected", "Rejected Loan Repayment Entries", "Repayment");
            }
        }

        private static void OpenViewLoansWindow(string status, string title, string Type)
        {
            Modules.Loans.ViewLoans _ViewLoans = new Modules.Loans.ViewLoans(status, title, Type);
            _ViewLoans.ShowDialog();
        }
    }
}
