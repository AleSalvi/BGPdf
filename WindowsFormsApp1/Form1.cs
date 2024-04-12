using ClosedXML.Excel;
using dto;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UglyToad.PdfPig;
using UglyToad.PdfPig.Content;
using UglyToad.PdfPig.Fonts.Standard14Fonts;
using UglyToad.PdfPig.Writer;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        pdfManagment pdfManagment = new pdfManagment();
        string rootAPI = ConfigurationManager.AppSettings["API_Root"];
        string pdfSourcePath1 = ConfigurationManager.AppSettings["PDF_SourcePath_1"];
        string pdfSourcePath2 = ConfigurationManager.AppSettings["PDF_SourcePath_2"];

        double Yass = 1008;
        double Xass = 1003;
        double Y173 = 1010;
        double X173 = 992;
        bool annulla = false;
        string pdfResultPath1;
        string pdfResultPath2;
        HttpClient client = new HttpClient();
        string token;

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await LoginAPI();
            await ReloadGrid();
            tbX.Text = Xass.ToString();
            tbY.Text = Yass.ToString();
            tbX173.Text = X173.ToString();
            tbY173.Text = Y173.ToString();
        }

        public async Task LoginAPI()
        {
            var json = JsonConvert.SerializeObject(new LoginRequest() { Username = ConfigurationManager.AppSettings["API_loginUsername"], Password = ConfigurationManager.AppSettings["API_loginPassword"] });
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            using HttpResponseMessage response = await client.PostAsync(rootAPI + "login/authenticate", data);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            LoginResponse loginResponse = JsonConvert.DeserializeObject<LoginResponse>(responseBody);
            token = loginResponse.Token;
        }

        public async Task ReloadGrid()
        {
            var msg = new HttpRequestMessage(HttpMethod.Get, rootAPI + "user/getall");
            msg.Headers.Add("X-AUTH", token);

            using HttpResponseMessage response = await client.SendAsync(msg);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            List<User> users = JsonConvert.DeserializeObject<List<User>>(responseBody);

            var esitoDataNascita = DateTime.TryParse(tbDataDiNascitaF.Text, out DateTime resultDataNascita);
            var esitoDataRilascio = DateTime.TryParse(tbDataRilascioPortoArmiF.Text, out DateTime resultDataRilascio);
            var esitoDataPagamento = DateTime.TryParse(tbDataPagamentoF.Text, out DateTime resultDataPagamento);
            if (cbScaduti.Checked)
            {
                esitoDataRilascio = false;
            }
            var esitoNumero = Int32.TryParse(tbNumeroF.Text, out Int32 resultNumero);

            // Applica il filtro sulla lista
            List<User> utentiFiltrati = users
                .Where(u =>
                    u.Nome.Contains(tbNomeF.Text) &&
                    u.Cognome.Contains(tbCognomeF.Text) &&
                    u.CodiceFiscale.Contains(tbCodiceFiscaleF.Text) &&
                    (!esitoDataNascita || resultDataNascita == u.Data_nascita) &&
                    (!esitoDataRilascio || resultDataRilascio == u.Data_rilascio_porto_armi) &&
                    u.Numero_porto_armi.Contains(tbNumeroPortoArmiF.Text) &&
                    u.Cap_nascita.Contains(tbCapNascitaF.Text) &&
                    u.Comune_nascita.Contains(tbComuneNascitaF.Text) &&
                    u.Provincia_nascita.Contains(tbProvinciaNascitaF.Text) &&
                    u.Indirizzo_residenza.Contains(tbIndirizzoResistenzaF.Text) &&
                    u.Cap_residenza.Contains(tbCapResistenzaF.Text) &&
                    u.Comune_residenza.Contains(tbComuneResidenzaF.Text) &&
                    u.Provincia_residenza.Contains(tbProvinciaResistenzaF.Text) &&
                    u.Sezione.Contains(tbSezioneF.Text) &&
                    (!esitoDataPagamento || resultDataPagamento == u.Data_pagamento) &&
                    (!esitoNumero || resultNumero == u.Numero) &&
                    u.Tipo.Contains(tbTipoF.Text) &&
                    u.Telefono.Contains(tbTelefonoF.Text) &&
                    u.Cellulare_whatsapp.Contains(tbCellulareF.Text) &&
                    u.Mail.Contains(tbMailF.Text)
                )
                .ToList();

            if (cbScaduti.Checked)
            {
                DateTime dataScadenza = DateTime.Now.AddYears(-5);
                utentiFiltrati = utentiFiltrati.Where(u => u.Data_rilascio_porto_armi < dataScadenza).ToList();
            }

            dataGridView1.DataSource = utentiFiltrati;

            dataGridView1.Columns["Uid"].Visible = false;
        }

        public void esportazioneExcel()
        {

            // Crea un nuovo foglio di lavoro Excel
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("DatiSelezionati");

            // Aggiungi l'intestazione (nomi delle colonne) al foglio di lavoro
            int colonna = 1;
            worksheet.Cell(1, 1).Value = "Nome";
            worksheet.Cell(1, 2).Value = "Cognome";
            worksheet.Cell(1, 3).Value = "CodiceFiscale";
            worksheet.Cell(1, 4).Value = "Data_nascita";
            worksheet.Cell(1, 5).Value = "Data_rilascio_porto_armi";
            worksheet.Cell(1, 6).Value = "Numero_porto_armi";
            worksheet.Cell(1, 7).Value = "Cap_nascita";
            worksheet.Cell(1, 8).Value = "Comune_nascita";
            worksheet.Cell(1, 9).Value = "Provincia_nascita";
            worksheet.Cell(1, 10).Value = "Indirizzo_residenza";
            worksheet.Cell(1, 11).Value = "Cap_residenza";
            worksheet.Cell(1, 12).Value = "Comune_residenza";
            worksheet.Cell(1, 13).Value = "Provincia_residenza";
            worksheet.Cell(1, 14).Value = "Sezione";
            worksheet.Cell(1, 15).Value = "Data_pagamento";
            worksheet.Cell(1, 16).Value = "Numero";
            worksheet.Cell(1, 17).Value = "Tipo";
            worksheet.Cell(1, 18).Value = "Telefono";
            worksheet.Cell(1, 19).Value = "Cellulare_whatsapp";
            worksheet.Cell(1, 20).Value = "Mail";
            // Aggiungi i dati al foglio di lavoro
            int riga = 2;

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                worksheet.Cell(riga, 1).Value = row.Cells["Nome"].Value.ToString();
                worksheet.Cell(riga, 2).Value = row.Cells["Cognome"].Value.ToString();
                worksheet.Cell(riga, 3).Value = row.Cells["CodiceFiscale"].Value.ToString();
                worksheet.Cell(riga, 4).Value = row.Cells["Data_nascita"].Value?.ToString()?.Substring(0, Math.Min(10, row.Cells["Data_nascita"].Value.ToString().Length));
                worksheet.Cell(riga, 5).Value = row.Cells["Data_rilascio_porto_armi"].Value?.ToString()?.Substring(0, Math.Min(10, row.Cells["Data_rilascio_porto_armi"].Value.ToString().Length));
                worksheet.Cell(riga, 6).Value = row.Cells["Numero_porto_armi"].Value.ToString();
                worksheet.Cell(riga, 7).Value = row.Cells["Cap_nascita"].Value.ToString();
                worksheet.Cell(riga, 8).Value = row.Cells["Comune_nascita"].Value.ToString();
                worksheet.Cell(riga, 9).Value = row.Cells["Provincia_nascita"].Value.ToString();
                worksheet.Cell(riga, 10).Value = row.Cells["Indirizzo_residenza"].Value.ToString();
                worksheet.Cell(riga, 11).Value = row.Cells["Cap_residenza"].Value.ToString();
                worksheet.Cell(riga, 12).Value = row.Cells["Comune_residenza"].Value.ToString();
                worksheet.Cell(riga, 13).Value = row.Cells["Provincia_residenza"].Value.ToString();
                worksheet.Cell(riga, 14).Value = row.Cells["Sezione"].Value.ToString();
                worksheet.Cell(riga, 15).Value = row.Cells["Data_pagamento"].Value?.ToString()?.Substring(0, Math.Min(10, row.Cells["Data_pagamento"].Value.ToString().Length));
                worksheet.Cell(riga, 16).Value = row.Cells["Numero"].Value.ToString();
                worksheet.Cell(riga, 17).Value = row.Cells["Tipo"].Value.ToString();
                worksheet.Cell(riga, 18).Value = row.Cells["Telefono"].Value.ToString();
                worksheet.Cell(riga, 19).Value = row.Cells["Cellulare_whatsapp"].Value.ToString();
                worksheet.Cell(riga, 20).Value = row.Cells["Mail"].Value.ToString();
                riga++;
            }

            // Salva il foglio di lavoro Excel in un file
            var percorsoFile = "pdf\\result\\DatiEsportati.xlsx";
            workbook.SaveAs(percorsoFile);

            MessageBox.Show("File creato!");

        }
        public void creazioneAssicurazione(Boolean colori)
        {
            //users = sql.GetTempUser();
            if (colori)
            {
                pdfResultPath1 = ConfigurationManager.AppSettings["PDF_ResultPath_1"];
                pdfSourcePath1 = ConfigurationManager.AppSettings["PDF_SourcePath_1"];
            }
            if (!colori)
            {
                pdfResultPath1 = ConfigurationManager.AppSettings["PDF_ResultPath_1B"];
                pdfSourcePath1 = ConfigurationManager.AppSettings["PDF_SourcePath_1B"];
            }

            PdfDocumentBuilder builder = new PdfDocumentBuilder();

            PdfDocumentBuilder.AddedFont helvetica = builder.AddStandard14Font(Standard14Font.Helvetica);

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                using (PdfDocument source = PdfDocument.Open(pdfSourcePath1))
                {
                    foreach (Page sourcePage in source.GetPages())
                    {
                        PdfPageBuilder resultPage = builder.AddPage(source, sourcePage.Number);

                        if (sourcePage.Number == 1)
                        {
                            //for (int x = 0; x < 500; x++)
                            //{
                            //    for (int y = 0; y < 500; y++)
                            //    {
                            //        if ((x * 10) % 50 == 0 && (y * 5) % 50 == 0)
                            //        {
                            //            pdfManagment.WriteLineOnPdf(ref resultPage, (x * 10).ToString() + "," + (y * 5).ToString(), 5, x * 10, y * 5 , helvetica);
                            //        }
                            //        else
                            //        {
                            //            pdfManagment.WriteLineOnPdf(ref resultPage, ".", 5, x * 10, y * 5 , helvetica);
                            //        }
                            //    }
                            //}

                            double percX = Xass;
                            double percY = Yass;
                            if (colori)
                            {
                                percX = 1;
                                percY = 1;
                            }

                            for (int x = 0; x < 2; x++)
                            {
                                int doppio = 0;
                                if (x == 1)
                                {
                                    doppio = 210;
                                }
                                string nome = row.Cells["Nome"].Value.ToString() + ' ' + row.Cells["Cognome"].Value.ToString();
                                string sezione = row.Cells["Sezione"].Value.ToString();
                                string numeroPortoArmi = row.Cells["Numero_porto_armi"].Value.ToString();
                                string indirizzoResidenza = row.Cells["Indirizzo_residenza"].Value.ToString();
                                string comuneNascita = row.Cells["Comune_nascita"].Value.ToString();
                                string codiceFiscale = row.Cells["CodiceFiscale"].Value.ToString();
                                string capResidenza = row.Cells["Cap_residenza"].Value.ToString();
                                string comuneResidenza = row.Cells["Comune_residenza"].Value.ToString();
                                string provinciaResidenza = row.Cells["Provincia_residenza"].Value.ToString();
                                string dataNascita = row.Cells["Data_nascita"].Value?.ToString()?.Substring(0, Math.Min(10, row.Cells["Data_nascita"].Value.ToString().Length));
                                string totResidenza = capResidenza + ' ' + comuneResidenza + ' ' + provinciaResidenza;
                                string dataPortoArmi = row.Cells["Data_rilascio_porto_armi"].Value?.ToString()?.Substring(0, Math.Min(10, row.Cells["Data_rilascio_porto_armi"].Value.ToString().Length));


                                pdfManagment.WriteLineOnPdf(ref resultPage, sezione, 8, (20 + doppio) * percX, getY(540, percY), helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, numeroPortoArmi, 8, (20 + doppio) * percX, getY(512, percY), helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, dataPortoArmi, 8, (130 + doppio) * percX, getY(512, percY), helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, nome, 8, (20 + doppio) * percX, getY(485, percY), helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, comuneNascita, 8, (20 + doppio) * percX, getY(457, percY), helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, dataNascita, 8, (130 + doppio) * percX, getY(457, percY), helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, indirizzoResidenza, 8, (20 + doppio) * percX, getY(430, percY), helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, totResidenza, 8, (20 + doppio) * percX, getY(402, percY), helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, codiceFiscale, 8, (20 + doppio) * percX, getY(375, percY), helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, row.Cells["Telefono"].Value.ToString(), 8, (20 + doppio) * percX, getY(345, percY), helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, row.Cells["Mail"].Value.ToString(), 8, (20 + doppio) * percX, getY(319, percY), helvetica);

                                pdfManagment.WriteLineOnPdf(ref resultPage, sezione, 8, 170 * percX, getY(179, percY), helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, numeroPortoArmi, 8, 60 * percX, getY(163, percY), helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, dataPortoArmi, 8, 210 * percX, getY(164, percY), helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, nome, 8, 20 * percX, getY(136, percY), helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, indirizzoResidenza, 8, 45 * percX, getY(101, percY), helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, capResidenza, 8, 45 * percX, getY(82, percY), helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, comuneResidenza, 8, 45 * percX, getY(64, percY), helvetica);

                                pdfManagment.WriteLineOnPdf(ref resultPage, nome, 8, 450 * percX, getY(445, percY), helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, comuneNascita, 8, 450 * percX, getY(426, percY), helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, dataNascita, 8, 580 * percX, getY(426, percY), helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, totResidenza, 8, 450 * percX, getY(407, percY), helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, indirizzoResidenza, 8, 450 * percX, getY(388, percY), helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, numeroPortoArmi, 8, 465 * percX, getY(369, percY), helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, dataPortoArmi, 8, 570 * percX, getY(369, percY), helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, sezione, 8, 460 * percX, getY(350, percY), helvetica);

                                pdfManagment.WriteLineOnPdf(ref resultPage, sezione, 8, 580 * percX, getY(178, percY), helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, numeroPortoArmi, 8, 485 * percX, getY(163, percY), helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, dataPortoArmi, 8, 670 * percX, getY(163, percY), helvetica);

                                double xcelle = 539.5;
                                int maxNomeCaratteri = 23;
                                foreach (char carattere in nome.Take(maxNomeCaratteri))
                                {
                                    string carattereMaiuscolo = carattere.ToString().ToUpper();
                                    pdfManagment.WriteLineOnPdf(ref resultPage, carattereMaiuscolo, 8, xcelle * percX, getY(139, percY), helvetica);
                                    xcelle += 12.29;
                                }

                                xcelle = 539;
                                int maxIndirizzoCaratteri = 23;
                                foreach (char carattere in indirizzoResidenza.Take(maxIndirizzoCaratteri))
                                {
                                    string carattereMaiuscolo = carattere.ToString().ToUpper();
                                    pdfManagment.WriteLineOnPdf(ref resultPage, carattereMaiuscolo, 8, xcelle * percX, getY(100, percY), helvetica);
                                    xcelle += 12.3;
                                }

                                xcelle = 540;
                                int maxCapCaratteri = 5;
                                foreach (char carattere in capResidenza.Take(maxCapCaratteri))
                                {
                                    string carattereMaiuscolo = carattere.ToString().ToUpper();
                                    pdfManagment.WriteLineOnPdf(ref resultPage, carattereMaiuscolo, 8, xcelle * percX, getY(76, percY), helvetica);
                                    xcelle += 12.35;
                                }

                                xcelle = 613;
                                int maxComuneCaratteri = 17;
                                foreach (char carattere in comuneResidenza.Take(maxComuneCaratteri))
                                {
                                    string carattereMaiuscolo = carattere.ToString().ToUpper();
                                    pdfManagment.WriteLineOnPdf(ref resultPage, carattereMaiuscolo, 8, xcelle * percX, getY(76, percY), helvetica);
                                    xcelle += 12.3;
                                }

                            }

                        }
                    }
                }
            }
            System.IO.File.WriteAllBytes(pdfResultPath1, builder.Build());

            MessageBox.Show("File creato!");
        }
        public void creazione173(Boolean colori)
        {
            //users = sql.GetTempUser();
            if (colori)
            {
                pdfResultPath2 = ConfigurationManager.AppSettings["PDF_ResultPath_2"];
                pdfSourcePath2 = ConfigurationManager.AppSettings["PDF_SourcePath_2"];
            }
            if (!colori)
            {
                pdfResultPath2 = ConfigurationManager.AppSettings["PDF_ResultPath_2B"];
                pdfSourcePath2 = ConfigurationManager.AppSettings["PDF_SourcePath_2B"];
            }

            PdfDocumentBuilder builder = new PdfDocumentBuilder();

            PdfDocumentBuilder.AddedFont helvetica = builder.AddStandard14Font(Standard14Font.Helvetica);

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                using (PdfDocument source = PdfDocument.Open(pdfSourcePath2))
                {
                    foreach (Page sourcePage in source.GetPages())
                    {
                        PdfPageBuilder resultPage = builder.AddPage(source, sourcePage.Number);

                        //if (sourcePage.Number == 1)
                        //{
                        //    for (int x = 0; x < 500; x++)
                        //    {
                        //        for (int y = 0; y < 500; y++)
                        //        {
                        //            if ((x * 10) % 50 == 0 && (y * 5) % 50 == 0)
                        //            {
                        //                pdfManagment.WriteLineOnPdf(ref resultPage, (x * 10).ToString() + "," + (y * 5).ToString(), 5, x * 10, y * 5, helvetica);
                        //            }
                        //            else
                        //            {
                        //                pdfManagment.WriteLineOnPdf(ref resultPage, ".", 5, x * 10, y * 5, helvetica);
                        //            }
                        //        }
                        //    }

                        double percX = X173;
                        double percY = Y173;
                        if (colori)
                        {
                            percX = 1;
                            percY = 1;
                        }

                        for (int x = 0; x < 2; x++)
                        {
                            int doppio = 1;
                            if (colori)
                            {
                                doppio = 0;
                            }

                            int doppiox = 0;
                            if (x == 1)
                            {
                                doppio = 289;
                                doppiox = 1;
                            }
                            string nome = row.Cells["Nome"].Value.ToString() + ' ' + row.Cells["Cognome"].Value.ToString();
                            string sezione = row.Cells["Sezione"].Value.ToString();
                            string numeroPortoArmi = row.Cells["Numero_porto_armi"].Value.ToString();
                            string indirizzoResidenza = row.Cells["Indirizzo_residenza"].Value.ToString();
                            string comuneNascita = row.Cells["Comune_nascita"].Value.ToString();
                            string codiceFiscale = row.Cells["CodiceFiscale"].Value.ToString();
                            string capResidenza = row.Cells["Cap_residenza"].Value.ToString();
                            string comuneResidenza = row.Cells["Comune_residenza"].Value.ToString();
                            string provinciaResidenza = row.Cells["Provincia_residenza"].Value.ToString();
                            string provinciaNascita = row.Cells["Provincia_nascita"].Value.ToString();
                            string dataNascita = row.Cells["Data_nascita"].Value?.ToString()?.Substring(0, Math.Min(10, row.Cells["Data_nascita"].Value.ToString().Length));
                            string totResidenza = capResidenza + ' ' + comuneResidenza + ' ' + provinciaResidenza;
                            string dataPortoArmi = row.Cells["Data_rilascio_porto_armi"].Value?.ToString()?.Substring(0, Math.Min(10, row.Cells["Data_rilascio_porto_armi"].Value.ToString().Length));

                            pdfManagment.WriteLineOnPdf(ref resultPage, nome, 8, 50 * percX, 480 - doppio * percY, helvetica);
                            pdfManagment.WriteLineOnPdf(ref resultPage, nome, 8, 280 * percX, 480 - doppio * percY, helvetica);

                            double xcelle = 726;
                            int maxCaratteri = 16;
                            foreach (char carattere in codiceFiscale.Take(maxCaratteri))
                            {
                                string carattereMaiuscolo = carattere.ToString().ToUpper();
                                pdfManagment.WriteLineOnPdf(ref resultPage, carattereMaiuscolo, 8, (xcelle + doppiox) * percX, 478 - doppio * percY, helvetica);
                                xcelle += 12.4;
                            }
                            xcelle = 640;
                            maxCaratteri = 23;
                            foreach (char carattere in nome.Take(maxCaratteri))
                            {
                                string carattereMaiuscolo = carattere.ToString().ToUpper();
                                pdfManagment.WriteLineOnPdf(ref resultPage, carattereMaiuscolo, 8, (xcelle + doppiox) * percX, 456 - doppio * percY, helvetica);
                                xcelle += 12.4;
                            }
                            xcelle = 640;
                            maxCaratteri = 20;
                            foreach (char carattere in indirizzoResidenza.Take(maxCaratteri))
                            {
                                string carattereMaiuscolo = carattere.ToString().ToUpper();
                                pdfManagment.WriteLineOnPdf(ref resultPage, carattereMaiuscolo, 8, (xcelle + doppiox) * percX, 410 - doppio * percY, helvetica);
                                xcelle += 12.4;
                            }
                            xcelle = 751;
                            maxCaratteri = 11;
                            foreach (char carattere in comuneNascita.Take(maxCaratteri))
                            {
                                string carattereMaiuscolo = carattere.ToString().ToUpper();
                                pdfManagment.WriteLineOnPdf(ref resultPage, carattereMaiuscolo, 8, (xcelle + doppiox) * percX, 434 - doppio * percY, helvetica);
                                xcelle += 12.4;
                            }
                            xcelle = 668;
                            maxCaratteri = 6;
                            string nuovaStringa = $"{dataNascita[0]}{dataNascita[1]}{dataNascita[3]}{dataNascita[4]}{dataNascita[8]}{dataNascita[9]}";
                            foreach (char carattere in nuovaStringa.Take(maxCaratteri))
                            {
                                string carattereMaiuscolo = carattere.ToString().ToUpper();
                                pdfManagment.WriteLineOnPdf(ref resultPage, carattereMaiuscolo, 8, (xcelle + doppiox) * percX, 432 - doppio * percY, helvetica);
                                xcelle += 12.4;
                            }
                            xcelle = 900;
                            maxCaratteri = 2;
                            foreach (char carattere in provinciaNascita.Take(maxCaratteri))
                            {
                                string carattereMaiuscolo = carattere.ToString().ToUpper();
                                pdfManagment.WriteLineOnPdf(ref resultPage, carattereMaiuscolo, 8, (xcelle + doppiox) * percX, 434 - doppio * percY, helvetica);
                                xcelle += 12.4;
                            }
                            xcelle = 900;
                            maxCaratteri = 2;
                            foreach (char carattere in provinciaResidenza.Take(maxCaratteri))
                            {
                                string carattereMaiuscolo = carattere.ToString().ToUpper();
                                pdfManagment.WriteLineOnPdf(ref resultPage, carattereMaiuscolo, 8, (xcelle + doppiox) * percX, 410 - doppio * percY, helvetica);
                                xcelle += 12.4;
                            }
                            xcelle = 639;
                            maxCaratteri = 17;
                            foreach (char carattere in comuneResidenza.Take(maxCaratteri))
                            {
                                string carattereMaiuscolo = carattere.ToString().ToUpper();
                                pdfManagment.WriteLineOnPdf(ref resultPage, carattereMaiuscolo, 8, (xcelle + doppiox) * percX, 388 - doppio * percY, helvetica);
                                xcelle += 12.4;
                            }
                            xcelle = 864;
                            maxCaratteri = 5;
                            foreach (char carattere in capResidenza.Take(maxCaratteri))
                            {
                                string carattereMaiuscolo = carattere.ToString().ToUpper();
                                pdfManagment.WriteLineOnPdf(ref resultPage, carattereMaiuscolo, 8, (xcelle + doppiox) * percX, 388 - doppio * percY, helvetica);
                                xcelle += 12.4;
                            }

                        }
                    }
                }
            }
            System.IO.File.WriteAllBytes(pdfResultPath2, builder.Build());

            MessageBox.Show("File creato!");
        }
        public double getY(double x, double percX)
        {
            return -((-x + 540) * percX - 540);
        }
        public void mostraFiltri()
        {
            applica_filtri_btn.Visible = true;
            pulisci_filtri_btn.Visible = true;
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
            tbDataPagamentoF.Visible = true;
            tbNumeroF.Visible = true;
            tbTipoF.Visible = true;
            tbTelefonoF.Visible = true;
            tbCellulareF.Visible = true;
            tbMailF.Visible = true;
        }
        public void nascondiFiltri()
        {
            applica_filtri_btn.Visible = false;
            applica_filtri_btn.Visible = false;
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
            tbDataPagamentoF.Visible = false;
            tbNumeroF.Visible = false;
            tbTipoF.Visible = false;
            tbTelefonoF.Visible = false;
            tbCellulareF.Visible = false;
            tbMailF.Visible = false;
        }
        public async void editUser()
        {
            User newUser = new User();

            if (this.label10.Text == "Modifica utente")
            {
                newUser.Uid = new Guid(lbl_Uid.Text);
            }
            else
            {
                newUser.Uid = Guid.NewGuid();
            }

            newUser.Nome = tbNome.Text;
            newUser.Cognome = tbCognome.Text;
            newUser.CodiceFiscale = tbCodiceFiscale.Text;

            if (!string.IsNullOrWhiteSpace(tbDataDiNascita.Text))
            {
                newUser.Data_nascita = Convert.ToDateTime(tbDataDiNascita.Text);
            }
            else
            {
                newUser.Data_nascita = Convert.ToDateTime("01-01-1900 00:00:00");
            }

            if (!string.IsNullOrWhiteSpace(tbDataRilascioPortoArmi.Text))
            {
                newUser.Data_rilascio_porto_armi = Convert.ToDateTime(tbDataRilascioPortoArmi.Text);
            }
            else
            {
                newUser.Data_rilascio_porto_armi = Convert.ToDateTime("01-01-1900 00:00:00");
            }

            newUser.Numero_porto_armi = tbNumeroPortoArmi.Text;
            newUser.Cap_nascita = tbCapNascita.Text;
            newUser.Comune_nascita = tbComuneNascita.Text;
            newUser.Provincia_nascita = tbProvinciaNascita.Text;
            newUser.Indirizzo_residenza = tbIndirizzoResistenza.Text;
            newUser.Cap_residenza = tbCapResistenza.Text;
            newUser.Comune_residenza = tbComuneResidenza.Text;
            newUser.Provincia_residenza = tbProvinciaResistenza.Text;
            newUser.Sezione = tbSezione.Text;

            if (!string.IsNullOrWhiteSpace(tbDataPagamento.Text))
            {
                newUser.Data_pagamento = Convert.ToDateTime(tbDataPagamento.Text);
            }
            else
            {
                newUser.Data_pagamento = Convert.ToDateTime("01-01-1900 00:00:00");
            }

            if (!string.IsNullOrWhiteSpace(tbNumero.Text))
            {
                newUser.Numero = Convert.ToInt32(tbNumero.Text);
            }
            else
            {
                newUser.Numero = 0;
            }

            newUser.Tipo = tbTipo.Text;
            newUser.Telefono = tbTelefono.Text;
            newUser.Cellulare_whatsapp = tbCellulare.Text;
            newUser.Mail = tbMail.Text;

            var json = JsonConvert.SerializeObject(newUser);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var msg = new HttpRequestMessage(HttpMethod.Post, rootAPI + "user/edit");
            msg.Headers.Add("X-AUTH", token);
            msg.Content = data;

            using HttpResponseMessage response = await client.SendAsync(msg);
            response.EnsureSuccessStatusCode();

            await ReloadGrid();
        }

        public async void deleteUser()
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                var uid = row.Cells["Uid"].Value;

                var json = JsonConvert.SerializeObject(uid);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                var msg = new HttpRequestMessage(HttpMethod.Post, rootAPI + "user/delete");
                msg.Headers.Add("X-AUTH", token);
                msg.Content = data;

                using HttpResponseMessage response = await client.SendAsync(msg);
                response.EnsureSuccessStatusCode();
            }

            await ReloadGrid();
        }
        private void addUser_btn_Click(object sender, EventArgs e)
        {

            this.label10.Text = "Nuovo utente";

            this.nascondiFiltri();

            this.addUser_btn.Enabled = false;
            this.editUser_btn.Enabled = false;
            this.saveUser_btn.Visible = true;
            this.annullla_btn.Visible = true;
            this.pulisci_filtri_btn.Visible = false;
            this.applica_filtri_btn.Visible = false;
        }

        private void editUser_btn_Click(object sender, EventArgs e)
        {

            this.label10.Text = "Modifica utente";

            this.nascondiFiltri();

            this.addUser_btn.Enabled = false;
            this.editUser_btn.Enabled = false;
            this.saveUser_btn.Visible = true;
            this.annullla_btn.Visible = true;
            this.pulisci_filtri_btn.Visible = false;
            this.applica_filtri_btn.Visible = false;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                lbl_Uid.Text = row.Cells["uid"].Value.ToString();
                tbNome.Text = row.Cells["nome"].Value.ToString();
                tbCognome.Text = row.Cells["cognome"].Value.ToString();
                tbCodiceFiscale.Text = row.Cells["CodiceFiscale"].Value.ToString();
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
                tbDataPagamento.Text = row.Cells["data_pagamento"].Value.ToString();
                tbNumero.Text = row.Cells["numero"].Value.ToString();
                tbTipo.Text = row.Cells["tipo"].Value.ToString();
                tbTelefono.Text = row.Cells["telefono"].Value.ToString();
                tbCellulare.Text = row.Cells["cellulare_whatsapp"].Value.ToString();
                tbMail.Text = row.Cells["mail"].Value.ToString();
            }
        }

        private void saveUser_btn_Click(object sender, EventArgs e)
        {
            if (annulla == false)
            {
                editUser();
            }

            lbl_Uid.Text = "";
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
            tbDataPagamento.Text = "";
            tbNumero.Text = "";
            tbTipo.Text = "";
            tbTelefono.Text = "";
            tbCellulare.Text = "";
            tbMail.Text = "";

            this.mostraFiltri();

            this.label10.Text = "Filtri";
            this.addUser_btn.Enabled = true;
            this.saveUser_btn.Visible = false;
            this.annullla_btn.Visible = false;
            this.editUser_btn.Enabled = true;

            this.pulisci_filtri_btn.Visible = true;
            this.applica_filtri_btn.Visible = true;

            annulla = false;
        }

        private void annullla_btn_Click(object sender, EventArgs e)
        {
            annulla = true;
            saveUser_btn.PerformClick();
        }

        private async void filtri_btn_Click(object sender, EventArgs e)
        {
            await ReloadGrid();
        }

        private async void pulisci_filtri_btn_Click(object sender, EventArgs e)
        {
            lbl_Uid.Text = "";
            tbNomeF.Text = "";
            tbCognomeF.Text = "";
            tbCodiceFiscaleF.Text = "";
            tbDataDiNascitaF.Text = "";
            tbDataRilascioPortoArmiF.Text = "";
            tbNumeroPortoArmiF.Text = "";
            tbCapNascitaF.Text = "";
            tbComuneNascitaF.Text = "";
            tbProvinciaNascitaF.Text = "";
            tbIndirizzoResistenzaF.Text = "";
            tbCapResistenzaF.Text = "";
            tbComuneResidenzaF.Text = "";
            tbProvinciaResistenzaF.Text = "";
            tbSezioneF.Text = "";
            tbDataPagamentoF.Text = "";
            tbNumeroF.Text = "";
            tbTipoF.Text = "";
            tbTelefonoF.Text = "";
            tbCellulareF.Text = "";
            tbMailF.Text = "";
            cbScaduti.Checked = false;

            await ReloadGrid();

            this.addUser_btn.Enabled = true;
            this.editUser_btn.Enabled = true;

        }

        private async void deleteUser_btn_Click(object sender, EventArgs e)
        {
            deleteUser();
        }

        private void pdf1_Click(object sender, EventArgs e)
        {
            creazione173(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            creazione173(false);
        }

        private void pdf2_Click(object sender, EventArgs e)
        {
            creazioneAssicurazione(true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            creazioneAssicurazione(false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            esportazioneExcel();
        }

        private void tbX_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Xass = Convert.ToDouble(tbX.Text) / 1000;
            }
            catch { }
        }

        private void tbY_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Yass = Convert.ToDouble(tbY.Text) / 1000;
            }
            catch { }
        }

        private void tbX173_TextChanged(object sender, EventArgs e)
        {
            try
            {
                X173 = Convert.ToDouble(tbX173.Text) / 1000;
            }
            catch { }
        }

        private void tbY173_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Y173 = Convert.ToDouble(tbY173.Text) / 1000;
            }
            catch { }
        }
    }
}