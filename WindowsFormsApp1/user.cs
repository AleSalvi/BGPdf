using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace WindowsFormsApp1
{
    internal class User
    {
        public string nome { get; set; }
        public string cognome { get; set; }
        public string codice_fiscale { get; set; }
        public string data_nascita { get; set; }
        public string data_rilascio_porto_armi { get; set; }
        public string numero_porto_armi { get; set; }
        public string cap_nascita { get; set; }
        public string comune_nascita { get; set; }
        public string provincia_nascita { get; set; }
        public string indirizzo_residenza { get; set; }
        public string cap_residenza { get; set; }
        public string comune_residenza { get; set; }
        public string provincia_residenza { get; set; }
        public string sezione { get; set; }
        public string provincia { get; set; }
        public string data_pagamento { get; set; }
        public string numero { get; set; }
        public string tipo { get; set; }

        public void SetUser(string nome, string cognome, string codice_fiscale, string data_nascita, string data_rilascio_porto_armi, string numero_porto_armi, string cap_nascita, string comune_nascita, string provincia_nascita, string indirizzo_residenza, string cap_residenza, string comune_residenza, string provincia_residenza, string sezione, string provincia, string data_pagamento, string numero, string tipo)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.codice_fiscale = codice_fiscale;
            this.data_nascita = data_nascita;
            this.data_rilascio_porto_armi = data_rilascio_porto_armi;
            this.numero_porto_armi = numero_porto_armi;
            this.cap_nascita = cap_nascita;
            this.comune_nascita = comune_nascita;
            this.provincia_nascita = provincia_nascita;
            this.indirizzo_residenza = indirizzo_residenza;
            this.cap_residenza = cap_residenza;
            this.comune_residenza = comune_residenza;
            this.provincia_residenza = provincia_residenza;
            this.sezione = sezione;
            this.provincia = provincia;
            this.data_pagamento = data_pagamento;
            this.numero = numero;
            this.tipo = tipo;
        }
    }
}
