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
    public partial class AccountCreation : UserControl
    {
        public AccountCreation()
        {
            InitializeComponent();
        }

        private void onRelogin(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void onSignup(object sender, EventArgs e)
        {
            if (Database.createUser(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text))
            {
                MessageBox.Show("Account creation successful");
                this.Hide();
            }
        }
    }
}
