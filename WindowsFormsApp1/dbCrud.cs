using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Net.Sockets;
using System.Runtime.Remoting.Contexts;

namespace WindowsFormsApp1
{
    internal class DbCrud
    {
        public string ConnectionString { get; set; }

        public User User = new User();

        public void OpenSqlConnection()
        {
            try
            {
                string connectionString = GetConnectionString();

                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = connectionString;

                    connection.Open();

                    Console.WriteLine("State: {0}", connection.State);
                    Console.WriteLine("ConnectionString: {0}", connection.ConnectionString);
                }
            }
            catch
            {
            }
        }

        private string GetConnectionString()
        {
            return "Data Source=62.149.153.61;Initial Catalog=MSSql212815;Integrated Security=False;User ID=MSSql212815; Password=Cacciator1.;";
        }

        private const string SelectQuery = "SELECT * FROM Users";
        public DataTable GetUsers()
        {
            var datatable = new DataTable();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(SelectQuery, con))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(com))
                    {
                        adapter.Fill(datatable);
                    }
                }
                con.Close();
            }
            return datatable;
        }

        private const string GetUserByTaxCodeQuery = "SELECT * FROM Users WHERE codiceFiscale = @codiceFiscale";
        public bool GetUserByTaxCode(User User)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(GetUserByTaxCodeQuery, con))
                {
                    com.Parameters.AddWithValue("@codiceFiscale", User.codice_fiscale);
                    rows = com.ExecuteNonQuery();
                }
                con.Close();
            }
            return (rows > 0) ? true : false;
        }

        private const string InsertQuery = "IF (SELECT COUNT (*) FROM Users WHERE TaxCode = @codiceFiscale) > 1 " +
                                                "BEGIN " +
                                                    "RAISERROR('Utente già registrato!', 16, 1) " +
                                                "END " +
                                            "ELSE" +
                                                "BEGIN " +
                                                    "INSERT INTO USERS(nome, cognome, codiceFiscale, data_nascita, sezione, data_pag, tipo, numero, indirizzo, provincia, comune, cap, comune_nascita, provincia_nascita, numero_porto_darmi) VALUES (@nome, @cognome, @codiceFiscale, @data_nascita, @sezione, @data_pag, @tipo, @numero, @indirizzo, @provincia, @comune, @cap, @comune_nascita, @provincia_nascita, @numero_porto_darmi)" +
                                                "END ";
        public bool InsertUser(User User)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(InsertQuery, con))
                {
                    com.Parameters.AddWithValue("@nome", User.nome);
                    com.Parameters.AddWithValue("@cognome", User.cognome);
                    com.Parameters.AddWithValue("@codice_fiscale", User.codice_fiscale);
                    com.Parameters.AddWithValue("@data_nascita", User.data_nascita);
                    com.Parameters.AddWithValue("@data_rilascio_porto_armi", User.data_rilascio_porto_armi);
                    com.Parameters.AddWithValue("@numero_porto_armi", User.numero_porto_armi);
                    com.Parameters.AddWithValue("@cap_nascita", User.cap_nascita);
                    com.Parameters.AddWithValue("@comune_nascita", User.comune_nascita);
                    com.Parameters.AddWithValue("@provincia_nascita", User.provincia_nascita);
                    com.Parameters.AddWithValue("@indirizzo_residenza", User.indirizzo_residenza);
                    com.Parameters.AddWithValue("@cap_residenza", User.cap_residenza);
                    com.Parameters.AddWithValue("@comune_residenza", User.comune_residenza);
                    com.Parameters.AddWithValue("@provincia_residenza", User.provincia_residenza);
                    com.Parameters.AddWithValue("@sezione", User.sezione);
                    com.Parameters.AddWithValue("@provincia", User.provincia);
                    com.Parameters.AddWithValue("@data_pagamento", User.data_pagamento);
                    com.Parameters.AddWithValue("@numero", User.numero);
                    com.Parameters.AddWithValue("@tipo", User.tipo);
                    rows = com.ExecuteNonQuery();
                }
                con.Close();
            }
            return (rows > 0) ? true : false;
        }

        private const string DeleteQuery = "DELETE FROM Users WHERE TaxCode=@TaxCode";
        public bool DeleteUser(User User)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(DeleteQuery, con))
                {
                    com.Parameters.AddWithValue("@TaxCode", User.codice_fiscale);
                    rows = com.ExecuteNonQuery();
                }
                con.Close();
            }
            return (rows > 0) ? true : false;
        }

        public List<User> GetTempUser()
        {
            List<User> users = new List<User>();

            // Instance 1
            User user1 = new User
            {
                nome = "Nome1",
                cognome = "Cognome1",
                codice_fiscale = "CF1",
                data_nascita = "01/01/1990",
                data_rilascio_porto_armi = "01/05/2022",
                numero_porto_armi = "ABCDE12345",
                cap_nascita = "80100",
                comune_nascita = "Napoli",
                provincia_nascita = "NA",
                indirizzo_residenza = "Via Milano 2",
                cap_residenza = "20100",
                comune_residenza = "Milano",
                provincia_residenza = "MI",
                sezione = "A",
                provincia = "MI",
                data_pagamento = "01/10/2023",
                numero = "12345",
                tipo = "Standard"
            };

            // Instance 2
            User user2 = new User
            {
                nome = "Nome2",
                cognome = "Cognome2",
                codice_fiscale = "CF2",
                data_nascita = "15/06/1985",
                data_rilascio_porto_armi = "10/03/2021",
                numero_porto_armi = "FGHIJ67890",
                cap_nascita = "70100",
                comune_nascita = "Bari",
                provincia_nascita = "BA",
                indirizzo_residenza = "Via Torino 3",
                cap_residenza = "10100",
                comune_residenza = "Torino",
                provincia_residenza = "TO",
                sezione = "B",
                provincia = "TO",
                data_pagamento = "05/10/2023",
                numero = "67890",
                tipo = "Premium"
            };

            // Instance 3
            User user3 = new User
            {
                nome = "Nome3",
                cognome = "Cognome3",
                codice_fiscale = "CF3",
                data_nascita = "20/12/1982",
                data_rilascio_porto_armi = "03/08/2019",
                numero_porto_armi = "WXYZ98765",
                cap_nascita = "90100",
                comune_nascita = "Palermo",
                provincia_nascita = "PA",
                indirizzo_residenza = "Viale Firenze 4",
                cap_residenza = "50100",
                comune_residenza = "Firenze",
                provincia_residenza = "FI",
                sezione = "C",
                provincia = "FI",
                data_pagamento = "15/10/2023",
                numero = "54321",
                tipo = "Basic"
            };

            // Instance 4
            User user4 = new User
            {
                nome = "Nome4",
                cognome = "Cognome4",
                codice_fiscale = "CF4",
                data_nascita = "05/04/1995",
                data_rilascio_porto_armi = "20/11/2020",
                numero_porto_armi = "LMNOP54321",
                cap_nascita = "60100",
                comune_nascita = "Ancona",
                provincia_nascita = "AN",
                indirizzo_residenza = "Via Venezia 5",
                cap_residenza = "30100",
                comune_residenza = "Venezia",
                provincia_residenza = "VE",
                sezione = "D",
                provincia = "VE",
                data_pagamento = "20/10/2023",
                numero = "98765",
                tipo = "Premium"
            };

            // Instance 5
            User user5 = new User
            {
                nome = "Nome5",
                cognome = "Cognome5",
                codice_fiscale = "CF5",
                data_nascita = "12/09/1988",
                data_rilascio_porto_armi = "08/06/2017",
                numero_porto_armi = "QRSTU54321",
                cap_nascita = "50120",
                comune_nascita = "Livorno",
                provincia_nascita = "LI",
                indirizzo_residenza = "Via Napoli 6",
                cap_residenza = "40100",
                comune_residenza = "Bologna",
                provincia_residenza = "BO",
                sezione = "E",
                provincia = "BO",
                data_pagamento = "25/10/2023",
                numero = "13579",
                tipo = "Standard"
            };


            users.Add(user1);
            users.Add(user2);
            users.Add(user3);
            users.Add(user4);
            users.Add(user5);


            return users;
        }
    }
}