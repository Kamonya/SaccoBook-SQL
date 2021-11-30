using DevExpress.XtraEditors;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaccoBook.AppResources
{
    class MakerChecker
    {
        /**
        * Function returns true if approval request is sent
        * @param _DocumentType | The record document type     
        * @param _DocumentNumber | The record record number

        * @return bool | return true if approval entry is created / return false if not created
        */
        public static bool SendApprovalRequest(string _DocumentType, string _DocumentNumber, string ParentTable)
        {
            string ApprovalStatus = null; //Created,Open,Canceled,Rejected,Approved
            string ApproverEmail = null;
            string ApproverName = null;

            bool ApprovalEntryCreated = false;

            if(EF.DocumentApprovalsQueries.GetCheckIfApprovalUserIsSet(_DocumentType))
            {
                //Get List of approval users then create Approval Entries (Make Reusable)
                string ApprovalUsersList = EF.DocumentApprovalsQueries.GetApprovalUsers(_DocumentType);

                //create approval entries for each of the Approvers, for first approver in the sequence, set to 'Open', the remaining, set to 'Created'

                dynamic jsonApprovalUsersList = JsonConvert.DeserializeObject(ApprovalUsersList);

                //loop through approval users json array

                foreach (var ApprovalUser in jsonApprovalUsersList)
                {
                    string DocumentType = ApprovalUser.DocumentType;
                    string Approver = ApprovalUser.Approver;

                    int ApprovalSequence = ApprovalUser.ApprovalSequence;

                    if (ApprovalSequence == 1)
                    {
                        ApprovalStatus = "Open";
                        ApproverEmail = ApprovalUser.ApproverEmail;
                        ApproverName = ApprovalUser.Approver;
                    }
                    else
                    {
                        ApprovalStatus = "Created";
                    }
                    //create Approval Entry
                    ApprovalEntryCreated = EF.ApprovalEntriesQueries.CreateApprovalEntry(_DocumentType, _DocumentNumber, ApprovalSequence, Login.LoggedInUser, Approver, ApprovalStatus, DateTime.Now.ToString(), DateTime.Now.ToString(), Login.LoggedInUser);
                }
                //Update Parent Table

                EF.ApprovalEntriesQueries.UpdateApprovalEntryParentTable(ParentTable, _DocumentNumber, "Pending Approval", DateTime.Now.ToString(), Login.LoggedInUser);

                //if sender has an approval entry approve it

                ApproveSenderApprovalEntryIfExist(_DocumentType, _DocumentNumber);



                //Send Approval request notifications

                string MemberRegistrationSetting = EF.NotificationTemplatesQueries.GetNotificationSettingInfo("REQUESTDOCUMENTAPPROVAL");

                dynamic GetNotificationSettingInfoResponseObject = JObject.Parse(MemberRegistrationSetting);

                string NotificationTemplateId = GetNotificationSettingInfoResponseObject.NotificationTemplateId;

                bool NotificationsEnabled = GetNotificationSettingInfoResponseObject.NotificationsEnabled;

                if (AppResources.AppConstants.IsSytemNotificationsEnabled())
                {
                    if (NotificationsEnabled)
                    {
                        EF.NotificationTemplatesQueries.QueueNotification(NotificationTemplateId, "", ApproverName, "", "", "", "", "", "", DateTime.Now.ToString("dd/MM/yyyy"), DateTime.Now.ToShortTimeString(), ApproverEmail, _DocumentType + " Approval");
                    }
                }
                
            }
            else
            {
                XtraMessageBox.Show("Encountered an error: The record cannot be sent for Approval because the approval users have not been set up", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ApprovalEntryCreated;
        }

        private static void ApproveSenderApprovalEntryIfExist(string DocumentType, string DocumentNumber)
        {
            string sql = @"SELECT EntryNumber, DocumentType, DocumentNumber, SequenceNumber, SenderId, ApproverId, Status, DateTimeSentForApproval, LastModifiedAt, LastModifiedBy FROM [saccobook].[approvalentries] WHERE ApproverId = '" + Login.LoggedInUser + "' AND Status = 'Open' AND DocumentType = '" + DocumentType + "' AND DocumentNumber = '"+ DocumentNumber + "' ";

        }

        /**
* Function returns true if approval entry record sequence is updated
* @param EntryNumber | The record entry    
* @param SequenceNumber | The record sequence number
* @param _DocumentType | The record document type     
* @param _DocumentNumber | The record's record number
* @param Table | The record record's parent

* @return bool | return true if approval entry is created / return false if not created
*/
        public static bool ApproveAppovalRequest(int EntryNumber, int SequenceNumber, string _DocumentType, string _DocumentNumber, string Table)
        { 
            bool ApprovalEntryCreated = false;

            int PendingApprovals = 0;

            // Update status to 'Approved' for specified DocumentNumber and Document Type where Approver is loggedIn user
            bool IsRecordApproved = EF.ApprovalEntriesQueries.UpdateApprovalEntry(EntryNumber, _DocumentType, _DocumentNumber, "Approved", DateTime.Now.ToString(), Login.LoggedInUser);

            if (IsRecordApproved)
            {
                //check if there are approvers in sequence

                PendingApprovals = EF.ApprovalEntriesQueries.GetNumberOfPendingApprovers(_DocumentType, _DocumentNumber);

                if (PendingApprovals > 0)
                {
                    //take current approval sequence and add 1 to get new approval sequence

                    SequenceNumber = SequenceNumber + 1;

                    //with the new approval sequence, update status to Open

                    ApprovalEntryCreated = EF.ApprovalEntriesQueries.UpdateApprovalEntrySequence(SequenceNumber, _DocumentType, _DocumentNumber, "Open", DateTime.Now.ToString(), Login.LoggedInUser);
                }
                else if (PendingApprovals == 0)
                {
                    //if no approver in sequence, update parent table status

                    ApprovalEntryCreated = true;

                    EF.ApprovalEntriesQueries.UpdateApprovalEntryParentTable(Table, _DocumentNumber, "Approved", DateTime.Now.ToString(), Login.LoggedInUser);
                }
            }
            return ApprovalEntryCreated;
        }
        /**
        * Function returns true if approval entry record sequence is rejected     
        * @param _DocumentType | The record document type     
        * @param _DocumentNumber | The record's record number

        * @return bool | return true if approval entry is rejected / return false if not rejected
        */
        public static bool RejectAppovalRequest(string _DocumentType, string _DocumentNumber)
        {
            //set all approval entries record to Rejected
            bool IsRecordApproved = EF.ApprovalEntriesQueries.RejectApprovalRequest(_DocumentType, _DocumentNumber, "Rejected", DateTime.Now.ToString(), Login.LoggedInUser);

            return IsRecordApproved;
        }
        /**
        * Function returns true if approval entry record sequence is delegated     
        * @param _DocumentType | The record document type     
        * @param _DocumentNumber | The record's record number

        * @return bool | return true if approval entry is delegated / return false if not delegated
        */
        public static bool DelegateAppovalRequest(int EntryNumber, string DocumentType, string ApprovalSequence)
        {
            //Get Document approver substitute
            string ApprovalSubstitute = EF.DocumentApprovalsQueries.GetApprovalUserSubstitute(DocumentType, ApprovalSequence);
            
            //Update Approval User 
            bool IsRecordDelegated = EF.ApprovalEntriesQueries.UpdateApprovalRequestApproverId(EntryNumber, ApprovalSubstitute, DateTime.Now.ToString(), Login.LoggedInUser);

            return IsRecordDelegated;
        }
    }
}
