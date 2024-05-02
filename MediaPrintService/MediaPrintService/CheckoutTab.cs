using Org.BouncyCastle.Math;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * CheckoutTab.cs
 * John Guido
 * Allows users to view their total with shipping and to place an order after providing shipping/payment information
 * April 28th, 2024
 */

namespace MediaPrintService
{
    public partial class CheckoutTab : UserControl
    {
        public CheckoutTab()
        {
            InitializeComponent();
        }

        public void SetOrderSummary(List<Print> Prints)
        {
            //We loop through each print tallying the total price to display to user for checkout
            //We also add a flat rate shipping cost of $6.50 and display that as well

            float subTotal = 0;
            float taxes = 0;

            foreach (Print print in Prints)
            {
                subTotal += float.Parse(print.price.Substring(1), CultureInfo.InvariantCulture.NumberFormat);
                taxes += (float.Parse(print.price.Substring(1), CultureInfo.InvariantCulture.NumberFormat) * 0.06f);
            }

            /*
            label14.Text = "$" + Math.Round(subTotal, 2).ToString();
            label15.Text = "$" + Math.Round(taxes, 2).ToString();

            double total = Math.Round(taxes, 2) + Math.Round(subTotal, 2);

            label18.Text = "$" + Math.Round(total, 2).ToString();
            */

            double total = Math.Round(taxes, 2) + Math.Round(subTotal, 2);

            label14.Text = "$" + Math.Round(total, 2).ToString();
            label15.Text = "$6.50";

            double bigTotal = Math.Round(total, 2) + Math.Round(6.50, 2);
            label18.Text = "$" + Math.Round(bigTotal, 2).ToString();


        }

        private void onPlaceOrder(object sender, EventArgs e)
        {
            //Here we check if both shipping/payment information data is filled before placing an order
            //Eventually we would like to actually validate the address/payment information using some sort of third party software

            if (!CheckAddressFilled() && !CheckPaymentFilled())
            {
                MessageBox.Show("You need to fill in your shipping / payment information before placing an order");

                return;
            }

            if (!CheckAddressFilled())
            {
                MessageBox.Show("You need to fill in your shipping information before placing an order");

                return;
            }

            if (!CheckPaymentFilled())
            {
                MessageBox.Show("You need to fill in your payment information before placing an order");

                return;
            }

            //CREATE ORDER
            MessageBox.Show("Order Placed!");
        }

        private bool CheckAddressFilled()
        {
            //Just checks if address boxes are filled
            //Return false if not all filled (other than the unit# request box)
            //Return true otherwise

            if (textBox1.Text.Length == 0 || textBox3.Text.Length == 0 || textBox4.Text.Length == 0 || textBox5.Text.Length == 0)
            {
                return false;
            }

            if (textBox1.Text == "Street Address / P.O. Box") return false;

            return true;
        }

        private bool CheckPaymentFilled()
        {
            //Just checks if payment boxes are filled
            //Return false if not all filled
            //Return true otherwise

            if (textBox6.Text.Length == 0 || textBox7.Text.Length == 0 || textBox8.Text.Length == 0 || textBox9.Text.Length == 0 || textBox10.Text.Length == 0)
            {
                return false;
            }

            return true;
        }
    }
}
