using System;
using System.Windows.Forms;

namespace presupvisual
{
    public partial class Fcontraseña : Form

    {
        public delegate void pasar(string dato);
        public event pasar Pasado;

        public Fcontraseña()
        {
            InitializeComponent();

        }

        private void Txtcontra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Pasado(txtcontra.Text);
                Dispose();
            }
        }

        private void BTaceptar_Click(object sender, EventArgs e)
        {
            Pasado(txtcontra.Text);
            Dispose();
        }
    }
}
