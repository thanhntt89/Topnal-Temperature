using System;

namespace TemperatureApiClient.Config
{
    [Serializable]
    public class ApiConfig
    {
        public ApiInfo ApiInfos { get; set; }

        public EndPointInfo EnpointInfo { get; set; }
    }

    [Serializable]
    public class ApiInfo
    {
        public string ApiKey { get; set; }
        public string ApiSecret { get; set; }
        public string ApiUrl { get; set; }
    }

    [Serializable]
    public class EndPointInfo
    {
        public string Login { get; set; }
        public string UserList { get; set; }
        public string UserRegiester { get; set; }
        public string UserUpdatePassword { get; set; }
        public string UserResetPassword { get; set; }
        public string UserDelete { get; set; }
        public string ClientList { get; set; }
        public string ClientExport { get; set; }

    }
}
