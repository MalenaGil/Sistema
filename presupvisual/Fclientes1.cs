using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace presupvisual
{
       public partial class Fclientes1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8COP5NU\SQLSISTEMAS;Initial Catalog=litografia;Integrated Security=True;");
        //SqlConnection con = new SqlConnection(@"Data Source=SERVER\SQLSISTEMAS;Initial Catalog=litografia;Integrated Security=True;");
        //SqlConnection con = new SqlConnection(strConnection);//@"Data Source=DESKTOP-8COP5NU\SQLSISTEMAS ;Initial Catalog=litografia; Integrated Security=True; ");

        ClassComboBox combo = new ClassComboBox();
        SqlCommand cmd = new SqlCommand();
        public Fclientes1()
        {
            InitializeComponent();
            combo.seleccionar(cb);
            cmd.Connection = con;
            this.Show();
            clte.Focus();

            clte.Text = "";
            razon.Text = "";
            clte_lito.Text = "0";
            dig_lito.Text = "0";
            clte_edi.Text = "0";
            dig_edi.Text = "0";
            calle.Text = "";
            numext.Text = "";
            numint.Text = "";
            colonia.Text = "";
            delega.Text = "";
            estado.Text = "";
            pais.Text = "";
            telefono.Text = "";
            rfc.Text = "";
            cp.Text = "";
            atencion1.Text = "";
            atencion2.Text = "";
            atencion3.Text = "";
            atencion4.Text = "";
            atencion5.Text = "";
            nombre.Text = "";
            apellidop.Text = "";
            apellidom.Text = "";
            clave.Text = "";
            vendedor.Text = "";
            comisvend.Text = "0";
            rebate.Text = "0";
            comis30.Text = "0";
            comis60.Text = "0";
            comis90.Text = "0";
            comistarj.Text = "0";
            cargofin.Text = "0";
            diasrevi.Text = "";
            email.Text = "";
            porcmas.Text = "0";
            carta.Text = "";
            tipoclte.Text = "0";
            clave.Text = "";
            dsctopapel.Text = "0";
            dscto.Text = "0";
            diseno.Text = "0";
            plazo.Text = "0";
            lunhora.Text = "";
            marhora.Text = "";
            miehora.Text = "";
            juehora.Text = "";
            viehora.Text = "";
            lun.Checked = false;
            mar.Checked = false;
            mie.Checked = false;
            jue.Checked = false;
            vie.Checked = false;
            cuenta1.Text = "0";
            cuenta2.Text = "0";
            cuenta3.Text = "0";
            cuenta4.Text = "0";
            cuenta5.Text = "0";
            cuenta6.Text = "0";
            cuenta7.Text = "0";
            cuenta8.Text = "0";
            cuenta9.Text = "0";
            cuenta10.Text = "0";
            porefe.Text = "0";
            porche.Text = "0";
            portra.Text = "0";
            porcre.Text = "0";
            pormon.Text = "0";
            pordin.Text = "0";
            porval.Text = "0";
            pordeb.Text = "0";
            porser.Text = "0";
            porant.Text = "0";
            porotr.Text = "0";
            comen1.Text = "";
            comen2.Text = "";
            comen3.Text = "";
            comen4.Text = "";
            comen5.Text = "";
            comen6.Text = "";
            comen7.Text = "";
            comen8.Text = "";
            comen9.Text = "";
            comen10.Text = "";
            fpefe.Checked = false;
            fptra.Checked = false;
            fptdeb.Checked = false;
            fptcre.Checked = false;
            fptser.Checked = false;
            fpche.Checked = false;
            fpmon.Checked = false;
            fpno.Checked = false;
            fpnoa.Checked = false;
            solofact.Text = "NO";
            ordencpa.Text = "NO";
            presup.Text = "0";
            proveedor.Text = "";
            txtcontrase.Text = "";
            LBLcontra.Text = "";

            tipoclte.Enabled = false;
            Lbl1montoaut.Visible = false;
            Lbl2montoaut.Visible = false;
            Lbl1montoacum.Visible = false;
            Lbl2montoacum.Visible = false;
            Lbl1porcanti.Visible = false;
            Lbl2porcanti.Visible = false;
            Lbl3porcanti.Visible = false;
            montoaut.Enabled = false;
            montoaut.Visible = false;
            montoacum.Enabled = false;
            montoacum.Visible = false;
            porcanti.Enabled = false;
            porcanti.Visible = false;
            this.cltecons.Focus();
        }

        public void Ejecutar(string dato)
        {
            LBLcontra.Text = dato;
            txtcontrase.Text = dato;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu ss = new presupvisual.menu();
            ss.Show();
        }

        private void Btprimero_Click(object sender, EventArgs e)
        {
            //      if (cuenta == 0)
            //      {
            //          MessageBox.Show("No hay registros", "Litografía Gil");
            //      }


            con.Open();
            clte.Text = "";
            razon.Text = "";
            clte_lito.Text = "0";
            dig_lito.Text = "0";
            calle.Text = "";
            numext.Text = "";
            numint.Text = "";
            colonia.Text = "";
            delega.Text = "";
            estado.Text = "";
            pais.Text = "";
            telefono.Text = "";
            rfc.Text = "";
            cp.Text = "";
            atencion1.Text = "";
            atencion2.Text = "";
            atencion3.Text = "";
            atencion4.Text = "";
            atencion5.Text = "";
            nombre.Text = "";
            apellidop.Text = "";
            apellidom.Text = "";
            clave.Text = "";
            vendedor.Text = "";
            comisvend.Text = "0";
            rebate.Text = "0";
            comis30.Text = "0";
            comis60.Text = "0";
            comis90.Text = "0";
            comistarj.Text = "0";
            cargofin.Text = "0";
            diasrevi.Text = "";
            email.Text = "";
            porcmas.Text = "0";
            carta.Text = "";
            tipoclte.Text = "0";
            clave.Text = "";
            dsctopapel.Text = "0";
            dscto.Text = "0";
            diseno.Text = "0";
            plazo.Text = "0";
            lunhora.Text = "";
            marhora.Text = "";
            miehora.Text = "";
            juehora.Text = "";
            viehora.Text = "";
            lun.Checked = false;
            mar.Checked = false;
            mie.Checked = false;
            jue.Checked = false;
            vie.Checked = false;
            cuenta1.Text = "0";
            cuenta2.Text = "0";
            cuenta3.Text = "0";
            cuenta4.Text = "0";
            cuenta5.Text = "0";
            cuenta6.Text = "0";
            cuenta7.Text = "0";
            cuenta8.Text = "0";
            cuenta9.Text = "0";
            cuenta10.Text = "0";
            porefe.Text = "0";
            porche.Text = "0";
            portra.Text = "0";
            porcre.Text = "0";
            pormon.Text = "0";
            pordin.Text = "0";
            porval.Text = "0";
            pordeb.Text = "0";
            porser.Text = "0";
            porant.Text = "0";
            porotr.Text = "0";
            comen1.Text = "";
            comen2.Text = "";
            comen3.Text = "";
            comen4.Text = "";
            comen5.Text = "";
            comen6.Text = "";
            comen7.Text = "";
            comen8.Text = "";
            comen9.Text = "";
            comen10.Text = "";
            fpefe.Checked = false;
            fptra.Checked = false;
            fpche.Checked = false;
            fptdeb.Checked = false;
            fptcre.Checked = false;
            fptser.Checked = false;
            fpmon.Checked = false;
            fpno.Checked = false;
            fpnoa.Checked = false;
            solofact.Text = "";
            ordencpa.Text = "";
            presup.Text = "0";
            proveedor.Text = "";
            montoaut.Text = "0";
            montoacum.Text = "0";
            porcanti.Text = "0";

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select top (1) clte,razon,clte_lito,dig_lito,calle,numext,numint, " +
                " colonia,delega,estado,pais,telefono,rfc,cp,atencion1,atencion2,atencion3,atencion4,atencion5, " +
                " nombre,apellidop,apellidom,clave,vendedor,comisvend,rebate,comis30,comis60,comis90,comistarj,cargofin," +
                " diasrevi,email,porcmas,carta,tipoclte,clave,dsctopapel,dscto,diseno,plazo,lun,lunhora,mar,marhora,mie,miehora,jue,juehora,vie,viehora," +
                " cuenta1,cuenta2,cuenta3,cuenta4,cuenta5,cuenta6,cuenta7,cuenta8,cuenta9,cuenta10, " +
                " porefe,porche,portra,porcre,pormon,pordin,porval,pordeb,porser,porant,porotr, " +
                " comen1,comen2,comen3,comen4,comen5,comen6,comen7,comen8,comen9,comen10, " +
                " fpefe,fptra,fpche,fptdeb,fptcre,fptser,fpmon,fpno,fpnoa,solofact,ordencpa,presup,proveedor " +
                " from dbo.clientes order by clte ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DGclientes.DataSource = dt;
            int cuenta = DGclientes.RowCount;


            DGclientes.RowHeadersVisible = false;

            DGclientes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DGclientes.Columns[0].Width = 70;
            DGclientes.Columns[0].DefaultCellStyle.BackColor = Color.PowderBlue;
            DGclientes.Columns[0].HeaderText = "Clave";
            DGclientes.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGclientes.Columns[1].Width = 200;
            DGclientes.Columns[1].DefaultCellStyle.BackColor = Color.Beige;
            DGclientes.Columns[1].HeaderText = "Razón Social";
            DGclientes.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGclientes.Columns[2].Width = 35;
            DGclientes.Columns[2].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGclientes.Columns[2].HeaderText = "Conta";
            DGclientes.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DGclientes.Columns[3].Width = 20;
            DGclientes.Columns[3].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGclientes.Columns[3].HeaderText = "Dig";
            DGclientes.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DGclientes.Columns[4].Width = 120;
            DGclientes.Columns[4].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGclientes.Columns[4].HeaderText = "Calle";
            DGclientes.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGclientes.Columns[5].Width = 40;
            DGclientes.Columns[5].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGclientes.Columns[5].HeaderText = "No.Ext";
            DGclientes.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGclientes.Columns[6].Width = 40;
            DGclientes.Columns[6].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGclientes.Columns[6].HeaderText = "No.Int";
            DGclientes.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGclientes.Columns[7].Width = 80;
            DGclientes.Columns[7].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGclientes.Columns[7].HeaderText = "Colonia";
            DGclientes.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGclientes.Columns[8].Width = 80;
            DGclientes.Columns[8].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGclientes.Columns[8].HeaderText = "Delegación";
            DGclientes.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGclientes.Columns[9].Width = 80;
            DGclientes.Columns[9].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGclientes.Columns[9].HeaderText = "Estado";
            DGclientes.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGclientes.Columns[10].Width = 80;
            DGclientes.Columns[10].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGclientes.Columns[10].HeaderText = "Pais";
            DGclientes.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGclientes.Columns[11].Width = 80;
            DGclientes.Columns[11].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGclientes.Columns[11].HeaderText = "Teléfono";
            DGclientes.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGclientes.Columns[12].Width = 80;
            DGclientes.Columns[12].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGclientes.Columns[12].HeaderText = "RFC";
            DGclientes.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGclientes.Columns[13].Width = 40;
            DGclientes.Columns[13].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGclientes.Columns[13].HeaderText = "CP";
            DGclientes.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            SqlCommand cursor = new SqlCommand(@"select top (1) clte,razon,clte_lito,dig_lito,calle,numext,numint, " +
            " colonia,delega,estado,pais,telefono,rfc,cp,atencion1,atencion2,atencion3,atencion4,atencion5, " +
            " nombre,apellidop,apellidom,clave,vendedor,comisvend,rebate,comis30,comis60,comis90,comistarj,cargofin, " +
            " diasrevi,email,porcmas,carta,tipoclte,clave,dsctopapel,dscto,diseno,plazo,lun,lunhora,mar,marhora,mie,miehora,jue,juehora,vie,viehora," +
            " cuenta1,cuenta2,cuenta3,cuenta4,cuenta5,cuenta6,cuenta7,cuenta8,cuenta9,cuenta10, " +
            " porefe,porche,portra,porcre,pormon,pordin,porval,pordeb,porser,porant,porotr, " +
            " comen1,comen2,comen3,comen4,comen5,comen6,comen7,comen8,comen9,comen10, " +
            " fpefe,fptra,fpche,fptdeb,fptcre,fptser,fpmon,fpno,fpnoa,solofact,ordencpa,presup,proveedor,montoaut,montoacum,porcanti " +
            " from dbo.clientes order by clte", con);
            SqlDataReader cursorleido = cursor.ExecuteReader();
            while (cursorleido.Read())
            {
                clte.Text = Convert.ToString(cursorleido["clte"]);
                razon.Text = Convert.ToString(cursorleido["razon"]);
                clte_lito.Text = Convert.ToString(cursorleido["clte_lito"]);
                dig_lito.Text = Convert.ToString(cursorleido["dig_lito"]);
                calle.Text = Convert.ToString(cursorleido["calle"]);
                numext.Text = Convert.ToString(cursorleido["numext"]);
                numint.Text = Convert.ToString(cursorleido["numint"]);
                colonia.Text = Convert.ToString(cursorleido["colonia"]);
                delega.Text = Convert.ToString(cursorleido["delega"]);
                estado.Text = Convert.ToString(cursorleido["estado"]);
                pais.Text = Convert.ToString(cursorleido["pais"]);
                telefono.Text = Convert.ToString(cursorleido["telefono"]);
                rfc.Text = Convert.ToString(cursorleido["rfc"]);
                cp.Text = Convert.ToString(cursorleido["cp"]);
                atencion1.Text = Convert.ToString(cursorleido["atencion1"]);
                atencion2.Text = Convert.ToString(cursorleido["atencion2"]);
                atencion3.Text = Convert.ToString(cursorleido["atencion3"]);
                atencion4.Text = Convert.ToString(cursorleido["atencion4"]);
                atencion5.Text = Convert.ToString(cursorleido["atencion5"]);
                nombre.Text = Convert.ToString(cursorleido["nombre"]);
                apellidop.Text = Convert.ToString(cursorleido["apellidop"]);
                apellidom.Text = Convert.ToString(cursorleido["apellidom"]);
                clave.Text = Convert.ToString(cursorleido["clave"]);
                vendedor.Text = Convert.ToString(cursorleido["vendedor"]);
                comisvend.Text = Convert.ToString(cursorleido["comisvend"]);
                rebate.Text = Convert.ToString(cursorleido["rebate"]);
                comis30.Text = Convert.ToString(cursorleido["comis30"]);
                comis60.Text = Convert.ToString(cursorleido["comis60"]);
                comis90.Text = Convert.ToString(cursorleido["comis90"]);
                comistarj.Text = Convert.ToString(cursorleido["comistarj"]);
                cargofin.Text = Convert.ToString(cursorleido["cargofin"]);
                diasrevi.Text = Convert.ToString(cursorleido["diasrevi"]);
                email.Text = Convert.ToString(cursorleido["email"]);
                porcmas.Text = Convert.ToString(cursorleido["porcmas"]);
                carta.Text = Convert.ToString(cursorleido["carta"]);
                clave.Text = Convert.ToString(cursorleido["clave"]);
                dsctopapel.Text = Convert.ToString(cursorleido["dsctopapel"]);
                dscto.Text = Convert.ToString(cursorleido["dscto"]);
                diseno.Text = Convert.ToString(cursorleido["diseno"]);
                plazo.Text = Convert.ToString(cursorleido["plazo"]);
                lunhora.Text = Convert.ToString(cursorleido["lunhora"]);
                marhora.Text = Convert.ToString(cursorleido["marhora"]);
                miehora.Text = Convert.ToString(cursorleido["miehora"]);
                juehora.Text = Convert.ToString(cursorleido["juehora"]);
                viehora.Text = Convert.ToString(cursorleido["viehora"]);
                lun.Checked = Convert.ToBoolean(cursorleido["lun"]);
                mar.Checked = Convert.ToBoolean(cursorleido["mar"]);
                mie.Checked = Convert.ToBoolean(cursorleido["mie"]);
                jue.Checked = Convert.ToBoolean(cursorleido["jue"]);
                vie.Checked = Convert.ToBoolean(cursorleido["vie"]);
                cuenta1.Text = Convert.ToString(cursorleido["cuenta1"]);
                cuenta2.Text = Convert.ToString(cursorleido["cuenta2"]);
                cuenta3.Text = Convert.ToString(cursorleido["cuenta3"]);
                cuenta4.Text = Convert.ToString(cursorleido["cuenta4"]);
                cuenta5.Text = Convert.ToString(cursorleido["cuenta5"]);
                cuenta6.Text = Convert.ToString(cursorleido["cuenta6"]);
                cuenta7.Text = Convert.ToString(cursorleido["cuenta7"]);
                cuenta8.Text = Convert.ToString(cursorleido["cuenta8"]);
                cuenta9.Text = Convert.ToString(cursorleido["cuenta9"]);
                cuenta10.Text = Convert.ToString(cursorleido["cuenta10"]);
                porefe.Text = Convert.ToString(cursorleido["porefe"]);
                porche.Text = Convert.ToString(cursorleido["porche"]);
                portra.Text = Convert.ToString(cursorleido["portra"]);
                porcre.Text = Convert.ToString(cursorleido["porcre"]);
                pormon.Text = Convert.ToString(cursorleido["pormon"]);
                pordin.Text = Convert.ToString(cursorleido["pordin"]);
                porval.Text = Convert.ToString(cursorleido["porval"]);
                pordeb.Text = Convert.ToString(cursorleido["pordeb"]);
                porser.Text = Convert.ToString(cursorleido["porser"]);
                porant.Text = Convert.ToString(cursorleido["porant"]);
                porotr.Text = Convert.ToString(cursorleido["porotr"]);
                comen1.Text = Convert.ToString(cursorleido["comen1"]);
                comen2.Text = Convert.ToString(cursorleido["comen2"]);
                comen3.Text = Convert.ToString(cursorleido["comen3"]);
                comen4.Text = Convert.ToString(cursorleido["comen4"]);
                comen5.Text = Convert.ToString(cursorleido["comen5"]);
                comen6.Text = Convert.ToString(cursorleido["comen6"]);
                comen7.Text = Convert.ToString(cursorleido["comen7"]);
                comen8.Text = Convert.ToString(cursorleido["comen8"]);
                comen9.Text = Convert.ToString(cursorleido["comen9"]);
                comen10.Text = Convert.ToString(cursorleido["comen10"]);
                fpefe.Checked  = Convert.ToBoolean(cursorleido["fpefe"]);
                fptra.Checked  = Convert.ToBoolean(cursorleido["fptra"]);
                fpche.Checked  = Convert.ToBoolean(cursorleido["fpche"]);
                fptdeb.Checked = Convert.ToBoolean(cursorleido["fptdeb"]);
                fptcre.Checked = Convert.ToBoolean(cursorleido["fptcre"]);
                fptser.Checked = Convert.ToBoolean(cursorleido["fptser"]);
                fpmon.Checked  = Convert.ToBoolean(cursorleido["fpmon"]);
                fpno.Checked   = Convert.ToBoolean(cursorleido["fpno"]);
                fpnoa.Checked  = Convert.ToBoolean(cursorleido["fpnoa"]);
                solofact.Text = Convert.ToString(cursorleido["solofact"]);
                ordencpa.Text = Convert.ToString(cursorleido["ordencpa"]);
                presup.Text = Convert.ToString(cursorleido["presup"]);
                proveedor.Text = Convert.ToString(cursorleido["proveedor"]);
                montoaut.Text = Convert.ToString(cursorleido["montoaut"]);
                montoacum.Text = Convert.ToString(cursorleido["montoacum"]);
                porcanti.Text = Convert.ToString(cursorleido["porcanti"]);

                tipoclte.Enabled = false;
                Lbl1montoaut.Visible = false;
                Lbl2montoaut.Visible = false;
                Lbl1montoacum.Visible = false;
                Lbl2montoacum.Visible = false;
                Lbl1porcanti.Visible = false;
                Lbl2porcanti.Visible = false;
                Lbl3porcanti.Visible = false;
                montoaut.Enabled = false;
                montoaut.Visible = false;
                montoacum.Enabled = false;
                montoacum.Visible = false;
                porcanti.Enabled = false;
                porcanti.Visible = false;

            }
            con.Close();
        }

        private void Btultimo_Click(object sender, EventArgs e)
        {
            con.Open();
            clte.Text = "";
            razon.Text = "";
            clte_lito.Text = "0";
            dig_lito.Text = "0";
            calle.Text = "";
            numext.Text = "";
            numint.Text = "";
            colonia.Text = "";
            delega.Text = "";
            estado.Text = "";
            pais.Text = "";
            telefono.Text = "";
            rfc.Text = "";
            cp.Text = "";
            atencion1.Text = "";
            atencion2.Text = "";
            atencion3.Text = "";
            atencion4.Text = "";
            atencion5.Text = "";
            nombre.Text = "";
            apellidop.Text = "";
            apellidom.Text = "";
            clave.Text = "";
            vendedor.Text = "";
            comisvend.Text = "0";
            rebate.Text = "0";
            comis30.Text = "0";
            comis60.Text = "0";
            comis90.Text = "0";
            comistarj.Text = "0";
            cargofin.Text = "0";
            diasrevi.Text = "";
            email.Text = "";
            porcmas.Text = "0";
            carta.Text = "";
            tipoclte.Text = "0";
            clave.Text = "";
            dsctopapel.Text = "0";
            dscto.Text = "0";
            diseno.Text = "0";
            plazo.Text = "0";
            lunhora.Text = "";
            marhora.Text = "";
            miehora.Text = "";
            juehora.Text = "";
            viehora.Text = "";
            lun.Checked = false;
            mar.Checked = false;
            mie.Checked = false;
            jue.Checked = false;
            vie.Checked = false;
            cuenta1.Text = "0";
            cuenta2.Text = "0";
            cuenta3.Text = "0";
            cuenta4.Text = "0";
            cuenta5.Text = "0";
            cuenta6.Text = "0";
            cuenta7.Text = "0";
            cuenta8.Text = "0";
            cuenta9.Text = "0";
            cuenta10.Text = "0";
            porefe.Text = "0";
            porche.Text = "0";
            portra.Text = "0";
            porcre.Text = "0";
            pormon.Text = "0";
            pordin.Text = "0";
            porval.Text = "0";
            pordeb.Text = "0";
            porser.Text = "0";
            porant.Text = "0";
            porotr.Text = "0";
            comen1.Text = "";
            comen2.Text = "";
            comen3.Text = "";
            comen4.Text = "";
            comen5.Text = "";
            comen6.Text = "";
            comen7.Text = "";
            comen8.Text = "";
            comen9.Text = "";
            comen10.Text = "";
            fpefe.Checked = false;
            fptra.Checked = false;
            fpche.Checked = false;
            fptdeb.Checked = false;
            fptcre.Checked = false;
            fptser.Checked = false;
            fpmon.Checked = false;
            fpno.Checked = false;
            fpnoa.Checked = false;
            solofact.Text = "";
            ordencpa.Text = "";
            presup.Text = "0";
            proveedor.Text = "";
            montoaut.Text = "0";
            montoacum.Text = "0";
            porcanti.Text = "0";


            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select top (1) clte,razon,clte_lito,dig_lito,calle,numext,numint, " +
            " colonia,delega,estado,pais,telefono,rfc,cp,atencion1,atencion2,atencion3,atencion4,atencion5," +
            " nombre,apellidop,apellidom,clave,vendedor,comisvend,rebate,comis30,comis60,comis90,comistarj,cargofin, " +
            " diasrevi,email,porcmas,carta,tipoclte,clave,dsctopapel,dscto,diseno,plazo,lun,lunhora,mar,marhora,mie,miehora,jue,juehora,vie,viehora," +
            " cuenta1,cuenta2,cuenta3,cuenta4,cuenta5,cuenta6,cuenta7,cuenta8,cuenta9,cuenta10, " +
            " porefe,porche,portra,porcre,pormon,pordin,porval,pordeb,porser,porant,porotr, " +
            " comen1,comen2,comen3,comen4,comen5,comen6,comen7,comen8,comen9,comen10, " +
            " fpefe,fptra,fpche,fptdeb,fptcre,fptser,fpmon,fpno,fpnoa,solofact,ordencpa,presup,proveedor " +
            " from dbo.clientes order by clte desc";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DGclientes.DataSource = dt;
            int cuenta = DGclientes.RowCount;
            if (cuenta == 0)
            {
                MessageBox.Show("No hay registros", "Litografía Gil");
            }

            DGclientes.RowHeadersVisible = false;
            DGclientes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DGclientes.Columns[0].Width = 70;
            DGclientes.Columns[0].DefaultCellStyle.BackColor = Color.PowderBlue;
            DGclientes.Columns[0].HeaderText = "Clave";
            DGclientes.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGclientes.Columns[1].Width = 200;
            DGclientes.Columns[1].DefaultCellStyle.BackColor = Color.Beige;
            DGclientes.Columns[1].HeaderText = "Razón Social";
            DGclientes.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGclientes.Columns[2].Width = 35;
            DGclientes.Columns[2].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGclientes.Columns[2].HeaderText = "Conta";
            DGclientes.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DGclientes.Columns[3].Width = 20;
            DGclientes.Columns[3].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGclientes.Columns[3].HeaderText = "Dig";
            DGclientes.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DGclientes.Columns[4].Width = 120;
            DGclientes.Columns[4].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGclientes.Columns[4].HeaderText = "Calle";
            DGclientes.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGclientes.Columns[5].Width = 40;
            DGclientes.Columns[5].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGclientes.Columns[5].HeaderText = "No.Ext";
            DGclientes.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGclientes.Columns[6].Width = 40;
            DGclientes.Columns[6].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGclientes.Columns[6].HeaderText = "No.Int";
            DGclientes.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGclientes.Columns[7].Width = 80;
            DGclientes.Columns[7].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGclientes.Columns[7].HeaderText = "Colonia";
            DGclientes.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGclientes.Columns[8].Width = 80;
            DGclientes.Columns[8].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGclientes.Columns[8].HeaderText = "Delegación";
            DGclientes.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGclientes.Columns[9].Width = 80;
            DGclientes.Columns[9].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGclientes.Columns[9].HeaderText = "Estado";
            DGclientes.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGclientes.Columns[10].Width = 80;
            DGclientes.Columns[10].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGclientes.Columns[10].HeaderText = "Pais";
            DGclientes.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGclientes.Columns[11].Width = 80;
            DGclientes.Columns[11].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGclientes.Columns[11].HeaderText = "Teléfono";
            DGclientes.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGclientes.Columns[12].Width = 80;
            DGclientes.Columns[12].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGclientes.Columns[12].HeaderText = "RFC";
            DGclientes.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGclientes.Columns[13].Width = 40;
            DGclientes.Columns[13].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGclientes.Columns[13].HeaderText = "CP";
            DGclientes.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            SqlCommand cursor = new SqlCommand(@"select top (1)  clte,razon,clte_lito,dig_lito,calle,numext,numint, " +
            " colonia,delega,estado,pais,telefono,rfc,cp,atencion1,atencion2,atencion3,atencion4,atencion5, " +
            " nombre,apellidop,apellidom,clave,vendedor,comisvend,rebate,comis30,comis60,comis90,comistarj,cargofin, " +
            " diasrevi,email,porcmas,carta,tipoclte,clave,dsctopapel,dscto,diseno,plazo,lun,lunhora,mar,marhora,mie,miehora,jue,juehora,vie,viehora," +
            " cuenta1,cuenta2,cuenta3,cuenta4,cuenta5,cuenta6,cuenta7,cuenta8,cuenta9,cuenta10, " +
            " porefe,porche,portra,porcre,pormon,pordin,porval,pordeb,porser,porant,porotr, " +
            " comen1,comen2,comen3,comen4,comen5,comen6,comen7,comen8,comen9,comen10, " +
            " fpefe,fptra,fpche,fptdeb,fptcre,fptser,fpmon,fpno,fpnoa,solofact,ordencpa,presup,proveedor,montoaut,montoacum,porcanti " +
            " from dbo.clientes order by clte desc", con);
            SqlDataReader cursorleido = cursor.ExecuteReader();
            while (cursorleido.Read())
            {
                clte.Text = Convert.ToString(cursorleido["clte"]);
                razon.Text = Convert.ToString(cursorleido["razon"]);
                clte_lito.Text = Convert.ToString(cursorleido["clte_lito"]);
                dig_lito.Text = Convert.ToString(cursorleido["dig_lito"]);
                calle.Text = Convert.ToString(cursorleido["calle"]);
                numext.Text = Convert.ToString(cursorleido["numext"]);
                numint.Text = Convert.ToString(cursorleido["numint"]);
                colonia.Text = Convert.ToString(cursorleido["colonia"]);
                delega.Text = Convert.ToString(cursorleido["delega"]);
                estado.Text = Convert.ToString(cursorleido["estado"]);
                pais.Text = Convert.ToString(cursorleido["pais"]);
                telefono.Text = Convert.ToString(cursorleido["telefono"]);
                rfc.Text = Convert.ToString(cursorleido["rfc"]);
                cp.Text = Convert.ToString(cursorleido["cp"]);
                atencion1.Text = Convert.ToString(cursorleido["atencion1"]);
                atencion2.Text = Convert.ToString(cursorleido["atencion2"]);
                atencion3.Text = Convert.ToString(cursorleido["atencion3"]);
                atencion4.Text = Convert.ToString(cursorleido["atencion4"]);
                atencion5.Text = Convert.ToString(cursorleido["atencion5"]);
                nombre.Text = Convert.ToString(cursorleido["nombre"]);
                apellidop.Text = Convert.ToString(cursorleido["apellidop"]);
                apellidom.Text = Convert.ToString(cursorleido["apellidom"]);
                clave.Text = Convert.ToString(cursorleido["clave"]);
                vendedor.Text = Convert.ToString(cursorleido["vendedor"]);
                comisvend.Text = Convert.ToString(cursorleido["comisvend"]);
                rebate.Text = Convert.ToString(cursorleido["rebate"]);
                comis30.Text = Convert.ToString(cursorleido["comis30"]);
                comis60.Text = Convert.ToString(cursorleido["comis60"]);
                comis90.Text = Convert.ToString(cursorleido["comis90"]);
                comistarj.Text = Convert.ToString(cursorleido["comistarj"]);
                cargofin.Text = Convert.ToString(cursorleido["cargofin"]);
                diasrevi.Text = Convert.ToString(cursorleido["diasrevi"]);
                email.Text = Convert.ToString(cursorleido["email"]);
                porcmas.Text = Convert.ToString(cursorleido["porcmas"]);
                carta.Text = Convert.ToString(cursorleido["carta"]);
                clave.Text = Convert.ToString(cursorleido["clave"]);
                dsctopapel.Text = Convert.ToString(cursorleido["dsctopapel"]);
                dscto.Text = Convert.ToString(cursorleido["dscto"]);
                diseno.Text = Convert.ToString(cursorleido["diseno"]);
                plazo.Text = Convert.ToString(cursorleido["plazo"]);
                lunhora.Text = Convert.ToString(cursorleido["lunhora"]);
                marhora.Text = Convert.ToString(cursorleido["marhora"]);
                miehora.Text = Convert.ToString(cursorleido["miehora"]);
                juehora.Text = Convert.ToString(cursorleido["juehora"]);
                viehora.Text = Convert.ToString(cursorleido["viehora"]);
                lun.Checked = Convert.ToBoolean(cursorleido["lun"]);
                mar.Checked = Convert.ToBoolean(cursorleido["mar"]);
                mie.Checked = Convert.ToBoolean(cursorleido["mie"]);
                jue.Checked = Convert.ToBoolean(cursorleido["jue"]);
                vie.Checked = Convert.ToBoolean(cursorleido["vie"]);
                cuenta1.Text = Convert.ToString(cursorleido["cuenta1"]);
                cuenta2.Text = Convert.ToString(cursorleido["cuenta2"]);
                cuenta3.Text = Convert.ToString(cursorleido["cuenta3"]);
                cuenta4.Text = Convert.ToString(cursorleido["cuenta4"]);
                cuenta5.Text = Convert.ToString(cursorleido["cuenta5"]);
                cuenta6.Text = Convert.ToString(cursorleido["cuenta6"]);
                cuenta7.Text = Convert.ToString(cursorleido["cuenta7"]);
                cuenta8.Text = Convert.ToString(cursorleido["cuenta8"]);
                cuenta9.Text = Convert.ToString(cursorleido["cuenta9"]);
                cuenta10.Text = Convert.ToString(cursorleido["cuenta10"]);
                porefe.Text = Convert.ToString(cursorleido["porefe"]);
                porche.Text = Convert.ToString(cursorleido["porche"]);
                portra.Text = Convert.ToString(cursorleido["portra"]);
                porcre.Text = Convert.ToString(cursorleido["porcre"]);
                pormon.Text = Convert.ToString(cursorleido["pormon"]);
                pordin.Text = Convert.ToString(cursorleido["pordin"]);
                porval.Text = Convert.ToString(cursorleido["porval"]);
                pordeb.Text = Convert.ToString(cursorleido["pordeb"]);
                porser.Text = Convert.ToString(cursorleido["porser"]);
                porant.Text = Convert.ToString(cursorleido["porant"]);
                porotr.Text = Convert.ToString(cursorleido["porotr"]);
                comen1.Text = Convert.ToString(cursorleido["comen1"]);
                comen2.Text = Convert.ToString(cursorleido["comen2"]);
                comen3.Text = Convert.ToString(cursorleido["comen3"]);
                comen4.Text = Convert.ToString(cursorleido["comen4"]);
                comen5.Text = Convert.ToString(cursorleido["comen5"]);
                comen6.Text = Convert.ToString(cursorleido["comen6"]);
                comen7.Text = Convert.ToString(cursorleido["comen7"]);
                comen8.Text = Convert.ToString(cursorleido["comen8"]);
                comen9.Text = Convert.ToString(cursorleido["comen9"]);
                comen10.Text = Convert.ToString(cursorleido["comen10"]);
                fpefe.Checked = Convert.ToBoolean(cursorleido["fpefe"]);
                fptra.Checked = Convert.ToBoolean(cursorleido["fptra"]);
                fpche.Checked = Convert.ToBoolean(cursorleido["fpche"]);
                fptdeb.Checked = Convert.ToBoolean(cursorleido["fptdeb"]);
                fptcre.Checked = Convert.ToBoolean(cursorleido["fptcre"]);
                fptser.Checked = Convert.ToBoolean(cursorleido["fptser"]);
                fpmon.Checked = Convert.ToBoolean(cursorleido["fpmon"]);
                fpno.Checked = Convert.ToBoolean(cursorleido["fpno"]);
                fpnoa.Checked = Convert.ToBoolean(cursorleido["fpnoa"]);
                solofact.Text = Convert.ToString(cursorleido["solofact"]);
                ordencpa.Text = Convert.ToString(cursorleido["ordencpa"]);
                presup.Text = Convert.ToString(cursorleido["presup"]);
                proveedor.Text = Convert.ToString(cursorleido["proveedor"]);
                montoaut.Text = Convert.ToString(cursorleido["montoaut"]);
                montoacum.Text = Convert.ToString(cursorleido["montoacum"]);
                porcanti.Text = Convert.ToString(cursorleido["porcanti"]);

                tipoclte.Enabled = false;
                Lbl1montoaut.Visible = false;
                Lbl2montoaut.Visible = false;
                Lbl1montoacum.Visible = false;
                Lbl2montoacum.Visible = false;
                Lbl1porcanti.Visible = false;
                Lbl2porcanti.Visible = false;
                Lbl3porcanti.Visible = false;
                montoaut.Enabled = false;
                montoaut.Visible = false;
                montoacum.Enabled = false;
                montoacum.Visible = false;
                porcanti.Enabled = false;
                porcanti.Visible = false;

            }
            con.Close();
        }

        private void Btanterior_Click(object sender, EventArgs e)
        {
            con.Open();
            //   clte.Text = "";
            razon.Text = "";
            clte_lito.Text = "0";
            dig_lito.Text = "0";
            calle.Text = "";
            numext.Text = "";
            numint.Text = "";
            colonia.Text = "";
            delega.Text = "";
            estado.Text = "";
            pais.Text = "";
            telefono.Text = "";
            rfc.Text = "";
            cp.Text = "";
            atencion1.Text = "";
            atencion2.Text = "";
            atencion3.Text = "";
            atencion4.Text = "";
            atencion5.Text = "";
            nombre.Text = "";
            apellidop.Text = "";
            apellidom.Text = "";
            clave.Text = "";
            vendedor.Text = "";
            comisvend.Text = "0";
            rebate.Text = "0";
            comis30.Text = "0";
            comis60.Text = "0";
            comis90.Text = "0";
            comistarj.Text = "0";
            cargofin.Text = "0";
            diasrevi.Text = "";
            email.Text = "";
            porcmas.Text = "0";
            carta.Text = "";
            tipoclte.Text = "0";
            clave.Text = "";
            dsctopapel.Text = "0";
            dscto.Text = "0";
            diseno.Text = "0";
            plazo.Text = "0";
            lunhora.Text = "";
            marhora.Text = "";
            miehora.Text = "";
            juehora.Text = "";
            viehora.Text = "";
            lun.Checked = false;
            mar.Checked = false;
            mie.Checked = false;
            jue.Checked = false;
            vie.Checked = false;
            cuenta1.Text = "0";
            cuenta2.Text = "0";
            cuenta3.Text = "0";
            cuenta4.Text = "0";
            cuenta5.Text = "0";
            cuenta6.Text = "0";
            cuenta7.Text = "0";
            cuenta8.Text = "0";
            cuenta9.Text = "0";
            cuenta10.Text = "0";
            porefe.Text = "0";
            porche.Text = "0";
            portra.Text = "0";
            porcre.Text = "0";
            pormon.Text = "0";
            pordin.Text = "0";
            porval.Text = "0";
            pordeb.Text = "0";
            porser.Text = "0";
            porant.Text = "0";
            porotr.Text = "0";
            comen1.Text = "";
            comen2.Text = "";
            comen3.Text = "";
            comen4.Text = "";
            comen5.Text = "";
            comen6.Text = "";
            comen7.Text = "";
            comen8.Text = "";
            comen9.Text = "";
            comen10.Text = "";
            fpefe.Checked = false;
            fptra.Checked = false;
            fpche.Checked = false;
            fptdeb.Checked = false;
            fptcre.Checked = false;
            fptser.Checked = false;
            fpmon.Checked = false;
            fpno.Checked = false;
            fpnoa.Checked = false;
            solofact.Text = "";
            ordencpa.Text = "";
            presup.Text = "0";
            proveedor.Text = "";
            montoaut.Text = "0";
            montoacum.Text = "0";
            porcanti.Text = "0";


            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select top 1 clte,razon,clte_lito,dig_lito,calle,numext,numint, " +
            " colonia,delega,estado,pais,telefono,rfc,cp,atencion1,atencion2,atencion3,atencion4,atencion5," +
            " nombre,apellidop,apellidom,clave,vendedor,comisvend,rebate,comis30,comis60,comis90,comistarj,cargofin," +
            " diasrevi,email,porcmas,carta,tipoclte,clave,dsctopapel,dscto,diseno,plazo,lun,lunhora,mar,marhora,mie,miehora,jue,juehora,vie,viehora," +
            " cuenta1,cuenta2,cuenta3,cuenta4,cuenta5,cuenta6,cuenta7,cuenta8,cuenta9,cuenta10, " +
            " porefe,porche,portra,porcre,pormon,pordin,porval,pordeb,porser,porant,porotr, " +
            " comen1,comen2,comen3,comen4,comen5,comen6,comen7,comen8,comen9,comen10, " +
            " fpefe,fptra,fpche,fptdeb,fptcre,fptser,fpmon,fpno,fpnoa,solofact,ordencpa,presup,proveedor " +
                " from dbo.clientes where clte < '" + clte.Text + "' order by clte desc";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DGclientes.DataSource = dt;
            int cuenta = DGclientes.RowCount;
            if (cuenta == 0)
            {
                MessageBox.Show("Ya no hay registros", "Litografía Gil");
            }

            DGclientes.RowHeadersVisible = false;
            DGclientes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DGclientes.Columns[0].Width = 70;
            DGclientes.Columns[0].DefaultCellStyle.BackColor = Color.PowderBlue;
            DGclientes.Columns[0].HeaderText = "Clave";
            DGclientes.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGclientes.Columns[1].Width = 200;
            DGclientes.Columns[1].DefaultCellStyle.BackColor = Color.Beige;
            DGclientes.Columns[1].HeaderText = "Razón Social";
            DGclientes.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGclientes.Columns[2].Width = 35;
            DGclientes.Columns[2].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGclientes.Columns[2].HeaderText = "Conta";
            DGclientes.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DGclientes.Columns[3].Width = 20;
            DGclientes.Columns[3].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGclientes.Columns[3].HeaderText = "Dig";
            DGclientes.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DGclientes.Columns[4].Width = 120;
            DGclientes.Columns[4].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGclientes.Columns[4].HeaderText = "Calle";
            DGclientes.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGclientes.Columns[5].Width = 40;
            DGclientes.Columns[5].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGclientes.Columns[5].HeaderText = "No.Ext";
            DGclientes.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGclientes.Columns[6].Width = 40;
            DGclientes.Columns[6].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGclientes.Columns[6].HeaderText = "No.Int";
            DGclientes.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGclientes.Columns[7].Width = 80;
            DGclientes.Columns[7].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGclientes.Columns[7].HeaderText = "Colonia";
            DGclientes.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGclientes.Columns[8].Width = 80;
            DGclientes.Columns[8].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGclientes.Columns[8].HeaderText = "Delegación";
            DGclientes.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGclientes.Columns[9].Width = 80;
            DGclientes.Columns[9].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGclientes.Columns[9].HeaderText = "Estado";
            DGclientes.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGclientes.Columns[10].Width = 80;
            DGclientes.Columns[10].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGclientes.Columns[10].HeaderText = "Pais";
            DGclientes.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGclientes.Columns[11].Width = 80;
            DGclientes.Columns[11].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGclientes.Columns[11].HeaderText = "Teléfono";
            DGclientes.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGclientes.Columns[12].Width = 80;
            DGclientes.Columns[12].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGclientes.Columns[12].HeaderText = "RFC";
            DGclientes.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGclientes.Columns[13].Width = 40;
            DGclientes.Columns[13].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGclientes.Columns[13].HeaderText = "CP";
            DGclientes.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            SqlCommand cursor = new SqlCommand("select top 1 clte,razon,clte_lito,dig_lito,calle,numext,numint, " +
            " colonia,delega,estado,pais,telefono,rfc,cp,atencion1,atencion2,atencion3,atencion4,atencion5,  " +
            " nombre,apellidop,apellidom,clave,vendedor,comisvend,rebate,comis30,comis60,comis90,comistarj,cargofin," +
            " diasrevi,email,porcmas,carta,tipoclte,clave,dsctopapel,dscto,diseno,plazo,lun,lunhora,mar,marhora,mie,miehora,jue,juehora,vie,viehora," +
            " cuenta1,cuenta2,cuenta3,cuenta4,cuenta5,cuenta6,cuenta7,cuenta8,cuenta9,cuenta10, " +
            " porefe,porche,portra,porcre,pormon,pordin,porval,pordeb,porser,porant,porotr, " +
            " comen1,comen2,comen3,comen4,comen5,comen6,comen7,comen8,comen9,comen10, " +
            " fpefe,fptra,fpche,fptdeb,fptcre,fptser,fpmon,fpno,fpnoa,solofact,ordencpa,presup,proveedor,montoaut,montoacum,porcanti " +
                "  from dbo.clientes where clte < '" + clte.Text + "'  order by clte desc", con);

            SqlDataReader cursorleido = cursor.ExecuteReader();
            while (cursorleido.Read())
            {
                clte.Text = Convert.ToString(cursorleido["clte"]);
                razon.Text = Convert.ToString(cursorleido["razon"]);
                clte_lito.Text = Convert.ToString(cursorleido["clte_lito"]);
                dig_lito.Text = Convert.ToString(cursorleido["dig_lito"]);
                calle.Text = Convert.ToString(cursorleido["calle"]);
                numext.Text = Convert.ToString(cursorleido["numext"]);
                numint.Text = Convert.ToString(cursorleido["numint"]);
                colonia.Text = Convert.ToString(cursorleido["colonia"]);
                delega.Text = Convert.ToString(cursorleido["delega"]);
                estado.Text = Convert.ToString(cursorleido["estado"]);
                pais.Text = Convert.ToString(cursorleido["pais"]);
                telefono.Text = Convert.ToString(cursorleido["telefono"]);
                rfc.Text = Convert.ToString(cursorleido["rfc"]);
                cp.Text = Convert.ToString(cursorleido["cp"]);
                atencion1.Text = Convert.ToString(cursorleido["atencion1"]);
                atencion2.Text = Convert.ToString(cursorleido["atencion2"]);
                atencion3.Text = Convert.ToString(cursorleido["atencion3"]);
                atencion4.Text = Convert.ToString(cursorleido["atencion4"]);
                atencion5.Text = Convert.ToString(cursorleido["atencion5"]);
                nombre.Text = Convert.ToString(cursorleido["nombre"]);
                apellidop.Text = Convert.ToString(cursorleido["apellidop"]);
                apellidom.Text = Convert.ToString(cursorleido["apellidom"]);
                clave.Text = Convert.ToString(cursorleido["clave"]);
                vendedor.Text = Convert.ToString(cursorleido["vendedor"]);
                comisvend.Text = Convert.ToString(cursorleido["comisvend"]);
                rebate.Text = Convert.ToString(cursorleido["rebate"]);
                comis30.Text = Convert.ToString(cursorleido["comis30"]);
                comis60.Text = Convert.ToString(cursorleido["comis60"]);
                comis90.Text = Convert.ToString(cursorleido["comis90"]);
                comistarj.Text = Convert.ToString(cursorleido["comistarj"]);
                cargofin.Text = Convert.ToString(cursorleido["cargofin"]);
                diasrevi.Text = Convert.ToString(cursorleido["diasrevi"]);
                email.Text = Convert.ToString(cursorleido["email"]);
                porcmas.Text = Convert.ToString(cursorleido["porcmas"]);
                carta.Text = Convert.ToString(cursorleido["carta"]);
                clave.Text = Convert.ToString(cursorleido["clave"]);
                dsctopapel.Text = Convert.ToString(cursorleido["dsctopapel"]);
                dscto.Text = Convert.ToString(cursorleido["dscto"]);
                diseno.Text = Convert.ToString(cursorleido["diseno"]);
                plazo.Text = Convert.ToString(cursorleido["plazo"]);
                lunhora.Text = Convert.ToString(cursorleido["lunhora"]);
                marhora.Text = Convert.ToString(cursorleido["marhora"]);
                miehora.Text = Convert.ToString(cursorleido["miehora"]);
                juehora.Text = Convert.ToString(cursorleido["juehora"]);
                viehora.Text = Convert.ToString(cursorleido["viehora"]);
                //    lun.Checked = Convert.ToBoolean(cursorleido["lun"]);
                //    mar.Checked = Convert.ToBoolean(cursorleido["mar"]);
                //mie.Checked = Convert.ToBoolean(cursorleido["mie"]);
                //jue.Checked = Convert.ToBoolean(cursorleido["jue"]);
                //vie.Checked = Convert.ToBoolean(cursorleido["vie"]);
                cuenta1.Text = Convert.ToString(cursorleido["cuenta1"]);
                cuenta2.Text = Convert.ToString(cursorleido["cuenta2"]);
                cuenta3.Text = Convert.ToString(cursorleido["cuenta3"]);
                cuenta4.Text = Convert.ToString(cursorleido["cuenta4"]);
                cuenta5.Text = Convert.ToString(cursorleido["cuenta5"]);
                cuenta6.Text = Convert.ToString(cursorleido["cuenta6"]);
                cuenta7.Text = Convert.ToString(cursorleido["cuenta7"]);
                cuenta8.Text = Convert.ToString(cursorleido["cuenta8"]);
                cuenta9.Text = Convert.ToString(cursorleido["cuenta9"]);
                cuenta10.Text = Convert.ToString(cursorleido["cuenta10"]);
                //porefe.Text = Convert.ToString(cursorleido["porefe"]);
                //porche.Text = Convert.ToString(cursorleido["porche"]);
                //portra.Text = Convert.ToString(cursorleido["portra"]);
                //porcre.Text = Convert.ToString(cursorleido["porcre"]);
                //pormon.Text = Convert.ToString(cursorleido["pormon"]);
                //pordin.Text = Convert.ToString(cursorleido["pordin"]);
                //porval.Text = Convert.ToString(cursorleido["porval"]);
                //pordeb.Text = Convert.ToString(cursorleido["pordeb"]);
                porser.Text = Convert.ToString(cursorleido["porser"]);
                porant.Text = Convert.ToString(cursorleido["porant"]);
                porotr.Text = Convert.ToString(cursorleido["porotr"]);
                comen1.Text = Convert.ToString(cursorleido["comen1"]);
                comen2.Text = Convert.ToString(cursorleido["comen2"]);
                comen3.Text = Convert.ToString(cursorleido["comen3"]);
                comen4.Text = Convert.ToString(cursorleido["comen4"]);
                comen5.Text = Convert.ToString(cursorleido["comen5"]);
                comen6.Text = Convert.ToString(cursorleido["comen6"]);
                comen7.Text = Convert.ToString(cursorleido["comen7"]);
                comen8.Text = Convert.ToString(cursorleido["comen8"]);
                comen9.Text = Convert.ToString(cursorleido["comen9"]);
                comen10.Text = Convert.ToString(cursorleido["comen10"]);
              //  fpefe.Checked = Convert.ToBoolean(cursorleido["fpefe"]);
              //  fptra.Checked = Convert.ToBoolean(cursorleido["fptra"]);
              //  fpche.Checked = Convert.ToBoolean(cursorleido["fpche"]);
              //  fptdeb.Checked = Convert.ToBoolean(cursorleido["fptdeb"]);
              //  fptcre.Checked = Convert.ToBoolean(cursorleido["fptcre"]);
              //  fptser.Checked = Convert.ToBoolean(cursorleido["fptser"]);
              //  fpmon.Checked = Convert.ToBoolean(cursorleido["fpmon"]);
              //  fpno.Checked = Convert.ToBoolean(cursorleido["fpno"]);
              //  fpnoa.Checked = Convert.ToBoolean(cursorleido["fpnoa"]);
                solofact.Text = Convert.ToString(cursorleido["solofact"]);
                ordencpa.Text = Convert.ToString(cursorleido["ordencpa"]);
                presup.Text = Convert.ToString(cursorleido["presup"]);
                proveedor.Text = Convert.ToString(cursorleido["proveedor"]);
                montoaut.Text = Convert.ToString(cursorleido["montoaut"]);
                montoacum.Text = Convert.ToString(cursorleido["montoacum"]);
                porcanti.Text = Convert.ToString(cursorleido["porcanti"]);

                tipoclte.Enabled = false;
                Lbl1montoaut.Visible = false;
                Lbl2montoaut.Visible = false;
                Lbl1montoacum.Visible = false;
                Lbl2montoacum.Visible = false;
                Lbl1porcanti.Visible = false;
                Lbl2porcanti.Visible = false;
                Lbl3porcanti.Visible = false;
                montoaut.Enabled = false;
                montoaut.Visible = false;
                montoacum.Enabled = false;
                montoacum.Visible = false;
                porcanti.Enabled = false;
                porcanti.Visible = false;

            }
            con.Close();


        }

        private void Btsiquiente_Click(object sender, EventArgs e)
        {
            con.Open();
            //    clte.Text = "";
            razon.Text = "";
            clte_lito.Text = "0";
            dig_lito.Text = "0";
            calle.Text = "";
            numext.Text = "";
            numint.Text = "";
            colonia.Text = "";
            delega.Text = "";
            estado.Text = "";
            pais.Text = "";
            telefono.Text = "";
            rfc.Text = "";
            cp.Text = "";
            atencion1.Text = "";
            atencion2.Text = "";
            atencion3.Text = "";
            atencion4.Text = "";
            atencion5.Text = "";
            nombre.Text = "";
            apellidop.Text = "";
            apellidom.Text = "";
            clave.Text = "";
            vendedor.Text = "";
            comisvend.Text = "0";
            rebate.Text = "0";
            comis30.Text = "0";
            comis60.Text = "0";
            comis90.Text = "0";
            comistarj.Text = "0";
            cargofin.Text = "0";
            diasrevi.Text = "";
            email.Text = "";
            porcmas.Text = "0";
            carta.Text = "";
            tipoclte.Text = "0";
            clave.Text = "";
            dsctopapel.Text = "0";
            dscto.Text = "0";
            diseno.Text = "0";
            plazo.Text = "0";
            lunhora.Text = "";
            marhora.Text = "";
            miehora.Text = "";
            juehora.Text = "";
            viehora.Text = "";
            lun.Checked = false;
            mar.Checked = false;
            mie.Checked = false;
            jue.Checked = false;
            vie.Checked = false;
            cuenta1.Text = "0";
            cuenta2.Text = "0";
            cuenta3.Text = "0";
            cuenta4.Text = "0";
            cuenta5.Text = "0";
            cuenta6.Text = "0";
            cuenta7.Text = "0";
            cuenta8.Text = "0";
            cuenta9.Text = "0";
            cuenta10.Text = "0";
            porefe.Text = "0";
            porche.Text = "0";
            portra.Text = "0";
            porcre.Text = "0";
            pormon.Text = "0";
            pordin.Text = "0";
            porval.Text = "0";
            pordeb.Text = "0";
            porser.Text = "0";
            porant.Text = "0";
            porotr.Text = "0";
            comen1.Text = "";
            comen2.Text = "";
            comen3.Text = "";
            comen4.Text = "";
            comen5.Text = "";
            comen6.Text = "";
            comen7.Text = "";
            comen8.Text = "";
            comen9.Text = "";
            comen10.Text = "";
            fpefe.Checked = false;
            fptra.Checked = false;
            fpche.Checked = false;
            fptdeb.Checked = false;
            fptcre.Checked = false;
            fptser.Checked = false;
            fpmon.Checked = false;
            fpno.Checked = false;
            fpnoa.Checked = false;
            solofact.Text = "";
            ordencpa.Text = "";
            presup.Text = "0";
            proveedor.Text = "";
            montoaut.Text = "0";
            montoacum.Text = "0";
            porcanti.Text = "0";



            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select top 1 clte,razon,clte_lito,dig_lito,calle,numext,numint, " +
            " colonia,delega,estado,pais,telefono,rfc,cp,atencion1,atencion2,atencion3,atencion4,atencion5, " +
            " nombre,apellidop,apellidom,clave,vendedor,comisvend,rebate,comis30,comis60,comis90,comistarj,cargofin, " +
            " diasrevi,email,porcmas,carta,tipoclte,clave,dsctopapel,dscto,diseno,plazo,lun,lunhora,mar,marhora,mie,miehora,jue,juehora,vie,viehora," +
            " cuenta1,cuenta2,cuenta3,cuenta4,cuenta5,cuenta6,cuenta7,cuenta8,cuenta9,cuenta10, " +
            " porefe,porche,portra,porcre,pormon,pordin,porval,pordeb,porser,porant,porotr, " +
            " comen1,comen2,comen3,comen4,comen5,comen6,comen7,comen8,comen9,comen10, " +
            " fpefe,fptra,fpche,fptdeb,fptcre,fptser,fpmon,fpno,fpnoa,solofact,ordencpa,presup,proveedor " +

                " from dbo.clientes where clte > '" + clte.Text + "' order by clte ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DGclientes.DataSource = dt;
            int cuenta = DGclientes.RowCount;
            if (cuenta == 0)
            {
                MessageBox.Show("Ya no hay registros", "Litografía Gil");
            }

            DGclientes.RowHeadersVisible = false;
            DGclientes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DGclientes.Columns[0].Width = 70;
            DGclientes.Columns[0].DefaultCellStyle.BackColor = Color.PowderBlue;
            DGclientes.Columns[0].HeaderText = "Clave";
            DGclientes.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGclientes.Columns[1].Width = 200;
            DGclientes.Columns[1].DefaultCellStyle.BackColor = Color.Beige;
            DGclientes.Columns[1].HeaderText = "Razón Social";
            DGclientes.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGclientes.Columns[2].Width = 35;
            DGclientes.Columns[2].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGclientes.Columns[2].HeaderText = "Conta";
            DGclientes.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DGclientes.Columns[3].Width = 20;
            DGclientes.Columns[3].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGclientes.Columns[3].HeaderText = "Dig";
            DGclientes.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DGclientes.Columns[4].Width = 120;
            DGclientes.Columns[4].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGclientes.Columns[4].HeaderText = "Calle";
            DGclientes.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGclientes.Columns[5].Width = 40;
            DGclientes.Columns[5].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGclientes.Columns[5].HeaderText = "No.Ext";
            DGclientes.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGclientes.Columns[6].Width = 40;
            DGclientes.Columns[6].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGclientes.Columns[6].HeaderText = "No.Int";
            DGclientes.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGclientes.Columns[7].Width = 80;
            DGclientes.Columns[7].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGclientes.Columns[7].HeaderText = "Colonia";
            DGclientes.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGclientes.Columns[8].Width = 80;
            DGclientes.Columns[8].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGclientes.Columns[8].HeaderText = "Delegación";
            DGclientes.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGclientes.Columns[9].Width = 80;
            DGclientes.Columns[9].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGclientes.Columns[9].HeaderText = "Estado";
            DGclientes.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGclientes.Columns[10].Width = 80;
            DGclientes.Columns[10].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGclientes.Columns[10].HeaderText = "Pais";
            DGclientes.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGclientes.Columns[11].Width = 80;
            DGclientes.Columns[11].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGclientes.Columns[11].HeaderText = "Teléfono";
            DGclientes.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGclientes.Columns[12].Width = 80;
            DGclientes.Columns[12].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGclientes.Columns[12].HeaderText = "RFC";
            DGclientes.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DGclientes.Columns[13].Width = 40;
            DGclientes.Columns[13].DefaultCellStyle.BackColor = Color.PapayaWhip;
            DGclientes.Columns[13].HeaderText = "CP";
            DGclientes.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            SqlCommand cursor = new SqlCommand("select top 1 clte,razon,clte_lito,dig_lito,calle,numext,numint, " +
            " colonia,delega,estado,pais,telefono,rfc,cp,atencion1,atencion2,atencion3,atencion4,atencion5, " +
            " nombre,apellidop,apellidom,clave,vendedor,comisvend,rebate,comis30,comis60,comis90,comistarj,cargofin," +
            " diasrevi,email,porcmas,carta,tipoclte,clave,dsctopapel,dscto,diseno,plazo,lun,lunhora,mar,marhora,mie,miehora,jue,juehora,vie,viehora," +
            " cuenta1,cuenta2,cuenta3,cuenta4,cuenta5,cuenta6,cuenta7,cuenta8,cuenta9,cuenta10, " +
            " porefe,porche,portra,porcre,pormon,pordin,porval,pordeb,porser,porant,porotr, " +
            " comen1,comen2,comen3,comen4,comen5,comen6,comen7,comen8,comen9,comen10, " +
            " fpefe,fptra,fpche,fptdeb,fptcre,fptser,fpmon,fpno,fpnoa,solofact,ordencpa,presup,proveedor,montoaut,montoacum,porcanti " +
            "  from dbo.clientes where clte > '" + clte.Text + "'  order by clte", con);

            SqlDataReader cursorleido = cursor.ExecuteReader();
            while (cursorleido.Read())
            {
                clte.Text = Convert.ToString(cursorleido["clte"]);
                razon.Text = Convert.ToString(cursorleido["razon"]);
                clte_lito.Text = Convert.ToString(cursorleido["clte_lito"]);
                dig_lito.Text = Convert.ToString(cursorleido["dig_lito"]);
                calle.Text = Convert.ToString(cursorleido["calle"]);
                numext.Text = Convert.ToString(cursorleido["numext"]);
                numint.Text = Convert.ToString(cursorleido["numint"]);
                colonia.Text = Convert.ToString(cursorleido["colonia"]);
                delega.Text = Convert.ToString(cursorleido["delega"]);
                estado.Text = Convert.ToString(cursorleido["estado"]);
                pais.Text = Convert.ToString(cursorleido["pais"]);
                telefono.Text = Convert.ToString(cursorleido["telefono"]);
                rfc.Text = Convert.ToString(cursorleido["rfc"]);
                cp.Text = Convert.ToString(cursorleido["cp"]);
                atencion1.Text = Convert.ToString(cursorleido["atencion1"]);
                atencion2.Text = Convert.ToString(cursorleido["atencion2"]);
                atencion3.Text = Convert.ToString(cursorleido["atencion3"]);
                atencion4.Text = Convert.ToString(cursorleido["atencion4"]);
                atencion5.Text = Convert.ToString(cursorleido["atencion5"]);
                nombre.Text = Convert.ToString(cursorleido["nombre"]);
                apellidop.Text = Convert.ToString(cursorleido["apellidop"]);
                apellidom.Text = Convert.ToString(cursorleido["apellidom"]);
                clave.Text = Convert.ToString(cursorleido["clave"]);
                vendedor.Text = Convert.ToString(cursorleido["vendedor"]);
                comisvend.Text = Convert.ToString(cursorleido["comisvend"]);
                rebate.Text = Convert.ToString(cursorleido["rebate"]);
                comis30.Text = Convert.ToString(cursorleido["comis30"]);
                comis60.Text = Convert.ToString(cursorleido["comis60"]);
                comis90.Text = Convert.ToString(cursorleido["comis90"]);
                comistarj.Text = Convert.ToString(cursorleido["comistarj"]);
                cargofin.Text = Convert.ToString(cursorleido["cargofin"]);
                diasrevi.Text = Convert.ToString(cursorleido["diasrevi"]);
                email.Text = Convert.ToString(cursorleido["email"]);
                porcmas.Text = Convert.ToString(cursorleido["porcmas"]);
                carta.Text = Convert.ToString(cursorleido["carta"]);
                clave.Text = Convert.ToString(cursorleido["clave"]);
                dsctopapel.Text = Convert.ToString(cursorleido["dsctopapel"]);
                dscto.Text = Convert.ToString(cursorleido["dscto"]);
                diseno.Text = Convert.ToString(cursorleido["diseno"]);
                plazo.Text = Convert.ToString(cursorleido["plazo"]);
                lunhora.Text = Convert.ToString(cursorleido["lunhora"]);
                marhora.Text = Convert.ToString(cursorleido["marhora"]);
                miehora.Text = Convert.ToString(cursorleido["miehora"]);
                juehora.Text = Convert.ToString(cursorleido["juehora"]);
                viehora.Text = Convert.ToString(cursorleido["viehora"]);
            //    lun.Checked = Convert.ToBoolean(cursorleido["lun"]);
            //    mar.Checked = Convert.ToBoolean(cursorleido["mar"]);
            //    mie.Checked = Convert.ToBoolean(cursorleido["mie"]);
            //    jue.Checked = Convert.ToBoolean(cursorleido["jue"]);
            //    vie.Checked = Convert.ToBoolean(cursorleido["vie"]);
                cuenta1.Text = Convert.ToString(cursorleido["cuenta1"]);
                cuenta2.Text = Convert.ToString(cursorleido["cuenta2"]);
                cuenta3.Text = Convert.ToString(cursorleido["cuenta3"]);
                cuenta4.Text = Convert.ToString(cursorleido["cuenta4"]);
                cuenta5.Text = Convert.ToString(cursorleido["cuenta5"]);
                cuenta6.Text = Convert.ToString(cursorleido["cuenta6"]);
                cuenta7.Text = Convert.ToString(cursorleido["cuenta7"]);
                cuenta8.Text = Convert.ToString(cursorleido["cuenta8"]);
                cuenta9.Text = Convert.ToString(cursorleido["cuenta9"]);
                cuenta10.Text = Convert.ToString(cursorleido["cuenta10"]);
                porefe.Text = Convert.ToString(cursorleido["porefe"]);
                porche.Text = Convert.ToString(cursorleido["porche"]);
                portra.Text = Convert.ToString(cursorleido["portra"]);
                porcre.Text = Convert.ToString(cursorleido["porcre"]);
                pormon.Text = Convert.ToString(cursorleido["pormon"]);
                pordin.Text = Convert.ToString(cursorleido["pordin"]);
                porval.Text = Convert.ToString(cursorleido["porval"]);
                pordeb.Text = Convert.ToString(cursorleido["pordeb"]);
                porser.Text = Convert.ToString(cursorleido["porser"]);
                porant.Text = Convert.ToString(cursorleido["porant"]);
                porotr.Text = Convert.ToString(cursorleido["porotr"]);
                comen1.Text = Convert.ToString(cursorleido["comen1"]);
                comen2.Text = Convert.ToString(cursorleido["comen2"]);
                comen3.Text = Convert.ToString(cursorleido["comen3"]);
                comen4.Text = Convert.ToString(cursorleido["comen4"]);
                comen5.Text = Convert.ToString(cursorleido["comen5"]);
                comen6.Text = Convert.ToString(cursorleido["comen6"]);
                comen7.Text = Convert.ToString(cursorleido["comen7"]);
                comen8.Text = Convert.ToString(cursorleido["comen8"]);
                comen9.Text = Convert.ToString(cursorleido["comen9"]);
                comen10.Text = Convert.ToString(cursorleido["comen10"]);
            //    fpefe.Checked = Convert.ToBoolean(cursorleido["fpefe"]);
            //    fptra.Checked = Convert.ToBoolean(cursorleido["fptra"]);
            //    fpche.Checked = Convert.ToBoolean(cursorleido["fpche"]);
            //    fptdeb.Checked = Convert.ToBoolean(cursorleido["fptdeb"]);
            //    fptcre.Checked = Convert.ToBoolean(cursorleido["fptcre"]);
            //    fptser.Checked = Convert.ToBoolean(cursorleido["fptser"]);
            //    fpmon.Checked = Convert.ToBoolean(cursorleido["fpmon"]);
            //    fpno.Checked = Convert.ToBoolean(cursorleido["fpno"]);
            //    fpnoa.Checked = Convert.ToBoolean(cursorleido["fpnoa"]);
                solofact.Text = Convert.ToString(cursorleido["solofact"]);
                ordencpa.Text = Convert.ToString(cursorleido["ordencpa"]);
                presup.Text = Convert.ToString(cursorleido["presup"]);
                proveedor.Text = Convert.ToString(cursorleido["proveedor"]);
                montoaut.Text = Convert.ToString(cursorleido["montoaut"]);
                montoacum.Text = Convert.ToString(cursorleido["montoacum"]);
                porcanti.Text = Convert.ToString(cursorleido["porcanti"]);

                tipoclte.Enabled = false;
                Lbl1montoaut.Visible = false;
                Lbl2montoaut.Visible = false;
                Lbl1montoacum.Visible = false;
                Lbl2montoacum.Visible = false;
                Lbl1porcanti.Visible = false;
                Lbl2porcanti.Visible = false;
                Lbl3porcanti.Visible = false;
                montoaut.Enabled = false;
                montoaut.Visible = false;
                montoacum.Enabled = false;
                montoacum.Visible = false;
                porcanti.Enabled = false;
                porcanti.Visible = false;

            }
            con.Close();

        }

        private void Btconsulta_Click(object sender, EventArgs e)
        {
            if (cltecons.Text == "")
            {
                MessageBox.Show("Falta poner la clave del cliente...!");
            }
            else
            {
                con.Close();
                con.Open();
                clte.Text = "";
                razon.Text = "";
                clte_lito.Text = "0";
                dig_lito.Text = "0";
                calle.Text = "";
                numext.Text = "";
                numint.Text = "";
                colonia.Text = "";
                delega.Text = "";
                estado.Text = "";
                pais.Text = "";
                telefono.Text = "";
                rfc.Text = "";
                cp.Text = "";
                atencion1.Text = "";
                atencion2.Text = "";
                atencion3.Text = "";
                atencion4.Text = "";
                atencion5.Text = "";
                nombre.Text = "";
                apellidop.Text = "";
                apellidom.Text = "";
                clave.Text = "";
                vendedor.Text = "";
                comisvend.Text = "0";
                rebate.Text = "0";
                comis30.Text = "0";
                comis60.Text = "0";
                comis90.Text = "0";
                comistarj.Text = "0";
                cargofin.Text = "0";
                diasrevi.Text = "";
                email.Text = "";
                porcmas.Text = "0";
                carta.Text = "";
                tipoclte.Text = "0";
                clave.Text = "";
                dsctopapel.Text = "0";
                dscto.Text = "0";
                diseno.Text = "0";
                plazo.Text = "0";
                lunhora.Text = "";
                marhora.Text = "";
                miehora.Text = "";
                juehora.Text = "";
                viehora.Text = "";
                lun.Checked = false;
                mar.Checked = false;
                mie.Checked = false;
                jue.Checked = false;
                vie.Checked = false;
                cuenta1.Text = "0";
                cuenta2.Text = "0";
                cuenta3.Text = "0";
                cuenta4.Text = "0";
                cuenta5.Text = "0";
                cuenta6.Text = "0";
                cuenta7.Text = "0";
                cuenta8.Text = "0";
                cuenta9.Text = "0";
                cuenta10.Text = "0";
                porefe.Text = "0";
                porche.Text = "0";
                portra.Text = "0";
                porcre.Text = "0";
                pormon.Text = "0";
                pordin.Text = "0";
                porval.Text = "0";
                pordeb.Text = "0";
                porser.Text = "0";
                porant.Text = "0";
                porotr.Text = "0";
                comen1.Text = "";
                comen2.Text = "";
                comen3.Text = "";
                comen4.Text = "";
                comen5.Text = "";
                comen6.Text = "";
                comen7.Text = "";
                comen8.Text = "";
                comen9.Text = "";
                comen10.Text = "";
                fpefe.Checked = false;
                fptra.Checked = false;
                fpche.Checked = false;
                fptdeb.Checked = false;
                fptcre.Checked = false;
                fptser.Checked = false;
                fpmon.Checked = false;
                fpno.Checked = false;
                fpnoa.Checked = false;
                solofact.Text = "";
                ordencpa.Text = "";
                presup.Text = "0";
                proveedor.Text = "";
                montoaut.Text = "0";
                montoacum.Text = "0";
                porcanti.Text = "0";

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select clte,razon,clte_lito,dig_lito,calle,numext,numint, " +
                " colonia,delega,estado,pais,telefono,rfc,cp,atencion1,atencion2,atencion3,atencion4,atencion5, " +
                " nombre,apellidop,apellidom,clave,vendedor,comisvend,rebate,comis30,comis60,comis90,comistarj,cargofin," +
                " diasrevi,email,porcmas,carta,tipoclte,clave,dsctopapel,dscto,diseno,plazo,lun,lunhora,mar,marhora,mie,miehora,jue,juehora,vie,viehora," +
                " cuenta1,cuenta2,cuenta3,cuenta4,cuenta5,cuenta6,cuenta7,cuenta8,cuenta9,cuenta10, " +
                " porefe,porche,portra,porcre,pormon,pordin,porval,pordeb,porser,porant,porotr, " +
                " comen1,comen2,comen3,comen4,comen5,comen6,comen7,comen8,comen9,comen10, " +
                " fpefe,fptra,fpche,fptdeb,fptcre,fptser,fpmon,fpno,fpnoa,solofact,ordencpa,presup,proveedor " +
                " from dbo.clientes where clte like '" + cltecons.Text + "%' ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {

                    DGclientes.RowHeadersVisible = false;
                    DGclientes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    DGclientes.Columns[0].Width = 70;
                    DGclientes.Columns[0].DefaultCellStyle.BackColor = Color.PowderBlue;
                    DGclientes.Columns[0].HeaderText = "Clave";
                    DGclientes.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    DGclientes.Columns[1].Width = 200;
                    DGclientes.Columns[1].DefaultCellStyle.BackColor = Color.Beige;
                    DGclientes.Columns[1].HeaderText = "Razón Social";
                    DGclientes.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    DGclientes.Columns[2].Width = 35;
                    DGclientes.Columns[2].DefaultCellStyle.BackColor = Color.PapayaWhip;
                    DGclientes.Columns[2].HeaderText = "Conta";
                    DGclientes.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                    DGclientes.Columns[3].Width = 20;
                    DGclientes.Columns[3].DefaultCellStyle.BackColor = Color.PapayaWhip;
                    DGclientes.Columns[3].HeaderText = "Dig";
                    DGclientes.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                    DGclientes.Columns[4].Width = 120;
                    DGclientes.Columns[4].DefaultCellStyle.BackColor = Color.PapayaWhip;
                    DGclientes.Columns[4].HeaderText = "Calle";
                    DGclientes.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    DGclientes.Columns[5].Width = 40;
                    DGclientes.Columns[5].DefaultCellStyle.BackColor = Color.PapayaWhip;
                    DGclientes.Columns[5].HeaderText = "No.Ext";
                    DGclientes.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    DGclientes.Columns[6].Width = 40;
                    DGclientes.Columns[6].DefaultCellStyle.BackColor = Color.PapayaWhip;
                    DGclientes.Columns[6].HeaderText = "No.Int";
                    DGclientes.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    DGclientes.Columns[7].Width = 80;
                    DGclientes.Columns[7].DefaultCellStyle.BackColor = Color.PapayaWhip;
                    DGclientes.Columns[7].HeaderText = "Colonia";
                    DGclientes.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    DGclientes.Columns[8].Width = 80;
                    DGclientes.Columns[8].DefaultCellStyle.BackColor = Color.PapayaWhip;
                    DGclientes.Columns[8].HeaderText = "Delegación";
                    DGclientes.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    DGclientes.Columns[9].Width = 80;
                    DGclientes.Columns[9].DefaultCellStyle.BackColor = Color.PapayaWhip;
                    DGclientes.Columns[9].HeaderText = "Estado";
                    DGclientes.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    DGclientes.Columns[10].Width = 80;
                    DGclientes.Columns[10].DefaultCellStyle.BackColor = Color.PapayaWhip;
                    DGclientes.Columns[10].HeaderText = "Pais";
                    DGclientes.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    DGclientes.Columns[11].Width = 80;
                    DGclientes.Columns[11].DefaultCellStyle.BackColor = Color.PapayaWhip;
                    DGclientes.Columns[11].HeaderText = "Teléfono";
                    DGclientes.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    DGclientes.Columns[12].Width = 80;
                    DGclientes.Columns[12].DefaultCellStyle.BackColor = Color.PapayaWhip;
                    DGclientes.Columns[12].HeaderText = "RFC";
                    DGclientes.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    DGclientes.Columns[13].Width = 40;
                    DGclientes.Columns[13].DefaultCellStyle.BackColor = Color.PapayaWhip;
                    DGclientes.Columns[13].HeaderText = "CP";
                    DGclientes.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;


                    SqlCommand cursor = new SqlCommand("select clte,razon,clte_lito,dig_lito,calle,numext,numint, " +
                    " colonia,delega,estado,pais,telefono,rfc,cp,atencion1,atencion2,atencion3,atencion4,atencion5,  " +
                    " nombre,apellidop,apellidom,clave,vendedor,comisvend,rebate,comis30,comis60,comis90,comistarj,cargofin, " +
                    " diasrevi,email,porcmas,carta,tipoclte,clave,dsctopapel,dscto,diseno,plazo,lun,lunhora,mar,marhora,mie,miehora,jue,juehora,vie,viehora," +
                    " cuenta1,cuenta2,cuenta3,cuenta4,cuenta5,cuenta6,cuenta7,cuenta8,cuenta9,cuenta10, " +
                    " porefe,porche,portra,porcre,pormon,pordin,porval,pordeb,porser,porant,porotr, " +
                    " comen1,comen2,comen3,comen4,comen5,comen6,comen7,comen8,comen9,comen10, " +
                    " fpefe,fptra,fpche,fptdeb,fptcre,fptser,fpmon,fpno,fpnoa,solofact,ordencpa,presup,proveedor,montoaut,montoacum,porcanti " +
                    "  from dbo.clientes where clte = '" + cltecons.Text + "' ", con);
                    SqlDataReader cursorleido = cursor.ExecuteReader();
                    while (cursorleido.Read())
                    {
                        clte.Text = Convert.ToString(cursorleido["clte"]);
                        razon.Text = Convert.ToString(cursorleido["razon"]);
                        clte_lito.Text = Convert.ToString(cursorleido["clte_lito"]);
                        dig_lito.Text = Convert.ToString(cursorleido["dig_lito"]);
                        calle.Text = Convert.ToString(cursorleido["calle"]);
                        numext.Text = Convert.ToString(cursorleido["numext"]);
                        numint.Text = Convert.ToString(cursorleido["numint"]);
                        colonia.Text = Convert.ToString(cursorleido["colonia"]);
                        delega.Text = Convert.ToString(cursorleido["delega"]);
                        estado.Text = Convert.ToString(cursorleido["estado"]);
                        pais.Text = Convert.ToString(cursorleido["pais"]);
                        telefono.Text = Convert.ToString(cursorleido["telefono"]);
                        rfc.Text = Convert.ToString(cursorleido["rfc"]);
                        cp.Text = Convert.ToString(cursorleido["cp"]);
                        atencion1.Text = Convert.ToString(cursorleido["atencion1"]);
                        atencion2.Text = Convert.ToString(cursorleido["atencion2"]);
                        atencion3.Text = Convert.ToString(cursorleido["atencion3"]);
                        atencion4.Text = Convert.ToString(cursorleido["atencion4"]);
                        atencion5.Text = Convert.ToString(cursorleido["atencion5"]);
                        nombre.Text = Convert.ToString(cursorleido["nombre"]);
                        apellidop.Text = Convert.ToString(cursorleido["apellidop"]);
                        apellidom.Text = Convert.ToString(cursorleido["apellidom"]);
                        clave.Text = Convert.ToString(cursorleido["clave"]);
                        vendedor.Text = Convert.ToString(cursorleido["vendedor"]);
                        comisvend.Text = Convert.ToString(cursorleido["comisvend"]);
                        rebate.Text = Convert.ToString(cursorleido["rebate"]);
                        comis30.Text = Convert.ToString(cursorleido["comis30"]);
                        comis60.Text = Convert.ToString(cursorleido["comis60"]);
                        comis90.Text = Convert.ToString(cursorleido["comis90"]);
                        comistarj.Text = Convert.ToString(cursorleido["comistarj"]);
                        cargofin.Text = Convert.ToString(cursorleido["cargofin"]);
                        diasrevi.Text = Convert.ToString(cursorleido["diasrevi"]);
                        email.Text = Convert.ToString(cursorleido["email"]);
                        porcmas.Text = Convert.ToString(cursorleido["porcmas"]);
                        carta.Text = Convert.ToString(cursorleido["carta"]);
                        clave.Text = Convert.ToString(cursorleido["clave"]);
                        dsctopapel.Text = Convert.ToString(cursorleido["dsctopapel"]);
                        dscto.Text = Convert.ToString(cursorleido["dscto"]);
                        diseno.Text = Convert.ToString(cursorleido["diseno"]);
                        plazo.Text = Convert.ToString(cursorleido["plazo"]);
                        lunhora.Text = Convert.ToString(cursorleido["lunhora"]);
                        marhora.Text = Convert.ToString(cursorleido["marhora"]);
                        miehora.Text = Convert.ToString(cursorleido["miehora"]);
                        juehora.Text = Convert.ToString(cursorleido["juehora"]);
                        viehora.Text = Convert.ToString(cursorleido["viehora"]);
                        lun.Checked = Convert.ToBoolean(cursorleido["lun"]);
                        mar.Checked = Convert.ToBoolean(cursorleido["mar"]);
                        mie.Checked = Convert.ToBoolean(cursorleido["mie"]);
                        jue.Checked = Convert.ToBoolean(cursorleido["jue"]);
                        vie.Checked = Convert.ToBoolean(cursorleido["vie"]);
                        cuenta1.Text = Convert.ToString(cursorleido["cuenta1"]);
                        cuenta2.Text = Convert.ToString(cursorleido["cuenta2"]);
                        cuenta3.Text = Convert.ToString(cursorleido["cuenta3"]);
                        cuenta4.Text = Convert.ToString(cursorleido["cuenta4"]);
                        cuenta5.Text = Convert.ToString(cursorleido["cuenta5"]);
                        cuenta6.Text = Convert.ToString(cursorleido["cuenta6"]);
                        cuenta7.Text = Convert.ToString(cursorleido["cuenta7"]);
                        cuenta8.Text = Convert.ToString(cursorleido["cuenta8"]);
                        cuenta9.Text = Convert.ToString(cursorleido["cuenta9"]);
                        cuenta10.Text = Convert.ToString(cursorleido["cuenta10"]);
                        porefe.Text = Convert.ToString(cursorleido["porefe"]);
                        porche.Text = Convert.ToString(cursorleido["porche"]);
                        portra.Text = Convert.ToString(cursorleido["portra"]);
                        porcre.Text = Convert.ToString(cursorleido["porcre"]);
                        pormon.Text = Convert.ToString(cursorleido["pormon"]);
                        pordin.Text = Convert.ToString(cursorleido["pordin"]);
                        porval.Text = Convert.ToString(cursorleido["porval"]);
                        pordeb.Text = Convert.ToString(cursorleido["pordeb"]);
                        porser.Text = Convert.ToString(cursorleido["porser"]);
                        porant.Text = Convert.ToString(cursorleido["porant"]);
                        porotr.Text = Convert.ToString(cursorleido["porotr"]);
                        comen1.Text = Convert.ToString(cursorleido["comen1"]);
                        comen2.Text = Convert.ToString(cursorleido["comen2"]);
                        comen3.Text = Convert.ToString(cursorleido["comen3"]);
                        comen4.Text = Convert.ToString(cursorleido["comen4"]);
                        comen5.Text = Convert.ToString(cursorleido["comen5"]);
                        comen6.Text = Convert.ToString(cursorleido["comen6"]);
                        comen7.Text = Convert.ToString(cursorleido["comen7"]);
                        comen8.Text = Convert.ToString(cursorleido["comen8"]);
                        comen9.Text = Convert.ToString(cursorleido["comen9"]);
                        comen10.Text = Convert.ToString(cursorleido["comen10"]);
                        fpefe.Checked = Convert.ToBoolean(cursorleido["fpefe"]);
                        fptra.Checked = Convert.ToBoolean(cursorleido["fptra"]);
                        fpche.Checked = Convert.ToBoolean(cursorleido["fpche"]);
                        fptdeb.Checked = Convert.ToBoolean(cursorleido["fptdeb"]);
                        fptcre.Checked = Convert.ToBoolean(cursorleido["fptcre"]);
                        fptser.Checked = Convert.ToBoolean(cursorleido["fptser"]);
                        fpmon.Checked = Convert.ToBoolean(cursorleido["fpmon"]);
                        fpno.Checked = Convert.ToBoolean(cursorleido["fpno"]);
                        fpnoa.Checked = Convert.ToBoolean(cursorleido["fpnoa"]);
                        solofact.Text = Convert.ToString(cursorleido["solofact"]);
                        ordencpa.Text = Convert.ToString(cursorleido["ordencpa"]);
                        presup.Text = Convert.ToString(cursorleido["presup"]);
                        proveedor.Text = Convert.ToString(cursorleido["proveedor"]);
                        montoaut.Text = Convert.ToString(cursorleido["montoaut"]);
                        montoacum.Text = Convert.ToString(cursorleido["montoacum"]);
                        porcanti.Text = Convert.ToString(cursorleido["porcanti"]);

                    }
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Ese cliente no existe...!");
                }
            }
        }

        private void Btlimpiar_Click(object sender, EventArgs e)
        {
            clte.Text = "";
            razon.Text = "";
            clte_lito.Text = "0";
            dig_lito.Text = "0";
            calle.Text = "";
            numext.Text = "";
            numint.Text = "";
            colonia.Text = "";
            delega.Text = "";
            estado.Text = "";
            pais.Text = "";
            telefono.Text = "";
            rfc.Text = "";
            cp.Text = "";
            atencion1.Text = "";
            atencion2.Text = "";
            atencion3.Text = "";
            atencion4.Text = "";
            atencion5.Text = "";
            nombre.Text = "";
            apellidop.Text = "";
            apellidom.Text = "";
            clave.Text = "";
            vendedor.Text = "";
            comisvend.Text = "0";
            rebate.Text = "0";
            comis30.Text = "0";
            comis60.Text = "0";
            comis90.Text = "0";
            comistarj.Text = "0";
            cargofin.Text = "0";
            diasrevi.Text = "";
            email.Text = "";
            porcmas.Text = "0";
            carta.Text = "";
            tipoclte.Text = "0";
            clave.Text = "";
            dsctopapel.Text = "0";
            dscto.Text = "0";
            diseno.Text = "0";
            plazo.Text = "0";
            lunhora.Text = "";
            marhora.Text = "";
            miehora.Text = "";
            juehora.Text = "";
            viehora.Text = "";
            lun.Checked = false;
            mar.Checked = false;
            mie.Checked = false;
            jue.Checked = false;
            vie.Checked = false;
            cuenta1.Text = "0";
            cuenta2.Text = "0";
            cuenta3.Text = "0";
            cuenta4.Text = "0";
            cuenta5.Text = "0";
            cuenta6.Text = "0";
            cuenta7.Text = "0";
            cuenta8.Text = "0";
            cuenta9.Text = "0";
            cuenta10.Text = "0";
            porefe.Text = "0";
            porche.Text = "0";
            portra.Text = "0";
            porcre.Text = "0";
            pormon.Text = "0";
            pordin.Text = "0";
            porval.Text = "0";
            pordeb.Text = "0";
            porser.Text = "0";
            porant.Text = "0";
            porotr.Text = "0";
            comen1.Text = "";
            comen2.Text = "";
            comen3.Text = "";
            comen4.Text = "";
            comen5.Text = "";
            comen6.Text = "";
            comen7.Text = "";
            comen8.Text = "";
            comen9.Text = "";
            comen10.Text = "";
            fpefe.Checked = false;
            fptra.Checked = false;
            fpche.Checked = false;
            fptdeb.Checked = false;
            fptcre.Checked = false;
            fptser.Checked = false;
            fpmon.Checked = false;
            fpno.Checked = false;
            fpnoa.Checked = false;
            solofact.Text = "NO";
            ordencpa.Text = "NO";
            presup.Text = "0";
            proveedor.Text = "";
            montoaut.Text = "0";
            montoacum.Text = "0";
            porcanti.Text = "0";
            clte.Focus();
        }

        private void Btmodificar_Click(object sender, EventArgs e)
        {
            if (clte.Text == "")
            {
                MessageBox.Show("Falta poner la clave del cliente...!");
            }
            else
            {
                // Checa contraseña:
                Fcontra Fcontra = new Fcontra();
                Fcontra.pasado += new Fcontra.pasar(Ejecutar);
                Fcontra.ShowDialog();
                if (txtcontrase.Text.ToUpper() == "MODI" || txtcontrase.Text.ToUpper() == "SSS")
                {
                    int fpefe2 = 0;
                    int fptra2 = 0;
                    int fptdeb2 = 0;
                    int fptcre2 = 0;
                    int fptser2 = 0;
                    int fpche2 = 0;
                    int fpmon2 = 0;
                    int fpno2 = 0;
                    int fpnoa2 = 0;

                    int lun2 = 0;
                    int mar2 = 0;
                    int mie2 = 0;
                    int jue2 = 0;
                    int vie2 = 0;

                    if (fpefe.Checked) { fpefe2 = 1; }
                    if (fptra.Checked) { fptra2 = 1; }
                    if (fptdeb.Checked) { fptdeb2 = 1; }
                    if (fptcre.Checked) { fptcre2 = 1; }
                    if (fptser.Checked) { fptser2 = 1; }
                    if (fpche.Checked) { fpche2 = 1; }
                    if (fpmon.Checked) { fpmon2 = 1; }
                    if (fpno.Checked) { fpno2 = 1; }
                    if (fpnoa.Checked) { fpnoa2 = 1; }

                    if (lun.Checked) { lun2 = 1; }
                    if (mar.Checked) { mar2 = 1; }
                    if (mie.Checked) { mie2 = 1; }
                    if (jue.Checked) { jue2 = 1; }
                    if (vie.Checked) { vie2 = 1; }


                    con.Open();

                    cmd.CommandText = "update dbo.clientes set  " +
                    " razon     = '" + razon.Text + "',  " +
                    " calle     = '" + calle.Text + "',  " +
                    " numext    = '" + numext.Text + "',  " +
                    " numint    = '" + numint.Text + "',  " +
                    " colonia   = '" + colonia.Text + "',  " +
                    " delega    = '" + delega.Text + "',  " +
                    " estado    = '" + estado.Text + "',  " +
                    " pais      = '" + pais.Text + "',  " +
                    " rfc       = '" + rfc.Text + "',  " +
                    " cp        = '" + cp.Text + "',  " +
                    " clte_lito = '" + clte_lito.Text + "',  " +
                    " dig_lito  = '" + dig_lito.Text + "',  " +
                    " clte_edi  = '" + clte_edi.Text + "',  " +
                    " dig_edi   = '" + dig_edi.Text + "',  " +
                    " atencion1 = '" + atencion1.Text + "',  " +
                    " atencion2 = '" + atencion2.Text + "',  " +
                    " atencion3 = '" + atencion3.Text + "',  " +
                    " atencion4 = '" + atencion4.Text + "',  " +
                    " atencion5 = '" + atencion5.Text + "',  " +
                    " nombre =    '" + nombre.Text + "',  " +
                    " apellidop = '" + apellidop.Text + "',  " +
                    " apellidom = '" + apellidom.Text + "',  " +
                    " clave     = '" + clave.Text + "',  " +
                    " vendedor  = '" + vendedor.Text + "',  " +
                    " comisvend = '" + comisvend.Text + "',  " +
                    " rebate    = '" + rebate.Text + "',  " +
                    " comis30   = '" + comis30.Text + "',  " +
                    " comis60   = '" + comis60.Text + "',  " +
                    " comis90   = '" + comis90.Text + "',  " +
                    " comistarj = '" + comistarj.Text + "',  " +
                    " cargofin  = '" + cargofin.Text + "',  " +
                    " diasrevi  = '" + diasrevi.Text + "',  " +
                    " email     = '" + email.Text + "',     " +
                    " porcmas   = '" + porcmas.Text + "',  " +
                    " carta     = '" + carta.Text + "',  " +
                    " tipoclte  = '" + tipoclte.Text + "',  " +
                    " dsctopapel = '" + dsctopapel.Text + "',  " +
                    " dscto     = '" + dscto.Text + "',  " +
                    " diseno    = '" + diseno.Text + "',  " +
                    " plazo     = '" + plazo.Text + "',  " +
                    " lunhora   = '" + lunhora.Text + "',  " +
                    " marhora   = '" + marhora.Text + "',  " +
                    " miehora   = '" + miehora.Text + "',  " +
                    " juehora   = '" + juehora.Text + "',  " +
                    " viehora   = '" + viehora.Text + "',  " +
                    " lun     = '" + lun2 + "',  " +
                    " mar     = '" + mar2 + "',  " +
                    " mie     = '" + mie2 + "',  " +
                    " jue     = '" + jue2 + "',  " +
                    " vie     = '" + vie2 + "',  " +
                    " cuenta1   = '" + cuenta1.Text + "',  " +
                    " cuenta2   = '" + cuenta2.Text + "',  " +
                    " cuenta3   = '" + cuenta3.Text + "',  " +
                    " cuenta4   = '" + cuenta4.Text + "',  " +
                    " cuenta5   = '" + cuenta5.Text + "',  " +
                    " cuenta6   = '" + cuenta6.Text + "',  " +
                    " cuenta7   = '" + cuenta7.Text + "',  " +
                    " cuenta8   = '" + cuenta8.Text + "',  " +
                    " cuenta9   = '" + cuenta9.Text + "',  " +
                    " cuenta10  = '" + cuenta10.Text + "',  " +
                    " porefe    = '" + porefe.Text + "',  " +
                    " porche    = '" + porche.Text + "',  " +
                    " portra    = '" + portra.Text + "',  " +
                    " porcre    = '" + porcre.Text + "',  " +
                    " pormon    = '" + pormon.Text + "',  " +
                    " pordin    = '" + pordin.Text + "',  " +
                    " porval    = '" + porval.Text + "',  " +
                    " pordeb    = '" + pordeb.Text + "',  " +
                    " porser    = '" + porser.Text + "',  " +
                    " porant    = '" + porant.Text + "',  " +
                    " porotr    = '" + porotr.Text + "',  " +
                    " comen1    = '" + comen1.Text + "',  " +
                    " comen2    = '" + comen2.Text + "',  " +
                    " comen3    = '" + comen3.Text + "',  " +
                    " comen4    = '" + comen4.Text + "',  " +
                    " comen5    = '" + comen5.Text + "',  " +
                    " comen6    = '" + comen6.Text + "',  " +
                    " comen7    = '" + comen7.Text + "',  " +
                    " comen8    = '" + comen8.Text + "',  " +
                    " comen9    = '" + comen9.Text + "',  " +
                    " comen10   = '" + comen10.Text + "',  " +
                    " fpefe     = '" + fpefe2 + "',  " +
                    " fptra     = '" + fptra2 + "',  " +
                    " fpche     = '" + fpche2 + "',  " +
                    " fptdeb    = '" + fptdeb2 + "',  " +
                    " fptcre    = '" + fptcre2 + "',  " +
                    " fptser    = '" + fptser2 + "',  " +
                    " fpmon     = '" + fpmon2 + "',  " +
                    " fpno      = '" + fpno2 + "',  " +
                    " fpnoa     = '" + fpnoa2 + "',  " +
                    " solofact  = '" + solofact.Text + "',  " +
                    " ordencpa  = '" + ordencpa.Text + "',  " +
                    " presup    = '" + presup.Text + "',  " +
                    " proveedor = '" + proveedor.Text + "',  " +
                    " telefono = '" + telefono.Text + "' where " +
                    " clte = '" + clte.Text + "' ";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cliente: " + clte.Text + " modificado...!", "Litografía Gil");
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta...!");
                }
            }
        }

        private void Btborra_Click(object sender, EventArgs e)
        {
            if (clte.Text == "")
            {
                MessageBox.Show("Falta poner la clave del cliente...!");
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
                    cmd.CommandText = "delete from dbo.clientes where clte = '" + clte.Text + "' ";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cliente: " + clte.Text + "  borrado...!", "Litografía Gil");
                    clte.Text = "";
                    razon.Text = "";
                    clte_lito.Text = "0";
                    dig_lito.Text = "0";
                    calle.Text = "";
                    numext.Text = "";
                    numint.Text = "";
                    colonia.Text = "";
                    delega.Text = "";
                    estado.Text = "";
                    pais.Text = "";
                    telefono.Text = "";
                    rfc.Text = "";
                    cp.Text = "";
                    atencion1.Text = "";
                    atencion2.Text = "";
                    atencion3.Text = "";
                    atencion4.Text = "";
                    atencion5.Text = "";
                    nombre.Text = "";
                    apellidop.Text = "";
                    apellidom.Text = "";
                    clave.Text = "";
                    vendedor.Text = "";
                    comisvend.Text = "0";
                    rebate.Text = "0";
                    comis30.Text = "0";
                    comis60.Text = "0";
                    comis90.Text = "0";
                    comistarj.Text = "0";
                    cargofin.Text = "0";
                    diasrevi.Text = "";
                    email.Text = "";
                    porcmas.Text = "0";
                    carta.Text = "";
                    tipoclte.Text = "0";
                    clave.Text = "";
                    dsctopapel.Text = "0";
                    dscto.Text = "0";
                    diseno.Text = "0";
                    plazo.Text = "0";
                    lunhora.Text = "";
                    marhora.Text = "";
                    miehora.Text = "";
                    juehora.Text = "";
                    viehora.Text = "";
                    lun.Checked = false;
                    mar.Checked = false;
                    mie.Checked = false;
                    jue.Checked = false;
                    vie.Checked = false;
                    cuenta1.Text = "0";
                    cuenta2.Text = "0";
                    cuenta3.Text = "0";
                    cuenta4.Text = "0";
                    cuenta5.Text = "0";
                    cuenta6.Text = "0";
                    cuenta7.Text = "0";
                    cuenta8.Text = "0";
                    cuenta9.Text = "0";
                    cuenta10.Text = "0";
                    porefe.Text = "0";
                    porche.Text = "0";
                    portra.Text = "0";
                    porcre.Text = "0";
                    pormon.Text = "0";
                    pordin.Text = "0";
                    porval.Text = "0";
                    pordeb.Text = "0";
                    porser.Text = "0";
                    porant.Text = "0";
                    porotr.Text = "0";
                    comen1.Text = "";
                    comen2.Text = "";
                    comen3.Text = "";
                    comen4.Text = "";
                    comen5.Text = "";
                    comen6.Text = "";
                    comen7.Text = "";
                    comen8.Text = "";
                    comen9.Text = "";
                    comen10.Text = "";
                    fpefe.Checked = false;
                    fptra.Checked = false;
                    fpche.Checked = false;
                    fptdeb.Checked = false;
                    fptcre.Checked = false;
                    fptser.Checked = false;
                    fpmon.Checked = false;
                    fpno.Checked = false;
                    fpnoa.Checked = false;
                    solofact.Text = "NO";
                    ordencpa.Text = "NO";
                    presup.Text = "0";
                    proveedor.Text = "";
                    clte.Focus();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta...!");
                }

            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            if (clte.Text != "")
            {
                con.Close();
                con.Open();
                SqlCommand cursor = new SqlCommand("select clte from dbo.clientes where clte = '" + clte.Text + "' ", con);
                SqlDataReader cursorleido = cursor.ExecuteReader();
                if (cursorleido.Read())
                {
                    MessageBox.Show("El cliente: '" + clte.Text + "' ya existe..!", "Litografía Gil");
                    con.Close();
                }
                else
                {

                    con.Close();
                    con.Open();

                    int fpefe1  = 0;
                    int fptra1  = 0;
                    int fptdeb1 = 0;
                    int fptcre1 = 0;
                    int fptser1 = 0;
                    int fpche1  = 0;
                    int fpmon1  = 0;
                    int fpno1   = 0;
                    int fpnoa1  = 0;

                    int lun1 = 0;
                    int mar1 = 0;
                    int mie1 = 0;
                    int jue1 = 0;
                    int vie1 = 0;

                    string nada = "";

                    if (fpefe.Checked)  { fpefe1 = 1; }
                    if (fptra.Checked)  { fptra1 = 1; }
                    if (fptdeb.Checked) { fptdeb1 = 1; }
                    if (fptcre.Checked) { fptcre1 = 1; }
                    if (fptser.Checked) { fptser1 = 1; }
                    if (fpche.Checked)  { fpche1 = 1; }
                    if (fpmon.Checked)  { fpmon1 = 1; }
                    if (fpno.Checked)   { fpno1 = 1; }
                    if (fpnoa.Checked)  { fpnoa1 = 1; }

                    if (lun.Checked) { lun1 = 'T' ; }
                    if (mar.Checked) { mar1 = 'T' ; }
                    if (mie.Checked) { mie1 = 'T' ; }
                    if (jue.Checked) { jue1 = 'T' ; }
                    if (vie.Checked) { vie1 = 'T' ; }

                    montoaut.Text = "0";
                    montoacum.Text = "0";
                    porcanti.Text = "0";

                    cmd.CommandText = "insert into dbo.clientes (clte)" +
                    " values " +
                    " ('" + clte.Text + "' )";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "update dbo.clientes set  " +
                    " razon     = '" + razon.Text + "',  " +
                    " psw       = '" + nada + "',  " +
                    " calle     = '" + calle.Text + "',  " +
                    " numext    = '" + numext.Text + "',  " +
                    " numint    = '" + numint.Text + "',  " +
                    " colonia   = '" + colonia.Text + "',  " +
                    " delega    = '" + delega.Text + "',  " +
                    " estado    = '" + estado.Text + "',  " +
                    " pais      = '" + pais.Text + "',  " +
                    " rfc       = '" + rfc.Text + "',  " +
                    " cp        = '" + cp.Text + "',  " +
                    " clte_lito = '" + clte_lito.Text + "',  " +
                    " dig_lito  = '" + dig_lito.Text + "',  " +
                    " clte_edi  = '" + clte_edi.Text + "',  " +
                    " dig_edi   = '" + dig_edi.Text + "',  " +
                    " atencion1 = '" + atencion1.Text + "',  " +
                    " atencion2 = '" + atencion2.Text + "',  " +
                    " atencion3 = '" + atencion3.Text + "',  " +
                    " atencion4 = '" + atencion4.Text + "',  " +
                    " atencion5 = '" + atencion5.Text + "',  " +
                    " nombre =    '" + nombre.Text + "',  " +
                    " apellidop = '" + apellidop.Text + "',  " +
                    " apellidom = '" + apellidom.Text + "',  " +
                    " clave     = '" + clave.Text + "',  " +
                    " vendedor  = '" + vendedor.Text + "',  " +
                    " comisvend = '" + comisvend.Text + "',  " +
                    " rebate    = '" + rebate.Text + "',  " +
                    " comis30   = '" + comis30.Text + "',  " +
                    " comis60   = '" + comis60.Text + "',  " +
                    " comis90   = '" + comis90.Text + "',  " +
                    " comistarj = '" + comistarj.Text + "',  " +
                    " cargofin  = '" + cargofin.Text + "',  " +
                    " diasrevi  = '" + diasrevi.Text + "',  " +
                    " email     = '" + email.Text + "',     " +
                    " porcmas   = '" + porcmas.Text + "',  " +
                    " carta     = '" + carta.Text + "',  " +
                    " tipoclte  = '" + tipoclte.Text + "',  " +
                    " dsctopapel = '" + dsctopapel.Text + "',  " +
                    " dscto     = '" + dscto.Text + "',  " +
                    " diseno    = '" + diseno.Text + "',  " +
                    " plazo     = '" + plazo.Text + "',  " +
                    " lunhora   = '" + lunhora.Text + "',  " +
                    " marhora   = '" + marhora.Text + "',  " +
                    " miehora   = '" + miehora.Text + "',  " +
                    " juehora   = '" + juehora.Text + "',  " +
                    " viehora   = '" + viehora.Text + "',  " +
                    " lun     = '" + lun1 + "',  " +
                    " mar     = '" + mar1 + "',  " +
                    " mie     = '" + mie1 + "',  " +
                    " jue     = '" + jue1 + "',  " +
                    " vie     = '" + vie1 + "',  " +
                    " cuenta1   = '" + cuenta1.Text + "',  " +
                    " cuenta2   = '" + cuenta2.Text + "',  " +
                    " cuenta3   = '" + cuenta3.Text + "',  " +
                    " cuenta4   = '" + cuenta4.Text + "',  " +
                    " cuenta5   = '" + cuenta5.Text + "',  " +
                    " cuenta6   = '" + cuenta6.Text + "',  " +
                    " cuenta7   = '" + cuenta7.Text + "',  " +
                    " cuenta8   = '" + cuenta8.Text + "',  " +
                    " cuenta9   = '" + cuenta9.Text + "',  " +
                    " cuenta10  = '" + cuenta10.Text + "',  " +
                    " porefe    = '" + porefe.Text + "',  " +
                    " porche    = '" + porche.Text + "',  " +
                    " portra    = '" + portra.Text + "',  " +
                    " porcre    = '" + porcre.Text + "',  " +
                    " pormon    = '" + pormon.Text + "',  " +
                    " pordin    = '" + pordin.Text + "',  " +
                    " porval    = '" + porval.Text + "',  " +
                    " pordeb    = '" + pordeb.Text + "',  " +
                    " porser    = '" + porser.Text + "',  " +
                    " porant    = '" + porant.Text + "',  " +
                    " porotr    = '" + porotr.Text + "',  " +
                    " comen1    = '" + comen1.Text + "',  " +
                    " comen2    = '" + comen2.Text + "',  " +
                    " comen3    = '" + comen3.Text + "',  " +
                    " comen4    = '" + comen4.Text + "',  " +
                    " comen5    = '" + comen5.Text + "',  " +
                    " comen6    = '" + comen6.Text + "',  " +
                    " comen7    = '" + comen7.Text + "',  " +
                    " comen8    = '" + comen8.Text + "',  " +
                    " comen9    = '" + comen9.Text + "',  " +
                    " comen10   = '" + comen10.Text + "',  " +
                    " fpefe     = '" + fpefe1  + "',  " +
                    " fptra     = '" + fptra1  + "',  " +
                    " fpche     = '" + fpche1  + "',  " +
                    " fptdeb    = '" + fptdeb1 + "',  " +
                    " fptcre    = '" + fptcre1 + "',  " +
                    " fptser    = '" + fptser1 + "',  " +
                    " fpmon     = '" + fpmon1  + "',  " +
                    " fpno      = '" + fpno1   + "',  " +
                    " fpnoa     = '" + fpnoa1  + "',  " +
                    " solofact  = '" + solofact.Text + "',  " +
                    " ordencpa  = '" + ordencpa.Text + "',  " +
                    " presup    = '" + presup.Text + "',  " +
                    " proveedor = '" + proveedor.Text + "',  " +
                    " montoaut  = '" + montoaut.Text  + "',  " +
                    " montoacum = '" + montoacum.Text + "',  " +
                    " porcanti  = '" + porcanti.Text + "',  " +
                    " telefono = '" + telefono.Text + "' where " +
                    " clte = '" + clte.Text + "' ";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "update dbo.clientes set psw = '' where psw is NULL and clte = '" + clte.Text + "' ";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "update dbo.clientes set clte_termi = 0 where clte_termi is NULL and clte = '" + clte.Text + "' ";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "update dbo.clientes set dig_termi = 0 where dig_termi is NULL and clte = '" + clte.Text + "' ";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "update dbo.clientes set nombre = '' where nombre is NULL and clte = '" + clte.Text + "' ";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "update dbo.clientes set apellidop = '' where apellidop is NULL and clte = '" + clte.Text + "' ";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "update dbo.clientes set apellidom = '' where apellidom is NULL and clte = '" + clte.Text + "' ";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "update dbo.clientes set direccion1 = '' where direccion1 is NULL and clte = '" + clte.Text + "' ";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "update dbo.clientes set direccion2 = '' where direccion2 is NULL and clte = '" + clte.Text + "' ";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "update dbo.clientes set direccion3 = '' where direccion3 is NULL and clte = '" + clte.Text + "' ";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "update dbo.clientes set aten1 = 0 where aten1 is NULL and clte = '" + clte.Text + "' ";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "update dbo.clientes set aten2 = 0 where aten2 is NULL and clte = '" + clte.Text + "' ";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "update dbo.clientes set aten3 = 0 where aten3 is NULL and clte = '" + clte.Text + "' ";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "update dbo.clientes set aten4 = 0 where aten4 is NULL and clte = '" + clte.Text + "' ";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "update dbo.clientes set aten5 = 0 where aten5 is NULL and clte = '" + clte.Text + "' ";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "update dbo.clientes set coti = 0 where coti is NULL and clte = '" + clte.Text + "' ";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "update dbo.clientes set cotiza1 = 0 where cotiza1 is NULL and clte = '" + clte.Text + "' ";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "update dbo.clientes set cotiza2 = 0 where cotiza2 is NULL and clte = '" + clte.Text + "' ";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "update dbo.clientes set dise = 0 where dise is NULL and clte = '" + clte.Text + "' ";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "update dbo.clientes set prod = 0 where prod is NULL and clte = '" + clte.Text + "' ";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "update dbo.clientes set cuentael = 0 where cuentael is NULL and clte = '" + clte.Text + "' ";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "update dbo.clientes set fpel = '' where fpel is NULL and clte = '" + clte.Text + "' ";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "update dbo.clientes set credito = '0' where credito is NULL and clte = '" + clte.Text + "' ";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "update dbo.clientes set pagina = '' where pagina is NULL and clte = '" + clte.Text + "' ";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "update dbo.clientes set usuario = '' where usuario is NULL and clte = '" + clte.Text + "' ";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "update dbo.clientes set pswclte = '' where pswclte is NULL and clte = '" + clte.Text + "' ";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "update dbo.clientes set nota1 = '' where nota1 is NULL and clte = '" + clte.Text + "' ";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "update dbo.clientes set nota2 = '' where nota2 is NULL and clte = '" + clte.Text + "' ";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "update dbo.clientes set nota3 = '' where nota3 is NULL and clte = '" + clte.Text + "' ";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "update dbo.clientes set nota4 = '' where nota4 is NULL and clte = '" + clte.Text + "' ";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "update dbo.clientes set clte_term2 = '0' where clte_term2 is NULL and clte = '" + clte.Text + "' ";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "update dbo.clientes set porna = '0' where porna is NULL and clte = '" + clte.Text + "' ";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "update dbo.clientes set bancos33 = '' where bancos33 is NULL and clte = '" + clte.Text + "' ";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "update dbo.clientes set residen = '' where residen is NULL and clte = '" + clte.Text + "' ";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "update dbo.clientes set idfis = '' where idfis is NULL and clte = '" + clte.Text + "' ";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "update dbo.clientes set creppag = 0 where creppag is NULL and clte = '" + clte.Text + "' ";
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cliente creado...!", "Litografía Gil");
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Falta poner la Clave del cliente...!");
            }
        }

        private void Btconsultagral_Click(object sender, EventArgs e)
        {
            //   if (razoncons.Text == "")
            //   {
            //       MessageBox.Show("Falta poner la Razón Social del cliente...!");
            //   }
            //   else
            {
                con.Close();
                con.Open();
                clte.Text = "";
                razon.Text = "";
                clte_lito.Text = "0";
                dig_lito.Text = "0";
                calle.Text = "";
                numext.Text = "";
                numint.Text = "";
                colonia.Text = "";
                delega.Text = "";
                estado.Text = "";
                pais.Text = "";
                telefono.Text = "";
                rfc.Text = "";
                cp.Text = "";
                atencion1.Text = "";
                atencion2.Text = "";
                atencion3.Text = "";
                atencion4.Text = "";
                atencion5.Text = "";
                nombre.Text = "";
                apellidop.Text = "";
                apellidom.Text = "";
                clave.Text = "";
                vendedor.Text = "";
                comisvend.Text = "0";
                rebate.Text = "0";
                comis30.Text = "0";
                comis60.Text = "0";
                comis90.Text = "0";
                comistarj.Text = "0";
                cargofin.Text = "0";
                diasrevi.Text = "";
                email.Text = "";
                porcmas.Text = "0";
                carta.Text = "";
                tipoclte.Text = "0";
                clave.Text = "";
                dsctopapel.Text = "0";
                dscto.Text = "0";
                diseno.Text = "0";
                plazo.Text = "0";
                lunhora.Text = "";
                marhora.Text = "";
                miehora.Text = "";
                juehora.Text = "";
                viehora.Text = "";
                lun.Checked = false;
                mar.Checked = false;
                mie.Checked = false;
                jue.Checked = false;
                vie.Checked = false;
                cuenta1.Text = "0";
                cuenta2.Text = "0";
                cuenta3.Text = "0";
                cuenta4.Text = "0";
                cuenta5.Text = "0";
                cuenta6.Text = "0";
                cuenta7.Text = "0";
                cuenta8.Text = "0";
                cuenta9.Text = "0";
                cuenta10.Text = "0";
                porefe.Text = "0";
                porche.Text = "0";
                portra.Text = "0";
                porcre.Text = "0";
                pormon.Text = "0";
                pordin.Text = "0";
                porval.Text = "0";
                pordeb.Text = "0";
                porser.Text = "0";
                porant.Text = "0";
                porotr.Text = "0";
                comen1.Text = "";
                comen2.Text = "";
                comen3.Text = "";
                comen4.Text = "";
                comen5.Text = "";
                comen6.Text = "";
                comen7.Text = "";
                comen8.Text = "";
                comen9.Text = "";
                comen10.Text = "";
                fpefe.Checked = false;
                fptra.Checked = false;
                fpche.Checked = false;
                fptdeb.Checked = false;
                fptcre.Checked = false;
                fptser.Checked = false;
                fpmon.Checked = false;
                fpno.Checked = false;
                fpnoa.Checked = false;
                solofact.Text = "NO";
                ordencpa.Text = "NO";
                presup.Text = "0";
                proveedor.Text = "";
                montoaut.Text = "0";
                montoacum.Text = "0";
                porcanti.Text = "0";


                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select clte,razon,clte_lito,dig_lito,calle,numext,numint, " +
                " colonia,delega,estado,pais,telefono,rfc,cp,atencion1,atencion2,atencion3,atencion4,atencion5, " +
                " nombre,apellidop,apellidom,clave,vendedor,comisvend,rebate,comis30,comis60,comis90,comistarj,cargofin, " +
                " diasrevi,email,porcmas,carta,tipoclte,clave,dsctopapel,dscto,diseno,plazo,lun,lunhora,mar,marhora,mie,miehora,jue,juehora,vie,viehora," +
                " cuenta1,cuenta2,cuenta3,cuenta4,cuenta5,cuenta6,cuenta7,cuenta8,cuenta9,cuenta10, " +
                " porefe,porche,portra,porcre,pormon,pordin,porval,pordeb,porser,porant,porotr, " +
                " comen1,comen2,comen3,comen4,comen5,comen6,comen7,comen8,comen9,comen10, " +
                " fpefe,fptra,fpche,fptdeb,fptcre,fptser,fpmon,fpno,fpnoa,solofact,ordencpa,presup,proveedor " +
                " from dbo.clientes where razon like '" + razoncons.Text + "%' ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    DGclientes.DataSource = dt;

                    DGclientes.RowHeadersVisible = false;
                    DGclientes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    DGclientes.Columns[0].Width = 70;
                    DGclientes.Columns[0].DefaultCellStyle.BackColor = Color.PowderBlue;
                    DGclientes.Columns[0].HeaderText = "Clave";
                    DGclientes.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    DGclientes.Columns[1].Width = 200;
                    DGclientes.Columns[1].DefaultCellStyle.BackColor = Color.Beige;
                    DGclientes.Columns[1].HeaderText = "Razón Social";
                    DGclientes.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    DGclientes.Columns[2].Width = 35;
                    DGclientes.Columns[2].DefaultCellStyle.BackColor = Color.PapayaWhip;
                    DGclientes.Columns[2].HeaderText = "Conta";
                    DGclientes.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                    DGclientes.Columns[3].Width = 20;
                    DGclientes.Columns[3].DefaultCellStyle.BackColor = Color.PapayaWhip;
                    DGclientes.Columns[3].HeaderText = "Dig";
                    DGclientes.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                    DGclientes.Columns[4].Width = 120;
                    DGclientes.Columns[4].DefaultCellStyle.BackColor = Color.PapayaWhip;
                    DGclientes.Columns[4].HeaderText = "Calle";
                    DGclientes.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    DGclientes.Columns[5].Width = 40;
                    DGclientes.Columns[5].DefaultCellStyle.BackColor = Color.PapayaWhip;
                    DGclientes.Columns[5].HeaderText = "No.Ext";
                    DGclientes.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    DGclientes.Columns[6].Width = 40;
                    DGclientes.Columns[6].DefaultCellStyle.BackColor = Color.PapayaWhip;
                    DGclientes.Columns[6].HeaderText = "No.Int";
                    DGclientes.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    DGclientes.Columns[7].Width = 80;
                    DGclientes.Columns[7].DefaultCellStyle.BackColor = Color.PapayaWhip;
                    DGclientes.Columns[7].HeaderText = "Colonia";
                    DGclientes.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    DGclientes.Columns[8].Width = 80;
                    DGclientes.Columns[8].DefaultCellStyle.BackColor = Color.PapayaWhip;
                    DGclientes.Columns[8].HeaderText = "Delegación";
                    DGclientes.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    DGclientes.Columns[9].Width = 80;
                    DGclientes.Columns[9].DefaultCellStyle.BackColor = Color.PapayaWhip;
                    DGclientes.Columns[9].HeaderText = "Estado";
                    DGclientes.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    DGclientes.Columns[10].Width = 80;
                    DGclientes.Columns[10].DefaultCellStyle.BackColor = Color.PapayaWhip;
                    DGclientes.Columns[10].HeaderText = "Pais";
                    DGclientes.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    DGclientes.Columns[11].Width = 80;
                    DGclientes.Columns[11].DefaultCellStyle.BackColor = Color.PapayaWhip;
                    DGclientes.Columns[11].HeaderText = "Teléfono";
                    DGclientes.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    DGclientes.Columns[12].Width = 80;
                    DGclientes.Columns[12].DefaultCellStyle.BackColor = Color.PapayaWhip;
                    DGclientes.Columns[12].HeaderText = "RFC";
                    DGclientes.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    DGclientes.Columns[13].Width = 40;
                    DGclientes.Columns[13].DefaultCellStyle.BackColor = Color.PapayaWhip;
                    DGclientes.Columns[13].HeaderText = "CP";
                    DGclientes.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    SqlCommand cursor = new SqlCommand("select clte,razon,clte_lito,dig_lito,calle,numext,numint, " +
                    " colonia,delega,estado,pais,telefono,rfc,cp,atencion1,atencion2,atencion3,atencion4,atencion5,  " +
                    " nombre,apellidop,apellidom,clave,vendedor,comisvend,rebate,comis30,comis60,comis90,comistarj,cargofin," +
                    " diasrevi,email,porcmas,carta,tipoclte,clave,dsctopapel,dscto,diseno,plazo,lun,lunhora,mar,marhora,mie,miehora,jue,juehora,vie,viehora," +
                    " cuenta1,cuenta2,cuenta3,cuenta4,cuenta5,cuenta6,cuenta7,cuenta8,cuenta9,cuenta10, " +
                    " porefe,porche,portra,porcre,pormon,pordin,porval,pordeb,porser,porant,porotr, " +
                    " comen1,comen2,comen3,comen4,comen5,comen6,comen7,comen8,comen9,comen10, " +
                    " fpefe,fptra,fpche,fptdeb,fptcre,fptser,fpmon,fpno,fpnoa,solofact,ordencpa,presup,proveedor " +
                    "  from dbo.clientes where razon = '" + razoncons.Text + "' ", con);
                    SqlDataReader cursorleido = cursor.ExecuteReader();
                    while (cursorleido.Read())
                    {
                        clte.Text = Convert.ToString(cursorleido["clte"]);
                        razon.Text = Convert.ToString(cursorleido["razon"]);
                        clte_lito.Text = Convert.ToString(cursorleido["clte_lito"]);
                        dig_lito.Text = Convert.ToString(cursorleido["dig_lito"]);
                        calle.Text = Convert.ToString(cursorleido["calle"]);
                        numext.Text = Convert.ToString(cursorleido["numext"]);
                        numint.Text = Convert.ToString(cursorleido["numint"]);
                        colonia.Text = Convert.ToString(cursorleido["colonia"]);
                        delega.Text = Convert.ToString(cursorleido["delega"]);
                        estado.Text = Convert.ToString(cursorleido["estado"]);
                        pais.Text = Convert.ToString(cursorleido["pais"]);
                        telefono.Text = Convert.ToString(cursorleido["telefono"]);
                        rfc.Text = Convert.ToString(cursorleido["rfc"]);
                        cp.Text = Convert.ToString(cursorleido["cp"]);
                        atencion1.Text = Convert.ToString(cursorleido["atencion1"]);
                        atencion2.Text = Convert.ToString(cursorleido["atencion2"]);
                        atencion3.Text = Convert.ToString(cursorleido["atencion3"]);
                        atencion4.Text = Convert.ToString(cursorleido["atencion4"]);
                        atencion5.Text = Convert.ToString(cursorleido["atencion5"]);
                        nombre.Text = Convert.ToString(cursorleido["nombre"]);
                        apellidop.Text = Convert.ToString(cursorleido["apellidop"]);
                        apellidom.Text = Convert.ToString(cursorleido["apellidom"]);
                        clave.Text = Convert.ToString(cursorleido["clave"]);
                        vendedor.Text = Convert.ToString(cursorleido["vendedor"]);
                        comisvend.Text = Convert.ToString(cursorleido["comisvend"]);
                        rebate.Text = Convert.ToString(cursorleido["rebate"]);
                        comis30.Text = Convert.ToString(cursorleido["comis30"]);
                        comis60.Text = Convert.ToString(cursorleido["comis60"]);
                        comis90.Text = Convert.ToString(cursorleido["comis90"]);
                        comistarj.Text = Convert.ToString(cursorleido["comistarj"]);
                        cargofin.Text = Convert.ToString(cursorleido["cargofin"]);
                        diasrevi.Text = Convert.ToString(cursorleido["diasrevi"]);
                        email.Text = Convert.ToString(cursorleido["email"]);
                        porcmas.Text = Convert.ToString(cursorleido["porcmas"]);
                        carta.Text = Convert.ToString(cursorleido["carta"]);
                        clave.Text = Convert.ToString(cursorleido["clave"]);
                        dsctopapel.Text = Convert.ToString(cursorleido["dsctopapel"]);
                        dscto.Text = Convert.ToString(cursorleido["dscto"]);
                        diseno.Text = Convert.ToString(cursorleido["diseno"]);
                        plazo.Text = Convert.ToString(cursorleido["plazo"]);
                        lunhora.Text = Convert.ToString(cursorleido["lunhora"]);
                        marhora.Text = Convert.ToString(cursorleido["marhora"]);
                        miehora.Text = Convert.ToString(cursorleido["miehora"]);
                        juehora.Text = Convert.ToString(cursorleido["juehora"]);
                        viehora.Text = Convert.ToString(cursorleido["viehora"]);
                        lun.Checked = Convert.ToBoolean(cursorleido["lun"]);
                        mar.Checked = Convert.ToBoolean(cursorleido["mar"]);
                        mie.Checked = Convert.ToBoolean(cursorleido["mie"]);
                        jue.Checked = Convert.ToBoolean(cursorleido["jue"]);
                        vie.Checked = Convert.ToBoolean(cursorleido["vie"]);
                        cuenta1.Text = Convert.ToString(cursorleido["cuenta1"]);
                        cuenta2.Text = Convert.ToString(cursorleido["cuenta2"]);
                        cuenta3.Text = Convert.ToString(cursorleido["cuenta3"]);
                        cuenta4.Text = Convert.ToString(cursorleido["cuenta4"]);
                        cuenta5.Text = Convert.ToString(cursorleido["cuenta5"]);
                        cuenta6.Text = Convert.ToString(cursorleido["cuenta6"]);
                        cuenta7.Text = Convert.ToString(cursorleido["cuenta7"]);
                        cuenta8.Text = Convert.ToString(cursorleido["cuenta8"]);
                        cuenta9.Text = Convert.ToString(cursorleido["cuenta9"]);
                        cuenta10.Text = Convert.ToString(cursorleido["cuenta10"]);
                        porefe.Text = Convert.ToString(cursorleido["porefe"]);
                        porche.Text = Convert.ToString(cursorleido["porche"]);
                        portra.Text = Convert.ToString(cursorleido["portra"]);
                        porcre.Text = Convert.ToString(cursorleido["porcre"]);
                        pormon.Text = Convert.ToString(cursorleido["pormon"]);
                        pordin.Text = Convert.ToString(cursorleido["pordin"]);
                        porval.Text = Convert.ToString(cursorleido["porval"]);
                        pordeb.Text = Convert.ToString(cursorleido["pordeb"]);
                        porser.Text = Convert.ToString(cursorleido["porser"]);
                        porant.Text = Convert.ToString(cursorleido["porant"]);
                        porotr.Text = Convert.ToString(cursorleido["porotr"]);
                        comen1.Text = Convert.ToString(cursorleido["comen1"]);
                        comen2.Text = Convert.ToString(cursorleido["comen2"]);
                        comen3.Text = Convert.ToString(cursorleido["comen3"]);
                        comen4.Text = Convert.ToString(cursorleido["comen4"]);
                        comen5.Text = Convert.ToString(cursorleido["comen5"]);
                        comen6.Text = Convert.ToString(cursorleido["comen6"]);
                        comen7.Text = Convert.ToString(cursorleido["comen7"]);
                        comen8.Text = Convert.ToString(cursorleido["comen8"]);
                        comen9.Text = Convert.ToString(cursorleido["comen9"]);
                        comen10.Text = Convert.ToString(cursorleido["comen10"]);
                        fpefe.Checked = Convert.ToBoolean(cursorleido["fpefe"]);
                        fptra.Checked = Convert.ToBoolean(cursorleido["fptra"]);
                        fpche.Checked = Convert.ToBoolean(cursorleido["fpche"]);
                        fptdeb.Checked = Convert.ToBoolean(cursorleido["fptdeb"]);
                        fptcre.Checked = Convert.ToBoolean(cursorleido["fptcre"]);
                        fptser.Checked = Convert.ToBoolean(cursorleido["fptser"]);
                        fpmon.Checked = Convert.ToBoolean(cursorleido["fpmon"]);
                        fpno.Checked = Convert.ToBoolean(cursorleido["fpno"]);
                        fpnoa.Checked = Convert.ToBoolean(cursorleido["fpnoa"]);
                        solofact.Text = Convert.ToString(cursorleido["solofact"]);
                        ordencpa.Text = Convert.ToString(cursorleido["ordencpa"]);
                        presup.Text = Convert.ToString(cursorleido["presup"]);
                        proveedor.Text = Convert.ToString(cursorleido["proveedor"]);

                    }
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Esa Razón Social no existe...!");
                }
            }
        }

        private void Txtcontrase_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cltecons_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                {
                    con.Close();
                    con.Open();
                    clte.Text = "";
                    razon.Text = "";
                    clte_lito.Text = "0";
                    dig_lito.Text = "0";
                    calle.Text = "";
                    numext.Text = "";
                    numint.Text = "";
                    colonia.Text = "";
                    delega.Text = "";
                    estado.Text = "";
                    pais.Text = "";
                    telefono.Text = "";
                    rfc.Text = "";
                    cp.Text = "";
                    atencion1.Text = "";
                    atencion2.Text = "";
                    atencion3.Text = "";
                    atencion4.Text = "";
                    atencion5.Text = "";
                    nombre.Text = "";
                    apellidop.Text = "";
                    apellidom.Text = "";
                    clave.Text = "";
                    vendedor.Text = "";
                    comisvend.Text = "0";
                    rebate.Text = "0";
                    comis30.Text = "0";
                    comis60.Text = "0";
                    comis90.Text = "0";
                    comistarj.Text = "0";
                    cargofin.Text = "0";
                    diasrevi.Text = "";
                    email.Text = "";
                    porcmas.Text = "0";
                    carta.Text = "";
                    tipoclte.Text = "0";
                    clave.Text = "";
                    dsctopapel.Text = "0";
                    dscto.Text = "0";
                    diseno.Text = "0";
                    plazo.Text = "0";
                    lunhora.Text = "";
                    marhora.Text = "";
                    miehora.Text = "";
                    juehora.Text = "";
                    viehora.Text = "";
                    lun.Checked = false;
                    mar.Checked = false;
                    mie.Checked = false;
                    jue.Checked = false;
                    vie.Checked = false;
                    cuenta1.Text = "0";
                    cuenta2.Text = "0";
                    cuenta3.Text = "0";
                    cuenta4.Text = "0";
                    cuenta5.Text = "0";
                    cuenta6.Text = "0";
                    cuenta7.Text = "0";
                    cuenta8.Text = "0";
                    cuenta9.Text = "0";
                    cuenta10.Text = "0";
                    porefe.Text = "0";
                    porche.Text = "0";
                    portra.Text = "0";
                    porcre.Text = "0";
                    pormon.Text = "0";
                    pordin.Text = "0";
                    porval.Text = "0";
                    pordeb.Text = "0";
                    porser.Text = "0";
                    porant.Text = "0";
                    porotr.Text = "0";
                    comen1.Text = "";
                    comen2.Text = "";
                    comen3.Text = "";
                    comen4.Text = "";
                    comen5.Text = "";
                    comen6.Text = "";
                    comen7.Text = "";
                    comen8.Text = "";
                    comen9.Text = "";
                    comen10.Text = "";
                    fpefe.Checked = false;
                    fptra.Checked = false;
                    fpche.Checked = false;
                    fptdeb.Checked = false;
                    fptcre.Checked = false;
                    fptser.Checked = false;
                    fpmon.Checked = false;
                    fpno.Checked = false;
                    fpnoa.Checked = false;
                    solofact.Text = "NO";
                    ordencpa.Text = "NO";
                    presup.Text = "0";
                    proveedor.Text = "";
                    montoaut.Text = "0";
                    montoacum.Text = "0";
                    porcanti.Text = "0";



                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select clte,razon,clte_lito,dig_lito,calle,numext,numint, " +
                    " colonia,delega,estado,pais,telefono,rfc,cp,atencion1,atencion2,atencion3,atencion4,atencion5," +
                    " nombre,apellidop,apellidom,clave,vendedor,comisvend,rebate,comis30,comis60,comis90,comistarj,cargofin, " +
                    " diasrevi,email,porcmas,carta,tipoclte,clave,dsctopapel,dscto,diseno,plazo,lun,lunhora,mar,marhora,mie,miehora,jue,juehora,vie,viehora," +
                    " cuenta1,cuenta2,cuenta3,cuenta4,cuenta5,cuenta6,cuenta7,cuenta8,cuenta9,cuenta10, " +
                    " porefe,porche,portra,porcre,pormon,pordin,porval,pordeb,porser,porant,porotr, " +
                    " comen1,comen2,comen3,comen4,comen5,comen6,comen7,comen8,comen9,comen10, " +
                    " fpefe,fptra,fpche,fptdeb,fptcre,fptser,fpmon,fpno,fpnoa,solofact,ordencpa,presup,proveedor " +
                    " from dbo.clientes where clte like '" + cltecons.Text + "%' ";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        DGclientes.DataSource = dt;

                        DGclientes.RowHeadersVisible = false;
                        DGclientes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                        DGclientes.Columns[0].Width = 70;
                        DGclientes.Columns[0].DefaultCellStyle.BackColor = Color.PowderBlue;
                        DGclientes.Columns[0].HeaderText = "Clave";
                        DGclientes.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                        DGclientes.Columns[1].Width = 200;
                        DGclientes.Columns[1].DefaultCellStyle.BackColor = Color.Beige;
                        DGclientes.Columns[1].HeaderText = "Razón Social";
                        DGclientes.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                        DGclientes.Columns[2].Width = 35;
                        DGclientes.Columns[2].DefaultCellStyle.BackColor = Color.PapayaWhip;
                        DGclientes.Columns[2].HeaderText = "Conta";
                        DGclientes.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                        DGclientes.Columns[3].Width = 20;
                        DGclientes.Columns[3].DefaultCellStyle.BackColor = Color.PapayaWhip;
                        DGclientes.Columns[3].HeaderText = "Dig";
                        DGclientes.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                        DGclientes.Columns[4].Width = 120;
                        DGclientes.Columns[4].DefaultCellStyle.BackColor = Color.PapayaWhip;
                        DGclientes.Columns[4].HeaderText = "Calle";
                        DGclientes.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                        DGclientes.Columns[5].Width = 40;
                        DGclientes.Columns[5].DefaultCellStyle.BackColor = Color.PapayaWhip;
                        DGclientes.Columns[5].HeaderText = "No.Ext";
                        DGclientes.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                        DGclientes.Columns[6].Width = 40;
                        DGclientes.Columns[6].DefaultCellStyle.BackColor = Color.PapayaWhip;
                        DGclientes.Columns[6].HeaderText = "No.Int";
                        DGclientes.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                        DGclientes.Columns[7].Width = 80;
                        DGclientes.Columns[7].DefaultCellStyle.BackColor = Color.PapayaWhip;
                        DGclientes.Columns[7].HeaderText = "Colonia";
                        DGclientes.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                        DGclientes.Columns[8].Width = 80;
                        DGclientes.Columns[8].DefaultCellStyle.BackColor = Color.PapayaWhip;
                        DGclientes.Columns[8].HeaderText = "Delegación";
                        DGclientes.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                        DGclientes.Columns[9].Width = 80;
                        DGclientes.Columns[9].DefaultCellStyle.BackColor = Color.PapayaWhip;
                        DGclientes.Columns[9].HeaderText = "Estado";
                        DGclientes.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                        DGclientes.Columns[10].Width = 80;
                        DGclientes.Columns[10].DefaultCellStyle.BackColor = Color.PapayaWhip;
                        DGclientes.Columns[10].HeaderText = "Pais";
                        DGclientes.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                        DGclientes.Columns[11].Width = 80;
                        DGclientes.Columns[11].DefaultCellStyle.BackColor = Color.PapayaWhip;
                        DGclientes.Columns[11].HeaderText = "Teléfono";
                        DGclientes.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                        DGclientes.Columns[12].Width = 80;
                        DGclientes.Columns[12].DefaultCellStyle.BackColor = Color.PapayaWhip;
                        DGclientes.Columns[12].HeaderText = "RFC";
                        DGclientes.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                        DGclientes.Columns[13].Width = 40;
                        DGclientes.Columns[13].DefaultCellStyle.BackColor = Color.PapayaWhip;
                        DGclientes.Columns[13].HeaderText = "CP";
                        DGclientes.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                        SqlCommand cursor = new SqlCommand("select clte,razon,clte_lito,dig_lito,calle,numext,numint, " +
                    " colonia,delega,estado,pais,telefono,rfc,cp,atencion1,atencion2,atencion3,atencion4,atencion5,  " +
                    " nombre,apellidop,apellidom,clave,vendedor,comisvend,rebate,comis30,comis60,comis90,comistarj,cargofin," +
                    " diasrevi,email,porcmas,carta,tipoclte,clave,dsctopapel,dscto,diseno,plazo,lun,lunhora,mar,marhora,mie,miehora,jue,juehora,vie,viehora," +
                    " cuenta1,cuenta2,cuenta3,cuenta4,cuenta5,cuenta6,cuenta7,cuenta8,cuenta9,cuenta10, " +
                    " porefe,porche,portra,porcre,pormon,pordin,porval,pordeb,porser,porant,porotr, " +
                    " comen1,comen2,comen3,comen4,comen5,comen6,comen7,comen8,comen9,comen10, " +
                    " fpefe,fptra,fpche,fptdeb,fptcre,fptser,fpmon,fpno,fpnoa,solofact,ordencpa,presup,proveedor,montoaut,montoacum,porcanti " +
                    "  from dbo.clientes where clte = '" + cltecons.Text + "' ", con);
                        SqlDataReader cursorleido = cursor.ExecuteReader();
                        while (cursorleido.Read())
                        {
                            if (!(cursorleido.HasRows))
                            {
                                MessageBox.Show("Ese cliente no existe...!");
                            }
                            else
                            {
                                clte.Text = Convert.ToString(cursorleido["clte"]);
                                razon.Text = Convert.ToString(cursorleido["razon"]);
                                clte_lito.Text = Convert.ToString(cursorleido["clte_lito"]);
                                dig_lito.Text = Convert.ToString(cursorleido["dig_lito"]);
                                calle.Text = Convert.ToString(cursorleido["calle"]);
                                numext.Text = Convert.ToString(cursorleido["numext"]);
                                numint.Text = Convert.ToString(cursorleido["numint"]);
                                colonia.Text = Convert.ToString(cursorleido["colonia"]);
                                delega.Text = Convert.ToString(cursorleido["delega"]);
                                estado.Text = Convert.ToString(cursorleido["estado"]);
                                pais.Text = Convert.ToString(cursorleido["pais"]);
                                telefono.Text = Convert.ToString(cursorleido["telefono"]);
                                rfc.Text = Convert.ToString(cursorleido["rfc"]);
                                cp.Text = Convert.ToString(cursorleido["cp"]);
                                atencion1.Text = Convert.ToString(cursorleido["atencion1"]);
                                atencion2.Text = Convert.ToString(cursorleido["atencion2"]);
                                atencion3.Text = Convert.ToString(cursorleido["atencion3"]);
                                atencion4.Text = Convert.ToString(cursorleido["atencion4"]);
                                atencion5.Text = Convert.ToString(cursorleido["atencion5"]);
                                nombre.Text = Convert.ToString(cursorleido["nombre"]);
                                apellidop.Text = Convert.ToString(cursorleido["apellidop"]);
                                apellidom.Text = Convert.ToString(cursorleido["apellidom"]);
                                clave.Text = Convert.ToString(cursorleido["clave"]);
                                vendedor.Text = Convert.ToString(cursorleido["vendedor"]);
                                comisvend.Text = Convert.ToString(cursorleido["comisvend"]);
                                rebate.Text = Convert.ToString(cursorleido["rebate"]);
                                comis30.Text = Convert.ToString(cursorleido["comis30"]);
                                comis60.Text = Convert.ToString(cursorleido["comis60"]);
                                comis90.Text = Convert.ToString(cursorleido["comis90"]);
                                comistarj.Text = Convert.ToString(cursorleido["comistarj"]);
                                cargofin.Text = Convert.ToString(cursorleido["cargofin"]);
                                diasrevi.Text = Convert.ToString(cursorleido["diasrevi"]);
                                email.Text = Convert.ToString(cursorleido["email"]);
                                porcmas.Text = Convert.ToString(cursorleido["porcmas"]);
                                carta.Text = Convert.ToString(cursorleido["carta"]);
                                clave.Text = Convert.ToString(cursorleido["clave"]);
                                dsctopapel.Text = Convert.ToString(cursorleido["dsctopapel"]);
                                dscto.Text = Convert.ToString(cursorleido["dscto"]);
                                diseno.Text = Convert.ToString(cursorleido["diseno"]);
                                plazo.Text = Convert.ToString(cursorleido["plazo"]);
                                lunhora.Text = Convert.ToString(cursorleido["lunhora"]);
                                marhora.Text = Convert.ToString(cursorleido["marhora"]);
                                miehora.Text = Convert.ToString(cursorleido["miehora"]);
                                juehora.Text = Convert.ToString(cursorleido["juehora"]);
                                viehora.Text = Convert.ToString(cursorleido["viehora"]);
                                //   lun.Checked = Convert.ToBoolean(cursorleido["lun"]);
                                //   mar.Checked = Convert.ToBoolean(cursorleido["mar"]);
                                //   mie.Checked = Convert.ToBoolean(cursorleido["mie"]);
                                //   jue.Checked = Convert.ToBoolean(cursorleido["jue"]);
                                //   vie.Checked = Convert.ToBoolean(cursorleido["vie"]);
                                cuenta1.Text = Convert.ToString(cursorleido["cuenta1"]);
                                cuenta2.Text = Convert.ToString(cursorleido["cuenta2"]);
                                cuenta3.Text = Convert.ToString(cursorleido["cuenta3"]);
                                cuenta4.Text = Convert.ToString(cursorleido["cuenta4"]);
                                cuenta5.Text = Convert.ToString(cursorleido["cuenta5"]);
                                cuenta6.Text = Convert.ToString(cursorleido["cuenta6"]);
                                cuenta7.Text = Convert.ToString(cursorleido["cuenta7"]);
                                cuenta8.Text = Convert.ToString(cursorleido["cuenta8"]);
                                cuenta9.Text = Convert.ToString(cursorleido["cuenta9"]);
                                cuenta10.Text = Convert.ToString(cursorleido["cuenta10"]);
                                porefe.Text = Convert.ToString(cursorleido["porefe"]);
                                porche.Text = Convert.ToString(cursorleido["porche"]);
                                portra.Text = Convert.ToString(cursorleido["portra"]);
                                porcre.Text = Convert.ToString(cursorleido["porcre"]);
                                pormon.Text = Convert.ToString(cursorleido["pormon"]);
                                pordin.Text = Convert.ToString(cursorleido["pordin"]);
                                porval.Text = Convert.ToString(cursorleido["porval"]);
                                pordeb.Text = Convert.ToString(cursorleido["pordeb"]);
                                porser.Text = Convert.ToString(cursorleido["porser"]);
                                porant.Text = Convert.ToString(cursorleido["porant"]);
                                porotr.Text = Convert.ToString(cursorleido["porotr"]);
                                comen1.Text = Convert.ToString(cursorleido["comen1"]);
                                comen2.Text = Convert.ToString(cursorleido["comen2"]);
                                comen3.Text = Convert.ToString(cursorleido["comen3"]);
                                comen4.Text = Convert.ToString(cursorleido["comen4"]);
                                comen5.Text = Convert.ToString(cursorleido["comen5"]);
                                comen6.Text = Convert.ToString(cursorleido["comen6"]);
                                comen7.Text = Convert.ToString(cursorleido["comen7"]);
                                comen8.Text = Convert.ToString(cursorleido["comen8"]);
                                comen9.Text = Convert.ToString(cursorleido["comen9"]);
                                comen10.Text = Convert.ToString(cursorleido["comen10"]);
                                //   fpefe.Checked = Convert.ToBoolean(cursorleido["fpefe"]);
                                //   fptra.Checked = Convert.ToBoolean(cursorleido["fptra"]);
                                //   fpche.Checked = Convert.ToBoolean(cursorleido["fpche"]);
                                //   fptdeb.Checked = Convert.ToBoolean(cursorleido["fptdeb"]);
                                //   fptcre.Checked = Convert.ToBoolean(cursorleido["fptcre"]);
                                //   fptser.Checked = Convert.ToBoolean(cursorleido["fptser"]);
                                //   fpmon.Checked = Convert.ToBoolean(cursorleido["fpmon"]);
                                //   fpno.Checked = Convert.ToBoolean(cursorleido["fpno"]);
                                //   fpnoa.Checked = Convert.ToBoolean(cursorleido["fpnoa"]);
                                solofact.Text = Convert.ToString(cursorleido["solofact"]);
                                ordencpa.Text = Convert.ToString(cursorleido["ordencpa"]);
                                presup.Text = Convert.ToString(cursorleido["presup"]);
                                proveedor.Text = Convert.ToString(cursorleido["proveedor"]);
                                montoaut.Text = Convert.ToString(cursorleido["montoaut"]);
                                montoacum.Text = Convert.ToString(cursorleido["montoacum"]);
                                porcanti.Text = Convert.ToString(cursorleido["porcanti"]);

                                tipoclte.Enabled = false;
                                Lbl1montoaut.Visible = false;
                                Lbl2montoaut.Visible = false;
                                Lbl1montoacum.Visible = false;
                                Lbl2montoacum.Visible = false;
                                Lbl1porcanti.Visible = false;
                                Lbl2porcanti.Visible = false;
                                Lbl3porcanti.Visible = false;
                                montoaut.Enabled = false;
                                montoaut.Visible = false;
                                montoacum.Enabled = false;
                                montoacum.Visible = false;
                                porcanti.Enabled = false;
                                porcanti.Visible = false;
                            }
                        }
                        con.Close();
                    } 
                }
            }
        }

        private void Razoncons_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                  if (razoncons.Text == "" || razoncons.Text == " ")
                  {
                      MessageBox.Show("Falta poner la Razón Social del cliente...!");
                  }
                  else
                  {
                    con.Close();
                    con.Open();
                    clte.Text = "";
                    razon.Text = "";
                    clte_lito.Text = "0";
                    dig_lito.Text = "0";
                    calle.Text = "";
                    numext.Text = "";
                    numint.Text = "";
                    colonia.Text = "";
                    delega.Text = "";
                    estado.Text = "";
                    pais.Text = "";
                    telefono.Text = "";
                    rfc.Text = "";
                    cp.Text = "";
                    atencion1.Text = "";
                    atencion2.Text = "";
                    atencion3.Text = "";
                    atencion4.Text = "";
                    atencion5.Text = "";
                    nombre.Text = "";
                    apellidop.Text = "";
                    apellidom.Text = "";
                    clave.Text = "";
                    vendedor.Text = "";
                    comisvend.Text = "0";
                    rebate.Text = "0";
                    comis30.Text = "0";
                    comis60.Text = "0";
                    comis90.Text = "0";
                    comistarj.Text = "0";
                    cargofin.Text = "0";
                    diasrevi.Text = "";
                    email.Text = "";
                    porcmas.Text = "0";
                    carta.Text = "";
                    tipoclte.Text = "0";
                    clave.Text = "";
                    dsctopapel.Text = "0";
                    dscto.Text = "0";
                    diseno.Text = "0";
                    plazo.Text = "0";
                    lunhora.Text = "";
                    marhora.Text = "";
                    miehora.Text = "";
                    juehora.Text = "";
                    viehora.Text = "";
                    lun.Checked = false;
                    mar.Checked = false;
                    mie.Checked = false;
                    jue.Checked = false;
                    vie.Checked = false;
                    cuenta1.Text = "0";
                    cuenta2.Text = "0";
                    cuenta3.Text = "0";
                    cuenta4.Text = "0";
                    cuenta5.Text = "0";
                    cuenta6.Text = "0";
                    cuenta7.Text = "0";
                    cuenta8.Text = "0";
                    cuenta9.Text = "0";
                    cuenta10.Text = "0";
                    porefe.Text = "0";
                    porche.Text = "0";
                    portra.Text = "0";
                    porcre.Text = "0";
                    pormon.Text = "0";
                    pordin.Text = "0";
                    porval.Text = "0";
                    pordeb.Text = "0";
                    porser.Text = "0";
                    porant.Text = "0";
                    porotr.Text = "0";
                    comen1.Text = "";
                    comen2.Text = "";
                    comen3.Text = "";
                    comen4.Text = "";
                    comen5.Text = "";
                    comen6.Text = "";
                    comen7.Text = "";
                    comen8.Text = "";
                    comen9.Text = "";
                    comen10.Text = "";
                    fpefe.Checked = false;
                    fptra.Checked = false;
                    fpche.Checked = false;
                    fptdeb.Checked = false;
                    fptcre.Checked = false;
                    fptser.Checked = false;
                    fpmon.Checked = false;
                    fpno.Checked = false;
                    fpnoa.Checked = false;
                    solofact.Text = "NO";
                    ordencpa.Text = "NO";
                    presup.Text = "0";
                    proveedor.Text = "";
                    montoaut.Text = "0";
                    montoacum.Text = "0";
                    porcanti.Text = "0";

                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select clte,razon,clte_lito,dig_lito,calle,numext,numint, " +
                    " colonia,delega,estado,pais,telefono,rfc,cp,atencion1,atencion2,atencion3,atencion4,atencion5, " +
                    " nombre,apellidop,apellidom,clave,vendedor,comisvend,rebate,comis30,comis60,comis90,comistarj,cargofin, " +
                    " diasrevi,email,porcmas,carta,tipoclte,clave,dsctopapel,dscto,diseno,plazo,lun,lunhora,mar,marhora,mie,miehora,jue,juehora,vie,viehora," +
                        " cuenta1,cuenta2,cuenta3,cuenta4,cuenta5,cuenta6,cuenta7,cuenta8,cuenta9,cuenta10, " +
                        " porefe,porche,portra,porcre,pormon,pordin,porval,pordeb,porser,porant,porotr, " +
                        " comen1,comen2,comen3,comen4,comen5,comen6,comen7,comen8,comen9,comen10, " +
                        " fpefe,fptra,fpche,fptdeb,fptcre,fptser,fpmon,fpno,fpnoa,solofact,ordencpa,presup,proveedor " +
                        " from dbo.clientes where razon like '" + razoncons.Text + "%' order by razon ";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        DGclientes.DataSource = dt;

                        DGclientes.RowHeadersVisible = false;
                        DGclientes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                        DGclientes.Columns[0].Width = 70;
                        DGclientes.Columns[0].DefaultCellStyle.BackColor = Color.PowderBlue;
                        DGclientes.Columns[0].HeaderText = "Clave";
                        DGclientes.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                        DGclientes.Columns[1].Width = 200;
                        DGclientes.Columns[1].DefaultCellStyle.BackColor = Color.Beige;
                        DGclientes.Columns[1].HeaderText = "Razón Social";
                        DGclientes.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                        DGclientes.Columns[2].Width = 35;
                        DGclientes.Columns[2].DefaultCellStyle.BackColor = Color.PapayaWhip;
                        DGclientes.Columns[2].HeaderText = "Conta";
                        DGclientes.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                        DGclientes.Columns[3].Width = 20;
                        DGclientes.Columns[3].DefaultCellStyle.BackColor = Color.PapayaWhip;
                        DGclientes.Columns[3].HeaderText = "Dig";
                        DGclientes.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                        DGclientes.Columns[4].Width = 120;
                        DGclientes.Columns[4].DefaultCellStyle.BackColor = Color.PapayaWhip;
                        DGclientes.Columns[4].HeaderText = "Calle";
                        DGclientes.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                        DGclientes.Columns[5].Width = 40;
                        DGclientes.Columns[5].DefaultCellStyle.BackColor = Color.PapayaWhip;
                        DGclientes.Columns[5].HeaderText = "No.Ext";
                        DGclientes.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                        DGclientes.Columns[6].Width = 40;
                        DGclientes.Columns[6].DefaultCellStyle.BackColor = Color.PapayaWhip;
                        DGclientes.Columns[6].HeaderText = "No.Int";
                        DGclientes.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                        DGclientes.Columns[7].Width = 80;
                        DGclientes.Columns[7].DefaultCellStyle.BackColor = Color.PapayaWhip;
                        DGclientes.Columns[7].HeaderText = "Colonia";
                        DGclientes.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                        DGclientes.Columns[8].Width = 80;
                        DGclientes.Columns[8].DefaultCellStyle.BackColor = Color.PapayaWhip;
                        DGclientes.Columns[8].HeaderText = "Delegación";
                        DGclientes.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                        DGclientes.Columns[9].Width = 80;
                        DGclientes.Columns[9].DefaultCellStyle.BackColor = Color.PapayaWhip;
                        DGclientes.Columns[9].HeaderText = "Estado";
                        DGclientes.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                        DGclientes.Columns[10].Width = 80;
                        DGclientes.Columns[10].DefaultCellStyle.BackColor = Color.PapayaWhip;
                        DGclientes.Columns[10].HeaderText = "Pais";
                        DGclientes.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                        DGclientes.Columns[11].Width = 80;
                        DGclientes.Columns[11].DefaultCellStyle.BackColor = Color.PapayaWhip;
                        DGclientes.Columns[11].HeaderText = "Teléfono";
                        DGclientes.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                        DGclientes.Columns[12].Width = 80;
                        DGclientes.Columns[12].DefaultCellStyle.BackColor = Color.PapayaWhip;
                        DGclientes.Columns[12].HeaderText = "RFC";
                        DGclientes.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                        DGclientes.Columns[13].Width = 40;
                        DGclientes.Columns[13].DefaultCellStyle.BackColor = Color.PapayaWhip;
                        DGclientes.Columns[13].HeaderText = "CP";
                        DGclientes.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                        SqlCommand cursor = new SqlCommand("select clte,razon,clte_lito,dig_lito,calle,numext,numint, " +
                    " colonia,delega,estado,pais,telefono,rfc,cp,atencion1,atencion2,atencion3,atencion4,atencion5,  " +
                    " nombre,apellidop,apellidom,clave,vendedor,comisvend,rebate,comis30,comis60,comis90,comistarj,cargofin," +
                    " diasrevi,email,porcmas,carta,tipoclte,clave,dsctopapel,dscto,diseno,plazo,lun,lunhora,mar,marhora,mie,miehora,jue,juehora,vie,viehora," +
                    " cuenta1,cuenta2,cuenta3,cuenta4,cuenta5,cuenta6,cuenta7,cuenta8,cuenta9,cuenta10, " +
                    " porefe,porche,portra,porcre,pormon,pordin,porval,pordeb,porser,porant,porotr, " +
                    " comen1,comen2,comen3,comen4,comen5,comen6,comen7,comen8,comen9,comen10, " +
                    " fpefe,fptra,fpche,fptdeb,fptcre,fptser,fpmon,fpno,fpnoa,solofact,ordencpa,presup,proveedor,montoaut,montoacum,porcanti " +
                    " from dbo.clientes where razon = '" + razoncons.Text + "' order by razon", con);
                        SqlDataReader cursorleido = cursor.ExecuteReader();
                        while (cursorleido.Read())
                        {
                            clte.Text = Convert.ToString(cursorleido["clte"]);
                            razon.Text = Convert.ToString(cursorleido["razon"]);
                            clte_lito.Text = Convert.ToString(cursorleido["clte_lito"]);
                            dig_lito.Text = Convert.ToString(cursorleido["dig_lito"]);
                            calle.Text = Convert.ToString(cursorleido["calle"]);
                            numext.Text = Convert.ToString(cursorleido["numext"]);
                            numint.Text = Convert.ToString(cursorleido["numint"]);
                            colonia.Text = Convert.ToString(cursorleido["colonia"]);
                            delega.Text = Convert.ToString(cursorleido["delega"]);
                            estado.Text = Convert.ToString(cursorleido["estado"]);
                            pais.Text = Convert.ToString(cursorleido["pais"]);
                            telefono.Text = Convert.ToString(cursorleido["telefono"]);
                            rfc.Text = Convert.ToString(cursorleido["rfc"]);
                            cp.Text = Convert.ToString(cursorleido["cp"]);
                            atencion1.Text = Convert.ToString(cursorleido["atencion1"]);
                            atencion2.Text = Convert.ToString(cursorleido["atencion2"]);
                            atencion3.Text = Convert.ToString(cursorleido["atencion3"]);
                            atencion4.Text = Convert.ToString(cursorleido["atencion4"]);
                            atencion5.Text = Convert.ToString(cursorleido["atencion5"]);
                            nombre.Text = Convert.ToString(cursorleido["nombre"]);
                            apellidop.Text = Convert.ToString(cursorleido["apellidop"]);
                            apellidom.Text = Convert.ToString(cursorleido["apellidom"]);
                            clave.Text = Convert.ToString(cursorleido["clave"]);
                            vendedor.Text = Convert.ToString(cursorleido["vendedor"]);
                            comisvend.Text = Convert.ToString(cursorleido["comisvend"]);
                            rebate.Text = Convert.ToString(cursorleido["rebate"]);
                            comis30.Text = Convert.ToString(cursorleido["comis30"]);
                            comis60.Text = Convert.ToString(cursorleido["comis60"]);
                            comis90.Text = Convert.ToString(cursorleido["comis90"]);
                            comistarj.Text = Convert.ToString(cursorleido["comistarj"]);
                            cargofin.Text = Convert.ToString(cursorleido["cargofin"]);
                            diasrevi.Text = Convert.ToString(cursorleido["diasrevi"]);
                            email.Text = Convert.ToString(cursorleido["email"]);
                            porcmas.Text = Convert.ToString(cursorleido["porcmas"]);
                            carta.Text = Convert.ToString(cursorleido["carta"]);
                            clave.Text = Convert.ToString(cursorleido["clave"]);
                            dsctopapel.Text = Convert.ToString(cursorleido["dsctopapel"]);
                            dscto.Text = Convert.ToString(cursorleido["dscto"]);
                            diseno.Text = Convert.ToString(cursorleido["diseno"]);
                            plazo.Text = Convert.ToString(cursorleido["plazo"]);
                            lunhora.Text = Convert.ToString(cursorleido["lunhora"]);
                            marhora.Text = Convert.ToString(cursorleido["marhora"]);
                            miehora.Text = Convert.ToString(cursorleido["miehora"]);
                            juehora.Text = Convert.ToString(cursorleido["juehora"]);
                            viehora.Text = Convert.ToString(cursorleido["viehora"]);
                            lun.Checked = Convert.ToBoolean(cursorleido["lun"]);
                            mar.Checked = Convert.ToBoolean(cursorleido["mar"]);
                            mie.Checked = Convert.ToBoolean(cursorleido["mie"]);
                            jue.Checked = Convert.ToBoolean(cursorleido["jue"]);
                            vie.Checked = Convert.ToBoolean(cursorleido["vie"]);
                            cuenta1.Text = Convert.ToString(cursorleido["cuenta1"]);
                            cuenta2.Text = Convert.ToString(cursorleido["cuenta2"]);
                            cuenta3.Text = Convert.ToString(cursorleido["cuenta3"]);
                            cuenta4.Text = Convert.ToString(cursorleido["cuenta4"]);
                            cuenta5.Text = Convert.ToString(cursorleido["cuenta5"]);
                            cuenta6.Text = Convert.ToString(cursorleido["cuenta6"]);
                            cuenta7.Text = Convert.ToString(cursorleido["cuenta7"]);
                            cuenta8.Text = Convert.ToString(cursorleido["cuenta8"]);
                            cuenta9.Text = Convert.ToString(cursorleido["cuenta9"]);
                            cuenta10.Text = Convert.ToString(cursorleido["cuenta10"]);
                            porefe.Text = Convert.ToString(cursorleido["porefe"]);
                            porche.Text = Convert.ToString(cursorleido["porche"]);
                            portra.Text = Convert.ToString(cursorleido["portra"]);
                            porcre.Text = Convert.ToString(cursorleido["porcre"]);
                            pormon.Text = Convert.ToString(cursorleido["pormon"]);
                            pordin.Text = Convert.ToString(cursorleido["pordin"]);
                            porval.Text = Convert.ToString(cursorleido["porval"]);
                            pordeb.Text = Convert.ToString(cursorleido["pordeb"]);
                            porser.Text = Convert.ToString(cursorleido["porser"]);
                            porant.Text = Convert.ToString(cursorleido["porant"]);
                            porotr.Text = Convert.ToString(cursorleido["porotr"]);
                            comen1.Text = Convert.ToString(cursorleido["comen1"]);
                            comen2.Text = Convert.ToString(cursorleido["comen2"]);
                            comen3.Text = Convert.ToString(cursorleido["comen3"]);
                            comen4.Text = Convert.ToString(cursorleido["comen4"]);
                            comen5.Text = Convert.ToString(cursorleido["comen5"]);
                            comen6.Text = Convert.ToString(cursorleido["comen6"]);
                            comen7.Text = Convert.ToString(cursorleido["comen7"]);
                            comen8.Text = Convert.ToString(cursorleido["comen8"]);
                            comen9.Text = Convert.ToString(cursorleido["comen9"]);
                            comen10.Text = Convert.ToString(cursorleido["comen10"]);
                            fpefe.Checked = Convert.ToBoolean(cursorleido["fpefe"]);
                            fptra.Checked = Convert.ToBoolean(cursorleido["fptra"]);
                            fpche.Checked = Convert.ToBoolean(cursorleido["fpche"]);
                            fptdeb.Checked = Convert.ToBoolean(cursorleido["fptdeb"]);
                            fptcre.Checked = Convert.ToBoolean(cursorleido["fptcre"]);
                            fptser.Checked = Convert.ToBoolean(cursorleido["fptser"]);
                            fpmon.Checked = Convert.ToBoolean(cursorleido["fpmon"]);
                            fpno.Checked = Convert.ToBoolean(cursorleido["fpno"]);
                            fpnoa.Checked = Convert.ToBoolean(cursorleido["fpnoa"]);
                            solofact.Text = Convert.ToString(cursorleido["solofact"]);
                            ordencpa.Text = Convert.ToString(cursorleido["ordencpa"]);
                            presup.Text = Convert.ToString(cursorleido["presup"]);
                            proveedor.Text = Convert.ToString(cursorleido["proveedor"]);
                            montoaut.Text = Convert.ToString(cursorleido["montoaut"]);
                            montoacum.Text = Convert.ToString(cursorleido["montoacum"]);
                            porcanti.Text = Convert.ToString(cursorleido["porcanti"]);

                            tipoclte.Enabled = false;
                            Lbl1montoaut.Visible = false;
                            Lbl2montoaut.Visible = false;
                            Lbl1montoacum.Visible = false;
                            Lbl2montoacum.Visible = false;
                            Lbl1porcanti.Visible = false;
                            Lbl2porcanti.Visible = false;
                            Lbl3porcanti.Visible = false;
                            montoaut.Enabled = false;
                            montoaut.Visible = false;
                            montoacum.Enabled = false;
                            montoacum.Visible = false;
                            porcanti.Enabled = false;
                            porcanti.Visible = false;

                        }
                        con.Close();
                    }
                    //     else
                    //   {
                    //         MessageBox.Show("Falta poner la Razón Social...!");
                    //   }
                }
            }
        }

        private void Btimprime_Click(object sender, EventArgs e)
        {
            this.Hide();
            FImprimir ss = new presupvisual.FImprimir();
            ss.Show();
        }

        private void Clte_lito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)48) | (e.KeyChar == (char)49) | (e.KeyChar == (char)50) | (e.KeyChar == (char)51) | (e.KeyChar == (char)52) | (e.KeyChar == (char)53) |
                (e.KeyChar == (char)54) | (e.KeyChar == (char)55) | (e.KeyChar == (char)56) | (e.KeyChar == (char)57) | (e.KeyChar == (char)58) | (e.KeyChar == (char)59) |
                (e.KeyChar == (char)13) | (e.KeyChar == (char)8) | (e.KeyChar == (char)9) | (e.KeyChar == (char)10) | (e.KeyChar == (char)11))
            {
            }
            else
            {
                MessageBox.Show("Sólo acepta números", "Litografía Gil");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (clte.Text == "")
            {
                MessageBox.Show("Falta poner la clave del cliente...!");
            }
            else
            {
                // Checa contraseña:
                Fcontra Fcontra = new Fcontra();
                Fcontra.pasado += new Fcontra.pasar(Ejecutar);
                Fcontra.ShowDialog();
                if (txtcontrase.Text.ToUpper() == "LLGG" || txtcontrase.Text.ToUpper() == "SSS")
                {
                    tipoclte.Enabled = true;
                    Lbl1montoaut.Visible = true;
                    Lbl2montoaut.Visible = true;
                    Lbl1montoacum.Visible = true;
                    Lbl2montoacum.Visible = true;
                    Lbl1porcanti.Visible = true;
                    Lbl2porcanti.Visible = true;
                    Lbl3porcanti.Visible = true;
                    montoaut.Enabled = true;
                    montoaut.Visible = true;
                    montoacum.Enabled = true;
                    montoacum.Visible = true;
                    porcanti.Enabled = true;
                    porcanti.Visible = true;
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta...!");
                }
            }
        }

        private void Montoaut_Leave(object sender, EventArgs e)
        {
            double montoautnum;
            montoautnum = Double.Parse(montoaut.Text);

            con.Open();
            cmd.CommandText = "update dbo.clientes set  " +
            " montoaut  = '" + montoautnum + "' where " +
            " clte = '" + clte.Text + "' ";
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Montoacum_Leave(object sender, EventArgs e)
        {
            double montoacumnum;
            montoacumnum = Double.Parse(montoacum.Text);

            con.Open();
            cmd.CommandText = "update dbo.clientes set  " +
            " montoacum  = '" + montoacumnum + "' where " +
            " clte = '" + clte.Text + "' ";
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Porcanti_Leave(object sender, EventArgs e)
        {
            double porcantinum;
            porcantinum = Double.Parse(porcanti.Text);

            con.Open();
            cmd.CommandText = "update dbo.clientes set  " +
            " porcanti  = '" + porcantinum + "' where " +
            " clte = '" + clte.Text + "' ";
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void BotonPagare_Click(object sender, EventArgs e)
        {
            this.Hide();
            FImprimirPagare1 ss = new presupvisual.FImprimirPagare1();
            ss.Show();
        }

        private void BotonContrato_Click(object sender, EventArgs e)
        {
            this.Hide();
            FContrato ss = new presupvisual.FContrato();
            ss.Show();
        }
    }
}