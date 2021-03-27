using Newtonsoft.Json;
using TemperatureModels;

namespace TemperatureModels
{
    public class UserDelete
    {
        public class UserDeleteRequest
        {
            [JsonProperty("login_id")]
            public int LoginId { get; set; }

            [JsonProperty("user_id")]
            public int UserId { get; set; }
          
        }

        public class UserDeleteResponse
        {
            [JsonProperty("status")]
            public string Status { get; set; }
            [JsonProperty("error_info")]
            public ErrorInfo ErrorInfo { get; set; }
        }
    }
}
