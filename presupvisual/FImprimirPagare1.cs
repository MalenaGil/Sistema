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
    public partial class FImprimirPagare1 : Form
    {
        public FImprimirPagare1()
        {
            InitializeComponent();
        }

        private void FImprimirPagare1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetClientes.clientes' Puede moverla o quitarla según sea necesario.

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fclientes1 ss = new presupvisual.Fclientes1();
            ss.Show();
        }

        private void BotonPasar_Click(object sender, EventArgs e)
        {
            string importe;
            importe = pimporte.Text;
        //    this.clientesTableAdapter.Fill(this.DataSetPagare.clientes, importe);
            this.reportViewer1.RefreshReport();
        }
    }
}
