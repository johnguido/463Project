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
 * LoginScreen.cs
 * John Guido
 * Allows users to login to the system or create a new user
 * April 24th, 2024
 */

namespace MediaPrintService
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();

            //Initally hide the account creation screen as it sits in front of the login screen on load

            accountCreation.Hide();

            //center to the users screen
            this.CenterToScreen();
        }

        private void onLogin(object sender, EventArgs e)
        {
            //This is called when the user clicks the "Login" button
            //We call the Database.getUser method expecting a User returned or null
            //If user does not equal null we presenting the main application
            //Other we notify the user on an invalid user or pass

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
            //This is called when the user selects the "New User?" button

            accountCreation.Show();
        }
    }
}
