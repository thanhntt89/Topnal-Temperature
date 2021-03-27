using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TemperatureApiClient;
using TemperatureApiClient.Utilities;
using TemperatureModels;
using static TemperatureModels.UserChangePassword;

namespace TemperatureManagement.Users
{
    public partial class ChangePassword : Form
    {
        private bool _isChangePassword = false;
        private bool isSuccess = false;

        public ChangePassword(bool isChangePassword)
        {
            InitializeComponent();
            _isChangePassword = isChangePassword;
        }

        public ChangePassword()
        {
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            UserChangePassword();
        }

        private bool Valid()
        {
            if (string.IsNullOrWhiteSpace(txtCurrentPassword.Text))
            {
                MessageBox.Show(string.Format("{0} 現在のパスワードを入力してください。", lblCurrentPassword.Text), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCurrentPassword.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNewPassword.Text))
            {
                MessageBox.Show(string.Format("{0} 新しいのパスワードを入力してください。", lblNewPassword.Text), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPassword.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                MessageBox.Show(string.Format("{0} 新しいのパスワード（確認）を入力してください。", lblConfirmPassword.Text), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Focus();
                return false;
            }
            if (!txtNewPassword.Text.Equals(txtConfirmPassword.Text))
            {
                MessageBox.Show(string.Format("新しいのパスワードと新しいのパスワード（確認）が一致しません。"), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Focus();
                return false;
            }

            var rst = MessageBox.Show("Do you want to change password?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rst != DialogResult.Yes)
                return false;
            return true;
        }

        private void UserChangePassword()
        {
            if (!Valid())
                return;
            try
            {
                UserChangePasswordRequest request = new UserChangePasswordRequest()
                {
                    LoginId = Constants.LoginId,
                    OldPassword = txtCurrentPassword.Text,
                    NewPassword = txtNewPassword.Text
                };

                UserChangePasswordResponse response = UserCollection.ChangePasswordResponse(request);

                if (response.Status.Equals(Constants.ResponseStatusSuccess))
                {
                    MessageBox.Show("Change password scucessful!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isSuccess = true;
                    Utils.SerializeObjectToBinary<List<UserInfo>>(UserCollection.userInfos, Constants.UserPath);
                    btnClose_Click(null, null);
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (_isChangePassword && !isSuccess)
            {
                Application.Exit();
            }
            else if (isSuccess)
            {
                this.Close();
            }
        }

        private void ChangePassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isChangePassword && !isSuccess)
            {
                Application.Exit();
            }
        }
    }
}
