using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaccoBook.SQL
{
    class GroupQueries
    {
        static string connectionstring = AppResources.DatabaseConnection.ConnectionString();

        /**
        * Function creates new Group
        * @param MembershipNumber | The member's membership number
        * @param Name | The member's full name
        * @param FirstName | The member's first name
        * @param MiddleName | The member's middle name
        * @param LastName | The member's last name
        * @param PhoneNumber | The member's phone number
        * @param AlternativeNumber | The member's alternative phone number
        * @param Email | The member's email address
        * @param DateOfBirth | The member's date of birth
        * @param Gender | The member's gender
        * @param Nationality | The member's nationality
        * @param NationalIdNumber | The member's national id number
        * @param TaxPIN | The member's tax pin (KRA/URA)
        * @param Address | The member's address
        * @param Photo | The member's photo name
        * @param Password | The member's portal password
        * @param SourceOfIncome | The member's primary source of income
        * @param Employer | The member's current employer
        * @param JobPosition | The member's job postion
        * @param PayrollNumber | The member's payroll number
        * @param EmployerAddress | The member's employer's address
        * @param EmployerTelephoneNumber | The member's employer's phone number
        * @param GrossMonthlyIncome | The member's gross monthly income
        * @param DateJoined | The date member joined the sacco
        * @param MembershipStatus | The member's membership status
        * @param LastModifiedBy | The user that last modified the record
        * @param LastModifiedAt | The time the record was last modified

        * @return bool | return true if member information is created / return false if not created
        */
        public static bool CreateGroup(string MembershipNumber, string Name, string FirstName, string MiddleName, string LastName, string PhoneNumber, string AlternativeNumber, string Email, string DateOfBirth, string Gender, string Nationality, string NationalIdNumber, string TaxPIN, string Address, byte[] Photo, string Password,
        string SourceOfIncome, string Employer, string JobPosition, string PayrollNumber, string EmployerAddress, string EmployerTelephoneNumber, string GrossMonthlyIncome,
        string DateJoined, string MembershipStatus, string LastModifiedBy, string LastModifiedAt)
        {
            bool status = false;
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                conn.Open();

                string sql = @"INSERT INTO [saccobook].[members](MembershipNumber, Name, FirstName, MiddleName, LastName, PhoneNumber, AlternativeNumber, Email, DateOfBirth, Gender, Nationality, NationalIdNumber, TaxPIN, Address, Photo, Password, SourceOfIncome, Employer, JobPosition, PayrollNumber, EmployerAddress, EmployerTelephoneNumber, GrossMonthlyIncome, DateJoined, MembershipStatus, MembershipType, LastModifiedBy, LastModifiedAt) VALUES (@MembershipNumber, @Name, @FirstName, @MiddleName, @LastName, @PhoneNumber, @AlternativeNumber, @Email, @DateOfBirth, @Gender, @Nationality, @NationalIdNumber, @TaxPIN, @Address, @Photo, @Password, @SourceOfIncome, @Employer, @JobPosition, @PayrollNumber, @EmployerAddress, @EmployerTelephoneNumber, @GrossMonthlyIncome, @DateJoined, @MembershipStatus, @MembershipType, @LastModifiedBy, @LastModifiedAt)";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MembershipNumber", MembershipNumber);
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@FirstName", FirstName);
                    cmd.Parameters.AddWithValue("@MiddleName", MiddleName);
                    cmd.Parameters.AddWithValue("@LastName", LastName);
                    cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                    cmd.Parameters.AddWithValue("@AlternativeNumber", AlternativeNumber);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    cmd.Parameters.AddWithValue("@Gender", Gender);
                    cmd.Parameters.AddWithValue("@Nationality", Nationality);
                    cmd.Parameters.AddWithValue("@NationalIdNumber", NationalIdNumber);
                    cmd.Parameters.AddWithValue("@TaxPIN", TaxPIN);
                    cmd.Parameters.AddWithValue("@Address", Address);
                    cmd.Parameters.AddWithValue("@Photo", Photo);
                    cmd.Parameters.AddWithValue("@Password", Password);
                    cmd.Parameters.AddWithValue("@SourceOfIncome", SourceOfIncome);
                    cmd.Parameters.AddWithValue("@Employer", Employer);
                    cmd.Parameters.AddWithValue("@JobPosition", JobPosition);
                    cmd.Parameters.AddWithValue("@PayrollNumber", PayrollNumber);
                    cmd.Parameters.AddWithValue("@EmployerAddress", EmployerAddress);
                    cmd.Parameters.AddWithValue("@EmployerTelephoneNumber", EmployerTelephoneNumber);
                    cmd.Parameters.AddWithValue("@GrossMonthlyIncome", GrossMonthlyIncome);
                    cmd.Parameters.AddWithValue("@DateJoined", DateJoined);
                    cmd.Parameters.AddWithValue("@MembershipStatus", MembershipStatus);
                    cmd.Parameters.AddWithValue("@MembershipType", "Group");
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

        public static bool CreateSignatory(string GroupMembershipNo
           , string IDNumber
           , string Names
           , string DateOfBirth
           , string StaffPayroll
           , bool Signatory
           , bool MustSign
           , bool MustBePresent
           , byte[] Picture
           , byte[] Signature
           , string ExpiryDate
           , string Type
           , string MemberNo
           , string EntryType
           , string PhoneNo
           , string Nationality
           , string Address
           , string Email
           , string WorkStation
           , string Employer
           , string Residence
           , string OtherBankers
           , string Occupation
           , string PINNumber)
        {
            bool status = false;
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                conn.Open();

                string sql = @"INSERT INTO [saccobook].[Signatories]
                               ([GroupMembershipNo]
                               ,[IDNumber]
                               ,[Names]
                               ,[DateOfBirth]
                               ,[StaffPayroll]
                               ,[Signatory]
                               ,[MustSign]
                               ,[MustBePresent]
                               ,[Picture]
                               ,[Signature]
                               ,[ExpiryDate]
                               ,[Type]
                               ,[MemberNo]
                               ,[EntryType]
                               ,[PhoneNo]
                               ,[Nationality]
                               ,[Address]
                               ,[Email]
                               ,[WorkStation]
                               ,[Employer]
                               ,[Residence]
                               ,[OtherBankers]
                               ,[Occupation]
                               ,[PINNumber])
                         VALUES
                               (@GroupMembershipNo
                               ,@IDNumber
                               ,@Names
                               ,@DateOfBirth
                               ,@StaffPayroll
                               ,@Signatory
                               ,@MustSign
                               ,@MustBePresent
                               ,@Picture
                               ,@Signature
                               ,@ExpiryDate
                               ,@Type
                               ,@MemberNo
                               ,@EntryType
                               ,@PhoneNo
                               ,@Nationality
                               ,@Address
                               ,@Email
                               ,@WorkStation
                               ,@Employer
                               ,@Residence
                               ,@OtherBankers
                               ,@Occupation
                               ,@PINNumber)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@GroupMembershipNo", GroupMembershipNo);
                    cmd.Parameters.AddWithValue("@IDNumber", IDNumber);
                    cmd.Parameters.AddWithValue("@Names", Names);
                    cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    cmd.Parameters.AddWithValue("@StaffPayroll", StaffPayroll);
                    cmd.Parameters.AddWithValue("@Signatory", Signatory);
                    cmd.Parameters.AddWithValue("@MustSign", MustSign);
                    cmd.Parameters.AddWithValue("@MustBePresent", MustBePresent);
                    cmd.Parameters.AddWithValue("@Picture", Picture);
                    cmd.Parameters.AddWithValue("@Signature", Signature);
                    cmd.Parameters.AddWithValue("@ExpiryDate", ExpiryDate);
                    cmd.Parameters.AddWithValue("@MemberNo", MemberNo);
                    cmd.Parameters.AddWithValue("@Type", Type);
                    cmd.Parameters.AddWithValue("@EntryType", EntryType);
                    cmd.Parameters.AddWithValue("@PhoneNo", PhoneNo);
                    cmd.Parameters.AddWithValue("@Nationality", Nationality);
                    cmd.Parameters.AddWithValue("@Address", Address);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@WorkStation", WorkStation);
                    cmd.Parameters.AddWithValue("@Employer", Employer);
                    cmd.Parameters.AddWithValue("@Residence", Residence);
                    cmd.Parameters.AddWithValue("@OtherBankers", OtherBankers);
                    cmd.Parameters.AddWithValue("@Occupation", Occupation);
                    cmd.Parameters.AddWithValue("@PINNumber", PINNumber);
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

       public static bool UpdateGroup(string MembershipNumber, string Name, string FirstName, string MiddleName, string LastName, string PhoneNumber, string AlternativeNumber, string Email, string DateOfBirth, string Gender, string Nationality, string NationalIdNumber, string TaxPIN, string Address, byte[] Photo, string Password,
       string SourceOfIncome, string Employer, string JobPosition, string PayrollNumber, string EmployerAddress, string EmployerTelephoneNumber, string GrossMonthlyIncome,
       string DateJoined, string MembershipStatus, string LastModifiedBy, string LastModifiedAt)
        {
            bool status = false;
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                conn.Open();

                string sql = @"UPDATE [saccobook].[members] SET Name=@Name,FirstName=@FirstName,MiddleName=@MiddleName,LastName=@LastName,PhoneNumber=@PhoneNumber,AlternativeNumber=@AlternativeNumber,Email=@Email,DateOfBirth=@DateOfBirth,Gender=@Gender,Nationality=@Nationality,NationalIdNumber=@NationalIdNumber,TaxPIN=@TaxPIN,Address=@Address,Photo=@Photo,Password=@Password,SourceOfIncome=@SourceOfIncome,Employer=@Employer,JobPosition=@JobPosition,PayrollNumber=@PayrollNumber,EmployerAddress=@EmployerAddress,EmployerTelephoneNumber=@EmployerTelephoneNumber,GrossMonthlyIncome=@GrossMonthlyIncome,DateJoined=@DateJoined,MembershipStatus=@MembershipStatus,LastModifiedBy=@LastModifiedBy,LastModifiedAt=@LastModifiedAt WHERE MembershipNumber=@MembershipNumber";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MembershipNumber", MembershipNumber);
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@FirstName", FirstName);
                    cmd.Parameters.AddWithValue("@MiddleName", MiddleName);
                    cmd.Parameters.AddWithValue("@LastName", LastName);
                    cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                    cmd.Parameters.AddWithValue("@AlternativeNumber", AlternativeNumber);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    cmd.Parameters.AddWithValue("@Gender", Gender);
                    cmd.Parameters.AddWithValue("@Nationality", Nationality);
                    cmd.Parameters.AddWithValue("@NationalIdNumber", NationalIdNumber);
                    cmd.Parameters.AddWithValue("@TaxPIN", TaxPIN);
                    cmd.Parameters.AddWithValue("@Address", Address);
                    cmd.Parameters.AddWithValue("@Photo", Photo);
                    cmd.Parameters.AddWithValue("@Password", Password);
                    cmd.Parameters.AddWithValue("@SourceOfIncome", SourceOfIncome);
                    cmd.Parameters.AddWithValue("@Employer", Employer);
                    cmd.Parameters.AddWithValue("@JobPosition", JobPosition);
                    cmd.Parameters.AddWithValue("@PayrollNumber", PayrollNumber);
                    cmd.Parameters.AddWithValue("@EmployerAddress", EmployerAddress);
                    cmd.Parameters.AddWithValue("@EmployerTelephoneNumber", EmployerTelephoneNumber);
                    cmd.Parameters.AddWithValue("@GrossMonthlyIncome", GrossMonthlyIncome);
                    cmd.Parameters.AddWithValue("@DateJoined", DateJoined);
                    cmd.Parameters.AddWithValue("@MembershipStatus", MembershipStatus);
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

        public static string LoadSignatories(string GroupMembershipNo)
        {
            string sql = @"SELECT `Id`, `IDNumber`, `Names`, `DateOfBirth`, `Email`, `PhoneNo`, `Address` FROM `signatories` WHERE `GroupMembershipNo` = '"+ GroupMembershipNo + "'";
            return sql;
        }

    }
}
