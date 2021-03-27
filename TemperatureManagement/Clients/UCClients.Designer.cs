namespace TemperatureManagement.Clients
{
    partial class UCClients
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
            this.dtgSearchingInfo = new System.Windows.Forms.DataGridView();
            this.colSnsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSnsType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRegDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTemperatureDate5Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTemperatureDate4Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTemperatureDate3Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTemperatureDate2Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTemperatureDate1Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRateMonth5Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRateMonth4Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRateMonth3Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRateMonth2Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRateMonth1Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRateSixMonthsAgo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRateStarted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cboDisplayCount = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAllUserUtilization = new System.Windows.Forms.TextBox();
            this.txtMostRecentUserRate = new System.Windows.Forms.TextBox();
            this.txtNumberOfUsers = new System.Windows.Forms.TextBox();
            this.txtAverageNumberOfDaysForAllUsers = new System.Windows.Forms.TextBox();
            this.bntExport = new System.Windows.Forms.Button();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ucPaging = new TemperatureManagement.UCPaging();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSearchingInfo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgSearchingInfo
            // 
            this.dtgSearchingInfo.AllowUserToAddRows = false;
            this.dtgSearchingInfo.AllowUserToDeleteRows = false;
            this.dtgSearchingInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgSearchingInfo.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgSearchingInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSearchingInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSnsId,
            this.colSnsType,
            this.colRegDate,
            this.colTemperatureDate5Value,
            this.colTemperatureDate4Value,
            this.colTemperatureDate3Value,
            this.colTemperatureDate2Value,
            this.colTemperatureDate1Value,
            this.colRateMonth5Value,
            this.colRateMonth4Value,
            this.colRateMonth3Value,
            this.colRateMonth2Value,
            this.colRateMonth1Value,
            this.colRateSixMonthsAgo,
            this.colRateStarted});
            this.dtgSearchingInfo.Location = new System.Drawing.Point(3, 77);
            this.dtgSearchingInfo.Name = "dtgSearchingInfo";
            this.dtgSearchingInfo.ReadOnly = true;
            this.dtgSearchingInfo.Size = new System.Drawing.Size(969, 396);
            this.dtgSearchingInfo.TabIndex = 1;
            this.dtgSearchingInfo.SizeChanged += new System.EventHandler(this.dtgSearchingInfo_SizeChanged);
            // 
            // colSnsId
            // 
            this.colSnsId.DataPropertyName = "SnsId";
            this.colSnsId.HeaderText = "SNS ID";
            this.colSnsId.Name = "colSnsId";
            this.colSnsId.ReadOnly = true;
            this.colSnsId.Width = 150;
            // 
            // colSnsType
            // 
            this.colSnsType.DataPropertyName = "SnsType";
            this.colSnsType.HeaderText = "SNS TYPE";
            this.colSnsType.Name = "colSnsType";
            this.colSnsType.ReadOnly = true;
            this.colSnsType.Width = 150;
            // 
            // colRegDate
            // 
            this.colRegDate.DataPropertyName = "RegDate";
            this.colRegDate.HeaderText = "利用開始日";
            this.colRegDate.Name = "colRegDate";
            this.colRegDate.ReadOnly = true;
            this.colRegDate.Width = 150;
            // 
            // colTemperatureDate5Value
            // 
            this.colTemperatureDate5Value.DataPropertyName = "TemperatureDate5Value";
            this.colTemperatureDate5Value.HeaderText = "温度5";
            this.colTemperatureDate5Value.Name = "colTemperatureDate5Value";
            this.colTemperatureDate5Value.ReadOnly = true;
            // 
            // colTemperatureDate4Value
            // 
            this.colTemperatureDate4Value.DataPropertyName = "TemperatureDate4Value";
            this.colTemperatureDate4Value.HeaderText = "温度4";
            this.colTemperatureDate4Value.Name = "colTemperatureDate4Value";
            this.colTemperatureDate4Value.ReadOnly = true;
            // 
            // colTemperatureDate3Value
            // 
            this.colTemperatureDate3Value.DataPropertyName = "TemperatureDate3Value";
            this.colTemperatureDate3Value.HeaderText = "温度3";
            this.colTemperatureDate3Value.Name = "colTemperatureDate3Value";
            this.colTemperatureDate3Value.ReadOnly = true;
            // 
            // colTemperatureDate2Value
            // 
            this.colTemperatureDate2Value.DataPropertyName = "TemperatureDate2Value";
            this.colTemperatureDate2Value.HeaderText = "温度2";
            this.colTemperatureDate2Value.Name = "colTemperatureDate2Value";
            this.colTemperatureDate2Value.ReadOnly = true;
            // 
            // colTemperatureDate1Value
            // 
            this.colTemperatureDate1Value.DataPropertyName = "TemperatureDate1Value";
            this.colTemperatureDate1Value.HeaderText = "温度1";
            this.colTemperatureDate1Value.Name = "colTemperatureDate1Value";
            this.colTemperatureDate1Value.ReadOnly = true;
            // 
            // colRateMonth5Value
            // 
            this.colRateMonth5Value.DataPropertyName = "RateMonth5Value";
            this.colRateMonth5Value.HeaderText = "利用率5";
            this.colRateMonth5Value.Name = "colRateMonth5Value";
            this.colRateMonth5Value.ReadOnly = true;
            // 
            // colRateMonth4Value
            // 
            this.colRateMonth4Value.DataPropertyName = "RateMonth4Value";
            this.colRateMonth4Value.HeaderText = "利用率4";
            this.colRateMonth4Value.Name = "colRateMonth4Value";
            this.colRateMonth4Value.ReadOnly = true;
            // 
            // colRateMonth3Value
            // 
            this.colRateMonth3Value.DataPropertyName = "RateMonth3Value";
            this.colRateMonth3Value.HeaderText = "利用率3";
            this.colRateMonth3Value.Name = "colRateMonth3Value";
            this.colRateMonth3Value.ReadOnly = true;
            // 
            // colRateMonth2Value
            // 
            this.colRateMonth2Value.DataPropertyName = "RateMonth2Value";
            this.colRateMonth2Value.HeaderText = "利用率2";
            this.colRateMonth2Value.Name = "colRateMonth2Value";
            this.colRateMonth2Value.ReadOnly = true;
            // 
            // colRateMonth1Value
            // 
            this.colRateMonth1Value.DataPropertyName = "RateMonth1Value";
            this.colRateMonth1Value.HeaderText = "利用率1";
            this.colRateMonth1Value.Name = "colRateMonth1Value";
            this.colRateMonth1Value.ReadOnly = true;
            // 
            // colRateSixMonthsAgo
            // 
            this.colRateSixMonthsAgo.DataPropertyName = "RateSixMonthsAgo";
            this.colRateSixMonthsAgo.HeaderText = "利用率 直近6ヶ月";
            this.colRateSixMonthsAgo.MinimumWidth = 150;
            this.colRateSixMonthsAgo.Name = "colRateSixMonthsAgo";
            this.colRateSixMonthsAgo.ReadOnly = true;
            this.colRateSixMonthsAgo.Width = 150;
            // 
            // colRateStarted
            // 
            this.colRateStarted.DataPropertyName = "RateStarted";
            this.colRateStarted.HeaderText = "利用率 利用開始～";
            this.colRateStarted.MinimumWidth = 150;
            this.colRateStarted.Name = "colRateStarted";
            this.colRateStarted.ReadOnly = true;
            this.colRateStarted.Width = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboStatus);
            this.groupBox1.Controls.Add(this.dtDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboDisplayCount);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 68);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "わたしの温度　統計ツール";
            // 
            // dtDate
            // 
            this.dtDate.CustomFormat = "yyyy/MM/dd";
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDate.Location = new System.Drawing.Point(42, 16);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(112, 20);
            this.dtDate.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "日付";
            // 
            // cboDisplayCount
            // 
            this.cboDisplayCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDisplayCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboDisplayCount.FormattingEnabled = true;
            this.cboDisplayCount.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "100",
            "200"});
            this.cboDisplayCount.Location = new System.Drawing.Point(216, 12);
            this.cboDisplayCount.Name = "cboDisplayCount";
            this.cboDisplayCount.Size = new System.Drawing.Size(82, 21);
            this.cboDisplayCount.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "表示件数";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(216, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "検索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 488);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total records:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "全ユーザー利用率";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(348, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "直近利用者率";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(586, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "利用者数";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(586, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "全ユーザー利用平均日数";
            // 
            // txtAllUserUtilization
            // 
            this.txtAllUserUtilization.Location = new System.Drawing.Point(449, 12);
            this.txtAllUserUtilization.Name = "txtAllUserUtilization";
            this.txtAllUserUtilization.ReadOnly = true;
            this.txtAllUserUtilization.Size = new System.Drawing.Size(129, 20);
            this.txtAllUserUtilization.TabIndex = 3;
            // 
            // txtMostRecentUserRate
            // 
            this.txtMostRecentUserRate.Location = new System.Drawing.Point(449, 38);
            this.txtMostRecentUserRate.Name = "txtMostRecentUserRate";
            this.txtMostRecentUserRate.ReadOnly = true;
            this.txtMostRecentUserRate.Size = new System.Drawing.Size(129, 20);
            this.txtMostRecentUserRate.TabIndex = 4;
            // 
            // txtNumberOfUsers
            // 
            this.txtNumberOfUsers.Location = new System.Drawing.Point(733, 12);
            this.txtNumberOfUsers.Name = "txtNumberOfUsers";
            this.txtNumberOfUsers.ReadOnly = true;
            this.txtNumberOfUsers.Size = new System.Drawing.Size(133, 20);
            this.txtNumberOfUsers.TabIndex = 5;
            // 
            // txtAverageNumberOfDaysForAllUsers
            // 
            this.txtAverageNumberOfDaysForAllUsers.Location = new System.Drawing.Point(733, 38);
            this.txtAverageNumberOfDaysForAllUsers.Name = "txtAverageNumberOfDaysForAllUsers";
            this.txtAverageNumberOfDaysForAllUsers.ReadOnly = true;
            this.txtAverageNumberOfDaysForAllUsers.Size = new System.Drawing.Size(133, 20);
            this.txtAverageNumberOfDaysForAllUsers.TabIndex = 6;
            // 
            // bntExport
            // 
            this.bntExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bntExport.Location = new System.Drawing.Point(3, 483);
            this.bntExport.Name = "bntExport";
            this.bntExport.Size = new System.Drawing.Size(75, 23);
            this.bntExport.TabIndex = 9;
            this.bntExport.Text = "CSV出力";
            this.bntExport.UseVisualStyleBackColor = true;
            this.bntExport.Click += new System.EventHandler(this.bntDownLoad_Click);
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "100",
            "200"});
            this.cboStatus.Location = new System.Drawing.Point(42, 39);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(112, 21);
            this.cboStatus.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "状況";
            // 
            // ucPaging
            // 
            this.ucPaging.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ucPaging.Location = new System.Drawing.Point(672, 479);
            this.ucPaging.Name = "ucPaging";
            this.ucPaging.Size = new System.Drawing.Size(300, 29);
            this.ucPaging.TabIndex = 11;
            // 
            // UCClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.ucPaging);
            this.Controls.Add(this.bntExport);
            this.Controls.Add(this.txtAverageNumberOfDaysForAllUsers);
            this.Controls.Add(this.txtNumberOfUsers);
            this.Controls.Add(this.txtMostRecentUserRate);
            this.Controls.Add(this.txtAllUserUtilization);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgSearchingInfo);
            this.Name = "UCClients";
            this.Size = new System.Drawing.Size(975, 513);
            this.Load += new System.EventHandler(this.UCSearchingInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSearchingInfo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.DataGridView dtgSearchingInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboDisplayCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAllUserUtilization;
        private System.Windows.Forms.TextBox txtMostRecentUserRate;
        private System.Windows.Forms.TextBox txtNumberOfUsers;
        private System.Windows.Forms.TextBox txtAverageNumberOfDaysForAllUsers;
        private System.Windows.Forms.Button bntExport;
        private UCPaging ucPaging;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSnsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSnsType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRegDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTemperatureDate5Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTemperatureDate4Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTemperatureDate3Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTemperatureDate2Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTemperatureDate1Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRateMonth5Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRateMonth4Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRateMonth3Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRateMonth2Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRateMonth1Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRateSixMonthsAgo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRateStarted;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label label8;
    }
}
