using DevExpress.XtraEditors;
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
    class AttachmentsQueries
    {        
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

            try
            {               
                using(var db = new SaccoBookEntities())
                {
                    var attachment = new attachment()
                    {
                        DocumentId = DocumentId,
                        Attachment1 = Attachment,
                        FileExtension = FileExtension,
                        FileType = FileType,
                        Description = Description,
                        User = User,
                        LastModifiedAt = LastModifiedAt,
                        LastModifiedBy = LastModifiedBy
                    };
                    db.attachments.Add(attachment);
                    db.SaveChanges();
                }
            }

            catch (Exception es)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", es.ToString(),
                                      System.Diagnostics.EventLogEntryType.Error);
            }
            return status;
        }
        /**
        * Function deletes attachment file
        * 
        * @param Id | The record's id

        * @return bool | return true if record is deleted / return false if not deleted
        */
        public static bool DeleteAttachment(int Id)
        {
            bool status = false;
            try
            {
                using (var db = new SaccoBookEntities())
                {
                    attachment attachment = db.attachments.Where(x => x.Id == Id).SingleOrDefault();
                    if (attachment == null)
                    {
                        status = false;
                    }
                    else
                    {
                        db.attachments.Remove(attachment);
                        db.SaveChanges();
                        status = true;
                    }
                }
            }
            catch (Exception es)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", es.ToString(),
                                    System.Diagnostics.EventLogEntryType.Error);
            }
            return status;
        }
    }
}
