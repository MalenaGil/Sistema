using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Media.TextFormatting;

namespace presupvisual
{
    public partial class FImprimir : Form
    {
        public FImprimir()
        {
            InitializeComponent();
        }

        private void FImprimir_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetClientes.clientes' Puede moverla o quitarla según sea necesario.
           // this.clientesTableAdapter.Fill(this.DataSetClientes.clientes);
           // this.reportViewer1.RefreshReport();
        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fclientes1 ss = new presupvisual.Fclientes1();
            ss.Show();
        }

        private void BotonBusca_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetClientes.clientes' Puede moverla o quitarla según sea necesario.
            string claveclte ;
            claveclte = pclaveclte.Text ;   
            this.clientesTableAdapter.Fill(this.DataSetClientes.clientes,claveclte);
            this.reportViewer1.RefreshReport();
        }

        private void BotonBuscaRFC_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetClientes.clientes' Puede moverla o quitarla según sea necesario.
            string claverfc;
            claverfc = prfcclte.Text;

            this.clientesTableAdapter.FillBy(this.DataSetClientes.clientes, claverfc);

            this.reportViewer1.RefreshReport();
        }

        private void BotonBuscaRazon_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetClientes.clientes' Puede moverla o quitarla según sea necesario.
            string claverazon;
            claverazon = prazonclte.Text;

            this.clientesTableAdapter.FillBy1(this.DataSetClientes.clientes, claverazon);

            this.reportViewer1.RefreshReport();
        }
    }
}
