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
    public partial class Fordenestrabajo : Form
    {
        public Fordenestrabajo()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //   Application.Exit();
            this.Hide();
            menu ss = new presupvisual.menu();
            ss.Show();
        }
    }
}
