using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaccoBook.SQL
{
    class ApprovalEntriesQueries
    {
        static string connectionstring = AppResources.DatabaseConnection.ConnectionString();

        /**
        * Function returns true if approval entry record is created
        * 
        * @param DocumentType | The record document type
        * @param DocumentNumber | The record document number
        * @param SequenceNumber | The document approval sequence number
        * @param SenderId | The record sender Id/Username
        * @param ApproverId | The record approver Id/Username
        * @param Status | The record approval status
        * @param DateTimeSentForApproval | The record Date & Time Sent For Approval
        * @param LastModifiedBy | The user that last modified the record
        * @param LastModifiedAt | The time the record was last modified

        * @return bool | return true if approval entry is created / return false if not created
        */
        public static bool CreateApprovalEntry(string DocumentType, string DocumentNumber, string SequenceNumber, string SenderId, string ApproverId, string Status, string DateTimeSentForApproval, string LastModifiedAt, string LastModifiedBy)
        {
            bool status = false;
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                conn.Open();

                string sql = @"INSERT INTO [saccobook].[approvalentries](DocumentType, DocumentNumber, SequenceNumber, SenderId, ApproverId, Status, DateTimeSentForApproval, LastModifiedAt, LastModifiedBy) VALUES (@DocumentType, @DocumentNumber, @SequenceNumber, @SenderId, @ApproverId, @Status, @DateTimeSentForApproval, @LastModifiedAt, @LastModifiedBy)";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@DocumentType", DocumentType);
                    cmd.Parameters.AddWithValue("@DocumentNumber", DocumentNumber);
                    cmd.Parameters.AddWithValue("@SequenceNumber", SequenceNumber);
                    cmd.Parameters.AddWithValue("@SenderId", SenderId);
                    cmd.Parameters.AddWithValue("@ApproverId", ApproverId);
                    cmd.Parameters.AddWithValue("@Status", Status);
                    cmd.Parameters.AddWithValue("@DateTimeSentForApproval", DateTimeSentForApproval);
                    cmd.Parameters.AddWithValue("@LastModifiedAt", LastModifiedAt);
                    cmd.Parameters.AddWithValue("@LastModifiedBy", LastModifiedBy);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    status = true;
                }
            }

            catch (SqlException ex)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", ex.ToString(),
                                       System.Diagnostics.EventLogEntryType.Warning);
            }
            return status;
        }
        /**
        * Function returns true if approval entry record is updated
        * 
        * @param EntryNumber | The record entry number     
        * @param Status | The record approval status
        * @param LastModifiedBy | The user that last modified the record
        * @param LastModifiedAt | The time the record was last modified

        * return bool | return true if approval entry is updated / return false if not updated 
        */
        public static bool UpdateApprovalEntry(int EntryNumber, string DocumentType, string DocumentNumber, string Status, string LastModifiedAt, string LastModifiedBy)
        {
            bool status = false;
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                conn.Open();

                string sql = @"UPDATE [saccobook].[approvalentries] SET Status=@Status,LastModifiedAt=@LastModifiedAt,LastModifiedBy=@LastModifiedBy WHERE EntryNumber=@EntryNumber AND DocumentType=@DocumentType AND DocumentNumber=@DocumentNumber";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@EntryNumber", EntryNumber);
                    cmd.Parameters.AddWithValue("@DocumentType", DocumentType);
                    cmd.Parameters.AddWithValue("@DocumentNumber", DocumentNumber);
                    cmd.Parameters.AddWithValue("@Status", Status);
                    cmd.Parameters.AddWithValue("@LastModifiedAt", LastModifiedAt);
                    cmd.Parameters.AddWithValue("@LastModifiedBy", LastModifiedBy);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    status = true;
                }
            }
            catch (SqlException ex)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", ex.ToString(),
                                       System.Diagnostics.EventLogEntryType.Warning);
            }
            return status;
        }
        /**
        * Function returns true if approval entry record sequence is updated
        * 
        * @param EntryNumber | The record entry number     
        * @param Status | The record approval status
        * @param LastModifiedBy | The user that last modified the record
        * @param LastModifiedAt | The time the record was last modified

        * return bool | return true if approval entry status is updated / return false if not updated  
        */
        public static bool UpdateApprovalEntrySequence(int SequenceNumber, string DocumentType, string DocumentNumber, string Status, string LastModifiedAt, string LastModifiedBy)
        {
            bool status = false;
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                conn.Open();

                string sql = @"UPDATE [saccobook].[approvalentries] SET Status=@Status,LastModifiedAt=@LastModifiedAt,LastModifiedBy=@LastModifiedBy WHERE SequenceNumber=@SequenceNumber AND DocumentType=@DocumentType AND DocumentNumber=@DocumentNumber";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@SequenceNumber", SequenceNumber);
                    cmd.Parameters.AddWithValue("@DocumentType", DocumentType);
                    cmd.Parameters.AddWithValue("@DocumentNumber", DocumentNumber);
                    cmd.Parameters.AddWithValue("@Status", Status);
                    cmd.Parameters.AddWithValue("@LastModifiedAt", LastModifiedAt);
                    cmd.Parameters.AddWithValue("@LastModifiedBy", LastModifiedBy);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    status = true;
                }
            }
            catch (SqlException ex)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", ex.ToString(),
                                       System.Diagnostics.EventLogEntryType.Warning);
            }
            return status;
        }
        /**
        * Function returns number of approvers pending
        * 
        * @param EntryNumber | The record entry number     
        * @param Status | The record approval status
        * @param LastModifiedBy | The user that last modified the record
        * @param LastModifiedAt | The time the record was last modified

        * @return List<MemberBankAccount> | returns a List of member's bank accounts 
        */
        public static int GetNumberOfPendingApprovers(string DocumentType, string DocumentNumber)
        {
            int Records = 0;
            SqlConnection conn = new SqlConnection(connectionstring);

            string sql = @"SELECT COUNT(EntryNumber) as Records FROM [saccobook].[approvalentries] WHERE (DocumentNumber ='" + DocumentNumber + "' AND DocumentType = '"+ DocumentType + "') AND Status= 'Created'";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                 
                if (dr.Read())
                {
                    Records = Convert.ToInt32(dr["Records"].ToString());
                }
                conn.Close();
            }
            catch (SqlException ex)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", ex.ToString(),
                                     System.Diagnostics.EventLogEntryType.Warning);
            }

           
            return Records;
        }
        /**
        * Function returns true if approval entry record sequence is updated
        * 
        * @param EntryNumber | The record entry number     
        * @param Status | The record approval status
        * @param LastModifiedBy | The user that last modified the record
        * @param LastModifiedAt | The time the record was last modified

        * return bool | return true if approval entry status is updated / return false if not updated  
        */
        public static bool UpdateApprovalEntryParentTable(string Table, string DocumentNumber, string Status, string LastModifiedAt, string LastModifiedBy)
        {
            bool status = false;
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                conn.Open();

                string sql = @"UPDATE " + Table + " SET Status=@Status,LastModifiedBy=@LastModifiedBy,LastModifiedAt=@LastModifiedAt WHERE DocumentNumber =@DocumentNumber";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {                   
                    cmd.Parameters.AddWithValue("@DocumentNumber", DocumentNumber);
                    cmd.Parameters.AddWithValue("@Status", Status);
                    cmd.Parameters.AddWithValue("@LastModifiedAt", LastModifiedAt);
                    cmd.Parameters.AddWithValue("@LastModifiedBy", LastModifiedBy);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    status = true;
                }
            }
            catch (SqlException ex)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", ex.ToString(),
                                      System.Diagnostics.EventLogEntryType.Warning);
            }
            return status;
        }
        /**
        * Function returns true if approval entry record is rejected    
        * 
        * @param Status | The record approval status
        * @param LastModifiedBy | The user that last modified the record
        * @param LastModifiedAt | The time the record was last modified

        * return bool | return true if approval entry is rejected / return false if not rejected 
        */
        public static bool RejectApprovalRequest(string DocumentType, string DocumentNumber, string Status, string LastModifiedAt, string LastModifiedBy)
        {
            bool status = false;
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                conn.Open();

                string sql = @"UPDATE [saccobook].[approvalentries] SET Status=@Status,LastModifiedAt=@LastModifiedAt,LastModifiedBy=@LastModifiedBy WHERE DocumentType=@DocumentType AND DocumentNumber=@DocumentNumber";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@DocumentType", DocumentType);
                    cmd.Parameters.AddWithValue("@DocumentNumber", DocumentNumber);
                    cmd.Parameters.AddWithValue("@Status", Status);
                    cmd.Parameters.AddWithValue("@LastModifiedAt", LastModifiedAt);
                    cmd.Parameters.AddWithValue("@LastModifiedBy", LastModifiedBy);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    status = true;
                }
            }
            catch (SqlException ex)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", ex.ToString(),
                                      System.Diagnostics.EventLogEntryType.Warning);
            }
            return status;
        }

        /**
        * Function returns true if approval entry record is rejected  
        * 
        * @param Status | The record approval status
        * @param LastModifiedBy | The user that last modified the record
        * @param LastModifiedAt | The time the record was last modified

        * return bool | return true if approval entry is rejected / return false if not rejected 
        */
        public static bool UpdateApprovalRequestApproverId(int EntryNumber, string ApproverId, string LastModifiedAt, string LastModifiedBy)
        {
            bool status = false;
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                conn.Open();

                string sql = @"UPDATE [saccobook].[approvalentries] SET ApproverId=@ApproverId,LastModifiedAt=@LastModifiedAt,LastModifiedBy=@LastModifiedBy WHERE EntryNumber=@EntryNumber";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@EntryNumber", EntryNumber);
                    cmd.Parameters.AddWithValue("@ApproverId", ApproverId);
                    cmd.Parameters.AddWithValue("@LastModifiedAt", LastModifiedAt);
                    cmd.Parameters.AddWithValue("@LastModifiedBy", LastModifiedBy);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    status = true;
                }
            }
            catch (SqlException ex)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", ex.ToString(),
                                      System.Diagnostics.EventLogEntryType.Warning);
            }
            return status;
        }
        /** 
        * Function returns sql string to fetch approval entries 
        * 
        * @param Status | The record approval status

        * return string | returns sql string to fetch approval entries
        */
        public static string LoadApprovalEntries(string status)
        {
            string sql = @"SELECT EntryNumber, DocumentType, DocumentNumber, SequenceNumber, SenderId, ApproverId, Status, DateTimeSentForApproval, LastModifiedAt, LastModifiedBy FROM [saccobook].[approvalentries] WHERE ApproverId = '" + Login.LoggedInUser + "' AND Status = '" + status + "'";
            
            return sql;
        }

    }
}
