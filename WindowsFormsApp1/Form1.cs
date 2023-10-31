using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using UglyToad.PdfPig;
using UglyToad.PdfPig.Content;
using UglyToad.PdfPig.Fonts.Standard14Fonts;
using UglyToad.PdfPig.Writer;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        DbCrud sql = new DbCrud();
        pdfManagment pdfManagment = new pdfManagment();
        List<User> users;
        string pdfSourcePath = "pdf\\source\\sourcePDF.pdf";
        string pdfResultPath;

        public Form1()
        {
            InitializeComponent();
            //sql.OpenSqlConnection();
        }

        private void btnCreatePdf_Click(object sender, EventArgs e)
        {
            //users = sql.GetTempUser();

            pdfResultPath = "pdf\\result\\compiledPDF.pdf";

            PdfDocumentBuilder builder = new PdfDocumentBuilder();

            PdfDocumentBuilder.AddedFont helvetica = builder.AddStandard14Font(Standard14Font.Helvetica);

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                using (PdfDocument source = PdfDocument.Open(pdfSourcePath))
                {
                    foreach (Page sourcePage in source.GetPages())
                    {
                        //.AddPage() -> impostando isPortrait : false, imposti il foglio orizzontale
                        PdfPageBuilder resultPage = builder.AddPage(source, sourcePage.Number);

                        if (sourcePage.Number == 1)
                        {
                            for (int x = 0; x < 100; x++)
                            {
                                for (int y = 0; y < 100; y++)
                                {
                                    pdfManagment.WriteLineOnPdf(ref resultPage, (x*20).ToString() + "," + (y*10).ToString(), 5, x*20, y*10, helvetica);
                                }
                            }

                            //pdfManagment.WriteLineOnPdf(ref resultPage, row.Cells["nome"].Value.ToString(), 10, 10, 700, helvetica);

                            //pdfManagment.WriteLineOnPdf(ref resultPage, row.Cells["cognome"].Value.ToString(), 10, 10, 720, helvetica);

                            //pdfManagment.WriteLineOnPdf(ref resultPage, row.Cells["codiceFiscale"].Value.ToString().ToUpper(), 10, 10, 740, helvetica);

                            //pdfManagment.WriteLineOnPdf(ref resultPage, row.Cells["data_nascita"].Value.ToString(), 10, 10, 760, helvetica);
                        }
                    }
                }
            }
            File.WriteAllBytes(pdfResultPath, builder.Build());

            MessageBox.Show("File creato!");
            //this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            users = sql.GetTempUser();

            User newUser = new User();
            newUser.nome = tbNome.Text;
            newUser.cognome = tbCognome.Text;
            newUser.codiceFiscale = tbCodiceFiscale.Text;
            newUser.data_nascita = tbDataDiNascita.Text;
            newUser.sezione = tbSezione.Text;
            newUser.data_pag = tbDataPag.Text;
            newUser.tipo = tbTipo.Text;
            newUser.numero = tbNumero.Text;
            newUser.indirizzo = tbIndirizzoResistenza.Text;
            newUser.provincia = tbIndirizzoResistenza.Text;
            newUser.comune = tbComuneResidenza.Text;
            newUser.cap = tbCap.Text;
            newUser.comune_nascita = tbComuneNascita.Text;
            newUser.provincia_nascita = tbProvinciaNascita.Text;
            newUser.numero_porto_darmi = tbNumeroPortoArmi.Text;
            users.Add(newUser);

            dataGridView1.DataSource = users;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sql.GetTempUser();

        }
    }
}