using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaccoBook
{
    class Notification
    {
        public int Id { get; set; }
        public string RecipientName { get; set; }
        public string EmailAddress { get; set; }
        public bool IsEmailSent { get; set; }
        public string EmailBody { get; set; }
        public string EmailSubject { get; set; }
        public string ReciepientMobileNumber { get; set; }
        public string SMSBody { get; set; }
        public bool IsSMSSent { get; set; }
    }
}
