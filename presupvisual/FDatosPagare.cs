using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace presupvisual
{
    public partial class FDatosPagare : Form
    {
        public FDatosPagare()
        {
            InitializeComponent();
        }

        private void BotonSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fclientes1 ss = new presupvisual.Fclientes1();
            ss.Show();
        }

        private void BotonPagare_Click(object sender, EventArgs e)
        {
            this.Hide();
            FImprimePagareClientes ss1 = new presupvisual.FImprimePagareClientes();
            // ss1.Datos.Fecha.Text = Datos.Fecha.Text;
            ss1.Show();
        }
    }
}
