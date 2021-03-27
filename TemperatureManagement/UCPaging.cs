using System;
using System.Drawing;
using System.Windows.Forms;
using TemperatureApiClient.Utilities;

namespace TemperatureManagement
{
    public partial class UCPaging : UserControl
    {
        public delegate void PageClickedEvent(int pageIndex);
        public PageClickedEvent PageClick;
        public delegate void PageChangedSizeEvent();
        public PageChangedSizeEvent PageChangedSize;

        private const string ButtonPagingPreFix = "btn_Page";
        private int currentPageIndex = 0;
        private int maxDisplay = 5;
        private int totalPages = 100;
        private int pageTabIndex = 0;
        private int startPageIndex = 0;

        public UCPaging()
        {
            InitializeComponent();
        }

        public void CreatePaging(int totalPages, int maxDisplay, int startIndex = 0, int currentPage = 1)
        {
            if (totalPages == 0)
                return;

            this.maxDisplay = maxDisplay;
            this.totalPages = totalPages;
            //currentPageIndex = startIndex;
            panelMain.Controls.Clear();
            int pageIndex = 0;
            int tabIndex = btnPreviewous.TabIndex;
            maxDisplay = totalPages > maxDisplay ? maxDisplay : totalPages;

            int locationX = 3;
            int localtionY = 2;

            int btnW = 28;
            int btnH = 26;
            Button btn = null;

            while (pageIndex < maxDisplay)
            {
                pageIndex++;
                if (startIndex != 0)
                    startIndex++;
                else
                    startIndex = pageIndex;

                btn = new Button();
                btn.Name = string.Format("{0}{1}", ButtonPagingPreFix, startIndex);
                if (btn.Name.Equals(string.Format("{0}{1}", ButtonPagingPreFix, currentPage)))
                {
                    btn.Focus();
                    txtCurrentPage.Text = currentPage.ToString();
                }

                btn.Click += Page_Click;
                btn.Text = startIndex.ToString();
                btn.TabIndex = tabIndex++;

                if (startPageIndex + tabIndex > 99)
                    btn.Size = new Size(btnW + 5, btnH);
                else
                    btn.Size = new Size(btnW, btnH);

                if (pageIndex == 1)
                {
                    btn.Location = new Point(locationX, localtionY);
                    btn.Focus();
                }
                else
                {
                    btn.Location = new Point(btnW * (pageIndex - 1) + locationX, localtionY);
                }
                panelMain.Controls.Add(btn);
                if (startPageIndex + tabIndex >= totalPages)
                    break;
            }

            btnNext.TabIndex = tabIndex++;
            this.Width = btnW * (maxDisplay + 3) + txtCurrentPage.Width - btnW / 2 + btn.Width / 2;
            if (PageChangedSize != null)
                PageChangedSize();
        }

        private void Page_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                currentPageIndex = int.Parse(button.Text);

                if (PageClick != null)
                    PageClick(currentPageIndex);
                txtCurrentPage.Text = button.Text;
                // Get current tab index
                pageTabIndex = button.TabIndex;
                LoadNextPaging(currentPageIndex, maxDisplay, totalPages);
                FocusPageByIndex(currentPageIndex);
            }
        }

        private void btnPreviewous_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCurrentPage.Text) && Utils.IsNumeric(txtCurrentPage.Text))
                currentPageIndex = int.Parse(txtCurrentPage.Text);
            currentPageIndex--;
            if (currentPageIndex <= 0)
                currentPageIndex = 1;
            FocusPageByIndex(currentPageIndex);
            Button btn = GetButtonByIndex(currentPageIndex);
            if (btn != null)
                Page_Click(btn, null);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCurrentPage.Text) && Utils.IsNumeric(txtCurrentPage.Text))
                currentPageIndex = int.Parse(txtCurrentPage.Text);

            currentPageIndex++;
            if (currentPageIndex > totalPages)
                currentPageIndex = totalPages;

            FocusPageByIndex(currentPageIndex);
            Button btn = GetButtonByIndex(currentPageIndex);
            if (btn != null)
                Page_Click(btn, null);
        }

        private void FocusPageByIndex(int pageIndex)
        {
            Button btn = GetButtonByIndex(pageIndex);
            if (btn != null)
                btn.Focus();
        }

        private Button GetButtonByIndex(int pageIndex)
        {
            foreach (var ctl in panelMain.Controls)
            {
                Button btn = ctl as Button;
                if (btn != null)
                {
                    if (btn.Name.Equals(string.Format("{0}{1}", ButtonPagingPreFix, pageIndex)))
                    {
                        return btn;
                    }
                }
            }

            return null;
        }

        private void LoadNextPaging(int currentPageIndex, int maxDisplay, int totalPage)
        {
            int midTabIndex = maxDisplay - maxDisplay / 2;
            if (pageTabIndex <= midTabIndex && startPageIndex < 1)
            {
                return;
            }

            int startPage = currentPageIndex - maxDisplay / 2;
            startPage = startPage < 0 ? 0 : startPage;
            startPageIndex = startPage;
            CreatePaging(totalPage, maxDisplay, startPage);
            FocusPageByIndex(currentPageIndex);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                InputPageIndex();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void InputPageIndex()
        {
            if (!Utils.IsNumeric(txtCurrentPage.Text))
                return;
            currentPageIndex = int.Parse(txtCurrentPage.Text);
            if (currentPageIndex > totalPages)
            {
                MessageBox.Show("Current page larger than total page :" + totalPages, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCurrentPage.SelectAll();
                txtCurrentPage.Focus();
                return;
            }
            if (PageClick != null)
                PageClick(currentPageIndex);

            FocusPageByIndex(currentPageIndex);
        }

        private void txtCurrentPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }
    }
}
