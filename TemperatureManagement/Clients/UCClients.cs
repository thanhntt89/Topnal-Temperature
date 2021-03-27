using System;
using System.Drawing;
using System.Windows.Forms;
using TemperatureApiClient;
using TemperatureManagement.Utilities;
using static TemperatureModels.ClientExport;
using static TemperatureModels.ClientList;

namespace TemperatureManagement.Clients
{
    public partial class UCClients : UserControl
    {
        private int CurrentPageIndex = 1;
        private string desPath = string.Empty;
        private int totalPage = 0;
        private bool isMaximize = false;

        public UCClients()
        {
            InitializeComponent();
        }

        private void UCSearchingInfo_Load(object sender, EventArgs e)
        {
            cboDisplayCount.SelectedIndex = 0;
            ucPaging.PageChangedSize += ResizePagin;
            ucPaging.PageClick += PageClicked;

            CreateHeader();
            LoadStatus();
        }

        private void LoadStatus()
        {
            StatusCollection statusCollection = new StatusCollection();
            cboStatus.DataSource = statusCollection.statuses;
            cboStatus.ValueMember = "Id";
            cboStatus.DisplayMember = "StatusText";
        }

        private void PageClicked(int pageIndex)
        {
            CurrentPageIndex = pageIndex;
            SearchData(CurrentPageIndex);
        }

        private void ResizePagin()
        {
            ucPaging.Location = new Point(this.Width - ucPaging.Size.Width - 5, ucPaging.Location.Y);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            CreateHeader();
            SearchData(1);
        }

        private void SearchData(int currentIndex)
        {
            try
            {
                ClientListRequest request = new ClientListRequest()
                {
                    Status = cboStatus.SelectedValue == null ? string.Empty : cboStatus.SelectedValue.ToString(),
                    Date = dtDate.Value.ToString("yyyyMMdd"),
                    Limit = int.Parse(cboDisplayCount.Text),
                    CurrentPage = currentIndex
                };

                ClientListResponse response = TemperatureSystem.iTemperatureClient.GetClients(request);

                if (response.Status.Equals(Constants.ResponseStatusSuccess))
                {
                    txtAllUserUtilization.Text = response.RateAllUser.ToString();
                    txtAverageNumberOfDaysForAllUsers.Text = response.AverageUsingDay.ToString();
                    txtMostRecentUserRate.Text = response.RateRecentUser.ToString();
                    txtNumberOfUsers.Text = response.TotalUsers.ToString();
                    totalPage = response.TotalPage;
                    CurrentPageIndex = response.CurrentPage;
                    ucPaging.CreatePaging(totalPage, 10, 0, CurrentPageIndex);
                    dtgSearchingInfo.DataSource = response.Clients;
                }
                else if (response.Status.Equals(Constants.ResponseStatusFails))
                {
                    MessageBox.Show(response.ErrorInfo.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error:{0}", ex.Message));
            }
        }

        private void CreateHeader()
        {
            for (int index = 1; index <= 5; index++)
            {
                foreach (DataGridViewColumn header in dtgSearchingInfo.Columns)
                {
                    // Header date
                    if (header.Name.Equals(string.Format("colTemperatureDate{0}Value", index)))
                    {
                        header.HeaderText = string.Format("温度\n{0}", dtDate.Value.AddDays(1 - index).ToString("MM/dd"));
                    }

                    // Header month
                    if (header.Name.Equals(string.Format("colRateMonth{0}Value", index)))
                    {
                        header.HeaderText = string.Format("利用率\n{0}", dtDate.Value.AddMonths(1 - index).ToString("yyyy/MM"));
                    }
                }
            }
        }

        private void dtgSearchingInfo_SizeChanged(object sender, EventArgs e)
        {
            try
            {
                if (!isMaximize)
                {
                    colRateStarted.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    colRateSixMonthsAgo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    colRateStarted.Width = 200;
                    colRateSixMonthsAgo.Width = 200;

                    isMaximize = false;
                }
                else
                {
                    colRateStarted.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    colRateSixMonthsAgo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    colRateStarted.Width = 100;
                    colRateSixMonthsAgo.Width = 100;
                }
            }
            catch
            {

            }
        }

        private void bntDownLoad_Click(object sender, EventArgs e)
        {
            ExportCSV();
        }

        private void ExportCSV()
        {
            try
            {
                ClientExportRequest request = new ClientExportRequest()
                {
                    Date = dtDate.Value.ToString("yyyyMMdd"),
                    Status = cboStatus.SelectedValue == null ? string.Empty : cboStatus.SelectedValue.ToString()
                };

                ClientExportResponse response = TemperatureSystem.iTemperatureClient.GetClientExport(request);

                if (response.Status.Equals(Constants.ResponseStatusSuccess))
                {
                    FolderBrowserDialog folder = new FolderBrowserDialog();
                    var rst = folder.ShowDialog();
                    if (rst != DialogResult.OK)
                        return;

                    string filePath = string.Format("{0}//report_{1}.csv", folder.SelectedPath, dtDate.Value.ToString("yyyyMMdd"));
                    ExportUtils.ToCSV(response, DataGridViewUtils.GetHeaderList(dtgSearchingInfo), filePath);

                    MessageBox.Show("File export successful!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
