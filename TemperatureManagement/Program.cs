using System;
using System.Windows.Forms;
using TemperatureApiClient.Utilities;

namespace TemperatureManagement
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Utils.CreateUserDefault();
            Utils.CreateDefaultConfig();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TemperatureMain());
        }
    }
}
