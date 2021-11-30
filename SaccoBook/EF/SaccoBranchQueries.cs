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
    class SaccoBranchQueries
    {
        static string connectionstring = AppResources.DatabaseConnection.ConnectionString();
        /**
        * Function returns list of branche 
        */
        public static string[] GetBranchesList()
        {
            List<string> list = new List<string>();

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionstring;
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM [saccobook].[branches] WHERE 1", conn);
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
        * Function creates Sacco Branch
        * @param BranchName | The branch name
        * @param Location | The location of the branch
        * @param LastModifiedBy | The user that last modified the record
        * @param LastModifiedAt | The time the record was last modified

        * @return bool | return true if number series is created / return false if not created
        */
        public static bool CreateBranch(string BranchName, string Location, string LastModifiedBy, string LastModifiedAt)
        {
            bool status = false;
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                conn.Open();

                string sql = @"INSERT INTO [saccobook].[branches](BranchName, Location, LastModifiedBy, LastModifiedAt) VALUES (@BranchName, @Location, @LastModifiedBy, @LastModifiedAt)";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@BranchName", BranchName);
                    cmd.Parameters.AddWithValue("@Location", Location);
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
        * Function updates Sacco Branch
        * @param BranchName | The branch name
        * @param Location | The location of the branch
        * @param LastModifiedBy | The user that last modified the record
        * @param LastModifiedAt | The time the record was last modified

        * @return bool | return true if number series is created / return false if not created
        */
        public static bool UpdateBranch(string Id, string BranchName, string Location, string LastModifiedBy, string LastModifiedAt)
        {
            bool status = false;
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                conn.Open();

                string sql = @"UPDATE [saccobook].[branches] SETBranchName=@BranchName,Location=@Location,LastModifiedBy=@LastModifiedBy,LastModifiedAt=@LastModifiedAt WHERE  Id=@Id";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.Parameters.AddWithValue("@BranchName", BranchName);
                    cmd.Parameters.AddWithValue("@Location", Location);
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
        * Function returns Sacco Branch information
        * @param Id | The Id of the record
        * @return string | return json string of the branch details
        */
        public static string GetBranchInfo(int Id)
        {
            string BranchData = "";
            string BranchName = "";
            string Location = "";
            string LastModifiedBy = "";;
            string LastModifiedAt = "";
            SqlConnection conn = new SqlConnection(connectionstring);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Id, BranchName, Location, LastModifiedBy, LastModifiedAt FROM [saccobook].[branches] WHERE Id  = '" + Id + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    Id = dr.GetInt16(0);
                    BranchName = dr.GetString(1);
                    Location = dr.GetString(2);
                    LastModifiedBy = dr.GetString(3);
                    LastModifiedAt = dr.GetString(4);

                }
                conn.Close();

                var _Branch = new Branch
                {
                    Id = Id,
                    BranchName = BranchName,
                    Location = Location,
                    LastModifiedBy = LastModifiedBy,
                    LastModifiedAt = LastModifiedAt
                };
                BranchData = JsonConvert.SerializeObject(_Branch);
            }
            catch (SqlException es)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", es.ToString(),
                                System.Diagnostics.EventLogEntryType.Warning);
            }
            return BranchData;
        }
        /**
        * Function returns Sacco Branch information
        * @param Id | The Id of the record

        * @return bool | return true if branch is deleted / return false if not deleted
        */
        public static bool DeleteBranch(string Id)
        {
            bool status = false;

            string sql = "DELETE FROM [saccobook].[branches] WHERE Id = @Id";
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
