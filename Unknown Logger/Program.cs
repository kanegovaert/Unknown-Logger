using System;
using System.Windows.Forms;
using Unknown_Logger.Forms;

namespace Unknown_Logger
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
            Application.Run(new TermsofServiceForm());
        }
    }
}
