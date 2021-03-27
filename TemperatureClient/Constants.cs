using System.Collections.Generic;
using System.Windows.Forms;
using TemperatureModels;

namespace TemperatureApiClient
{
    public class Constants
    {
        public static string ResponseStatusSuccess = "OK";
        public static string ResponseStatusFails = "NG";
        

        public static int LoginId { get; set; }
        public static string LoginName { get; set; }
        public static string ConfigPath = string.Format("{0}\\{1}", Application.StartupPath, "Config.dat");
        public static string UserPath = string.Format("{0}\\{1}", Application.StartupPath, "t_admin.dat");
        public static string DownloadDesPath = Application.StartupPath;

        public static List<UserInfo> userCollection { get; set; }
    }
}
