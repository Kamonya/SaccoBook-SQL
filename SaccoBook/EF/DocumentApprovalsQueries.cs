using DevExpress.XtraEditors;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaccoBook.EF
{
    class DocumentApprovalsQueries
    {
        static string connectionstring = AppResources.DatabaseConnection.ConnectionString();
        /**
        * Function creates Approval User
        * 
        * @param DocumentType | The document type to be approved
        * @param Approver | The user Login ID for the document Approver
        * @param ApprovalSequence | The approval sequence for the approver
        * @param ApproverEmail | The approver's email address
        * @param SubstituteApprover | The user Login ID for the document Approver's Substitute when approval request is delegated
        * @param SubstituteApproverEmail | The approver's substitute email address
        * @param LastModifiedBy | The user that last modified the record
        * @param LastModifiedAt | The time the record was last modified
        
        * @return bool | return true if approval user is created / return false if not created 
        */
        public static bool CreateApprovalUser(string DocumentType, string Approver, string ApprovalSequence, string ApproverEmail, string SubstituteApprover, string SubstituteApproverEmail, string LastModifiedBy, string LastModifiedAt)
        {
            bool status = false;
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                conn.Open();

                string sql = @"INSERT INTO [saccobook].[approvalusers](DocumentType, Approver, ApprovalSequence, ApproverEmail, SubstituteApprover, SubstituteApproverEmail, LastModifiedBy, LastModifiedAt) VALUES (@DocumentType, @Approver, @ApprovalSequence, @ApproverEmail, @SubstituteApprover, @SubstituteApproverEmail, @LastModifiedBy, @LastModifiedAt)";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@DocumentType", DocumentType);
                    cmd.Parameters.AddWithValue("@Approver", Approver);
                    cmd.Parameters.AddWithValue("@ApprovalSequence", ApprovalSequence);
                    cmd.Parameters.AddWithValue("@ApproverEmail", ApproverEmail);
                    cmd.Parameters.AddWithValue("@SubstituteApprover", SubstituteApprover);
                    cmd.Parameters.AddWithValue("@SubstituteApproverEmail", SubstituteApproverEmail);
                    cmd.Parameters.AddWithValue("@LastModifiedBy", LastModifiedBy);
                    cmd.Parameters.AddWithValue("@LastModifiedAt", LastModifiedAt);
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
        * Function updates Approval User 
        * 
        * @param Id | The document record Id
        * @param DocumentType | The document type to be approved
        * @param Approver | The user Login ID for the document Approver
        * @param ApprovalSequence | The approval sequence for the approver
        * @param ApproverEmail | The approver's email address
        * @param SubstituteApprover | The user Login ID for the document Approver's Substitute when approval request is delegated
        * @param SubstituteApproverEmail | The approver's substitute email address
        * @param LastModifiedBy | The user that last modified the record
        * @param LastModifiedAt | The time the record was last modified
        
        * @return bool | return true if approval user is updated / return false if not updated 
        */
        public static bool UpdateApprovalUser(string Id, string DocumentType, string Approver, string ApprovalSequence, string ApproverEmail, string SubstituteApprover, string SubstituteApproverEmail, string LastModifiedBy, string LastModifiedAt)
        {
            bool status = false;
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                conn.Open();

                string sql = @"UPDATE [saccobook].[approvalusers] SET DocumentType=@DocumentType,Approver=@Approver,ApprovalSequence=@ApprovalSequence,ApproverEmail=@ApproverEmail,SubstituteApprover=@SubstituteApprover,SubstituteApproverEmail=@SubstituteApproverEmail,LastModifiedBy=@LastModifiedBy,LastModifiedAt=@LastModifiedAt WHERE Id=@Id";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.Parameters.AddWithValue("@DocumentType", DocumentType);
                    cmd.Parameters.AddWithValue("@Approver", Approver);
                    cmd.Parameters.AddWithValue("@ApprovalSequence", ApprovalSequence);
                    cmd.Parameters.AddWithValue("@ApproverEmail", ApproverEmail);
                    cmd.Parameters.AddWithValue("@SubstituteApprover", SubstituteApprover);
                    cmd.Parameters.AddWithValue("@SubstituteApproverEmail", SubstituteApproverEmail);
                    cmd.Parameters.AddWithValue("@LastModifiedBy", LastModifiedBy);
                    cmd.Parameters.AddWithValue("@LastModifiedAt", LastModifiedAt);
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

        /********************************************* Approval Document *************************************************/

        /**
        * Function creates Approval Document
        * 
        * @param DocumentType | The document type 
        * @param ApprovalSequences | The number of approval sequences in document approval chain
        * @param LastModifiedBy | The user that last modified the record
        * @param LastModifiedAt | The time the record was last modified
        
        * @return bool | return true if approval document is created / return false if not created
        */
        public static bool CreateApprovalDocument(string DocumentType, string ApprovalSequences, string LastModifiedBy, string LastModifiedAt)
        {
            bool status = false;
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                conn.Open();

                string sql = @"INSERT INTO [saccobook].[appprovaldocumentsettings] (DocumentType, ApprovalSequences, LastModifiedBy, LastModifiedAt) VALUES (@DocumentType, @ApprovalSequences, @LastModifiedBy, @LastModifiedAt) ";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@DocumentType", DocumentType);
                    cmd.Parameters.AddWithValue("@ApprovalSequences", ApprovalSequences);
                    cmd.Parameters.AddWithValue("@LastModifiedBy", LastModifiedBy);
                    cmd.Parameters.AddWithValue("@LastModifiedAt", LastModifiedAt);
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
        * Function updates Approval Document
        * 
        * @param DocumentType | The document type 
        * @param ApprovalSequences | The number of approval sequences in document approval chain
        * @param LastModifiedBy | The user that last modified the record
        * @param LastModifiedAt | The time the record was last modified
        
        * @return bool | return true if approval document is updated / return false if not updated
        */
        public static bool UpdateApprovalDocument(string DocumentType, string ApprovalSequences, string LastModifiedBy, string LastModifiedAt)
        {
            bool status = false;
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                conn.Open();

                string sql = @"UPDATE [saccobook].[appprovaldocumentsettings] SET ApprovalSequences=@ApprovalSequences,LastModifiedBy=@LastModifiedBy,LastModifiedAt=@LastModifiedAt WHERE DocumentType=@DocumentType";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@DocumentType", DocumentType);
                    cmd.Parameters.AddWithValue("@ApprovalSequences", ApprovalSequences);
                    cmd.Parameters.AddWithValue("@LastModifiedBy", LastModifiedBy);
                    cmd.Parameters.AddWithValue("@LastModifiedAt", LastModifiedAt);
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
        * Function retuns list of Approval Documents  
        * 
        * @return string[] | returns string aray list of Documents which have been set up to use maker checker feature       
        */
        public static string[] GetApprovalDocumentList()
        {
            List<string> list = new List<string>();

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionstring;
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT DocumentType FROM [saccobook].[appprovaldocumentsettings]", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(reader.GetString(0));
                }

            }
            catch (SqlException es)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", es.ToString(),
                                      System.Diagnostics.EventLogEntryType.Warning);
            }
            return list.ToArray();
        }
        /**
        * Function retuns list of Approval Sequences in Approval Document
        * 
        * @param DocumentType | The Document type
        * 
        * @return string[] | returns string aray list of Approval sequences set up
        */
        public static string[] GetApprovalSequenceList(string DocumentType)
        {
            List<string> list = new List<string>();

            int ApprovalSequences = 0;

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionstring;
            conn.Open();
            try
            {
                string sql = "SELECT [ApprovalSequences] FROM [Sacco Book].[saccobook].[appprovaldocumentsettings] WHERE DocumentType ='" + DocumentType + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    ApprovalSequences = Convert.ToInt16(reader["ApprovalSequences"].ToString());

                }

                for(int i = 1; i <= ApprovalSequences; i++)
                {
                    list.Add(i.ToString());
                }

            }
            catch (SqlException es)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", es.ToString(),
                                      System.Diagnostics.EventLogEntryType.Warning);
            }
            return list.ToArray();
        }
        /**
        * Function retuns list of Approval Users and Approval sequence for a specified document
        * 
        * @param DocumentType | The Document type
        * 
        * @return string | returns JSON string list of Approval users set up for a specified document type
        */
        public static string GetApprovalUsers(string DocumentType)
        {
            List<ApprovalUser> list = new List<ApprovalUser>();

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionstring;
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT DocumentType, Approver,ApprovalSequence, ApproverEmail FROM [saccobook].[approvalusers] WHERE DocumentType = '" + DocumentType + "'", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string _DocumentType = reader.GetString(0);
                    string Approver = reader.GetString(1);
                    int ApprovalSequence = reader.GetInt32(2);
                    string ApproverEmail = reader.GetString(3);

                    list.Add(new ApprovalUser { 
                            DocumentType = _DocumentType, 
                            Approver = Approver, 
                            ApprovalSequence = ApprovalSequence, 
                            ApproverEmail = ApproverEmail
                    });
                }

            }
            catch (SqlException es)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", es.ToString(),
                                      System.Diagnostics.EventLogEntryType.Warning);
            }
            return JsonConvert.SerializeObject(list);
        }
        public static bool GetCheckIfApprovalUserIsSet(string DocumentType)
        {
            bool status = false;

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionstring;
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT DocumentType, Approver,ApprovalSequence, ApproverEmail FROM [saccobook].[approvalusers] WHERE DocumentType = '" + DocumentType + "'", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    status = true;
                }

            }
            catch (SqlException es)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", es.ToString(),
                                      System.Diagnostics.EventLogEntryType.Warning);
            }
            return status;
        }
        /**
        * Function retuns substitute approver at a specified sequence of a specified document
        * 
        * @param DocumentType | The Document type
        * @param ApprovalSequence | The Approval Sequence
        * 
        * @return string | returns substitute approver at a specified sequence of a specified document
        */
        public static string GetApprovalUserSubstitute(string DocumentType, string ApprovalSequence)
        {
            string _SubstituteApprover = null;

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionstring;
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT SubstituteApprover FROM [saccobook].[approvalusers] WHERE DocumentType = '" + DocumentType + "' AND ApprovalSequence = '"+ ApprovalSequence + "'", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    _SubstituteApprover = reader.GetString(0);
                }

            }
            catch (SqlException es)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", es.ToString(),
                                      System.Diagnostics.EventLogEntryType.Warning);
            }
            return _SubstituteApprover;
        }
    }
}
