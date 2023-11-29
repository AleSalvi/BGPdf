using dto;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace API.Provider
{
    public class userProvider
    {
        public string ConnectionString = ConfigurationManager.ConnectionStrings["SqlDataContext"].ConnectionString;

        public User User = new User();

        private const string SelectQuery = @"[Api_Users_GetAll]";
        public List<User> GetUsers()
        {
            List<User> users = new List<User>();
            var datatable = new DataTable();

            using (SqlConnection con = new SqlConnection(ConnectionString))
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
                                        , row["CodiceFiscale"].ToString()
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
                                        , Convert.ToDateTime(row["Data_pagamento"].ToString())
                                        , Convert.ToInt16(row["Numero"])
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

                    com.Parameters.Add(new SqlParameter("@Uid", Uid));

                    using (SqlDataAdapter adapter = new SqlDataAdapter(com))
                    {
                        adapter.Fill(datatable);

                        User.SetUser(new Guid(datatable.Rows[0]["Uid"].ToString())
                                    , datatable.Rows[0]["Nome"].ToString()
                                    , datatable.Rows[0]["Cognome"].ToString()
                                    , datatable.Rows[0]["CodiceFiscale"].ToString()
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
                                    , Convert.ToDateTime(datatable.Rows[0]["Data_pagamento"].ToString())
                                    , Convert.ToInt16(datatable.Rows[0]["Numero"])
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

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(EditQuery, con))
                {
                    com.CommandType = CommandType.StoredProcedure;

                    com.Parameters.Add(new SqlParameter("@Uid", User.Uid));
                    com.Parameters.Add(new SqlParameter("@Nome", User.Nome));
                    com.Parameters.Add(new SqlParameter("@Cognome", User.Cognome));
                    com.Parameters.Add(new SqlParameter("@CodiceFiscale", User.CodiceFiscale));
                    com.Parameters.Add(new SqlParameter("@Data_nascita", User.Data_nascita));
                    com.Parameters.Add(new SqlParameter("@Cap_nascita", User.Cap_nascita));  
                    com.Parameters.Add(new SqlParameter("@Comune_nascita", User.Comune_nascita));
                    com.Parameters.Add(new SqlParameter("@Provincia_nascita", User.Provincia_nascita));
                    com.Parameters.Add(new SqlParameter("@Indirizzo_residenza", User.Indirizzo_residenza));
                    com.Parameters.Add(new SqlParameter("@Cap_residenza", User.Cap_residenza));
                    com.Parameters.Add(new SqlParameter("@Comune_residenza", User.Comune_residenza));
                    com.Parameters.Add(new SqlParameter("@Provincia_residenza", User.Provincia_residenza));
                    com.Parameters.Add(new SqlParameter("@Numero_porto_armi", User.Numero_porto_armi));
                    com.Parameters.Add(new SqlParameter("@Data_rilascio_porto_armi", User.Data_rilascio_porto_armi));
                    com.Parameters.Add(new SqlParameter("@Sezione", User.Sezione));
                    com.Parameters.Add(new SqlParameter("@Data_pagamento", User.Data_pagamento));
                    com.Parameters.Add(new SqlParameter("@Numero", User.Numero));
                    com.Parameters.Add(new SqlParameter("@Tipo", User.Tipo));
                    com.Parameters.Add(new SqlParameter("@Telefono", User.Telefono));
                    com.Parameters.Add(new SqlParameter("@Cellulare_whatsapp", User.Cellulare_whatsapp));
                    com.Parameters.Add(new SqlParameter("@Mail", User.Mail));

                    using (SqlDataAdapter adapter = new SqlDataAdapter(com))
                    {
                        adapter.Fill(datatable);

                        User.SetUser(new Guid(datatable.Rows[0]["Uid"].ToString())
                                    , datatable.Rows[0]["Nome"].ToString()
                                    , datatable.Rows[0]["Cognome"].ToString()
                                    , datatable.Rows[0]["CodiceFiscale"].ToString()
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
                                    , Convert.ToDateTime(datatable.Rows[0]["Data_pagamento"].ToString())
                                    , Convert.ToInt16(datatable.Rows[0]["Numero"])
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
                    com.Parameters.Add(new SqlParameter("@Uid", Uid));
                    rows = com.ExecuteNonQuery();
                }
                con.Close();
            }
            return (rows > 0) ? true : false;
        }
    }
}