using Newtonsoft.Json;
using System.Collections.Generic;

namespace TemperatureModels
{
    public class ClientList
    {
        public class ClientListRequest
        {
            [JsonProperty("date")]
            public string Date { get; set; }

            [JsonProperty("status")]
            public string Status { get; set; }

            [JsonProperty("current_page")]
            public int CurrentPage { get; set; }

            [JsonProperty("limit")]
            public int Limit { get; set; } 
        }

        public class ClientListResponse
        {
            [JsonProperty("status")]
            public string Status { get; set; }

            [JsonProperty("error_info")]
            public ErrorInfo ErrorInfo { get; set; }

            [JsonProperty("current_page")]
            public int CurrentPage { get; set; }

            [JsonProperty("total_pages")]
            public int TotalPage { get; set; }

            [JsonProperty("rate_all_user")]
            public decimal RateAllUser { get; set; }

            [JsonProperty("rate_recent_user")]
            public decimal RateRecentUser { get; set; }

            [JsonProperty("total_users")]
            public decimal TotalUsers { get; set; }

            [JsonProperty("average_using_day")]
            public decimal AverageUsingDay { get; set; }

            [JsonProperty("clients")]
            public IEnumerable<Client> Clients { get; set; }          
        }
       
        public class Client
        {
            [JsonProperty("sns_id")]
            public string SnsId { get; set; }
            [JsonProperty("sns_type")]
            public string SnsType { get; set; }
            [JsonProperty("reg_date")]
            public decimal RegDate { get; set; }
            [JsonProperty("temperature_date5_value")]
            public decimal TemperatureDate5Value { get; set; }
            [JsonProperty("temperature_date4_value")]
            public decimal TemperatureDate4Value { get; set; }
            [JsonProperty("temperature_date3_value")]
            public decimal TemperatureDate3Value { get; set; }
            [JsonProperty("temperature_date2_value")]
            public decimal TemperatureDate2Value { get; set; }
            [JsonProperty("temperature_date1_value")]
            public decimal TemperatureDate1Value { get; set; }
            [JsonProperty("rate_month5_value")]
            public decimal RateMonth5Value { get; set; }
            [JsonProperty("rate_month4_value")]
            public decimal RateMonth4Value { get; set; }
            [JsonProperty("rate_month3_value")]
            public decimal RateMonth3Value { get; set; }
            [JsonProperty("rate_month2_value")]
            public decimal RateMonth2Value { get; set; }
            [JsonProperty("rate_month1_value")]
            public decimal RateMonth1Value { get; set; }
            [JsonProperty("rate_six_months_ago")]
            public decimal RateSixMonthsAgo { get; set; }
            [JsonProperty("rate_started")]
            public decimal RateStarted { get; set; }
        }
    }
}
