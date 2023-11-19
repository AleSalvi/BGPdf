using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
        bool annulla = false;
        string pdfResultPath;

        public Form1()
        {
            InitializeComponent();
            //sql.OpenSqlConnection();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sql.GetTempUser();
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
                            //for (int x = 0; x < 100; x++)
                            //{
                            //    for (int y = 0; y < 150; y++)
                            //    {
                            //        if ((x * 10) % 50 == 0 && (y * 5) % 50 == 0)
                            //        {
                            //            pdfManagment.WriteLineOnPdf(ref resultPage, (x * 10).ToString() + "," + (y * 5).ToString(), 5, x * 10, y * 5, helvetica);
                            //            pdfManagment.WriteLineOnPdf(ref resultPage, row.Cells["Name"].Value.ToString(), 10, 10, 700, helvetica);
                            //        }
                            //        else
                            //        {
                            //            pdfManagment.WriteLineOnPdf(ref resultPage, ".", 5, x * 10, y * 5, helvetica);
                            //        }
                            // 
                            //}

                            //dsafsdds
                            for (int x = 0; x < 2; x++)
                            {
                                int doppio = 0;
                                if (x == 1)
                                {
                                    doppio = 275;
                                }
                                pdfManagment.WriteLineOnPdf(ref resultPage, "PROVA", 10, 30, 455 - doppio, helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, "PROVA", 10, 30, 440 - doppio, helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, "PROVA", 10, 690, 450 - doppio, helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, "PROVA", 10, 640, 425 - doppio, helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, "PROVA", 10, 640, 405 - doppio, helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, "PROVA", 10, 640, 380 - doppio, helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, "PROVA", 10, 640, 360 - doppio, helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, "PROVA", 10, 900, 380 - doppio, helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, "PROVA", 10, 865, 360 - doppio, helvetica);

                            }

                        }
                    }
                }
            }
            File.WriteAllBytes(pdfResultPath, builder.Build());

            MessageBox.Show("File creato!");
        }
        public void mostraFiltri()
        {
            filtri_btn.Visible = true;
            tbNomeF.Visible = true;
            tbCognomeF.Visible = true;
            tbCodiceFiscaleF.Visible = true;
            tbDataDiNascitaF.Visible = true;
            tbDataRilascioPortoArmiF.Visible = true;
            tbNumeroPortoArmiF.Visible = true;
            tbCapNascitaF.Visible = true;
            tbComuneNascitaF.Visible = true;
            tbProvinciaNascitaF.Visible = true;
            tbIndirizzoResistenzaF.Visible = true;
            tbCapResistenzaF.Visible = true;
            tbComuneResidenzaF.Visible = true;
            tbProvinciaResistenzaF.Visible = true;
            tbSezioneF.Visible = true;
            tbProvinciaF.Visible = true;
            tbDataPagamentoF.Visible = true;
            tbNumeroF.Visible = true;
            tbTipoF.Visible = true;
        }
        public void nascondiFiltri()
        {
            filtri_btn.Visible = false;
            tbNomeF.Visible = false;
            tbCognomeF.Visible = false;
            tbCodiceFiscaleF.Visible = false;
            tbDataDiNascitaF.Visible = false;
            tbDataRilascioPortoArmiF.Visible = false;
            tbNumeroPortoArmiF.Visible = false;
            tbCapNascitaF.Visible = false;
            tbComuneNascitaF.Visible = false;
            tbProvinciaNascitaF.Visible = false;
            tbIndirizzoResistenzaF.Visible = false;
            tbCapResistenzaF.Visible = false;
            tbComuneResidenzaF.Visible = false;
            tbProvinciaResistenzaF.Visible = false;
            tbSezioneF.Visible = false;
            tbProvinciaF.Visible = false;
            tbDataPagamentoF.Visible = false;
            tbNumeroF.Visible = false;
            tbTipoF.Visible = false;
        }
        public void addUser()
        {
            users = sql.GetTempUser();

            User newUser = new User();
            newUser.nome = tbNome.Text;
            newUser.cognome = tbCognome.Text;
            newUser.codice_fiscale = tbCodiceFiscale.Text;
            newUser.data_nascita = tbDataDiNascita.Text;
            newUser.data_rilascio_porto_armi = tbDataRilascioPortoArmi.Text;
            newUser.numero_porto_armi = tbNumeroPortoArmi.Text;
            newUser.cap_nascita = tbCapNascita.Text;
            newUser.comune_nascita = tbComuneNascita.Text;
            newUser.provincia_nascita = tbProvinciaNascita.Text;
            newUser.indirizzo_residenza = tbIndirizzoResistenza.Text;
            newUser.cap_residenza = tbCapResistenza.Text;
            newUser.comune_residenza = tbComuneResidenza.Text;
            newUser.provincia_residenza = tbProvinciaResistenza.Text;
            newUser.sezione = tbSezione.Text;
            newUser.provincia = tbProvincia.Text;
            newUser.data_pagamento = tbDataPagamento.Text;
            newUser.numero = tbNumero.Text;
            newUser.tipo = tbTipo.Text;
            users.Add(newUser);

            dataGridView1.DataSource = users;
        }
        public void editUser()
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                row.Cells["nome"].Value = tbNome.Text;
                row.Cells["cognome"].Value = tbCognome.Text;
                row.Cells["codice_fiscale"].Value = tbCodiceFiscale.Text;
                row.Cells["data_nascita"].Value = tbDataDiNascita.Text;
                row.Cells["data_rilascio_porto_armi"].Value = tbDataRilascioPortoArmi.Text;
                row.Cells["numero_porto_armi"].Value = tbNumeroPortoArmi.Text;
                row.Cells["cap_nascita"].Value = tbCapNascita.Text;
                row.Cells["comune_nascita"].Value = tbComuneNascita.Text;
                row.Cells["provincia_nascita"].Value = tbProvinciaNascita.Text;
                row.Cells["indirizzo_residenza"].Value = tbIndirizzoResistenza.Text;
                row.Cells["cap_residenza"].Value = tbCapResistenza.Text;
                row.Cells["comune_residenza"].Value = tbComuneResidenza.Text;
                row.Cells["provincia_residenza"].Value = tbProvinciaResistenza.Text;
                row.Cells["sezione"].Value = tbSezione.Text;
                row.Cells["provincia"].Value = tbProvincia.Text;
                row.Cells["data_pagamento"].Value = tbDataPagamento.Text;
                row.Cells["numero"].Value = tbNumero.Text;
                row.Cells["tipo"].Value = tbTipo.Text;
            }
        }

        private void addUser_btn_Click(object sender, EventArgs e)
        {

            this.label10.Text = "Nuovo utente";

            this.nascondiFiltri();
            
            this.addUser_btn.Enabled = false;
            this.editUser_btn.Enabled = false;
            this.saveUser_btn.Visible = true;
            this.annullla_btn.Visible = true;
        }

        private void editUser_btn_Click(object sender, EventArgs e)
        {

            this.label10.Text = "Modifica utente";

            this.nascondiFiltri();
            
            this.addUser_btn.Enabled = false;
            this.editUser_btn.Enabled = false;
            this.saveUser_btn.Visible = true;
            this.annullla_btn.Visible = true;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                tbNome.Text = row.Cells["nome"].Value.ToString();
                tbCognome.Text = row.Cells["cognome"].Value.ToString();
                tbCodiceFiscale.Text = row.Cells["codice_fiscale"].Value.ToString();
                tbDataDiNascita.Text = row.Cells["data_nascita"].Value.ToString();
                tbDataRilascioPortoArmi.Text = row.Cells["data_rilascio_porto_armi"].Value.ToString();
                tbNumeroPortoArmi.Text = row.Cells["numero_porto_armi"].Value.ToString();
                tbCapNascita.Text = row.Cells["cap_nascita"].Value.ToString();
                tbComuneNascita.Text = row.Cells["comune_nascita"].Value.ToString();
                tbProvinciaNascita.Text = row.Cells["provincia_nascita"].Value.ToString();
                tbIndirizzoResistenza.Text = row.Cells["indirizzo_residenza"].Value.ToString();
                tbCapResistenza.Text = row.Cells["cap_residenza"].Value.ToString();
                tbComuneResidenza.Text = row.Cells["comune_residenza"].Value.ToString();
                tbProvinciaResistenza.Text = row.Cells["provincia_residenza"].Value.ToString();
                tbSezione.Text = row.Cells["sezione"].Value.ToString();
                tbProvincia.Text = row.Cells["provincia"].Value.ToString();
                tbDataPagamento.Text = row.Cells["data_pagamento"].Value.ToString();
                tbNumero.Text = row.Cells["numero"].Value.ToString();
                tbTipo.Text = row.Cells["tipo"].Value.ToString();
            }
        }

        private void saveUser_btn_Click(object sender, EventArgs e)
        {
            if (annulla == false)
            {
                if (this.editUser_btn.Enabled == true)
                {
                    editUser();
                }
                else
                {
                    addUser();
                }
            }
            tbNome.Text = "";
            tbCognome.Text = "";
            tbCodiceFiscale.Text = "";
            tbDataDiNascita.Text = "";
            tbDataRilascioPortoArmi.Text = "";
            tbNumeroPortoArmi.Text = "";
            tbCapNascita.Text = "";
            tbComuneNascita.Text = "";
            tbProvinciaNascita.Text = "";
            tbIndirizzoResistenza.Text = "";
            tbCapResistenza.Text = "";
            tbComuneResidenza.Text = "";
            tbProvinciaResistenza.Text = "";
            tbSezione.Text = "";
            tbProvincia.Text = "";
            tbDataPagamento.Text = "";
            tbNumero.Text = "";
            tbTipo.Text = "";

            this.mostraFiltri();

            this.label10.Text = "Filtri";
            this.addUser_btn.Enabled = true;
            this.saveUser_btn.Visible = false;
            this.annullla_btn.Visible = false;
            this.editUser_btn.Enabled = true;

            annulla = false;
        }

        private void annullla_btn_Click(object sender, EventArgs e)
        {
            annulla = true;
            saveUser_btn.PerformClick();
        }

        private void filtri_btn_Click(object sender, EventArgs e)
        {
            List<User> users = sql.GetTempUser();

            // Applica il filtro sulla lista
            List<User> utentiFiltrati = users
                .Where(u =>
                    u.nome.Contains(tbNomeF.Text) &&
                    u.cognome.Contains(tbCognomeF.Text) &&
                    u.codice_fiscale.Contains(tbCodiceFiscaleF.Text) &&
                    u.data_nascita.Contains(tbDataDiNascitaF.Text) &&
                    u.data_rilascio_porto_armi.Contains(tbDataRilascioPortoArmiF.Text) &&
                    u.numero_porto_armi.Contains(tbNumeroPortoArmiF.Text) &&
                    u.cap_nascita.Contains(tbCapNascitaF.Text) &&
                    u.comune_nascita.Contains(tbComuneNascitaF.Text) &&
                    u.provincia_nascita.Contains(tbProvinciaNascitaF.Text) &&
                    u.indirizzo_residenza.Contains(tbIndirizzoResistenzaF.Text) &&
                    u.cap_residenza.Contains(tbCapResistenzaF.Text) &&
                    u.comune_residenza.Contains(tbComuneResidenzaF.Text) &&
                    u.provincia_residenza.Contains(tbProvinciaResistenzaF.Text) &&
                    u.sezione.Contains(tbSezioneF.Text) &&
                    u.provincia.Contains(tbProvinciaF.Text) &&
                    u.data_pagamento.Contains(tbDataPagamentoF.Text) &&
                    u.numero.Contains(tbNumeroF.Text) &&
                    u.tipo.Contains(tbTipoF.Text)
                )
                .ToList();

            // Assegna la lista filtrata al DataGridView
            dataGridView1.DataSource = utentiFiltrati;
        }

    }
}