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
    class BankQueries
    {
        static string connectionstring = AppResources.DatabaseConnection.ConnectionString();

        /**
        * Function returns member's bank accounts list
        * 
        * @param MembershipNumber | The member's membership number
        
        * @return List<MemberBankAccount> | returns a List of member's bank accounts 
        */
        public static List<MemberBankAccount> GetBankAccountsList(string MembershipNumber)
        {
            List<MemberBankAccount> BankAccountList = new List<MemberBankAccount>();

            try
            {                
                using(var db = new SaccoBookEntities())
                {
                    var query = from b in db.memberbankaccounts
                                where b.MembershipNumber == MembershipNumber
                                orderby b.BankName
                                select b;

                    foreach (var item in query)
                    {
                        BankAccountList.Add(new MemberBankAccount
                        {
                            MembershipNumber = item.MembershipNumber,
                            BankName = item.BankName,
                            Branch = item.Branch,
                            AccountNumber = item.AccountNumber,
                            LastModifiedBy = item.LastModifiedBy,
                            LastModifiedAt = item.LastModifiedAt
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", ex.ToString(),
                                    System.Diagnostics.EventLogEntryType.Error);
            }

            return BankAccountList;
        }

        /**
        * Function creates new member bank account
               
        * @param MembershipNumber | The member's membership number
        * @param BankName | The bank name
        * @param Branch | The bank branch
        * @param AccountNumber | The member's bank account number
        * @param LastModifiedBy | The user that last modified the record
        * @param LastModifiedAt | The time the record was last modified

        * @return bool | return true if bank account is created / return false if not created
        */
        public static bool CreateBankAccount(string MembershipNumber, string BankName, string Branch, string AccountNumber, string LastModifiedBy, string LastModifiedAt)
        {
            bool status = false;

            try
            {
                using(var db = new SaccoBookEntities())
                {
                    var memberbankaccount = new memberbankaccount() 
                    {
                        MembershipNumber = MembershipNumber,
                        BankName = BankName,
                        Branch = Branch,
                        AccountNumber = AccountNumber,
                        LastModifiedAt = LastModifiedAt,
                        LastModifiedBy = LastModifiedBy
                    };
                    db.memberbankaccounts.Add(memberbankaccount);
                    db.SaveChanges();

                    status = true;
                }
            }

            catch (Exception ex)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", ex.ToString(),
                                      System.Diagnostics.EventLogEntryType.Warning);
            }
            return status;
        }

        /**
        * Function updates new member bank account
               
        * @param MembershipNumber | The member's membership number
        * @param BankName | The bank name
        * @param Branch | The bank branch
        * @param AccountNumber | The member's bank account number
        * @param LastModifiedBy | The user that last modified the record
        * @param LastModifiedAt | The time the record was last modified

        * @return bool | return true if bank account is updates / return false if not created
        */
        public static bool UpdateBankAccount(string MembershipNumber, string BankName, string Branch, string AccountNumber, string LastModifiedBy, string LastModifiedAt)
        {
            bool status = false;

            try
            {               
                using(var db = new SaccoBookEntities())
                {
                    memberbankaccount memberbankaccount = db.memberbankaccounts.Where(x => x.MembershipNumber == MembershipNumber && x.AccountNumber == AccountNumber).SingleOrDefault();

                    if (memberbankaccount == null)
                    {
                        status = false;
                    }
                    else
                    {
                        memberbankaccount.MembershipNumber = MembershipNumber;
                        memberbankaccount.BankName = BankName;
                        memberbankaccount.Branch = Branch;
                        memberbankaccount.AccountNumber = AccountNumber;
                        memberbankaccount.LastModifiedAt = LastModifiedAt;
                        memberbankaccount.LastModifiedBy = LastModifiedBy;
                        db.SaveChanges();
                        status = true;
                    }
                }
            }

            catch (Exception ex)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", ex.ToString(),
                                      System.Diagnostics.EventLogEntryType.Error);
            }
            return status;
        }

        /**
        * Function deletes member bank accounts 
        * 
        * @param MembershipNumber | The member's membership number
        * @param AccountNumber | The member's account number

        * @return bool | return true if bank account is deleted / return false if not deleted
        */
        public static bool DeleteBankAccount(string MembershipNumber, string AccountNumber)
        {
            bool status = false;

            try
            {
                using (var db = new SaccoBookEntities())
                {
                    memberbankaccount memberbankaccount = db.memberbankaccounts.Where(x => x.MembershipNumber == MembershipNumber && x.AccountNumber == AccountNumber).SingleOrDefault();
                    if (memberbankaccount == null)
                    {
                        status = false;
                    }
                    else
                    {
                        db.memberbankaccounts.Remove(memberbankaccount);
                        db.SaveChanges();
                        status = true;
                    }
                }

            }
            catch (Exception ex)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", ex.ToString(),
                                    System.Diagnostics.EventLogEntryType.Error);
            }
            return status;
        }

        /**
        * Function returns bank account information
        * 
        * @param MembershipNumber | The member's membership number
        * @param _BankAccountNumber | The member's bank account number
        
        * @return string | returns JSON string with bank account data
        */
        public static string GetBankAccountInfo(string MembershipNumber, string _BankAccountNumber)
        {
            string MemberBankAccountData = "";

            try
            {               
                using (var db = new SaccoBookEntities())
                {
                    memberbankaccount memberbankaccounts = db.memberbankaccounts.Where(x => x.MembershipNumber == MembershipNumber && x.AccountNumber == _BankAccountNumber).SingleOrDefault();

                    if (memberbankaccounts != null)
                    {
                        var _MemberBankAccount = new MemberBankAccount
                        {
                            MembershipNumber = memberbankaccounts.MembershipNumber,
                            BankName = memberbankaccounts.BankName,
                            Branch = memberbankaccounts.Branch,
                            AccountNumber = memberbankaccounts.AccountNumber,
                            LastModifiedBy = memberbankaccounts.LastModifiedBy,
                            LastModifiedAt = memberbankaccounts.LastModifiedAt
                        };

                        MemberBankAccountData = JsonConvert.SerializeObject(_MemberBankAccount);
                    }
                }
            }
            catch (SqlException ex)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", ex.ToString(),
                                    System.Diagnostics.EventLogEntryType.Warning);
            }
            return MemberBankAccountData;
        }
        /**
        * Function loads member's bank accounts to SearchLookUpEdit
        * 
        * @param _SearchLookUpEdit | The SearchLookUpEdit to be loaded
        * @param MembershipNumber | The member's membership number
        
        * @return string | returns JSON string with bank account data
        */
        public static void LoadMembersBankAccounts(DevExpress.XtraEditors.SearchLookUpEdit _SearchLookUpEdit, string MembershipNumber)
        {
            string sql = @"select `memberbankaccounts`.`BankName`,
                                       `memberbankaccounts`.`Branch`,
                                       `memberbankaccounts`.`AccountNumber`
                                  from `memberbankaccounts` `memberbankaccounts`
                                 where
                                       (`memberbankaccounts`.`MembershipNumber` = '"+ MembershipNumber + "')";

            AppResources.AppFunctions.LoadSearchLookUpEdit(_SearchLookUpEdit, sql);
        }
    }
}
