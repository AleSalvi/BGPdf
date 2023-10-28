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
        public string codiceFiscale { get; set; }
        public string data_nascita { get; set; }
        public string sezione { get; set; }
        public string data_pag { get; set; }
        public string tipo { get; set; }
        public string numero { get; set; }
        public string indirizzo { get; set; }
        public string provincia { get; set; }
        public string comune { get; set; }
        public string cap { get; set; }
        public string comune_nascita { get; set; }
        public string provincia_nascita { get; set; }
        public string numero_porto_darmi { get; set; }

        public void SetUser(string nome, string cognome, string codiceFiscale, string data_nascita, string sezione, string data_pag, string tipo, string numero, string indirizzo, string provincia, string comune, string cap, string comune_nascita, string provincia_nascita, string numero_porto_darmi)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.codiceFiscale = codiceFiscale;
            this.data_nascita = data_nascita;
            this.sezione = sezione;
            this.data_pag = data_pag;
            this.tipo = tipo;
            this.numero = numero;
            this.indirizzo = indirizzo;
            this.provincia = provincia;
            this.comune = comune;
            this.cap = cap;
            this.comune_nascita = comune_nascita;
            this.provincia_nascita = provincia_nascita;
            this.numero_porto_darmi = numero_porto_darmi;
        }
    }
}
