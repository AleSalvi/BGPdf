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
                    com.Parameters.AddWithValue("@codiceFiscale", User.codiceFiscale);
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
                    com.Parameters.AddWithValue("@codiceFiscale", User.codiceFiscale);
                    com.Parameters.AddWithValue("@data_nascita", User.data_nascita);
                    com.Parameters.AddWithValue("@sezione", User.sezione);
                    com.Parameters.AddWithValue("@data_pag", User.data_pag);
                    com.Parameters.AddWithValue("@tipo", User.tipo);
                    com.Parameters.AddWithValue("@numero", User.numero);
                    com.Parameters.AddWithValue("@indirizzo", User.indirizzo);
                    com.Parameters.AddWithValue("@provincia", User.provincia);
                    com.Parameters.AddWithValue("@comune", User.comune);
                    com.Parameters.AddWithValue("@cap", User.cap);
                    com.Parameters.AddWithValue("@comune_nascita", User.comune_nascita);
                    com.Parameters.AddWithValue("@provincia_nascita", User.provincia_nascita);
                    com.Parameters.AddWithValue("@numero_porto_darmi", User.numero_porto_darmi); rows = com.ExecuteNonQuery();
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
                    com.Parameters.AddWithValue("@TaxCode", User.codiceFiscale);
                    rows = com.ExecuteNonQuery();
                }
                con.Close();
            }
            return (rows > 0) ? true : false;
        }

        public List<User> GetTempUser()
        {
            List<User> users = new List<User>();

            User user1 = new User
            {
                nome = "Nome1",
                cognome = "Cognome1",
                codiceFiscale = "CF1",
                data_nascita = "01/01/1990",
                sezione = "A",
                data_pag = "01/10/2023",
                tipo = "Standard",
                numero = "12345",
                indirizzo = "Via Roma 1",
                provincia = "MI",
                comune = "Milano",
                cap = "20100",
                comune_nascita = "Napoli",
                provincia_nascita = "NA",
                numero_porto_darmi = "ABCDE12345"
            };

            User user2 = new User
            {
                nome = "Nome2",
                cognome = "Cognome2",
                codiceFiscale = "CF2",
                data_nascita = "02/02/1991",
                sezione = "B",
                data_pag = "02/10/2023",
                tipo = "Premium",
                numero = "67890",
                indirizzo = "Via Roma 2",
                provincia = "RM",
                comune = "Roma",
                cap = "00100",
                comune_nascita = "Milano",
                provincia_nascita = "MI",
                numero_porto_darmi = "FGHIJ67890"
            };

            User user3 = new User
            {
                nome = "Nome3",
                cognome = "Cognome3",
                codiceFiscale = "CF3",
                data_nascita = "03/03/1992",
                sezione = "C",
                data_pag = "03/10/2023",
                tipo = "Premium",
                numero = "13579",
                indirizzo = "Via Roma 3",
                provincia = "TO",
                comune = "Torino",
                cap = "10100",
                comune_nascita = "Genova",
                provincia_nascita = "GE",
                numero_porto_darmi = "KLMNO13579"
            };

            User user4 = new User
            {
                nome = "Nome4",
                cognome = "Cognome4",
                codiceFiscale = "CF4",
                data_nascita = "04/04/1993",
                sezione = "D",
                data_pag = "04/10/2023",
                tipo = "Standard",
                numero = "24680",
                indirizzo = "Via Roma 4",
                provincia = "NA",
                comune = "Napoli",
                cap = "80100",
                comune_nascita = "Palermo",
                provincia_nascita = "PA",
                numero_porto_darmi = "PQRST24680"
            };

            User user5 = new User
            {
                nome = "Nome5",
                cognome = "Cognome5",
                codiceFiscale = "CF5",
                data_nascita = "05/05/1994",
                sezione = "E",
                data_pag = "05/10/2023",
                tipo = "Standard",
                numero = "35791",
                indirizzo = "Via Roma 5",
                provincia = "FI",
                comune = "Firenze",
                cap = "50100",
                comune_nascita = "Bologna",
                provincia_nascita = "BO",
                numero_porto_darmi = "UVWXY35791"
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