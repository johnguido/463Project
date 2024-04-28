using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPrintService
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();

            accountCreation.Hide();
        }

        private void onLogin(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();

            string email = textBox1.Text;
            string pass = textBox2.Text;

            var user = Database.getUser(email, pass);

            if (user != null)
            {
                //Form1 mainForm = new Form1();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("INVALID USER OR PASS");
            }

        }

        private void onNewUser(object sender, EventArgs e)
        {
            accountCreation.Show();
        }
    }
}
