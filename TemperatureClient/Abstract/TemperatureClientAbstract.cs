using TemperatureApiClient.Config;
using TemperatureApiClient.Interfaces;

namespace TemperatureApiClient.Abstract
{
    public abstract class TemperatureClientAbstract
    {
        public readonly IApiClient _apiClient;
        public readonly EndPointInfo _endPointInfo;

        public TemperatureClientAbstract(IApiClient apiClient, EndPointInfo endPointInfo)
        {
            _apiClient = apiClient;
            _endPointInfo = endPointInfo;
        }
    }
}
