using System;
using System.Threading;
using System.Windows.Forms;

namespace _3CX_FTPSample
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.ThreadException += ApplicationOnThreadException;

            Application.Run(new Form1());
        }

        private static void ApplicationOnThreadException(object sender, ThreadExceptionEventArgs e)
        {
            Exception ex = e.Exception;
            var message = ex.Message;

            MessageBox.Show(message, "Exception Occured", MessageBoxButtons.OK);
        }

    }
}
