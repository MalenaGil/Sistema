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
    public partial class FImprimirPagare : Form
    {
        public FImprimirPagare()
        {
            InitializeComponent();
        }

        private void FImprimirPagare_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetClientes.clientes' Puede moverla o quitarla según sea necesario.
          //  this.clientesTableAdapter.Fill(this.DataSetClientes.clientes);

          //  this.reportViewer1.RefreshReport();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fclientes1 ss = new presupvisual.Fclientes1();
            ss.Show();
        }

        private void BotonPasar_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetClientes.clientes' Puede moverla o quitarla según sea necesario.
            string importe;
            importe = pimporte.Text;
            this.clientesTableAdapter.Fill(this.DataSetPagare.clientes,importe);
            this.reportViewer1.RefreshReport();
        }
    }
}
