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
    public partial class Fimprimeprovs : Form
    {
        public Fimprimeprovs()
        {
            InitializeComponent();
        }

       private void Fimprimeprovs_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DSproveedores.provs' Puede moverla o quitarla según sea necesario.
            this.provsTableAdapter.Fill(this.DSproveedores.provs);
            this.reportViewer1.RefreshReport();
        }

        private void BotonBusca_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DSproveedores.provs' Puede moverla o quitarla según sea necesario.
            string claveprove;
            claveprove = pclaveprove.Text;
            this.provsTableAdapter.FillByProve(this.DSproveedores.provs, claveprove);
            this.reportViewer1.RefreshReport();
        }

        private void BotonBuscaRFC_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DSproveedores.provs' Puede moverla o quitarla según sea necesario.
            string rfcprove;
            rfcprove = prfcprove.Text;
            this.provsTableAdapter.FillByrfc(this.DSproveedores.provs, rfcprove);
            this.reportViewer1.RefreshReport();
        }

        private void BotonBuscaRazon_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DSproveedores.provs' Puede moverla o quitarla según sea necesario.
            string razonprove;
            razonprove = prazonprove.Text;
            this.provsTableAdapter.FillByrazon(this.DSproveedores.provs, razonprove);
            this.reportViewer1.RefreshReport();
        }


        private void btsalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fproveedores ss = new presupvisual.Fproveedores();
            ss.Show();
        }
    }
}
