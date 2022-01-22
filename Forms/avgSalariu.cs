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
    public partial class avgSalariu : Form
    {
        public avgSalariu()
        {
            InitializeComponent();
        }

        private void avgSalariu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'salariuMediuDataSet.SalariuMediu' table. You can move, or remove it, as needed.
            this.salariuMediuTableAdapter.Fill(this.salariuMediuDataSet.SalariuMediu);

            this.reportViewer1.RefreshReport();
        }
    }
}
