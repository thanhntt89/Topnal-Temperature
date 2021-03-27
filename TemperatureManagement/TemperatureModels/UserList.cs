using Newtonsoft.Json;
using System.Collections.Generic;

namespace TemperatureModels
{
    public class UserList
    {
        public class UserListRequest
        {
            [JsonProperty("login_id")]
            public int LoginId { get; set; }
        }

        public class UserListResponse
        {
            [JsonProperty("users")]
            public IEnumerable<User> Users { get; set; }
            [JsonProperty("status")]
            public string Status { get; set; }
            [JsonProperty("error_info")]
            public ErrorInfo ErrorInfo { get; set; }

            public void InitList()
            {
                int index = 0;
                foreach (var item in Users)
                {
                    index++;
                    item.No = index;
                }
            }
        }

        public class User
        {
            public int No { get; set; }
            [JsonProperty("user_id")]
            public int UserId { get; set; }
            [JsonProperty("user_name")]
            public string UserName { get; set; }
            [JsonProperty("reg_date")]
            public string CreatedDate { get; set; }
            [JsonProperty("upd_date")]
            public string UpdatedDate { get; set; }
            public string ActionResetPassword { get { return "パスワードリセット"; } }
            public string ActionDelete { get { return "削除"; } }
        }
    }
}
