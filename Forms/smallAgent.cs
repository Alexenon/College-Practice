using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica.Forms.Agenti
{
    public partial class smallAgent : Form
    {
        public smallAgent()
        {
            InitializeComponent();
        }

        private void smallAgent_Load(object sender, EventArgs e)
        {
            string Id = getYoungestId();
            label_Id.Text = Id;
            label_Nume.Text = Classes.DatabaseCon.getString("Nume", Id);
            label_Prenume.Text = Classes.DatabaseCon.getString("Prenume", Id);
            label_Salariu.Text = Classes.DatabaseCon.getString("Salariu", Id);
            label_Varsta.Text = Classes.DatabaseCon.getString("Varsta", Id);
            label_Staj.Text = Classes.DatabaseCon.getString("Staj", Id);
            label_Procentaj.Text = "1,2";

        }

        public static string getYoungestId()
        {
            string queryString = "SELECT TOP 1 * FROM Agenti ORDER BY Varsta ASC";

            using (SqlConnection connection = new SqlConnection(Classes.DatabaseCon.conString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    return reader.GetInt32(0).ToString();
                }
            }
            return null;
        }
    }
}
