using BackendService;
using BackendService.Services;
using MVPWinForms.Presenters.Blogs;

namespace MVPWinForms
{
    public class Program
    {
        //private static Mutex mutex = null;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            //const string appName = "MVPWinForms";
            //bool createdNew;

            //mutex = new Mutex(true, appName, out createdNew);

            //if (!createdNew)
            //{
            //    //app is already running! Exiting the application
            //    MessageBox.Show(@"App is running already");
            //    return;
            //}

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Main());
        }
    }
}