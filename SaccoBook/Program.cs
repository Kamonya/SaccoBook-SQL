using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using SaccoBook.Utilities;
using System.IO;
using System.Drawing;
using SaccoBook.AppResources;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;

namespace SaccoBook
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string conString = DatabaseConnection.ConnectionString();
            

            if (DatabaseConnection.IsDatabaseReachable(conString))
            {
                string ConfigFilepath = AppDomain.CurrentDomain.BaseDirectory + AppConstants.GetXMLFilePath();

                if (File.Exists(ConfigFilepath))
                {

                    BonusSkins.Register();
                    SkinManager.EnableFormSkins();
                    
                    UserLookAndFeel.Default.SetSkinStyle(XMLFormatter.GetContent("ActiveSkin"));

                    DevExpress.Utils.AppearanceObject.DefaultFont = new Font("Segoe UI", 8.25F);
                    
                    Secure scr = new Secure();
                    
                    bool logic = scr.Algorithm(AppConstants.GetAppPassword(), AppConstants.GetGlobalPath());

                    if (logic == true)
                    {
                        if (EF.SystemUserQueries.IsThereAnyUsers())
                        {
                            Application.Run(new Login());
                        }
                        else
                        {
                            Application.Run(new Modules.SystemUsers.CreateSystemUser());
                        }
                    }
                       
                }
                else
                {
                    XtraMessageBox.Show("An Error Occured: Application configuration file was not found. Application can't start", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
