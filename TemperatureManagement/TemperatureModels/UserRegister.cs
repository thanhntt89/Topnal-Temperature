using Newtonsoft.Json;

namespace TemperatureModels
{
    public class UserRegister
    {
        public class UserRegisterRequest
        {
            [JsonProperty("login_id")]
            public int LoginId { get; set; }
        }

        public class UserRegisterResponse
        {
            [JsonProperty("user_id")]
            public int UserId { get; set; }
            [JsonProperty("status")]
            public string Status { get; set; }
            [JsonProperty("error_info")]
            public ErrorInfo ErrorInfo { get; set; }
        }
    }
}
