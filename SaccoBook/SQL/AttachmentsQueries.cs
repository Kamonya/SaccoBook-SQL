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
    class AttachmentsQueries
    {
        static string connectionstring = AppResources.DatabaseConnection.ConnectionString();
        
        /**
        * Function creates new attachment record
               
        * @param DocumentId | The Document Id for the Record the attachment is being attached
        * @param Attachment | The attachment file name
        * @param FileExtension | The attachment file extension
        * @param FileType | The attachment file type (document, Media, File)
        * @param Description | The attachment description
        * @param User | The user that has added the attachment
        * @param LastModifiedBy | The user that last modified the record
        * @param LastModifiedAt | The time the record was last modified

        * @return bool | return true if attachment record is created / return false if not created
        */
        public static bool AddAttachment(string DocumentId, string Attachment, string FileExtension, string FileType, string Description, string User, string LastModifiedBy, string LastModifiedAt)
        {
            bool status = false;
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                conn.Open();

                string sql = @"INSERT INTO [saccobook].[attachments] (DocumentId, Attachment, FileExtension, FileType, Description, User, LastModifiedBy, LastModifiedAt) VALUES (@DocumentId, @Attachment, @FileExtension, @FileType, @Description, @User, @LastModifiedBy, @LastModifiedAt)";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@DocumentId", DocumentId);
                    cmd.Parameters.AddWithValue("@Attachment", Attachment);
                    cmd.Parameters.AddWithValue("@FileExtension", FileExtension);
                    cmd.Parameters.AddWithValue("@FileType", FileType);
                    cmd.Parameters.AddWithValue("@Description", Description);
                    cmd.Parameters.AddWithValue("@User", User);
                    cmd.Parameters.AddWithValue("@LastModifiedBy", LastModifiedBy);
                    cmd.Parameters.AddWithValue("@LastModifiedAt", LastModifiedAt);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    conn.Close();
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
        * Function deletes attachment file
        * 
        * @param Id | The record's id

        * @return bool | return true if record is deleted / return false if not deleted
        */
        public static bool DeleteAttachment(string Id)
        {
            bool status = false;

            string sql = "DELETE FROM [saccobook].[attachments] WHERE Id = @Id";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionstring;
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                conn.Close();

                status = true;

            }
            catch (SqlException es)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", es.ToString(),
                                    System.Diagnostics.EventLogEntryType.Warning);
            }
            return status;
        }
    }
}
