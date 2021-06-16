using MostriVsEroi.Modelli;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace MostriVsEroi.DbManager
{
    public class DbManagerEroi : IEroeRepository
    {
        const string connectionString = @"Data Source= (localdb)\mssqllocaldb;" +
                                            "Initial Catalog = MostriVsEroi;" +
                                            "Integrated Security=true;";

        public void AddEroi(Utente u, Eroe e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "insert into dbo.";
               
                command.ExecuteNonQuery();

                connection.Close();

            }
        }
            public List<Eroe> FetchEroi()
        {
            throw new NotImplementedException();
        }

        public bool RemoveEroe(Eroe e)
        {
            throw new NotImplementedException();
        }
    }
}
