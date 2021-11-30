using DevExpress.XtraEditors;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
    class NumberSeriesQueries
    {
        static string connectionstring = AppResources.DatabaseConnection.ConnectionString();

        public static string GetNumberSeries()
        {
            string sql = @"SELECT  [Code]
                              ,[Description]
                              ,[StartingNumber]
                              ,[EndingNumber]
                              ,[LastUsedNumber]
                              ,[LastModifiedBy]
                              ,[LastModifiedAt]
                          FROM [Sacco Book].[saccobook].[numberseries]";

            return sql;
        }
        /**
        * Function returns list of tables in the database
        */
        public static string[] GetTablesList()
        {
            List<string> list = new List<string>();

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionstring;
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("SHOW TABLES", conn);
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
        * Function creates Number series
        * @param Code | The Number series code
        * @param Description | The Number series description
        * @param StartingNumber | The starting number of the number series
        * @param EndingNumber | The ending number of the number series
        * @param LastUsedNumber | The last used number series Code
        * @param LastModifiedBy | The user that last modified the record
        * @param LastModifiedAt | The time the record was last modified

        * @return bool | return true if number series is created / return false if not created
        */
        public static bool CreateNumberSeries(string Code, string Description, string StartingNumber, string EndingNumber, string LastUsedNumber, string LastModifiedBy, string LastModifiedAt)
        {
            bool status = false;
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                conn.Open();

                string sql = @"INSERT INTO [saccobook].[numberseries](Code, Description, StartingNumber, EndingNumber, LastUsedNumber, LastModifiedBy, LastModifiedAt) VALUES (@Code, @Description, @StartingNumber, @EndingNumber, @LastUsedNumber, @LastModifiedBy, @LastModifiedAt)";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Code", Code);
                    cmd.Parameters.AddWithValue("@Description", Description);
                    cmd.Parameters.AddWithValue("@StartingNumber", StartingNumber);
                    cmd.Parameters.AddWithValue("@EndingNumber", EndingNumber);
                    cmd.Parameters.AddWithValue("@LastUsedNumber", LastUsedNumber);
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
        * Function updates Number series
        * @param Code | The Number series code
        * @param Description | The Number series description
        * @param StartingNumber | The starting number of the number series
        * @param EndingNumber | The ending number of the number series
        * @param LastUsedNumber | The Number series Code
        * @param LastModifiedBy | The user that last modified the record
        * @param LastModifiedAt | The time the record was last modified

        * @return bool | return true if number series is updated / return false if not updated
        */
        public static bool UpdateNumberSeries(string Code, string Description, string StartingNumber, string EndingNumber, string LastUsedNumber, string LastModifiedBy, string LastModifiedAt)
        {
            bool status = false;
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                conn.Open();

                string sql = @"UPDATE [saccobook].[numberseries] SET Description=@Description,StartingNumber=@StartingNumber,EndingNumber=@EndingNumber,LastUsedNumber=@LastUsedNumber,LastModifiedBy=@LastModifiedBy,LastModifiedAt=@LastModifiedAt WHERE Code=@Code";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Code", Code);
                    cmd.Parameters.AddWithValue("@Description", Description);
                    cmd.Parameters.AddWithValue("@StartingNumber", StartingNumber);
                    cmd.Parameters.AddWithValue("@EndingNumber", EndingNumber);
                    cmd.Parameters.AddWithValue("@LastUsedNumber", LastUsedNumber);
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
        * Function returns Number Series information
        * @param Code | The Number Series Code

        * @return string | returns JSON string with Number Series data
        */
        public static string GetNumberSeriesInfo(string Code)
        {
            string NumberSeriesData = "";
            string Description = "";
            string StartingNumber = "";
            string EndingNumber = "";
            string LastUsedNumber = "";
            string LastModifiedBy = "";
            string LastModifiedAt = "";
            SqlConnection conn = new SqlConnection(connectionstring);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Code, Description, StartingNumber, EndingNumber, LastUsedNumber, LastModifiedBy, LastModifiedAt FROM [saccobook].[numberseries] WHERE Code  = '" + Code + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {

                    Code = dr.GetString(0);
                    Description = dr.GetString(1);
                    StartingNumber = dr.GetString(2);
                    EndingNumber = dr.GetString(3);
                    LastUsedNumber = dr.GetString(4);
                    LastModifiedBy = dr.GetString(5);
                    LastModifiedAt = dr.GetString(6);

                }
                conn.Close();

                var _NumberSeries = new NumberSeries
                {
                    Code = Code,
                    Description = Description,
                    StartingNumber = StartingNumber,
                    EndingNumber = EndingNumber,
                    LastUsedNumber = LastUsedNumber,
                    LastModifiedBy = LastModifiedBy,
                    LastModifiedAt = LastModifiedAt
                };
                NumberSeriesData = JsonConvert.SerializeObject(_NumberSeries);
            }
            catch (SqlException es)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", es.ToString(),
                                System.Diagnostics.EventLogEntryType.Warning);
            }
            return NumberSeriesData;
        }
        /**
        * Function deletes G/L Account 
        * @param Code | The G/L Account Code

        * @return bool | return true if number series is deleted / return false if not deleted
        */
        public static bool DeleteNumberSeries(string Code)
        {
            bool status = false;

            string sql = "DELETE FROM [saccobook].[numberseries] WHERE Code = @Code";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionstring;
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@Code", Code);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                conn.Close();

                status = true;

            }
            catch (SqlException es)
            {
                  XtraMessageBox.Show(es.Message);
            }
            return status;
        }

        /**
        * Function updates the last used number of the number series
        * @param NumberSeriesCode | The number series code to be update
        * @param LastUsedNumber | The last used number of the number series
        */
        public static void UpdateLastUsedNumberSeries(string NumberSeriesCode, string LastUsedNumber)
        {
            string _NumberSeriesData = NumberSeriesQueries.GetNumberSeriesInfo(NumberSeriesCode);
            dynamic responseObject = JObject.Parse(_NumberSeriesData);
            string StartingNumber = responseObject.StartingNumber;
            string EndingNumber = responseObject.EndingNumber;
            string Description = responseObject.Description;
            NumberSeriesQueries.UpdateNumberSeries(NumberSeriesCode,  Description, StartingNumber, EndingNumber, LastUsedNumber, "Admin", DateTime.Now.ToString());     
        }
    }
}
