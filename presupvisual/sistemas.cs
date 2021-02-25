using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace presupvisual
{
    public partial class sistemas : Form
    {
        public sistemas()
        {
            InitializeComponent();
            label1.Parent = fondo;
            label1.BackColor = Color.Transparent;
            label2.Parent = fondo;
            label2.BackColor = Color.Transparent;
            label3.Parent = fondo;
            label3.BackColor = Color.Transparent;
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Psw_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8COP5NU\SQLSISTEMAS;Initial Catalog=litografia;Integrated Security=True;");
                //SqlConnection con = new SqlConnection(@"Data Source=SERVER\SQLSISTEMAS;Initial Catalog=litografia;Integrated Security=True;");
                //SqlConnection con = new SqlConnection(strConnection);//@"Data Source=DESKTOP-8COP5NU\SQLSISTEMAS ;Initial Catalog=litografia; Integrated Security=True; ");
                System.Data.SqlClient.SqlDataAdapter sda = new SqlDataAdapter("select count(*) from usuarios where usuario='" + usuario.Text + "' and psw='" + psw.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    menu ss = new presupvisual.menu();
                    ss.Show();
                }
                else
                {
                    MessageBox.Show("Revisa el usuario y contraseña");
                }
            }
        }
    }
}
