using System;

namespace dto
{
    public class User
    {
        public Guid Uid { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string CodiceFiscale { get; set; }
        public DateTime? Data_nascita { get; set; }
        public DateTime? Data_rilascio_porto_armi { get; set; }
        public string Numero_porto_armi { get; set; }
        public string Cap_nascita { get; set; }
        public string Comune_nascita { get; set; }
        public string Provincia_nascita { get; set; }
        public string Indirizzo_residenza { get; set; }
        public string Cap_residenza { get; set; }
        public string Comune_residenza { get; set; }
        public string Provincia_residenza { get; set; }
        public string Sezione { get; set; }
        public DateTime? Data_pagamento { get; set; }
        public int Numero { get; set; }
        public string Tipo { get; set; }
        public string Telefono { get; set; }
        public string Cellulare_whatsapp { get; set; }
        public string Mail { get; set; }

        public void SetUser(Guid uid, string nome, string cognome, string codiceFiscale, DateTime? data_nascita, DateTime? data_rilascio_porto_armi, string numero_porto_armi, string cap_nascita, string comune_nascita, string provincia_nascita, string indirizzo_residenza, string cap_residenza, string comune_residenza, string provincia_residenza, string sezione, DateTime? data_pagamento, int numero, string tipo, string telefono, string cellulare_whatsapp, string mail)
        {
            this.Uid = uid;
            this.Nome = nome;
            this.Cognome = cognome;
            this.CodiceFiscale = codiceFiscale;
            this.Data_nascita = data_nascita;
            this.Data_rilascio_porto_armi = data_rilascio_porto_armi;
            this.Numero_porto_armi = numero_porto_armi;
            this.Cap_nascita = cap_nascita;
            this.Comune_nascita = comune_nascita;
            this.Provincia_nascita = provincia_nascita;
            this.Indirizzo_residenza = indirizzo_residenza;
            this.Cap_residenza = cap_residenza;
            this.Comune_residenza = comune_residenza;
            this.Provincia_residenza = provincia_residenza;
            this.Sezione = sezione;
            this.Data_pagamento = data_pagamento;
            this.Numero = numero;
            this.Tipo = tipo;
            this.Telefono = telefono;
            this.Cellulare_whatsapp = cellulare_whatsapp;
            this.Mail = mail;
        }
    }
}
