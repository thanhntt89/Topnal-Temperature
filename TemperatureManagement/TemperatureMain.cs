using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TemperatureApiClient;
using TemperatureApiClient.Config;
using TemperatureApiClient.Utilities;
using TemperatureManagement.Clients;
using TemperatureManagement.Users;
using TemperatureModels;

namespace TemperatureManagement
{
    public partial class TemperatureMain : Form
    {
        private UCClients uCClients;
        private UCUserList cUserList;

        public TemperatureMain()
        {
            InitializeComponent();
        }

        private void mnLogin_Click(object sender, System.EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
            ActiveLayout(login.loginResponse);
        }

        private void ActiveLayout(LoginResponse response)
        {
            if (response == null)
                return;

            mnLogin.Visible = false;
            mnClients.Visible = true;
            mnUserManagement.Visible = response.AdminFlg == 1 ? true : false;
            mnLogOut.Visible = true;
            mnChangePassword.Visible = response.AdminFlg == 1 ? false : true;
            lblUserLogin.Text = Constants.LoginName;

            mnClients_Click(null, null);
        }

        private void TemperatureMain_Load(object sender, System.EventArgs e)
        {
            LoadConfig();
            mnLogin_Click(null, null);
        }

        private void LoadConfig()
        {
            try
            {              
                //Load UserList
                UserCollection.userInfos = Utils.DeSerializeBinaryObject<List<UserInfo>>(Constants.UserPath);

                // Get config info
                ApiConfig apiConfig = Utils.DeSerializeObject<ApiConfig>(Constants.ConfigPath);

                ApiClient apiClient = new ApiClient(apiConfig.ApiInfos.ApiKey, apiConfig.ApiInfos.ApiSecret, apiConfig.ApiInfos.ApiUrl);
                TemperatureSystem.iTemperatureClient = new TemperatureClient(apiClient, apiConfig.EnpointInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Load config error:{0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Application.Exit();
            }
        }

        private void mnLogOut_Click(object sender, System.EventArgs e)
        {
            LogOut();
        }

        private void LogOut()
        {
            panelMain.Controls.Clear();
            uCClients = null;
            cUserList = null;

            mnLogin.Visible = true;
            mnChangePassword.Visible = false;
            mnLogOut.Visible = false;
            mnUserManagement.Visible = false;
            mnClients.Visible = false;
            lblUserLogin.Text = string.Empty;
            mnLogin_Click(null, null);
        }

        private void mnChangePassword_Click(object sender, System.EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword();
            changePassword.ShowDialog();
        }

        private void AddControl(Control ctrl)
        {
            if (panelMain.Controls.Count > 0 && !panelMain.Controls[0].Name.Equals(ctrl.Name))
                panelMain.Controls.Clear();
            ctrl.Dock = DockStyle.Fill;
            try
            {
                panelMain.Controls.Add(ctrl);
            }
            catch
            {
            }

        }

        private void mnClients_Click(object sender, System.EventArgs e)
        {
            if (uCClients == null)
                uCClients = new UCClients();

            AddControl(uCClients);
        }

        private void mnUserManagement_Click(object sender, System.EventArgs e)
        {
            if (cUserList == null)
                cUserList = new UCUserList();

            AddControl(cUserList);
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
