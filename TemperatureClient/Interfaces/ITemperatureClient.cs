using TemperatureModels;
using static TemperatureModels.ClientExport;
using static TemperatureModels.ClientList;
using static TemperatureModels.UserChangePassword;
using static TemperatureModels.UserDelete;
using static TemperatureModels.UserList;
using static TemperatureModels.UserRegister;
using static TemperatureModels.UserResetPassword;

namespace TemperatureApiClient.Interfaces
{
    public interface ITemperatureClient
    {       
        LoginResponse GetLoginInfo(LoginRequest request);
        UserListResponse GetTAdminUsers(UserListRequest request);
        UserRegisterResponse RegisterTAdminUser(UserRegisterRequest request);
        UserResetPasswordResponse ResetPasswordTAdminUser(UserResetPasswordRequest request);
        UserChangePasswordResponse ChangePasswordTAdminUser(UserChangePasswordRequest request);
        UserDeleteResponse DeleteTAdminUser(UserDeleteRequest request);
        ClientListResponse GetClients(ClientListRequest request);
        ClientExportResponse GetClientExport(ClientExportRequest request); 
    }
}
