
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
    public partial class Produse : Form
    {
        public Produse()
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

        private void Produse_Load(object sender, EventArgs e)
        {

        }

        private void btn_Oferte_Click(object sender, EventArgs e)
        {
            openChildForm(new Produse_Folder.Oferte());
        }

        private void btn_infoProduse_Click(object sender, EventArgs e)
        {
            openChildForm(new Produse_Folder.infoProdus());
        }

        private void btn_produseTop_Click(object sender, EventArgs e)
        {
            openChildForm(new Produse_Folder.produseTop());
        }

        private void btn_avgPret_Click(object sender, EventArgs e)
        {
            openChildForm(new Produse_Folder.avgPret());
        }
    }
}
