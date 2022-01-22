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
    public partial class AddAgent : Form
    {
        public AddAgent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (is_dataValid(txt_Nume.Text, txt_Prenume.Text, txt_Salariu.Text, numVarsta.Value, numStaj.Value, txtProcentaj.Text))
            {
                Classes.DatabaseCon.insertAgent(txt_Nume.Text, txt_Prenume.Text, txt_Salariu.Text, numVarsta.Text, numStaj.Text, txtProcentaj.Text);
                MessageBox.Show("Datele au fost inserate", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
        }

        private bool is_dataValid(string Nume, string Prenume, string Salariu, decimal Varsta, decimal Staj, string Procentaj)
        {

            if (String.IsNullOrEmpty(Nume) || String.IsNullOrEmpty(Prenume) || String.IsNullOrEmpty(Procentaj))
            {
                MessageBox.Show("Complete all data", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (String.IsNullOrEmpty(Salariu) || String.IsNullOrEmpty(Varsta.ToString()) || String.IsNullOrEmpty(Staj.ToString()))
            {
                MessageBox.Show("Complete all data", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Nume.Length > 10 || Prenume.Length > 10 || Varsta < 16 || Staj < 0 || Salariu.Length > 6)
            {
                MessageBox.Show("Invalid data", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Varsta >= 110 || Staj >= 40 || Procentaj.Length > 5)
            {
                MessageBox.Show("Invalid data", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Procentaj.Contains(","))
            {
                MessageBox.Show("Use dot instead of comma", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void txt_Salariu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar);
        }

        private void txtProcentaj_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar);
        }
    }
}
