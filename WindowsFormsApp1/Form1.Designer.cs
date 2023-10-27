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
            this.name_tb = new System.Windows.Forms.TextBox();
            this.surname_tb = new System.Windows.Forms.TextBox();
            this.taxCode_tb = new System.Windows.Forms.TextBox();
            this.phone_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreatePdf
            // 
            this.btnCreatePdf.Location = new System.Drawing.Point(578, 293);
            this.btnCreatePdf.Name = "btnCreatePdf";
            this.btnCreatePdf.Size = new System.Drawing.Size(164, 23);
            this.btnCreatePdf.TabIndex = 0;
            this.btnCreatePdf.Text = "Create Pdf";
            this.btnCreatePdf.UseVisualStyleBackColor = true;
            this.btnCreatePdf.Click += new System.EventHandler(this.btnCreatePdf_Click);
            // 
            // name_tb
            // 
            this.name_tb.Location = new System.Drawing.Point(3, 35);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(100, 20);
            this.name_tb.TabIndex = 1;
            // 
            // surname_tb
            // 
            this.surname_tb.Location = new System.Drawing.Point(3, 93);
            this.surname_tb.Name = "surname_tb";
            this.surname_tb.Size = new System.Drawing.Size(100, 20);
            this.surname_tb.TabIndex = 2;
            // 
            // taxCode_tb
            // 
            this.taxCode_tb.Location = new System.Drawing.Point(3, 159);
            this.taxCode_tb.Name = "taxCode_tb";
            this.taxCode_tb.Size = new System.Drawing.Size(100, 20);
            this.taxCode_tb.TabIndex = 3;
            // 
            // phone_tb
            // 
            this.phone_tb.Location = new System.Drawing.Point(3, 225);
            this.phone_tb.Name = "phone_tb";
            this.phone_tb.Size = new System.Drawing.Size(100, 20);
            this.phone_tb.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cognome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Codice Fiscale:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Telefono:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.name_tb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.surname_tb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.taxCode_tb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.phone_tb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 271);
            this.panel1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(408, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add User";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(249, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(493, 271);
            this.dataGridView1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 322);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.TextBox surname_tb;
        private System.Windows.Forms.TextBox taxCode_tb;
        private System.Windows.Forms.TextBox phone_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

