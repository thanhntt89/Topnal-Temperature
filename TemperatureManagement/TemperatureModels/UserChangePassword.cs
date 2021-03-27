using Newtonsoft.Json;

namespace TemperatureModels
{
    public class UserChangePassword
    {
        public class UserChangePasswordRequest
        {
            [JsonProperty("login_id")]
            public int LoginId { get; set; }
            [JsonProperty("old_password")]
            public string OldPassword { get; set; }
            [JsonProperty("new_password")]
            public string NewPassword { get; set; }
        }

        public class UserChangePasswordResponse
        {
            [JsonProperty("status")]
            public string Status { get; set; }

            [JsonProperty("error_info")]
            public ErrorInfo ErrorInfo { get; set; }
        }

    }
}
