using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace presupvisual
{

    public partial class Fproveedores : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8COP5NU\SQLSISTEMAS;Initial Catalog=litografia;Integrated Security=True;");
        //SqlConnection con = new SqlConnection(@"Data Source=SERVER\SQLSISTEMAS;Initial Catalog=litografia;Integrated Security=True;");
        //SqlConnection con = new SqlConnection(strConnection);//@"Data Source=DESKTOP-8COP5NU\SQLSISTEMAS ;Initial Catalog=litografia; Integrated Security=True; ");

        ClassComboBox combo = new ClassComboBox();
        SqlCommand cmd = new SqlCommand();
        public Fproveedores()
        {
            InitializeComponent();
            //   combo.seleccionar(cb);
            cmd.Connection = con;
            this.Show();
            razon.Focus();
            con.Open();

            txtcontrase.Text = "";
            LBLcontra.Text = "";

            proveedor.Text = "";
            tipo.Text = "";
            razon.Text = "";
            direc1.Text = "";
            direc2.Text = "";
            direc3.Text = "";
            rfc.Text = "";
            porcmas.Text = "";
            transf.Text = "";
            ext.Text = "";
            atencion.Text = "";
            tel1.Text = "";
            tel2.Text = "";
            email.Text = "";
            web.Text = "";
            reqent.Text = "";
            reqord.Text = "";
            polizas.Checked = false;
            cont1.Checked = false;
            cont2.Checked = false;
            cont3.Checked = false;
            cont4.Checked = false;
            cont5.Checked = false;
            cont6.Checked = false;
            ultorden.Text = "";
            nombrerep.Text = "";
            escritura.Text = "";
            fechaesc.Text = "";
            nombrenot.Text = "";
            numnot.Text = "";
            lugar.Text = "";
            regcomer.Text = "";
            ultorden.Text = "";
            prove_lg.Text = "";
            prove_edi.Text = "";
            prove_ter.Text = "";
            banco_lg.Text = "";
            banco_edi.Text = "";
            banco_ter.Text = "";
            ctabanco_l.Text = "";
            ctabanco_e.Text = "";
            ctabanco_t.Text = "";
            cont_lg.Text = "";
            cont_edi.Text = "";
            cont_ter.Text = "";
            cta_lg.Text = "";
            cta_edi.Text = "";
            cta_ter.Text = "";
            pago.Text = "";
            rb90.Checked = false;
            rb60.Checked = false;
            rb45.Checked = false;
            rb30.Checked = false;
            rb15.Checked = false;
            rb7.Checked = false;
            rbContado.Checked = false;
            rbOtro.Checked = false;
            imss.Text = "";
            creden.Text = "";
            fiscal.Text = "";
            ctaiva.Text = "";
            cta1a.Text = "";
            cta2a.Text = "";
            cta3a.Text = "";
            email1.Text = "";
            email2.Text = "";
            email3.Text = "";
            mailcontra.Text = "";
            mailcomple.Text = "";
            especi.Text = "";

            SqlCommand cursor = new SqlCommand("select top (1) proveedor,tipo,razon,direc1,direc2,direc3,rfc,porcmas,transf,ext,atencion,tel1,tel2,email,web," +
                "reqent,reqord,polizas,ultorden,nombrerep,escritura,fechaesc,nombrenot,numnot,lugar,regcomer,prove_lg,prove_edi,prove_ter," +
                "banco_lg,banco_edi,banco_ter,ctabanco_l,ctabanco_e,ctabanco_t,cont_lg,cont_edi,cont_ter,cta_lg,cta_edi,cta_ter," +
                "pago,imss,creden,fiscal,ctaiva,cta1a,cta2a,cta3a,email1,email2,email3,mailcontra,mailcomple,especi,cont1,cont2,cont3,cont4,cont5,cont6 " +
                " from dbo.provs ", con);
            SqlDataReader cursorleido = cursor.ExecuteReader();
            while (cursorleido.Read())
            {
                proveedor.Text = Convert.ToString(cursorleido["proveedor"]);
                tipo.Text = Convert.ToString(cursorleido["tipo"]);
                razon.Text = Convert.ToString(cursorleido["razon"]);
                direc1.Text = Convert.ToString(cursorleido["direc1"]);
                direc2.Text = Convert.ToString(cursorleido["direc2"]);
                direc3.Text = Convert.ToString(cursorleido["direc3"]);
                rfc.Text = Convert.ToString(cursorleido["rfc"]);
                porcmas.Text = Convert.ToString(cursorleido["porcmas"]);
                transf.Text = Convert.ToString(cursorleido["transf"]);
                ext.Text = Convert.ToString(cursorleido["ext"]);
                atencion.Text = Convert.ToString(cursorleido["atencion"]);
                tel1.Text = Convert.ToString(cursorleido["tel1"]);
                tel2.Text = Convert.ToString(cursorleido["tel2"]);
                email.Text = Convert.ToString(cursorleido["email"]);
                web.Text = Convert.ToString(cursorleido["web"]);
                reqent.Text = Convert.ToString(cursorleido["reqent"]);
                reqord.Text = Convert.ToString(cursorleido["reqord"]);
                polizas.Checked = Convert.ToBoolean(cursorleido["polizas"]);
                ultorden.Text = Convert.ToString(cursorleido["ultorden"]);
                nombrerep.Text = Convert.ToString(cursorleido["nombrerep"]);
                escritura.Text = Convert.ToString(cursorleido["escritura"]);
                fechaesc.Text = Convert.ToString(cursorleido["fechaesc"]);
                nombrenot.Text = Convert.ToString(cursorleido["nombrenot"]);
                numnot.Text = Convert.ToString(cursorleido["numnot"]);
                lugar.Text = Convert.ToString(cursorleido["lugar"]);
                regcomer.Text = Convert.ToString(cursorleido["regcomer"]);
                prove_lg.Text = Convert.ToString(cursorleido["prove_lg"]);
                prove_edi.Text = Convert.ToString(cursorleido["prove_edi"]);
                prove_ter.Text = Convert.ToString(cursorleido["prove_ter"]);
                banco_lg.Text = Convert.ToString(cursorleido["banco_lg"]);
                banco_edi.Text = Convert.ToString(cursorleido["banco_edi"]);
                banco_ter.Text = Convert.ToString(cursorleido["banco_ter"]);
                ctabanco_l.Text = Convert.ToString(cursorleido["ctabanco_l"]);
                ctabanco_e.Text = Convert.ToString(cursorleido["ctabanco_e"]);
                ctabanco_t.Text = Convert.ToString(cursorleido["ctabanco_t"]);
                cont_lg.Text = Convert.ToString(cursorleido["cont_lg"]);
                cont_edi.Text = Convert.ToString(cursorleido["cont_edi"]);
                cont_ter.Text = Convert.ToString(cursorleido["cont_ter"]);
                cta_lg.Text = Convert.ToString(cursorleido["cta_lg"]);
                cta_edi.Text = Convert.ToString(cursorleido["cta_edi"]);
                cta_ter.Text = Convert.ToString(cursorleido["cta_ter"]);
                pago.Text = Convert.ToString(cursorleido["pago"]);
                if (pago.Text == "1") { rb90.Checked = true; };
                if (pago.Text == "2") { rb60.Checked = true; };
                if (pago.Text == "3") { rb45.Checked = true; };
                if (pago.Text == "4") { rb30.Checked = true; };
                if (pago.Text == "5") { rb15.Checked = true; };
                if (pago.Text == "6") { rb7.Checked = true; };
                if (pago.Text == "7") { rbContado.Checked = true; };
                if (pago.Text == "8") { rbOtro.Checked = true; };
                cont1.Checked = Convert.ToBoolean(cursorleido["cont1"]);
                cont2.Checked = Convert.ToBoolean(cursorleido["cont2"]);
                cont3.Checked = Convert.ToBoolean(cursorleido["cont3"]);
                cont4.Checked = Convert.ToBoolean(cursorleido["cont4"]);
                cont5.Checked = Convert.ToBoolean(cursorleido["cont5"]);
                cont6.Checked = Convert.ToBoolean(cursorleido["cont6"]);
                imss.Text = Convert.ToString(cursorleido["imss"]);
                creden.Text = Convert.ToString(cursorleido["creden"]);
                fiscal.Text = Convert.ToString(cursorleido["fiscal"]);
                ctaiva.Text = Convert.ToString(cursorleido["ctaiva"]);
                cta1a.Text = Convert.ToString(cursorleido["cta1a"]);
                cta2a.Text = Convert.ToString(cursorleido["cta2a"]);
                cta3a.Text = Convert.ToString(cursorleido["cta3a"]);
                email1.Text = Convert.ToString(cursorleido["email1"]);
                email2.Text = Convert.ToString(cursorleido["email2"]);
                email3.Text = Convert.ToString(cursorleido["email3"]);
                mailcontra.Text = Convert.ToString(cursorleido["mailcontra"]);
                mailcomple.Text = Convert.ToString(cursorleido["mailcomple"]);
                especi.Text = Convert.ToString(cursorleido["especi"]);
            }
            con.Close();
            this.Show();
            razon.Focus();



            //           prove.Text = "";
            //
            //            SqlCommand cursor = new SqlCommand("select top (1) tipo,descrip from dbo.tipocontra ", con);
            //            SqlDataReader cursorleido = cursor.ExecuteReader();
            //            while (cursorleido.Read())
            //            {
            //                tipo.Text = Convert.ToString(cursorleido["tipo"]);
            //            }
            //            con.Close();
            //            this.Show();
            //            prove.Focus();
        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu ss = new presupvisual.menu();
            ss.Show();
        }

        private void Fproveedores_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand comando = new SqlCommand("select tipo,descrip from dbo.tipocontra", con);
            SqlDataReader registro = comando.ExecuteReader();
            while (registro.Read())
            {
                tipo.Items.Add((registro["tipo"].ToString()) + " - " + (registro["descrip"].ToString()));
                //               tipo.Items.Add(registro["descrip"].ToString());
            }
            con.Close();

            con.Open();
            SqlCommand comandolg = new SqlCommand("select banco,nombre from dbo.bancos", con);
            SqlDataReader registrolg = comandolg.ExecuteReader();
            while (registrolg.Read())
            {
                banco_lg.Items.Add((registrolg["banco"].ToString()) + " - " + (registrolg["nombre"].ToString()));
            }
            con.Close();

            con.Open();
            SqlCommand comandoedi = new SqlCommand("select banco,nombre from dbo.bancos", con);
            SqlDataReader registroedi = comandoedi.ExecuteReader();
            while (registroedi.Read())
            {
                banco_edi.Items.Add((registroedi["banco"].ToString()) + " - " + (registroedi["nombre"].ToString()));
            }
            con.Close();

            con.Open();
            SqlCommand comandoter = new SqlCommand("select banco,nombre from dbo.bancos", con);
            SqlDataReader registroter = comandoter.ExecuteReader();
            while (registroter.Read())
            {
                banco_ter.Items.Add((registroter["banco"].ToString()) + " - " + (registroter["nombre"].ToString()));
            }
            con.Close();

            con.Open();
            SqlCommand comandoctalg = new SqlCommand("select cta_lg from dbo.cuentaslg", con);
            SqlDataReader registroctalg = comandoctalg.ExecuteReader();
            while (registroctalg.Read())
            {
                cta_lg.Items.Add((registroctalg["cta_lg"].ToString()));
            }
            con.Close();

            con.Open();
            SqlCommand comandoctaedi = new SqlCommand("select cta_edi from dbo.cuentasedi", con);
            SqlDataReader registroctaedi = comandoctaedi.ExecuteReader();
            while (registroctaedi.Read())
            {
                cta_edi.Items.Add((registroctaedi["cta_edi"].ToString()));
            }
            con.Close();

            con.Open();
            SqlCommand comandoctater = new SqlCommand("select cta_ter from dbo.cuentaster", con);
            SqlDataReader registroctater = comandoctater.ExecuteReader();
            while (registroctater.Read())
            {
                cta_ter.Items.Add((registroctater["cta_ter"].ToString()));
            }
            con.Close();
        }


        private void btprimero_Click(object sender, EventArgs e)
        {
            con.Open();
            proveedor.Text = "";
            tipo.Text = "";
            razon.Text = "";
            direc1.Text = "";
            direc2.Text = "";
            direc3.Text = "";
            rfc.Text = "";
            porcmas.Text = "";
            transf.Text = "";
            ext.Text = "";
            atencion.Text = "";
            tel1.Text = "";
            tel2.Text = "";
            email.Text = "";
            web.Text = "";
            reqent.Text = "";
            reqord.Text = "";
            polizas.Checked = false;
            cont1.Checked = false;
            cont2.Checked = false;
            cont3.Checked = false;
            cont4.Checked = false;
            cont5.Checked = false;
            cont6.Checked = false;
            ultorden.Text = "";
            nombrerep.Text = "";
            escritura.Text = "";
            fechaesc.Text = "";
            nombrenot.Text = "";
            numnot.Text = "";
            lugar.Text = "";
            regcomer.Text = "";
            ultorden.Text = "";
            prove_lg.Text = "";
            prove_edi.Text = "";
            prove_ter.Text = "";
            banco_lg.Text = "";
            banco_edi.Text = "";
            banco_ter.Text = "";
            ctabanco_l.Text = "";
            ctabanco_e.Text = "";
            ctabanco_t.Text = "";
            cont_lg.Text = "";
            cont_edi.Text = "";
            cont_ter.Text = "";
            cta_lg.Text = "";
            cta_edi.Text = "";
            cta_ter.Text = "";
            pago.Text = "";
            rb90.Checked = false;
            rb60.Checked = false;
            rb45.Checked = false;
            rb30.Checked = false;
            rb15.Checked = false;
            rb7.Checked = false;
            rbContado.Checked = false;
            rbOtro.Checked = false;
            imss.Text = "";
            creden.Text = "";
            fiscal.Text = "";
            ctaiva.Text = "";
            cta1a.Text = "";
            cta2a.Text = "";
            cta3a.Text = "";
            email1.Text = "";
            email2.Text = "";
            email3.Text = "";
            mailcontra.Text = "";
            mailcomple.Text = "";
            especi.Text = "";

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select top(1) proveedor,tipo,razon,direc1,rfc " +
               " from dbo.provs ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DGproveedores.DataSource = dt;
            int cuenta = DGproveedores.RowCount;


            DGproveedores.RowHeadersVisible = false;

            DGproveedores.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DGproveedores.Columns[0].Width = 95;
            DGproveedores.Columns[0].DefaultCellStyle.BackColor = Color.PowderBlue;
            DGproveedores.Columns[0].HeaderText = "PROVE";
            DGproveedores.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGproveedores.Columns[1].Width = 40;
            DGproveedores.Columns[1].DefaultCellStyle.BackColor = Color.Beige;
            DGproveedores.Columns[1].HeaderText = "TIPO";
            DGproveedores.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGproveedores.Columns[2].Width = 200;
            DGproveedores.Columns[2].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGproveedores.Columns[2].HeaderText = "RAZON SOCIAL";
            DGproveedores.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGproveedores.Columns[3].Width = 185;
            DGproveedores.Columns[3].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGproveedores.Columns[3].HeaderText = "DIRECCION";
            DGproveedores.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGproveedores.Columns[4].Width = 80;
            DGproveedores.Columns[4].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGproveedores.Columns[4].HeaderText = "RFC";
            DGproveedores.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            SqlCommand cursor = new SqlCommand("select top (1) proveedor,tipo,razon,direc1,direc2,direc3,rfc,porcmas,transf,ext,atencion,tel1,tel2,email,web," +
               "reqent,reqord,polizas,ultorden,nombrerep,escritura,fechaesc,nombrenot,numnot,lugar,regcomer,prove_lg,prove_edi,prove_ter, " +
               "banco_lg,banco_edi,banco_ter,ctabanco_l,ctabanco_e,ctabanco_t,cont_lg,cont_edi,cont_ter,cta_lg,cta_edi,cta_ter, " +
               "pago,imss,creden,fiscal,ctaiva,cta1a,cta2a,cta3a,email1,email2,email3,mailcontra,mailcomple,especi,cont1,cont2,cont3,cont4,cont5,cont6 " +
               " from dbo.provs ", con);
            SqlDataReader cursorleido = cursor.ExecuteReader();
            while (cursorleido.Read())
            {
                proveedor.Text = Convert.ToString(cursorleido["proveedor"]);
                tipo.Text = Convert.ToString(cursorleido["tipo"]);
                razon.Text = Convert.ToString(cursorleido["razon"]);
                direc1.Text = Convert.ToString(cursorleido["direc1"]);
                direc2.Text = Convert.ToString(cursorleido["direc2"]);
                direc3.Text = Convert.ToString(cursorleido["direc3"]);
                rfc.Text = Convert.ToString(cursorleido["rfc"]);
                porcmas.Text = Convert.ToString(cursorleido["porcmas"]);
                transf.Text = Convert.ToString(cursorleido["transf"]);
                ext.Text = Convert.ToString(cursorleido["ext"]);
                atencion.Text = Convert.ToString(cursorleido["atencion"]);
                tel1.Text = Convert.ToString(cursorleido["tel1"]);
                tel2.Text = Convert.ToString(cursorleido["tel2"]);
                email.Text = Convert.ToString(cursorleido["email"]);
                web.Text = Convert.ToString(cursorleido["web"]);
                reqent.Text = Convert.ToString(cursorleido["reqent"]);
                reqord.Text = Convert.ToString(cursorleido["reqord"]);
                polizas.Checked = Convert.ToBoolean(cursorleido["polizas"]);
                ultorden.Text = Convert.ToString(cursorleido["ultorden"]);
                nombrerep.Text = Convert.ToString(cursorleido["nombrerep"]);
                escritura.Text = Convert.ToString(cursorleido["escritura"]);
                fechaesc.Text = Convert.ToString(cursorleido["fechaesc"]);
                nombrenot.Text = Convert.ToString(cursorleido["nombrenot"]);
                numnot.Text = Convert.ToString(cursorleido["numnot"]);
                lugar.Text = Convert.ToString(cursorleido["lugar"]);
                regcomer.Text = Convert.ToString(cursorleido["regcomer"]);
                prove_lg.Text = Convert.ToString(cursorleido["prove_lg"]);
                prove_edi.Text = Convert.ToString(cursorleido["prove_edi"]);
                prove_ter.Text = Convert.ToString(cursorleido["prove_ter"]);
                banco_lg.Text = Convert.ToString(cursorleido["banco_lg"]);
                banco_edi.Text = Convert.ToString(cursorleido["banco_edi"]);
                banco_ter.Text = Convert.ToString(cursorleido["banco_ter"]);
                ctabanco_l.Text = Convert.ToString(cursorleido["ctabanco_l"]);
                ctabanco_e.Text = Convert.ToString(cursorleido["ctabanco_e"]);
                ctabanco_t.Text = Convert.ToString(cursorleido["ctabanco_t"]);
                cont_lg.Text = Convert.ToString(cursorleido["cont_lg"]);
                cont_edi.Text = Convert.ToString(cursorleido["cont_edi"]);
                cont_ter.Text = Convert.ToString(cursorleido["cont_ter"]);
                cta_lg.Text = Convert.ToString(cursorleido["cta_lg"]);
                cta_edi.Text = Convert.ToString(cursorleido["cta_edi"]);
                cta_ter.Text = Convert.ToString(cursorleido["cta_ter"]);
                pago.Text = Convert.ToString(cursorleido["pago"]);
                if (pago.Text == "1") { rb90.Checked = true; };
                if (pago.Text == "2") { rb60.Checked = true; };
                if (pago.Text == "3") { rb45.Checked = true; };
                if (pago.Text == "4") { rb30.Checked = true; };
                if (pago.Text == "5") { rb15.Checked = true; };
                if (pago.Text == "6") { rb7.Checked = true; };
                if (pago.Text == "7") { rbContado.Checked = true; };
                if (pago.Text == "8") { rbOtro.Checked = true; };
                cont1.Checked = Convert.ToBoolean(cursorleido["cont1"]);
                cont2.Checked = Convert.ToBoolean(cursorleido["cont2"]);
                cont3.Checked = Convert.ToBoolean(cursorleido["cont3"]);
                cont4.Checked = Convert.ToBoolean(cursorleido["cont4"]);
                cont5.Checked = Convert.ToBoolean(cursorleido["cont5"]);
                cont6.Checked = Convert.ToBoolean(cursorleido["cont6"]);
                imss.Text = Convert.ToString(cursorleido["imss"]);
                creden.Text = Convert.ToString(cursorleido["creden"]);
                fiscal.Text = Convert.ToString(cursorleido["fiscal"]);
                ctaiva.Text = Convert.ToString(cursorleido["ctaiva"]);
                cta1a.Text = Convert.ToString(cursorleido["cta1a"]);
                cta2a.Text = Convert.ToString(cursorleido["cta2a"]);
                cta3a.Text = Convert.ToString(cursorleido["cta3a"]);
                email1.Text = Convert.ToString(cursorleido["email1"]);
                email2.Text = Convert.ToString(cursorleido["email2"]);
                email3.Text = Convert.ToString(cursorleido["email3"]);
                mailcontra.Text = Convert.ToString(cursorleido["mailcontra"]);
                mailcomple.Text = Convert.ToString(cursorleido["mailcomple"]);
                especi.Text = Convert.ToString(cursorleido["especi"]);
            }
            con.Close();
            this.Show();
            razon.Focus();

        }

        private void btultimo_Click(object sender, EventArgs e)
        {
            con.Open();
            proveedor.Text = "";
            tipo.Text = "";
            razon.Text = "";
            direc1.Text = "";
            direc2.Text = "";
            direc3.Text = "";
            rfc.Text = "";
            porcmas.Text = "";
            transf.Text = "";
            ext.Text = "";
            atencion.Text = "";
            tel1.Text = "";
            tel2.Text = "";
            email.Text = "";
            web.Text = "";
            reqent.Text = "";
            reqord.Text = "";
            polizas.Checked = false;
            cont1.Checked = false;
            cont2.Checked = false;
            cont3.Checked = false;
            cont4.Checked = false;
            cont5.Checked = false;
            cont6.Checked = false;
            ultorden.Text = "";
            nombrerep.Text = "";
            escritura.Text = "";
            fechaesc.Text = "";
            nombrenot.Text = "";
            numnot.Text = "";
            lugar.Text = "";
            regcomer.Text = "";
            ultorden.Text = "";
            prove_lg.Text = "";
            prove_edi.Text = "";
            prove_ter.Text = "";
            banco_lg.Text = "";
            banco_edi.Text = "";
            banco_ter.Text = "";
            ctabanco_l.Text = "";
            ctabanco_e.Text = "";
            ctabanco_t.Text = "";
            cont_lg.Text = "";
            cont_edi.Text = "";
            cont_ter.Text = "";
            cta_lg.Text = "";
            cta_edi.Text = "";
            cta_ter.Text = "";
            pago.Text = "";
            rb90.Checked = false;
            rb60.Checked = false;
            rb45.Checked = false;
            rb30.Checked = false;
            rb15.Checked = false;
            rb7.Checked = false;
            rbContado.Checked = false;
            rbOtro.Checked = false;
            imss.Text = "";
            creden.Text = "";
            fiscal.Text = "";
            ctaiva.Text = "";
            cta1a.Text = "";
            cta2a.Text = "";
            cta3a.Text = "";
            email1.Text = "";
            email2.Text = "";
            email3.Text = "";
            mailcontra.Text = "";
            mailcomple.Text = "";
            especi.Text = "";

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select top(1) proveedor,tipo,razon,direc1,rfc " +
               " from dbo.provs order by proveedor desc";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DGproveedores.DataSource = dt;
            int cuenta = DGproveedores.RowCount;

            DGproveedores.RowHeadersVisible = false;

            DGproveedores.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DGproveedores.Columns[0].Width = 95;
            DGproveedores.Columns[0].DefaultCellStyle.BackColor = Color.PowderBlue;
            DGproveedores.Columns[0].HeaderText = "PROVE";
            DGproveedores.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGproveedores.Columns[1].Width = 40;
            DGproveedores.Columns[1].DefaultCellStyle.BackColor = Color.Beige;
            DGproveedores.Columns[1].HeaderText = "TIPO";
            DGproveedores.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGproveedores.Columns[2].Width = 200;
            DGproveedores.Columns[2].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGproveedores.Columns[2].HeaderText = "RAZON SOCIAL";
            DGproveedores.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGproveedores.Columns[3].Width = 185;
            DGproveedores.Columns[3].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGproveedores.Columns[3].HeaderText = "DIRECCION";
            DGproveedores.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGproveedores.Columns[4].Width = 80;
            DGproveedores.Columns[4].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGproveedores.Columns[4].HeaderText = "RFC";
            DGproveedores.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;


            SqlCommand cursor = new SqlCommand("select top (1) proveedor,tipo,razon,direc1,direc2,direc3,rfc,porcmas,transf,ext,atencion,tel1,tel2,email,web," +
               "reqent,reqord,polizas,ultorden,nombrerep,escritura,fechaesc,nombrenot,numnot,lugar,regcomer,prove_lg,prove_edi,prove_ter," +
               "banco_lg,banco_edi,banco_ter,ctabanco_l,ctabanco_e,ctabanco_t,cont_lg,cont_edi,cont_ter,cta_lg,cta_edi,cta_ter, " +
               "pago,imss,creden,fiscal,ctaiva,cta1a,cta2a,cta3a,email1,email2,email3,mailcontra,mailcomple,especi,cont1,cont2,cont3,cont4,cont5,cont6 " +
               " from dbo.provs order by proveedor desc ", con);
            SqlDataReader cursorleido = cursor.ExecuteReader();
            while (cursorleido.Read())
            {
                proveedor.Text = Convert.ToString(cursorleido["proveedor"]);
                tipo.Text = Convert.ToString(cursorleido["tipo"]);
                razon.Text = Convert.ToString(cursorleido["razon"]);
                direc1.Text = Convert.ToString(cursorleido["direc1"]);
                direc2.Text = Convert.ToString(cursorleido["direc2"]);
                direc3.Text = Convert.ToString(cursorleido["direc3"]);
                rfc.Text = Convert.ToString(cursorleido["rfc"]);
                porcmas.Text = Convert.ToString(cursorleido["porcmas"]);
                transf.Text = Convert.ToString(cursorleido["transf"]);
                ext.Text = Convert.ToString(cursorleido["ext"]);
                atencion.Text = Convert.ToString(cursorleido["atencion"]);
                tel1.Text = Convert.ToString(cursorleido["tel1"]);
                tel2.Text = Convert.ToString(cursorleido["tel2"]);
                email.Text = Convert.ToString(cursorleido["email"]);
                web.Text = Convert.ToString(cursorleido["web"]);
                reqent.Text = Convert.ToString(cursorleido["reqent"]);
                reqord.Text = Convert.ToString(cursorleido["reqord"]);
                polizas.Checked = Convert.ToBoolean(cursorleido["polizas"]);
                ultorden.Text = Convert.ToString(cursorleido["ultorden"]);
                nombrerep.Text = Convert.ToString(cursorleido["nombrerep"]);
                escritura.Text = Convert.ToString(cursorleido["escritura"]);
                fechaesc.Text = Convert.ToString(cursorleido["fechaesc"]);
                nombrenot.Text = Convert.ToString(cursorleido["nombrenot"]);
                numnot.Text = Convert.ToString(cursorleido["numnot"]);
                lugar.Text = Convert.ToString(cursorleido["lugar"]);
                regcomer.Text = Convert.ToString(cursorleido["regcomer"]);
                prove_lg.Text = Convert.ToString(cursorleido["prove_lg"]);
                prove_edi.Text = Convert.ToString(cursorleido["prove_edi"]);
                prove_ter.Text = Convert.ToString(cursorleido["prove_ter"]);
                banco_lg.Text = Convert.ToString(cursorleido["banco_lg"]);
                banco_edi.Text = Convert.ToString(cursorleido["banco_edi"]);
                banco_ter.Text = Convert.ToString(cursorleido["banco_ter"]);
                ctabanco_l.Text = Convert.ToString(cursorleido["ctabanco_l"]);
                ctabanco_e.Text = Convert.ToString(cursorleido["ctabanco_e"]);
                ctabanco_t.Text = Convert.ToString(cursorleido["ctabanco_t"]);
                cont_lg.Text = Convert.ToString(cursorleido["cont_lg"]);
                cont_edi.Text = Convert.ToString(cursorleido["cont_edi"]);
                cont_ter.Text = Convert.ToString(cursorleido["cont_ter"]);
                cta_lg.Text = Convert.ToString(cursorleido["cta_lg"]);
                cta_edi.Text = Convert.ToString(cursorleido["cta_edi"]);
                cta_ter.Text = Convert.ToString(cursorleido["cta_ter"]);
                pago.Text = Convert.ToString(cursorleido["pago"]);
                if (pago.Text == "1") { rb90.Checked = true; };
                if (pago.Text == "2") { rb60.Checked = true; };
                if (pago.Text == "3") { rb45.Checked = true; };
                if (pago.Text == "4") { rb30.Checked = true; };
                if (pago.Text == "5") { rb15.Checked = true; };
                if (pago.Text == "6") { rb7.Checked = true; };
                if (pago.Text == "7") { rbContado.Checked = true; };
                if (pago.Text == "8") { rbOtro.Checked = true; };
                cont1.Checked = Convert.ToBoolean(cursorleido["cont1"]);
                cont2.Checked = Convert.ToBoolean(cursorleido["cont2"]);
                cont3.Checked = Convert.ToBoolean(cursorleido["cont3"]);
                cont4.Checked = Convert.ToBoolean(cursorleido["cont4"]);
                cont5.Checked = Convert.ToBoolean(cursorleido["cont5"]);
                cont6.Checked = Convert.ToBoolean(cursorleido["cont6"]);
                imss.Text = Convert.ToString(cursorleido["imss"]);
                creden.Text = Convert.ToString(cursorleido["creden"]);
                fiscal.Text = Convert.ToString(cursorleido["fiscal"]);
                ctaiva.Text = Convert.ToString(cursorleido["ctaiva"]);
                cta1a.Text = Convert.ToString(cursorleido["cta1a"]);
                cta2a.Text = Convert.ToString(cursorleido["cta2a"]);
                cta3a.Text = Convert.ToString(cursorleido["cta3a"]);
                email1.Text = Convert.ToString(cursorleido["email1"]);
                email2.Text = Convert.ToString(cursorleido["email2"]);
                email3.Text = Convert.ToString(cursorleido["email3"]);
                mailcontra.Text = Convert.ToString(cursorleido["mailcontra"]);
                mailcomple.Text = Convert.ToString(cursorleido["mailcomple"]);
                especi.Text = Convert.ToString(cursorleido["especi"]);
            }
            con.Close();
            this.Show();
            razon.Focus();
        }

        private void btanterior_Click(object sender, EventArgs e)
        {
            con.Open();
            //    proveedor.Text = "";
            tipo.Text = "";
            razon.Text = "";
            direc1.Text = "";
            direc2.Text = "";
            direc3.Text = "";
            rfc.Text = "";
            porcmas.Text = "";
            transf.Text = "";
            ext.Text = "";
            atencion.Text = "";
            tel1.Text = "";
            tel2.Text = "";
            email.Text = "";
            web.Text = "";
            reqent.Text = "";
            reqord.Text = "";
            polizas.Checked = false;
            cont1.Checked = false;
            cont2.Checked = false;
            cont3.Checked = false;
            cont4.Checked = false;
            cont5.Checked = false;
            cont6.Checked = false;
            ultorden.Text = "";
            nombrerep.Text = "";
            escritura.Text = "";
            fechaesc.Text = "";
            nombrenot.Text = "";
            numnot.Text = "";
            lugar.Text = "";
            regcomer.Text = "";
            ultorden.Text = "";
            prove_lg.Text = "";
            prove_edi.Text = "";
            prove_ter.Text = "";
            banco_lg.Text = "";
            banco_edi.Text = "";
            banco_ter.Text = "";
            ctabanco_l.Text = "";
            ctabanco_e.Text = "";
            ctabanco_t.Text = "";
            cont_lg.Text = "";
            cont_edi.Text = "";
            cont_ter.Text = "";
            cta_lg.Text = "";
            cta_edi.Text = "";
            cta_ter.Text = "";
            pago.Text = "";
            rb90.Checked = false;
            rb60.Checked = false;
            rb45.Checked = false;
            rb30.Checked = false;
            rb15.Checked = false;
            rb7.Checked = false;
            rbContado.Checked = false;
            rbOtro.Checked = false;
            imss.Text = "";
            creden.Text = "";
            fiscal.Text = "";
            ctaiva.Text = "";
            cta1a.Text = "";
            cta2a.Text = "";
            cta3a.Text = "";
            email1.Text = "";
            email2.Text = "";
            email3.Text = "";
            mailcontra.Text = "";
            mailcomple.Text = "";
            especi.Text = "";

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select top 1 proveedor,tipo,razon,direc1,rfc " +
               "  from dbo.provs where proveedor < '" + proveedor.Text + "' order by proveedor desc  ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DGproveedores.DataSource = dt;
            int cuenta = DGproveedores.RowCount;

            DGproveedores.RowHeadersVisible = false;

            DGproveedores.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DGproveedores.Columns[0].Width = 95;
            DGproveedores.Columns[0].DefaultCellStyle.BackColor = Color.PowderBlue;
            DGproveedores.Columns[0].HeaderText = "PROVE";
            DGproveedores.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGproveedores.Columns[1].Width = 40;
            DGproveedores.Columns[1].DefaultCellStyle.BackColor = Color.Beige;
            DGproveedores.Columns[1].HeaderText = "TIPO";
            DGproveedores.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGproveedores.Columns[2].Width = 200;
            DGproveedores.Columns[2].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGproveedores.Columns[2].HeaderText = "RAZON SOCIAL";
            DGproveedores.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGproveedores.Columns[3].Width = 185;
            DGproveedores.Columns[3].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGproveedores.Columns[3].HeaderText = "DIRECCION";
            DGproveedores.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGproveedores.Columns[4].Width = 80;
            DGproveedores.Columns[4].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGproveedores.Columns[4].HeaderText = "RFC";
            DGproveedores.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;


            SqlCommand cursor = new SqlCommand("select top 1 proveedor,tipo,razon,direc1,direc2,direc3,rfc,porcmas,transf,ext,atencion,tel1,tel2,email,web," +
               "reqent,reqord,polizas,ultorden,nombrerep,escritura,fechaesc,nombrenot,numnot,lugar,regcomer,prove_lg,prove_edi,prove_ter," +
               "banco_lg,banco_edi,banco_ter,ctabanco_l,ctabanco_e,ctabanco_t,cont_lg,cont_edi,cont_ter,cta_lg,cta_edi,cta_ter, " +
               "pago,imss,creden,fiscal,ctaiva,cta1a,cta2a,cta3a,email1,email2,email3,mailcontra,mailcomple,especi,cont1,cont2,cont3,cont4,cont5,cont6 " +
               " from dbo.provs where proveedor < '" + proveedor.Text + "' order by proveedor desc ", con);
            SqlDataReader cursorleido = cursor.ExecuteReader();
            while (cursorleido.Read())
            {
                proveedor.Text = Convert.ToString(cursorleido["proveedor"]);
                tipo.Text = Convert.ToString(cursorleido["tipo"]);
                razon.Text = Convert.ToString(cursorleido["razon"]);
                direc1.Text = Convert.ToString(cursorleido["direc1"]);
                direc2.Text = Convert.ToString(cursorleido["direc2"]);
                direc3.Text = Convert.ToString(cursorleido["direc3"]);
                rfc.Text = Convert.ToString(cursorleido["rfc"]);
                porcmas.Text = Convert.ToString(cursorleido["porcmas"]);
                transf.Text = Convert.ToString(cursorleido["transf"]);
                ext.Text = Convert.ToString(cursorleido["ext"]);
                atencion.Text = Convert.ToString(cursorleido["atencion"]);
                tel1.Text = Convert.ToString(cursorleido["tel1"]);
                tel2.Text = Convert.ToString(cursorleido["tel2"]);
                email.Text = Convert.ToString(cursorleido["email"]);
                web.Text = Convert.ToString(cursorleido["web"]);
                reqent.Text = Convert.ToString(cursorleido["reqent"]);
                reqord.Text = Convert.ToString(cursorleido["reqord"]);
                polizas.Checked = Convert.ToBoolean(cursorleido["polizas"]);
                ultorden.Text = Convert.ToString(cursorleido["ultorden"]);
                nombrerep.Text = Convert.ToString(cursorleido["nombrerep"]);
                escritura.Text = Convert.ToString(cursorleido["escritura"]);
                fechaesc.Text = Convert.ToString(cursorleido["fechaesc"]);
                nombrenot.Text = Convert.ToString(cursorleido["nombrenot"]);
                numnot.Text = Convert.ToString(cursorleido["numnot"]);
                lugar.Text = Convert.ToString(cursorleido["lugar"]);
                regcomer.Text = Convert.ToString(cursorleido["regcomer"]);
                prove_lg.Text = Convert.ToString(cursorleido["prove_lg"]);
                prove_edi.Text = Convert.ToString(cursorleido["prove_edi"]);
                prove_ter.Text = Convert.ToString(cursorleido["prove_ter"]);
                banco_lg.Text = Convert.ToString(cursorleido["banco_lg"]);
                banco_edi.Text = Convert.ToString(cursorleido["banco_edi"]);
                banco_ter.Text = Convert.ToString(cursorleido["banco_ter"]);
                ctabanco_l.Text = Convert.ToString(cursorleido["ctabanco_l"]);
                ctabanco_e.Text = Convert.ToString(cursorleido["ctabanco_e"]);
                ctabanco_t.Text = Convert.ToString(cursorleido["ctabanco_t"]);
                cont_lg.Text = Convert.ToString(cursorleido["cont_lg"]);
                cont_edi.Text = Convert.ToString(cursorleido["cont_edi"]);
                cont_ter.Text = Convert.ToString(cursorleido["cont_ter"]);
                cta_lg.Text = Convert.ToString(cursorleido["cta_lg"]);
                cta_edi.Text = Convert.ToString(cursorleido["cta_edi"]);
                cta_ter.Text = Convert.ToString(cursorleido["cta_ter"]);
                pago.Text = Convert.ToString(cursorleido["pago"]);
                if (pago.Text == "1") { rb90.Checked = true; };
                if (pago.Text == "2") { rb60.Checked = true; };
                if (pago.Text == "3") { rb45.Checked = true; };
                if (pago.Text == "4") { rb30.Checked = true; };
                if (pago.Text == "5") { rb15.Checked = true; };
                if (pago.Text == "6") { rb7.Checked = true; };
                if (pago.Text == "7") { rbContado.Checked = true; };
                if (pago.Text == "8") { rbOtro.Checked = true; };
                cont1.Checked = Convert.ToBoolean(cursorleido["cont1"]);
                cont2.Checked = Convert.ToBoolean(cursorleido["cont2"]);
                cont3.Checked = Convert.ToBoolean(cursorleido["cont3"]);
                cont4.Checked = Convert.ToBoolean(cursorleido["cont4"]);
                cont5.Checked = Convert.ToBoolean(cursorleido["cont5"]);
                cont6.Checked = Convert.ToBoolean(cursorleido["cont6"]);
                imss.Text = Convert.ToString(cursorleido["imss"]);
                creden.Text = Convert.ToString(cursorleido["creden"]);
                fiscal.Text = Convert.ToString(cursorleido["fiscal"]);
                ctaiva.Text = Convert.ToString(cursorleido["ctaiva"]);
                cta1a.Text = Convert.ToString(cursorleido["cta1a"]);
                cta2a.Text = Convert.ToString(cursorleido["cta2a"]);
                cta3a.Text = Convert.ToString(cursorleido["cta3a"]);
                email1.Text = Convert.ToString(cursorleido["email1"]);
                email2.Text = Convert.ToString(cursorleido["email2"]);
                email3.Text = Convert.ToString(cursorleido["email3"]);
                mailcontra.Text = Convert.ToString(cursorleido["mailcontra"]);
                mailcomple.Text = Convert.ToString(cursorleido["mailcomple"]);
                especi.Text = Convert.ToString(cursorleido["especi"]);
            }
            con.Close();
            this.Show();
            razon.Focus();
        }

        private void btsiquiente_Click(object sender, EventArgs e)
        {
            con.Open();
            //   proveedor.Text = "";
            tipo.Text = "";
            razon.Text = "";
            direc1.Text = "";
            direc2.Text = "";
            direc3.Text = "";
            rfc.Text = "";
            porcmas.Text = "";
            transf.Text = "";
            ext.Text = "";
            atencion.Text = "";
            tel1.Text = "";
            tel2.Text = "";
            email.Text = "";
            web.Text = "";
            reqent.Text = "";
            reqord.Text = "";
            polizas.Checked = false;
            cont1.Checked = false;
            cont2.Checked = false;
            cont3.Checked = false;
            cont4.Checked = false;
            cont5.Checked = false;
            cont6.Checked = false;
            ultorden.Text = "";
            nombrerep.Text = "";
            escritura.Text = "";
            fechaesc.Text = "";
            nombrenot.Text = "";
            numnot.Text = "";
            lugar.Text = "";
            regcomer.Text = "";
            ultorden.Text = "";
            prove_lg.Text = "";
            prove_edi.Text = "";
            prove_ter.Text = "";
            banco_lg.Text = "";
            banco_edi.Text = "";
            banco_ter.Text = "";
            ctabanco_l.Text = "";
            ctabanco_e.Text = "";
            ctabanco_t.Text = "";
            cont_lg.Text = "";
            cont_edi.Text = "";
            cont_ter.Text = "";
            cta_lg.Text = "";
            cta_edi.Text = "";
            cta_ter.Text = "";
            pago.Text = "";
            rb90.Checked = false;
            rb60.Checked = false;
            rb45.Checked = false;
            rb30.Checked = false;
            rb15.Checked = false;
            rb7.Checked = false;
            rbContado.Checked = false;
            rbOtro.Checked = false;
            imss.Text = "";
            creden.Text = "";
            fiscal.Text = "";
            ctaiva.Text = "";
            cta1a.Text = "";
            cta2a.Text = "";
            cta3a.Text = "";
            email1.Text = "";
            email2.Text = "";
            email3.Text = "";
            mailcontra.Text = "";
            mailcomple.Text = "";
            especi.Text = "";

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select top 1 proveedor,tipo,razon,direc1,rfc " +
               "  from dbo.provs where proveedor > '" + proveedor.Text + "' order by proveedor ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DGproveedores.DataSource = dt;
            int cuenta = DGproveedores.RowCount;

            DGproveedores.RowHeadersVisible = false;

            DGproveedores.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DGproveedores.Columns[0].Width = 95;
            DGproveedores.Columns[0].DefaultCellStyle.BackColor = Color.PowderBlue;
            DGproveedores.Columns[0].HeaderText = "PROVE";
            DGproveedores.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGproveedores.Columns[1].Width = 40;
            DGproveedores.Columns[1].DefaultCellStyle.BackColor = Color.Beige;
            DGproveedores.Columns[1].HeaderText = "TIPO";
            DGproveedores.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGproveedores.Columns[2].Width = 200;
            DGproveedores.Columns[2].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGproveedores.Columns[2].HeaderText = "RAZON SOCIAL";
            DGproveedores.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGproveedores.Columns[3].Width = 185;
            DGproveedores.Columns[3].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGproveedores.Columns[3].HeaderText = "DIRECCION";
            DGproveedores.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGproveedores.Columns[4].Width = 80;
            DGproveedores.Columns[4].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGproveedores.Columns[4].HeaderText = "RFC";
            DGproveedores.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;


            SqlCommand cursor = new SqlCommand("select top 1 proveedor,tipo,razon,direc1,direc2,direc3,rfc,porcmas,transf,ext,atencion,tel1,tel2,email,web," +
               "reqent,reqord,polizas,ultorden,nombrerep,escritura,fechaesc,nombrenot,numnot,lugar,regcomer,prove_lg,prove_edi,prove_ter," +
               "banco_lg,banco_edi,banco_ter,ctabanco_l,ctabanco_e,ctabanco_t,cont_lg,cont_edi,cont_ter,cta_lg,cta_edi,cta_ter, " +
               "pago,imss,creden,fiscal,ctaiva,cta1a,cta2a,cta3a,email1,email2,email3,mailcontra,mailcomple,especi,cont1,cont2,cont3,cont4,cont5,cont6 " +
               " from dbo.provs where proveedor > '" + proveedor.Text + "' order by proveedor ", con);
            SqlDataReader cursorleido = cursor.ExecuteReader();
            while (cursorleido.Read())
            {
                proveedor.Text = Convert.ToString(cursorleido["proveedor"]);
                tipo.Text = Convert.ToString(cursorleido["tipo"]);
                razon.Text = Convert.ToString(cursorleido["razon"]);
                direc1.Text = Convert.ToString(cursorleido["direc1"]);
                direc2.Text = Convert.ToString(cursorleido["direc2"]);
                direc3.Text = Convert.ToString(cursorleido["direc3"]);
                rfc.Text = Convert.ToString(cursorleido["rfc"]);
                porcmas.Text = Convert.ToString(cursorleido["porcmas"]);
                transf.Text = Convert.ToString(cursorleido["transf"]);
                ext.Text = Convert.ToString(cursorleido["ext"]);
                atencion.Text = Convert.ToString(cursorleido["atencion"]);
                tel1.Text = Convert.ToString(cursorleido["tel1"]);
                tel2.Text = Convert.ToString(cursorleido["tel2"]);
                email.Text = Convert.ToString(cursorleido["email"]);
                web.Text = Convert.ToString(cursorleido["web"]);
                reqent.Text = Convert.ToString(cursorleido["reqent"]);
                reqord.Text = Convert.ToString(cursorleido["reqord"]);
                polizas.Checked = Convert.ToBoolean(cursorleido["polizas"]);
                ultorden.Text = Convert.ToString(cursorleido["ultorden"]);
                nombrerep.Text = Convert.ToString(cursorleido["nombrerep"]);
                escritura.Text = Convert.ToString(cursorleido["escritura"]);
                fechaesc.Text = Convert.ToString(cursorleido["fechaesc"]);
                nombrenot.Text = Convert.ToString(cursorleido["nombrenot"]);
                numnot.Text = Convert.ToString(cursorleido["numnot"]);
                lugar.Text = Convert.ToString(cursorleido["lugar"]);
                regcomer.Text = Convert.ToString(cursorleido["regcomer"]);
                prove_lg.Text = Convert.ToString(cursorleido["prove_lg"]);
                prove_edi.Text = Convert.ToString(cursorleido["prove_edi"]);
                prove_ter.Text = Convert.ToString(cursorleido["prove_ter"]);
                banco_lg.Text = Convert.ToString(cursorleido["banco_lg"]);
                banco_edi.Text = Convert.ToString(cursorleido["banco_edi"]);
                banco_ter.Text = Convert.ToString(cursorleido["banco_ter"]);
                ctabanco_l.Text = Convert.ToString(cursorleido["ctabanco_l"]);
                ctabanco_e.Text = Convert.ToString(cursorleido["ctabanco_e"]);
                ctabanco_t.Text = Convert.ToString(cursorleido["ctabanco_t"]);
                cont_lg.Text = Convert.ToString(cursorleido["cont_lg"]);
                cont_edi.Text = Convert.ToString(cursorleido["cont_edi"]);
                cont_ter.Text = Convert.ToString(cursorleido["cont_ter"]);
                cta_lg.Text = Convert.ToString(cursorleido["cta_lg"]);
                cta_edi.Text = Convert.ToString(cursorleido["cta_edi"]);
                cta_ter.Text = Convert.ToString(cursorleido["cta_ter"]);
                pago.Text = Convert.ToString(cursorleido["pago"]);
                if (pago.Text == "1") { rb90.Checked = true; };
                if (pago.Text == "2") { rb60.Checked = true; };
                if (pago.Text == "3") { rb45.Checked = true; };
                if (pago.Text == "4") { rb30.Checked = true; };
                if (pago.Text == "5") { rb15.Checked = true; };
                if (pago.Text == "6") { rb7.Checked = true; };
                if (pago.Text == "7") { rbContado.Checked = true; };
                if (pago.Text == "8") { rbOtro.Checked = true; };
                cont1.Checked = Convert.ToBoolean(cursorleido["cont1"]);
                cont2.Checked = Convert.ToBoolean(cursorleido["cont2"]);
                cont3.Checked = Convert.ToBoolean(cursorleido["cont3"]);
                cont4.Checked = Convert.ToBoolean(cursorleido["cont4"]);
                cont5.Checked = Convert.ToBoolean(cursorleido["cont5"]);
                cont6.Checked = Convert.ToBoolean(cursorleido["cont6"]);
                imss.Text = Convert.ToString(cursorleido["imss"]);
                creden.Text = Convert.ToString(cursorleido["creden"]);
                fiscal.Text = Convert.ToString(cursorleido["fiscal"]);
                ctaiva.Text = Convert.ToString(cursorleido["ctaiva"]);
                cta1a.Text = Convert.ToString(cursorleido["cta1a"]);
                cta2a.Text = Convert.ToString(cursorleido["cta2a"]);
                cta3a.Text = Convert.ToString(cursorleido["cta3a"]);
                email1.Text = Convert.ToString(cursorleido["email1"]);
                email2.Text = Convert.ToString(cursorleido["email2"]);
                email3.Text = Convert.ToString(cursorleido["email3"]);
                mailcontra.Text = Convert.ToString(cursorleido["mailcontra"]);
                mailcomple.Text = Convert.ToString(cursorleido["mailcomple"]);
                especi.Text = Convert.ToString(cursorleido["especi"]);
            }
            con.Close();
            this.Show();
            razon.Focus();
        }

        private void provecons_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                con.Close();
                con.Open();
                proveedor.Text = "";
                tipo.Text = "";
                razon.Text = "";
                direc1.Text = "";
                direc2.Text = "";
                direc3.Text = "";
                rfc.Text = "";
                porcmas.Text = "";
                transf.Text = "";
                ext.Text = "";
                atencion.Text = "";
                tel1.Text = "";
                tel2.Text = "";
                email.Text = "";
                web.Text = "";
                reqent.Text = "";
                reqord.Text = "";
                polizas.Checked = false;
                cont1.Checked = false;
                cont2.Checked = false;
                cont3.Checked = false;
                cont4.Checked = false;
                cont5.Checked = false;
                cont6.Checked = false;
                ultorden.Text = "";
                nombrerep.Text = "";
                escritura.Text = "";
                fechaesc.Text = "";
                nombrenot.Text = "";
                numnot.Text = "";
                lugar.Text = "";
                regcomer.Text = "";
                ultorden.Text = "";
                prove_lg.Text = "";
                prove_edi.Text = "";
                prove_ter.Text = "";
                banco_lg.Text = "";
                banco_edi.Text = "";
                banco_ter.Text = "";
                ctabanco_l.Text = "";
                ctabanco_e.Text = "";
                ctabanco_t.Text = "";
                cont_lg.Text = "";
                cont_edi.Text = "";
                cont_ter.Text = "";
                cta_lg.Text = "";
                cta_edi.Text = "";
                cta_ter.Text = "";
                pago.Text = "";
                rb90.Checked = false;
                rb60.Checked = false;
                rb45.Checked = false;
                rb30.Checked = false;
                rb15.Checked = false;
                rb7.Checked = false;
                rbContado.Checked = false;
                rbOtro.Checked = false;
                imss.Text = "";
                creden.Text = "";
                fiscal.Text = "";
                ctaiva.Text = "";
                cta1a.Text = "";
                cta2a.Text = "";
                cta3a.Text = "";
                email1.Text = "";
                email2.Text = "";
                email3.Text = "";
                mailcontra.Text = "";
                mailcomple.Text = "";
                especi.Text = "";

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select proveedor,tipo,razon,direc1,rfc " +
                    " from dbo.provs where proveedor like '" + provecons.Text + "%' ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                DGproveedores.DataSource = dt;
                int cuenta = DGproveedores.RowCount;

                DGproveedores.RowHeadersVisible = false;

                DGproveedores.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                DGproveedores.Columns[0].Width = 95;
                DGproveedores.Columns[0].DefaultCellStyle.BackColor = Color.PowderBlue;
                DGproveedores.Columns[0].HeaderText = "PROVE";
                DGproveedores.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                DGproveedores.Columns[1].Width = 40;
                DGproveedores.Columns[1].DefaultCellStyle.BackColor = Color.Beige;
                DGproveedores.Columns[1].HeaderText = "TIPO";
                DGproveedores.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                DGproveedores.Columns[2].Width = 200;
                DGproveedores.Columns[2].DefaultCellStyle.BackColor = Color.PapayaWhip;
                DGproveedores.Columns[2].HeaderText = "RAZON SOCIAL";
                DGproveedores.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                DGproveedores.Columns[3].Width = 185;
                DGproveedores.Columns[3].DefaultCellStyle.BackColor = Color.PapayaWhip;
                DGproveedores.Columns[3].HeaderText = "DIRECCION";
                DGproveedores.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                DGproveedores.Columns[4].Width = 80;
                DGproveedores.Columns[4].DefaultCellStyle.BackColor = Color.PapayaWhip;
                DGproveedores.Columns[4].HeaderText = "RFC";
                DGproveedores.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                SqlCommand cursor = new SqlCommand("select proveedor,tipo,razon,direc1,direc2,direc3,rfc,porcmas,transf,ext,atencion,tel1,tel2,email,web," +
                   "reqent,reqord,polizas,ultorden,nombrerep,escritura,fechaesc,nombrenot,numnot,lugar,regcomer,prove_lg,prove_edi,prove_ter," +
                   "banco_lg,banco_edi,banco_ter,ctabanco_l,ctabanco_e,ctabanco_t,cont_lg,cont_edi,cont_ter,cta_lg,cta_edi,cta_ter, " +
                   "pago,imss,creden,fiscal,ctaiva,cta1a,cta2a,cta3a,email1,email2,email3,mailcontra,mailcomple,especi,cont1,cont2,cont3,cont4,cont5,cont6 " +
                   " from dbo.provs where proveedor = '" + provecons.Text + "' ", con);
                SqlDataReader cursorleido = cursor.ExecuteReader();
                while (cursorleido.Read())
                {
                    if (!(cursorleido.HasRows))
                    {
                        MessageBox.Show("Ese proveedor no existe...!");
                    }
                    else
                    {
                        proveedor.Text = Convert.ToString(cursorleido["proveedor"]);
                        tipo.Text = Convert.ToString(cursorleido["tipo"]);
                        razon.Text = Convert.ToString(cursorleido["razon"]);
                        direc1.Text = Convert.ToString(cursorleido["direc1"]);
                        direc2.Text = Convert.ToString(cursorleido["direc2"]);
                        direc3.Text = Convert.ToString(cursorleido["direc3"]);
                        rfc.Text = Convert.ToString(cursorleido["rfc"]);
                        porcmas.Text = Convert.ToString(cursorleido["porcmas"]);
                        transf.Text = Convert.ToString(cursorleido["transf"]);
                        ext.Text = Convert.ToString(cursorleido["ext"]);
                        atencion.Text = Convert.ToString(cursorleido["atencion"]);
                        tel1.Text = Convert.ToString(cursorleido["tel1"]);
                        tel2.Text = Convert.ToString(cursorleido["tel2"]);
                        email.Text = Convert.ToString(cursorleido["email"]);
                        web.Text = Convert.ToString(cursorleido["web"]);
                        reqent.Text = Convert.ToString(cursorleido["reqent"]);
                        reqord.Text = Convert.ToString(cursorleido["reqord"]);
                        polizas.Checked = Convert.ToBoolean(cursorleido["polizas"]);
                        ultorden.Text = Convert.ToString(cursorleido["ultorden"]);
                        nombrerep.Text = Convert.ToString(cursorleido["nombrerep"]);
                        escritura.Text = Convert.ToString(cursorleido["escritura"]);
                        fechaesc.Text = Convert.ToString(cursorleido["fechaesc"]);
                        nombrenot.Text = Convert.ToString(cursorleido["nombrenot"]);
                        numnot.Text = Convert.ToString(cursorleido["numnot"]);
                        lugar.Text = Convert.ToString(cursorleido["lugar"]);
                        regcomer.Text = Convert.ToString(cursorleido["regcomer"]);
                        prove_lg.Text = Convert.ToString(cursorleido["prove_lg"]);
                        prove_edi.Text = Convert.ToString(cursorleido["prove_edi"]);
                        prove_ter.Text = Convert.ToString(cursorleido["prove_ter"]);
                        banco_lg.Text = Convert.ToString(cursorleido["banco_lg"]);
                        banco_edi.Text = Convert.ToString(cursorleido["banco_edi"]);
                        banco_ter.Text = Convert.ToString(cursorleido["banco_ter"]);
                        ctabanco_l.Text = Convert.ToString(cursorleido["ctabanco_l"]);
                        ctabanco_e.Text = Convert.ToString(cursorleido["ctabanco_e"]);
                        ctabanco_t.Text = Convert.ToString(cursorleido["ctabanco_t"]);
                        cont_lg.Text = Convert.ToString(cursorleido["cont_lg"]);
                        cont_edi.Text = Convert.ToString(cursorleido["cont_edi"]);
                        cont_ter.Text = Convert.ToString(cursorleido["cont_ter"]);
                        cta_lg.Text = Convert.ToString(cursorleido["cta_lg"]);
                        cta_edi.Text = Convert.ToString(cursorleido["cta_edi"]);
                        cta_ter.Text = Convert.ToString(cursorleido["cta_ter"]);
                        pago.Text = Convert.ToString(cursorleido["pago"]);
                        if (pago.Text == "1") { rb90.Checked = true; };
                        if (pago.Text == "2") { rb60.Checked = true; };
                        if (pago.Text == "3") { rb45.Checked = true; };
                        if (pago.Text == "4") { rb30.Checked = true; };
                        if (pago.Text == "5") { rb15.Checked = true; };
                        if (pago.Text == "6") { rb7.Checked = true; };
                        if (pago.Text == "7") { rbContado.Checked = true; };
                        if (pago.Text == "8") { rbOtro.Checked = true; };
                        cont1.Checked = Convert.ToBoolean(cursorleido["cont1"]);
                        cont2.Checked = Convert.ToBoolean(cursorleido["cont2"]);
                        cont3.Checked = Convert.ToBoolean(cursorleido["cont3"]);
                        cont4.Checked = Convert.ToBoolean(cursorleido["cont4"]);
                        cont5.Checked = Convert.ToBoolean(cursorleido["cont5"]);
                        cont6.Checked = Convert.ToBoolean(cursorleido["cont6"]);
                        imss.Text = Convert.ToString(cursorleido["imss"]);
                        creden.Text = Convert.ToString(cursorleido["creden"]);
                        fiscal.Text = Convert.ToString(cursorleido["fiscal"]);
                        ctaiva.Text = Convert.ToString(cursorleido["ctaiva"]);
                        cta1a.Text = Convert.ToString(cursorleido["cta1a"]);
                        cta2a.Text = Convert.ToString(cursorleido["cta2a"]);
                        cta3a.Text = Convert.ToString(cursorleido["cta3a"]);
                        email1.Text = Convert.ToString(cursorleido["email1"]);
                        email2.Text = Convert.ToString(cursorleido["email2"]);
                        email3.Text = Convert.ToString(cursorleido["email3"]);
                        mailcontra.Text = Convert.ToString(cursorleido["mailcontra"]);
                        mailcomple.Text = Convert.ToString(cursorleido["mailcomple"]);
                        especi.Text = Convert.ToString(cursorleido["especi"]);
                    }
                }
            }
            this.Show();
            con.Close();
        }

        private void razoncons_KeyPress(object sender, KeyPressEventArgs e)
        {
            //     if (razoncons.Text == "" || razoncons.Text == " ")
            //     {
            //         MessageBox.Show("Falta poner la Razón Social del proveedor...!");
            //     }
            //     else
            //     {
            con.Close();
            con.Open();
            proveedor.Text = "";
            tipo.Text = "";
            razon.Text = "";
            direc1.Text = "";
            direc2.Text = "";
            direc3.Text = "";
            rfc.Text = "";
            porcmas.Text = "";
            transf.Text = "";
            ext.Text = "";
            atencion.Text = "";
            tel1.Text = "";
            tel2.Text = "";
            email.Text = "";
            web.Text = "";
            reqent.Text = "";
            reqord.Text = "";
            polizas.Checked = false;
            cont1.Checked = false;
            cont2.Checked = false;
            cont3.Checked = false;
            cont4.Checked = false;
            cont5.Checked = false;
            cont6.Checked = false;
            ultorden.Text = "";
            nombrerep.Text = "";
            escritura.Text = "";
            fechaesc.Text = "";
            nombrenot.Text = "";
            numnot.Text = "";
            lugar.Text = "";
            regcomer.Text = "";
            ultorden.Text = "";
            prove_lg.Text = "";
            prove_edi.Text = "";
            prove_ter.Text = "";
            banco_lg.Text = "";
            banco_edi.Text = "";
            banco_ter.Text = "";
            ctabanco_l.Text = "";
            ctabanco_e.Text = "";
            ctabanco_t.Text = "";
            cont_lg.Text = "";
            cont_edi.Text = "";
            cont_ter.Text = "";
            cta_lg.Text = "";
            cta_edi.Text = "";
            cta_ter.Text = "";
            pago.Text = "";
            rb90.Checked = false;
            rb60.Checked = false;
            rb45.Checked = false;
            rb30.Checked = false;
            rb15.Checked = false;
            rb7.Checked = false;
            rbContado.Checked = false;
            rbOtro.Checked = false;
            imss.Text = "";
            creden.Text = "";
            fiscal.Text = "";
            ctaiva.Text = "";
            cta1a.Text = "";
            cta2a.Text = "";
            cta3a.Text = "";
            email1.Text = "";
            email2.Text = "";
            email3.Text = "";
            mailcontra.Text = "";
            mailcomple.Text = "";
            especi.Text = "";

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select proveedor,tipo,razon,direc1,rfc " +
                " from dbo.provs where razon like '" + razoncons.Text + "%' ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DGproveedores.DataSource = dt;
            int cuenta = DGproveedores.RowCount;

            DGproveedores.RowHeadersVisible = false;

            DGproveedores.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DGproveedores.Columns[0].Width = 95;
            DGproveedores.Columns[0].DefaultCellStyle.BackColor = Color.PowderBlue;
            DGproveedores.Columns[0].HeaderText = "PROVE";
            DGproveedores.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGproveedores.Columns[1].Width = 40;
            DGproveedores.Columns[1].DefaultCellStyle.BackColor = Color.Beige;
            DGproveedores.Columns[1].HeaderText = "TIPO";
            DGproveedores.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGproveedores.Columns[2].Width = 200;
            DGproveedores.Columns[2].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGproveedores.Columns[2].HeaderText = "RAZON SOCIAL";
            DGproveedores.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGproveedores.Columns[3].Width = 185;
            DGproveedores.Columns[3].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGproveedores.Columns[3].HeaderText = "DIRECCION";
            DGproveedores.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGproveedores.Columns[4].Width = 80;
            DGproveedores.Columns[4].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGproveedores.Columns[4].HeaderText = "RFC";
            DGproveedores.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;


            SqlCommand cursor = new SqlCommand("select proveedor,tipo,razon,direc1,direc2,direc3,rfc,porcmas,transf,ext,atencion,tel1,tel2,email,web," +
                   "reqent,reqord,polizas,ultorden,nombrerep,escritura,fechaesc,nombrenot,numnot,lugar,regcomer,prove_lg,prove_edi,prove_ter," +
                   "banco_lg,banco_edi,banco_ter,ctabanco_l,ctabanco_e,ctabanco_t,cont_lg,cont_edi,cont_ter,cta_lg,cta_edi,cta_ter, " +
                   "pago,imss,creden,fiscal,ctaiva,cta1a,cta2a,cta3a,email1,email2,email3,mailcontra,mailcomple,especi,cont1,cont2,cont3,cont4,cont5,cont6 " +
                   " from dbo.provs where razon = '" + razoncons.Text + "' order by razon", con);
            SqlDataReader cursorleido = cursor.ExecuteReader();
            while (cursorleido.Read())
            {
                proveedor.Text = Convert.ToString(cursorleido["proveedor"]);
                tipo.Text = Convert.ToString(cursorleido["tipo"]);
                razon.Text = Convert.ToString(cursorleido["razon"]);
                direc1.Text = Convert.ToString(cursorleido["direc1"]);
                direc2.Text = Convert.ToString(cursorleido["direc2"]);
                direc3.Text = Convert.ToString(cursorleido["direc3"]);
                rfc.Text = Convert.ToString(cursorleido["rfc"]);
                porcmas.Text = Convert.ToString(cursorleido["porcmas"]);
                transf.Text = Convert.ToString(cursorleido["transf"]);
                ext.Text = Convert.ToString(cursorleido["ext"]);
                atencion.Text = Convert.ToString(cursorleido["atencion"]);
                tel1.Text = Convert.ToString(cursorleido["tel1"]);
                tel2.Text = Convert.ToString(cursorleido["tel2"]);
                email.Text = Convert.ToString(cursorleido["email"]);
                web.Text = Convert.ToString(cursorleido["web"]);
                reqent.Text = Convert.ToString(cursorleido["reqent"]);
                reqord.Text = Convert.ToString(cursorleido["reqord"]);
                polizas.Checked = Convert.ToBoolean(cursorleido["polizas"]);
                ultorden.Text = Convert.ToString(cursorleido["ultorden"]);
                nombrerep.Text = Convert.ToString(cursorleido["nombrerep"]);
                escritura.Text = Convert.ToString(cursorleido["escritura"]);
                fechaesc.Text = Convert.ToString(cursorleido["fechaesc"]);
                nombrenot.Text = Convert.ToString(cursorleido["nombrenot"]);
                numnot.Text = Convert.ToString(cursorleido["numnot"]);
                lugar.Text = Convert.ToString(cursorleido["lugar"]);
                regcomer.Text = Convert.ToString(cursorleido["regcomer"]);
                prove_lg.Text = Convert.ToString(cursorleido["prove_lg"]);
                prove_edi.Text = Convert.ToString(cursorleido["prove_edi"]);
                prove_ter.Text = Convert.ToString(cursorleido["prove_ter"]);
                banco_lg.Text = Convert.ToString(cursorleido["banco_lg"]);
                banco_edi.Text = Convert.ToString(cursorleido["banco_edi"]);
                banco_ter.Text = Convert.ToString(cursorleido["banco_ter"]);
                ctabanco_l.Text = Convert.ToString(cursorleido["ctabanco_l"]);
                ctabanco_e.Text = Convert.ToString(cursorleido["ctabanco_e"]);
                ctabanco_t.Text = Convert.ToString(cursorleido["ctabanco_t"]);
                cont_lg.Text = Convert.ToString(cursorleido["cont_lg"]);
                cont_edi.Text = Convert.ToString(cursorleido["cont_edi"]);
                cont_ter.Text = Convert.ToString(cursorleido["cont_ter"]);
                cta_lg.Text = Convert.ToString(cursorleido["cta_lg"]);
                cta_edi.Text = Convert.ToString(cursorleido["cta_edi"]);
                cta_ter.Text = Convert.ToString(cursorleido["cta_ter"]);
                pago.Text = Convert.ToString(cursorleido["pago"]);
                if (pago.Text == "1") { rb90.Checked = true; };
                if (pago.Text == "2") { rb60.Checked = true; };
                if (pago.Text == "3") { rb45.Checked = true; };
                if (pago.Text == "4") { rb30.Checked = true; };
                if (pago.Text == "5") { rb15.Checked = true; };
                if (pago.Text == "6") { rb7.Checked = true; };
                if (pago.Text == "7") { rbContado.Checked = true; };
                if (pago.Text == "8") { rbOtro.Checked = true; };
                cont1.Checked = Convert.ToBoolean(cursorleido["cont1"]);
                cont2.Checked = Convert.ToBoolean(cursorleido["cont2"]);
                cont3.Checked = Convert.ToBoolean(cursorleido["cont3"]);
                cont4.Checked = Convert.ToBoolean(cursorleido["cont4"]);
                cont5.Checked = Convert.ToBoolean(cursorleido["cont5"]);
                cont6.Checked = Convert.ToBoolean(cursorleido["cont6"]);
                imss.Text = Convert.ToString(cursorleido["imss"]);
                creden.Text = Convert.ToString(cursorleido["creden"]);
                fiscal.Text = Convert.ToString(cursorleido["fiscal"]);
                ctaiva.Text = Convert.ToString(cursorleido["ctaiva"]);
                cta1a.Text = Convert.ToString(cursorleido["cta1a"]);
                cta2a.Text = Convert.ToString(cursorleido["cta2a"]);
                cta3a.Text = Convert.ToString(cursorleido["cta3a"]);
                email1.Text = Convert.ToString(cursorleido["email1"]);
                email2.Text = Convert.ToString(cursorleido["email2"]);
                email3.Text = Convert.ToString(cursorleido["email3"]);
                mailcontra.Text = Convert.ToString(cursorleido["mailcontra"]);
                mailcomple.Text = Convert.ToString(cursorleido["mailcomple"]);
                especi.Text = Convert.ToString(cursorleido["especi"]);
            }
            this.Show();
            con.Close();
        }

        private void btlimpiar_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            proveedor.Text = "";
            tipo.Text = "";
            razon.Text = "";
            direc1.Text = "";
            direc2.Text = "";
            direc3.Text = "";
            rfc.Text = "";
            porcmas.Text = "";
            transf.Text = "";
            ext.Text = "";
            atencion.Text = "";
            tel1.Text = "";
            tel2.Text = "";
            email.Text = "";
            web.Text = "";
            reqent.Text = "";
            reqord.Text = "";
            polizas.Checked = false;
            cont1.Checked = false;
            cont2.Checked = false;
            cont3.Checked = false;
            cont4.Checked = false;
            cont5.Checked = false;
            cont6.Checked = false;
            ultorden.Text = "";
            nombrerep.Text = "";
            escritura.Text = "";
            fechaesc.Text = "";
            nombrenot.Text = "";
            numnot.Text = "";
            lugar.Text = "";
            regcomer.Text = "";
            ultorden.Text = "";
            prove_lg.Text = "";
            prove_edi.Text = "";
            prove_ter.Text = "";
            banco_lg.Text = "";
            banco_edi.Text = "";
            banco_ter.Text = "";
            ctabanco_l.Text = "";
            ctabanco_e.Text = "";
            ctabanco_t.Text = "";
            cont_lg.Text = "";
            cont_edi.Text = "";
            cont_ter.Text = "";
            cta_lg.Text = "";
            cta_edi.Text = "";
            cta_ter.Text = "";
            pago.Text = "";
            rb90.Checked = false;
            rb60.Checked = false;
            rb45.Checked = false;
            rb30.Checked = false;
            rb15.Checked = false;
            rb7.Checked = false;
            rbContado.Checked = false;
            rbOtro.Checked = false;
            imss.Text = "";
            creden.Text = "";
            fiscal.Text = "";
            ctaiva.Text = "";
            cta1a.Text = "";
            cta2a.Text = "";
            cta3a.Text = "";
            email1.Text = "";
            email2.Text = "";
            email3.Text = "";
            mailcontra.Text = "";
            mailcomple.Text = "";
            especi.Text = "";

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select proveedor,tipo,razon,direc1,rfc " +
                " from dbo.provs where proveedor = '0000' ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DGproveedores.DataSource = dt;
            int cuenta = DGproveedores.RowCount;

            DGproveedores.RowHeadersVisible = false;

            DGproveedores.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DGproveedores.Columns[0].Width = 95;
            DGproveedores.Columns[0].DefaultCellStyle.BackColor = Color.PowderBlue;
            DGproveedores.Columns[0].HeaderText = "PROVE";
            DGproveedores.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGproveedores.Columns[1].Width = 40;
            DGproveedores.Columns[1].DefaultCellStyle.BackColor = Color.Beige;
            DGproveedores.Columns[1].HeaderText = "TIPO";
            DGproveedores.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGproveedores.Columns[2].Width = 200;
            DGproveedores.Columns[2].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGproveedores.Columns[2].HeaderText = "RAZON SOCIAL";
            DGproveedores.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGproveedores.Columns[3].Width = 185;
            DGproveedores.Columns[3].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGproveedores.Columns[3].HeaderText = "DIRECCION";
            DGproveedores.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGproveedores.Columns[4].Width = 80;
            DGproveedores.Columns[4].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGproveedores.Columns[4].HeaderText = "RFC";
            DGproveedores.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            con.Close();
            this.Show();
            razon.Focus();
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            if (proveedor.Text != "")
            {
                con.Close();
                con.Open();
                SqlCommand cursor = new SqlCommand("select proveedor from dbo.provs where proveedor = '" + proveedor.Text + "' ", con);
                SqlDataReader cursorleido = cursor.ExecuteReader();
                if (cursorleido.Read())
                {
                    MessageBox.Show("El Proveedor: '" + proveedor.Text + "' ya existe..!", "Litografía Gil");
                    con.Close();
                }
                else
                {

                    con.Close();
                    con.Open();

                    int wpolizas = 0;
                    int wcont1 = 0;
                    int wcont2 = 0;
                    int wcont3 = 0;
                    int wcont4 = 0;
                    int wcont5 = 0;
                    int wcont6 = 0;

                    if (polizas.Checked)
                    { wpolizas = 'T'; }
                    else
                    { wpolizas = 'F'; };

                    wpolizas = 'F';

                    wcont1 = 'F';
                    wcont2 = 'F';
                    wcont3 = 'F';
                    wcont4 = 'F';
                    wcont5 = 'F';
                    wcont6 = 'F';

                    int wpago = 0;
                    if (rb90.Checked) { wpago = 1; }
                    if (rb60.Checked) { wpago = 2; }
                    if (rb45.Checked) { wpago = 3; }
                    if (rb30.Checked) { wpago = 4; }
                    if (rb15.Checked) { wpago = 5; }
                    if (rb7.Checked) { wpago = 6; }
                    if (rbContado.Checked) { wpago = 7; }
                    if (rbOtro.Checked) { wpago = 8; }


                    cmd.CommandText = "insert into dbo.provs (proveedor)" +
                        " values " +
                        " ('" + proveedor.Text + "' )";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "update dbo.provs set  " +
                    " razon      = '" + razon.Text + "',  " +
                    " direc1     = '" + direc1.Text + "',  " +
                    " pago       = '" + wpago + "',   " +
                    " polizas    = '" + wpolizas + "',  " +
                    " cont1      = '" + wcont1 + "',  " +
                    " cont2      = '" + wcont2 + "',  " +
                    " cont3      = '" + wcont3 + "',  " +
                    " cont4      = '" + wcont4 + "',  " +
                    " cont5      = '" + wcont5 + "',  " +
                    " cont6      = '" + wcont6 + "',  " +
                    " rfc        = '" + rfc.Text +
                    "' where  proveedor  = '" + proveedor.Text + "' ";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Proveedor creado...!", "Litografía Gil");
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Falta poner la Clave del proveedor...!");
            }

        }


        public void Ejecutar(string dato)
        {
            LBLcontra.Text = dato;
            txtcontrase.Text = dato;
        }


        private void btborra_Click(object sender, EventArgs e)
        {
            if (proveedor.Text == "")
            {
                MessageBox.Show("Falta poner la clave del proveedor...!");
            }
            else
            {
                // Checa contraseña:
                Fcontra Fcontra = new Fcontra();
                Fcontra.pasado += new Fcontra.pasar(Ejecutar);
                Fcontra.ShowDialog();
                if (txtcontrase.Text.ToUpper() == "BORRA" || txtcontrase.Text.ToUpper() == "SSS")
                {
                    con.Open();
                    cmd.CommandText = "delete from dbo.provs where proveedor = '" + proveedor.Text + "' ";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Proveedor: " + proveedor.Text + "  borrado...!", "Litografía Gil");
                    proveedor.Text = "";
                    tipo.Text = "";
                    razon.Text = "";
                    direc1.Text = "";
                    direc2.Text = "";
                    direc3.Text = "";
                    rfc.Text = "";
                    porcmas.Text = "";
                    transf.Text = "";
                    ext.Text = "";
                    atencion.Text = "";
                    tel1.Text = "";
                    tel2.Text = "";
                    email.Text = "";
                    web.Text = "";
                    reqent.Text = "";
                    reqord.Text = "";
                    polizas.Checked = false;
                    cont1.Checked = false;
                    cont2.Checked = false;
                    cont3.Checked = false;
                    cont4.Checked = false;
                    cont5.Checked = false;
                    cont6.Checked = false;
                    ultorden.Text = "";
                    nombrerep.Text = "";
                    escritura.Text = "";
                    fechaesc.Text = "";
                    nombrenot.Text = "";
                    numnot.Text = "";
                    lugar.Text = "";
                    regcomer.Text = "";
                    ultorden.Text = "";
                    prove_lg.Text = "";
                    prove_edi.Text = "";
                    prove_ter.Text = "";
                    banco_lg.Text = "";
                    banco_edi.Text = "";
                    banco_ter.Text = "";
                    ctabanco_l.Text = "";
                    ctabanco_e.Text = "";
                    ctabanco_t.Text = "";
                    cont_lg.Text = "";
                    cont_edi.Text = "";
                    cont_ter.Text = "";
                    cta_lg.Text = "";
                    cta_edi.Text = "";
                    cta_ter.Text = "";
                    pago.Text = "";
                    rb90.Checked = false;
                    rb60.Checked = false;
                    rb45.Checked = false;
                    rb30.Checked = false;
                    rb15.Checked = false;
                    rb7.Checked = false;
                    rbContado.Checked = false;
                    rbOtro.Checked = false;
                    imss.Text = "";
                    creden.Text = "";
                    fiscal.Text = "";
                    ctaiva.Text = "";
                    cta1a.Text = "";
                    cta2a.Text = "";
                    cta3a.Text = "";
                    email1.Text = "";
                    email2.Text = "";
                    email3.Text = "";
                    mailcontra.Text = "";
                    mailcomple.Text = "";
                    especi.Text = "";
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta...!");
                }

            }


        }

        private void btmodificar_Click(object sender, EventArgs e)
        {
            if (proveedor.Text == "")
            {
                MessageBox.Show("Falta poner la clave del proveedor...!");
            }
            else
            {

                // Checa contraseña:
                Fcontra Fcontra = new Fcontra();
                Fcontra.pasado += new Fcontra.pasar(Ejecutar);
                Fcontra.ShowDialog();
                if (txtcontrase.Text.ToUpper() == "MODI" || txtcontrase.Text.ToUpper() == "SSS")
                {
                    int wpolizas = 0;
                    int wcont1 = 0;
                    int wcont2 = 0;
                    int wcont3 = 0;
                    int wcont4 = 0;
                    int wcont5 = 0;
                    int wcont6 = 0;

                    if (polizas.Checked) { wpolizas = 'T'; }

                    if (cont1.Checked) { wcont1 = 'T'; }
                    if (cont2.Checked) { wcont2 = 'T'; }
                    if (cont3.Checked) { wcont3 = 'T'; }
                    if (cont4.Checked) { wcont4 = 'T'; }
                    if (cont5.Checked) { wcont5 = 'T'; }
                    if (cont6.Checked) { wcont6 = 'T'; }

                    int wpago = 0;
                    if (rb90.Checked) { wpago = 1; }
                    if (rb60.Checked) { wpago = 2; }
                    if (rb45.Checked) { wpago = 3; }
                    if (rb30.Checked) { wpago = 4; }
                    if (rb15.Checked) { wpago = 5; }
                    if (rb7.Checked) { wpago = 6; }
                    if (rbContado.Checked) { wpago = 7; }
                    if (rbOtro.Checked) { wpago = 8; }

                    con.Open();

                    cmd.CommandText = "update dbo.provs set  " +
                    " tipo       = '" + tipo.Text + "',  " +
                    " razon      = '" + razon.Text + "',  " +
                    " direc1     = '" + direc1.Text + "',  " +
                    " direc2     = '" + direc2.Text + "',  " +
                    " direc3     = '" + direc3.Text + "',  " +
                    " atencion   = '" + atencion.Text + "',  " +
                    " tel1       = '" + tel1.Text + "',  " +
                    " tel2       = '" + tel2.Text + "',  " +
                    " email      = '" + email.Text + "',  " +
                    " web        = '" + web.Text + "',  " +
                    " porcmas    = '" + porcmas.Text + "',  " +
                    " transf     = '" + transf.Text + "',  " +
                    " ext        = '" + ext.Text + "',  " +
                    " reqent     = '" + reqent.Text + "',  " +
                    " reqord     = '" + reqord.Text + "',  " +
                    " ultorden   = '" + ultorden.Text + "',  " +
                    " cta1a      = '" + cta1a.Text + "',  " +
                    " cta2a      = '" + cta2a.Text + "',  " +
                    " cta3a      = '" + cta3a.Text + "',  " +
                    " prove_lg   = '" + prove_lg.Text + "',  " +
                    " prove_edi  = '" + prove_edi.Text + "',  " +
                    " prove_ter  = '" + prove_ter.Text + "',  " +
                    " banco_lg   = '" + banco_lg.Text + "',  " +
                    " banco_edi  = '" + banco_edi.Text + "',  " +
                    " banco_ter  = '" + banco_ter.Text + "',  " +
                    " ctabanco_l = '" + ctabanco_l.Text + "',  " +
                    " ctabanco_e = '" + ctabanco_e.Text + "',  " +
                    " ctabanco_t = '" + ctabanco_t.Text + "',  " +
                    " cont_lg    = '" + cont_lg.Text + "',  " +
                    " cont_edi   = '" + cont_edi.Text + "',  " +
                    " cont_ter   = '" + cont_ter.Text + "',  " +
                    " cta_lg     = '" + cta_lg.Text + "',  " +
                    " cta_edi    = '" + cta_edi.Text + "',  " +
                    " cta_ter    = '" + cta_ter.Text + "',  " +
                    " email1     = '" + email1.Text + "',  " +
                    " email2     = '" + email2.Text + "',  " +
                    " email3     = '" + email3.Text + "',  " +
                    " mailcontra = '" + mailcontra.Text + "',  " +
                    " mailcomple = '" + mailcomple.Text + "',  " +
                    " pago       = '" + wpago + "',   " +
                    " polizas    = '" + wpolizas + "',  " +
                    " cont1      = '" + wcont1 + "',  " +
                    " cont2      = '" + wcont2 + "',  " +
                    " cont3      = '" + wcont3 + "',  " +
                    " cont4      = '" + wcont4 + "',  " +
                    " cont5      = '" + wcont5 + "',  " +
                    " cont6      = '" + wcont6 + "',  " +
                    " creden     = '" + creden.Text + "',  " +
                    " fiscal     = '" + fiscal.Text + "',  " +
                    " imss       = '" + imss.Text + "',  " +
                    " nombrerep  = '" + nombrerep.Text + "',  " +
                    " escritura  = '" + escritura.Text + "',  " +
                    " fechaesc   = '" + fechaesc.Text + "',  " +
                    " nombrenot  = '" + nombrenot.Text + "',  " +
                    " numnot     = '" + numnot.Text + "',  " +
                    " lugar      = '" + lugar.Text + "',  " +
                    " regcomer   = '" + regcomer.Text + "',  " +
                    " rfc        = '" + rfc.Text +
                    "' where  proveedor  = '" + proveedor.Text + "' ";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Proveedor modificado...!", "Litografía Gil");
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta...!");
                }
            }
        }

        private void btimprime_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fimprimeprovs ss = new presupvisual.Fimprimeprovs();
            ss.Show();
            //   this.Show();
        }

        private void btcontratos_Click(object sender, EventArgs e)
        {
            this.Hide();
            string pclaveprove = proveedor.Text;
            ContServiciosFisica ss = new presupvisual.ContServiciosFisica();
            ss.Show();
        }

        private void btserviciospf_Click(object sender, EventArgs e)
        {
            if (proveedor.Text == "") { MessageBox.Show("Falta poner la clave del proveedor...!"); }
            else
            {
                if (especi.Text == "") { MessageBox.Show("Falta la especificación de actividad...!"); }
                else
                {
                    if (creden.Text == "") { MessageBox.Show("Falta poner la credencial del proveedor...!"); }
                    else
                    {
                        if (fiscal.Text == "") { MessageBox.Show("Falta el folio de cédula de identificación fiscal...!"); }
                        else
                        {
                            if (pago.Text == "8") { MessageBox.Show("Verifica el plazo del pago"); }
                            else
                            {
                                string mlaempresa = "";
                                string mzreplegal = "";
                                string mztestigo1 = "";
                                string mztestigo2 = "";

                                if (btlitogil.Checked)
                                {
                                    mlaempresa = "Litografía Gil, S. A. de C. V.";
                                    mzreplegal = "JOSÉ ABEL GIL GUERRA";
                                    mztestigo1 = "FEDERICO NAVARRETE SANCHEZ";
                                    mztestigo2 = "ALAN ADRIAN GAMBOA NAVARRO";
                                };

                                if (btediciones.Checked)
                                {
                                    mlaempresa = "Ediciones Litográficas, S. A.";
                                    mzreplegal = "";
                                    mztestigo1 = "";
                                    mztestigo2 = "";
                                };

                                if (btterminados.Checked)
                                {
                                    mlaempresa = "Terminados Litográficos, S. A. de C. V.";
                                    mzreplegal = "LUIS ALFONSO GIL GUERRA";
                                    mztestigo1 = "JOSÉ ABEL GIL ZUÑIGA";
                                    mztestigo2 = "JORGE LIRA ESTRADA";
                                };

                                this.Hide();
                                // Datos necesarios para el contrato
                                Fdamedatoscontrato ss = new presupvisual.Fdamedatoscontrato();
                                ss.mproveedor.Text = proveedor.Text;
                                ss.mrazon.Text  = razon.Text;
                                ss.mrfc.Text    = rfc.Text;
                                ss.mespeci.Text = especi.Text;
                                ss.mdirec1.Text = direc1.Text;
                                ss.mdirec2.Text = direc2.Text;
                                ss.mdirec3.Text = direc3.Text;
                                ss.mcreden.Text = creden.Text;
                                ss.mfiscal.Text = fiscal.Text;
                                ss.mimss.Text   = imss.Text;
                                ss.mpago.Text   = pago.Text;
                                ss.laempresa.Text = mlaempresa;
                                ss.zreplegal.Text = mzreplegal;
                                ss.ztestigo1.Text = mztestigo1;
                                ss.ztestigo2.Text = mztestigo2;
                                if (btlitogil.Checked)  { ss.mbtlitogil.Checked = true; };
                                if (btediciones.Checked) { ss.mbtediciones.Checked = true; };
                                if (btterminados.Checked) { ss.mbtterminados.Checked = true; };
                                ss.Show();
                            }
                        }
                    }
                }
            }
        }

        private void btserviciospm_Click(object sender, EventArgs e)
        {
            if (proveedor.Text == "") { MessageBox.Show("Falta poner la clave del proveedor...!"); }
            else
            {
                if (especi.Text == "") { MessageBox.Show("Falta la especificación de actividad...!"); }
                else
                {
                    if (nombrerep.Text == "") { MessageBox.Show("Falta poner el nombre del representante legal...!"); }
                    else
                    {
                        if (escritura.Text == "") { MessageBox.Show("Falta el número de la escritura...!"); }
                        else
                        {
                            if (fechaesc.Text == "") { MessageBox.Show("Falta la fecha de laescritura"); }
                            else
                            {
                                if (nombrenot.Text == "") { MessageBox.Show("Falta el nombre del notario"); }
                                else
                                {
                                    if (numnot.Text == "") { MessageBox.Show("Falta el número del notario"); }
                                    else
                                    {
                                        if (lugar.Text == "") { MessageBox.Show("Falta el lugar"); }
                                        else
                                        {
                                            if (regcomer.Text == "") { MessageBox.Show("Falta el registro público de comercio"); }
                                            else
                                            {
                                                string mlaempresa = "";
                                                string mzreplegal = "";
                                                string mztestigo1 = "";
                                                string mztestigo2 = "";

                                                if (btlitogil.Checked)
                                                {
                                                    mlaempresa = "Litografía Gil, S. A. de C. V.";
                                                    mzreplegal = "JOSÉ ABEL GIL GUERRA";
                                                    mztestigo1 = "FEDERICO NAVARRETE SANCHEZ";
                                                    mztestigo2 = "ALAN ADRIAN GAMBOA NAVARRO";
                                                };

                                                if (btediciones.Checked)
                                                {
                                                    mlaempresa = "Ediciones Litográficas, S. A.";
                                                    mzreplegal = "";
                                                    mztestigo1 = "";
                                                    mztestigo2 = "";
                                                };

                                                if (btterminados.Checked)
                                                {
                                                    mlaempresa = "Terminados Litográficos, S. A. de C. V.";
                                                    mzreplegal = "LUIS ALFONSO GIL GUERRA";
                                                    mztestigo1 = "JOSÉ ABEL GIL ZUÑIGA";
                                                    mztestigo2 = "JORGE LIRA ESTRADA";
                                                };

                                                this.Hide();
                                                // Datos necesarios para el contrato
                                                Fdamedatoscontrato2 ss = new presupvisual.Fdamedatoscontrato2();
                                                ss.mproveedor.Text = proveedor.Text;
                                                ss.mrazon.Text = razon.Text;
                                                ss.mrfc.Text = rfc.Text;
                                                ss.mespeci.Text = especi.Text;
                                                ss.mdirec1.Text = direc1.Text;
                                                ss.mdirec2.Text = direc2.Text;
                                                ss.mdirec3.Text = direc3.Text;
                                                ss.mcreden.Text = creden.Text;
                                                ss.mfiscal.Text = fiscal.Text;
                                                ss.mimss.Text = imss.Text;
                                                ss.mpago.Text = pago.Text;
                                                ss.mnombrerep.Text = nombrerep.Text;
                                                ss.mescritura.Text = escritura.Text;
                                                ss.mfechaesc.Text = fechaesc.Text;
                                                ss.mnombrenot.Text = nombrenot.Text;
                                                ss.mnumnot.Text = numnot.Text;
                                                ss.mlugar.Text = lugar.Text;
                                                ss.mregcomer.Text = regcomer.Text;
                                                ss.laempresa.Text = mlaempresa;
                                                ss.zreplegal.Text = mzreplegal;
                                                ss.ztestigo1.Text = mztestigo1;
                                                ss.ztestigo2.Text = mztestigo2;
                                                if (btlitogil.Checked) { ss.mbtlitogil.Checked = true; };
                                                if (btediciones.Checked) { ss.mbtediciones.Checked = true; };
                                                if (btterminados.Checked) { ss.mbtterminados.Checked = true; };
                                                ss.Show();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (proveedor.Text == "") { MessageBox.Show("Falta poner la clave del proveedor...!"); }
            else
            {
                if (especi.Text == "") { MessageBox.Show("Falta la especificación de actividad...!"); }
                else
                {
                    if (creden.Text == "") { MessageBox.Show("Falta poner la credencial del proveedor...!"); }
                    else
                    {
                        if (fiscal.Text == "") { MessageBox.Show("Falta el folio de cédula de identificación fiscal...!"); }
                        else
                        {
                            if (pago.Text == "8") { MessageBox.Show("Verifica el plazo del pago"); }
                            else
                            {
                                string mlaempresa = "";
                                string mzreplegal = "";
                                string mztestigo1 = "";
                                string mztestigo2 = "";

                                if (btlitogil.Checked)
                                {
                                    mlaempresa = "Litografía Gil, S. A. de C. V.";
                                    mzreplegal = "JOSÉ ABEL GIL GUERRA";
                                    mztestigo1 = "FEDERICO NAVARRETE SANCHEZ";
                                    mztestigo2 = "ALAN ADRIAN GAMBOA NAVARRO";
                                };

                                if (btediciones.Checked)
                                {
                                    mlaempresa = "Ediciones Litográficas, S. A.";
                                    mzreplegal = "";
                                    mztestigo1 = "";
                                    mztestigo2 = "";
                                };

                                if (btterminados.Checked)
                                {
                                    mlaempresa = "Terminados Litográficos, S. A. de C. V.";
                                    mzreplegal = "LUIS ALFONSO GIL GUERRA";
                                    mztestigo1 = "JOSÉ ABEL GIL ZUÑIGA";
                                    mztestigo2 = "JORGE LIRA ESTRADA";
                                };

                                this.Hide();
                                // Datos necesarios para el contrato
                                Fdamesuministrospf ss = new presupvisual.Fdamesuministrospf();
                                ss.mproveedor.Text = proveedor.Text;
                                ss.mrazon.Text = razon.Text;
                                ss.mrfc.Text = rfc.Text;
                                ss.mespeci.Text = especi.Text;
                                ss.mdirec1.Text = direc1.Text;
                                ss.mdirec2.Text = direc2.Text;
                                ss.mdirec3.Text = direc3.Text;
                                ss.mcreden.Text = creden.Text;
                                ss.mfiscal.Text = fiscal.Text;
                                ss.mimss.Text = imss.Text;
                                ss.mpago.Text = pago.Text;
                                ss.laempresa.Text = mlaempresa;
                                ss.zreplegal.Text = mzreplegal;
                                ss.ztestigo1.Text = mztestigo1;
                                ss.ztestigo2.Text = mztestigo2;
                                if (btlitogil.Checked) { ss.mbtlitogil.Checked = true; };
                                if (btediciones.Checked) { ss.mbtediciones.Checked = true; };
                                if (btterminados.Checked) { ss.mbtterminados.Checked = true; };
                                ss.Show();
                            }
                        }
                    }
                }
            }
        }
    }
}   
    
