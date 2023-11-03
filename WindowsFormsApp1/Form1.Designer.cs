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
            this.btnCreatePdf = new System.Windows.Forms.Button();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbCognome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbCodiceFiscale = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbProvinciaNascita = new System.Windows.Forms.TextBox();
            this.tbNumeroPortoArmi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbCap = new System.Windows.Forms.TextBox();
            this.tbComuneNascita = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbIndirizzoResistenza = new System.Windows.Forms.TextBox();
            this.tbComuneResidenza = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbTipo = new System.Windows.Forms.TextBox();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbProvincia = new System.Windows.Forms.TextBox();
            this.tbDataPag = new System.Windows.Forms.TextBox();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreatePdf
            // 
            this.btnCreatePdf.Location = new System.Drawing.Point(768, 396);
            this.btnCreatePdf.Name = "btnCreatePdf";
            this.btnCreatePdf.Size = new System.Drawing.Size(155, 23);
            this.btnCreatePdf.TabIndex = 0;
            this.btnCreatePdf.Text = "Create Pdf";
            this.btnCreatePdf.UseVisualStyleBackColor = true;
            this.btnCreatePdf.Click += new System.EventHandler(this.btnCreatePdf_Click);
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(21, 45);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(121, 20);
            this.tbNome.TabIndex = 1;
            // 
            // tbCognome
            // 
            this.tbCognome.Location = new System.Drawing.Point(148, 45);
            this.tbCognome.Name = "tbCognome";
            this.tbCognome.Size = new System.Drawing.Size(121, 20);
            this.tbCognome.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cognome:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbCodiceFiscale);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tbProvinciaNascita);
            this.panel1.Controls.Add(this.tbNumeroPortoArmi);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.tbCap);
            this.panel1.Controls.Add(this.tbComuneNascita);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.tbIndirizzoResistenza);
            this.panel1.Controls.Add(this.tbComuneResidenza);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.tbTipo);
            this.panel1.Controls.Add(this.tbNumero);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbProvincia);
            this.panel1.Controls.Add(this.tbDataPag);
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
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 378);
            this.panel1.TabIndex = 9;
            // 
            // tbCodiceFiscale
            // 
            this.tbCodiceFiscale.Location = new System.Drawing.Point(21, 84);
            this.tbCodiceFiscale.Name = "tbCodiceFiscale";
            this.tbCodiceFiscale.Size = new System.Drawing.Size(248, 20);
            this.tbCodiceFiscale.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Codice fiscale:";
            // 
            // tbProvinciaNascita
            // 
            this.tbProvinciaNascita.Location = new System.Drawing.Point(21, 318);
            this.tbProvinciaNascita.Name = "tbProvinciaNascita";
            this.tbProvinciaNascita.Size = new System.Drawing.Size(121, 20);
            this.tbProvinciaNascita.TabIndex = 27;
            // 
            // tbNumeroPortoArmi
            // 
            this.tbNumeroPortoArmi.Location = new System.Drawing.Point(148, 318);
            this.tbNumeroPortoArmi.Name = "tbNumeroPortoArmi";
            this.tbNumeroPortoArmi.Size = new System.Drawing.Size(121, 20);
            this.tbNumeroPortoArmi.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(145, 302);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Numero porto d\'armi:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 302);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Provincia nascita:";
            // 
            // tbCap
            // 
            this.tbCap.Location = new System.Drawing.Point(21, 279);
            this.tbCap.Name = "tbCap";
            this.tbCap.Size = new System.Drawing.Size(121, 20);
            this.tbCap.TabIndex = 23;
            // 
            // tbComuneNascita
            // 
            this.tbComuneNascita.Location = new System.Drawing.Point(148, 279);
            this.tbComuneNascita.Name = "tbComuneNascita";
            this.tbComuneNascita.Size = new System.Drawing.Size(121, 20);
            this.tbComuneNascita.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(145, 263);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Comune nascita:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 263);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "CAP residenza:";
            // 
            // tbIndirizzoResistenza
            // 
            this.tbIndirizzoResistenza.Location = new System.Drawing.Point(21, 240);
            this.tbIndirizzoResistenza.Name = "tbIndirizzoResistenza";
            this.tbIndirizzoResistenza.Size = new System.Drawing.Size(121, 20);
            this.tbIndirizzoResistenza.TabIndex = 19;
            // 
            // tbComuneResidenza
            // 
            this.tbComuneResidenza.Location = new System.Drawing.Point(148, 240);
            this.tbComuneResidenza.Name = "tbComuneResidenza";
            this.tbComuneResidenza.Size = new System.Drawing.Size(121, 20);
            this.tbComuneResidenza.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(145, 224);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "Comune residenza:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 224);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 13);
            this.label16.TabIndex = 21;
            this.label16.Text = "Indirizzo residenza:";
            // 
            // tbTipo
            // 
            this.tbTipo.Location = new System.Drawing.Point(21, 201);
            this.tbTipo.Name = "tbTipo";
            this.tbTipo.Size = new System.Drawing.Size(121, 20);
            this.tbTipo.TabIndex = 15;
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(148, 201);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(121, 20);
            this.tbNumero.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Numero:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tipo:";
            // 
            // tbProvincia
            // 
            this.tbProvincia.Location = new System.Drawing.Point(21, 162);
            this.tbProvincia.Name = "tbProvincia";
            this.tbProvincia.Size = new System.Drawing.Size(121, 20);
            this.tbProvincia.TabIndex = 11;
            // 
            // tbDataPag
            // 
            this.tbDataPag.Location = new System.Drawing.Point(148, 162);
            this.tbDataPag.Name = "tbDataPag";
            this.tbDataPag.Size = new System.Drawing.Size(121, 20);
            this.tbDataPag.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(145, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Data pag.:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Provincia:";
            // 
            // tbDataDiNascita
            // 
            this.tbDataDiNascita.Location = new System.Drawing.Point(21, 123);
            this.tbDataDiNascita.Name = "tbDataDiNascita";
            this.tbDataDiNascita.Size = new System.Drawing.Size(121, 20);
            this.tbDataDiNascita.TabIndex = 7;
            // 
            // tbSezione
            // 
            this.tbSezione.Location = new System.Drawing.Point(148, 123);
            this.tbSezione.Name = "tbSezione";
            this.tbSezione.Size = new System.Drawing.Size(121, 20);
            this.tbSezione.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sezione:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data di nascita:";
            // 
            // addUser_btn
            // 
            this.addUser_btn.Location = new System.Drawing.Point(603, 396);
            this.addUser_btn.Name = "addUser_btn";
            this.addUser_btn.Size = new System.Drawing.Size(155, 23);
            this.addUser_btn.TabIndex = 10;
            this.addUser_btn.Text = "Add User";
            this.addUser_btn.UseVisualStyleBackColor = true;
            this.addUser_btn.Click += new System.EventHandler(this.addUser_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(305, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(618, 378);
            this.dataGridView1.TabIndex = 11;
            // 
            // editUser_btn
            // 
            this.editUser_btn.Location = new System.Drawing.Point(438, 396);
            this.editUser_btn.Name = "editUser_btn";
            this.editUser_btn.Size = new System.Drawing.Size(159, 23);
            this.editUser_btn.TabIndex = 12;
            this.editUser_btn.Text = "Edit User";
            this.editUser_btn.UseVisualStyleBackColor = true;
            this.editUser_btn.Click += new System.EventHandler(this.editUser_btn_Click);
            // 
            // saveUser_btn
            // 
            this.saveUser_btn.Location = new System.Drawing.Point(603, 396);
            this.saveUser_btn.Name = "saveUser_btn";
            this.saveUser_btn.Size = new System.Drawing.Size(159, 23);
            this.saveUser_btn.TabIndex = 13;
            this.saveUser_btn.Text = "Save User";
            this.saveUser_btn.UseVisualStyleBackColor = true;
            this.saveUser_btn.Visible = false;
            this.saveUser_btn.Click += new System.EventHandler(this.saveUser_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 431);
            this.Controls.Add(this.saveUser_btn);
            this.Controls.Add(this.editUser_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addUser_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCreatePdf);
            this.Name = "Form1";
            this.Text = "Form1";
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

        private System.Windows.Forms.Button btnCreatePdf;
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbProvincia;
        private System.Windows.Forms.TextBox tbDataPag;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbDataDiNascita;
        private System.Windows.Forms.TextBox tbSezione;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbProvinciaNascita;
        private System.Windows.Forms.TextBox tbNumeroPortoArmi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbCap;
        private System.Windows.Forms.TextBox tbComuneNascita;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbIndirizzoResistenza;
        private System.Windows.Forms.TextBox tbComuneResidenza;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbCodiceFiscale;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button editUser_btn;
        private System.Windows.Forms.Button saveUser_btn;
    }
}

