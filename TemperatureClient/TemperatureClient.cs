using Newtonsoft.Json;
using System.Threading.Tasks;
using TemperatureApiClient.Abstract;
using TemperatureApiClient.Config;
using TemperatureApiClient.Enums;
using TemperatureApiClient.Interfaces;
using TemperatureModels;
using static TemperatureModels.ClientExport;
using static TemperatureModels.ClientList;
using static TemperatureModels.UserChangePassword;
using static TemperatureModels.UserDelete;
using static TemperatureModels.UserList;
using static TemperatureModels.UserRegister;
using static TemperatureModels.UserResetPassword;

namespace TemperatureApiClient
{
    public class TemperatureClient : TemperatureClientAbstract, ITemperatureClient
    {
        public TemperatureClient(IApiClient apiClient, EndPointInfo endPointInfo) : base(apiClient, endPointInfo)
        {

        }

        public ClientListResponse GetClients(ClientListRequest request)
        {
            var args = JsonConvert.SerializeObject(request);
            var task = Task.Run(() => _apiClient.CallAsync<ClientListResponse>(ApiMethod.POST, _endPointInfo.ClientList, args));
            task.Wait();
            return task.Result;
        }

        public ClientExportResponse GetClientExport(ClientExportRequest request)
        {
            var args = JsonConvert.SerializeObject(request);
            var task = Task.Run(() => _apiClient.CallAsync<ClientExportResponse>(ApiMethod.POST, _endPointInfo.ClientExport, args));
            task.Wait();
            return task.Result;
        }

        public LoginResponse GetLoginInfo(LoginRequest request)
        {
            var args = JsonConvert.SerializeObject(request);
        
            var task = Task.Run(() => _apiClient.CallAsync<LoginResponse>(ApiMethod.POST, _endPointInfo.Login, args));
            task.Wait();
            return task.Result;
        }

        public UserListResponse GetTAdminUsers(UserListRequest request)
        {
            var args = JsonConvert.SerializeObject(request);
            var task = Task.Run(() => _apiClient.CallAsync<UserListResponse>(ApiMethod.POST, _endPointInfo.UserList, args));
            task.Wait();
            return task.Result;
        }

        public UserDeleteResponse DeleteTAdminUser(UserDeleteRequest request)
        {
            var args = JsonConvert.SerializeObject(request);
            var task = Task.Run(() => _apiClient.CallAsync<UserDeleteResponse>(ApiMethod.POST, _endPointInfo.UserDelete, args));
            task.Wait();
            return task.Result;
        }

        public UserRegisterResponse RegisterTAdminUser(UserRegisterRequest request)
        {
            var args = JsonConvert.SerializeObject(request);
            var task = Task.Run(() => _apiClient.CallAsync<UserRegisterResponse>(ApiMethod.POST, _endPointInfo.UserRegiester, args));
            task.Wait();
            return task.Result;
        }

        public UserResetPasswordResponse ResetPasswordTAdminUser(UserResetPasswordRequest request)
        {
            var args = JsonConvert.SerializeObject(request);
            var task = Task.Run(() => _apiClient.CallAsync<UserResetPasswordResponse>(ApiMethod.POST, _endPointInfo.UserResetPassword, args));
            task.Wait();
            return task.Result;
        }

        public UserChangePasswordResponse ChangePasswordTAdminUser(UserChangePasswordRequest request)
        {
            var args = JsonConvert.SerializeObject(request);
            var task = Task.Run(() => _apiClient.CallAsync<UserChangePasswordResponse>(ApiMethod.POST, _endPointInfo.UserUpdatePassword, args));
            task.Wait();
            return task.Result;
        }

       
    }
}
