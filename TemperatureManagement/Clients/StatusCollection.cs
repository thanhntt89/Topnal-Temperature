using System.Collections.Generic;

namespace TemperatureManagement.Clients
{
    public class StatusCollection
    {
        public List<Status> statuses;
        public StatusCollection()
        {       
            statuses = new List<Status>();

            statuses.Add(new Status()
            {
                Id = 1,
                StatusText = "全て"
            });
            statuses.Add(new Status()
            {
                Id = 2,
                StatusText = "測定した"
            }); 
            statuses.Add(new Status()
            {
                Id = 3,
                StatusText = "装着していない"
            });
            statuses.Add(new Status()
            {
                Id = 4,
                StatusText = "未測定"
            });
        }
    }

    public class Status
    {
        public int Id { get; set; }
        public string StatusText { get; set; }
    }
}
