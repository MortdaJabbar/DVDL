using DVDL.Users;
using DVDL.Pepole;
using DVDL.Applications;
using DVDL.Tests;
using DVDL.Applications.LocalLicense;
using DVDL.Drivers;
using DVDL.InternationalLicense;
using DVDL.DetainAndRelease;


namespace DVDL
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
             
            ApplicationConfiguration.Initialize();
            Application.Run(new frmLoginUser());

        }
    }
}