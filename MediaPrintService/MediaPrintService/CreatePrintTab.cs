using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MediaPrintService
{
    public partial class CreatePrintTab : UserControl
    {
        public CreatePrintTab()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            List<string> list = new List<string>() { "1 x 2", "2 x 4", "3 x 6" };
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(list.ToArray());
            comboBox2.SelectedIndex = 0;

            panel2.AutoScroll = false;
            panel2.HorizontalScroll.Enabled = false;
            panel2.HorizontalScroll.Visible = false;
            panel2.HorizontalScroll.Maximum = 0;
            panel2.AutoScroll = true;
        }

        List<Print> prints = new List<Print>();

        private int totalPrints = 0;

        private string imageLocation;

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);

            if (Visible)
            {
                Clear();
            }
        }

        public void Clear()
        {
            panel2.Controls.Clear();
            totalPrints = 0;
            prints.Clear();
            label1.Text = "No Image Selected";
            imageLocation = null;

            Label label = new Label();
            label.Name = "label5";
            label.Text = "Prints";
            label.Parent = panel2;
            label.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            label.ForeColor = Color.Black;
            label.Location = new Point(122, 4);
            label.Size = new Size(74, 30);
        }

        private void onMediaTypeSelected(object sender, EventArgs e)
        {
            int mediaType = comboBox1.SelectedIndex;
            List<string> list;

            switch (mediaType)
            {
                case 0:
                    list = new List<string>() { "1 x 2", "2 x 4", "3 x 6" };
                    comboBox2.Items.Clear();
                    comboBox2.Items.AddRange(list.ToArray());
                    comboBox2.SelectedIndex = 0;
                    break;
                case 1:
                    list = new List<string>() { "1 x 1", "2 x 2", "3 x 3" };
                    comboBox2.Items.Clear();
                    comboBox2.Items.AddRange(list.ToArray());
                    comboBox2.SelectedIndex = 0;
                    break;
                case 2:
                    list = new List<string>() { "3 x 8", "10 x 12", "24 x 24" };
                    comboBox2.Items.Clear();
                    comboBox2.Items.AddRange(list.ToArray());
                    comboBox2.SelectedIndex = 0;
                    break;
                default:
                    break;
            }
        }

        private void onCreatePrint(object sender, EventArgs e)
        {
            if (totalPrints == 4)
            {
                MessageBox.Show("Only allowed to add four prints at one time");
                return;
            }

            int mediaType = comboBox1.SelectedIndex;

            switch (mediaType)
            {
                case 0:
                    createMugPrint();
                    break;
                case 1:
                    createPinPrint();
                    break;
                case 2:
                    createShirtPrint();
                    break;
                default:
                    break;
            }
        }

        private void createMugPrint()
        {
            totalPrints++;

            Panel panel = new Panel();
            panel.Parent = panel2;
            panel.Size = new Size(290, 62);
            panel.BackColor = Color.Cornsilk;
            panel.Location = new Point(12, 41 + ((totalPrints - 1) * 68));

            Label mediaType = new Label();
            mediaType.Parent = panel;
            mediaType.Text = "Type: Mug";
            mediaType.ForeColor = Color.Black;
            mediaType.Location = new Point(13, 9);
            int width = mediaType.Size.Width;
            mediaType.Size = new Size(width, 15);

            Label size = new Label();
            size.Parent = panel;
            size.Text = "Size: ";
            size.ForeColor = Color.Black;
            size.Location = new Point(13, 24);
            width = size.Size.Width;
            size.Size = new Size(width, 15);

            Label price = new Label();
            price.Parent = panel;
            price.Text = "Price: ";
            price.ForeColor = Color.Black;
            price.Location = new Point(13, 39);
            width = price.Size.Width;
            price.Size = new Size(width, 15);

            PictureBox pictureBox = new PictureBox();
            pictureBox.Location = new Point(226, 3);
            pictureBox.Parent = panel;
            pictureBox.Size = new Size(59, 56);
            Image image = Image.FromFile(imageLocation);
            pictureBox.Image = image;

            /*
            if (imageLocation != null)
            {
                image = Image.FromFile(imageLocation);
                pictureBox.Image = image;
            }
            else
            {
                pictureBox.BackColor = Color.DarkSlateBlue;

                Label holderText = new Label();
                holderText.Parent = pictureBox;
                holderText.Text = "NO IMAGE";
                holderText.BackColor = Color.DarkSlateBlue;
                holderText.AutoSize = false;
                holderText.TextAlign = ContentAlignment.MiddleCenter;
                holderText.Dock = DockStyle.Fill;
                holderText.Size = new Size(52, 15);
                holderText.ForeColor = Color.Black;
            }
            */

            DetermineMugPriceAndSize(price, size, image);
        }

        private void DetermineMugPriceAndSize(Label price, Label size, Image image)
        {
            int realIndex = comboBox2.SelectedIndex;

            switch (realIndex)
            {
                case 0:
                    price.Text += "$1.99";
                    size.Text += "1 x 2";
                    prints.Add(new Print("1 x 2", "$1.99", "Mug", image));
                    break;
                case 1:
                    price.Text += "$2.99";
                    size.Text += "2 x 4";
                    prints.Add(new Print("2 x 4", "$2.99", "Mug", image));
                    break;
                case 2:
                    price.Text += "$3.99";
                    size.Text += "3 x 6";
                    prints.Add(new Print("3 x 6", "$3.99", "Mug", image));
                    break;
                default:
                    break;
            }
        }

        private void createPinPrint()
        {
            totalPrints++;

            Panel panel = new Panel();
            panel.Parent = panel2;
            panel.Size = new Size(290, 62);
            panel.BackColor = Color.Cornsilk;
            panel.Location = new Point(12, 41 + ((totalPrints - 1) * 68));

            Label mediaType = new Label();
            mediaType.Parent = panel;
            mediaType.Text = "Type: Pin";
            mediaType.ForeColor = Color.Black;
            mediaType.Location = new Point(13, 9);
            int width = mediaType.Size.Width;
            mediaType.Size = new Size(width, 15);

            Label size = new Label();
            size.Parent = panel;
            size.Text = "Size: ";
            size.ForeColor = Color.Black;
            size.Location = new Point(13, 24);
            width = size.Size.Width;
            size.Size = new Size(width, 15);

            Label price = new Label();
            price.Parent = panel;
            price.Text = "Price: ";
            price.ForeColor = Color.Black;
            price.Location = new Point(13, 39);
            width = price.Size.Width;
            price.Size = new Size(width, 15);

            PictureBox pictureBox = new PictureBox();
            pictureBox.Location = new Point(228, 3);
            pictureBox.Parent = panel;
            pictureBox.Size = new Size(59, 56);
            Image image = Image.FromFile(imageLocation);
            pictureBox.Image = image;

            /*
            if (imageLocation != null)
            {
                Image image = Image.FromFile(imageLocation);
                pictureBox.Image = image;
            }
            else
            {
                pictureBox.BackColor = Color.DarkSlateBlue;

                Label holderText = new Label();
                holderText.Parent = pictureBox;
                holderText.Text = "NO IMAGE";
                holderText.BackColor = Color.DarkSlateBlue;
                holderText.AutoSize = false;
                holderText.TextAlign = ContentAlignment.MiddleCenter;
                holderText.Dock = DockStyle.Fill;
                holderText.Size = new Size(52, 15);
                holderText.ForeColor = Color.Black;
            }
            */

            DeterminePinPriceAndSize(price, size, image);
        }

        private void DeterminePinPriceAndSize(Label price, Label size, Image image)
        {
            int realIndex = comboBox2.SelectedIndex;

            switch (realIndex)
            {
                case 0:
                    price.Text += "$4.99";
                    size.Text += "1 x 1";
                    prints.Add(new Print("1 x 1", "$4.99", "Pin", image));
                    break;
                case 1:
                    price.Text += "$5.99";
                    size.Text += "2 x 2";
                    prints.Add(new Print("2 x 2", "$5.99", "Pin", image));
                    break;
                case 2:
                    price.Text += "$6.99";
                    size.Text += "3 x 3";
                    prints.Add(new Print("3 x 3", "$6.99", "Pin", image));
                    break;
                default:
                    break;
            }
        }

        private void createShirtPrint()
        {
            totalPrints++;

            Panel panel = new Panel();
            panel.Parent = panel2;
            panel.Size = new Size(290, 62);
            panel.BackColor = Color.Cornsilk;
            panel.Location = new Point(12, 41 + ((totalPrints - 1) * 68));

            Label mediaType = new Label();
            mediaType.Parent = panel;
            mediaType.Text = "Type: Shirt";
            mediaType.ForeColor = Color.Black;
            mediaType.Location = new Point(13, 9);
            int width = mediaType.Size.Width;
            mediaType.Size = new Size(width, 15);

            Label size = new Label();
            size.Parent = panel;
            size.Text = "Size: ";
            size.ForeColor = Color.Black;
            size.Location = new Point(13, 24);
            width = size.Size.Width;
            size.Size = new Size(width, 15);

            Label price = new Label();
            price.Parent = panel;
            price.Text = "Price: ";
            price.ForeColor = Color.Black;
            price.Location = new Point(13, 39);
            width = price.Size.Width;
            price.Size = new Size(width, 15);

            PictureBox pictureBox = new PictureBox();
            pictureBox.Location = new Point(228, 3);
            pictureBox.Parent = panel;
            pictureBox.Size = new Size(59, 56);
            Image image = Image.FromFile(imageLocation);
            pictureBox.Image = image;

            /*
            if (imageLocation != null)
            {
                Image image = Image.FromFile(imageLocation);
                pictureBox.Image = image;
            }
            else
            {
                pictureBox.BackColor = Color.DarkSlateBlue;

                Label holderText = new Label();
                holderText.Parent = pictureBox;
                holderText.Text = "NO IMAGE";
                holderText.BackColor = Color.DarkSlateBlue;
                holderText.AutoSize = false;
                holderText.TextAlign = ContentAlignment.MiddleCenter;
                holderText.Dock = DockStyle.Fill;
                holderText.Size = new Size(52, 15);
                holderText.ForeColor = Color.Black;
            }
            */

            DetermineShirtPriceAndSize(price, size, image);
        }

        private void DetermineShirtPriceAndSize(Label price, Label size, Image image)
        {
            int sizeIndex = comboBox2.SelectedIndex;

            switch (sizeIndex)
            {
                case 0:
                    price.Text += "$12.99";
                    size.Text += "3 x 8";
                    prints.Add(new Print("3 x 8", "$12.99", "Shirt", image));
                    break;
                case 1:
                    price.Text += "$17.99";
                    size.Text += "10 x 12";
                    prints.Add(new Print("10 x 12", "$17.99", "Shirt", image));
                    break;
                case 2:
                    price.Text += "$25.99";
                    size.Text += "24 x 24";
                    prints.Add(new Print("24 x 24", "$25.99", "Shirt", image));
                    break;
                default:
                    break;
            }
        }

        private void onAddPrintsToCart(object sender, EventArgs e)
        {
            CartTab.LoadCart = true;
            CartTab.Prints.AddRange(prints);
            Clear();
        }

        private void onClearPrints(object sender, EventArgs e)
        {
            Clear();
        }

        private void onUploadImage(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Select Image";
            fileDialog.InitialDirectory = "C:\\Windows\\Images";
            fileDialog.ShowDialog();

            imageLocation = fileDialog.FileName;
            label1.Text = "Image selected";
        }
    }

    public class Print
    {
        public string price;
        public string size;
        public string mediaType;
        public Image image;

        public Print(string size, string price, string mediaType, Image image)
        {
            this.price = price;
            this.size = size;
            this.mediaType = mediaType;
            this.image = image;
        }
    }
}
