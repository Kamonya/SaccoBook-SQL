using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SaccoBook.Modules.Settings.NumberSeries
{
    using SaccoBook.EF;
    using SaccoBook.AppResources;
    using Newtonsoft.Json.Linq;

    public partial class DefineRecordNumbers : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        string DocumentNumber = null;
        public DefineRecordNumbers()
        {
            InitializeComponent();
        }
        public DefineRecordNumbers(string RecordId)
        {
            InitializeComponent();
            LoadNumberSeries(RecordId);
        }

        private void LoadNumberSeries(string RecordId)
        {
            string _NumberSeriesData = NumberSeriesQueries.GetNumberSeriesInfo(RecordId);

            dynamic responseObject = JObject.Parse(_NumberSeriesData);
            _Code.Text = responseObject.Code;
            _StartingNumber.Text = responseObject.StartingNumber;
            _EndingNumber.Text = responseObject.EndingNumber;
            _Description.Text = responseObject.Description;

        }

        private void btn_save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dxValidationProvider_DefineRecordNumbers.Validate().Equals(true))
            {
                if (DocumentNumber != null)
                {
                    if (NumberSeriesQueries.UpdateNumberSeries(_Code.Text, _Description.Text, _StartingNumber.Text, _EndingNumber.Text, _Code.Text, Login.LoggedInUser, DateTime.Now.ToString()))
                    {
                        XtraMessageBox.Show("Information has been successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    string LastUsedNumber = null;

                    LastUsedNumber = GetLastUsedDocumentNumberForNewRecord(_Code.Text, _StartingNumber.Text);
                  
                    if (NumberSeriesQueries.CreateNumberSeries(_Code.Text, _Description.Text, _StartingNumber.Text, _EndingNumber.Text, LastUsedNumber, Login.LoggedInUser, DateTime.Now.ToString()))
                    {
                       XtraMessageBox.Show("Information has been successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        public static string GetLastUsedDocumentNumberForNewRecord(string NumberSeriesCode, string LastUsedNumber)
        {
            string RecordNumber = LastUsedNumber.Substring(NumberSeriesCode.Length);
            int DecimalPlaces = RecordNumber.Length;
            int LastAutoIncrementId = Convert.ToInt32(RecordNumber);

            string FormatterPrefix = "";
            string fmt = ".##";

            char pad = '0';
            FormatterPrefix = FormatterPrefix.PadLeft(DecimalPlaces, pad);
            FormatterPrefix = FormatterPrefix + fmt;

            int NextAutoIncrementId = LastAutoIncrementId - 1;
            return NumberSeriesCode + NextAutoIncrementId.ToString(FormatterPrefix);
        }

        private void _Code_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void _StartingNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void _EndingNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void _LastUsedNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }
    }
}