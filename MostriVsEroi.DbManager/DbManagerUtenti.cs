using MostriVsEroi.Modelli;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MostriVsEroi.DbManager
{
    public class DbManagerUtenti : IUtenteRepository
    {
        const string connectionString = @"Data Source= (localdb)\mssqllocaldb;" +
                                             "Initial Catalog = MostriVsEroi;" +
                                             "Integrated Security=true;";
        public List<Utente> FetchUtenti()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "select * from dbo.Utenti";
                SqlDataReader reader = command.ExecuteReader();
                List<Utente> utenti = new List<Utente>();
                while (reader.Read())
                {
                    var username = (string)reader["Username"];
                    var password = (string)reader["Password"];
                    var isAdmin = (bool)reader["IsAdmin"];

                    Utente u = new Utente(username, password);
                    utenti.Add(u);

                }
                return utenti;
                connection.Close();
            }
        }

        public Utente GetUser(Utente utente)
        {
            using(SqlConnection connection=new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "select *from dbo.Utenti where Username=@Username and Password=@Password";
                command.Parameters.AddWithValue("@Username", utente.Username);
                command.Parameters.AddWithValue("@Password", utente.Password);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    utente.IsAuthenticated = true;
                }
                else
                {
                    utente.IsAuthenticated = false;
                }

                return utente;
                connection.Close();
            }
        }

        public void AddUtente(Utente utente)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "insert into dbo.Utenti values (@Username, @Password, @IsAdmin)";
                command.Parameters.AddWithValue("@Username", utente.Username);
                command.Parameters.AddWithValue("@Password", utente.Password);
                command.Parameters.AddWithValue("@IsAdmin", false);
                command.ExecuteNonQuery();

                connection.Close();

               
            }
        }
    }
}
