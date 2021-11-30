using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraEditors;
using System.IO;
using DevExpress.DataAccess.Excel;
using Newtonsoft.Json.Linq;

namespace SaccoBook.Data.DataImport
{
    public partial class ImportMembers : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private BindingList<Member> memberData;
        public ImportMembers()
        {
            InitializeComponent();

            //string sqlSavings = "SELECT * FROM `members` WHERE 1";

            //AppResources.AppFunctions.LoadTable(gridControl1, gridView1, sqlSavings);

        }

        private void btn_generate_template_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog f = new SaveFileDialog();
                f.Filter = "Excel|*.xlsx";
                f.FileName = "MemberInformationTemplate" + ".xlsx";
                if (f.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                {
                    return;
                }
                //wait
                SplashScreenManager.ShowForm(this, typeof(AppWaitForm), true, true, false);
                SplashScreenManager.Default.SetWaitFormCaption("Please wait");
                SplashScreenManager.Default.SetWaitFormDescription("Generating...");

                string destination = f.FileName;

                string origin = Path.GetDirectoryName(Application.ExecutablePath) + @"\Templates\MemberInformationTemplate.xlsx";

                File.Copy(origin, destination);

                SplashScreenManager.CloseForm();
                XtraMessageBox.Show("Template Generated Succesfully", "System Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Diagnostics.Process.Start(destination);
            }
            catch (Exception ex)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", ex.ToString(),
                                       System.Diagnostics.EventLogEntryType.Warning);
            }
        }

        private void btn_load_from_excel_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                OpenFileDialog of = new OpenFileDialog();
                of.Filter = "Excel|*.xlsx";
                of.Title = "Select the xlsx file";
                of.Multiselect = false;
                if (of.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                {
                    return;
                }

                string file = of.FileName;
                SplashScreenManager.ShowForm(this, typeof(AppWaitForm), true, true, false);
                SplashScreenManager.Default.SetWaitFormCaption("Please wait");
                SplashScreenManager.Default.SetWaitFormDescription("Importing...");

                DevExpress.DataAccess.Excel.ExcelDataSource myExcelSource = new DevExpress.DataAccess.Excel.ExcelDataSource();
                // myExcelSource.FileName = @"d:\test.xlsx";
                myExcelSource.FileName = file;

                //ExcelWorksheetSettings wks = new ExcelWorksheetSettings(,)

                ExcelWorksheetSettings worksheetSettings = new ExcelWorksheetSettings("Members", "A1:X1");
                myExcelSource.SourceOptions = new ExcelSourceOptions(worksheetSettings);
                //or 
                myExcelSource.SourceOptions = new CsvSourceOptions() { CellRange = "A1:X3500" };
                myExcelSource.SourceOptions.SkipEmptyRows = false;
                myExcelSource.SourceOptions.UseFirstRowAsHeader = true;
                myExcelSource.Fill();
                gridControl1.DataSource = myExcelSource;

                SplashScreenManager.CloseForm();

            }
            catch (Exception ex)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", ex.ToString(),
                                       System.Diagnostics.EventLogEntryType.Warning);
            }
        }

        private void btn_save_ItemClick(object sender, ItemClickEventArgs e)
        {
            SaveMembers();
        }
        private void SaveMembers()
        {
            DialogResult dlr = XtraMessageBox.Show("The data must be validated first to ensure no duplicates or inconsistencies. \nDo you still want to proceed anyway?", "System Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlr == DialogResult.Yes)
            {
                try
                {

                    if (gridView1.DataRowCount > 0)
                    {
                        ImportMembersList(gridView1);

                        XtraMessageBox.Show("Information has been successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        memberData = new BindingList<Member>();
                        gridControl1.DataSource = memberData;
                        gridView1.PopulateColumns();
                    }
                    else
                    {
                        XtraMessageBox.Show("An Error Occured: No records were found on the import table. Information was not saved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.EventLog.WriteEntry("Sacco Book", ex.ToString(),
                                     System.Diagnostics.EventLogEntryType.Warning);
                }
            }
            else if (dlr == DialogResult.No)
            {

            }

        }
        public static void ImportMembersList(DevExpress.XtraGrid.Views.Grid.GridView gridview)
        {
            string NumberSeriesCode = "";

            string MembershipNumber = ""; 
            string Name = ""; 
            string FirstName = ""; 
            string MiddleName = ""; 
            string LastName = ""; 
            string PhoneNumber = ""; 
            string AlternativeNumber = ""; 
            string Email = ""; 
            string DateOfBirth = ""; 
            string Gender = ""; 
            string Nationality = ""; 
            string NationalIdNumber = ""; 
            string TaxPIN = ""; 
            string Address = ""; 
           // string Photo = ""; 
            string Password = "";
            string SourceOfIncome = ""; 
            string Employer = ""; 
            string JobPosition = ""; 
            string PayrollNumber = ""; 
            string EmployerAddress = ""; 
            string EmployerTelephoneNumber = ""; 
            string GrossMonthlyIncome = "";
            string DateJoined = ""; 
            string MembershipStatus = "";

            byte[] Photo = null;


            //string Password = "";

            try
            {
                for (int i = 0; i < gridview.DataRowCount; i++)
                {
                    if (gridview.GetRowCellValue(i, "Membership Number") != null)
                    {
                        MembershipNumber = gridview.GetRowCellValue(i, "Membership Number").ToString();
                    }
                    if (gridview.GetRowCellValue(i, "First Name") != null)
                    {
                        FirstName = gridview.GetRowCellValue(i, "First Name").ToString();
                    }
                    if (gridview.GetRowCellValue(i, "Middle Name") != null)
                    {
                        MiddleName = gridview.GetRowCellValue(i, "Middle Name").ToString();
                    }
                    if (gridview.GetRowCellValue(i, "Last Name") != null)
                    {
                        LastName = gridview.GetRowCellValue(i, "Last Name").ToString();
                    }
                    if (gridview.GetRowCellValue(i, "Phone Number") != null)
                    {
                        PhoneNumber = gridview.GetRowCellValue(i, "Phone Number").ToString();
                    }
                    if (gridview.GetRowCellValue(i, "Alternative Number") != null)
                    {
                        AlternativeNumber = gridview.GetRowCellValue(i, "Alternative Number").ToString();
                    }
                    if (gridview.GetRowCellValue(i, "Email") != null)
                    {
                        Email = gridview.GetRowCellValue(i, "Email").ToString();
                    }
                    if (gridview.GetRowCellValue(i, "National Id Number") != null)
                    {
                        NationalIdNumber = gridview.GetRowCellValue(i, "National Id Number").ToString();
                    }
                    if (gridview.GetRowCellValue(i, "Date Of Birth") != null)
                    {
                        DateOfBirth = gridview.GetRowCellValue(i, "Date Of Birth").ToString();

                        if(DateOfBirth != "")
                        {
                            DateOfBirth = AppResources.AppFunctions.ConvertTo_YYYY_MM_D_DateFormat(DateOfBirth);
                        }                        
                    }
                    if (gridview.GetRowCellValue(i, "Gender") != null)
                    {
                        Gender = gridview.GetRowCellValue(i, "Gender").ToString();
                    }
                    if (gridview.GetRowCellValue(i, "Nationality") != null)
                    {
                        Nationality = gridview.GetRowCellValue(i, "Nationality").ToString();
                    }
                    if (gridview.GetRowCellValue(i, "Address") != null)
                    {
                        Address = gridview.GetRowCellValue(i, "Address").ToString();
                    }
                    if (gridview.GetRowCellValue(i, "Tax PIN") != null)
                    {
                        TaxPIN = gridview.GetRowCellValue(i, "Tax PIN").ToString();
                    }
                    if (gridview.GetRowCellValue(i, "Source Of Income") != null)
                    {
                        SourceOfIncome = gridview.GetRowCellValue(i, "Source Of Income").ToString();
                    }
                    if (gridview.GetRowCellValue(i, "Employer") != null)
                    {
                        Employer = gridview.GetRowCellValue(i, "Employer").ToString();
                    }
                    if (gridview.GetRowCellValue(i, "Job Position") != null)
                    {
                        JobPosition = gridview.GetRowCellValue(i, "Job Position").ToString();
                    }
                    if (gridview.GetRowCellValue(i, "PayrollNumber") != null)
                    {
                        PayrollNumber = gridview.GetRowCellValue(i, "PayrollNumber").ToString();
                    }
                    if (gridview.GetRowCellValue(i, "EmployerAddress") != null)
                    {
                        EmployerAddress = gridview.GetRowCellValue(i, "EmployerAddress").ToString();
                    }
                    if (gridview.GetRowCellValue(i, "Employer Telephone Number") != null)
                    {
                        EmployerTelephoneNumber = gridview.GetRowCellValue(i, "Employer Telephone Number").ToString();
                    }
                    if (gridview.GetRowCellValue(i, "Gross Monthly Income") != null)
                    {
                        GrossMonthlyIncome = gridview.GetRowCellValue(i, "Gross Monthly Income").ToString();
                    }
                    if (gridview.GetRowCellValue(i, "Date Joined") != null)
                    {
                        DateJoined = gridview.GetRowCellValue(i, "Date Joined").ToString();

                        if (DateJoined != "")
                        {
                            DateJoined = AppResources.AppFunctions.ConvertTo_YYYY_MM_D_DateFormat(DateJoined);
                        }
                        
                    }
                    //if (gridview.GetRowCellValue(i, "MembershipStatus") != null)
                    //{
                    //    MembershipStatus = gridview.GetRowCellValue(i, "MembershipStatus").ToString();
                    //}


                    PayrollNumber = MembershipNumber;

                    if (MiddleName != "")
                    {
                        Name = FirstName + " " + MiddleName + " " + LastName;
                    }
                    else if(LastName != "")
                    {
                        Name = FirstName + " " + LastName;
                    }
                    if (LastName =="")
                    {
                        Name = FirstName + " " + MiddleName;
                    }
                    if (LastName == "" && LastName == "" && LastName == "")
                    {
                        Name = "James" + " " + "Doe";
                    }


                    Email = FirstName + "." + LastName + "@gmail.com";

                    if(NationalIdNumber == "")
                    {
                        NationalIdNumber = GeenerateID();
                    }

                    if (DateOfBirth == "")
                    {
                        DateOfBirth = DateJoined;
                    }

                    if(TaxPIN == "")
                    {
                        TaxPIN = GenerateTaxID();
                    }


                    //Validation

                    //if (EF.MemberQueries.IsNationalIdNumberExist(NationalIdNumber))
                    //{
                    //    XtraMessageBox.Show("An Error Occured: Information was not saved.\nA member with the National ID Number provided already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    return;
                    //}
                    //if (EF.MemberQueries.IsTaxPINExist(TaxPIN))
                    //{
                    //    XtraMessageBox.Show("An Error Occured: Information was not saved.\nA member with the Tax PIN provided already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    return;
                    //}
                    //if (EF.MemberQueries.IsPhoneNumberExist(PhoneNumber))
                    //{
                    //    XtraMessageBox.Show("An Error Occured: Information was not saved.\nA member with the Phone Number provided already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    return;
                    //}
                    //if (EF.MemberQueries.IsEmailExist(Email))
                    //{
                    //    XtraMessageBox.Show("An Error Occured: Information was not saved.\nA member with the Email address provided already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    return;
                    //}


                    //Call Function to create member here

                    GrossMonthlyIncome = GrossMonthlyIncome.Replace(",", "");

                    //generate new Membership number here
                    MembershipNumber = GetDocumentNumber("SB");

                    PhoneNumber = GetPhoneNumber();//= PhoneNumber.Replace("254", "256");

                    MembershipStatus = "Active";

                    string filename = Application.StartupPath + @"\Photos\Portrait_Placeholder.png";
                    Image img = Image.FromFile(filename);
                    Photo = ImageToByteArray(img);


                    if (EF.MemberQueries.CreateMember(MembershipNumber.Trim(), Name.Trim(), FirstName.Trim(), MiddleName.Trim(), LastName.Trim(), PhoneNumber.Trim(), AlternativeNumber.Trim() , Email.Trim(), Convert.ToDateTime(DateOfBirth.Trim()), Gender.Trim(), Nationality.Trim(), NationalIdNumber.Trim(), TaxPIN.Trim(), Address.Trim(), Photo, Password.Trim(),
                        SourceOfIncome.Trim(), Employer.Trim(), JobPosition.Trim(), PayrollNumber.Trim(), EmployerAddress.Trim(), EmployerTelephoneNumber.Trim(), Convert.ToDouble(GrossMonthlyIncome.Trim()), Convert.ToDateTime(DateJoined.Trim()), MembershipStatus.Trim(), "Admin", DateTime.Now.ToString()))
                    {
                        //Update number series
                        EF.NumberSeriesQueries.UpdateLastUsedNumberSeries("SB", MembershipNumber);

                        //XtraMessageBox.Show("Information has been successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    //else { break; }


                    //reset variabkes
                    MembershipNumber = ""; Name = ""; FirstName = ""; MiddleName = ""; LastName = ""; PhoneNumber = ""; AlternativeNumber = ""; Email = ""; DateOfBirth = ""; Gender = ""; Nationality = ""; NationalIdNumber = ""; TaxPIN = ""; Address = "";  Password = "";
                    SourceOfIncome = ""; Employer = ""; JobPosition = ""; PayrollNumber = ""; EmployerAddress = ""; EmployerTelephoneNumber = ""; GrossMonthlyIncome = "";
                    DateJoined = ""; MembershipStatus = ""; 

                }

                XtraMessageBox.Show("Information has been successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", ex.ToString(),
                                     System.Diagnostics.EventLogEntryType.Warning);
            }
        }

        private static string GetPhoneNumber()
        {
            Random generator = new Random();
            String r = generator.Next(0, 999999999).ToString("D9");

            return "256" + r;
        }
        private static string GeenerateID()
        {
            Random generator = new Random();
            String r = generator.Next(0, 999999999).ToString("D9");

            return "3" + r;
        }
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private static string GenerateTaxID()
        {
            Random generator = new Random();
            String r = generator.Next(0, 999999999).ToString("D3");

            return "A000" + r + RandomString(4);
        }

        private static string GetDocumentNumber(string DocumentNumberSeriesCode)
        {
            string No = "";

            string _NumberSeriesData = EF.NumberSeriesQueries.GetNumberSeriesInfo(DocumentNumberSeriesCode);

            dynamic responseObject = JObject.Parse(_NumberSeriesData);
            string LastUsedNumber = responseObject.LastUsedNumber;

            if (LastUsedNumber != "")
            {
                No = AppResources.AppFunctions.GetNewDocumentNumber(DocumentNumberSeriesCode, LastUsedNumber);
            }
            else
            {
                XtraMessageBox.Show("Encountered an error: The document number series has not been properly configured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               // AppResources.DevexpressFunctions.EnableDisableForm(layoutControl1, true);
            }
            return No;
        }
        public static byte[] ImageToByteArray(Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

    }
}