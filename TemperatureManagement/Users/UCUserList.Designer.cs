namespace TemperatureManagement.Users
{
    partial class UCUserList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgtUsers = new System.Windows.Forms.DataGridView();
            this.btnRegistUser = new System.Windows.Forms.Button();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colActionResetPassword = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colUpdatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgtUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgtUsers
            // 
            this.dgtUsers.AllowUserToDeleteRows = false;
            this.dgtUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgtUsers.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgtUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIndex,
            this.colUserId,
            this.colUserName,
            this.colCreatedDate,
            this.colUpdatedDate,
            this.colActionResetPassword,
            this.colDelete});
            this.dgtUsers.Location = new System.Drawing.Point(3, 3);
            this.dgtUsers.Name = "dgtUsers";
            this.dgtUsers.ReadOnly = true;
            this.dgtUsers.Size = new System.Drawing.Size(941, 512);
            this.dgtUsers.TabIndex = 1;
            this.dgtUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtUsers_CellClick);           
            // 
            // btnRegistUser
            // 
            this.btnRegistUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRegistUser.Location = new System.Drawing.Point(3, 521);
            this.btnRegistUser.Name = "btnRegistUser";
            this.btnRegistUser.Size = new System.Drawing.Size(75, 23);
            this.btnRegistUser.TabIndex = 2;
            this.btnRegistUser.Text = "利用者登録";
            this.btnRegistUser.UseVisualStyleBackColor = true;
            this.btnRegistUser.Click += new System.EventHandler(this.btnRegistUser_Click);
            // 
            // colDelete
            // 
            this.colDelete.DataPropertyName = "ActionDelete";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "Delete";
            this.colDelete.DefaultCellStyle = dataGridViewCellStyle2;
            this.colDelete.HeaderText = "";
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            // 
            // colActionResetPassword
            // 
            this.colActionResetPassword.DataPropertyName = "ActionResetPassword";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "Reset Password";
            this.colActionResetPassword.DefaultCellStyle = dataGridViewCellStyle1;
            this.colActionResetPassword.HeaderText = "";
            this.colActionResetPassword.Name = "colActionResetPassword";
            this.colActionResetPassword.ReadOnly = true;
            // 
            // colUpdatedDate
            // 
            this.colUpdatedDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colUpdatedDate.DataPropertyName = "UpdatedDate";
            this.colUpdatedDate.HeaderText = "更新日";
            this.colUpdatedDate.Name = "colUpdatedDate";
            this.colUpdatedDate.ReadOnly = true;
            // 
            // colCreatedDate
            // 
            this.colCreatedDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCreatedDate.DataPropertyName = "CreatedDate";
            this.colCreatedDate.HeaderText = "作成日";
            this.colCreatedDate.Name = "colCreatedDate";
            this.colCreatedDate.ReadOnly = true;
            // 
            // colUserId
            // 
            this.colUserId.DataPropertyName = "UserId";
            this.colUserId.HeaderText = "利用者ID";
            this.colUserId.Name = "colUserId";
            this.colUserId.ReadOnly = true;
            this.colUserId.Visible = false;
            this.colUserId.Width = 200;
            // 
            // colUserName
            // 
            this.colUserName.DataPropertyName = "UserName";
            this.colUserName.HeaderText = "利用者Name";
            this.colUserName.Name = "colUserName";
            this.colUserName.ReadOnly = true;
            this.colUserName.Width = 200;
            // 
            // colIndex
            // 
            this.colIndex.DataPropertyName = "No";
            this.colIndex.HeaderText = "No";
            this.colIndex.Name = "colIndex";
            this.colIndex.ReadOnly = true;
            this.colIndex.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colIndex.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colIndex.Width = 50;
            // 
            // UCUserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnRegistUser);
            this.Controls.Add(this.dgtUsers);
            this.Name = "UCUserList";
            this.Size = new System.Drawing.Size(947, 552);
            this.Load += new System.EventHandler(this.UCUserList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgtUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgtUsers;
        private System.Windows.Forms.Button btnRegistUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUpdatedDate;
        private System.Windows.Forms.DataGridViewButtonColumn colActionResetPassword;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
    }
}
