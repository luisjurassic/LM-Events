using LM_Events.PresentationLayer;
using System;
using System.Threading;
using System.Windows.Forms;

namespace LM_Events
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
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("pt-br");
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("pt-br");
            Application.Run(new FormTelaSplash());
        }
    }
}

