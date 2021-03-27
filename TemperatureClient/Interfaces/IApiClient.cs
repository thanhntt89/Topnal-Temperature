using System.Threading.Tasks;
using TemperatureApiClient.Enums;
using TemperatureModels;

namespace TemperatureApiClient.Interfaces
{
    public interface IApiClient
    {
        /// <summary>
        /// Call api funtction
        /// </summary>
        /// <typeparam name="T">Models</typeparam>
        /// <param name="apiMethod">Method</param>
        /// <param name="endPoint">Function api</param>
        /// <param name="isSinged">isSinged</param>
        /// <param name="body">parameters</param>
        /// <returns></returns>     
        Task<T> CallAsync<T>(ApiMethod apiMethod, string endPoint, string body = null, string parameters = null);

        T CallFunc<T>(ApiMethod apiMethod, string endPoint, bool isSinged = false, string parameters = null);
    }
}
