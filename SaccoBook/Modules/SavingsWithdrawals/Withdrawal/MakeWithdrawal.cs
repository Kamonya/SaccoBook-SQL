using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using SaccoBook.AppResources;

namespace SaccoBook.Modules.SavingsWithdrawals.Withdrawal
{
    public partial class MakeWithdrawal : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        string MembershipNumber = null;
        string _NumberSeriesCode = XMLFormatter.GetContent("WithdrawalsNumberSeriesCode");
        bool Edit = false;
        bool IsDocumentCreated = false;
        public MakeWithdrawal()
        {
            InitializeComponent();

            EF.MemberQueries.LoadActiveMembers(_Search, _Search.EditValue.ToString());

            GetDocumentNumber(_NumberSeriesCode);
        }
        public MakeWithdrawal(string DocumentNumber, bool _Edit)
        {
            InitializeComponent();

            Edit = _Edit;

            EF.MemberQueries.LoadActiveMembers(_Search, _Search.EditValue.ToString());

            GetDocumentNumber(_NumberSeriesCode);
            
            MembershipNumber = LoadWithdrawal(DocumentNumber);

            LoadMemberInformation(MembershipNumber);
        }
        public MakeWithdrawal(string DocumentNumber)
        {
            InitializeComponent();
            btn_save.Enabled = false;
            btn_sendapprovalrequest.Enabled = false;
            _Search.Enabled = false;

            MembershipNumber = LoadWithdrawal(DocumentNumber);

            LoadMemberInformation(MembershipNumber);
            
            btn_addattachment.Enabled = false;

            AppResources.DevexpressFunctions.EnableDisableForm(layoutControl1, true);
        }
        private void LoadMemberInformation(string MembershipNumber)
        {
            SplashScreenManager.ShowForm(this, typeof(AppWaitForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Please wait");
            SplashScreenManager.Default.SetWaitFormDescription("Loading...");

            string GetMemberInfoJSON = EF.MemberQueries.GetMemberInfo(MembershipNumber);
            Member jsonGetMemberInfo = JsonConvert.DeserializeObject<Member>(GetMemberInfoJSON);

            _MembershipNumber.Text = MembershipNumber;
            _Name.Text = jsonGetMemberInfo.Name;
            _NationalIdNumber.Text = jsonGetMemberInfo.NationalIdNumber;
            _DateJoined.Text = jsonGetMemberInfo.DateJoined.ToString();
            _MembershipStatus.Text = jsonGetMemberInfo.MembershipStatus;

            SplashScreenManager.CloseForm();
        }
        private string LoadWithdrawal(string DocumentNumber)
        {
            string MembershipNumber = null;

            string SavingsLine = EF.SavingsQueries.GetSavingInfo(DocumentNumber);

            dynamic jsonSavingsLine = JObject.Parse(SavingsLine);

            string AccountNumber = jsonSavingsLine.DestinationAccount;
            double DepositAmount = jsonSavingsLine.CreditAmount;
            // DocumentNumber = DocumentNumber,
            MembershipNumber = jsonSavingsLine.MembershipNumber;
            string TransactionType = jsonSavingsLine.TransactionType;
            string Source = jsonSavingsLine.Source;
            string SourceAccount = jsonSavingsLine.SourceAccount;
            string AccountType = jsonSavingsLine.AccountType;
            string Description = jsonSavingsLine.Description;
            string ReferenceNo = jsonSavingsLine.ReferenceNo;
            string TransactionDate = jsonSavingsLine.TransactionDate;
            string GLAccount = jsonSavingsLine.GLAccount;
            string DebitAmount = jsonSavingsLine.DebitAmount;
            string CreditAmount = jsonSavingsLine.CreditAmount;
            string Status = jsonSavingsLine.Status;
            string LastModifiedBy = jsonSavingsLine.LastModifiedBy;
            string LastModifiedAt = jsonSavingsLine.LastModifiedAt;
            string DestinationAccount = jsonSavingsLine.DestinationAccount;
            string Destination = jsonSavingsLine.Destination;


            _DocumentNumber.Text = DocumentNumber;
            _MembershipNumber.Text = MembershipNumber;
            _Destination.EditValue = Destination;
            _DestinationAccountNumber.EditValue = DestinationAccount;
            _SourceAccountType.EditValue = Source;
            _Destination.Text = Destination;
            _SourceAccount.Text = SourceAccount;
            _Description.Text = Description;
            _ReferenceNumber.Text = ReferenceNo;
            _TransactionDate.Text = TransactionDate;
            _Amount.Text = DebitAmount;
            _Status.Text = Status;

            if (Status != "Open")
            {
                btn_addattachment.Enabled = false;
            }           

            double TotalBalance = EF.SavingsQueries.GetSavingsAccountBalance(DestinationAccount, "Balance");

            _SourceAccountBalance.Text = TotalBalance.ToString();

            return MembershipNumber;
        }
        private void GetDocumentNumber(string DocumentNumberSeriesCode)
        {
            string _NumberSeriesData = EF.NumberSeriesQueries.GetNumberSeriesInfo(DocumentNumberSeriesCode);

            dynamic responseObject = JObject.Parse(_NumberSeriesData);
            string LastUsedNumber = responseObject.LastUsedNumber;

            if (LastUsedNumber != "")
            {
                _DocumentNumber.Text = AppResources.AppFunctions.GetNewDocumentNumber(DocumentNumberSeriesCode, LastUsedNumber);
                _Status.Text = "Open";
            }
            else
            {
                XtraMessageBox.Show("Encountered an error: The document number series has not been properly configured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AppResources.DevexpressFunctions.EnableDisableForm(layoutControl1, true);
            }
        }
        private void _Source_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (_Destination.Text == "To Cash")
            {
                _DestinationMember.Enabled = false;
                _DestinationAccountNumber.Enabled = false;
                _DestinationBankAccount.Enabled = false;
            }
            else if(_Destination.Text == "To Bank")
            {
                _DestinationMember.Enabled = false;
                _DestinationAccountNumber.Enabled = false;
                _DestinationBankAccount.Enabled = true;
                EF.BankQueries.LoadMembersBankAccounts(_DestinationBankAccount, _Search.EditValue.ToString());
            }
            else if (_Destination.Text == "To Members Own Account")
            {
                _DestinationMember.Enabled = false;
                _DestinationAccountNumber.Enabled = true;
                _DestinationBankAccount.Enabled = false;
                EF.SavingsQueries.LoadMembersActiveAccounts(_DestinationAccountNumber, _Search.EditValue.ToString());
            }
            else if (_Destination.Text == "To Other Members Account")
            {
                _DestinationMember.Enabled = true;
                _DestinationAccountNumber.Enabled = true;
                _DestinationBankAccount.Enabled = false;
                EF.MemberQueries.LoadMembers(_DestinationMember, _Search.EditValue.ToString());
                EF.SavingsQueries.LoadMembersActiveAccounts(_DestinationAccountNumber, _DestinationMember.EditValue.ToString());
            }
        }

        private void _Member_EditValueChanged(object sender, EventArgs e)
        {
            if(_DestinationMember.EditValue.ToString() != null)
            {
                EF.SavingsQueries.LoadMembersActiveAccounts(_DestinationAccountNumber, _DestinationMember.EditValue.ToString());
            }            
        }
        private bool CreateWithdrawal()
        {
            bool status = false;
            if (dxValidationProviderMakeSaving.Validate().Equals(true))
            {
                string DocumentNumber = _DocumentNumber.Text;
                string MembershipNumber = _MembershipNumber.Text;
                string TransactionType = "Withdrawal";
                string Source = _Destination.EditValue.ToString();
                string SourceAccount = _SourceAccount.EditValue.ToString();
                string AccountType = _SourceAccountType.EditValue.ToString();
                string Destination = _Destination.Text;
                string DestinationAccount = _DestinationAccountNumber.Text;
                string Description = _Description.Text;
                string ReferenceNo = _ReferenceNumber.Text;
                string TransactionDate = _TransactionDate.Text;
                string Status = "Open";
                string CreatedBy = Login.LoggedInUser;
                string LastModifiedBy = Login.LoggedInUser;
                string LastModifiedAt = DateTime.Now.ToString();

                ///G/L

                string GLAccount = "";
                double DebitAmount = Convert.ToDouble(_Amount.Text.Trim().Replace(",",""));
                double CreditAmount = 0;

                if (EF.SavingsQueries.CreateSavingWithdrawal(DocumentNumber, MembershipNumber, TransactionType, Source, SourceAccount, AccountType, Destination, DestinationAccount, Description, ReferenceNo, TransactionDate, GLAccount, CreditAmount, DebitAmount, Status, CreatedBy, LastModifiedBy, LastModifiedAt))
                {
                    EF.NumberSeriesQueries.UpdateLastUsedNumberSeries(_NumberSeriesCode, DocumentNumber);

                    IsDocumentCreated = true;

                    status = true;
                }

            }
            return status;
        }
        private bool UpdateWithdrawal()
        {
            bool status = false;
            if (dxValidationProviderMakeSaving.Validate().Equals(true))
            {
                string DocumentNumber = _DocumentNumber.Text;
                string MembershipNumber = _MembershipNumber.Text;
                string TransactionType = "Withdrawal";
                string Source = _Destination.EditValue.ToString();
                string SourceAccount = _DestinationAccountNumber.EditValue.ToString();
                string AccountType = _SourceAccountType.EditValue.ToString();
                string Destination = _Destination.Text;
                string DestinationAccount = _SourceAccount.Text;
                string Description = _Description.Text;
                string ReferenceNo = _ReferenceNumber.Text;
                string TransactionDate = _TransactionDate.Text;
                string Status = "Open";
                string CreatedBy = Login.LoggedInUser;
                string LastModifiedBy = Login.LoggedInUser;
                string LastModifiedAt = DateTime.Now.ToString();

                ///G/L

                string GLAccount = "";
                string DebitAmount = _Amount.Text;                

                string CreditAmount  = "0.00";

                DebitAmount = DebitAmount.Replace(",", "");

                if (EF.SavingsQueries.UpdateSavingWithdrawal(DocumentNumber, MembershipNumber, TransactionType, Source, SourceAccount, AccountType, Destination, DestinationAccount, Description, ReferenceNo, TransactionDate, GLAccount, CreditAmount, DebitAmount, Status, CreatedBy, LastModifiedBy, LastModifiedAt))
                {
                    status = true;
                }

            }
            return status;
        }
        public static bool SendApprovalRequest(string ApprovalDocumentNumber)
        {
            bool status = false;

            DialogResult dlr = XtraMessageBox.Show("Are you sure you want to send record for approval?", "System Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlr == DialogResult.Yes)
            {
                //Created,Open,Canceled,Rejected,Approved

                //send for approval
                if (AppResources.MakerChecker.SendApprovalRequest("Withdrawal", ApprovalDocumentNumber, "[saccobook].[membersavings]"))
                {
                    status = true;
                }
                
            }
            return status;
        }

        private void btn_save_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Edit)
            {
                if (UpdateWithdrawal())
                {
                    alertControl1.Show(this, "Success!", "Information has been successfully saved");
                    //XtraMessageBox.Show("Information has been successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (IsDocumentCreated)
                {
                    if (UpdateWithdrawal())
                    {
                        alertControl1.Show(this, "Success!", "Information has been successfully saved");
                        //XtraMessageBox.Show("Information has been successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {                    
                    if (CreateWithdrawal())
                    {
                        alertControl1.Show(this, "Success!", "Information has been successfully saved");
                        //XtraMessageBox.Show("Information has been successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                
            }
        }

        private void btn_sendapprovalrequest_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Edit)
            {
                if (UpdateWithdrawal())
                {
                    if (_Status.Text == "Open")
                    {
                        if (SendApprovalRequest(_DocumentNumber.Text))
                        {
                            _Status.Text = "Pending Approval";

                            XtraMessageBox.Show("Information has been successfully saved and an approval request sent to the approver", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Encountered an error: The record has already been sent for Approval", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (!IsDocumentCreated)
                {
                    if (CreateWithdrawal())
                    {
                        if (_Status.Text == "Open")
                        {
                            if (SendApprovalRequest(_DocumentNumber.Text))
                            {
                                _Status.Text = "Pending Approval";

                                XtraMessageBox.Show("Information has been successfully saved and an approval request sent to the approver", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            XtraMessageBox.Show("Encountered an error: The record has already been sent for Approval", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    if (UpdateWithdrawal())
                    {
                        if (_Status.Text == "Open")
                        {
                            if (SendApprovalRequest(_DocumentNumber.Text))
                            {
                                _Status.Text = "Pending Approval";

                                XtraMessageBox.Show("Information has been successfully saved and an approval request sent to the approver", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            XtraMessageBox.Show("Encountered an error: The record has already been sent for Approval", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
               
            }
        }

        private void _Search_EditValueChanged(object sender, EventArgs e)
        {
            if (_Search.EditValue != null)
            {
                SplashScreenManager.ShowForm(this, typeof(AppWaitForm), true, true, false);
                SplashScreenManager.Default.SetWaitFormCaption("Please wait");
                SplashScreenManager.Default.SetWaitFormDescription("Loading...");

                string MembershipNumber = _Search.EditValue.ToString();

                string GetMemberInfoJSON = EF.MemberQueries.GetMemberInfo(MembershipNumber);
                Member jsonGetMemberInfo = JsonConvert.DeserializeObject<Member>(GetMemberInfoJSON);

                _MembershipNumber.Text = MembershipNumber;
                _Name.Text = jsonGetMemberInfo.Name;                
                _NationalIdNumber.Text = jsonGetMemberInfo.NationalIdNumber;
                _DateJoined.Text = jsonGetMemberInfo.DateJoined.ToString();
                _MembershipStatus.Text = jsonGetMemberInfo.MembershipStatus;

                EF.SavingsQueries.LoadMembersActiveAccounts(_SourceAccountType, _Search.EditValue.ToString());

                SplashScreenManager.CloseForm();
            }
        }
        
        private void _SourceAccountType_EditValueChanged(object sender, EventArgs e)
        {
            _SourceAccount.Text = _SourceAccountType.EditValue.ToString();

            double TotalBalance = EF.SavingsQueries.GetSavingsAccountBalance(_SourceAccount.Text, "Balance");

            _SourceAccountBalance.Text = TotalBalance.ToString();
        }

        private void btn_addattachment_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_DocumentNumber.Text != "" && _Status.Text == "Open")
            {
                AddAttachment _AddAttachment = new AddAttachment(_DocumentNumber.Text);
                _AddAttachment.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("Encountered an error: You must select the savings account type first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_viewattachments_ItemClick(object sender, ItemClickEventArgs e)
        {
            Attachments _Attachments = new Attachments(_DocumentNumber.Text);
            _Attachments.ShowDialog();
        }
    }
    
}