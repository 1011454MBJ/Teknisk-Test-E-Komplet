using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TT_DataAccess.Repository
{
    public class ForemanRepository
    {
        public ForemanRepository() 
        {
            Initialize();
        }
        private void Initialize()
        {
            // Opret forbindelse til SQL Server
            string connectionString = "Server=.\\SQLExpress;Database=FitterTest;IntegratedSecurity=true;";
            SqlConnection connection = new SqlConnection(connectionString);
            // Åbn forbindelse til databasen
            connection.Open();

            // Udfør SQL-kommando
            string sql = "SELECT TOP 1 FROM Fiters";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();

            //// Læs data fra databasen
            //while (reader.Read())
            //{
            //    return reader["FirstName"].ToString();
            //}

            // Luk forbindelsen til databasen
            reader.Close();
            connection.Close();
        }
    }
}
