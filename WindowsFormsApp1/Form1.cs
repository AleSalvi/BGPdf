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
                            pdfManagment.WriteLineOnPdf(ref resultPage, row.Cells["Name"].Value.ToString(), 10, 10, 700, helvetica);

                            pdfManagment.WriteLineOnPdf(ref resultPage, row.Cells["Surname"].Value.ToString(), 10, 10, 720, helvetica);

                            pdfManagment.WriteLineOnPdf(ref resultPage, row.Cells["TaxCode"].Value.ToString().ToUpper(), 10, 10, 740, helvetica);

                            pdfManagment.WriteLineOnPdf(ref resultPage, row.Cells["Phone"].Value.ToString(), 10, 10, 760, helvetica);
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
            newUser.Name = name_tb.Text;
            newUser.Surname = surname_tb.Text;
            newUser.TaxCode = taxCode_tb.Text;
            newUser.Phone = phone_tb.Text;

            users.Add(newUser);

            dataGridView1.DataSource = users;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sql.GetTempUser();

            dataGridView1.Columns["Email"].Visible = false;
            dataGridView1.Columns["Address"].Visible = false;
        }
    }
}