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
    public partial class FContrato : Form
    {
        public FContrato()
        {
            InitializeComponent();
        }

        private void FContrato_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetClientes.clientes' Puede moverla o quitarla según sea necesario.
         // this.clientesTableAdapter.Fill(this.DataSetClientes.clientes);
         //   this.clientesTableAdapter.Fill(this.DataSetContrato.clientes);

         //   this.reportViewer1.RefreshReport();
         //   this.reportViewer1.RefreshReport();
        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fclientes1 ss = new presupvisual.Fclientes1();
            ss.Show();
        }
    }
}
