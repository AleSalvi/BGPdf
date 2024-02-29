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
            this.cbScaduti = new System.Windows.Forms.CheckBox();
            this.tbDataPagamentoF = new System.Windows.Forms.TextBox();
            this.tbDataPagamento = new System.Windows.Forms.DateTimePicker();
            this.tbDataRilascioPortoArmiF = new System.Windows.Forms.TextBox();
            this.tbDataRilascioPortoArmi = new System.Windows.Forms.DateTimePicker();
            this.tbDataDiNascitaF = new System.Windows.Forms.TextBox();
            this.tbDataDiNascita = new System.Windows.Forms.DateTimePicker();
            this.lbl_Uid = new System.Windows.Forms.Label();
            this.pulisci_filtri_btn = new System.Windows.Forms.Button();
            this.tbMailF = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.tbCellulareF = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tbCellulare = new System.Windows.Forms.TextBox();
            this.applica_filtri_btn = new System.Windows.Forms.Button();
            this.tbTelefonoF = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.annullla_btn = new System.Windows.Forms.Button();
            this.tbNomeF = new System.Windows.Forms.TextBox();
            this.tbProvinciaNascitaF = new System.Windows.Forms.TextBox();
            this.tbCapNascitaF = new System.Windows.Forms.TextBox();
            this.tbComuneNascitaF = new System.Windows.Forms.TextBox();
            this.tbProvinciaResistenzaF = new System.Windows.Forms.TextBox();
            this.tbCapResistenzaF = new System.Windows.Forms.TextBox();
            this.tbCodiceFiscaleF = new System.Windows.Forms.TextBox();
            this.tbNumeroPortoArmiF = new System.Windows.Forms.TextBox();
            this.tbIndirizzoResistenzaF = new System.Windows.Forms.TextBox();
            this.tbComuneResidenzaF = new System.Windows.Forms.TextBox();
            this.tbTipoF = new System.Windows.Forms.TextBox();
            this.tbNumeroF = new System.Windows.Forms.TextBox();
            this.tbSezioneF = new System.Windows.Forms.TextBox();
            this.tbCognomeF = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.saveUser_btn = new System.Windows.Forms.Button();
            this.tbProvinciaNascita = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbCapNascita = new System.Windows.Forms.TextBox();
            this.tbComuneNascita = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
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
            this.label7 = new System.Windows.Forms.Label();
            this.tbSezione = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addUser_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.editUser_btn = new System.Windows.Forms.Button();
            this.pdf1 = new System.Windows.Forms.Button();
            this.deleteUser_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tbX = new System.Windows.Forms.TextBox();
            this.tbY = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pdf2
            // 
            this.pdf2.Location = new System.Drawing.Point(1085, 752);
            this.pdf2.Margin = new System.Windows.Forms.Padding(4);
            this.pdf2.Name = "pdf2";
            this.pdf2.Size = new System.Drawing.Size(207, 28);
            this.pdf2.TabIndex = 0;
            this.pdf2.Text = "Create Pdf Assicurazione";
            this.pdf2.UseVisualStyleBackColor = true;
            this.pdf2.Click += new System.EventHandler(this.pdf2_Click);
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(9, 63);
            this.tbNome.Margin = new System.Windows.Forms.Padding(4);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(371, 22);
            this.tbNome.TabIndex = 1;
            // 
            // tbCognome
            // 
            this.tbCognome.Location = new System.Drawing.Point(9, 111);
            this.tbCognome.Margin = new System.Windows.Forms.Padding(4);
            this.tbCognome.Name = "tbCognome";
            this.tbCognome.Size = new System.Drawing.Size(371, 22);
            this.tbCognome.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cognome:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbY);
            this.panel1.Controls.Add(this.tbX);
            this.panel1.Controls.Add(this.cbScaduti);
            this.panel1.Controls.Add(this.tbDataPagamentoF);
            this.panel1.Controls.Add(this.tbDataPagamento);
            this.panel1.Controls.Add(this.tbDataRilascioPortoArmiF);
            this.panel1.Controls.Add(this.tbDataRilascioPortoArmi);
            this.panel1.Controls.Add(this.tbDataDiNascitaF);
            this.panel1.Controls.Add(this.tbDataDiNascita);
            this.panel1.Controls.Add(this.lbl_Uid);
            this.panel1.Controls.Add(this.pulisci_filtri_btn);
            this.panel1.Controls.Add(this.tbMailF);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.tbMail);
            this.panel1.Controls.Add(this.tbCellulareF);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.tbCellulare);
            this.panel1.Controls.Add(this.applica_filtri_btn);
            this.panel1.Controls.Add(this.tbTelefonoF);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.tbTelefono);
            this.panel1.Controls.Add(this.annullla_btn);
            this.panel1.Controls.Add(this.tbNomeF);
            this.panel1.Controls.Add(this.tbProvinciaNascitaF);
            this.panel1.Controls.Add(this.tbCapNascitaF);
            this.panel1.Controls.Add(this.tbComuneNascitaF);
            this.panel1.Controls.Add(this.tbProvinciaResistenzaF);
            this.panel1.Controls.Add(this.tbCapResistenzaF);
            this.panel1.Controls.Add(this.tbCodiceFiscaleF);
            this.panel1.Controls.Add(this.tbNumeroPortoArmiF);
            this.panel1.Controls.Add(this.tbIndirizzoResistenzaF);
            this.panel1.Controls.Add(this.tbComuneResidenzaF);
            this.panel1.Controls.Add(this.tbTipoF);
            this.panel1.Controls.Add(this.tbNumeroF);
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
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tbSezione);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbNome);
            this.panel1.Controls.Add(this.tbCognome);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1348, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 763);
            this.panel1.TabIndex = 9;
            // 
            // cbScaduti
            // 
            this.cbScaduti.AutoSize = true;
            this.cbScaduti.Location = new System.Drawing.Point(206, 234);
            this.cbScaduti.Name = "cbScaduti";
            this.cbScaduti.Size = new System.Drawing.Size(151, 20);
            this.cbScaduti.TabIndex = 77;
            this.cbScaduti.Text = "Mostra date scadute";
            this.cbScaduti.UseVisualStyleBackColor = true;
            // 
            // tbDataPagamentoF
            // 
            this.tbDataPagamentoF.Location = new System.Drawing.Point(9, 591);
            this.tbDataPagamentoF.Margin = new System.Windows.Forms.Padding(4);
            this.tbDataPagamentoF.Name = "tbDataPagamentoF";
            this.tbDataPagamentoF.Size = new System.Drawing.Size(176, 22);
            this.tbDataPagamentoF.TabIndex = 32;
            // 
            // tbDataPagamento
            // 
            this.tbDataPagamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tbDataPagamento.Location = new System.Drawing.Point(9, 591);
            this.tbDataPagamento.Margin = new System.Windows.Forms.Padding(4);
            this.tbDataPagamento.Name = "tbDataPagamento";
            this.tbDataPagamento.Size = new System.Drawing.Size(176, 22);
            this.tbDataPagamento.TabIndex = 31;
            this.tbDataPagamento.Value = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            // 
            // tbDataRilascioPortoArmiF
            // 
            this.tbDataRilascioPortoArmiF.Location = new System.Drawing.Point(204, 207);
            this.tbDataRilascioPortoArmiF.Margin = new System.Windows.Forms.Padding(4);
            this.tbDataRilascioPortoArmiF.Name = "tbDataRilascioPortoArmiF";
            this.tbDataRilascioPortoArmiF.Size = new System.Drawing.Size(176, 22);
            this.tbDataRilascioPortoArmiF.TabIndex = 10;
            // 
            // tbDataRilascioPortoArmi
            // 
            this.tbDataRilascioPortoArmi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tbDataRilascioPortoArmi.Location = new System.Drawing.Point(204, 207);
            this.tbDataRilascioPortoArmi.Margin = new System.Windows.Forms.Padding(4);
            this.tbDataRilascioPortoArmi.Name = "tbDataRilascioPortoArmi";
            this.tbDataRilascioPortoArmi.Size = new System.Drawing.Size(176, 22);
            this.tbDataRilascioPortoArmi.TabIndex = 9;
            this.tbDataRilascioPortoArmi.Value = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            // 
            // tbDataDiNascitaF
            // 
            this.tbDataDiNascitaF.Location = new System.Drawing.Point(9, 207);
            this.tbDataDiNascitaF.Margin = new System.Windows.Forms.Padding(4);
            this.tbDataDiNascitaF.Name = "tbDataDiNascitaF";
            this.tbDataDiNascitaF.Size = new System.Drawing.Size(176, 22);
            this.tbDataDiNascitaF.TabIndex = 8;
            // 
            // tbDataDiNascita
            // 
            this.tbDataDiNascita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tbDataDiNascita.Location = new System.Drawing.Point(9, 207);
            this.tbDataDiNascita.Margin = new System.Windows.Forms.Padding(4);
            this.tbDataDiNascita.Name = "tbDataDiNascita";
            this.tbDataDiNascita.Size = new System.Drawing.Size(176, 22);
            this.tbDataDiNascita.TabIndex = 7;
            this.tbDataDiNascita.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // lbl_Uid
            // 
            this.lbl_Uid.AutoSize = true;
            this.lbl_Uid.Location = new System.Drawing.Point(89, 23);
            this.lbl_Uid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Uid.Name = "lbl_Uid";
            this.lbl_Uid.Size = new System.Drawing.Size(25, 16);
            this.lbl_Uid.TabIndex = 76;
            this.lbl_Uid.Text = "uid";
            this.lbl_Uid.Visible = false;
            // 
            // pulisci_filtri_btn
            // 
            this.pulisci_filtri_btn.Location = new System.Drawing.Point(9, 721);
            this.pulisci_filtri_btn.Margin = new System.Windows.Forms.Padding(4);
            this.pulisci_filtri_btn.Name = "pulisci_filtri_btn";
            this.pulisci_filtri_btn.Size = new System.Drawing.Size(175, 28);
            this.pulisci_filtri_btn.TabIndex = 75;
            this.pulisci_filtri_btn.Text = "Pulisci filtri";
            this.pulisci_filtri_btn.UseVisualStyleBackColor = true;
            this.pulisci_filtri_btn.Click += new System.EventHandler(this.pulisci_filtri_btn_Click);
            // 
            // tbMailF
            // 
            this.tbMailF.Location = new System.Drawing.Point(8, 684);
            this.tbMailF.Margin = new System.Windows.Forms.Padding(4);
            this.tbMailF.Name = "tbMailF";
            this.tbMailF.Size = new System.Drawing.Size(373, 22);
            this.tbMailF.TabIndex = 42;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 665);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 16);
            this.label21.TabIndex = 73;
            this.label21.Text = "Mail:";
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(9, 684);
            this.tbMail.Margin = new System.Windows.Forms.Padding(4);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(369, 22);
            this.tbMail.TabIndex = 41;
            // 
            // tbCellulareF
            // 
            this.tbCellulareF.Location = new System.Drawing.Point(9, 639);
            this.tbCellulareF.Margin = new System.Windows.Forms.Padding(4);
            this.tbCellulareF.Name = "tbCellulareF";
            this.tbCellulareF.Size = new System.Drawing.Size(175, 22);
            this.tbCellulareF.TabIndex = 40;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(4, 620);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(124, 16);
            this.label22.TabIndex = 70;
            this.label22.Text = "Cellulare whatsapp:";
            // 
            // tbCellulare
            // 
            this.tbCellulare.Location = new System.Drawing.Point(9, 639);
            this.tbCellulare.Margin = new System.Windows.Forms.Padding(4);
            this.tbCellulare.Name = "tbCellulare";
            this.tbCellulare.Size = new System.Drawing.Size(175, 22);
            this.tbCellulare.TabIndex = 39;
            // 
            // applica_filtri_btn
            // 
            this.applica_filtri_btn.Location = new System.Drawing.Point(204, 721);
            this.applica_filtri_btn.Margin = new System.Windows.Forms.Padding(4);
            this.applica_filtri_btn.Name = "applica_filtri_btn";
            this.applica_filtri_btn.Size = new System.Drawing.Size(175, 28);
            this.applica_filtri_btn.TabIndex = 15;
            this.applica_filtri_btn.Text = "Applica filtri";
            this.applica_filtri_btn.UseVisualStyleBackColor = true;
            this.applica_filtri_btn.Click += new System.EventHandler(this.filtri_btn_Click);
            // 
            // tbTelefonoF
            // 
            this.tbTelefonoF.Location = new System.Drawing.Point(204, 639);
            this.tbTelefonoF.Margin = new System.Windows.Forms.Padding(4);
            this.tbTelefonoF.Name = "tbTelefonoF";
            this.tbTelefonoF.Size = new System.Drawing.Size(175, 22);
            this.tbTelefonoF.TabIndex = 38;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(199, 619);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(64, 16);
            this.label20.TabIndex = 67;
            this.label20.Text = "Telefono:";
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(204, 639);
            this.tbTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(175, 22);
            this.tbTelefono.TabIndex = 37;
            // 
            // annullla_btn
            // 
            this.annullla_btn.Location = new System.Drawing.Point(8, 721);
            this.annullla_btn.Margin = new System.Windows.Forms.Padding(4);
            this.annullla_btn.Name = "annullla_btn";
            this.annullla_btn.Size = new System.Drawing.Size(177, 28);
            this.annullla_btn.TabIndex = 65;
            this.annullla_btn.Text = "Annulla";
            this.annullla_btn.UseVisualStyleBackColor = true;
            this.annullla_btn.Visible = false;
            this.annullla_btn.Click += new System.EventHandler(this.annullla_btn_Click);
            // 
            // tbNomeF
            // 
            this.tbNomeF.Location = new System.Drawing.Point(9, 63);
            this.tbNomeF.Margin = new System.Windows.Forms.Padding(4);
            this.tbNomeF.Name = "tbNomeF";
            this.tbNomeF.Size = new System.Drawing.Size(371, 22);
            this.tbNomeF.TabIndex = 2;
            // 
            // tbProvinciaNascitaF
            // 
            this.tbProvinciaNascitaF.Location = new System.Drawing.Point(9, 351);
            this.tbProvinciaNascitaF.Margin = new System.Windows.Forms.Padding(4);
            this.tbProvinciaNascitaF.Name = "tbProvinciaNascitaF";
            this.tbProvinciaNascitaF.Size = new System.Drawing.Size(371, 22);
            this.tbProvinciaNascitaF.TabIndex = 18;
            // 
            // tbCapNascitaF
            // 
            this.tbCapNascitaF.Location = new System.Drawing.Point(9, 303);
            this.tbCapNascitaF.Margin = new System.Windows.Forms.Padding(4);
            this.tbCapNascitaF.Name = "tbCapNascitaF";
            this.tbCapNascitaF.Size = new System.Drawing.Size(176, 22);
            this.tbCapNascitaF.TabIndex = 14;
            // 
            // tbComuneNascitaF
            // 
            this.tbComuneNascitaF.Location = new System.Drawing.Point(203, 303);
            this.tbComuneNascitaF.Margin = new System.Windows.Forms.Padding(4);
            this.tbComuneNascitaF.Name = "tbComuneNascitaF";
            this.tbComuneNascitaF.Size = new System.Drawing.Size(177, 22);
            this.tbComuneNascitaF.TabIndex = 16;
            // 
            // tbProvinciaResistenzaF
            // 
            this.tbProvinciaResistenzaF.Location = new System.Drawing.Point(9, 495);
            this.tbProvinciaResistenzaF.Margin = new System.Windows.Forms.Padding(4);
            this.tbProvinciaResistenzaF.Name = "tbProvinciaResistenzaF";
            this.tbProvinciaResistenzaF.Size = new System.Drawing.Size(371, 22);
            this.tbProvinciaResistenzaF.TabIndex = 26;
            // 
            // tbCapResistenzaF
            // 
            this.tbCapResistenzaF.Location = new System.Drawing.Point(9, 447);
            this.tbCapResistenzaF.Margin = new System.Windows.Forms.Padding(4);
            this.tbCapResistenzaF.Name = "tbCapResistenzaF";
            this.tbCapResistenzaF.Size = new System.Drawing.Size(176, 22);
            this.tbCapResistenzaF.TabIndex = 22;
            // 
            // tbCodiceFiscaleF
            // 
            this.tbCodiceFiscaleF.Location = new System.Drawing.Point(9, 159);
            this.tbCodiceFiscaleF.Margin = new System.Windows.Forms.Padding(4);
            this.tbCodiceFiscaleF.Name = "tbCodiceFiscaleF";
            this.tbCodiceFiscaleF.Size = new System.Drawing.Size(371, 22);
            this.tbCodiceFiscaleF.TabIndex = 6;
            // 
            // tbNumeroPortoArmiF
            // 
            this.tbNumeroPortoArmiF.Location = new System.Drawing.Point(9, 255);
            this.tbNumeroPortoArmiF.Margin = new System.Windows.Forms.Padding(4);
            this.tbNumeroPortoArmiF.Name = "tbNumeroPortoArmiF";
            this.tbNumeroPortoArmiF.Size = new System.Drawing.Size(371, 22);
            this.tbNumeroPortoArmiF.TabIndex = 12;
            // 
            // tbIndirizzoResistenzaF
            // 
            this.tbIndirizzoResistenzaF.Location = new System.Drawing.Point(9, 399);
            this.tbIndirizzoResistenzaF.Margin = new System.Windows.Forms.Padding(4);
            this.tbIndirizzoResistenzaF.Name = "tbIndirizzoResistenzaF";
            this.tbIndirizzoResistenzaF.Size = new System.Drawing.Size(371, 22);
            this.tbIndirizzoResistenzaF.TabIndex = 20;
            // 
            // tbComuneResidenzaF
            // 
            this.tbComuneResidenzaF.Location = new System.Drawing.Point(203, 447);
            this.tbComuneResidenzaF.Margin = new System.Windows.Forms.Padding(4);
            this.tbComuneResidenzaF.Name = "tbComuneResidenzaF";
            this.tbComuneResidenzaF.Size = new System.Drawing.Size(177, 22);
            this.tbComuneResidenzaF.TabIndex = 24;
            // 
            // tbTipoF
            // 
            this.tbTipoF.Location = new System.Drawing.Point(206, 591);
            this.tbTipoF.Margin = new System.Windows.Forms.Padding(4);
            this.tbTipoF.Name = "tbTipoF";
            this.tbTipoF.Size = new System.Drawing.Size(175, 22);
            this.tbTipoF.TabIndex = 36;
            // 
            // tbNumeroF
            // 
            this.tbNumeroF.Location = new System.Drawing.Point(204, 543);
            this.tbNumeroF.Margin = new System.Windows.Forms.Padding(4);
            this.tbNumeroF.Name = "tbNumeroF";
            this.tbNumeroF.Size = new System.Drawing.Size(177, 22);
            this.tbNumeroF.TabIndex = 34;
            // 
            // tbSezioneF
            // 
            this.tbSezioneF.Location = new System.Drawing.Point(9, 543);
            this.tbSezioneF.Margin = new System.Windows.Forms.Padding(4);
            this.tbSezioneF.Name = "tbSezioneF";
            this.tbSezioneF.Size = new System.Drawing.Size(176, 22);
            this.tbSezioneF.TabIndex = 28;
            // 
            // tbCognomeF
            // 
            this.tbCognomeF.Location = new System.Drawing.Point(9, 111);
            this.tbCognomeF.Margin = new System.Windows.Forms.Padding(4);
            this.tbCognomeF.Name = "tbCognomeF";
            this.tbCognomeF.Size = new System.Drawing.Size(371, 22);
            this.tbCognomeF.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 571);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 45;
            this.label6.Text = "Tipo:";
            // 
            // saveUser_btn
            // 
            this.saveUser_btn.Location = new System.Drawing.Point(204, 721);
            this.saveUser_btn.Margin = new System.Windows.Forms.Padding(4);
            this.saveUser_btn.Name = "saveUser_btn";
            this.saveUser_btn.Size = new System.Drawing.Size(175, 28);
            this.saveUser_btn.TabIndex = 13;
            this.saveUser_btn.Text = "Salva";
            this.saveUser_btn.UseVisualStyleBackColor = true;
            this.saveUser_btn.Visible = false;
            this.saveUser_btn.Click += new System.EventHandler(this.saveUser_btn_Click);
            // 
            // tbProvinciaNascita
            // 
            this.tbProvinciaNascita.Location = new System.Drawing.Point(9, 351);
            this.tbProvinciaNascita.Margin = new System.Windows.Forms.Padding(4);
            this.tbProvinciaNascita.Name = "tbProvinciaNascita";
            this.tbProvinciaNascita.Size = new System.Drawing.Size(371, 22);
            this.tbProvinciaNascita.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 331);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 16);
            this.label12.TabIndex = 44;
            this.label12.Text = "Provincia nascita:";
            // 
            // tbCapNascita
            // 
            this.tbCapNascita.Location = new System.Drawing.Point(9, 303);
            this.tbCapNascita.Margin = new System.Windows.Forms.Padding(4);
            this.tbCapNascita.Name = "tbCapNascita";
            this.tbCapNascita.Size = new System.Drawing.Size(176, 22);
            this.tbCapNascita.TabIndex = 13;
            // 
            // tbComuneNascita
            // 
            this.tbComuneNascita.Location = new System.Drawing.Point(203, 303);
            this.tbComuneNascita.Margin = new System.Windows.Forms.Padding(4);
            this.tbComuneNascita.Name = "tbComuneNascita";
            this.tbComuneNascita.Size = new System.Drawing.Size(177, 22);
            this.tbComuneNascita.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(199, 283);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 16);
            this.label13.TabIndex = 42;
            this.label13.Text = "Comune nascita:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 283);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 16);
            this.label14.TabIndex = 41;
            this.label14.Text = "CAP nascita:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(200, 187);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(173, 16);
            this.label19.TabIndex = 38;
            this.label19.Text = "Data di rilascio porto d\'armi:";
            // 
            // tbProvinciaResistenza
            // 
            this.tbProvinciaResistenza.Location = new System.Drawing.Point(9, 495);
            this.tbProvinciaResistenza.Margin = new System.Windows.Forms.Padding(4);
            this.tbProvinciaResistenza.Name = "tbProvinciaResistenza";
            this.tbProvinciaResistenza.Size = new System.Drawing.Size(371, 22);
            this.tbProvinciaResistenza.TabIndex = 25;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(5, 475);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(128, 16);
            this.label18.TabIndex = 36;
            this.label18.Text = "Provincia residenza:";
            // 
            // tbCapResistenza
            // 
            this.tbCapResistenza.Location = new System.Drawing.Point(9, 447);
            this.tbCapResistenza.Margin = new System.Windows.Forms.Padding(4);
            this.tbCapResistenza.Name = "tbCapResistenza";
            this.tbCapResistenza.Size = new System.Drawing.Size(176, 22);
            this.tbCapResistenza.TabIndex = 21;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(5, 427);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 16);
            this.label17.TabIndex = 34;
            this.label17.Text = "CAP residenza:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 14);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 29);
            this.label10.TabIndex = 14;
            this.label10.Text = "Filtri";
            // 
            // tbCodiceFiscale
            // 
            this.tbCodiceFiscale.Location = new System.Drawing.Point(9, 159);
            this.tbCodiceFiscale.Margin = new System.Windows.Forms.Padding(4);
            this.tbCodiceFiscale.Name = "tbCodiceFiscale";
            this.tbCodiceFiscale.Size = new System.Drawing.Size(371, 22);
            this.tbCodiceFiscale.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 139);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 16);
            this.label9.TabIndex = 32;
            this.label9.Text = "Codice fiscale:";
            // 
            // tbNumeroPortoArmi
            // 
            this.tbNumeroPortoArmi.Location = new System.Drawing.Point(9, 255);
            this.tbNumeroPortoArmi.Margin = new System.Windows.Forms.Padding(4);
            this.tbNumeroPortoArmi.Name = "tbNumeroPortoArmi";
            this.tbNumeroPortoArmi.Size = new System.Drawing.Size(371, 22);
            this.tbNumeroPortoArmi.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 235);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 16);
            this.label11.TabIndex = 30;
            this.label11.Text = "Numero porto d\'armi:";
            // 
            // tbIndirizzoResistenza
            // 
            this.tbIndirizzoResistenza.Location = new System.Drawing.Point(9, 399);
            this.tbIndirizzoResistenza.Margin = new System.Windows.Forms.Padding(4);
            this.tbIndirizzoResistenza.Name = "tbIndirizzoResistenza";
            this.tbIndirizzoResistenza.Size = new System.Drawing.Size(371, 22);
            this.tbIndirizzoResistenza.TabIndex = 19;
            // 
            // tbComuneResidenza
            // 
            this.tbComuneResidenza.Location = new System.Drawing.Point(203, 447);
            this.tbComuneResidenza.Margin = new System.Windows.Forms.Padding(4);
            this.tbComuneResidenza.Name = "tbComuneResidenza";
            this.tbComuneResidenza.Size = new System.Drawing.Size(177, 22);
            this.tbComuneResidenza.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(199, 427);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(122, 16);
            this.label15.TabIndex = 22;
            this.label15.Text = "Comune residenza:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(5, 379);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(120, 16);
            this.label16.TabIndex = 21;
            this.label16.Text = "Indirizzo residenza:";
            // 
            // tbTipo
            // 
            this.tbTipo.Location = new System.Drawing.Point(206, 591);
            this.tbTipo.Margin = new System.Windows.Forms.Padding(4);
            this.tbTipo.Name = "tbTipo";
            this.tbTipo.Size = new System.Drawing.Size(175, 22);
            this.tbTipo.TabIndex = 35;
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(204, 543);
            this.tbNumero.Margin = new System.Windows.Forms.Padding(4);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(177, 22);
            this.tbNumero.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 523);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Numero:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 571);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Data pagamento:";
            // 
            // tbSezione
            // 
            this.tbSezione.Location = new System.Drawing.Point(9, 543);
            this.tbSezione.Margin = new System.Windows.Forms.Padding(4);
            this.tbSezione.Name = "tbSezione";
            this.tbSezione.Size = new System.Drawing.Size(176, 22);
            this.tbSezione.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 523);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sezione:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 187);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data di nascita:";
            // 
            // addUser_btn
            // 
            this.addUser_btn.Location = new System.Drawing.Point(198, 752);
            this.addUser_btn.Margin = new System.Windows.Forms.Padding(4);
            this.addUser_btn.Name = "addUser_btn";
            this.addUser_btn.Size = new System.Drawing.Size(207, 28);
            this.addUser_btn.TabIndex = 10;
            this.addUser_btn.Text = "Crea utente";
            this.addUser_btn.UseVisualStyleBackColor = true;
            this.addUser_btn.Click += new System.EventHandler(this.addUser_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1316, 727);
            this.dataGridView1.TabIndex = 11;
            // 
            // editUser_btn
            // 
            this.editUser_btn.Location = new System.Drawing.Point(412, 752);
            this.editUser_btn.Margin = new System.Windows.Forms.Padding(4);
            this.editUser_btn.Name = "editUser_btn";
            this.editUser_btn.Size = new System.Drawing.Size(193, 28);
            this.editUser_btn.TabIndex = 12;
            this.editUser_btn.Text = "Modifica utente";
            this.editUser_btn.UseVisualStyleBackColor = true;
            this.editUser_btn.Click += new System.EventHandler(this.editUser_btn_Click);
            // 
            // pdf1
            // 
            this.pdf1.Location = new System.Drawing.Point(830, 752);
            this.pdf1.Margin = new System.Windows.Forms.Padding(4);
            this.pdf1.Name = "pdf1";
            this.pdf1.Size = new System.Drawing.Size(207, 28);
            this.pdf1.TabIndex = 14;
            this.pdf1.Text = "Create Pdf 173";
            this.pdf1.UseVisualStyleBackColor = true;
            this.pdf1.Click += new System.EventHandler(this.pdf1_Click);
            // 
            // deleteUser_btn
            // 
            this.deleteUser_btn.Location = new System.Drawing.Point(615, 752);
            this.deleteUser_btn.Margin = new System.Windows.Forms.Padding(4);
            this.deleteUser_btn.Name = "deleteUser_btn";
            this.deleteUser_btn.Size = new System.Drawing.Size(207, 28);
            this.deleteUser_btn.TabIndex = 15;
            this.deleteUser_btn.Text = "Elimina utente";
            this.deleteUser_btn.UseVisualStyleBackColor = true;
            this.deleteUser_btn.Click += new System.EventHandler(this.deleteUser_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1045, 752);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 28);
            this.button1.TabIndex = 16;
            this.button1.Text = "B";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1300, 752);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 28);
            this.button2.TabIndex = 17;
            this.button2.Text = "B";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 752);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 28);
            this.button3.TabIndex = 18;
            this.button3.Text = "Esportazione Excel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(183, 21);
            this.tbX.Margin = new System.Windows.Forms.Padding(4);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(95, 22);
            this.tbX.TabIndex = 78;
            this.tbX.TextChanged += new System.EventHandler(this.tbX_TextChanged);
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(286, 21);
            this.tbY.Margin = new System.Windows.Forms.Padding(4);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(95, 22);
            this.tbY.TabIndex = 79;
            this.tbY.TextChanged += new System.EventHandler(this.tbY_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1764, 793);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deleteUser_btn);
            this.Controls.Add(this.pdf1);
            this.Controls.Add(this.editUser_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addUser_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pdf2);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label label7;
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
        private System.Windows.Forms.TextBox tbDataPagamentoF;
        private System.Windows.Forms.TextBox tbDataDiNascitaF;
        private System.Windows.Forms.TextBox tbSezioneF;
        private System.Windows.Forms.TextBox tbCognomeF;
        private System.Windows.Forms.Button annullla_btn;
        private System.Windows.Forms.Button applica_filtri_btn;
        private System.Windows.Forms.TextBox tbMailF;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.TextBox tbCellulareF;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tbCellulare;
        private System.Windows.Forms.TextBox tbTelefonoF;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.Button pulisci_filtri_btn;
        private System.Windows.Forms.Label lbl_Uid;
        private System.Windows.Forms.Button deleteUser_btn;
        private System.Windows.Forms.DateTimePicker tbDataDiNascita;
        private System.Windows.Forms.DateTimePicker tbDataPagamento;
        private System.Windows.Forms.DateTimePicker tbDataRilascioPortoArmi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox cbScaduti;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.TextBox tbX;
    }
}

