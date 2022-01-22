using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica.Forms
{
    public partial class AgentiForm : Form
    {
        public AgentiForm()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(childForm);
            panelContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_infoAgent_Click(object sender, EventArgs e)
        {
            openChildForm(new infoAgent());
        }

        private void btn_smallAgent_Click(object sender, EventArgs e)
        {
            openChildForm(new Agenti.smallAgent());
        }

        private void btn_Pensionari_Click(object sender, EventArgs e)
        {
            openChildForm(new Pensionari());
        }

        private void btn_avgSalariu_Click(object sender, EventArgs e)
        {
            openChildForm(new avgSalariu());
        }



        //private void updateDataGridView(string sqlStatement)
        //{
        //    try
        //    {
        //        dataGridView1.AllowUserToAddRows = false;

        //        SqlConnection con = new SqlConnection(Classes.DatabaseCon.conString);
        //        con.Open();

        //        /* Add data to DataTable */
        //        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlStatement, con);
        //        DataTable dataTable = new DataTable();
        //        sqlDataAdapter.Fill(dataTable);
        //        dataGridView1.DataSource = dataTable;

        //        /* Resize dataGridView by columns and rows */
        //        dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        //        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        //    }
        //    catch (Exception err)
        //    {
        //        MessageBox.Show(err.ToString());
        //    }
        //}
    }


}

