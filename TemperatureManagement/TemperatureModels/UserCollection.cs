using System;
using System.Collections.Generic;
using System.Linq;
using static TemperatureModels.UserChangePassword;
using static TemperatureModels.UserDelete;
using static TemperatureModels.UserList;
using static TemperatureModels.UserRegister;
using static TemperatureModels.UserResetPassword;

namespace TemperatureModels
{
    [Serializable]
    public static class UserCollection
    {
        private static readonly string AdminUserDefault = "administrator";
        private static readonly string PasswordAdminDefault = "admin_123456";
        private static readonly int AdminId = 1;

        public static List<UserInfo> userInfos = new List<UserInfo>();

        public static void Add(UserInfo user)
        {
            user.UserId = userInfos.Count + 1;
            user.PasswordReset = 1;
            user.Authy = 2;
            userInfos.Add(user);
        }

        public static void Update(UserInfo user)
        {
            var exist = GetUserById(user.UserId);

            if (exist == null)
                return;

            exist.UserName = user.UserName;
            exist.Password = user.Password;
            exist.PasswordReset = user.PasswordReset;
            exist.RegDate = user.RegDate;
            exist.UpdateDate = user.UpdateDate;
            exist.Pds = user.Pds;
            exist.DelDate = user.DelDate;
            exist.Authy = user.Authy;
        }

        public static void Delete(int userId)
        {
            var exist = GetUserById(userId);
            if (exist != null)
                userInfos.Remove(exist);
        }

        public static int GetUserIdByUserName(string userName)
        {
            var exist = userInfos.Where(r => r.UserName.Equals(userName)).FirstOrDefault();
            return exist == null ? -1 : exist.UserId;
        }

        public static UserInfo GetUserById(int userId)
        {
            var exist = userInfos.Where(r => r.UserId == userId).FirstOrDefault();
            if (exist == null)
            {
                return null;
            }

            return exist;
        }

        public static LoginResponse CheckLoginResponse(LoginRequest loginRequest)
        {
            LoginResponse response = new LoginResponse();

            if (loginRequest.UserName.Equals(AdminUserDefault))
            {
                if (loginRequest.Password.Equals(PasswordAdminDefault))
                {
                    response.Status = "OK";
                    response.AdminFlg = 1;
                    response.UserId = AdminId;
                }
                else
                {
                    response.Status = "NG";
                    response.ErrorInfo = new ErrorInfo() { Message = "You don't have permission!!!" };
                }
            }
            else
            {
                var exist = userInfos.Where(r => r.UserName.Equals(loginRequest.UserName) && r.Password.Equals(loginRequest.Password)).FirstOrDefault();
                if (exist != null)
                {
                    response.Status = "OK";
                    response.AdminFlg = 0;
                    response.UserId = exist.UserId;
                    response.ChangePasswordFlg = exist.PasswordReset;
                }
                else
                {
                    response.Status = "NG";
                    response.ErrorInfo = new ErrorInfo() { Message = "You don't have permission!!!" };
                }
            }
            return response;
        }

        public static UserChangePasswordResponse ChangePasswordResponse(UserChangePasswordRequest request)
        {
            UserChangePasswordResponse response = new UserChangePasswordResponse();
            var exist = userInfos.Where(r => r.UserId == request.LoginId && r.Password.Equals(request.OldPassword)).FirstOrDefault();
            if (exist != null)
            {
                exist.Password = request.NewPassword;
                exist.PasswordReset = 0;
                exist.PasswordReset = 0;
                Update(exist);
                response.Status = "OK";
            }
            else
            {
                response.Status = "NG";
                response.ErrorInfo = new ErrorInfo() { Message = "現在のパスワードが間違いました。" };
            }

            return response;
        }

        public static UserRegisterResponse RegisterUserResponse(UserRegisterRequest request)
        {
            UserRegisterResponse response = new UserRegisterResponse();

            if (request.LoginId == AdminId)
            {
                string userName = CreateUserName();
                response.Status = "OK";

                Add(new UserInfo()
                {
                    UserName = userName,
                    Password = userName,
                    PasswordReset = 1,
                    UpdateDate = DateTime.Now,
                    RegDate = DateTime.Now,
                    Authy = 2
                });

                response.UserId = GetUserIdByUserName(userName);
            }
            else
            {
                response.Status = "NG";
                response.ErrorInfo = new ErrorInfo() { Message = "You don't have permission!!!" };
            }
            return response;
        }

        public static UserListResponse GetUserListResponse(UserListRequest request)
        {
            UserListResponse response = new UserListResponse();
            List<User> users = new List<User>();
            foreach (UserInfo user in userInfos)
            {
                users.Add(new User()
                {
                    UserId = user.UserId,
                    UserName = user.UserName,
                    UpdatedDate = user.UpdateDate.ToString("yyy/MM/dd HH:mm:ss"),
                    CreatedDate = user.RegDate.ToString("yyy/MM/dd HH:mm:ss")
                });
            }
            response.Status = "OK";
            response.Users = users;
            return response;
        }

        public static UserDeleteResponse DeleteUserResponse(UserDeleteRequest request)
        {
            UserDeleteResponse response = new UserDeleteResponse();
            if (request.LoginId == AdminId)
            {
                response.Status = "OK";
                Delete(request.UserId);
            }
            else
            {
                response.Status = "NG";
                response.ErrorInfo = new ErrorInfo() { Message = "You don't have permission!!" };
            }

            return response;
        }

        public static UserResetPasswordResponse ResetPasswordResponse(UserResetPasswordRequest request)
        {
            UserResetPasswordResponse response = new UserResetPasswordResponse();
            if (request.LoginId == AdminId)
            {
                response.Status = "OK";
                var exist = GetUserById(request.UserId);
                if (exist != null)
                {
                    exist.Password = exist.UserName;
                }
            }
            else
            {
                response.Status = "NG";
                response.ErrorInfo = new ErrorInfo() { Message = "You don't have permission!!" };
            }

            return response;
        }

        public static string CreateUserName()
        {
            int maxLength = 8;
            string preFix = "TF";
            string userName = string.Empty;
            int maxId = userInfos.Count + 1;
            int pad = maxLength - preFix.Length;
            userName = string.Format("{0}{1}", preFix, maxId.ToString().PadLeft(pad, '0'));

            var exist = userInfos.Where(r => r.UserName.Equals(userName)).FirstOrDefault();

            if (exist != null)
            {
                CreateUserName();
            }
            return userName;
        }
    }


    [Serializable]
    public class UserInfo
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int PasswordReset { get; set; }
        public DateTime RegDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime DelDate { get; set; }
        public string Pds { get; set; }
        public int Authy { get; set; }
    }
}
