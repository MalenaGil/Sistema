using System;
using System.Windows.Forms;

namespace presupvisual

{
    public partial class Fcontra : Form
    {
        public delegate void pasar(string dato);
        public event pasar pasado;

        public Fcontra()
        {
            InitializeComponent();
        }

        private void BTaceptar_Click(object sender, EventArgs e)
        {
            pasado(txtcontra.Text);
            Dispose();
        }

        private void Txtcontra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                pasado(txtcontra.Text);
                Dispose();
            }
        }
    }
}
