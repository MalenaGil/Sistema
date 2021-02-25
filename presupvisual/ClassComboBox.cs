using System.Windows.Forms;
using System.Data.SqlClient;

namespace presupvisual
{
    public class ClassComboBox
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8COP5NU\SQLSISTEMAS;Initial Catalog=litografia;Integrated Security=True;");
        public void seleccionar(ComboBox cb)
        {
            cb.Items.Clear();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from clientes", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cb.Items.Add(dr[0].ToString());
                cb.Items.Add(dr[1].ToString());
            }
            con.Close();
        }
    }
}