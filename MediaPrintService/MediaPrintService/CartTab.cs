using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace MediaPrintService
{
    public partial class CartTab : UserControl
    {
        public CartTab()
        {
            InitializeComponent();

            panel2.AutoScroll = false;
            panel2.HorizontalScroll.Enabled = false;
            panel2.HorizontalScroll.Visible = false;
            panel2.HorizontalScroll.Maximum = 0;
            panel2.AutoScroll = true;
        }

        public static bool LoadCart = false;
        public static List<Print> Prints = new List<Print>();

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);

            if (Visible && LoadCart)
            {
               FillCart();
            }
        }

        public void FillCart()
        {
            int index = 0;
            float subTotal = 0;
            float taxes = 0;

            foreach(Print print in Prints)
            {
                subTotal += float.Parse(print.price.Substring(1), CultureInfo.InvariantCulture.NumberFormat);
                taxes += (float.Parse(print.price.Substring(1), CultureInfo.InvariantCulture.NumberFormat) * 0.06f);

                Panel panel = new Panel();
                panel.Parent = panel2;
                panel.Size = new Size(387, 62);
                panel.BackColor = Color.Cornsilk;
                panel.Location = new Point(12, 12 + ((index) * 68));

                Label mediaType = new Label();
                mediaType.Parent = panel;
                mediaType.Text = "Type: " + print.mediaType;
                mediaType.ForeColor = Color.Black;
                mediaType.Location = new Point(13, 9);
                int width = mediaType.Size.Width;
                mediaType.Size = new Size(width, 15);

                Label size = new Label();
                size.Parent = panel;
                size.Text = "Size: " + print.size;
                size.ForeColor = Color.Black;
                size.Location = new Point(13, 24);
                width = size.Size.Width;
                size.Size = new Size(width, 15);

                Label price = new Label();
                price.Parent = panel;
                price.Text = "Price: " + print.price;
                price.ForeColor = Color.Black;
                price.Location = new Point(13, 39);
                width = price.Size.Width;
                price.Size = new Size(width, 15);

                PictureBox pictureBox = new PictureBox();
                pictureBox.Location = new Point(325, 3);
                pictureBox.Parent = panel;
                pictureBox.BackColor = Color.DarkSlateBlue;
                pictureBox.Size = new Size(59, 56);
                pictureBox.Image = print.image;

                /*
                Label holderText = new Label();
                holderText.Parent = pictureBox;
                holderText.Text = "HOLDER";
                holderText.BackColor = Color.DarkSlateBlue;
                holderText.AutoSize = false;
                holderText.TextAlign = ContentAlignment.MiddleCenter;
                holderText.Dock = DockStyle.Fill;
                holderText.Size = new Size(52, 15);
                holderText.ForeColor = Color.Black;
                */

                index++;
            }

            LoadCart = false;

            label12.Text = "$" + Math.Round(subTotal, 2).ToString();
            label13.Text = "$" + Math.Round(taxes, 2).ToString();

            double total = Math.Round(taxes, 2) + Math.Round(subTotal, 2);

            label14.Text = "$" + Math.Round(total, 2).ToString();
        }
    }
}
