using System;
using System.Windows.Forms;

namespace AxataPOS.LogReader
{
    public partial class PageControl : UserControl
    {
        public event EventHandler<int> PageChanged;

        private int currentPage = 1;
        private int totalPages = 1;

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
            btnNextPage.Enabled = (currentPage < totalPages);
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

        private void txtCurrentPage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
