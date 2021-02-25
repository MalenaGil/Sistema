using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using objWord = Microsoft.Office.Interop.Word;

namespace presupvisual
{
    public partial class Fdamesuministrospf : Form
    {
        public Fdamesuministrospf()
        {
            InitializeComponent();

            DateTime fecha = DateTime.Today;

            string mes = "";
            string mesletras = "";
            mesletras = fecha.Month.ToString();

            if (mesletras == "1") { mes = "enero"; };
            if (mesletras == "2") { mes = "febrero"; };
            if (mesletras == "3") { mes = "marzo"; };
            if (mesletras == "4") { mes = "abril"; };
            if (mesletras == "5") { mes = "mayo"; };
            if (mesletras == "6") { mes = "junio"; };
            if (mesletras == "7") { mes = "julio"; };
            if (mesletras == "8") { mes = "agosto"; };
            if (mesletras == "9") { mes = "septiembre"; };
            if (mesletras == "10") { mes = "octubre"; };
            if (mesletras == "11") { mes = "noviembre"; };
            if (mesletras == "12") { mes = "diciembre"; };

            zfechacontrato.Text = fecha.Day.ToString() + " de " + mes + " de " + fecha.Year.ToString();

            int i = 0;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fproveedores ss = new presupvisual.Fproveedores();
            ss.Show();
        }

        private void btaceptar_Click(object sender, EventArgs e)
        {

            {
                //No olvides agregar la referencia Microsoft.Office.Interop.Word u Object Library Word a tu proyecto
                //---https://www.youtube.com/watch?v=wcEfwzvcluA

                btaceptar.BackColor = Color.Turquoise;

                //  laempresa.Text = "Litografía Gil, S. A. de C. V.";
                //  zreplegal.Text = "JOSÉ ABEL GIL GUERRA";
                //  ztestigo1.Text = "FEDERICO NAVARRETE SANCHEZ";
                //  ztestigo2.Text = "ALAN ADRIAN GAMBOA NAVARRO";

                string direc1e = "B) Acredita su personalidad con escritura constitutiva No. 25375 del 7 de noviembre de 1966, ante el ";
                string direc2e = "notario público número 58 LIC. MARIO D. REYNOSO OBREGÓN. Declara tener como RFC LGI661107M86, y domicilio fiscal: CALLE TOLTECA NO 169 ";
                string direc3e = "COL. IND SAN PEDRO DE LOS PINOS, CP 01180, DELEG. ALVARO OBREGÓN EN LA CIUDAD DE MEXICO (CDMX). ";

                string leyendapago = " ";
                if (mpago.Text == "1") { leyendapago = "90 días"; };
                if (mpago.Text == "2") { leyendapago = "60 días"; };
                if (mpago.Text == "3") { leyendapago = "45 días"; };
                if (mpago.Text == "4") { leyendapago = "1 mes"; };
                if (mpago.Text == "5") { leyendapago = "15 días"; };
                if (mpago.Text == "6") { leyendapago = "1 semana"; };
                if (mpago.Text == "7") { leyendapago = "1 día"; };

                Show();

                string rutalg = "C:/presupvisual/usuarios/proveedores-contratos/LitoGil/LG-SUMINISTROS-(PF)-" + mproveedor.Text;
                string rutael = "C:/presupvisual/usuarios/proveedores-contratos/EdiLito/EL-SUMINISTROS-(PF)-" + mproveedor.Text;
                string rutatl = "C:/presupvisual/usuarios/proveedores-contratos/Terminados/TL-SUMINISTROS-(PF)-" + mproveedor.Text;
                //string rutalg = "//server/presupvisual/usuarios/proveedores-contratos/LitoGil/LG-SUMINISTROS-(PF)-" + mproveedor.Text;
                //string rutael = "//server/presupvisual/usuarios/proveedores-contratos/EdiLito/EL-SUMINISTROS-(PF)-" + mproveedor.Text;
                //string rutatl = "//server/presupvisual/usuarios/proveedores-contratos/Terminados/TL-SUMINISTROS-(PF)-" + mproveedor.Text;

                objWord.Application objAplicacion = new objWord.Application();
                objWord.Document objDocumento = objAplicacion.Documents.Add();
                //    objAplicacion.Visible = true;

                objWord.Paragraph objParrfafo1 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo1.Range.Font.Bold = 0;
                objParrfafo1.Range.Font.Italic = 0;
                objParrfafo1.Range.Font.Underline = 0;
                objParrfafo1.Range.Font.Name = "Arial";
                objParrfafo1.Range.Font.Size = 9;
                string linea1 = "CONTRATO DE COMPRAVENTA (EN LO SUCESIVO EL 'CONTRATO')  QUE CELEBRAN, POR UNA PARTE, " + mrazon.Text.ToUpper().Trim()  + " ";
                string linea2 = "(A QUIEN EN LO SUCESIVO SE LE DENOMINARÁ EL 'VENDEDOR') Y POR OTRA PARTE " + laempresa.Text.ToUpper().Trim() + " ";
                string linea3 = "(A QUIEN EN LO SUCESIVO SE LE DENOMINARÁ EL 'CLIENTE') REPRESENTADO POR " + zreplegal.Text.ToUpper().Trim()  + " ";
                string linea4 = "EL CUAL SUJETAN AL TENOR DE LAS SIGUIENTES:  ";
                objParrfafo1.Range.Text = linea1 + linea2 + linea3 + linea4;
                objParrfafo1.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo1.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo1a = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo1a.Range.Font.Bold = 0;
                objParrfafo1a.Range.Font.Italic = 0;
                objParrfafo1a.Range.Font.Underline = 0;
                objParrfafo1a.Range.Font.Name = "Arial";
                objParrfafo1a.Range.Font.Size = 9;
                objParrfafo1a.Range.Text = " ";
                objParrfafo1a.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo1a.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo2 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo2.Range.Font.Bold = 1;
                objParrfafo2.Range.Font.Italic = 0;
                objParrfafo2.Range.Font.Underline = 0;
                objParrfafo2.Range.Font.Name = "Arial";
                objParrfafo2.Range.Font.Size = 10;
                objParrfafo2.Range.Text = " DECLARACIONES ";
                objParrfafo2.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphCenter;
                objParrfafo2.Range.InsertParagraphAfter();

                objParrfafo1a.Range.Text = " ";
                objParrfafo1a.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo1a.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo3 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo3.Range.Font.Bold = 0;
                objParrfafo3.Range.Font.Italic = 0;
                objParrfafo3.Range.Font.Underline = 0;
                objParrfafo3.Range.Font.Name = "Arial";
                objParrfafo3.Range.Font.Size = 9;
                string linea3a = "I.	Declara el CLIENTE por conducto de su representante legal: ";
                objParrfafo3.Range.Text = linea3a ;
                objParrfafo3.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphLeft;
                objParrfafo3.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo4 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo4.Range.Font.Bold = 0;
                objParrfafo4.Range.Font.Italic = 0;
                objParrfafo4.Range.Font.Underline = 0;
                objParrfafo4.Range.Font.Name = "Arial";
                objParrfafo4.Range.Font.Size = 9;
                string linea5 = "A) Que es una sociedad constituida conforme a las leyes mexicanas y que su apoderado " + zreplegal.Text.ToUpper().Trim();
                string linea6 = " tiene las facultades necesarias para celebrar el presente contrato en su representación.  ";
                objParrfafo4.Range.Text = linea5 + linea6;
                objParrfafo4.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo4.Range.InsertParagraphAfter();

                if (mbtlitogil.Checked)
                {
                    direc1e = "B) Acredita su personalidad con escritura constitutiva No. 25375 del 7 de noviembre de 1966, ante el ";
                    direc2e = "notario público número 58 LIC. MARIO D. REYNOSO OBREGÓN. Declara tener como RFC LGI661107M86, y domicilio fiscal: CALLE TOLTECA NO 169 ";
                    direc3e = "COL. IND SAN PEDRO DE LOS PINOS, CP 01180, DELEG. ALVARO OBREGÓN EN LA CIUDAD DE MEXICO (CDMX). ";
                };

                if (mbtediciones.Checked)
                {
                    direc1e = "B) Acredita su personalidad con escritura constitutiva No. , ";
                    direc2e = "ante el notario público número  . declara tener como RFC , y  ";
                    direc3e = "domicilio fiscal:  EN LA CIUDAD DE MEXICO (CDMX). ";
                };

                if (mbtterminados.Checked)
                {
                    direc1e = "B) Acredita su personalidad con escritura constitutiva No. 89794 del 17 de septiembre de 1998, ";
                    direc2e = "ante el notario público número 9 LIC.  JOSE ANGEL VILLALOBS MAGAÑA. Declara tener como RFC TLI9809183U3, y ";
                    direc3e = "domicilio fiscal: AV. TOLTECA NO 143 COL. IND SAN PEDRO DE LOS PINOS, CP 01180, DELEG. ALVARO OBREGÓN EN LA CIUDAD DE MEXICO (CDMX). ";
                };


                objWord.Paragraph objParrfafo5 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo5.Range.Font.Bold = 0;
                objParrfafo5.Range.Font.Italic = 0;
                objParrfafo5.Range.Font.Underline = 0;
                objParrfafo5.Range.Font.Name = "Arial";
                objParrfafo5.Range.Font.Size = 9;
                objParrfafo5.Range.Text = direc1e + direc2e + direc3e;
                objParrfafo5.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo5.Range.InsertParagraphAfter();

                if (mbtlitogil.Checked)
                {
                    objWord.Paragraph objParrfafo6 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                    objParrfafo6.Range.Font.Bold = 0;
                    objParrfafo6.Range.Font.Italic = 0;
                    objParrfafo6.Range.Font.Underline = 0;
                    objParrfafo6.Range.Font.Name = "Arial";
                    objParrfafo6.Range.Font.Size = 9;
                    string linea6a = "C) En su caso, su representante en este acto cuenta con facultades y poderes suficientes para celebrar el presente contrato, como consta de la ";
                    string linea6b = "escritura pública no. 125741 de fecha 25 de julio de 2014, otorgada ante el LIC. JOSÉ ANGEL VILLALOBOS MAGAÑA, notario público no. 9 del distrito federal, ";
                    string linea6c = "facultades y poderes que a la fecha no le han sido revocados ni limitados en forma alguna.  ";
                    objParrfafo6.Range.Text = linea6a + linea6b + linea6c;
                    objParrfafo6.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                    objParrfafo6.Range.InsertParagraphAfter();
                };

                if (mbtlitogil.Checked)
                {
                    objWord.Paragraph objParrfafo7 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                    objParrfafo7.Range.Font.Bold = 0;
                    objParrfafo7.Range.Font.Italic = 0;
                    objParrfafo7.Range.Font.Underline = 0;
                    objParrfafo7.Range.Font.Name = "Arial";
                    objParrfafo7.Range.Font.Size = 9;
                    string linea7a = "D) Que su Registro Federal de Contribuyentes es el LGI661107M86. ";
                    objParrfafo7.Range.Text = linea7a;
                    objParrfafo7.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                    objParrfafo7.Range.InsertParagraphAfter();
                }

                if (mbtterminados.Checked)
                {
                    objWord.Paragraph objParrfafo7a = objDocumento.Content.Paragraphs.Add(Type.Missing);
                    objParrfafo7a.Range.Font.Bold = 0;
                    objParrfafo7a.Range.Font.Italic = 0;
                    objParrfafo7a.Range.Font.Underline = 0;
                    objParrfafo7a.Range.Font.Name = "Arial";
                    objParrfafo7a.Range.Font.Size = 9;
                    string linea7aa = " D) Que su Registro Federal de Contribuyentes es el TLI9809183U3. ";
                    objParrfafo7a.Range.Text = linea7aa ;
                    objParrfafo7a.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                    objParrfafo7a.Range.InsertParagraphAfter();
                }

                objWord.Paragraph objParrfafo7b = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo7b.Range.Font.Bold = 0;
                objParrfafo7b.Range.Font.Italic = 0;
                objParrfafo7b.Range.Font.Underline = 0;
                objParrfafo7b.Range.Font.Name = "Arial";
                objParrfafo7b.Range.Font.Size = 9;
                string linea7ba = "E) Que su representada cuenta con los recursos económicos suficientes para celebrar el presente Contrato, por lo que, podrá cumplir con todos y ";
                string linea7bb = "cada uno de los términos y condiciones que más adelante se establecen en el mismo. ";
                objParrfafo7b.Range.Text = linea7ba + linea7bb;
                objParrfafo7b.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo7b.Range.InsertParagraphAfter();

                objParrfafo1a.Range.Text = " ";
                objParrfafo1a.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo1a.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo8 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo8.Range.Font.Bold = 0;
                objParrfafo8.Range.Font.Italic = 0;
                objParrfafo8.Range.Font.Underline = 0;
                objParrfafo8.Range.Font.Name = "Arial";
                objParrfafo8.Range.Font.Size = 9;
                objParrfafo8.Range.Text = "II.	Declara el VENDEDOR por conducto de su representante legal: ";
                objParrfafo8.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphLeft;
                objParrfafo8.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo9 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo9.Range.Font.Bold = 0;
                objParrfafo9.Range.Font.Italic = 0;
                objParrfafo9.Range.Font.Underline = 0;
                objParrfafo9.Range.Font.Name = "Arial";
                objParrfafo9.Range.Font.Size = 9;
                objParrfafo9.Range.Text = "A) Que " + mrazon.Text.ToUpper().Trim() + " es una persona física con actividades empresariales y con RFC: " + mrfc.Text.Trim();
                objParrfafo9.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo9.Range.InsertParagraphAfter();

                string linea10a = "B) Que acredita su personalidad con credencial para votar No. " + mcreden.Text.Trim() + " y con cédula de identificación fiscal de folio No. " + mfiscal.Text.Trim() + ", ";
                string linea10b = "con domicilio fiscal " + mdirec1.Text.ToUpper().Trim() + " " + mdirec2.Text.ToUpper().Trim() + " " + mdirec3.Text.ToUpper().Trim() + " ";
                string linea10c = "";
                if (mimss.Text != " ") { linea10c = "y número de registro patronal del IMSS " + mimss.Text.Trim() + "."; };

                objWord.Paragraph objParrfafo10 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo10.Range.Font.Bold = 0;
                objParrfafo10.Range.Font.Italic = 0;
                objParrfafo10.Range.Font.Underline = 0;
                objParrfafo10.Range.Font.Name = "Arial";
                objParrfafo10.Range.Font.Size = 9;
                objParrfafo10.Range.Text = linea10a + linea10b + linea10c;
                objParrfafo10.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo10.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo11 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo11.Range.Font.Bold = 0;
                objParrfafo11.Range.Font.Italic = 0;
                objParrfafo11.Range.Font.Underline = 0;
                objParrfafo11.Range.Font.Name = "Arial";
                objParrfafo11.Range.Font.Size = 9;
                objParrfafo11.Range.Text = "C) Que su RFC es " + mrfc.Text.Trim() + ".  ";
                objParrfafo11.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo11.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo12 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo12.Range.Font.Bold = 0;
                objParrfafo12.Range.Font.Italic = 0;
                objParrfafo12.Range.Font.Underline = 0;
                objParrfafo12.Range.Font.Name = "Arial";
                objParrfafo12.Range.Font.Size = 9;
                string linea12a = "D) Que presta servicios en forma independiente y que cuenta con diversos clientes. ";
                objParrfafo12.Range.Text = linea12a ;
                objParrfafo12.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo12.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo12a = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo12a.Range.Font.Bold = 0;
                objParrfafo12a.Range.Font.Italic = 0;
                objParrfafo12a.Range.Font.Underline = 0;
                objParrfafo12a.Range.Font.Name = "Arial";
                objParrfafo12a.Range.Font.Size = 9;
                string linea12aa = "E) Que se dedica a la venta de " + mespeci.Text.ToUpper().Trim() + ", y que por lo tanto, cuenta con los elementos necesarios para poder cumplir con el objeto de este Contrato. ";
                objParrfafo12a.Range.Text = linea12aa;
                objParrfafo12a.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo12a.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo12b = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo12b.Range.Font.Bold = 0;
                objParrfafo12b.Range.Font.Italic = 0;
                objParrfafo12b.Range.Font.Underline = 0;
                objParrfafo12b.Range.Font.Name = "Arial";
                objParrfafo12b.Range.Font.Size = 9;
                string linea12ba = "F) Que los productos objeto de este contrato no son, ni han sido instrumento, objeto o producto de algún delito; ni han sido utilizado para ";
                string linea12bb = "ocultar o mezclar bienes producto de un hecho delictivo y que los mismos no fueron adquiridos con producto de un acto ilícito. ";
                objParrfafo12b.Range.Text = linea12ba + linea12bb ;
                objParrfafo12b.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo12b.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo12c = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo12c.Range.Font.Bold = 0;
                objParrfafo12c.Range.Font.Italic = 0;
                objParrfafo12c.Range.Font.Underline = 0;
                objParrfafo12c.Range.Font.Name = "Arial";
                objParrfafo12c.Range.Font.Size = 9;
                string linea12ca = "G) Que cuenta con la solvencia moral y con los recursos económicos suficientes para celebrar el presente Contrato, por lo que, podrá cumplir ";
                string linea12cb = "con todos y cada uno de los términos y condiciones que más adelante se establecen en el mismo. ";
                objParrfafo12c.Range.Text = linea12ca + linea12cb;
                objParrfafo12c.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo12c.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo12d = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo12d.Range.Font.Bold = 0;
                objParrfafo12d.Range.Font.Italic = 0;
                objParrfafo12d.Range.Font.Underline = 0;
                objParrfafo12d.Range.Font.Name = "Arial";
                objParrfafo12d.Range.Font.Size = 9;
                string linea12da = "H) Que no se le ha promovido en su contra investigación, juicio penal, civil o mercantil alguno que pueda afectar la celebración del presente Contrato. ";
                objParrfafo12d.Range.Text = linea12da;
                objParrfafo12d.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo12d.Range.InsertParagraphAfter();

                objParrfafo1a.Range.Text = " ";
                objParrfafo1a.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo1a.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo12e = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo12e.Range.Font.Bold = 0;
                objParrfafo12e.Range.Font.Italic = 0;
                objParrfafo12e.Range.Font.Underline = 0;
                objParrfafo12e.Range.Font.Name = "Arial";
                objParrfafo12e.Range.Font.Size = 9;
                string linea12ea = "III.    Declaran ambas Partes que tienen interés en celebrar el presente Contrato, a fin de que el VENDEDOR le enajene al CLIENTE los PRODUCTOS que en el mismo se especifican. ";
                objParrfafo12e.Range.Text = linea12ea;
                objParrfafo12e.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo12e.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo12f = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo12f.Range.Font.Bold = 0;
                objParrfafo12f.Range.Font.Italic = 0;
                objParrfafo12f.Range.Font.Underline = 0;
                objParrfafo12f.Range.Font.Name = "Arial";
                objParrfafo12f.Range.Font.Size = 9;
                string linea12fa = "Conforme a lo expuesto, las Partes otorgan las siguientes: ";
                objParrfafo12f.Range.Text = linea12fa;
                objParrfafo12f.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo12f.Range.InsertParagraphAfter();

                objParrfafo1a.Range.Text = " ";
                objParrfafo1a.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo1a.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo13 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo13.Range.Font.Bold = 1;
                objParrfafo13.Range.Font.Italic = 0;
                objParrfafo13.Range.Font.Underline = objWord.WdUnderline.wdUnderlineSingle;
                objParrfafo13.Range.Font.Name = "Arial";
                objParrfafo13.Range.Font.Size = 9;
                objParrfafo13.Range.Text = "CLAUSULAS:";
                objParrfafo13.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphLeft;
                objParrfafo13.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo15 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo15.Range.Font.Bold = 0;
                objParrfafo15.Range.Font.Italic = 0;
                objParrfafo15.Range.Font.Underline = 0;
                objParrfafo15.Range.Font.Name = "Arial";
                objParrfafo15.Range.Font.Size = 9;
                string linea15a = "PRIMERA. Objeto. El VENDEDOR se obliga a vender, directamente, los PRODUCTOS descritos en la cotización expedida por el VENDEDOR ('LISTADO DE MATERIALES'), ";
                string linea15b = "en las órdenes de compra emitidas por el CLIENTE. ";
                objParrfafo15.Range.Text = linea15a + linea15b;
                objParrfafo15.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo15.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo15a = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo15a.Range.Font.Bold = 0;
                objParrfafo15a.Range.Font.Italic = 0;
                objParrfafo15a.Range.Font.Underline = 0;
                objParrfafo15a.Range.Font.Name = "Arial";
                objParrfafo15a.Range.Font.Size = 9;
                string linea15aa = "En todo momento, los PRODUCTOS enajenados por el VENDEDOR deberán reunir las características, especificaciones y demás atributos ";
                string linea15ab = "que sean necesarios para el óptimo desarrollo de las actividades del CLIENTE. ";
                objParrfafo15a.Range.Text = linea15aa + linea15ab;
                objParrfafo15a.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo15a.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo15b = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo15b.Range.Font.Bold = 0;
                objParrfafo15b.Range.Font.Italic = 0;
                objParrfafo15b.Range.Font.Underline = 0;
                objParrfafo15b.Range.Font.Name = "Arial";
                objParrfafo15b.Range.Font.Size = 9;
                string linea15ba = "El VENDEDOR manifiesta expresamente conocer los diseños, requerimientos, necesidades y expectativas del CLIENTE con respecto a los PRODUCTOS y ";
                string linea15bb = "en tal sentido garantiza que los PRODUCTOS cumplirán con dichos requerimientos, necesidades y expectativas. ";
                objParrfafo15b.Range.Text = linea15ba + linea15bb;
                objParrfafo15b.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo15b.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo15c = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo15c.Range.Font.Bold = 0;
                objParrfafo15c.Range.Font.Italic = 0;
                objParrfafo15c.Range.Font.Underline = 0;
                objParrfafo15c.Range.Font.Name = "Arial";
                objParrfafo15c.Range.Font.Size = 9;
                string linea15ca = "Las Partes acuerdan que los diseños de los PRODUCTOS están sujetos a aprobación del CLIENTE, por lo que en caso que durante la vigencia de este Contrato, ";
                string linea15cb = "se varié, modifique o de alguna manera se altere el diseño inicial de los PRODUCTOS, éstos deberán ser previamente aprobados por escrito por el CLIENTE. ";
                objParrfafo15c.Range.Text = linea15ca + linea15cb;
                objParrfafo15c.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo15c.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo16 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo16.Range.Font.Bold = 0;
                objParrfafo16.Range.Font.Italic = 0;
                objParrfafo16.Range.Font.Underline = 0;
                objParrfafo16.Range.Font.Name = "Arial";
                objParrfafo16.Range.Font.Size = 9;
                string linea16a = "SEGUNDA. Control de Calidad. El VENDEDOR se obliga a enajenar PRODUCTOS de la más alta calidad, así como a asegurar el control cualitativo ";
                string linea16b = "de éstos conforme a las siguientes bases enunciativas y no limitativas: ";
                objParrfafo16.Range.Text = linea16a + linea16b ;
                objParrfafo16.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo16.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo16a = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo16a.Range.Font.Bold = 0;
                objParrfafo16a.Range.Font.Italic = 0;
                objParrfafo16a.Range.Font.Underline = 0;
                objParrfafo16a.Range.Font.Name = "Arial";
                objParrfafo16a.Range.Font.Size = 9;
                string linea16aa = "  a) Propósitos y características. Los PRODUCTOS deben ajustarse a los propósitos requeridos por este Contrato, así como a las características que ";
                string linea16ab = "cualesquier otros PRODUCTOS de la misma descripción ordinariamente observan; ";
                objParrfafo16a.Range.Text = linea16aa + linea16ab;
                objParrfafo16a.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo16a.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo16b = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo16b.Range.Font.Bold = 0;
                objParrfafo16b.Range.Font.Italic = 0;
                objParrfafo16b.Range.Font.Underline = 0;
                objParrfafo16b.Range.Font.Name = "Arial";
                objParrfafo16b.Range.Font.Size = 9;
                string linea16ba = "  b) Finalidades comerciales. Los PRODUCTOS deben ajustarse a las finalidades u objetivos comerciales del CLIENTE, de los cuales tuvo ";
                string linea16bb = "conocimiento el VENDEDOR hasta el momento de la celebración de este Contrato; ";
                objParrfafo16b.Range.Text = linea16ba + linea16bb;
                objParrfafo16b.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo16b.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo16c = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo16c.Range.Font.Bold = 0;
                objParrfafo16c.Range.Font.Italic = 0;
                objParrfafo16c.Range.Font.Underline = 0;
                objParrfafo16c.Range.Font.Name = "Arial";
                objParrfafo16c.Range.Font.Size = 9;
                string linea16ca = "  c) Proceso. Los PRODUCTOS deben manipularse, empacarse y trasladarse con el cuidado y diligencia requerida para la protección de los mismos. ";
                objParrfafo16c.Range.Text = linea16ca ;
                objParrfafo16c.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo16c.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo16d = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo16d.Range.Font.Bold = 0;
                objParrfafo16d.Range.Font.Italic = 0;
                objParrfafo16d.Range.Font.Underline = 0;
                objParrfafo16d.Range.Font.Name = "Arial";
                objParrfafo16d.Range.Font.Size = 9;
                string linea16da = "En su caso, el VENDEDOR autoriza y faculta al CLIENTE para que un funcionario nombrado por este último, tenga acceso a las instalaciones del VENDEDOR, ";
                string linea16db = "con el objeto de verificar la calidad de los procesos de fabricación y de la fabricación en sí de los PRODUCTOS. ";
                objParrfafo16d.Range.Text = linea16da + linea16db;
                objParrfafo16d.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo16d.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo17 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo17.Range.Font.Bold = 0;
                objParrfafo17.Range.Font.Italic = 0;
                objParrfafo17.Range.Font.Underline = 0;
                objParrfafo17.Range.Font.Name = "Arial";
                objParrfafo17.Range.Font.Size = 9;
                string linea17a = "TERCERA. Entrega de los Productos.  El VENDEDOR se obliga a entregar al CLIENTE los PRODUCTOS, precisamente en la o las fechas y ";
                string linea17b = "en el o los distintos lugares indicados por el CLIENTE en la(s) ORDEN(ES) DE COMPRA, atendiendo a los requerimientos establecidos por el VENDEDOR; ";
                string linea17c = "el VENDEDOR deberá notificar de inmediato al CLIENTE cualquier retraso en la entrega de los PRODUCTOS, para el efecto de que el CLIENTE ";
                string linea17d = "tome las medidas correspondientes; sin embargo, en ningún caso podrá considerarse que la notificación del retraso implica una prórroga para dicha entrega.  ";
                objParrfafo17.Range.Text = linea17a + linea17b + linea17c + linea17d;
                objParrfafo17.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo17.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo17a = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo17a.Range.Font.Bold = 0;
                objParrfafo17a.Range.Font.Italic = 0;
                objParrfafo17a.Range.Font.Underline = 0;
                objParrfafo17a.Range.Font.Name = "Arial";
                objParrfafo17a.Range.Font.Size = 9;
                string linea17aa = "El riesgo por la entrega de los PRODUCTOS correrá a cargo del VENDEDOR hasta en tanto hayan sido entregados y recibidos a satisfacción del CLIENTE ";
                string linea17ab = "en los lugares por éste indicados. Para lo anterior, las Partes acuerdan que el hecho que el CLIENTE reciba en sus instalaciones los PRODUCTOS, ";
                string linea17ac = "no deber ser interpretado como que los productos han sido recibidos a la entera satisfacción del CLIENTE. ";
                objParrfafo17a.Range.Text = linea17aa + linea17ab + linea17ac ;
                objParrfafo17a.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo17a.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo17b = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo17b.Range.Font.Bold = 0;
                objParrfafo17b.Range.Font.Italic = 0;
                objParrfafo17b.Range.Font.Underline = 0;
                objParrfafo17b.Range.Font.Name = "Arial";
                objParrfafo17b.Range.Font.Size = 9;
                string linea17ba = "Todos los gastos que se originen para la entrega de los PRODUCTOS al CLIENTE, incluyendo sin limitar, empaque, transportación, seguros y carga, ";
                string linea17bb = "son por cuenta exclusiva del VENDEDOR. ";
                objParrfafo17b.Range.Text = linea17ba + linea17bb;
                objParrfafo17b.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo17b.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo18 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo18.Range.Font.Bold = 0;
                objParrfafo18.Range.Font.Italic = 0;
                objParrfafo18.Range.Font.Underline = 0;
                objParrfafo18.Range.Font.Name = "Arial";
                objParrfafo18.Range.Font.Size = 9;
                string linea8a = "CUARTA. Precio. Ambas Partes reconocen que el precio de los PRODUCTOS se indica en la COTIZACION y representa el precio total de los ";
                string linea8b = "PRODUCTOS terminados y entregados en la fecha, lugar y modo en que fueron acordados. El precio permanecerá fijo durante la vigencia de este Contrato. ";
                objParrfafo18.Range.Text = linea8a + linea8b;
                objParrfafo18.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo18.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo18a = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo18a.Range.Font.Bold = 0;
                objParrfafo18a.Range.Font.Italic = 0;
                objParrfafo18a.Range.Font.Underline = 0;
                objParrfafo18a.Range.Font.Name = "Arial";
                objParrfafo18a.Range.Font.Size = 9;
                string linea8aa = "Adicional, en caso de movimientos bruscos en tipo de cambio que impacten significativamente el precio de los PRODUCTOS, el VENDEDOR se obliga a ";
                string linea8ab = "informar al CLIENTE con 20 días de anticipación para hacer las revisiones correspondientes, en el entendido que, durante este período, el VENDEDOR se obliga a mantener los precios vigentes. ";
                objParrfafo18a.Range.Text = linea8aa + linea8ab;
                objParrfafo18a.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo18a.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo19 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo19.Range.Font.Bold = 0;
                objParrfafo19.Range.Font.Italic = 0;
                objParrfafo19.Range.Font.Underline = 0;
                objParrfafo19.Range.Font.Name = "Arial";
                objParrfafo19.Range.Font.Size = 9;
                string linea19a = "QUINTA. Forma de Pago. El CLIENTE se obliga a pagar al VENDEDOR, el precio total de los  PRODUCTOS objeto de este Contrato y recibidos por el ";
                string linea19b = "CLIENTE a su entera satisfacción. ";
                objParrfafo19.Range.Text = linea19a + linea19b ;
                objParrfafo19.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo19.Range.InsertParagraphAfter();









                objWord.Paragraph objParrfafo20 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo20.Range.Font.Bold = 0;
                objParrfafo20.Range.Font.Italic = 0;
                objParrfafo20.Range.Font.Underline = 0;
                objParrfafo20.Range.Font.Name = "Arial";
                objParrfafo20.Range.Font.Size = 9;
                objParrfafo20.Range.Text = "F) 'EL PRESTADOR' se obliga mediante la firma del presente contrato a: ";
                objParrfafo20.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo20.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo21 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo21.Range.Font.Bold = 0;
                objParrfafo21.Range.Font.Italic = 0;
                objParrfafo21.Range.Font.Underline = 0;
                objParrfafo21.Range.Font.Name = "Arial";
                objParrfafo21.Range.Font.Size = 9;
                objParrfafo21.Range.Text = "    -No copiar, fotocopiar o por cualquier otro medio reproducir la información total o parcial recibida. ";
                objParrfafo21.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo21.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo22 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo22.Range.Font.Bold = 0;
                objParrfafo22.Range.Font.Italic = 0;
                objParrfafo22.Range.Font.Underline = 0;
                objParrfafo22.Range.Font.Name = "Arial";
                objParrfafo22.Range.Font.Size = 9;
                objParrfafo22.Range.Text = "    -No utilizar en todo o en parte la información confidencial para fines distintos a los intereses de 'EL CLIENTE'. ";
                objParrfafo22.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo22.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo23 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo23.Range.Font.Bold = 0;
                objParrfafo23.Range.Font.Italic = 0;
                objParrfafo23.Range.Font.Underline = 0;
                objParrfafo23.Range.Font.Name = "Arial";
                objParrfafo23.Range.Font.Size = 9;
                string linea23a = "G) 'EL PRESTADOR' está de acuerdo en que responderá por el incumplimiento al presente contrato mediante el pago y los perjuicios ";
                string linea23b = "que tal incumplimiento ocasionare, siendo siempre el monto mínimo de pago, la magnitud del daño causado al contratante, independientemente de las sanciones ";
                string linea23c = "a que se hagan acreedores de acuerdo a la legislación mexicana. ";
                objParrfafo23.Range.Text = linea23a + linea23b + linea23c;
                objParrfafo23.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo23.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo24 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo24.Range.Font.Bold = 0;
                objParrfafo24.Range.Font.Italic = 0;
                objParrfafo24.Range.Font.Underline = 0;
                objParrfafo24.Range.Font.Name = "Arial";
                objParrfafo24.Range.Font.Size = 9;
                string linea24a = "Ambas partes conocen las responsabilidades y sanciones legales previstas en los artículos 210 y 211 del código penal federal y sus correlativos ";
                string linea24b = "en los estados de la República Mexicana aplicables, así como las establecidas en la Ley Federal de Derechos de Autor y la Ley de la Propiedad Industrial, ";
                string linea24c = "en el caso de incumplimiento con lo estipulado en el presente contrato. ";
                objParrfafo24.Range.Text = linea24a + linea24b + linea24c;
                objParrfafo24.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo24.Range.InsertParagraphAfter();

                objParrfafo1a.Range.Text = " ";
                objParrfafo1a.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo1a.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo25 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo25.Range.Font.Bold = 1;
                objParrfafo25.Range.Font.Italic = 0;
                objParrfafo25.Range.Font.Underline = objWord.WdUnderline.wdUnderlineSingle;
                objParrfafo25.Range.Font.Name = "Arial";
                objParrfafo25.Range.Font.Size = 9;
                objParrfafo25.Range.Text = "OBJETO:";
                objParrfafo25.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphLeft;
                objParrfafo25.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo26 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo26.Range.Font.Bold = 0;
                objParrfafo26.Range.Font.Italic = 0;
                objParrfafo26.Range.Font.Underline = 0;
                objParrfafo26.Range.Font.Name = "Arial";
                objParrfafo26.Range.Font.Size = 9;
                objParrfafo26.Range.Text = "1) El trabajo consiste en: " + mespeci.Text.ToUpper().Trim() + ". ";
                objParrfafo26.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo26.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo27 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo27.Range.Font.Bold = 0;
                objParrfafo27.Range.Font.Italic = 0;
                objParrfafo27.Range.Font.Underline = 0;
                objParrfafo27.Range.Font.Name = "Arial";
                objParrfafo27.Range.Font.Size = 9;
                objParrfafo27.Range.Text = "2) El trabajo se realizará en las instalaciones de 'EL PRESTADOR'. ";
                objParrfafo27.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo27.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo28 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo28.Range.Font.Bold = 0;
                objParrfafo28.Range.Font.Italic = 0;
                objParrfafo28.Range.Font.Underline = 0;
                objParrfafo28.Range.Font.Name = "Arial";
                objParrfafo28.Range.Font.Size = 9;
                objParrfafo28.Range.Text = "3) Cuenta con el activo necesario para la realización de los trabajos contratados. ";
                objParrfafo28.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo28.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo29 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo29.Range.Font.Bold = 0;
                objParrfafo29.Range.Font.Italic = 0;
                objParrfafo29.Range.Font.Underline = 0;
                objParrfafo29.Range.Font.Name = "Arial";
                objParrfafo29.Range.Font.Size = 9;
                string linea29a = "4) Monto del contrato: el precio se determinará en cada trabajo a realizar, 'EL PRESTADOR' se compromete a ";
                string linea29b = "entregar una cotización para que 'EL CLIENTE', lo autorice si conviene así a sus intereses a la cantidad ";
                string linea29c = "que resulte se le agregara el impuesto al valor agregado. ";
                objParrfafo29.Range.Text = linea29a + linea29b + linea29c;
                objParrfafo29.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo29.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo30 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo30.Range.Font.Bold = 0;
                objParrfafo30.Range.Font.Italic = 0;
                objParrfafo30.Range.Font.Underline = 0;
                objParrfafo30.Range.Font.Name = "Arial";
                objParrfafo30.Range.Font.Size = 9;
                string linea30a = "5) En virtud de que 'EL PRESTADOR' cuenta con elementos propios suficientes para llevar a cabo sus actividades y ";
                string linea30b = "cumplir con las obligaciones en relación con sus trabajadores en términos de lo dispuesto por el artículo 13 de la Ley ";
                string linea30c = "Federal del Trabajo, 'EL PRESTADOR' es y será el único responsable del cumplimiento de todas y cada una de sus obligaciones laborales ";
                string linea30d = "y de seguridad social en relación con todos y cada uno de sus trabajadores, especialmente de aquellos trabajadores que sean asignados por ";
                string linea30e = "'EL PRESTADOR' a la prestación de los SERVICIOS. ";
                objParrfafo30.Range.Text = linea30a + linea30b + linea30c + linea30d + linea30e;
                objParrfafo30.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo30.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo31 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo31.Range.Font.Bold = 0;
                objParrfafo31.Range.Font.Italic = 0;
                objParrfafo31.Range.Font.Underline = 0;
                objParrfafo31.Range.Font.Name = "Arial";
                objParrfafo31.Range.Font.Size = 9;
                string linea31a = "En virtud de que 'EL PRESTADOR' y, en su caso, los trabajadores de 'EL PRESTADOR' no tienen ni tendrán relación laboral alguna con 'EL CLIENTE', ";
                string linea31b = "'EL PRESTADOR' se obliga a sacar en paz y a salvo a 'EL CLIENTE' y, en su caso, a indemnizar a 'EL CLIENTE' de cualquier demanda, reclamación, denuncia ";
                string linea31c = "o querella presentada por 'EL PRESTADOR'  y/o cualquiera de los trabajadores de 'EL PRESTADOR' en contra de 'EL CLIENTE', sus directores, gerentes, ";
                string linea31d = "administradores, funcionarios, empleados o partes relacionadas por los motivos señalados en la presente cláusula. ";
                objParrfafo31.Range.Text = linea31a + linea31b + linea31c + linea31d;
                objParrfafo31.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo31.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo32 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo32.Range.Font.Bold = 0;
                objParrfafo32.Range.Font.Italic = 0;
                objParrfafo32.Range.Font.Underline = 0;
                objParrfafo32.Range.Font.Name = "Arial";
                objParrfafo32.Range.Font.Size = 9;
                string linea32a = "'EL PRESTADOR' se obliga a sacar en paz y a salvo a 'EL CLIENTE' y, en su caso, a indemnizar a 'EL CLIENTE' de cualquier procedimiento, multa o ";
                string linea32b = "sanción interpuesta en contra de 'EL CLIENTE' por cualquier autoridad laboral, del trabajo o de seguridad social relacionada con 'EL PRESTADOR' y/o ";
                string linea32c = "con cualquiera de los trabajadores de 'EL PRESTADOR', especialmente con los trabajadores de 'EL PRESTADOR' asignados a la prestación de los SERVICIOS. ";
                objParrfafo32.Range.Text = linea32a + linea32b + linea32c;
                objParrfafo32.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo32.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo33 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo33.Range.Font.Bold = 0;
                objParrfafo33.Range.Font.Italic = 0;
                objParrfafo33.Range.Font.Underline = 0;
                objParrfafo33.Range.Font.Name = "Arial";
                objParrfafo33.Range.Font.Size = 9;
                string linea33a = "De conformidad con lo dispuesto por los artículos 1913, 1935 y demás relativos y aplicables del Código Civil para el Distrito Federal, 'EL PRESTADOR' ";
                string linea33b = "expresamente reconoce y acepta que 'EL PRESTADOR' es y será el único responsable: (i) de los accidentes de trabajo y de las enfermedades profesionales que sufra, ";
                string linea33c = "así como de los de sus trabajadores con motivo o en el ejercicio de la profesión o trabajo que ejecuten, obligándose a pagar la indemnización correspondiente; ";
                string linea33d = "y (ii) del daño que cause él y/o sus trabajadores, aunque no obre ilícitamente, con motivo de la prestación de los SERVICIOS. Asimismo, 'EL PRESTADOR' se obliga a mantener ";
                string linea33e = "en paz y a salvo a 'EL CLIENTE, sus accionistas, administradores, directores, personal y clientes de cualquier demanda o reclamación presentada en contra de cualesquiera ";
                string linea33f = "de ellos por esos motivos, obligándose, en su caso, a indemnizarlos por los daños y perjuicios sufridos. ";
                objParrfafo33.Range.Text = linea33a + linea33b + linea33c + linea33d + linea33e + linea33f;
                objParrfafo33.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo33.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo34 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo34.Range.Font.Bold = 0;
                objParrfafo34.Range.Font.Italic = 0;
                objParrfafo34.Range.Font.Underline = 0;
                objParrfafo34.Range.Font.Name = "Arial";
                objParrfafo34.Range.Font.Size = 9;
                string linea34a = "6) El personal de 'EL PRESTADOR' asignado con motivo del presente contrato no podrá ser contratado como trabajador de 'EL CLIENTE' directa o por interpósita persona, ";
                string linea34b = "mientras formen parte del personal de 'EL PRESTADOR'. ";
                objParrfafo34.Range.Text = linea34a + linea34b;
                objParrfafo34.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo34.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo35 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo35.Range.Font.Bold = 0;
                objParrfafo35.Range.Font.Italic = 0;
                objParrfafo35.Range.Font.Underline = 0;
                objParrfafo35.Range.Font.Name = "Arial";
                objParrfafo35.Range.Font.Size = 9;
                string linea35a = "7) Plazo del contrato: este contrato será vigente por tiempo indefinido o, hasta que el cliente o 'EL PRESTADOR' decidan terminarlo en cualquier ";
                string linea35b = "tiempo por medio de un aviso por escrito con 30 días de anticipación. ";
                objParrfafo35.Range.Text = linea35a + linea35b;
                objParrfafo35.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo35.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo36 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo36.Range.Font.Bold = 0;
                objParrfafo36.Range.Font.Italic = 0;
                objParrfafo36.Range.Font.Underline = 0;
                objParrfafo36.Range.Font.Name = "Arial";
                objParrfafo36.Range.Font.Size = 9;
                string linea36a = "8) 'EL PRESTADOR', podrá efectuar entregas parciales de cada trabajo. 'EL CLIENTE' se obliga a recibirlas, previo aviso que aquel haga, cuando existieren trabajos ";
                string linea36b = "terminados y sus partes sean identificables y susceptibles de utilizarse.  La recepción total de los trabajos, se realizará también previo aviso de 'EL PRESTADOR' ";
                string linea36c = "a 'EL CLIENTE' una vez concluidos los trabajos, y este se obliga a recibirlos, reservándose el derecho de reclamar a 'EL PRESTADOR' por trabajos faltantes o mal ejecutados. ";
                objParrfafo36.Range.Text = linea36a + linea36b + linea36c;
                objParrfafo36.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo36.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo37 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo37.Range.Font.Bold = 0;
                objParrfafo37.Range.Font.Italic = 0;
                objParrfafo37.Range.Font.Underline = 0;
                objParrfafo37.Range.Font.Name = "Arial";
                objParrfafo37.Range.Font.Size = 9;
                string linea37a = "9) 'EL PRESTADOR' presentará su factura después de entregar cada trabajo los días miércoles para su revisión y el pago se realizará " + leyendapago + " después. ";
                objParrfafo37.Range.Text = linea37a;
                objParrfafo37.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo37.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo38 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo38.Range.Font.Bold = 0;
                objParrfafo38.Range.Font.Italic = 0;
                objParrfafo38.Range.Font.Underline = 0;
                objParrfafo38.Range.Font.Name = "Arial";
                objParrfafo38.Range.Font.Size = 9;
                string linea38a = "10) 'EL PRESTADOR' se obliga a que los materiales y equipo que se utilicen en los trabajos objeto de la obra motivo del contrato cumplan con las normas de calidad establecidas ";
                string linea38b = "en cada cotización  y que la realización de todas y cada una de las partes de dicho trabajo se efectúen a satisfacción de 'EL CLIENTE' así como a responder por su cuenta y riesgo ";
                string linea38c = "de los defectos y vicios ocultos de la misma y de los daños  y perjuicios que por negligencia o inobservancia de sus partes se lleguen a causar a 'EL CLIENTE' o a terceros. ";
                objParrfafo38.Range.Text = linea38a + linea38b + linea38c;
                objParrfafo38.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo38.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo39 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo39.Range.Font.Bold = 0;
                objParrfafo39.Range.Font.Italic = 0;
                objParrfafo39.Range.Font.Underline = 0;
                objParrfafo39.Range.Font.Name = "Arial";
                objParrfafo39.Range.Font.Size = 9;
                string linea39a = "11) Igualmente se obliga 'EL PRESTADOR' a no ceder a terceras personas físicas o morales sus derechos y obligaciones derivados de este contrato, así como los derechos ";
                string linea39b = "de cobro sobre los bienes o trabajos ejecutados que amprar este contrato sin previa aprobación expresa y por escrito de 'EL CLIENTE'. ";
                objParrfafo39.Range.Text = linea39a + linea39b;
                objParrfafo39.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo39.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo40 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo40.Range.Font.Bold = 0;
                objParrfafo40.Range.Font.Italic = 0;
                objParrfafo40.Range.Font.Underline = 0;
                objParrfafo40.Range.Font.Name = "Arial";
                objParrfafo40.Range.Font.Size = 9;
                string linea40a = "12) Cada una de las Partes se obliga a sacar en paz y a salvo y en su caso a indemnizar a la otra Parte contra cualquier demanda, reclamación, acción legal, ";
                string linea40b = "daño y/o perjuicio interpuesto y/o reclamado por cualquier tercero en contra de una de las Partes como resultado de un acto u omisión que le sea imputable a la otra Parte.  ";
                objParrfafo40.Range.Text = linea40a + linea40b;
                objParrfafo40.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo40.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo41 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo41.Range.Font.Bold = 0;
                objParrfafo41.Range.Font.Italic = 0;
                objParrfafo41.Range.Font.Underline = 0;
                objParrfafo41.Range.Font.Name = "Arial";
                objParrfafo41.Range.Font.Size = 9;
                string linea41a = "13) 'EL PRESTADOR' se obliga a sacar en paz y a salvo y en su caso a indemnizar a 'EL CLIENTE' contra cualquier demanda, reclamación, acción legal, daño y / o perjuicio interpuesto y / o reclamado ";
                string linea41b = "por cualquier tercero en contra de 'EL CLIENTE' por violaciones a cualquier derecho de propiedad intelectual de terceros relacionadas con la prestación de los SERVICIOS.  ";
                objParrfafo41.Range.Text = linea41a + linea41b;
                objParrfafo41.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo41.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo42 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo42.Range.Font.Bold = 0;
                objParrfafo42.Range.Font.Italic = 0;
                objParrfafo42.Range.Font.Underline = 0;
                objParrfafo42.Range.Font.Name = "Arial";
                objParrfafo42.Range.Font.Size = 9;
                string linea42a = "14) 'EL PRESTADOR' se obliga a sacar en paz y a salvo y en su caso a indemnizar a 'EL CLIENTE' cualquier daño y/o perjuicio, incluyendo de manera no limitativa, cualquier daño por robo, deterioro, ";
                string linea42b = "destrucción o pérdida de equipo o mobiliario de 'EL CLIENTE' o de terceros, incluyendo en el LUGAR DE PRESTACION DE SERVICIOS, durante la prestación de los SERVICIOS.  ";
                objParrfafo42.Range.Text = linea42a + linea42b;
                objParrfafo42.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo42.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo43 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo43.Range.Font.Bold = 0;
                objParrfafo43.Range.Font.Italic = 0;
                objParrfafo43.Range.Font.Underline = 0;
                objParrfafo43.Range.Font.Name = "Arial";
                objParrfafo43.Range.Font.Size = 9;
                string linea43a = "15) 'EL PRESTADOR' reconoce y está de acuerdo en que el simple retraso en el cumplimiento de cualquiera de sus obligaciones conforme a este Contrato, especialmente en la ";
                string linea43b = "prestación de los SERVICIOS, o el hecho de que los SERVICIOS no se presten de conformidad con las ESPECIFICACIONES, puede ocasionar graves daños y perjuicios a 'EL CLIENTE', ";
                string linea43c = "por lo que 'EL PRESTADOR' está de acuerdo en y acepta pagar como pena convencional por el simple retraso en el cumplimiento de cualquiera de sus obligaciones conforme a ";
                string linea43d = "este Contrato, especialmente en la prestación de los SERVICIOS, o por el hecho de que los SERVICIOS no se presten de conformidad con las ESPECIFICACIONES la cantidad ";
                string linea43e = "correspondiente al 10% del valor de cada  proyecto por todo el tiempo que dure el retraso en el cumplimiento de su obligación o hasta que los SERVICIOS sean prestados ";
                string linea43f = "de acuerdo a las ESPECIFICACIONES. Lo anterior, sin perjuicio de cualquier otro derecho que pueda tener 'EL CLIENTE' de conformidad con el presente contrato y/o la legislación aplicable. ";
                objParrfafo43.Range.Text = linea43a + linea43b + linea43c + linea43d + linea43e + linea43f;
                objParrfafo43.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo43.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo44 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo44.Range.Font.Bold = 0;
                objParrfafo44.Range.Font.Italic = 0;
                objParrfafo44.Range.Font.Underline = 0;
                objParrfafo44.Range.Font.Name = "Arial";
                objParrfafo44.Range.Font.Size = 9;
                string linea44a = "16) Para la interpretación y cumplimiento del presente contrato, las partes se someten a la jurisdicción de los tribunales competentes de la Ciudad de México ";
                string linea44b = "(CDMX) y a los previstos por la legislación aplicable al presente contrato, renunciando al fuero que pudiera corresponderles por razón de sus domicilios presentes y futuros. ";
                objParrfafo44.Range.Text = linea44a + linea44b;
                objParrfafo44.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo44.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo45 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo45.Range.Font.Bold = 0;
                objParrfafo45.Range.Font.Italic = 0;
                objParrfafo45.Range.Font.Underline = 0;
                objParrfafo45.Range.Font.Name = "Arial";
                objParrfafo45.Range.Font.Size = 9;
                string linea45a = "Enteradas las partes del contenido, alcance y fuerza legal del presente contrato, lo ratifican y firman de conformidad por duplicado, en la Ciudad de México ";
                string linea45b = "(CDMX) el día " + zfechacontrato.Text.ToUpper().Trim() + ".";
                objParrfafo45.Range.Text = linea45a + linea45b;
                objParrfafo45.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo45.Range.InsertParagraphAfter();

                objParrfafo1a.Range.Text = " ";
                objParrfafo1a.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo1a.Range.InsertParagraphAfter();

                objParrfafo1a.Range.Text = " ";
                objParrfafo1a.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo1a.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo46 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo46.Range.Font.Bold = 1;
                objParrfafo46.Range.Font.Italic = 0;
                objParrfafo46.Range.Font.Underline = 0;
                objParrfafo46.Range.Font.Name = "Arial";
                objParrfafo46.Range.Font.Size = 9;
                string linea46a = " 'EL CLIENTE'                                                                    'EL PRESTADOR'";
                objParrfafo46.Range.Text = linea46a;
                objParrfafo46.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphCenter;
                objParrfafo46.Range.InsertParagraphAfter();

                objParrfafo1a.Range.Text = " ";
                objParrfafo1a.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo1a.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo47 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo47.Range.Font.Bold = 1;
                objParrfafo47.Range.Font.Italic = 0;
                objParrfafo47.Range.Font.Underline = 0;
                objParrfafo47.Range.Font.Name = "Arial";
                objParrfafo47.Range.Font.Size = 9;
                string linea47a = "_________________________                                       _________________________ ";
                objParrfafo47.Range.Text = linea47a;
                objParrfafo47.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphCenter;
                objParrfafo47.Range.InsertParagraphAfter();

                int valora = (zreplegal.Text.Trim()).Length;
                int valorb = (mrazon.Text.Trim()).Length;
                int blancos = 88 - valora - valorb;

                string espacio = " ";
                for (int i = 0; i < blancos; i++) { espacio = espacio + ' '; };

                objWord.Paragraph objParrfafo48 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo48.Range.Font.Bold = 1;
                objParrfafo48.Range.Font.Italic = 0;
                objParrfafo48.Range.Font.Underline = 0;
                objParrfafo48.Range.Font.Name = "Arial";
                objParrfafo48.Range.Font.Size = 9;
                string linea48a = "                     " + zreplegal.Text.ToUpper().Trim() + espacio + mrazon.Text.ToUpper().Trim();
                objParrfafo48.Range.Text = linea48a;
                objParrfafo48.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphCenter;
                objParrfafo48.Range.InsertParagraphAfter();

                objParrfafo1a.Range.Text = " ";
                objParrfafo1a.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo1a.Range.InsertParagraphAfter();

                objParrfafo1a.Range.Text = " ";
                objParrfafo1a.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo1a.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo50 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo50.Range.Font.Bold = 1;
                objParrfafo50.Range.Font.Italic = 0;
                objParrfafo50.Range.Font.Underline = 0;
                objParrfafo50.Range.Font.Name = "Arial";
                objParrfafo50.Range.Font.Size = 9;
                string linea50a = "   TESTIGO                                                                          TESTIGO";
                objParrfafo50.Range.Text = linea50a;
                objParrfafo50.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphCenter;
                objParrfafo50.Range.InsertParagraphAfter();

                objParrfafo1a.Range.Text = " ";
                objParrfafo1a.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo1a.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo51 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo51.Range.Font.Bold = 1;
                objParrfafo51.Range.Font.Italic = 0;
                objParrfafo51.Range.Font.Underline = 0;
                objParrfafo51.Range.Font.Name = "Arial";
                objParrfafo51.Range.Font.Size = 9;
                string linea51a = "_________________________                                       _________________________ ";
                objParrfafo51.Range.Text = linea51a;
                objParrfafo51.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphCenter;
                objParrfafo51.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo52 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo52.Range.Font.Bold = 1;
                objParrfafo52.Range.Font.Italic = 0;
                objParrfafo52.Range.Font.Underline = 0;
                objParrfafo52.Range.Font.Name = "Arial";
                objParrfafo52.Range.Font.Size = 9;
                string linea52a = ztestigo1.Text.ToUpper().Trim();
                string linea52b = ztestigo2.Text.ToUpper().Trim();
                objParrfafo52.Range.Text = linea52a + "               " + linea52b;
                objParrfafo52.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphCenter;
                objParrfafo52.Range.InsertParagraphAfter();


                ////////////////////////////////////////////////////


                btaceptar.BackColor = Color.Green;


                if (mbtlitogil.Checked) { objDocumento.SaveAs2(rutalg); MessageBox.Show("Contrato generado en: " + rutalg); };
                if (mbtediciones.Checked) { objDocumento.SaveAs2(rutael); MessageBox.Show("Contrato generado en: " + rutael); };
                if (mbtterminados.Checked) { objDocumento.SaveAs2(rutatl); MessageBox.Show("Contrato generado en: " + rutatl); }

                objDocumento.Close();
                objAplicacion.Quit();

                this.Hide();
                Fproveedores ss = new presupvisual.Fproveedores();
                ss.Show();

            }

        }

    }
}

