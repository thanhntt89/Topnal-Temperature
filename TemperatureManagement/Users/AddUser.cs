using System;
using System.Windows.Forms;
using TemperatureModels;

namespace TemperatureManagement.Users
{
    public partial class AddUser : Form
    {
        public delegate void ReLoadUserHandle();
        public ReLoadUserHandle ReLoadUserEvent;


        public AddUser()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddNew();
        }

        private void AddNew()
        {
            if (!Valid())
                return;

            AddUer();
        }

        private bool Valid()
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                MessageBox.Show(string.Format("{0} is empty!", label1.Text), "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUserName.Focus();
                return false;
            }

            if (!txtUserName.Text.Substring(0, 1).Contains("A"))
            {
                MessageBox.Show(string.Format("{0} A+英数字を入力してください。", label1.Text), "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUserName.Focus();
                return false;
            }

            if (txtUserName.Text.Trim().Length < 7)
            {
                MessageBox.Show(string.Format("{0} must length 7 chars!", label1.Text), "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUserName.Focus();
                return false;
            }

            var userId = UserCollection.GetUserIdByUserName(txtUserName.Text);
            if (userId != -1)
            {
                MessageBox.Show(string.Format("{0} ユーザーIDが重複しています。別のユーザーIDを入力してください。", txtUserName.Text), "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUserName.Focus();
                return false;
            }

            return true;
        }

        private void AddUer()
        {
            UserCollection.Add(
                new UserInfo()
                {
                    UserName = txtUserName.Text,
                    Password = txtUserName.Text,
                    PasswordReset = 1,
                    UpdateDate = DateTime.Now,
                    RegDate = DateTime.Now,
                    Authy = 2
                });

            MessageBox.Show(string.Format("ユーザー登録が完了しました。", txtUserName.Text), "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (ReLoadUserEvent != null)
                ReLoadUserEvent();
        }
    }
}
