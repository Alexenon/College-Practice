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
    public partial class infoAgent : Form
    {
        public infoAgent()
        {
            InitializeComponent();
        }

        private void btn_infoAgent_Click(object sender, EventArgs e)
        {
            string Id = textBox1.Text;
            label_Id.Text = Id;
            label_Nume.Text = Classes.DatabaseCon.getString("Nume", Id);
            label_Prenume.Text = Classes.DatabaseCon.getString("Prenume", Id);
            label_Salariu.Text = Classes.DatabaseCon.getString("Salariu", Id);
            label_Varsta.Text = Classes.DatabaseCon.getString("Varsta", Id);
            label_Staj.Text = Classes.DatabaseCon.getString("Staj", Id);
            label_Procentaj.Text = "1,2";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
