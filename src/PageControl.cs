using AxataPOS.App.Helper;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AxataPOS.LogReader
{
    public partial class PageControl : UserControl
    {
        public event EventHandler<int> PageChanged;
        public event EventHandler TooltipOnCurrentPage;
        public event EventHandler TooltipOnTotalPages;

        public bool ActivateTooltipOnTextBox { get; set; } = false;

        private int currentPage = 1;
        private int totalPages = 1;
        private int prevPage = 1;

        public PageControl()
        {
            InitializeComponent();
        }

        public PageControl(int currentPage, int totalPages) : this()
        {
            TotalPages = totalPages;
            CurrentPage = currentPage;
        }

        public int CurrentPage
        {
            get { return currentPage; }
            set
            {
                currentPage = value;
                UpdateUI();
            }
        }

        public int TotalPages
        {
            get { return totalPages; }
            set
            {
                totalPages = value;
                UpdateUI();
            }
        }

        private void UpdateUI()
        {
            txtCurrentPage.Text = $"{currentPage}";
            txtTotalPage.Text = TotalPages.ToString();
            btnPreviousPage.Enabled = (currentPage > 1);
            btnFirstPage.Enabled = btnPreviousPage.Enabled;
            btnNextPage.Enabled = (currentPage < totalPages);
            btnLastPage.Enabled = btnNextPage.Enabled;
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                UpdateUI();
                PageChanged?.Invoke(this, currentPage);
            }
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                UpdateUI();
                PageChanged?.Invoke(this, currentPage);
            }
        }

        private void txtCurrentPage_Enter(object sender, EventArgs e)
        {
            prevPage = currentPage;
        }

        private void txtCurrentPage_KeyDown(object sender, KeyEventArgs e)
        {
            e.OnEnterPerform(() =>
            {
                if (int.TryParse(txtCurrentPage.Text, out int page))
                {
                    if (page > 0 && page <= TotalPages)
                    {
                        CurrentPage = page;
                        PageChanged?.Invoke(this, CurrentPage);
                        prevPage = page;
                        return;
                    }
                }
                txtCurrentPage.Text = prevPage.ToString();
            });
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            CurrentPage = 1;
            PageChanged?.Invoke(this, CurrentPage);
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            CurrentPage = TotalPages;
            PageChanged?.Invoke(this, CurrentPage);
        }

        private void txtCurrentPage_MouseHover(object sender, EventArgs e)
        {
            ShowToolTipOnText(txtCurrentPage, TooltipOnCurrentPage, $"Current Page: {CurrentPage}");
        }

        private void txtTotalPage_MouseHover(object sender, EventArgs e)
        {
            ShowToolTipOnText(txtTotalPage, TooltipOnTotalPages, $"Total Pages: {TotalPages}");
        }

        private void txtCurrentPage_MouseEnter(object sender, EventArgs e)
        {
            ShowToolTipOnText(txtCurrentPage, TooltipOnCurrentPage, $"Current Page: {CurrentPage}");
        }

        private void txtTotalPage_MouseEnter(object sender, EventArgs e)
        {
            ShowToolTipOnText(txtTotalPage, TooltipOnTotalPages, $"Total Pages: {TotalPages}");
        }

        private void ShowToolTipOnText(KryptonTextBox textBox, EventHandler handler, string caption)
        {
            if (ActivateTooltipOnTextBox is false) return;

            if (handler != null)
            {
                handler?.Invoke(this, new EventArgs());
            }
            else
            {
                toolTip.Show(caption, textBox);
            }
        }

        private void txtCurrentPage_Leave(object sender, EventArgs e)
        {
            var ev = new KeyEventArgs(Keys.Enter);
            txtCurrentPage_KeyDown(sender, ev);
        }
    }
}
