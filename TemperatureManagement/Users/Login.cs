using System;
using System.Windows.Forms;
using TemperatureApiClient;
using TemperatureModels;

namespace TemperatureManagement.Users
{
    public partial class Login : Form
    {
        public bool IsLoginSuccess = false;
        public LoginResponse loginResponse;

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            IsLoginSuccess = Valid();
            if (IsLoginSuccess)
            {
                btnClosed_Click(null, null);
            }
        }

        private bool Valid()
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                MessageBox.Show("ユーザー名を入力してください。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("パスワードを入力してください。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return false;
            }
            try
            {
                LoginRequest request = new LoginRequest()
                {
                    UserName = txtUserName.Text,
                    Password = txtPassword.Text
                };

                loginResponse = UserCollection.CheckLoginResponse(request);

                if (loginResponse.Status.Equals(Constants.ResponseStatusSuccess))
                {
                    Constants.LoginId = loginResponse.UserId;
                    Constants.LoginName = txtUserName.Text;
                    if (loginResponse.ChangePasswordFlg == 1)
                    {
                        this.Hide();
                        ChangePassword changePassword = new ChangePassword(true);
                        changePassword.ShowDialog();
                    }
                }
                else if (loginResponse.Status.Equals(Constants.ResponseStatusFails) && loginResponse.ErrorInfo != null)
                {
                    if (loginResponse.ErrorInfo != null)
                        MessageBox.Show(loginResponse.ErrorInfo.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("System error:{0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void btnClosed_Click(object sender, EventArgs e)
        {
            if (IsLoginSuccess)
            {
                this.Close();
            }
            else
            {
                Application.Exit();
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!IsLoginSuccess)
                Application.Exit();
        }
    }
}
