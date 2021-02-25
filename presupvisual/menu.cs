using System;
using System.Drawing;
using System.Windows.Forms;

namespace presupvisual
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
            labelPresupuestos.Parent = fondo;
            labelPresupuestos.BackColor = Color.Transparent;

            labelOrdenesTrabajo.Parent = fondo;
            labelOrdenesTrabajo.BackColor = Color.Transparent;

            labelOrdenesCompra.Parent = fondo;
            labelOrdenesCompra.BackColor = Color.Transparent;

            labelRemisiones.Parent = fondo;
            labelRemisiones.BackColor = Color.Transparent;

            labelFacturas.Parent = fondo;
            labelFacturas.BackColor = Color.Transparent;

            labelNotasCredito.Parent = fondo;
            labelNotasCredito.BackColor = Color.Transparent;

            labelContrarecibos.Parent = fondo;
            labelContrarecibos.BackColor = Color.Transparent;

            labelCobranzas.Parent = fondo;
            labelCobranzas.BackColor = Color.Transparent;

            labelDepositos.Parent = fondo;
            labelDepositos.BackColor = Color.Transparent;

            labelCheques.Parent = fondo;
            labelCheques.BackColor = Color.Transparent;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //      this.Hide();
            //      Form1 ss = new presupvisual.Form1();
            //      ss.Show();
        }

        private void PROVEEDORESToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void labelPresupuestos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fpresupuestos ss = new presupvisual.Fpresupuestos();
            ss.Show();
        }

        private void LabelOrdenesTrabajo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fordenestrabajo ss = new presupvisual.Fordenestrabajo();
            ss.Show();
        }

        private void ToolStripDropDownClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fclientes1 ss = new presupvisual.Fclientes1();
            ss.Show();
        }

        private void LabelOrdenesCompra_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fordenescompra ss = new presupvisual.Fordenescompra();
            ss.Show();
        }

        private void LabelRemisiones_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fremisiones ss = new presupvisual.Fremisiones();
            ss.Show();
        }

        private void LabelFacturas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ffacturas ss = new presupvisual.Ffacturas();
            ss.Show();
        }

        private void LabelNotasCredito_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fnotascredito ss = new presupvisual.Fnotascredito();
            ss.Show();
        }

        private void LabelContrarecibos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fcontrarecibos ss = new presupvisual.Fcontrarecibos();
            ss.Show();
        }

        private void LabelCobranzas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fcobranzas ss = new presupvisual.Fcobranzas();
            ss.Show();
        }

        private void LabelDepositos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fdepositos ss = new presupvisual.Fdepositos();
            ss.Show();
        }

        private void LabelCheques_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fcheques ss = new presupvisual.Fcheques();
            ss.Show();
        }

        private void LabelPresupuestos_MouseHover(object sender, EventArgs e)
        {
            labelPresupuestos.ForeColor = Color.Red;
        }

        private void LabelPresupuestos_MouseLeave(object sender, EventArgs e)
        {
            labelPresupuestos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
        }

        private void LabelOrdenesTrabajo_MouseHover(object sender, EventArgs e)
        {
            labelOrdenesTrabajo.ForeColor = Color.Red;
        }

        private void LabelOrdenesTrabajo_MouseLeave(object sender, EventArgs e)
        {
            labelOrdenesTrabajo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
        }

        private void LabelOrdenesCompra_MouseHover(object sender, EventArgs e)
        {
            labelOrdenesCompra.ForeColor = Color.Red;
        }

        private void LabelOrdenesCompra_MouseLeave(object sender, EventArgs e)
        {
            labelOrdenesCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
        }

        private void LabelRemisiones_MouseHover(object sender, EventArgs e)
        {
            labelRemisiones.ForeColor = Color.Red;
        }

        private void LabelRemisiones_MouseLeave(object sender, EventArgs e)
        {
            labelRemisiones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
        }

        private void LabelFacturas_MouseHover(object sender, EventArgs e)
        {
            labelFacturas.ForeColor = Color.Red;
        }

        private void LabelFacturas_MouseLeave(object sender, EventArgs e)
        {
            labelFacturas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
        }

        private void LabelNotasCredito_MouseHover(object sender, EventArgs e)
        {
            labelNotasCredito.ForeColor = Color.Red;
        }

        private void LabelNotasCredito_MouseLeave(object sender, EventArgs e)
        {
            labelNotasCredito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
        }

        private void LabelContrarecibos_MouseHover(object sender, EventArgs e)
        {
            labelContrarecibos.ForeColor = Color.Red;
        }

        private void LabelContrarecibos_MouseLeave(object sender, EventArgs e)
        {
            labelContrarecibos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
        }

        private void LabelCobranzas_MouseHover(object sender, EventArgs e)
        {
            labelCobranzas.ForeColor = Color.Red;
        }

        private void LabelCobranzas_MouseLeave(object sender, EventArgs e)
        {
            labelCobranzas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
        }

        private void LabelDepositos_MouseHover(object sender, EventArgs e)
        {
            labelDepositos.ForeColor = Color.Red;
        }

        private void LabelDepositos_MouseLeave(object sender, EventArgs e)
        {
            labelDepositos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
        }

        private void LabelCheques_MouseHover(object sender, EventArgs e)
        {
            labelCheques.ForeColor = Color.Red;
        }

        private void LabelCheques_MouseLeave(object sender, EventArgs e)
        {
            labelCheques.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fproveedores ss = new presupvisual.Fproveedores();
            ss.Show();
        }
    }
}
