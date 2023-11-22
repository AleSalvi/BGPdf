using dto;
using System.Data.SqlClient;
using System.Data;

namespace API.Provider
{
    public class userProvider
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
            //return "Data Source=62.149.153.61;Initial Catalog=MSSql212815;Integrated Security=False;User ID=MSSql212815; Password=Cacciator1.;";
            return "Data Source=PC-DAVIIMUSE\\MSSQLSERVER01;Initial Catalog=DB_pdf;Integrated Security=SSPI;";
        }

        private const string SelectQuery = @"[Api_Users_GetAll]";
        public List<User> GetUsers()
        {
            List<User> users = new List<User>();
            var datatable = new DataTable();
            string connectionString = GetConnectionString();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(SelectQuery, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(datatable);

                        foreach (DataRow row in datatable.Rows)
                        {
                            User = new User();
                            User.SetUser(new Guid(row["Uid"].ToString())
                                        , row["Nome"].ToString()
                                        , row["Cognome"].ToString()
                                        , row["Codice_fiscale"].ToString()
                                        , Convert.ToDateTime(row["Data_nascita"].ToString())
                                        , Convert.ToDateTime(row["Data_rilascio_porto_armi"].ToString())
                                        , row["Numero_porto_armi"].ToString()
                                        , row["Cap_nascita"].ToString()
                                        , row["Comune_nascita"].ToString()
                                        , row["Provincia_nascita"].ToString()
                                        , row["Indirizzo_residenza"].ToString()
                                        , row["Cap_residenza"].ToString()
                                        , row["Comune_residenza"].ToString()
                                        , row["Provincia_residenza"].ToString()
                                        , row["Sezione"].ToString()
                                        , row["Provincia"].ToString()
                                        , Convert.ToDateTime(row["Data_pagamento"].ToString())
                                        , row["Numero"].ToString()
                                        , row["Tipo"].ToString()
                                        , row["Telefono"].ToString()
                                        , row["Cellulare_whatsapp"].ToString()
                                        , row["Mail"].ToString()
                                        );
                            users.Add(User);
                        }
                    }
                }
                con.Close();
            }
            return users;
        }

        private const string GetUserByUidQuery = @"[Api_Users_GetByUid]";
        public User GetUserByUid(Guid Uid)
        {
            int rows;
            var datatable = new DataTable();
            User = new User();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(GetUserByUidQuery, con))
                {
                    com.CommandType = CommandType.StoredProcedure;

                    com.Parameters.AddWithValue("@Uid", Uid);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(com))
                    {
                        adapter.Fill(datatable);

                        User.SetUser(new Guid(datatable.Rows[0]["Uid"].ToString())
                                    , datatable.Rows[0]["Nome"].ToString()
                                    , datatable.Rows[0]["Cognome"].ToString()
                                    , datatable.Rows[0]["Codice_fiscale"].ToString()
                                    , Convert.ToDateTime(datatable.Rows[0]["Data_nascita"].ToString())
                                    , Convert.ToDateTime(datatable.Rows[0]["Data_rilascio_porto_armi"].ToString())
                                    , datatable.Rows[0]["Numero_porto_armi"].ToString()
                                    , datatable.Rows[0]["Cap_nascita"].ToString()
                                    , datatable.Rows[0]["Comune_nascita"].ToString()
                                    , datatable.Rows[0]["Provincia_nascita"].ToString()
                                    , datatable.Rows[0]["Indirizzo_residenza"].ToString()
                                    , datatable.Rows[0]["Cap_residenza"].ToString()
                                    , datatable.Rows[0]["Comune_residenza"].ToString()
                                    , datatable.Rows[0]["Provincia_residenza"].ToString()
                                    , datatable.Rows[0]["Sezione"].ToString()
                                    , datatable.Rows[0]["Provincia"].ToString()
                                    , Convert.ToDateTime(datatable.Rows[0]["Data_pagamento"].ToString())
                                    , datatable.Rows[0]["Numero"].ToString()
                                    , datatable.Rows[0]["Tipo"].ToString()
                                    , datatable.Rows[0]["Telefono"].ToString()
                                    , datatable.Rows[0]["Cellulare_whatsapp"].ToString()
                                    , datatable.Rows[0]["Mail"].ToString()
                                    );
                    }
                }
                con.Close();
            }
            return User;
        }

        private const string EditQuery = @"[Api_Users_Edit]";
        public User EditUser(User User)
        {
            int rows;
            var datatable = new DataTable();
            User = new User();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(EditQuery, con))
                {
                    com.CommandType = CommandType.StoredProcedure;

                    com.Parameters.AddWithValue("@Uid", User.Uid);
                    com.Parameters.AddWithValue("@Nome", User.Nome);
                    com.Parameters.AddWithValue("@Cognome", User.Cognome);
                    com.Parameters.AddWithValue("@Codice_fiscale", User.Codice_fiscale);
                    com.Parameters.AddWithValue("@Data_nascita", User.Data_nascita);
                    com.Parameters.AddWithValue("@Cap_nascita", User.Cap_nascita);
                    com.Parameters.AddWithValue("@Comune_nascita", User.Comune_nascita);
                    com.Parameters.AddWithValue("@Provincia_nascita", User.Provincia_nascita);
                    com.Parameters.AddWithValue("@Indirizzo_residenza", User.Indirizzo_residenza);
                    com.Parameters.AddWithValue("@Cap_residenza", User.Cap_residenza);
                    com.Parameters.AddWithValue("@Comune_residenza", User.Comune_residenza);
                    com.Parameters.AddWithValue("@Provincia_residenza", User.Provincia_residenza);
                    com.Parameters.AddWithValue("@Numero_porto_armi", User.Numero_porto_armi);
                    com.Parameters.AddWithValue("@Data_rilascio_porto_armi", User.Data_rilascio_porto_armi);
                    com.Parameters.AddWithValue("@Sezione", User.Sezione);
                    com.Parameters.AddWithValue("@Data_pagamento", User.Data_pagamento);
                    com.Parameters.AddWithValue("@Numero", User.Numero);
                    com.Parameters.AddWithValue("@Tipo", User.Tipo);
                    com.Parameters.AddWithValue("@Cellulare_whatsapp", User.Cellulare_whatsapp);
                    com.Parameters.AddWithValue("@Mail", User.Mail);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(com))
                    {
                        adapter.Fill(datatable);

                        User.SetUser(new Guid(datatable.Rows[0]["Uid"].ToString())
                                    , datatable.Rows[0]["Nome"].ToString()
                                    , datatable.Rows[0]["Cognome"].ToString()
                                    , datatable.Rows[0]["Codice_fiscale"].ToString()
                                    , Convert.ToDateTime(datatable.Rows[0]["Data_nascita"].ToString())
                                    , Convert.ToDateTime(datatable.Rows[0]["Data_rilascio_porto_armi"].ToString())
                                    , datatable.Rows[0]["Numero_porto_armi"].ToString()
                                    , datatable.Rows[0]["Cap_nascita"].ToString()
                                    , datatable.Rows[0]["Comune_nascita"].ToString()
                                    , datatable.Rows[0]["Provincia_nascita"].ToString()
                                    , datatable.Rows[0]["Indirizzo_residenza"].ToString()
                                    , datatable.Rows[0]["Cap_residenza"].ToString()
                                    , datatable.Rows[0]["Comune_residenza"].ToString()
                                    , datatable.Rows[0]["Provincia_residenza"].ToString()
                                    , datatable.Rows[0]["Sezione"].ToString()
                                    , datatable.Rows[0]["Provincia"].ToString()
                                    , Convert.ToDateTime(datatable.Rows[0]["Data_pagamento"].ToString())
                                    , datatable.Rows[0]["Numero"].ToString()
                                    , datatable.Rows[0]["Tipo"].ToString()
                                    , datatable.Rows[0]["Telefono"].ToString()
                                    , datatable.Rows[0]["Cellulare_whatsapp"].ToString()
                                    , datatable.Rows[0]["Mail"].ToString()
                                    );
                    }
                }
                con.Close();
            }
            return User;
        }

        private const string DeleteQuery = @"[Api_Users_Delete]";
        public bool DeleteUser(Guid Uid)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(DeleteQuery, con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@Uid", Uid);
                    rows = com.ExecuteNonQuery();
                }
                con.Close();
            }
            return (rows > 0) ? true : false;
        }
    }
}