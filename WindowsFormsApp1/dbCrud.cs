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

        private const string GetUserByTaxCodeQuery = "SELECT * FROM Users WHERE TaxCode = @TaxCOde";
        public bool GetUserByTaxCode(User User)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(GetUserByTaxCodeQuery, con))
                {
                    com.Parameters.AddWithValue("@TaxCode", User.TaxCode);
                    rows = com.ExecuteNonQuery();
                }
                con.Close();
            }
            return (rows > 0) ? true : false;
        }

        private const string InsertQuery = "IF (SELECT COUNT (*) FROM Users WHERE TaxCode = @TaxCode) > 1 " +
                                                "BEGIN " +
                                                    "RAISERROR('Utente già registrato!', 16, 1) " +
                                                "END " +
                                            "ELSE" +
                                                "BEGIN " +
                                                    "INSERT INTO USERS(Name, Surname, TaxCode, Email, Phone, Address) VALUES (@Name, @Surname, @TaxCode, @Email, @Phone, @Address)" +
                                                "END ";
        public bool InsertUser(User User)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(InsertQuery, con))
                {
                    com.Parameters.AddWithValue("@Name", User.Name);
                    com.Parameters.AddWithValue("@Surname", User.Surname);
                    com.Parameters.AddWithValue("@TaxCode", User.TaxCode);
                    com.Parameters.AddWithValue("@Email", User.Email);
                    com.Parameters.AddWithValue("@Phone", User.Phone);
                    com.Parameters.AddWithValue("@Address", User.Address);
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
                    com.Parameters.AddWithValue("@TaxCode", User.TaxCode);
                    rows = com.ExecuteNonQuery();
                }
                con.Close();
            }
            return (rows > 0) ? true : false;
        }

        public List<User> GetTempUser()
        {
            List<User> users = new List<User>();

            User user1 = new User();
            user1.Phone = "3227078322";
            user1.TaxCode = "MSTDDL03T19H910L";
            user1.Name = "Davide";
            user1.Surname = "Musitelli";
            users.Add(user1);

            User user2 = new User();
            user2.Phone = "33945687991";
            user2.TaxCode = "CMPVNT90S14G856M";
            user2.Name = "Valentino";
            user2.Surname = "Campana";
            users.Add(user2);

            User user3 = new User();
            user3.Phone = "3277078951";
            user3.TaxCode = "RSSLC94D13F890M";
            user3.Name = "Luca";
            user3.Surname = "Rossi";
            users.Add(user3);

            User user4 = new User();
            user4.Phone = "3897448772";
            user4.TaxCode = "GSPGD98D82h271O";
            user4.Name = "Giandomenico";
            user4.Surname = "Gaspare";
            users.Add(user4);

            return users;
        }
    }
}