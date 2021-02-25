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
    public partial class Fdamesuministrospm : Form
    {
        public Fdamesuministrospm()
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


                string direc1e = "B) Acredita su personalidad con escritura constitutiva No. 25375 del 7 de noviembre de 1966, ante el ";
                string direc2e = "notario público número 58 LIC. MARIO D. REYNOSO OBREGÓN. Declara tener como RFC LGI661107M86, y domicilio fiscal: CALLE TOLTECA NO 169 ";
                string direc3e = "COL. IND SAN PEDRO DE LOS PINOS, CP 01180, DELEG. ALVARO OBREGÓN EN LA CIUDAD DE MEXICO (CDMX). ";

                string linea1c = "C) En su caso, su representante en este acto cuenta con facultades y poderes suficientes para celebrar el presente contrato, como consta de la ";
                string linea2c = "escritura pública no. 125741 de fecha 25 de julio de 2014, otorgada ante el LIC. JOSÉ ANGEL VILLALOBOS MAGAÑA, notario público no. 9 del distrito federal, ";
                string linea3c = "facultades y poderes que a la fecha no le han sido revocados ni limitados en forma alguna.  ";

                string linea1d = "D) Que en virtud de la necesidad que tiene de " + mespeci.Text.ToUpper().Trim() + ", celebran el presente contrato. ";



                string leyendapago = " ";
                if (mpago.Text == "1") { leyendapago = "90 días"; };
                if (mpago.Text == "2") { leyendapago = "60 días"; };
                if (mpago.Text == "3") { leyendapago = "45 días"; };
                if (mpago.Text == "4") { leyendapago = "1 mes"; };
                if (mpago.Text == "5") { leyendapago = "15 días"; };
                if (mpago.Text == "6") { leyendapago = "1 semana"; };
                if (mpago.Text == "7") { leyendapago = "1 día"; };


                if (mbtlitogil.Checked)
                {
                    direc1e = "B) Acredita su personalidad con escritura constitutiva No. 25375 del 7 de noviembre de 1966, ante el ";
                    direc2e = "notario público número 58 LIC. MARIO D. REYNOSO OBREGÓN. Declara tener como RFC LGI661107M86, y domicilio fiscal: CALLE TOLTECA NO 169 ";
                    direc3e = "COL. IND SAN PEDRO DE LOS PINOS, CP 01180, DELEG. ALVARO OBREGÓN EN LA CIUDAD DE MEXICO (CDMX). ";
                    linea1c = "C) En su caso, su representante en este acto cuenta con facultades y poderes suficientes para celebrar el presente contrato, como consta de la ";
                    linea2c = "escritura pública no. 125741 de fecha 25 de julio de 2014, otorgada ante el LIC. JOSÉ ANGEL VILLALOBOS MAGAÑA, notario público no. 9 del distrito federal, ";
                    linea3c = "facultades y poderes que a la fecha no le han sido revocados ni limitados en forma alguna.  ";
                    linea1d = "D) Que en virtud de la necesidad que tiene de " + mespeci.Text.ToUpper().Trim() + ", celebran el presente contrato. ";
                };

                if (mbtediciones.Checked)
                {
                    direc1e = "B) Acredita su personalidad con escritura constitutiva No. , ";
                    direc2e = "ante el notario público número  . declara tener como RFC , y  ";
                    direc3e = "domicilio fiscal:  EN LA CIUDAD DE MEXICO (CDMX). ";
                    linea1c = "";
                    linea2c = "";
                    linea3c = "";
                    linea1d = "C) Que en virtud de la necesidad que tiene de " + mespeci.Text.ToUpper().Trim() + ", celebran el presente contrato. ";
                };

                if (mbtterminados.Checked)
                {
                    direc1e = "B) Acredita su personalidad con escritura constitutiva No. 89794 del 17 de septiembre de 1998, ";
                    direc2e = "ante el notario público número 9 LIC.  JOSE ANGEL VILLALOBS MAGAÑA. Declara tener como RFC TLI9809183U3, y ";
                    direc3e = "domicilio fiscal: AV. TOLTECA NO 143 COL. IND SAN PEDRO DE LOS PINOS, CP 01180, DELEG. ALVARO OBREGÓN EN LA CIUDAD DE MEXICO (CDMX). ";
                    linea1c = "";
                    linea2c = "";
                    linea3c = "";
                    linea1d = "C) Que en virtud de la necesidad que tiene de " + mespeci.Text.ToUpper().Trim() + ", celebran el presente contrato. ";
                };

                Show();

                string rutalg = "C:/presupvisual/usuarios/proveedores-contratos/LitoGil/LG-SUMINISTROS-(PM)-" + mproveedor.Text;
                string rutael = "C:/presupvisual/usuarios/proveedores-contratos/EdiLito/EL-SUMINISTROS-(PM)-" + mproveedor.Text;
                string rutatl = "C:/presupvisual/usuarios/proveedores-contratos/Terminados/TL-SUMINISTROS-(PM)-" + mproveedor.Text;
                //string rutalg = "//server/presupvisual/usuarios/proveedores-contratos/LitoGil/LG-SUMINISTROS-(PM)-" + mproveedor.Text;
                //string rutael = "//server/presupvisual/usuarios/proveedores-contratos/EdiLito/EL-SUMINISTROS-(PM)-" + mproveedor.Text;
                //string rutatl = "//server/presupvisual/usuarios/proveedores-contratos/Terminados/TL-SUMINISTROS-(PM)-" + mproveedor.Text;

                objWord.Application objAplicacion = new objWord.Application();
                objWord.Document objDocumento = objAplicacion.Documents.Add();
                //    objAplicacion.Visible = true;

                objWord.Paragraph objParrfafo1 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo1.Range.Font.Bold = 0;
                objParrfafo1.Range.Font.Italic = 0;
                objParrfafo1.Range.Font.Underline = 0;
                objParrfafo1.Range.Font.Name = "Arial";
                objParrfafo1.Range.Font.Size = 9;
                string linea1 = "CONTRATO DE SERVICIOS DE " + mespeci.Text.ToUpper().Trim() + " QUE CELEBRAN, POR UNA PARTE: " + laempresa.Text.ToUpper().Trim();
                string linea2 = " REPRESENTADA POR: " + zreplegal.Text.ToUpper().Trim() + ", EN SU CARÁCTER DE ";
                string linea3 = "APODERADO LEGAL Y A QUIEN EN LO SUCESIVO SE LE DENOMINARÁ ";
                string linea4 = "'EL CLIENTE' Y, POR LA OTRA PARTE: " + mrazon.Text.ToUpper().Trim() + ", REPRESENTADA POR: " + mnombrerep.Text.ToUpper().Trim() + " A QUIEN EN LO SUCESIVO SE LE DENOMINARÁ 'EL PRESTADOR'.  ";
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
                objParrfafo3.Range.Text = "Declara 'EL CLIENTE' por conducto de su representante:";
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
                    objParrfafo6.Range.Text = linea1c + linea2c + linea3c;
                    objParrfafo6.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                    objParrfafo6.Range.InsertParagraphAfter();
                };

                objWord.Paragraph objParrfafo7 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo7.Range.Font.Bold = 0;
                objParrfafo7.Range.Font.Italic = 0;
                objParrfafo7.Range.Font.Underline = 0;
                objParrfafo7.Range.Font.Name = "Arial";
                objParrfafo7.Range.Font.Size = 9;
                objParrfafo7.Range.Text = linea1d;
                objParrfafo7.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo7.Range.InsertParagraphAfter();

                objParrfafo1a.Range.Text = " ";
                objParrfafo1a.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo1a.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo8 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo8.Range.Font.Bold = 0;
                objParrfafo8.Range.Font.Italic = 0;
                objParrfafo8.Range.Font.Underline = 0;
                objParrfafo8.Range.Font.Name = "Arial";
                objParrfafo8.Range.Font.Size = 9;
                objParrfafo8.Range.Text = "Declara 'EL PRESTADOR':";
                objParrfafo8.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphLeft;
                objParrfafo8.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo9 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo9.Range.Font.Bold = 0;
                objParrfafo9.Range.Font.Italic = 0;
                objParrfafo9.Range.Font.Underline = 0;
                objParrfafo9.Range.Font.Name = "Arial";
                objParrfafo9.Range.Font.Size = 9;
                string linea9a = "A) Que es una sociedad constituida de conformidad con las leyes de los Estados Unidos Mexicanos ('México'), como consta de la escritura pública No. " + mescritura.Text.Trim() + " ";
                string linea9b = " de fecha " + mfechaesc.Text.Trim() + ", otorgada ante el LIC. " + mnombrenot.Text.ToUpper().Trim() + ", Notario Público No. " + mnumnot.Text.Trim() + " de " + mlugar.Text.ToUpper().Trim();
                string linea9c = " inscrita en el Registro Público de Comercio de " + mregcomer.Text.Trim() + ". ";
                objParrfafo9.Range.Text = linea9a + linea9b + linea9c;
                objParrfafo9.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo9.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo10 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo10.Range.Font.Bold = 0;
                objParrfafo10.Range.Font.Italic = 0;
                objParrfafo10.Range.Font.Underline = 0;
                objParrfafo10.Range.Font.Name = "Arial";
                objParrfafo10.Range.Font.Size = 9;
                string linea10a = "'B) En su caso, su representante en este acto cuenta con facultades y poderes suficientes para celebrar el presente Contrato, como consta de la escritura pública No. " + mescritura.Text.Trim();
                string linea10b = " de fecha " + mfechaesc.Text.Trim() + ", otorgada ante el LIC. " + mnombrenot.Text.ToUpper().Trim() + ", Notario Público No. " + mnumnot.Text.Trim() + " de " + mlugar.Text.ToUpper().Trim() + ", ";
                string linea10c = "facultades y poderes que a la fecha no le han sido revocados ni limitados en forma alguna. ";
                objParrfafo10.Range.Text = linea10a + linea10b + linea10c;
                objParrfafo10.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo10.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo11 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo11.Range.Font.Bold = 0;
                objParrfafo11.Range.Font.Italic = 0;
                objParrfafo11.Range.Font.Underline = 0;
                objParrfafo11.Range.Font.Name = "Arial";
                objParrfafo11.Range.Font.Size = 9;
                string linea11a = "";
                if (mimss.Text != " ") { linea11a = "C) Que su RFC es " + mimss.Text.Trim() + "."; }
                else { linea11a = "C) Que su RFC es " + mimss.Text.Trim() + " y su número de registro patronal del IMSS es " + mimss.Text.Trim() + " . "; };
                objParrfafo11.Range.Text = linea11a;
                objParrfafo11.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo11.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo12 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo12.Range.Font.Bold = 0;
                objParrfafo12.Range.Font.Italic = 0;
                objParrfafo12.Range.Font.Underline = 0;
                objParrfafo12.Range.Font.Name = "Arial";
                objParrfafo12.Range.Font.Size = 9;
                string linea12a = "D) Que cuenta con diversos clientes y en ningún caso tiene exclusividad que le limite contratar con 'EL PRESTADOR' y a su vez en este acto no  ";
                string linea12b = "se limitante para contratar con cualquier otro cliente. ";
                objParrfafo12.Range.Text = linea12a + linea12b;
                objParrfafo12.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo12.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo12a = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo12a.Range.Font.Bold = 0;
                objParrfafo12a.Range.Font.Italic = 0;
                objParrfafo12a.Range.Font.Underline = 0;
                objParrfafo12a.Range.Font.Name = "Arial";
                objParrfafo12a.Range.Font.Size = 9;
                string linea12aa = "E) Que está al corriente de sus contribuciones locales y federales y las de seguridad social. ";
                objParrfafo12a.Range.Text = linea12aa;
                objParrfafo12a.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo12a.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo12b = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo12b.Range.Font.Bold = 0;
                objParrfafo12b.Range.Font.Italic = 0;
                objParrfafo12b.Range.Font.Underline = 0;
                objParrfafo12b.Range.Font.Name = "Arial";
                objParrfafo12b.Range.Font.Size = 9;
                string linea12ba = "F) Que tiene una amplia experiencia en la prestación de los SERVICIOS, que cuenta con los recursos propios, licencias y autorizaciones legales requeridos para prestar los SERVICIOS. ";
                objParrfafo12b.Range.Text = linea12ba;
                objParrfafo12b.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo12b.Range.InsertParagraphAfter();

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

                objWord.Paragraph objParrfafo14 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo14.Range.Font.Bold = 0;
                objParrfafo14.Range.Font.Italic = 0;
                objParrfafo14.Range.Font.Underline = 0;
                objParrfafo14.Range.Font.Name = "Arial";
                objParrfafo14.Range.Font.Size = 9;
                string linea14a = "Ambas partes gozan de plena capacidad legal y se reconocen mutuamente la personalidad con que se obligan en las declaraciones que anteceden, ";
                string linea14b = "las cuales no podrán ser objetadas con posterioridad a este acto, por lo cual es su libre y expresa voluntad suscribir el presente contrato al tenor de las siguientes clausulas: ";
                objParrfafo14.Range.Text = linea14a + linea14b;
                objParrfafo14.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo14.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo15 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo15.Range.Font.Bold = 0;
                objParrfafo15.Range.Font.Italic = 0;
                objParrfafo15.Range.Font.Underline = 0;
                objParrfafo15.Range.Font.Name = "Arial";
                objParrfafo15.Range.Font.Size = 9;
                objParrfafo15.Range.Text = "A) Contar con el personal capacitado para realizar los trabajos objeto de este contrato.";
                objParrfafo15.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo15.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo16 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo16.Range.Font.Bold = 0;
                objParrfafo16.Range.Font.Italic = 0;
                objParrfafo16.Range.Font.Underline = 0;
                objParrfafo16.Range.Font.Name = "Arial";
                objParrfafo16.Range.Font.Size = 9;
                objParrfafo16.Range.Text = "B) Asumir la responsabilidad derivada de ocupar las instalaciones de 'EL CLIENTE', de ser necesario, en forma adecuada.";
                objParrfafo16.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo16.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo17 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo17.Range.Font.Bold = 0;
                objParrfafo17.Range.Font.Italic = 0;
                objParrfafo17.Range.Font.Underline = 0;
                objParrfafo17.Range.Font.Name = "Arial";
                objParrfafo17.Range.Font.Size = 9;
                string linea7a = "C) 'EL PRESTADOR' es el único obligado como empresario y patrón del personal que ocupa con motivo del presente contrato y que será el único responsable ";
                string linea7b = "de sus obligaciones fiscales, laborales y de los riesgos de seguridad social ante el Instituto Mexicano del Seguro Social, así como los del INFONAVIT, ";
                string linea7c = "FONACOT y de la Secretaria del Trabajo y conviene por lo mismo en responder de todas las reclamaciones que sus trabajadores presten en su contra ";
                string linea7d = "o en contra de 'EL CLIENTE'  en relación con los trabajos, motivos del presente contrato. ";
                objParrfafo17.Range.Text = linea7a + linea7b + linea7c + linea7d;
                objParrfafo17.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo17.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo18 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo18.Range.Font.Bold = 0;
                objParrfafo18.Range.Font.Italic = 0;
                objParrfafo18.Range.Font.Underline = 0;
                objParrfafo18.Range.Font.Name = "Arial";
                objParrfafo18.Range.Font.Size = 9;
                string linea8a = "D) 'EL PRESTADOR' se obliga a mantener con carácter estrictamente confidencial toda la información del material que reciba de 'EL CLIENTE', ";
                string linea8b = "limitando la divulgación de la misma a todo tipo de persona ajena al trabajo por realizar o ya realizado. ";
                objParrfafo18.Range.Text = linea8a + linea8b;
                objParrfafo18.Range.ParagraphFormat.Alignment = objWord.WdParagraphAlignment.wdAlignParagraphJustify;
                objParrfafo18.Range.InsertParagraphAfter();

                objWord.Paragraph objParrfafo19 = objDocumento.Content.Paragraphs.Add(Type.Missing);
                objParrfafo19.Range.Font.Bold = 0;
                objParrfafo19.Range.Font.Italic = 0;
                objParrfafo19.Range.Font.Underline = 0;
                objParrfafo19.Range.Font.Name = "Arial";
                objParrfafo19.Range.Font.Size = 9;
                string linea19a = "E) 'EL PRESTADOR' y sus empleados deberán mantener en estricta confidencialidad toda la información proporcionada por 'EL CLIENTE' para las propuestas, ";
                string linea19b = "presupuestos o comunicaciones que se realicen, por lo tanto, deben abstenerse de publicarla o comunicarla a cualquier persona o a explotarla comercialmente ";
                string linea19c = "para cualquier fin distinto a lo establecido en el contrato. ";
                objParrfafo19.Range.Text = linea19a + linea19b + linea19c;
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
                string linea40a = "12) 'El PRESTADOR' se obliga a sacar en paz y a salvo y en su caso a indemnizar a 'EL CLIENTE' contra cualquier demanda, reclamación, acción legal, daño y/o perjuicio interpuesto ";
                string linea40b = "y/o reclamado por cualquier tercero en contra de 'EL CLIENTE' como resultado de un acto u omisión que le sea imputable a 'El PRESTADOR'. ";
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

