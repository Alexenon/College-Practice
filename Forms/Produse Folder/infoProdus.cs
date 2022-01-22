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

namespace Practica.Forms.Produse_Folder
{
    public partial class infoProdus : Form
    {
        public infoProdus()
        {
            InitializeComponent();
        }

        private void btn_infoAgent_Click(object sender, EventArgs e)
        {
            string Id_Agent = textBox1.Text;

            updateDataGridView("SELECT A.Id_Agent, P.Denumire, P.Pret, A.Nume, A.Prenume, A.Procent," 
                +  " AP.PretTotal AS 'PretTotal', AP.inStoc" 
                + " FROM Agenti_Produse AP " 
                + " INNER JOIN Produse P ON P.Id_Produs = AP.Id_Produs"
                + " INNER JOIN Agenti A ON A.Id_Agent = AP.Id_Agent"
                + $" WHERE A.Id_Agent = {Id_Agent}"
                + " ORDER BY P.Denumire, AP.PretTotal");
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
