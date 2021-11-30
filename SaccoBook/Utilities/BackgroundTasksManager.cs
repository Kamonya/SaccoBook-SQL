using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace SaccoBook.Utilities
{
    class BackgroundTasksManager
    {
        public void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Do not access the form's BackgroundWorker reference directly.
            // Instead, use the reference provided by the sender parameter.
            BackgroundWorker bw = sender as BackgroundWorker;

            // Extract the argument.
            int arg = (int)e.Argument;

            // Start the time-consuming operation.
            e.Result = TimeConsumingOperation(bw, arg);

            // If the operation was canceled by the user,
            // set the DoWorkEventArgs.Cancel property to true.
            if (bw.CancellationPending)
            {
                e.Cancel = true;
            }
        }

        // This event handler demonstrates how to interpret
        // the outcome of the asynchronous operation implemented
        // in the DoWork event handler.
        public void BackgroundWorker_RunWorkerCompleted(
            object sender,
            RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                // The user canceled the operation.
                MessageBox.Show("Operation was canceled");
            }
            else if (e.Error != null)
            {
                // There was an error during the operation.
                string msg = String.Format("An error occurred: {0}", e.Error.Message);
                MessageBox.Show(msg);
            }
            else
            {
                // The operation completed normally.
                string msg = String.Format("Result = {0}", e.Result);
                MessageBox.Show(msg);
            }
        }

        // This method models an operation that may take a long time
        // to run. It can be cancelled, it can raise an exception,
        // or it can exit normally and return a result. These outcomes
        // are chosen randomly.
        private int TimeConsumingOperation(
            BackgroundWorker bw,
            int sleepPeriod
            )
        {
            int result = 0;

            
            //fetch notification and send

            string NotificationList = EF.NotificationTemplatesQueries.GetNotificationList();

            dynamic jsonNotificationList = JsonConvert.DeserializeObject(NotificationList);

            //loop through approval users json array

            foreach (var Notification in jsonNotificationList)
            {
                string Id = Notification.Id;
                string ReciepientName = Notification.RecipientName;
                string EmailAddress = Notification.EmailAddress;
                string EmailSubject = Notification.EmailSubject;
                string EmailBody = Notification.EmailBody;
                string _IsEmailSent = Notification.IsEmailSent;
                string ReciepientMobileNumber = Notification.ReciepientMobileNumber;
                string SMSBody = Notification.SMSBody;
                string _IsSMSSent = Notification.IsSMSSent;

                bool IsSMSSent = bool.Parse(_IsSMSSent);
                bool IsEmailSent = bool.Parse(_IsEmailSent);

                if (!IsEmailSent)
                {
                    if(EF.NotificationTemplatesQueries.SendEmailNotification(EmailAddress, ReciepientName, EmailSubject, EmailBody))
                    {
                        //update status
                        EF.NotificationTemplatesQueries.UpdateNotificationQueue(Id, "IsEmailSent", true, Login.LoggedInUser, DateTime.Now.ToString());

                        result = 2;
                    }
                }
                if (!IsSMSSent)
                {
                    if(EF.NotificationTemplatesQueries.SendSMSNotification(ReciepientMobileNumber, SMSBody))
                    {
                        //update status
                        EF.NotificationTemplatesQueries.UpdateNotificationQueue(Id, "IsSMSSent", true, Login.LoggedInUser, DateTime.Now.ToString());
                        result = 2;
                    }                    
                }
            }

            return result;
        }

    }
}
