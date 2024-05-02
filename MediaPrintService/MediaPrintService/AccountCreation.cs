using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * AccountCreation.cs
 * John Guido
 * Allows users to create a new account
 * April 24th, 2024
 */

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
            //Hides the account creation screen when users click the "Already have an account? *login*" button

            this.Hide();
        }

        private void onSignup(object sender, EventArgs e)
        {
            //Sends all new user info to the Database class
            //Takes return value from the Database.createUser method as true or false
            //If true we notify user of successful account creation and hide the account creation screen which will show the member login screen
            //If false we notify the user account creation failed

            if (Database.createUser(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text))
            {
                MessageBox.Show("Account creation successful");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Account creation failed");
            }
        }
    }
}
