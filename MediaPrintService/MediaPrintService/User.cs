using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * User.cs
 * John Guido
 * Allows the creation of user objects for later use
 * April 24th, 2024
 */

namespace MediaPrintService
{
    internal class User
    {
        //All of the users data that can be pulled from the database

        private string email;
        private string paymentCardID;
        private string firstName;
        private string Minit;
        private string lastName;
        private string password;
        private string pin;
        private string streetOne;
        private string? streetTwo;
        private string city;
        private string state;
        private string zip;

        public User(string email, string paymentCardID, string firstName, string minit, string lastName, string password, string pin, string streetOne, string? streetTwo, string city, string state, string zip)
        {
            //This is called within the Database class on pull from database

            this.email = email;
            this.paymentCardID = paymentCardID;
            this.firstName = firstName;
            Minit = minit;
            this.lastName = lastName;
            this.password = password;
            this.pin = pin;
            this.streetOne = streetOne;
            this.streetTwo = streetTwo;
            this.city = city;
            this.state = state;
            this.zip = zip;
        }
    }
}
