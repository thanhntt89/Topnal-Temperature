using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using static TemperatureModels.ClientList;

namespace TemperatureModels
{
    public class ClientExport
    {
        public class ClientExportRequest
        {
            [JsonProperty("date")]
            public string Date { get; set; }

            [JsonProperty("status")]
            public string Status { get; set; }
        }

        public class ClientExportResponse
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
    }
}
