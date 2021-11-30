using DevExpress.XtraEditors;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaccoBook.EF
{
    class DividendsQueries
    {
        static string connectionstring = AppResources.DatabaseConnection.ConnectionString();

        /*
        * Function loads member's bank accounts to SearchLookUpEdit
        * 
        * @param MembershipNumber | The member's membership number

        * @return string | returns JSON string with Savings Dividends List
        */
        public static string GetDividendsList(string MembershipNumber)
        {
            List<SavingsDividends> SavingsDividendsList = new List<SavingsDividends>();

            string sql = @"SELECT EXTRACT(YEAR FROM `Date`) as Year, EXTRACT(MONTH FROM `Date`) as MonthNumber, MONTHNAME(`Date`) as Month, SUM(Amount) as Amount FROM [saccobook].[membersavings] WHERE `MemberNumber` ='100001' GROUP BY YEAR(`Date`), MONTH(`Date`) ORDER BY MONTH(`Date`) ASC";

            SqlConnection conn = new SqlConnection(connectionstring);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    SavingsDividendsList.Add(new SavingsDividends
                    {
                        MonthNumber = dr.GetString(1),
                        Month = dr.GetString(2),
                        Amount = dr.GetString(3),
                        Year = dr.GetString(0),

                    });
                }
                conn.Close();
            }
            catch (SqlException ex)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", ex.ToString(),
                                    System.Diagnostics.EventLogEntryType.Warning);
            }

            return JsonConvert.SerializeObject(SavingsDividendsList);
        }
    }
}
