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

namespace Practica.Forms
{
    public partial class Pensionari : Form
    {
        public Pensionari()
        {
            InitializeComponent();
        }

        private void Pensionari_Load(object sender, EventArgs e)
        {

            updateDataGridView("SELECT Nume, Prenume, Varsta, Staj FROM Agenti WHERE Varsta > 57 ORDER BY Varsta");

        }

        private void updateDataGridView(string sqlStatement)
        {
            try
            {
                dataGridView1.AllowUserToAddRows = false;

                SqlConnection con = new SqlConnection(Classes.DatabaseCon.conString);
                con.Open();

                /* Add data to DataTable */
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlStatement, con);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;

                /* Resize dataGridView by columns and rows */
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

    }
}
