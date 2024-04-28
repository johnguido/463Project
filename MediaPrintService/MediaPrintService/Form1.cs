using System.Diagnostics;

namespace MediaPrintService
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            HideAllTabs();
            //summaryTab.Show();
        }

        private void onSummaryTabClick(object sender, EventArgs e)
        {
            HideAllTabs();

            //summaryTab.Show();
        }

        private void onCreatePrintClick(object sender, EventArgs e)
        {
            HideAllTabs();

            createPrintTab.Clear();
            createPrintTab.Show();
        }

        private void onAccountClick(object sender, EventArgs e)
        {
            HideAllTabs();

            accountTab.Show();
        }

        private void onCartClick(object sender, EventArgs e)
        {
            HideAllTabs();

            checkoutButton.Show();
            cartTab.Show();
        }

        private void HideAllTabs()
        {
            //summaryTab.Hide();
            createPrintTab.Hide();
            accountTab.Hide();
            cartTab.Hide();
            checkoutTab.Hide();
            checkoutButton.Hide();
        }

        private void onCheckoutButtonClick(object sender, EventArgs e)
        {
            cartTab.Hide();
            checkoutButton.Hide();

            List<Print> prints = new List<Print>();
            prints.AddRange(CartTab.Prints);

            checkoutTab.SetOrderSummary(prints);
            checkoutTab.Show();
        }
    }
}
