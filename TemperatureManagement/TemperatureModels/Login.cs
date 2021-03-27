using Newtonsoft.Json;
using System;

namespace TemperatureModels
{
    [Serializable]
    public class LoginRequest
    {
        [JsonProperty("user_name")]
        public string UserName { get; set; }
        [JsonProperty("password")]
        public string Password { get; set; }
    }

    [Serializable]
    public class LoginResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("user_id")]
        public int UserId { get; set; }
        [JsonProperty("change_password_flg")]
        public int ChangePasswordFlg { get; set; }
        [JsonProperty("admin_flg")]
        public int AdminFlg { get; set; }
        [JsonProperty("error_info")]
        public ErrorInfo ErrorInfo { get; set; }
    }
}
