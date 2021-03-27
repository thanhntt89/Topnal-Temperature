using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TemperatureApiClient;
using TemperatureApiClient.Utilities;
using TemperatureModels;
using static TemperatureModels.UserDelete;
using static TemperatureModels.UserList;
using static TemperatureModels.UserRegister;
using static TemperatureModels.UserResetPassword;

namespace TemperatureManagement.Users
{
    public partial class UCUserList : UserControl
    {
        public UCUserList()
        {
            InitializeComponent();
        }

        private void UCUserList_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void btnRegistUser_Click(object sender, EventArgs e)
        {
            AddNewUser();          
        }

        private void LoadUsers()
        {
            try
            {
                UserListRequest request = new UserListRequest()
                {
                    LoginId = Constants.LoginId
                };
              
                UserListResponse response = UserCollection.GetUserListResponse(request);

                if (response.Status.Equals(Constants.ResponseStatusSuccess))
                {
                    response.InitList();
                    dgtUsers.DataSource = response.Users;
                }
                else if (response.Status.Equals(Constants.ResponseStatusFails))
                {
                    MessageBox.Show(response.ErrorInfo.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error:{0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddNewUser()
        {
            AddUser addUser = new AddUser();
            addUser.ReLoadUserEvent += LoadUsers;
            addUser.ShowDialog();
            try
            {
                Utils.SerializeObjectToBinary<List<UserInfo>>(UserCollection.userInfos, Constants.UserPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("System error:{0}", ex.Message), "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegisterUser()
        {
            var rst = MessageBox.Show("Do you want to register new admin user?", "Infomation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (rst == DialogResult.No)
                return;
            try
            {
                UserRegisterRequest userRegister = new UserRegisterRequest()
                {
                    LoginId = Constants.LoginId
                };
             
                UserRegisterResponse response = UserCollection.RegisterUserResponse(userRegister);

                if (response.Status.Equals(Constants.ResponseStatusSuccess))
                {
                    MessageBox.Show(string.Format("Register userId:{0} sucessful!", response.UserId), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Utils.SerializeObjectToBinary<List<UserInfo>>(UserCollection.userInfos, Constants.UserPath);
                }
                else if (response.Status.Equals(Constants.ResponseStatusFails))
                {
                    MessageBox.Show(response.ErrorInfo.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("System error:{0}", ex.Message), "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgtUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ResetPassword();
            DeleteUser();
        }

        private void ResetPassword()
        {
            if (!dgtUsers.CurrentCell.OwningColumn.Name.Equals(colActionResetPassword.Name))
            {
                return;
            }
            int userId = dgtUsers.Rows[dgtUsers.CurrentRow.Index].Cells[colUserId.Name].Value == null ? -1 : System.Convert.ToInt32(dgtUsers.Rows[dgtUsers.CurrentRow.Index].Cells[colUserId.Name].Value);
            string userName = dgtUsers.Rows[dgtUsers.CurrentRow.Index].Cells[colUserName.Name].Value == null ? string.Empty : dgtUsers.Rows[dgtUsers.CurrentRow.Index].Cells[colUserName.Name].Value.ToString();
            
            var rst = MessageBox.Show(string.Format("Do you want to reset password for user:{0}?", userName), "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rst == DialogResult.No)
                return;

            try
            {
                UserResetPasswordRequest passwordRequest = new UserResetPasswordRequest()
                {
                    LoginId = Constants.LoginId,
                    UserId = userId
                };

                UserResetPasswordResponse response = UserCollection.ResetPasswordResponse(passwordRequest);
                if (response.Status.Equals(Constants.ResponseStatusSuccess))
                {
                    MessageBox.Show(string.Format("Reset password for user:{0} sucessful!", userName), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Utils.SerializeObjectToBinary<List<UserInfo>>(UserCollection.userInfos, Constants.UserPath);
                }

                else if (response.Status.Equals(Constants.ResponseStatusFails))
                {
                    if (response.ErrorInfo != null)
                        MessageBox.Show(response.ErrorInfo.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("System error:{0}", ex.Message), "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteUser()
        {
            if (!dgtUsers.CurrentCell.OwningColumn.Name.Equals(colDelete.Name))
            {
                return;
            }

            int userId = dgtUsers.Rows[dgtUsers.CurrentRow.Index].Cells[colUserId.Name].Value == null ? -1 : System.Convert.ToInt32(dgtUsers.Rows[dgtUsers.CurrentRow.Index].Cells[colUserId.Name].Value.ToString());
            string userName = dgtUsers.Rows[dgtUsers.CurrentRow.Index].Cells[colUserName.Name].Value == null ? string.Empty : dgtUsers.Rows[dgtUsers.CurrentRow.Index].Cells[colUserName.Name].Value.ToString();
            
            var rst = MessageBox.Show(string.Format("Do you want to delete user:{0}?", userName), "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rst == DialogResult.No)
                return;

            try
            {
                UserDeleteRequest request = new UserDeleteRequest()
                {
                    LoginId = Constants.LoginId,
                    UserId = userId
                };

                UserDeleteResponse response = UserCollection.DeleteUserResponse(request);
                if (response.Status.Equals(Constants.ResponseStatusSuccess))
                {
                    MessageBox.Show(string.Format("Delete user:{0} sucessful!", userName), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Utils.SerializeObjectToBinary<List<UserInfo>>(UserCollection.userInfos, Constants.UserPath);
                    LoadUsers();
                }
                else if (response.Status.Equals(Constants.ResponseStatusFails))
                {
                    MessageBox.Show(response.ErrorInfo.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("System error:{0}", ex.Message), "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
