using Newtonsoft.Json;

namespace TemperatureModels
{
    public class UserResetPassword
    {
        public class UserResetPasswordRequest
        {
            [JsonProperty("login_id")]
            public int LoginId { get; set; }
            [JsonProperty("user_id")]
            public int UserId { get; set; }
        }

        public class UserResetPasswordResponse
        {
            [JsonProperty("status")]
            public string Status { get; set; }
            [JsonProperty("error_info")]
            public ErrorInfo ErrorInfo { get; set; }
        }
    }
}
