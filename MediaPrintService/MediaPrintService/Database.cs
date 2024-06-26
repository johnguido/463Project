﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Database.cs
 * John Guido
 * Allows system to easily talk to Database and statically provides methods for other classes to easily call
 * April 24th, 2024
 */

namespace MediaPrintService
{
    internal class Database
    {
        //All class variables are just information pertaining to the systems database

        private static MySqlConnection? connection = null;

        private static string server = "sql5.freesqldatabase.com";
        private static string username = "sql5683620";
        private static string password = "1vzCes11eT";
        private static string databaseName = "sql5683620";

        public static User? getUser(string email, string pass)
        {
            //LoginScreen.cs calls this when trying to login a user
            //Returns a new user if we were able to find one in the database with the given email / pass
            //Returns null otherwise

            try
            {
                connection = new MySqlConnection();
                connection.ConnectionString = "server=" + server + ";uid=" + username + ";pwd=" + password + ";database=" + databaseName;
                connection.Open();

                string query = "SELECT * FROM User WHERE Email = '" + email + "' AND Password = '" + pass + "';";

                MySqlCommand cmd = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return new User(reader["Email"].ToString(), reader["PaymentCardID"].ToString(), reader["FirstName"].ToString(), reader["Minit"].ToString(), reader["LastName"].ToString(), reader["Password"].ToString(), reader["Pin"].ToString(), reader["StreetOne"].ToString(), reader["StreetTwo"].ToString(), reader["City"].ToString(), reader["State"].ToString(), reader["Zipcode"].ToString());
                    }
                }
            }
            catch (MySqlException ex)
            {
                //QUERY FAILED
            }

            return null;
        }

        public static bool createUser(string email, string name, string user, string pass, string pin)
        {
            //AccountCreation.cs calls this method
            //We return true if we were able to successfully create the account with the given information
            //Return false otherwise

            List<string> namePart = name.Split(' ').ToList();

            try
            {
                connection = new MySqlConnection();
                connection.ConnectionString = "server=" + server + ";uid=" + username + ";pwd=" + password + ";database=" + databaseName;
                connection.Open();

                string query;

                if (namePart.Count == 2) {
                    //just first last
                    query = "INSERT INTO User (Email, PaymentCardID, FirstName, Minit, LastName, Password, Pin, StreetOne, StreetTwo, City, State, Zipcode) VALUES ('" + email + "', NULL, '" + namePart[0] + "', NULL, '" + namePart[1] + "', '" + pass + "', '" + pin + "', NULL, NULL, NULL, NULL, NULL)"; 

                }
                else
                {
                    //first middle last
                    query = "INSERT INTO User (Email, PaymentCardID, FirstName, Minit, LastName, Password, Pin, StreetOne, StreetTwo, City, State, Zipcode) VALUES ('" + email + "', NULL, '" + namePart[0] + "', '" + namePart[1] + "', '" + namePart[2] + "', '" + pass + "', '" + pin + "', NULL, NULL, NULL, NULL, NULL)";
                }

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                return false;
            }

            return true;
        }

    }

}
