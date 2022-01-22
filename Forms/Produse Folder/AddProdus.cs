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
    public partial class AddProdus : Form
    {
        public AddProdus()
        {
            InitializeComponent();
        }

        private void txt_Pret_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (is_dataValid(numId.Value, txt_Denumire.Text, txt_Pret.Text) == true)
            {
                Classes.DatabaseCon.insertProdus(numId.Text, txt_Denumire.Text, txt_Pret.Text);
                MessageBox.Show("Datele au fost inserate", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }


        private bool is_dataValid(decimal Id, string Denumire, string Pret)
        {

            if (String.IsNullOrEmpty(Denumire) || String.IsNullOrEmpty(Id.ToString()) || String.IsNullOrEmpty(Pret))
            {
                MessageBox.Show("Complete all data", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Denumire.Length > 10 || Id <= 0 || Pret.Length > 3)
            {
                MessageBox.Show("Invalid data", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Pret.Contains(","))
            {
                MessageBox.Show("Use dot instead of comma", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

    }
}
