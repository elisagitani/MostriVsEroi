using MostriVsEroi.Modelli;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace MostriVsEroi.DbManager
{
    public class DbManagerArmi : IArmaRepository
    {
        const string connectionString = @"Data Source= (localdb)\mssqllocaldb;" +
                                            "Initial Catalog = MostriVsEroi;" +
                                            "Integrated Security=true;";
        public List<Arma> FetchArmiEroi(string categoria)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "select NomeArma, PuntiDanno from dbo.ArmiConCategorieEroiEMostri where Categoria=@Categoria";
                command.Parameters.AddWithValue("@Categoria", categoria);
                SqlDataReader reader = command.ExecuteReader();
                List<Arma> armi = new List<Arma>();
                while (reader.Read())
                {
                    var nome = (string)reader["NomeArma"];
                    var puntiDanno = (int)reader["PuntiDanno"];


                    Arma a = new Arma(nome, puntiDanno);
                    armi.Add(a);

                }
                return armi;
                connection.Close();
            }
        }
    }
}
