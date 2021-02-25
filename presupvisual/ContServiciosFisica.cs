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
    public partial class ContServiciosFisica : Form
    {
        public ContServiciosFisica()
        {
            InitializeComponent();
        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fproveedores ss = new presupvisual.Fproveedores();
            ss.Show();
        }

        private void btnWord_Click_1(object sender, EventArgs e)
        {
            //No olvides agregar la referencia Microsoft.Office.Interop.Word u Object Library Word a tu proyecto
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            objWord.Application objAplicacion = new objWord.Application();
            objWord.Document objDocumento = objAplicacion.Documents.Add();

            objWord.Paragraph objParrfafo1 = objDocumento.Content.Paragraphs.Add(Type.Missing);

            objParrfafo1.Range.Font.Size = 14;
            objParrfafo1.Range.Font.Color = objWord.WdColor.wdColorDarkBlue;
            objParrfafo1.Range.Text = "Este es mi primer párrafo.";
            objParrfafo1.Range.InsertParagraphAfter();

            objWord.Paragraph objParrfafo2 = objDocumento.Content.Paragraphs.Add(Type.Missing);
            objParrfafo2.Range.Font.Size = 18;
            objParrfafo2.Range.Font.Color = objWord.WdColor.wdColorDarkRed;
            objParrfafo2.Range.Text = "Este es mi segundo párrafo.";
            objParrfafo2.Range.InsertParagraphAfter();

            objDocumento.SaveAs2(ruta + "\\miPrimerArchivoWord.docx");
            objDocumento.Close();
            objAplicacion.Quit();

            MessageBox.Show("Contrato generado en: "+ruta);
        }
    }
}
