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
    public partial class Export : Form
    {
        public Export()
        {
            InitializeComponent();
        }

        private void Export_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'companieDataSet.Agenti' table. You can move, or remove it, as needed.
            this.agentiTableAdapter.Fill(this.companieDataSet.Agenti);

            this.reportViewer1.RefreshReport();
        }
    }
}
