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
            float subTotal = 0;
            float taxes = 0;

            foreach (Print print in Prints)
            {
                subTotal += float.Parse(print.price.Substring(1), CultureInfo.InvariantCulture.NumberFormat);
                taxes += (float.Parse(print.price.Substring(1), CultureInfo.InvariantCulture.NumberFormat) * 0.06f);
            }

            label14.Text = "$" + Math.Round(subTotal, 2).ToString();
            label15.Text = "$" + Math.Round(taxes, 2).ToString();

            double total = Math.Round(taxes, 2) + Math.Round(subTotal, 2);

            label18.Text = "$" + Math.Round(total, 2).ToString();
        }

        private void onPlaceOrder(object sender, EventArgs e)
        {
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
        }

        private bool CheckAddressFilled()
        {
            if (textBox1.Text.Length == 0 || textBox3.Text.Length == 0 || textBox4.Text.Length == 0 || textBox5.Text.Length == 0)
            {
                return false;
            }

            if (textBox1.Text == "Street Address / P.O. Box") return false;
            if (textBox2.Text == "Apt #, Unit, Building, etc.") return false;

            return true;
        }

        private bool CheckPaymentFilled()
        {
            if (textBox6.Text.Length == 0 || textBox7.Text.Length == 0 || textBox8.Text.Length == 0 || textBox9.Text.Length == 0 || textBox10.Text.Length == 0)
            {
                return false;
            }

            return true;
        }
    }
}
