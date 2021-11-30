using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaccoBook.Utilities
{
    class WindowsLogin
    {
        [System.Runtime.InteropServices.DllImport("advapi32.dll")]

        public static extern bool LogonUser(string userName, string domainName, string password, int LogonType, int LogonProvider, ref IntPtr phToken);
        /**
        * Function authenticates user using Windows Authentication
          params - username - Windows Username e.g Derrick
          params - password - Windows Password e.g myPasss@3019..
          params - domain - MyDomain
        
          return - Bool if credentials are correct or not
        */
        public static bool IsValidateCredentials(string username, string password, string domain)
        {
            IntPtr tokenHandler = IntPtr.Zero;
            bool isValid = LogonUser(username, domain, password, 2, 0, ref tokenHandler);
            return isValid;
        }

    }
}
