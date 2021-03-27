namespace TemperatureManagement
{
    partial class TemperatureMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemperatureMain));
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUserLogin = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.temperatureSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnClients = new System.Windows.Forms.ToolStripMenuItem();
            this.mnUserManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.mnChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.mnLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain = new System.Windows.Forms.Panel();
            this.StatusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusStrip
            // 
            this.StatusStrip.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblUserLogin});
            this.StatusStrip.Location = new System.Drawing.Point(0, 605);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(1022, 22);
            this.StatusStrip.TabIndex = 0;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(67, 17);
            this.toolStripStatusLabel1.Text = "ユーザー名：";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // lblUserLogin
            // 
            this.lblUserLogin.Name = "lblUserLogin";
            this.lblUserLogin.Size = new System.Drawing.Size(16, 17);
            this.lblUserLogin.Text = "...";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.temperatureSystemToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1022, 24);
            this.menuStrip.TabIndex = 1;
            // 
            // temperatureSystemToolStripMenuItem
            // 
            this.temperatureSystemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnLogin,
            this.mnClients,
            this.mnUserManagement,
            this.mnChangePassword,
            this.mnLogOut});
            this.temperatureSystemToolStripMenuItem.Name = "temperatureSystemToolStripMenuItem";
            this.temperatureSystemToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.temperatureSystemToolStripMenuItem.Text = "メニュー";
            // 
            // mnLogin
            // 
            this.mnLogin.Name = "mnLogin";
            this.mnLogin.Size = new System.Drawing.Size(180, 22);
            this.mnLogin.Text = "ログイン";
            this.mnLogin.Click += new System.EventHandler(this.mnLogin_Click);
            // 
            // mnClients
            // 
            this.mnClients.Name = "mnClients";
            this.mnClients.Size = new System.Drawing.Size(180, 22);
            this.mnClients.Text = "統計画面";
            this.mnClients.Visible = false;
            this.mnClients.Click += new System.EventHandler(this.mnClients_Click);
            // 
            // mnUserManagement
            // 
            this.mnUserManagement.Name = "mnUserManagement";
            this.mnUserManagement.Size = new System.Drawing.Size(180, 22);
            this.mnUserManagement.Text = "ユーザー管理";
            this.mnUserManagement.Click += new System.EventHandler(this.mnUserManagement_Click);
            // 
            // mnChangePassword
            // 
            this.mnChangePassword.Name = "mnChangePassword";
            this.mnChangePassword.Size = new System.Drawing.Size(180, 22);
            this.mnChangePassword.Text = "パスワード更新";
            this.mnChangePassword.Visible = false;
            this.mnChangePassword.Click += new System.EventHandler(this.mnChangePassword_Click);
            // 
            // mnLogOut
            // 
            this.mnLogOut.Name = "mnLogOut";
            this.mnLogOut.Size = new System.Drawing.Size(180, 22);
            this.mnLogOut.Text = "ログアウト";
            this.mnLogOut.Visible = false;
            this.mnLogOut.Click += new System.EventHandler(this.mnLogOut_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 24);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1022, 581);
            this.panelMain.TabIndex = 2;
            // 
            // TemperatureMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1022, 627);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "TemperatureMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temperature System";
            this.Load += new System.EventHandler(this.TemperatureMain_Load);
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem temperatureSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnLogin;
        private System.Windows.Forms.ToolStripMenuItem mnUserManagement;
        private System.Windows.Forms.ToolStripMenuItem mnLogOut;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblUserLogin;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ToolStripMenuItem mnChangePassword;
        private System.Windows.Forms.ToolStripMenuItem mnClients;
    }
}

