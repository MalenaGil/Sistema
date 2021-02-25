using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace presupvisual
{
    public partial class FImprime : Form
    {
        public FImprime()
        {
            InitializeComponent();
        }

        private void FImprime_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetClientes.clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.DataSetClientes.clientes);

            this.reportViewer1.RefreshReport();
        }
    }
}
