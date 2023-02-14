using vellsPos.Forms.Layouts;
using vellsPos.Forms.Masters.user;

namespace vellsPos
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new frmLoading());
            //Application.Run(new FrmForm());
            Application.Run(new FrmForm());
        }
    }
}