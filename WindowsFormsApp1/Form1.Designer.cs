using System;

namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pdf2 = new System.Windows.Forms.Button();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbCognome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tbProvinciaNascita = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbCapNascita = new System.Windows.Forms.TextBox();
            this.tbComuneNascita = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbDataRilascioPortoArmi = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tbProvinciaResistenza = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbCapResistenza = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbCodiceFiscale = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbNumeroPortoArmi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbIndirizzoResistenza = new System.Windows.Forms.TextBox();
            this.tbComuneResidenza = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbTipo = new System.Windows.Forms.TextBox();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbProvincia = new System.Windows.Forms.TextBox();
            this.tbDataPagamento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbDataDiNascita = new System.Windows.Forms.TextBox();
            this.tbSezione = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addUser_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.editUser_btn = new System.Windows.Forms.Button();
            this.saveUser_btn = new System.Windows.Forms.Button();
            this.pdf1 = new System.Windows.Forms.Button();
            this.tbNomeF = new System.Windows.Forms.TextBox();
            this.tbProvinciaNascitaF = new System.Windows.Forms.TextBox();
            this.tbCapNascitaF = new System.Windows.Forms.TextBox();
            this.tbComuneNascitaF = new System.Windows.Forms.TextBox();
            this.tbDataRilascioPortoArmiF = new System.Windows.Forms.TextBox();
            this.tbProvinciaResistenzaF = new System.Windows.Forms.TextBox();
            this.tbCapResistenzaF = new System.Windows.Forms.TextBox();
            this.tbCodiceFiscaleF = new System.Windows.Forms.TextBox();
            this.tbNumeroPortoArmiF = new System.Windows.Forms.TextBox();
            this.tbIndirizzoResistenzaF = new System.Windows.Forms.TextBox();
            this.tbComuneResidenzaF = new System.Windows.Forms.TextBox();
            this.tbTipoF = new System.Windows.Forms.TextBox();
            this.tbNumeroF = new System.Windows.Forms.TextBox();
            this.tbProvinciaF = new System.Windows.Forms.TextBox();
            this.tbDataPagamentoF = new System.Windows.Forms.TextBox();
            this.tbDataDiNascitaF = new System.Windows.Forms.TextBox();
            this.tbSezioneF = new System.Windows.Forms.TextBox();
            this.tbCognomeF = new System.Windows.Forms.TextBox();
            this.annullla_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pdf2
            // 
            this.pdf2.Location = new System.Drawing.Point(844, 609);
            this.pdf2.Name = "pdf2";
            this.pdf2.Size = new System.Drawing.Size(155, 23);
            this.pdf2.TabIndex = 0;
            this.pdf2.Text = "Create Pdf";
            this.pdf2.UseVisualStyleBackColor = true;
            this.pdf2.Click += new System.EventHandler(this.btnCreatePdf_Click);
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(12, 84);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(279, 20);
            this.tbNome.TabIndex = 1;
            // 
            // tbCognome
            // 
            this.tbCognome.Location = new System.Drawing.Point(12, 123);
            this.tbCognome.Name = "tbCognome";
            this.tbCognome.Size = new System.Drawing.Size(279, 20);
            this.tbCognome.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cognome:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.annullla_btn);
            this.panel1.Controls.Add(this.tbNomeF);
            this.panel1.Controls.Add(this.tbProvinciaNascitaF);
            this.panel1.Controls.Add(this.tbCapNascitaF);
            this.panel1.Controls.Add(this.tbComuneNascitaF);
            this.panel1.Controls.Add(this.tbDataRilascioPortoArmiF);
            this.panel1.Controls.Add(this.tbProvinciaResistenzaF);
            this.panel1.Controls.Add(this.tbCapResistenzaF);
            this.panel1.Controls.Add(this.tbCodiceFiscaleF);
            this.panel1.Controls.Add(this.tbNumeroPortoArmiF);
            this.panel1.Controls.Add(this.tbIndirizzoResistenzaF);
            this.panel1.Controls.Add(this.tbComuneResidenzaF);
            this.panel1.Controls.Add(this.tbTipoF);
            this.panel1.Controls.Add(this.tbNumeroF);
            this.panel1.Controls.Add(this.tbProvinciaF);
            this.panel1.Controls.Add(this.tbDataPagamentoF);
            this.panel1.Controls.Add(this.tbDataDiNascitaF);
            this.panel1.Controls.Add(this.tbSezioneF);
            this.panel1.Controls.Add(this.tbCognomeF);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.saveUser_btn);
            this.panel1.Controls.Add(this.tbProvinciaNascita);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.tbCapNascita);
            this.panel1.Controls.Add(this.tbComuneNascita);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.tbDataRilascioPortoArmi);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.tbProvinciaResistenza);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.tbCapResistenza);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.tbCodiceFiscale);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tbNumeroPortoArmi);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.tbIndirizzoResistenza);
            this.panel1.Controls.Add(this.tbComuneResidenza);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.tbTipo);
            this.panel1.Controls.Add(this.tbNumero);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbProvincia);
            this.panel1.Controls.Add(this.tbDataPagamento);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tbDataDiNascita);
            this.panel1.Controls.Add(this.tbSezione);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbNome);
            this.panel1.Controls.Add(this.tbCognome);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1011, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 591);
            this.panel1.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 536);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Tipo:";
            // 
            // tbProvinciaNascita
            // 
            this.tbProvinciaNascita.Location = new System.Drawing.Point(12, 318);
            this.tbProvinciaNascita.Name = "tbProvinciaNascita";
            this.tbProvinciaNascita.Size = new System.Drawing.Size(279, 20);
            this.tbProvinciaNascita.TabIndex = 43;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 302);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 13);
            this.label12.TabIndex = 44;
            this.label12.Text = "Provincia nascita:";
            // 
            // tbCapNascita
            // 
            this.tbCapNascita.Location = new System.Drawing.Point(12, 279);
            this.tbCapNascita.Name = "tbCapNascita";
            this.tbCapNascita.Size = new System.Drawing.Size(133, 20);
            this.tbCapNascita.TabIndex = 39;
            // 
            // tbComuneNascita
            // 
            this.tbComuneNascita.Location = new System.Drawing.Point(157, 279);
            this.tbComuneNascita.Name = "tbComuneNascita";
            this.tbComuneNascita.Size = new System.Drawing.Size(134, 20);
            this.tbComuneNascita.TabIndex = 40;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(154, 263);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 13);
            this.label13.TabIndex = 42;
            this.label13.Text = "Comune nascita:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 263);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 13);
            this.label14.TabIndex = 41;
            this.label14.Text = "CAP nascita:";
            // 
            // tbDataRilascioPortoArmi
            // 
            this.tbDataRilascioPortoArmi.Location = new System.Drawing.Point(158, 201);
            this.tbDataRilascioPortoArmi.Name = "tbDataRilascioPortoArmi";
            this.tbDataRilascioPortoArmi.Size = new System.Drawing.Size(133, 20);
            this.tbDataRilascioPortoArmi.TabIndex = 37;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(155, 185);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(136, 13);
            this.label19.TabIndex = 38;
            this.label19.Text = "Data di rilascio porto d\'armi:";
            // 
            // tbProvinciaResistenza
            // 
            this.tbProvinciaResistenza.Location = new System.Drawing.Point(12, 435);
            this.tbProvinciaResistenza.Name = "tbProvinciaResistenza";
            this.tbProvinciaResistenza.Size = new System.Drawing.Size(279, 20);
            this.tbProvinciaResistenza.TabIndex = 35;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 419);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(102, 13);
            this.label18.TabIndex = 36;
            this.label18.Text = "Provincia residenza:";
            // 
            // tbCapResistenza
            // 
            this.tbCapResistenza.Location = new System.Drawing.Point(12, 396);
            this.tbCapResistenza.Name = "tbCapResistenza";
            this.tbCapResistenza.Size = new System.Drawing.Size(133, 20);
            this.tbCapResistenza.TabIndex = 33;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 380);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "CAP residenza:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 24);
            this.label10.TabIndex = 14;
            this.label10.Text = "Filtri";
            // 
            // tbCodiceFiscale
            // 
            this.tbCodiceFiscale.Location = new System.Drawing.Point(12, 162);
            this.tbCodiceFiscale.Name = "tbCodiceFiscale";
            this.tbCodiceFiscale.Size = new System.Drawing.Size(279, 20);
            this.tbCodiceFiscale.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Codice fiscale:";
            // 
            // tbNumeroPortoArmi
            // 
            this.tbNumeroPortoArmi.Location = new System.Drawing.Point(12, 240);
            this.tbNumeroPortoArmi.Name = "tbNumeroPortoArmi";
            this.tbNumeroPortoArmi.Size = new System.Drawing.Size(279, 20);
            this.tbNumeroPortoArmi.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 224);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Numero porto d\'armi:";
            // 
            // tbIndirizzoResistenza
            // 
            this.tbIndirizzoResistenza.Location = new System.Drawing.Point(12, 357);
            this.tbIndirizzoResistenza.Name = "tbIndirizzoResistenza";
            this.tbIndirizzoResistenza.Size = new System.Drawing.Size(279, 20);
            this.tbIndirizzoResistenza.TabIndex = 19;
            // 
            // tbComuneResidenza
            // 
            this.tbComuneResidenza.Location = new System.Drawing.Point(157, 396);
            this.tbComuneResidenza.Name = "tbComuneResidenza";
            this.tbComuneResidenza.Size = new System.Drawing.Size(134, 20);
            this.tbComuneResidenza.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(154, 380);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "Comune residenza:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 341);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 13);
            this.label16.TabIndex = 21;
            this.label16.Text = "Indirizzo residenza:";
            // 
            // tbTipo
            // 
            this.tbTipo.Location = new System.Drawing.Point(13, 552);
            this.tbTipo.Name = "tbTipo";
            this.tbTipo.Size = new System.Drawing.Size(132, 20);
            this.tbTipo.TabIndex = 15;
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(157, 513);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(134, 20);
            this.tbNumero.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 497);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Numero:";
            // 
            // tbProvincia
            // 
            this.tbProvincia.Location = new System.Drawing.Point(158, 474);
            this.tbProvincia.Name = "tbProvincia";
            this.tbProvincia.Size = new System.Drawing.Size(133, 20);
            this.tbProvincia.TabIndex = 11;
            // 
            // tbDataPagamento
            // 
            this.tbDataPagamento.Location = new System.Drawing.Point(12, 513);
            this.tbDataPagamento.Name = "tbDataPagamento";
            this.tbDataPagamento.Size = new System.Drawing.Size(133, 20);
            this.tbDataPagamento.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 497);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Data pagamento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(155, 458);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Provincia:";
            // 
            // tbDataDiNascita
            // 
            this.tbDataDiNascita.Location = new System.Drawing.Point(12, 201);
            this.tbDataDiNascita.Name = "tbDataDiNascita";
            this.tbDataDiNascita.Size = new System.Drawing.Size(133, 20);
            this.tbDataDiNascita.TabIndex = 7;
            // 
            // tbSezione
            // 
            this.tbSezione.Location = new System.Drawing.Point(12, 474);
            this.tbSezione.Name = "tbSezione";
            this.tbSezione.Size = new System.Drawing.Size(133, 20);
            this.tbSezione.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 458);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sezione:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data di nascita:";
            // 
            // addUser_btn
            // 
            this.addUser_btn.Location = new System.Drawing.Point(371, 609);
            this.addUser_btn.Name = "addUser_btn";
            this.addUser_btn.Size = new System.Drawing.Size(155, 23);
            this.addUser_btn.TabIndex = 10;
            this.addUser_btn.Text = "Crea utente";
            this.addUser_btn.UseVisualStyleBackColor = true;
            this.addUser_btn.Click += new System.EventHandler(this.addUser_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(987, 591);
            this.dataGridView1.TabIndex = 11;
            // 
            // editUser_btn
            // 
            this.editUser_btn.Location = new System.Drawing.Point(532, 609);
            this.editUser_btn.Name = "editUser_btn";
            this.editUser_btn.Size = new System.Drawing.Size(145, 23);
            this.editUser_btn.TabIndex = 12;
            this.editUser_btn.Text = "Modifica utente";
            this.editUser_btn.UseVisualStyleBackColor = true;
            this.editUser_btn.Click += new System.EventHandler(this.editUser_btn_Click);
            // 
            // saveUser_btn
            // 
            this.saveUser_btn.Location = new System.Drawing.Point(226, 549);
            this.saveUser_btn.Name = "saveUser_btn";
            this.saveUser_btn.Size = new System.Drawing.Size(65, 23);
            this.saveUser_btn.TabIndex = 13;
            this.saveUser_btn.Text = "Salva";
            this.saveUser_btn.UseVisualStyleBackColor = true;
            this.saveUser_btn.Visible = false;
            this.saveUser_btn.Click += new System.EventHandler(this.saveUser_btn_Click);
            // 
            // pdf1
            // 
            this.pdf1.Location = new System.Drawing.Point(683, 609);
            this.pdf1.Name = "pdf1";
            this.pdf1.Size = new System.Drawing.Size(155, 23);
            this.pdf1.TabIndex = 14;
            this.pdf1.Text = "Create Pdf";
            this.pdf1.UseVisualStyleBackColor = true;
            // 
            // tbNomeF
            // 
            this.tbNomeF.Location = new System.Drawing.Point(18, 84);
            this.tbNomeF.Name = "tbNomeF";
            this.tbNomeF.Size = new System.Drawing.Size(279, 20);
            this.tbNomeF.TabIndex = 64;
            // 
            // tbProvinciaNascitaF
            // 
            this.tbProvinciaNascitaF.Location = new System.Drawing.Point(18, 318);
            this.tbProvinciaNascitaF.Name = "tbProvinciaNascitaF";
            this.tbProvinciaNascitaF.Size = new System.Drawing.Size(279, 20);
            this.tbProvinciaNascitaF.TabIndex = 63;
            // 
            // tbCapNascitaF
            // 
            this.tbCapNascitaF.Location = new System.Drawing.Point(18, 279);
            this.tbCapNascitaF.Name = "tbCapNascitaF";
            this.tbCapNascitaF.Size = new System.Drawing.Size(133, 20);
            this.tbCapNascitaF.TabIndex = 61;
            // 
            // tbComuneNascitaF
            // 
            this.tbComuneNascitaF.Location = new System.Drawing.Point(163, 279);
            this.tbComuneNascitaF.Name = "tbComuneNascitaF";
            this.tbComuneNascitaF.Size = new System.Drawing.Size(134, 20);
            this.tbComuneNascitaF.TabIndex = 62;
            // 
            // tbDataRilascioPortoArmiF
            // 
            this.tbDataRilascioPortoArmiF.Location = new System.Drawing.Point(164, 201);
            this.tbDataRilascioPortoArmiF.Name = "tbDataRilascioPortoArmiF";
            this.tbDataRilascioPortoArmiF.Size = new System.Drawing.Size(133, 20);
            this.tbDataRilascioPortoArmiF.TabIndex = 60;
            // 
            // tbProvinciaResistenzaF
            // 
            this.tbProvinciaResistenzaF.Location = new System.Drawing.Point(18, 435);
            this.tbProvinciaResistenzaF.Name = "tbProvinciaResistenzaF";
            this.tbProvinciaResistenzaF.Size = new System.Drawing.Size(279, 20);
            this.tbProvinciaResistenzaF.TabIndex = 59;
            // 
            // tbCapResistenzaF
            // 
            this.tbCapResistenzaF.Location = new System.Drawing.Point(18, 396);
            this.tbCapResistenzaF.Name = "tbCapResistenzaF";
            this.tbCapResistenzaF.Size = new System.Drawing.Size(133, 20);
            this.tbCapResistenzaF.TabIndex = 58;
            // 
            // tbCodiceFiscaleF
            // 
            this.tbCodiceFiscaleF.Location = new System.Drawing.Point(18, 162);
            this.tbCodiceFiscaleF.Name = "tbCodiceFiscaleF";
            this.tbCodiceFiscaleF.Size = new System.Drawing.Size(279, 20);
            this.tbCodiceFiscaleF.TabIndex = 57;
            // 
            // tbNumeroPortoArmiF
            // 
            this.tbNumeroPortoArmiF.Location = new System.Drawing.Point(18, 240);
            this.tbNumeroPortoArmiF.Name = "tbNumeroPortoArmiF";
            this.tbNumeroPortoArmiF.Size = new System.Drawing.Size(279, 20);
            this.tbNumeroPortoArmiF.TabIndex = 56;
            // 
            // tbIndirizzoResistenzaF
            // 
            this.tbIndirizzoResistenzaF.Location = new System.Drawing.Point(18, 357);
            this.tbIndirizzoResistenzaF.Name = "tbIndirizzoResistenzaF";
            this.tbIndirizzoResistenzaF.Size = new System.Drawing.Size(279, 20);
            this.tbIndirizzoResistenzaF.TabIndex = 54;
            // 
            // tbComuneResidenzaF
            // 
            this.tbComuneResidenzaF.Location = new System.Drawing.Point(163, 396);
            this.tbComuneResidenzaF.Name = "tbComuneResidenzaF";
            this.tbComuneResidenzaF.Size = new System.Drawing.Size(134, 20);
            this.tbComuneResidenzaF.TabIndex = 55;
            // 
            // tbTipoF
            // 
            this.tbTipoF.Location = new System.Drawing.Point(19, 552);
            this.tbTipoF.Name = "tbTipoF";
            this.tbTipoF.Size = new System.Drawing.Size(132, 20);
            this.tbTipoF.TabIndex = 52;
            // 
            // tbNumeroF
            // 
            this.tbNumeroF.Location = new System.Drawing.Point(163, 513);
            this.tbNumeroF.Name = "tbNumeroF";
            this.tbNumeroF.Size = new System.Drawing.Size(134, 20);
            this.tbNumeroF.TabIndex = 53;
            // 
            // tbProvinciaF
            // 
            this.tbProvinciaF.Location = new System.Drawing.Point(164, 474);
            this.tbProvinciaF.Name = "tbProvinciaF";
            this.tbProvinciaF.Size = new System.Drawing.Size(133, 20);
            this.tbProvinciaF.TabIndex = 50;
            // 
            // tbDataPagamentoF
            // 
            this.tbDataPagamentoF.Location = new System.Drawing.Point(18, 513);
            this.tbDataPagamentoF.Name = "tbDataPagamentoF";
            this.tbDataPagamentoF.Size = new System.Drawing.Size(133, 20);
            this.tbDataPagamentoF.TabIndex = 51;
            // 
            // tbDataDiNascitaF
            // 
            this.tbDataDiNascitaF.Location = new System.Drawing.Point(18, 201);
            this.tbDataDiNascitaF.Name = "tbDataDiNascitaF";
            this.tbDataDiNascitaF.Size = new System.Drawing.Size(133, 20);
            this.tbDataDiNascitaF.TabIndex = 48;
            // 
            // tbSezioneF
            // 
            this.tbSezioneF.Location = new System.Drawing.Point(18, 474);
            this.tbSezioneF.Name = "tbSezioneF";
            this.tbSezioneF.Size = new System.Drawing.Size(133, 20);
            this.tbSezioneF.TabIndex = 49;
            // 
            // tbCognomeF
            // 
            this.tbCognomeF.Location = new System.Drawing.Point(18, 123);
            this.tbCognomeF.Name = "tbCognomeF";
            this.tbCognomeF.Size = new System.Drawing.Size(279, 20);
            this.tbCognomeF.TabIndex = 47;
            // 
            // annullla_btn
            // 
            this.annullla_btn.Location = new System.Drawing.Point(157, 549);
            this.annullla_btn.Name = "annullla_btn";
            this.annullla_btn.Size = new System.Drawing.Size(65, 23);
            this.annullla_btn.TabIndex = 65;
            this.annullla_btn.Text = "Annulla";
            this.annullla_btn.UseVisualStyleBackColor = true;
            this.annullla_btn.Visible = false;
            this.annullla_btn.Click += new System.EventHandler(this.annullla_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 644);
            this.Controls.Add(this.pdf1);
            this.Controls.Add(this.editUser_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addUser_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pdf2);
            this.Name = "Form1";
            this.Text = "Associazione Cacciatori Lombardi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        private void tb_name_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button pdf2;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbCognome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addUser_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbTipo;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbProvincia;
        private System.Windows.Forms.TextBox tbDataPagamento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbDataDiNascita;
        private System.Windows.Forms.TextBox tbSezione;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNumeroPortoArmi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbIndirizzoResistenza;
        private System.Windows.Forms.TextBox tbComuneResidenza;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbCodiceFiscale;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button editUser_btn;
        private System.Windows.Forms.Button saveUser_btn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbProvinciaResistenza;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbCapResistenza;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbDataRilascioPortoArmi;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbProvinciaNascita;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbCapNascita;
        private System.Windows.Forms.TextBox tbComuneNascita;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button pdf1;
        private System.Windows.Forms.TextBox tbNomeF;
        private System.Windows.Forms.TextBox tbProvinciaNascitaF;
        private System.Windows.Forms.TextBox tbCapNascitaF;
        private System.Windows.Forms.TextBox tbComuneNascitaF;
        private System.Windows.Forms.TextBox tbDataRilascioPortoArmiF;
        private System.Windows.Forms.TextBox tbProvinciaResistenzaF;
        private System.Windows.Forms.TextBox tbCapResistenzaF;
        private System.Windows.Forms.TextBox tbCodiceFiscaleF;
        private System.Windows.Forms.TextBox tbNumeroPortoArmiF;
        private System.Windows.Forms.TextBox tbIndirizzoResistenzaF;
        private System.Windows.Forms.TextBox tbComuneResidenzaF;
        private System.Windows.Forms.TextBox tbTipoF;
        private System.Windows.Forms.TextBox tbNumeroF;
        private System.Windows.Forms.TextBox tbProvinciaF;
        private System.Windows.Forms.TextBox tbDataPagamentoF;
        private System.Windows.Forms.TextBox tbDataDiNascitaF;
        private System.Windows.Forms.TextBox tbSezioneF;
        private System.Windows.Forms.TextBox tbCognomeF;
        private System.Windows.Forms.Button annullla_btn;
    }
}

