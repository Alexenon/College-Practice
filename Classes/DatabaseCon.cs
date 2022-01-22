using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica.Classes
{
    class DatabaseCon
    {

        public static string conString = "Data Source=BATAURS;Initial Catalog=Companie;Integrated Security=True";


        

        public static bool is_Email_Taken(string Email)
        {

            string queryString = "SELECT Email From Useri";

            using (SqlConnection connection = new SqlConnection(conString))
            {

                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var email = reader.GetString(0);

                    // If Email already exist return True
                    if (email == Email)
                        return true;
                }

            }
            return false;
        }

        public static bool is_Email_Password_Correct(string Email, string Password)
        {

            string queryString = "SELECT Email, Parola From Useri";

            using (SqlConnection connection = new SqlConnection(conString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    // Get first and second column
                    var email = reader.GetString(0);
                    var pass = reader.GetString(1);

                    // IF Login And Email are correct returns True
                    if (email == Email && pass == Password)
                        return true;
                }
            }
            return false;
        }

        public static string selectUser(string Email)
        {
            string queryString = $"SELECT Id_User FROM Useri WHERE Email = '{Email}'";

            using (SqlConnection connection = new SqlConnection(conString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    // Return Id_User in string format
                    return reader.GetInt32(0).ToString();
                }
            }
            return null;
        }

        public static void InsertUser(string Username, string Email, string Password)
        {
            try
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                if (con.State == System.Data.ConnectionState.Open)
                {
                    string querry = "INSERT INTO Useri VALUES ('" + Username + "', '" + Email + "', '" + Password + "')";
                    SqlCommand cmd = new SqlCommand(querry, con);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public static void insertAgent(string Nume, string Prenume, string Salariu, string Varsta, string Staj, string Procentaj) 
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                if (con.State == System.Data.ConnectionState.Open)
                {
                    string querry = $"INSERT INTO Agenti VALUES ('{Prenume}', '{Nume}', {Salariu}, {Varsta}, {Staj}, {Procentaj})";
                    SqlCommand cmd = new SqlCommand(querry, con);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void insertProdus(string Id_Produs, string Denumire, string Pret)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                if (con.State == System.Data.ConnectionState.Open)
                {
                    string querry = $"INSERT INTO Produse VALUES ({Id_Produs}, '{Denumire}', {Pret})";
                    SqlCommand cmd = new SqlCommand(querry, con);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static string getString(string Column, string Id)
        {
            string queryString = $"SELECT {Column} FROM Agenti WHERE Id_Agent = {Id}";

            using (SqlConnection connection = new SqlConnection(conString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (Column == "Nume" || Column == "Prenume")
                        return reader.GetString(0).ToString();
                    else if (Column == "Procent")
                        return reader.GetFloat(0).ToString();
                    else
                        return reader.GetInt32(0).ToString();

                }
            }
            return null;
        }

    }



    
}
