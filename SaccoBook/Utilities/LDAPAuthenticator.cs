using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.DirectoryServices.AccountManagement;
using System.Security.Principal;
using System.DirectoryServices;

namespace SaccoBook.Utilities
{
    //string domain = System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName;
    //string adPath = "LDAP://" + domain;
    //LDAPAuthenticator auth = new LDAPAuthenticator(adPath);

    //if (auth.authenticated(domain, "Derrick", "@Derroh_254"))
    //{
    //    MessageBox.Show("Success");
    //}
    //else
    //{
    //    MessageBox.Show("Failed");
    //}
    public class LDAPAuthenticator
    {
        private string _path;
        private string _filterAttribute;
        public string info;
        private ArrayList listaPropiedades = new ArrayList();

        public LDAPAuthenticator(string path)
        {
            _path = path;
        }

        public ArrayList getListaPropiedades()
        {
            return listaPropiedades;
        }

        public string getCN()
        {
            return _filterAttribute;
        }

        public string getInfo()
        {
            return info;
        }
        public bool authenticated(string domain, string user, string pass)
        {
            bool authenticated = true;

            string access = domain + @"\" + user;
            DirectoryEntry entry = new DirectoryEntry(_path, user, pass);
            entry.AuthenticationType = AuthenticationTypes.Secure;

            try
            {
                object obj = entry.NativeObject;
                DirectorySearcher search = new DirectorySearcher(entry);

                search.Filter = "(SAMAccountName=" + user + ")";
                string[] requiredProperties = new string[] { "cn", "givenname", "sn" };
                foreach (String property in requiredProperties)
                    search.PropertiesToLoad.Add(property);

                SearchResult result = search.FindOne();

                if (null == result)
                {
                    authenticated = false;
                }
                else
                {

                    foreach (String property in requiredProperties)
                        foreach (Object myCollection in result.Properties[property])
                            listaPropiedades.Add(myCollection.ToString());
                }

                //Update the new path to the user in the directory.
                _path = result.Path;
                _filterAttribute = (string)result.Properties["cn"][0];
            }
            catch (Exception ex)
            {
                authenticated = false;
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", ex.ToString(),
                                  System.Diagnostics.EventLogEntryType.Warning);
            }

            return authenticated;
        }

        public ArrayList GetGroups(string cn)
        {
            DirectorySearcher search = new DirectorySearcher(_path);
            search.Filter = "(cn=" + cn + ")";
            search.PropertiesToLoad.Add("memberOf");
            ArrayList groups = new ArrayList();

            try
            {
                SearchResult result = search.FindOne();
                int propertyCount = result.Properties["memberOf"].Count;
                string dn;
                int equalsIndex, commaIndex;

                for (int propertyCounter = 0; propertyCounter < propertyCount; propertyCounter++)
                {
                    dn = (string)result.Properties["memberOf"][propertyCounter];
                    equalsIndex = dn.IndexOf("=", 1);
                    commaIndex = dn.IndexOf(",", 1);
                    if (-1 == equalsIndex)
                    {
                        return null;
                    }
                    groups.Add(dn.Substring((equalsIndex + 1), (commaIndex - equalsIndex) - 1));
                }
            }
            catch (Exception ex)
            {
                // throw new Exception("Error obtaining group names. " + ex.Message);
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", ex.ToString(),
                                   System.Diagnostics.EventLogEntryType.Warning);
            }
            return groups;
        }


        public ArrayList getTodosusers()
        {
            ArrayList cnusers = new ArrayList();
            try
            {
                DirectoryEntry entry = new DirectoryEntry();
                entry.Path = _path;
                DirectorySearcher search = new DirectorySearcher(entry);
                search.PropertiesToLoad.Add("cn");


                SearchResultCollection allUsers = search.FindAll();

                foreach (SearchResult result in allUsers)
                {
                    if (result.Properties["cn"].Count > 0)
                    {
                        cnusers.Add(String.Format("{0,-20} : {1}", result.Properties["cn"][0].ToString()));
                    }
                }

            }
            catch (Exception exc)
            {
                cnusers.Add("Error: " + exc.ToString());
            }

            return cnusers;
        }
        //
        public string ChangePass(string newpass, string user, string oldpass)
        {
            string message;
            try
            {
                DirectoryEntry entry = new DirectoryEntry();
                entry.Path = _path;
                DirectorySearcher search = new DirectorySearcher(entry);
                search.Filter = "(SAMAccountName=" + user + ")";
                search.PropertiesToLoad.Add("password");
                SearchResult result = search.FindOne();

                if (result != null)
                {
                    // create new object from search result  
                    DirectoryEntry entryToUpdate = result.GetDirectoryEntry();
                    entryToUpdate.Invoke("ChangePassword", new object[] { oldpass, newpass });
                    entryToUpdate.CommitChanges();
                    message = "Password Successfully changed.";
                }

                else message = "Could not change password. Invalid user.";
            }
            catch (Exception e)
            {
                message = "Error: " + e.ToString();
            }
            return message;
        }

    }
}
