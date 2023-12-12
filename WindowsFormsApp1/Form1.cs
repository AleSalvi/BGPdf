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

            dataGridView1.DataSource = utentiFiltrati;

            dataGridView1.Columns["Uid"].Visible = false;
        }

        private void btnCreatePdf_Click(object sender, EventArgs e)
        {
            //users = sql.GetTempUser();

            pdfResultPath1 = ConfigurationManager.AppSettings["PDF_ResultPath_1"];

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
                            //            pdfManagment.WriteLineOnPdf(ref resultPage, (x * 10).ToString() + "," + (y * 5).ToString(), 5, x * 10, y * 5, helvetica);
                            //        }
                            //        else
                            //        {
                            //            pdfManagment.WriteLineOnPdf(ref resultPage, ".", 5, x * 10, y * 5, helvetica);
                            //        }
                            //    }
                            //}
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

                                pdfManagment.WriteLineOnPdf(ref resultPage, sezione, 10, 20 + doppio, 532, helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, numeroPortoArmi, 10, 20 + doppio, 504, helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, dataPortoArmi, 10, 130 + doppio, 504, helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, nome, 10, 20 + doppio, 477, helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, comuneNascita, 10, 20 + doppio, 449, helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, dataNascita, 10, 130 + doppio, 449, helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, indirizzoResidenza, 10, 20 + doppio, 422, helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, totResidenza, 10, 20 + doppio, 394, helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, codiceFiscale, 10, 20 + doppio, 367, helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, row.Cells["Telefono"].Value.ToString(), 10, 20 + doppio, 338, helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, row.Cells["Mail"].Value.ToString(), 10, 20 + doppio, 311, helvetica);

                                pdfManagment.WriteLineOnPdf(ref resultPage, sezione, 10, 170, 172, helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, numeroPortoArmi, 10, 60, 156, helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, dataPortoArmi, 10, 210, 157, helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, nome, 10, 20, 129, helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, indirizzoResidenza, 10, 45, 94, helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, capResidenza, 10, 45, 75, helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, comuneResidenza, 10, 45, 57, helvetica);

                                pdfManagment.WriteLineOnPdf(ref resultPage, nome, 10, 450, 439, helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, comuneNascita, 10, 450, 420, helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, dataNascita, 10, 580, 420, helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, totResidenza, 10, 450, 401, helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, indirizzoResidenza, 10, 450, 382, helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, sezione, 10, 460, 344, helvetica);

                                pdfManagment.WriteLineOnPdf(ref resultPage, sezione, 10, 580, 172, helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, numeroPortoArmi, 10, 485, 157, helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, dataPortoArmi, 10, 670, 157, helvetica);
                                
                                double xcelle = 540;
                                foreach (char carattere in nome)
                                {
                                    string carattereMaiuscolo = carattere.ToString().ToUpper();
                                    pdfManagment.WriteLineOnPdf(ref resultPage, carattereMaiuscolo, 10, xcelle, 135, helvetica);

                                    xcelle += 12.35;
                                }
                                xcelle = 540;
                                foreach (char carattere in indirizzoResidenza)
                                {
                                    string carattereMaiuscolo = carattere.ToString().ToUpper();
                                    pdfManagment.WriteLineOnPdf(ref resultPage, carattereMaiuscolo, 10, xcelle, 96, helvetica);

                                    xcelle += 12.35;
                                }
                                xcelle = 540;
                                foreach (char carattere in capResidenza)
                                {
                                    string carattereMaiuscolo = carattere.ToString().ToUpper();
                                    pdfManagment.WriteLineOnPdf(ref resultPage, carattereMaiuscolo, 10, xcelle, 72, helvetica);

                                    xcelle += 12.35;
                                }
                                xcelle = 615;
                                foreach (char carattere in comuneResidenza)
                                {
                                    string carattereMaiuscolo = carattere.ToString().ToUpper();
                                    pdfManagment.WriteLineOnPdf(ref resultPage, carattereMaiuscolo, 10, xcelle, 72, helvetica);

                                    xcelle += 12.25;
                                }

                            }

                        }
                    }
                }
            }
            System.IO.File.WriteAllBytes(pdfResultPath1, builder.Build());

            MessageBox.Show("File creato!");
        }
        private void pdf1_Click(object sender, EventArgs e)
        {
            //users = sql.GetTempUser();

            pdfResultPath2 = ConfigurationManager.AppSettings["PDF_ResultPath_2"];

            PdfDocumentBuilder builder = new PdfDocumentBuilder();

            PdfDocumentBuilder.AddedFont helvetica = builder.AddStandard14Font(Standard14Font.Helvetica);

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                using (PdfDocument source = PdfDocument.Open(pdfSourcePath2))
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
                            //            pdfManagment.WriteLineOnPdf(ref resultPage, (x * 10).ToString() + "," + (y * 5).ToString(), 5, x * 10, y * 5, helvetica);
                            //        }
                            //        else
                            //        {
                            //            pdfManagment.WriteLineOnPdf(ref resultPage, ".", 5, x * 10, y * 5, helvetica);
                            //        }
                            //    }
                            //}
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

                                pdfManagment.WriteLineOnPdf(ref resultPage, sezione, 10, 20 + doppio, 532, helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, numeroPortoArmi, 10, 20 + doppio, 504, helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, dataPortoArmi, 10, 130 + doppio, 504, helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, nome, 10, 20 + doppio, 477, helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, comuneNascita, 10, 20 + doppio, 449, helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, dataNascita, 10, 130 + doppio, 449, helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, indirizzoResidenza, 10, 20 + doppio, 422, helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, totResidenza, 10, 20 + doppio, 394, helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, codiceFiscale, 10, 20 + doppio, 367, helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, row.Cells["Telefono"].Value.ToString(), 10, 20 + doppio, 338, helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, row.Cells["Mail"].Value.ToString(), 10, 20 + doppio, 311, helvetica);

                                pdfManagment.WriteLineOnPdf(ref resultPage, sezione, 10, 170, 172, helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, numeroPortoArmi, 10, 60, 156, helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, dataPortoArmi, 10, 210, 157, helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, nome, 10, 20, 129, helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, indirizzoResidenza, 10, 45, 94, helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, capResidenza, 10, 45, 75, helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, comuneResidenza, 10, 45, 57, helvetica);

                                pdfManagment.WriteLineOnPdf(ref resultPage, nome, 10, 450, 439, helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, comuneNascita, 10, 450, 420, helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, dataNascita, 10, 580, 420, helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, totResidenza, 10, 450, 401, helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, indirizzoResidenza, 10, 450, 382, helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, sezione, 10, 460, 344, helvetica);

                                pdfManagment.WriteLineOnPdf(ref resultPage, sezione, 10, 580, 172, helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, numeroPortoArmi, 10, 485, 157, helvetica);
                                pdfManagment.WriteLineOnPdf(ref resultPage, dataPortoArmi, 10, 670, 157, helvetica);

                                double xcelle = 540;
                                foreach (char carattere in nome)
                                {
                                    string carattereMaiuscolo = carattere.ToString().ToUpper();
                                    pdfManagment.WriteLineOnPdf(ref resultPage, carattereMaiuscolo, 10, xcelle, 135, helvetica);

                                    xcelle += 12.35;
                                }
                                xcelle = 540;
                                foreach (char carattere in indirizzoResidenza)
                                {
                                    string carattereMaiuscolo = carattere.ToString().ToUpper();
                                    pdfManagment.WriteLineOnPdf(ref resultPage, carattereMaiuscolo, 10, xcelle, 96, helvetica);

                                    xcelle += 12.35;
                                }
                                xcelle = 540;
                                foreach (char carattere in capResidenza)
                                {
                                    string carattereMaiuscolo = carattere.ToString().ToUpper();
                                    pdfManagment.WriteLineOnPdf(ref resultPage, carattereMaiuscolo, 10, xcelle, 72, helvetica);

                                    xcelle += 12.35;
                                }
                                xcelle = 615;
                                foreach (char carattere in comuneResidenza)
                                {
                                    string carattereMaiuscolo = carattere.ToString().ToUpper();
                                    pdfManagment.WriteLineOnPdf(ref resultPage, carattereMaiuscolo, 10, xcelle, 72, helvetica);

                                    xcelle += 12.25;
                                }

                            }

                        }
                    }
                }
            }
            System.IO.File.WriteAllBytes(pdfResultPath2, builder.Build());

            MessageBox.Show("File creato!");
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
            tbProvinciaF.Visible = true;
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
            tbProvinciaF.Visible = false;
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
            tbProvincia.Text = "";
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
            tbProvinciaF.Text = "";
            tbDataPagamentoF.Text = "";
            tbNumeroF.Text = "";
            tbTipoF.Text = "";
            tbTelefonoF.Text = "";
            tbCellulareF.Text = "";
            tbMailF.Text = "";

            await ReloadGrid();

            this.addUser_btn.Enabled = true;
            this.editUser_btn.Enabled = true;

        }

        private async void deleteUser_btn_Click(object sender, EventArgs e)
        {
            deleteUser();
        }

    }
}