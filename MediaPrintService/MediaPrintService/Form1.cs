using System.Diagnostics;

/*
 * Form1.cs
 * John Guido
 * Allows users to see the available features within the program
 * April 24th, 2024
 */

namespace MediaPrintService
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //center to the users screen
            this.CenterToScreen();

            //Start off by hiding all tabs 
            HideAllTabs();
        }

        private void onSummaryTabClick(object sender, EventArgs e)
        {
            //There is no summary to show at the moment so we ust ignore this call

            //HideAllTabs();
            //summaryTab.Show();
        }

        private void onCreatePrintClick(object sender, EventArgs e)
        {
            //We hide all other tabs, make sure the clear the Create Print screen, then show it

            HideAllTabs();

            createPrintTab.Clear();
            createPrintTab.Show();
        }

        private void onAccountClick(object sender, EventArgs e)
        {
            //We hide all other tabs, and show the account tab

            HideAllTabs();

            accountTab.Show();
        }

        private void onCartClick(object sender, EventArgs e)
        {
            //We hide all other tabs, show the checkout button, and the cart tab itself

            HideAllTabs();

            checkoutButton.Show();
            cartTab.Show();
        }

        private void HideAllTabs()
        {
            //Easily hides all tabs

            //summaryTab.Hide();
            createPrintTab.Hide();
            accountTab.Hide();
            cartTab.Hide();
            checkoutTab.Hide();
            checkoutButton.Hide();
        }

        private void onCheckoutButtonClick(object sender, EventArgs e)
        {
            //This hides the cart tab and checkout button
            //This will also send the created prints to the checkTab for total price calculation purposes

            cartTab.Hide();
            checkoutButton.Hide();

            List<Print> prints = new List<Print>();
            prints.AddRange(CartTab.Prints);

            checkoutTab.SetOrderSummary(prints);
            checkoutTab.Show();
        }
    }
}
